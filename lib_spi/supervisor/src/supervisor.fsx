let rec closure0 () (v0 : string) : unit =
    let v1 : string = "zmq_request."
    System.Console.WriteLine v1
    let v2 : string = "msg:"
    System.Console.WriteLine v2
    System.Console.WriteLine v0
    let v3 : string = "zmq::Context::new()"
    let v4 : obj = Fable.Core.Rust.emitExpr () v3
    let v5 : string = "$0.socket(zmq::REQ).unwrap()"
    let v6 : obj = Fable.Core.Rust.emitExpr v4 v5
    let v7 : string = $"tcp://localhost:{13805}"
    let v8 : string = "$0.connect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v6, v7) v8
    let v9 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v6, v0) v9
    let v10 : string = "$0.recv_string(0).unwrap().unwrap()"
    let v11 : obj = Fable.Core.Rust.emitExpr v6 v10
    let v12 : string = "zmq_request. result:"
    System.Console.WriteLine v12
    System.Console.WriteLine v11
    let v13 : string = "$0.disconnect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v6, v7) v13
    ()
and closure2 (v0 : Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>>) (v1 : Option<Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>>>) : string =
    let v2 : string = "| spi_to_fsx."
    System.Console.WriteLine v2
    let v3 : string = "spi_path:"
    System.Console.WriteLine v3
    let v4 : string = "fable_library_rust::String_::fromStr(Box::leak(format!(\"{:?}\", ($0).strip_prefix(\"\").unwrap().display()).into_boxed_str()))"
    let v5 : string = Fable.Core.Rust.emitExpr v0 v4
    System.Console.WriteLine v5
    let v6 : string = "std::rc::Rc::new(fable_library_rust::Native_::MutCell::new(Box::from(($0).canonicalize().unwrap().strip_prefix(\"\").unwrap())))"
    let v7 : Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>> = Fable.Core.Rust.emitExpr v0 v6
    let v8 : string = "spi_path_canonicalize:"
    System.Console.WriteLine v8
    let v9 : string = Fable.Core.Rust.emitExpr v7 v4
    System.Console.WriteLine v9
    let v10 : string = "new_fsx_path:"
    System.Console.WriteLine v10
    let v11 : string = "($0).as_ref().unwrap().clone()"
    let v12 : Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>> = Fable.Core.Rust.emitExpr v1 v11
    let v13 : string = Fable.Core.Rust.emitExpr v12 v4
    System.Console.WriteLine v13
    let v14 : string = ""
    v14
and closure1 () (v0 : Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>>) : (Option<Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>>> -> string) =
    closure2(v0)
let v0 : (string -> unit) = closure0()
let v1 : (Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>> -> (Option<Std.std.Lrc<Std.std.MutCell<Std.std.Box<Std.std.path.Path>>>> -> string)) = closure1()
()
