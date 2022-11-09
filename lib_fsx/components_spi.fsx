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
and [<Struct>] US5 =
    | US5_0
    | US5_1
    | US5_2
    | US5_3
and Mut1 = {mutable l0 : (struct (US0 * string * string * string) []); mutable l1 : US2; mutable l2 : US3; mutable l3 : US3; mutable l4 : (struct (US4 * int32 * string * string) []); mutable l5 : (struct (US4 * US4) []); mutable l6 : (struct (int32 * obj) []); mutable l7 : (struct (int32 * obj) []); mutable l8 : (struct (int32 * int32) []); mutable l9 : US5; mutable l10 : US2}
and Mut2() = class end
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : JS.Function
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : bool
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : (unit -> (JSX.Element []))
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : obj
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
and Mut3 = {mutable l0 : US3; mutable l1 : US3; mutable l2 : US3; mutable l3 : US6; mutable l4 : US3; mutable l5 : US3; mutable l6 : US3; mutable l7 : US3; mutable l8 : US3; mutable l9 : US3; mutable l10 : US7; mutable l11 : US8; mutable l12 : US3; mutable l13 : US3; mutable l14 : US7; mutable l15 : US9; mutable l16 : US3; mutable l17 : US3; mutable l18 : US3; mutable l19 : US10; mutable l20 : US7; mutable l21 : US3; mutable l22 : US3; mutable l23 : US3; mutable l24 : US3; mutable l25 : US3; mutable l26 : US3; mutable l27 : US11; mutable l28 : US3; mutable l29 : US3; mutable l30 : US3; mutable l31 : US11; mutable l32 : US3; mutable l33 : US3; mutable l34 : US3; mutable l35 : US3; mutable l36 : US3; mutable l37 : US3; mutable l38 : US3; mutable l39 : US3; mutable l40 : US12; mutable l41 : US13; mutable l42 : US12; mutable l43 : US3; mutable l44 : US3; mutable l45 : US3; mutable l46 : US3; mutable l47 : US3; mutable l48 : US3; mutable l49 : US3; mutable l50 : US3; mutable l51 : US3; mutable l52 : US3; mutable l53 : US3; mutable l54 : US3; mutable l55 : US3; mutable l56 : US3; mutable l57 : US3; mutable l58 : US3; mutable l59 : US3; mutable l60 : US11; mutable l61 : US3; mutable l62 : US3; mutable l63 : US9; mutable l64 : US9; mutable l65 : US3; mutable l66 : US2; mutable l67 : US3}
and [<Struct>] US14 =
    | US14_0
    | US14_1 of f1_0 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit))
and Mut4 = {mutable l0 : int32}
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and [<Struct>] US15 =
    | US15_0
    | US15_1
    | US15_2
and Mut5 = {mutable l0 : US14; mutable l1 : US14; mutable l2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)); mutable l3 : US15}
and Mut6 = {mutable l0 : (unit -> bool); mutable l1 : (bool -> unit); mutable l2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))}
and Mut7 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US14; mutable l3 : US14; mutable l4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))}
and Mut8 = {mutable l0 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)); mutable l1 : (unit -> JS.Function); mutable l2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))}
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
and method0 () : struct ((struct (US0 * string * string * string) []) * US2 * US3 * US3 * (struct (US4 * int32 * string * string) []) * (struct (US4 * US4) []) * (struct (int32 * obj) []) * (struct (int32 * obj) []) * (struct (int32 * int32) []) * US5 * US2) =
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
    let v42 : bool = v2 = ""
    let v45 : US5 =
        if v42 then
            US5_0
        else
            US5_3
    let v46 : (struct (int32 * int32) []) = [||]
    let v47 : (struct (int32 * obj) []) = [||]
    let v48 : (struct (int32 * obj) []) = [||]
    let v49 : US2 = US2_1(v11)
    let v50 : US3 = US3_1(v5)
    let v51 : US3 = US3_1(v9)
    let v52 : US2 = US2_0
    struct (v12, v49, v50, v51, v40, v13, v48, v47, v46, v45, v52)
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
and closure3 (v0 : Mut1, v1 : JS.Function, v2 : (Mut1 -> (Mut1 -> unit)), v3 : Mut1) () : unit =
    let v4 : (Mut1 -> unit) = v2 v0
    v4 v3
    let v5 : obj = v3
    v1.Invoke ("set", v5) |> ignore
    ()
and closure2 (v0 : JS.Function, v1 : Mut1, v2 : JS.Function) (v3 : (Mut1 -> (Mut1 -> unit))) : unit =
    let v4 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v5 : obj = createObj v4
    let v6 : Mut1 = v5 |> unbox
    let v7 : (unit -> unit) = closure3(v1, v2, v3, v6)
    v0.Invoke v7 |> ignore
    ()
and method8 () : struct (Mut1 * ((Mut1 -> (Mut1 -> unit)) -> unit)) =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : string = "batch"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v7 : Mut1 = v6.[0] |> unbox
    let v8 : JS.Function = v6.[1] |> unbox
    let v9 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure2(v5, v7, v8)
    struct (v7, v9)
and closure4 (v0 : Mut1) () : bool =
    let struct (v1 : US5, v2 : US2) = v0.l9, v0.l10
    match v1 with
    | US5_0 -> (* Debug *)
        true
    | _ ->
        false
and closure5 () () : (obj []) =
    [||]
and method10 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method10(v0, v4)
    else
        v1
and closure6 (v0 : (unit -> bool), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64) (v9 : (obj [])) : unit =
    let v10 : bool = v0 ()
    if v10 then
        let v11 : int64 = DateTime.UtcNow.Ticks / 1000L
        let v12 : int64 = v11 - v8
        let v13 : string = v12.ToString ()
        let v14 : int32 = 6
        let v15 : string = method10(v14, v13)
        let v16 : int32 = emitJsExpr () "components_spi.run_id"
        let v17 : string = $"[{v15}] {v16}"
        let v18 : string = JS.JSON.stringify v9
        let v19 : (obj []) = v1 ()
        let v20 : string = JS.JSON.stringify v19
        let struct (v25 : string, v26 : string, v27 : string, v28 : string, v29 : string) =
            if v7 then
                let v21 : string = ""
                struct (v17, v18, v20, v21, v21)
            else
                let v22 : string = $"{v17} %%c%%s %%c%%s"
                let v23 : string = $"font-weight: bold; color: {v2}"
                let v24 : string = "font-weight: bold; color: #444"
                struct (v22, v23, v18, v24, v20)
        emitJsExpr () $"console.log.apply(console, {struct (v25, v26, v27, v28, v29)})"
        ()
and method9 (v0 : (unit -> bool), v1 : (unit -> (obj [])), v2 : string) : ((obj []) -> unit) =
    let struct (v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool) = method1()
    let v8 : int64 = DateTime.UtcNow.Ticks / 1000L
    closure6(v0, v1, v2, v3, v4, v5, v6, v7, v8)
and closure7 (v0 : ((obj []) -> unit)) struct (v1 : Mut1, v2 : Mut1, v3 : obj) : unit =
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
and method11 (v0 : (unit -> unit)) : unit =
    let v1 : string = "onCleanup"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    v3.Invoke v0 |> ignore
    ()
and method7 (v0 : obj) : JSX.Element =
    let struct (v1 : Mut1, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v3 : (unit -> bool) = closure4(v1)
    let v4 : (unit -> (obj [])) = closure5()
    let v5 : string = "#cf1100"
    let v6 : ((obj []) -> unit) = method9(v3, v4, v5)
    let v7 : string = "> db_listener ()"
    let v8 : obj = v7
    let v9 : (obj []) = [|v8|]
    v6 v9
    let v10 : JS.Function = v0?on |> unbox<JS.Function>
    let v11 : (struct (Mut1 * Mut1 * obj) -> unit) = closure7(v6)
    let v12 : JS.Function = emitJsExpr v11 "(...args: any[]) => $0(args)"
    let v13 : (unit -> unit) = v10.Invoke ("@changed", v12) |> unbox<unit -> unit>
    method11(v13)
    let v14 : JSX.Element = null
    v14
and closure1 (v0 : obj) (v1 : Mut2) : JSX.Element =
    method7(v0)
and method13 () : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v0 : US3 = US3_0
    let v1 : US3 = US3_0
    let v2 : US3 = US3_0
    let v3 : US6 = US6_0
    let v4 : US3 = US3_0
    let v5 : US3 = US3_0
    let v6 : US3 = US3_0
    let v7 : US3 = US3_0
    let v8 : US3 = US3_0
    let v9 : US3 = US3_0
    let v10 : US7 = US7_0
    let v11 : US8 = US8_0
    let v12 : US3 = US3_0
    let v13 : US3 = US3_0
    let v14 : US7 = US7_0
    let v15 : US9 = US9_0
    let v16 : US3 = US3_0
    let v17 : US3 = US3_0
    let v18 : US3 = US3_0
    let v19 : US10 = US10_0
    let v20 : US7 = US7_0
    let v21 : US3 = US3_0
    let v22 : US3 = US3_0
    let v23 : US3 = US3_0
    let v24 : US3 = US3_0
    let v25 : US3 = US3_0
    let v26 : US3 = US3_0
    let v27 : US11 = US11_0
    let v28 : US3 = US3_0
    let v29 : US3 = US3_0
    let v30 : US3 = US3_0
    let v31 : US11 = US11_0
    let v32 : US3 = US3_0
    let v33 : US3 = US3_0
    let v34 : US3 = US3_0
    let v35 : US3 = US3_0
    let v36 : US3 = US3_0
    let v37 : US3 = US3_0
    let v38 : US3 = US3_0
    let v39 : US3 = US3_0
    let v40 : US12 = US12_0
    let v41 : US13 = US13_0
    let v42 : US12 = US12_0
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
    let v58 : US3 = US3_0
    let v59 : US3 = US3_0
    let v60 : US11 = US11_0
    let v61 : US3 = US3_0
    let v62 : US3 = US3_0
    let v63 : US9 = US9_0
    let v64 : US9 = US9_0
    let v65 : US3 = US3_0
    let v66 : US2 = US2_0
    let v67 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and method15 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure18 () () : (JSX.Element []) =
    [||]
and closure21 (v0 : obj) (v1 : Mut1) : unit =
    let v2 : string = v0.ToString ()
    let v3 : bool = "Debug" = v2
    let v15 : US5 =
        if v3 then
            US5_0
        else
            let v5 : bool = "Info" = v2
            if v5 then
                US5_2
            else
                let v7 : bool = "Warn" = v2
                if v7 then
                    US5_3
                else
                    let v9 : bool = "Error" = v2
                    US5_1
    v1.l9 <- v15
    ()
and closure20 (v0 : obj) (v1 : Mut1) : (Mut1 -> unit) =
    closure21(v0)
and closure19 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) (v1 : obj) : unit =
    let v2 : (Mut1 -> (Mut1 -> unit)) = closure20(v1)
    v0 v2
    ()
and closure25 (v0 : obj) () : (JSX.Element []) =
    let v1 : string = v0.ToString ()
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    let v3 : JSX.Element = Html.fragment [ v2 ]
    [|v3|]
and method19 (v0 : UH0, v1 : int32) : int32 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method19(v3, v4)
    | UH0_1 -> (* Nil *)
        v1
and method20 (v0 : ((string * obj) []), v1 : UH0, v2 : int32) : int32 =
    match v1 with
    | UH0_0(v3, v4) -> (* Cons *)
        v0.[int v2] <- v3
        let v5 : int32 = v2 + 1
        method20(v0, v4, v5)
    | UH0_1 -> (* Nil *)
        v2
and method18 (v0 : UH0) : ((string * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method19(v0, v1)
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method20(v3, v0, v4)
    v3
and method17 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : ((string * obj) []) =
    let v71 : obj =
        match v0 with
        | US3_0 -> (* None *)
            let v68 : obj = ()
            v68
        | US3_1(v69) -> (* Some *)
            let v70 : obj = v69
            v70
    let v72 : bool = emitJsExpr v71 "!$0"
    let v78 : UH0 =
        if v72 then
            UH0_1
        else
            let v74 : string = "alignItems"
            let v75 : (string * obj) = v74, v71
            let v76 : UH0 = UH0_1
            UH0_0(v75, v76)
    let v82 : obj =
        match v1 with
        | US3_0 -> (* None *)
            let v79 : obj = ()
            v79
        | US3_1(v80) -> (* Some *)
            let v81 : obj = v80
            v81
    let v83 : bool = emitJsExpr v82 "!$0"
    let v87 : UH0 =
        if v83 then
            v78
        else
            let v84 : string = "alignSelf"
            let v85 : (string * obj) = v84, v82
            UH0_0(v85, v78)
    let v91 : obj =
        match v2 with
        | US3_0 -> (* None *)
            let v88 : obj = ()
            v88
        | US3_1(v89) -> (* Some *)
            let v90 : obj = v89
            v90
    let v92 : bool = emitJsExpr v91 "!$0"
    let v96 : UH0 =
        if v92 then
            v87
        else
            let v93 : string = "aria-label"
            let v94 : (string * obj) = v93, v91
            UH0_0(v94, v87)
    let v100 : obj =
        match v3 with
        | US6_0 -> (* None *)
            let v97 : obj = ()
            v97
        | US6_1(v98) -> (* Some *)
            let v99 : obj = v98
            v99
    let v101 : bool = emitJsExpr v100 "!$0"
    let v105 : UH0 =
        if v101 then
            v96
        else
            let v102 : string = "as"
            let v103 : (string * obj) = v102, v100
            UH0_0(v103, v96)
    let v109 : obj =
        match v4 with
        | US3_0 -> (* None *)
            let v106 : obj = ()
            v106
        | US3_1(v107) -> (* Some *)
            let v108 : obj = v107
            v108
    let v110 : bool = emitJsExpr v109 "!$0"
    let v114 : UH0 =
        if v110 then
            v105
        else
            let v111 : string = "backgroundColor"
            let v112 : (string * obj) = v111, v109
            UH0_0(v112, v105)
    let v118 : obj =
        match v5 with
        | US3_0 -> (* None *)
            let v115 : obj = ()
            v115
        | US3_1(v116) -> (* Some *)
            let v117 : obj = v116
            v117
    let v119 : bool = emitJsExpr v118 "!$0"
    let v123 : UH0 =
        if v119 then
            v114
        else
            let v120 : string = "border"
            let v121 : (string * obj) = v120, v118
            UH0_0(v121, v114)
    let v127 : obj =
        match v6 with
        | US3_0 -> (* None *)
            let v124 : obj = ()
            v124
        | US3_1(v125) -> (* Some *)
            let v126 : obj = v125
            v126
    let v128 : bool = emitJsExpr v127 "!$0"
    let v132 : UH0 =
        if v128 then
            v123
        else
            let v129 : string = "borderBottomWidth"
            let v130 : (string * obj) = v129, v127
            UH0_0(v130, v123)
    let v136 : obj =
        match v7 with
        | US3_0 -> (* None *)
            let v133 : obj = ()
            v133
        | US3_1(v134) -> (* Some *)
            let v135 : obj = v134
            v135
    let v137 : bool = emitJsExpr v136 "!$0"
    let v141 : UH0 =
        if v137 then
            v132
        else
            let v138 : string = "borderColor"
            let v139 : (string * obj) = v138, v136
            UH0_0(v139, v132)
    let v145 : obj =
        match v8 with
        | US3_0 -> (* None *)
            let v142 : obj = ()
            v142
        | US3_1(v143) -> (* Some *)
            let v144 : obj = v143
            v144
    let v146 : bool = emitJsExpr v145 "!$0"
    let v150 : UH0 =
        if v146 then
            v141
        else
            let v147 : string = "borderWidth"
            let v148 : (string * obj) = v147, v145
            UH0_0(v148, v141)
    let v154 : obj =
        match v9 with
        | US3_0 -> (* None *)
            let v151 : obj = ()
            v151
        | US3_1(v152) -> (* Some *)
            let v153 : obj = v152
            v153
    let v155 : bool = emitJsExpr v154 "!$0"
    let v159 : UH0 =
        if v155 then
            v150
        else
            let v156 : string = "bottom"
            let v157 : (string * obj) = v156, v154
            UH0_0(v157, v150)
    let v163 : obj =
        match v10 with
        | US7_0 -> (* None *)
            let v160 : obj = ()
            v160
        | US7_1(v161) -> (* Some *)
            let v162 : obj = v161
            v162
    let v164 : bool = emitJsExpr v163 "!$0"
    let v168 : UH0 =
        if v164 then
            v159
        else
            let v165 : string = "checked"
            let v166 : (string * obj) = v165, v163
            UH0_0(v166, v159)
    let v172 : obj =
        match v11 with
        | US8_0 -> (* None *)
            let v169 : obj = ()
            v169
        | US8_1(v170) -> (* Some *)
            let v171 : obj = v170
            v171
    let v173 : bool = emitJsExpr v172 "!$0"
    let v177 : UH0 =
        if v173 then
            v168
        else
            let v174 : string = "children"
            let v175 : (string * obj) = v174, v172
            UH0_0(v175, v168)
    let v181 : obj =
        match v12 with
        | US3_0 -> (* None *)
            let v178 : obj = ()
            v178
        | US3_1(v179) -> (* Some *)
            let v180 : obj = v179
            v180
    let v182 : bool = emitJsExpr v181 "!$0"
    let v186 : UH0 =
        if v182 then
            v177
        else
            let v183 : string = "color"
            let v184 : (string * obj) = v183, v181
            UH0_0(v184, v177)
    let v190 : obj =
        match v13 with
        | US3_0 -> (* None *)
            let v187 : obj = ()
            v187
        | US3_1(v188) -> (* Some *)
            let v189 : obj = v188
            v189
    let v191 : bool = emitJsExpr v190 "!$0"
    let v195 : UH0 =
        if v191 then
            v186
        else
            let v192 : string = "colorScheme"
            let v193 : (string * obj) = v192, v190
            UH0_0(v193, v186)
    let v199 : obj =
        match v14 with
        | US7_0 -> (* None *)
            let v196 : obj = ()
            v196
        | US7_1(v197) -> (* Some *)
            let v198 : obj = v197
            v198
    let v200 : bool = emitJsExpr v199 "!$0"
    let v204 : UH0 =
        if v200 then
            v195
        else
            let v201 : string = "compact"
            let v202 : (string * obj) = v201, v199
            UH0_0(v202, v195)
    let v208 : obj =
        match v15 with
        | US9_0 -> (* None *)
            let v205 : obj = ()
            v205
        | US9_1(v206) -> (* Some *)
            let v207 : obj = v206
            v207
    let v209 : bool = emitJsExpr v208 "!$0"
    let v213 : UH0 =
        if v209 then
            v204
        else
            let v210 : string = "css"
            let v211 : (string * obj) = v210, v208
            UH0_0(v211, v204)
    let v217 : obj =
        match v16 with
        | US3_0 -> (* None *)
            let v214 : obj = ()
            v214
        | US3_1(v215) -> (* Some *)
            let v216 : obj = v215
            v216
    let v218 : bool = emitJsExpr v217 "!$0"
    let v222 : UH0 =
        if v218 then
            v213
        else
            let v219 : string = "defaultValue"
            let v220 : (string * obj) = v219, v217
            UH0_0(v220, v213)
    let v226 : obj =
        match v17 with
        | US3_0 -> (* None *)
            let v223 : obj = ()
            v223
        | US3_1(v224) -> (* Some *)
            let v225 : obj = v224
            v225
    let v227 : bool = emitJsExpr v226 "!$0"
    let v231 : UH0 =
        if v227 then
            v222
        else
            let v228 : string = "direction"
            let v229 : (string * obj) = v228, v226
            UH0_0(v229, v222)
    let v235 : obj =
        match v18 with
        | US3_0 -> (* None *)
            let v232 : obj = ()
            v232
        | US3_1(v233) -> (* Some *)
            let v234 : obj = v233
            v234
    let v236 : bool = emitJsExpr v235 "!$0"
    let v240 : UH0 =
        if v236 then
            v231
        else
            let v237 : string = "display"
            let v238 : (string * obj) = v237, v235
            UH0_0(v238, v231)
    let v244 : obj =
        match v19 with
        | US10_0 -> (* None *)
            let v241 : obj = ()
            v241
        | US10_1(v242) -> (* Some *)
            let v243 : obj = v242
            v243
    let v245 : bool = emitJsExpr v244 "!$0"
    let v249 : UH0 =
        if v245 then
            v240
        else
            let v246 : string = "each"
            let v247 : (string * obj) = v246, v244
            UH0_0(v247, v240)
    let v253 : obj =
        match v20 with
        | US7_0 -> (* None *)
            let v250 : obj = ()
            v250
        | US7_1(v251) -> (* Some *)
            let v252 : obj = v251
            v252
    let v254 : bool = emitJsExpr v253 "!$0"
    let v258 : UH0 =
        if v254 then
            v249
        else
            let v255 : string = "external"
            let v256 : (string * obj) = v255, v253
            UH0_0(v256, v249)
    let v262 : obj =
        match v21 with
        | US3_0 -> (* None *)
            let v259 : obj = ()
            v259
        | US3_1(v260) -> (* Some *)
            let v261 : obj = v260
            v261
    let v263 : bool = emitJsExpr v262 "!$0"
    let v267 : UH0 =
        if v263 then
            v258
        else
            let v264 : string = "flex"
            let v265 : (string * obj) = v264, v262
            UH0_0(v265, v258)
    let v271 : obj =
        match v22 with
        | US3_0 -> (* None *)
            let v268 : obj = ()
            v268
        | US3_1(v269) -> (* Some *)
            let v270 : obj = v269
            v270
    let v272 : bool = emitJsExpr v271 "!$0"
    let v276 : UH0 =
        if v272 then
            v267
        else
            let v273 : string = "flexDirection"
            let v274 : (string * obj) = v273, v271
            UH0_0(v274, v267)
    let v280 : obj =
        match v23 with
        | US3_0 -> (* None *)
            let v277 : obj = ()
            v277
        | US3_1(v278) -> (* Some *)
            let v279 : obj = v278
            v279
    let v281 : bool = emitJsExpr v280 "!$0"
    let v285 : UH0 =
        if v281 then
            v276
        else
            let v282 : string = "flexFlow"
            let v283 : (string * obj) = v282, v280
            UH0_0(v283, v276)
    let v289 : obj =
        match v24 with
        | US3_0 -> (* None *)
            let v286 : obj = ()
            v286
        | US3_1(v287) -> (* Some *)
            let v288 : obj = v287
            v288
    let v290 : bool = emitJsExpr v289 "!$0"
    let v294 : UH0 =
        if v290 then
            v285
        else
            let v291 : string = "fontSize"
            let v292 : (string * obj) = v291, v289
            UH0_0(v292, v285)
    let v298 : obj =
        match v25 with
        | US3_0 -> (* None *)
            let v295 : obj = ()
            v295
        | US3_1(v296) -> (* Some *)
            let v297 : obj = v296
            v297
    let v299 : bool = emitJsExpr v298 "!$0"
    let v303 : UH0 =
        if v299 then
            v294
        else
            let v300 : string = "height"
            let v301 : (string * obj) = v300, v298
            UH0_0(v301, v294)
    let v307 : obj =
        match v26 with
        | US3_0 -> (* None *)
            let v304 : obj = ()
            v304
        | US3_1(v305) -> (* Some *)
            let v306 : obj = v305
            v306
    let v308 : bool = emitJsExpr v307 "!$0"
    let v312 : UH0 =
        if v308 then
            v303
        else
            let v309 : string = "href"
            let v310 : (string * obj) = v309, v307
            UH0_0(v310, v303)
    let v316 : obj =
        match v27 with
        | US11_0 -> (* None *)
            let v313 : obj = ()
            v313
        | US11_1(v314) -> (* Some *)
            let v315 : obj = v314
            v315
    let v317 : bool = emitJsExpr v316 "!$0"
    let v321 : UH0 =
        if v317 then
            v312
        else
            let v318 : string = "icon"
            let v319 : (string * obj) = v318, v316
            UH0_0(v319, v312)
    let v325 : obj =
        match v28 with
        | US3_0 -> (* None *)
            let v322 : obj = ()
            v322
        | US3_1(v323) -> (* Some *)
            let v324 : obj = v323
            v324
    let v326 : bool = emitJsExpr v325 "!$0"
    let v330 : UH0 =
        if v326 then
            v321
        else
            let v327 : string = "id"
            let v328 : (string * obj) = v327, v325
            UH0_0(v328, v321)
    let v334 : obj =
        match v29 with
        | US3_0 -> (* None *)
            let v331 : obj = ()
            v331
        | US3_1(v332) -> (* Some *)
            let v333 : obj = v332
            v333
    let v335 : bool = emitJsExpr v334 "!$0"
    let v339 : UH0 =
        if v335 then
            v330
        else
            let v336 : string = "justifyContent"
            let v337 : (string * obj) = v336, v334
            UH0_0(v337, v330)
    let v343 : obj =
        match v30 with
        | US3_0 -> (* None *)
            let v340 : obj = ()
            v340
        | US3_1(v341) -> (* Some *)
            let v342 : obj = v341
            v342
    let v344 : bool = emitJsExpr v343 "!$0"
    let v348 : UH0 =
        if v344 then
            v339
        else
            let v345 : string = "left"
            let v346 : (string * obj) = v345, v343
            UH0_0(v346, v339)
    let v352 : obj =
        match v31 with
        | US11_0 -> (* None *)
            let v349 : obj = ()
            v349
        | US11_1(v350) -> (* Some *)
            let v351 : obj = v350
            v351
    let v353 : bool = emitJsExpr v352 "!$0"
    let v357 : UH0 =
        if v353 then
            v348
        else
            let v354 : string = "leftIcon"
            let v355 : (string * obj) = v354, v352
            UH0_0(v355, v348)
    let v361 : obj =
        match v32 with
        | US3_0 -> (* None *)
            let v358 : obj = ()
            v358
        | US3_1(v359) -> (* Some *)
            let v360 : obj = v359
            v360
    let v362 : bool = emitJsExpr v361 "!$0"
    let v366 : UH0 =
        if v362 then
            v357
        else
            let v363 : string = "lineHeight"
            let v364 : (string * obj) = v363, v361
            UH0_0(v364, v357)
    let v370 : obj =
        match v33 with
        | US3_0 -> (* None *)
            let v367 : obj = ()
            v367
        | US3_1(v368) -> (* Some *)
            let v369 : obj = v368
            v369
    let v371 : bool = emitJsExpr v370 "!$0"
    let v375 : UH0 =
        if v371 then
            v366
        else
            let v372 : string = "margin"
            let v373 : (string * obj) = v372, v370
            UH0_0(v373, v366)
    let v379 : obj =
        match v34 with
        | US3_0 -> (* None *)
            let v376 : obj = ()
            v376
        | US3_1(v377) -> (* Some *)
            let v378 : obj = v377
            v378
    let v380 : bool = emitJsExpr v379 "!$0"
    let v384 : UH0 =
        if v380 then
            v375
        else
            let v381 : string = "marginBottom"
            let v382 : (string * obj) = v381, v379
            UH0_0(v382, v375)
    let v388 : obj =
        match v35 with
        | US3_0 -> (* None *)
            let v385 : obj = ()
            v385
        | US3_1(v386) -> (* Some *)
            let v387 : obj = v386
            v387
    let v389 : bool = emitJsExpr v388 "!$0"
    let v393 : UH0 =
        if v389 then
            v384
        else
            let v390 : string = "marginLeft"
            let v391 : (string * obj) = v390, v388
            UH0_0(v391, v384)
    let v397 : obj =
        match v36 with
        | US3_0 -> (* None *)
            let v394 : obj = ()
            v394
        | US3_1(v395) -> (* Some *)
            let v396 : obj = v395
            v396
    let v398 : bool = emitJsExpr v397 "!$0"
    let v402 : UH0 =
        if v398 then
            v393
        else
            let v399 : string = "marginRight"
            let v400 : (string * obj) = v399, v397
            UH0_0(v400, v393)
    let v406 : obj =
        match v37 with
        | US3_0 -> (* None *)
            let v403 : obj = ()
            v403
        | US3_1(v404) -> (* Some *)
            let v405 : obj = v404
            v405
    let v407 : bool = emitJsExpr v406 "!$0"
    let v411 : UH0 =
        if v407 then
            v402
        else
            let v408 : string = "marginTop"
            let v409 : (string * obj) = v408, v406
            UH0_0(v409, v402)
    let v415 : obj =
        match v38 with
        | US3_0 -> (* None *)
            let v412 : obj = ()
            v412
        | US3_1(v413) -> (* Some *)
            let v414 : obj = v413
            v414
    let v416 : bool = emitJsExpr v415 "!$0"
    let v420 : UH0 =
        if v416 then
            v411
        else
            let v417 : string = "maxHeight"
            let v418 : (string * obj) = v417, v415
            UH0_0(v418, v411)
    let v424 : obj =
        match v39 with
        | US3_0 -> (* None *)
            let v421 : obj = ()
            v421
        | US3_1(v422) -> (* Some *)
            let v423 : obj = v422
            v423
    let v425 : bool = emitJsExpr v424 "!$0"
    let v429 : UH0 =
        if v425 then
            v420
        else
            let v426 : string = "maxWidth"
            let v427 : (string * obj) = v426, v424
            UH0_0(v427, v420)
    let v433 : obj =
        match v40 with
        | US12_0 -> (* None *)
            let v430 : obj = ()
            v430
        | US12_1(v431) -> (* Some *)
            let v432 : obj = v431
            v432
    let v434 : bool = emitJsExpr v433 "!$0"
    let v438 : UH0 =
        if v434 then
            v429
        else
            let v435 : string = "onChange"
            let v436 : (string * obj) = v435, v433
            UH0_0(v436, v429)
    let v442 : obj =
        match v41 with
        | US13_0 -> (* None *)
            let v439 : obj = ()
            v439
        | US13_1(v440) -> (* Some *)
            let v441 : obj = v440
            v441
    let v443 : bool = emitJsExpr v442 "!$0"
    let v447 : UH0 =
        if v443 then
            v438
        else
            let v444 : string = "onClick"
            let v445 : (string * obj) = v444, v442
            UH0_0(v445, v438)
    let v451 : obj =
        match v42 with
        | US12_0 -> (* None *)
            let v448 : obj = ()
            v448
        | US12_1(v449) -> (* Some *)
            let v450 : obj = v449
            v450
    let v452 : bool = emitJsExpr v451 "!$0"
    let v456 : UH0 =
        if v452 then
            v447
        else
            let v453 : string = "onInput"
            let v454 : (string * obj) = v453, v451
            UH0_0(v454, v447)
    let v460 : obj =
        match v43 with
        | US3_0 -> (* None *)
            let v457 : obj = ()
            v457
        | US3_1(v458) -> (* Some *)
            let v459 : obj = v458
            v459
    let v461 : bool = emitJsExpr v460 "!$0"
    let v465 : UH0 =
        if v461 then
            v456
        else
            let v462 : string = "outline"
            let v463 : (string * obj) = v462, v460
            UH0_0(v463, v456)
    let v469 : obj =
        match v44 with
        | US3_0 -> (* None *)
            let v466 : obj = ()
            v466
        | US3_1(v467) -> (* Some *)
            let v468 : obj = v467
            v468
    let v470 : bool = emitJsExpr v469 "!$0"
    let v474 : UH0 =
        if v470 then
            v465
        else
            let v471 : string = "overflow"
            let v472 : (string * obj) = v471, v469
            UH0_0(v472, v465)
    let v478 : obj =
        match v45 with
        | US3_0 -> (* None *)
            let v475 : obj = ()
            v475
        | US3_1(v476) -> (* Some *)
            let v477 : obj = v476
            v477
    let v479 : bool = emitJsExpr v478 "!$0"
    let v483 : UH0 =
        if v479 then
            v474
        else
            let v480 : string = "overflowX"
            let v481 : (string * obj) = v480, v478
            UH0_0(v481, v474)
    let v487 : obj =
        match v46 with
        | US3_0 -> (* None *)
            let v484 : obj = ()
            v484
        | US3_1(v485) -> (* Some *)
            let v486 : obj = v485
            v486
    let v488 : bool = emitJsExpr v487 "!$0"
    let v492 : UH0 =
        if v488 then
            v483
        else
            let v489 : string = "overflowY"
            let v490 : (string * obj) = v489, v487
            UH0_0(v490, v483)
    let v496 : obj =
        match v47 with
        | US3_0 -> (* None *)
            let v493 : obj = ()
            v493
        | US3_1(v494) -> (* Some *)
            let v495 : obj = v494
            v495
    let v497 : bool = emitJsExpr v496 "!$0"
    let v501 : UH0 =
        if v497 then
            v492
        else
            let v498 : string = "padding"
            let v499 : (string * obj) = v498, v496
            UH0_0(v499, v492)
    let v505 : obj =
        match v48 with
        | US3_0 -> (* None *)
            let v502 : obj = ()
            v502
        | US3_1(v503) -> (* Some *)
            let v504 : obj = v503
            v504
    let v506 : bool = emitJsExpr v505 "!$0"
    let v510 : UH0 =
        if v506 then
            v501
        else
            let v507 : string = "paddingBottom"
            let v508 : (string * obj) = v507, v505
            UH0_0(v508, v501)
    let v514 : obj =
        match v49 with
        | US3_0 -> (* None *)
            let v511 : obj = ()
            v511
        | US3_1(v512) -> (* Some *)
            let v513 : obj = v512
            v513
    let v515 : bool = emitJsExpr v514 "!$0"
    let v519 : UH0 =
        if v515 then
            v510
        else
            let v516 : string = "paddingLeft"
            let v517 : (string * obj) = v516, v514
            UH0_0(v517, v510)
    let v523 : obj =
        match v50 with
        | US3_0 -> (* None *)
            let v520 : obj = ()
            v520
        | US3_1(v521) -> (* Some *)
            let v522 : obj = v521
            v522
    let v524 : bool = emitJsExpr v523 "!$0"
    let v528 : UH0 =
        if v524 then
            v519
        else
            let v525 : string = "paddingRight"
            let v526 : (string * obj) = v525, v523
            UH0_0(v526, v519)
    let v532 : obj =
        match v51 with
        | US3_0 -> (* None *)
            let v529 : obj = ()
            v529
        | US3_1(v530) -> (* Some *)
            let v531 : obj = v530
            v531
    let v533 : bool = emitJsExpr v532 "!$0"
    let v537 : UH0 =
        if v533 then
            v528
        else
            let v534 : string = "paddingTop"
            let v535 : (string * obj) = v534, v532
            UH0_0(v535, v528)
    let v541 : obj =
        match v52 with
        | US3_0 -> (* None *)
            let v538 : obj = ()
            v538
        | US3_1(v539) -> (* Some *)
            let v540 : obj = v539
            v540
    let v542 : bool = emitJsExpr v541 "!$0"
    let v546 : UH0 =
        if v542 then
            v537
        else
            let v543 : string = "placeholder"
            let v544 : (string * obj) = v543, v541
            UH0_0(v544, v537)
    let v550 : obj =
        match v53 with
        | US3_0 -> (* None *)
            let v547 : obj = ()
            v547
        | US3_1(v548) -> (* Some *)
            let v549 : obj = v548
            v549
    let v551 : bool = emitJsExpr v550 "!$0"
    let v555 : UH0 =
        if v551 then
            v546
        else
            let v552 : string = "position"
            let v553 : (string * obj) = v552, v550
            UH0_0(v553, v546)
    let v559 : obj =
        match v54 with
        | US3_0 -> (* None *)
            let v556 : obj = ()
            v556
        | US3_1(v557) -> (* Some *)
            let v558 : obj = v557
            v558
    let v560 : bool = emitJsExpr v559 "!$0"
    let v564 : UH0 =
        if v560 then
            v555
        else
            let v561 : string = "right"
            let v562 : (string * obj) = v561, v559
            UH0_0(v562, v555)
    let v568 : obj =
        match v55 with
        | US3_0 -> (* None *)
            let v565 : obj = ()
            v565
        | US3_1(v566) -> (* Some *)
            let v567 : obj = v566
            v567
    let v569 : bool = emitJsExpr v568 "!$0"
    let v573 : UH0 =
        if v569 then
            v564
        else
            let v570 : string = "size"
            let v571 : (string * obj) = v570, v568
            UH0_0(v571, v564)
    let v577 : obj =
        match v56 with
        | US3_0 -> (* None *)
            let v574 : obj = ()
            v574
        | US3_1(v575) -> (* Some *)
            let v576 : obj = v575
            v576
    let v578 : bool = emitJsExpr v577 "!$0"
    let v582 : UH0 =
        if v578 then
            v573
        else
            let v579 : string = "spacing"
            let v580 : (string * obj) = v579, v577
            UH0_0(v580, v573)
    let v586 : obj =
        match v57 with
        | US3_0 -> (* None *)
            let v583 : obj = ()
            v583
        | US3_1(v584) -> (* Some *)
            let v585 : obj = v584
            v585
    let v587 : bool = emitJsExpr v586 "!$0"
    let v591 : UH0 =
        if v587 then
            v582
        else
            let v588 : string = "src"
            let v589 : (string * obj) = v588, v586
            UH0_0(v589, v582)
    let v595 : obj =
        match v58 with
        | US3_0 -> (* None *)
            let v592 : obj = ()
            v592
        | US3_1(v593) -> (* Some *)
            let v594 : obj = v593
            v594
    let v596 : bool = emitJsExpr v595 "!$0"
    let v600 : UH0 =
        if v596 then
            v591
        else
            let v597 : string = "striped"
            let v598 : (string * obj) = v597, v595
            UH0_0(v598, v591)
    let v604 : obj =
        match v59 with
        | US3_0 -> (* None *)
            let v601 : obj = ()
            v601
        | US3_1(v602) -> (* Some *)
            let v603 : obj = v602
            v603
    let v605 : bool = emitJsExpr v604 "!$0"
    let v609 : UH0 =
        if v605 then
            v600
        else
            let v606 : string = "thickness"
            let v607 : (string * obj) = v606, v604
            UH0_0(v607, v600)
    let v613 : obj =
        match v60 with
        | US11_0 -> (* None *)
            let v610 : obj = ()
            v610
        | US11_1(v611) -> (* Some *)
            let v612 : obj = v611
            v612
    let v614 : bool = emitJsExpr v613 "!$0"
    let v618 : UH0 =
        if v614 then
            v609
        else
            let v615 : string = "title"
            let v616 : (string * obj) = v615, v613
            UH0_0(v616, v609)
    let v622 : obj =
        match v61 with
        | US3_0 -> (* None *)
            let v619 : obj = ()
            v619
        | US3_1(v620) -> (* Some *)
            let v621 : obj = v620
            v621
    let v623 : bool = emitJsExpr v622 "!$0"
    let v627 : UH0 =
        if v623 then
            v618
        else
            let v624 : string = "top"
            let v625 : (string * obj) = v624, v622
            UH0_0(v625, v618)
    let v631 : obj =
        match v62 with
        | US3_0 -> (* None *)
            let v628 : obj = ()
            v628
        | US3_1(v629) -> (* Some *)
            let v630 : obj = v629
            v630
    let v632 : bool = emitJsExpr v631 "!$0"
    let v636 : UH0 =
        if v632 then
            v627
        else
            let v633 : string = "type"
            let v634 : (string * obj) = v633, v631
            UH0_0(v634, v627)
    let v640 : obj =
        match v63 with
        | US9_0 -> (* None *)
            let v637 : obj = ()
            v637
        | US9_1(v638) -> (* Some *)
            let v639 : obj = v638
            v639
    let v641 : bool = emitJsExpr v640 "!$0"
    let v645 : UH0 =
        if v641 then
            v636
        else
            let v642 : string = "value"
            let v643 : (string * obj) = v642, v640
            UH0_0(v643, v636)
    let v649 : obj =
        match v64 with
        | US9_0 -> (* None *)
            let v646 : obj = ()
            v646
        | US9_1(v647) -> (* Some *)
            let v648 : obj = v647
            v648
    let v650 : bool = emitJsExpr v649 "!$0"
    let v654 : UH0 =
        if v650 then
            v645
        else
            let v651 : string = "when"
            let v652 : (string * obj) = v651, v649
            UH0_0(v652, v645)
    let v658 : obj =
        match v65 with
        | US3_0 -> (* None *)
            let v655 : obj = ()
            v655
        | US3_1(v656) -> (* Some *)
            let v657 : obj = v656
            v657
    let v659 : bool = emitJsExpr v658 "!$0"
    let v663 : UH0 =
        if v659 then
            v654
        else
            let v660 : string = "width"
            let v661 : (string * obj) = v660, v658
            UH0_0(v661, v654)
    let v667 : obj =
        match v66 with
        | US2_0 -> (* None *)
            let v664 : obj = ()
            v664
        | US2_1(v665) -> (* Some *)
            let v666 : obj = v665
            v666
    let v668 : bool = emitJsExpr v667 "!$0"
    let v672 : UH0 =
        if v668 then
            v663
        else
            let v669 : string = "zIndex"
            let v670 : (string * obj) = v669, v667
            UH0_0(v670, v663)
    let v676 : obj =
        match v67 with
        | US3_0 -> (* None *)
            let v673 : obj = ()
            v673
        | US3_1(v674) -> (* Some *)
            let v675 : obj = v674
            v675
    let v677 : bool = emitJsExpr v676 "!$0"
    let v681 : UH0 =
        if v677 then
            v672
        else
            let v678 : string = "zoom"
            let v679 : (string * obj) = v678, v676
            UH0_0(v679, v672)
    method18(v681)
and closure24 () (v0 : obj) : (JSX.Element []) =
    let v1 : string = "SimpleOption"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v79 : US8 =
        match v15 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US8_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US8_0 -> (* None *)
            closure25(v0)
        | US8_1(v81) -> (* Some *)
            v81
    let v83 : US8 = US8_1(v82)
    let v84 : US9 = US9_1(v0)
    let v85 : ((string * obj) []) = method17(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v83, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v84, v68, v69, v70, v71)
    let v86 : obj = createObj v85
    let v87 : (unit -> (JSX.Element [])) = closure25(v0)
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v86) |> unbox<JSX.Element>
    [|v92|]
and closure23 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : US10 = v0.l19
    let v2 : (obj []) = [||]
    let v4 : (obj []) =
        match v1 with
        | US10_0 -> (* None *)
            v2
        | US10_1(v3) -> (* Some *)
            v3
    let v5 : string = "For"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (obj -> (JSX.Element [])) = closure24()
    let v9 : (unit -> (JSX.Element [])) = v8 |> unbox
    let struct (v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US7, v21 : US8, v22 : US3, v23 : US3, v24 : US7, v25 : US9, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US7, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US11, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US12, v51 : US13, v52 : US12, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US11, v71 : US3, v72 : US3, v73 : US9, v74 : US9, v75 : US3, v76 : US2, v77 : US3) = method13()
    let v78 : (obj []) = v4 |> unbox<obj[]>
    let v85 : US8 =
        match v21 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v80) -> (* Some *)
            let v81 : string = "children"
            let v82 : JS.Function = import v81 v6
            let v83 : (unit -> (JSX.Element [])) = v82.Invoke v80 |> unbox<unit -> JSX.Element[]>
            US8_1(v83)
    let v87 : (unit -> (JSX.Element [])) =
        match v85 with
        | US8_0 -> (* None *)
            v9
        | US8_1(v86) -> (* Some *)
            v86
    let v88 : US8 = US8_1(v87)
    let v89 : US10 = US10_1(v78)
    let v90 : ((string * obj) []) = method17(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v88, v22, v23, v24, v25, v26, v27, v28, v89, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
    let v91 : obj = createObj v90
    emitJsExpr (v91, v9) "$0.children = $1"
    let v92 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v93 : string = "createComponent"
    let v94 : JS.Function = import v93 v6
    let v95 : JSX.Element = v94.Invoke (v92, v91) |> unbox<JSX.Element>
    [|v95|]
and method16 (v0 : Mut3) : JSX.Element =
    let v1 : string = "SimpleSelect"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v72 : US3 = v0.l37
    let v73 : US3 = v0.l52
    let v74 : US9 = v0.l63
    let v75 : US12 = v0.l40
    let v83 : US8 =
        match v15 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US8_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US8_0 -> (* None *)
            closure23(v0)
        | US8_1(v85) -> (* Some *)
            v85
    let v87 : US8 = US8_1(v86)
    let v88 : string = "xs"
    let v89 : US3 = US3_1(v88)
    let v90 : ((string * obj) []) = method17(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v87, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v72, v42, v43, v75, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v73, v57, v58, v89, v60, v61, v62, v63, v64, v65, v66, v74, v68, v69, v70, v71)
    let v91 : obj = createObj v90
    let v92 : (unit -> (JSX.Element [])) = closure23(v0)
    emitJsExpr (v91, v92) "$0.children = $1"
    let v93 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v94 : string = "createComponent"
    let v95 : string = "solid-js"
    let v96 : JS.Function = import v94 v95
    let v97 : JSX.Element = v96.Invoke (v93, v91) |> unbox<JSX.Element>
    v97
and closure22 () (v0 : Mut3) : JSX.Element =
    method16(v0)
and closure17 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let v70 : US5 = US5_0
    let v71 : US5 = US5_2
    let v72 : US5 = US5_3
    let v73 : US5 = US5_1
    let v74 : (US5 []) = [|v70; v71; v72; v73|]
    let v75 : int32 = v74.Length
    let v76 : (string []) = Array.zeroCreate<string> (v75)
    let v77 : Mut4 = {l0 = 0} : Mut4
    while method15(v75, v77) do
        let v79 : int32 = v77.l0
        let v80 : US5 = v74.[int v79]
        let v85 : string =
            match v80 with
            | US5_0 -> (* Debug *)
                let v81 : string = "Debug"
                v81
            | US5_1 -> (* Error *)
                let v82 : string = "Error"
                v82
            | US5_2 -> (* Info *)
                let v83 : string = "Info"
                v83
            | US5_3 -> (* Warn *)
                let v84 : string = "Warn"
                v84
        v76.[int v79] <- v85
        let v86 : int32 = v79 + 1
        v77.l0 <- v86
        ()
    let v87 : int32 = v76.Length
    let v88 : (obj []) = Array.zeroCreate<obj> (v87)
    let v89 : Mut4 = {l0 = 0} : Mut4
    while method15(v87, v89) do
        let v91 : int32 = v89.l0
        let v92 : string = v76.[int v91]
        let v93 : obj = v92
        v88.[int v91] <- v93
        let v94 : int32 = v91 + 1
        v89.l0 <- v94
        ()
    let struct (v95 : US5, v96 : US2) = v1.l9, v1.l10
    let v101 : string =
        match v95 with
        | US5_0 -> (* Debug *)
            let v97 : string = "Debug"
            v97
        | US5_1 -> (* Error *)
            let v98 : string = "Error"
            v98
        | US5_2 -> (* Info *)
            let v99 : string = "Info"
            v99
        | US5_3 -> (* Warn *)
            let v100 : string = "Warn"
            v100
    let v102 : obj = v101
    let v110 : US8 =
        match v13 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v104) -> (* Some *)
            let v105 : string = "children"
            let v106 : string = "solid-js"
            let v107 : JS.Function = import v105 v106
            let v108 : (unit -> (JSX.Element [])) = v107.Invoke v104 |> unbox<unit -> JSX.Element[]>
            US8_1(v108)
    let v113 : (unit -> (JSX.Element [])) =
        match v110 with
        | US8_0 -> (* None *)
            closure18()
        | US8_1(v112) -> (* Some *)
            v112
    let v114 : US8 = US8_1(v113)
    let v115 : US10 = US10_1(v88)
    let v116 : string = "2px"
    let v117 : US3 = US3_1(v116)
    let v118 : (obj -> unit) = closure19(v0)
    let v119 : US12 = US12_1(v118)
    let v120 : US9 = US9_1(v102)
    let v121 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v114; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v115; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v117; l38 = v40; l39 = v41; l40 = v119; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v120; l64 = v66; l65 = v67; l66 = v68; l67 = v69} : Mut3
    let v122 : (unit -> (JSX.Element [])) = closure18()
    emitJsExpr (v121, v122) "$0.children = $1"
    let v123 : string = "createComponent"
    let v124 : string = "solid-js"
    let v125 : JS.Function = import v123 v124
    let v126 : (Mut3 -> JSX.Element) = closure22()
    let v127 : JSX.Element = v125.Invoke (v126, v121) |> unbox<JSX.Element>
    [|v127|]
and closure16 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : string = "Log Level"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure17(v0, v1)
    let v74 : US8 = US8_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v74, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and method22 (v0 : bool) : struct ((unit -> bool) * (bool -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> bool) = v4.[0] |> unbox
    let v6 : (bool -> unit) = v4.[1] |> unbox
    struct (v5, v6)
and method23 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@initial`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure30 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure29 (v0 : JSX.Element) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (unit -> (JSX.Element [])) = closure30(v0)
    let v70 : US8 = US8_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v70, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure33 () () : (JSX.Element []) =
    [||]
and closure32 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) () : (JSX.Element []) =
    let v68 : string = "Box"
    let v69 : string = "@hope-ui/solid"
    let v70 : JS.Function = import v68 v69
    let v73 : (unit -> (JSX.Element [])) =
        match v11 with
        | US8_0 -> (* None *)
            closure33()
        | US8_1(v72) -> (* Some *)
            v72
    let struct (v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US7, v85 : US8, v86 : US3, v87 : US3, v88 : US7, v89 : US9, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US7, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US12, v115 : US13, v116 : US12, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US11, v135 : US3, v136 : US3, v137 : US9, v138 : US9, v139 : US3, v140 : US2, v141 : US3) = method13()
    let v149 : US8 =
        match v85 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v143) -> (* Some *)
            let v144 : string = "children"
            let v145 : string = "solid-js"
            let v146 : JS.Function = import v144 v145
            let v147 : (unit -> (JSX.Element [])) = v146.Invoke v143 |> unbox<unit -> JSX.Element[]>
            US8_1(v147)
    let v151 : (unit -> (JSX.Element [])) =
        match v149 with
        | US8_0 -> (* None *)
            v73
        | US8_1(v150) -> (* Some *)
            v150
    let v152 : US8 = US8_1(v151)
    let v153 : string = "2px"
    let v154 : US3 = US3_1(v153)
    let v155 : ((string * obj) []) = method17(v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v152, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v154, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v156 : obj = createObj v155
    emitJsExpr (v156, v73) "$0.children = $1"
    let v157 : (obj -> JSX.Element) = v70 |> unbox<obj -> JSX.Element>
    let v158 : string = "createComponent"
    let v159 : string = "solid-js"
    let v160 : JS.Function = import v158 v159
    let v161 : JSX.Element = v160.Invoke (v157, v156) |> unbox<JSX.Element>
    [|v161|]
and closure34 (v0 : Mut6) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    let v3 : (bool -> unit) = v0.l1
    v3 v2
    ()
and closure31 () (v0 : Mut6) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l2
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let struct (v70 : US3, v71 : US3, v72 : US3, v73 : US6, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US7, v81 : US8, v82 : US3, v83 : US3, v84 : US7, v85 : US9, v86 : US3, v87 : US3, v88 : US3, v89 : US10, v90 : US7, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US11, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US12, v111 : US13, v112 : US12, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US11, v131 : US3, v132 : US3, v133 : US9, v134 : US9, v135 : US3, v136 : US2, v137 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v145 : US8 =
        match v81 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v139) -> (* Some *)
            let v140 : string = "children"
            let v141 : string = "solid-js"
            let v142 : JS.Function = import v140 v141
            let v143 : (unit -> (JSX.Element [])) = v142.Invoke v139 |> unbox<unit -> JSX.Element[]>
            US8_1(v143)
    let v146 : string = "Checkbox"
    let v147 : string = "@hope-ui/solid"
    let v148 : JS.Function = import v146 v147
    let struct (v149 : US3, v150 : US3, v151 : US3, v152 : US6, v153 : US3, v154 : US3, v155 : US3, v156 : US3, v157 : US3, v158 : US3, v159 : US7, v160 : US8, v161 : US3, v162 : US3, v163 : US7, v164 : US9, v165 : US3, v166 : US3, v167 : US3, v168 : US10, v169 : US7, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US3, v176 : US11, v177 : US3, v178 : US3, v179 : US3, v180 : US11, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US12, v190 : US13, v191 : US12, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US11, v210 : US3, v211 : US3, v212 : US9, v213 : US9, v214 : US3, v215 : US2, v216 : US3) = method13()
    let v217 : (unit -> bool) = v0.l0
    let v218 : bool = v217 ()
    let v226 : US8 =
        match v160 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v220) -> (* Some *)
            let v221 : string = "children"
            let v222 : string = "solid-js"
            let v223 : JS.Function = import v221 v222
            let v224 : (unit -> (JSX.Element [])) = v223.Invoke v220 |> unbox<unit -> JSX.Element[]>
            US8_1(v224)
    let v229 : (unit -> (JSX.Element [])) =
        match v226 with
        | US8_0 -> (* None *)
            closure32(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
        | US8_1(v228) -> (* Some *)
            v228
    let v230 : US7 = US7_1(v218)
    let v231 : US8 = US8_1(v229)
    let v232 : string = "neutral"
    let v233 : US3 = US3_1(v232)
    let v234 : string = "2px"
    let v235 : US3 = US3_1(v234)
    let v236 : (obj -> unit) = closure34(v0)
    let v237 : US12 = US12_1(v236)
    let v238 : string = "sm"
    let v239 : US3 = US3_1(v238)
    let v240 : ((string * obj) []) = method17(v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v230, v231, v161, v233, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v235, v184, v185, v186, v187, v188, v237, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v239, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216)
    let v241 : obj = createObj v240
    let v242 : (unit -> (JSX.Element [])) = closure32(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
    emitJsExpr (v241, v242) "$0.children = $1"
    let v243 : (obj -> JSX.Element) = v148 |> unbox<obj -> JSX.Element>
    let v244 : string = "createComponent"
    let v245 : string = "solid-js"
    let v246 : JS.Function = import v244 v245
    let v247 : JSX.Element = v246.Invoke (v243, v241) |> unbox<JSX.Element>
    v247
and closure28 (v0 : Mut5, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US15 = v0.l3
    let v19 : JSX.Element =
        match v4 with
        | US15_0 -> (* CheckDisabled *)
            let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure29(v3)
            let v6 : Mut6 = {l0 = v2; l1 = v1; l2 = v5} : Mut6
            let v7 : string = "createComponent"
            let v8 : string = "solid-js"
            let v9 : JS.Function = import v7 v8
            let v10 : (Mut6 -> JSX.Element) = closure31()
            let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
            v11
        | US15_1 -> (* CheckEnabled *)
            let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure29(v3)
            let v13 : Mut6 = {l0 = v2; l1 = v1; l2 = v12} : Mut6
            let v14 : string = "createComponent"
            let v15 : string = "solid-js"
            let v16 : JS.Function = import v14 v15
            let v17 : (Mut6 -> JSX.Element) = closure31()
            let v18 : JSX.Element = v16.Invoke (v17, v13) |> unbox<JSX.Element>
            v18
        | US15_2 -> (* CheckHidden *)
            v3
    [|v19|]
and closure35 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure37 (v0 : (unit -> (JSX.Element []))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : US8 = US8_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v69, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure39 (v0 : Mut1) () : bool =
    let struct (v1 : US5, v2 : US2) = v0.l9, v0.l10
    match v1 with
    | US5_0 -> (* Debug *)
        true
    | _ ->
        false
and closure40 (v0 : int32) () : (obj []) =
    let v1 : obj = v0
    [|v1|]
and closure43 (v0 : int32) (v1 : Mut1) : unit =
    let v2 : US2 = US2_1(v0)
    v1.l10 <- v2
    ()
and closure42 (v0 : int32) (v1 : Mut1) : (Mut1 -> unit) =
    closure43(v0)
and closure41 (v0 : Mut7, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit), v2 : int32) () : unit =
    let v3 : bool = v0.l1
    if v3 then
        let v4 : (Mut1 -> (Mut1 -> unit)) = closure42(v2)
        v1 v4
        ()
and method25 (v0 : (unit -> unit)) : unit =
    let v1 : string = "createEffect"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    v3.Invoke v0 |> ignore
    ()
and closure44 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure45 (v0 : Mut7, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit), v2 : Mut1) () : unit =
    let v3 : US14 = v0.l3
    match v3 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v4) -> (* Some *)
        let v5 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v4 v2
        v5 v1
        ()
and closure48 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure49 (v0 : (bool -> unit), v1 : Mut7, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) () : unit =
    let v4 : US14 = v1.l2
    match v4 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v5) -> (* Some *)
        let v6 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v5 v3
        v6 v2
        ()
    v0 true
    ()
and closure51 () () : (JSX.Element []) =
    [||]
and method27 (v0 : Mut3, v1 : Mut3) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut4 = {l0 = 0} : Mut4
    while method15(v3, v4) do
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
and method26 (v0 : Mut3) : JSX.Element =
    let v1 : string = "Button"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : US8 = v0.l11
    let v7 : (unit -> (JSX.Element [])) =
        match v4 with
        | US8_0 -> (* None *)
            closure51()
        | US8_1(v6) -> (* Some *)
            v6
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US7, v19 : US8, v20 : US3, v21 : US3, v22 : US7, v23 : US9, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US12, v49 : US13, v50 : US12, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US11, v69 : US3, v70 : US3, v71 : US9, v72 : US9, v73 : US3, v74 : US2, v75 : US3) = method13()
    let struct (v76 : US3, v77 : US3, v78 : US3, v79 : US6, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US7, v87 : US8, v88 : US3, v89 : US3, v90 : US7, v91 : US9, v92 : US3, v93 : US3, v94 : US3, v95 : US10, v96 : US7, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US11, v104 : US3, v105 : US3, v106 : US3, v107 : US11, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US12, v117 : US13, v118 : US12, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US11, v137 : US3, v138 : US3, v139 : US9, v140 : US9, v141 : US3, v142 : US2, v143 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67
    let v144 : Mut3 = {l0 = v76; l1 = v77; l2 = v78; l3 = v79; l4 = v80; l5 = v81; l6 = v82; l7 = v83; l8 = v84; l9 = v85; l10 = v86; l11 = v87; l12 = v88; l13 = v89; l14 = v90; l15 = v91; l16 = v92; l17 = v93; l18 = v94; l19 = v95; l20 = v96; l21 = v97; l22 = v98; l23 = v99; l24 = v100; l25 = v101; l26 = v102; l27 = v103; l28 = v104; l29 = v105; l30 = v106; l31 = v107; l32 = v108; l33 = v109; l34 = v110; l35 = v111; l36 = v112; l37 = v113; l38 = v114; l39 = v115; l40 = v116; l41 = v117; l42 = v118; l43 = v119; l44 = v120; l45 = v121; l46 = v122; l47 = v123; l48 = v124; l49 = v125; l50 = v126; l51 = v127; l52 = v128; l53 = v129; l54 = v130; l55 = v131; l56 = v132; l57 = v133; l58 = v134; l59 = v135; l60 = v136; l61 = v137; l62 = v138; l63 = v139; l64 = v140; l65 = v141; l66 = v142; l67 = v143} : Mut3
    let v145 : string = "neutral"
    let v146 : US3 = US3_1(v145)
    let v147 : US7 = US7_1(true)
    let v148 : string = "left"
    let v149 : US3 = US3_1(v148)
    let v150 : string = "xs"
    let v151 : US3 = US3_1(v150)
    let v152 : Mut3 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v20; l13 = v146; l14 = v147; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v149; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v151; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70; l63 = v71; l64 = v72; l65 = v73; l66 = v74; l67 = v75} : Mut3
    method27(v152, v144)
    let struct (v153 : US3, v154 : US3, v155 : US3, v156 : US6, v157 : US3, v158 : US3, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US7, v164 : US8, v165 : US3, v166 : US3, v167 : US7, v168 : US9, v169 : US3, v170 : US3, v171 : US3, v172 : US10, v173 : US7, v174 : US3, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US11, v181 : US3, v182 : US3, v183 : US3, v184 : US11, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US12, v194 : US13, v195 : US12, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US11, v214 : US3, v215 : US3, v216 : US9, v217 : US9, v218 : US3, v219 : US2, v220 : US3) = v152.l0, v152.l1, v152.l2, v152.l3, v152.l4, v152.l5, v152.l6, v152.l7, v152.l8, v152.l9, v152.l10, v152.l11, v152.l12, v152.l13, v152.l14, v152.l15, v152.l16, v152.l17, v152.l18, v152.l19, v152.l20, v152.l21, v152.l22, v152.l23, v152.l24, v152.l25, v152.l26, v152.l27, v152.l28, v152.l29, v152.l30, v152.l31, v152.l32, v152.l33, v152.l34, v152.l35, v152.l36, v152.l37, v152.l38, v152.l39, v152.l40, v152.l41, v152.l42, v152.l43, v152.l44, v152.l45, v152.l46, v152.l47, v152.l48, v152.l49, v152.l50, v152.l51, v152.l52, v152.l53, v152.l54, v152.l55, v152.l56, v152.l57, v152.l58, v152.l59, v152.l60, v152.l61, v152.l62, v152.l63, v152.l64, v152.l65, v152.l66, v152.l67
    let v228 : US8 =
        match v164 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v222) -> (* Some *)
            let v223 : string = "children"
            let v224 : string = "solid-js"
            let v225 : JS.Function = import v223 v224
            let v226 : (unit -> (JSX.Element [])) = v225.Invoke v222 |> unbox<unit -> JSX.Element[]>
            US8_1(v226)
    let v230 : (unit -> (JSX.Element [])) =
        match v228 with
        | US8_0 -> (* None *)
            v7
        | US8_1(v229) -> (* Some *)
            v229
    let v231 : US8 = US8_1(v230)
    let v232 : ((string * obj) []) = method17(v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v231, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220)
    let v233 : obj = createObj v232
    emitJsExpr (v233, v7) "$0.children = $1"
    let v234 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v235 : string = "createComponent"
    let v236 : string = "solid-js"
    let v237 : JS.Function = import v235 v236
    let v238 : JSX.Element = v237.Invoke (v234, v233) |> unbox<JSX.Element>
    v238
and closure50 () (v0 : Mut3) : JSX.Element =
    method26(v0)
and closure47 (v0 : (bool -> unit), v1 : Mut7, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) () : (JSX.Element []) =
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v79 : US8 =
        match v15 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US8_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US8_0 -> (* None *)
            closure48()
        | US8_1(v81) -> (* Some *)
            v81
    let v83 : US8 = US8_1(v82)
    let v84 : (unit -> unit) = closure49(v0, v1, v2, v3)
    let v85 : US13 = US13_1(v84)
    let v86 : Mut3 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v83; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v85; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66; l63 = v67; l64 = v68; l65 = v69; l66 = v70; l67 = v71} : Mut3
    let v87 : (unit -> (JSX.Element [])) = closure48()
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : string = "createComponent"
    let v89 : string = "solid-js"
    let v90 : JS.Function = import v88 v89
    let v91 : (Mut3 -> JSX.Element) = closure50()
    let v92 : JSX.Element = v90.Invoke (v91, v86) |> unbox<JSX.Element>
    [|v92|]
and closure55 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure56 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure58 () () : (JSX.Element []) =
    [||]
and method28 (v0 : Mut8) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v72 : (unit -> JS.Function) = v0.l1
    let v73 : JS.Function = v72 ()
    let struct (v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US7, v85 : US8, v86 : US3, v87 : US3, v88 : US7, v89 : US9, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US7, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US12, v115 : US13, v116 : US12, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US11, v135 : US3, v136 : US3, v137 : US9, v138 : US9, v139 : US3, v140 : US2, v141 : US3) = method13()
    let v149 : US8 =
        match v85 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v143) -> (* Some *)
            let v144 : string = "children"
            let v145 : string = "solid-js"
            let v146 : JS.Function = import v144 v145
            let v147 : (unit -> (JSX.Element [])) = v146.Invoke v143 |> unbox<unit -> JSX.Element[]>
            US8_1(v147)
    let v150 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l0
    let v151 : string = "-12px"
    let v152 : US3 = US3_1(v151)
    let v153 : US3 = US3_1(v151)
    let v154 : string = "0.6"
    let v155 : US3 = US3_1(v154)
    let struct (v156 : US3, v157 : US3, v158 : US3, v159 : US6, v160 : US3, v161 : US3, v162 : US3, v163 : US3, v164 : US3, v165 : US3, v166 : US7, v167 : US8, v168 : US3, v169 : US3, v170 : US7, v171 : US9, v172 : US3, v173 : US3, v174 : US3, v175 : US10, v176 : US7, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US11, v184 : US3, v185 : US3, v186 : US3, v187 : US11, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US12, v197 : US13, v198 : US12, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US11, v217 : US3, v218 : US3, v219 : US9, v220 : US9, v221 : US3, v222 : US2, v223 : US3) = v150 struct (v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v149, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v152, v110, v153, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v155)
    let v224 : ((string * obj) []) = method17(v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223)
    let v225 : obj = createObj v224
    let v226 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l2
    let v227 : US6 = US6_1(v73)
    let v228 : US9 = US9_1(v225)
    let v229 : string = "14px"
    let v230 : US3 = US3_1(v229)
    let struct (v231 : US3, v232 : US3, v233 : US3, v234 : US6, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US3, v241 : US7, v242 : US8, v243 : US3, v244 : US3, v245 : US7, v246 : US9, v247 : US3, v248 : US3, v249 : US3, v250 : US10, v251 : US7, v252 : US3, v253 : US3, v254 : US3, v255 : US3, v256 : US3, v257 : US3, v258 : US11, v259 : US3, v260 : US3, v261 : US3, v262 : US11, v263 : US3, v264 : US3, v265 : US3, v266 : US3, v267 : US3, v268 : US3, v269 : US3, v270 : US3, v271 : US12, v272 : US13, v273 : US12, v274 : US3, v275 : US3, v276 : US3, v277 : US3, v278 : US3, v279 : US3, v280 : US3, v281 : US3, v282 : US3, v283 : US3, v284 : US3, v285 : US3, v286 : US3, v287 : US3, v288 : US3, v289 : US3, v290 : US3, v291 : US11, v292 : US3, v293 : US3, v294 : US9, v295 : US9, v296 : US3, v297 : US2, v298 : US3) = v226 struct (v4, v5, v6, v227, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v228, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v230, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v306 : US8 =
        match v242 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v300) -> (* Some *)
            let v301 : string = "children"
            let v302 : string = "solid-js"
            let v303 : JS.Function = import v301 v302
            let v304 : (unit -> (JSX.Element [])) = v303.Invoke v300 |> unbox<unit -> JSX.Element[]>
            US8_1(v304)
    let v309 : (unit -> (JSX.Element [])) =
        match v306 with
        | US8_0 -> (* None *)
            closure58()
        | US8_1(v308) -> (* Some *)
            v308
    let v310 : US8 = US8_1(v309)
    let v311 : ((string * obj) []) = method17(v231, v232, v233, v234, v235, v236, v237, v238, v239, v240, v241, v310, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v273, v274, v275, v276, v277, v278, v279, v280, v281, v282, v283, v284, v285, v286, v287, v288, v289, v290, v291, v292, v293, v294, v295, v296, v297, v298)
    let v312 : obj = createObj v311
    let v313 : (unit -> (JSX.Element [])) = closure58()
    emitJsExpr (v312, v313) "$0.children = $1"
    let v314 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v315 : string = "createComponent"
    let v316 : string = "solid-js"
    let v317 : JS.Function = import v315 v316
    let v318 : JSX.Element = v317.Invoke (v314, v312) |> unbox<JSX.Element>
    v318
and closure57 () (v0 : Mut8) : JSX.Element =
    method28(v0)
and closure59 () () : (JSX.Element []) =
    [||]
and closure60 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure61 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure62 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure63 () () : (JSX.Element []) =
    [||]
and closure66 (v0 : int32, v1 : Mut1) (v2 : Mut1) : unit =
    let struct (v3 : US5, v4 : US2) = v1.l9, v1.l10
    let v8 : bool =
        match v4 with
        | US2_1(v6) -> (* Some *)
            let v7 : bool = v6 = v0
            v7
        | _ ->
            false
    let v9 : bool = v8 = false
    let v12 : US2 =
        if v9 then
            US2_1(v0)
        else
            US2_0
    v2.l10 <- v12
    ()
and closure65 (v0 : int32, v1 : Mut1) (v2 : Mut1) : (Mut1 -> unit) =
    closure66(v0, v1)
and closure64 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : int32, v2 : Mut1) () : unit =
    let v3 : (Mut1 -> (Mut1 -> unit)) = closure65(v1, v2)
    v0 v3
    ()
and closure67 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure68 () () : (JSX.Element []) =
    [||]
and closure69 (v0 : (bool -> unit), v1 : Mut7, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) () : unit =
    let v4 : US14 = v1.l3
    match v4 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v5) -> (* Some *)
        let v6 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v5 v3
        v6 v2
        ()
    v0 false
    ()
and closure54 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : int32, v2 : (bool -> unit), v3 : (bool -> unit), v4 : Mut7, v5 : Mut1) () : (JSX.Element []) =
    let v6 : string = "IconButton"
    let v7 : string = "@hope-ui/solid"
    let v8 : JS.Function = import v6 v7
    let struct (v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US7, v20 : US8, v21 : US3, v22 : US3, v23 : US7, v24 : US9, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US12, v50 : US13, v51 : US12, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US11, v70 : US3, v71 : US3, v72 : US9, v73 : US9, v74 : US3, v75 : US2, v76 : US3) = method13()
    let v77 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure55()
    let v78 : (unit -> JS.Function) = closure56()
    let v79 : Mut8 = {l0 = v77; l1 = v78; l2 = v77} : Mut8
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : (Mut8 -> JSX.Element) = closure57()
    let v84 : JSX.Element = v82.Invoke (v83, v79) |> unbox<JSX.Element>
    let v91 : US8 =
        match v20 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v86) -> (* Some *)
            let v87 : string = "children"
            let v88 : JS.Function = import v87 v81
            let v89 : (unit -> (JSX.Element [])) = v88.Invoke v86 |> unbox<unit -> JSX.Element[]>
            US8_1(v89)
    let v94 : (unit -> (JSX.Element [])) =
        match v91 with
        | US8_0 -> (* None *)
            closure59()
        | US8_1(v93) -> (* Some *)
            v93
    let v95 : string = "Refresh"
    let v96 : US3 = US3_1(v95)
    let v97 : US8 = US8_1(v94)
    let v98 : string = "neutral"
    let v99 : US3 = US3_1(v98)
    let v100 : string = "20px"
    let v101 : US3 = US3_1(v100)
    let v102 : US11 = US11_1(v84)
    let v103 : (unit -> unit) = closure60(v3)
    let v104 : US13 = US13_1(v103)
    let v105 : string = "xs"
    let v106 : US3 = US3_1(v105)
    let v107 : ((string * obj) []) = method17(v9, v10, v96, v12, v13, v14, v15, v16, v17, v18, v19, v97, v21, v99, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v101, v35, v102, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v104, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v106, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76)
    let v108 : obj = createObj v107
    let v109 : (unit -> (JSX.Element [])) = closure59()
    emitJsExpr (v108, v109) "$0.children = $1"
    let v110 : (obj -> JSX.Element) = v8 |> unbox<obj -> JSX.Element>
    let v111 : JS.Function = import v80 v81
    let v112 : JSX.Element = v111.Invoke (v110, v108) |> unbox<JSX.Element>
    let v113 : JS.Function = import v6 v7
    let struct (v114 : US3, v115 : US3, v116 : US3, v117 : US6, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US7, v125 : US8, v126 : US3, v127 : US3, v128 : US7, v129 : US9, v130 : US3, v131 : US3, v132 : US3, v133 : US10, v134 : US7, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US11, v142 : US3, v143 : US3, v144 : US3, v145 : US11, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US12, v155 : US13, v156 : US12, v157 : US3, v158 : US3, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US3, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US11, v175 : US3, v176 : US3, v177 : US9, v178 : US9, v179 : US3, v180 : US2, v181 : US3) = method13()
    let struct (v182 : US5, v183 : US2) = v5.l9, v5.l10
    let v187 : bool =
        match v183 with
        | US2_1(v185) -> (* Some *)
            let v186 : bool = v185 = v1
            v186
        | _ ->
            false
    let v190 : string =
        if v187 then
            let v188 : string = "Restore"
            v188
        else
            let v189 : string = "Maximize"
            v189
    let struct (v191 : US5, v192 : US2) = v5.l9, v5.l10
    let v196 : bool =
        match v192 with
        | US2_1(v194) -> (* Some *)
            let v195 : bool = v194 = v1
            v195
        | _ ->
            false
    let v199 : (unit -> JS.Function) =
        if v196 then
            closure61()
        else
            closure62()
    let v200 : Mut8 = {l0 = v77; l1 = v199; l2 = v77} : Mut8
    let v201 : JS.Function = import v80 v81
    let v202 : JSX.Element = v201.Invoke (v83, v200) |> unbox<JSX.Element>
    let v209 : US8 =
        match v125 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v204) -> (* Some *)
            let v205 : string = "children"
            let v206 : JS.Function = import v205 v81
            let v207 : (unit -> (JSX.Element [])) = v206.Invoke v204 |> unbox<unit -> JSX.Element[]>
            US8_1(v207)
    let v212 : (unit -> (JSX.Element [])) =
        match v209 with
        | US8_0 -> (* None *)
            closure63()
        | US8_1(v211) -> (* Some *)
            v211
    let v213 : US3 = US3_1(v190)
    let v214 : US8 = US8_1(v212)
    let v215 : US3 = US3_1(v98)
    let v216 : US3 = US3_1(v100)
    let v217 : US11 = US11_1(v202)
    let v218 : (unit -> unit) = closure64(v0, v1, v5)
    let v219 : US13 = US13_1(v218)
    let v220 : US3 = US3_1(v105)
    let v221 : ((string * obj) []) = method17(v114, v115, v213, v117, v118, v119, v120, v121, v122, v123, v124, v214, v126, v215, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v216, v140, v217, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v219, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v220, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181)
    let v222 : obj = createObj v221
    let v223 : (unit -> (JSX.Element [])) = closure63()
    emitJsExpr (v222, v223) "$0.children = $1"
    let v224 : (obj -> JSX.Element) = v113 |> unbox<obj -> JSX.Element>
    let v225 : JS.Function = import v80 v81
    let v226 : JSX.Element = v225.Invoke (v224, v222) |> unbox<JSX.Element>
    let v227 : JS.Function = import v6 v7
    let struct (v228 : US3, v229 : US3, v230 : US3, v231 : US6, v232 : US3, v233 : US3, v234 : US3, v235 : US3, v236 : US3, v237 : US3, v238 : US7, v239 : US8, v240 : US3, v241 : US3, v242 : US7, v243 : US9, v244 : US3, v245 : US3, v246 : US3, v247 : US10, v248 : US7, v249 : US3, v250 : US3, v251 : US3, v252 : US3, v253 : US3, v254 : US3, v255 : US11, v256 : US3, v257 : US3, v258 : US3, v259 : US11, v260 : US3, v261 : US3, v262 : US3, v263 : US3, v264 : US3, v265 : US3, v266 : US3, v267 : US3, v268 : US12, v269 : US13, v270 : US12, v271 : US3, v272 : US3, v273 : US3, v274 : US3, v275 : US3, v276 : US3, v277 : US3, v278 : US3, v279 : US3, v280 : US3, v281 : US3, v282 : US3, v283 : US3, v284 : US3, v285 : US3, v286 : US3, v287 : US3, v288 : US11, v289 : US3, v290 : US3, v291 : US9, v292 : US9, v293 : US3, v294 : US2, v295 : US3) = method13()
    let v296 : (unit -> JS.Function) = closure67()
    let v297 : Mut8 = {l0 = v77; l1 = v296; l2 = v77} : Mut8
    let v298 : JS.Function = import v80 v81
    let v299 : JSX.Element = v298.Invoke (v83, v297) |> unbox<JSX.Element>
    let v306 : US8 =
        match v239 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v301) -> (* Some *)
            let v302 : string = "children"
            let v303 : JS.Function = import v302 v81
            let v304 : (unit -> (JSX.Element [])) = v303.Invoke v301 |> unbox<unit -> JSX.Element[]>
            US8_1(v304)
    let v309 : (unit -> (JSX.Element [])) =
        match v306 with
        | US8_0 -> (* None *)
            closure68()
        | US8_1(v308) -> (* Some *)
            v308
    let v310 : string = "Unload"
    let v311 : US3 = US3_1(v310)
    let v312 : US8 = US8_1(v309)
    let v313 : US3 = US3_1(v98)
    let v314 : US3 = US3_1(v100)
    let v315 : US11 = US11_1(v299)
    let v316 : (unit -> unit) = closure69(v2, v4, v0, v5)
    let v317 : US13 = US13_1(v316)
    let v318 : US3 = US3_1(v105)
    let v319 : ((string * obj) []) = method17(v228, v229, v311, v231, v232, v233, v234, v235, v236, v237, v238, v312, v240, v313, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v314, v254, v315, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v317, v270, v271, v272, v273, v274, v275, v276, v277, v278, v279, v280, v281, v282, v318, v284, v285, v286, v287, v288, v289, v290, v291, v292, v293, v294, v295)
    let v320 : obj = createObj v319
    let v321 : (unit -> (JSX.Element [])) = closure68()
    emitJsExpr (v320, v321) "$0.children = $1"
    let v322 : (obj -> JSX.Element) = v227 |> unbox<obj -> JSX.Element>
    let v323 : JS.Function = import v80 v81
    let v324 : JSX.Element = v323.Invoke (v322, v320) |> unbox<JSX.Element>
    [|v112; v226; v324|]
and closure53 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : Mut7, v7 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v8 : string = "Stack"
    let v9 : string = "@hope-ui/solid"
    let v10 : JS.Function = import v8 v9
    let struct (v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US7, v22 : US8, v23 : US3, v24 : US3, v25 : US7, v26 : US9, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US7, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US12, v52 : US13, v53 : US12, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US11, v72 : US3, v73 : US3, v74 : US9, v75 : US9, v76 : US3, v77 : US2, v78 : US3) = method13()
    let struct (v79 : US5, v80 : US2) = v1.l9, v1.l10
    let v89 : US3 =
        match v80 with
        | US2_0 -> (* None *)
            US3_0
        | US2_1(v82) -> (* Some *)
            let v83 : bool = v82 = v2
            let v84 : bool = v83 <> true
            if v84 then
                let v85 : string = "none"
                US3_1(v85)
            else
                US3_0
    let v97 : US8 =
        match v22 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v91) -> (* Some *)
            let v92 : string = "children"
            let v93 : string = "solid-js"
            let v94 : JS.Function = import v92 v93
            let v95 : (unit -> (JSX.Element [])) = v94.Invoke v91 |> unbox<unit -> JSX.Element[]>
            US8_1(v95)
    let v100 : (unit -> (JSX.Element [])) =
        match v97 with
        | US8_0 -> (* None *)
            closure54(v0, v2, v3, v4, v6, v1)
        | US8_1(v99) -> (* Some *)
            v99
    let v101 : US8 = US8_1(v100)
    let v102 : string = "row"
    let v103 : US3 = US3_1(v102)
    let v104 : string = "absolute"
    let v105 : US3 = US3_1(v104)
    let v106 : string = "6px"
    let v107 : US3 = US3_1(v106)
    let v108 : string = "3px"
    let v109 : US3 = US3_1(v108)
    let v110 : US3 = US3_1(v106)
    let v111 : int32 = 2
    let v112 : US2 = US2_1(v111)
    let v113 : ((string * obj) []) = method17(v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v101, v23, v24, v25, v26, v27, v103, v89, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v105, v107, v66, v109, v68, v69, v70, v71, v110, v73, v74, v75, v76, v112, v78)
    let v114 : obj = createObj v113
    let v115 : (unit -> (JSX.Element [])) = closure54(v0, v2, v3, v4, v6, v1)
    emitJsExpr (v114, v115) "$0.children = $1"
    let v116 : (obj -> JSX.Element) = v10 |> unbox<obj -> JSX.Element>
    let v117 : string = "createComponent"
    let v118 : string = "solid-js"
    let v119 : JS.Function = import v117 v118
    let v120 : JSX.Element = v119.Invoke (v116, v114) |> unbox<JSX.Element>
    let v121 : bool = v5 ()
    let v124 : JSX.Element =
        if v121 then
            let v122 : JSX.Element = null
            v122
        else
            let v123 : JSX.Element = v7 |> unbox<JSX.Element>
            v123
    [|v120; v124|]
and closure52 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3, v68 : ((Mut1 -> (Mut1 -> unit)) -> unit), v69 : Mut1, v70 : int32, v71 : (bool -> unit), v72 : (bool -> unit), v73 : (unit -> bool), v74 : Mut7) () : (JSX.Element []) =
    let v180 : JSX.Element =
        match v11 with
        | US8_0 -> (* None *)
            let v75 : JSX.Element = null
            v75
        | US8_1(v76) -> (* Some *)
            let v77 : string = "Box"
            let v78 : string = "@hope-ui/solid"
            let v79 : JS.Function = import v77 v78
            let struct (v80 : US3, v81 : US3, v82 : US3, v83 : US6, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US7, v91 : US8, v92 : US3, v93 : US3, v94 : US7, v95 : US9, v96 : US3, v97 : US3, v98 : US3, v99 : US10, v100 : US7, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US11, v108 : US3, v109 : US3, v110 : US3, v111 : US11, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US12, v121 : US13, v122 : US12, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US11, v141 : US3, v142 : US3, v143 : US9, v144 : US9, v145 : US3, v146 : US2, v147 : US3) = method13()
            let struct (v148 : US5, v149 : US2) = v69.l9, v69.l10
            let v151 : bool =
                match v149 with
                | US2_0 -> (* None *)
                    true
                | _ ->
                    false
            let v155 : US3 =
                if v151 then
                    let v152 : string = "relative"
                    US3_1(v152)
                else
                    US3_0
            let v163 : US8 =
                match v91 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v157) -> (* Some *)
                    let v158 : string = "children"
                    let v159 : string = "solid-js"
                    let v160 : JS.Function = import v158 v159
                    let v161 : (unit -> (JSX.Element [])) = v160.Invoke v157 |> unbox<unit -> JSX.Element[]>
                    US8_1(v161)
            let v166 : (unit -> (JSX.Element [])) =
                match v163 with
                | US8_0 -> (* None *)
                    closure53(v68, v69, v70, v71, v72, v73, v74, v76)
                | US8_1(v165) -> (* Some *)
                    v165
            let v167 : US8 = US8_1(v166)
            let v168 : string = "flex"
            let v169 : US3 = US3_1(v168)
            let v170 : string = "1"
            let v171 : US3 = US3_1(v170)
            let v172 : ((string * obj) []) = method17(v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v167, v92, v93, v94, v95, v96, v97, v169, v99, v100, v171, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v155, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147)
            let v173 : obj = createObj v172
            let v174 : (unit -> (JSX.Element [])) = closure53(v68, v69, v70, v71, v72, v73, v74, v76)
            emitJsExpr (v173, v174) "$0.children = $1"
            let v175 : (obj -> JSX.Element) = v79 |> unbox<obj -> JSX.Element>
            let v176 : string = "createComponent"
            let v177 : string = "solid-js"
            let v178 : JS.Function = import v176 v177
            let v179 : JSX.Element = v178.Invoke (v175, v173) |> unbox<JSX.Element>
            v179
    [|v180|]
and closure46 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3, v68 : ((Mut1 -> (Mut1 -> unit)) -> unit), v69 : Mut1, v70 : int32, v71 : (bool -> unit), v72 : (unit -> bool), v73 : (bool -> unit), v74 : (unit -> bool), v75 : Mut7) () : (JSX.Element []) =
    let v76 : bool = v72 ()
    let v77 : bool = v76 = false
    let v335 : JSX.Element =
        if v77 then
            let v78 : string = "Box"
            let v79 : string = "@hope-ui/solid"
            let v80 : JS.Function = import v78 v79
            let struct (v81 : US3, v82 : US3, v83 : US3, v84 : US6, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US7, v92 : US8, v93 : US3, v94 : US3, v95 : US7, v96 : US9, v97 : US3, v98 : US3, v99 : US3, v100 : US10, v101 : US7, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US11, v109 : US3, v110 : US3, v111 : US3, v112 : US11, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US12, v122 : US13, v123 : US12, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US11, v142 : US3, v143 : US3, v144 : US9, v145 : US9, v146 : US3, v147 : US2, v148 : US3) = method13()
            let v156 : US8 =
                match v92 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v150) -> (* Some *)
                    let v151 : string = "children"
                    let v152 : string = "solid-js"
                    let v153 : JS.Function = import v151 v152
                    let v154 : (unit -> (JSX.Element [])) = v153.Invoke v150 |> unbox<unit -> JSX.Element[]>
                    US8_1(v154)
            let v159 : (unit -> (JSX.Element [])) =
                match v156 with
                | US8_0 -> (* None *)
                    closure47(v71, v75, v68, v69)
                | US8_1(v158) -> (* Some *)
                    v158
            let v160 : US8 = US8_1(v159)
            let v161 : string = "3px 0"
            let v162 : US3 = US3_1(v161)
            let v163 : ((string * obj) []) = method17(v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v160, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v162, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148)
            let v164 : obj = createObj v163
            let v165 : (unit -> (JSX.Element [])) = closure47(v71, v75, v68, v69)
            emitJsExpr (v164, v165) "$0.children = $1"
            let v166 : (obj -> JSX.Element) = v80 |> unbox<obj -> JSX.Element>
            let v167 : string = "createComponent"
            let v168 : string = "solid-js"
            let v169 : JS.Function = import v167 v168
            let v170 : JSX.Element = v169.Invoke (v166, v164) |> unbox<JSX.Element>
            v170
        else
            let v171 : string = "Box"
            let v172 : string = "@hope-ui/solid"
            let v173 : JS.Function = import v171 v172
            let struct (v174 : US3, v175 : US3, v176 : US3, v177 : US6, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US7, v185 : US8, v186 : US3, v187 : US3, v188 : US7, v189 : US9, v190 : US3, v191 : US3, v192 : US3, v193 : US10, v194 : US7, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US11, v202 : US3, v203 : US3, v204 : US3, v205 : US11, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US12, v215 : US13, v216 : US12, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US3, v231 : US3, v232 : US3, v233 : US3, v234 : US11, v235 : US3, v236 : US3, v237 : US9, v238 : US9, v239 : US3, v240 : US2, v241 : US3) = method13()
            let struct (v242 : US5, v243 : US2) = v69.l9, v69.l10
            let v247 : bool =
                match v243 with
                | US2_1(v245) -> (* Some *)
                    let v246 : bool = v245 = v70
                    v246
                | _ ->
                    false
            let v250 : US2 =
                if v247 then
                    US2_1(1)
                else
                    US2_0
            let struct (v251 : US5, v252 : US2) = v69.l9, v69.l10
            let v256 : bool =
                match v252 with
                | US2_1(v254) -> (* Some *)
                    let v255 : bool = v254 = v70
                    v255
                | _ ->
                    false
            let v260 : US3 =
                if v256 then
                    let v257 : string = "fixed"
                    US3_1(v257)
                else
                    US3_0
            let struct (v261 : US5, v262 : US2) = v69.l9, v69.l10
            let v266 : bool =
                match v262 with
                | US2_1(v264) -> (* Some *)
                    let v265 : bool = v264 = v70
                    v265
                | _ ->
                    false
            let v270 : US3 =
                if v266 then
                    let v267 : string = "0"
                    US3_1(v267)
                else
                    US3_0
            let struct (v271 : US5, v272 : US2) = v69.l9, v69.l10
            let v276 : bool =
                match v272 with
                | US2_1(v274) -> (* Some *)
                    let v275 : bool = v274 = v70
                    v275
                | _ ->
                    false
            let v280 : US3 =
                if v276 then
                    let v277 : string = "0"
                    US3_1(v277)
                else
                    US3_0
            let struct (v281 : US5, v282 : US2) = v69.l9, v69.l10
            let v286 : bool =
                match v282 with
                | US2_1(v284) -> (* Some *)
                    let v285 : bool = v284 = v70
                    v285
                | _ ->
                    false
            let v290 : US3 =
                if v286 then
                    let v287 : string = "0"
                    US3_1(v287)
                else
                    US3_0
            let struct (v291 : US5, v292 : US2) = v69.l9, v69.l10
            let v296 : bool =
                match v292 with
                | US2_1(v294) -> (* Some *)
                    let v295 : bool = v294 = v70
                    v295
                | _ ->
                    false
            let v300 : US3 =
                if v296 then
                    let v297 : string = "0"
                    US3_1(v297)
                else
                    US3_0
            let struct (v301 : US5, v302 : US2) = v69.l9, v69.l10
            let v306 : bool =
                match v302 with
                | US2_1(v304) -> (* Some *)
                    let v305 : bool = v304 = v70
                    v305
                | _ ->
                    false
            let v310 : US3 =
                if v306 then
                    let v307 : string = "$bg"
                    US3_1(v307)
                else
                    US3_0
            let v318 : US8 =
                match v185 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v312) -> (* Some *)
                    let v313 : string = "children"
                    let v314 : string = "solid-js"
                    let v315 : JS.Function = import v313 v314
                    let v316 : (unit -> (JSX.Element [])) = v315.Invoke v312 |> unbox<unit -> JSX.Element[]>
                    US8_1(v316)
            let v321 : (unit -> (JSX.Element [])) =
                match v318 with
                | US8_0 -> (* None *)
                    closure52(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v73, v74, v75)
                | US8_1(v320) -> (* Some *)
                    v320
            let v322 : US8 = US8_1(v321)
            let v323 : string = "flex"
            let v324 : US3 = US3_1(v323)
            let v325 : string = "1"
            let v326 : US3 = US3_1(v325)
            let v327 : ((string * obj) []) = method17(v174, v175, v176, v177, v310, v179, v180, v181, v182, v290, v184, v322, v186, v187, v188, v189, v190, v191, v324, v193, v194, v326, v196, v197, v198, v199, v200, v201, v202, v203, v300, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v260, v280, v229, v230, v231, v232, v233, v234, v270, v236, v237, v238, v239, v250, v241)
            let v328 : obj = createObj v327
            let v329 : (unit -> (JSX.Element [])) = closure52(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v73, v74, v75)
            emitJsExpr (v328, v329) "$0.children = $1"
            let v330 : (obj -> JSX.Element) = v173 |> unbox<obj -> JSX.Element>
            let v331 : string = "createComponent"
            let v332 : string = "solid-js"
            let v333 : JS.Function = import v331 v332
            let v334 : JSX.Element = v333.Invoke (v330, v328) |> unbox<JSX.Element>
            v334
    [|v335|]
and method24 (v0 : Mut7) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l4
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let struct (v70 : US3, v71 : US3, v72 : US3, v73 : US6, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US7, v81 : US8, v82 : US3, v83 : US3, v84 : US7, v85 : US9, v86 : US3, v87 : US3, v88 : US3, v89 : US10, v90 : US7, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US11, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US12, v111 : US13, v112 : US12, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US11, v131 : US3, v132 : US3, v133 : US9, v134 : US9, v135 : US3, v136 : US2, v137 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v145 : US8 =
        match v81 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v139) -> (* Some *)
            let v140 : string = "children"
            let v141 : string = "solid-js"
            let v142 : JS.Function = import v140 v141
            let v143 : (unit -> (JSX.Element [])) = v142.Invoke v139 |> unbox<unit -> JSX.Element[]>
            US8_1(v143)
    let struct (v146 : Mut1, v147 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v148 : int32 = Random().Next ()
    let v149 : (unit -> bool) = closure39(v146)
    let v150 : (unit -> (obj [])) = closure40(v148)
    let v151 : string = "#de884c"
    let v152 : ((obj []) -> unit) = method9(v149, v150, v151)
    let v153 : string = "> loader ()"
    let v154 : obj = v153
    let v155 : (obj []) = [|v154|]
    v152 v155
    let v156 : bool = v0.l0
    let struct (v157 : (unit -> bool), v158 : (bool -> unit)) = method22(v156)
    let v159 : bool = false
    let struct (v160 : (unit -> bool), v161 : (bool -> unit)) = method22(v159)
    let v162 : (unit -> unit) = closure41(v0, v147, v148)
    method25(v162)
    let v163 : (unit -> unit) = closure44(v161, v160)
    method25(v163)
    let v164 : (unit -> unit) = closure45(v0, v147, v146)
    method11(v164)
    let v165 : bool = v0.l0
    let v166 : bool = v165 = true
    if v166 then
        let v167 : US14 = v0.l2
        match v167 with
        | US14_0 -> (* None *)
            ()
        | US14_1(v168) -> (* Some *)
            let v169 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v168 v146
            v169 v147
            ()
    let v170 : string = "Box"
    let v171 : string = "@hope-ui/solid"
    let v172 : JS.Function = import v170 v171
    let struct (v173 : US3, v174 : US3, v175 : US3, v176 : US6, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US7, v184 : US8, v185 : US3, v186 : US3, v187 : US7, v188 : US9, v189 : US3, v190 : US3, v191 : US3, v192 : US10, v193 : US7, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US11, v201 : US3, v202 : US3, v203 : US3, v204 : US11, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US12, v214 : US13, v215 : US12, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US3, v231 : US3, v232 : US3, v233 : US11, v234 : US3, v235 : US3, v236 : US9, v237 : US9, v238 : US3, v239 : US2, v240 : US3) = method13()
    let v248 : US8 =
        match v184 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v242) -> (* Some *)
            let v243 : string = "children"
            let v244 : string = "solid-js"
            let v245 : JS.Function = import v243 v244
            let v246 : (unit -> (JSX.Element [])) = v245.Invoke v242 |> unbox<unit -> JSX.Element[]>
            US8_1(v246)
    let v251 : (unit -> (JSX.Element [])) =
        match v248 with
        | US8_0 -> (* None *)
            closure46(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v147, v146, v148, v158, v157, v161, v160, v0)
        | US8_1(v250) -> (* Some *)
            v250
    let v252 : US8 = US8_1(v251)
    let v253 : string = "flex"
    let v254 : US3 = US3_1(v253)
    let v255 : string = "1"
    let v256 : US3 = US3_1(v255)
    let v257 : ((string * obj) []) = method17(v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v252, v185, v186, v187, v188, v189, v190, v254, v192, v193, v256, v195, v196, v197, v198, v199, v200, v98, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v239, v240)
    let v258 : obj = createObj v257
    let v259 : (unit -> (JSX.Element [])) = closure46(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v147, v146, v148, v158, v157, v161, v160, v0)
    emitJsExpr (v258, v259) "$0.children = $1"
    let v260 : (obj -> JSX.Element) = v172 |> unbox<obj -> JSX.Element>
    let v261 : string = "createComponent"
    let v262 : string = "solid-js"
    let v263 : JS.Function = import v261 v262
    let v264 : JSX.Element = v263.Invoke (v260, v258) |> unbox<JSX.Element>
    v264
and closure38 () (v0 : Mut7) : JSX.Element =
    method24(v0)
and closure36 (v0 : Mut5, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US15 = v0.l3
    let v29 : JSX.Element =
        match v3 with
        | US15_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : US14 = v0.l0
                let v6 : US14 = v0.l1
                let v7 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure37(v2)
                let v8 : Mut7 = {l0 = true; l1 = false; l2 = v5; l3 = v6; l4 = v7} : Mut7
                let v9 : string = "createComponent"
                let v10 : string = "solid-js"
                let v11 : JS.Function = import v9 v10
                let v12 : (Mut7 -> JSX.Element) = closure38()
                let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
                v13
            else
                let v14 : JSX.Element = null
                v14
        | US15_1 -> (* CheckEnabled *)
            let v16 : bool = v1 ()
            if v16 then
                let v17 : US14 = v0.l0
                let v18 : US14 = v0.l1
                let v19 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure37(v2)
                let v20 : Mut7 = {l0 = true; l1 = false; l2 = v17; l3 = v18; l4 = v19} : Mut7
                let v21 : string = "createComponent"
                let v22 : string = "solid-js"
                let v23 : JS.Function = import v21 v22
                let v24 : (Mut7 -> JSX.Element) = closure38()
                let v25 : JSX.Element = v23.Invoke (v24, v20) |> unbox<JSX.Element>
                v25
            else
                let v26 : JSX.Element = null
                v26
        | US15_2 -> (* CheckHidden *)
            let v28 : JSX.Element = v2 |> unbox<JSX.Element>
            v28
    [|v29|]
and closure27 (v0 : Mut5, v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3, v69 : (bool -> unit), v70 : (unit -> bool)) () : (JSX.Element []) =
    let v187 : JSX.Element =
        match v61 with
        | US11_0 -> (* None *)
            let v71 : JSX.Element = null
            v71
        | US11_1(v72) -> (* Some *)
            let v73 : string = "Td"
            let v74 : string = "@hope-ui/solid"
            let v75 : JS.Function = import v73 v74
            let struct (v76 : US3, v77 : US3, v78 : US3, v79 : US6, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US7, v87 : US8, v88 : US3, v89 : US3, v90 : US7, v91 : US9, v92 : US3, v93 : US3, v94 : US3, v95 : US10, v96 : US7, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US11, v104 : US3, v105 : US3, v106 : US3, v107 : US11, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US12, v117 : US13, v118 : US12, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US11, v137 : US3, v138 : US3, v139 : US9, v140 : US9, v141 : US3, v142 : US2, v143 : US3) = method13()
            let v144 : US15 = v0.l3
            let v146 : bool =
                match v144 with
                | US15_2 -> (* CheckHidden *)
                    true
                | _ ->
                    false
            let v148 : bool =
                if v146 then
                    true
                else
                    let v147 : bool = v70 ()
                    v147
            let v153 : string =
                if v148 then
                    let v149 : string = "2px !important"
                    let v150 : string = "0px !important"
                    method23(v150, v149)
                else
                    let v152 : string = "0px !important"
                    v152
            let v161 : US8 =
                match v87 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v155) -> (* Some *)
                    let v156 : string = "children"
                    let v157 : string = "solid-js"
                    let v158 : JS.Function = import v156 v157
                    let v159 : (unit -> (JSX.Element [])) = v158.Invoke v155 |> unbox<unit -> JSX.Element[]>
                    US8_1(v159)
            let v164 : (unit -> (JSX.Element [])) =
                match v161 with
                | US8_0 -> (* None *)
                    closure28(v0, v69, v70, v72)
                | US8_1(v163) -> (* Some *)
                    v163
            let v165 : US3 = US3_1(v153)
            let v166 : string = "$neutral5"
            let v167 : US3 = US3_1(v166)
            let v168 : US8 = US8_1(v164)
            let v169 : string = "$neutral9"
            let v170 : US3 = US3_1(v169)
            let v171 : string = "flex"
            let v172 : US3 = US3_1(v171)
            let v173 : string = "column"
            let v174 : US3 = US3_1(v173)
            let v175 : string = "$sm"
            let v176 : US3 = US3_1(v175)
            let v177 : string = "3px 20px 0 8px"
            let v178 : US3 = US3_1(v177)
            let v179 : ((string * obj) []) = method17(v76, v77, v78, v79, v80, v81, v165, v167, v84, v85, v86, v168, v170, v89, v90, v91, v92, v93, v172, v95, v96, v97, v174, v99, v176, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v178, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143)
            let v180 : obj = createObj v179
            let v181 : (unit -> (JSX.Element [])) = closure28(v0, v69, v70, v72)
            emitJsExpr (v180, v181) "$0.children = $1"
            let v182 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
            let v183 : string = "createComponent"
            let v184 : string = "solid-js"
            let v185 : JS.Function = import v183 v184
            let v186 : JSX.Element = v185.Invoke (v182, v180) |> unbox<JSX.Element>
            v186
    let v398 : JSX.Element =
        match v12 with
        | US8_0 -> (* None *)
            let v188 : string = "Td"
            let v189 : string = "@hope-ui/solid"
            let v190 : JS.Function = import v188 v189
            let struct (v191 : US3, v192 : US3, v193 : US3, v194 : US6, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US7, v202 : US8, v203 : US3, v204 : US3, v205 : US7, v206 : US9, v207 : US3, v208 : US3, v209 : US3, v210 : US10, v211 : US7, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US11, v219 : US3, v220 : US3, v221 : US3, v222 : US11, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US3, v231 : US12, v232 : US13, v233 : US12, v234 : US3, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US3, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US3, v247 : US3, v248 : US3, v249 : US3, v250 : US3, v251 : US11, v252 : US3, v253 : US3, v254 : US9, v255 : US9, v256 : US3, v257 : US2, v258 : US3) = method13()
            let v266 : US8 =
                match v202 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v260) -> (* Some *)
                    let v261 : string = "children"
                    let v262 : string = "solid-js"
                    let v263 : JS.Function = import v261 v262
                    let v264 : (unit -> (JSX.Element [])) = v263.Invoke v260 |> unbox<unit -> JSX.Element[]>
                    US8_1(v264)
            let v269 : (unit -> (JSX.Element [])) =
                match v266 with
                | US8_0 -> (* None *)
                    closure35()
                | US8_1(v268) -> (* Some *)
                    v268
            let v270 : string = "0"
            let v271 : US3 = US3_1(v270)
            let v272 : US8 = US8_1(v269)
            let v273 : string = "9px"
            let v274 : US3 = US3_1(v273)
            let v275 : US3 = US3_1(v270)
            let v276 : ((string * obj) []) = method17(v191, v192, v193, v194, v195, v271, v197, v198, v199, v200, v201, v272, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v274, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v275, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258)
            let v277 : obj = createObj v276
            let v278 : (unit -> (JSX.Element [])) = closure35()
            emitJsExpr (v277, v278) "$0.children = $1"
            let v279 : (obj -> JSX.Element) = v190 |> unbox<obj -> JSX.Element>
            let v280 : string = "createComponent"
            let v281 : string = "solid-js"
            let v282 : JS.Function = import v280 v281
            let v283 : JSX.Element = v282.Invoke (v279, v277) |> unbox<JSX.Element>
            v283
        | US8_1(v284) -> (* Some *)
            let v285 : string = "Td"
            let v286 : string = "@hope-ui/solid"
            let v287 : JS.Function = import v285 v286
            let struct (v288 : US3, v289 : US3, v290 : US3, v291 : US6, v292 : US3, v293 : US3, v294 : US3, v295 : US3, v296 : US3, v297 : US3, v298 : US7, v299 : US8, v300 : US3, v301 : US3, v302 : US7, v303 : US9, v304 : US3, v305 : US3, v306 : US3, v307 : US10, v308 : US7, v309 : US3, v310 : US3, v311 : US3, v312 : US3, v313 : US3, v314 : US3, v315 : US11, v316 : US3, v317 : US3, v318 : US3, v319 : US11, v320 : US3, v321 : US3, v322 : US3, v323 : US3, v324 : US3, v325 : US3, v326 : US3, v327 : US3, v328 : US12, v329 : US13, v330 : US12, v331 : US3, v332 : US3, v333 : US3, v334 : US3, v335 : US3, v336 : US3, v337 : US3, v338 : US3, v339 : US3, v340 : US3, v341 : US3, v342 : US3, v343 : US3, v344 : US3, v345 : US3, v346 : US3, v347 : US3, v348 : US11, v349 : US3, v350 : US3, v351 : US9, v352 : US9, v353 : US3, v354 : US2, v355 : US3) = method13()
            let v358 : string =
                match v48 with
                | US3_0 -> (* None *)
                    let v356 : string = "0"
                    v356
                | US3_1(v357) -> (* Some *)
                    v357
            let v366 : US8 =
                match v299 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v360) -> (* Some *)
                    let v361 : string = "children"
                    let v362 : string = "solid-js"
                    let v363 : JS.Function = import v361 v362
                    let v364 : (unit -> (JSX.Element [])) = v363.Invoke v360 |> unbox<unit -> JSX.Element[]>
                    US8_1(v364)
            let v369 : (unit -> (JSX.Element [])) =
                match v366 with
                | US8_0 -> (* None *)
                    closure36(v0, v70, v284)
                | US8_1(v368) -> (* Some *)
                    v368
            let v370 : string = "0"
            let v371 : US3 = US3_1(v370)
            let v372 : US8 = US8_1(v369)
            let v373 : string = "flex"
            let v374 : US3 = US3_1(v373)
            let v375 : string = "6"
            let v376 : US3 = US3_1(v375)
            let v377 : string = "column"
            let v378 : US3 = US3_1(v377)
            let v379 : string = "$sm"
            let v380 : US3 = US3_1(v379)
            let v381 : string = "$base"
            let v382 : US3 = US3_1(v381)
            let v383 : US3 = US3_1(v370)
            let v384 : string = "85vh"
            let v385 : US3 = US3_1(v384)
            let v386 : US3 = US3_1(v370)
            let v387 : string = "auto"
            let v388 : US3 = US3_1(v387)
            let v389 : US3 = US3_1(v358)
            let v390 : ((string * obj) []) = method17(v288, v289, v290, v291, v292, v371, v294, v295, v296, v297, v298, v372, v300, v301, v302, v303, v304, v305, v374, v307, v308, v376, v378, v311, v380, v313, v314, v315, v316, v317, v318, v319, v382, v383, v322, v323, v324, v325, v385, v327, v328, v329, v330, v386, v332, v333, v388, v389, v336, v337, v338, v339, v340, v341, v342, v343, v344, v345, v346, v347, v348, v349, v350, v351, v352, v353, v354, v355)
            let v391 : obj = createObj v390
            let v392 : (unit -> (JSX.Element [])) = closure36(v0, v70, v284)
            emitJsExpr (v391, v392) "$0.children = $1"
            let v393 : (obj -> JSX.Element) = v287 |> unbox<obj -> JSX.Element>
            let v394 : string = "createComponent"
            let v395 : string = "solid-js"
            let v396 : JS.Function = import v394 v395
            let v397 : JSX.Element = v396.Invoke (v393, v391) |> unbox<JSX.Element>
            v397
    [|v187; v398|]
and method21 (v0 : Mut5) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l2
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let struct (v70 : US3, v71 : US3, v72 : US3, v73 : US6, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US7, v81 : US8, v82 : US3, v83 : US3, v84 : US7, v85 : US9, v86 : US3, v87 : US3, v88 : US3, v89 : US10, v90 : US7, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US11, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US12, v111 : US13, v112 : US12, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US11, v131 : US3, v132 : US3, v133 : US9, v134 : US9, v135 : US3, v136 : US2, v137 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v145 : US8 =
        match v81 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v139) -> (* Some *)
            let v140 : string = "children"
            let v141 : string = "solid-js"
            let v142 : JS.Function = import v140 v141
            let v143 : (unit -> (JSX.Element [])) = v142.Invoke v139 |> unbox<unit -> JSX.Element[]>
            US8_1(v143)
    let v146 : US15 = v0.l3
    let v148 : bool =
        match v146 with
        | US15_0 -> (* CheckDisabled *)
            true
        | _ ->
            false
    let v149 : bool = v148 <> true
    let struct (v150 : (unit -> bool), v151 : (bool -> unit)) = method22(v149)
    let v152 : string = "Tr"
    let v153 : string = "@hope-ui/solid"
    let v154 : JS.Function = import v152 v153
    let struct (v155 : US3, v156 : US3, v157 : US3, v158 : US6, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US3, v164 : US3, v165 : US7, v166 : US8, v167 : US3, v168 : US3, v169 : US7, v170 : US9, v171 : US3, v172 : US3, v173 : US3, v174 : US10, v175 : US7, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US11, v183 : US3, v184 : US3, v185 : US3, v186 : US11, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US12, v196 : US13, v197 : US12, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US11, v216 : US3, v217 : US3, v218 : US9, v219 : US9, v220 : US3, v221 : US2, v222 : US3) = method13()
    let v223 : string = "column"
    let v224 : string = "row"
    let v225 : string = method23(v224, v223)
    let v233 : US8 =
        match v166 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v227) -> (* Some *)
            let v228 : string = "children"
            let v229 : string = "solid-js"
            let v230 : JS.Function = import v228 v229
            let v231 : (unit -> (JSX.Element [])) = v230.Invoke v227 |> unbox<unit -> JSX.Element[]>
            US8_1(v231)
    let v236 : (unit -> (JSX.Element [])) =
        match v233 with
        | US8_0 -> (* None *)
            closure27(v0, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v151, v150)
        | US8_1(v235) -> (* Some *)
            v235
    let v237 : string = "$neutral5"
    let v238 : US3 = US3_1(v237)
    let v239 : string = "1px 2px"
    let v240 : US3 = US3_1(v239)
    let v241 : US8 = US8_1(v236)
    let v242 : string = "flex"
    let v243 : US3 = US3_1(v242)
    let v244 : string = "1"
    let v245 : US3 = US3_1(v244)
    let v246 : US3 = US3_1(v225)
    let v247 : ((string * obj) []) = method17(v155, v156, v157, v158, v159, v160, v161, v238, v240, v164, v165, v241, v167, v168, v169, v170, v171, v172, v243, v174, v175, v245, v246, v178, v179, v180, v181, v182, v98, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222)
    let v248 : obj = createObj v247
    let v249 : (unit -> (JSX.Element [])) = closure27(v0, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v151, v150)
    emitJsExpr (v248, v249) "$0.children = $1"
    let v250 : (obj -> JSX.Element) = v154 |> unbox<obj -> JSX.Element>
    let v251 : string = "createComponent"
    let v252 : string = "solid-js"
    let v253 : JS.Function = import v251 v252
    let v254 : JSX.Element = v253.Invoke (v250, v248) |> unbox<JSX.Element>
    v254
and closure26 () (v0 : Mut5) : JSX.Element =
    method21(v0)
and closure72 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = emitJsExpr v0 "JSON.stringify($0, null, 2)"
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    let v3 : JSX.Element = Html.fragment [ v2 ]
    [|v3|]
and closure71 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure72(v0)
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : string = "8px"
    let v86 : US3 = US3_1(v85)
    let v87 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v84, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v86, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure72(v0)
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    [|v94|]
and closure70 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : string = "State"
    let v70 : JSX.Element = v69 |> unbox<JSX.Element>
    let v71 : JSX.Element = Html.fragment [ v70 ]
    let v72 : (unit -> (JSX.Element [])) = closure71(v0)
    let v73 : US8 = US8_1(v72)
    let v74 : US11 = US11_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v73, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v74, v62, v63, v64, v65, v66, v67, v68)
and closure15 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure16(v0, v1)
    let v5 : US15 = US15_2
    let v6 : Mut5 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut5 -> JSX.Element) = closure26()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    let v12 : US14 = US14_0
    let v13 : US14 = US14_0
    let v14 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure70(v1)
    let v15 : US15 = US15_2
    let v16 : Mut5 = {l0 = v12; l1 = v13; l2 = v14; l3 = v15} : Mut5
    let v17 : JS.Function = import v7 v8
    let v18 : JSX.Element = v17.Invoke (v10, v16) |> unbox<JSX.Element>
    [|v11; v18|]
and closure75 () () : (JSX.Element []) =
    [||]
and closure74 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : string = "Tbody"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : US8 = v0.l11
    let v7 : (unit -> (JSX.Element [])) =
        match v4 with
        | US8_0 -> (* None *)
            closure75()
        | US8_1(v6) -> (* Some *)
            v6
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US7, v19 : US8, v20 : US3, v21 : US3, v22 : US7, v23 : US9, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US12, v49 : US13, v50 : US12, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US11, v69 : US3, v70 : US3, v71 : US9, v72 : US9, v73 : US3, v74 : US2, v75 : US3) = method13()
    let v83 : US8 =
        match v19 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US8_1(v81)
    let v85 : (unit -> (JSX.Element [])) =
        match v83 with
        | US8_0 -> (* None *)
            v7
        | US8_1(v84) -> (* Some *)
            v84
    let v86 : string = "$blackAlpha3"
    let v87 : US3 = US3_1(v86)
    let v88 : US8 = US8_1(v85)
    let v89 : string = "flex"
    let v90 : US3 = US3_1(v89)
    let v91 : string = "column"
    let v92 : US3 = US3_1(v91)
    let v93 : string = "-1px"
    let v94 : US3 = US3_1(v93)
    let v95 : ((string * obj) []) = method17(v8, v9, v10, v11, v87, v13, v14, v15, v16, v17, v18, v88, v20, v21, v22, v23, v24, v25, v90, v27, v28, v29, v92, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v94, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v96 : obj = createObj v95
    emitJsExpr (v96, v7) "$0.children = $1"
    let v97 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v98 : string = "createComponent"
    let v99 : string = "solid-js"
    let v100 : JS.Function = import v98 v99
    let v101 : JSX.Element = v100.Invoke (v97, v96) |> unbox<JSX.Element>
    [|v101|]
and method29 (v0 : Mut3) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v72 : US3 = v0.l46
    let v75 : string =
        match v72 with
        | US3_0 -> (* None *)
            let v73 : string = "hidden"
            v73
        | US3_1(v74) -> (* Some *)
            v74
    let v83 : US8 =
        match v15 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US8_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US8_0 -> (* None *)
            closure74(v0)
        | US8_1(v85) -> (* Some *)
            v85
    let v87 : US8 = US8_1(v86)
    let v88 : string = "flex"
    let v89 : US3 = US3_1(v88)
    let v90 : string = "1"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "column"
    let v93 : US3 = US3_1(v92)
    let v94 : string = "hidden"
    let v95 : US3 = US3_1(v94)
    let v96 : US3 = US3_1(v75)
    let v97 : ((string * obj) []) = method17(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v87, v16, v17, v18, v19, v20, v21, v89, v23, v24, v91, v93, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v95, v96, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v98 : obj = createObj v97
    let v99 : (unit -> (JSX.Element [])) = closure74(v0)
    emitJsExpr (v98, v99) "$0.children = $1"
    let v100 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v101 : string = "createComponent"
    let v102 : string = "solid-js"
    let v103 : JS.Function = import v101 v102
    let v104 : JSX.Element = v103.Invoke (v100, v98) |> unbox<JSX.Element>
    v104
and closure73 () (v0 : Mut3) : JSX.Element =
    method29(v0)
and closure14 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let v77 : US8 =
        match v13 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US8_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US8_0 -> (* None *)
            closure15(v0, v1)
        | US8_1(v79) -> (* Some *)
            v79
    let v81 : US8 = US8_1(v80)
    let v82 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v81; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure15(v0, v1)
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure73()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure13 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : string = "Debug"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure14(v0, v1)
    let v74 : US8 = US8_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v74, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure12 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure13(v0, v1)
    let v5 : US15 = US15_0
    let v6 : Mut5 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut5 -> JSX.Element) = closure26()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    [|v11|]
and closure11 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let v77 : US8 =
        match v13 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US8_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US8_0 -> (* None *)
            closure12(v0, v1)
        | US8_1(v79) -> (* Some *)
            v79
    let v81 : US8 = US8_1(v80)
    let v82 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v81; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure12(v0, v1)
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure73()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and method14 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure11(v1, v0)
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : string = "$blackAlpha9"
    let v85 : US3 = US3_1(v84)
    let v86 : string = "0"
    let v87 : US3 = US3_1(v86)
    let v88 : US8 = US8_1(v83)
    let v89 : string = "flex"
    let v90 : US3 = US3_1(v89)
    let v91 : string = "column"
    let v92 : US3 = US3_1(v91)
    let v93 : string = "80vh"
    let v94 : US3 = US3_1(v93)
    let v95 : string = "50vw"
    let v96 : US3 = US3_1(v95)
    let v97 : string = "auto"
    let v98 : US3 = US3_1(v97)
    let v99 : string = "absolute"
    let v100 : US3 = US3_1(v99)
    let v101 : US3 = US3_1(v86)
    let v102 : int32 = 2
    let v103 : US2 = US2_1(v102)
    let v104 : ((string * obj) []) = method17(v5, v6, v7, v8, v85, v10, v11, v12, v13, v87, v15, v88, v17, v18, v19, v20, v21, v22, v90, v24, v25, v26, v92, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v94, v96, v45, v46, v47, v48, v98, v50, v51, v52, v53, v54, v55, v56, v57, v100, v101, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v103, v72)
    let v105 : obj = createObj v104
    let v106 : (unit -> (JSX.Element [])) = closure11(v1, v0)
    emitJsExpr (v105, v106) "$0.children = $1"
    let v107 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v108 : string = "createComponent"
    let v109 : string = "solid-js"
    let v110 : JS.Function = import v108 v109
    let v111 : JSX.Element = v110.Invoke (v107, v105) |> unbox<JSX.Element>
    v111
and closure10 () (v0 : Mut2) : JSX.Element =
    method14()
and closure79 () () : (JSX.Element []) =
    [||]
and closure84 () () : (JSX.Element []) =
    [||]
and closure87 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : US3 = v0.l26
    let v4 : string =
        match v1 with
        | US3_0 -> (* None *)
            let v2 : string = ""
            v2
        | US3_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = v4 |> unbox<JSX.Element>
    let v6 : JSX.Element = Html.fragment [ v5 ]
    [|v6|]
and closure88 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    let v69 : string = "-13px"
    let v70 : US3 = US3_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v70, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure89 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure86 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let struct (v72 : US3, v73 : US3, v74 : US3, v75 : US6, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US7, v83 : US8, v84 : US3, v85 : US3, v86 : US7, v87 : US9, v88 : US3, v89 : US3, v90 : US3, v91 : US10, v92 : US7, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US11, v100 : US3, v101 : US3, v102 : US3, v103 : US11, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US12, v113 : US13, v114 : US12, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US11, v133 : US3, v134 : US3, v135 : US9, v136 : US9, v137 : US3, v138 : US2, v139 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67
    let v140 : Mut3 = {l0 = v72; l1 = v73; l2 = v74; l3 = v75; l4 = v76; l5 = v77; l6 = v78; l7 = v79; l8 = v80; l9 = v81; l10 = v82; l11 = v83; l12 = v84; l13 = v85; l14 = v86; l15 = v87; l16 = v88; l17 = v89; l18 = v90; l19 = v91; l20 = v92; l21 = v93; l22 = v94; l23 = v95; l24 = v96; l25 = v97; l26 = v98; l27 = v99; l28 = v100; l29 = v101; l30 = v102; l31 = v103; l32 = v104; l33 = v105; l34 = v106; l35 = v107; l36 = v108; l37 = v109; l38 = v110; l39 = v111; l40 = v112; l41 = v113; l42 = v114; l43 = v115; l44 = v116; l45 = v117; l46 = v118; l47 = v119; l48 = v120; l49 = v121; l50 = v122; l51 = v123; l52 = v124; l53 = v125; l54 = v126; l55 = v127; l56 = v128; l57 = v129; l58 = v130; l59 = v131; l60 = v132; l61 = v133; l62 = v134; l63 = v135; l64 = v136; l65 = v137; l66 = v138; l67 = v139} : Mut3
    let v141 : US7 = US7_1(true)
    let v142 : Mut3 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v141; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66; l63 = v67; l64 = v68; l65 = v69; l66 = v70; l67 = v71} : Mut3
    method27(v142, v140)
    let struct (v143 : US3, v144 : US3, v145 : US3, v146 : US6, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US7, v154 : US8, v155 : US3, v156 : US3, v157 : US7, v158 : US9, v159 : US3, v160 : US3, v161 : US3, v162 : US10, v163 : US7, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US11, v171 : US3, v172 : US3, v173 : US3, v174 : US11, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US12, v184 : US13, v185 : US12, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US11, v204 : US3, v205 : US3, v206 : US9, v207 : US9, v208 : US3, v209 : US2, v210 : US3) = v142.l0, v142.l1, v142.l2, v142.l3, v142.l4, v142.l5, v142.l6, v142.l7, v142.l8, v142.l9, v142.l10, v142.l11, v142.l12, v142.l13, v142.l14, v142.l15, v142.l16, v142.l17, v142.l18, v142.l19, v142.l20, v142.l21, v142.l22, v142.l23, v142.l24, v142.l25, v142.l26, v142.l27, v142.l28, v142.l29, v142.l30, v142.l31, v142.l32, v142.l33, v142.l34, v142.l35, v142.l36, v142.l37, v142.l38, v142.l39, v142.l40, v142.l41, v142.l42, v142.l43, v142.l44, v142.l45, v142.l46, v142.l47, v142.l48, v142.l49, v142.l50, v142.l51, v142.l52, v142.l53, v142.l54, v142.l55, v142.l56, v142.l57, v142.l58, v142.l59, v142.l60, v142.l61, v142.l62, v142.l63, v142.l64, v142.l65, v142.l66, v142.l67
    let v218 : US8 =
        match v154 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v212) -> (* Some *)
            let v213 : string = "children"
            let v214 : string = "solid-js"
            let v215 : JS.Function = import v213 v214
            let v216 : (unit -> (JSX.Element [])) = v215.Invoke v212 |> unbox<unit -> JSX.Element[]>
            US8_1(v216)
    let v221 : (unit -> (JSX.Element [])) =
        match v218 with
        | US8_0 -> (* None *)
            closure87(v0)
        | US8_1(v220) -> (* Some *)
            v220
    let v222 : US8 = US8_1(v221)
    let v223 : ((string * obj) []) = method17(v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v222, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210)
    let v224 : obj = createObj v223
    let v225 : (unit -> (JSX.Element [])) = closure87(v0)
    emitJsExpr (v224, v225) "$0.children = $1"
    let v226 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v227 : string = "createComponent"
    let v228 : string = "solid-js"
    let v229 : JS.Function = import v227 v228
    let v230 : JSX.Element = v229.Invoke (v226, v224) |> unbox<JSX.Element>
    let v231 : string = "&nbsp;"
    let v232 : JSX.Element = v231 |> unbox<JSX.Element>
    let v233 : JSX.Element = Html.fragment [ v232 ]
    let v234 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure88()
    let v235 : (unit -> JS.Function) = closure89()
    let v236 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure55()
    let v237 : Mut8 = {l0 = v234; l1 = v235; l2 = v236} : Mut8
    let v238 : JS.Function = import v227 v228
    let v239 : (Mut8 -> JSX.Element) = closure57()
    let v240 : JSX.Element = v238.Invoke (v239, v237) |> unbox<JSX.Element>
    [|v230; v233; v240|]
and method31 (v0 : Mut3) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v79 : US8 =
        match v15 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US8_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US8_0 -> (* None *)
            closure86(v0)
        | US8_1(v81) -> (* Some *)
            v81
    let v83 : US8 = US8_1(v82)
    let v84 : ((string * obj) []) = method17(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v83, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v85 : obj = createObj v84
    let v86 : (unit -> (JSX.Element [])) = closure86(v0)
    emitJsExpr (v85, v86) "$0.children = $1"
    let v87 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v88 : string = "createComponent"
    let v89 : string = "solid-js"
    let v90 : JS.Function = import v88 v89
    let v91 : JSX.Element = v90.Invoke (v87, v85) |> unbox<JSX.Element>
    v91
and closure85 () (v0 : Mut3) : JSX.Element =
    method31(v0)
and closure83 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure84()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v81 : US3 = US3_1(v80)
    let v82 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v81; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure84()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure85()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure82 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : (unit -> (JSX.Element [])) = closure83()
    let v69 : US8 = US8_1(v68)
    let v70 : string = "1px 6px"
    let v71 : US3 = US3_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure91 (v0 : string) () : (JSX.Element []) =
    let struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) = method13()
    let v76 : US8 =
        match v12 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v70) -> (* Some *)
            let v71 : string = "children"
            let v72 : string = "solid-js"
            let v73 : JS.Function = import v71 v72
            let v74 : (unit -> (JSX.Element [])) = v73.Invoke v70 |> unbox<unit -> JSX.Element[]>
            US8_1(v74)
    let v79 : (unit -> (JSX.Element [])) =
        match v76 with
        | US8_0 -> (* None *)
            closure84()
        | US8_1(v78) -> (* Some *)
            v78
    let v80 : US8 = US8_1(v79)
    let v81 : US3 = US3_1(v0)
    let v82 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v80; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v81; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure84()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure85()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure90 (v0 : string) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (unit -> (JSX.Element [])) = closure91(v0)
    let v70 : US8 = US8_1(v69)
    let v71 : string = "1px 6px"
    let v72 : US3 = US3_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v70, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v72, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure93 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure84()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v81 : US3 = US3_1(v80)
    let v82 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v81; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure84()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure85()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure92 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : (unit -> (JSX.Element [])) = closure93()
    let v69 : US8 = US8_1(v68)
    let v70 : string = "1px 6px"
    let v71 : US3 = US3_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure95 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure84()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v81 : US3 = US3_1(v80)
    let v82 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v81; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure84()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure85()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure94 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : (unit -> (JSX.Element [])) = closure95()
    let v69 : US8 = US8_1(v68)
    let v70 : string = "1px 6px"
    let v71 : US3 = US3_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure81 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v23 : JSX.Element =
        if v1 then
            let v2 : US14 = US14_0
            let v3 : US14 = US14_0
            let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure82()
            let v5 : US15 = US15_2
            let v6 : Mut5 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut5
            let v7 : string = "createComponent"
            let v8 : string = "solid-js"
            let v9 : JS.Function = import v7 v8
            let v10 : (Mut5 -> JSX.Element) = closure26()
            let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
            v11
        else
            let v12 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let v13 : US14 = US14_0
            let v14 : US14 = US14_0
            let v15 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure90(v12)
            let v16 : US15 = US15_2
            let v17 : Mut5 = {l0 = v13; l1 = v14; l2 = v15; l3 = v16} : Mut5
            let v18 : string = "createComponent"
            let v19 : string = "solid-js"
            let v20 : JS.Function = import v18 v19
            let v21 : (Mut5 -> JSX.Element) = closure26()
            let v22 : JSX.Element = v20.Invoke (v21, v17) |> unbox<JSX.Element>
            v22
    let v24 : US14 = US14_0
    let v25 : US14 = US14_0
    let v26 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure92()
    let v27 : US15 = US15_2
    let v28 : Mut5 = {l0 = v24; l1 = v25; l2 = v26; l3 = v27} : Mut5
    let v29 : string = "createComponent"
    let v30 : string = "solid-js"
    let v31 : JS.Function = import v29 v30
    let v32 : (Mut5 -> JSX.Element) = closure26()
    let v33 : JSX.Element = v31.Invoke (v32, v28) |> unbox<JSX.Element>
    let v34 : US14 = US14_0
    let v35 : US14 = US14_0
    let v36 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure94()
    let v37 : US15 = US15_2
    let v38 : Mut5 = {l0 = v34; l1 = v35; l2 = v36; l3 = v37} : Mut5
    let v39 : JS.Function = import v29 v30
    let v40 : JSX.Element = v39.Invoke (v32, v38) |> unbox<JSX.Element>
    [|v23; v33; v40|]
and method30 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method1()
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure81(v3)
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : Mut3 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v84; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67; l63 = v68; l64 = v69; l65 = v70; l66 = v71; l67 = v72} : Mut3
    let v86 : (unit -> (JSX.Element [])) = closure81(v3)
    emitJsExpr (v85, v86) "$0.children = $1"
    let v87 : string = "createComponent"
    let v88 : string = "solid-js"
    let v89 : JS.Function = import v87 v88
    let v90 : (Mut3 -> JSX.Element) = closure73()
    let v91 : JSX.Element = v89.Invoke (v90, v85) |> unbox<JSX.Element>
    v91
and closure80 () (v0 : Mut3) : JSX.Element =
    method30()
and closure78 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure79()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure79()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure80()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    [|v86|]
and closure77 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Links"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure78()
    let v72 : US8 = US8_1(v71)
    let v73 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66, v67)
and closure98 () () : (JSX.Element []) =
    [||]
and method33 () : struct ((unit -> string) * (unit -> unit)) =
    let v0 : string = "useColorMode"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : obj = v2.Invoke () |> unbox
    let v4 : (unit -> string) = v3?colorMode |> unbox
    let v5 : (unit -> unit) = v3?toggleColorMode |> unbox
    struct (v4, v5)
and closure105 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure106 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure104 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) = method13()
    let v71 : string = "dark"
    let v72 : obj = v71
    let v80 : US8 =
        match v14 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure105()
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : string = "neutral"
    let v86 : US3 = US3_1(v85)
    let v87 : string = "sm"
    let v88 : US3 = US3_1(v87)
    let v89 : US9 = US9_1(v72)
    let v90 : ((string * obj) []) = method17(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v84, v15, v86, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v88, v59, v60, v61, v62, v63, v64, v65, v89, v67, v68, v69, v70)
    let v91 : obj = createObj v90
    let v92 : (unit -> (JSX.Element [])) = closure105()
    emitJsExpr (v91, v92) "$0.children = $1"
    let v93 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v94 : string = "createComponent"
    let v95 : string = "solid-js"
    let v96 : JS.Function = import v94 v95
    let v97 : JSX.Element = v96.Invoke (v93, v91) |> unbox<JSX.Element>
    let v98 : JS.Function = import v0 v1
    let struct (v99 : US3, v100 : US3, v101 : US3, v102 : US6, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US7, v110 : US8, v111 : US3, v112 : US3, v113 : US7, v114 : US9, v115 : US3, v116 : US3, v117 : US3, v118 : US10, v119 : US7, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US11, v127 : US3, v128 : US3, v129 : US3, v130 : US11, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US12, v140 : US13, v141 : US12, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US3, v156 : US3, v157 : US3, v158 : US3, v159 : US11, v160 : US3, v161 : US3, v162 : US9, v163 : US9, v164 : US3, v165 : US2, v166 : US3) = method13()
    let v167 : string = "light"
    let v168 : obj = v167
    let v175 : US8 =
        match v110 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v170) -> (* Some *)
            let v171 : string = "children"
            let v172 : JS.Function = import v171 v95
            let v173 : (unit -> (JSX.Element [])) = v172.Invoke v170 |> unbox<unit -> JSX.Element[]>
            US8_1(v173)
    let v178 : (unit -> (JSX.Element [])) =
        match v175 with
        | US8_0 -> (* None *)
            closure106()
        | US8_1(v177) -> (* Some *)
            v177
    let v179 : US8 = US8_1(v178)
    let v180 : US3 = US3_1(v85)
    let v181 : US3 = US3_1(v87)
    let v182 : US9 = US9_1(v168)
    let v183 : ((string * obj) []) = method17(v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v179, v111, v180, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v181, v155, v156, v157, v158, v159, v160, v161, v182, v163, v164, v165, v166)
    let v184 : obj = createObj v183
    let v185 : (unit -> (JSX.Element [])) = closure106()
    emitJsExpr (v184, v185) "$0.children = $1"
    let v186 : (obj -> JSX.Element) = v98 |> unbox<obj -> JSX.Element>
    let v187 : JS.Function = import v94 v95
    let v188 : JSX.Element = v187.Invoke (v186, v184) |> unbox<JSX.Element>
    [|v97; v188|]
and closure103 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) = method13()
    let v78 : US8 =
        match v14 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v72) -> (* Some *)
            let v73 : string = "children"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : (unit -> (JSX.Element [])) = v75.Invoke v72 |> unbox<unit -> JSX.Element[]>
            US8_1(v76)
    let v81 : (unit -> (JSX.Element [])) =
        match v78 with
        | US8_0 -> (* None *)
            closure104()
        | US8_1(v80) -> (* Some *)
            v80
    let v82 : US8 = US8_1(v81)
    let v83 : string = "row"
    let v84 : US3 = US3_1(v83)
    let v85 : string = "$4"
    let v86 : US3 = US3_1(v85)
    let v87 : ((string * obj) []) = method17(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v82, v15, v16, v17, v18, v19, v84, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v86, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure104()
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    [|v94|]
and closure107 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure102 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v73 : string = v1 ()
    let v81 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v75) -> (* Some *)
            let v76 : string = "children"
            let v77 : string = "solid-js"
            let v78 : JS.Function = import v76 v77
            let v79 : (unit -> (JSX.Element [])) = v78.Invoke v75 |> unbox<unit -> JSX.Element[]>
            US8_1(v79)
    let v84 : (unit -> (JSX.Element [])) =
        match v81 with
        | US8_0 -> (* None *)
            closure103()
        | US8_1(v83) -> (* Some *)
            v83
    let v85 : US8 = US8_1(v84)
    let v86 : US3 = US3_1(v73)
    let v87 : (obj -> unit) = closure107(v0)
    let v88 : US12 = US12_1(v87)
    let v89 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v85, v17, v18, v19, v20, v86, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v88, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v90 : obj = createObj v89
    let v91 : (unit -> (JSX.Element [])) = closure103()
    emitJsExpr (v90, v91) "$0.children = $1"
    let v92 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v93 : string = "createComponent"
    let v94 : string = "solid-js"
    let v95 : JS.Function = import v93 v94
    let v96 : JSX.Element = v95.Invoke (v92, v90) |> unbox<JSX.Element>
    [|v96|]
and closure101 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : string = "Theme"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure102(v0, v1)
    let v74 : US8 = US8_1(v73)
    let v75 : string = "5px 6px"
    let v76 : US3 = US3_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v74, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v76, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure100 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure101(v0, v1)
    let v5 : US15 = US15_2
    let v6 : Mut5 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut5 -> JSX.Element) = closure26()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    [|v11|]
and method32 () : JSX.Element =
    let struct (v0 : (unit -> string), v1 : (unit -> unit)) = method33()
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let v77 : US8 =
        match v13 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US8_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US8_0 -> (* None *)
            closure100(v1, v0)
        | US8_1(v79) -> (* Some *)
            v79
    let v81 : US8 = US8_1(v80)
    let v82 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v81; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure100(v1, v0)
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure73()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    v88
and closure99 () (v0 : Mut3) : JSX.Element =
    method32()
and closure97 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure98()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure98()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure99()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    [|v86|]
and closure96 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Settings"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure97()
    let v72 : US8 = US8_1(v71)
    let v73 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66, v67)
and closure110 () () : (JSX.Element []) =
    [||]
and closure115 () () : (JSX.Element []) =
    [||]
and closure120 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v3
and closure123 (v0 : Mut1) (v1 : US3) : unit =
    v0.l2 <- v1
    ()
and closure122 () (v0 : Mut1) : (US3 -> unit) =
    closure123(v0)
and closure121 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure122()
and closure125 () () : (JSX.Element []) =
    [||]
and closure128 (v0 : Mut9, v1 : string, v2 : Mut1) (v3 : Mut1) : unit =
    let v4 : (Mut1 -> (Mut1 -> (US3 -> unit))) = v0.l1
    let v5 : (Mut1 -> (US3 -> unit)) = v4 v2
    let v6 : (US3 -> unit) = v5 v3
    let v7 : US3 = US3_1(v1)
    v6 v7
    ()
and closure127 (v0 : Mut9, v1 : string) (v2 : Mut1) : (Mut1 -> unit) =
    closure128(v0, v1, v2)
and closure126 (v0 : Mut9, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) (v2 : obj) : unit =
    let v3 : string = v2?currentTarget?value
    let v4 : (Mut1 -> (Mut1 -> unit)) = closure127(v0, v3)
    v1 v4
    ()
and method36 (v0 : Mut9) : JSX.Element =
    let struct (v1 : Mut1, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v3 : string = "Input"
    let v4 : string = "@hope-ui/solid"
    let v5 : JS.Function = import v3 v4
    let struct (v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US7, v17 : US8, v18 : US3, v19 : US3, v20 : US7, v21 : US9, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US11, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US12, v47 : US13, v48 : US12, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US11, v67 : US3, v68 : US3, v69 : US9, v70 : US9, v71 : US3, v72 : US2, v73 : US3) = method13()
    let v74 : (Mut1 -> US3) = v0.l0
    let v75 : US3 = v74 v1
    let v76 : string = JS.undefined
    let v78 : string =
        match v75 with
        | US3_0 -> (* None *)
            v76
        | US3_1(v77) -> (* Some *)
            v77
    let v79 : obj = v78
    let v87 : US8 =
        match v17 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v81) -> (* Some *)
            let v82 : string = "children"
            let v83 : string = "solid-js"
            let v84 : JS.Function = import v82 v83
            let v85 : (unit -> (JSX.Element [])) = v84.Invoke v81 |> unbox<unit -> JSX.Element[]>
            US8_1(v85)
    let v90 : (unit -> (JSX.Element [])) =
        match v87 with
        | US8_0 -> (* None *)
            closure125()
        | US8_1(v89) -> (* Some *)
            v89
    let v91 : US8 = US8_1(v90)
    let v92 : (obj -> unit) = closure126(v0, v2)
    let v93 : US12 = US12_1(v92)
    let v94 : string = "xs"
    let v95 : US3 = US3_1(v94)
    let v96 : string = "text"
    let v97 : US3 = US3_1(v96)
    let v98 : US9 = US9_1(v79)
    let v99 : ((string * obj) []) = method17(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v91, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v93, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v95, v62, v63, v64, v65, v66, v67, v97, v98, v70, v71, v72, v73)
    let v100 : obj = createObj v99
    let v101 : (unit -> (JSX.Element [])) = closure125()
    emitJsExpr (v100, v101) "$0.children = $1"
    let v102 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v103 : string = "createComponent"
    let v104 : string = "solid-js"
    let v105 : JS.Function = import v103 v104
    let v106 : JSX.Element = v105.Invoke (v102, v100) |> unbox<JSX.Element>
    v106
and closure124 () (v0 : Mut9) : JSX.Element =
    method36(v0)
and closure119 () () : (JSX.Element []) =
    let v0 : (Mut1 -> US3) = closure120()
    let v1 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure121()
    let v2 : Mut9 = {l0 = v0; l1 = v1} : Mut9
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : (Mut9 -> JSX.Element) = closure124()
    let v7 : JSX.Element = v5.Invoke (v6, v2) |> unbox<JSX.Element>
    [|v7|]
and closure118 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Token"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure119()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v74, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure131 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v4
and closure134 (v0 : Mut1) (v1 : US3) : unit =
    v0.l3 <- v1
    ()
and closure133 () (v0 : Mut1) : (US3 -> unit) =
    closure134(v0)
and closure132 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure133()
and closure130 () () : (JSX.Element []) =
    let v0 : (Mut1 -> US3) = closure131()
    let v1 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure132()
    let v2 : Mut9 = {l0 = v0; l1 = v1} : Mut9
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : (Mut9 -> JSX.Element) = closure124()
    let v7 : JSX.Element = v5.Invoke (v6, v2) |> unbox<JSX.Element>
    [|v7|]
and closure129 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "URL"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure130()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v74, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure137 () (v0 : Mut1) : US2 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v2
and closure140 (v0 : Mut1) (v1 : US2) : unit =
    v0.l1 <- v1
    ()
and closure139 () (v0 : Mut1) : (US2 -> unit) =
    closure140(v0)
and closure138 () (v0 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure139()
and closure144 (v0 : Mut10, v1 : int32, v2 : Mut1) (v3 : Mut1) : unit =
    let v4 : (Mut1 -> (Mut1 -> (US2 -> unit))) = v0.l1
    let v5 : (Mut1 -> (US2 -> unit)) = v4 v2
    let v6 : (US2 -> unit) = v5 v3
    let v7 : US2 = US2_1(v1)
    v6 v7
    ()
and closure143 (v0 : Mut10, v1 : int32) (v2 : Mut1) : (Mut1 -> unit) =
    closure144(v0, v1, v2)
and closure142 (v0 : Mut10, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) (v2 : obj) : unit =
    let v3 : int32 = v2?currentTarget?value
    let v4 : (Mut1 -> (Mut1 -> unit)) = closure143(v0, v3)
    v1 v4
    ()
and method37 (v0 : Mut10) : JSX.Element =
    let struct (v1 : Mut1, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v3 : string = "Input"
    let v4 : string = "@hope-ui/solid"
    let v5 : JS.Function = import v3 v4
    let struct (v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US7, v17 : US8, v18 : US3, v19 : US3, v20 : US7, v21 : US9, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US11, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US12, v47 : US13, v48 : US12, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US11, v67 : US3, v68 : US3, v69 : US9, v70 : US9, v71 : US3, v72 : US2, v73 : US3) = method13()
    let v74 : (Mut1 -> US2) = v0.l0
    let v75 : US2 = v74 v1
    let v76 : int32 = JS.undefined
    let v78 : int32 =
        match v75 with
        | US2_0 -> (* None *)
            v76
        | US2_1(v77) -> (* Some *)
            v77
    let v79 : obj = v78
    let v87 : US8 =
        match v17 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v81) -> (* Some *)
            let v82 : string = "children"
            let v83 : string = "solid-js"
            let v84 : JS.Function = import v82 v83
            let v85 : (unit -> (JSX.Element [])) = v84.Invoke v81 |> unbox<unit -> JSX.Element[]>
            US8_1(v85)
    let v90 : (unit -> (JSX.Element [])) =
        match v87 with
        | US8_0 -> (* None *)
            closure125()
        | US8_1(v89) -> (* Some *)
            v89
    let v91 : US8 = US8_1(v90)
    let v92 : (obj -> unit) = closure142(v0, v2)
    let v93 : US12 = US12_1(v92)
    let v94 : string = "xs"
    let v95 : US3 = US3_1(v94)
    let v96 : string = "text"
    let v97 : US3 = US3_1(v96)
    let v98 : US9 = US9_1(v79)
    let v99 : ((string * obj) []) = method17(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v91, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v93, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v95, v62, v63, v64, v65, v66, v67, v97, v98, v70, v71, v72, v73)
    let v100 : obj = createObj v99
    let v101 : (unit -> (JSX.Element [])) = closure125()
    emitJsExpr (v100, v101) "$0.children = $1"
    let v102 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v103 : string = "createComponent"
    let v104 : string = "solid-js"
    let v105 : JS.Function = import v103 v104
    let v106 : JSX.Element = v105.Invoke (v102, v100) |> unbox<JSX.Element>
    v106
and closure141 () (v0 : Mut10) : JSX.Element =
    method37(v0)
and closure136 () () : (JSX.Element []) =
    let v0 : (Mut1 -> US2) = closure137()
    let v1 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure138()
    let v2 : Mut10 = {l0 = v0; l1 = v1} : Mut10
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : (Mut10 -> JSX.Element) = closure141()
    let v7 : JSX.Element = v5.Invoke (v6, v2) |> unbox<JSX.Element>
    [|v7|]
and closure135 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Port"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure136()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v74, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure117 () () : (JSX.Element []) =
    let v0 : US14 = US14_0
    let v1 : US14 = US14_0
    let v2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure118()
    let v3 : US15 = US15_2
    let v4 : Mut5 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3} : Mut5
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut5 -> JSX.Element) = closure26()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure129()
    let v13 : US15 = US15_2
    let v14 : Mut5 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13} : Mut5
    let v15 : JS.Function = import v5 v6
    let v16 : JSX.Element = v15.Invoke (v8, v14) |> unbox<JSX.Element>
    let v17 : US14 = US14_0
    let v18 : US14 = US14_0
    let v19 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure135()
    let v20 : US15 = US15_2
    let v21 : Mut5 = {l0 = v17; l1 = v18; l2 = v19; l3 = v20} : Mut5
    let v22 : JS.Function = import v5 v6
    let v23 : JSX.Element = v22.Invoke (v8, v21) |> unbox<JSX.Element>
    [|v9; v16; v23|]
and method35 () : JSX.Element =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure117()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure117()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure73()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    v86
and closure116 () (v0 : Mut3) : JSX.Element =
    method35()
and closure114 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure115()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure115()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure116()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    [|v86|]
and closure113 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Connection"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure114()
    let v72 : US8 = US8_1(v71)
    let v73 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66, v67)
and closure147 () () : (JSX.Element []) =
    [||]
and closure156 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v1)
and closure159 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut4 = {l0 = 0} : Mut4
    while method15(v11, v13) do
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
and closure158 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure159(v0, v1, v2, v3, v4, v5)
and closure157 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure158(v0, v1, v2, v3, v4)
and closure155 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut1 -> US3) = closure156(v0, v1, v2, v3)
    let v5 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure157(v0, v1, v2, v3)
    let v6 : Mut9 = {l0 = v4; l1 = v5} : Mut9
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut9 -> JSX.Element) = closure124()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    [|v11|]
and closure154 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v72 : string = "Address"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure155(v0, v1, v2, v3)
    let v76 : US8 = US8_1(v75)
    let v77 : string = "3px"
    let v78 : US3 = US3_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v76, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure162 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v3)
and closure165 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut4 = {l0 = 0} : Mut4
    while method15(v11, v13) do
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
and closure164 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure165(v0, v1, v2, v3, v4, v5)
and closure163 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure164(v0, v1, v2, v3, v4)
and closure161 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut1 -> US3) = closure162(v0, v1, v2, v3)
    let v5 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure163(v0, v1, v2, v3)
    let v6 : Mut9 = {l0 = v4; l1 = v5} : Mut9
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut9 -> JSX.Element) = closure124()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    [|v11|]
and closure160 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v72 : string = "Private Key"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure161(v0, v1, v2, v3)
    let v76 : US8 = US8_1(v75)
    let v77 : string = "3px"
    let v78 : US3 = US3_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v76, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure153 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure154(v0, v1, v2, v3)
    let v7 : US15 = US15_2
    let v8 : Mut5 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut5
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut5 -> JSX.Element) = closure26()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    let v14 : US14 = US14_0
    let v15 : US14 = US14_0
    let v16 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure160(v0, v1, v2, v3)
    let v17 : US15 = US15_2
    let v18 : Mut5 = {l0 = v14; l1 = v15; l2 = v16; l3 = v17} : Mut5
    let v19 : JS.Function = import v9 v10
    let v20 : JSX.Element = v19.Invoke (v12, v18) |> unbox<JSX.Element>
    [|v13; v20|]
and closure152 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v79 : US8 =
        match v15 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US8_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US8_0 -> (* None *)
            closure153(v0, v1, v2, v3)
        | US8_1(v81) -> (* Some *)
            v81
    let v83 : US8 = US8_1(v82)
    let v84 : Mut3 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v83; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66; l63 = v67; l64 = v68; l65 = v69; l66 = v70; l67 = v71} : Mut3
    let v85 : (unit -> (JSX.Element [])) = closure153(v0, v1, v2, v3)
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut3 -> JSX.Element) = closure73()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    [|v90|]
and closure151 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v77 : string =
        match v0 with
        | US0_0 -> (* Admin *)
            let v72 : string = "admin"
            v72
        | US0_1(v73) -> (* Player *)
            match v73 with
            | US1_0 -> (* O *)
                let v74 : string = "o"
                v74
            | US1_1 -> (* X *)
                let v75 : string = "x"
                v75
    let v78 : JSX.Element = v77 |> unbox<JSX.Element>
    let v79 : JSX.Element = Html.fragment [ v78 ]
    let v80 : (unit -> (JSX.Element [])) = closure152(v0, v1, v2, v3)
    let v81 : US8 = US8_1(v80)
    let v82 : US11 = US11_1(v79)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v81, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v82, v65, v66, v67, v68, v69, v70, v71)
and closure150 () struct (v0 : US0, v1 : string, v2 : string, v3 : string) : (JSX.Element []) =
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure151(v0, v1, v2, v3)
    let v7 : US15 = US15_2
    let v8 : Mut5 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut5
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut5 -> JSX.Element) = closure26()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    [|v13|]
and closure149 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    let v5 : string = "For"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US0 * string * string * string) -> (JSX.Element [])) = closure150()
    let v9 : (unit -> (JSX.Element [])) = v8 |> unbox
    let struct (v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US7, v21 : US8, v22 : US3, v23 : US3, v24 : US7, v25 : US9, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US7, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US11, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US12, v51 : US13, v52 : US12, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US11, v71 : US3, v72 : US3, v73 : US9, v74 : US9, v75 : US3, v76 : US2, v77 : US3) = method13()
    let v78 : (obj []) = v1 |> unbox<obj[]>
    let v85 : US8 =
        match v21 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v80) -> (* Some *)
            let v81 : string = "children"
            let v82 : JS.Function = import v81 v6
            let v83 : (unit -> (JSX.Element [])) = v82.Invoke v80 |> unbox<unit -> JSX.Element[]>
            US8_1(v83)
    let v87 : (unit -> (JSX.Element [])) =
        match v85 with
        | US8_0 -> (* None *)
            v9
        | US8_1(v86) -> (* Some *)
            v86
    let v88 : US8 = US8_1(v87)
    let v89 : US10 = US10_1(v78)
    let v90 : ((string * obj) []) = method17(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v88, v22, v23, v24, v25, v26, v27, v28, v89, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
    let v91 : obj = createObj v90
    emitJsExpr (v91, v9) "$0.children = $1"
    let v92 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v93 : string = "createComponent"
    let v94 : JS.Function = import v93 v6
    let v95 : JSX.Element = v94.Invoke (v92, v91) |> unbox<JSX.Element>
    [|v95|]
and method38 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method13()
    let v77 : US8 =
        match v13 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US8_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US8_0 -> (* None *)
            closure149(v0)
        | US8_1(v79) -> (* Some *)
            v79
    let v81 : US8 = US8_1(v80)
    let v82 : Mut3 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v81; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69} : Mut3
    let v83 : (unit -> (JSX.Element [])) = closure149(v0)
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut3 -> JSX.Element) = closure73()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    v88
and closure148 () (v0 : Mut3) : JSX.Element =
    method38()
and closure146 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure147()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure147()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure148()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    [|v86|]
and closure145 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Accounts"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure146()
    let v72 : US8 = US8_1(v71)
    let v73 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66, v67)
and closure168 () () : (JSX.Element []) =
    [||]
and closure167 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method13()
    let v72 : string = "algorand testnet bank"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v82 : US8 =
        match v15 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US8_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US8_0 -> (* None *)
            closure168()
        | US8_1(v84) -> (* Some *)
            v84
    let v86 : string = "#aaa"
    let v87 : US3 = US3_1(v86)
    let v88 : US8 = US8_1(v85)
    let v89 : string = "1"
    let v90 : US3 = US3_1(v89)
    let v91 : string = "350px"
    let v92 : US3 = US3_1(v91)
    let v93 : string = "https://bank.testnet.algorand.network"
    let v94 : US3 = US3_1(v93)
    let v95 : US11 = US11_1(v74)
    let v96 : ((string * obj) []) = method17(v4, v5, v6, v7, v87, v9, v10, v11, v12, v13, v14, v88, v16, v17, v18, v19, v20, v21, v22, v23, v24, v90, v26, v27, v28, v92, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v94, v62, v63, v95, v65, v66, v67, v68, v69, v70, v71)
    let v97 : obj = createObj v96
    let v98 : (unit -> (JSX.Element [])) = closure168()
    emitJsExpr (v97, v98) "$0.children = $1"
    let v99 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v100 : string = "createComponent"
    let v101 : string = "solid-js"
    let v102 : JS.Function = import v100 v101
    let v103 : JSX.Element = v102.Invoke (v99, v97) |> unbox<JSX.Element>
    [|v103|]
and closure166 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Testnet Bank Dispenser"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure167()
    let v72 : US8 = US8_1(v71)
    let v73 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66, v67)
and closure112 () () : (JSX.Element []) =
    let v0 : US14 = US14_0
    let v1 : US14 = US14_0
    let v2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure113()
    let v3 : US15 = US15_2
    let v4 : Mut5 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3} : Mut5
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut5 -> JSX.Element) = closure26()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure145()
    let v13 : US15 = US15_2
    let v14 : Mut5 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13} : Mut5
    let v15 : JS.Function = import v5 v6
    let v16 : JSX.Element = v15.Invoke (v8, v14) |> unbox<JSX.Element>
    let v17 : US14 = US14_0
    let v18 : US14 = US14_0
    let v19 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure166()
    let v20 : US15 = US15_0
    let v21 : Mut5 = {l0 = v17; l1 = v18; l2 = v19; l3 = v20} : Mut5
    let v22 : JS.Function = import v5 v6
    let v23 : JSX.Element = v22.Invoke (v8, v21) |> unbox<JSX.Element>
    [|v9; v16; v23|]
and method34 () : JSX.Element =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure112()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure112()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure73()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    v86
and closure111 () (v0 : Mut3) : JSX.Element =
    method34()
and closure109 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure110()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure110()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure111()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    [|v86|]
and closure108 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Chain"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure109()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "db"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v74, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure171 () () : (JSX.Element []) =
    [||]
and closure177 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_1
    let v5 : US4 = US4_1
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut4 = {l0 = 0} : Mut4
    while method15(v9, v11) do
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
and method40 (v0 : int32, v1 : Mut11) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure181 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method40(v4, v6) do
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
    let v23 : Mut4 = {l0 = 0} : Mut4
    while method15(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure180 () (v0 : Mut1) : (Mut1 -> unit) =
    closure181(v0)
and closure179 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure180()
    v0 v1
    ()
and closure178 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure179()
and closure188 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US3 =
    US3_1(v2)
and closure190 (v0 : Mut12, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US3) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v9 : string =
        match v5 with
        | US3_0 -> (* None *)
            let v7 : string = ""
            v7
        | US3_1(v8) -> (* Some *)
            v8
    struct (v6, v2, v9, v4)
and closure189 (v0 : Mut12) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US3 -> struct (US4 * int32 * string * string)) =
    closure190(v0, v1, v2, v3, v4)
and method43 (v0 : int32, v1 : Mut14) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure192 (v0 : Mut13) (v1 : Mut1) : US3 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US3 = US3_0
    let v6 : Mut14 = {l0 = 0; l1 = v5} : Mut14
    while method43(v4, v6) do
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
and closure195 (v0 : Mut13, v1 : Mut1, v2 : Mut1) (v3 : US3) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v6 : int32 = v4.Length
    let v7 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v6)
    let v8 : Mut4 = {l0 = 0} : Mut4
    while method15(v6, v8) do
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
and closure194 (v0 : Mut13, v1 : Mut1) (v2 : Mut1) : (US3 -> unit) =
    closure195(v0, v1, v2)
and closure193 (v0 : Mut13) (v1 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure194(v0, v1)
and method42 (v0 : Mut13) : JSX.Element =
    let v1 : (Mut1 -> US3) = closure192(v0)
    let v2 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure193(v0)
    let v3 : Mut9 = {l0 = v1; l1 = v2} : Mut9
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : (Mut9 -> JSX.Element) = closure124()
    let v8 : JSX.Element = v6.Invoke (v7, v3) |> unbox<JSX.Element>
    v8
and closure191 () (v0 : Mut13) : JSX.Element =
    method42(v0)
and closure187 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (struct (US4 * int32 * string * string) -> US3) = closure188()
    let v3 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string))) = closure189(v0)
    let v4 : Mut13 = {l0 = v1; l1 = v2; l2 = v3} : Mut13
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut13 -> JSX.Element) = closure191()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure186 (v0 : Mut12) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : string = "URL"
    let v70 : JSX.Element = v69 |> unbox<JSX.Element>
    let v71 : JSX.Element = Html.fragment [ v70 ]
    let v72 : (unit -> (JSX.Element [])) = closure187(v0)
    let v73 : US8 = US8_1(v72)
    let v74 : string = "3px"
    let v75 : US3 = US3_1(v74)
    let v76 : US11 = US11_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v73, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v75, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v76, v62, v63, v64, v65, v66, v67, v68)
and closure198 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US2 =
    US2_1(v1)
and closure200 (v0 : Mut12, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US2) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v8 : int32 =
        match v5 with
        | US2_0 -> (* None *)
            0
        | US2_1(v7) -> (* Some *)
            v7
    struct (v6, v8, v3, v4)
and closure199 (v0 : Mut12) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US2 -> struct (US4 * int32 * string * string)) =
    closure200(v0, v1, v2, v3, v4)
and method45 (v0 : int32, v1 : Mut16) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure202 (v0 : Mut15) (v1 : Mut1) : US2 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US2 = US2_0
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method45(v4, v6) do
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
and closure205 (v0 : Mut15, v1 : Mut1, v2 : Mut1) (v3 : US2) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v6 : int32 = v4.Length
    let v7 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v6)
    let v8 : Mut4 = {l0 = 0} : Mut4
    while method15(v6, v8) do
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
and closure204 (v0 : Mut15, v1 : Mut1) (v2 : Mut1) : (US2 -> unit) =
    closure205(v0, v1, v2)
and closure203 (v0 : Mut15) (v1 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure204(v0, v1)
and method44 (v0 : Mut15) : JSX.Element =
    let v1 : (Mut1 -> US2) = closure202(v0)
    let v2 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure203(v0)
    let v3 : Mut10 = {l0 = v1; l1 = v2} : Mut10
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : (Mut10 -> JSX.Element) = closure141()
    let v8 : JSX.Element = v6.Invoke (v7, v3) |> unbox<JSX.Element>
    v8
and closure201 () (v0 : Mut15) : JSX.Element =
    method44(v0)
and closure197 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (struct (US4 * int32 * string * string) -> US2) = closure198()
    let v3 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string))) = closure199(v0)
    let v4 : Mut15 = {l0 = v1; l1 = v2; l2 = v3} : Mut15
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut15 -> JSX.Element) = closure201()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure196 (v0 : Mut12) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : string = "Port"
    let v70 : JSX.Element = v69 |> unbox<JSX.Element>
    let v71 : JSX.Element = Html.fragment [ v70 ]
    let v72 : (unit -> (JSX.Element [])) = closure197(v0)
    let v73 : US8 = US8_1(v72)
    let v74 : string = "3px"
    let v75 : US3 = US3_1(v74)
    let v76 : US11 = US11_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v73, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v75, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v76, v62, v63, v64, v65, v66, v67, v68)
and closure185 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure186(v0)
    let v4 : US15 = US15_2
    let v5 : Mut5 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut5
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut5 -> JSX.Element) = closure26()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure196(v0)
    let v14 : US15 = US15_2
    let v15 : Mut5 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14} : Mut5
    let v16 : JS.Function = import v6 v7
    let v17 : JSX.Element = v16.Invoke (v9, v15) |> unbox<JSX.Element>
    [|v10; v17|]
and method41 (v0 : Mut12) : JSX.Element =
    let struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) = method13()
    let v76 : US8 =
        match v12 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v70) -> (* Some *)
            let v71 : string = "children"
            let v72 : string = "solid-js"
            let v73 : JS.Function = import v71 v72
            let v74 : (unit -> (JSX.Element [])) = v73.Invoke v70 |> unbox<unit -> JSX.Element[]>
            US8_1(v74)
    let v79 : (unit -> (JSX.Element [])) =
        match v76 with
        | US8_0 -> (* None *)
            closure185(v0)
        | US8_1(v78) -> (* Some *)
            v78
    let v80 : US8 = US8_1(v79)
    let v81 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v80; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68} : Mut3
    let v82 : (unit -> (JSX.Element [])) = closure185(v0)
    emitJsExpr (v81, v82) "$0.children = $1"
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : (Mut3 -> JSX.Element) = closure73()
    let v87 : JSX.Element = v85.Invoke (v86, v81) |> unbox<JSX.Element>
    v87
and closure184 () (v0 : Mut12) : JSX.Element =
    method41(v0)
and closure183 () () : (JSX.Element []) =
    let v0 : US4 = US4_1
    let v1 : Mut12 = {l0 = v0} : Mut12
    let v2 : string = "createComponent"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (Mut12 -> JSX.Element) = closure184()
    let v6 : JSX.Element = v4.Invoke (v5, v1) |> unbox<JSX.Element>
    [|v6|]
and closure182 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Rust -{'>'} Rust"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure183()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "db-gun-rs-rs"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v74, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure209 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_1
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut4 = {l0 = 0} : Mut4
    while method15(v9, v11) do
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
and closure208 () (v0 : Mut1) : (Mut1 -> unit) =
    closure209(v0)
and closure207 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure208()
    v0 v1
    ()
and closure206 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure207()
and closure213 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method40(v4, v6) do
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
    let v23 : Mut4 = {l0 = 0} : Mut4
    while method15(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure212 () (v0 : Mut1) : (Mut1 -> unit) =
    closure213(v0)
and closure211 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure212()
    v0 v1
    ()
and closure210 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure211()
and closure215 () () : (JSX.Element []) =
    let v0 : US4 = US4_0
    let v1 : Mut12 = {l0 = v0} : Mut12
    let v2 : string = "createComponent"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (Mut12 -> JSX.Element) = closure184()
    let v6 : JSX.Element = v4.Invoke (v5, v1) |> unbox<JSX.Element>
    [|v6|]
and closure214 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Rust -{'>'} JavaScript"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure215()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "db-gun-rs-js"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v74, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure219 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut4 = {l0 = 0} : Mut4
    while method15(v9, v11) do
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
and closure218 () (v0 : Mut1) : (Mut1 -> unit) =
    closure219(v0)
and closure217 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure218()
    v0 v1
    ()
and closure216 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure217()
and closure223 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method40(v4, v6) do
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
    let v23 : Mut4 = {l0 = 0} : Mut4
    while method15(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure222 () (v0 : Mut1) : (Mut1 -> unit) =
    closure223(v0)
and closure221 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure222()
    v0 v1
    ()
and closure220 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure221()
and closure224 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "JavaScript -{'>'} JavaScript"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure215()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "db-gun-js-js"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v74, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure228 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_1
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut4 = {l0 = 0} : Mut4
    while method15(v9, v11) do
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
and closure227 () (v0 : Mut1) : (Mut1 -> unit) =
    closure228(v0)
and closure226 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure227()
    v0 v1
    ()
and closure225 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure226()
and closure232 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method40(v4, v6) do
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
    let v23 : Mut4 = {l0 = 0} : Mut4
    while method15(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure231 () (v0 : Mut1) : (Mut1 -> unit) =
    closure232(v0)
and closure230 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure231()
    v0 v1
    ()
and closure229 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure230()
and closure233 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "JavaScript -{'>'} Rust"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure183()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "db-gun-js-rs"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v74, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure173 () () : (JSX.Element []) =
    let v0 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure174()
    let v1 : US14 = US14_1(v0)
    let v2 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure178()
    let v3 : US14 = US14_1(v2)
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure182()
    let v5 : US15 = US15_0
    let v6 : Mut5 = {l0 = v1; l1 = v3; l2 = v4; l3 = v5} : Mut5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut5 -> JSX.Element) = closure26()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    let v12 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure206()
    let v13 : US14 = US14_1(v12)
    let v14 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure210()
    let v15 : US14 = US14_1(v14)
    let v16 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure214()
    let v17 : US15 = US15_0
    let v18 : Mut5 = {l0 = v13; l1 = v15; l2 = v16; l3 = v17} : Mut5
    let v19 : JS.Function = import v7 v8
    let v20 : JSX.Element = v19.Invoke (v10, v18) |> unbox<JSX.Element>
    let v21 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure216()
    let v22 : US14 = US14_1(v21)
    let v23 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure220()
    let v24 : US14 = US14_1(v23)
    let v25 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure224()
    let v26 : US15 = US15_0
    let v27 : Mut5 = {l0 = v22; l1 = v24; l2 = v25; l3 = v26} : Mut5
    let v28 : JS.Function = import v7 v8
    let v29 : JSX.Element = v28.Invoke (v10, v27) |> unbox<JSX.Element>
    let v30 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure225()
    let v31 : US14 = US14_1(v30)
    let v32 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure229()
    let v33 : US14 = US14_1(v32)
    let v34 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure233()
    let v35 : US15 = US15_0
    let v36 : Mut5 = {l0 = v31; l1 = v33; l2 = v34; l3 = v35} : Mut5
    let v37 : JS.Function = import v7 v8
    let v38 : JSX.Element = v37.Invoke (v10, v36) |> unbox<JSX.Element>
    [|v11; v20; v29; v38|]
and method39 () : JSX.Element =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure173()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure173()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure73()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    v86
and closure172 () (v0 : Mut3) : JSX.Element =
    method39()
and closure170 () () : (JSX.Element []) =
    let struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) = method13()
    let v75 : US8 =
        match v11 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v69) -> (* Some *)
            let v70 : string = "children"
            let v71 : string = "solid-js"
            let v72 : JS.Function = import v70 v71
            let v73 : (unit -> (JSX.Element [])) = v72.Invoke v69 |> unbox<unit -> JSX.Element[]>
            US8_1(v73)
    let v78 : (unit -> (JSX.Element [])) =
        match v75 with
        | US8_0 -> (* None *)
            closure171()
        | US8_1(v77) -> (* Some *)
            v77
    let v79 : US8 = US8_1(v78)
    let v80 : Mut3 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v79; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67} : Mut3
    let v81 : (unit -> (JSX.Element [])) = closure171()
    emitJsExpr (v80, v81) "$0.children = $1"
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut3 -> JSX.Element) = closure172()
    let v86 : JSX.Element = v84.Invoke (v85, v80) |> unbox<JSX.Element>
    [|v86|]
and closure169 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Database"
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    let v70 : JSX.Element = Html.fragment [ v69 ]
    let v71 : (unit -> (JSX.Element [])) = closure170()
    let v72 : US8 = US8_1(v71)
    let v73 : string = "db"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v74, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v75, v61, v62, v63, v64, v65, v66, v67)
and closure237 () () : (JSX.Element []) =
    [||]
and closure241 (v0 : Mut1) (v1 : (struct (int32 * int32) [])) : unit =
    v0.l8 <- v1
    ()
and closure240 (v0 : Mut1) (v1 : Mut1) : ((struct (int32 * int32) []) -> unit) =
    closure241(v0)
and closure239 () (v0 : Mut1) : (Mut1 -> ((struct (int32 * int32) []) -> unit)) =
    closure240(v0)
and closure242 (v0 : Mut1) (v1 : obj) : int32 =
    let struct (v2 : (struct (int32 * obj) []), v3 : (struct (int32 * obj) []), v4 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v5 : int32 = v4.Length
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method40(v5, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 = v6.l1
        let struct (v10 : int32, v11 : int32) = v4.[int v8]
        let v12 : int32 = v9 + 1
        let v13 : int32 = v8 + 1
        v6.l0 <- v13
        v6.l1 <- v12
        ()
    let v14 : int32 = v6.l1
    v14
and closure243 (v0 : Mut1) () : bool =
    let struct (v1 : US5, v2 : US2) = v0.l9, v0.l10
    match v1 with
    | US5_0 -> (* Debug *)
        true
    | _ ->
        false
and closure244 () () : (obj []) =
    [||]
and closure245 (v0 : string, v1 : ((obj []) -> unit)) () : unit =
    let v2 : string = ">> use_fetch request()"
    let v3 : obj = v2
    let v4 : string = "content_address:"
    let v5 : obj = struct (v4, v0)
    let v6 : (obj []) = [|v3; v5|]
    v1 v6
    ()
and closure246 (v0 : string, v1 : ((obj []) -> unit)) () : unit =
    let v2 : string = ">> use_fetch clear()"
    let v3 : obj = v2
    let v4 : string = "content_address:"
    let v5 : obj = struct (v4, v0)
    let v6 : (obj []) = [|v3; v5|]
    v1 v6
    ()
and method47 (v0 : string) : struct ((unit -> unit) * (unit -> unit)) =
    let struct (v1 : Mut1, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v3 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v4 : int32 = v3.Length
    let v5 : Mut11 = {l0 = 0; l1 = 100000} : Mut11
    while method40(v4, v5) do
        let v7 : int32 = v5.l0
        let v8 : int32 = v5.l1
        let v9 : uint8 = v3.[int v7]
        let v10 : int32 = (v9 |> unbox)
        let v11 : int32 = v10 * 12
        let v12 : int32 = v8 + v11
        let v13 : int32 = v7 + 1
        v5.l0 <- v13
        v5.l1 <- v12
        ()
    let v14 : int32 = v5.l1
    let v15 : string = v14.ToString ()
    let v16 : string = $"#{v15}"
    let v17 : (unit -> bool) = closure243(v1)
    let v18 : (unit -> (obj [])) = closure244()
    let v19 : ((obj []) -> unit) = method9(v17, v18, v16)
    let v20 : string = "> use_fetch ()"
    let v21 : obj = v20
    let v22 : (obj []) = [|v21|]
    v19 v22
    let v23 : (unit -> unit) = closure245(v0, v19)
    let v24 : (unit -> unit) = closure246(v0, v19)
    struct (v23, v24)
and closure249 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure250 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure251 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure252 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure253 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure254 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure255 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure248 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure249()
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v84, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v86 : obj = createObj v85
    let v87 : (unit -> (JSX.Element [])) = closure249()
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v86) |> unbox<JSX.Element>
    let struct (v93 : US3, v94 : US3, v95 : US3, v96 : US6, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US7, v104 : US8, v105 : US3, v106 : US3, v107 : US7, v108 : US9, v109 : US3, v110 : US3, v111 : US3, v112 : US10, v113 : US7, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US11, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US12, v134 : US13, v135 : US12, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US11, v154 : US3, v155 : US3, v156 : US9, v157 : US9, v158 : US3, v159 : US2, v160 : US3) = method13()
    let v161 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure250()
    let v162 : (unit -> JS.Function) = closure251()
    let v163 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure55()
    let v164 : Mut8 = {l0 = v161; l1 = v162; l2 = v163} : Mut8
    let v165 : JS.Function = import v89 v90
    let v166 : (Mut8 -> JSX.Element) = closure57()
    let v167 : JSX.Element = v165.Invoke (v166, v164) |> unbox<JSX.Element>
    let v174 : US8 =
        match v104 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v169) -> (* Some *)
            let v170 : string = "children"
            let v171 : JS.Function = import v170 v90
            let v172 : (unit -> (JSX.Element [])) = v171.Invoke v169 |> unbox<unit -> JSX.Element[]>
            US8_1(v172)
    let v177 : (unit -> (JSX.Element [])) =
        match v174 with
        | US8_0 -> (* None *)
            closure252()
        | US8_1(v176) -> (* Some *)
            v176
    let v178 : US8 = US8_1(v177)
    let v179 : US11 = US11_1(v167)
    let v180 : US13 = US13_1(v1)
    let v181 : string = "10px"
    let v182 : US3 = US3_1(v181)
    let v183 : Mut3 = {l0 = v93; l1 = v94; l2 = v95; l3 = v96; l4 = v97; l5 = v98; l6 = v99; l7 = v100; l8 = v101; l9 = v102; l10 = v103; l11 = v178; l12 = v105; l13 = v106; l14 = v107; l15 = v108; l16 = v109; l17 = v110; l18 = v111; l19 = v112; l20 = v113; l21 = v114; l22 = v115; l23 = v116; l24 = v117; l25 = v118; l26 = v119; l27 = v120; l28 = v121; l29 = v122; l30 = v123; l31 = v179; l32 = v125; l33 = v126; l34 = v127; l35 = v128; l36 = v129; l37 = v130; l38 = v131; l39 = v132; l40 = v133; l41 = v180; l42 = v135; l43 = v136; l44 = v137; l45 = v138; l46 = v139; l47 = v140; l48 = v141; l49 = v142; l50 = v182; l51 = v144; l52 = v145; l53 = v146; l54 = v147; l55 = v148; l56 = v149; l57 = v150; l58 = v151; l59 = v152; l60 = v153; l61 = v154; l62 = v155; l63 = v156; l64 = v157; l65 = v158; l66 = v159; l67 = v160} : Mut3
    let v184 : (unit -> (JSX.Element [])) = closure252()
    emitJsExpr (v183, v184) "$0.children = $1"
    let v185 : JS.Function = import v89 v90
    let v186 : (Mut3 -> JSX.Element) = closure50()
    let v187 : JSX.Element = v185.Invoke (v186, v183) |> unbox<JSX.Element>
    let struct (v188 : US3, v189 : US3, v190 : US3, v191 : US6, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US7, v199 : US8, v200 : US3, v201 : US3, v202 : US7, v203 : US9, v204 : US3, v205 : US3, v206 : US3, v207 : US10, v208 : US7, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US11, v216 : US3, v217 : US3, v218 : US3, v219 : US11, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US12, v229 : US13, v230 : US12, v231 : US3, v232 : US3, v233 : US3, v234 : US3, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US3, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US3, v247 : US3, v248 : US11, v249 : US3, v250 : US3, v251 : US9, v252 : US9, v253 : US3, v254 : US2, v255 : US3) = method13()
    let v256 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure253()
    let v257 : (unit -> JS.Function) = closure254()
    let v258 : Mut8 = {l0 = v256; l1 = v257; l2 = v163} : Mut8
    let v259 : JS.Function = import v89 v90
    let v260 : JSX.Element = v259.Invoke (v166, v258) |> unbox<JSX.Element>
    let v267 : US8 =
        match v199 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v262) -> (* Some *)
            let v263 : string = "children"
            let v264 : JS.Function = import v263 v90
            let v265 : (unit -> (JSX.Element [])) = v264.Invoke v262 |> unbox<unit -> JSX.Element[]>
            US8_1(v265)
    let v270 : (unit -> (JSX.Element [])) =
        match v267 with
        | US8_0 -> (* None *)
            closure255()
        | US8_1(v269) -> (* Some *)
            v269
    let v271 : US8 = US8_1(v270)
    let v272 : US11 = US11_1(v260)
    let v273 : US13 = US13_1(v0)
    let v274 : US3 = US3_1(v181)
    let v275 : Mut3 = {l0 = v188; l1 = v189; l2 = v190; l3 = v191; l4 = v192; l5 = v193; l6 = v194; l7 = v195; l8 = v196; l9 = v197; l10 = v198; l11 = v271; l12 = v200; l13 = v201; l14 = v202; l15 = v203; l16 = v204; l17 = v205; l18 = v206; l19 = v207; l20 = v208; l21 = v209; l22 = v210; l23 = v211; l24 = v212; l25 = v213; l26 = v214; l27 = v215; l28 = v216; l29 = v217; l30 = v218; l31 = v272; l32 = v220; l33 = v221; l34 = v222; l35 = v223; l36 = v224; l37 = v225; l38 = v226; l39 = v227; l40 = v228; l41 = v273; l42 = v230; l43 = v231; l44 = v232; l45 = v233; l46 = v234; l47 = v235; l48 = v236; l49 = v237; l50 = v274; l51 = v239; l52 = v240; l53 = v241; l54 = v242; l55 = v243; l56 = v244; l57 = v245; l58 = v246; l59 = v247; l60 = v248; l61 = v249; l62 = v250; l63 = v251; l64 = v252; l65 = v253; l66 = v254; l67 = v255} : Mut3
    let v276 : (unit -> (JSX.Element [])) = closure255()
    emitJsExpr (v275, v276) "$0.children = $1"
    let v277 : JS.Function = import v89 v90
    let v278 : JSX.Element = v277.Invoke (v186, v275) |> unbox<JSX.Element>
    [|v92; v187; v278|]
and method48 (v0 : int32, v1 : Mut17) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method49 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method49(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method51 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method51(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method52 (v0 : (struct (int32 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method52(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method50 (v0 : UH1) : (struct (int32 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method51(v0, v1)
    let v3 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method52(v3, v0, v4)
    v3
and closure261 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure260 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure261(v0)
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v84, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v86 : obj = createObj v85
    let v87 : (unit -> (JSX.Element [])) = closure261(v0)
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v86) |> unbox<JSX.Element>
    [|v92|]
and closure259 (v0 : (unit -> struct (int32 * int32))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : int32, v70 : int32) = v0 ()
    let v71 : string = v69.ToString ()
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure260(v0)
    let v75 : US8 = US8_1(v74)
    let v76 : string = "3px"
    let v77 : US3 = US3_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v77, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v78, v62, v63, v64, v65, v66, v67, v68)
and closure258 () (v0 : (unit -> struct (int32 * int32))) : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure259(v0)
    let v4 : US15 = US15_2
    let v5 : Mut5 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut5
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut5 -> JSX.Element) = closure26()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    [|v10|]
and closure257 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v3.Length
    let v5 : UH1 = UH1_1
    let v6 : Mut17 = {l0 = 0; l1 = v5} : Mut17
    while method48(v4, v6) do
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
    let v19 : UH1 = method49(v17, v18)
    let v20 : (struct (int32 * int32) []) = method50(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * int32)) -> (JSX.Element [])) = closure258()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US3, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US7, v37 : US8, v38 : US3, v39 : US3, v40 : US7, v41 : US9, v42 : US3, v43 : US3, v44 : US3, v45 : US10, v46 : US7, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US11, v54 : US3, v55 : US3, v56 : US3, v57 : US11, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US12, v67 : US13, v68 : US12, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US11, v87 : US3, v88 : US3, v89 : US9, v90 : US9, v91 : US3, v92 : US2, v93 : US3) = method13()
    let v94 : (obj []) = v20 |> unbox<obj[]>
    let v101 : US8 =
        match v37 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v96) -> (* Some *)
            let v97 : string = "children"
            let v98 : JS.Function = import v97 v22
            let v99 : (unit -> (JSX.Element [])) = v98.Invoke v96 |> unbox<unit -> JSX.Element[]>
            US8_1(v99)
    let v103 : (unit -> (JSX.Element [])) =
        match v101 with
        | US8_0 -> (* None *)
            v25
        | US8_1(v102) -> (* Some *)
            v102
    let v104 : US8 = US8_1(v103)
    let v105 : US10 = US10_1(v94)
    let v106 : ((string * obj) []) = method17(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v104, v38, v39, v40, v41, v42, v43, v44, v105, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93)
    let v107 : obj = createObj v106
    emitJsExpr (v107, v25) "$0.children = $1"
    let v108 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v109 : string = "createComponent"
    let v110 : JS.Function = import v109 v22
    let v111 : JSX.Element = v110.Invoke (v108, v107) |> unbox<JSX.Element>
    [|v111|]
and closure256 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) = method13()
    let v76 : US8 =
        match v12 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v70) -> (* Some *)
            let v71 : string = "children"
            let v72 : string = "solid-js"
            let v73 : JS.Function = import v71 v72
            let v74 : (unit -> (JSX.Element [])) = v73.Invoke v70 |> unbox<unit -> JSX.Element[]>
            US8_1(v74)
    let v79 : (unit -> (JSX.Element [])) =
        match v76 with
        | US8_0 -> (* None *)
            closure257(v0)
        | US8_1(v78) -> (* Some *)
            v78
    let v80 : US8 = US8_1(v79)
    let v81 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v80; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68} : Mut3
    let v82 : (unit -> (JSX.Element [])) = closure257(v0)
    emitJsExpr (v81, v82) "$0.children = $1"
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : (Mut3 -> JSX.Element) = closure73()
    let v87 : JSX.Element = v85.Invoke (v86, v81) |> unbox<JSX.Element>
    [|v87|]
and closure247 (v0 : Mut1, v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let struct (v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US7, v85 : US8, v86 : US3, v87 : US3, v88 : US7, v89 : US9, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US7, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US12, v115 : US13, v116 : US12, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US11, v135 : US3, v136 : US3, v137 : US9, v138 : US9, v139 : US3, v140 : US2, v141 : US3) = method13()
    let v142 : string = "row"
    let v143 : string = "column"
    let v144 : string = method23(v143, v142)
    let v145 : string = "0"
    let v146 : string = "8px"
    let v147 : string = method23(v146, v145)
    let v155 : US8 =
        match v85 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v149) -> (* Some *)
            let v150 : string = "children"
            let v151 : string = "solid-js"
            let v152 : JS.Function = import v150 v151
            let v153 : (unit -> (JSX.Element [])) = v152.Invoke v149 |> unbox<unit -> JSX.Element[]>
            US8_1(v153)
    let v158 : (unit -> (JSX.Element [])) =
        match v155 with
        | US8_0 -> (* None *)
            closure248(v1, v2)
        | US8_1(v157) -> (* Some *)
            v157
    let v159 : string = "start"
    let v160 : US3 = US3_1(v159)
    let v161 : US8 = US8_1(v158)
    let v162 : US3 = US3_1(v144)
    let v163 : US3 = US3_1(v147)
    let v164 : string = "3px"
    let v165 : US3 = US3_1(v164)
    let v166 : string = "7px"
    let v167 : US3 = US3_1(v166)
    let v168 : ((string * obj) []) = method17(v160, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v161, v86, v87, v88, v89, v90, v162, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v163, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v165, v122, v123, v124, v125, v126, v127, v128, v129, v167, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v169 : obj = createObj v168
    let v170 : (unit -> (JSX.Element [])) = closure248(v1, v2)
    emitJsExpr (v169, v170) "$0.children = $1"
    let v171 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v172 : string = "createComponent"
    let v173 : string = "solid-js"
    let v174 : JS.Function = import v172 v173
    let v175 : JSX.Element = v174.Invoke (v171, v169) |> unbox<JSX.Element>
    let v176 : (unit -> (JSX.Element [])) = closure256(v0)
    let v177 : US8 = US8_1(v176)
    let v178 : string = "counter"
    let v179 : US3 = US3_1(v178)
    let v180 : US11 = US11_1(v175)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v177, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v179, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v180, v64, v65, v66, v67, v68, v69, v70)
and method46 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "profile/tmp/counter"
    let struct (v3 : (struct (int32 * obj) []), v4 : (struct (int32 * obj) []), v5 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v6 : (Mut1 -> (Mut1 -> ((struct (int32 * int32) []) -> unit))) = closure239()
    let v7 : (obj -> int32) = closure242(v0)
    let struct (v8 : (unit -> unit), v9 : (unit -> unit)) = method47(v2)
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure247(v0, v9, v8)
    let v13 : US15 = US15_2
    let v14 : Mut5 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13} : Mut5
    let v15 : string = "createComponent"
    let v16 : string = "solid-js"
    let v17 : JS.Function = import v15 v16
    let v18 : (Mut5 -> JSX.Element) = closure26()
    let v19 : JSX.Element = v17.Invoke (v18, v14) |> unbox<JSX.Element>
    v19
and closure238 () (v0 : Mut3) : JSX.Element =
    method46()
and closure262 () () : (JSX.Element []) =
    [||]
and closure266 (v0 : Mut1) (v1 : (struct (int32 * obj) [])) : unit =
    v0.l7 <- v1
    ()
and closure265 (v0 : Mut1) (v1 : Mut1) : ((struct (int32 * obj) []) -> unit) =
    closure266(v0)
and closure264 () (v0 : Mut1) : (Mut1 -> ((struct (int32 * obj) []) -> unit)) =
    closure265(v0)
and closure267 () (v0 : obj) : obj =
    let v1 : obj = "status"
    v1
and closure270 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure271 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure272 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure273 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure274 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure269 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure270()
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v84, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v86 : obj = createObj v85
    let v87 : (unit -> (JSX.Element [])) = closure270()
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v86) |> unbox<JSX.Element>
    let struct (v93 : US3, v94 : US3, v95 : US3, v96 : US6, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US7, v104 : US8, v105 : US3, v106 : US3, v107 : US7, v108 : US9, v109 : US3, v110 : US3, v111 : US3, v112 : US10, v113 : US7, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US11, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US12, v134 : US13, v135 : US12, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US11, v154 : US3, v155 : US3, v156 : US9, v157 : US9, v158 : US3, v159 : US2, v160 : US3) = method13()
    let v161 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure271()
    let v162 : (unit -> JS.Function) = closure251()
    let v163 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure55()
    let v164 : Mut8 = {l0 = v161; l1 = v162; l2 = v163} : Mut8
    let v165 : JS.Function = import v89 v90
    let v166 : (Mut8 -> JSX.Element) = closure57()
    let v167 : JSX.Element = v165.Invoke (v166, v164) |> unbox<JSX.Element>
    let v174 : US8 =
        match v104 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v169) -> (* Some *)
            let v170 : string = "children"
            let v171 : JS.Function = import v170 v90
            let v172 : (unit -> (JSX.Element [])) = v171.Invoke v169 |> unbox<unit -> JSX.Element[]>
            US8_1(v172)
    let v177 : (unit -> (JSX.Element [])) =
        match v174 with
        | US8_0 -> (* None *)
            closure272()
        | US8_1(v176) -> (* Some *)
            v176
    let v178 : US8 = US8_1(v177)
    let v179 : US11 = US11_1(v167)
    let v180 : US13 = US13_1(v1)
    let v181 : string = "10px"
    let v182 : US3 = US3_1(v181)
    let v183 : Mut3 = {l0 = v93; l1 = v94; l2 = v95; l3 = v96; l4 = v97; l5 = v98; l6 = v99; l7 = v100; l8 = v101; l9 = v102; l10 = v103; l11 = v178; l12 = v105; l13 = v106; l14 = v107; l15 = v108; l16 = v109; l17 = v110; l18 = v111; l19 = v112; l20 = v113; l21 = v114; l22 = v115; l23 = v116; l24 = v117; l25 = v118; l26 = v119; l27 = v120; l28 = v121; l29 = v122; l30 = v123; l31 = v179; l32 = v125; l33 = v126; l34 = v127; l35 = v128; l36 = v129; l37 = v130; l38 = v131; l39 = v132; l40 = v133; l41 = v180; l42 = v135; l43 = v136; l44 = v137; l45 = v138; l46 = v139; l47 = v140; l48 = v141; l49 = v142; l50 = v182; l51 = v144; l52 = v145; l53 = v146; l54 = v147; l55 = v148; l56 = v149; l57 = v150; l58 = v151; l59 = v152; l60 = v153; l61 = v154; l62 = v155; l63 = v156; l64 = v157; l65 = v158; l66 = v159; l67 = v160} : Mut3
    let v184 : (unit -> (JSX.Element [])) = closure272()
    emitJsExpr (v183, v184) "$0.children = $1"
    let v185 : JS.Function = import v89 v90
    let v186 : (Mut3 -> JSX.Element) = closure50()
    let v187 : JSX.Element = v185.Invoke (v186, v183) |> unbox<JSX.Element>
    let struct (v188 : US3, v189 : US3, v190 : US3, v191 : US6, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US7, v199 : US8, v200 : US3, v201 : US3, v202 : US7, v203 : US9, v204 : US3, v205 : US3, v206 : US3, v207 : US10, v208 : US7, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US11, v216 : US3, v217 : US3, v218 : US3, v219 : US11, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US12, v229 : US13, v230 : US12, v231 : US3, v232 : US3, v233 : US3, v234 : US3, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US3, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US3, v247 : US3, v248 : US11, v249 : US3, v250 : US3, v251 : US9, v252 : US9, v253 : US3, v254 : US2, v255 : US3) = method13()
    let v256 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure273()
    let v257 : (unit -> JS.Function) = closure254()
    let v258 : Mut8 = {l0 = v256; l1 = v257; l2 = v163} : Mut8
    let v259 : JS.Function = import v89 v90
    let v260 : JSX.Element = v259.Invoke (v166, v258) |> unbox<JSX.Element>
    let v267 : US8 =
        match v199 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v262) -> (* Some *)
            let v263 : string = "children"
            let v264 : JS.Function = import v263 v90
            let v265 : (unit -> (JSX.Element [])) = v264.Invoke v262 |> unbox<unit -> JSX.Element[]>
            US8_1(v265)
    let v270 : (unit -> (JSX.Element [])) =
        match v267 with
        | US8_0 -> (* None *)
            closure274()
        | US8_1(v269) -> (* Some *)
            v269
    let v271 : US8 = US8_1(v270)
    let v272 : US11 = US11_1(v260)
    let v273 : US13 = US13_1(v0)
    let v274 : US3 = US3_1(v181)
    let v275 : Mut3 = {l0 = v188; l1 = v189; l2 = v190; l3 = v191; l4 = v192; l5 = v193; l6 = v194; l7 = v195; l8 = v196; l9 = v197; l10 = v198; l11 = v271; l12 = v200; l13 = v201; l14 = v202; l15 = v203; l16 = v204; l17 = v205; l18 = v206; l19 = v207; l20 = v208; l21 = v209; l22 = v210; l23 = v211; l24 = v212; l25 = v213; l26 = v214; l27 = v215; l28 = v216; l29 = v217; l30 = v218; l31 = v272; l32 = v220; l33 = v221; l34 = v222; l35 = v223; l36 = v224; l37 = v225; l38 = v226; l39 = v227; l40 = v228; l41 = v273; l42 = v230; l43 = v231; l44 = v232; l45 = v233; l46 = v234; l47 = v235; l48 = v236; l49 = v237; l50 = v274; l51 = v239; l52 = v240; l53 = v241; l54 = v242; l55 = v243; l56 = v244; l57 = v245; l58 = v246; l59 = v247; l60 = v248; l61 = v249; l62 = v250; l63 = v251; l64 = v252; l65 = v253; l66 = v254; l67 = v255} : Mut3
    let v276 : (unit -> (JSX.Element [])) = closure274()
    emitJsExpr (v275, v276) "$0.children = $1"
    let v277 : JS.Function = import v89 v90
    let v278 : JSX.Element = v277.Invoke (v186, v275) |> unbox<JSX.Element>
    [|v92; v187; v278|]
and method54 (v0 : int32, v1 : Mut18) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method55 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method55(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method57 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method57(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method58 (v0 : (struct (int32 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method58(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method56 (v0 : UH2) : (struct (int32 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method57(v0, v1)
    let v3 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method58(v3, v0, v4)
    v3
and closure280 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure279 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure280(v0)
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v84, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v86 : obj = createObj v85
    let v87 : (unit -> (JSX.Element [])) = closure280(v0)
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v86) |> unbox<JSX.Element>
    [|v92|]
and closure278 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : int32, v70 : obj) = v0 ()
    let v71 : string = v69.ToString ()
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure279(v0)
    let v75 : US8 = US8_1(v74)
    let v76 : string = "3px"
    let v77 : US3 = US3_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v77, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v78, v62, v63, v64, v65, v66, v67, v68)
and closure277 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure278(v0)
    let v4 : US15 = US15_2
    let v5 : Mut5 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut5
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut5 -> JSX.Element) = closure26()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    [|v10|]
and closure276 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v2.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut18 = {l0 = 0; l1 = v5} : Mut18
    while method54(v4, v6) do
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
    let v19 : UH2 = method55(v17, v18)
    let v20 : (struct (int32 * obj) []) = method56(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure277()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US3, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US7, v37 : US8, v38 : US3, v39 : US3, v40 : US7, v41 : US9, v42 : US3, v43 : US3, v44 : US3, v45 : US10, v46 : US7, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US11, v54 : US3, v55 : US3, v56 : US3, v57 : US11, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US12, v67 : US13, v68 : US12, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US11, v87 : US3, v88 : US3, v89 : US9, v90 : US9, v91 : US3, v92 : US2, v93 : US3) = method13()
    let v94 : (obj []) = v20 |> unbox<obj[]>
    let v101 : US8 =
        match v37 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v96) -> (* Some *)
            let v97 : string = "children"
            let v98 : JS.Function = import v97 v22
            let v99 : (unit -> (JSX.Element [])) = v98.Invoke v96 |> unbox<unit -> JSX.Element[]>
            US8_1(v99)
    let v103 : (unit -> (JSX.Element [])) =
        match v101 with
        | US8_0 -> (* None *)
            v25
        | US8_1(v102) -> (* Some *)
            v102
    let v104 : US8 = US8_1(v103)
    let v105 : US10 = US10_1(v94)
    let v106 : ((string * obj) []) = method17(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v104, v38, v39, v40, v41, v42, v43, v44, v105, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93)
    let v107 : obj = createObj v106
    emitJsExpr (v107, v25) "$0.children = $1"
    let v108 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v109 : string = "createComponent"
    let v110 : JS.Function = import v109 v22
    let v111 : JSX.Element = v110.Invoke (v108, v107) |> unbox<JSX.Element>
    [|v111|]
and closure275 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) = method13()
    let v76 : US8 =
        match v12 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v70) -> (* Some *)
            let v71 : string = "children"
            let v72 : string = "solid-js"
            let v73 : JS.Function = import v71 v72
            let v74 : (unit -> (JSX.Element [])) = v73.Invoke v70 |> unbox<unit -> JSX.Element[]>
            US8_1(v74)
    let v79 : (unit -> (JSX.Element [])) =
        match v76 with
        | US8_0 -> (* None *)
            closure276(v0)
        | US8_1(v78) -> (* Some *)
            v78
    let v80 : US8 = US8_1(v79)
    let v81 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v80; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68} : Mut3
    let v82 : (unit -> (JSX.Element [])) = closure276(v0)
    emitJsExpr (v81, v82) "$0.children = $1"
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : (Mut3 -> JSX.Element) = closure73()
    let v87 : JSX.Element = v85.Invoke (v86, v81) |> unbox<JSX.Element>
    [|v87|]
and closure268 (v0 : Mut1, v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let struct (v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US7, v85 : US8, v86 : US3, v87 : US3, v88 : US7, v89 : US9, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US7, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US12, v115 : US13, v116 : US12, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US11, v135 : US3, v136 : US3, v137 : US9, v138 : US9, v139 : US3, v140 : US2, v141 : US3) = method13()
    let v142 : string = "row"
    let v143 : string = "column"
    let v144 : string = method23(v143, v142)
    let v145 : string = "0"
    let v146 : string = "8px"
    let v147 : string = method23(v146, v145)
    let v155 : US8 =
        match v85 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v149) -> (* Some *)
            let v150 : string = "children"
            let v151 : string = "solid-js"
            let v152 : JS.Function = import v150 v151
            let v153 : (unit -> (JSX.Element [])) = v152.Invoke v149 |> unbox<unit -> JSX.Element[]>
            US8_1(v153)
    let v158 : (unit -> (JSX.Element [])) =
        match v155 with
        | US8_0 -> (* None *)
            closure269(v1, v2)
        | US8_1(v157) -> (* Some *)
            v157
    let v159 : string = "start"
    let v160 : US3 = US3_1(v159)
    let v161 : US8 = US8_1(v158)
    let v162 : US3 = US3_1(v144)
    let v163 : US3 = US3_1(v147)
    let v164 : string = "3px"
    let v165 : US3 = US3_1(v164)
    let v166 : string = "7px"
    let v167 : US3 = US3_1(v166)
    let v168 : ((string * obj) []) = method17(v160, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v161, v86, v87, v88, v89, v90, v162, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v163, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v165, v122, v123, v124, v125, v126, v127, v128, v129, v167, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v169 : obj = createObj v168
    let v170 : (unit -> (JSX.Element [])) = closure269(v1, v2)
    emitJsExpr (v169, v170) "$0.children = $1"
    let v171 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v172 : string = "createComponent"
    let v173 : string = "solid-js"
    let v174 : JS.Function = import v172 v173
    let v175 : JSX.Element = v174.Invoke (v171, v169) |> unbox<JSX.Element>
    let v176 : (unit -> (JSX.Element [])) = closure275(v0)
    let v177 : US8 = US8_1(v176)
    let v178 : string = "status"
    let v179 : US3 = US3_1(v178)
    let v180 : US11 = US11_1(v175)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v177, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v179, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v180, v64, v65, v66, v67, v68, v69, v70)
and method53 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "profile/tmp/chain_status"
    let struct (v3 : (struct (int32 * obj) []), v4 : (struct (int32 * obj) []), v5 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v6 : (Mut1 -> (Mut1 -> ((struct (int32 * obj) []) -> unit))) = closure264()
    let v7 : (obj -> obj) = closure267()
    let struct (v8 : (unit -> unit), v9 : (unit -> unit)) = method47(v2)
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure268(v0, v9, v8)
    let v13 : US15 = US15_2
    let v14 : Mut5 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13} : Mut5
    let v15 : string = "createComponent"
    let v16 : string = "solid-js"
    let v17 : JS.Function = import v15 v16
    let v18 : (Mut5 -> JSX.Element) = closure26()
    let v19 : JSX.Element = v17.Invoke (v18, v14) |> unbox<JSX.Element>
    v19
and closure263 () (v0 : Mut3) : JSX.Element =
    method53()
and closure281 () () : (JSX.Element []) =
    [||]
and closure285 (v0 : Mut1) (v1 : (struct (int32 * obj) [])) : unit =
    v0.l6 <- v1
    ()
and closure284 (v0 : Mut1) (v1 : Mut1) : ((struct (int32 * obj) []) -> unit) =
    closure285(v0)
and closure283 () (v0 : Mut1) : (Mut1 -> ((struct (int32 * obj) []) -> unit)) =
    closure284(v0)
and closure286 () (v0 : obj) : obj =
    let v1 : obj = ()
    v1
and closure289 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure290 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure291 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure292 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure293 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure288 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure289()
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v84, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v86 : obj = createObj v85
    let v87 : (unit -> (JSX.Element [])) = closure289()
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v86) |> unbox<JSX.Element>
    let struct (v93 : US3, v94 : US3, v95 : US3, v96 : US6, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US7, v104 : US8, v105 : US3, v106 : US3, v107 : US7, v108 : US9, v109 : US3, v110 : US3, v111 : US3, v112 : US10, v113 : US7, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US11, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US12, v134 : US13, v135 : US12, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US11, v154 : US3, v155 : US3, v156 : US9, v157 : US9, v158 : US3, v159 : US2, v160 : US3) = method13()
    let v161 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure290()
    let v162 : (unit -> JS.Function) = closure251()
    let v163 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure55()
    let v164 : Mut8 = {l0 = v161; l1 = v162; l2 = v163} : Mut8
    let v165 : JS.Function = import v89 v90
    let v166 : (Mut8 -> JSX.Element) = closure57()
    let v167 : JSX.Element = v165.Invoke (v166, v164) |> unbox<JSX.Element>
    let v174 : US8 =
        match v104 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v169) -> (* Some *)
            let v170 : string = "children"
            let v171 : JS.Function = import v170 v90
            let v172 : (unit -> (JSX.Element [])) = v171.Invoke v169 |> unbox<unit -> JSX.Element[]>
            US8_1(v172)
    let v177 : (unit -> (JSX.Element [])) =
        match v174 with
        | US8_0 -> (* None *)
            closure291()
        | US8_1(v176) -> (* Some *)
            v176
    let v178 : US8 = US8_1(v177)
    let v179 : US11 = US11_1(v167)
    let v180 : US13 = US13_1(v1)
    let v181 : string = "10px"
    let v182 : US3 = US3_1(v181)
    let v183 : Mut3 = {l0 = v93; l1 = v94; l2 = v95; l3 = v96; l4 = v97; l5 = v98; l6 = v99; l7 = v100; l8 = v101; l9 = v102; l10 = v103; l11 = v178; l12 = v105; l13 = v106; l14 = v107; l15 = v108; l16 = v109; l17 = v110; l18 = v111; l19 = v112; l20 = v113; l21 = v114; l22 = v115; l23 = v116; l24 = v117; l25 = v118; l26 = v119; l27 = v120; l28 = v121; l29 = v122; l30 = v123; l31 = v179; l32 = v125; l33 = v126; l34 = v127; l35 = v128; l36 = v129; l37 = v130; l38 = v131; l39 = v132; l40 = v133; l41 = v180; l42 = v135; l43 = v136; l44 = v137; l45 = v138; l46 = v139; l47 = v140; l48 = v141; l49 = v142; l50 = v182; l51 = v144; l52 = v145; l53 = v146; l54 = v147; l55 = v148; l56 = v149; l57 = v150; l58 = v151; l59 = v152; l60 = v153; l61 = v154; l62 = v155; l63 = v156; l64 = v157; l65 = v158; l66 = v159; l67 = v160} : Mut3
    let v184 : (unit -> (JSX.Element [])) = closure291()
    emitJsExpr (v183, v184) "$0.children = $1"
    let v185 : JS.Function = import v89 v90
    let v186 : (Mut3 -> JSX.Element) = closure50()
    let v187 : JSX.Element = v185.Invoke (v186, v183) |> unbox<JSX.Element>
    let struct (v188 : US3, v189 : US3, v190 : US3, v191 : US6, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US7, v199 : US8, v200 : US3, v201 : US3, v202 : US7, v203 : US9, v204 : US3, v205 : US3, v206 : US3, v207 : US10, v208 : US7, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US11, v216 : US3, v217 : US3, v218 : US3, v219 : US11, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US12, v229 : US13, v230 : US12, v231 : US3, v232 : US3, v233 : US3, v234 : US3, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US3, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US3, v247 : US3, v248 : US11, v249 : US3, v250 : US3, v251 : US9, v252 : US9, v253 : US3, v254 : US2, v255 : US3) = method13()
    let v256 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure292()
    let v257 : (unit -> JS.Function) = closure254()
    let v258 : Mut8 = {l0 = v256; l1 = v257; l2 = v163} : Mut8
    let v259 : JS.Function = import v89 v90
    let v260 : JSX.Element = v259.Invoke (v166, v258) |> unbox<JSX.Element>
    let v267 : US8 =
        match v199 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v262) -> (* Some *)
            let v263 : string = "children"
            let v264 : JS.Function = import v263 v90
            let v265 : (unit -> (JSX.Element [])) = v264.Invoke v262 |> unbox<unit -> JSX.Element[]>
            US8_1(v265)
    let v270 : (unit -> (JSX.Element [])) =
        match v267 with
        | US8_0 -> (* None *)
            closure293()
        | US8_1(v269) -> (* Some *)
            v269
    let v271 : US8 = US8_1(v270)
    let v272 : US11 = US11_1(v260)
    let v273 : US13 = US13_1(v0)
    let v274 : US3 = US3_1(v181)
    let v275 : Mut3 = {l0 = v188; l1 = v189; l2 = v190; l3 = v191; l4 = v192; l5 = v193; l6 = v194; l7 = v195; l8 = v196; l9 = v197; l10 = v198; l11 = v271; l12 = v200; l13 = v201; l14 = v202; l15 = v203; l16 = v204; l17 = v205; l18 = v206; l19 = v207; l20 = v208; l21 = v209; l22 = v210; l23 = v211; l24 = v212; l25 = v213; l26 = v214; l27 = v215; l28 = v216; l29 = v217; l30 = v218; l31 = v272; l32 = v220; l33 = v221; l34 = v222; l35 = v223; l36 = v224; l37 = v225; l38 = v226; l39 = v227; l40 = v228; l41 = v273; l42 = v230; l43 = v231; l44 = v232; l45 = v233; l46 = v234; l47 = v235; l48 = v236; l49 = v237; l50 = v274; l51 = v239; l52 = v240; l53 = v241; l54 = v242; l55 = v243; l56 = v244; l57 = v245; l58 = v246; l59 = v247; l60 = v248; l61 = v249; l62 = v250; l63 = v251; l64 = v252; l65 = v253; l66 = v254; l67 = v255} : Mut3
    let v276 : (unit -> (JSX.Element [])) = closure293()
    emitJsExpr (v275, v276) "$0.children = $1"
    let v277 : JS.Function = import v89 v90
    let v278 : JSX.Element = v277.Invoke (v186, v275) |> unbox<JSX.Element>
    [|v92; v187; v278|]
and closure299 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure298 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure299(v0)
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : ((string * obj) []) = method17(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v84, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v86 : obj = createObj v85
    let v87 : (unit -> (JSX.Element [])) = closure299(v0)
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v86) |> unbox<JSX.Element>
    [|v92|]
and closure297 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : int32, v70 : obj) = v0 ()
    let v71 : string = v69.ToString ()
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure298(v0)
    let v75 : US8 = US8_1(v74)
    let v76 : string = "3px"
    let v77 : US3 = US3_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v77, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v78, v62, v63, v64, v65, v66, v67, v68)
and closure296 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure297(v0)
    let v4 : US15 = US15_2
    let v5 : Mut5 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut5
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut5 -> JSX.Element) = closure26()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    [|v10|]
and closure295 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v1.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut18 = {l0 = 0; l1 = v5} : Mut18
    while method54(v4, v6) do
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
    let v19 : UH2 = method55(v17, v18)
    let v20 : (struct (int32 * obj) []) = method56(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure296()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US3, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US7, v37 : US8, v38 : US3, v39 : US3, v40 : US7, v41 : US9, v42 : US3, v43 : US3, v44 : US3, v45 : US10, v46 : US7, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US11, v54 : US3, v55 : US3, v56 : US3, v57 : US11, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US12, v67 : US13, v68 : US12, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US11, v87 : US3, v88 : US3, v89 : US9, v90 : US9, v91 : US3, v92 : US2, v93 : US3) = method13()
    let v94 : (obj []) = v20 |> unbox<obj[]>
    let v101 : US8 =
        match v37 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v96) -> (* Some *)
            let v97 : string = "children"
            let v98 : JS.Function = import v97 v22
            let v99 : (unit -> (JSX.Element [])) = v98.Invoke v96 |> unbox<unit -> JSX.Element[]>
            US8_1(v99)
    let v103 : (unit -> (JSX.Element [])) =
        match v101 with
        | US8_0 -> (* None *)
            v25
        | US8_1(v102) -> (* Some *)
            v102
    let v104 : US8 = US8_1(v103)
    let v105 : US10 = US10_1(v94)
    let v106 : ((string * obj) []) = method17(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v104, v38, v39, v40, v41, v42, v43, v44, v105, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93)
    let v107 : obj = createObj v106
    emitJsExpr (v107, v25) "$0.children = $1"
    let v108 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v109 : string = "createComponent"
    let v110 : JS.Function = import v109 v22
    let v111 : JSX.Element = v110.Invoke (v108, v107) |> unbox<JSX.Element>
    [|v111|]
and closure294 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) = method13()
    let v76 : US8 =
        match v12 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v70) -> (* Some *)
            let v71 : string = "children"
            let v72 : string = "solid-js"
            let v73 : JS.Function = import v71 v72
            let v74 : (unit -> (JSX.Element [])) = v73.Invoke v70 |> unbox<unit -> JSX.Element[]>
            US8_1(v74)
    let v79 : (unit -> (JSX.Element [])) =
        match v76 with
        | US8_0 -> (* None *)
            closure295(v0)
        | US8_1(v78) -> (* Some *)
            v78
    let v80 : US8 = US8_1(v79)
    let v81 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v80; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68} : Mut3
    let v82 : (unit -> (JSX.Element [])) = closure295(v0)
    emitJsExpr (v81, v82) "$0.children = $1"
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : (Mut3 -> JSX.Element) = closure73()
    let v87 : JSX.Element = v85.Invoke (v86, v81) |> unbox<JSX.Element>
    [|v87|]
and closure287 (v0 : Mut1, v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let struct (v74 : US3, v75 : US3, v76 : US3, v77 : US6, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US7, v85 : US8, v86 : US3, v87 : US3, v88 : US7, v89 : US9, v90 : US3, v91 : US3, v92 : US3, v93 : US10, v94 : US7, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US12, v115 : US13, v116 : US12, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US11, v135 : US3, v136 : US3, v137 : US9, v138 : US9, v139 : US3, v140 : US2, v141 : US3) = method13()
    let v142 : string = "row"
    let v143 : string = "column"
    let v144 : string = method23(v143, v142)
    let v145 : string = "0"
    let v146 : string = "8px"
    let v147 : string = method23(v146, v145)
    let v155 : US8 =
        match v85 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v149) -> (* Some *)
            let v150 : string = "children"
            let v151 : string = "solid-js"
            let v152 : JS.Function = import v150 v151
            let v153 : (unit -> (JSX.Element [])) = v152.Invoke v149 |> unbox<unit -> JSX.Element[]>
            US8_1(v153)
    let v158 : (unit -> (JSX.Element [])) =
        match v155 with
        | US8_0 -> (* None *)
            closure288(v1, v2)
        | US8_1(v157) -> (* Some *)
            v157
    let v159 : string = "start"
    let v160 : US3 = US3_1(v159)
    let v161 : US8 = US8_1(v158)
    let v162 : US3 = US3_1(v144)
    let v163 : US3 = US3_1(v147)
    let v164 : string = "3px"
    let v165 : US3 = US3_1(v164)
    let v166 : string = "7px"
    let v167 : US3 = US3_1(v166)
    let v168 : ((string * obj) []) = method17(v160, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v161, v86, v87, v88, v89, v90, v162, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v163, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v165, v122, v123, v124, v125, v126, v127, v128, v129, v167, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v169 : obj = createObj v168
    let v170 : (unit -> (JSX.Element [])) = closure288(v1, v2)
    emitJsExpr (v169, v170) "$0.children = $1"
    let v171 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v172 : string = "createComponent"
    let v173 : string = "solid-js"
    let v174 : JS.Function = import v172 v173
    let v175 : JSX.Element = v174.Invoke (v171, v169) |> unbox<JSX.Element>
    let v176 : (unit -> (JSX.Element [])) = closure294(v0)
    let v177 : US8 = US8_1(v176)
    let v178 : string = "deploy"
    let v179 : US3 = US3_1(v178)
    let v180 : US11 = US11_1(v175)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v177, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v179, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v180, v64, v65, v66, v67, v68, v69, v70)
and method59 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "profile/tmp/chain_deploy"
    let struct (v3 : (struct (int32 * obj) []), v4 : (struct (int32 * obj) []), v5 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v6 : (Mut1 -> (Mut1 -> ((struct (int32 * obj) []) -> unit))) = closure283()
    let v7 : (obj -> obj) = closure286()
    let struct (v8 : (unit -> unit), v9 : (unit -> unit)) = method47(v2)
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure287(v0, v9, v8)
    let v13 : US15 = US15_2
    let v14 : Mut5 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13} : Mut5
    let v15 : string = "createComponent"
    let v16 : string = "solid-js"
    let v17 : JS.Function = import v15 v16
    let v18 : (Mut5 -> JSX.Element) = closure26()
    let v19 : JSX.Element = v17.Invoke (v18, v14) |> unbox<JSX.Element>
    v19
and closure282 () (v0 : Mut3) : JSX.Element =
    method59()
and closure236 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure237()
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : Mut3 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v84; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67; l63 = v68; l64 = v69; l65 = v70; l66 = v71; l67 = v72} : Mut3
    let v86 : (unit -> (JSX.Element [])) = closure237()
    emitJsExpr (v85, v86) "$0.children = $1"
    let v87 : string = "createComponent"
    let v88 : string = "solid-js"
    let v89 : JS.Function = import v87 v88
    let v90 : (Mut3 -> JSX.Element) = closure238()
    let v91 : JSX.Element = v89.Invoke (v90, v85) |> unbox<JSX.Element>
    let v93 : bool = v2 = ""
    let v94 : bool = v93 <> true
    let v180 : JSX.Element =
        if v94 then
            let struct (v95 : US3, v96 : US3, v97 : US3, v98 : US6, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US7, v106 : US8, v107 : US3, v108 : US3, v109 : US7, v110 : US9, v111 : US3, v112 : US3, v113 : US3, v114 : US10, v115 : US7, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US11, v123 : US3, v124 : US3, v125 : US3, v126 : US11, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US12, v136 : US13, v137 : US12, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US11, v156 : US3, v157 : US3, v158 : US9, v159 : US9, v160 : US3, v161 : US2, v162 : US3) = method13()
            let v169 : US8 =
                match v106 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v164) -> (* Some *)
                    let v165 : string = "children"
                    let v166 : JS.Function = import v165 v88
                    let v167 : (unit -> (JSX.Element [])) = v166.Invoke v164 |> unbox<unit -> JSX.Element[]>
                    US8_1(v167)
            let v172 : (unit -> (JSX.Element [])) =
                match v169 with
                | US8_0 -> (* None *)
                    closure262()
                | US8_1(v171) -> (* Some *)
                    v171
            let v173 : US8 = US8_1(v172)
            let v174 : Mut3 = {l0 = v95; l1 = v96; l2 = v97; l3 = v98; l4 = v99; l5 = v100; l6 = v101; l7 = v102; l8 = v103; l9 = v104; l10 = v105; l11 = v173; l12 = v107; l13 = v108; l14 = v109; l15 = v110; l16 = v111; l17 = v112; l18 = v113; l19 = v114; l20 = v115; l21 = v116; l22 = v117; l23 = v118; l24 = v119; l25 = v120; l26 = v121; l27 = v122; l28 = v123; l29 = v124; l30 = v125; l31 = v126; l32 = v127; l33 = v128; l34 = v129; l35 = v130; l36 = v131; l37 = v132; l38 = v133; l39 = v134; l40 = v135; l41 = v136; l42 = v137; l43 = v138; l44 = v139; l45 = v140; l46 = v141; l47 = v142; l48 = v143; l49 = v144; l50 = v145; l51 = v146; l52 = v147; l53 = v148; l54 = v149; l55 = v150; l56 = v151; l57 = v152; l58 = v153; l59 = v154; l60 = v155; l61 = v156; l62 = v157; l63 = v158; l64 = v159; l65 = v160; l66 = v161; l67 = v162} : Mut3
            let v175 : (unit -> (JSX.Element [])) = closure262()
            emitJsExpr (v174, v175) "$0.children = $1"
            let v176 : JS.Function = import v87 v88
            let v177 : (Mut3 -> JSX.Element) = closure263()
            let v178 : JSX.Element = v176.Invoke (v177, v174) |> unbox<JSX.Element>
            v178
        else
            let v179 : JSX.Element = null
            v179
    let v267 : JSX.Element =
        if v94 then
            let struct (v182 : US3, v183 : US3, v184 : US3, v185 : US6, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US7, v193 : US8, v194 : US3, v195 : US3, v196 : US7, v197 : US9, v198 : US3, v199 : US3, v200 : US3, v201 : US10, v202 : US7, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US11, v210 : US3, v211 : US3, v212 : US3, v213 : US11, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US12, v223 : US13, v224 : US12, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US3, v231 : US3, v232 : US3, v233 : US3, v234 : US3, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US3, v241 : US3, v242 : US11, v243 : US3, v244 : US3, v245 : US9, v246 : US9, v247 : US3, v248 : US2, v249 : US3) = method13()
            let v256 : US8 =
                match v193 with
                | US8_0 -> (* None *)
                    US8_0
                | US8_1(v251) -> (* Some *)
                    let v252 : string = "children"
                    let v253 : JS.Function = import v252 v88
                    let v254 : (unit -> (JSX.Element [])) = v253.Invoke v251 |> unbox<unit -> JSX.Element[]>
                    US8_1(v254)
            let v259 : (unit -> (JSX.Element [])) =
                match v256 with
                | US8_0 -> (* None *)
                    closure281()
                | US8_1(v258) -> (* Some *)
                    v258
            let v260 : US8 = US8_1(v259)
            let v261 : Mut3 = {l0 = v182; l1 = v183; l2 = v184; l3 = v185; l4 = v186; l5 = v187; l6 = v188; l7 = v189; l8 = v190; l9 = v191; l10 = v192; l11 = v260; l12 = v194; l13 = v195; l14 = v196; l15 = v197; l16 = v198; l17 = v199; l18 = v200; l19 = v201; l20 = v202; l21 = v203; l22 = v204; l23 = v205; l24 = v206; l25 = v207; l26 = v208; l27 = v209; l28 = v210; l29 = v211; l30 = v212; l31 = v213; l32 = v214; l33 = v215; l34 = v216; l35 = v217; l36 = v218; l37 = v219; l38 = v220; l39 = v221; l40 = v222; l41 = v223; l42 = v224; l43 = v225; l44 = v226; l45 = v227; l46 = v228; l47 = v229; l48 = v230; l49 = v231; l50 = v232; l51 = v233; l52 = v234; l53 = v235; l54 = v236; l55 = v237; l56 = v238; l57 = v239; l58 = v240; l59 = v241; l60 = v242; l61 = v243; l62 = v244; l63 = v245; l64 = v246; l65 = v247; l66 = v248; l67 = v249} : Mut3
            let v262 : (unit -> (JSX.Element [])) = closure281()
            emitJsExpr (v261, v262) "$0.children = $1"
            let v263 : JS.Function = import v87 v88
            let v264 : (Mut3 -> JSX.Element) = closure282()
            let v265 : JSX.Element = v263.Invoke (v264, v261) |> unbox<JSX.Element>
            v265
        else
            let v266 : JSX.Element = null
            v266
    [|v91; v180; v267|]
and closure235 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) = method13()
    let v80 : US8 =
        match v16 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US8_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US8_0 -> (* None *)
            closure236(v0, v1, v2, v3, v4)
        | US8_1(v82) -> (* Some *)
            v82
    let v84 : US8 = US8_1(v83)
    let v85 : Mut3 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v84; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67; l63 = v68; l64 = v69; l65 = v70; l66 = v71; l67 = v72} : Mut3
    let v86 : (unit -> (JSX.Element [])) = closure236(v0, v1, v2, v3, v4)
    emitJsExpr (v85, v86) "$0.children = $1"
    let v87 : string = "createComponent"
    let v88 : string = "solid-js"
    let v89 : JS.Function = import v87 v88
    let v90 : (Mut3 -> JSX.Element) = closure73()
    let v91 : JSX.Element = v89.Invoke (v90, v85) |> unbox<JSX.Element>
    [|v91|]
and closure234 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v73 : string = "Profile"
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure235(v0, v1, v2, v3, v4)
    let v77 : US8 = US8_1(v76)
    let v78 : US11 = US11_1(v75)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v77, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v78, v66, v67, v68, v69, v70, v71, v72)
and closure76 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure77()
    let v8 : US15 = US15_2
    let v9 : Mut5 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8} : Mut5
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : (Mut5 -> JSX.Element) = closure26()
    let v14 : JSX.Element = v12.Invoke (v13, v9) |> unbox<JSX.Element>
    let v15 : US14 = US14_0
    let v16 : US14 = US14_0
    let v17 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure55()
    let v18 : US15 = US15_2
    let v19 : Mut5 = {l0 = v15; l1 = v16; l2 = v17; l3 = v18} : Mut5
    let v20 : JS.Function = import v10 v11
    let v21 : JSX.Element = v20.Invoke (v13, v19) |> unbox<JSX.Element>
    let v22 : US14 = US14_0
    let v23 : US14 = US14_0
    let v24 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure96()
    let v25 : US15 = US15_2
    let v26 : Mut5 = {l0 = v22; l1 = v23; l2 = v24; l3 = v25} : Mut5
    let v27 : JS.Function = import v10 v11
    let v28 : JSX.Element = v27.Invoke (v13, v26) |> unbox<JSX.Element>
    let v29 : US14 = US14_0
    let v30 : US14 = US14_0
    let v31 : US15 = US15_2
    let v32 : Mut5 = {l0 = v29; l1 = v30; l2 = v17; l3 = v31} : Mut5
    let v33 : JS.Function = import v10 v11
    let v34 : JSX.Element = v33.Invoke (v13, v32) |> unbox<JSX.Element>
    let v35 : US14 = US14_0
    let v36 : US14 = US14_0
    let v37 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure108()
    let v38 : US15 = US15_0
    let v39 : Mut5 = {l0 = v35; l1 = v36; l2 = v37; l3 = v38} : Mut5
    let v40 : JS.Function = import v10 v11
    let v41 : JSX.Element = v40.Invoke (v13, v39) |> unbox<JSX.Element>
    let v42 : US14 = US14_0
    let v43 : US14 = US14_0
    let v44 : US15 = US15_2
    let v45 : Mut5 = {l0 = v42; l1 = v43; l2 = v17; l3 = v44} : Mut5
    let v46 : JS.Function = import v10 v11
    let v47 : JSX.Element = v46.Invoke (v13, v45) |> unbox<JSX.Element>
    let v48 : US14 = US14_0
    let v49 : US14 = US14_0
    let v50 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure169()
    let v51 : US15 = US15_0
    let v52 : Mut5 = {l0 = v48; l1 = v49; l2 = v50; l3 = v51} : Mut5
    let v53 : JS.Function = import v10 v11
    let v54 : JSX.Element = v53.Invoke (v13, v52) |> unbox<JSX.Element>
    let v55 : US14 = US14_0
    let v56 : US14 = US14_0
    let v57 : US15 = US15_2
    let v58 : Mut5 = {l0 = v55; l1 = v56; l2 = v17; l3 = v57} : Mut5
    let v59 : JS.Function = import v10 v11
    let v60 : JSX.Element = v59.Invoke (v13, v58) |> unbox<JSX.Element>
    let v61 : US14 = US14_0
    let v62 : US14 = US14_0
    let v63 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure234(v0, v1, v2, v3, v4)
    let v64 : US15 = US15_2
    let v65 : Mut5 = {l0 = v61; l1 = v62; l2 = v63; l3 = v64} : Mut5
    let v66 : JS.Function = import v10 v11
    let v67 : JSX.Element = v66.Invoke (v13, v65) |> unbox<JSX.Element>
    [|v14; v21; v28; v34; v41; v47; v54; v60; v67|]
and closure9 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v6 : bool = v2 = ""
    let v14 : JSX.Element =
        if v6 then
            let v7 : Mut2 = Mut2()
            let v8 : string = "createComponent"
            let v9 : string = "solid-js"
            let v10 : JS.Function = import v8 v9
            let v11 : (Mut2 -> JSX.Element) = closure10()
            let v12 : JSX.Element = v10.Invoke (v11, v7) |> unbox<JSX.Element>
            v12
        else
            let v13 : JSX.Element = null
            v13
    let struct (v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US8, v27 : US3, v28 : US3, v29 : US7, v30 : US9, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US7, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US12, v56 : US13, v57 : US12, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US11, v76 : US3, v77 : US3, v78 : US9, v79 : US9, v80 : US3, v81 : US2, v82 : US3) = method13()
    let v90 : US8 =
        match v26 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v84) -> (* Some *)
            let v85 : string = "children"
            let v86 : string = "solid-js"
            let v87 : JS.Function = import v85 v86
            let v88 : (unit -> (JSX.Element [])) = v87.Invoke v84 |> unbox<unit -> JSX.Element[]>
            US8_1(v88)
    let v93 : (unit -> (JSX.Element [])) =
        match v90 with
        | US8_0 -> (* None *)
            closure76(v0, v1, v2, v3, v4)
        | US8_1(v92) -> (* Some *)
            v92
    let v94 : US8 = US8_1(v93)
    let v95 : string = "flex"
    let v96 : US3 = US3_1(v95)
    let v97 : string = "1"
    let v98 : US3 = US3_1(v97)
    let v99 : string = "column"
    let v100 : US3 = US3_1(v99)
    let v101 : string = "hidden"
    let v102 : US3 = US3_1(v101)
    let v103 : string = "auto"
    let v104 : US3 = US3_1(v103)
    let v105 : Mut3 = {l0 = v15; l1 = v16; l2 = v17; l3 = v18; l4 = v19; l5 = v20; l6 = v21; l7 = v22; l8 = v23; l9 = v24; l10 = v25; l11 = v94; l12 = v27; l13 = v28; l14 = v29; l15 = v30; l16 = v31; l17 = v32; l18 = v96; l19 = v34; l20 = v35; l21 = v98; l22 = v100; l23 = v38; l24 = v39; l25 = v40; l26 = v41; l27 = v42; l28 = v43; l29 = v44; l30 = v45; l31 = v46; l32 = v47; l33 = v48; l34 = v49; l35 = v50; l36 = v51; l37 = v52; l38 = v53; l39 = v54; l40 = v55; l41 = v56; l42 = v57; l43 = v58; l44 = v59; l45 = v102; l46 = v104; l47 = v62; l48 = v63; l49 = v64; l50 = v65; l51 = v66; l52 = v67; l53 = v68; l54 = v69; l55 = v70; l56 = v71; l57 = v72; l58 = v73; l59 = v74; l60 = v75; l61 = v76; l62 = v77; l63 = v78; l64 = v79; l65 = v80; l66 = v81; l67 = v82} : Mut3
    let v106 : (unit -> (JSX.Element [])) = closure76(v0, v1, v2, v3, v4)
    emitJsExpr (v105, v106) "$0.children = $1"
    let v107 : string = "createComponent"
    let v108 : string = "solid-js"
    let v109 : JS.Function = import v107 v108
    let v110 : (Mut3 -> JSX.Element) = closure73()
    let v111 : JSX.Element = v109.Invoke (v110, v105) |> unbox<JSX.Element>
    [|v14; v111|]
and method12 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method1()
    let v5 : string = "Box"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US7, v19 : US8, v20 : US3, v21 : US3, v22 : US7, v23 : US9, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US12, v49 : US13, v50 : US12, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US11, v69 : US3, v70 : US3, v71 : US9, v72 : US9, v73 : US3, v74 : US2, v75 : US3) = method13()
    let v83 : US8 =
        match v19 with
        | US8_0 -> (* None *)
            US8_0
        | US8_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US8_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US8_0 -> (* None *)
            closure9(v0, v1, v2, v3, v4)
        | US8_1(v85) -> (* Some *)
            v85
    let v87 : string = "$bg"
    let v88 : US3 = US3_1(v87)
    let v89 : US8 = US8_1(v86)
    let v90 : string = "$text1"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "flex"
    let v93 : US3 = US3_1(v92)
    let v94 : string = "1"
    let v95 : US3 = US3_1(v94)
    let v96 : string = "column"
    let v97 : US3 = US3_1(v96)
    let v98 : string = "$sm"
    let v99 : US3 = US3_1(v98)
    let v100 : string = "100vh"
    let v101 : US3 = US3_1(v100)
    let v102 : string = "100vw"
    let v103 : US3 = US3_1(v102)
    let v104 : string = "1px"
    let v105 : US3 = US3_1(v104)
    let v106 : ((string * obj) []) = method17(v8, v9, v10, v11, v88, v13, v14, v15, v16, v17, v18, v89, v91, v21, v22, v23, v24, v25, v93, v27, v28, v95, v97, v31, v99, v101, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v103, v48, v49, v50, v51, v52, v53, v54, v105, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v107 : obj = createObj v106
    let v108 : (unit -> (JSX.Element [])) = closure9(v0, v1, v2, v3, v4)
    emitJsExpr (v107, v108) "$0.children = $1"
    let v109 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v110 : string = "createComponent"
    let v111 : string = "solid-js"
    let v112 : JS.Function = import v110 v111
    let v113 : JSX.Element = v112.Invoke (v109, v107) |> unbox<JSX.Element>
    v113
and closure8 () (v0 : Mut3) : JSX.Element =
    method12()
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v70 : obj = emitJsExpr () "process.env"
let v71 : string = "env"
let v72 : (string * obj) = v71, v70
let v73 : ((string * obj) []) = [|v72|]
let v74 : obj = createObj v73
Browser.Dom.window?components_spi <- v74
let struct (v75 : (struct (US0 * string * string * string) []), v76 : US2, v77 : US3, v78 : US3, v79 : (struct (US4 * int32 * string * string) []), v80 : (struct (US4 * US4) []), v81 : (struct (int32 * obj) []), v82 : (struct (int32 * obj) []), v83 : (struct (int32 * int32) []), v84 : US5, v85 : US2) = method0()
let v86 : Mut1 = {l0 = v75; l1 = v76; l2 = v77; l3 = v78; l4 = v79; l5 = v80; l6 = v81; l7 = v82; l8 = v83; l9 = v84; l10 = v85} : Mut1
let v87 : obj = v86
let v88 : obj = method6(v87)
let v89 : int32 = Random().Next ()
let v90 : string = "db_listener"
let v91 : (Mut2 -> JSX.Element) = closure1(v88)
let v92 : (string * obj) = v90, v91
let v93 : string = "content"
let v94 : (Mut3 -> JSX.Element) = closure8()
let v95 : (string * obj) = v93, v94
let v96 : string = "store"
let v97 : (string * obj) = v96, v88
let v98 : string = "run_id"
let v99 : (string * obj) = v98, v89
let v100 : ((string * obj) []) = [|v92; v95; v97; v99; v72|]
let v101 : obj = createObj v100
Browser.Dom.window?components_spi <- v101
v1.l0 <- v101
()
