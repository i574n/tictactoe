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
    let v2 : UH1 = null |> unbox<UH1>
    v2
let v0 : obj = null |> unbox<obj>
let v1 : Mut0 = {l0 = v0} : Mut0
let v2 : (UH0 -> UH1) = closure0()
let v3 : obj = v2
let v4 : string = "update"
let v5 : (string * obj) = v4, v3
let v6 : string = "/peer"
let v7 : obj = v6
let v8 : string = "endpoint"
let v9 : (string * obj) = v8, v7
let v10 : ((string * obj) []) = [|v5; v9|]
let v11 : Map<string, obj> = Map v10
let v12 : obj = v11
v1.l0 <- v12
()
