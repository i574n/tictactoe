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
and Mut1 = {mutable l0 : (struct (string * string * string * string) []); mutable l1 : US0; mutable l2 : US1; mutable l3 : US1; mutable l4 : (struct (US2 * int32 * string * string) []); mutable l5 : (struct (US2 * US2) []); mutable l6 : US1; mutable l7 : US0}
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
and Mut2 = {mutable l0 : US1; mutable l1 : US3; mutable l2 : US1; mutable l3 : US1; mutable l4 : US1; mutable l5 : US1; mutable l6 : US1; mutable l7 : US1; mutable l8 : US4; mutable l9 : US5; mutable l10 : US1; mutable l11 : US1; mutable l12 : US4; mutable l13 : US6; mutable l14 : US1; mutable l15 : US1; mutable l16 : US1; mutable l17 : US7; mutable l18 : US4; mutable l19 : US1; mutable l20 : US1; mutable l21 : US1; mutable l22 : US1; mutable l23 : US1; mutable l24 : US8; mutable l25 : US1; mutable l26 : US1; mutable l27 : US1; mutable l28 : US6; mutable l29 : US1; mutable l30 : US1; mutable l31 : US1; mutable l32 : US1; mutable l33 : US1; mutable l34 : US1; mutable l35 : US1; mutable l36 : US1; mutable l37 : US9; mutable l38 : US10; mutable l39 : US9; mutable l40 : US1; mutable l41 : US1; mutable l42 : US1; mutable l43 : US1; mutable l44 : US1; mutable l45 : US1; mutable l46 : US1; mutable l47 : US1; mutable l48 : US1; mutable l49 : US1; mutable l50 : US1; mutable l51 : US1; mutable l52 : US1; mutable l53 : US1; mutable l54 : US1; mutable l55 : US8; mutable l56 : US1; mutable l57 : US1; mutable l58 : US6; mutable l59 : US1; mutable l60 : US0; mutable l61 : US1}
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
and Mut6 = {mutable l0 : (Mut1 -> US1); mutable l1 : (Mut1 -> (Mut1 -> (US1 -> unit)))}
and Mut7 = {mutable l0 : (Mut1 -> US0); mutable l1 : (Mut1 -> (Mut1 -> (US0 -> unit)))}
and Mut8 = {mutable l0 : US2}
and Mut9 = {mutable l0 : US2; mutable l1 : (struct (US2 * int32 * string * string) -> US1); mutable l2 : (struct (US2 * int32 * string * string) -> (US1 -> struct (US2 * int32 * string * string)))}
and Mut10 = {mutable l0 : int32; mutable l1 : US1}
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : US2 * f1_1 : int32 * f1_2 : string * f1_3 : string
and Mut11 = {mutable l0 : int32; mutable l1 : US13}
and Mut12 = {mutable l0 : US2; mutable l1 : (struct (US2 * int32 * string * string) -> US0); mutable l2 : (struct (US2 * int32 * string * string) -> (US0 -> struct (US2 * int32 * string * string)))}
and Mut13 = {mutable l0 : int32; mutable l1 : US0}
let rec method0 () : struct ((struct (string * string * string * string) []) * US0 * US1 * US1 * (struct (US2 * int32 * string * string) []) * (struct (US2 * US2) []) * US1 * US0) =
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
    let v15 : US0 = US0_1(4001)
    let v16 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    let v17 : US1 = US1_1(v16)
    let v18 : string = "http://localhost"
    let v19 : US1 = US1_1(v18)
    let v20 : US1 = US1_0
    let v21 : US0 = US0_0
    struct (v12, v15, v17, v19, v14, v13, v20, v21)
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
and closure8 () () : (JSX.Element []) =
    [||]
and method5 () : struct (US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US6 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v0 : US1 = US1_0
    let v1 : US3 = US3_0
    let v2 : US1 = US1_0
    let v3 : US1 = US1_0
    let v4 : US1 = US1_0
    let v5 : US1 = US1_0
    let v6 : US1 = US1_0
    let v7 : US1 = US1_0
    let v8 : US4 = US4_0
    let v9 : US5 = US5_0
    let v10 : US1 = US1_0
    let v11 : US1 = US1_0
    let v12 : US4 = US4_0
    let v13 : US6 = US6_0
    let v14 : US1 = US1_0
    let v15 : US1 = US1_0
    let v16 : US1 = US1_0
    let v17 : US7 = US7_0
    let v18 : US4 = US4_0
    let v19 : US1 = US1_0
    let v20 : US1 = US1_0
    let v21 : US1 = US1_0
    let v22 : US1 = US1_0
    let v23 : US1 = US1_0
    let v24 : US8 = US8_0
    let v25 : US1 = US1_0
    let v26 : US1 = US1_0
    let v27 : US1 = US1_0
    let v28 : US6 = US6_0
    let v29 : US1 = US1_0
    let v30 : US1 = US1_0
    let v31 : US1 = US1_0
    let v32 : US1 = US1_0
    let v33 : US1 = US1_0
    let v34 : US1 = US1_0
    let v35 : US1 = US1_0
    let v36 : US1 = US1_0
    let v37 : US9 = US9_0
    let v38 : US10 = US10_0
    let v39 : US9 = US9_0
    let v40 : US1 = US1_0
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
    let v55 : US8 = US8_0
    let v56 : US1 = US1_0
    let v57 : US1 = US1_0
    let v58 : US6 = US6_0
    let v59 : US1 = US1_0
    let v60 : US0 = US0_0
    let v61 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61)
and method4 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "flex"
    let v64 : US1 = US1_1(v63)
    v62.l16 <- v64
    let v65 : string = "column"
    let v66 : US1 = US1_1(v65)
    v62.l20 <- v66
    let v67 : string = "$blackAlpha3"
    let v68 : US1 = US1_1(v67)
    v62.l2 <- v68
    let v69 : string = "-1px"
    let v70 : US1 = US1_1(v69)
    v62.l30 <- v70
    v62
and method6 (v0 : (unit -> (JSX.Element [])), v1 : Mut2) : Mut2 =
    let v2 : US5 = US5_1(v0)
    v1.l9 <- v2
    emitJsExpr (v1, v0) "$0.children = $1"
    v1
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
and method7 (v0 : Mut2) : ((string * obj) []) =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61
    let v66 : obj =
        match v1 with
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
            let v69 : string = "aria-label"
            let v70 : (string * obj) = v69, v66
            let v71 : UH0 = UH0_1
            UH0_0(v70, v71)
    let v77 : obj =
        match v2 with
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
            let v79 : string = "as"
            let v80 : (string * obj) = v79, v77
            UH0_0(v80, v73)
    let v86 : obj =
        match v3 with
        | US1_0 -> (* None *)
            let v83 : obj = ()
            v83
        | US1_1(v84) -> (* Some *)
            let v85 : obj = v84
            v85
    let v87 : bool = emitJsExpr v86 "!$0"
    let v91 : UH0 =
        if v87 then
            v82
        else
            let v88 : string = "backgroundColor"
            let v89 : (string * obj) = v88, v86
            UH0_0(v89, v82)
    let v95 : obj =
        match v4 with
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
            let v97 : string = "border"
            let v98 : (string * obj) = v97, v95
            UH0_0(v98, v91)
    let v104 : obj =
        match v5 with
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
            let v106 : string = "borderBottomWidth"
            let v107 : (string * obj) = v106, v104
            UH0_0(v107, v100)
    let v113 : obj =
        match v6 with
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
            let v115 : string = "borderColor"
            let v116 : (string * obj) = v115, v113
            UH0_0(v116, v109)
    let v122 : obj =
        match v7 with
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
            let v124 : string = "borderWidth"
            let v125 : (string * obj) = v124, v122
            UH0_0(v125, v118)
    let v131 : obj =
        match v8 with
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
            let v133 : string = "bottom"
            let v134 : (string * obj) = v133, v131
            UH0_0(v134, v127)
    let v140 : obj =
        match v9 with
        | US4_0 -> (* None *)
            let v137 : obj = ()
            v137
        | US4_1(v138) -> (* Some *)
            let v139 : obj = v138
            v139
    let v141 : bool = emitJsExpr v140 "!$0"
    let v145 : UH0 =
        if v141 then
            v136
        else
            let v142 : string = "checked"
            let v143 : (string * obj) = v142, v140
            UH0_0(v143, v136)
    let v149 : obj =
        match v10 with
        | US5_0 -> (* None *)
            let v146 : obj = ()
            v146
        | US5_1(v147) -> (* Some *)
            let v148 : obj = v147
            v148
    let v150 : bool = emitJsExpr v149 "!$0"
    let v154 : UH0 =
        if v150 then
            v145
        else
            let v151 : string = "children"
            let v152 : (string * obj) = v151, v149
            UH0_0(v152, v145)
    let v158 : obj =
        match v11 with
        | US1_0 -> (* None *)
            let v155 : obj = ()
            v155
        | US1_1(v156) -> (* Some *)
            let v157 : obj = v156
            v157
    let v159 : bool = emitJsExpr v158 "!$0"
    let v163 : UH0 =
        if v159 then
            v154
        else
            let v160 : string = "color"
            let v161 : (string * obj) = v160, v158
            UH0_0(v161, v154)
    let v167 : obj =
        match v12 with
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
            let v169 : string = "colorScheme"
            let v170 : (string * obj) = v169, v167
            UH0_0(v170, v163)
    let v176 : obj =
        match v13 with
        | US4_0 -> (* None *)
            let v173 : obj = ()
            v173
        | US4_1(v174) -> (* Some *)
            let v175 : obj = v174
            v175
    let v177 : bool = emitJsExpr v176 "!$0"
    let v181 : UH0 =
        if v177 then
            v172
        else
            let v178 : string = "compact"
            let v179 : (string * obj) = v178, v176
            UH0_0(v179, v172)
    let v185 : obj =
        match v14 with
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
            let v187 : string = "css"
            let v188 : (string * obj) = v187, v185
            UH0_0(v188, v181)
    let v194 : obj =
        match v15 with
        | US1_0 -> (* None *)
            let v191 : obj = ()
            v191
        | US1_1(v192) -> (* Some *)
            let v193 : obj = v192
            v193
    let v195 : bool = emitJsExpr v194 "!$0"
    let v199 : UH0 =
        if v195 then
            v190
        else
            let v196 : string = "defaultValue"
            let v197 : (string * obj) = v196, v194
            UH0_0(v197, v190)
    let v203 : obj =
        match v16 with
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
            let v205 : string = "direction"
            let v206 : (string * obj) = v205, v203
            UH0_0(v206, v199)
    let v212 : obj =
        match v17 with
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
            let v214 : string = "display"
            let v215 : (string * obj) = v214, v212
            UH0_0(v215, v208)
    let v221 : obj =
        match v18 with
        | US7_0 -> (* None *)
            let v218 : obj = ()
            v218
        | US7_1(v219) -> (* Some *)
            let v220 : obj = v219
            v220
    let v222 : bool = emitJsExpr v221 "!$0"
    let v226 : UH0 =
        if v222 then
            v217
        else
            let v223 : string = "each"
            let v224 : (string * obj) = v223, v221
            UH0_0(v224, v217)
    let v230 : obj =
        match v19 with
        | US4_0 -> (* None *)
            let v227 : obj = ()
            v227
        | US4_1(v228) -> (* Some *)
            let v229 : obj = v228
            v229
    let v231 : bool = emitJsExpr v230 "!$0"
    let v235 : UH0 =
        if v231 then
            v226
        else
            let v232 : string = "external"
            let v233 : (string * obj) = v232, v230
            UH0_0(v233, v226)
    let v239 : obj =
        match v20 with
        | US1_0 -> (* None *)
            let v236 : obj = ()
            v236
        | US1_1(v237) -> (* Some *)
            let v238 : obj = v237
            v238
    let v240 : bool = emitJsExpr v239 "!$0"
    let v244 : UH0 =
        if v240 then
            v235
        else
            let v241 : string = "flex"
            let v242 : (string * obj) = v241, v239
            UH0_0(v242, v235)
    let v248 : obj =
        match v21 with
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
            let v250 : string = "flexDirection"
            let v251 : (string * obj) = v250, v248
            UH0_0(v251, v244)
    let v257 : obj =
        match v22 with
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
            let v259 : string = "fontSize"
            let v260 : (string * obj) = v259, v257
            UH0_0(v260, v253)
    let v266 : obj =
        match v23 with
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
            let v268 : string = "height"
            let v269 : (string * obj) = v268, v266
            UH0_0(v269, v262)
    let v275 : obj =
        match v24 with
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
            let v277 : string = "href"
            let v278 : (string * obj) = v277, v275
            UH0_0(v278, v271)
    let v284 : obj =
        match v25 with
        | US8_0 -> (* None *)
            let v281 : obj = ()
            v281
        | US8_1(v282) -> (* Some *)
            let v283 : obj = v282
            v283
    let v285 : bool = emitJsExpr v284 "!$0"
    let v289 : UH0 =
        if v285 then
            v280
        else
            let v286 : string = "icon"
            let v287 : (string * obj) = v286, v284
            UH0_0(v287, v280)
    let v293 : obj =
        match v26 with
        | US1_0 -> (* None *)
            let v290 : obj = ()
            v290
        | US1_1(v291) -> (* Some *)
            let v292 : obj = v291
            v292
    let v294 : bool = emitJsExpr v293 "!$0"
    let v298 : UH0 =
        if v294 then
            v289
        else
            let v295 : string = "id"
            let v296 : (string * obj) = v295, v293
            UH0_0(v296, v289)
    let v302 : obj =
        match v27 with
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
            let v304 : string = "justifyContent"
            let v305 : (string * obj) = v304, v302
            UH0_0(v305, v298)
    let v311 : obj =
        match v28 with
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
            let v313 : string = "left"
            let v314 : (string * obj) = v313, v311
            UH0_0(v314, v307)
    let v320 : obj =
        match v29 with
        | US6_0 -> (* None *)
            let v317 : obj = ()
            v317
        | US6_1(v318) -> (* Some *)
            let v319 : obj = v318
            v319
    let v321 : bool = emitJsExpr v320 "!$0"
    let v325 : UH0 =
        if v321 then
            v316
        else
            let v322 : string = "leftIcon"
            let v323 : (string * obj) = v322, v320
            UH0_0(v323, v316)
    let v329 : obj =
        match v30 with
        | US1_0 -> (* None *)
            let v326 : obj = ()
            v326
        | US1_1(v327) -> (* Some *)
            let v328 : obj = v327
            v328
    let v330 : bool = emitJsExpr v329 "!$0"
    let v334 : UH0 =
        if v330 then
            v325
        else
            let v331 : string = "lineHeight"
            let v332 : (string * obj) = v331, v329
            UH0_0(v332, v325)
    let v338 : obj =
        match v31 with
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
            let v340 : string = "margin"
            let v341 : (string * obj) = v340, v338
            UH0_0(v341, v334)
    let v347 : obj =
        match v32 with
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
            let v349 : string = "marginBottom"
            let v350 : (string * obj) = v349, v347
            UH0_0(v350, v343)
    let v356 : obj =
        match v33 with
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
            let v358 : string = "marginLeft"
            let v359 : (string * obj) = v358, v356
            UH0_0(v359, v352)
    let v365 : obj =
        match v34 with
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
            let v367 : string = "marginRight"
            let v368 : (string * obj) = v367, v365
            UH0_0(v368, v361)
    let v374 : obj =
        match v35 with
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
            let v376 : string = "marginTop"
            let v377 : (string * obj) = v376, v374
            UH0_0(v377, v370)
    let v383 : obj =
        match v36 with
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
            let v385 : string = "maxHeight"
            let v386 : (string * obj) = v385, v383
            UH0_0(v386, v379)
    let v392 : obj =
        match v37 with
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
            let v394 : string = "maxWidth"
            let v395 : (string * obj) = v394, v392
            UH0_0(v395, v388)
    let v401 : obj =
        match v38 with
        | US9_0 -> (* None *)
            let v398 : obj = ()
            v398
        | US9_1(v399) -> (* Some *)
            let v400 : obj = v399
            v400
    let v402 : bool = emitJsExpr v401 "!$0"
    let v406 : UH0 =
        if v402 then
            v397
        else
            let v403 : string = "onChange"
            let v404 : (string * obj) = v403, v401
            UH0_0(v404, v397)
    let v410 : obj =
        match v39 with
        | US10_0 -> (* None *)
            let v407 : obj = ()
            v407
        | US10_1(v408) -> (* Some *)
            let v409 : obj = v408
            v409
    let v411 : bool = emitJsExpr v410 "!$0"
    let v415 : UH0 =
        if v411 then
            v406
        else
            let v412 : string = "onClick"
            let v413 : (string * obj) = v412, v410
            UH0_0(v413, v406)
    let v419 : obj =
        match v40 with
        | US9_0 -> (* None *)
            let v416 : obj = ()
            v416
        | US9_1(v417) -> (* Some *)
            let v418 : obj = v417
            v418
    let v420 : bool = emitJsExpr v419 "!$0"
    let v424 : UH0 =
        if v420 then
            v415
        else
            let v421 : string = "onInput"
            let v422 : (string * obj) = v421, v419
            UH0_0(v422, v415)
    let v428 : obj =
        match v41 with
        | US1_0 -> (* None *)
            let v425 : obj = ()
            v425
        | US1_1(v426) -> (* Some *)
            let v427 : obj = v426
            v427
    let v429 : bool = emitJsExpr v428 "!$0"
    let v433 : UH0 =
        if v429 then
            v424
        else
            let v430 : string = "outline"
            let v431 : (string * obj) = v430, v428
            UH0_0(v431, v424)
    let v437 : obj =
        match v42 with
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
            let v439 : string = "overflowX"
            let v440 : (string * obj) = v439, v437
            UH0_0(v440, v433)
    let v446 : obj =
        match v43 with
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
            let v448 : string = "overflowY"
            let v449 : (string * obj) = v448, v446
            UH0_0(v449, v442)
    let v455 : obj =
        match v44 with
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
            let v457 : string = "padding"
            let v458 : (string * obj) = v457, v455
            UH0_0(v458, v451)
    let v464 : obj =
        match v45 with
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
            let v466 : string = "paddingBottom"
            let v467 : (string * obj) = v466, v464
            UH0_0(v467, v460)
    let v473 : obj =
        match v46 with
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
            let v475 : string = "paddingLeft"
            let v476 : (string * obj) = v475, v473
            UH0_0(v476, v469)
    let v482 : obj =
        match v47 with
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
            let v484 : string = "paddingRight"
            let v485 : (string * obj) = v484, v482
            UH0_0(v485, v478)
    let v491 : obj =
        match v48 with
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
            let v493 : string = "paddingTop"
            let v494 : (string * obj) = v493, v491
            UH0_0(v494, v487)
    let v500 : obj =
        match v49 with
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
            let v502 : string = "position"
            let v503 : (string * obj) = v502, v500
            UH0_0(v503, v496)
    let v509 : obj =
        match v50 with
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
            let v511 : string = "right"
            let v512 : (string * obj) = v511, v509
            UH0_0(v512, v505)
    let v518 : obj =
        match v51 with
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
            let v520 : string = "size"
            let v521 : (string * obj) = v520, v518
            UH0_0(v521, v514)
    let v527 : obj =
        match v52 with
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
            let v529 : string = "spacing"
            let v530 : (string * obj) = v529, v527
            UH0_0(v530, v523)
    let v536 : obj =
        match v53 with
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
            let v538 : string = "src"
            let v539 : (string * obj) = v538, v536
            UH0_0(v539, v532)
    let v545 : obj =
        match v54 with
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
            let v547 : string = "striped"
            let v548 : (string * obj) = v547, v545
            UH0_0(v548, v541)
    let v554 : obj =
        match v55 with
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
            let v556 : string = "thickness"
            let v557 : (string * obj) = v556, v554
            UH0_0(v557, v550)
    let v563 : obj =
        match v56 with
        | US8_0 -> (* None *)
            let v560 : obj = ()
            v560
        | US8_1(v561) -> (* Some *)
            let v562 : obj = v561
            v562
    let v564 : bool = emitJsExpr v563 "!$0"
    let v568 : UH0 =
        if v564 then
            v559
        else
            let v565 : string = "title"
            let v566 : (string * obj) = v565, v563
            UH0_0(v566, v559)
    let v572 : obj =
        match v57 with
        | US1_0 -> (* None *)
            let v569 : obj = ()
            v569
        | US1_1(v570) -> (* Some *)
            let v571 : obj = v570
            v571
    let v573 : bool = emitJsExpr v572 "!$0"
    let v577 : UH0 =
        if v573 then
            v568
        else
            let v574 : string = "top"
            let v575 : (string * obj) = v574, v572
            UH0_0(v575, v568)
    let v581 : obj =
        match v58 with
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
            let v583 : string = "type"
            let v584 : (string * obj) = v583, v581
            UH0_0(v584, v577)
    let v590 : obj =
        match v59 with
        | US6_0 -> (* None *)
            let v587 : obj = ()
            v587
        | US6_1(v588) -> (* Some *)
            let v589 : obj = v588
            v589
    let v591 : bool = emitJsExpr v590 "!$0"
    let v595 : UH0 =
        if v591 then
            v586
        else
            let v592 : string = "value"
            let v593 : (string * obj) = v592, v590
            UH0_0(v593, v586)
    let v599 : obj =
        match v60 with
        | US1_0 -> (* None *)
            let v596 : obj = ()
            v596
        | US1_1(v597) -> (* Some *)
            let v598 : obj = v597
            v598
    let v600 : bool = emitJsExpr v599 "!$0"
    let v604 : UH0 =
        if v600 then
            v595
        else
            let v601 : string = "width"
            let v602 : (string * obj) = v601, v599
            UH0_0(v602, v595)
    let v608 : obj =
        match v61 with
        | US0_0 -> (* None *)
            let v605 : obj = ()
            v605
        | US0_1(v606) -> (* Some *)
            let v607 : obj = v606
            v607
    let v609 : bool = emitJsExpr v608 "!$0"
    let v613 : UH0 =
        if v609 then
            v604
        else
            let v610 : string = "zIndex"
            let v611 : (string * obj) = v610, v608
            UH0_0(v611, v604)
    let v617 : obj =
        match v62 with
        | US1_0 -> (* None *)
            let v614 : obj = ()
            v614
        | US1_1(v615) -> (* Some *)
            let v616 : obj = v615
            v616
    let v618 : bool = emitJsExpr v617 "!$0"
    let v622 : UH0 =
        if v618 then
            v613
        else
            let v619 : string = "zoom"
            let v620 : (string * obj) = v619, v617
            UH0_0(v620, v613)
    method8(v622)
and closure7 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : US5 = v0.l9
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US5_0 -> (* None *)
            closure8()
        | US5_1(v3) -> (* Some *)
            v3
    let v5 : string = "Tbody"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let v8 : Mut2 = method4()
    let v9 : Mut2 = method6(v4, v8)
    let v10 : ((string * obj) []) = method7(v9)
    let v11 : obj = createObj v10
    let v12 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v13 : string = "createComponent"
    let v14 : string = "solid-js"
    let v15 : JS.Function = import v13 v14
    let v16 : JSX.Element = v15.Invoke (v12, v11) |> unbox<JSX.Element>
    [|v16|]
and method11 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "flex"
    let v64 : US1 = US1_1(v63)
    v62.l16 <- v64
    let v65 : string = "1"
    let v66 : US1 = US1_1(v65)
    v62.l19 <- v66
    let v67 : string = "column"
    let v68 : US1 = US1_1(v67)
    v62.l20 <- v68
    let v69 : string = "hidden"
    let v70 : US1 = US1_1(v69)
    v62.l41 <- v70
    let v71 : US1 = v62.l42
    let v73 : string =
        match v71 with
        | US1_0 -> (* None *)
            v69
        | US1_1(v72) -> (* Some *)
            v72
    let v74 : US1 = US1_1(v73)
    v62.l42 <- v74
    v62
and closure6 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure7(v0)
    let v5 : Mut2 = method11()
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    v13
and method12 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "flex"
    let v64 : US1 = US1_1(v63)
    v62.l16 <- v64
    let v65 : string = "1"
    let v66 : US1 = US1_1(v65)
    v62.l19 <- v66
    let v67 : string = "column"
    let v68 : US1 = US1_1(v67)
    v62.l20 <- v68
    let v69 : string = "auto"
    let v70 : US1 = US1_1(v69)
    v62.l42 <- v70
    let v71 : string = "hidden"
    let v72 : US1 = US1_1(v71)
    v62.l41 <- v72
    v62
and closure14 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and method13 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "2px"
    let v64 : US1 = US1_1(v63)
    v62.l47 <- v64
    v62
and closure13 (v0 : JSX.Element) () : (JSX.Element []) =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure14(v0)
    let v5 : Mut2 = method13()
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    [|v13|]
and closure15 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and method14 (v0 : (bool -> unit), v1 : (unit -> bool)) : Mut2 =
    let struct (v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US6, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let v64 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63} : Mut2
    let v65 : string = "sm"
    let v66 : US1 = US1_1(v65)
    v64.l50 <- v66
    let v67 : string = "2px"
    let v68 : US1 = US1_1(v67)
    v64.l31 <- v68
    let v69 : bool = v1 ()
    let v70 : US4 = US4_1(v69)
    v64.l8 <- v70
    let v71 : string = "neutral"
    let v72 : US1 = US1_1(v71)
    v64.l11 <- v72
    let v73 : (obj -> unit) = closure15(v0)
    let v74 : US9 = US9_1(v73)
    v64.l37 <- v74
    v64
and closure12 (v0 : Mut3, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US12 = v0.l2
    let v31 : JSX.Element =
        match v4 with
        | US12_0 -> (* CheckDisabled *)
            let v5 : string = "Checkbox"
            let v6 : string = "@hope-ui/solid"
            let v7 : JS.Function = import v5 v6
            let v8 : (unit -> (JSX.Element [])) = closure13(v3)
            let v9 : Mut2 = method14(v1, v2)
            let v10 : Mut2 = method6(v8, v9)
            let v11 : ((string * obj) []) = method7(v10)
            let v12 : obj = createObj v11
            let v13 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v14 : string = "createComponent"
            let v15 : string = "solid-js"
            let v16 : JS.Function = import v14 v15
            let v17 : JSX.Element = v16.Invoke (v13, v12) |> unbox<JSX.Element>
            v17
        | US12_1 -> (* CheckEnabled *)
            let v18 : string = "Checkbox"
            let v19 : string = "@hope-ui/solid"
            let v20 : JS.Function = import v18 v19
            let v21 : (unit -> (JSX.Element [])) = closure13(v3)
            let v22 : Mut2 = method14(v1, v2)
            let v23 : Mut2 = method6(v21, v22)
            let v24 : ((string * obj) []) = method7(v23)
            let v25 : obj = createObj v24
            let v26 : (obj -> JSX.Element) = v20 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v27 : string = "createComponent"
            let v28 : string = "solid-js"
            let v29 : JS.Function = import v27 v28
            let v30 : JSX.Element = v29.Invoke (v26, v25) |> unbox<JSX.Element>
            v30
        | US12_2 -> (* CheckHidden *)
            v3
    [|v31|]
and method15 (v0 : Mut3, v1 : (unit -> bool)) : Mut2 =
    let struct (v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US6, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let v64 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63} : Mut2
    let v65 : US12 = v0.l2
    let v67 : bool =
        match v65 with
        | US12_2 -> (* CheckHidden *)
            true
        | _ ->
            false
    let v69 : bool =
        if v67 then
            true
        else
            let v68 : bool = v1 ()
            v68
    let v74 : string =
        if v69 then
            let v70 : string = "2px !important"
            let v71 : string = "0px !important"
            let v72 : string = {| ``@initial`` = v70; ``@sm`` = v71 |} |> unbox<string>
            v72
        else
            let v73 : string = "0px !important"
            v73
    let v75 : US1 = US1_1(v74)
    v64.l4 <- v75
    let v76 : string = "$neutral5"
    let v77 : US1 = US1_1(v76)
    v64.l5 <- v77
    let v78 : string = "$neutral9"
    let v79 : US1 = US1_1(v78)
    v64.l10 <- v79
    let v80 : string = "flex"
    let v81 : US1 = US1_1(v80)
    v64.l16 <- v81
    let v82 : string = "column"
    let v83 : US1 = US1_1(v82)
    v64.l20 <- v83
    let v84 : string = "$sm"
    let v85 : US1 = US1_1(v84)
    v64.l21 <- v85
    let v86 : string = "3px 20px 0 8px"
    let v87 : US1 = US1_1(v86)
    v64.l43 <- v87
    v64
and closure16 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and method16 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "0"
    let v64 : US1 = US1_1(v63)
    v62.l3 <- v64
    let v65 : US1 = US1_1(v63)
    v62.l43 <- v65
    let v66 : string = "9px"
    let v67 : US1 = US1_1(v66)
    v62.l29 <- v67
    v62
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
and closure25 () () : (JSX.Element []) =
    [||]
and method19 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method18 (v0 : Mut2, v1 : Mut2) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v1 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut5 = {l0 = 0} : Mut5
    while method19(v3, v4) do
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
and method17 (v0 : Mut2) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : string = "xs"
    let v65 : US1 = US1_1(v64)
    v63.l50 <- v65
    let v66 : string = "left"
    let v67 : US1 = US1_1(v66)
    v63.l26 <- v67
    let v68 : US4 = US4_1(true)
    v63.l12 <- v68
    let v69 : string = "neutral"
    let v70 : US1 = US1_1(v69)
    v63.l11 <- v70
    method18(v63, v0)
    v63
and closure24 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Button"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure25()
    let v5 : Mut2 = method17(v0)
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    v13
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
and method20 (v0 : (bool -> unit), v1 : Mut4, v2 : Mut1, v3 : JS.Function) : Mut2 =
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : (unit -> unit) = closure26(v0, v1, v2, v3)
    let v68 : US10 = US10_1(v67)
    v66.l38 <- v68
    v66
and closure27 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure23 (v0 : (bool -> unit), v1 : Mut4, v2 : Mut1, v3 : JS.Function) () : (JSX.Element []) =
    let v4 : (Mut2 -> JSX.Element) = closure24()
    let v5 : Mut2 = method20(v0, v1, v2, v3)
    let v6 : (unit -> (JSX.Element [])) = closure27()
    let v7 : Mut2 = method6(v6, v5)
    let struct (v8 : US1, v9 : US3, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US4, v17 : US5, v18 : US1, v19 : US1, v20 : US4, v21 : US6, v22 : US1, v23 : US1, v24 : US1, v25 : US7, v26 : US4, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US6, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US9, v46 : US10, v47 : US9, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US8, v64 : US1, v65 : US1, v66 : US6, v67 : US1, v68 : US0, v69 : US1) = v7.l0, v7.l1, v7.l2, v7.l3, v7.l4, v7.l5, v7.l6, v7.l7, v7.l8, v7.l9, v7.l10, v7.l11, v7.l12, v7.l13, v7.l14, v7.l15, v7.l16, v7.l17, v7.l18, v7.l19, v7.l20, v7.l21, v7.l22, v7.l23, v7.l24, v7.l25, v7.l26, v7.l27, v7.l28, v7.l29, v7.l30, v7.l31, v7.l32, v7.l33, v7.l34, v7.l35, v7.l36, v7.l37, v7.l38, v7.l39, v7.l40, v7.l41, v7.l42, v7.l43, v7.l44, v7.l45, v7.l46, v7.l47, v7.l48, v7.l49, v7.l50, v7.l51, v7.l52, v7.l53, v7.l54, v7.l55, v7.l56, v7.l57, v7.l58, v7.l59, v7.l60, v7.l61
    "create_component -> create_custom_component" |> ignore
    let v70 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69} : Mut2
    let v71 : obj = v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and method21 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "3px 0"
    let v64 : US1 = US1_1(v63)
    v62.l43 <- v64
    v62
and closure31 () () : (JSX.Element []) =
    [||]
and closure32 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure33 () () : (JSX.Element []) =
    [||]
and method24 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "0.6"
    let v64 : US1 = US1_1(v63)
    v62.l61 <- v64
    let v65 : string = "-12px"
    let v66 : US1 = US1_1(v65)
    v62.l34 <- v66
    let v67 : US1 = US1_1(v65)
    v62.l32 <- v67
    v62
and method23 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "BiRegularRefresh"
    let v64 : string = "solid-icons/bi"
    let v65 : JS.Function = import v63 v64
    let v66 : US3 = US3_1(v65)
    v62.l1 <- v66
    let v67 : string = "14px"
    let v68 : US1 = US1_1(v67)
    v62.l50 <- v68
    let v69 : Mut2 = method24()
    let v70 : ((string * obj) []) = method7(v69)
    let v71 : obj = createObj v70
    let v72 : US6 = US6_1(v71)
    v62.l13 <- v72
    v62
and method22 (v0 : (bool -> unit)) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : string = "Refresh"
    let v65 : US1 = US1_1(v64)
    v63.l0 <- v65
    let v66 : string = "xs"
    let v67 : US1 = US1_1(v66)
    v63.l50 <- v67
    let v68 : string = "20px"
    let v69 : US1 = US1_1(v68)
    v63.l22 <- v69
    let v70 : string = "neutral"
    let v71 : US1 = US1_1(v70)
    v63.l11 <- v71
    let v72 : (unit -> unit) = closure32(v0)
    let v73 : US10 = US10_1(v72)
    v63.l38 <- v73
    let v74 : string = "Icon"
    let v75 : string = "@hope-ui/solid"
    let v76 : JS.Function = import v74 v75
    let v77 : (unit -> (JSX.Element [])) = closure33()
    let v78 : Mut2 = method23()
    let v79 : Mut2 = method6(v77, v78)
    let v80 : ((string * obj) []) = method7(v79)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v76 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    let v87 : US8 = US8_1(v86)
    v63.l24 <- v87
    v63
and closure34 () () : (JSX.Element []) =
    [||]
and closure35 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (unit -> bool)) () : unit =
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
    v9.l7 <- v12
    let v13 : obj = v9
    v1.Invoke ("set", v13) |> ignore
    ()
and closure36 () () : (JSX.Element []) =
    [||]
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
and method27 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "0.6"
    let v64 : US1 = US1_1(v63)
    v62.l61 <- v64
    let v65 : string = "-12px"
    let v66 : US1 = US1_1(v65)
    v62.l34 <- v66
    let v67 : US1 = US1_1(v65)
    v62.l32 <- v67
    v62
and method26 (v0 : (unit -> bool)) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : bool = v0 ()
    let v67 : (unit -> JS.Function) =
        if v64 then
            closure37()
        else
            closure38()
    let v68 : JS.Function = v67 ()
    let v69 : US3 = US3_1(v68)
    v63.l1 <- v69
    let v70 : string = "14px"
    let v71 : US1 = US1_1(v70)
    v63.l50 <- v71
    let v72 : Mut2 = method27()
    let v73 : ((string * obj) []) = method7(v72)
    let v74 : obj = createObj v73
    let v75 : US6 = US6_1(v74)
    v63.l13 <- v75
    v63
and method25 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (unit -> bool)) : Mut2 =
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : bool = v4 ()
    let v71 : string =
        if v68 then
            let v69 : string = "Restore"
            v69
        else
            let v70 : string = "Maximize"
            v70
    let v72 : US1 = US1_1(v71)
    v67.l0 <- v72
    let v73 : string = "xs"
    let v74 : US1 = US1_1(v73)
    v67.l50 <- v74
    let v75 : string = "20px"
    let v76 : US1 = US1_1(v75)
    v67.l22 <- v76
    let v77 : string = "neutral"
    let v78 : US1 = US1_1(v77)
    v67.l11 <- v78
    let v79 : (unit -> unit) = closure35(v0, v1, v2, v3, v4)
    let v80 : US10 = US10_1(v79)
    v67.l38 <- v80
    let v81 : string = "Icon"
    let v82 : string = "@hope-ui/solid"
    let v83 : JS.Function = import v81 v82
    let v84 : (unit -> (JSX.Element [])) = closure36()
    let v85 : Mut2 = method26(v4)
    let v86 : Mut2 = method6(v84, v85)
    let v87 : ((string * obj) []) = method7(v86)
    let v88 : obj = createObj v87
    let v89 : (obj -> JSX.Element) = v83 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v90 : string = "createComponent"
    let v91 : string = "solid-js"
    let v92 : JS.Function = import v90 v91
    let v93 : JSX.Element = v92.Invoke (v89, v88) |> unbox<JSX.Element>
    let v94 : US8 = US8_1(v93)
    v67.l24 <- v94
    v67
and closure39 () () : (JSX.Element []) =
    [||]
and closure40 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure41 () () : (JSX.Element []) =
    [||]
and method30 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "0.6"
    let v64 : US1 = US1_1(v63)
    v62.l61 <- v64
    let v65 : string = "-12px"
    let v66 : US1 = US1_1(v65)
    v62.l34 <- v66
    let v67 : US1 = US1_1(v65)
    v62.l32 <- v67
    v62
and method29 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "BiRegularUndo"
    let v64 : string = "solid-icons/bi"
    let v65 : JS.Function = import v63 v64
    let v66 : US3 = US3_1(v65)
    v62.l1 <- v66
    let v67 : string = "14px"
    let v68 : US1 = US1_1(v67)
    v62.l50 <- v68
    let v69 : Mut2 = method30()
    let v70 : ((string * obj) []) = method7(v69)
    let v71 : obj = createObj v70
    let v72 : US6 = US6_1(v71)
    v62.l13 <- v72
    v62
and method28 (v0 : (bool -> unit)) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : string = "Unload"
    let v65 : US1 = US1_1(v64)
    v63.l0 <- v65
    let v66 : string = "xs"
    let v67 : US1 = US1_1(v66)
    v63.l50 <- v67
    let v68 : string = "20px"
    let v69 : US1 = US1_1(v68)
    v63.l22 <- v69
    let v70 : string = "neutral"
    let v71 : US1 = US1_1(v70)
    v63.l11 <- v71
    let v72 : (unit -> unit) = closure40(v0)
    let v73 : US10 = US10_1(v72)
    v63.l38 <- v73
    let v74 : string = "Icon"
    let v75 : string = "@hope-ui/solid"
    let v76 : JS.Function = import v74 v75
    let v77 : (unit -> (JSX.Element [])) = closure41()
    let v78 : Mut2 = method29()
    let v79 : Mut2 = method6(v77, v78)
    let v80 : ((string * obj) []) = method7(v79)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v76 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    let v87 : US8 = US8_1(v86)
    v63.l24 <- v87
    v63
and closure30 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool)) () : (JSX.Element []) =
    let v7 : string = "IconButton"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let v10 : (unit -> (JSX.Element [])) = closure31()
    let v11 : Mut2 = method22(v4)
    let v12 : Mut2 = method6(v10, v11)
    let v13 : ((string * obj) []) = method7(v12)
    let v14 : obj = createObj v13
    let v15 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v16 : string = "createComponent"
    let v17 : string = "solid-js"
    let v18 : JS.Function = import v16 v17
    let v19 : JSX.Element = v18.Invoke (v15, v14) |> unbox<JSX.Element>
    let v20 : JS.Function = import v7 v8
    let v21 : (unit -> (JSX.Element [])) = closure34()
    let v22 : Mut2 = method25(v0, v1, v2, v5, v6)
    let v23 : Mut2 = method6(v21, v22)
    let v24 : ((string * obj) []) = method7(v23)
    let v25 : obj = createObj v24
    let v26 : (obj -> JSX.Element) = v20 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v27 : JS.Function = import v16 v17
    let v28 : JSX.Element = v27.Invoke (v26, v25) |> unbox<JSX.Element>
    let v29 : JS.Function = import v7 v8
    let v30 : (unit -> (JSX.Element [])) = closure39()
    let v31 : Mut2 = method28(v3)
    let v32 : Mut2 = method6(v30, v31)
    let v33 : ((string * obj) []) = method7(v32)
    let v34 : obj = createObj v33
    let v35 : (obj -> JSX.Element) = v29 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v36 : JS.Function = import v16 v17
    let v37 : JSX.Element = v36.Invoke (v35, v34) |> unbox<JSX.Element>
    [|v19; v28; v37|]
and method31 (v0 : Mut1, v1 : int32) : Mut2 =
    let struct (v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US6, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let v64 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63} : Mut2
    let v65 : US0 = v0.l7
    match v65 with
    | US0_0 -> (* None *)
        ()
    | US0_1(v66) -> (* Some *)
        let v67 : bool = v66 = v1
        let v68 : bool = v67 <> true
        if v68 then
            let v69 : string = "none"
            let v70 : US1 = US1_1(v69)
            v64.l16 <- v70
            ()
    let v71 : string = "row"
    let v72 : US1 = US1_1(v71)
    v64.l15 <- v72
    let v73 : string = "3px"
    let v74 : US1 = US1_1(v73)
    v64.l51 <- v74
    let v75 : string = "absolute"
    let v76 : US1 = US1_1(v75)
    v64.l48 <- v76
    let v77 : string = "6px"
    let v78 : US1 = US1_1(v77)
    v64.l56 <- v78
    let v79 : US1 = US1_1(v77)
    v64.l49 <- v79
    let v80 : US0 = US0_1(1)
    v64.l60 <- v80
    v64
and closure29 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v9 : string = "Stack"
    let v10 : string = "@hope-ui/solid"
    let v11 : JS.Function = import v9 v10
    let v12 : (unit -> (JSX.Element [])) = closure30(v0, v1, v2, v3, v4, v6, v7)
    let v13 : Mut2 = method31(v0, v2)
    let v14 : Mut2 = method6(v12, v13)
    let v15 : ((string * obj) []) = method7(v14)
    let v16 : obj = createObj v15
    let v17 : (obj -> JSX.Element) = v11 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v18 : string = "createComponent"
    let v19 : string = "solid-js"
    let v20 : JS.Function = import v18 v19
    let v21 : JSX.Element = v20.Invoke (v17, v16) |> unbox<JSX.Element>
    let v22 : bool = v5 ()
    let v25 : JSX.Element =
        if v22 then
            let v23 : JSX.Element = Html.fragment []
            v23
        else
            let v24 : JSX.Element = v8 |> unbox<JSX.Element>
            v24
    [|v21; v25|]
and method32 (v0 : Mut1) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : US0 = v0.l7
    let v66 : bool =
        match v64 with
        | US0_0 -> (* None *)
            true
        | _ ->
            false
    if v66 then
        let v67 : string = "relative"
        let v68 : US1 = US1_1(v67)
        v63.l48 <- v68
        ()
    let v69 : string = "1"
    let v70 : US1 = US1_1(v69)
    v63.l19 <- v70
    let v71 : string = "flex"
    let v72 : US1 = US1_1(v71)
    v63.l16 <- v72
    v63
and closure28 (v0 : Mut2, v1 : Mut1, v2 : JS.Function, v3 : int32, v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool), v7 : (bool -> unit), v8 : (unit -> bool)) () : (JSX.Element []) =
    let v9 : US5 = v0.l9
    let v25 : JSX.Element =
        match v9 with
        | US5_0 -> (* None *)
            let v10 : JSX.Element = Html.fragment []
            v10
        | US5_1(v11) -> (* Some *)
            let v12 : string = "Box"
            let v13 : string = "@hope-ui/solid"
            let v14 : JS.Function = import v12 v13
            let v15 : (unit -> (JSX.Element [])) = closure29(v1, v2, v3, v4, v5, v6, v7, v8, v11)
            let v16 : Mut2 = method32(v1)
            let v17 : Mut2 = method6(v15, v16)
            let v18 : ((string * obj) []) = method7(v17)
            let v19 : obj = createObj v18
            let v20 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v21 : string = "createComponent"
            let v22 : string = "solid-js"
            let v23 : JS.Function = import v21 v22
            let v24 : JSX.Element = v23.Invoke (v20, v19) |> unbox<JSX.Element>
            v24
    [|v25|]
and method33 (v0 : (unit -> bool)) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : bool = v0 ()
    if v64 then
        let v65 : US0 = US0_1(1)
        v63.l60 <- v65
        let v66 : string = "absolute"
        let v67 : US1 = US1_1(v66)
        v63.l48 <- v67
        let v68 : string = "0"
        let v69 : US1 = US1_1(v68)
        v63.l56 <- v69
        let v70 : US1 = US1_1(v68)
        v63.l49 <- v70
        let v71 : US1 = US1_1(v68)
        v63.l7 <- v71
        let v72 : US1 = US1_1(v68)
        v63.l27 <- v72
        let v73 : string = "$bg"
        let v74 : US1 = US1_1(v73)
        v63.l2 <- v74
        ()
    let v75 : string = "flex"
    let v76 : US1 = US1_1(v75)
    v63.l16 <- v76
    let v77 : string = "1"
    let v78 : US1 = US1_1(v77)
    v63.l19 <- v78
    v63
and closure22 (v0 : Mut2, v1 : Mut1, v2 : JS.Function, v3 : int32, v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (bool -> unit), v9 : (unit -> bool), v10 : Mut4) () : (JSX.Element []) =
    let v11 : bool = v5 ()
    let v12 : bool = v11 = false
    let v39 : JSX.Element =
        if v12 then
            let v13 : string = "Box"
            let v14 : string = "@hope-ui/solid"
            let v15 : JS.Function = import v13 v14
            let v16 : (unit -> (JSX.Element [])) = closure23(v4, v10, v1, v2)
            let v17 : Mut2 = method21()
            let v18 : Mut2 = method6(v16, v17)
            let v19 : ((string * obj) []) = method7(v18)
            let v20 : obj = createObj v19
            let v21 : (obj -> JSX.Element) = v15 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v22 : string = "createComponent"
            let v23 : string = "solid-js"
            let v24 : JS.Function = import v22 v23
            let v25 : JSX.Element = v24.Invoke (v21, v20) |> unbox<JSX.Element>
            v25
        else
            let v26 : string = "Box"
            let v27 : string = "@hope-ui/solid"
            let v28 : JS.Function = import v26 v27
            let v29 : (unit -> (JSX.Element [])) = closure28(v0, v1, v2, v3, v4, v6, v7, v8, v9)
            let v30 : Mut2 = method33(v9)
            let v31 : Mut2 = method6(v29, v30)
            let v32 : ((string * obj) []) = method7(v31)
            let v33 : obj = createObj v32
            let v34 : (obj -> JSX.Element) = v28 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v35 : string = "createComponent"
            let v36 : string = "solid-js"
            let v37 : JS.Function = import v35 v36
            let v38 : JSX.Element = v37.Invoke (v34, v33) |> unbox<JSX.Element>
            v38
    [|v39|]
and method34 (v0 : Mut2) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : US1 = v0.l25
    v63.l25 <- v64
    let v65 : string = "flex"
    let v66 : US1 = US1_1(v65)
    v0.l16 <- v66
    let v67 : string = "1"
    let v68 : US1 = US1_1(v67)
    v0.l19 <- v68
    v63
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
    let v41 : (unit -> (JSX.Element [])) = closure22(v1, v6, v7, v8, v15, v14, v19, v18, v24, v23, v0)
    let v42 : Mut2 = method34(v1)
    let v43 : Mut2 = method6(v41, v42)
    let v44 : ((string * obj) []) = method7(v43)
    let v45 : obj = createObj v44
    let v46 : (obj -> JSX.Element) = v40 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v47 : string = "createComponent"
    let v48 : JS.Function = import v47 v11
    let v49 : JSX.Element = v48.Invoke (v46, v45) |> unbox<JSX.Element>
    v49
and method35 (v0 : (unit -> (JSX.Element []))) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : US5 = US5_1(v0)
    v63.l9 <- v64
    v63
and closure17 (v0 : Mut3, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US12 = v0.l2
    let v31 : JSX.Element =
        match v3 with
        | US12_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : (Mut4 -> JSX.Element) = closure18()
                let v6 : US11 = v0.l0
                let v7 : Mut2 = method35(v2)
                let v8 : Mut4 = {l0 = true; l1 = false; l2 = v6; l3 = v7} : Mut4
                let v9 : obj = v8
                let v10 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
                "create_custom_component -> create_component'" |> ignore
                let v11 : string = "createComponent"
                let v12 : string = "solid-js"
                let v13 : JS.Function = import v11 v12
                let v14 : JSX.Element = v13.Invoke (v10, v9) |> unbox<JSX.Element>
                v14
            else
                let v15 : JSX.Element = Html.fragment []
                v15
        | US12_1 -> (* CheckEnabled *)
            let v17 : bool = v1 ()
            if v17 then
                let v18 : (Mut4 -> JSX.Element) = closure18()
                let v19 : US11 = v0.l0
                let v20 : Mut2 = method35(v2)
                let v21 : Mut4 = {l0 = true; l1 = false; l2 = v19; l3 = v20} : Mut4
                let v22 : obj = v21
                let v23 : (obj -> JSX.Element) = v18 |> unbox<obj -> JSX.Element>
                "create_custom_component -> create_component'" |> ignore
                let v24 : string = "createComponent"
                let v25 : string = "solid-js"
                let v26 : JS.Function = import v24 v25
                let v27 : JSX.Element = v26.Invoke (v23, v22) |> unbox<JSX.Element>
                v27
            else
                let v28 : JSX.Element = Html.fragment []
                v28
        | US12_2 -> (* CheckHidden *)
            let v30 : JSX.Element = v2 |> unbox<JSX.Element>
            v30
    [|v31|]
and method36 (v0 : Mut2) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : string = "0"
    let v65 : US1 = US1_1(v64)
    v63.l3 <- v65
    let v66 : US1 = US1_1(v64)
    v63.l40 <- v66
    let v67 : US1 = US1_1(v64)
    v63.l30 <- v67
    let v68 : US1 = v0.l43
    let v70 : string =
        match v68 with
        | US1_0 -> (* None *)
            v64
        | US1_1(v69) -> (* Some *)
            v69
    let v71 : US1 = US1_1(v70)
    v63.l43 <- v71
    let v72 : string = "flex"
    let v73 : US1 = US1_1(v72)
    v63.l16 <- v73
    let v74 : string = "6"
    let v75 : US1 = US1_1(v74)
    v63.l19 <- v75
    let v76 : string = "$base"
    let v77 : US1 = US1_1(v76)
    v63.l29 <- v77
    let v78 : string = "column"
    let v79 : US1 = US1_1(v78)
    v63.l20 <- v79
    let v80 : string = "$sm"
    let v81 : US1 = US1_1(v80)
    v63.l21 <- v81
    let v82 : string = "85vh"
    let v83 : US1 = US1_1(v82)
    v63.l35 <- v83
    let v84 : string = "auto"
    let v85 : US1 = US1_1(v84)
    v63.l42 <- v85
    v63
and closure11 (v0 : Mut3, v1 : Mut2, v2 : (bool -> unit), v3 : (unit -> bool)) () : (JSX.Element []) =
    let v4 : US8 = v1.l55
    let v20 : JSX.Element =
        match v4 with
        | US8_0 -> (* None *)
            let v5 : JSX.Element = Html.fragment []
            v5
        | US8_1(v6) -> (* Some *)
            let v7 : string = "Td"
            let v8 : string = "@hope-ui/solid"
            let v9 : JS.Function = import v7 v8
            let v10 : (unit -> (JSX.Element [])) = closure12(v0, v2, v3, v6)
            let v11 : Mut2 = method15(v0, v3)
            let v12 : Mut2 = method6(v10, v11)
            let v13 : ((string * obj) []) = method7(v12)
            let v14 : obj = createObj v13
            let v15 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v16 : string = "createComponent"
            let v17 : string = "solid-js"
            let v18 : JS.Function = import v16 v17
            let v19 : JSX.Element = v18.Invoke (v15, v14) |> unbox<JSX.Element>
            v19
    let v21 : US5 = v1.l9
    let v49 : JSX.Element =
        match v21 with
        | US5_0 -> (* None *)
            let v22 : string = "Td"
            let v23 : string = "@hope-ui/solid"
            let v24 : JS.Function = import v22 v23
            let v25 : (unit -> (JSX.Element [])) = closure16()
            let v26 : Mut2 = method16()
            let v27 : Mut2 = method6(v25, v26)
            let v28 : ((string * obj) []) = method7(v27)
            let v29 : obj = createObj v28
            let v30 : (obj -> JSX.Element) = v24 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v31 : string = "createComponent"
            let v32 : string = "solid-js"
            let v33 : JS.Function = import v31 v32
            let v34 : JSX.Element = v33.Invoke (v30, v29) |> unbox<JSX.Element>
            v34
        | US5_1(v35) -> (* Some *)
            let v36 : string = "Td"
            let v37 : string = "@hope-ui/solid"
            let v38 : JS.Function = import v36 v37
            let v39 : (unit -> (JSX.Element [])) = closure17(v0, v3, v35)
            let v40 : Mut2 = method36(v1)
            let v41 : Mut2 = method6(v39, v40)
            let v42 : ((string * obj) []) = method7(v41)
            let v43 : obj = createObj v42
            let v44 : (obj -> JSX.Element) = v38 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v45 : string = "createComponent"
            let v46 : string = "solid-js"
            let v47 : JS.Function = import v45 v46
            let v48 : JSX.Element = v47.Invoke (v44, v43) |> unbox<JSX.Element>
            v48
    [|v20; v49|]
and method37 (v0 : Mut2) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : US1 = v0.l25
    v63.l25 <- v64
    let v65 : string = "flex"
    let v66 : US1 = US1_1(v65)
    v63.l16 <- v66
    let v67 : string = "1"
    let v68 : US1 = US1_1(v67)
    v63.l19 <- v68
    let v69 : string = "1px 2px"
    let v70 : US1 = US1_1(v69)
    v63.l6 <- v70
    let v71 : string = "$neutral5"
    let v72 : US1 = US1_1(v71)
    v63.l5 <- v72
    let v73 : string = "column"
    let v74 : string = "row"
    let v75 : string = {| ``@initial`` = v73; ``@sm`` = v74 |} |> unbox<string>
    let v76 : US1 = US1_1(v75)
    v63.l20 <- v76
    v63
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
    let v15 : (unit -> (JSX.Element [])) = closure11(v0, v1, v11, v10)
    let v16 : Mut2 = method37(v1)
    let v17 : Mut2 = method6(v15, v16)
    let v18 : ((string * obj) []) = method7(v17)
    let v19 : obj = createObj v18
    let v20 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v21 : string = "createComponent"
    let v22 : JS.Function = import v21 v7
    let v23 : JSX.Element = v22.Invoke (v20, v19) |> unbox<JSX.Element>
    v23
and method39 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure48 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : US1 = v0.l23
    let v4 : string =
        match v1 with
        | US1_0 -> (* None *)
            let v2 : string = ""
            v2
        | US1_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = Html.fragment [ v4 |> unbox<JSX.Element> ]
    [|v5|]
and method41 (v0 : Mut2) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : US4 = US4_1(true)
    v63.l18 <- v64
    method18(v63, v0)
    v63
and closure49 () () : (JSX.Element []) =
    [||]
and method43 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "0.6"
    let v64 : US1 = US1_1(v63)
    v62.l61 <- v64
    let v65 : string = "-13px"
    let v66 : US1 = US1_1(v65)
    v62.l34 <- v66
    v62
and method42 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "BiRegularLinkExternal"
    let v64 : string = "solid-icons/bi"
    let v65 : JS.Function = import v63 v64
    let v66 : US3 = US3_1(v65)
    v62.l1 <- v66
    let v67 : Mut2 = method43()
    let v68 : ((string * obj) []) = method7(v67)
    let v69 : obj = createObj v68
    let v70 : US6 = US6_1(v69)
    v62.l13 <- v70
    v62
and closure47 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure48(v0)
    let v5 : Mut2 = method41(v0)
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    let v14 : string = "&nbsp;"
    let v15 : JSX.Element = Html.fragment [ v14 |> unbox<JSX.Element> ]
    let v16 : string = "Icon"
    let v17 : JS.Function = import v16 v2
    let v18 : (unit -> (JSX.Element [])) = closure49()
    let v19 : Mut2 = method42()
    let v20 : Mut2 = method6(v18, v19)
    let v21 : ((string * obj) []) = method7(v20)
    let v22 : obj = createObj v21
    let v23 : (obj -> JSX.Element) = v17 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v24 : JS.Function = import v10 v11
    let v25 : JSX.Element = v24.Invoke (v23, v22) |> unbox<JSX.Element>
    [|v13; v15; v25|]
and method44 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure46 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure47(v0)
    let v5 : Mut2 = method44()
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    v13
and method45 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v64 : US1 = US1_1(v63)
    v62.l23 <- v64
    v62
and closure50 () () : (JSX.Element []) =
    [||]
and closure45 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure46()
    let v1 : Mut2 = method45()
    let v2 : (unit -> (JSX.Element [])) = closure50()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method40 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "1px 6px"
    let v64 : US1 = US1_1(v63)
    v62.l43 <- v64
    let v65 : (unit -> (JSX.Element [])) = closure45()
    let v66 : US5 = US5_1(v65)
    v62.l9 <- v66
    v62
and method47 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v64 : US1 = US1_1(v63)
    v62.l23 <- v64
    v62
and closure51 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure46()
    let v1 : Mut2 = method47()
    let v2 : (unit -> (JSX.Element [])) = closure50()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method46 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "1px 6px"
    let v64 : US1 = US1_1(v63)
    v62.l43 <- v64
    let v65 : (unit -> (JSX.Element [])) = closure51()
    let v66 : US5 = US5_1(v65)
    v62.l9 <- v66
    v62
and method49 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v64 : US1 = US1_1(v63)
    v62.l23 <- v64
    v62
and closure52 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure46()
    let v1 : Mut2 = method49()
    let v2 : (unit -> (JSX.Element [])) = closure50()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method48 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "1px 6px"
    let v64 : US1 = US1_1(v63)
    v62.l43 <- v64
    let v65 : (unit -> (JSX.Element [])) = closure52()
    let v66 : US5 = US5_1(v65)
    v62.l9 <- v66
    v62
and closure44 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let v1 : Mut2 = method40()
    let v2 : US11 = US11_0
    let v3 : US12 = US12_2
    let v4 : Mut3 = {l0 = v2; l1 = v1; l2 = v3} : Mut3
    let v5 : obj = v4
    let v6 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v6, v5) |> unbox<JSX.Element>
    let v11 : Mut2 = method46()
    let v12 : US11 = US11_0
    let v13 : US12 = US12_2
    let v14 : Mut3 = {l0 = v12; l1 = v11; l2 = v13} : Mut3
    let v15 : obj = v14
    let v16 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v17 : JS.Function = import v7 v8
    let v18 : JSX.Element = v17.Invoke (v16, v15) |> unbox<JSX.Element>
    let v19 : Mut2 = method48()
    let v20 : US11 = US11_0
    let v21 : US12 = US12_2
    let v22 : Mut3 = {l0 = v20; l1 = v19; l2 = v21} : Mut3
    let v23 : obj = v22
    let v24 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v25 : JS.Function = import v7 v8
    let v26 : JSX.Element = v25.Invoke (v24, v23) |> unbox<JSX.Element>
    [|v10; v18; v26|]
and closure43 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : Mut2 = method39()
    let v3 : (unit -> (JSX.Element [])) = closure44()
    let v4 : Mut2 = method6(v3, v2)
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61
    "create_component -> create_custom_component" |> ignore
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : obj = v67
    let v69 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v69, v68) |> unbox<JSX.Element>
    v73
and method50 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure53 () () : (JSX.Element []) =
    [||]
and closure42 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure43()
    let v1 : Mut2 = method50()
    let v2 : (unit -> (JSX.Element [])) = closure53()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method38 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "Links"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : (unit -> (JSX.Element [])) = closure42()
    let v67 : US5 = US5_1(v66)
    v62.l9 <- v67
    v62
and method51 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method53 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure60 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and method55 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "dark"
    let v64 : obj = v63
    let v65 : US6 = US6_1(v64)
    v62.l58 <- v65
    let v66 : string = "sm"
    let v67 : US1 = US1_1(v66)
    v62.l50 <- v67
    let v68 : string = "neutral"
    let v69 : US1 = US1_1(v68)
    v62.l11 <- v69
    v62
and closure61 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and method56 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "light"
    let v64 : obj = v63
    let v65 : US6 = US6_1(v64)
    v62.l58 <- v65
    let v66 : string = "sm"
    let v67 : US1 = US1_1(v66)
    v62.l50 <- v67
    let v68 : string = "neutral"
    let v69 : US1 = US1_1(v68)
    v62.l11 <- v69
    v62
and closure59 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : (unit -> (JSX.Element [])) = closure60()
    let v4 : Mut2 = method55()
    let v5 : Mut2 = method6(v3, v4)
    let v6 : ((string * obj) []) = method7(v5)
    let v7 : obj = createObj v6
    let v8 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v8, v7) |> unbox<JSX.Element>
    let v13 : JS.Function = import v0 v1
    let v14 : (unit -> (JSX.Element [])) = closure61()
    let v15 : Mut2 = method56()
    let v16 : Mut2 = method6(v14, v15)
    let v17 : ((string * obj) []) = method7(v16)
    let v18 : obj = createObj v17
    let v19 : (obj -> JSX.Element) = v13 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v20 : JS.Function = import v9 v10
    let v21 : JSX.Element = v20.Invoke (v19, v18) |> unbox<JSX.Element>
    [|v12; v21|]
and method57 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "row"
    let v64 : US1 = US1_1(v63)
    v62.l15 <- v64
    let v65 : string = "$4"
    let v66 : US1 = US1_1(v65)
    v62.l51 <- v66
    v62
and closure58 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : (unit -> (JSX.Element [])) = closure59()
    let v4 : Mut2 = method57()
    let v5 : Mut2 = method6(v3, v4)
    let v6 : ((string * obj) []) = method7(v5)
    let v7 : obj = createObj v6
    let v8 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v8, v7) |> unbox<JSX.Element>
    [|v12|]
and closure62 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and method58 (v0 : (unit -> unit), v1 : (unit -> string)) : Mut2 =
    let struct (v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US6, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let v64 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63} : Mut2
    let v65 : string = v1 ()
    let v66 : US1 = US1_1(v65)
    v64.l14 <- v66
    let v67 : (obj -> unit) = closure62(v0)
    let v68 : US9 = US9_1(v67)
    v64.l37 <- v68
    v64
and closure57 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (unit -> (JSX.Element [])) = closure58()
    let v6 : Mut2 = method58(v0, v1)
    let v7 : Mut2 = method6(v5, v6)
    let v8 : ((string * obj) []) = method7(v7)
    let v9 : obj = createObj v8
    let v10 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v11 : string = "createComponent"
    let v12 : string = "solid-js"
    let v13 : JS.Function = import v11 v12
    let v14 : JSX.Element = v13.Invoke (v10, v9) |> unbox<JSX.Element>
    [|v14|]
and method54 (v0 : (unit -> unit), v1 : (unit -> string)) : Mut2 =
    let struct (v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US6, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let v64 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63} : Mut2
    let v65 : string = "Theme"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v64.l55 <- v67
    let v68 : string = "5px 6px"
    let v69 : US1 = US1_1(v68)
    v64.l43 <- v69
    let v70 : (unit -> (JSX.Element [])) = closure57(v0, v1)
    let v71 : US5 = US5_1(v70)
    v64.l9 <- v71
    v64
and closure56 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure10()
    let v3 : Mut2 = method54(v0, v1)
    let v4 : US11 = US11_0
    let v5 : US12 = US12_2
    let v6 : Mut3 = {l0 = v4; l1 = v3; l2 = v5} : Mut3
    let v7 : obj = v6
    let v8 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v8, v7) |> unbox<JSX.Element>
    [|v12|]
and closure55 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "useColorMode"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : obj = v3.Invoke () |> unbox
    let v5 : (unit -> string) = v4?colorMode |> unbox
    let v6 : (unit -> unit) = v4?toggleColorMode |> unbox
    let v7 : (Mut2 -> JSX.Element) = closure6()
    let v8 : Mut2 = method53()
    let v9 : (unit -> (JSX.Element [])) = closure56(v6, v5)
    let v10 : Mut2 = method6(v9, v8)
    let struct (v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US6, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = v10.l0, v10.l1, v10.l2, v10.l3, v10.l4, v10.l5, v10.l6, v10.l7, v10.l8, v10.l9, v10.l10, v10.l11, v10.l12, v10.l13, v10.l14, v10.l15, v10.l16, v10.l17, v10.l18, v10.l19, v10.l20, v10.l21, v10.l22, v10.l23, v10.l24, v10.l25, v10.l26, v10.l27, v10.l28, v10.l29, v10.l30, v10.l31, v10.l32, v10.l33, v10.l34, v10.l35, v10.l36, v10.l37, v10.l38, v10.l39, v10.l40, v10.l41, v10.l42, v10.l43, v10.l44, v10.l45, v10.l46, v10.l47, v10.l48, v10.l49, v10.l50, v10.l51, v10.l52, v10.l53, v10.l54, v10.l55, v10.l56, v10.l57, v10.l58, v10.l59, v10.l60, v10.l61
    "create_component -> create_custom_component" |> ignore
    let v73 : Mut2 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14; l4 = v15; l5 = v16; l6 = v17; l7 = v18; l8 = v19; l9 = v20; l10 = v21; l11 = v22; l12 = v23; l13 = v24; l14 = v25; l15 = v26; l16 = v27; l17 = v28; l18 = v29; l19 = v30; l20 = v31; l21 = v32; l22 = v33; l23 = v34; l24 = v35; l25 = v36; l26 = v37; l27 = v38; l28 = v39; l29 = v40; l30 = v41; l31 = v42; l32 = v43; l33 = v44; l34 = v45; l35 = v46; l36 = v47; l37 = v48; l38 = v49; l39 = v50; l40 = v51; l41 = v52; l42 = v53; l43 = v54; l44 = v55; l45 = v56; l46 = v57; l47 = v58; l48 = v59; l49 = v60; l50 = v61; l51 = v62; l52 = v63; l53 = v64; l54 = v65; l55 = v66; l56 = v67; l57 = v68; l58 = v69; l59 = v70; l60 = v71; l61 = v72} : Mut2
    let v74 : obj = v73
    let v75 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v76 : string = "createComponent"
    let v77 : string = "solid-js"
    let v78 : JS.Function = import v76 v77
    let v79 : JSX.Element = v78.Invoke (v75, v74) |> unbox<JSX.Element>
    v79
and method59 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure63 () () : (JSX.Element []) =
    [||]
and closure54 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure55()
    let v1 : Mut2 = method59()
    let v2 : (unit -> (JSX.Element [])) = closure63()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method52 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "Settings"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : (unit -> (JSX.Element [])) = closure54()
    let v67 : US5 = US5_1(v66)
    v62.l9 <- v67
    v62
and method60 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method62 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method64 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure72 () () : (JSX.Element []) =
    [||]
and closure73 (v0 : Mut6, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
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
and method66 (v0 : Mut6, v1 : Mut1, v2 : JS.Function) : Mut2 =
    let struct (v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US6, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64} : Mut2
    let v66 : string = "text"
    let v67 : US1 = US1_1(v66)
    v65.l57 <- v67
    let v68 : string = "xs"
    let v69 : US1 = US1_1(v68)
    v65.l50 <- v69
    let v70 : (Mut1 -> US1) = v0.l0
    let v71 : US1 = v70 v1
    let v72 : string = JS.undefined
    let v74 : string =
        match v71 with
        | US1_0 -> (* None *)
            v72
        | US1_1(v73) -> (* Some *)
            v73
    let v75 : obj = v74
    let v76 : US6 = US6_1(v75)
    v65.l58 <- v76
    let v77 : (obj -> unit) = closure73(v0, v1, v2)
    let v78 : US9 = US9_1(v77)
    v65.l39 <- v78
    v65
and closure71 () (v0 : Mut6) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let v10 : (unit -> (JSX.Element [])) = closure72()
    let v11 : Mut2 = method66(v0, v5, v6)
    let v12 : Mut2 = method6(v10, v11)
    let v13 : ((string * obj) []) = method7(v12)
    let v14 : obj = createObj v13
    let v15 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v16 : string = "createComponent"
    let v17 : string = "solid-js"
    let v18 : JS.Function = import v16 v17
    let v19 : JSX.Element = v18.Invoke (v15, v14) |> unbox<JSX.Element>
    v19
and closure74 () (v0 : Mut1) : US1 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v3
and closure77 (v0 : Mut1) (v1 : US1) : unit =
    v0.l2 <- v1
    ()
and closure76 () (v0 : Mut1) : (US1 -> unit) =
    closure77(v0)
and closure75 () (v0 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure76()
and closure70 () () : (JSX.Element []) =
    let v0 : (Mut6 -> JSX.Element) = closure71()
    let v1 : (Mut1 -> US1) = closure74()
    let v2 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure75()
    let v3 : Mut6 = {l0 = v1; l1 = v2} : Mut6
    let v4 : obj = v3
    let v5 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v5, v4) |> unbox<JSX.Element>
    [|v9|]
and method65 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "Token"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : string = "3px"
    let v67 : US1 = US1_1(v66)
    v62.l43 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure70()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and closure79 () (v0 : Mut1) : US1 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v4
and closure82 (v0 : Mut1) (v1 : US1) : unit =
    v0.l3 <- v1
    ()
and closure81 () (v0 : Mut1) : (US1 -> unit) =
    closure82(v0)
and closure80 () (v0 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure81()
and closure78 () () : (JSX.Element []) =
    let v0 : (Mut6 -> JSX.Element) = closure71()
    let v1 : (Mut1 -> US1) = closure79()
    let v2 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure80()
    let v3 : Mut6 = {l0 = v1; l1 = v2} : Mut6
    let v4 : obj = v3
    let v5 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v5, v4) |> unbox<JSX.Element>
    [|v9|]
and method67 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "URL"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : string = "3px"
    let v67 : US1 = US1_1(v66)
    v62.l43 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure78()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and closure85 (v0 : Mut7, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
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
and method69 (v0 : Mut7, v1 : Mut1, v2 : JS.Function) : Mut2 =
    let struct (v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US6, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64} : Mut2
    let v66 : string = "text"
    let v67 : US1 = US1_1(v66)
    v65.l57 <- v67
    let v68 : string = "xs"
    let v69 : US1 = US1_1(v68)
    v65.l50 <- v69
    let v70 : (Mut1 -> US0) = v0.l0
    let v71 : US0 = v70 v1
    let v72 : int32 = JS.undefined
    let v74 : int32 =
        match v71 with
        | US0_0 -> (* None *)
            v72
        | US0_1(v73) -> (* Some *)
            v73
    let v75 : obj = v74
    let v76 : US6 = US6_1(v75)
    v65.l58 <- v76
    let v77 : (obj -> unit) = closure85(v0, v1, v2)
    let v78 : US9 = US9_1(v77)
    v65.l39 <- v78
    v65
and closure84 () (v0 : Mut7) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let v10 : (unit -> (JSX.Element [])) = closure72()
    let v11 : Mut2 = method69(v0, v5, v6)
    let v12 : Mut2 = method6(v10, v11)
    let v13 : ((string * obj) []) = method7(v12)
    let v14 : obj = createObj v13
    let v15 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v16 : string = "createComponent"
    let v17 : string = "solid-js"
    let v18 : JS.Function = import v16 v17
    let v19 : JSX.Element = v18.Invoke (v15, v14) |> unbox<JSX.Element>
    v19
and closure86 () (v0 : Mut1) : US0 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v2
and closure89 (v0 : Mut1) (v1 : US0) : unit =
    v0.l1 <- v1
    ()
and closure88 () (v0 : Mut1) : (US0 -> unit) =
    closure89(v0)
and closure87 () (v0 : Mut1) : (Mut1 -> (US0 -> unit)) =
    closure88()
and closure83 () () : (JSX.Element []) =
    let v0 : (Mut7 -> JSX.Element) = closure84()
    let v1 : (Mut1 -> US0) = closure86()
    let v2 : (Mut1 -> (Mut1 -> (US0 -> unit))) = closure87()
    let v3 : Mut7 = {l0 = v1; l1 = v2} : Mut7
    let v4 : obj = v3
    let v5 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v5, v4) |> unbox<JSX.Element>
    [|v9|]
and method68 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "Port"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : string = "3px"
    let v67 : US1 = US1_1(v66)
    v62.l43 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure83()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and closure69 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let v1 : Mut2 = method65()
    let v2 : US11 = US11_0
    let v3 : US12 = US12_2
    let v4 : Mut3 = {l0 = v2; l1 = v1; l2 = v3} : Mut3
    let v5 : obj = v4
    let v6 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v6, v5) |> unbox<JSX.Element>
    let v11 : Mut2 = method67()
    let v12 : US11 = US11_0
    let v13 : US12 = US12_2
    let v14 : Mut3 = {l0 = v12; l1 = v11; l2 = v13} : Mut3
    let v15 : obj = v14
    let v16 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v17 : JS.Function = import v7 v8
    let v18 : JSX.Element = v17.Invoke (v16, v15) |> unbox<JSX.Element>
    let v19 : Mut2 = method68()
    let v20 : US11 = US11_0
    let v21 : US12 = US12_2
    let v22 : Mut3 = {l0 = v20; l1 = v19; l2 = v21} : Mut3
    let v23 : obj = v22
    let v24 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v25 : JS.Function = import v7 v8
    let v26 : JSX.Element = v25.Invoke (v24, v23) |> unbox<JSX.Element>
    [|v10; v18; v26|]
and closure68 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : Mut2 = method64()
    let v3 : (unit -> (JSX.Element [])) = closure69()
    let v4 : Mut2 = method6(v3, v2)
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61
    "create_component -> create_custom_component" |> ignore
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : obj = v67
    let v69 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v69, v68) |> unbox<JSX.Element>
    v73
and method70 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure90 () () : (JSX.Element []) =
    [||]
and closure67 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure68()
    let v1 : Mut2 = method70()
    let v2 : (unit -> (JSX.Element [])) = closure90()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method63 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "Connection"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : (unit -> (JSX.Element [])) = closure67()
    let v67 : US5 = US5_1(v66)
    v62.l9 <- v67
    v62
and method72 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method74 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure98 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US1 =
    US1_1(v0)
and closure101 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US1) : unit =
    let struct (v7 : (struct (string * string * string * string) []), v8 : US0, v9 : US1, v10 : US1) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (string * string * string * string) []) = Array.zeroCreate<struct (string * string * string * string)> (v11)
    let v13 : Mut5 = {l0 = 0} : Mut5
    while method19(v11, v13) do
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
and closure100 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US1 -> unit) =
    closure101(v0, v1, v2, v3, v4, v5)
and closure99 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure100(v0, v1, v2, v3, v4)
and closure97 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut6 -> JSX.Element) = closure71()
    let v5 : (Mut1 -> US1) = closure98(v0, v1, v2, v3)
    let v6 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure99(v0, v1, v2, v3)
    let v7 : Mut6 = {l0 = v5; l1 = v6} : Mut6
    let v8 : obj = v7
    let v9 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    [|v13|]
and method75 (v0 : Mut2, v1 : string, v2 : string, v3 : string, v4 : string) : Mut2 =
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : string = "Address"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : US8 = US8_1(v69)
    v67.l55 <- v70
    let v71 : string = "3px"
    let v72 : US1 = US1_1(v71)
    v67.l43 <- v72
    let v73 : (unit -> (JSX.Element [])) = closure97(v1, v2, v3, v4)
    let v74 : US5 = US5_1(v73)
    v0.l9 <- v74
    v67
and closure103 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US1 =
    US1_1(v3)
and closure106 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US1) : unit =
    let struct (v7 : (struct (string * string * string * string) []), v8 : US0, v9 : US1, v10 : US1) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (string * string * string * string) []) = Array.zeroCreate<struct (string * string * string * string)> (v11)
    let v13 : Mut5 = {l0 = 0} : Mut5
    while method19(v11, v13) do
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
and closure105 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US1 -> unit) =
    closure106(v0, v1, v2, v3, v4, v5)
and closure104 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure105(v0, v1, v2, v3, v4)
and closure102 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut6 -> JSX.Element) = closure71()
    let v5 : (Mut1 -> US1) = closure103(v0, v1, v2, v3)
    let v6 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure104(v0, v1, v2, v3)
    let v7 : Mut6 = {l0 = v5; l1 = v6} : Mut6
    let v8 : obj = v7
    let v9 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    [|v13|]
and method76 (v0 : Mut2, v1 : string, v2 : string, v3 : string, v4 : string) : Mut2 =
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : string = "Private Key"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : US8 = US8_1(v69)
    v67.l55 <- v70
    let v71 : string = "3px"
    let v72 : US1 = US1_1(v71)
    v67.l43 <- v72
    let v73 : (unit -> (JSX.Element [])) = closure102(v1, v2, v3, v4)
    let v74 : US5 = US5_1(v73)
    v0.l9 <- v74
    v67
and closure96 (v0 : Mut2, v1 : string, v2 : string, v3 : string, v4 : string) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure10()
    let v6 : Mut2 = method75(v0, v1, v2, v3, v4)
    let v7 : US11 = US11_0
    let v8 : US12 = US12_2
    let v9 : Mut3 = {l0 = v7; l1 = v6; l2 = v8} : Mut3
    let v10 : obj = v9
    let v11 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v12 : string = "createComponent"
    let v13 : string = "solid-js"
    let v14 : JS.Function = import v12 v13
    let v15 : JSX.Element = v14.Invoke (v11, v10) |> unbox<JSX.Element>
    let v16 : Mut2 = method76(v0, v1, v2, v3, v4)
    let v17 : US11 = US11_0
    let v18 : US12 = US12_2
    let v19 : Mut3 = {l0 = v17; l1 = v16; l2 = v18} : Mut3
    let v20 : obj = v19
    let v21 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v22 : JS.Function = import v12 v13
    let v23 : JSX.Element = v22.Invoke (v21, v20) |> unbox<JSX.Element>
    [|v15; v23|]
and closure95 (v0 : Mut2, v1 : string, v2 : string, v3 : string, v4 : string) () : (JSX.Element []) =
    let v5 : (Mut2 -> JSX.Element) = closure6()
    let v6 : Mut2 = method74()
    let v7 : (unit -> (JSX.Element [])) = closure96(v0, v1, v2, v3, v4)
    let v8 : Mut2 = method6(v7, v6)
    let struct (v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US6, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6, v8.l7, v8.l8, v8.l9, v8.l10, v8.l11, v8.l12, v8.l13, v8.l14, v8.l15, v8.l16, v8.l17, v8.l18, v8.l19, v8.l20, v8.l21, v8.l22, v8.l23, v8.l24, v8.l25, v8.l26, v8.l27, v8.l28, v8.l29, v8.l30, v8.l31, v8.l32, v8.l33, v8.l34, v8.l35, v8.l36, v8.l37, v8.l38, v8.l39, v8.l40, v8.l41, v8.l42, v8.l43, v8.l44, v8.l45, v8.l46, v8.l47, v8.l48, v8.l49, v8.l50, v8.l51, v8.l52, v8.l53, v8.l54, v8.l55, v8.l56, v8.l57, v8.l58, v8.l59, v8.l60, v8.l61
    "create_component -> create_custom_component" |> ignore
    let v71 : Mut2 = {l0 = v9; l1 = v10; l2 = v11; l3 = v12; l4 = v13; l5 = v14; l6 = v15; l7 = v16; l8 = v17; l9 = v18; l10 = v19; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v33; l25 = v34; l26 = v35; l27 = v36; l28 = v37; l29 = v38; l30 = v39; l31 = v40; l32 = v41; l33 = v42; l34 = v43; l35 = v44; l36 = v45; l37 = v46; l38 = v47; l39 = v48; l40 = v49; l41 = v50; l42 = v51; l43 = v52; l44 = v53; l45 = v54; l46 = v55; l47 = v56; l48 = v57; l49 = v58; l50 = v59; l51 = v60; l52 = v61; l53 = v62; l54 = v63; l55 = v64; l56 = v65; l57 = v66; l58 = v67; l59 = v68; l60 = v69; l61 = v70} : Mut2
    let v72 : obj = v71
    let v73 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v73, v72) |> unbox<JSX.Element>
    [|v77|]
and method73 (v0 : Mut2, v1 : string, v2 : string, v3 : string, v4 : string) : Mut2 =
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : JSX.Element = Html.fragment [ v2 |> unbox<JSX.Element> ]
    let v69 : US8 = US8_1(v68)
    v67.l55 <- v69
    let v70 : (unit -> (JSX.Element [])) = closure95(v0, v1, v2, v3, v4)
    let v71 : US5 = US5_1(v70)
    v0.l9 <- v71
    v67
and closure94 (v0 : Mut2) struct (v1 : string, v2 : string, v3 : string, v4 : string) : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure10()
    let v6 : Mut2 = method73(v0, v1, v2, v3, v4)
    let v7 : US11 = US11_0
    let v8 : US12 = US12_2
    let v9 : Mut3 = {l0 = v7; l1 = v6; l2 = v8} : Mut3
    let v10 : obj = v9
    let v11 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v12 : string = "createComponent"
    let v13 : string = "solid-js"
    let v14 : JS.Function = import v12 v13
    let v15 : JSX.Element = v14.Invoke (v11, v10) |> unbox<JSX.Element>
    [|v15|]
and method77 (v0 : (struct (string * string * string * string) [])) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v65 : (struct (string * string * string * string) []) = [||]
    let v66 : int32 = v0.Length
    let v67 : (obj []) = Array.zeroCreate<obj> (v66)
    let v68 : Mut5 = {l0 = 0} : Mut5
    while method19(v66, v68) do
        let v70 : int32 = v68.l0
        let struct (v71 : string, v72 : string, v73 : string, v74 : string) = v0.[int v70]
        let v75 : obj = struct (v71, v72, v73, v74)
        v67.[int v70] <- v75
        let v76 : int32 = v70 + 1
        v68.l0 <- v76
        ()
    let v77 : US7 = US7_1(v67)
    v63.l17 <- v77
    v63
and closure93 (v0 : Mut2, v1 : Mut1) () : (JSX.Element []) =
    let struct (v2 : (struct (string * string * string * string) []), v3 : US0, v4 : US1, v5 : US1) = v1.l0, v1.l1, v1.l2, v1.l3
    let v6 : string = "For"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (struct (string * string * string * string) -> (JSX.Element [])) = closure94(v0)
    let v10 : (unit -> (JSX.Element [])) = v9 |> unbox
    let v11 : Mut2 = method77(v2)
    let v12 : Mut2 = method6(v10, v11)
    let v13 : ((string * obj) []) = method7(v12)
    let v14 : obj = createObj v13
    let v15 : (obj -> JSX.Element) = v8 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v16 : string = "createComponent"
    let v17 : JS.Function = import v16 v7
    let v18 : JSX.Element = v17.Invoke (v15, v14) |> unbox<JSX.Element>
    [|v18|]
and closure92 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : (Mut2 -> JSX.Element) = closure6()
    let v8 : Mut2 = method72()
    let v9 : (unit -> (JSX.Element [])) = closure93(v0, v5)
    let v10 : Mut2 = method6(v9, v8)
    let struct (v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US6, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = v10.l0, v10.l1, v10.l2, v10.l3, v10.l4, v10.l5, v10.l6, v10.l7, v10.l8, v10.l9, v10.l10, v10.l11, v10.l12, v10.l13, v10.l14, v10.l15, v10.l16, v10.l17, v10.l18, v10.l19, v10.l20, v10.l21, v10.l22, v10.l23, v10.l24, v10.l25, v10.l26, v10.l27, v10.l28, v10.l29, v10.l30, v10.l31, v10.l32, v10.l33, v10.l34, v10.l35, v10.l36, v10.l37, v10.l38, v10.l39, v10.l40, v10.l41, v10.l42, v10.l43, v10.l44, v10.l45, v10.l46, v10.l47, v10.l48, v10.l49, v10.l50, v10.l51, v10.l52, v10.l53, v10.l54, v10.l55, v10.l56, v10.l57, v10.l58, v10.l59, v10.l60, v10.l61
    "create_component -> create_custom_component" |> ignore
    let v73 : Mut2 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14; l4 = v15; l5 = v16; l6 = v17; l7 = v18; l8 = v19; l9 = v20; l10 = v21; l11 = v22; l12 = v23; l13 = v24; l14 = v25; l15 = v26; l16 = v27; l17 = v28; l18 = v29; l19 = v30; l20 = v31; l21 = v32; l22 = v33; l23 = v34; l24 = v35; l25 = v36; l26 = v37; l27 = v38; l28 = v39; l29 = v40; l30 = v41; l31 = v42; l32 = v43; l33 = v44; l34 = v45; l35 = v46; l36 = v47; l37 = v48; l38 = v49; l39 = v50; l40 = v51; l41 = v52; l42 = v53; l43 = v54; l44 = v55; l45 = v56; l46 = v57; l47 = v58; l48 = v59; l49 = v60; l50 = v61; l51 = v62; l52 = v63; l53 = v64; l54 = v65; l55 = v66; l56 = v67; l57 = v68; l58 = v69; l59 = v70; l60 = v71; l61 = v72} : Mut2
    let v74 : obj = v73
    let v75 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v76 : string = "createComponent"
    let v77 : string = "solid-js"
    let v78 : JS.Function = import v76 v77
    let v79 : JSX.Element = v78.Invoke (v75, v74) |> unbox<JSX.Element>
    v79
and method78 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure107 () () : (JSX.Element []) =
    [||]
and closure91 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure92()
    let v1 : Mut2 = method78()
    let v2 : (unit -> (JSX.Element [])) = closure107()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method71 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "Accounts"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : (unit -> (JSX.Element [])) = closure91()
    let v67 : US5 = US5_1(v66)
    v62.l9 <- v67
    v62
and closure109 () () : (JSX.Element []) =
    [||]
and method80 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "https://bank.testnet.algorand.network"
    let v64 : US1 = US1_1(v63)
    v62.l52 <- v64
    let v65 : string = "algorand testnet bank"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v62.l55 <- v67
    let v68 : string = "#aaa"
    let v69 : US1 = US1_1(v68)
    v62.l2 <- v69
    let v70 : string = "350px"
    let v71 : US1 = US1_1(v70)
    v62.l22 <- v71
    let v72 : string = "1"
    let v73 : US1 = US1_1(v72)
    v62.l19 <- v73
    v62
and closure108 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let v4 : (unit -> (JSX.Element [])) = closure109()
    let v5 : Mut2 = method80()
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    [|v13|]
and method79 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "Testnet Bank Dispenser"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : US8 = US8_1(v64)
    v62.l55 <- v65
    let v66 : (unit -> (JSX.Element [])) = closure108()
    let v67 : US5 = US5_1(v66)
    v62.l9 <- v67
    v62
and closure66 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let v1 : Mut2 = method63()
    let v2 : US11 = US11_0
    let v3 : US12 = US12_2
    let v4 : Mut3 = {l0 = v2; l1 = v1; l2 = v3} : Mut3
    let v5 : obj = v4
    let v6 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v6, v5) |> unbox<JSX.Element>
    let v11 : Mut2 = method71()
    let v12 : US11 = US11_0
    let v13 : US12 = US12_2
    let v14 : Mut3 = {l0 = v12; l1 = v11; l2 = v13} : Mut3
    let v15 : obj = v14
    let v16 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v17 : JS.Function = import v7 v8
    let v18 : JSX.Element = v17.Invoke (v16, v15) |> unbox<JSX.Element>
    let v19 : Mut2 = method79()
    let v20 : US11 = US11_0
    let v21 : US12 = US12_0
    let v22 : Mut3 = {l0 = v20; l1 = v19; l2 = v21} : Mut3
    let v23 : obj = v22
    let v24 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v25 : JS.Function = import v7 v8
    let v26 : JSX.Element = v25.Invoke (v24, v23) |> unbox<JSX.Element>
    [|v10; v18; v26|]
and closure65 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : Mut2 = method62()
    let v3 : (unit -> (JSX.Element [])) = closure66()
    let v4 : Mut2 = method6(v3, v2)
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61
    "create_component -> create_custom_component" |> ignore
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : obj = v67
    let v69 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v69, v68) |> unbox<JSX.Element>
    v73
and method81 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure110 () () : (JSX.Element []) =
    [||]
and closure64 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure65()
    let v1 : Mut2 = method81()
    let v2 : (unit -> (JSX.Element [])) = closure110()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method61 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "db"
    let v64 : US1 = US1_1(v63)
    v62.l25 <- v64
    let v65 : string = "Chain"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v62.l55 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure64()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and method82 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method84 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method86 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method88 (v0 : int32, v1 : Mut10) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure119 (v0 : Mut9) (v1 : Mut1) : US1 =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v4 : (struct (US2 * int32 * string * string) -> US1) = v0.l1
    let v5 : int32 = v2.Length
    let v6 : US1 = US1_0
    let v7 : Mut10 = {l0 = 0; l1 = v6} : Mut10
    while method88(v5, v7) do
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
and method89 (v0 : int32, v1 : Mut11) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method90 () : struct (US2 * int32 * string * string) =
    let v0 : US2 = US2_1
    let v1 : string = ""
    struct (v0, 0, v1, v1)
and closure122 (v0 : Mut9, v1 : Mut1) (v2 : US1) : unit =
    let struct (v3 : (struct (US2 * int32 * string * string) []), v4 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let struct (v5 : (struct (US2 * int32 * string * string) []), v6 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v7 : int32 = v5.Length
    let v8 : US13 = US13_0
    let v9 : Mut11 = {l0 = 0; l1 = v8} : Mut11
    while method89(v7, v9) do
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
    let struct (v32 : US2, v33 : int32, v34 : string, v35 : string) = method90()
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
    while method19(v53, v55) do
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
and closure121 (v0 : Mut9) (v1 : Mut1) : (US1 -> unit) =
    closure122(v0, v1)
and closure120 (v0 : Mut9) (v1 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure121(v0)
and closure118 () (v0 : Mut9) : JSX.Element =
    let v1 : (Mut6 -> JSX.Element) = closure71()
    let v2 : (Mut1 -> US1) = closure119(v0)
    let v3 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure120(v0)
    let v4 : Mut6 = {l0 = v2; l1 = v3} : Mut6
    let v5 : obj = v4
    let v6 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v6, v5) |> unbox<JSX.Element>
    v10
and closure123 () struct (v0 : US2, v1 : int32, v2 : string, v3 : string) : US1 =
    US1_1(v2)
and closure125 (v0 : Mut8, v1 : US2, v2 : int32, v3 : string, v4 : string) (v5 : US1) : struct (US2 * int32 * string * string) =
    let v6 : US2 = v0.l0
    let v9 : string =
        match v5 with
        | US1_0 -> (* None *)
            let v7 : string = ""
            v7
        | US1_1(v8) -> (* Some *)
            v8
    struct (v6, v2, v9, v4)
and closure124 (v0 : Mut8) struct (v1 : US2, v2 : int32, v3 : string, v4 : string) : (US1 -> struct (US2 * int32 * string * string)) =
    closure125(v0, v1, v2, v3, v4)
and closure117 (v0 : Mut8) () : (JSX.Element []) =
    let v1 : (Mut9 -> JSX.Element) = closure118()
    let v2 : US2 = v0.l0
    let v3 : (struct (US2 * int32 * string * string) -> US1) = closure123()
    let v4 : (struct (US2 * int32 * string * string) -> (US1 -> struct (US2 * int32 * string * string))) = closure124(v0)
    let v5 : Mut9 = {l0 = v2; l1 = v3; l2 = v4} : Mut9
    let v6 : obj = v5
    let v7 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v7, v6) |> unbox<JSX.Element>
    [|v11|]
and method87 (v0 : Mut8) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : string = "URL"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : US8 = US8_1(v65)
    v63.l55 <- v66
    let v67 : string = "3px"
    let v68 : US1 = US1_1(v67)
    v63.l43 <- v68
    let v69 : (unit -> (JSX.Element [])) = closure117(v0)
    let v70 : US5 = US5_1(v69)
    v63.l9 <- v70
    v63
and method92 (v0 : int32, v1 : Mut13) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure128 (v0 : Mut12) (v1 : Mut1) : US0 =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v4 : (struct (US2 * int32 * string * string) -> US0) = v0.l1
    let v5 : int32 = v2.Length
    let v6 : US0 = US0_0
    let v7 : Mut13 = {l0 = 0; l1 = v6} : Mut13
    while method92(v5, v7) do
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
and closure131 (v0 : Mut12, v1 : Mut1) (v2 : US0) : unit =
    let struct (v3 : (struct (US2 * int32 * string * string) []), v4 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let struct (v5 : (struct (US2 * int32 * string * string) []), v6 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v7 : int32 = v5.Length
    let v8 : US13 = US13_0
    let v9 : Mut11 = {l0 = 0; l1 = v8} : Mut11
    while method89(v7, v9) do
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
    let struct (v32 : US2, v33 : int32, v34 : string, v35 : string) = method90()
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
    while method19(v53, v55) do
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
and closure130 (v0 : Mut12) (v1 : Mut1) : (US0 -> unit) =
    closure131(v0, v1)
and closure129 (v0 : Mut12) (v1 : Mut1) : (Mut1 -> (US0 -> unit)) =
    closure130(v0)
and closure127 () (v0 : Mut12) : JSX.Element =
    let v1 : (Mut7 -> JSX.Element) = closure84()
    let v2 : (Mut1 -> US0) = closure128(v0)
    let v3 : (Mut1 -> (Mut1 -> (US0 -> unit))) = closure129(v0)
    let v4 : Mut7 = {l0 = v2; l1 = v3} : Mut7
    let v5 : obj = v4
    let v6 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v6, v5) |> unbox<JSX.Element>
    v10
and closure132 () struct (v0 : US2, v1 : int32, v2 : string, v3 : string) : US0 =
    US0_1(v1)
and closure134 (v0 : Mut8, v1 : US2, v2 : int32, v3 : string, v4 : string) (v5 : US0) : struct (US2 * int32 * string * string) =
    let v6 : US2 = v0.l0
    let v8 : int32 =
        match v5 with
        | US0_0 -> (* None *)
            0
        | US0_1(v7) -> (* Some *)
            v7
    struct (v6, v8, v3, v4)
and closure133 (v0 : Mut8) struct (v1 : US2, v2 : int32, v3 : string, v4 : string) : (US0 -> struct (US2 * int32 * string * string)) =
    closure134(v0, v1, v2, v3, v4)
and closure126 (v0 : Mut8) () : (JSX.Element []) =
    let v1 : (Mut12 -> JSX.Element) = closure127()
    let v2 : US2 = v0.l0
    let v3 : (struct (US2 * int32 * string * string) -> US0) = closure132()
    let v4 : (struct (US2 * int32 * string * string) -> (US0 -> struct (US2 * int32 * string * string))) = closure133(v0)
    let v5 : Mut12 = {l0 = v2; l1 = v3; l2 = v4} : Mut12
    let v6 : obj = v5
    let v7 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v7, v6) |> unbox<JSX.Element>
    [|v11|]
and method91 (v0 : Mut8) : Mut2 =
    let struct (v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62} : Mut2
    let v64 : string = "Port"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : US8 = US8_1(v65)
    v63.l55 <- v66
    let v67 : string = "3px"
    let v68 : US1 = US1_1(v67)
    v63.l43 <- v68
    let v69 : (unit -> (JSX.Element [])) = closure126(v0)
    let v70 : US5 = US5_1(v69)
    v63.l9 <- v70
    v63
and closure116 (v0 : Mut8) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure10()
    let v2 : Mut2 = method87(v0)
    let v3 : US11 = US11_0
    let v4 : US12 = US12_2
    let v5 : Mut3 = {l0 = v3; l1 = v2; l2 = v4} : Mut3
    let v6 : obj = v5
    let v7 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v7, v6) |> unbox<JSX.Element>
    let v12 : Mut2 = method91(v0)
    let v13 : US11 = US11_0
    let v14 : US12 = US12_2
    let v15 : Mut3 = {l0 = v13; l1 = v12; l2 = v14} : Mut3
    let v16 : obj = v15
    let v17 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v18 : JS.Function = import v8 v9
    let v19 : JSX.Element = v18.Invoke (v17, v16) |> unbox<JSX.Element>
    [|v11; v19|]
and closure115 () (v0 : Mut8) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : Mut2 = method86()
    let v3 : (unit -> (JSX.Element [])) = closure116(v0)
    let v4 : Mut2 = method6(v3, v2)
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61
    "create_component -> create_custom_component" |> ignore
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : obj = v67
    let v69 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v69, v68) |> unbox<JSX.Element>
    v73
and closure114 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure115()
    let v1 : US2 = US2_1
    let v2 : Mut8 = {l0 = v1} : Mut8
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and method85 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "db-gun-rs-rs"
    let v64 : US1 = US1_1(v63)
    v62.l25 <- v64
    let v65 : string = "Rust -> Rust"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v62.l55 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure114()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and closure138 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_1
    let v4 : US2 = US2_1
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method19(v8, v10) do
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
and closure137 () (v0 : Mut1) : (Mut1 -> unit) =
    closure138()
and closure136 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure137()
    v0 v1
    ()
and closure135 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure136()
and closure139 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure115()
    let v1 : US2 = US2_0
    let v2 : Mut8 = {l0 = v1} : Mut8
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and method93 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "db-gun-rs-js"
    let v64 : US1 = US1_1(v63)
    v62.l25 <- v64
    let v65 : string = "Rust -> JavaScript"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v62.l55 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure139()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and closure143 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_1
    let v4 : US2 = US2_0
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method19(v8, v10) do
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
and closure142 () (v0 : Mut1) : (Mut1 -> unit) =
    closure143()
and closure141 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure142()
    v0 v1
    ()
and closure140 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure141()
and closure144 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure115()
    let v1 : US2 = US2_0
    let v2 : Mut8 = {l0 = v1} : Mut8
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and method94 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "db-gun-js-js"
    let v64 : US1 = US1_1(v63)
    v62.l25 <- v64
    let v65 : string = "JavaScript -> JavaScript"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v62.l55 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure144()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and closure148 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_0
    let v4 : US2 = US2_0
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method19(v8, v10) do
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
and closure147 () (v0 : Mut1) : (Mut1 -> unit) =
    closure148()
and closure146 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure147()
    v0 v1
    ()
and closure145 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure146()
and closure149 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure115()
    let v1 : US2 = US2_1
    let v2 : Mut8 = {l0 = v1} : Mut8
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and method95 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "db-gun-js-rs"
    let v64 : US1 = US1_1(v63)
    v62.l25 <- v64
    let v65 : string = "JavaScript -> Rust"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v62.l55 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure149()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and closure153 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_0
    let v4 : US2 = US2_1
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method19(v8, v10) do
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
and closure152 () (v0 : Mut1) : (Mut1 -> unit) =
    closure153()
and closure151 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure152()
    v0 v1
    ()
and closure150 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure151()
and closure113 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let v1 : Mut2 = method85()
    let v2 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure135()
    let v3 : US11 = US11_1(v2)
    let v4 : US12 = US12_0
    let v5 : Mut3 = {l0 = v3; l1 = v1; l2 = v4} : Mut3
    let v6 : obj = v5
    let v7 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v7, v6) |> unbox<JSX.Element>
    let v12 : Mut2 = method93()
    let v13 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure140()
    let v14 : US11 = US11_1(v13)
    let v15 : US12 = US12_0
    let v16 : Mut3 = {l0 = v14; l1 = v12; l2 = v15} : Mut3
    let v17 : obj = v16
    let v18 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v19 : JS.Function = import v8 v9
    let v20 : JSX.Element = v19.Invoke (v18, v17) |> unbox<JSX.Element>
    let v21 : Mut2 = method94()
    let v22 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure145()
    let v23 : US11 = US11_1(v22)
    let v24 : US12 = US12_0
    let v25 : Mut3 = {l0 = v23; l1 = v21; l2 = v24} : Mut3
    let v26 : obj = v25
    let v27 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v28 : JS.Function = import v8 v9
    let v29 : JSX.Element = v28.Invoke (v27, v26) |> unbox<JSX.Element>
    let v30 : Mut2 = method95()
    let v31 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure150()
    let v32 : US11 = US11_1(v31)
    let v33 : US12 = US12_0
    let v34 : Mut3 = {l0 = v32; l1 = v30; l2 = v33} : Mut3
    let v35 : obj = v34
    let v36 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v37 : JS.Function = import v8 v9
    let v38 : JSX.Element = v37.Invoke (v36, v35) |> unbox<JSX.Element>
    [|v11; v20; v29; v38|]
and closure112 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : Mut2 = method84()
    let v3 : (unit -> (JSX.Element [])) = closure113()
    let v4 : Mut2 = method6(v3, v2)
    let struct (v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US6, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61
    "create_component -> create_custom_component" |> ignore
    let v67 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66} : Mut2
    let v68 : obj = v67
    let v69 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v69, v68) |> unbox<JSX.Element>
    v73
and method96 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure154 () () : (JSX.Element []) =
    [||]
and closure111 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure112()
    let v1 : Mut2 = method96()
    let v2 : (unit -> (JSX.Element [])) = closure154()
    let v3 : Mut2 = method6(v2, v1)
    let struct (v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US6, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61
    "create_component -> create_custom_component" |> ignore
    let v66 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65} : Mut2
    let v67 : obj = v66
    let v68 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v68, v67) |> unbox<JSX.Element>
    [|v72|]
and method83 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "db"
    let v64 : US1 = US1_1(v63)
    v62.l25 <- v64
    let v65 : string = "Database"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : US8 = US8_1(v66)
    v62.l55 <- v67
    let v68 : (unit -> (JSX.Element [])) = closure111()
    let v69 : US5 = US5_1(v68)
    v62.l9 <- v69
    v62
and method97 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and method99 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure158 () () : (JSX.Element []) =
    [||]
and method100 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure157 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure158()
    let v5 : Mut2 = method100()
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    v13
and method101 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure159 () () : (JSX.Element []) =
    [||]
and closure161 () () : (JSX.Element []) =
    [||]
and method102 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure160 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure161()
    let v5 : Mut2 = method102()
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    v13
and method103 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure162 () () : (JSX.Element []) =
    [||]
and closure164 () () : (JSX.Element []) =
    [||]
and method104 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure163 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure164()
    let v5 : Mut2 = method104()
    let v6 : Mut2 = method6(v4, v5)
    let v7 : ((string * obj) []) = method7(v6)
    let v8 : obj = createObj v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    v13
and method105 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
and closure165 () () : (JSX.Element []) =
    [||]
and closure156 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut2 -> JSX.Element) = closure157()
    let v4 : Mut2 = method101()
    let v5 : (unit -> (JSX.Element [])) = closure159()
    let v6 : Mut2 = method6(v5, v4)
    let struct (v7 : US1, v8 : US3, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US4, v16 : US5, v17 : US1, v18 : US1, v19 : US4, v20 : US6, v21 : US1, v22 : US1, v23 : US1, v24 : US7, v25 : US4, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US6, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US9, v45 : US10, v46 : US9, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US8, v63 : US1, v64 : US1, v65 : US6, v66 : US1, v67 : US0, v68 : US1) = v6.l0, v6.l1, v6.l2, v6.l3, v6.l4, v6.l5, v6.l6, v6.l7, v6.l8, v6.l9, v6.l10, v6.l11, v6.l12, v6.l13, v6.l14, v6.l15, v6.l16, v6.l17, v6.l18, v6.l19, v6.l20, v6.l21, v6.l22, v6.l23, v6.l24, v6.l25, v6.l26, v6.l27, v6.l28, v6.l29, v6.l30, v6.l31, v6.l32, v6.l33, v6.l34, v6.l35, v6.l36, v6.l37, v6.l38, v6.l39, v6.l40, v6.l41, v6.l42, v6.l43, v6.l44, v6.l45, v6.l46, v6.l47, v6.l48, v6.l49, v6.l50, v6.l51, v6.l52, v6.l53, v6.l54, v6.l55, v6.l56, v6.l57, v6.l58, v6.l59, v6.l60, v6.l61
    "create_component -> create_custom_component" |> ignore
    let v69 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v17; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68} : Mut2
    let v70 : obj = v69
    let v71 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v71, v70) |> unbox<JSX.Element>
    let v76 : (Mut2 -> JSX.Element) = closure160()
    let v77 : Mut2 = method103()
    let v78 : (unit -> (JSX.Element [])) = closure162()
    let v79 : Mut2 = method6(v78, v77)
    let struct (v80 : US1, v81 : US3, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US4, v89 : US5, v90 : US1, v91 : US1, v92 : US4, v93 : US6, v94 : US1, v95 : US1, v96 : US1, v97 : US7, v98 : US4, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US8, v105 : US1, v106 : US1, v107 : US1, v108 : US6, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US9, v118 : US10, v119 : US9, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US8, v136 : US1, v137 : US1, v138 : US6, v139 : US1, v140 : US0, v141 : US1) = v79.l0, v79.l1, v79.l2, v79.l3, v79.l4, v79.l5, v79.l6, v79.l7, v79.l8, v79.l9, v79.l10, v79.l11, v79.l12, v79.l13, v79.l14, v79.l15, v79.l16, v79.l17, v79.l18, v79.l19, v79.l20, v79.l21, v79.l22, v79.l23, v79.l24, v79.l25, v79.l26, v79.l27, v79.l28, v79.l29, v79.l30, v79.l31, v79.l32, v79.l33, v79.l34, v79.l35, v79.l36, v79.l37, v79.l38, v79.l39, v79.l40, v79.l41, v79.l42, v79.l43, v79.l44, v79.l45, v79.l46, v79.l47, v79.l48, v79.l49, v79.l50, v79.l51, v79.l52, v79.l53, v79.l54, v79.l55, v79.l56, v79.l57, v79.l58, v79.l59, v79.l60, v79.l61
    "create_component -> create_custom_component" |> ignore
    let v142 : Mut2 = {l0 = v80; l1 = v81; l2 = v82; l3 = v83; l4 = v84; l5 = v85; l6 = v86; l7 = v87; l8 = v88; l9 = v89; l10 = v90; l11 = v91; l12 = v92; l13 = v93; l14 = v94; l15 = v95; l16 = v96; l17 = v97; l18 = v98; l19 = v99; l20 = v100; l21 = v101; l22 = v102; l23 = v103; l24 = v104; l25 = v105; l26 = v106; l27 = v107; l28 = v108; l29 = v109; l30 = v110; l31 = v111; l32 = v112; l33 = v113; l34 = v114; l35 = v115; l36 = v116; l37 = v117; l38 = v118; l39 = v119; l40 = v120; l41 = v121; l42 = v122; l43 = v123; l44 = v124; l45 = v125; l46 = v126; l47 = v127; l48 = v128; l49 = v129; l50 = v130; l51 = v131; l52 = v132; l53 = v133; l54 = v134; l55 = v135; l56 = v136; l57 = v137; l58 = v138; l59 = v139; l60 = v140; l61 = v141} : Mut2
    let v143 : obj = v142
    let v144 : (obj -> JSX.Element) = v76 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v145 : JS.Function = import v72 v73
    let v146 : JSX.Element = v145.Invoke (v144, v143) |> unbox<JSX.Element>
    let v148 : bool = v1 = ""
    let v149 : bool = v148 <> true
    let v151 : JSX.Element =
        if v149 then
            v146
        else
            let v150 : JSX.Element = Html.fragment []
            v150
    let v152 : (Mut2 -> JSX.Element) = closure163()
    let v153 : Mut2 = method105()
    let v154 : (unit -> (JSX.Element [])) = closure165()
    let v155 : Mut2 = method6(v154, v153)
    let struct (v156 : US1, v157 : US3, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US4, v165 : US5, v166 : US1, v167 : US1, v168 : US4, v169 : US6, v170 : US1, v171 : US1, v172 : US1, v173 : US7, v174 : US4, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US8, v181 : US1, v182 : US1, v183 : US1, v184 : US6, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US9, v194 : US10, v195 : US9, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US8, v212 : US1, v213 : US1, v214 : US6, v215 : US1, v216 : US0, v217 : US1) = v155.l0, v155.l1, v155.l2, v155.l3, v155.l4, v155.l5, v155.l6, v155.l7, v155.l8, v155.l9, v155.l10, v155.l11, v155.l12, v155.l13, v155.l14, v155.l15, v155.l16, v155.l17, v155.l18, v155.l19, v155.l20, v155.l21, v155.l22, v155.l23, v155.l24, v155.l25, v155.l26, v155.l27, v155.l28, v155.l29, v155.l30, v155.l31, v155.l32, v155.l33, v155.l34, v155.l35, v155.l36, v155.l37, v155.l38, v155.l39, v155.l40, v155.l41, v155.l42, v155.l43, v155.l44, v155.l45, v155.l46, v155.l47, v155.l48, v155.l49, v155.l50, v155.l51, v155.l52, v155.l53, v155.l54, v155.l55, v155.l56, v155.l57, v155.l58, v155.l59, v155.l60, v155.l61
    "create_component -> create_custom_component" |> ignore
    let v218 : Mut2 = {l0 = v156; l1 = v157; l2 = v158; l3 = v159; l4 = v160; l5 = v161; l6 = v162; l7 = v163; l8 = v164; l9 = v165; l10 = v166; l11 = v167; l12 = v168; l13 = v169; l14 = v170; l15 = v171; l16 = v172; l17 = v173; l18 = v174; l19 = v175; l20 = v176; l21 = v177; l22 = v178; l23 = v179; l24 = v180; l25 = v181; l26 = v182; l27 = v183; l28 = v184; l29 = v185; l30 = v186; l31 = v187; l32 = v188; l33 = v189; l34 = v190; l35 = v191; l36 = v192; l37 = v193; l38 = v194; l39 = v195; l40 = v196; l41 = v197; l42 = v198; l43 = v199; l44 = v200; l45 = v201; l46 = v202; l47 = v203; l48 = v204; l49 = v205; l50 = v206; l51 = v207; l52 = v208; l53 = v209; l54 = v210; l55 = v211; l56 = v212; l57 = v213; l58 = v214; l59 = v215; l60 = v216; l61 = v217} : Mut2
    let v219 : obj = v218
    let v220 : (obj -> JSX.Element) = v152 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v221 : JS.Function = import v72 v73
    let v222 : JSX.Element = v221.Invoke (v220, v219) |> unbox<JSX.Element>
    let v225 : JSX.Element =
        if v149 then
            v222
        else
            let v224 : JSX.Element = Html.fragment []
            v224
    [|v75; v151; v225|]
and closure155 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut2 -> JSX.Element) = closure6()
    let v4 : Mut2 = method99()
    let v5 : (unit -> (JSX.Element [])) = closure156(v0, v1, v2)
    let v6 : Mut2 = method6(v5, v4)
    let struct (v7 : US1, v8 : US3, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US4, v16 : US5, v17 : US1, v18 : US1, v19 : US4, v20 : US6, v21 : US1, v22 : US1, v23 : US1, v24 : US7, v25 : US4, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US6, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US9, v45 : US10, v46 : US9, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US8, v63 : US1, v64 : US1, v65 : US6, v66 : US1, v67 : US0, v68 : US1) = v6.l0, v6.l1, v6.l2, v6.l3, v6.l4, v6.l5, v6.l6, v6.l7, v6.l8, v6.l9, v6.l10, v6.l11, v6.l12, v6.l13, v6.l14, v6.l15, v6.l16, v6.l17, v6.l18, v6.l19, v6.l20, v6.l21, v6.l22, v6.l23, v6.l24, v6.l25, v6.l26, v6.l27, v6.l28, v6.l29, v6.l30, v6.l31, v6.l32, v6.l33, v6.l34, v6.l35, v6.l36, v6.l37, v6.l38, v6.l39, v6.l40, v6.l41, v6.l42, v6.l43, v6.l44, v6.l45, v6.l46, v6.l47, v6.l48, v6.l49, v6.l50, v6.l51, v6.l52, v6.l53, v6.l54, v6.l55, v6.l56, v6.l57, v6.l58, v6.l59, v6.l60, v6.l61
    "create_component -> create_custom_component" |> ignore
    let v69 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v17; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68} : Mut2
    let v70 : obj = v69
    let v71 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v71, v70) |> unbox<JSX.Element>
    [|v75|]
and method98 (v0 : obj, v1 : string, v2 : bool) : Mut2 =
    let struct (v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US6, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64} : Mut2
    let v66 : string = "Profile"
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : US8 = US8_1(v67)
    v65.l55 <- v68
    let v69 : (unit -> (JSX.Element [])) = closure155(v0, v1, v2)
    let v70 : US5 = US5_1(v69)
    v65.l9 <- v70
    v65
and closure9 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut3 -> JSX.Element) = closure10()
    let v4 : Mut2 = method38()
    let v5 : US11 = US11_0
    let v6 : US12 = US12_2
    let v7 : Mut3 = {l0 = v5; l1 = v4; l2 = v6} : Mut3
    let v8 : obj = v7
    let v9 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    let v14 : Mut2 = method51()
    let v15 : US11 = US11_0
    let v16 : US12 = US12_2
    let v17 : Mut3 = {l0 = v15; l1 = v14; l2 = v16} : Mut3
    let v18 : obj = v17
    let v19 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v20 : JS.Function = import v10 v11
    let v21 : JSX.Element = v20.Invoke (v19, v18) |> unbox<JSX.Element>
    let v22 : Mut2 = method52()
    let v23 : US11 = US11_0
    let v24 : US12 = US12_2
    let v25 : Mut3 = {l0 = v23; l1 = v22; l2 = v24} : Mut3
    let v26 : obj = v25
    let v27 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v28 : JS.Function = import v10 v11
    let v29 : JSX.Element = v28.Invoke (v27, v26) |> unbox<JSX.Element>
    let v30 : Mut2 = method60()
    let v31 : US11 = US11_0
    let v32 : US12 = US12_2
    let v33 : Mut3 = {l0 = v31; l1 = v30; l2 = v32} : Mut3
    let v34 : obj = v33
    let v35 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v36 : JS.Function = import v10 v11
    let v37 : JSX.Element = v36.Invoke (v35, v34) |> unbox<JSX.Element>
    let v38 : Mut2 = method61()
    let v39 : US11 = US11_0
    let v40 : US12 = US12_0
    let v41 : Mut3 = {l0 = v39; l1 = v38; l2 = v40} : Mut3
    let v42 : obj = v41
    let v43 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v44 : JS.Function = import v10 v11
    let v45 : JSX.Element = v44.Invoke (v43, v42) |> unbox<JSX.Element>
    let v46 : Mut2 = method82()
    let v47 : US11 = US11_0
    let v48 : US12 = US12_2
    let v49 : Mut3 = {l0 = v47; l1 = v46; l2 = v48} : Mut3
    let v50 : obj = v49
    let v51 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v52 : JS.Function = import v10 v11
    let v53 : JSX.Element = v52.Invoke (v51, v50) |> unbox<JSX.Element>
    let v54 : Mut2 = method83()
    let v55 : US11 = US11_0
    let v56 : US12 = US12_0
    let v57 : Mut3 = {l0 = v55; l1 = v54; l2 = v56} : Mut3
    let v58 : obj = v57
    let v59 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v60 : JS.Function = import v10 v11
    let v61 : JSX.Element = v60.Invoke (v59, v58) |> unbox<JSX.Element>
    let v62 : Mut2 = method97()
    let v63 : US11 = US11_0
    let v64 : US12 = US12_2
    let v65 : Mut3 = {l0 = v63; l1 = v62; l2 = v64} : Mut3
    let v66 : obj = v65
    let v67 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v68 : JS.Function = import v10 v11
    let v69 : JSX.Element = v68.Invoke (v67, v66) |> unbox<JSX.Element>
    let v70 : Mut2 = method98(v0, v1, v2)
    let v71 : US11 = US11_0
    let v72 : US12 = US12_2
    let v73 : Mut3 = {l0 = v71; l1 = v70; l2 = v72} : Mut3
    let v74 : obj = v73
    let v75 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v76 : JS.Function = import v10 v11
    let v77 : JSX.Element = v76.Invoke (v75, v74) |> unbox<JSX.Element>
    [|v13; v21; v29; v37; v45; v53; v61; v69; v77|]
and closure5 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut2 -> JSX.Element) = closure6()
    let v4 : Mut2 = method12()
    let v5 : (unit -> (JSX.Element [])) = closure9(v0, v1, v2)
    let v6 : Mut2 = method6(v5, v4)
    let struct (v7 : US1, v8 : US3, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US4, v16 : US5, v17 : US1, v18 : US1, v19 : US4, v20 : US6, v21 : US1, v22 : US1, v23 : US1, v24 : US7, v25 : US4, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US6, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US9, v45 : US10, v46 : US9, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US8, v63 : US1, v64 : US1, v65 : US6, v66 : US1, v67 : US0, v68 : US1) = v6.l0, v6.l1, v6.l2, v6.l3, v6.l4, v6.l5, v6.l6, v6.l7, v6.l8, v6.l9, v6.l10, v6.l11, v6.l12, v6.l13, v6.l14, v6.l15, v6.l16, v6.l17, v6.l18, v6.l19, v6.l20, v6.l21, v6.l22, v6.l23, v6.l24, v6.l25, v6.l26, v6.l27, v6.l28, v6.l29, v6.l30, v6.l31, v6.l32, v6.l33, v6.l34, v6.l35, v6.l36, v6.l37, v6.l38, v6.l39, v6.l40, v6.l41, v6.l42, v6.l43, v6.l44, v6.l45, v6.l46, v6.l47, v6.l48, v6.l49, v6.l50, v6.l51, v6.l52, v6.l53, v6.l54, v6.l55, v6.l56, v6.l57, v6.l58, v6.l59, v6.l60, v6.l61
    "create_component -> create_custom_component" |> ignore
    let v69 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v17; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68} : Mut2
    let v70 : obj = v69
    let v71 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v71, v70) |> unbox<JSX.Element>
    [|v75|]
and method106 () : Mut2 =
    let struct (v0 : US1, v1 : US3, v2 : US1, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US4, v9 : US5, v10 : US1, v11 : US1, v12 : US4, v13 : US6, v14 : US1, v15 : US1, v16 : US1, v17 : US7, v18 : US4, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US8, v25 : US1, v26 : US1, v27 : US1, v28 : US6, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US9, v38 : US10, v39 : US9, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US6, v59 : US1, v60 : US0, v61 : US1) = method5()
    let v62 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61} : Mut2
    let v63 : string = "flex"
    let v64 : US1 = US1_1(v63)
    v62.l16 <- v64
    let v65 : string = "1"
    let v66 : US1 = US1_1(v65)
    v62.l19 <- v66
    let v67 : string = "column"
    let v68 : US1 = US1_1(v67)
    v62.l20 <- v68
    let v69 : string = "100vw"
    let v70 : US1 = US1_1(v69)
    v62.l36 <- v70
    let v71 : string = "100vh"
    let v72 : US1 = US1_1(v71)
    v62.l22 <- v72
    let v73 : string = "$bg"
    let v74 : US1 = US1_1(v73)
    v62.l2 <- v74
    let v75 : string = "$sm"
    let v76 : US1 = US1_1(v75)
    v62.l21 <- v76
    let v77 : string = "$text1"
    let v78 : US1 = US1_1(v77)
    v62.l10 <- v78
    let v79 : string = "1px"
    let v80 : US1 = US1_1(v79)
    v62.l43 <- v80
    v62
and closure4 () (v0 : Mut2) : JSX.Element =
    let struct (v1 : obj, v2 : string, v3 : bool) = method2()
    let v4 : string = "Box"
    let v5 : string = "@hope-ui/solid"
    let v6 : JS.Function = import v4 v5
    let v7 : (unit -> (JSX.Element [])) = closure5(v1, v2, v3)
    let v8 : Mut2 = method106()
    let v9 : Mut2 = method6(v7, v8)
    let v10 : ((string * obj) []) = method7(v9)
    let v11 : obj = createObj v10
    let v12 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v13 : string = "createComponent"
    let v14 : string = "solid-js"
    let v15 : JS.Function = import v13 v14
    let v16 : JSX.Element = v15.Invoke (v12, v11) |> unbox<JSX.Element>
    v16
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let struct (v64 : (struct (string * string * string * string) []), v65 : US0, v66 : US1, v67 : US1, v68 : (struct (US2 * int32 * string * string) []), v69 : (struct (US2 * US2) []), v70 : US1, v71 : US0) = method0()
let v72 : Mut1 = {l0 = v64; l1 = v65; l2 = v66; l3 = v67; l4 = v68; l5 = v69; l6 = v70; l7 = v71} : Mut1
let v73 : obj = v72
let v74 : (obj -> obj) = method1()
let v75 : obj = v74 v73
let v76 : int32 = Random().Next ()
let v77 : string = "db_listener"
let v78 : (Mut2 -> JSX.Element) = closure2(v75)
let v79 : (string * obj) = v77, v78
let v80 : string = "content"
let v81 : (Mut2 -> JSX.Element) = closure4()
let v82 : (string * obj) = v80, v81
let v83 : string = "store"
let v84 : (string * obj) = v83, v75
let v85 : string = "run_id"
let v86 : (string * obj) = v85, v76
let v87 : obj = emitJsExpr () "process.env"
let v88 : string = "env"
let v89 : (string * obj) = v88, v87
let v90 : ((string * obj) []) = [|v79; v82; v84; v86; v89|]
let v91 : obj = createObj v90
v1.l0 <- v91
Browser.Dom.window?components_spi <- v91
()
