let rec method0 () : int32 =
    180
and closure0 () () : int32 =
    method0()
and method1 (v0 : string) : unit =
    printfn $"%A{v0}"
and method2 (v0 : bool) : unit =
    let v1 : bool = v0 = false
    if v1 then
        failwith<unit> "test"
and method3 (v0 : (int32 [])) : unit =
    printfn $"%A{v0}"
let v0 : (unit -> int32) = closure0()
let v1 : string = $"main.spi Loaded. Width: {v0 ()}"
method1(v1)
let v2 : string = "/########################################\\ start"
method1(v2)
let v3 : bool = true
method2(v3)
let v4 : string = System.String ('q', 17)
method1(v4)
let v5 : (int32 []) = [|3|]
method3(v5)
let v6 : string = "\\########################################/ end"
method1(v6)
