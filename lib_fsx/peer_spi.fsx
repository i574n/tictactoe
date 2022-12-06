type Mut0 = {mutable l0 : obj}
and UH0 =
    | UH0_0 of string
    | UH0_1 of string * string
    | UH0_2 of string * string
    | UH0_3 of string * string * string
and [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : string
and UH1 =
    | UH1_0
    | UH1_1 of US0
    | UH1_2 of string * string * US0
    | UH1_3 of (string [])
    | UH1_4 of string * string * (string []) * (string [])
    | UH1_5 of bool
let rec closure0 () (v0 : UH0) : UH1 =
    let v1 : string = "request:"
    printfn $"%A{v1}"
    printfn $"%A{v0}"
    let v2 : obj = null
    let v3 : UH1 = v2 |> unbox<UH1>
    v3
let v0 : obj = null
let v1 : obj = v0 |> unbox<obj>
let v2 : Mut0 = {l0 = v1} : Mut0
let v3 : (UH0 -> UH1) = closure0()
let v4 : obj = v3
let v5 : string = "update"
let v6 : (string * obj) = v5, v4
let v7 : ((string * obj) []) = [|v6|]
let v8 : Map<string, obj> = Map v7
let v9 : obj = v8
v2.l0 <- v9
()
