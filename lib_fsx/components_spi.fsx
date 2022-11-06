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
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and [<Struct>] US14 =
    | US14_0
    | US14_1 of f1_0 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit))
and [<Struct>] US15 =
    | US15_0
    | US15_1
    | US15_2
and Mut4 = {mutable l0 : US14; mutable l1 : US14; mutable l2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)); mutable l3 : US15}
and Mut5 = {mutable l0 : (unit -> bool); mutable l1 : (bool -> unit); mutable l2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))}
and Mut6 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US14; mutable l3 : US14; mutable l4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))}
and Mut7 = {mutable l0 : int32}
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
and closure2 (v0 : Mut1, v1 : JS.Function) (v2 : (Mut1 -> (Mut1 -> unit))) : unit =
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v4 : obj = createObj v3
    let v5 : Mut1 = v4 |> unbox
    let v6 : (Mut1 -> unit) = v2 v0
    v6 v5
    let v7 : obj = v5
    v1.Invoke ("set", v7) |> ignore
    ()
and method8 () : struct (Mut1 * ((Mut1 -> (Mut1 -> unit)) -> unit)) =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure2(v4, v5)
    struct (v4, v6)
and closure3 (v0 : Mut1) () : bool =
    let struct (v1 : US5, v2 : US2) = v0.l9, v0.l10
    match v1 with
    | US5_0 -> (* Debug *)
        true
    | _ ->
        false
and closure4 () () : (obj []) =
    [||]
and method10 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method10(v0, v4)
    else
        v1
and closure5 (v0 : (unit -> bool), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64) (v9 : (obj [])) : unit =
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
    closure5(v0, v1, v2, v3, v4, v5, v6, v7, v8)
and closure6 (v0 : ((obj []) -> unit)) struct (v1 : Mut1, v2 : Mut1, v3 : obj) : unit =
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
    let v3 : (unit -> bool) = closure3(v1)
    let v4 : (unit -> (obj [])) = closure4()
    let v5 : string = "#cf1100"
    let v6 : ((obj []) -> unit) = method9(v3, v4, v5)
    let v7 : string = "> db_listener ()"
    let v8 : obj = v7
    let v9 : (obj []) = [|v8|]
    v6 v9
    let v10 : JS.Function = v0?on |> unbox<JS.Function>
    let v11 : (struct (Mut1 * Mut1 * obj) -> unit) = closure6(v6)
    let v12 : JS.Function = emitJsExpr v11 "(...args: any[]) => $0(args)"
    let v13 : (unit -> unit) = v10.Invoke ("@changed", v12) |> unbox<unit -> unit>
    method11(v13)
    let v14 : JSX.Element = Html.fragment []
    v14
and closure1 (v0 : obj) (v1 : Mut2) : JSX.Element =
    method7(v0)
and closure8 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "$bg"
    let v69 : US3 = US3_1(v68)
    let v70 : string = "$text1"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "flex"
    let v73 : US3 = US3_1(v72)
    let v74 : string = "1"
    let v75 : US3 = US3_1(v74)
    let v76 : string = "column"
    let v77 : US3 = US3_1(v76)
    let v78 : string = "$sm"
    let v79 : US3 = US3_1(v78)
    let v80 : string = "100vh"
    let v81 : US3 = US3_1(v80)
    let v82 : string = "100vw"
    let v83 : US3 = US3_1(v82)
    let v84 : string = "1px"
    let v85 : US3 = US3_1(v84)
    struct (v0, v1, v2, v3, v69, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v73, v19, v20, v75, v77, v23, v79, v81, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v83, v40, v41, v42, v43, v44, v45, v46, v85, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure11 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : US5, v70 : US2) = v0.l9, v0.l10
    let v72 : bool =
        match v70 with
        | US2_0 -> (* None *)
            true
        | _ ->
            false
    let v76 : US3 =
        if v72 then
            let v73 : string = "absolute"
            US3_1(v73)
        else
            US3_0
    let v77 : string = "$blackAlpha9"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "0"
    let v80 : US3 = US3_1(v79)
    let v81 : string = "flex"
    let v82 : US3 = US3_1(v81)
    let v83 : string = "column"
    let v84 : US3 = US3_1(v83)
    let v85 : string = "80vh"
    let v86 : US3 = US3_1(v85)
    let v87 : string = "50vw"
    let v88 : US3 = US3_1(v87)
    let v89 : string = "auto"
    let v90 : US3 = US3_1(v89)
    let v91 : US3 = US3_1(v79)
    let v92 : US2 = US2_1(2)
    struct (v1, v2, v3, v4, v78, v6, v7, v8, v9, v80, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v84, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v86, v88, v41, v42, v43, v44, v90, v46, v47, v48, v49, v50, v51, v52, v53, v76, v91, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v92, v68)
and closure14 (v0 : Mut3) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : US3 = v0.l46
    let v72 : string =
        match v69 with
        | US3_0 -> (* None *)
            let v70 : string = "hidden"
            v70
        | US3_1(v71) -> (* Some *)
            v71
    let v73 : string = "flex"
    let v74 : US3 = US3_1(v73)
    let v75 : string = "1"
    let v76 : US3 = US3_1(v75)
    let v77 : string = "column"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "hidden"
    let v80 : US3 = US3_1(v79)
    let v81 : US3 = US3_1(v72)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v74, v20, v21, v76, v78, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v80, v81, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure16 () () : (JSX.Element []) =
    [||]
and closure17 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "$blackAlpha3"
    let v69 : US3 = US3_1(v68)
    let v70 : string = "flex"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "column"
    let v73 : US3 = US3_1(v72)
    let v74 : string = "-1px"
    let v75 : US3 = US3_1(v74)
    struct (v0, v1, v2, v3, v69, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v71, v19, v20, v21, v73, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v75, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and method16 () : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
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
and method15 (v0 : JS.Function, v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)), v2 : (unit -> (JSX.Element []))) : JSX.Element =
    let struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) = method16()
    let struct (v71 : US3, v72 : US3, v73 : US3, v74 : US6, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US7, v82 : US8, v83 : US3, v84 : US3, v85 : US7, v86 : US9, v87 : US3, v88 : US3, v89 : US3, v90 : US10, v91 : US7, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US3, v98 : US11, v99 : US3, v100 : US3, v101 : US3, v102 : US11, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US12, v112 : US13, v113 : US12, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US11, v132 : US3, v133 : US3, v134 : US9, v135 : US9, v136 : US3, v137 : US2, v138 : US3) = v1 struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v139 : US8 = US8_1(v2)
    let v140 : ((string * obj) []) = method17(v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v139, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138)
    let v141 : obj = createObj v140
    let v142 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v143 : string = "createComponent"
    let v144 : string = "solid-js"
    let v145 : JS.Function = import v143 v144
    let v146 : JSX.Element = v145.Invoke (v142, v141) |> unbox<JSX.Element>
    v146
and closure15 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : US8 = v0.l11
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US8_0 -> (* None *)
            closure16()
        | US8_1(v3) -> (* Some *)
            v3
    let v5 : string = "Tbody"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure17()
    let v9 : JSX.Element = method15(v7, v8, v4)
    [|v9|]
and method14 (v0 : Mut3) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure14(v0)
    let v5 : (unit -> (JSX.Element [])) = closure15(v0)
    method15(v3, v4, v5)
and closure13 () (v0 : Mut3) : JSX.Element =
    method14(v0)
and closure18 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
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
and closure21 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) struct (v68 : US3, v69 : US3, v70 : US3, v71 : US6, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US7, v79 : US8, v80 : US3, v81 : US3, v82 : US7, v83 : US9, v84 : US3, v85 : US3, v86 : US3, v87 : US10, v88 : US7, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US11, v96 : US3, v97 : US3, v98 : US3, v99 : US11, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US12, v109 : US13, v110 : US12, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US11, v129 : US3, v130 : US3, v131 : US9, v132 : US9, v133 : US3, v134 : US2, v135 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v136 : string = "column"
    let v137 : string = "row"
    let v138 : string = method23(v137, v136)
    let v139 : string = "$neutral5"
    let v140 : US3 = US3_1(v139)
    let v141 : string = "1px 2px"
    let v142 : US3 = US3_1(v141)
    let v143 : string = "flex"
    let v144 : US3 = US3_1(v143)
    let v145 : string = "1"
    let v146 : US3 = US3_1(v145)
    let v147 : US3 = US3_1(v138)
    struct (v68, v69, v70, v71, v72, v73, v74, v140, v142, v77, v78, v79, v80, v81, v82, v83, v84, v85, v144, v87, v88, v146, v147, v91, v92, v93, v94, v95, v28, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135)
and closure23 (v0 : Mut4, v1 : (unit -> bool)) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : US15 = v0.l3
    let v72 : bool =
        match v70 with
        | US15_2 -> (* CheckHidden *)
            true
        | _ ->
            false
    let v74 : bool =
        if v72 then
            true
        else
            let v73 : bool = v1 ()
            v73
    let v79 : string =
        if v74 then
            let v75 : string = "2px !important"
            let v76 : string = "0px !important"
            method23(v76, v75)
        else
            let v78 : string = "0px !important"
            v78
    let v80 : US3 = US3_1(v79)
    let v81 : string = "$neutral5"
    let v82 : US3 = US3_1(v81)
    let v83 : string = "$neutral9"
    let v84 : US3 = US3_1(v83)
    let v85 : string = "flex"
    let v86 : US3 = US3_1(v85)
    let v87 : string = "column"
    let v88 : US3 = US3_1(v87)
    let v89 : string = "$sm"
    let v90 : US3 = US3_1(v89)
    let v91 : string = "3px 20px 0 8px"
    let v92 : US3 = US3_1(v91)
    struct (v2, v3, v4, v5, v6, v7, v80, v82, v10, v11, v12, v13, v84, v15, v16, v17, v18, v19, v86, v21, v22, v23, v88, v25, v90, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v92, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure27 (v0 : Mut5) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    let v3 : (bool -> unit) = v0.l1
    v3 v2
    ()
and closure26 (v0 : Mut5) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (unit -> bool) = v0.l0
    let v70 : bool = v69 ()
    let v71 : US7 = US7_1(v70)
    let v72 : string = "neutral"
    let v73 : US3 = US3_1(v72)
    let v74 : string = "2px"
    let v75 : US3 = US3_1(v74)
    let v76 : (obj -> unit) = closure27(v0)
    let v77 : US12 = US12_1(v76)
    let v78 : string = "sm"
    let v79 : US3 = US3_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v73, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v75, v36, v37, v38, v39, v40, v77, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v79, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure29 () () : (JSX.Element []) =
    [||]
and closure30 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "2px"
    let v69 : US3 = US3_1(v68)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v69, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure28 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) () : (JSX.Element []) =
    let v70 : (unit -> (JSX.Element [])) =
        match v11 with
        | US8_0 -> (* None *)
            closure29()
        | US8_1(v69) -> (* Some *)
            v69
    let v71 : string = "Box"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let v74 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure30()
    let v75 : JSX.Element = method15(v73, v74, v70)
    [|v75|]
and closure25 () (v0 : Mut5) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l2
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method16()
    let struct (v70 : US3, v71 : US3, v72 : US3, v73 : US6, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US7, v81 : US8, v82 : US3, v83 : US3, v84 : US7, v85 : US9, v86 : US3, v87 : US3, v88 : US3, v89 : US10, v90 : US7, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US11, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US12, v111 : US13, v112 : US12, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US11, v131 : US3, v132 : US3, v133 : US9, v134 : US9, v135 : US3, v136 : US2, v137 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v138 : string = "Checkbox"
    let v139 : string = "@hope-ui/solid"
    let v140 : JS.Function = import v138 v139
    let v141 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure26(v0)
    let v142 : (unit -> (JSX.Element [])) = closure28(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
    method15(v140, v141, v142)
and closure32 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure31 (v0 : JSX.Element) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (unit -> (JSX.Element [])) = closure32(v0)
    let v70 : US8 = US8_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v70, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and method24 (v0 : (Mut5 -> JSX.Element), v1 : (unit -> bool), v2 : (bool -> unit), v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))) : JSX.Element =
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v5 : Mut5 = {l0 = v1; l1 = v2; l2 = v3} : Mut5
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v4, v6) |> unbox<JSX.Element>
    v10
and closure24 (v0 : Mut4, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US15 = v0.l3
    let v11 : JSX.Element =
        match v4 with
        | US15_0 -> (* CheckDisabled *)
            let v5 : (Mut5 -> JSX.Element) = closure25()
            let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure31(v3)
            method24(v5, v2, v1, v6)
        | US15_1 -> (* CheckEnabled *)
            let v8 : (Mut5 -> JSX.Element) = closure25()
            let v9 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure31(v3)
            method24(v8, v2, v1, v9)
        | US15_2 -> (* CheckHidden *)
            v3
    [|v11|]
and closure33 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "0"
    let v69 : US3 = US3_1(v68)
    let v70 : string = "9px"
    let v71 : US3 = US3_1(v70)
    let v72 : US3 = US3_1(v68)
    struct (v0, v1, v2, v3, v4, v69, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v71, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v72, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure34 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure35 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) struct (v68 : US3, v69 : US3, v70 : US3, v71 : US6, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US7, v79 : US8, v80 : US3, v81 : US3, v82 : US7, v83 : US9, v84 : US3, v85 : US3, v86 : US3, v87 : US10, v88 : US7, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US11, v96 : US3, v97 : US3, v98 : US3, v99 : US11, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US12, v109 : US13, v110 : US12, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US11, v129 : US3, v130 : US3, v131 : US9, v132 : US9, v133 : US3, v134 : US2, v135 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v138 : string =
        match v47 with
        | US3_0 -> (* None *)
            let v136 : string = "0"
            v136
        | US3_1(v137) -> (* Some *)
            v137
    let v139 : string = "0"
    let v140 : US3 = US3_1(v139)
    let v141 : string = "flex"
    let v142 : US3 = US3_1(v141)
    let v143 : string = "6"
    let v144 : US3 = US3_1(v143)
    let v145 : string = "column"
    let v146 : US3 = US3_1(v145)
    let v147 : string = "$sm"
    let v148 : US3 = US3_1(v147)
    let v149 : string = "$base"
    let v150 : US3 = US3_1(v149)
    let v151 : US3 = US3_1(v139)
    let v152 : string = "85vh"
    let v153 : US3 = US3_1(v152)
    let v154 : US3 = US3_1(v139)
    let v155 : string = "auto"
    let v156 : US3 = US3_1(v155)
    let v157 : US3 = US3_1(v138)
    struct (v68, v69, v70, v71, v72, v140, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v142, v87, v88, v144, v146, v91, v148, v93, v94, v95, v96, v97, v98, v99, v150, v151, v102, v103, v104, v105, v153, v107, v108, v109, v110, v154, v112, v113, v156, v157, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135)
and closure40 (v0 : int32) (v1 : Mut1) : unit =
    let v2 : US2 = US2_1(v0)
    v1.l10 <- v2
    ()
and closure39 (v0 : int32) (v1 : Mut1) : (Mut1 -> unit) =
    closure40(v0)
and closure38 (v0 : Mut6, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit), v2 : int32) () : unit =
    let v3 : bool = v0.l1
    if v3 then
        let v4 : (Mut1 -> (Mut1 -> unit)) = closure39(v2)
        v1 v4
        ()
and method26 (v0 : (unit -> unit)) : unit =
    let v1 : string = "createEffect"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    v3.Invoke v0 |> ignore
    ()
and closure41 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure42 (v0 : Mut6, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit), v2 : Mut1) () : unit =
    let v3 : US14 = v0.l3
    match v3 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v4) -> (* Some *)
        let v5 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v4 v2
        v5 v1
        ()
and closure43 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) struct (v68 : US3, v69 : US3, v70 : US3, v71 : US6, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US7, v79 : US8, v80 : US3, v81 : US3, v82 : US7, v83 : US9, v84 : US3, v85 : US3, v86 : US3, v87 : US10, v88 : US7, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US11, v96 : US3, v97 : US3, v98 : US3, v99 : US11, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US12, v109 : US13, v110 : US12, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US11, v129 : US3, v130 : US3, v131 : US9, v132 : US9, v133 : US3, v134 : US2, v135 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v136 : string = "flex"
    let v137 : US3 = US3_1(v136)
    let v138 : string = "1"
    let v139 : US3 = US3_1(v138)
    struct (v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v137, v87, v88, v139, v90, v91, v92, v93, v94, v95, v28, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135)
and closure45 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "3px 0"
    let v69 : US3 = US3_1(v68)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v69, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure48 () () : (JSX.Element []) =
    [||]
and method29 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method28 (v0 : Mut3, v1 : Mut3) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut7 = {l0 = 0} : Mut7
    while method29(v3, v4) do
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
and closure49 (v0 : Mut3) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : US3, v70 : US3, v71 : US3, v72 : US6, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US7, v80 : US8, v81 : US3, v82 : US3, v83 : US7, v84 : US9, v85 : US3, v86 : US3, v87 : US3, v88 : US10, v89 : US7, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US11, v97 : US3, v98 : US3, v99 : US3, v100 : US11, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US12, v110 : US13, v111 : US12, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US11, v130 : US3, v131 : US3, v132 : US9, v133 : US9, v134 : US3, v135 : US2, v136 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67
    let v137 : Mut3 = {l0 = v69; l1 = v70; l2 = v71; l3 = v72; l4 = v73; l5 = v74; l6 = v75; l7 = v76; l8 = v77; l9 = v78; l10 = v79; l11 = v80; l12 = v81; l13 = v82; l14 = v83; l15 = v84; l16 = v85; l17 = v86; l18 = v87; l19 = v88; l20 = v89; l21 = v90; l22 = v91; l23 = v92; l24 = v93; l25 = v94; l26 = v95; l27 = v96; l28 = v97; l29 = v98; l30 = v99; l31 = v100; l32 = v101; l33 = v102; l34 = v103; l35 = v104; l36 = v105; l37 = v106; l38 = v107; l39 = v108; l40 = v109; l41 = v110; l42 = v111; l43 = v112; l44 = v113; l45 = v114; l46 = v115; l47 = v116; l48 = v117; l49 = v118; l50 = v119; l51 = v120; l52 = v121; l53 = v122; l54 = v123; l55 = v124; l56 = v125; l57 = v126; l58 = v127; l59 = v128; l60 = v129; l61 = v130; l62 = v131; l63 = v132; l64 = v133; l65 = v134; l66 = v135; l67 = v136} : Mut3
    let v138 : string = "neutral"
    let v139 : US3 = US3_1(v138)
    let v140 : US7 = US7_1(true)
    let v141 : string = "left"
    let v142 : US3 = US3_1(v141)
    let v143 : string = "xs"
    let v144 : US3 = US3_1(v143)
    let v145 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v139; l14 = v140; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v142; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v144; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68} : Mut3
    method28(v145, v137)
    let struct (v146 : US3, v147 : US3, v148 : US3, v149 : US6, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US3, v156 : US7, v157 : US8, v158 : US3, v159 : US3, v160 : US7, v161 : US9, v162 : US3, v163 : US3, v164 : US3, v165 : US10, v166 : US7, v167 : US3, v168 : US3, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US11, v174 : US3, v175 : US3, v176 : US3, v177 : US11, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US12, v187 : US13, v188 : US12, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US11, v207 : US3, v208 : US3, v209 : US9, v210 : US9, v211 : US3, v212 : US2, v213 : US3) = v145.l0, v145.l1, v145.l2, v145.l3, v145.l4, v145.l5, v145.l6, v145.l7, v145.l8, v145.l9, v145.l10, v145.l11, v145.l12, v145.l13, v145.l14, v145.l15, v145.l16, v145.l17, v145.l18, v145.l19, v145.l20, v145.l21, v145.l22, v145.l23, v145.l24, v145.l25, v145.l26, v145.l27, v145.l28, v145.l29, v145.l30, v145.l31, v145.l32, v145.l33, v145.l34, v145.l35, v145.l36, v145.l37, v145.l38, v145.l39, v145.l40, v145.l41, v145.l42, v145.l43, v145.l44, v145.l45, v145.l46, v145.l47, v145.l48, v145.l49, v145.l50, v145.l51, v145.l52, v145.l53, v145.l54, v145.l55, v145.l56, v145.l57, v145.l58, v145.l59, v145.l60, v145.l61, v145.l62, v145.l63, v145.l64, v145.l65, v145.l66, v145.l67
    struct (v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213)
and method27 (v0 : Mut3) : JSX.Element =
    let v1 : US8 = v0.l11
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US8_0 -> (* None *)
            closure48()
        | US8_1(v3) -> (* Some *)
            v3
    let v5 : string = "Button"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure49(v0)
    method15(v7, v8, v4)
and closure47 () (v0 : Mut3) : JSX.Element =
    method27(v0)
and closure51 (v0 : (bool -> unit), v1 : Mut6, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) () : unit =
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
and closure50 (v0 : (bool -> unit), v1 : Mut6, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v72 : (unit -> unit) = closure51(v0, v1, v2, v3)
    let v73 : US13 = US13_1(v72)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v73, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure52 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and method30 (v0 : (Mut3 -> JSX.Element), v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)), v2 : (unit -> (JSX.Element []))) : JSX.Element =
    let v3 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) = method16()
    let struct (v72 : US3, v73 : US3, v74 : US3, v75 : US6, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US7, v83 : US8, v84 : US3, v85 : US3, v86 : US7, v87 : US9, v88 : US3, v89 : US3, v90 : US3, v91 : US10, v92 : US7, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US11, v100 : US3, v101 : US3, v102 : US3, v103 : US11, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US12, v113 : US13, v114 : US12, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US11, v133 : US3, v134 : US3, v135 : US9, v136 : US9, v137 : US3, v138 : US2, v139 : US3) = v1 struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v140 : US8 = US8_1(v2)
    let v141 : Mut3 = {l0 = v72; l1 = v73; l2 = v74; l3 = v75; l4 = v76; l5 = v77; l6 = v78; l7 = v79; l8 = v80; l9 = v81; l10 = v82; l11 = v140; l12 = v84; l13 = v85; l14 = v86; l15 = v87; l16 = v88; l17 = v89; l18 = v90; l19 = v91; l20 = v92; l21 = v93; l22 = v94; l23 = v95; l24 = v96; l25 = v97; l26 = v98; l27 = v99; l28 = v100; l29 = v101; l30 = v102; l31 = v103; l32 = v104; l33 = v105; l34 = v106; l35 = v107; l36 = v108; l37 = v109; l38 = v110; l39 = v111; l40 = v112; l41 = v113; l42 = v114; l43 = v115; l44 = v116; l45 = v117; l46 = v118; l47 = v119; l48 = v120; l49 = v121; l50 = v122; l51 = v123; l52 = v124; l53 = v125; l54 = v126; l55 = v127; l56 = v128; l57 = v129; l58 = v130; l59 = v131; l60 = v132; l61 = v133; l62 = v134; l63 = v135; l64 = v136; l65 = v137; l66 = v138; l67 = v139} : Mut3
    emitJsExpr (v141, v2) "$0.children = $1"
    let v142 : obj = v141
    let v143 : string = "createComponent"
    let v144 : string = "solid-js"
    let v145 : JS.Function = import v143 v144
    let v146 : JSX.Element = v145.Invoke (v3, v142) |> unbox<JSX.Element>
    v146
and closure46 (v0 : (bool -> unit), v1 : Mut6, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) () : (JSX.Element []) =
    let v4 : (Mut3 -> JSX.Element) = closure47()
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure50(v0, v1, v2, v3)
    let v6 : (unit -> (JSX.Element [])) = closure52()
    let v7 : JSX.Element = method30(v4, v5, v6)
    [|v7|]
and closure53 (v0 : Mut1, v1 : int32) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v70 : US5, v71 : US2) = v0.l9, v0.l10
    let v75 : bool =
        match v71 with
        | US2_1(v73) -> (* Some *)
            let v74 : bool = v73 = v1
            v74
        | _ ->
            false
    let v78 : US2 =
        if v75 then
            US2_1(1)
        else
            US2_0
    let struct (v79 : US5, v80 : US2) = v0.l9, v0.l10
    let v84 : bool =
        match v80 with
        | US2_1(v82) -> (* Some *)
            let v83 : bool = v82 = v1
            v83
        | _ ->
            false
    let v88 : US3 =
        if v84 then
            let v85 : string = "absolute"
            US3_1(v85)
        else
            US3_0
    let struct (v89 : US5, v90 : US2) = v0.l9, v0.l10
    let v94 : bool =
        match v90 with
        | US2_1(v92) -> (* Some *)
            let v93 : bool = v92 = v1
            v93
        | _ ->
            false
    let v98 : US3 =
        if v94 then
            let v95 : string = "0"
            US3_1(v95)
        else
            US3_0
    let struct (v99 : US5, v100 : US2) = v0.l9, v0.l10
    let v104 : bool =
        match v100 with
        | US2_1(v102) -> (* Some *)
            let v103 : bool = v102 = v1
            v103
        | _ ->
            false
    let v108 : US3 =
        if v104 then
            let v105 : string = "0"
            US3_1(v105)
        else
            US3_0
    let struct (v109 : US5, v110 : US2) = v0.l9, v0.l10
    let v114 : bool =
        match v110 with
        | US2_1(v112) -> (* Some *)
            let v113 : bool = v112 = v1
            v113
        | _ ->
            false
    let v118 : US3 =
        if v114 then
            let v115 : string = "0"
            US3_1(v115)
        else
            US3_0
    let struct (v119 : US5, v120 : US2) = v0.l9, v0.l10
    let v124 : bool =
        match v120 with
        | US2_1(v122) -> (* Some *)
            let v123 : bool = v122 = v1
            v123
        | _ ->
            false
    let v128 : US3 =
        if v124 then
            let v125 : string = "0"
            US3_1(v125)
        else
            US3_0
    let struct (v129 : US5, v130 : US2) = v0.l9, v0.l10
    let v134 : bool =
        match v130 with
        | US2_1(v132) -> (* Some *)
            let v133 : bool = v132 = v1
            v133
        | _ ->
            false
    let v138 : US3 =
        if v134 then
            let v135 : string = "$bg"
            US3_1(v135)
        else
            US3_0
    let v139 : string = "flex"
    let v140 : US3 = US3_1(v139)
    let v141 : string = "1"
    let v142 : US3 = US3_1(v141)
    struct (v2, v3, v4, v5, v138, v7, v8, v9, v10, v118, v12, v13, v14, v15, v16, v17, v18, v19, v140, v21, v22, v142, v24, v25, v26, v27, v28, v29, v30, v31, v128, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v88, v108, v57, v58, v59, v60, v61, v62, v98, v64, v65, v66, v67, v78, v69)
and closure55 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : US5, v70 : US2) = v0.l9, v0.l10
    let v72 : bool =
        match v70 with
        | US2_0 -> (* None *)
            true
        | _ ->
            false
    let v76 : US3 =
        if v72 then
            let v73 : string = "relative"
            US3_1(v73)
        else
            US3_0
    let v77 : string = "flex"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "1"
    let v80 : US3 = US3_1(v79)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v78, v20, v21, v80, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v76, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure57 (v0 : Mut1, v1 : int32) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v70 : US5, v71 : US2) = v0.l9, v0.l10
    let v80 : US3 =
        match v71 with
        | US2_0 -> (* None *)
            US3_0
        | US2_1(v73) -> (* Some *)
            let v74 : bool = v73 = v1
            let v75 : bool = v74 <> true
            if v75 then
                let v76 : string = "none"
                US3_1(v76)
            else
                US3_0
    let v81 : string = "row"
    let v82 : US3 = US3_1(v81)
    let v83 : string = "absolute"
    let v84 : US3 = US3_1(v83)
    let v85 : string = "6px"
    let v86 : US3 = US3_1(v85)
    let v87 : string = "3px"
    let v88 : US3 = US3_1(v87)
    let v89 : US3 = US3_1(v85)
    let v90 : US2 = US2_1(2)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v80, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v84, v86, v57, v88, v59, v60, v61, v62, v89, v64, v65, v66, v67, v90, v69)
and closure61 (v0 : Mut8) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (unit -> JS.Function) = v0.l1
    let v70 : JS.Function = v69 ()
    let struct (v71 : US3, v72 : US3, v73 : US3, v74 : US6, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US7, v82 : US8, v83 : US3, v84 : US3, v85 : US7, v86 : US9, v87 : US3, v88 : US3, v89 : US3, v90 : US10, v91 : US7, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US3, v98 : US11, v99 : US3, v100 : US3, v101 : US3, v102 : US11, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US12, v112 : US13, v113 : US12, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US11, v132 : US3, v133 : US3, v134 : US9, v135 : US9, v136 : US3, v137 : US2, v138 : US3) = method16()
    let v139 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l0
    let v140 : string = "-12px"
    let v141 : US3 = US3_1(v140)
    let v142 : US3 = US3_1(v140)
    let v143 : string = "0.6"
    let v144 : US3 = US3_1(v143)
    let struct (v145 : US3, v146 : US3, v147 : US3, v148 : US6, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US7, v156 : US8, v157 : US3, v158 : US3, v159 : US7, v160 : US9, v161 : US3, v162 : US3, v163 : US3, v164 : US10, v165 : US7, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US3, v171 : US3, v172 : US11, v173 : US3, v174 : US3, v175 : US3, v176 : US11, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US12, v186 : US13, v187 : US12, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US11, v206 : US3, v207 : US3, v208 : US9, v209 : US9, v210 : US3, v211 : US2, v212 : US3) = v139 struct (v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v141, v107, v142, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v144)
    let v213 : ((string * obj) []) = method17(v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212)
    let v214 : obj = createObj v213
    let v215 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l2
    let v216 : US6 = US6_1(v70)
    let v217 : US9 = US9_1(v214)
    let v218 : string = "14px"
    let v219 : US3 = US3_1(v218)
    let struct (v220 : US3, v221 : US3, v222 : US3, v223 : US6, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US7, v231 : US8, v232 : US3, v233 : US3, v234 : US7, v235 : US9, v236 : US3, v237 : US3, v238 : US3, v239 : US10, v240 : US7, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US3, v247 : US11, v248 : US3, v249 : US3, v250 : US3, v251 : US11, v252 : US3, v253 : US3, v254 : US3, v255 : US3, v256 : US3, v257 : US3, v258 : US3, v259 : US3, v260 : US12, v261 : US13, v262 : US12, v263 : US3, v264 : US3, v265 : US3, v266 : US3, v267 : US3, v268 : US3, v269 : US3, v270 : US3, v271 : US3, v272 : US3, v273 : US3, v274 : US3, v275 : US3, v276 : US3, v277 : US3, v278 : US3, v279 : US3, v280 : US11, v281 : US3, v282 : US3, v283 : US9, v284 : US9, v285 : US3, v286 : US2, v287 : US3) = v215 struct (v1, v2, v3, v216, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v217, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v219, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
    struct (v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v273, v274, v275, v276, v277, v278, v279, v280, v281, v282, v283, v284, v285, v286, v287)
and closure62 () () : (JSX.Element []) =
    [||]
and method31 (v0 : Mut8) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure61(v0)
    let v5 : (unit -> (JSX.Element [])) = closure62()
    method15(v3, v4, v5)
and closure60 () (v0 : Mut8) : JSX.Element =
    method31(v0)
and closure63 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and method32 (v0 : (Mut8 -> JSX.Element), v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)), v2 : (unit -> JS.Function)) : JSX.Element =
    let v3 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v4 : Mut8 = {l0 = v1; l1 = v2; l2 = v1} : Mut8
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v3, v5) |> unbox<JSX.Element>
    v9
and closure64 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure59 (v0 : (bool -> unit)) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (Mut8 -> JSX.Element) = closure60()
    let v70 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v71 : (unit -> JS.Function) = closure63()
    let v72 : JSX.Element = method32(v69, v70, v71)
    let v73 : string = "Refresh"
    let v74 : US3 = US3_1(v73)
    let v75 : string = "neutral"
    let v76 : US3 = US3_1(v75)
    let v77 : string = "20px"
    let v78 : US3 = US3_1(v77)
    let v79 : US11 = US11_1(v72)
    let v80 : (unit -> unit) = closure64(v0)
    let v81 : US13 = US13_1(v80)
    let v82 : string = "xs"
    let v83 : US3 = US3_1(v82)
    struct (v1, v2, v74, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v76, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v79, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v81, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v83, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
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
and closure71 (v0 : int32, v1 : Mut1) (v2 : Mut1) : unit =
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
and closure70 (v0 : int32, v1 : Mut1) (v2 : Mut1) : (Mut1 -> unit) =
    closure71(v0, v1)
and closure69 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : int32, v2 : Mut1) () : unit =
    let v3 : (Mut1 -> (Mut1 -> unit)) = closure70(v1, v2)
    v0 v3
    ()
and closure66 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : int32, v2 : Mut1) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v71 : US5, v72 : US2) = v2.l9, v2.l10
    let v76 : bool =
        match v72 with
        | US2_1(v74) -> (* Some *)
            let v75 : bool = v74 = v1
            v75
        | _ ->
            false
    let v79 : string =
        if v76 then
            let v77 : string = "Restore"
            v77
        else
            let v78 : string = "Maximize"
            v78
    let struct (v80 : US5, v81 : US2) = v2.l9, v2.l10
    let v85 : bool =
        match v81 with
        | US2_1(v83) -> (* Some *)
            let v84 : bool = v83 = v1
            v84
        | _ ->
            false
    let v88 : (unit -> JS.Function) =
        if v85 then
            closure67()
        else
            closure68()
    let v89 : (Mut8 -> JSX.Element) = closure60()
    let v90 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v91 : JSX.Element = method32(v89, v90, v88)
    let v92 : US3 = US3_1(v79)
    let v93 : string = "neutral"
    let v94 : US3 = US3_1(v93)
    let v95 : string = "20px"
    let v96 : US3 = US3_1(v95)
    let v97 : US11 = US11_1(v91)
    let v98 : (unit -> unit) = closure69(v0, v1, v2)
    let v99 : US13 = US13_1(v98)
    let v100 : string = "xs"
    let v101 : US3 = US3_1(v100)
    struct (v3, v4, v92, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v94, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v96, v29, v97, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v99, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v101, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure72 () () : (JSX.Element []) =
    [||]
and closure74 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure75 (v0 : (bool -> unit), v1 : Mut6, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) () : unit =
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
and closure73 (v0 : (bool -> unit), v1 : Mut6, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit), v3 : Mut1) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v72 : (Mut8 -> JSX.Element) = closure60()
    let v73 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v74 : (unit -> JS.Function) = closure74()
    let v75 : JSX.Element = method32(v72, v73, v74)
    let v76 : string = "Unload"
    let v77 : US3 = US3_1(v76)
    let v78 : string = "neutral"
    let v79 : US3 = US3_1(v78)
    let v80 : string = "20px"
    let v81 : US3 = US3_1(v80)
    let v82 : US11 = US11_1(v75)
    let v83 : (unit -> unit) = closure75(v0, v1, v2, v3)
    let v84 : US13 = US13_1(v83)
    let v85 : string = "xs"
    let v86 : US3 = US3_1(v85)
    struct (v4, v5, v77, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v79, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v81, v30, v82, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v84, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v86, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure76 () () : (JSX.Element []) =
    [||]
and closure58 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : int32, v2 : (bool -> unit), v3 : (bool -> unit), v4 : Mut6, v5 : Mut1) () : (JSX.Element []) =
    let v6 : string = "IconButton"
    let v7 : string = "@hope-ui/solid"
    let v8 : JS.Function = import v6 v7
    let v9 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure59(v3)
    let v10 : (unit -> (JSX.Element [])) = closure65()
    let v11 : JSX.Element = method15(v8, v9, v10)
    let v12 : JS.Function = import v6 v7
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure66(v0, v1, v5)
    let v14 : (unit -> (JSX.Element [])) = closure72()
    let v15 : JSX.Element = method15(v12, v13, v14)
    let v16 : JS.Function = import v6 v7
    let v17 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure73(v2, v4, v0, v5)
    let v18 : (unit -> (JSX.Element [])) = closure76()
    let v19 : JSX.Element = method15(v16, v17, v18)
    [|v11; v15; v19|]
and closure56 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : Mut6, v7 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v8 : string = "Stack"
    let v9 : string = "@hope-ui/solid"
    let v10 : JS.Function = import v8 v9
    let v11 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure57(v1, v2)
    let v12 : (unit -> (JSX.Element [])) = closure58(v0, v2, v3, v4, v6, v1)
    let v13 : JSX.Element = method15(v10, v11, v12)
    let v14 : bool = v5 ()
    let v17 : JSX.Element =
        if v14 then
            let v15 : JSX.Element = Html.fragment []
            v15
        else
            let v16 : JSX.Element = v7 |> unbox<JSX.Element>
            v16
    [|v13; v17|]
and closure54 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3, v68 : ((Mut1 -> (Mut1 -> unit)) -> unit), v69 : Mut1, v70 : int32, v71 : (bool -> unit), v72 : (bool -> unit), v73 : (unit -> bool), v74 : Mut6) () : (JSX.Element []) =
    let v83 : JSX.Element =
        match v11 with
        | US8_0 -> (* None *)
            let v75 : JSX.Element = Html.fragment []
            v75
        | US8_1(v76) -> (* Some *)
            let v77 : string = "Box"
            let v78 : string = "@hope-ui/solid"
            let v79 : JS.Function = import v77 v78
            let v80 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure55(v69)
            let v81 : (unit -> (JSX.Element [])) = closure56(v68, v69, v70, v71, v72, v73, v74, v76)
            method15(v79, v80, v81)
    [|v83|]
and closure44 (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3, v68 : ((Mut1 -> (Mut1 -> unit)) -> unit), v69 : Mut1, v70 : int32, v71 : (bool -> unit), v72 : (unit -> bool), v73 : (bool -> unit), v74 : (unit -> bool), v75 : Mut6) () : (JSX.Element []) =
    let v76 : bool = v72 ()
    let v77 : bool = v76 = false
    let v90 : JSX.Element =
        if v77 then
            let v78 : string = "Box"
            let v79 : string = "@hope-ui/solid"
            let v80 : JS.Function = import v78 v79
            let v81 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure45()
            let v82 : (unit -> (JSX.Element [])) = closure46(v71, v75, v68, v69)
            method15(v80, v81, v82)
        else
            let v84 : string = "Box"
            let v85 : string = "@hope-ui/solid"
            let v86 : JS.Function = import v84 v85
            let v87 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure53(v69, v70)
            let v88 : (unit -> (JSX.Element [])) = closure54(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v73, v74, v75)
            method15(v86, v87, v88)
    [|v90|]
and method25 (v0 : Mut6) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l4
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method16()
    let struct (v70 : US3, v71 : US3, v72 : US3, v73 : US6, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US7, v81 : US8, v82 : US3, v83 : US3, v84 : US7, v85 : US9, v86 : US3, v87 : US3, v88 : US3, v89 : US10, v90 : US7, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US11, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US12, v111 : US13, v112 : US12, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US11, v131 : US3, v132 : US3, v133 : US9, v134 : US9, v135 : US3, v136 : US2, v137 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let struct (v138 : Mut1, v139 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v140 : int32 = Random().Next ()
    let v141 : bool = v0.l0
    let struct (v142 : (unit -> bool), v143 : (bool -> unit)) = method22(v141)
    let v144 : bool = false
    let struct (v145 : (unit -> bool), v146 : (bool -> unit)) = method22(v144)
    let v147 : (unit -> unit) = closure38(v0, v139, v140)
    method26(v147)
    let v148 : (unit -> unit) = closure41(v146, v145)
    method26(v148)
    let v149 : (unit -> unit) = closure42(v0, v139, v138)
    method11(v149)
    let v150 : bool = v0.l0
    let v151 : bool = v150 = true
    if v151 then
        let v152 : US14 = v0.l2
        match v152 with
        | US14_0 -> (* None *)
            ()
        | US14_1(v153) -> (* Some *)
            let v154 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v153 v138
            v154 v139
            ()
    let v155 : string = "Box"
    let v156 : string = "@hope-ui/solid"
    let v157 : JS.Function = import v155 v156
    let v158 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure43(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
    let v159 : (unit -> (JSX.Element [])) = closure44(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v139, v138, v140, v143, v142, v146, v145, v0)
    method15(v157, v158, v159)
and closure37 () (v0 : Mut6) : JSX.Element =
    method25(v0)
and closure77 (v0 : (unit -> (JSX.Element []))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : US8 = US8_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v69, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and method33 (v0 : (Mut6 -> JSX.Element), v1 : bool, v2 : bool, v3 : US14, v4 : US14, v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))) : JSX.Element =
    let v6 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v7 : Mut6 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5} : Mut6
    let v8 : obj = v7
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v6, v8) |> unbox<JSX.Element>
    v12
and closure36 (v0 : Mut4, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US15 = v0.l3
    let v25 : JSX.Element =
        match v3 with
        | US15_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : US14 = v0.l0
                let v6 : US14 = v0.l1
                let v7 : (Mut6 -> JSX.Element) = closure37()
                let v8 : bool = true
                let v9 : bool = false
                let v10 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure77(v2)
                method33(v7, v8, v9, v5, v6, v10)
            else
                let v12 : JSX.Element = Html.fragment []
                v12
        | US15_1 -> (* CheckEnabled *)
            let v14 : bool = v1 ()
            if v14 then
                let v15 : US14 = v0.l0
                let v16 : US14 = v0.l1
                let v17 : (Mut6 -> JSX.Element) = closure37()
                let v18 : bool = true
                let v19 : bool = false
                let v20 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure77(v2)
                method33(v17, v18, v19, v15, v16, v20)
            else
                let v22 : JSX.Element = Html.fragment []
                v22
        | US15_2 -> (* CheckHidden *)
            let v24 : JSX.Element = v2 |> unbox<JSX.Element>
            v24
    [|v25|]
and closure22 (v0 : Mut4, v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3, v69 : (bool -> unit), v70 : (unit -> bool)) () : (JSX.Element []) =
    let v79 : JSX.Element =
        match v61 with
        | US11_0 -> (* None *)
            let v71 : JSX.Element = Html.fragment []
            v71
        | US11_1(v72) -> (* Some *)
            let v73 : string = "Td"
            let v74 : string = "@hope-ui/solid"
            let v75 : JS.Function = import v73 v74
            let v76 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure23(v0, v70)
            let v77 : (unit -> (JSX.Element [])) = closure24(v0, v69, v70, v72)
            method15(v75, v76, v77)
    let v93 : JSX.Element =
        match v12 with
        | US8_0 -> (* None *)
            let v80 : string = "Td"
            let v81 : string = "@hope-ui/solid"
            let v82 : JS.Function = import v80 v81
            let v83 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure33()
            let v84 : (unit -> (JSX.Element [])) = closure34()
            method15(v82, v83, v84)
        | US8_1(v86) -> (* Some *)
            let v87 : string = "Td"
            let v88 : string = "@hope-ui/solid"
            let v89 : JS.Function = import v87 v88
            let v90 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure35(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
            let v91 : (unit -> (JSX.Element [])) = closure36(v0, v70, v86)
            method15(v89, v90, v91)
    [|v79; v93|]
and method21 (v0 : Mut4) : JSX.Element =
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = v0.l2
    let struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) = method16()
    let struct (v70 : US3, v71 : US3, v72 : US3, v73 : US6, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US7, v81 : US8, v82 : US3, v83 : US3, v84 : US7, v85 : US9, v86 : US3, v87 : US3, v88 : US3, v89 : US10, v90 : US7, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US3, v97 : US11, v98 : US3, v99 : US3, v100 : US3, v101 : US11, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US12, v111 : US13, v112 : US12, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US11, v131 : US3, v132 : US3, v133 : US9, v134 : US9, v135 : US3, v136 : US2, v137 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v138 : US15 = v0.l3
    let v140 : bool =
        match v138 with
        | US15_0 -> (* CheckDisabled *)
            true
        | _ ->
            false
    let v141 : bool = v140 <> true
    let struct (v142 : (unit -> bool), v143 : (bool -> unit)) = method22(v141)
    let v144 : string = "Tr"
    let v145 : string = "@hope-ui/solid"
    let v146 : JS.Function = import v144 v145
    let v147 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure21(v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
    let v148 : (unit -> (JSX.Element [])) = closure22(v0, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v143, v142)
    method15(v146, v147, v148)
and closure20 () (v0 : Mut4) : JSX.Element =
    method21(v0)
and closure84 (v0 : Mut3) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : US3 = v0.l37
    let v70 : US3 = v0.l52
    let v71 : US9 = v0.l63
    let v72 : US12 = v0.l40
    let v73 : string = "xs"
    let v74 : US3 = US3_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v69, v39, v40, v72, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v70, v54, v55, v74, v57, v58, v59, v60, v61, v62, v63, v71, v65, v66, v67, v68)
and closure87 (v0 : obj) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : US9 = US9_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v69, v65, v66, v67, v68)
and closure88 (v0 : obj) () : (JSX.Element []) =
    let v1 : string = v0.ToString ()
    let v2 : JSX.Element = Html.fragment [ v1 |> unbox<JSX.Element> ]
    [|v2|]
and closure86 () (v0 : obj) : (JSX.Element []) =
    let v1 : string = "SimpleOption"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure87(v0)
    let v5 : (unit -> (JSX.Element [])) = closure88(v0)
    let v6 : JSX.Element = method15(v3, v4, v5)
    [|v6|]
and closure89 (v0 : (obj [])) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (obj []) = v0 |> unbox<obj[]>
    let v70 : US10 = US10_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v70, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and method35 (v0 : (obj []), v1 : (obj -> (JSX.Element []))) : JSX.Element =
    let v2 : string = "For"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (unit -> (JSX.Element [])) = v1 |> unbox
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure89(v0)
    method15(v4, v6, v5)
and closure85 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : US10 = v0.l19
    let v2 : (obj []) = [||]
    let v4 : (obj []) =
        match v1 with
        | US10_0 -> (* None *)
            v2
        | US10_1(v3) -> (* Some *)
            v3
    let v5 : (obj -> (JSX.Element [])) = closure86()
    let v6 : JSX.Element = method35(v4, v5)
    [|v6|]
and method34 (v0 : Mut3) : JSX.Element =
    let v1 : string = "SimpleSelect"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure84(v0)
    let v5 : (unit -> (JSX.Element [])) = closure85(v0)
    method15(v3, v4, v5)
and closure83 () (v0 : Mut3) : JSX.Element =
    method34(v0)
and closure93 (v0 : obj) (v1 : Mut1) : unit =
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
and closure92 (v0 : obj) (v1 : Mut1) : (Mut1 -> unit) =
    closure93(v0)
and closure91 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) (v1 : obj) : unit =
    let v2 : (Mut1 -> (Mut1 -> unit)) = closure92(v1)
    v0 v2
    ()
and closure90 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : US5 = US5_0
    let v71 : US5 = US5_2
    let v72 : US5 = US5_3
    let v73 : US5 = US5_1
    let v74 : (US5 []) = [|v70; v71; v72; v73|]
    let v75 : int32 = v74.Length
    let v76 : (string []) = Array.zeroCreate<string> (v75)
    let v77 : Mut7 = {l0 = 0} : Mut7
    while method29(v75, v77) do
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
    let v89 : Mut7 = {l0 = 0} : Mut7
    while method29(v87, v89) do
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
    let v103 : US10 = US10_1(v88)
    let v104 : string = "2px"
    let v105 : US3 = US3_1(v104)
    let v106 : (obj -> unit) = closure91(v0)
    let v107 : US12 = US12_1(v106)
    let v108 : US9 = US9_1(v102)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v103, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v105, v40, v41, v107, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v108, v66, v67, v68, v69)
and closure94 () () : (JSX.Element []) =
    [||]
and closure82 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure83()
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure90(v0, v1)
    let v4 : (unit -> (JSX.Element [])) = closure94()
    let v5 : JSX.Element = method30(v2, v3, v4)
    [|v5|]
and closure81 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : string = "Log Level"
    let v71 : JSX.Element = Html.fragment [ v70 |> unbox<JSX.Element> ]
    let v72 : (unit -> (JSX.Element [])) = closure82(v0, v1)
    let v73 : US8 = US8_1(v72)
    let v74 : US11 = US11_1(v71)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v73, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v74, v63, v64, v65, v66, v67, v68, v69)
and method36 (v0 : (Mut4 -> JSX.Element), v1 : US14, v2 : US14, v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)), v4 : US15) : JSX.Element =
    let v5 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v6 : Mut4 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut4
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v5, v7) |> unbox<JSX.Element>
    v11
and closure97 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "8px"
    let v69 : US3 = US3_1(v68)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v69, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure98 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = emitJsExpr v0 "JSON.stringify($0, null, 2)"
    let v2 : JSX.Element = Html.fragment [ v1 |> unbox<JSX.Element> ]
    [|v2|]
and closure96 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure97()
    let v6 : (unit -> (JSX.Element [])) = closure98(v0)
    let v7 : JSX.Element = method15(v4, v5, v6)
    [|v7|]
and closure95 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : string = "State"
    let v70 : JSX.Element = Html.fragment [ v69 |> unbox<JSX.Element> ]
    let v71 : (unit -> (JSX.Element [])) = closure96(v0)
    let v72 : US8 = US8_1(v71)
    let v73 : US11 = US11_1(v70)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v73, v62, v63, v64, v65, v66, v67, v68)
and closure80 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let v2 : (Mut4 -> JSX.Element) = closure20()
    let v3 : US14 = US14_0
    let v4 : US14 = US14_0
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure81(v0, v1)
    let v6 : US15 = US15_2
    let v7 : JSX.Element = method36(v2, v3, v4, v5, v6)
    let v8 : US14 = US14_0
    let v9 : US14 = US14_0
    let v10 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure95(v1)
    let v11 : US15 = US15_2
    let v12 : JSX.Element = method36(v2, v8, v9, v10, v11)
    [|v7; v12|]
and closure79 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure13()
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v4 : (unit -> (JSX.Element [])) = closure80(v0, v1)
    let v5 : JSX.Element = method30(v2, v3, v4)
    [|v5|]
and closure78 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : string = "Debug"
    let v71 : JSX.Element = Html.fragment [ v70 |> unbox<JSX.Element> ]
    let v72 : (unit -> (JSX.Element [])) = closure79(v0, v1)
    let v73 : US8 = US8_1(v72)
    let v74 : US11 = US11_1(v71)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v73, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v74, v63, v64, v65, v66, v67, v68, v69)
and closure19 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let v2 : (Mut4 -> JSX.Element) = closure20()
    let v3 : US14 = US14_0
    let v4 : US14 = US14_0
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure78(v0, v1)
    let v6 : US15 = US15_0
    let v7 : JSX.Element = method36(v2, v3, v4, v5, v6)
    [|v7|]
and closure12 (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit), v1 : Mut1) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure13()
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v4 : (unit -> (JSX.Element [])) = closure19(v0, v1)
    let v5 : JSX.Element = method30(v2, v3, v4)
    [|v5|]
and method13 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure11(v0)
    let v6 : (unit -> (JSX.Element [])) = closure12(v1, v0)
    method15(v4, v5, v6)
and closure10 () (v0 : Mut2) : JSX.Element =
    method13()
and method37 (v0 : (Mut2 -> JSX.Element)) : JSX.Element =
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : Mut2 = Mut2()
    let v3 : obj = v2
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : JSX.Element = v6.Invoke (v1, v3) |> unbox<JSX.Element>
    v7
and closure99 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "flex"
    let v69 : US3 = US3_1(v68)
    let v70 : string = "1"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "column"
    let v73 : US3 = US3_1(v72)
    let v74 : string = "hidden"
    let v75 : US3 = US3_1(v74)
    let v76 : string = "auto"
    let v77 : US3 = US3_1(v76)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v69, v19, v20, v71, v73, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v75, v77, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure109 (v0 : Mut3) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : US3, v70 : US3, v71 : US3, v72 : US6, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US7, v80 : US8, v81 : US3, v82 : US3, v83 : US7, v84 : US9, v85 : US3, v86 : US3, v87 : US3, v88 : US10, v89 : US7, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US11, v97 : US3, v98 : US3, v99 : US3, v100 : US11, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US12, v110 : US13, v111 : US12, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US11, v130 : US3, v131 : US3, v132 : US9, v133 : US9, v134 : US3, v135 : US2, v136 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67
    let v137 : Mut3 = {l0 = v69; l1 = v70; l2 = v71; l3 = v72; l4 = v73; l5 = v74; l6 = v75; l7 = v76; l8 = v77; l9 = v78; l10 = v79; l11 = v80; l12 = v81; l13 = v82; l14 = v83; l15 = v84; l16 = v85; l17 = v86; l18 = v87; l19 = v88; l20 = v89; l21 = v90; l22 = v91; l23 = v92; l24 = v93; l25 = v94; l26 = v95; l27 = v96; l28 = v97; l29 = v98; l30 = v99; l31 = v100; l32 = v101; l33 = v102; l34 = v103; l35 = v104; l36 = v105; l37 = v106; l38 = v107; l39 = v108; l40 = v109; l41 = v110; l42 = v111; l43 = v112; l44 = v113; l45 = v114; l46 = v115; l47 = v116; l48 = v117; l49 = v118; l50 = v119; l51 = v120; l52 = v121; l53 = v122; l54 = v123; l55 = v124; l56 = v125; l57 = v126; l58 = v127; l59 = v128; l60 = v129; l61 = v130; l62 = v131; l63 = v132; l64 = v133; l65 = v134; l66 = v135; l67 = v136} : Mut3
    let v138 : US7 = US7_1(true)
    let v139 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v138; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68} : Mut3
    method28(v139, v137)
    let struct (v140 : US3, v141 : US3, v142 : US3, v143 : US6, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US7, v151 : US8, v152 : US3, v153 : US3, v154 : US7, v155 : US9, v156 : US3, v157 : US3, v158 : US3, v159 : US10, v160 : US7, v161 : US3, v162 : US3, v163 : US3, v164 : US3, v165 : US3, v166 : US3, v167 : US11, v168 : US3, v169 : US3, v170 : US3, v171 : US11, v172 : US3, v173 : US3, v174 : US3, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US12, v181 : US13, v182 : US12, v183 : US3, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US11, v201 : US3, v202 : US3, v203 : US9, v204 : US9, v205 : US3, v206 : US2, v207 : US3) = v139.l0, v139.l1, v139.l2, v139.l3, v139.l4, v139.l5, v139.l6, v139.l7, v139.l8, v139.l9, v139.l10, v139.l11, v139.l12, v139.l13, v139.l14, v139.l15, v139.l16, v139.l17, v139.l18, v139.l19, v139.l20, v139.l21, v139.l22, v139.l23, v139.l24, v139.l25, v139.l26, v139.l27, v139.l28, v139.l29, v139.l30, v139.l31, v139.l32, v139.l33, v139.l34, v139.l35, v139.l36, v139.l37, v139.l38, v139.l39, v139.l40, v139.l41, v139.l42, v139.l43, v139.l44, v139.l45, v139.l46, v139.l47, v139.l48, v139.l49, v139.l50, v139.l51, v139.l52, v139.l53, v139.l54, v139.l55, v139.l56, v139.l57, v139.l58, v139.l59, v139.l60, v139.l61, v139.l62, v139.l63, v139.l64, v139.l65, v139.l66, v139.l67
    struct (v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207)
and closure110 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : US3 = v0.l26
    let v4 : string =
        match v1 with
        | US3_0 -> (* None *)
            let v2 : string = ""
            v2
        | US3_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = Html.fragment [ v4 |> unbox<JSX.Element> ]
    [|v5|]
and closure111 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    let v69 : string = "-13px"
    let v70 : US3 = US3_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v70, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure112 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and method40 (v0 : (Mut8 -> JSX.Element), v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)), v2 : (unit -> JS.Function), v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3))) : JSX.Element =
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v5 : Mut8 = {l0 = v1; l1 = v2; l2 = v3} : Mut8
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v4, v6) |> unbox<JSX.Element>
    v10
and closure108 (v0 : Mut3) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure109(v0)
    let v5 : (unit -> (JSX.Element [])) = closure110(v0)
    let v6 : JSX.Element = method15(v3, v4, v5)
    let v7 : string = "&nbsp;"
    let v8 : JSX.Element = Html.fragment [ v7 |> unbox<JSX.Element> ]
    let v9 : (Mut8 -> JSX.Element) = closure60()
    let v10 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure111()
    let v11 : (unit -> JS.Function) = closure112()
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v13 : JSX.Element = method40(v9, v10, v11, v12)
    [|v6; v8; v13|]
and method39 (v0 : Mut3) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v5 : (unit -> (JSX.Element [])) = closure108(v0)
    method15(v3, v4, v5)
and closure107 () (v0 : Mut3) : JSX.Element =
    method39(v0)
and closure113 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v69 : US3 = US3_1(v68)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v69, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure114 () () : (JSX.Element []) =
    [||]
and closure106 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure107()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure113()
    let v2 : (unit -> (JSX.Element [])) = closure114()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure105 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : (unit -> (JSX.Element [])) = closure106()
    let v69 : US8 = US8_1(v68)
    let v70 : string = "1px 6px"
    let v71 : US3 = US3_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure117 (v0 : string) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : US3 = US3_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v69, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure116 (v0 : string) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure107()
    let v2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure117(v0)
    let v3 : (unit -> (JSX.Element [])) = closure114()
    let v4 : JSX.Element = method30(v1, v2, v3)
    [|v4|]
and closure115 (v0 : string) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (unit -> (JSX.Element [])) = closure116(v0)
    let v70 : US8 = US8_1(v69)
    let v71 : string = "1px 6px"
    let v72 : US3 = US3_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v70, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v72, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure120 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v69 : US3 = US3_1(v68)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v69, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure119 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure107()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure120()
    let v2 : (unit -> (JSX.Element [])) = closure114()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure118 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : (unit -> (JSX.Element [])) = closure119()
    let v69 : US8 = US8_1(v68)
    let v70 : string = "1px 6px"
    let v71 : US3 = US3_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure123 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v69 : US3 = US3_1(v68)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v69, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure122 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure107()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure123()
    let v2 : (unit -> (JSX.Element [])) = closure114()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure121 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : (unit -> (JSX.Element [])) = closure122()
    let v69 : US8 = US8_1(v68)
    let v70 : string = "1px 6px"
    let v71 : US3 = US3_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v71, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure104 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v15 : JSX.Element =
        if v1 then
            let v2 : (Mut4 -> JSX.Element) = closure20()
            let v3 : US14 = US14_0
            let v4 : US14 = US14_0
            let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure105()
            let v6 : US15 = US15_2
            method36(v2, v3, v4, v5, v6)
        else
            let v8 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let v9 : (Mut4 -> JSX.Element) = closure20()
            let v10 : US14 = US14_0
            let v11 : US14 = US14_0
            let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure115(v8)
            let v13 : US15 = US15_2
            method36(v9, v10, v11, v12, v13)
    let v16 : (Mut4 -> JSX.Element) = closure20()
    let v17 : US14 = US14_0
    let v18 : US14 = US14_0
    let v19 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure118()
    let v20 : US15 = US15_2
    let v21 : JSX.Element = method36(v16, v17, v18, v19, v20)
    let v22 : US14 = US14_0
    let v23 : US14 = US14_0
    let v24 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure121()
    let v25 : US15 = US15_2
    let v26 : JSX.Element = method36(v16, v22, v23, v24, v25)
    [|v15; v21; v26|]
and method38 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method1()
    let v5 : (Mut3 -> JSX.Element) = closure13()
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v7 : (unit -> (JSX.Element [])) = closure104(v3)
    method30(v5, v6, v7)
and closure103 () (v0 : Mut3) : JSX.Element =
    method38()
and closure124 () () : (JSX.Element []) =
    [||]
and closure102 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure103()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure124()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure101 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Links"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure102()
    let v71 : US8 = US8_1(v70)
    let v72 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v72, v61, v62, v63, v64, v65, v66, v67)
and method42 () : struct ((unit -> string) * (unit -> unit)) =
    let v0 : string = "useColorMode"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : obj = v2.Invoke () |> unbox
    let v4 : (unit -> string) = v3?colorMode |> unbox
    let v5 : (unit -> unit) = v3?toggleColorMode |> unbox
    struct (v4, v5)
and closure132 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure131 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : string = v1 ()
    let v71 : US3 = US3_1(v70)
    let v72 : (obj -> unit) = closure132(v0)
    let v73 : US12 = US12_1(v72)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v71, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v73, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure134 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "row"
    let v69 : US3 = US3_1(v68)
    let v70 : string = "$4"
    let v71 : US3 = US3_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v69, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v71, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure136 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "dark"
    let v69 : obj = v68
    let v70 : string = "neutral"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "sm"
    let v73 : US3 = US3_1(v72)
    let v74 : US9 = US9_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v71, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v73, v56, v57, v58, v59, v60, v61, v62, v74, v64, v65, v66, v67)
and closure137 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure138 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "light"
    let v69 : obj = v68
    let v70 : string = "neutral"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "sm"
    let v73 : US3 = US3_1(v72)
    let v74 : US9 = US9_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v71, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v73, v56, v57, v58, v59, v60, v61, v62, v74, v64, v65, v66, v67)
and closure139 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure135 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure136()
    let v4 : (unit -> (JSX.Element [])) = closure137()
    let v5 : JSX.Element = method15(v2, v3, v4)
    let v6 : JS.Function = import v0 v1
    let v7 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure138()
    let v8 : (unit -> (JSX.Element [])) = closure139()
    let v9 : JSX.Element = method15(v6, v7, v8)
    [|v5; v9|]
and closure133 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure134()
    let v4 : (unit -> (JSX.Element [])) = closure135()
    let v5 : JSX.Element = method15(v2, v3, v4)
    [|v5|]
and closure130 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure131(v0, v1)
    let v6 : (unit -> (JSX.Element [])) = closure133()
    let v7 : JSX.Element = method15(v4, v5, v6)
    [|v7|]
and closure129 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US3, v3 : US3, v4 : US3, v5 : US6, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US7, v13 : US8, v14 : US3, v15 : US3, v16 : US7, v17 : US9, v18 : US3, v19 : US3, v20 : US3, v21 : US10, v22 : US7, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US11, v30 : US3, v31 : US3, v32 : US3, v33 : US11, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US12, v43 : US13, v44 : US12, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US11, v63 : US3, v64 : US3, v65 : US9, v66 : US9, v67 : US3, v68 : US2, v69 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v70 : string = "Theme"
    let v71 : JSX.Element = Html.fragment [ v70 |> unbox<JSX.Element> ]
    let v72 : (unit -> (JSX.Element [])) = closure130(v0, v1)
    let v73 : US8 = US8_1(v72)
    let v74 : string = "5px 6px"
    let v75 : US3 = US3_1(v74)
    let v76 : US11 = US11_1(v71)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v73, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v75, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v76, v63, v64, v65, v66, v67, v68, v69)
and closure128 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut4 -> JSX.Element) = closure20()
    let v3 : US14 = US14_0
    let v4 : US14 = US14_0
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure129(v0, v1)
    let v6 : US15 = US15_2
    let v7 : JSX.Element = method36(v2, v3, v4, v5, v6)
    [|v7|]
and method41 () : JSX.Element =
    let struct (v0 : (unit -> string), v1 : (unit -> unit)) = method42()
    let v2 : (Mut3 -> JSX.Element) = closure13()
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v4 : (unit -> (JSX.Element [])) = closure128(v1, v0)
    method30(v2, v3, v4)
and closure127 () (v0 : Mut3) : JSX.Element =
    method41()
and closure140 () () : (JSX.Element []) =
    [||]
and closure126 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure127()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure140()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure125 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Settings"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure126()
    let v71 : US8 = US8_1(v70)
    let v72 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v72, v61, v62, v63, v64, v65, v66, v67)
and closure155 (v0 : Mut9, v1 : string, v2 : Mut1) (v3 : Mut1) : unit =
    let v4 : (Mut1 -> (Mut1 -> (US3 -> unit))) = v0.l1
    let v5 : (Mut1 -> (US3 -> unit)) = v4 v2
    let v6 : (US3 -> unit) = v5 v3
    let v7 : US3 = US3_1(v1)
    v6 v7
    ()
and closure154 (v0 : Mut9, v1 : string) (v2 : Mut1) : (Mut1 -> unit) =
    closure155(v0, v1, v2)
and closure153 (v0 : Mut9, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) (v2 : obj) : unit =
    let v3 : string = v2?currentTarget?value
    let v4 : (Mut1 -> (Mut1 -> unit)) = closure154(v0, v3)
    v1 v4
    ()
and closure152 (v0 : Mut9, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit), v2 : Mut1) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : (Mut1 -> US3) = v0.l0
    let v72 : US3 = v71 v2
    let v73 : string = JS.undefined
    let v75 : string =
        match v72 with
        | US3_0 -> (* None *)
            v73
        | US3_1(v74) -> (* Some *)
            v74
    let v76 : obj = v75
    let v77 : (obj -> unit) = closure153(v0, v1)
    let v78 : US12 = US12_1(v77)
    let v79 : string = "xs"
    let v80 : US3 = US3_1(v79)
    let v81 : string = "text"
    let v82 : US3 = US3_1(v81)
    let v83 : US9 = US9_1(v76)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v78, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v80, v59, v60, v61, v62, v63, v64, v82, v83, v67, v68, v69, v70)
and closure156 () () : (JSX.Element []) =
    [||]
and method45 (v0 : Mut9) : JSX.Element =
    let struct (v1 : Mut1, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v3 : string = "Input"
    let v4 : string = "@hope-ui/solid"
    let v5 : JS.Function = import v3 v4
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure152(v0, v2, v1)
    let v7 : (unit -> (JSX.Element [])) = closure156()
    method15(v5, v6, v7)
and closure151 () (v0 : Mut9) : JSX.Element =
    method45(v0)
and closure157 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v3
and closure160 (v0 : Mut1) (v1 : US3) : unit =
    v0.l2 <- v1
    ()
and closure159 () (v0 : Mut1) : (US3 -> unit) =
    closure160(v0)
and closure158 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure159()
and method46 (v0 : (Mut9 -> JSX.Element), v1 : (Mut1 -> US3), v2 : (Mut1 -> (Mut1 -> (US3 -> unit)))) : JSX.Element =
    let v3 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v4 : Mut9 = {l0 = v1; l1 = v2} : Mut9
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v3, v5) |> unbox<JSX.Element>
    v9
and closure150 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure151()
    let v1 : (Mut1 -> US3) = closure157()
    let v2 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure158()
    let v3 : JSX.Element = method46(v0, v1, v2)
    [|v3|]
and closure149 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Token"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure150()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "3px"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v73, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure163 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v4
and closure166 (v0 : Mut1) (v1 : US3) : unit =
    v0.l3 <- v1
    ()
and closure165 () (v0 : Mut1) : (US3 -> unit) =
    closure166(v0)
and closure164 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure165()
and closure162 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure151()
    let v1 : (Mut1 -> US3) = closure163()
    let v2 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure164()
    let v3 : JSX.Element = method46(v0, v1, v2)
    [|v3|]
and closure161 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "URL"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure162()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "3px"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v73, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure173 (v0 : Mut10, v1 : int32, v2 : Mut1) (v3 : Mut1) : unit =
    let v4 : (Mut1 -> (Mut1 -> (US2 -> unit))) = v0.l1
    let v5 : (Mut1 -> (US2 -> unit)) = v4 v2
    let v6 : (US2 -> unit) = v5 v3
    let v7 : US2 = US2_1(v1)
    v6 v7
    ()
and closure172 (v0 : Mut10, v1 : int32) (v2 : Mut1) : (Mut1 -> unit) =
    closure173(v0, v1, v2)
and closure171 (v0 : Mut10, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) (v2 : obj) : unit =
    let v3 : int32 = v2?currentTarget?value
    let v4 : (Mut1 -> (Mut1 -> unit)) = closure172(v0, v3)
    v1 v4
    ()
and closure170 (v0 : Mut10, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit), v2 : Mut1) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : (Mut1 -> US2) = v0.l0
    let v72 : US2 = v71 v2
    let v73 : int32 = JS.undefined
    let v75 : int32 =
        match v72 with
        | US2_0 -> (* None *)
            v73
        | US2_1(v74) -> (* Some *)
            v74
    let v76 : obj = v75
    let v77 : (obj -> unit) = closure171(v0, v1)
    let v78 : US12 = US12_1(v77)
    let v79 : string = "xs"
    let v80 : US3 = US3_1(v79)
    let v81 : string = "text"
    let v82 : US3 = US3_1(v81)
    let v83 : US9 = US9_1(v76)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v78, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v80, v59, v60, v61, v62, v63, v64, v82, v83, v67, v68, v69, v70)
and method47 (v0 : Mut10) : JSX.Element =
    let struct (v1 : Mut1, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v3 : string = "Input"
    let v4 : string = "@hope-ui/solid"
    let v5 : JS.Function = import v3 v4
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure170(v0, v2, v1)
    let v7 : (unit -> (JSX.Element [])) = closure156()
    method15(v5, v6, v7)
and closure169 () (v0 : Mut10) : JSX.Element =
    method47(v0)
and closure174 () (v0 : Mut1) : US2 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v2
and closure177 (v0 : Mut1) (v1 : US2) : unit =
    v0.l1 <- v1
    ()
and closure176 () (v0 : Mut1) : (US2 -> unit) =
    closure177(v0)
and closure175 () (v0 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure176()
and method48 (v0 : (Mut10 -> JSX.Element), v1 : (Mut1 -> US2), v2 : (Mut1 -> (Mut1 -> (US2 -> unit)))) : JSX.Element =
    let v3 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v4 : Mut10 = {l0 = v1; l1 = v2} : Mut10
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v3, v5) |> unbox<JSX.Element>
    v9
and closure168 () () : (JSX.Element []) =
    let v0 : (Mut10 -> JSX.Element) = closure169()
    let v1 : (Mut1 -> US2) = closure174()
    let v2 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure175()
    let v3 : JSX.Element = method48(v0, v1, v2)
    [|v3|]
and closure167 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Port"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure168()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "3px"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v73, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure148 () () : (JSX.Element []) =
    let v0 : (Mut4 -> JSX.Element) = closure20()
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure149()
    let v4 : US15 = US15_2
    let v5 : JSX.Element = method36(v0, v1, v2, v3, v4)
    let v6 : US14 = US14_0
    let v7 : US14 = US14_0
    let v8 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure161()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method36(v0, v6, v7, v8, v9)
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure167()
    let v14 : US15 = US15_2
    let v15 : JSX.Element = method36(v0, v11, v12, v13, v14)
    [|v5; v10; v15|]
and method44 () : JSX.Element =
    let v0 : (Mut3 -> JSX.Element) = closure13()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure148()
    method30(v0, v1, v2)
and closure147 () (v0 : Mut3) : JSX.Element =
    method44()
and closure178 () () : (JSX.Element []) =
    [||]
and closure146 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure147()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure178()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure145 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Connection"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure146()
    let v71 : US8 = US8_1(v70)
    let v72 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v72, v61, v62, v63, v64, v65, v66, v67)
and closure189 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v1)
and closure192 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut7 = {l0 = 0} : Mut7
    while method29(v11, v13) do
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
and closure191 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure192(v0, v1, v2, v3, v4, v5)
and closure190 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure191(v0, v1, v2, v3, v4)
and closure188 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut9 -> JSX.Element) = closure151()
    let v5 : (Mut1 -> US3) = closure189(v0, v1, v2, v3)
    let v6 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure190(v0, v1, v2, v3)
    let v7 : JSX.Element = method46(v4, v5, v6)
    [|v7|]
and closure187 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v72 : string = "Address"
    let v73 : JSX.Element = Html.fragment [ v72 |> unbox<JSX.Element> ]
    let v74 : (unit -> (JSX.Element [])) = closure188(v0, v1, v2, v3)
    let v75 : US8 = US8_1(v74)
    let v76 : string = "3px"
    let v77 : US3 = US3_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v75, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v78, v65, v66, v67, v68, v69, v70, v71)
and closure195 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v3)
and closure198 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut7 = {l0 = 0} : Mut7
    while method29(v11, v13) do
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
and closure197 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure198(v0, v1, v2, v3, v4, v5)
and closure196 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure197(v0, v1, v2, v3, v4)
and closure194 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut9 -> JSX.Element) = closure151()
    let v5 : (Mut1 -> US3) = closure195(v0, v1, v2, v3)
    let v6 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure196(v0, v1, v2, v3)
    let v7 : JSX.Element = method46(v4, v5, v6)
    [|v7|]
and closure193 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v72 : string = "Private Key"
    let v73 : JSX.Element = Html.fragment [ v72 |> unbox<JSX.Element> ]
    let v74 : (unit -> (JSX.Element [])) = closure194(v0, v1, v2, v3)
    let v75 : US8 = US8_1(v74)
    let v76 : string = "3px"
    let v77 : US3 = US3_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v75, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v78, v65, v66, v67, v68, v69, v70, v71)
and closure186 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut4 -> JSX.Element) = closure20()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure187(v0, v1, v2, v3)
    let v8 : US15 = US15_2
    let v9 : JSX.Element = method36(v4, v5, v6, v7, v8)
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure193(v0, v1, v2, v3)
    let v13 : US15 = US15_2
    let v14 : JSX.Element = method36(v4, v10, v11, v12, v13)
    [|v9; v14|]
and closure185 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut3 -> JSX.Element) = closure13()
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v6 : (unit -> (JSX.Element [])) = closure186(v0, v1, v2, v3)
    let v7 : JSX.Element = method30(v4, v5, v6)
    [|v7|]
and closure184 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US3, v7 : US6, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US7, v15 : US8, v16 : US3, v17 : US3, v18 : US7, v19 : US9, v20 : US3, v21 : US3, v22 : US3, v23 : US10, v24 : US7, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US11, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US12, v45 : US13, v46 : US12, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US3, v66 : US3, v67 : US9, v68 : US9, v69 : US3, v70 : US2, v71 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
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
    let v78 : JSX.Element = Html.fragment [ v77 |> unbox<JSX.Element> ]
    let v79 : (unit -> (JSX.Element [])) = closure185(v0, v1, v2, v3)
    let v80 : US8 = US8_1(v79)
    let v81 : US11 = US11_1(v78)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v80, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v81, v65, v66, v67, v68, v69, v70, v71)
and closure183 () struct (v0 : US0, v1 : string, v2 : string, v3 : string) : (JSX.Element []) =
    let v4 : (Mut4 -> JSX.Element) = closure20()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure184(v0, v1, v2, v3)
    let v8 : US15 = US15_2
    let v9 : JSX.Element = method36(v4, v5, v6, v7, v8)
    [|v9|]
and closure199 (v0 : (struct (US0 * string * string * string) [])) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (obj []) = v0 |> unbox<obj[]>
    let v70 : US10 = US10_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v70, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and method50 (v0 : (struct (US0 * string * string * string) []), v1 : (struct (US0 * string * string * string) -> (JSX.Element []))) : JSX.Element =
    let v2 : string = "For"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (unit -> (JSX.Element [])) = v1 |> unbox
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure199(v0)
    method15(v4, v6, v5)
and closure182 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    let v5 : (struct (US0 * string * string * string) -> (JSX.Element [])) = closure183()
    let v6 : JSX.Element = method50(v1, v5)
    [|v6|]
and method49 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : (Mut3 -> JSX.Element) = closure13()
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v4 : (unit -> (JSX.Element [])) = closure182(v0)
    method30(v2, v3, v4)
and closure181 () (v0 : Mut3) : JSX.Element =
    method49()
and closure200 () () : (JSX.Element []) =
    [||]
and closure180 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure181()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure200()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure179 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Accounts"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure180()
    let v71 : US8 = US8_1(v70)
    let v72 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v72, v61, v62, v63, v64, v65, v66, v67)
and closure203 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "algorand testnet bank"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : string = "#aaa"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "1"
    let v73 : US3 = US3_1(v72)
    let v74 : string = "350px"
    let v75 : US3 = US3_1(v74)
    let v76 : string = "https://bank.testnet.algorand.network"
    let v77 : US3 = US3_1(v76)
    let v78 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v71, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v73, v22, v23, v24, v75, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v77, v58, v59, v78, v61, v62, v63, v64, v65, v66, v67)
and closure204 () () : (JSX.Element []) =
    [||]
and closure202 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure203()
    let v5 : (unit -> (JSX.Element [])) = closure204()
    let v6 : JSX.Element = method15(v3, v4, v5)
    [|v6|]
and closure201 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Testnet Bank Dispenser"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure202()
    let v71 : US8 = US8_1(v70)
    let v72 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v72, v61, v62, v63, v64, v65, v66, v67)
and closure144 () () : (JSX.Element []) =
    let v0 : (Mut4 -> JSX.Element) = closure20()
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure145()
    let v4 : US15 = US15_2
    let v5 : JSX.Element = method36(v0, v1, v2, v3, v4)
    let v6 : US14 = US14_0
    let v7 : US14 = US14_0
    let v8 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure179()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method36(v0, v6, v7, v8, v9)
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure201()
    let v14 : US15 = US15_0
    let v15 : JSX.Element = method36(v0, v11, v12, v13, v14)
    [|v5; v10; v15|]
and method43 () : JSX.Element =
    let v0 : (Mut3 -> JSX.Element) = closure13()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure144()
    method30(v0, v1, v2)
and closure143 () (v0 : Mut3) : JSX.Element =
    method43()
and closure205 () () : (JSX.Element []) =
    [||]
and closure142 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure143()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure205()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure141 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Chain"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure142()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "db"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v73, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure213 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_1
    let v5 : US4 = US4_1
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method29(v9, v11) do
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
and closure212 () (v0 : Mut1) : (Mut1 -> unit) =
    closure213(v0)
and closure211 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure212()
    v0 v1
    ()
and closure210 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure211()
and method52 (v0 : int32, v1 : Mut11) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure217 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method52(v4, v6) do
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
    while method29(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure216 () (v0 : Mut1) : (Mut1 -> unit) =
    closure217(v0)
and closure215 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure216()
    v0 v1
    ()
and closure214 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure215()
and method55 (v0 : int32, v1 : Mut14) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure225 (v0 : Mut13) (v1 : Mut1) : US3 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US3 = US3_0
    let v6 : Mut14 = {l0 = 0; l1 = v5} : Mut14
    while method55(v4, v6) do
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
and closure228 (v0 : Mut13, v1 : Mut1, v2 : Mut1) (v3 : US3) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v6 : int32 = v4.Length
    let v7 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v6)
    let v8 : Mut7 = {l0 = 0} : Mut7
    while method29(v6, v8) do
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
and closure227 (v0 : Mut13, v1 : Mut1) (v2 : Mut1) : (US3 -> unit) =
    closure228(v0, v1, v2)
and closure226 (v0 : Mut13) (v1 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure227(v0, v1)
and method54 (v0 : Mut13) : JSX.Element =
    let v1 : (Mut9 -> JSX.Element) = closure151()
    let v2 : (Mut1 -> US3) = closure225(v0)
    let v3 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure226(v0)
    method46(v1, v2, v3)
and closure224 () (v0 : Mut13) : JSX.Element =
    method54(v0)
and closure229 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US3 =
    US3_1(v2)
and closure231 (v0 : Mut12, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US3) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v9 : string =
        match v5 with
        | US3_0 -> (* None *)
            let v7 : string = ""
            v7
        | US3_1(v8) -> (* Some *)
            v8
    struct (v6, v2, v9, v4)
and closure230 (v0 : Mut12) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US3 -> struct (US4 * int32 * string * string)) =
    closure231(v0, v1, v2, v3, v4)
and method56 (v0 : (Mut13 -> JSX.Element), v1 : US4, v2 : (struct (US4 * int32 * string * string) -> US3), v3 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string)))) : JSX.Element =
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v5 : Mut13 = {l0 = v1; l1 = v2; l2 = v3} : Mut13
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v4, v6) |> unbox<JSX.Element>
    v10
and closure223 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (Mut13 -> JSX.Element) = closure224()
    let v3 : (struct (US4 * int32 * string * string) -> US3) = closure229()
    let v4 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string))) = closure230(v0)
    let v5 : JSX.Element = method56(v2, v1, v3, v4)
    [|v5|]
and closure222 (v0 : Mut12) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : string = "URL"
    let v70 : JSX.Element = Html.fragment [ v69 |> unbox<JSX.Element> ]
    let v71 : (unit -> (JSX.Element [])) = closure223(v0)
    let v72 : US8 = US8_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v74, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v75, v62, v63, v64, v65, v66, v67, v68)
and method58 (v0 : int32, v1 : Mut16) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure235 (v0 : Mut15) (v1 : Mut1) : US2 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US2 = US2_0
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method58(v4, v6) do
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
and closure238 (v0 : Mut15, v1 : Mut1, v2 : Mut1) (v3 : US2) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v6 : int32 = v4.Length
    let v7 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v6)
    let v8 : Mut7 = {l0 = 0} : Mut7
    while method29(v6, v8) do
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
and closure237 (v0 : Mut15, v1 : Mut1) (v2 : Mut1) : (US2 -> unit) =
    closure238(v0, v1, v2)
and closure236 (v0 : Mut15) (v1 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure237(v0, v1)
and method57 (v0 : Mut15) : JSX.Element =
    let v1 : (Mut10 -> JSX.Element) = closure169()
    let v2 : (Mut1 -> US2) = closure235(v0)
    let v3 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure236(v0)
    method48(v1, v2, v3)
and closure234 () (v0 : Mut15) : JSX.Element =
    method57(v0)
and closure239 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US2 =
    US2_1(v1)
and closure241 (v0 : Mut12, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US2) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v8 : int32 =
        match v5 with
        | US2_0 -> (* None *)
            0
        | US2_1(v7) -> (* Some *)
            v7
    struct (v6, v8, v3, v4)
and closure240 (v0 : Mut12) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US2 -> struct (US4 * int32 * string * string)) =
    closure241(v0, v1, v2, v3, v4)
and method59 (v0 : (Mut15 -> JSX.Element), v1 : US4, v2 : (struct (US4 * int32 * string * string) -> US2), v3 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string)))) : JSX.Element =
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v5 : Mut15 = {l0 = v1; l1 = v2; l2 = v3} : Mut15
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v4, v6) |> unbox<JSX.Element>
    v10
and closure233 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (Mut15 -> JSX.Element) = closure234()
    let v3 : (struct (US4 * int32 * string * string) -> US2) = closure239()
    let v4 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string))) = closure240(v0)
    let v5 : JSX.Element = method59(v2, v1, v3, v4)
    [|v5|]
and closure232 (v0 : Mut12) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : string = "Port"
    let v70 : JSX.Element = Html.fragment [ v69 |> unbox<JSX.Element> ]
    let v71 : (unit -> (JSX.Element [])) = closure233(v0)
    let v72 : US8 = US8_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US11 = US11_1(v70)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v74, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v75, v62, v63, v64, v65, v66, v67, v68)
and closure221 (v0 : Mut12) () : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure20()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure222(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method36(v1, v2, v3, v4, v5)
    let v7 : US14 = US14_0
    let v8 : US14 = US14_0
    let v9 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure232(v0)
    let v10 : US15 = US15_2
    let v11 : JSX.Element = method36(v1, v7, v8, v9, v10)
    [|v6; v11|]
and method53 (v0 : Mut12) : JSX.Element =
    let v1 : (Mut3 -> JSX.Element) = closure13()
    let v2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v3 : (unit -> (JSX.Element [])) = closure221(v0)
    method30(v1, v2, v3)
and closure220 () (v0 : Mut12) : JSX.Element =
    method53(v0)
and method60 (v0 : (Mut12 -> JSX.Element), v1 : US4) : JSX.Element =
    let v2 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v3 : Mut12 = {l0 = v1} : Mut12
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v2, v4) |> unbox<JSX.Element>
    v8
and closure219 () () : (JSX.Element []) =
    let v0 : (Mut12 -> JSX.Element) = closure220()
    let v1 : US4 = US4_1
    let v2 : JSX.Element = method60(v0, v1)
    [|v2|]
and closure218 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Rust -{'>'} Rust"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure219()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "db-gun-rs-rs"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v73, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure245 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_1
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method29(v9, v11) do
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
and closure244 () (v0 : Mut1) : (Mut1 -> unit) =
    closure245(v0)
and closure243 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure244()
    v0 v1
    ()
and closure242 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure243()
and closure249 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method52(v4, v6) do
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
    while method29(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure248 () (v0 : Mut1) : (Mut1 -> unit) =
    closure249(v0)
and closure247 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure248()
    v0 v1
    ()
and closure246 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure247()
and closure251 () () : (JSX.Element []) =
    let v0 : (Mut12 -> JSX.Element) = closure220()
    let v1 : US4 = US4_0
    let v2 : JSX.Element = method60(v0, v1)
    [|v2|]
and closure250 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Rust -{'>'} JavaScript"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure251()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "db-gun-rs-js"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v73, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure255 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method29(v9, v11) do
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
and closure254 () (v0 : Mut1) : (Mut1 -> unit) =
    closure255(v0)
and closure253 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure254()
    v0 v1
    ()
and closure252 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure253()
and closure259 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method52(v4, v6) do
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
    while method29(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure258 () (v0 : Mut1) : (Mut1 -> unit) =
    closure259(v0)
and closure257 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure258()
    v0 v1
    ()
and closure256 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure257()
and closure260 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "JavaScript -{'>'} JavaScript"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure251()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "db-gun-js-js"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v73, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure264 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_1
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut7 = {l0 = 0} : Mut7
    while method29(v9, v11) do
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
and closure263 () (v0 : Mut1) : (Mut1 -> unit) =
    closure264(v0)
and closure262 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure263()
    v0 v1
    ()
and closure261 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure262()
and closure268 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : int32 = v3.Length
    let v5 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v4)
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method52(v4, v6) do
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
    while method29(v21, v23) do
        let v25 : int32 = v23.l0
        let struct (v26 : US4, v27 : US4) = v5.[int v25]
        v22.[int v25] <- struct (v26, v27)
        let v28 : int32 = v25 + 1
        v23.l0 <- v28
        ()
    v1.l5 <- v22
    ()
and closure267 () (v0 : Mut1) : (Mut1 -> unit) =
    closure268(v0)
and closure266 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure267()
    v0 v1
    ()
and closure265 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure266()
and closure269 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "JavaScript -{'>'} Rust"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure219()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "db-gun-js-rs"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v73, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure209 () () : (JSX.Element []) =
    let v0 : (Mut4 -> JSX.Element) = closure20()
    let v1 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure210()
    let v2 : US14 = US14_1(v1)
    let v3 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure214()
    let v4 : US14 = US14_1(v3)
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure218()
    let v6 : US15 = US15_0
    let v7 : JSX.Element = method36(v0, v2, v4, v5, v6)
    let v8 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure242()
    let v9 : US14 = US14_1(v8)
    let v10 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure246()
    let v11 : US14 = US14_1(v10)
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure250()
    let v13 : US15 = US15_0
    let v14 : JSX.Element = method36(v0, v9, v11, v12, v13)
    let v15 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure252()
    let v16 : US14 = US14_1(v15)
    let v17 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure256()
    let v18 : US14 = US14_1(v17)
    let v19 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure260()
    let v20 : US15 = US15_0
    let v21 : JSX.Element = method36(v0, v16, v18, v19, v20)
    let v22 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure261()
    let v23 : US14 = US14_1(v22)
    let v24 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure265()
    let v25 : US14 = US14_1(v24)
    let v26 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure269()
    let v27 : US15 = US15_0
    let v28 : JSX.Element = method36(v0, v23, v25, v26, v27)
    [|v7; v14; v21; v28|]
and method51 () : JSX.Element =
    let v0 : (Mut3 -> JSX.Element) = closure13()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure209()
    method30(v0, v1, v2)
and closure208 () (v0 : Mut3) : JSX.Element =
    method51()
and closure270 () () : (JSX.Element []) =
    [||]
and closure207 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure208()
    let v1 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v2 : (unit -> (JSX.Element [])) = closure270()
    let v3 : JSX.Element = method30(v0, v1, v2)
    [|v3|]
and closure206 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "Database"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure207()
    let v71 : US8 = US8_1(v70)
    let v72 : string = "db"
    let v73 : US3 = US3_1(v72)
    let v74 : US11 = US11_1(v69)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v73, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v74, v61, v62, v63, v64, v65, v66, v67)
and closure277 (v0 : Mut1) (v1 : (struct (int32 * int32) [])) : unit =
    v0.l8 <- v1
    ()
and closure276 (v0 : Mut1) (v1 : Mut1) : ((struct (int32 * int32) []) -> unit) =
    closure277(v0)
and closure275 () (v0 : Mut1) : (Mut1 -> ((struct (int32 * int32) []) -> unit)) =
    closure276(v0)
and closure278 (v0 : Mut1) (v1 : obj) : int32 =
    let struct (v2 : (struct (int32 * obj) []), v3 : (struct (int32 * obj) []), v4 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v5 : int32 = v4.Length
    let v6 : Mut11 = {l0 = 0; l1 = 0} : Mut11
    while method52(v5, v6) do
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
and closure279 (v0 : Mut1) () : bool =
    let struct (v1 : US5, v2 : US2) = v0.l9, v0.l10
    match v1 with
    | US5_0 -> (* Debug *)
        true
    | _ ->
        false
and closure280 () () : (obj []) =
    [||]
and closure281 (v0 : string, v1 : ((obj []) -> unit)) () : unit =
    let v2 : string = ">> use_fetch request()"
    let v3 : obj = v2
    let v4 : string = "content_address:"
    let v5 : obj = struct (v4, v0)
    let v6 : (obj []) = [|v3; v5|]
    v1 v6
    ()
and closure282 (v0 : string, v1 : ((obj []) -> unit)) () : unit =
    let v2 : string = ">> use_fetch clear()"
    let v3 : obj = v2
    let v4 : string = "content_address:"
    let v5 : obj = struct (v4, v0)
    let v6 : (obj []) = [|v3; v5|]
    v1 v6
    ()
and method62 (v0 : string) : struct ((unit -> unit) * (unit -> unit)) =
    let struct (v1 : Mut1, v2 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v3 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v4 : int32 = v3.Length
    let v5 : Mut11 = {l0 = 0; l1 = 100000} : Mut11
    while method52(v4, v5) do
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
    let v17 : (unit -> bool) = closure279(v1)
    let v18 : (unit -> (obj [])) = closure280()
    let v19 : ((obj []) -> unit) = method9(v17, v18, v16)
    let v20 : string = "> use_fetch ()"
    let v21 : obj = v20
    let v22 : (obj []) = [|v21|]
    v19 v22
    let v23 : (unit -> unit) = closure281(v0, v19)
    let v24 : (unit -> unit) = closure282(v0, v19)
    struct (v23, v24)
and closure284 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "row"
    let v69 : string = "column"
    let v70 : string = method23(v69, v68)
    let v71 : string = "0"
    let v72 : string = "8px"
    let v73 : string = method23(v72, v71)
    let v74 : string = "start"
    let v75 : US3 = US3_1(v74)
    let v76 : US3 = US3_1(v70)
    let v77 : US3 = US3_1(v73)
    let v78 : string = "3px"
    let v79 : US3 = US3_1(v78)
    let v80 : string = "7px"
    let v81 : US3 = US3_1(v80)
    struct (v75, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v76, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v77, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v79, v48, v49, v50, v51, v52, v53, v54, v55, v81, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure286 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure287 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure289 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure290 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure288 (v0 : (unit -> unit)) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (Mut8 -> JSX.Element) = closure60()
    let v70 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure289()
    let v71 : (unit -> JS.Function) = closure290()
    let v72 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v73 : JSX.Element = method40(v69, v70, v71, v72)
    let v74 : US11 = US11_1(v73)
    let v75 : US13 = US13_1(v0)
    let v76 : string = "10px"
    let v77 : US3 = US3_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v74, v33, v34, v35, v36, v37, v38, v39, v40, v41, v75, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure291 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure293 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure294 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure292 (v0 : (unit -> unit)) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (Mut8 -> JSX.Element) = closure60()
    let v70 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure293()
    let v71 : (unit -> JS.Function) = closure294()
    let v72 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v73 : JSX.Element = method40(v69, v70, v71, v72)
    let v74 : US11 = US11_1(v73)
    let v75 : US13 = US13_1(v0)
    let v76 : string = "10px"
    let v77 : US3 = US3_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v74, v33, v34, v35, v36, v37, v38, v39, v40, v41, v75, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure295 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure285 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure286()
    let v6 : (unit -> (JSX.Element [])) = closure287()
    let v7 : JSX.Element = method15(v4, v5, v6)
    let v8 : (Mut3 -> JSX.Element) = closure47()
    let v9 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure288(v1)
    let v10 : (unit -> (JSX.Element [])) = closure291()
    let v11 : JSX.Element = method30(v8, v9, v10)
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure292(v0)
    let v13 : (unit -> (JSX.Element [])) = closure295()
    let v14 : JSX.Element = method30(v8, v12, v13)
    [|v7; v11; v14|]
and method63 (v0 : int32, v1 : Mut17) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method64 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method64(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method66 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method66(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method67 (v0 : (struct (int32 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method67(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method65 (v0 : UH1) : (struct (int32 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method66(v0, v1)
    let v3 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method67(v3, v0, v4)
    v3
and closure301 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure300 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v6 : (unit -> (JSX.Element [])) = closure301(v0)
    let v7 : JSX.Element = method15(v4, v5, v6)
    [|v7|]
and closure299 (v0 : (unit -> struct (int32 * int32))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : int32, v70 : int32) = v0 ()
    let v71 : string = v69.ToString ()
    let v72 : JSX.Element = Html.fragment [ v71 |> unbox<JSX.Element> ]
    let v73 : (unit -> (JSX.Element [])) = closure300(v0)
    let v74 : US8 = US8_1(v73)
    let v75 : string = "3px"
    let v76 : US3 = US3_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v74, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v76, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v77, v62, v63, v64, v65, v66, v67, v68)
and closure298 () (v0 : (unit -> struct (int32 * int32))) : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure20()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure299(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method36(v1, v2, v3, v4, v5)
    [|v6|]
and closure302 (v0 : (struct (int32 * int32) [])) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (obj []) = v0 |> unbox<obj[]>
    let v70 : US10 = US10_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v70, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and method68 (v0 : (struct (int32 * int32) []), v1 : ((unit -> struct (int32 * int32)) -> (JSX.Element []))) : JSX.Element =
    let v2 : string = "Index"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (unit -> (JSX.Element [])) = v1 |> unbox
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure302(v0)
    method15(v4, v6, v5)
and closure297 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v3.Length
    let v5 : UH1 = UH1_1
    let v6 : Mut17 = {l0 = 0; l1 = v5} : Mut17
    while method63(v4, v6) do
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
    let v19 : UH1 = method64(v17, v18)
    let v20 : (struct (int32 * int32) []) = method65(v19)
    let v21 : ((unit -> struct (int32 * int32)) -> (JSX.Element [])) = closure298()
    let v22 : JSX.Element = method68(v20, v21)
    [|v22|]
and closure296 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure13()
    let v2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v3 : (unit -> (JSX.Element [])) = closure297(v0)
    let v4 : JSX.Element = method30(v1, v2, v3)
    [|v4|]
and closure283 (v0 : Mut1, v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let v74 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure284()
    let v75 : (unit -> (JSX.Element [])) = closure285(v1, v2)
    let v76 : JSX.Element = method15(v73, v74, v75)
    let v77 : (unit -> (JSX.Element [])) = closure296(v0)
    let v78 : US8 = US8_1(v77)
    let v79 : string = "counter"
    let v80 : US3 = US3_1(v79)
    let v81 : US11 = US11_1(v76)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v78, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v80, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v81, v64, v65, v66, v67, v68, v69, v70)
and method61 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "profile/tmp/counter"
    let struct (v3 : (struct (int32 * obj) []), v4 : (struct (int32 * obj) []), v5 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v6 : (Mut1 -> (Mut1 -> ((struct (int32 * int32) []) -> unit))) = closure275()
    let v7 : (obj -> int32) = closure278(v0)
    let struct (v8 : (unit -> unit), v9 : (unit -> unit)) = method62(v2)
    let v10 : (Mut4 -> JSX.Element) = closure20()
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure283(v0, v9, v8)
    let v14 : US15 = US15_2
    method36(v10, v11, v12, v13, v14)
and closure274 () (v0 : Mut3) : JSX.Element =
    method61()
and closure303 () () : (JSX.Element []) =
    [||]
and closure307 (v0 : Mut1) (v1 : (struct (int32 * obj) [])) : unit =
    v0.l7 <- v1
    ()
and closure306 (v0 : Mut1) (v1 : Mut1) : ((struct (int32 * obj) []) -> unit) =
    closure307(v0)
and closure305 () (v0 : Mut1) : (Mut1 -> ((struct (int32 * obj) []) -> unit)) =
    closure306(v0)
and closure308 () (v0 : obj) : obj =
    let v1 : obj = "status"
    v1
and closure310 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "row"
    let v69 : string = "column"
    let v70 : string = method23(v69, v68)
    let v71 : string = "0"
    let v72 : string = "8px"
    let v73 : string = method23(v72, v71)
    let v74 : string = "start"
    let v75 : US3 = US3_1(v74)
    let v76 : US3 = US3_1(v70)
    let v77 : US3 = US3_1(v73)
    let v78 : string = "3px"
    let v79 : US3 = US3_1(v78)
    let v80 : string = "7px"
    let v81 : US3 = US3_1(v80)
    struct (v75, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v76, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v77, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v79, v48, v49, v50, v51, v52, v53, v54, v55, v81, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure312 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure314 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure313 (v0 : (unit -> unit)) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (Mut8 -> JSX.Element) = closure60()
    let v70 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure314()
    let v71 : (unit -> JS.Function) = closure290()
    let v72 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v73 : JSX.Element = method40(v69, v70, v71, v72)
    let v74 : US11 = US11_1(v73)
    let v75 : US13 = US13_1(v0)
    let v76 : string = "10px"
    let v77 : US3 = US3_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v74, v33, v34, v35, v36, v37, v38, v39, v40, v41, v75, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure315 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure317 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure316 (v0 : (unit -> unit)) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (Mut8 -> JSX.Element) = closure60()
    let v70 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure317()
    let v71 : (unit -> JS.Function) = closure294()
    let v72 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v73 : JSX.Element = method40(v69, v70, v71, v72)
    let v74 : US11 = US11_1(v73)
    let v75 : US13 = US13_1(v0)
    let v76 : string = "10px"
    let v77 : US3 = US3_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v74, v33, v34, v35, v36, v37, v38, v39, v40, v41, v75, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure318 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure311 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v6 : (unit -> (JSX.Element [])) = closure312()
    let v7 : JSX.Element = method15(v4, v5, v6)
    let v8 : (Mut3 -> JSX.Element) = closure47()
    let v9 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure313(v1)
    let v10 : (unit -> (JSX.Element [])) = closure315()
    let v11 : JSX.Element = method30(v8, v9, v10)
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure316(v0)
    let v13 : (unit -> (JSX.Element [])) = closure318()
    let v14 : JSX.Element = method30(v8, v12, v13)
    [|v7; v11; v14|]
and method70 (v0 : int32, v1 : Mut18) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method71 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method71(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method73 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method73(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method74 (v0 : (struct (int32 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method74(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method72 (v0 : UH2) : (struct (int32 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method73(v0, v1)
    let v3 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method74(v3, v0, v4)
    v3
and closure324 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure323 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v6 : (unit -> (JSX.Element [])) = closure324(v0)
    let v7 : JSX.Element = method15(v4, v5, v6)
    [|v7|]
and closure322 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : int32, v70 : obj) = v0 ()
    let v71 : string = v69.ToString ()
    let v72 : JSX.Element = Html.fragment [ v71 |> unbox<JSX.Element> ]
    let v73 : (unit -> (JSX.Element [])) = closure323(v0)
    let v74 : US8 = US8_1(v73)
    let v75 : string = "3px"
    let v76 : US3 = US3_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v74, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v76, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v77, v62, v63, v64, v65, v66, v67, v68)
and closure321 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure20()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure322(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method36(v1, v2, v3, v4, v5)
    [|v6|]
and closure325 (v0 : (struct (int32 * obj) [])) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (obj []) = v0 |> unbox<obj[]>
    let v70 : US10 = US10_1(v69)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v70, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and method75 (v0 : (struct (int32 * obj) []), v1 : ((unit -> struct (int32 * obj)) -> (JSX.Element []))) : JSX.Element =
    let v2 : string = "Index"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (unit -> (JSX.Element [])) = v1 |> unbox
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure325(v0)
    method15(v4, v6, v5)
and closure320 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v2.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut18 = {l0 = 0; l1 = v5} : Mut18
    while method70(v4, v6) do
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
    let v19 : UH2 = method71(v17, v18)
    let v20 : (struct (int32 * obj) []) = method72(v19)
    let v21 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure321()
    let v22 : JSX.Element = method75(v20, v21)
    [|v22|]
and closure319 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure13()
    let v2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v3 : (unit -> (JSX.Element [])) = closure320(v0)
    let v4 : JSX.Element = method30(v1, v2, v3)
    [|v4|]
and closure309 (v0 : Mut1, v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let v74 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure310()
    let v75 : (unit -> (JSX.Element [])) = closure311(v1, v2)
    let v76 : JSX.Element = method15(v73, v74, v75)
    let v77 : (unit -> (JSX.Element [])) = closure319(v0)
    let v78 : US8 = US8_1(v77)
    let v79 : string = "status"
    let v80 : US3 = US3_1(v79)
    let v81 : US11 = US11_1(v76)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v78, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v80, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v81, v64, v65, v66, v67, v68, v69, v70)
and method69 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "profile/tmp/chain_status"
    let struct (v3 : (struct (int32 * obj) []), v4 : (struct (int32 * obj) []), v5 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v6 : (Mut1 -> (Mut1 -> ((struct (int32 * obj) []) -> unit))) = closure305()
    let v7 : (obj -> obj) = closure308()
    let struct (v8 : (unit -> unit), v9 : (unit -> unit)) = method62(v2)
    let v10 : (Mut4 -> JSX.Element) = closure20()
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure309(v0, v9, v8)
    let v14 : US15 = US15_2
    method36(v10, v11, v12, v13, v14)
and closure304 () (v0 : Mut3) : JSX.Element =
    method69()
and closure326 () () : (JSX.Element []) =
    [||]
and closure330 (v0 : Mut1) (v1 : (struct (int32 * obj) [])) : unit =
    v0.l6 <- v1
    ()
and closure329 (v0 : Mut1) (v1 : Mut1) : ((struct (int32 * obj) []) -> unit) =
    closure330(v0)
and closure328 () (v0 : Mut1) : (Mut1 -> ((struct (int32 * obj) []) -> unit)) =
    closure329(v0)
and closure331 () (v0 : obj) : obj =
    let v1 : obj = ()
    v1
and closure333 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : string = "row"
    let v69 : string = "column"
    let v70 : string = method23(v69, v68)
    let v71 : string = "0"
    let v72 : string = "8px"
    let v73 : string = method23(v72, v71)
    let v74 : string = "start"
    let v75 : US3 = US3_1(v74)
    let v76 : US3 = US3_1(v70)
    let v77 : US3 = US3_1(v73)
    let v78 : string = "3px"
    let v79 : US3 = US3_1(v78)
    let v80 : string = "7px"
    let v81 : US3 = US3_1(v80)
    struct (v75, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v76, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v77, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v79, v48, v49, v50, v51, v52, v53, v54, v55, v81, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure335 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure337 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure336 (v0 : (unit -> unit)) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (Mut8 -> JSX.Element) = closure60()
    let v70 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure337()
    let v71 : (unit -> JS.Function) = closure290()
    let v72 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v73 : JSX.Element = method40(v69, v70, v71, v72)
    let v74 : US11 = US11_1(v73)
    let v75 : US13 = US13_1(v0)
    let v76 : string = "10px"
    let v77 : US3 = US3_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v74, v33, v34, v35, v36, v37, v38, v39, v40, v41, v75, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure338 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure340 () struct (v0 : US3, v1 : US3, v2 : US3, v3 : US6, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US7, v11 : US8, v12 : US3, v13 : US3, v14 : US7, v15 : US9, v16 : US3, v17 : US3, v18 : US3, v19 : US10, v20 : US7, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US11, v28 : US3, v29 : US3, v30 : US3, v31 : US11, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US12, v41 : US13, v42 : US12, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US11, v61 : US3, v62 : US3, v63 : US9, v64 : US9, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v68 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v68, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
and closure339 (v0 : (unit -> unit)) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v69 : (Mut8 -> JSX.Element) = closure60()
    let v70 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure340()
    let v71 : (unit -> JS.Function) = closure294()
    let v72 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v73 : JSX.Element = method40(v69, v70, v71, v72)
    let v74 : US11 = US11_1(v73)
    let v75 : US13 = US13_1(v0)
    let v76 : string = "10px"
    let v77 : US3 = US3_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v74, v33, v34, v35, v36, v37, v38, v39, v40, v41, v75, v43, v44, v45, v46, v47, v48, v49, v50, v77, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68)
and closure341 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure334 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v6 : (unit -> (JSX.Element [])) = closure335()
    let v7 : JSX.Element = method15(v4, v5, v6)
    let v8 : (Mut3 -> JSX.Element) = closure47()
    let v9 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure336(v1)
    let v10 : (unit -> (JSX.Element [])) = closure338()
    let v11 : JSX.Element = method30(v8, v9, v10)
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure339(v0)
    let v13 : (unit -> (JSX.Element [])) = closure341()
    let v14 : JSX.Element = method30(v8, v12, v13)
    [|v7; v11; v14|]
and closure347 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure346 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v6 : (unit -> (JSX.Element [])) = closure347(v0)
    let v7 : JSX.Element = method15(v4, v5, v6)
    [|v7|]
and closure345 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US3, v4 : US6, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US7, v12 : US8, v13 : US3, v14 : US3, v15 : US7, v16 : US9, v17 : US3, v18 : US3, v19 : US3, v20 : US10, v21 : US7, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US11, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US12, v42 : US13, v43 : US12, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US11, v62 : US3, v63 : US3, v64 : US9, v65 : US9, v66 : US3, v67 : US2, v68 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let struct (v69 : int32, v70 : obj) = v0 ()
    let v71 : string = v69.ToString ()
    let v72 : JSX.Element = Html.fragment [ v71 |> unbox<JSX.Element> ]
    let v73 : (unit -> (JSX.Element [])) = closure346(v0)
    let v74 : US8 = US8_1(v73)
    let v75 : string = "3px"
    let v76 : US3 = US3_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v74, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v76, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v77, v62, v63, v64, v65, v66, v67, v68)
and closure344 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure20()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure345(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method36(v1, v2, v3, v4, v5)
    [|v6|]
and closure343 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v1.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut18 = {l0 = 0; l1 = v5} : Mut18
    while method70(v4, v6) do
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
    let v19 : UH2 = method71(v17, v18)
    let v20 : (struct (int32 * obj) []) = method72(v19)
    let v21 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure344()
    let v22 : JSX.Element = method75(v20, v21)
    [|v22|]
and closure342 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure13()
    let v2 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v3 : (unit -> (JSX.Element [])) = closure343(v0)
    let v4 : JSX.Element = method30(v1, v2, v3)
    [|v4|]
and closure332 (v0 : Mut1, v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US3, v4 : US3, v5 : US3, v6 : US6, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US7, v14 : US8, v15 : US3, v16 : US3, v17 : US7, v18 : US9, v19 : US3, v20 : US3, v21 : US3, v22 : US10, v23 : US7, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US11, v31 : US3, v32 : US3, v33 : US3, v34 : US11, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US12, v44 : US13, v45 : US12, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US11, v64 : US3, v65 : US3, v66 : US9, v67 : US9, v68 : US3, v69 : US2, v70 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let v74 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure333()
    let v75 : (unit -> (JSX.Element [])) = closure334(v1, v2)
    let v76 : JSX.Element = method15(v73, v74, v75)
    let v77 : (unit -> (JSX.Element [])) = closure342(v0)
    let v78 : US8 = US8_1(v77)
    let v79 : string = "deploy"
    let v80 : US3 = US3_1(v79)
    let v81 : US11 = US11_1(v76)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v78, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v80, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v81, v64, v65, v66, v67, v68, v69, v70)
and method76 () : JSX.Element =
    let struct (v0 : Mut1, v1 : ((Mut1 -> (Mut1 -> unit)) -> unit)) = method8()
    let v2 : string = "profile/tmp/chain_deploy"
    let struct (v3 : (struct (int32 * obj) []), v4 : (struct (int32 * obj) []), v5 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v6 : (Mut1 -> (Mut1 -> ((struct (int32 * obj) []) -> unit))) = closure328()
    let v7 : (obj -> obj) = closure331()
    let struct (v8 : (unit -> unit), v9 : (unit -> unit)) = method62(v2)
    let v10 : (Mut4 -> JSX.Element) = closure20()
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure332(v0, v9, v8)
    let v14 : US15 = US15_2
    method36(v10, v11, v12, v13, v14)
and closure327 () (v0 : Mut3) : JSX.Element =
    method76()
and closure348 () () : (JSX.Element []) =
    [||]
and closure273 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure274()
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v7 : (unit -> (JSX.Element [])) = closure303()
    let v8 : JSX.Element = method30(v5, v6, v7)
    let v10 : bool = v2 = ""
    let v11 : bool = v10 <> true
    let v16 : JSX.Element =
        if v11 then
            let v12 : (Mut3 -> JSX.Element) = closure304()
            let v13 : (unit -> (JSX.Element [])) = closure326()
            method30(v12, v6, v13)
        else
            let v15 : JSX.Element = Html.fragment []
            v15
    let v22 : JSX.Element =
        if v11 then
            let v18 : (Mut3 -> JSX.Element) = closure327()
            let v19 : (unit -> (JSX.Element [])) = closure348()
            method30(v18, v6, v19)
        else
            let v21 : JSX.Element = Html.fragment []
            v21
    [|v8; v16; v22|]
and closure272 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure13()
    let v6 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v7 : (unit -> (JSX.Element [])) = closure273(v0, v1, v2, v3, v4)
    let v8 : JSX.Element = method30(v5, v6, v7)
    [|v8|]
and closure271 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US3, v6 : US3, v7 : US3, v8 : US6, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US7, v16 : US8, v17 : US3, v18 : US3, v19 : US7, v20 : US9, v21 : US3, v22 : US3, v23 : US3, v24 : US10, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US11, v33 : US3, v34 : US3, v35 : US3, v36 : US11, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US12, v46 : US13, v47 : US12, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US11, v66 : US3, v67 : US3, v68 : US9, v69 : US9, v70 : US3, v71 : US2, v72 : US3) : struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) =
    let v73 : string = "Profile"
    let v74 : JSX.Element = Html.fragment [ v73 |> unbox<JSX.Element> ]
    let v75 : (unit -> (JSX.Element [])) = closure272(v0, v1, v2, v3, v4)
    let v76 : US8 = US8_1(v75)
    let v77 : US11 = US11_1(v74)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v76, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v77, v66, v67, v68, v69, v70, v71, v72)
and closure100 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut4 -> JSX.Element) = closure20()
    let v6 : US14 = US14_0
    let v7 : US14 = US14_0
    let v8 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure101()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method36(v5, v6, v7, v8, v9)
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure18()
    let v14 : US15 = US15_2
    let v15 : JSX.Element = method36(v5, v11, v12, v13, v14)
    let v16 : US14 = US14_0
    let v17 : US14 = US14_0
    let v18 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure125()
    let v19 : US15 = US15_2
    let v20 : JSX.Element = method36(v5, v16, v17, v18, v19)
    let v21 : US14 = US14_0
    let v22 : US14 = US14_0
    let v23 : US15 = US15_2
    let v24 : JSX.Element = method36(v5, v21, v22, v13, v23)
    let v25 : US14 = US14_0
    let v26 : US14 = US14_0
    let v27 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure141()
    let v28 : US15 = US15_0
    let v29 : JSX.Element = method36(v5, v25, v26, v27, v28)
    let v30 : US14 = US14_0
    let v31 : US14 = US14_0
    let v32 : US15 = US15_2
    let v33 : JSX.Element = method36(v5, v30, v31, v13, v32)
    let v34 : US14 = US14_0
    let v35 : US14 = US14_0
    let v36 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure206()
    let v37 : US15 = US15_0
    let v38 : JSX.Element = method36(v5, v34, v35, v36, v37)
    let v39 : US14 = US14_0
    let v40 : US14 = US14_0
    let v41 : US15 = US15_2
    let v42 : JSX.Element = method36(v5, v39, v40, v13, v41)
    let v43 : US14 = US14_0
    let v44 : US14 = US14_0
    let v45 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure271(v0, v1, v2, v3, v4)
    let v46 : US15 = US15_2
    let v47 : JSX.Element = method36(v5, v43, v44, v45, v46)
    [|v10; v15; v20; v24; v29; v33; v38; v42; v47|]
and closure9 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v6 : bool = v2 = ""
    let v10 : JSX.Element =
        if v6 then
            let v7 : (Mut2 -> JSX.Element) = closure10()
            method37(v7)
        else
            let v9 : JSX.Element = Html.fragment []
            v9
    let v11 : (Mut3 -> JSX.Element) = closure13()
    let v12 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure99()
    let v13 : (unit -> (JSX.Element [])) = closure100(v0, v1, v2, v3, v4)
    let v14 : JSX.Element = method30(v11, v12, v13)
    [|v10; v14|]
and method12 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method1()
    let v5 : string = "Box"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3) -> struct (US3 * US3 * US3 * US6 * US3 * US3 * US3 * US3 * US3 * US3 * US7 * US8 * US3 * US3 * US7 * US9 * US3 * US3 * US3 * US10 * US7 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US12 * US13 * US12 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US3 * US3 * US9 * US9 * US3 * US2 * US3)) = closure8()
    let v9 : (unit -> (JSX.Element [])) = closure9(v0, v1, v2, v3, v4)
    method15(v7, v8, v9)
and closure7 () (v0 : Mut3) : JSX.Element =
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
let v94 : (Mut3 -> JSX.Element) = closure7()
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
