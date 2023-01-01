let rec closure0 () () : int32 =
    let v0 : string = "app ()"
    System.Console.WriteLine v0
    let v1 : string = "v"
    let v2 : string = "tracing::debug!(\"v={}\", $0)"
    Fable.Core.Rust.emitExpr v1 v2
    1
let v0 : (unit -> int32) = closure0()
()
