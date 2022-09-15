#r "nuget: Fable.Core, 4.0.0-theta-001"
open Fable.Core
open Fable.Core.JsInterop

let rec closure1 () (v0 : JSX.Element) : JSX.Element =
    let v1 : string = "flex"
    let v2 : obj = v1
    let v3 : string = "display"
    let v4 : string = "column"
    let v5 : obj = v4
    let v6 : string = "flexDirection"
    let v7 : obj = v0
    let v8 : string = "children"
    let v9 : (struct (string * obj) []) = [|struct (v3, v2); struct (v6, v5); struct (v8, v7)|]
    let v10 : JS.Function = import "Tbody" "@hope-ui/solid"
    let v11 : JSX.Element = JSX.create v10 (v9 |> unbox<JSX.Prop list>)
    let v12 : (JSX.Element []) = [|v11|]
    let v13 : JSX.Element = v12 |> unbox<JSX.Element>
    let v14 : obj = v1
    let v15 : obj = 1
    let v16 : obj = v4
    let v17 : string = "odd"
    let v18 : obj = v17
    let v19 : string = "striped"
    let v20 : obj = v13
    let v21 : (struct (string * obj) []) = [|struct (v3, v14); struct (v1, v15); struct (v6, v16); struct (v19, v18); struct (v8, v20)|]
    let v22 : JS.Function = import "Table" "@hope-ui/solid"
    let v23 : JSX.Element = JSX.create v22 (v21 |> unbox<JSX.Prop list>)
    v23
and closure0 () () : (JSX.Element -> JSX.Element) =
    closure1()
and closure2 () (v0 : string) : JSX.Element =
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : string = " "
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    let v4 : JS.Function = import "BiRegularLinkExternal" "solid-icons/bi"
    let v5 : obj = v4
    let v6 : string = "as"
    let v7 : (struct (string * obj) []) = [|struct (v6, v5)|]
    let v8 : JS.Function = import "Icon" "@hope-ui/solid"
    let v9 : JSX.Element = JSX.create v8 (v7 |> unbox<JSX.Prop list>)
    let v10 : (JSX.Element []) = [|v1; v3; v9|]
    let v11 : JSX.Element = v10 |> unbox<JSX.Element>
    let v12 : obj = true
    let v13 : string = "external"
    let v14 : obj = v0
    let v15 : string = "href"
    let v16 : obj = v11
    let v17 : string = "children"
    let v18 : (struct (string * obj) []) = [|struct (v13, v12); struct (v15, v14); struct (v17, v16)|]
    let v19 : JS.Function = import "Anchor" "@hope-ui/solid"
    let v20 : JSX.Element = JSX.create v19 (v18 |> unbox<JSX.Prop list>)
    v20
let v0 : (unit -> (JSX.Element -> JSX.Element)) = closure0()
let v1 : (string -> JSX.Element) = closure2()
()
