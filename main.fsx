let rec method0 () : int32 =
    180
and closure0 () () : int32 =
    method0()
let v0 : (unit -> int32) = closure0()
printfn($"main.spi Loaded. Width: {v0 ()}")
