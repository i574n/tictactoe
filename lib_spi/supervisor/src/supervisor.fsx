let rec closure2 () (v0 : Std.std.Ref<Std.std.path.Path>) : Std.std.path.PathBuf =
    let v1 : string = "package.spiproj"
    let v2 : string = "$1.join($0.as_str())"
    let v3 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr struct (v1, v0) v2
    v3
and closure3 () (v0 : Std.std.Ref<Std.std.path.PathBuf>) : bool =
    let v1 : string = "std::path::Path::exists($0)"
    let v2 : bool = Fable.Core.Rust.emitExpr v0 v1
    v2
and closure1 (v0 : Std.std.path.PathBuf) (v1 : Option<Std.std.path.PathBuf>) : string =
    let v2 : string = "\n| spi_to_fsx."
    System.Console.WriteLine v2
    let v3 : string = "\npwd:"
    System.Console.WriteLine v3
    let v4 : string = "std::env::current_dir()"
    let v5 : Result<Std.std.path.PathBuf, Std.std.io.Error> = Fable.Core.Rust.emitExpr () v4
    let v6 : string = "($0).as_ref().unwrap().to_path_buf()"
    let v7 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v5 v6
    let v8 : string = "($0).canonicalize()"
    let v9 : Result<Std.std.path.PathBuf, Std.std.io.Error> = Fable.Core.Rust.emitExpr v7 v8
    let v10 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v9 v6
    let v11 : string = "fable_library_rust::String_::fromStr(&format!(\"{:?}\", $0.display()))"
    let v12 : string = Fable.Core.Rust.emitExpr v10 v11
    System.Console.WriteLine v12
    let v13 : string = "\nspi_path:"
    System.Console.WriteLine v13
    let v14 : string = Fable.Core.Rust.emitExpr v0 v11
    System.Console.WriteLine v14
    let v15 : Result<Std.std.path.PathBuf, Std.std.io.Error> = Fable.Core.Rust.emitExpr v0 v8
    let v16 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v15 v6
    let v17 : string = "\nspi_path_clean:"
    System.Console.WriteLine v17
    let v18 : string = Fable.Core.Rust.emitExpr v16 v11
    System.Console.WriteLine v18
    let v19 : string = "($0).parent()"
    let v20 : Option<Std.std.Ref<Std.std.path.Path>> = Fable.Core.Rust.emitExpr v16 v19
    let v21 : string = "($0).unwrap()"
    let v22 : Std.std.Ref<Std.std.path.Path> = Fable.Core.Rust.emitExpr v20 v21
    let v23 : string = "std::path::PathBuf::from($0)"
    let v24 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v22 v23
    let v25 : Result<Std.std.path.PathBuf, Std.std.io.Error> = Fable.Core.Rust.emitExpr v24 v8
    let v26 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v25 v6
    let v27 : string = "\nsrc_path:"
    System.Console.WriteLine v27
    let v28 : string = Fable.Core.Rust.emitExpr v26 v11
    System.Console.WriteLine v28
    let v29 : string = "$0.ancestors()"
    let v30 : Std.std.Ref<Std.std.path.Ancestors> = Fable.Core.Rust.emitExpr v26 v29
    let v31 : unativeint = unativeint 10
    let v32 : string = "$1.take($0)"
    let v33 : Std.std.iter.Iterator<Std.std.Ref<Std.std.path.Path>> = Fable.Core.Rust.emitExpr struct (v31, v30) v32
    let v34 : (Std.std.Ref<Std.std.path.Path> -> Std.std.path.PathBuf) = closure2()
    let v35 : string = "$1.into_iter().map(&Func1::get($0))"
    let v36 : Std.std.iter.Iterator<Std.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v34, v33) v35
    let v37 : (Std.std.Ref<Std.std.path.PathBuf> -> bool) = closure3()
    let v38 : string = "$1.into_iter().find(&Func1::get($0))"
    let v39 : Option<Std.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v37, v36) v38
    let v40 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v39 v6
    let v41 : string = "\nspiproj_path:"
    System.Console.WriteLine v41
    let v42 : string = Fable.Core.Rust.emitExpr v40 v11
    System.Console.WriteLine v42
    let v43 : string = "\nnew_fsx_path:"
    System.Console.WriteLine v43
    let v44 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v1 v6
    let v45 : string = Fable.Core.Rust.emitExpr v44 v11
    System.Console.WriteLine v45
    let v46 : string = "???"
    v46
and closure0 () (v0 : Std.std.path.PathBuf) : (Option<Std.std.path.PathBuf> -> string) =
    closure1(v0)
let v0 : (Std.std.path.PathBuf -> (Option<Std.std.path.PathBuf> -> string)) = closure0()
()
