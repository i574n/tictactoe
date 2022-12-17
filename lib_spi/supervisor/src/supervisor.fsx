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
    let v35 : Std.std.Ref<(Std.std.Ref<Std.std.path.Path> -> Std.std.path.PathBuf)> = v34 |> unbox
    let v36 : string = "$1.into_iter().map($0)"
    let v37 : Std.std.iter.Iterator<Std.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v35, v33) v36
    let v38 : (Std.std.Ref<Std.std.path.PathBuf> -> bool) = closure3()
    let v39 : Std.std.Ref<(Std.std.Ref<Std.std.path.PathBuf> -> bool)> = v38 |> unbox
    let v40 : string = "$1.into_iter().find($0)"
    let v41 : Option<Std.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v39, v37) v40
    let v42 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v41 v6
    let v43 : string = "\nspiproj_path:"
    System.Console.WriteLine v43
    let v44 : string = Fable.Core.Rust.emitExpr v42 v11
    System.Console.WriteLine v44
    let v45 : string = "($0).to_str()"
    let v46 : Option<Std.std.Ref<Std.std.Str>> = Fable.Core.Rust.emitExpr v16 v45
    let v47 : Std.std.Ref<Std.std.Str> = Fable.Core.Rust.emitExpr v46 v21
    let v48 : string = ".spir"
    let v49 : Std.std.Ref<string> = v48 |> unbox
    let v50 : string = ".spi"
    let v51 : Std.std.Ref<string> = v50 |> unbox
    let v52 : string = "&$2.replace(&*$0, &$1)"
    let v53 : Std.std.Ref<Std.std.Str> = Fable.Core.Rust.emitExpr struct (v49, v51, v47) v52
    let v54 : Std.std.Ref<string> = v50 |> unbox
    let v55 : string = ".fsx"
    let v56 : Std.std.Ref<string> = v55 |> unbox
    let v57 : Std.std.Ref<Std.std.Str> = Fable.Core.Rust.emitExpr struct (v54, v56, v53) v52
    let v58 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v57 v23
    let v59 : Result<Std.std.path.PathBuf, Std.std.io.Error> = Fable.Core.Rust.emitExpr v58 v8
    let v60 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v59 v6
    let v61 : string = "\nfsx_path:"
    System.Console.WriteLine v61
    let v62 : string = Fable.Core.Rust.emitExpr v60 v11
    System.Console.WriteLine v62
    let v63 : string = "\nnew_fsx_path:"
    System.Console.WriteLine v63
    let v64 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v1 v6
    let v65 : string = Fable.Core.Rust.emitExpr v64 v11
    System.Console.WriteLine v65
    let v66 : string = "???"
    v66
and closure0 () (v0 : Std.std.path.PathBuf) : (Option<Std.std.path.PathBuf> -> string) =
    closure1(v0)
let v0 : (Std.std.path.PathBuf -> (Option<Std.std.path.PathBuf> -> string)) = closure0()
()
