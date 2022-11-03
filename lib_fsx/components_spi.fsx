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
and Mut2() = class end
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
and Mut3 = {mutable l0 : US3; mutable l1 : US3; mutable l2 : US3; mutable l3 : US5; mutable l4 : US3; mutable l5 : US3; mutable l6 : US3; mutable l7 : US3; mutable l8 : US3; mutable l9 : US3; mutable l10 : US6; mutable l11 : US7; mutable l12 : US3; mutable l13 : US3; mutable l14 : US6; mutable l15 : US8; mutable l16 : US3; mutable l17 : US3; mutable l18 : US3; mutable l19 : US9; mutable l20 : US6; mutable l21 : US3; mutable l22 : US3; mutable l23 : US3; mutable l24 : US3; mutable l25 : US3; mutable l26 : US10; mutable l27 : US3; mutable l28 : US3; mutable l29 : US3; mutable l30 : US10; mutable l31 : US3; mutable l32 : US3; mutable l33 : US3; mutable l34 : US3; mutable l35 : US3; mutable l36 : US3; mutable l37 : US3; mutable l38 : US3; mutable l39 : US11; mutable l40 : US12; mutable l41 : US11; mutable l42 : US3; mutable l43 : US3; mutable l44 : US3; mutable l45 : US3; mutable l46 : US3; mutable l47 : US3; mutable l48 : US3; mutable l49 : US3; mutable l50 : US3; mutable l51 : US3; mutable l52 : US3; mutable l53 : US3; mutable l54 : US3; mutable l55 : US3; mutable l56 : US3; mutable l57 : US3; mutable l58 : US10; mutable l59 : US3; mutable l60 : US3; mutable l61 : US8; mutable l62 : US3; mutable l63 : US2; mutable l64 : US3}
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and Mut4 = {mutable l0 : (unit -> bool); mutable l1 : (bool -> unit); mutable l2 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3))}
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit))
and [<Struct>] US14 =
    | US14_0
    | US14_1
    | US14_2
and Mut5 = {mutable l0 : US13; mutable l1 : US13; mutable l2 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)); mutable l3 : US14}
and Mut6 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US13; mutable l3 : US13; mutable l4 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3))}
and Mut7 = {mutable l0 : int32}
and Mut8 = {mutable l0 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)); mutable l1 : (unit -> JS.Function); mutable l2 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3))}
and Mut9 = {mutable l0 : (Mut1 -> US3); mutable l1 : (Mut1 -> (Mut1 -> (US3 -> unit)))}
and Mut10 = {mutable l0 : (Mut1 -> US2); mutable l1 : (Mut1 -> (Mut1 -> (US2 -> unit)))}
and Mut11 = {mutable l0 : int32; mutable l1 : int32}
and Mut12 = {mutable l0 : US4}
and Mut13 = {mutable l0 : US4; mutable l1 : (struct (US4 * int32 * string * string) -> US3); mutable l2 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string)))}
and Mut14 = {mutable l0 : int32; mutable l1 : US3}
and Mut15 = {mutable l0 : US4; mutable l1 : (struct (US4 * int32 * string * string) -> US2); mutable l2 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string)))}
and Mut16 = {mutable l0 : int32; mutable l1 : US2}
and UH1 =
    | UH1_0 of int32 * int32 * UH1
    | UH1_1
and Mut17 = {mutable l0 : int32; mutable l1 : UH1}
and UH2 =
    | UH2_0 of int32 * obj * UH2
    | UH2_1
and Mut18 = {mutable l0 : int32; mutable l1 : UH2}
let rec method1 () : struct (string * obj * string * string * bool) =
    let v0 : obj = emitJsExpr () "components_spi.env"
    let v1 : string = emitJsExpr v0 "$0.CODESPACE_NAME || \"\""
    let v2 : string = emitJsExpr v0 "$0.GITHUB_RUN_ID || \"\""
    let v3 : string = emitJsExpr v0 "$0.GITHUB_SHA || \"\""
    let v4 : obj = v0?IS_TEST
    let v5 : bool = emitJsExpr v4 "!$0"
    let v6 : bool = v5 = false
    struct (v1, v0, v2, v3, v6)
and method2 () : string =
    let v0 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    v0
and method3 () : string =
    let v0 : string = "http://localhost"
    v0
and method4 () : int32 =
    4001
and method5 () : (struct (US0 * string * string * string) []) =
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
and method0 () : struct ((struct (US0 * string * string * string) []) * US2 * US3 * US3 * (struct (US4 * int32 * string * string) []) * (struct (US4 * US4) []) * (struct (int32 * obj) []) * (struct (int32 * obj) []) * (struct (int32 * int32) []) * US2) =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method1()
    let v5 : string = method2()
    let v6 : bool = "" = v0
    let v9 : string =
        if v6 then
            method3()
        else
            let v8 : string = $"http://{v0}-4001.githubpreview.dev"
            v8
    let v11 : int32 =
        if v6 then
            method4()
        else
            80
    let v12 : (struct (US0 * string * string * string) []) = method5()
    let v13 : (struct (US4 * US4) []) = [||]
    let v19 : string =
        if v6 then
            let v14 : string = "ws://localhost"
            v14
        else
            let v15 : bool = true = v4
            if v15 then
                let v16 : string = "ws://localhost"
                v16
            else
                let v17 : string = $"ws://{v0}-4944.githubpreview.dev"
                v17
    let v24 : int32 =
        if v6 then
            let v20 : bool = true = v4
            if v20 then
                14944
            else
                let v21 : bool = false = v4
                if v21 then
                    4944
                else
                    80
        else
            80
    let v25 : US4 = US4_1
    let v26 : string = "ws"
    let v32 : string =
        if v6 then
            let v27 : string = "wss://localhost"
            v27
        else
            let v28 : bool = true = v4
            if v28 then
                let v29 : string = "wss://localhost"
                v29
            else
                let v30 : string = $"ws://{v0}-8765.githubpreview.dev"
                v30
    let v37 : int32 =
        if v6 then
            let v33 : bool = true = v4
            if v33 then
                18765
            else
                let v34 : bool = false = v4
                if v34 then
                    8765
                else
                    80
        else
            80
    let v38 : US4 = US4_0
    let v39 : string = "gun"
    let v40 : (struct (US4 * int32 * string * string) []) = [|struct (v25, v24, v19, v26); struct (v38, v37, v32, v39)|]
    let v41 : (struct (int32 * int32) []) = [||]
    let v42 : (struct (int32 * obj) []) = [||]
    let v43 : (struct (int32 * obj) []) = [||]
    let v44 : US2 = US2_1(v11)
    let v45 : US3 = US3_1(v5)
    let v46 : US3 = US3_1(v9)
    let v47 : US2 = US2_0
    struct (v12, v44, v45, v46, v40, v13, v43, v42, v41, v47)
and closure0 (v0 : obj) (v1 : obj) : unit =
    let v2 : JS.Function = v1?on |> unbox<JS.Function>
    v2.Invoke ("@init", fun () -> v0) |> ignore
    v2.Invoke ("set", emitJsExpr () "(_: any, state: any) => state") |> ignore
    ()
and method6 (v0 : obj) : obj =
    let v1 : string = "createStoreon"
    let v2 : string = "storeon"
    let v3 : JS.Function = import v1 v2
    let v4 : (obj -> unit) = closure0(v0)
    let v5 : obj = v3.Invoke [| v4 |]
    v5
and closure2 () () : (obj []) =
    [||]
and method9 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method9(v0, v4)
    else
        v1
and closure3 (v0 : (unit -> (obj [])), v1 : string, v2 : string, v3 : obj, v4 : string, v5 : string, v6 : bool, v7 : int64) (v8 : (obj [])) : unit =
    let v9 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v10 : int64 = v9 - v7
    let v11 : string = v10.ToString ()
    let v12 : int32 = 6
    let v13 : string = method9(v12, v11)
    let v14 : int32 = emitJsExpr () "components_spi.run_id"
    let v15 : string = $"[{v13}] {v14}"
    let v16 : string = JS.JSON.stringify v8
    let v17 : (obj []) = v0 ()
    let v18 : string = JS.JSON.stringify v17
    let struct (v23 : string, v24 : string, v25 : string, v26 : string, v27 : string) =
        if v6 then
            let v19 : string = ""
            struct (v15, v16, v18, v19, v19)
        else
            let v20 : string = $"{v15} %%c%%s %%c%%s"
            let v21 : string = $"font-weight: bold; color: {v1}"
            let v22 : string = "font-weight: bold; color: #444"
            struct (v20, v21, v16, v22, v18)
    emitJsExpr () $"console.log.apply(console, {struct (v23, v24, v25, v26, v27)})"
    ()
and method8 (v0 : (unit -> (obj [])), v1 : string) : ((obj []) -> unit) =
    let struct (v2 : string, v3 : obj, v4 : string, v5 : string, v6 : bool) = method1()
    let v7 : int64 = DateTime.UtcNow.Ticks / 1000L
    closure3(v0, v1, v2, v3, v4, v5, v6, v7)
and closure4 (v0 : ((obj []) -> unit)) struct (v1 : Mut1, v2 : Mut1, v3 : obj) : unit =
    let v4 : string = ">> db_listener store.on(@changed)"
    let v5 : obj = v4
    let v6 : string = "b_changed:"
    let v7 : obj = struct (v6, v2)
    let v8 : (obj []) = [|v5; v7|]
    v0 v8
    let struct (v9 : (struct (US4 * int32 * string * string) []), v10 : (struct (US4 * US4) [])) = v2.l4, v2.l5
    let v11 : bool = emitJsExpr v10 "!$0"
    let v12 : bool = v11 = false
    let v17 : bool =
        if v12 then
            true
        else
            let struct (v13 : (struct (US4 * int32 * string * string) []), v14 : (struct (US4 * US4) [])) = v2.l4, v2.l5
            let v15 : bool = emitJsExpr v13 "!$0"
            let v16 : bool = v15 = false
            v16
    ()
and method7 (v0 : obj) : JSX.Element =
    let v1 : (unit -> (obj [])) = closure2()
    let v2 : string = "#cf1100"
    let v3 : ((obj []) -> unit) = method8(v1, v2)
    let v4 : string = "> db_listener ()"
    let v5 : obj = v4
    let v6 : (obj []) = [|v5|]
    v3 v6
    let v7 : JS.Function = v0?on |> unbox<JS.Function>
    let v8 : (struct (Mut1 * Mut1 * obj) -> unit) = closure4(v3)
    let v9 : JS.Function = emitJsExpr v8 "(...args: any[]) => $0(args)"
    let v10 : (unit -> unit) = v7.Invoke ("@changed", v9) |> unbox<unit -> unit>
    let v11 : string = "onCleanup"
    let v12 : string = "solid-js"
    let v13 : JS.Function = import v11 v12
    v13.Invoke v10 |> ignore
    let v14 : JSX.Element = Html.fragment []
    v14
and closure1 (v0 : obj) (v1 : Mut2) : JSX.Element =
    method7(v0)
and method11 () : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v0 : US3 = US3_0
    let v1 : US3 = US3_0
    let v2 : US3 = US3_0
    let v3 : US5 = US5_0
    let v4 : US3 = US3_0
    let v5 : US3 = US3_0
    let v6 : US3 = US3_0
    let v7 : US3 = US3_0
    let v8 : US3 = US3_0
    let v9 : US3 = US3_0
    let v10 : US6 = US6_0
    let v11 : US7 = US7_0
    let v12 : US3 = US3_0
    let v13 : US3 = US3_0
    let v14 : US6 = US6_0
    let v15 : US8 = US8_0
    let v16 : US3 = US3_0
    let v17 : US3 = US3_0
    let v18 : US3 = US3_0
    let v19 : US9 = US9_0
    let v20 : US6 = US6_0
    let v21 : US3 = US3_0
    let v22 : US3 = US3_0
    let v23 : US3 = US3_0
    let v24 : US3 = US3_0
    let v25 : US3 = US3_0
    let v26 : US10 = US10_0
    let v27 : US3 = US3_0
    let v28 : US3 = US3_0
    let v29 : US3 = US3_0
    let v30 : US10 = US10_0
    let v31 : US3 = US3_0
    let v32 : US3 = US3_0
    let v33 : US3 = US3_0
    let v34 : US3 = US3_0
    let v35 : US3 = US3_0
    let v36 : US3 = US3_0
    let v37 : US3 = US3_0
    let v38 : US3 = US3_0
    let v39 : US11 = US11_0
    let v40 : US12 = US12_0
    let v41 : US11 = US11_0
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
    let v56 : US3 = US3_0
    let v57 : US3 = US3_0
    let v58 : US10 = US10_0
    let v59 : US3 = US3_0
    let v60 : US3 = US3_0
    let v61 : US8 = US8_0
    let v62 : US3 = US3_0
    let v63 : US2 = US2_0
    let v64 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure10 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = emitJsExpr v0 "JSON.stringify($0, null, 2)"
    let v2 : JSX.Element = Html.fragment [ v1 |> unbox<JSX.Element> ]
    [|v2|]
and method15 (v0 : UH0, v1 : int32) : int32 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method15(v3, v4)
    | UH0_1 -> (* Nil *)
        v1
and method16 (v0 : ((string * obj) []), v1 : UH0, v2 : int32) : int32 =
    match v1 with
    | UH0_0(v3, v4) -> (* Cons *)
        v0.[int v2] <- v3
        let v5 : int32 = v2 + 1
        method16(v0, v4, v5)
    | UH0_1 -> (* Nil *)
        v2
and method14 (v0 : UH0) : ((string * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method15(v0, v1)
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method16(v3, v0, v4)
    v3
and method13 (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : ((string * obj) []) =
    let v68 : obj =
        match v0 with
        | US3_0 -> (* None *)
            let v65 : obj = ()
            v65
        | US3_1(v66) -> (* Some *)
            let v67 : obj = v66
            v67
    let v69 : bool = emitJsExpr v68 "!$0"
    let v75 : UH0 =
        if v69 then
            UH0_1
        else
            let v71 : string = "alignItems"
            let v72 : (string * obj) = v71, v68
            let v73 : UH0 = UH0_1
            UH0_0(v72, v73)
    let v79 : obj =
        match v1 with
        | US3_0 -> (* None *)
            let v76 : obj = ()
            v76
        | US3_1(v77) -> (* Some *)
            let v78 : obj = v77
            v78
    let v80 : bool = emitJsExpr v79 "!$0"
    let v84 : UH0 =
        if v80 then
            v75
        else
            let v81 : string = "alignSelf"
            let v82 : (string * obj) = v81, v79
            UH0_0(v82, v75)
    let v88 : obj =
        match v2 with
        | US3_0 -> (* None *)
            let v85 : obj = ()
            v85
        | US3_1(v86) -> (* Some *)
            let v87 : obj = v86
            v87
    let v89 : bool = emitJsExpr v88 "!$0"
    let v93 : UH0 =
        if v89 then
            v84
        else
            let v90 : string = "aria-label"
            let v91 : (string * obj) = v90, v88
            UH0_0(v91, v84)
    let v97 : obj =
        match v3 with
        | US5_0 -> (* None *)
            let v94 : obj = ()
            v94
        | US5_1(v95) -> (* Some *)
            let v96 : obj = v95
            v96
    let v98 : bool = emitJsExpr v97 "!$0"
    let v102 : UH0 =
        if v98 then
            v93
        else
            let v99 : string = "as"
            let v100 : (string * obj) = v99, v97
            UH0_0(v100, v93)
    let v106 : obj =
        match v4 with
        | US3_0 -> (* None *)
            let v103 : obj = ()
            v103
        | US3_1(v104) -> (* Some *)
            let v105 : obj = v104
            v105
    let v107 : bool = emitJsExpr v106 "!$0"
    let v111 : UH0 =
        if v107 then
            v102
        else
            let v108 : string = "backgroundColor"
            let v109 : (string * obj) = v108, v106
            UH0_0(v109, v102)
    let v115 : obj =
        match v5 with
        | US3_0 -> (* None *)
            let v112 : obj = ()
            v112
        | US3_1(v113) -> (* Some *)
            let v114 : obj = v113
            v114
    let v116 : bool = emitJsExpr v115 "!$0"
    let v120 : UH0 =
        if v116 then
            v111
        else
            let v117 : string = "border"
            let v118 : (string * obj) = v117, v115
            UH0_0(v118, v111)
    let v124 : obj =
        match v6 with
        | US3_0 -> (* None *)
            let v121 : obj = ()
            v121
        | US3_1(v122) -> (* Some *)
            let v123 : obj = v122
            v123
    let v125 : bool = emitJsExpr v124 "!$0"
    let v129 : UH0 =
        if v125 then
            v120
        else
            let v126 : string = "borderBottomWidth"
            let v127 : (string * obj) = v126, v124
            UH0_0(v127, v120)
    let v133 : obj =
        match v7 with
        | US3_0 -> (* None *)
            let v130 : obj = ()
            v130
        | US3_1(v131) -> (* Some *)
            let v132 : obj = v131
            v132
    let v134 : bool = emitJsExpr v133 "!$0"
    let v138 : UH0 =
        if v134 then
            v129
        else
            let v135 : string = "borderColor"
            let v136 : (string * obj) = v135, v133
            UH0_0(v136, v129)
    let v142 : obj =
        match v8 with
        | US3_0 -> (* None *)
            let v139 : obj = ()
            v139
        | US3_1(v140) -> (* Some *)
            let v141 : obj = v140
            v141
    let v143 : bool = emitJsExpr v142 "!$0"
    let v147 : UH0 =
        if v143 then
            v138
        else
            let v144 : string = "borderWidth"
            let v145 : (string * obj) = v144, v142
            UH0_0(v145, v138)
    let v151 : obj =
        match v9 with
        | US3_0 -> (* None *)
            let v148 : obj = ()
            v148
        | US3_1(v149) -> (* Some *)
            let v150 : obj = v149
            v150
    let v152 : bool = emitJsExpr v151 "!$0"
    let v156 : UH0 =
        if v152 then
            v147
        else
            let v153 : string = "bottom"
            let v154 : (string * obj) = v153, v151
            UH0_0(v154, v147)
    let v160 : obj =
        match v10 with
        | US6_0 -> (* None *)
            let v157 : obj = ()
            v157
        | US6_1(v158) -> (* Some *)
            let v159 : obj = v158
            v159
    let v161 : bool = emitJsExpr v160 "!$0"
    let v165 : UH0 =
        if v161 then
            v156
        else
            let v162 : string = "checked"
            let v163 : (string * obj) = v162, v160
            UH0_0(v163, v156)
    let v169 : obj =
        match v11 with
        | US7_0 -> (* None *)
            let v166 : obj = ()
            v166
        | US7_1(v167) -> (* Some *)
            let v168 : obj = v167
            v168
    let v170 : bool = emitJsExpr v169 "!$0"
    let v174 : UH0 =
        if v170 then
            v165
        else
            let v171 : string = "children"
            let v172 : (string * obj) = v171, v169
            UH0_0(v172, v165)
    let v178 : obj =
        match v12 with
        | US3_0 -> (* None *)
            let v175 : obj = ()
            v175
        | US3_1(v176) -> (* Some *)
            let v177 : obj = v176
            v177
    let v179 : bool = emitJsExpr v178 "!$0"
    let v183 : UH0 =
        if v179 then
            v174
        else
            let v180 : string = "color"
            let v181 : (string * obj) = v180, v178
            UH0_0(v181, v174)
    let v187 : obj =
        match v13 with
        | US3_0 -> (* None *)
            let v184 : obj = ()
            v184
        | US3_1(v185) -> (* Some *)
            let v186 : obj = v185
            v186
    let v188 : bool = emitJsExpr v187 "!$0"
    let v192 : UH0 =
        if v188 then
            v183
        else
            let v189 : string = "colorScheme"
            let v190 : (string * obj) = v189, v187
            UH0_0(v190, v183)
    let v196 : obj =
        match v14 with
        | US6_0 -> (* None *)
            let v193 : obj = ()
            v193
        | US6_1(v194) -> (* Some *)
            let v195 : obj = v194
            v195
    let v197 : bool = emitJsExpr v196 "!$0"
    let v201 : UH0 =
        if v197 then
            v192
        else
            let v198 : string = "compact"
            let v199 : (string * obj) = v198, v196
            UH0_0(v199, v192)
    let v205 : obj =
        match v15 with
        | US8_0 -> (* None *)
            let v202 : obj = ()
            v202
        | US8_1(v203) -> (* Some *)
            let v204 : obj = v203
            v204
    let v206 : bool = emitJsExpr v205 "!$0"
    let v210 : UH0 =
        if v206 then
            v201
        else
            let v207 : string = "css"
            let v208 : (string * obj) = v207, v205
            UH0_0(v208, v201)
    let v214 : obj =
        match v16 with
        | US3_0 -> (* None *)
            let v211 : obj = ()
            v211
        | US3_1(v212) -> (* Some *)
            let v213 : obj = v212
            v213
    let v215 : bool = emitJsExpr v214 "!$0"
    let v219 : UH0 =
        if v215 then
            v210
        else
            let v216 : string = "defaultValue"
            let v217 : (string * obj) = v216, v214
            UH0_0(v217, v210)
    let v223 : obj =
        match v17 with
        | US3_0 -> (* None *)
            let v220 : obj = ()
            v220
        | US3_1(v221) -> (* Some *)
            let v222 : obj = v221
            v222
    let v224 : bool = emitJsExpr v223 "!$0"
    let v228 : UH0 =
        if v224 then
            v219
        else
            let v225 : string = "direction"
            let v226 : (string * obj) = v225, v223
            UH0_0(v226, v219)
    let v232 : obj =
        match v18 with
        | US3_0 -> (* None *)
            let v229 : obj = ()
            v229
        | US3_1(v230) -> (* Some *)
            let v231 : obj = v230
            v231
    let v233 : bool = emitJsExpr v232 "!$0"
    let v237 : UH0 =
        if v233 then
            v228
        else
            let v234 : string = "display"
            let v235 : (string * obj) = v234, v232
            UH0_0(v235, v228)
    let v241 : obj =
        match v19 with
        | US9_0 -> (* None *)
            let v238 : obj = ()
            v238
        | US9_1(v239) -> (* Some *)
            let v240 : obj = v239
            v240
    let v242 : bool = emitJsExpr v241 "!$0"
    let v246 : UH0 =
        if v242 then
            v237
        else
            let v243 : string = "each"
            let v244 : (string * obj) = v243, v241
            UH0_0(v244, v237)
    let v250 : obj =
        match v20 with
        | US6_0 -> (* None *)
            let v247 : obj = ()
            v247
        | US6_1(v248) -> (* Some *)
            let v249 : obj = v248
            v249
    let v251 : bool = emitJsExpr v250 "!$0"
    let v255 : UH0 =
        if v251 then
            v246
        else
            let v252 : string = "external"
            let v253 : (string * obj) = v252, v250
            UH0_0(v253, v246)
    let v259 : obj =
        match v21 with
        | US3_0 -> (* None *)
            let v256 : obj = ()
            v256
        | US3_1(v257) -> (* Some *)
            let v258 : obj = v257
            v258
    let v260 : bool = emitJsExpr v259 "!$0"
    let v264 : UH0 =
        if v260 then
            v255
        else
            let v261 : string = "flex"
            let v262 : (string * obj) = v261, v259
            UH0_0(v262, v255)
    let v268 : obj =
        match v22 with
        | US3_0 -> (* None *)
            let v265 : obj = ()
            v265
        | US3_1(v266) -> (* Some *)
            let v267 : obj = v266
            v267
    let v269 : bool = emitJsExpr v268 "!$0"
    let v273 : UH0 =
        if v269 then
            v264
        else
            let v270 : string = "flexDirection"
            let v271 : (string * obj) = v270, v268
            UH0_0(v271, v264)
    let v277 : obj =
        match v23 with
        | US3_0 -> (* None *)
            let v274 : obj = ()
            v274
        | US3_1(v275) -> (* Some *)
            let v276 : obj = v275
            v276
    let v278 : bool = emitJsExpr v277 "!$0"
    let v282 : UH0 =
        if v278 then
            v273
        else
            let v279 : string = "fontSize"
            let v280 : (string * obj) = v279, v277
            UH0_0(v280, v273)
    let v286 : obj =
        match v24 with
        | US3_0 -> (* None *)
            let v283 : obj = ()
            v283
        | US3_1(v284) -> (* Some *)
            let v285 : obj = v284
            v285
    let v287 : bool = emitJsExpr v286 "!$0"
    let v291 : UH0 =
        if v287 then
            v282
        else
            let v288 : string = "height"
            let v289 : (string * obj) = v288, v286
            UH0_0(v289, v282)
    let v295 : obj =
        match v25 with
        | US3_0 -> (* None *)
            let v292 : obj = ()
            v292
        | US3_1(v293) -> (* Some *)
            let v294 : obj = v293
            v294
    let v296 : bool = emitJsExpr v295 "!$0"
    let v300 : UH0 =
        if v296 then
            v291
        else
            let v297 : string = "href"
            let v298 : (string * obj) = v297, v295
            UH0_0(v298, v291)
    let v304 : obj =
        match v26 with
        | US10_0 -> (* None *)
            let v301 : obj = ()
            v301
        | US10_1(v302) -> (* Some *)
            let v303 : obj = v302
            v303
    let v305 : bool = emitJsExpr v304 "!$0"
    let v309 : UH0 =
        if v305 then
            v300
        else
            let v306 : string = "icon"
            let v307 : (string * obj) = v306, v304
            UH0_0(v307, v300)
    let v313 : obj =
        match v27 with
        | US3_0 -> (* None *)
            let v310 : obj = ()
            v310
        | US3_1(v311) -> (* Some *)
            let v312 : obj = v311
            v312
    let v314 : bool = emitJsExpr v313 "!$0"
    let v318 : UH0 =
        if v314 then
            v309
        else
            let v315 : string = "id"
            let v316 : (string * obj) = v315, v313
            UH0_0(v316, v309)
    let v322 : obj =
        match v28 with
        | US3_0 -> (* None *)
            let v319 : obj = ()
            v319
        | US3_1(v320) -> (* Some *)
            let v321 : obj = v320
            v321
    let v323 : bool = emitJsExpr v322 "!$0"
    let v327 : UH0 =
        if v323 then
            v318
        else
            let v324 : string = "justifyContent"
            let v325 : (string * obj) = v324, v322
            UH0_0(v325, v318)
    let v331 : obj =
        match v29 with
        | US3_0 -> (* None *)
            let v328 : obj = ()
            v328
        | US3_1(v329) -> (* Some *)
            let v330 : obj = v329
            v330
    let v332 : bool = emitJsExpr v331 "!$0"
    let v336 : UH0 =
        if v332 then
            v327
        else
            let v333 : string = "left"
            let v334 : (string * obj) = v333, v331
            UH0_0(v334, v327)
    let v340 : obj =
        match v30 with
        | US10_0 -> (* None *)
            let v337 : obj = ()
            v337
        | US10_1(v338) -> (* Some *)
            let v339 : obj = v338
            v339
    let v341 : bool = emitJsExpr v340 "!$0"
    let v345 : UH0 =
        if v341 then
            v336
        else
            let v342 : string = "leftIcon"
            let v343 : (string * obj) = v342, v340
            UH0_0(v343, v336)
    let v349 : obj =
        match v31 with
        | US3_0 -> (* None *)
            let v346 : obj = ()
            v346
        | US3_1(v347) -> (* Some *)
            let v348 : obj = v347
            v348
    let v350 : bool = emitJsExpr v349 "!$0"
    let v354 : UH0 =
        if v350 then
            v345
        else
            let v351 : string = "lineHeight"
            let v352 : (string * obj) = v351, v349
            UH0_0(v352, v345)
    let v358 : obj =
        match v32 with
        | US3_0 -> (* None *)
            let v355 : obj = ()
            v355
        | US3_1(v356) -> (* Some *)
            let v357 : obj = v356
            v357
    let v359 : bool = emitJsExpr v358 "!$0"
    let v363 : UH0 =
        if v359 then
            v354
        else
            let v360 : string = "margin"
            let v361 : (string * obj) = v360, v358
            UH0_0(v361, v354)
    let v367 : obj =
        match v33 with
        | US3_0 -> (* None *)
            let v364 : obj = ()
            v364
        | US3_1(v365) -> (* Some *)
            let v366 : obj = v365
            v366
    let v368 : bool = emitJsExpr v367 "!$0"
    let v372 : UH0 =
        if v368 then
            v363
        else
            let v369 : string = "marginBottom"
            let v370 : (string * obj) = v369, v367
            UH0_0(v370, v363)
    let v376 : obj =
        match v34 with
        | US3_0 -> (* None *)
            let v373 : obj = ()
            v373
        | US3_1(v374) -> (* Some *)
            let v375 : obj = v374
            v375
    let v377 : bool = emitJsExpr v376 "!$0"
    let v381 : UH0 =
        if v377 then
            v372
        else
            let v378 : string = "marginLeft"
            let v379 : (string * obj) = v378, v376
            UH0_0(v379, v372)
    let v385 : obj =
        match v35 with
        | US3_0 -> (* None *)
            let v382 : obj = ()
            v382
        | US3_1(v383) -> (* Some *)
            let v384 : obj = v383
            v384
    let v386 : bool = emitJsExpr v385 "!$0"
    let v390 : UH0 =
        if v386 then
            v381
        else
            let v387 : string = "marginRight"
            let v388 : (string * obj) = v387, v385
            UH0_0(v388, v381)
    let v394 : obj =
        match v36 with
        | US3_0 -> (* None *)
            let v391 : obj = ()
            v391
        | US3_1(v392) -> (* Some *)
            let v393 : obj = v392
            v393
    let v395 : bool = emitJsExpr v394 "!$0"
    let v399 : UH0 =
        if v395 then
            v390
        else
            let v396 : string = "marginTop"
            let v397 : (string * obj) = v396, v394
            UH0_0(v397, v390)
    let v403 : obj =
        match v37 with
        | US3_0 -> (* None *)
            let v400 : obj = ()
            v400
        | US3_1(v401) -> (* Some *)
            let v402 : obj = v401
            v402
    let v404 : bool = emitJsExpr v403 "!$0"
    let v408 : UH0 =
        if v404 then
            v399
        else
            let v405 : string = "maxHeight"
            let v406 : (string * obj) = v405, v403
            UH0_0(v406, v399)
    let v412 : obj =
        match v38 with
        | US3_0 -> (* None *)
            let v409 : obj = ()
            v409
        | US3_1(v410) -> (* Some *)
            let v411 : obj = v410
            v411
    let v413 : bool = emitJsExpr v412 "!$0"
    let v417 : UH0 =
        if v413 then
            v408
        else
            let v414 : string = "maxWidth"
            let v415 : (string * obj) = v414, v412
            UH0_0(v415, v408)
    let v421 : obj =
        match v39 with
        | US11_0 -> (* None *)
            let v418 : obj = ()
            v418
        | US11_1(v419) -> (* Some *)
            let v420 : obj = v419
            v420
    let v422 : bool = emitJsExpr v421 "!$0"
    let v426 : UH0 =
        if v422 then
            v417
        else
            let v423 : string = "onChange"
            let v424 : (string * obj) = v423, v421
            UH0_0(v424, v417)
    let v430 : obj =
        match v40 with
        | US12_0 -> (* None *)
            let v427 : obj = ()
            v427
        | US12_1(v428) -> (* Some *)
            let v429 : obj = v428
            v429
    let v431 : bool = emitJsExpr v430 "!$0"
    let v435 : UH0 =
        if v431 then
            v426
        else
            let v432 : string = "onClick"
            let v433 : (string * obj) = v432, v430
            UH0_0(v433, v426)
    let v439 : obj =
        match v41 with
        | US11_0 -> (* None *)
            let v436 : obj = ()
            v436
        | US11_1(v437) -> (* Some *)
            let v438 : obj = v437
            v438
    let v440 : bool = emitJsExpr v439 "!$0"
    let v444 : UH0 =
        if v440 then
            v435
        else
            let v441 : string = "onInput"
            let v442 : (string * obj) = v441, v439
            UH0_0(v442, v435)
    let v448 : obj =
        match v42 with
        | US3_0 -> (* None *)
            let v445 : obj = ()
            v445
        | US3_1(v446) -> (* Some *)
            let v447 : obj = v446
            v447
    let v449 : bool = emitJsExpr v448 "!$0"
    let v453 : UH0 =
        if v449 then
            v444
        else
            let v450 : string = "outline"
            let v451 : (string * obj) = v450, v448
            UH0_0(v451, v444)
    let v457 : obj =
        match v43 with
        | US3_0 -> (* None *)
            let v454 : obj = ()
            v454
        | US3_1(v455) -> (* Some *)
            let v456 : obj = v455
            v456
    let v458 : bool = emitJsExpr v457 "!$0"
    let v462 : UH0 =
        if v458 then
            v453
        else
            let v459 : string = "overflow"
            let v460 : (string * obj) = v459, v457
            UH0_0(v460, v453)
    let v466 : obj =
        match v44 with
        | US3_0 -> (* None *)
            let v463 : obj = ()
            v463
        | US3_1(v464) -> (* Some *)
            let v465 : obj = v464
            v465
    let v467 : bool = emitJsExpr v466 "!$0"
    let v471 : UH0 =
        if v467 then
            v462
        else
            let v468 : string = "overflowX"
            let v469 : (string * obj) = v468, v466
            UH0_0(v469, v462)
    let v475 : obj =
        match v45 with
        | US3_0 -> (* None *)
            let v472 : obj = ()
            v472
        | US3_1(v473) -> (* Some *)
            let v474 : obj = v473
            v474
    let v476 : bool = emitJsExpr v475 "!$0"
    let v480 : UH0 =
        if v476 then
            v471
        else
            let v477 : string = "overflowY"
            let v478 : (string * obj) = v477, v475
            UH0_0(v478, v471)
    let v484 : obj =
        match v46 with
        | US3_0 -> (* None *)
            let v481 : obj = ()
            v481
        | US3_1(v482) -> (* Some *)
            let v483 : obj = v482
            v483
    let v485 : bool = emitJsExpr v484 "!$0"
    let v489 : UH0 =
        if v485 then
            v480
        else
            let v486 : string = "padding"
            let v487 : (string * obj) = v486, v484
            UH0_0(v487, v480)
    let v493 : obj =
        match v47 with
        | US3_0 -> (* None *)
            let v490 : obj = ()
            v490
        | US3_1(v491) -> (* Some *)
            let v492 : obj = v491
            v492
    let v494 : bool = emitJsExpr v493 "!$0"
    let v498 : UH0 =
        if v494 then
            v489
        else
            let v495 : string = "paddingBottom"
            let v496 : (string * obj) = v495, v493
            UH0_0(v496, v489)
    let v502 : obj =
        match v48 with
        | US3_0 -> (* None *)
            let v499 : obj = ()
            v499
        | US3_1(v500) -> (* Some *)
            let v501 : obj = v500
            v501
    let v503 : bool = emitJsExpr v502 "!$0"
    let v507 : UH0 =
        if v503 then
            v498
        else
            let v504 : string = "paddingLeft"
            let v505 : (string * obj) = v504, v502
            UH0_0(v505, v498)
    let v511 : obj =
        match v49 with
        | US3_0 -> (* None *)
            let v508 : obj = ()
            v508
        | US3_1(v509) -> (* Some *)
            let v510 : obj = v509
            v510
    let v512 : bool = emitJsExpr v511 "!$0"
    let v516 : UH0 =
        if v512 then
            v507
        else
            let v513 : string = "paddingRight"
            let v514 : (string * obj) = v513, v511
            UH0_0(v514, v507)
    let v520 : obj =
        match v50 with
        | US3_0 -> (* None *)
            let v517 : obj = ()
            v517
        | US3_1(v518) -> (* Some *)
            let v519 : obj = v518
            v519
    let v521 : bool = emitJsExpr v520 "!$0"
    let v525 : UH0 =
        if v521 then
            v516
        else
            let v522 : string = "paddingTop"
            let v523 : (string * obj) = v522, v520
            UH0_0(v523, v516)
    let v529 : obj =
        match v51 with
        | US3_0 -> (* None *)
            let v526 : obj = ()
            v526
        | US3_1(v527) -> (* Some *)
            let v528 : obj = v527
            v528
    let v530 : bool = emitJsExpr v529 "!$0"
    let v534 : UH0 =
        if v530 then
            v525
        else
            let v531 : string = "position"
            let v532 : (string * obj) = v531, v529
            UH0_0(v532, v525)
    let v538 : obj =
        match v52 with
        | US3_0 -> (* None *)
            let v535 : obj = ()
            v535
        | US3_1(v536) -> (* Some *)
            let v537 : obj = v536
            v537
    let v539 : bool = emitJsExpr v538 "!$0"
    let v543 : UH0 =
        if v539 then
            v534
        else
            let v540 : string = "right"
            let v541 : (string * obj) = v540, v538
            UH0_0(v541, v534)
    let v547 : obj =
        match v53 with
        | US3_0 -> (* None *)
            let v544 : obj = ()
            v544
        | US3_1(v545) -> (* Some *)
            let v546 : obj = v545
            v546
    let v548 : bool = emitJsExpr v547 "!$0"
    let v552 : UH0 =
        if v548 then
            v543
        else
            let v549 : string = "size"
            let v550 : (string * obj) = v549, v547
            UH0_0(v550, v543)
    let v556 : obj =
        match v54 with
        | US3_0 -> (* None *)
            let v553 : obj = ()
            v553
        | US3_1(v554) -> (* Some *)
            let v555 : obj = v554
            v555
    let v557 : bool = emitJsExpr v556 "!$0"
    let v561 : UH0 =
        if v557 then
            v552
        else
            let v558 : string = "spacing"
            let v559 : (string * obj) = v558, v556
            UH0_0(v559, v552)
    let v565 : obj =
        match v55 with
        | US3_0 -> (* None *)
            let v562 : obj = ()
            v562
        | US3_1(v563) -> (* Some *)
            let v564 : obj = v563
            v564
    let v566 : bool = emitJsExpr v565 "!$0"
    let v570 : UH0 =
        if v566 then
            v561
        else
            let v567 : string = "src"
            let v568 : (string * obj) = v567, v565
            UH0_0(v568, v561)
    let v574 : obj =
        match v56 with
        | US3_0 -> (* None *)
            let v571 : obj = ()
            v571
        | US3_1(v572) -> (* Some *)
            let v573 : obj = v572
            v573
    let v575 : bool = emitJsExpr v574 "!$0"
    let v579 : UH0 =
        if v575 then
            v570
        else
            let v576 : string = "striped"
            let v577 : (string * obj) = v576, v574
            UH0_0(v577, v570)
    let v583 : obj =
        match v57 with
        | US3_0 -> (* None *)
            let v580 : obj = ()
            v580
        | US3_1(v581) -> (* Some *)
            let v582 : obj = v581
            v582
    let v584 : bool = emitJsExpr v583 "!$0"
    let v588 : UH0 =
        if v584 then
            v579
        else
            let v585 : string = "thickness"
            let v586 : (string * obj) = v585, v583
            UH0_0(v586, v579)
    let v592 : obj =
        match v58 with
        | US10_0 -> (* None *)
            let v589 : obj = ()
            v589
        | US10_1(v590) -> (* Some *)
            let v591 : obj = v590
            v591
    let v593 : bool = emitJsExpr v592 "!$0"
    let v597 : UH0 =
        if v593 then
            v588
        else
            let v594 : string = "title"
            let v595 : (string * obj) = v594, v592
            UH0_0(v595, v588)
    let v601 : obj =
        match v59 with
        | US3_0 -> (* None *)
            let v598 : obj = ()
            v598
        | US3_1(v599) -> (* Some *)
            let v600 : obj = v599
            v600
    let v602 : bool = emitJsExpr v601 "!$0"
    let v606 : UH0 =
        if v602 then
            v597
        else
            let v603 : string = "top"
            let v604 : (string * obj) = v603, v601
            UH0_0(v604, v597)
    let v610 : obj =
        match v60 with
        | US3_0 -> (* None *)
            let v607 : obj = ()
            v607
        | US3_1(v608) -> (* Some *)
            let v609 : obj = v608
            v609
    let v611 : bool = emitJsExpr v610 "!$0"
    let v615 : UH0 =
        if v611 then
            v606
        else
            let v612 : string = "type"
            let v613 : (string * obj) = v612, v610
            UH0_0(v613, v606)
    let v619 : obj =
        match v61 with
        | US8_0 -> (* None *)
            let v616 : obj = ()
            v616
        | US8_1(v617) -> (* Some *)
            let v618 : obj = v617
            v618
    let v620 : bool = emitJsExpr v619 "!$0"
    let v624 : UH0 =
        if v620 then
            v615
        else
            let v621 : string = "value"
            let v622 : (string * obj) = v621, v619
            UH0_0(v622, v615)
    let v628 : obj =
        match v62 with
        | US3_0 -> (* None *)
            let v625 : obj = ()
            v625
        | US3_1(v626) -> (* Some *)
            let v627 : obj = v626
            v627
    let v629 : bool = emitJsExpr v628 "!$0"
    let v633 : UH0 =
        if v629 then
            v624
        else
            let v630 : string = "width"
            let v631 : (string * obj) = v630, v628
            UH0_0(v631, v624)
    let v637 : obj =
        match v63 with
        | US2_0 -> (* None *)
            let v634 : obj = ()
            v634
        | US2_1(v635) -> (* Some *)
            let v636 : obj = v635
            v636
    let v638 : bool = emitJsExpr v637 "!$0"
    let v642 : UH0 =
        if v638 then
            v633
        else
            let v639 : string = "zIndex"
            let v640 : (string * obj) = v639, v637
            UH0_0(v640, v633)
    let v646 : obj =
        match v64 with
        | US3_0 -> (* None *)
            let v643 : obj = ()
            v643
        | US3_1(v644) -> (* Some *)
            let v645 : obj = v644
            v645
    let v647 : bool = emitJsExpr v646 "!$0"
    let v651 : UH0 =
        if v647 then
            v642
        else
            let v648 : string = "zoom"
            let v649 : (string * obj) = v648, v646
            UH0_0(v649, v642)
    method14(v651)
and closure9 (v0 : Mut1, v1 : (unit -> bool)) () : (JSX.Element []) =
    let v2 : bool = v1 ()
    let v84 : JSX.Element =
        if v2 then
            let v3 : string = "hope"
            let v4 : string = "@hope-ui/solid"
            let v5 : JS.Function = import v3 v4
            let v6 : JS.Function = v5?pre
            let struct (v7 : US3, v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US10, v66 : US3, v67 : US3, v68 : US8, v69 : US3, v70 : US2, v71 : US3) = method11()
            let v72 : (unit -> (JSX.Element [])) = closure10(v0)
            let v73 : US7 = US7_1(v72)
            let v74 : string = "9px"
            let v75 : US3 = US3_1(v74)
            let v76 : ((string * obj) []) = method13(v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v73, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v75, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
            let v77 : obj = createObj v76
            let v78 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
            let v79 : string = "createComponent"
            let v80 : string = "solid-js"
            let v81 : JS.Function = import v79 v80
            let v82 : JSX.Element = v81.Invoke (v78, v77) |> unbox<JSX.Element>
            v82
        else
            let v83 : JSX.Element = Html.fragment []
            v83
    [|v84|]
and closure14 () () : (JSX.Element []) =
    [||]
and closure13 (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) () : (JSX.Element []) =
    let v67 : (unit -> (JSX.Element [])) =
        match v11 with
        | US7_0 -> (* None *)
            closure14()
        | US7_1(v66) -> (* Some *)
            v66
    let v68 : string = "Box"
    let v69 : string = "@hope-ui/solid"
    let v70 : JS.Function = import v68 v69
    let struct (v71 : US3, v72 : US3, v73 : US3, v74 : US5, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US6, v82 : US7, v83 : US3, v84 : US3, v85 : US6, v86 : US8, v87 : US3, v88 : US3, v89 : US3, v90 : US9, v91 : US6, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US10, v98 : US3, v99 : US3, v100 : US3, v101 : US10, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US11, v111 : US12, v112 : US11, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US10, v130 : US3, v131 : US3, v132 : US8, v133 : US3, v134 : US2, v135 : US3) = method11()
    let v136 : US7 = US7_1(v67)
    let v137 : string = "2px"
    let v138 : US3 = US3_1(v137)
    let v139 : ((string * obj) []) = method13(v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v136, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v138, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135)
    let v140 : obj = createObj v139
    let v141 : (obj -> JSX.Element) = v70 |> unbox<obj -> JSX.Element>
    let v142 : string = "createComponent"
    let v143 : string = "solid-js"
    let v144 : JS.Function = import v142 v143
    let v145 : JSX.Element = v144.Invoke (v141, v140) |> unbox<JSX.Element>
    [|v145|]
and closure15 (v0 : Mut4) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    let v3 : (bool -> unit) = v0.l1
    v3 v2
    ()
and closure12 () (v0 : Mut4) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l2
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let struct (v67 : US3, v68 : US3, v69 : US3, v70 : US5, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US7, v79 : US3, v80 : US3, v81 : US6, v82 : US8, v83 : US3, v84 : US3, v85 : US3, v86 : US9, v87 : US6, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US3, v95 : US3, v96 : US3, v97 : US10, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US11, v107 : US12, v108 : US11, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US10, v126 : US3, v127 : US3, v128 : US8, v129 : US3, v130 : US2, v131 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v132 : string = "Checkbox"
    let v133 : string = "@hope-ui/solid"
    let v134 : JS.Function = import v132 v133
    let struct (v135 : US3, v136 : US3, v137 : US3, v138 : US5, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US6, v146 : US7, v147 : US3, v148 : US3, v149 : US6, v150 : US8, v151 : US3, v152 : US3, v153 : US3, v154 : US9, v155 : US6, v156 : US3, v157 : US3, v158 : US3, v159 : US3, v160 : US3, v161 : US10, v162 : US3, v163 : US3, v164 : US3, v165 : US10, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US11, v175 : US12, v176 : US11, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US10, v194 : US3, v195 : US3, v196 : US8, v197 : US3, v198 : US2, v199 : US3) = method11()
    let v200 : (unit -> bool) = v0.l0
    let v201 : bool = v200 ()
    let v202 : US6 = US6_1(v201)
    let v203 : (unit -> (JSX.Element [])) = closure13(v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131)
    let v204 : US7 = US7_1(v203)
    let v205 : string = "neutral"
    let v206 : US3 = US3_1(v205)
    let v207 : string = "2px"
    let v208 : US3 = US3_1(v207)
    let v209 : (obj -> unit) = closure15(v0)
    let v210 : US11 = US11_1(v209)
    let v211 : string = "sm"
    let v212 : US3 = US3_1(v211)
    let v213 : ((string * obj) []) = method13(v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v202, v204, v147, v206, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v208, v169, v170, v171, v172, v173, v210, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v212, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199)
    let v214 : obj = createObj v213
    let v215 : (obj -> JSX.Element) = v134 |> unbox<obj -> JSX.Element>
    let v216 : string = "createComponent"
    let v217 : string = "solid-js"
    let v218 : JS.Function = import v216 v217
    let v219 : JSX.Element = v218.Invoke (v215, v214) |> unbox<JSX.Element>
    v219
and closure17 () () : (JSX.Element []) =
    let v0 : string = "Debug"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure16 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : (unit -> (JSX.Element [])) = closure17()
    let v66 : US7 = US7_1(v65)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v66, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure11 (v0 : (bool -> unit), v1 : (unit -> bool)) () : (JSX.Element []) =
    let v2 : (Mut4 -> JSX.Element) = closure12()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure16()
    let v5 : Mut4 = {l0 = v1; l1 = v0; l2 = v4} : Mut4
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v3, v6) |> unbox<JSX.Element>
    [|v10|]
and closure8 (v0 : Mut1, v1 : (bool -> unit), v2 : (unit -> bool)) () : (JSX.Element []) =
    let v3 : string = "Box"
    let v4 : string = "@hope-ui/solid"
    let v5 : JS.Function = import v3 v4
    let struct (v6 : US3, v7 : US3, v8 : US3, v9 : US5, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US6, v17 : US7, v18 : US3, v19 : US3, v20 : US6, v21 : US8, v22 : US3, v23 : US3, v24 : US3, v25 : US9, v26 : US6, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US11, v46 : US12, v47 : US11, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method11()
    let v71 : (unit -> (JSX.Element [])) = closure9(v0, v2)
    let v72 : US7 = US7_1(v71)
    let v73 : string = "1"
    let v74 : US3 = US3_1(v73)
    let v75 : ((string * obj) []) = method13(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v72, v18, v19, v20, v21, v22, v23, v24, v25, v26, v74, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v76 : obj = createObj v75
    let v77 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    let v82 : JS.Function = import v3 v4
    let struct (v83 : US3, v84 : US3, v85 : US3, v86 : US5, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US6, v94 : US7, v95 : US3, v96 : US3, v97 : US6, v98 : US8, v99 : US3, v100 : US3, v101 : US3, v102 : US9, v103 : US6, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US10, v110 : US3, v111 : US3, v112 : US3, v113 : US10, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US11, v123 : US12, v124 : US11, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US10, v142 : US3, v143 : US3, v144 : US8, v145 : US3, v146 : US2, v147 : US3) = method11()
    let v148 : string = "flex-end"
    let v149 : US3 = US3_1(v148)
    let v150 : (unit -> (JSX.Element [])) = closure11(v1, v2)
    let v151 : US7 = US7_1(v150)
    let v152 : ((string * obj) []) = method13(v83, v149, v85, v86, v87, v88, v89, v90, v91, v92, v93, v151, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147)
    let v153 : obj = createObj v152
    let v154 : (obj -> JSX.Element) = v82 |> unbox<obj -> JSX.Element>
    let v155 : JS.Function = import v78 v79
    let v156 : JSX.Element = v155.Invoke (v154, v153) |> unbox<JSX.Element>
    [|v81; v156|]
and method12 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : string = "createSignal"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (JS.Function []) = v8.Invoke false |> unbox<JS.Function[]>
    let v10 : (unit -> bool) = v9.[0] |> unbox
    let v11 : (bool -> unit) = v9.[1] |> unbox
    let v12 : string = "Box"
    let v13 : string = "@hope-ui/solid"
    let v14 : JS.Function = import v12 v13
    let struct (v15 : US3, v16 : US3, v17 : US3, v18 : US5, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US7, v27 : US3, v28 : US3, v29 : US6, v30 : US8, v31 : US3, v32 : US3, v33 : US3, v34 : US9, v35 : US6, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US10, v42 : US3, v43 : US3, v44 : US3, v45 : US10, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US11, v55 : US12, v56 : US11, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US10, v74 : US3, v75 : US3, v76 : US8, v77 : US3, v78 : US2, v79 : US3) = method11()
    let v80 : string = "#00000066"
    let v81 : US3 = US3_1(v80)
    let v82 : string = "0"
    let v83 : US3 = US3_1(v82)
    let v84 : (unit -> (JSX.Element [])) = closure8(v4, v11, v10)
    let v85 : US7 = US7_1(v84)
    let v86 : string = "flex"
    let v87 : US3 = US3_1(v86)
    let v88 : string = "column"
    let v89 : US3 = US3_1(v88)
    let v90 : string = "80vh"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "50vw"
    let v93 : US3 = US3_1(v92)
    let v94 : string = "auto"
    let v95 : US3 = US3_1(v94)
    let v96 : string = "2px 6px"
    let v97 : US3 = US3_1(v96)
    let v98 : string = "absolute"
    let v99 : US3 = US3_1(v98)
    let v100 : US3 = US3_1(v82)
    let v101 : int32 = 2
    let v102 : US2 = US2_1(v101)
    let v103 : ((string * obj) []) = method13(v15, v16, v17, v18, v81, v20, v21, v22, v23, v83, v25, v85, v27, v28, v29, v30, v31, v32, v87, v34, v35, v36, v89, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v91, v93, v54, v55, v56, v57, v95, v59, v60, v97, v62, v63, v64, v65, v99, v100, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v102, v79)
    let v104 : obj = createObj v103
    let v105 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
    let v106 : string = "createComponent"
    let v107 : JS.Function = import v106 v7
    let v108 : JSX.Element = v107.Invoke (v105, v104) |> unbox<JSX.Element>
    v108
and closure7 () (v0 : Mut2) : JSX.Element =
    method12()
and closure20 () () : (JSX.Element []) =
    [||]
and closure19 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : US7 = v0.l11
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US7_0 -> (* None *)
            closure20()
        | US7_1(v3) -> (* Some *)
            v3
    let v5 : string = "Tbody"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US5, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US7, v20 : US3, v21 : US3, v22 : US6, v23 : US8, v24 : US3, v25 : US3, v26 : US3, v27 : US9, v28 : US6, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US10, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US11, v48 : US12, v49 : US11, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method11()
    let v73 : string = "$blackAlpha3"
    let v74 : US3 = US3_1(v73)
    let v75 : US7 = US7_1(v4)
    let v76 : string = "flex"
    let v77 : US3 = US3_1(v76)
    let v78 : string = "column"
    let v79 : US3 = US3_1(v78)
    let v80 : string = "-1px"
    let v81 : US3 = US3_1(v80)
    let v82 : ((string * obj) []) = method13(v8, v9, v10, v11, v74, v13, v14, v15, v16, v17, v18, v75, v20, v21, v22, v23, v24, v25, v77, v27, v28, v29, v79, v31, v32, v33, v34, v35, v36, v37, v38, v39, v81, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v83 : obj = createObj v82
    let v84 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : JSX.Element = v87.Invoke (v84, v83) |> unbox<JSX.Element>
    [|v88|]
and method17 (v0 : Mut3) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) = method11()
    let v69 : US3 = v0.l45
    let v72 : string =
        match v69 with
        | US3_0 -> (* None *)
            let v70 : string = "hidden"
            v70
        | US3_1(v71) -> (* Some *)
            v71
    let v73 : (unit -> (JSX.Element [])) = closure19(v0)
    let v74 : US7 = US7_1(v73)
    let v75 : string = "flex"
    let v76 : US3 = US3_1(v75)
    let v77 : string = "1"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "column"
    let v80 : US3 = US3_1(v79)
    let v81 : string = "hidden"
    let v82 : US3 = US3_1(v81)
    let v83 : US3 = US3_1(v72)
    let v84 : ((string * obj) []) = method13(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v74, v16, v17, v18, v19, v20, v21, v76, v23, v24, v78, v80, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v82, v83, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
    let v85 : obj = createObj v84
    let v86 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v87 : string = "createComponent"
    let v88 : string = "solid-js"
    let v89 : JS.Function = import v87 v88
    let v90 : JSX.Element = v89.Invoke (v86, v85) |> unbox<JSX.Element>
    v90
and closure18 () (v0 : Mut3) : JSX.Element =
    method17(v0)
and method19 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@initial`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure26 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure25 (v0 : JSX.Element) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : (unit -> (JSX.Element [])) = closure26(v0)
    let v67 : US7 = US7_1(v66)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v67, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
and closure24 (v0 : Mut5, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US14 = v0.l3
    let v23 : JSX.Element =
        match v4 with
        | US14_0 -> (* CheckDisabled *)
            let v5 : (Mut4 -> JSX.Element) = closure12()
            let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
            let v7 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure25(v3)
            let v8 : Mut4 = {l0 = v2; l1 = v1; l2 = v7} : Mut4
            let v9 : obj = v8
            let v10 : string = "createComponent"
            let v11 : string = "solid-js"
            let v12 : JS.Function = import v10 v11
            let v13 : JSX.Element = v12.Invoke (v6, v9) |> unbox<JSX.Element>
            v13
        | US14_1 -> (* CheckEnabled *)
            let v14 : (Mut4 -> JSX.Element) = closure12()
            let v15 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
            let v16 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure25(v3)
            let v17 : Mut4 = {l0 = v2; l1 = v1; l2 = v16} : Mut4
            let v18 : obj = v17
            let v19 : string = "createComponent"
            let v20 : string = "solid-js"
            let v21 : JS.Function = import v19 v20
            let v22 : JSX.Element = v21.Invoke (v15, v18) |> unbox<JSX.Element>
            v22
        | US14_2 -> (* CheckHidden *)
            v3
    [|v23|]
and closure27 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure30 (v0 : (unit -> bool)) () : (obj []) =
    let v1 : bool = v0 ()
    let v2 : obj = v1
    [|v2|]
and closure31 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure33 (v0 : Mut1, v1 : JS.Function) (v2 : (Mut1 -> (Mut1 -> unit))) : unit =
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
and closure32 (v0 : Mut6, v1 : Mut1, v2 : JS.Function) () : unit =
    let v3 : US13 = v0.l3
    match v3 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v4) -> (* Some *)
        let v5 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v4 v1
        let v6 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure33(v1, v2)
        v5 v6
        ()
and closure37 () () : (JSX.Element []) =
    [||]
and method23 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method22 (v0 : Mut3, v1 : Mut3) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut7 = {l0 = 0} : Mut7
    while method23(v3, v4) do
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
and method21 (v0 : Mut3) : JSX.Element =
    let v1 : US7 = v0.l11
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US7_0 -> (* None *)
            closure37()
        | US7_1(v3) -> (* Some *)
            v3
    let v5 : string = "Button"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US5, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US7, v20 : US3, v21 : US3, v22 : US6, v23 : US8, v24 : US3, v25 : US3, v26 : US3, v27 : US9, v28 : US6, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US10, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US11, v48 : US12, v49 : US11, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method11()
    let struct (v73 : US3, v74 : US3, v75 : US3, v76 : US5, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US6, v84 : US7, v85 : US3, v86 : US3, v87 : US6, v88 : US8, v89 : US3, v90 : US3, v91 : US3, v92 : US9, v93 : US6, v94 : US3, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US10, v100 : US3, v101 : US3, v102 : US3, v103 : US10, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US11, v113 : US12, v114 : US11, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US10, v132 : US3, v133 : US3, v134 : US8, v135 : US3, v136 : US2, v137 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64
    let v138 : Mut3 = {l0 = v73; l1 = v74; l2 = v75; l3 = v76; l4 = v77; l5 = v78; l6 = v79; l7 = v80; l8 = v81; l9 = v82; l10 = v83; l11 = v84; l12 = v85; l13 = v86; l14 = v87; l15 = v88; l16 = v89; l17 = v90; l18 = v91; l19 = v92; l20 = v93; l21 = v94; l22 = v95; l23 = v96; l24 = v97; l25 = v98; l26 = v99; l27 = v100; l28 = v101; l29 = v102; l30 = v103; l31 = v104; l32 = v105; l33 = v106; l34 = v107; l35 = v108; l36 = v109; l37 = v110; l38 = v111; l39 = v112; l40 = v113; l41 = v114; l42 = v115; l43 = v116; l44 = v117; l45 = v118; l46 = v119; l47 = v120; l48 = v121; l49 = v122; l50 = v123; l51 = v124; l52 = v125; l53 = v126; l54 = v127; l55 = v128; l56 = v129; l57 = v130; l58 = v131; l59 = v132; l60 = v133; l61 = v134; l62 = v135; l63 = v136; l64 = v137} : Mut3
    let v139 : string = "neutral"
    let v140 : US3 = US3_1(v139)
    let v141 : US6 = US6_1(true)
    let v142 : string = "left"
    let v143 : US3 = US3_1(v142)
    let v144 : string = "xs"
    let v145 : US3 = US3_1(v144)
    let v146 : Mut3 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v20; l13 = v140; l14 = v141; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v143; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v145; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70; l63 = v71; l64 = v72} : Mut3
    method22(v146, v138)
    let struct (v147 : US3, v148 : US3, v149 : US3, v150 : US5, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US3, v156 : US3, v157 : US6, v158 : US7, v159 : US3, v160 : US3, v161 : US6, v162 : US8, v163 : US3, v164 : US3, v165 : US3, v166 : US9, v167 : US6, v168 : US3, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US10, v174 : US3, v175 : US3, v176 : US3, v177 : US10, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US11, v187 : US12, v188 : US11, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US10, v206 : US3, v207 : US3, v208 : US8, v209 : US3, v210 : US2, v211 : US3) = v146.l0, v146.l1, v146.l2, v146.l3, v146.l4, v146.l5, v146.l6, v146.l7, v146.l8, v146.l9, v146.l10, v146.l11, v146.l12, v146.l13, v146.l14, v146.l15, v146.l16, v146.l17, v146.l18, v146.l19, v146.l20, v146.l21, v146.l22, v146.l23, v146.l24, v146.l25, v146.l26, v146.l27, v146.l28, v146.l29, v146.l30, v146.l31, v146.l32, v146.l33, v146.l34, v146.l35, v146.l36, v146.l37, v146.l38, v146.l39, v146.l40, v146.l41, v146.l42, v146.l43, v146.l44, v146.l45, v146.l46, v146.l47, v146.l48, v146.l49, v146.l50, v146.l51, v146.l52, v146.l53, v146.l54, v146.l55, v146.l56, v146.l57, v146.l58, v146.l59, v146.l60, v146.l61, v146.l62, v146.l63, v146.l64
    let v212 : US7 = US7_1(v4)
    let v213 : ((string * obj) []) = method13(v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v212, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211)
    let v214 : obj = createObj v213
    let v215 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v216 : string = "createComponent"
    let v217 : string = "solid-js"
    let v218 : JS.Function = import v216 v217
    let v219 : JSX.Element = v218.Invoke (v215, v214) |> unbox<JSX.Element>
    v219
and closure36 () (v0 : Mut3) : JSX.Element =
    method21(v0)
and closure38 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure39 (v0 : (bool -> unit), v1 : Mut6, v2 : Mut1, v3 : JS.Function) () : unit =
    let v4 : US13 = v1.l2
    match v4 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v5) -> (* Some *)
        let v6 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v5 v2
        let v7 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure33(v2, v3)
        v6 v7
        ()
    v0 true
    ()
and closure35 (v0 : (bool -> unit), v1 : Mut6, v2 : Mut1, v3 : JS.Function) () : (JSX.Element []) =
    let v4 : (Mut3 -> JSX.Element) = closure36()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let struct (v6 : US3, v7 : US3, v8 : US3, v9 : US5, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US6, v17 : US7, v18 : US3, v19 : US3, v20 : US6, v21 : US8, v22 : US3, v23 : US3, v24 : US3, v25 : US9, v26 : US6, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US11, v46 : US12, v47 : US11, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method11()
    let v71 : (unit -> (JSX.Element [])) = closure38()
    let v72 : US7 = US7_1(v71)
    let v73 : (unit -> unit) = closure39(v0, v1, v2, v3)
    let v74 : US12 = US12_1(v73)
    let v75 : Mut3 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9; l4 = v10; l5 = v11; l6 = v12; l7 = v13; l8 = v14; l9 = v15; l10 = v16; l11 = v72; l12 = v18; l13 = v19; l14 = v20; l15 = v21; l16 = v22; l17 = v23; l18 = v24; l19 = v25; l20 = v26; l21 = v27; l22 = v28; l23 = v29; l24 = v30; l25 = v31; l26 = v32; l27 = v33; l28 = v34; l29 = v35; l30 = v36; l31 = v37; l32 = v38; l33 = v39; l34 = v40; l35 = v41; l36 = v42; l37 = v43; l38 = v44; l39 = v45; l40 = v74; l41 = v47; l42 = v48; l43 = v49; l44 = v50; l45 = v51; l46 = v52; l47 = v53; l48 = v54; l49 = v55; l50 = v56; l51 = v57; l52 = v58; l53 = v59; l54 = v60; l55 = v61; l56 = v62; l57 = v63; l58 = v64; l59 = v65; l60 = v66; l61 = v67; l62 = v68; l63 = v69; l64 = v70} : Mut3
    emitJsExpr (v75, v71) "$0.children = $1"
    let v76 : obj = v75
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v5, v76) |> unbox<JSX.Element>
    [|v80|]
and closure44 () () : (JSX.Element []) =
    [||]
and method24 (v0 : Mut8) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) = method11()
    let v69 : (unit -> JS.Function) = v0.l1
    let v70 : JS.Function = v69 ()
    let struct (v71 : US3, v72 : US3, v73 : US3, v74 : US5, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US6, v82 : US7, v83 : US3, v84 : US3, v85 : US6, v86 : US8, v87 : US3, v88 : US3, v89 : US3, v90 : US9, v91 : US6, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US10, v98 : US3, v99 : US3, v100 : US3, v101 : US10, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US11, v111 : US12, v112 : US11, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US10, v130 : US3, v131 : US3, v132 : US8, v133 : US3, v134 : US2, v135 : US3) = method11()
    let v136 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l0
    let v137 : string = "-12px"
    let v138 : US3 = US3_1(v137)
    let v139 : US3 = US3_1(v137)
    let v140 : string = "0.6"
    let v141 : US3 = US3_1(v140)
    let struct (v142 : US3, v143 : US3, v144 : US3, v145 : US5, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US6, v153 : US7, v154 : US3, v155 : US3, v156 : US6, v157 : US8, v158 : US3, v159 : US3, v160 : US3, v161 : US9, v162 : US6, v163 : US3, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US10, v169 : US3, v170 : US3, v171 : US3, v172 : US10, v173 : US3, v174 : US3, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US11, v182 : US12, v183 : US11, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US10, v201 : US3, v202 : US3, v203 : US8, v204 : US3, v205 : US2, v206 : US3) = v136 struct (v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v138, v106, v139, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v141)
    let v207 : ((string * obj) []) = method13(v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206)
    let v208 : obj = createObj v207
    let v209 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l2
    let v210 : US5 = US5_1(v70)
    let v211 : US8 = US8_1(v208)
    let v212 : string = "14px"
    let v213 : US3 = US3_1(v212)
    let struct (v214 : US3, v215 : US3, v216 : US3, v217 : US5, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US6, v225 : US7, v226 : US3, v227 : US3, v228 : US6, v229 : US8, v230 : US3, v231 : US3, v232 : US3, v233 : US9, v234 : US6, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US10, v241 : US3, v242 : US3, v243 : US3, v244 : US10, v245 : US3, v246 : US3, v247 : US3, v248 : US3, v249 : US3, v250 : US3, v251 : US3, v252 : US3, v253 : US11, v254 : US12, v255 : US11, v256 : US3, v257 : US3, v258 : US3, v259 : US3, v260 : US3, v261 : US3, v262 : US3, v263 : US3, v264 : US3, v265 : US3, v266 : US3, v267 : US3, v268 : US3, v269 : US3, v270 : US3, v271 : US3, v272 : US10, v273 : US3, v274 : US3, v275 : US8, v276 : US3, v277 : US2, v278 : US3) = v209 struct (v4, v5, v6, v210, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v211, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v213, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
    let v279 : (unit -> (JSX.Element [])) = closure44()
    let v280 : US7 = US7_1(v279)
    let v281 : ((string * obj) []) = method13(v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v280, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v273, v274, v275, v276, v277, v278)
    let v282 : obj = createObj v281
    let v283 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v284 : string = "createComponent"
    let v285 : string = "solid-js"
    let v286 : JS.Function = import v284 v285
    let v287 : JSX.Element = v286.Invoke (v283, v282) |> unbox<JSX.Element>
    v287
and closure43 () (v0 : Mut8) : JSX.Element =
    method24(v0)
and closure45 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure46 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure47 () () : (JSX.Element []) =
    [||]
and closure48 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure49 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure50 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure51 () () : (JSX.Element []) =
    [||]
and closure52 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (unit -> bool)) () : unit =
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
and closure53 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure54 () () : (JSX.Element []) =
    [||]
and closure55 (v0 : (bool -> unit), v1 : Mut6, v2 : Mut1, v3 : JS.Function) () : unit =
    let v4 : string = "# on_click"
    printfn $"%A{v4}"
    let v5 : US13 = v1.l3
    match v5 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v6) -> (* Some *)
        let v7 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v6 v2
        let v8 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure33(v2, v3)
        v7 v8
        ()
    v0 false
    ()
and closure42 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool), v7 : Mut6) () : (JSX.Element []) =
    let v8 : string = "IconButton"
    let v9 : string = "@hope-ui/solid"
    let v10 : JS.Function = import v8 v9
    let struct (v11 : US3, v12 : US3, v13 : US3, v14 : US5, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US7, v23 : US3, v24 : US3, v25 : US6, v26 : US8, v27 : US3, v28 : US3, v29 : US3, v30 : US9, v31 : US6, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US10, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US11, v51 : US12, v52 : US11, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US10, v70 : US3, v71 : US3, v72 : US8, v73 : US3, v74 : US2, v75 : US3) = method11()
    let v76 : (Mut8 -> JSX.Element) = closure43()
    let v77 : (obj -> JSX.Element) = v76 |> unbox<obj -> JSX.Element>
    let v78 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure45()
    let v79 : (unit -> JS.Function) = closure46()
    let v80 : Mut8 = {l0 = v78; l1 = v79; l2 = v78} : Mut8
    let v81 : obj = v80
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : JSX.Element = v84.Invoke (v77, v81) |> unbox<JSX.Element>
    let v86 : string = "Refresh"
    let v87 : US3 = US3_1(v86)
    let v88 : (unit -> (JSX.Element [])) = closure47()
    let v89 : US7 = US7_1(v88)
    let v90 : string = "neutral"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "20px"
    let v93 : US3 = US3_1(v92)
    let v94 : US10 = US10_1(v85)
    let v95 : (unit -> unit) = closure48(v4)
    let v96 : US12 = US12_1(v95)
    let v97 : string = "xs"
    let v98 : US3 = US3_1(v97)
    let v99 : ((string * obj) []) = method13(v11, v12, v87, v14, v15, v16, v17, v18, v19, v20, v21, v89, v23, v91, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v93, v36, v94, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v96, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v98, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v100 : obj = createObj v99
    let v101 : (obj -> JSX.Element) = v10 |> unbox<obj -> JSX.Element>
    let v102 : JS.Function = import v82 v83
    let v103 : JSX.Element = v102.Invoke (v101, v100) |> unbox<JSX.Element>
    let v104 : JS.Function = import v8 v9
    let struct (v105 : US3, v106 : US3, v107 : US3, v108 : US5, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US6, v116 : US7, v117 : US3, v118 : US3, v119 : US6, v120 : US8, v121 : US3, v122 : US3, v123 : US3, v124 : US9, v125 : US6, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US10, v132 : US3, v133 : US3, v134 : US3, v135 : US10, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US3, v144 : US11, v145 : US12, v146 : US11, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US3, v156 : US3, v157 : US3, v158 : US3, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US10, v164 : US3, v165 : US3, v166 : US8, v167 : US3, v168 : US2, v169 : US3) = method11()
    let v170 : bool = v6 ()
    let v173 : string =
        if v170 then
            let v171 : string = "Restore"
            v171
        else
            let v172 : string = "Maximize"
            v172
    let v174 : bool = v6 ()
    let v177 : (unit -> JS.Function) =
        if v174 then
            closure49()
        else
            closure50()
    let v178 : (obj -> JSX.Element) = v76 |> unbox<obj -> JSX.Element>
    let v179 : Mut8 = {l0 = v78; l1 = v177; l2 = v78} : Mut8
    let v180 : obj = v179
    let v181 : JS.Function = import v82 v83
    let v182 : JSX.Element = v181.Invoke (v178, v180) |> unbox<JSX.Element>
    let v183 : US3 = US3_1(v173)
    let v184 : (unit -> (JSX.Element [])) = closure51()
    let v185 : US7 = US7_1(v184)
    let v186 : US3 = US3_1(v90)
    let v187 : US3 = US3_1(v92)
    let v188 : US10 = US10_1(v182)
    let v189 : (unit -> unit) = closure52(v0, v1, v2, v5, v6)
    let v190 : US12 = US12_1(v189)
    let v191 : US3 = US3_1(v97)
    let v192 : ((string * obj) []) = method13(v105, v106, v183, v108, v109, v110, v111, v112, v113, v114, v115, v185, v117, v186, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v187, v130, v188, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v190, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v191, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169)
    let v193 : obj = createObj v192
    let v194 : (obj -> JSX.Element) = v104 |> unbox<obj -> JSX.Element>
    let v195 : JS.Function = import v82 v83
    let v196 : JSX.Element = v195.Invoke (v194, v193) |> unbox<JSX.Element>
    let v197 : JS.Function = import v8 v9
    let struct (v198 : US3, v199 : US3, v200 : US3, v201 : US5, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US6, v209 : US7, v210 : US3, v211 : US3, v212 : US6, v213 : US8, v214 : US3, v215 : US3, v216 : US3, v217 : US9, v218 : US6, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US10, v225 : US3, v226 : US3, v227 : US3, v228 : US10, v229 : US3, v230 : US3, v231 : US3, v232 : US3, v233 : US3, v234 : US3, v235 : US3, v236 : US3, v237 : US11, v238 : US12, v239 : US11, v240 : US3, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US3, v247 : US3, v248 : US3, v249 : US3, v250 : US3, v251 : US3, v252 : US3, v253 : US3, v254 : US3, v255 : US3, v256 : US10, v257 : US3, v258 : US3, v259 : US8, v260 : US3, v261 : US2, v262 : US3) = method11()
    let v263 : (obj -> JSX.Element) = v76 |> unbox<obj -> JSX.Element>
    let v264 : (unit -> JS.Function) = closure53()
    let v265 : Mut8 = {l0 = v78; l1 = v264; l2 = v78} : Mut8
    let v266 : obj = v265
    let v267 : JS.Function = import v82 v83
    let v268 : JSX.Element = v267.Invoke (v263, v266) |> unbox<JSX.Element>
    let v269 : string = "Unload"
    let v270 : US3 = US3_1(v269)
    let v271 : (unit -> (JSX.Element [])) = closure54()
    let v272 : US7 = US7_1(v271)
    let v273 : US3 = US3_1(v90)
    let v274 : US3 = US3_1(v92)
    let v275 : US10 = US10_1(v268)
    let v276 : (unit -> unit) = closure55(v3, v7, v0, v1)
    let v277 : US12 = US12_1(v276)
    let v278 : US3 = US3_1(v97)
    let v279 : ((string * obj) []) = method13(v198, v199, v270, v201, v202, v203, v204, v205, v206, v207, v208, v272, v210, v273, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v274, v223, v275, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v277, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v278, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262)
    let v280 : obj = createObj v279
    let v281 : (obj -> JSX.Element) = v197 |> unbox<obj -> JSX.Element>
    let v282 : JS.Function = import v82 v83
    let v283 : JSX.Element = v282.Invoke (v281, v280) |> unbox<JSX.Element>
    [|v103; v196; v283|]
and closure41 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : Mut6, v9 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v10 : string = "Stack"
    let v11 : string = "@hope-ui/solid"
    let v12 : JS.Function = import v10 v11
    let struct (v13 : US3, v14 : US3, v15 : US3, v16 : US5, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US6, v24 : US7, v25 : US3, v26 : US3, v27 : US6, v28 : US8, v29 : US3, v30 : US3, v31 : US3, v32 : US9, v33 : US6, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US10, v40 : US3, v41 : US3, v42 : US3, v43 : US10, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US11, v53 : US12, v54 : US11, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US10, v72 : US3, v73 : US3, v74 : US8, v75 : US3, v76 : US2, v77 : US3) = method11()
    let v78 : US2 = v0.l9
    let v87 : US3 =
        match v78 with
        | US2_0 -> (* None *)
            US3_0
        | US2_1(v80) -> (* Some *)
            let v81 : bool = v80 = v2
            let v82 : bool = v81 <> true
            if v82 then
                let v83 : string = "none"
                US3_1(v83)
            else
                US3_0
    let v88 : (unit -> (JSX.Element [])) = closure42(v0, v1, v2, v3, v4, v6, v7, v8)
    let v89 : US7 = US7_1(v88)
    let v90 : string = "row"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "absolute"
    let v93 : US3 = US3_1(v92)
    let v94 : string = "6px"
    let v95 : US3 = US3_1(v94)
    let v96 : string = "3px"
    let v97 : US3 = US3_1(v96)
    let v98 : US3 = US3_1(v94)
    let v99 : int32 = 2
    let v100 : US2 = US2_1(v99)
    let v101 : ((string * obj) []) = method13(v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v89, v25, v26, v27, v28, v29, v91, v87, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v93, v95, v66, v97, v68, v69, v70, v71, v98, v73, v74, v75, v100, v77)
    let v102 : obj = createObj v101
    let v103 : (obj -> JSX.Element) = v12 |> unbox<obj -> JSX.Element>
    let v104 : string = "createComponent"
    let v105 : string = "solid-js"
    let v106 : JS.Function = import v104 v105
    let v107 : JSX.Element = v106.Invoke (v103, v102) |> unbox<JSX.Element>
    let v108 : bool = v5 ()
    let v111 : JSX.Element =
        if v108 then
            let v109 : JSX.Element = Html.fragment []
            v109
        else
            let v110 : JSX.Element = v9 |> unbox<JSX.Element>
            v110
    [|v107; v111|]
and closure40 (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3, v65 : Mut1, v66 : JS.Function, v67 : int32, v68 : (bool -> unit), v69 : (bool -> unit), v70 : (unit -> bool), v71 : (bool -> unit), v72 : (unit -> bool), v73 : Mut6) () : (JSX.Element []) =
    let v164 : JSX.Element =
        match v11 with
        | US7_0 -> (* None *)
            let v74 : JSX.Element = Html.fragment []
            v74
        | US7_1(v75) -> (* Some *)
            let v76 : string = "Box"
            let v77 : string = "@hope-ui/solid"
            let v78 : JS.Function = import v76 v77
            let struct (v79 : US3, v80 : US3, v81 : US3, v82 : US5, v83 : US3, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US6, v90 : US7, v91 : US3, v92 : US3, v93 : US6, v94 : US8, v95 : US3, v96 : US3, v97 : US3, v98 : US9, v99 : US6, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US10, v106 : US3, v107 : US3, v108 : US3, v109 : US10, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US11, v119 : US12, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US10, v138 : US3, v139 : US3, v140 : US8, v141 : US3, v142 : US2, v143 : US3) = method11()
            let v144 : US2 = v65.l9
            let v146 : bool =
                match v144 with
                | US2_0 -> (* None *)
                    true
                | _ ->
                    false
            let v150 : US3 =
                if v146 then
                    let v147 : string = "relative"
                    US3_1(v147)
                else
                    US3_0
            let v151 : (unit -> (JSX.Element [])) = closure41(v65, v66, v67, v68, v69, v70, v71, v72, v73, v75)
            let v152 : US7 = US7_1(v151)
            let v153 : string = "flex"
            let v154 : US3 = US3_1(v153)
            let v155 : string = "1"
            let v156 : US3 = US3_1(v155)
            let v157 : ((string * obj) []) = method13(v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v152, v91, v92, v93, v94, v95, v96, v154, v98, v99, v156, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v150, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143)
            let v158 : obj = createObj v157
            let v159 : (obj -> JSX.Element) = v78 |> unbox<obj -> JSX.Element>
            let v160 : string = "createComponent"
            let v161 : string = "solid-js"
            let v162 : JS.Function = import v160 v161
            let v163 : JSX.Element = v162.Invoke (v159, v158) |> unbox<JSX.Element>
            v163
    [|v164|]
and closure34 (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3, v65 : Mut1, v66 : JS.Function, v67 : int32, v68 : (bool -> unit), v69 : (unit -> bool), v70 : (bool -> unit), v71 : (unit -> bool), v72 : (bool -> unit), v73 : (unit -> bool), v74 : Mut6) () : (JSX.Element []) =
    let v75 : bool = v69 ()
    let v76 : bool = v75 = false
    let v271 : JSX.Element =
        if v76 then
            let v77 : string = "Box"
            let v78 : string = "@hope-ui/solid"
            let v79 : JS.Function = import v77 v78
            let struct (v80 : US3, v81 : US3, v82 : US3, v83 : US5, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US6, v91 : US7, v92 : US3, v93 : US3, v94 : US6, v95 : US8, v96 : US3, v97 : US3, v98 : US3, v99 : US9, v100 : US6, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US10, v107 : US3, v108 : US3, v109 : US3, v110 : US10, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US11, v120 : US12, v121 : US11, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US10, v139 : US3, v140 : US3, v141 : US8, v142 : US3, v143 : US2, v144 : US3) = method11()
            let v145 : (unit -> (JSX.Element [])) = closure35(v68, v74, v65, v66)
            let v146 : US7 = US7_1(v145)
            let v147 : string = "3px 0"
            let v148 : US3 = US3_1(v147)
            let v149 : ((string * obj) []) = method13(v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v146, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v148, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144)
            let v150 : obj = createObj v149
            let v151 : (obj -> JSX.Element) = v79 |> unbox<obj -> JSX.Element>
            let v152 : string = "createComponent"
            let v153 : string = "solid-js"
            let v154 : JS.Function = import v152 v153
            let v155 : JSX.Element = v154.Invoke (v151, v150) |> unbox<JSX.Element>
            v155
        else
            let v156 : string = "Box"
            let v157 : string = "@hope-ui/solid"
            let v158 : JS.Function = import v156 v157
            let struct (v159 : US3, v160 : US3, v161 : US3, v162 : US5, v163 : US3, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US6, v170 : US7, v171 : US3, v172 : US3, v173 : US6, v174 : US8, v175 : US3, v176 : US3, v177 : US3, v178 : US9, v179 : US6, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US10, v186 : US3, v187 : US3, v188 : US3, v189 : US10, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US11, v199 : US12, v200 : US11, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US10, v218 : US3, v219 : US3, v220 : US8, v221 : US3, v222 : US2, v223 : US3) = method11()
            let v224 : bool = v73 ()
            let v227 : US2 =
                if v224 then
                    US2_1(1)
                else
                    US2_0
            let v228 : bool = v73 ()
            let v232 : US3 =
                if v228 then
                    let v229 : string = "absolute"
                    US3_1(v229)
                else
                    US3_0
            let v233 : bool = v73 ()
            let v237 : US3 =
                if v233 then
                    let v234 : string = "0"
                    US3_1(v234)
                else
                    US3_0
            let v238 : bool = v73 ()
            let v242 : US3 =
                if v238 then
                    let v239 : string = "0"
                    US3_1(v239)
                else
                    US3_0
            let v243 : bool = v73 ()
            let v247 : US3 =
                if v243 then
                    let v244 : string = "0"
                    US3_1(v244)
                else
                    US3_0
            let v248 : bool = v73 ()
            let v252 : US3 =
                if v248 then
                    let v249 : string = "0"
                    US3_1(v249)
                else
                    US3_0
            let v253 : bool = v73 ()
            let v257 : US3 =
                if v253 then
                    let v254 : string = "$bg"
                    US3_1(v254)
                else
                    US3_0
            let v258 : (unit -> (JSX.Element [])) = closure40(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v70, v71, v72, v73, v74)
            let v259 : US7 = US7_1(v258)
            let v260 : string = "flex"
            let v261 : US3 = US3_1(v260)
            let v262 : string = "1"
            let v263 : US3 = US3_1(v262)
            let v264 : ((string * obj) []) = method13(v159, v160, v161, v162, v257, v164, v165, v166, v167, v247, v169, v259, v171, v172, v173, v174, v175, v176, v261, v178, v179, v263, v181, v182, v183, v184, v185, v186, v187, v252, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v232, v242, v212, v213, v214, v215, v216, v217, v237, v219, v220, v221, v227, v223)
            let v265 : obj = createObj v264
            let v266 : (obj -> JSX.Element) = v158 |> unbox<obj -> JSX.Element>
            let v267 : string = "createComponent"
            let v268 : string = "solid-js"
            let v269 : JS.Function = import v267 v268
            let v270 : JSX.Element = v269.Invoke (v266, v265) |> unbox<JSX.Element>
            v270
    [|v271|]
and method20 (v0 : Mut6) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l4
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let struct (v67 : US3, v68 : US3, v69 : US3, v70 : US5, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US7, v79 : US3, v80 : US3, v81 : US6, v82 : US8, v83 : US3, v84 : US3, v85 : US3, v86 : US9, v87 : US6, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US3, v95 : US3, v96 : US3, v97 : US10, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US11, v107 : US12, v108 : US11, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US10, v126 : US3, v127 : US3, v128 : US8, v129 : US3, v130 : US2, v131 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v132 : string = "useStoreon"
    let v133 : string = "@storeon/solidjs"
    let v134 : JS.Function = import v132 v133
    let v135 : (JS.Function []) = v134.Invoke () |> unbox<JS.Function[]>
    let v136 : Mut1 = v135.[0] |> unbox
    let v137 : JS.Function = v135.[1] |> unbox
    let v138 : int32 = Random().Next ()
    let v139 : bool = v0.l0
    let v140 : string = "createSignal"
    let v141 : string = "solid-js"
    let v142 : JS.Function = import v140 v141
    let v143 : (JS.Function []) = v142.Invoke v139 |> unbox<JS.Function[]>
    let v144 : (unit -> bool) = v143.[0] |> unbox
    let v145 : (bool -> unit) = v143.[1] |> unbox
    let v146 : JS.Function = import v140 v141
    let v147 : (JS.Function []) = v146.Invoke false |> unbox<JS.Function[]>
    let v148 : (unit -> bool) = v147.[0] |> unbox
    let v149 : (bool -> unit) = v147.[1] |> unbox
    let v150 : bool = v0.l1
    let v151 : JS.Function = import v140 v141
    let v152 : (JS.Function []) = v151.Invoke v150 |> unbox<JS.Function[]>
    let v153 : (unit -> bool) = v152.[0] |> unbox
    let v154 : (bool -> unit) = v152.[1] |> unbox
    let v155 : string = "on"
    let v156 : JS.Function = import v155 v141
    let v157 : (unit -> (obj [])) = closure30(v148)
    let v158 : (unit -> unit) = closure31(v149, v148)
    let v159 : JS.Function = v156.Invoke (v157, v158) |> unbox<JS.Function>
    let v160 : string = "createEffect"
    let v161 : JS.Function = import v160 v141
    v161.Invoke v159 |> ignore
    let v162 : string = "onCleanup"
    let v163 : JS.Function = import v162 v141
    let v164 : (unit -> unit) = closure32(v0, v136, v137)
    v163.Invoke v164 |> ignore
    let v165 : bool = v0.l0
    let v166 : bool = v165 = true
    if v166 then
        let v167 : US13 = v0.l2
        match v167 with
        | US13_0 -> (* None *)
            ()
        | US13_1(v168) -> (* Some *)
            let v169 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v168 v136
            let v170 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure33(v136, v137)
            v169 v170
            ()
    let v171 : string = "Box"
    let v172 : string = "@hope-ui/solid"
    let v173 : JS.Function = import v171 v172
    let struct (v174 : US3, v175 : US3, v176 : US3, v177 : US5, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US6, v185 : US7, v186 : US3, v187 : US3, v188 : US6, v189 : US8, v190 : US3, v191 : US3, v192 : US3, v193 : US9, v194 : US6, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US10, v201 : US3, v202 : US3, v203 : US3, v204 : US10, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US11, v214 : US12, v215 : US11, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US3, v231 : US3, v232 : US10, v233 : US3, v234 : US3, v235 : US8, v236 : US3, v237 : US2, v238 : US3) = method11()
    let v239 : (unit -> (JSX.Element [])) = closure34(v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v136, v137, v138, v145, v144, v149, v148, v154, v153, v0)
    let v240 : US7 = US7_1(v239)
    let v241 : string = "flex"
    let v242 : US3 = US3_1(v241)
    let v243 : string = "1"
    let v244 : US3 = US3_1(v243)
    let v245 : ((string * obj) []) = method13(v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v240, v186, v187, v188, v189, v190, v191, v242, v193, v194, v244, v196, v197, v198, v199, v200, v94, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238)
    let v246 : obj = createObj v245
    let v247 : (obj -> JSX.Element) = v173 |> unbox<obj -> JSX.Element>
    let v248 : string = "createComponent"
    let v249 : JS.Function = import v248 v141
    let v250 : JSX.Element = v249.Invoke (v247, v246) |> unbox<JSX.Element>
    v250
and closure29 () (v0 : Mut6) : JSX.Element =
    method20(v0)
and closure56 (v0 : (unit -> (JSX.Element []))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : US7 = US7_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v66, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
and closure28 (v0 : Mut5, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US14 = v0.l3
    let v33 : JSX.Element =
        match v3 with
        | US14_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : US13 = v0.l0
                let v6 : US13 = v0.l1
                let v7 : (Mut6 -> JSX.Element) = closure29()
                let v8 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
                let v9 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure56(v2)
                let v10 : Mut6 = {l0 = true; l1 = false; l2 = v5; l3 = v6; l4 = v9} : Mut6
                let v11 : obj = v10
                let v12 : string = "createComponent"
                let v13 : string = "solid-js"
                let v14 : JS.Function = import v12 v13
                let v15 : JSX.Element = v14.Invoke (v8, v11) |> unbox<JSX.Element>
                v15
            else
                let v16 : JSX.Element = Html.fragment []
                v16
        | US14_1 -> (* CheckEnabled *)
            let v18 : bool = v1 ()
            if v18 then
                let v19 : US13 = v0.l0
                let v20 : US13 = v0.l1
                let v21 : (Mut6 -> JSX.Element) = closure29()
                let v22 : (obj -> JSX.Element) = v21 |> unbox<obj -> JSX.Element>
                let v23 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure56(v2)
                let v24 : Mut6 = {l0 = true; l1 = false; l2 = v19; l3 = v20; l4 = v23} : Mut6
                let v25 : obj = v24
                let v26 : string = "createComponent"
                let v27 : string = "solid-js"
                let v28 : JS.Function = import v26 v27
                let v29 : JSX.Element = v28.Invoke (v22, v25) |> unbox<JSX.Element>
                v29
            else
                let v30 : JSX.Element = Html.fragment []
                v30
        | US14_2 -> (* CheckHidden *)
            let v32 : JSX.Element = v2 |> unbox<JSX.Element>
            v32
    [|v33|]
and closure23 (v0 : Mut5, v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3, v66 : (bool -> unit), v67 : (unit -> bool)) () : (JSX.Element []) =
    let v170 : JSX.Element =
        match v59 with
        | US10_0 -> (* None *)
            let v68 : JSX.Element = Html.fragment []
            v68
        | US10_1(v69) -> (* Some *)
            let v70 : string = "Td"
            let v71 : string = "@hope-ui/solid"
            let v72 : JS.Function = import v70 v71
            let struct (v73 : US3, v74 : US3, v75 : US3, v76 : US5, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US6, v84 : US7, v85 : US3, v86 : US3, v87 : US6, v88 : US8, v89 : US3, v90 : US3, v91 : US3, v92 : US9, v93 : US6, v94 : US3, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US10, v100 : US3, v101 : US3, v102 : US3, v103 : US10, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US11, v113 : US12, v114 : US11, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US10, v132 : US3, v133 : US3, v134 : US8, v135 : US3, v136 : US2, v137 : US3) = method11()
            let v138 : US14 = v0.l3
            let v140 : bool =
                match v138 with
                | US14_2 -> (* CheckHidden *)
                    true
                | _ ->
                    false
            let v142 : bool =
                if v140 then
                    true
                else
                    let v141 : bool = v67 ()
                    v141
            let v147 : string =
                if v142 then
                    let v143 : string = "2px !important"
                    let v144 : string = "0px !important"
                    method19(v144, v143)
                else
                    let v146 : string = "0px !important"
                    v146
            let v148 : US3 = US3_1(v147)
            let v149 : string = "$neutral5"
            let v150 : US3 = US3_1(v149)
            let v151 : (unit -> (JSX.Element [])) = closure24(v0, v66, v67, v69)
            let v152 : US7 = US7_1(v151)
            let v153 : string = "$neutral9"
            let v154 : US3 = US3_1(v153)
            let v155 : string = "flex"
            let v156 : US3 = US3_1(v155)
            let v157 : string = "column"
            let v158 : US3 = US3_1(v157)
            let v159 : string = "$sm"
            let v160 : US3 = US3_1(v159)
            let v161 : string = "3px 20px 0 8px"
            let v162 : US3 = US3_1(v161)
            let v163 : ((string * obj) []) = method13(v73, v74, v75, v76, v77, v78, v148, v150, v81, v82, v83, v152, v154, v86, v87, v88, v89, v90, v156, v92, v93, v94, v158, v160, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v162, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
            let v164 : obj = createObj v163
            let v165 : (obj -> JSX.Element) = v72 |> unbox<obj -> JSX.Element>
            let v166 : string = "createComponent"
            let v167 : string = "solid-js"
            let v168 : JS.Function = import v166 v167
            let v169 : JSX.Element = v168.Invoke (v165, v164) |> unbox<JSX.Element>
            v169
    let v353 : JSX.Element =
        match v12 with
        | US7_0 -> (* None *)
            let v171 : string = "Td"
            let v172 : string = "@hope-ui/solid"
            let v173 : JS.Function = import v171 v172
            let struct (v174 : US3, v175 : US3, v176 : US3, v177 : US5, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US6, v185 : US7, v186 : US3, v187 : US3, v188 : US6, v189 : US8, v190 : US3, v191 : US3, v192 : US3, v193 : US9, v194 : US6, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US10, v201 : US3, v202 : US3, v203 : US3, v204 : US10, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US11, v214 : US12, v215 : US11, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US3, v231 : US3, v232 : US10, v233 : US3, v234 : US3, v235 : US8, v236 : US3, v237 : US2, v238 : US3) = method11()
            let v239 : string = "0"
            let v240 : US3 = US3_1(v239)
            let v241 : (unit -> (JSX.Element [])) = closure27()
            let v242 : US7 = US7_1(v241)
            let v243 : string = "9px"
            let v244 : US3 = US3_1(v243)
            let v245 : US3 = US3_1(v239)
            let v246 : ((string * obj) []) = method13(v174, v175, v176, v177, v178, v240, v180, v181, v182, v183, v184, v242, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v244, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v245, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238)
            let v247 : obj = createObj v246
            let v248 : (obj -> JSX.Element) = v173 |> unbox<obj -> JSX.Element>
            let v249 : string = "createComponent"
            let v250 : string = "solid-js"
            let v251 : JS.Function = import v249 v250
            let v252 : JSX.Element = v251.Invoke (v248, v247) |> unbox<JSX.Element>
            v252
        | US7_1(v253) -> (* Some *)
            let v254 : string = "Td"
            let v255 : string = "@hope-ui/solid"
            let v256 : JS.Function = import v254 v255
            let struct (v257 : US3, v258 : US3, v259 : US3, v260 : US5, v261 : US3, v262 : US3, v263 : US3, v264 : US3, v265 : US3, v266 : US3, v267 : US6, v268 : US7, v269 : US3, v270 : US3, v271 : US6, v272 : US8, v273 : US3, v274 : US3, v275 : US3, v276 : US9, v277 : US6, v278 : US3, v279 : US3, v280 : US3, v281 : US3, v282 : US3, v283 : US10, v284 : US3, v285 : US3, v286 : US3, v287 : US10, v288 : US3, v289 : US3, v290 : US3, v291 : US3, v292 : US3, v293 : US3, v294 : US3, v295 : US3, v296 : US11, v297 : US12, v298 : US11, v299 : US3, v300 : US3, v301 : US3, v302 : US3, v303 : US3, v304 : US3, v305 : US3, v306 : US3, v307 : US3, v308 : US3, v309 : US3, v310 : US3, v311 : US3, v312 : US3, v313 : US3, v314 : US3, v315 : US10, v316 : US3, v317 : US3, v318 : US8, v319 : US3, v320 : US2, v321 : US3) = method11()
            let v324 : string =
                match v47 with
                | US3_0 -> (* None *)
                    let v322 : string = "0"
                    v322
                | US3_1(v323) -> (* Some *)
                    v323
            let v325 : string = "0"
            let v326 : US3 = US3_1(v325)
            let v327 : (unit -> (JSX.Element [])) = closure28(v0, v67, v253)
            let v328 : US7 = US7_1(v327)
            let v329 : string = "flex"
            let v330 : US3 = US3_1(v329)
            let v331 : string = "6"
            let v332 : US3 = US3_1(v331)
            let v333 : string = "column"
            let v334 : US3 = US3_1(v333)
            let v335 : string = "$sm"
            let v336 : US3 = US3_1(v335)
            let v337 : string = "$base"
            let v338 : US3 = US3_1(v337)
            let v339 : US3 = US3_1(v325)
            let v340 : string = "85vh"
            let v341 : US3 = US3_1(v340)
            let v342 : US3 = US3_1(v325)
            let v343 : string = "auto"
            let v344 : US3 = US3_1(v343)
            let v345 : US3 = US3_1(v324)
            let v346 : ((string * obj) []) = method13(v257, v258, v259, v260, v261, v326, v263, v264, v265, v266, v267, v328, v269, v270, v271, v272, v273, v274, v330, v276, v277, v332, v334, v336, v281, v282, v283, v284, v285, v286, v287, v338, v339, v290, v291, v292, v293, v341, v295, v296, v297, v298, v342, v300, v301, v344, v345, v304, v305, v306, v307, v308, v309, v310, v311, v312, v313, v314, v315, v316, v317, v318, v319, v320, v321)
            let v347 : obj = createObj v346
            let v348 : (obj -> JSX.Element) = v256 |> unbox<obj -> JSX.Element>
            let v349 : string = "createComponent"
            let v350 : string = "solid-js"
            let v351 : JS.Function = import v349 v350
            let v352 : JSX.Element = v351.Invoke (v348, v347) |> unbox<JSX.Element>
            v352
    [|v170; v353|]
and method18 (v0 : Mut5) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l2
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let struct (v67 : US3, v68 : US3, v69 : US3, v70 : US5, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US7, v79 : US3, v80 : US3, v81 : US6, v82 : US8, v83 : US3, v84 : US3, v85 : US3, v86 : US9, v87 : US6, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US3, v95 : US3, v96 : US3, v97 : US10, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US11, v107 : US12, v108 : US11, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US10, v126 : US3, v127 : US3, v128 : US8, v129 : US3, v130 : US2, v131 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v132 : US14 = v0.l3
    let v134 : bool =
        match v132 with
        | US14_0 -> (* CheckDisabled *)
            true
        | _ ->
            false
    let v135 : bool = v134 <> true
    let v136 : string = "createSignal"
    let v137 : string = "solid-js"
    let v138 : JS.Function = import v136 v137
    let v139 : (JS.Function []) = v138.Invoke v135 |> unbox<JS.Function[]>
    let v140 : (unit -> bool) = v139.[0] |> unbox
    let v141 : (bool -> unit) = v139.[1] |> unbox
    let v142 : string = "Tr"
    let v143 : string = "@hope-ui/solid"
    let v144 : JS.Function = import v142 v143
    let struct (v145 : US3, v146 : US3, v147 : US3, v148 : US5, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US6, v156 : US7, v157 : US3, v158 : US3, v159 : US6, v160 : US8, v161 : US3, v162 : US3, v163 : US3, v164 : US9, v165 : US6, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US3, v171 : US10, v172 : US3, v173 : US3, v174 : US3, v175 : US10, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US11, v185 : US12, v186 : US11, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US10, v204 : US3, v205 : US3, v206 : US8, v207 : US3, v208 : US2, v209 : US3) = method11()
    let v210 : string = "column"
    let v211 : string = "row"
    let v212 : string = method19(v211, v210)
    let v213 : string = "$neutral5"
    let v214 : US3 = US3_1(v213)
    let v215 : string = "1px 2px"
    let v216 : US3 = US3_1(v215)
    let v217 : (unit -> (JSX.Element [])) = closure23(v0, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v141, v140)
    let v218 : US7 = US7_1(v217)
    let v219 : string = "flex"
    let v220 : US3 = US3_1(v219)
    let v221 : string = "1"
    let v222 : US3 = US3_1(v221)
    let v223 : US3 = US3_1(v212)
    let v224 : ((string * obj) []) = method13(v145, v146, v147, v148, v149, v150, v151, v214, v216, v154, v155, v218, v157, v158, v159, v160, v161, v162, v220, v164, v165, v222, v223, v168, v169, v170, v171, v94, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209)
    let v225 : obj = createObj v224
    let v226 : (obj -> JSX.Element) = v144 |> unbox<obj -> JSX.Element>
    let v227 : string = "createComponent"
    let v228 : JS.Function = import v227 v137
    let v229 : JSX.Element = v228.Invoke (v226, v225) |> unbox<JSX.Element>
    v229
and closure22 () (v0 : Mut5) : JSX.Element =
    method18(v0)
and closure65 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : US3 = v0.l25
    let v4 : string =
        match v1 with
        | US3_0 -> (* None *)
            let v2 : string = ""
            v2
        | US3_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = Html.fragment [ v4 |> unbox<JSX.Element> ]
    [|v5|]
and closure66 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : US3 = US3_0
    let v66 : string = "-13px"
    let v67 : US3 = US3_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v65, v35, v67, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure67 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure64 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) = method11()
    let struct (v69 : US3, v70 : US3, v71 : US3, v72 : US5, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US6, v80 : US7, v81 : US3, v82 : US3, v83 : US6, v84 : US8, v85 : US3, v86 : US3, v87 : US3, v88 : US9, v89 : US6, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US10, v96 : US3, v97 : US3, v98 : US3, v99 : US10, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US11, v109 : US12, v110 : US11, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US10, v128 : US3, v129 : US3, v130 : US8, v131 : US3, v132 : US2, v133 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64
    let v134 : Mut3 = {l0 = v69; l1 = v70; l2 = v71; l3 = v72; l4 = v73; l5 = v74; l6 = v75; l7 = v76; l8 = v77; l9 = v78; l10 = v79; l11 = v80; l12 = v81; l13 = v82; l14 = v83; l15 = v84; l16 = v85; l17 = v86; l18 = v87; l19 = v88; l20 = v89; l21 = v90; l22 = v91; l23 = v92; l24 = v93; l25 = v94; l26 = v95; l27 = v96; l28 = v97; l29 = v98; l30 = v99; l31 = v100; l32 = v101; l33 = v102; l34 = v103; l35 = v104; l36 = v105; l37 = v106; l38 = v107; l39 = v108; l40 = v109; l41 = v110; l42 = v111; l43 = v112; l44 = v113; l45 = v114; l46 = v115; l47 = v116; l48 = v117; l49 = v118; l50 = v119; l51 = v120; l52 = v121; l53 = v122; l54 = v123; l55 = v124; l56 = v125; l57 = v126; l58 = v127; l59 = v128; l60 = v129; l61 = v130; l62 = v131; l63 = v132; l64 = v133} : Mut3
    let v135 : US6 = US6_1(true)
    let v136 : Mut3 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v135; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66; l63 = v67; l64 = v68} : Mut3
    method22(v136, v134)
    let struct (v137 : US3, v138 : US3, v139 : US3, v140 : US5, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US6, v148 : US7, v149 : US3, v150 : US3, v151 : US6, v152 : US8, v153 : US3, v154 : US3, v155 : US3, v156 : US9, v157 : US6, v158 : US3, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US10, v164 : US3, v165 : US3, v166 : US3, v167 : US10, v168 : US3, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US3, v176 : US11, v177 : US12, v178 : US11, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US10, v196 : US3, v197 : US3, v198 : US8, v199 : US3, v200 : US2, v201 : US3) = v136.l0, v136.l1, v136.l2, v136.l3, v136.l4, v136.l5, v136.l6, v136.l7, v136.l8, v136.l9, v136.l10, v136.l11, v136.l12, v136.l13, v136.l14, v136.l15, v136.l16, v136.l17, v136.l18, v136.l19, v136.l20, v136.l21, v136.l22, v136.l23, v136.l24, v136.l25, v136.l26, v136.l27, v136.l28, v136.l29, v136.l30, v136.l31, v136.l32, v136.l33, v136.l34, v136.l35, v136.l36, v136.l37, v136.l38, v136.l39, v136.l40, v136.l41, v136.l42, v136.l43, v136.l44, v136.l45, v136.l46, v136.l47, v136.l48, v136.l49, v136.l50, v136.l51, v136.l52, v136.l53, v136.l54, v136.l55, v136.l56, v136.l57, v136.l58, v136.l59, v136.l60, v136.l61, v136.l62, v136.l63, v136.l64
    let v202 : (unit -> (JSX.Element [])) = closure65(v0)
    let v203 : US7 = US7_1(v202)
    let v204 : ((string * obj) []) = method13(v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v203, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201)
    let v205 : obj = createObj v204
    let v206 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v207 : string = "createComponent"
    let v208 : string = "solid-js"
    let v209 : JS.Function = import v207 v208
    let v210 : JSX.Element = v209.Invoke (v206, v205) |> unbox<JSX.Element>
    let v211 : string = "&nbsp;"
    let v212 : JSX.Element = Html.fragment [ v211 |> unbox<JSX.Element> ]
    let v213 : (Mut8 -> JSX.Element) = closure43()
    let v214 : (obj -> JSX.Element) = v213 |> unbox<obj -> JSX.Element>
    let v215 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure66()
    let v216 : (unit -> JS.Function) = closure67()
    let v217 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure45()
    let v218 : Mut8 = {l0 = v215; l1 = v216; l2 = v217} : Mut8
    let v219 : obj = v218
    let v220 : JS.Function = import v207 v208
    let v221 : JSX.Element = v220.Invoke (v214, v219) |> unbox<JSX.Element>
    [|v210; v212; v221|]
and method26 (v0 : Mut3) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) = method11()
    let v69 : (unit -> (JSX.Element [])) = closure64(v0)
    let v70 : US7 = US7_1(v69)
    let v71 : ((string * obj) []) = method13(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v70, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
    let v72 : obj = createObj v71
    let v73 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v73, v72) |> unbox<JSX.Element>
    v77
and closure63 () (v0 : Mut3) : JSX.Element =
    method26(v0)
and closure68 () () : (JSX.Element []) =
    [||]
and closure62 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure63()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure68()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v70 : US3 = US3_1(v69)
    let v71 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v70; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v71, v67) "$0.children = $1"
    let v72 : obj = v71
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v1, v72) |> unbox<JSX.Element>
    [|v76|]
and closure61 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : (unit -> (JSX.Element [])) = closure62()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "1px 6px"
    let v68 : US3 = US3_1(v67)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v66, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v68, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure70 (v0 : string) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure63()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure68()
    let v69 : US7 = US7_1(v68)
    let v70 : US3 = US3_1(v0)
    let v71 : Mut3 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v69; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v70; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65; l63 = v66; l64 = v67} : Mut3
    emitJsExpr (v71, v68) "$0.children = $1"
    let v72 : obj = v71
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v2, v72) |> unbox<JSX.Element>
    [|v76|]
and closure69 (v0 : string) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : (unit -> (JSX.Element [])) = closure70(v0)
    let v67 : US7 = US7_1(v66)
    let v68 : string = "1px 6px"
    let v69 : US3 = US3_1(v68)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v67, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v69, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
and closure72 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure63()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure68()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v70 : US3 = US3_1(v69)
    let v71 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v70; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v71, v67) "$0.children = $1"
    let v72 : obj = v71
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v1, v72) |> unbox<JSX.Element>
    [|v76|]
and closure71 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : (unit -> (JSX.Element [])) = closure72()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "1px 6px"
    let v68 : US3 = US3_1(v67)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v66, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v68, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure74 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure63()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure68()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v70 : US3 = US3_1(v69)
    let v71 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v70; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v71, v67) "$0.children = $1"
    let v72 : obj = v71
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v1, v72) |> unbox<JSX.Element>
    [|v76|]
and closure73 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : (unit -> (JSX.Element [])) = closure74()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "1px 6px"
    let v68 : US3 = US3_1(v67)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v66, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v68, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure60 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v27 : JSX.Element =
        if v1 then
            let v2 : (Mut5 -> JSX.Element) = closure22()
            let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
            let v4 : US13 = US13_0
            let v5 : US13 = US13_0
            let v6 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure61()
            let v7 : US14 = US14_2
            let v8 : Mut5 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut5
            let v9 : obj = v8
            let v10 : string = "createComponent"
            let v11 : string = "solid-js"
            let v12 : JS.Function = import v10 v11
            let v13 : JSX.Element = v12.Invoke (v3, v9) |> unbox<JSX.Element>
            v13
        else
            let v14 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let v15 : (Mut5 -> JSX.Element) = closure22()
            let v16 : (obj -> JSX.Element) = v15 |> unbox<obj -> JSX.Element>
            let v17 : US13 = US13_0
            let v18 : US13 = US13_0
            let v19 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure69(v14)
            let v20 : US14 = US14_2
            let v21 : Mut5 = {l0 = v17; l1 = v18; l2 = v19; l3 = v20} : Mut5
            let v22 : obj = v21
            let v23 : string = "createComponent"
            let v24 : string = "solid-js"
            let v25 : JS.Function = import v23 v24
            let v26 : JSX.Element = v25.Invoke (v16, v22) |> unbox<JSX.Element>
            v26
    let v28 : (Mut5 -> JSX.Element) = closure22()
    let v29 : (obj -> JSX.Element) = v28 |> unbox<obj -> JSX.Element>
    let v30 : US13 = US13_0
    let v31 : US13 = US13_0
    let v32 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure71()
    let v33 : US14 = US14_2
    let v34 : Mut5 = {l0 = v30; l1 = v31; l2 = v32; l3 = v33} : Mut5
    let v35 : obj = v34
    let v36 : string = "createComponent"
    let v37 : string = "solid-js"
    let v38 : JS.Function = import v36 v37
    let v39 : JSX.Element = v38.Invoke (v29, v35) |> unbox<JSX.Element>
    let v40 : (obj -> JSX.Element) = v28 |> unbox<obj -> JSX.Element>
    let v41 : US13 = US13_0
    let v42 : US13 = US13_0
    let v43 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure73()
    let v44 : US14 = US14_2
    let v45 : Mut5 = {l0 = v41; l1 = v42; l2 = v43; l3 = v44} : Mut5
    let v46 : obj = v45
    let v47 : JS.Function = import v36 v37
    let v48 : JSX.Element = v47.Invoke (v40, v46) |> unbox<JSX.Element>
    [|v27; v39; v48|]
and method25 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method1()
    let v5 : (Mut3 -> JSX.Element) = closure18()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US3, v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US10, v66 : US3, v67 : US3, v68 : US8, v69 : US3, v70 : US2, v71 : US3) = method11()
    let v72 : (unit -> (JSX.Element [])) = closure60(v3)
    let v73 : US7 = US7_1(v72)
    let v74 : Mut3 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v17; l11 = v73; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69; l63 = v70; l64 = v71} : Mut3
    emitJsExpr (v74, v72) "$0.children = $1"
    let v75 : obj = v74
    let v76 : string = "createComponent"
    let v77 : string = "solid-js"
    let v78 : JS.Function = import v76 v77
    let v79 : JSX.Element = v78.Invoke (v6, v75) |> unbox<JSX.Element>
    v79
and closure59 () (v0 : Mut3) : JSX.Element =
    method25()
and closure75 () () : (JSX.Element []) =
    [||]
and closure58 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure59()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure75()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure57 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Links"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure58()
    let v68 : US7 = US7_1(v67)
    let v69 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v69, v59, v60, v61, v62, v63, v64)
and closure84 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure85 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure83 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : string = "dark"
    let v69 : obj = v68
    let v70 : (unit -> (JSX.Element [])) = closure84()
    let v71 : US7 = US7_1(v70)
    let v72 : string = "neutral"
    let v73 : US3 = US3_1(v72)
    let v74 : string = "sm"
    let v75 : US3 = US3_1(v74)
    let v76 : US8 = US8_1(v69)
    let v77 : ((string * obj) []) = method13(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v71, v15, v73, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v75, v57, v58, v59, v60, v61, v62, v63, v76, v65, v66, v67)
    let v78 : obj = createObj v77
    let v79 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v79, v78) |> unbox<JSX.Element>
    let v84 : JS.Function = import v0 v1
    let struct (v85 : US3, v86 : US3, v87 : US3, v88 : US5, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US6, v96 : US7, v97 : US3, v98 : US3, v99 : US6, v100 : US8, v101 : US3, v102 : US3, v103 : US3, v104 : US9, v105 : US6, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US10, v112 : US3, v113 : US3, v114 : US3, v115 : US10, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US11, v125 : US12, v126 : US11, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US10, v144 : US3, v145 : US3, v146 : US8, v147 : US3, v148 : US2, v149 : US3) = method11()
    let v150 : string = "light"
    let v151 : obj = v150
    let v152 : (unit -> (JSX.Element [])) = closure85()
    let v153 : US7 = US7_1(v152)
    let v154 : US3 = US3_1(v72)
    let v155 : US3 = US3_1(v74)
    let v156 : US8 = US8_1(v151)
    let v157 : ((string * obj) []) = method13(v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v153, v97, v154, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v155, v139, v140, v141, v142, v143, v144, v145, v156, v147, v148, v149)
    let v158 : obj = createObj v157
    let v159 : (obj -> JSX.Element) = v84 |> unbox<obj -> JSX.Element>
    let v160 : JS.Function = import v80 v81
    let v161 : JSX.Element = v160.Invoke (v159, v158) |> unbox<JSX.Element>
    [|v83; v161|]
and closure82 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure83()
    let v69 : US7 = US7_1(v68)
    let v70 : string = "row"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "$4"
    let v73 : US3 = US3_1(v72)
    let v74 : ((string * obj) []) = method13(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v69, v15, v16, v17, v18, v19, v71, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v73, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v75 : obj = createObj v74
    let v76 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v76, v75) |> unbox<JSX.Element>
    [|v80|]
and closure86 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure81 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US5, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US6, v16 : US7, v17 : US3, v18 : US3, v19 : US6, v20 : US8, v21 : US3, v22 : US3, v23 : US3, v24 : US9, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US11, v45 : US12, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US10, v64 : US3, v65 : US3, v66 : US8, v67 : US3, v68 : US2, v69 : US3) = method11()
    let v70 : string = v1 ()
    let v71 : (unit -> (JSX.Element [])) = closure82()
    let v72 : US7 = US7_1(v71)
    let v73 : US3 = US3_1(v70)
    let v74 : (obj -> unit) = closure86(v0)
    let v75 : US11 = US11_1(v74)
    let v76 : ((string * obj) []) = method13(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v72, v17, v18, v19, v20, v73, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v75, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v77 : obj = createObj v76
    let v78 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v79 : string = "createComponent"
    let v80 : string = "solid-js"
    let v81 : JS.Function = import v79 v80
    let v82 : JSX.Element = v81.Invoke (v78, v77) |> unbox<JSX.Element>
    [|v82|]
and closure80 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v67 : string = "Theme"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure81(v0, v1)
    let v70 : US7 = US7_1(v69)
    let v71 : string = "5px 6px"
    let v72 : US3 = US3_1(v71)
    let v73 : US10 = US10_1(v68)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v70, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v72, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66)
and closure79 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut5 -> JSX.Element) = closure22()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : US13 = US13_0
    let v5 : US13 = US13_0
    let v6 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure80(v0, v1)
    let v7 : US14 = US14_2
    let v8 : Mut5 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut5
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v3, v9) |> unbox<JSX.Element>
    [|v13|]
and method27 () : JSX.Element =
    let v0 : string = "useColorMode"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : obj = v2.Invoke () |> unbox
    let v4 : (unit -> string) = v3?colorMode |> unbox
    let v5 : (unit -> unit) = v3?toggleColorMode |> unbox
    let v6 : (Mut3 -> JSX.Element) = closure18()
    let v7 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US5, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US7, v20 : US3, v21 : US3, v22 : US6, v23 : US8, v24 : US3, v25 : US3, v26 : US3, v27 : US9, v28 : US6, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US10, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US11, v48 : US12, v49 : US11, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method11()
    let v73 : (unit -> (JSX.Element [])) = closure79(v5, v4)
    let v74 : US7 = US7_1(v73)
    let v75 : Mut3 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v74; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70; l63 = v71; l64 = v72} : Mut3
    emitJsExpr (v75, v73) "$0.children = $1"
    let v76 : obj = v75
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v7, v76) |> unbox<JSX.Element>
    v80
and closure78 () (v0 : Mut3) : JSX.Element =
    method27()
and closure87 () () : (JSX.Element []) =
    [||]
and closure77 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure78()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure87()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure76 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Settings"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure77()
    let v68 : US7 = US7_1(v67)
    let v69 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v69, v59, v60, v61, v62, v63, v64)
and closure99 () () : (JSX.Element []) =
    [||]
and closure100 (v0 : Mut9, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
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
and method30 (v0 : Mut9) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US3, v11 : US3, v12 : US3, v13 : US5, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US6, v21 : US7, v22 : US3, v23 : US3, v24 : US6, v25 : US8, v26 : US3, v27 : US3, v28 : US3, v29 : US9, v30 : US6, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US10, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US11, v50 : US12, v51 : US11, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US10, v69 : US3, v70 : US3, v71 : US8, v72 : US3, v73 : US2, v74 : US3) = method11()
    let v75 : (Mut1 -> US3) = v0.l0
    let v76 : US3 = v75 v5
    let v77 : string = JS.undefined
    let v79 : string =
        match v76 with
        | US3_0 -> (* None *)
            v77
        | US3_1(v78) -> (* Some *)
            v78
    let v80 : obj = v79
    let v81 : (unit -> (JSX.Element [])) = closure99()
    let v82 : US7 = US7_1(v81)
    let v83 : (obj -> unit) = closure100(v0, v5, v6)
    let v84 : US11 = US11_1(v83)
    let v85 : string = "xs"
    let v86 : US3 = US3_1(v85)
    let v87 : string = "text"
    let v88 : US3 = US3_1(v87)
    let v89 : US8 = US8_1(v80)
    let v90 : ((string * obj) []) = method13(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v82, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v84, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v86, v64, v65, v66, v67, v68, v69, v88, v89, v72, v73, v74)
    let v91 : obj = createObj v90
    let v92 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v93 : string = "createComponent"
    let v94 : string = "solid-js"
    let v95 : JS.Function = import v93 v94
    let v96 : JSX.Element = v95.Invoke (v92, v91) |> unbox<JSX.Element>
    v96
and closure98 () (v0 : Mut9) : JSX.Element =
    method30(v0)
and closure101 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v3
and closure104 (v0 : Mut1) (v1 : US3) : unit =
    v0.l2 <- v1
    ()
and closure103 () (v0 : Mut1) : (US3 -> unit) =
    closure104(v0)
and closure102 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure103()
and closure97 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure98()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US3) = closure101()
    let v3 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure102()
    let v4 : Mut9 = {l0 = v2; l1 = v3} : Mut9
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure96 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Token"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure97()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "3px"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v70, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure107 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v4
and closure110 (v0 : Mut1) (v1 : US3) : unit =
    v0.l3 <- v1
    ()
and closure109 () (v0 : Mut1) : (US3 -> unit) =
    closure110(v0)
and closure108 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure109()
and closure106 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure98()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US3) = closure107()
    let v3 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure108()
    let v4 : Mut9 = {l0 = v2; l1 = v3} : Mut9
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure105 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "URL"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure106()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "3px"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v70, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure114 (v0 : Mut10, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
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
and method31 (v0 : Mut10) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US3, v11 : US3, v12 : US3, v13 : US5, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US6, v21 : US7, v22 : US3, v23 : US3, v24 : US6, v25 : US8, v26 : US3, v27 : US3, v28 : US3, v29 : US9, v30 : US6, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US10, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US11, v50 : US12, v51 : US11, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US10, v69 : US3, v70 : US3, v71 : US8, v72 : US3, v73 : US2, v74 : US3) = method11()
    let v75 : (Mut1 -> US2) = v0.l0
    let v76 : US2 = v75 v5
    let v77 : int32 = JS.undefined
    let v79 : int32 =
        match v76 with
        | US2_0 -> (* None *)
            v77
        | US2_1(v78) -> (* Some *)
            v78
    let v80 : obj = v79
    let v81 : (unit -> (JSX.Element [])) = closure99()
    let v82 : US7 = US7_1(v81)
    let v83 : (obj -> unit) = closure114(v0, v5, v6)
    let v84 : US11 = US11_1(v83)
    let v85 : string = "xs"
    let v86 : US3 = US3_1(v85)
    let v87 : string = "text"
    let v88 : US3 = US3_1(v87)
    let v89 : US8 = US8_1(v80)
    let v90 : ((string * obj) []) = method13(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v82, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v84, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v86, v64, v65, v66, v67, v68, v69, v88, v89, v72, v73, v74)
    let v91 : obj = createObj v90
    let v92 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v93 : string = "createComponent"
    let v94 : string = "solid-js"
    let v95 : JS.Function = import v93 v94
    let v96 : JSX.Element = v95.Invoke (v92, v91) |> unbox<JSX.Element>
    v96
and closure113 () (v0 : Mut10) : JSX.Element =
    method31(v0)
and closure115 () (v0 : Mut1) : US2 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v2
and closure118 (v0 : Mut1) (v1 : US2) : unit =
    v0.l1 <- v1
    ()
and closure117 () (v0 : Mut1) : (US2 -> unit) =
    closure118(v0)
and closure116 () (v0 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure117()
and closure112 () () : (JSX.Element []) =
    let v0 : (Mut10 -> JSX.Element) = closure113()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US2) = closure115()
    let v3 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure116()
    let v4 : Mut10 = {l0 = v2; l1 = v3} : Mut10
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure111 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Port"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure112()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "3px"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v70, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure95 () () : (JSX.Element []) =
    let v0 : (Mut5 -> JSX.Element) = closure22()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure96()
    let v5 : US14 = US14_2
    let v6 : Mut5 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut5
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v1, v7) |> unbox<JSX.Element>
    let v12 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v13 : US13 = US13_0
    let v14 : US13 = US13_0
    let v15 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure105()
    let v16 : US14 = US14_2
    let v17 : Mut5 = {l0 = v13; l1 = v14; l2 = v15; l3 = v16} : Mut5
    let v18 : obj = v17
    let v19 : JS.Function = import v8 v9
    let v20 : JSX.Element = v19.Invoke (v12, v18) |> unbox<JSX.Element>
    let v21 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v22 : US13 = US13_0
    let v23 : US13 = US13_0
    let v24 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure111()
    let v25 : US14 = US14_2
    let v26 : Mut5 = {l0 = v22; l1 = v23; l2 = v24; l3 = v25} : Mut5
    let v27 : obj = v26
    let v28 : JS.Function = import v8 v9
    let v29 : JSX.Element = v28.Invoke (v21, v27) |> unbox<JSX.Element>
    [|v11; v20; v29|]
and method29 () : JSX.Element =
    let v0 : (Mut3 -> JSX.Element) = closure18()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure95()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    v74
and closure94 () (v0 : Mut3) : JSX.Element =
    method29()
and closure119 () () : (JSX.Element []) =
    [||]
and closure93 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure94()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure119()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure92 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Connection"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure93()
    let v68 : US7 = US7_1(v67)
    let v69 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v69, v59, v60, v61, v62, v63, v64)
and closure130 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v1)
and closure133 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut7 = {l0 = 0} : Mut7
    while method23(v11, v13) do
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
and closure132 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure133(v0, v1, v2, v3, v4, v5)
and closure131 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure132(v0, v1, v2, v3, v4)
and closure129 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut9 -> JSX.Element) = closure98()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : (Mut1 -> US3) = closure130(v0, v1, v2, v3)
    let v7 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure131(v0, v1, v2, v3)
    let v8 : Mut9 = {l0 = v6; l1 = v7} : Mut9
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v5, v9) |> unbox<JSX.Element>
    [|v13|]
and closure128 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v69 : string = "Address"
    let v70 : JSX.Element = Html.fragment [ v69 |> unbox<JSX.Element> ]
    let v71 : (unit -> (JSX.Element [])) = closure129(v0, v1, v2, v3)
    let v72 : US7 = US7_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US10 = US10_1(v70)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v72, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v74, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68)
and closure136 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v3)
and closure139 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut7 = {l0 = 0} : Mut7
    while method23(v11, v13) do
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
and closure138 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure139(v0, v1, v2, v3, v4, v5)
and closure137 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure138(v0, v1, v2, v3, v4)
and closure135 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut9 -> JSX.Element) = closure98()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : (Mut1 -> US3) = closure136(v0, v1, v2, v3)
    let v7 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure137(v0, v1, v2, v3)
    let v8 : Mut9 = {l0 = v6; l1 = v7} : Mut9
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v5, v9) |> unbox<JSX.Element>
    [|v13|]
and closure134 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v69 : string = "Private Key"
    let v70 : JSX.Element = Html.fragment [ v69 |> unbox<JSX.Element> ]
    let v71 : (unit -> (JSX.Element [])) = closure135(v0, v1, v2, v3)
    let v72 : US7 = US7_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US10 = US10_1(v70)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v72, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v74, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68)
and closure127 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut5 -> JSX.Element) = closure22()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : US13 = US13_0
    let v7 : US13 = US13_0
    let v8 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure128(v0, v1, v2, v3)
    let v9 : US14 = US14_2
    let v10 : Mut5 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9} : Mut5
    let v11 : obj = v10
    let v12 : string = "createComponent"
    let v13 : string = "solid-js"
    let v14 : JS.Function = import v12 v13
    let v15 : JSX.Element = v14.Invoke (v5, v11) |> unbox<JSX.Element>
    let v16 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v17 : US13 = US13_0
    let v18 : US13 = US13_0
    let v19 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure134(v0, v1, v2, v3)
    let v20 : US14 = US14_2
    let v21 : Mut5 = {l0 = v17; l1 = v18; l2 = v19; l3 = v20} : Mut5
    let v22 : obj = v21
    let v23 : JS.Function = import v12 v13
    let v24 : JSX.Element = v23.Invoke (v16, v22) |> unbox<JSX.Element>
    [|v15; v24|]
and closure126 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut3 -> JSX.Element) = closure18()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let struct (v6 : US3, v7 : US3, v8 : US3, v9 : US5, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US6, v17 : US7, v18 : US3, v19 : US3, v20 : US6, v21 : US8, v22 : US3, v23 : US3, v24 : US3, v25 : US9, v26 : US6, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US11, v46 : US12, v47 : US11, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method11()
    let v71 : (unit -> (JSX.Element [])) = closure127(v0, v1, v2, v3)
    let v72 : US7 = US7_1(v71)
    let v73 : Mut3 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9; l4 = v10; l5 = v11; l6 = v12; l7 = v13; l8 = v14; l9 = v15; l10 = v16; l11 = v72; l12 = v18; l13 = v19; l14 = v20; l15 = v21; l16 = v22; l17 = v23; l18 = v24; l19 = v25; l20 = v26; l21 = v27; l22 = v28; l23 = v29; l24 = v30; l25 = v31; l26 = v32; l27 = v33; l28 = v34; l29 = v35; l30 = v36; l31 = v37; l32 = v38; l33 = v39; l34 = v40; l35 = v41; l36 = v42; l37 = v43; l38 = v44; l39 = v45; l40 = v46; l41 = v47; l42 = v48; l43 = v49; l44 = v50; l45 = v51; l46 = v52; l47 = v53; l48 = v54; l49 = v55; l50 = v56; l51 = v57; l52 = v58; l53 = v59; l54 = v60; l55 = v61; l56 = v62; l57 = v63; l58 = v64; l59 = v65; l60 = v66; l61 = v67; l62 = v68; l63 = v69; l64 = v70} : Mut3
    emitJsExpr (v73, v71) "$0.children = $1"
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v5, v74) |> unbox<JSX.Element>
    [|v78|]
and closure125 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v74 : string =
        match v0 with
        | US0_0 -> (* Admin *)
            let v69 : string = "admin"
            v69
        | US0_1(v70) -> (* Player *)
            match v70 with
            | US1_0 -> (* O *)
                let v71 : string = "o"
                v71
            | US1_1 -> (* X *)
                let v72 : string = "x"
                v72
    let v75 : JSX.Element = Html.fragment [ v74 |> unbox<JSX.Element> ]
    let v76 : (unit -> (JSX.Element [])) = closure126(v0, v1, v2, v3)
    let v77 : US7 = US7_1(v76)
    let v78 : US10 = US10_1(v75)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v77, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v78, v63, v64, v65, v66, v67, v68)
and closure124 () struct (v0 : US0, v1 : string, v2 : string, v3 : string) : (JSX.Element []) =
    let v4 : (Mut5 -> JSX.Element) = closure22()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : US13 = US13_0
    let v7 : US13 = US13_0
    let v8 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure125(v0, v1, v2, v3)
    let v9 : US14 = US14_2
    let v10 : Mut5 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9} : Mut5
    let v11 : obj = v10
    let v12 : string = "createComponent"
    let v13 : string = "solid-js"
    let v14 : JS.Function = import v12 v13
    let v15 : JSX.Element = v14.Invoke (v5, v11) |> unbox<JSX.Element>
    [|v15|]
and closure123 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    let v5 : string = "For"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US0 * string * string * string) -> (JSX.Element [])) = closure124()
    let v9 : (unit -> (JSX.Element [])) = v8 |> unbox
    let struct (v10 : US3, v11 : US3, v12 : US3, v13 : US5, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US6, v21 : US7, v22 : US3, v23 : US3, v24 : US6, v25 : US8, v26 : US3, v27 : US3, v28 : US3, v29 : US9, v30 : US6, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US10, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US11, v50 : US12, v51 : US11, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US10, v69 : US3, v70 : US3, v71 : US8, v72 : US3, v73 : US2, v74 : US3) = method11()
    let v75 : (obj []) = v1 |> unbox<obj[]>
    let v76 : US7 = US7_1(v9)
    let v77 : US9 = US9_1(v75)
    let v78 : ((string * obj) []) = method13(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v76, v22, v23, v24, v25, v26, v27, v28, v77, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v79 : obj = createObj v78
    let v80 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v81 : string = "createComponent"
    let v82 : JS.Function = import v81 v6
    let v83 : JSX.Element = v82.Invoke (v80, v79) |> unbox<JSX.Element>
    [|v83|]
and method32 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : (Mut3 -> JSX.Element) = closure18()
    let v7 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US5, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US7, v20 : US3, v21 : US3, v22 : US6, v23 : US8, v24 : US3, v25 : US3, v26 : US3, v27 : US9, v28 : US6, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US10, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US11, v48 : US12, v49 : US11, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method11()
    let v73 : (unit -> (JSX.Element [])) = closure123(v4)
    let v74 : US7 = US7_1(v73)
    let v75 : Mut3 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v74; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70; l63 = v71; l64 = v72} : Mut3
    emitJsExpr (v75, v73) "$0.children = $1"
    let v76 : obj = v75
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v7, v76) |> unbox<JSX.Element>
    v80
and closure122 () (v0 : Mut3) : JSX.Element =
    method32()
and closure140 () () : (JSX.Element []) =
    [||]
and closure121 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure122()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure140()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure120 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Accounts"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure121()
    let v68 : US7 = US7_1(v67)
    let v69 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v69, v59, v60, v61, v62, v63, v64)
and closure143 () () : (JSX.Element []) =
    [||]
and closure142 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) = method11()
    let v69 : string = "algorand testnet bank"
    let v70 : JSX.Element = Html.fragment [ v69 |> unbox<JSX.Element> ]
    let v71 : string = "#aaa"
    let v72 : US3 = US3_1(v71)
    let v73 : (unit -> (JSX.Element [])) = closure143()
    let v74 : US7 = US7_1(v73)
    let v75 : string = "1"
    let v76 : US3 = US3_1(v75)
    let v77 : string = "350px"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "https://bank.testnet.algorand.network"
    let v80 : US3 = US3_1(v79)
    let v81 : US10 = US10_1(v70)
    let v82 : ((string * obj) []) = method13(v4, v5, v6, v7, v72, v9, v10, v11, v12, v13, v14, v74, v16, v17, v18, v19, v20, v21, v22, v23, v24, v76, v26, v27, v78, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v80, v60, v61, v81, v63, v64, v65, v66, v67, v68)
    let v83 : obj = createObj v82
    let v84 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : JSX.Element = v87.Invoke (v84, v83) |> unbox<JSX.Element>
    [|v88|]
and closure141 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Testnet Bank Dispenser"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure142()
    let v68 : US7 = US7_1(v67)
    let v69 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v69, v59, v60, v61, v62, v63, v64)
and closure91 () () : (JSX.Element []) =
    let v0 : (Mut5 -> JSX.Element) = closure22()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure92()
    let v5 : US14 = US14_2
    let v6 : Mut5 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut5
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v1, v7) |> unbox<JSX.Element>
    let v12 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v13 : US13 = US13_0
    let v14 : US13 = US13_0
    let v15 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure120()
    let v16 : US14 = US14_2
    let v17 : Mut5 = {l0 = v13; l1 = v14; l2 = v15; l3 = v16} : Mut5
    let v18 : obj = v17
    let v19 : JS.Function = import v8 v9
    let v20 : JSX.Element = v19.Invoke (v12, v18) |> unbox<JSX.Element>
    let v21 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v22 : US13 = US13_0
    let v23 : US13 = US13_0
    let v24 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure141()
    let v25 : US14 = US14_0
    let v26 : Mut5 = {l0 = v22; l1 = v23; l2 = v24; l3 = v25} : Mut5
    let v27 : obj = v26
    let v28 : JS.Function = import v8 v9
    let v29 : JSX.Element = v28.Invoke (v21, v27) |> unbox<JSX.Element>
    [|v11; v20; v29|]
and method28 () : JSX.Element =
    let v0 : (Mut3 -> JSX.Element) = closure18()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure91()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    v74
and closure90 () (v0 : Mut3) : JSX.Element =
    method28()
and closure144 () () : (JSX.Element []) =
    [||]
and closure89 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure90()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure144()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure88 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Chain"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure89()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "db"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v70, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure152 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_1
    let v5 : US4 = US4_1
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method23(v9, v11) do
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
and closure151 () (v0 : Mut1) : (Mut1 -> unit) =
    closure152(v0)
and closure150 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure151()
    v0 v1
    ()
and closure149 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure150()
and method34 (v0 : int32, v1 : Mut11) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure156 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method34(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 = v6.l1
        let struct (v10 : US4, v11 : US4) = v3.[int v8]
        let v14 : bool =
            match v10 with
            | US4_1 -> (* GunRs *)
                true
            | _ ->
                false
        let v16 : bool =
            if v14 then
                match v11 with
                | US4_1 -> (* GunRs *)
                    true
                | _ ->
                    false
            else
                false
        let v17 : bool = v16 <> true
        let v19 : int32 =
            if v17 then
                v5.[int v9] <- struct (v10, v11)
                let v18 : int32 = v9 + 1
                v18
            else
                v9
        let v20 : int32 = v8 + 1
        v6.l0 <- v20
        v6.l1 <- v19
        ()
    let v21 : int32 = v6.l1
    let v22 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v21)
    let v23 : Mut7 = {l0 = 0} : Mut7
    while method23(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure155 () (v0 : Mut1) : (Mut1 -> unit) =
    closure156(v0)
and closure154 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure155()
    v0 v1
    ()
and closure153 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure154()
and method37 (v0 : int32, v1 : Mut14) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure164 (v0 : Mut13) (v1 : Mut1) : US3 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US3 = US3_0
    let v6 : Mut14 = {l0 = 0; l1 = v5} : Mut14
    while method37(v4, v6) do
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
and closure167 (v0 : Mut13, v1 : Mut1, v2 : Mut1) (v3 : US3) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v6 : int32 = v4.Length
    let v7 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v6)
    let v8 : Mut7 = {l0 = 0} : Mut7
    while method23(v6, v8) do
        let v10 : int32 = v8.l0
        let struct (v11 : US4, v12 : int32, v13 : string, v14 : string) = v4.[int v10]
        let v15 : US4 = v0.l0
        let v16 : bool =
            match v11, v15 with
            | US4_0, US4_0 -> (* GunJs *)
                true
            | US4_1, US4_1 -> (* GunRs *)
                true
            | _ ->
                false
        let struct (v23 : US4, v24 : int32, v25 : string, v26 : string) =
            if v16 then
                let v17 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string))) = v0.l2
                let v18 : (US3 -> struct (US4 * int32 * string * string)) = v17 struct (v11, v12, v13, v14)
                let struct (v19 : US4, v20 : int32, v21 : string, v22 : string) = v18 v3
                struct (v19, v20, v21, v22)
            else
                struct (v11, v12, v13, v14)
        v7.[int v10] <- struct (v23, v24, v25, v26)
        let v27 : int32 = v10 + 1
        v8.l0 <- v27
        ()
    v2.l4 <- v7
    ()
and closure166 (v0 : Mut13, v1 : Mut1) (v2 : Mut1) : (US3 -> unit) =
    closure167(v0, v1, v2)
and closure165 (v0 : Mut13) (v1 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure166(v0, v1)
and method36 (v0 : Mut13) : JSX.Element =
    let v1 : (Mut9 -> JSX.Element) = closure98()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : (Mut1 -> US3) = closure164(v0)
    let v4 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure165(v0)
    let v5 : Mut9 = {l0 = v3; l1 = v4} : Mut9
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v2, v6) |> unbox<JSX.Element>
    v10
and closure163 () (v0 : Mut13) : JSX.Element =
    method36(v0)
and closure168 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US3 =
    US3_1(v2)
and closure170 (v0 : Mut12, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US3) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v9 : string =
        match v5 with
        | US3_0 -> (* None *)
            let v7 : string = ""
            v7
        | US3_1(v8) -> (* Some *)
            v8
    struct (v6, v2, v9, v4)
and closure169 (v0 : Mut12) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US3 -> struct (US4 * int32 * string * string)) =
    closure170(v0, v1, v2, v3, v4)
and closure162 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (Mut13 -> JSX.Element) = closure163()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : (struct (US4 * int32 * string * string) -> US3) = closure168()
    let v5 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string))) = closure169(v0)
    let v6 : Mut13 = {l0 = v1; l1 = v4; l2 = v5} : Mut13
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v11|]
and closure161 (v0 : Mut12) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : string = "URL"
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure162(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : string = "3px"
    let v71 : US3 = US3_1(v70)
    let v72 : US10 = US10_1(v67)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v69, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v72, v60, v61, v62, v63, v64, v65)
and method39 (v0 : int32, v1 : Mut16) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure174 (v0 : Mut15) (v1 : Mut1) : US2 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US2 = US2_0
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method39(v4, v6) do
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
and closure177 (v0 : Mut15, v1 : Mut1, v2 : Mut1) (v3 : US2) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v6 : int32 = v4.Length
    let v7 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v6)
    let v8 : Mut7 = {l0 = 0} : Mut7
    while method23(v6, v8) do
        let v10 : int32 = v8.l0
        let struct (v11 : US4, v12 : int32, v13 : string, v14 : string) = v4.[int v10]
        let v15 : US4 = v0.l0
        let v16 : bool =
            match v11, v15 with
            | US4_0, US4_0 -> (* GunJs *)
                true
            | US4_1, US4_1 -> (* GunRs *)
                true
            | _ ->
                false
        let struct (v23 : US4, v24 : int32, v25 : string, v26 : string) =
            if v16 then
                let v17 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string))) = v0.l2
                let v18 : (US2 -> struct (US4 * int32 * string * string)) = v17 struct (v11, v12, v13, v14)
                let struct (v19 : US4, v20 : int32, v21 : string, v22 : string) = v18 v3
                struct (v19, v20, v21, v22)
            else
                struct (v11, v12, v13, v14)
        v7.[int v10] <- struct (v23, v24, v25, v26)
        let v27 : int32 = v10 + 1
        v8.l0 <- v27
        ()
    v2.l4 <- v7
    ()
and closure176 (v0 : Mut15, v1 : Mut1) (v2 : Mut1) : (US2 -> unit) =
    closure177(v0, v1, v2)
and closure175 (v0 : Mut15) (v1 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure176(v0, v1)
and method38 (v0 : Mut15) : JSX.Element =
    let v1 : (Mut10 -> JSX.Element) = closure113()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : (Mut1 -> US2) = closure174(v0)
    let v4 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure175(v0)
    let v5 : Mut10 = {l0 = v3; l1 = v4} : Mut10
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v2, v6) |> unbox<JSX.Element>
    v10
and closure173 () (v0 : Mut15) : JSX.Element =
    method38(v0)
and closure178 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US2 =
    US2_1(v1)
and closure180 (v0 : Mut12, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US2) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v8 : int32 =
        match v5 with
        | US2_0 -> (* None *)
            0
        | US2_1(v7) -> (* Some *)
            v7
    struct (v6, v8, v3, v4)
and closure179 (v0 : Mut12) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US2 -> struct (US4 * int32 * string * string)) =
    closure180(v0, v1, v2, v3, v4)
and closure172 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (Mut15 -> JSX.Element) = closure173()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : (struct (US4 * int32 * string * string) -> US2) = closure178()
    let v5 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string))) = closure179(v0)
    let v6 : Mut15 = {l0 = v1; l1 = v4; l2 = v5} : Mut15
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v11|]
and closure171 (v0 : Mut12) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : string = "Port"
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure172(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : string = "3px"
    let v71 : US3 = US3_1(v70)
    let v72 : US10 = US10_1(v67)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v69, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v72, v60, v61, v62, v63, v64, v65)
and closure160 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : (Mut5 -> JSX.Element) = closure22()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure161(v0)
    let v6 : US14 = US14_2
    let v7 : Mut5 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6} : Mut5
    let v8 : obj = v7
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v2, v8) |> unbox<JSX.Element>
    let v13 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v14 : US13 = US13_0
    let v15 : US13 = US13_0
    let v16 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure171(v0)
    let v17 : US14 = US14_2
    let v18 : Mut5 = {l0 = v14; l1 = v15; l2 = v16; l3 = v17} : Mut5
    let v19 : obj = v18
    let v20 : JS.Function = import v9 v10
    let v21 : JSX.Element = v20.Invoke (v13, v19) |> unbox<JSX.Element>
    [|v12; v21|]
and method35 (v0 : Mut12) : JSX.Element =
    let v1 : (Mut3 -> JSX.Element) = closure18()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure160(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : Mut3 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v69; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65; l63 = v66; l64 = v67} : Mut3
    emitJsExpr (v70, v68) "$0.children = $1"
    let v71 : obj = v70
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v2, v71) |> unbox<JSX.Element>
    v75
and closure159 () (v0 : Mut12) : JSX.Element =
    method35(v0)
and closure158 () () : (JSX.Element []) =
    let v0 : (Mut12 -> JSX.Element) = closure159()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US4 = US4_1
    let v3 : Mut12 = {l0 = v2} : Mut12
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure157 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Rust -{'>'} Rust"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure158()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "db-gun-rs-rs"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v70, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure184 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_1
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method23(v9, v11) do
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
and closure183 () (v0 : Mut1) : (Mut1 -> unit) =
    closure184(v0)
and closure182 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure183()
    v0 v1
    ()
and closure181 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure182()
and closure188 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method34(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 = v6.l1
        let struct (v10 : US4, v11 : US4) = v3.[int v8]
        let v14 : bool =
            match v10 with
            | US4_1 -> (* GunRs *)
                true
            | _ ->
                false
        let v16 : bool =
            if v14 then
                match v11 with
                | US4_0 -> (* GunJs *)
                    true
                | _ ->
                    false
            else
                false
        let v17 : bool = v16 <> true
        let v19 : int32 =
            if v17 then
                v5.[int v9] <- struct (v10, v11)
                let v18 : int32 = v9 + 1
                v18
            else
                v9
        let v20 : int32 = v8 + 1
        v6.l0 <- v20
        v6.l1 <- v19
        ()
    let v21 : int32 = v6.l1
    let v22 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v21)
    let v23 : Mut7 = {l0 = 0} : Mut7
    while method23(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure187 () (v0 : Mut1) : (Mut1 -> unit) =
    closure188(v0)
and closure186 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure187()
    v0 v1
    ()
and closure185 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure186()
and closure190 () () : (JSX.Element []) =
    let v0 : (Mut12 -> JSX.Element) = closure159()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US4 = US4_0
    let v3 : Mut12 = {l0 = v2} : Mut12
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure189 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Rust -{'>'} JavaScript"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure190()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "db-gun-rs-js"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v70, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure194 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method23(v9, v11) do
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
and closure193 () (v0 : Mut1) : (Mut1 -> unit) =
    closure194(v0)
and closure192 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure193()
    v0 v1
    ()
and closure191 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure192()
and closure198 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method34(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 = v6.l1
        let struct (v10 : US4, v11 : US4) = v3.[int v8]
        let v14 : bool =
            match v10 with
            | US4_0 -> (* GunJs *)
                true
            | _ ->
                false
        let v16 : bool =
            if v14 then
                match v11 with
                | US4_0 -> (* GunJs *)
                    true
                | _ ->
                    false
            else
                false
        let v17 : bool = v16 <> true
        let v19 : int32 =
            if v17 then
                v5.[int v9] <- struct (v10, v11)
                let v18 : int32 = v9 + 1
                v18
            else
                v9
        let v20 : int32 = v8 + 1
        v6.l0 <- v20
        v6.l1 <- v19
        ()
    let v21 : int32 = v6.l1
    let v22 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v21)
    let v23 : Mut7 = {l0 = 0} : Mut7
    while method23(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure197 () (v0 : Mut1) : (Mut1 -> unit) =
    closure198(v0)
and closure196 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure197()
    v0 v1
    ()
and closure195 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure196()
and closure199 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "JavaScript -{'>'} JavaScript"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure190()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "db-gun-js-js"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v70, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure203 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_1
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method23(v9, v11) do
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
and closure202 () (v0 : Mut1) : (Mut1 -> unit) =
    closure203(v0)
and closure201 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure202()
    v0 v1
    ()
and closure200 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure201()
and closure207 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method34(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 = v6.l1
        let struct (v10 : US4, v11 : US4) = v3.[int v8]
        let v14 : bool =
            match v10 with
            | US4_0 -> (* GunJs *)
                true
            | _ ->
                false
        let v16 : bool =
            if v14 then
                match v11 with
                | US4_1 -> (* GunRs *)
                    true
                | _ ->
                    false
            else
                false
        let v17 : bool = v16 <> true
        let v19 : int32 =
            if v17 then
                v5.[int v9] <- struct (v10, v11)
                let v18 : int32 = v9 + 1
                v18
            else
                v9
        let v20 : int32 = v8 + 1
        v6.l0 <- v20
        v6.l1 <- v19
        ()
    let v21 : int32 = v6.l1
    let v22 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v21)
    let v23 : Mut7 = {l0 = 0} : Mut7
    while method23(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure206 () (v0 : Mut1) : (Mut1 -> unit) =
    closure207(v0)
and closure205 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure206()
    v0 v1
    ()
and closure204 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure205()
and closure208 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "JavaScript -{'>'} Rust"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure158()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "db-gun-js-rs"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v70, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure148 () () : (JSX.Element []) =
    let v0 : (Mut5 -> JSX.Element) = closure22()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure149()
    let v3 : US13 = US13_1(v2)
    let v4 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure153()
    let v5 : US13 = US13_1(v4)
    let v6 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure157()
    let v7 : US14 = US14_0
    let v8 : Mut5 = {l0 = v3; l1 = v5; l2 = v6; l3 = v7} : Mut5
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v1, v9) |> unbox<JSX.Element>
    let v14 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v15 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure181()
    let v16 : US13 = US13_1(v15)
    let v17 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure185()
    let v18 : US13 = US13_1(v17)
    let v19 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure189()
    let v20 : US14 = US14_0
    let v21 : Mut5 = {l0 = v16; l1 = v18; l2 = v19; l3 = v20} : Mut5
    let v22 : obj = v21
    let v23 : JS.Function = import v10 v11
    let v24 : JSX.Element = v23.Invoke (v14, v22) |> unbox<JSX.Element>
    let v25 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v26 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure191()
    let v27 : US13 = US13_1(v26)
    let v28 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure195()
    let v29 : US13 = US13_1(v28)
    let v30 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure199()
    let v31 : US14 = US14_0
    let v32 : Mut5 = {l0 = v27; l1 = v29; l2 = v30; l3 = v31} : Mut5
    let v33 : obj = v32
    let v34 : JS.Function = import v10 v11
    let v35 : JSX.Element = v34.Invoke (v25, v33) |> unbox<JSX.Element>
    let v36 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v37 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure200()
    let v38 : US13 = US13_1(v37)
    let v39 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure204()
    let v40 : US13 = US13_1(v39)
    let v41 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure208()
    let v42 : US14 = US14_0
    let v43 : Mut5 = {l0 = v38; l1 = v40; l2 = v41; l3 = v42} : Mut5
    let v44 : obj = v43
    let v45 : JS.Function = import v10 v11
    let v46 : JSX.Element = v45.Invoke (v36, v44) |> unbox<JSX.Element>
    [|v13; v24; v35; v46|]
and method33 () : JSX.Element =
    let v0 : (Mut3 -> JSX.Element) = closure18()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure148()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    v74
and closure147 () (v0 : Mut3) : JSX.Element =
    method33()
and closure209 () () : (JSX.Element []) =
    [||]
and closure146 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure147()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method11()
    let v67 : (unit -> (JSX.Element [])) = closure209()
    let v68 : US7 = US7_1(v67)
    let v69 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v68; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66} : Mut3
    emitJsExpr (v69, v67) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure145 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Database"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure146()
    let v68 : US7 = US7_1(v67)
    let v69 : string = "db"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v68, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v70, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure216 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure217 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v65, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure218 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure219 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure220 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/counter"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure221 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v65, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure222 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure223 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure224 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/counter"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure215 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure216()
    let v69 : US7 = US7_1(v68)
    let v70 : ((string * obj) []) = method13(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v69, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    let v77 : (Mut3 -> JSX.Element) = closure36()
    let v78 : (obj -> JSX.Element) = v77 |> unbox<obj -> JSX.Element>
    let struct (v79 : US3, v80 : US3, v81 : US3, v82 : US5, v83 : US3, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US6, v90 : US7, v91 : US3, v92 : US3, v93 : US6, v94 : US8, v95 : US3, v96 : US3, v97 : US3, v98 : US9, v99 : US6, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US10, v106 : US3, v107 : US3, v108 : US3, v109 : US10, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US11, v119 : US12, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US10, v138 : US3, v139 : US3, v140 : US8, v141 : US3, v142 : US2, v143 : US3) = method11()
    let v144 : (Mut8 -> JSX.Element) = closure43()
    let v145 : (obj -> JSX.Element) = v144 |> unbox<obj -> JSX.Element>
    let v146 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure217()
    let v147 : (unit -> JS.Function) = closure218()
    let v148 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure45()
    let v149 : Mut8 = {l0 = v146; l1 = v147; l2 = v148} : Mut8
    let v150 : obj = v149
    let v151 : JS.Function = import v73 v74
    let v152 : JSX.Element = v151.Invoke (v145, v150) |> unbox<JSX.Element>
    let v153 : (unit -> (JSX.Element [])) = closure219()
    let v154 : US7 = US7_1(v153)
    let v155 : US10 = US10_1(v152)
    let v156 : (unit -> unit) = closure220()
    let v157 : US12 = US12_1(v156)
    let v158 : string = "10px"
    let v159 : US3 = US3_1(v158)
    let v160 : Mut3 = {l0 = v79; l1 = v80; l2 = v81; l3 = v82; l4 = v83; l5 = v84; l6 = v85; l7 = v86; l8 = v87; l9 = v88; l10 = v89; l11 = v154; l12 = v91; l13 = v92; l14 = v93; l15 = v94; l16 = v95; l17 = v96; l18 = v97; l19 = v98; l20 = v99; l21 = v100; l22 = v101; l23 = v102; l24 = v103; l25 = v104; l26 = v105; l27 = v106; l28 = v107; l29 = v108; l30 = v155; l31 = v110; l32 = v111; l33 = v112; l34 = v113; l35 = v114; l36 = v115; l37 = v116; l38 = v117; l39 = v118; l40 = v157; l41 = v120; l42 = v121; l43 = v122; l44 = v123; l45 = v124; l46 = v125; l47 = v126; l48 = v127; l49 = v159; l50 = v129; l51 = v130; l52 = v131; l53 = v132; l54 = v133; l55 = v134; l56 = v135; l57 = v136; l58 = v137; l59 = v138; l60 = v139; l61 = v140; l62 = v141; l63 = v142; l64 = v143} : Mut3
    emitJsExpr (v160, v153) "$0.children = $1"
    let v161 : obj = v160
    let v162 : JS.Function = import v73 v74
    let v163 : JSX.Element = v162.Invoke (v78, v161) |> unbox<JSX.Element>
    let v164 : (obj -> JSX.Element) = v77 |> unbox<obj -> JSX.Element>
    let struct (v165 : US3, v166 : US3, v167 : US3, v168 : US5, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US6, v176 : US7, v177 : US3, v178 : US3, v179 : US6, v180 : US8, v181 : US3, v182 : US3, v183 : US3, v184 : US9, v185 : US6, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US10, v192 : US3, v193 : US3, v194 : US3, v195 : US10, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US11, v205 : US12, v206 : US11, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US10, v224 : US3, v225 : US3, v226 : US8, v227 : US3, v228 : US2, v229 : US3) = method11()
    let v230 : (obj -> JSX.Element) = v144 |> unbox<obj -> JSX.Element>
    let v231 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure221()
    let v232 : (unit -> JS.Function) = closure222()
    let v233 : Mut8 = {l0 = v231; l1 = v232; l2 = v148} : Mut8
    let v234 : obj = v233
    let v235 : JS.Function = import v73 v74
    let v236 : JSX.Element = v235.Invoke (v230, v234) |> unbox<JSX.Element>
    let v237 : (unit -> (JSX.Element [])) = closure223()
    let v238 : US7 = US7_1(v237)
    let v239 : US10 = US10_1(v236)
    let v240 : (unit -> unit) = closure224()
    let v241 : US12 = US12_1(v240)
    let v242 : US3 = US3_1(v158)
    let v243 : Mut3 = {l0 = v165; l1 = v166; l2 = v167; l3 = v168; l4 = v169; l5 = v170; l6 = v171; l7 = v172; l8 = v173; l9 = v174; l10 = v175; l11 = v238; l12 = v177; l13 = v178; l14 = v179; l15 = v180; l16 = v181; l17 = v182; l18 = v183; l19 = v184; l20 = v185; l21 = v186; l22 = v187; l23 = v188; l24 = v189; l25 = v190; l26 = v191; l27 = v192; l28 = v193; l29 = v194; l30 = v239; l31 = v196; l32 = v197; l33 = v198; l34 = v199; l35 = v200; l36 = v201; l37 = v202; l38 = v203; l39 = v204; l40 = v241; l41 = v206; l42 = v207; l43 = v208; l44 = v209; l45 = v210; l46 = v211; l47 = v212; l48 = v213; l49 = v242; l50 = v215; l51 = v216; l52 = v217; l53 = v218; l54 = v219; l55 = v220; l56 = v221; l57 = v222; l58 = v223; l59 = v224; l60 = v225; l61 = v226; l62 = v227; l63 = v228; l64 = v229} : Mut3
    emitJsExpr (v243, v237) "$0.children = $1"
    let v244 : obj = v243
    let v245 : JS.Function = import v73 v74
    let v246 : JSX.Element = v245.Invoke (v164, v244) |> unbox<JSX.Element>
    [|v76; v163; v246|]
and method41 (v0 : int32, v1 : Mut17) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method42 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method42(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method44 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method44(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method45 (v0 : (struct (int32 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method45(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method43 (v0 : UH1) : (struct (int32 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method44(v0, v1)
    let v3 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method45(v3, v0, v4)
    v3
and closure230 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure229 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US5, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US6, v16 : US7, v17 : US3, v18 : US3, v19 : US6, v20 : US8, v21 : US3, v22 : US3, v23 : US3, v24 : US9, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US11, v45 : US12, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US10, v64 : US3, v65 : US3, v66 : US8, v67 : US3, v68 : US2, v69 : US3) = method11()
    let v70 : (unit -> (JSX.Element [])) = closure230(v0)
    let v71 : US7 = US7_1(v70)
    let v72 : ((string * obj) []) = method13(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v71, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v73 : obj = createObj v72
    let v74 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    [|v78|]
and closure228 (v0 : (unit -> struct (int32 * int32))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let struct (v66 : int32, v67 : int32) = v0 ()
    let v68 : string = v66.ToString ()
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure229(v0)
    let v71 : US7 = US7_1(v70)
    let v72 : string = "3px"
    let v73 : US3 = US3_1(v72)
    let v74 : US10 = US10_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v73, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v74, v60, v61, v62, v63, v64, v65)
and closure227 () (v0 : (unit -> struct (int32 * int32))) : (JSX.Element []) =
    let v1 : (Mut5 -> JSX.Element) = closure22()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure228(v0)
    let v6 : US14 = US14_2
    let v7 : Mut5 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6} : Mut5
    let v8 : obj = v7
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v2, v8) |> unbox<JSX.Element>
    [|v12|]
and closure226 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v3.Length
    let v5 : UH1 = UH1_1
    let v6 : Mut17 = {l0 = 0; l1 = v5} : Mut17
    while method41(v4, v6) do
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
    let v19 : UH1 = method42(v17, v18)
    let v20 : (struct (int32 * int32) []) = method43(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * int32)) -> (JSX.Element [])) = closure227()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US3, v29 : US5, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US6, v37 : US7, v38 : US3, v39 : US3, v40 : US6, v41 : US8, v42 : US3, v43 : US3, v44 : US3, v45 : US9, v46 : US6, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US10, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US12, v67 : US11, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US10, v85 : US3, v86 : US3, v87 : US8, v88 : US3, v89 : US2, v90 : US3) = method11()
    let v91 : (obj []) = v20 |> unbox<obj[]>
    let v92 : US7 = US7_1(v25)
    let v93 : US9 = US9_1(v91)
    let v94 : ((string * obj) []) = method13(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v92, v38, v39, v40, v41, v42, v43, v44, v93, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90)
    let v95 : obj = createObj v94
    let v96 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v97 : string = "createComponent"
    let v98 : JS.Function = import v97 v22
    let v99 : JSX.Element = v98.Invoke (v96, v95) |> unbox<JSX.Element>
    [|v99|]
and closure225 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure18()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure226(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : Mut3 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v69; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65; l63 = v66; l64 = v67} : Mut3
    emitJsExpr (v70, v68) "$0.children = $1"
    let v71 : obj = v70
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v2, v71) |> unbox<JSX.Element>
    [|v75|]
and closure214 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : string = "Stack"
    let v67 : string = "@hope-ui/solid"
    let v68 : JS.Function = import v66 v67
    let struct (v69 : US3, v70 : US3, v71 : US3, v72 : US5, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US6, v80 : US7, v81 : US3, v82 : US3, v83 : US6, v84 : US8, v85 : US3, v86 : US3, v87 : US3, v88 : US9, v89 : US6, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US10, v96 : US3, v97 : US3, v98 : US3, v99 : US10, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US11, v109 : US12, v110 : US11, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US10, v128 : US3, v129 : US3, v130 : US8, v131 : US3, v132 : US2, v133 : US3) = method11()
    let v134 : string = "row"
    let v135 : string = "column"
    let v136 : string = method19(v135, v134)
    let v137 : string = "0"
    let v138 : string = "8px"
    let v139 : string = method19(v138, v137)
    let v140 : string = "start"
    let v141 : US3 = US3_1(v140)
    let v142 : (unit -> (JSX.Element [])) = closure215()
    let v143 : US7 = US7_1(v142)
    let v144 : US3 = US3_1(v136)
    let v145 : US3 = US3_1(v139)
    let v146 : string = "3px"
    let v147 : US3 = US3_1(v146)
    let v148 : string = "7px"
    let v149 : US3 = US3_1(v148)
    let v150 : ((string * obj) []) = method13(v141, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v143, v81, v82, v83, v84, v85, v144, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v145, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v147, v116, v117, v118, v119, v120, v121, v122, v149, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133)
    let v151 : obj = createObj v150
    let v152 : (obj -> JSX.Element) = v68 |> unbox<obj -> JSX.Element>
    let v153 : string = "createComponent"
    let v154 : string = "solid-js"
    let v155 : JS.Function = import v153 v154
    let v156 : JSX.Element = v155.Invoke (v152, v151) |> unbox<JSX.Element>
    let v157 : (unit -> (JSX.Element [])) = closure225(v0)
    let v158 : US7 = US7_1(v157)
    let v159 : string = "counter"
    let v160 : US3 = US3_1(v159)
    let v161 : US10 = US10_1(v156)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v158, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v160, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v161, v60, v61, v62, v63, v64, v65)
and method40 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let v9 : (Mut5 -> JSX.Element) = closure22()
    let v10 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v11 : US13 = US13_0
    let v12 : US13 = US13_0
    let v13 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure214(v4)
    let v14 : US14 = US14_2
    let v15 : Mut5 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14} : Mut5
    let v16 : obj = v15
    let v17 : string = "createComponent"
    let v18 : string = "solid-js"
    let v19 : JS.Function = import v17 v18
    let v20 : JSX.Element = v19.Invoke (v10, v16) |> unbox<JSX.Element>
    v20
and closure213 () (v0 : Mut3) : JSX.Element =
    method40()
and closure231 () () : (JSX.Element []) =
    [||]
and closure235 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure236 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v65, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure237 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure238 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_status"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure239 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v65, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure240 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure241 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_status"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure234 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure235()
    let v69 : US7 = US7_1(v68)
    let v70 : ((string * obj) []) = method13(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v69, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    let v77 : (Mut3 -> JSX.Element) = closure36()
    let v78 : (obj -> JSX.Element) = v77 |> unbox<obj -> JSX.Element>
    let struct (v79 : US3, v80 : US3, v81 : US3, v82 : US5, v83 : US3, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US6, v90 : US7, v91 : US3, v92 : US3, v93 : US6, v94 : US8, v95 : US3, v96 : US3, v97 : US3, v98 : US9, v99 : US6, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US10, v106 : US3, v107 : US3, v108 : US3, v109 : US10, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US11, v119 : US12, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US10, v138 : US3, v139 : US3, v140 : US8, v141 : US3, v142 : US2, v143 : US3) = method11()
    let v144 : (Mut8 -> JSX.Element) = closure43()
    let v145 : (obj -> JSX.Element) = v144 |> unbox<obj -> JSX.Element>
    let v146 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure236()
    let v147 : (unit -> JS.Function) = closure218()
    let v148 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure45()
    let v149 : Mut8 = {l0 = v146; l1 = v147; l2 = v148} : Mut8
    let v150 : obj = v149
    let v151 : JS.Function = import v73 v74
    let v152 : JSX.Element = v151.Invoke (v145, v150) |> unbox<JSX.Element>
    let v153 : (unit -> (JSX.Element [])) = closure237()
    let v154 : US7 = US7_1(v153)
    let v155 : US10 = US10_1(v152)
    let v156 : (unit -> unit) = closure238()
    let v157 : US12 = US12_1(v156)
    let v158 : string = "10px"
    let v159 : US3 = US3_1(v158)
    let v160 : Mut3 = {l0 = v79; l1 = v80; l2 = v81; l3 = v82; l4 = v83; l5 = v84; l6 = v85; l7 = v86; l8 = v87; l9 = v88; l10 = v89; l11 = v154; l12 = v91; l13 = v92; l14 = v93; l15 = v94; l16 = v95; l17 = v96; l18 = v97; l19 = v98; l20 = v99; l21 = v100; l22 = v101; l23 = v102; l24 = v103; l25 = v104; l26 = v105; l27 = v106; l28 = v107; l29 = v108; l30 = v155; l31 = v110; l32 = v111; l33 = v112; l34 = v113; l35 = v114; l36 = v115; l37 = v116; l38 = v117; l39 = v118; l40 = v157; l41 = v120; l42 = v121; l43 = v122; l44 = v123; l45 = v124; l46 = v125; l47 = v126; l48 = v127; l49 = v159; l50 = v129; l51 = v130; l52 = v131; l53 = v132; l54 = v133; l55 = v134; l56 = v135; l57 = v136; l58 = v137; l59 = v138; l60 = v139; l61 = v140; l62 = v141; l63 = v142; l64 = v143} : Mut3
    emitJsExpr (v160, v153) "$0.children = $1"
    let v161 : obj = v160
    let v162 : JS.Function = import v73 v74
    let v163 : JSX.Element = v162.Invoke (v78, v161) |> unbox<JSX.Element>
    let v164 : (obj -> JSX.Element) = v77 |> unbox<obj -> JSX.Element>
    let struct (v165 : US3, v166 : US3, v167 : US3, v168 : US5, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US6, v176 : US7, v177 : US3, v178 : US3, v179 : US6, v180 : US8, v181 : US3, v182 : US3, v183 : US3, v184 : US9, v185 : US6, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US10, v192 : US3, v193 : US3, v194 : US3, v195 : US10, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US11, v205 : US12, v206 : US11, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US10, v224 : US3, v225 : US3, v226 : US8, v227 : US3, v228 : US2, v229 : US3) = method11()
    let v230 : (obj -> JSX.Element) = v144 |> unbox<obj -> JSX.Element>
    let v231 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure239()
    let v232 : (unit -> JS.Function) = closure222()
    let v233 : Mut8 = {l0 = v231; l1 = v232; l2 = v148} : Mut8
    let v234 : obj = v233
    let v235 : JS.Function = import v73 v74
    let v236 : JSX.Element = v235.Invoke (v230, v234) |> unbox<JSX.Element>
    let v237 : (unit -> (JSX.Element [])) = closure240()
    let v238 : US7 = US7_1(v237)
    let v239 : US10 = US10_1(v236)
    let v240 : (unit -> unit) = closure241()
    let v241 : US12 = US12_1(v240)
    let v242 : US3 = US3_1(v158)
    let v243 : Mut3 = {l0 = v165; l1 = v166; l2 = v167; l3 = v168; l4 = v169; l5 = v170; l6 = v171; l7 = v172; l8 = v173; l9 = v174; l10 = v175; l11 = v238; l12 = v177; l13 = v178; l14 = v179; l15 = v180; l16 = v181; l17 = v182; l18 = v183; l19 = v184; l20 = v185; l21 = v186; l22 = v187; l23 = v188; l24 = v189; l25 = v190; l26 = v191; l27 = v192; l28 = v193; l29 = v194; l30 = v239; l31 = v196; l32 = v197; l33 = v198; l34 = v199; l35 = v200; l36 = v201; l37 = v202; l38 = v203; l39 = v204; l40 = v241; l41 = v206; l42 = v207; l43 = v208; l44 = v209; l45 = v210; l46 = v211; l47 = v212; l48 = v213; l49 = v242; l50 = v215; l51 = v216; l52 = v217; l53 = v218; l54 = v219; l55 = v220; l56 = v221; l57 = v222; l58 = v223; l59 = v224; l60 = v225; l61 = v226; l62 = v227; l63 = v228; l64 = v229} : Mut3
    emitJsExpr (v243, v237) "$0.children = $1"
    let v244 : obj = v243
    let v245 : JS.Function = import v73 v74
    let v246 : JSX.Element = v245.Invoke (v164, v244) |> unbox<JSX.Element>
    [|v76; v163; v246|]
and method47 (v0 : int32, v1 : Mut18) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method48 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method48(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method50 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method50(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method51 (v0 : (struct (int32 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method51(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method49 (v0 : UH2) : (struct (int32 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method50(v0, v1)
    let v3 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method51(v3, v0, v4)
    v3
and closure247 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure246 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US5, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US6, v16 : US7, v17 : US3, v18 : US3, v19 : US6, v20 : US8, v21 : US3, v22 : US3, v23 : US3, v24 : US9, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US11, v45 : US12, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US10, v64 : US3, v65 : US3, v66 : US8, v67 : US3, v68 : US2, v69 : US3) = method11()
    let v70 : (unit -> (JSX.Element [])) = closure247(v0)
    let v71 : US7 = US7_1(v70)
    let v72 : ((string * obj) []) = method13(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v71, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v73 : obj = createObj v72
    let v74 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    [|v78|]
and closure245 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let struct (v66 : int32, v67 : obj) = v0 ()
    let v68 : string = v66.ToString ()
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure246(v0)
    let v71 : US7 = US7_1(v70)
    let v72 : string = "3px"
    let v73 : US3 = US3_1(v72)
    let v74 : US10 = US10_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v73, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v74, v60, v61, v62, v63, v64, v65)
and closure244 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut5 -> JSX.Element) = closure22()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure245(v0)
    let v6 : US14 = US14_2
    let v7 : Mut5 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6} : Mut5
    let v8 : obj = v7
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v2, v8) |> unbox<JSX.Element>
    [|v12|]
and closure243 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v2.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut18 = {l0 = 0; l1 = v5} : Mut18
    while method47(v4, v6) do
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
    let v19 : UH2 = method48(v17, v18)
    let v20 : (struct (int32 * obj) []) = method49(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure244()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US3, v29 : US5, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US6, v37 : US7, v38 : US3, v39 : US3, v40 : US6, v41 : US8, v42 : US3, v43 : US3, v44 : US3, v45 : US9, v46 : US6, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US10, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US12, v67 : US11, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US10, v85 : US3, v86 : US3, v87 : US8, v88 : US3, v89 : US2, v90 : US3) = method11()
    let v91 : (obj []) = v20 |> unbox<obj[]>
    let v92 : US7 = US7_1(v25)
    let v93 : US9 = US9_1(v91)
    let v94 : ((string * obj) []) = method13(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v92, v38, v39, v40, v41, v42, v43, v44, v93, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90)
    let v95 : obj = createObj v94
    let v96 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v97 : string = "createComponent"
    let v98 : JS.Function = import v97 v22
    let v99 : JSX.Element = v98.Invoke (v96, v95) |> unbox<JSX.Element>
    [|v99|]
and closure242 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure18()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure243(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : Mut3 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v69; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65; l63 = v66; l64 = v67} : Mut3
    emitJsExpr (v70, v68) "$0.children = $1"
    let v71 : obj = v70
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v2, v71) |> unbox<JSX.Element>
    [|v75|]
and closure233 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : string = "Stack"
    let v67 : string = "@hope-ui/solid"
    let v68 : JS.Function = import v66 v67
    let struct (v69 : US3, v70 : US3, v71 : US3, v72 : US5, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US6, v80 : US7, v81 : US3, v82 : US3, v83 : US6, v84 : US8, v85 : US3, v86 : US3, v87 : US3, v88 : US9, v89 : US6, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US10, v96 : US3, v97 : US3, v98 : US3, v99 : US10, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US11, v109 : US12, v110 : US11, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US10, v128 : US3, v129 : US3, v130 : US8, v131 : US3, v132 : US2, v133 : US3) = method11()
    let v134 : string = "row"
    let v135 : string = "column"
    let v136 : string = method19(v135, v134)
    let v137 : string = "0"
    let v138 : string = "8px"
    let v139 : string = method19(v138, v137)
    let v140 : string = "start"
    let v141 : US3 = US3_1(v140)
    let v142 : (unit -> (JSX.Element [])) = closure234()
    let v143 : US7 = US7_1(v142)
    let v144 : US3 = US3_1(v136)
    let v145 : US3 = US3_1(v139)
    let v146 : string = "3px"
    let v147 : US3 = US3_1(v146)
    let v148 : string = "7px"
    let v149 : US3 = US3_1(v148)
    let v150 : ((string * obj) []) = method13(v141, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v143, v81, v82, v83, v84, v85, v144, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v145, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v147, v116, v117, v118, v119, v120, v121, v122, v149, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133)
    let v151 : obj = createObj v150
    let v152 : (obj -> JSX.Element) = v68 |> unbox<obj -> JSX.Element>
    let v153 : string = "createComponent"
    let v154 : string = "solid-js"
    let v155 : JS.Function = import v153 v154
    let v156 : JSX.Element = v155.Invoke (v152, v151) |> unbox<JSX.Element>
    let v157 : (unit -> (JSX.Element [])) = closure242(v0)
    let v158 : US7 = US7_1(v157)
    let v159 : string = "status"
    let v160 : US3 = US3_1(v159)
    let v161 : US10 = US10_1(v156)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v158, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v160, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v161, v60, v61, v62, v63, v64, v65)
and method46 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let v9 : (Mut5 -> JSX.Element) = closure22()
    let v10 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v11 : US13 = US13_0
    let v12 : US13 = US13_0
    let v13 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure233(v4)
    let v14 : US14 = US14_2
    let v15 : Mut5 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14} : Mut5
    let v16 : obj = v15
    let v17 : string = "createComponent"
    let v18 : string = "solid-js"
    let v19 : JS.Function = import v17 v18
    let v20 : JSX.Element = v19.Invoke (v10, v16) |> unbox<JSX.Element>
    v20
and closure232 () (v0 : Mut3) : JSX.Element =
    method46()
and closure248 () () : (JSX.Element []) =
    [||]
and closure252 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure253 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v65, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure254 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure255 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_deploy"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure256 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v65, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
and closure257 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure258 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_deploy"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure251 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure252()
    let v69 : US7 = US7_1(v68)
    let v70 : ((string * obj) []) = method13(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v69, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    let v77 : (Mut3 -> JSX.Element) = closure36()
    let v78 : (obj -> JSX.Element) = v77 |> unbox<obj -> JSX.Element>
    let struct (v79 : US3, v80 : US3, v81 : US3, v82 : US5, v83 : US3, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US6, v90 : US7, v91 : US3, v92 : US3, v93 : US6, v94 : US8, v95 : US3, v96 : US3, v97 : US3, v98 : US9, v99 : US6, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US10, v106 : US3, v107 : US3, v108 : US3, v109 : US10, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US11, v119 : US12, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US10, v138 : US3, v139 : US3, v140 : US8, v141 : US3, v142 : US2, v143 : US3) = method11()
    let v144 : (Mut8 -> JSX.Element) = closure43()
    let v145 : (obj -> JSX.Element) = v144 |> unbox<obj -> JSX.Element>
    let v146 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure253()
    let v147 : (unit -> JS.Function) = closure218()
    let v148 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure45()
    let v149 : Mut8 = {l0 = v146; l1 = v147; l2 = v148} : Mut8
    let v150 : obj = v149
    let v151 : JS.Function = import v73 v74
    let v152 : JSX.Element = v151.Invoke (v145, v150) |> unbox<JSX.Element>
    let v153 : (unit -> (JSX.Element [])) = closure254()
    let v154 : US7 = US7_1(v153)
    let v155 : US10 = US10_1(v152)
    let v156 : (unit -> unit) = closure255()
    let v157 : US12 = US12_1(v156)
    let v158 : string = "10px"
    let v159 : US3 = US3_1(v158)
    let v160 : Mut3 = {l0 = v79; l1 = v80; l2 = v81; l3 = v82; l4 = v83; l5 = v84; l6 = v85; l7 = v86; l8 = v87; l9 = v88; l10 = v89; l11 = v154; l12 = v91; l13 = v92; l14 = v93; l15 = v94; l16 = v95; l17 = v96; l18 = v97; l19 = v98; l20 = v99; l21 = v100; l22 = v101; l23 = v102; l24 = v103; l25 = v104; l26 = v105; l27 = v106; l28 = v107; l29 = v108; l30 = v155; l31 = v110; l32 = v111; l33 = v112; l34 = v113; l35 = v114; l36 = v115; l37 = v116; l38 = v117; l39 = v118; l40 = v157; l41 = v120; l42 = v121; l43 = v122; l44 = v123; l45 = v124; l46 = v125; l47 = v126; l48 = v127; l49 = v159; l50 = v129; l51 = v130; l52 = v131; l53 = v132; l54 = v133; l55 = v134; l56 = v135; l57 = v136; l58 = v137; l59 = v138; l60 = v139; l61 = v140; l62 = v141; l63 = v142; l64 = v143} : Mut3
    emitJsExpr (v160, v153) "$0.children = $1"
    let v161 : obj = v160
    let v162 : JS.Function = import v73 v74
    let v163 : JSX.Element = v162.Invoke (v78, v161) |> unbox<JSX.Element>
    let v164 : (obj -> JSX.Element) = v77 |> unbox<obj -> JSX.Element>
    let struct (v165 : US3, v166 : US3, v167 : US3, v168 : US5, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US6, v176 : US7, v177 : US3, v178 : US3, v179 : US6, v180 : US8, v181 : US3, v182 : US3, v183 : US3, v184 : US9, v185 : US6, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US10, v192 : US3, v193 : US3, v194 : US3, v195 : US10, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US11, v205 : US12, v206 : US11, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US10, v224 : US3, v225 : US3, v226 : US8, v227 : US3, v228 : US2, v229 : US3) = method11()
    let v230 : (obj -> JSX.Element) = v144 |> unbox<obj -> JSX.Element>
    let v231 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure256()
    let v232 : (unit -> JS.Function) = closure222()
    let v233 : Mut8 = {l0 = v231; l1 = v232; l2 = v148} : Mut8
    let v234 : obj = v233
    let v235 : JS.Function = import v73 v74
    let v236 : JSX.Element = v235.Invoke (v230, v234) |> unbox<JSX.Element>
    let v237 : (unit -> (JSX.Element [])) = closure257()
    let v238 : US7 = US7_1(v237)
    let v239 : US10 = US10_1(v236)
    let v240 : (unit -> unit) = closure258()
    let v241 : US12 = US12_1(v240)
    let v242 : US3 = US3_1(v158)
    let v243 : Mut3 = {l0 = v165; l1 = v166; l2 = v167; l3 = v168; l4 = v169; l5 = v170; l6 = v171; l7 = v172; l8 = v173; l9 = v174; l10 = v175; l11 = v238; l12 = v177; l13 = v178; l14 = v179; l15 = v180; l16 = v181; l17 = v182; l18 = v183; l19 = v184; l20 = v185; l21 = v186; l22 = v187; l23 = v188; l24 = v189; l25 = v190; l26 = v191; l27 = v192; l28 = v193; l29 = v194; l30 = v239; l31 = v196; l32 = v197; l33 = v198; l34 = v199; l35 = v200; l36 = v201; l37 = v202; l38 = v203; l39 = v204; l40 = v241; l41 = v206; l42 = v207; l43 = v208; l44 = v209; l45 = v210; l46 = v211; l47 = v212; l48 = v213; l49 = v242; l50 = v215; l51 = v216; l52 = v217; l53 = v218; l54 = v219; l55 = v220; l56 = v221; l57 = v222; l58 = v223; l59 = v224; l60 = v225; l61 = v226; l62 = v227; l63 = v228; l64 = v229} : Mut3
    emitJsExpr (v243, v237) "$0.children = $1"
    let v244 : obj = v243
    let v245 : JS.Function = import v73 v74
    let v246 : JSX.Element = v245.Invoke (v164, v244) |> unbox<JSX.Element>
    [|v76; v163; v246|]
and closure264 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure263 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US5, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US6, v16 : US7, v17 : US3, v18 : US3, v19 : US6, v20 : US8, v21 : US3, v22 : US3, v23 : US3, v24 : US9, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US11, v45 : US12, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US10, v64 : US3, v65 : US3, v66 : US8, v67 : US3, v68 : US2, v69 : US3) = method11()
    let v70 : (unit -> (JSX.Element [])) = closure264(v0)
    let v71 : US7 = US7_1(v70)
    let v72 : ((string * obj) []) = method13(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v71, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v73 : obj = createObj v72
    let v74 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    [|v78|]
and closure262 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let struct (v66 : int32, v67 : obj) = v0 ()
    let v68 : string = v66.ToString ()
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure263(v0)
    let v71 : US7 = US7_1(v70)
    let v72 : string = "3px"
    let v73 : US3 = US3_1(v72)
    let v74 : US10 = US10_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v73, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v74, v60, v61, v62, v63, v64, v65)
and closure261 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut5 -> JSX.Element) = closure22()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure262(v0)
    let v6 : US14 = US14_2
    let v7 : Mut5 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6} : Mut5
    let v8 : obj = v7
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v2, v8) |> unbox<JSX.Element>
    [|v12|]
and closure260 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v1.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut18 = {l0 = 0; l1 = v5} : Mut18
    while method47(v4, v6) do
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
    let v19 : UH2 = method48(v17, v18)
    let v20 : (struct (int32 * obj) []) = method49(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure261()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US3, v29 : US5, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US6, v37 : US7, v38 : US3, v39 : US3, v40 : US6, v41 : US8, v42 : US3, v43 : US3, v44 : US3, v45 : US9, v46 : US6, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US10, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US12, v67 : US11, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US10, v85 : US3, v86 : US3, v87 : US8, v88 : US3, v89 : US2, v90 : US3) = method11()
    let v91 : (obj []) = v20 |> unbox<obj[]>
    let v92 : US7 = US7_1(v25)
    let v93 : US9 = US9_1(v91)
    let v94 : ((string * obj) []) = method13(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v92, v38, v39, v40, v41, v42, v43, v44, v93, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90)
    let v95 : obj = createObj v94
    let v96 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v97 : string = "createComponent"
    let v98 : JS.Function = import v97 v22
    let v99 : JSX.Element = v98.Invoke (v96, v95) |> unbox<JSX.Element>
    [|v99|]
and closure259 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure18()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method11()
    let v68 : (unit -> (JSX.Element [])) = closure260(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : Mut3 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v69; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65; l63 = v66; l64 = v67} : Mut3
    emitJsExpr (v70, v68) "$0.children = $1"
    let v71 : obj = v70
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v2, v71) |> unbox<JSX.Element>
    [|v75|]
and closure250 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v66 : string = "Stack"
    let v67 : string = "@hope-ui/solid"
    let v68 : JS.Function = import v66 v67
    let struct (v69 : US3, v70 : US3, v71 : US3, v72 : US5, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US6, v80 : US7, v81 : US3, v82 : US3, v83 : US6, v84 : US8, v85 : US3, v86 : US3, v87 : US3, v88 : US9, v89 : US6, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US10, v96 : US3, v97 : US3, v98 : US3, v99 : US10, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US11, v109 : US12, v110 : US11, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US10, v128 : US3, v129 : US3, v130 : US8, v131 : US3, v132 : US2, v133 : US3) = method11()
    let v134 : string = "row"
    let v135 : string = "column"
    let v136 : string = method19(v135, v134)
    let v137 : string = "0"
    let v138 : string = "8px"
    let v139 : string = method19(v138, v137)
    let v140 : string = "start"
    let v141 : US3 = US3_1(v140)
    let v142 : (unit -> (JSX.Element [])) = closure251()
    let v143 : US7 = US7_1(v142)
    let v144 : US3 = US3_1(v136)
    let v145 : US3 = US3_1(v139)
    let v146 : string = "3px"
    let v147 : US3 = US3_1(v146)
    let v148 : string = "7px"
    let v149 : US3 = US3_1(v148)
    let v150 : ((string * obj) []) = method13(v141, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v143, v81, v82, v83, v84, v85, v144, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v145, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v147, v116, v117, v118, v119, v120, v121, v122, v149, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133)
    let v151 : obj = createObj v150
    let v152 : (obj -> JSX.Element) = v68 |> unbox<obj -> JSX.Element>
    let v153 : string = "createComponent"
    let v154 : string = "solid-js"
    let v155 : JS.Function = import v153 v154
    let v156 : JSX.Element = v155.Invoke (v152, v151) |> unbox<JSX.Element>
    let v157 : (unit -> (JSX.Element [])) = closure259(v0)
    let v158 : US7 = US7_1(v157)
    let v159 : string = "deploy"
    let v160 : US3 = US3_1(v159)
    let v161 : US10 = US10_1(v156)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v158, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v160, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v161, v60, v61, v62, v63, v64, v65)
and method52 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let v9 : (Mut5 -> JSX.Element) = closure22()
    let v10 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v11 : US13 = US13_0
    let v12 : US13 = US13_0
    let v13 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure250(v4)
    let v14 : US14 = US14_2
    let v15 : Mut5 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14} : Mut5
    let v16 : obj = v15
    let v17 : string = "createComponent"
    let v18 : string = "solid-js"
    let v19 : JS.Function = import v17 v18
    let v20 : JSX.Element = v19.Invoke (v10, v16) |> unbox<JSX.Element>
    v20
and closure249 () (v0 : Mut3) : JSX.Element =
    method52()
and closure265 () () : (JSX.Element []) =
    [||]
and closure212 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure213()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US3, v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US10, v66 : US3, v67 : US3, v68 : US8, v69 : US3, v70 : US2, v71 : US3) = method11()
    let v72 : (unit -> (JSX.Element [])) = closure231()
    let v73 : US7 = US7_1(v72)
    let v74 : Mut3 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v17; l11 = v73; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69; l63 = v70; l64 = v71} : Mut3
    emitJsExpr (v74, v72) "$0.children = $1"
    let v75 : obj = v74
    let v76 : string = "createComponent"
    let v77 : string = "solid-js"
    let v78 : JS.Function = import v76 v77
    let v79 : JSX.Element = v78.Invoke (v6, v75) |> unbox<JSX.Element>
    let v80 : (Mut3 -> JSX.Element) = closure232()
    let v81 : (obj -> JSX.Element) = v80 |> unbox<obj -> JSX.Element>
    let struct (v82 : US3, v83 : US3, v84 : US3, v85 : US5, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US6, v93 : US7, v94 : US3, v95 : US3, v96 : US6, v97 : US8, v98 : US3, v99 : US3, v100 : US3, v101 : US9, v102 : US6, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US10, v109 : US3, v110 : US3, v111 : US3, v112 : US10, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US11, v122 : US12, v123 : US11, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US10, v141 : US3, v142 : US3, v143 : US8, v144 : US3, v145 : US2, v146 : US3) = method11()
    let v147 : (unit -> (JSX.Element [])) = closure248()
    let v148 : US7 = US7_1(v147)
    let v149 : Mut3 = {l0 = v82; l1 = v83; l2 = v84; l3 = v85; l4 = v86; l5 = v87; l6 = v88; l7 = v89; l8 = v90; l9 = v91; l10 = v92; l11 = v148; l12 = v94; l13 = v95; l14 = v96; l15 = v97; l16 = v98; l17 = v99; l18 = v100; l19 = v101; l20 = v102; l21 = v103; l22 = v104; l23 = v105; l24 = v106; l25 = v107; l26 = v108; l27 = v109; l28 = v110; l29 = v111; l30 = v112; l31 = v113; l32 = v114; l33 = v115; l34 = v116; l35 = v117; l36 = v118; l37 = v119; l38 = v120; l39 = v121; l40 = v122; l41 = v123; l42 = v124; l43 = v125; l44 = v126; l45 = v127; l46 = v128; l47 = v129; l48 = v130; l49 = v131; l50 = v132; l51 = v133; l52 = v134; l53 = v135; l54 = v136; l55 = v137; l56 = v138; l57 = v139; l58 = v140; l59 = v141; l60 = v142; l61 = v143; l62 = v144; l63 = v145; l64 = v146} : Mut3
    emitJsExpr (v149, v147) "$0.children = $1"
    let v150 : obj = v149
    let v151 : JS.Function = import v76 v77
    let v152 : JSX.Element = v151.Invoke (v81, v150) |> unbox<JSX.Element>
    let v154 : bool = v2 = ""
    let v155 : bool = v154 <> true
    let v157 : JSX.Element =
        if v155 then
            v152
        else
            let v156 : JSX.Element = Html.fragment []
            v156
    let v158 : (Mut3 -> JSX.Element) = closure249()
    let v159 : (obj -> JSX.Element) = v158 |> unbox<obj -> JSX.Element>
    let struct (v160 : US3, v161 : US3, v162 : US3, v163 : US5, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US6, v171 : US7, v172 : US3, v173 : US3, v174 : US6, v175 : US8, v176 : US3, v177 : US3, v178 : US3, v179 : US9, v180 : US6, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US10, v187 : US3, v188 : US3, v189 : US3, v190 : US10, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US11, v200 : US12, v201 : US11, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US10, v219 : US3, v220 : US3, v221 : US8, v222 : US3, v223 : US2, v224 : US3) = method11()
    let v225 : (unit -> (JSX.Element [])) = closure265()
    let v226 : US7 = US7_1(v225)
    let v227 : Mut3 = {l0 = v160; l1 = v161; l2 = v162; l3 = v163; l4 = v164; l5 = v165; l6 = v166; l7 = v167; l8 = v168; l9 = v169; l10 = v170; l11 = v226; l12 = v172; l13 = v173; l14 = v174; l15 = v175; l16 = v176; l17 = v177; l18 = v178; l19 = v179; l20 = v180; l21 = v181; l22 = v182; l23 = v183; l24 = v184; l25 = v185; l26 = v186; l27 = v187; l28 = v188; l29 = v189; l30 = v190; l31 = v191; l32 = v192; l33 = v193; l34 = v194; l35 = v195; l36 = v196; l37 = v197; l38 = v198; l39 = v199; l40 = v200; l41 = v201; l42 = v202; l43 = v203; l44 = v204; l45 = v205; l46 = v206; l47 = v207; l48 = v208; l49 = v209; l50 = v210; l51 = v211; l52 = v212; l53 = v213; l54 = v214; l55 = v215; l56 = v216; l57 = v217; l58 = v218; l59 = v219; l60 = v220; l61 = v221; l62 = v222; l63 = v223; l64 = v224} : Mut3
    emitJsExpr (v227, v225) "$0.children = $1"
    let v228 : obj = v227
    let v229 : JS.Function = import v76 v77
    let v230 : JSX.Element = v229.Invoke (v159, v228) |> unbox<JSX.Element>
    let v233 : JSX.Element =
        if v155 then
            v230
        else
            let v232 : JSX.Element = Html.fragment []
            v232
    [|v79; v157; v233|]
and closure211 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure18()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US3, v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US10, v66 : US3, v67 : US3, v68 : US8, v69 : US3, v70 : US2, v71 : US3) = method11()
    let v72 : (unit -> (JSX.Element [])) = closure212(v0, v1, v2, v3, v4)
    let v73 : US7 = US7_1(v72)
    let v74 : Mut3 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v17; l11 = v73; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69; l63 = v70; l64 = v71} : Mut3
    emitJsExpr (v74, v72) "$0.children = $1"
    let v75 : obj = v74
    let v76 : string = "createComponent"
    let v77 : string = "solid-js"
    let v78 : JS.Function = import v76 v77
    let v79 : JSX.Element = v78.Invoke (v6, v75) |> unbox<JSX.Element>
    [|v79|]
and closure210 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US3, v6 : US3, v7 : US3, v8 : US5, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US6, v16 : US7, v17 : US3, v18 : US3, v19 : US6, v20 : US8, v21 : US3, v22 : US3, v23 : US3, v24 : US9, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US11, v45 : US12, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US10, v64 : US3, v65 : US3, v66 : US8, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v70 : string = "Profile"
    let v71 : JSX.Element = Html.fragment [ v70 |> unbox<JSX.Element> ]
    let v72 : (unit -> (JSX.Element [])) = closure211(v0, v1, v2, v3, v4)
    let v73 : US7 = US7_1(v72)
    let v74 : US10 = US10_1(v71)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v73, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v74, v64, v65, v66, v67, v68, v69)
and closure21 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut5 -> JSX.Element) = closure22()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v7 : US13 = US13_0
    let v8 : US13 = US13_0
    let v9 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure57()
    let v10 : US14 = US14_2
    let v11 : Mut5 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10} : Mut5
    let v12 : obj = v11
    let v13 : string = "createComponent"
    let v14 : string = "solid-js"
    let v15 : JS.Function = import v13 v14
    let v16 : JSX.Element = v15.Invoke (v6, v12) |> unbox<JSX.Element>
    let v17 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v18 : US13 = US13_0
    let v19 : US13 = US13_0
    let v20 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure45()
    let v21 : US14 = US14_2
    let v22 : Mut5 = {l0 = v18; l1 = v19; l2 = v20; l3 = v21} : Mut5
    let v23 : obj = v22
    let v24 : JS.Function = import v13 v14
    let v25 : JSX.Element = v24.Invoke (v17, v23) |> unbox<JSX.Element>
    let v26 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v27 : US13 = US13_0
    let v28 : US13 = US13_0
    let v29 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure76()
    let v30 : US14 = US14_2
    let v31 : Mut5 = {l0 = v27; l1 = v28; l2 = v29; l3 = v30} : Mut5
    let v32 : obj = v31
    let v33 : JS.Function = import v13 v14
    let v34 : JSX.Element = v33.Invoke (v26, v32) |> unbox<JSX.Element>
    let v35 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v36 : US13 = US13_0
    let v37 : US13 = US13_0
    let v38 : US14 = US14_2
    let v39 : Mut5 = {l0 = v36; l1 = v37; l2 = v20; l3 = v38} : Mut5
    let v40 : obj = v39
    let v41 : JS.Function = import v13 v14
    let v42 : JSX.Element = v41.Invoke (v35, v40) |> unbox<JSX.Element>
    let v43 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v44 : US13 = US13_0
    let v45 : US13 = US13_0
    let v46 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure88()
    let v47 : US14 = US14_0
    let v48 : Mut5 = {l0 = v44; l1 = v45; l2 = v46; l3 = v47} : Mut5
    let v49 : obj = v48
    let v50 : JS.Function = import v13 v14
    let v51 : JSX.Element = v50.Invoke (v43, v49) |> unbox<JSX.Element>
    let v52 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v53 : US13 = US13_0
    let v54 : US13 = US13_0
    let v55 : US14 = US14_2
    let v56 : Mut5 = {l0 = v53; l1 = v54; l2 = v20; l3 = v55} : Mut5
    let v57 : obj = v56
    let v58 : JS.Function = import v13 v14
    let v59 : JSX.Element = v58.Invoke (v52, v57) |> unbox<JSX.Element>
    let v60 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v61 : US13 = US13_0
    let v62 : US13 = US13_0
    let v63 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure145()
    let v64 : US14 = US14_0
    let v65 : Mut5 = {l0 = v61; l1 = v62; l2 = v63; l3 = v64} : Mut5
    let v66 : obj = v65
    let v67 : JS.Function = import v13 v14
    let v68 : JSX.Element = v67.Invoke (v60, v66) |> unbox<JSX.Element>
    let v69 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v70 : US13 = US13_0
    let v71 : US13 = US13_0
    let v72 : US14 = US14_2
    let v73 : Mut5 = {l0 = v70; l1 = v71; l2 = v20; l3 = v72} : Mut5
    let v74 : obj = v73
    let v75 : JS.Function = import v13 v14
    let v76 : JSX.Element = v75.Invoke (v69, v74) |> unbox<JSX.Element>
    let v77 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v78 : US13 = US13_0
    let v79 : US13 = US13_0
    let v80 : (struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure210(v0, v1, v2, v3, v4)
    let v81 : US14 = US14_2
    let v82 : Mut5 = {l0 = v78; l1 = v79; l2 = v80; l3 = v81} : Mut5
    let v83 : obj = v82
    let v84 : JS.Function = import v13 v14
    let v85 : JSX.Element = v84.Invoke (v77, v83) |> unbox<JSX.Element>
    [|v16; v25; v34; v42; v51; v59; v68; v76; v85|]
and closure6 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut2 -> JSX.Element) = closure7()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v7 : Mut2 = Mut2()
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
    let v17 : (Mut3 -> JSX.Element) = closure18()
    let v18 : (obj -> JSX.Element) = v17 |> unbox<obj -> JSX.Element>
    let struct (v19 : US3, v20 : US3, v21 : US3, v22 : US5, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US6, v30 : US7, v31 : US3, v32 : US3, v33 : US6, v34 : US8, v35 : US3, v36 : US3, v37 : US3, v38 : US9, v39 : US6, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US10, v46 : US3, v47 : US3, v48 : US3, v49 : US10, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US11, v59 : US12, v60 : US11, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US10, v78 : US3, v79 : US3, v80 : US8, v81 : US3, v82 : US2, v83 : US3) = method11()
    let v84 : (unit -> (JSX.Element [])) = closure21(v0, v1, v2, v3, v4)
    let v85 : US7 = US7_1(v84)
    let v86 : string = "flex"
    let v87 : US3 = US3_1(v86)
    let v88 : string = "1"
    let v89 : US3 = US3_1(v88)
    let v90 : string = "column"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "hidden"
    let v93 : US3 = US3_1(v92)
    let v94 : string = "auto"
    let v95 : US3 = US3_1(v94)
    let v96 : Mut3 = {l0 = v19; l1 = v20; l2 = v21; l3 = v22; l4 = v23; l5 = v24; l6 = v25; l7 = v26; l8 = v27; l9 = v28; l10 = v29; l11 = v85; l12 = v31; l13 = v32; l14 = v33; l15 = v34; l16 = v35; l17 = v36; l18 = v87; l19 = v38; l20 = v39; l21 = v89; l22 = v91; l23 = v42; l24 = v43; l25 = v44; l26 = v45; l27 = v46; l28 = v47; l29 = v48; l30 = v49; l31 = v50; l32 = v51; l33 = v52; l34 = v53; l35 = v54; l36 = v55; l37 = v56; l38 = v57; l39 = v58; l40 = v59; l41 = v60; l42 = v61; l43 = v62; l44 = v93; l45 = v95; l46 = v65; l47 = v66; l48 = v67; l49 = v68; l50 = v69; l51 = v70; l52 = v71; l53 = v72; l54 = v73; l55 = v74; l56 = v75; l57 = v76; l58 = v77; l59 = v78; l60 = v79; l61 = v80; l62 = v81; l63 = v82; l64 = v83} : Mut3
    emitJsExpr (v96, v84) "$0.children = $1"
    let v97 : obj = v96
    let v98 : JS.Function = import v9 v10
    let v99 : JSX.Element = v98.Invoke (v18, v97) |> unbox<JSX.Element>
    [|v16; v99|]
and method10 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method1()
    let v5 : string = "Box"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US5, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US7, v20 : US3, v21 : US3, v22 : US6, v23 : US8, v24 : US3, v25 : US3, v26 : US3, v27 : US9, v28 : US6, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US10, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US11, v48 : US12, v49 : US11, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method11()
    let v73 : string = "$bg"
    let v74 : US3 = US3_1(v73)
    let v75 : (unit -> (JSX.Element [])) = closure6(v0, v1, v2, v3, v4)
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
    let v93 : ((string * obj) []) = method13(v8, v9, v10, v11, v74, v13, v14, v15, v16, v17, v18, v76, v78, v21, v22, v23, v24, v25, v80, v27, v28, v82, v84, v86, v88, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v90, v47, v48, v49, v50, v51, v52, v53, v92, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v94 : obj = createObj v93
    let v95 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v96 : string = "createComponent"
    let v97 : string = "solid-js"
    let v98 : JS.Function = import v96 v97
    let v99 : JSX.Element = v98.Invoke (v95, v94) |> unbox<JSX.Element>
    v99
and closure5 () (v0 : Mut3) : JSX.Element =
    method10()
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v67 : obj = emitJsExpr () "process.env"
let v68 : string = "env"
let v69 : (string * obj) = v68, v67
let v70 : ((string * obj) []) = [|v69|]
let v71 : obj = createObj v70
Browser.Dom.window?components_spi <- v71
let struct (v72 : (struct (US0 * string * string * string) []), v73 : US2, v74 : US3, v75 : US3, v76 : (struct (US4 * int32 * string * string) []), v77 : (struct (US4 * US4) []), v78 : (struct (int32 * obj) []), v79 : (struct (int32 * obj) []), v80 : (struct (int32 * int32) []), v81 : US2) = method0()
let v82 : Mut1 = {l0 = v72; l1 = v73; l2 = v74; l3 = v75; l4 = v76; l5 = v77; l6 = v78; l7 = v79; l8 = v80; l9 = v81} : Mut1
let v83 : obj = v82
let v84 : obj = method6(v83)
let v85 : int32 = Random().Next ()
let v86 : string = "db_listener"
let v87 : (Mut2 -> JSX.Element) = closure1(v84)
let v88 : (string * obj) = v86, v87
let v89 : string = "content"
let v90 : (Mut3 -> JSX.Element) = closure5()
let v91 : (string * obj) = v89, v90
let v92 : string = "store"
let v93 : (string * obj) = v92, v84
let v94 : string = "run_id"
let v95 : (string * obj) = v94, v85
let v96 : ((string * obj) []) = [|v88; v91; v93; v95; v69|]
let v97 : obj = createObj v96
Browser.Dom.window?components_spi <- v97
v1.l0 <- v97
()
