type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
let rec closure1 () () : US0 =
    US0_0
and closure2 () () : Types.EmitType<Types.std.string.String> =
    let v0 : string = "> app ()"
    let v1 : string = "($0).to_string()"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    let v4 : (Types.EmitType<Types.std.string.String> []) = [|v3|]
    let v5 : string = "core::ops::Deref::deref($0)"
    let v6 : obj = Fable.Core.Rust.emitExpr v4 v5
    let v7 : string = "format!(\"{:?}\", ***$0)"
    let v8 : Types.std.string.String = Fable.Core.Rust.emitExpr v6 v7
    let v9 : Types.EmitType<Types.std.string.String> = v8 |> unbox<Types.EmitType<Types.std.string.String>>
    v9
and closure3 () (v0 : string) : unit =
    System.Console.WriteLine v0
    ()
and method1 () : struct (string * string * string * bool) =
    let v0 : string = ""
    let v1 : obj = v0
    struct (v0, v0, v0, true)
and method2 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method2(v0, v4)
    else
        v1
and closure5 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : (string -> unit), v3 : string, v4 : int64, v5 : US0) (v6 : Types.EmitType<Types.std.string.String>) : unit =
    let v7 : US0 = v0 ()
    let v11 : int32 =
        match v7 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v15 : int32 =
        match v5 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v16 : bool = v11 <= v15
    if v16 then
        let v17 : string = "chrono::Utc::now()"
        let v18 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v17
        let v19 : string = "($0).timestamp()"
        let v20 : int64 = Fable.Core.Rust.emitExpr v18 v19
        let v21 : int64 = v20 - v4
        let v22 : string = (v21).ToString ()
        let v23 : int32 = 6
        let v24 : string = method2(v23, v22)
        let v25 : string = "rand::random::<u8>()"
        let v26 : uint8 = Fable.Core.Rust.emitExpr () v25
        let v27 : string = "timestamp:"
        let v28 : string = "($0).to_string()"
        let v29 : Types.std.string.String = Fable.Core.Rust.emitExpr v27 v28
        let v30 : Types.EmitType<Types.std.string.String> = v29 |> unbox<Types.EmitType<Types.std.string.String>>
        let v31 : Types.std.string.String = Fable.Core.Rust.emitExpr v24 v28
        let v32 : Types.EmitType<Types.std.string.String> = v31 |> unbox<Types.EmitType<Types.std.string.String>>
        let v33 : string = "run_id:"
        let v34 : Types.std.string.String = Fable.Core.Rust.emitExpr v33 v28
        let v35 : Types.EmitType<Types.std.string.String> = v34 |> unbox<Types.EmitType<Types.std.string.String>>
        let v36 : string = "format!(\"{}\", $0)"
        let v37 : Types.std.string.String = Fable.Core.Rust.emitExpr v26 v36
        let v38 : Types.EmitType<Types.std.string.String> = v37 |> unbox<Types.EmitType<Types.std.string.String>>
        let v39 : (Types.EmitType<Types.std.string.String> []) = [|v30; v32; v35; v38|]
        let v40 : string = "core::ops::Deref::deref($0)"
        let v41 : obj = Fable.Core.Rust.emitExpr v39 v40
        let v42 : string = "format!(\"{:?}\", ***$0)"
        let v43 : Types.std.string.String = Fable.Core.Rust.emitExpr v41 v42
        let v44 : Types.EmitType<Types.std.string.String> = v43 |> unbox<Types.EmitType<Types.std.string.String>>
        let v45 : Types.EmitType<Types.std.string.String> = v1 ()
        let v46 : string = "purple"
        let v47 : string = "colored::Colorize::color(&*$0, $1.to_string())"
        let v48 : obj = Fable.Core.Rust.emitExpr struct (v45, v46) v47
        let v49 : Types.std.string.String = Fable.Core.Rust.emitExpr v48 v36
        let v50 : string = v3.Substring (0, 2)
        let v51 : string = "u8::from_str_radix($0, 16).unwrap()"
        let v52 : uint8 = Fable.Core.Rust.emitExpr v50 v51
        let v53 : string = v3.Substring (2, 2)
        let v54 : uint8 = Fable.Core.Rust.emitExpr v53 v51
        let v55 : string = v3.Substring (4, 2)
        let v56 : uint8 = Fable.Core.Rust.emitExpr v55 v51
        let v57 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
        let v58 : obj = Fable.Core.Rust.emitExpr struct (v6, v52, v54, v56) v57
        let v59 : Types.std.string.String = Fable.Core.Rust.emitExpr v58 v36
        let v60 : string = "222222"
        let v61 : string = v60.Substring (0, 2)
        let v62 : uint8 = Fable.Core.Rust.emitExpr v61 v51
        let v63 : string = v60.Substring (2, 2)
        let v64 : uint8 = Fable.Core.Rust.emitExpr v63 v51
        let v65 : string = v60.Substring (4, 2)
        let v66 : uint8 = Fable.Core.Rust.emitExpr v65 v51
        let v67 : obj = Fable.Core.Rust.emitExpr struct (v44, v62, v64, v66) v57
        let v68 : Types.std.string.String = Fable.Core.Rust.emitExpr v67 v36
        let v69 : string = $"{v49} {v59} {v68}"
        v2 v69
and closure4 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : (string -> unit), v3 : string, v4 : int64) (v5 : US0) : (Types.EmitType<Types.std.string.String> -> unit) =
    closure5(v0, v1, v2, v3, v4, v5)
and method0 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : (string -> unit), v3 : string) : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) =
    let struct (v4 : string, v5 : string, v6 : string, v7 : bool) = method1()
    let v8 : string = "chrono::Utc::now()"
    let v9 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v8
    let v10 : string = "($0).timestamp()"
    let v11 : int64 = Fable.Core.Rust.emitExpr v9 v10
    closure4(v0, v1, v2, v3, v11)
and method3 () : string =
    let v0 : string = "./cli.rs"
    v0
and closure6 () () : US0 =
    US0_0
and closure7 () () : Types.EmitType<Types.std.string.String> =
    let v0 : string = "> read_lines ()"
    let v1 : string = "($0).to_string()"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    let v4 : (Types.EmitType<Types.std.string.String> []) = [|v3|]
    let v5 : string = "core::ops::Deref::deref($0)"
    let v6 : obj = Fable.Core.Rust.emitExpr v4 v5
    let v7 : string = "format!(\"{:?}\", ***$0)"
    let v8 : Types.std.string.String = Fable.Core.Rust.emitExpr v6 v7
    let v9 : Types.EmitType<Types.std.string.String> = v8 |> unbox<Types.EmitType<Types.std.string.String>>
    v9
and closure0 () () : int32 =
    let v0 : (unit -> US0) = closure1()
    let v1 : (unit -> Types.EmitType<Types.std.string.String>) = closure2()
    let v2 : (string -> unit) = closure3()
    let v3 : string = "666666"
    let v4 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v0, v1, v2, v3)
    let v5 : string = method3()
    let v6 : string = "$0.as_str()"
    let v7 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v7 v8
    let v10 : (unit -> US0) = closure6()
    let v11 : (unit -> Types.EmitType<Types.std.string.String>) = closure7()
    let v12 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v10, v11, v2, v3)
    let v13 : string = "($0).canonicalize()"
    let v14 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v9 v13
    let v15 : string = "($0).as_ref().unwrap().to_path_buf()"
    let v16 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v14 v15
    let v17 : US0 = US0_0
    let v18 : (Types.EmitType<Types.std.string.String> -> unit) = v12 v17
    let v19 : string = "path_clean:"
    let v20 : string = "($0).to_string()"
    let v21 : Types.std.string.String = Fable.Core.Rust.emitExpr v19 v20
    let v22 : Types.EmitType<Types.std.string.String> = v21 |> unbox<Types.EmitType<Types.std.string.String>>
    let v23 : string = "fable_library_rust::String_::fromStr(&format!(\"{}\", $0.display()))"
    let v24 : string = Fable.Core.Rust.emitExpr v16 v23
    let v25 : Types.std.string.String = Fable.Core.Rust.emitExpr v24 v20
    let v26 : Types.EmitType<Types.std.string.String> = v25 |> unbox<Types.EmitType<Types.std.string.String>>
    let v27 : (Types.EmitType<Types.std.string.String> []) = [|v22; v26|]
    let v28 : string = "core::ops::Deref::deref($0)"
    let v29 : obj = Fable.Core.Rust.emitExpr v27 v28
    let v30 : string = "format!(\"{:?}\", ***$0)"
    let v31 : Types.std.string.String = Fable.Core.Rust.emitExpr v29 v30
    let v32 : Types.EmitType<Types.std.string.String> = v31 |> unbox<Types.EmitType<Types.std.string.String>>
    v18 v32
    let v33 : string = "std::fs::File::open($0)"
    let v34 : obj = Fable.Core.Rust.emitExpr v16 v33
    let v35 : string = "($0).unwrap()"
    let v36 : obj = Fable.Core.Rust.emitExpr v34 v35
    let v37 : string = "Box::new(linereader::LineReader::new(&$0))"
    let v38 : Types.Box<Types.linereader.LineReader<Types.Ref<Types.std.fs.File>>> = Fable.Core.Rust.emitExpr v36 v37
    let v39 : US0 = US0_0
    let v40 : (Types.EmitType<Types.std.string.String> -> unit) = v12 v39
    let v41 : string = "reader:"
    let v42 : Types.std.string.String = Fable.Core.Rust.emitExpr v41 v20
    let v43 : Types.EmitType<Types.std.string.String> = v42 |> unbox<Types.EmitType<Types.std.string.String>>
    let v44 : string = "format!(\"{:?}\", $0)"
    let v45 : Types.std.string.String = Fable.Core.Rust.emitExpr v38 v44
    let v46 : Types.EmitType<Types.std.string.String> = v45 |> unbox<Types.EmitType<Types.std.string.String>>
    let v47 : (Types.EmitType<Types.std.string.String> []) = [|v43; v46|]
    let v48 : obj = Fable.Core.Rust.emitExpr v47 v28
    let v49 : Types.std.string.String = Fable.Core.Rust.emitExpr v48 v30
    let v50 : Types.EmitType<Types.std.string.String> = v49 |> unbox<Types.EmitType<Types.std.string.String>>
    v40 v50
    let v51 : (string []) = [||]
    let v52 : US0 = US0_0
    let v53 : (Types.EmitType<Types.std.string.String> -> unit) = v4 v52
    let v54 : string = "lines:"
    let v55 : Types.std.string.String = Fable.Core.Rust.emitExpr v54 v20
    let v56 : Types.EmitType<Types.std.string.String> = v55 |> unbox<Types.EmitType<Types.std.string.String>>
    let v57 : string = "format!(\"{}\", $0)"
    let v58 : Types.std.string.String = Fable.Core.Rust.emitExpr v51 v57
    let v59 : Types.EmitType<Types.std.string.String> = v58 |> unbox<Types.EmitType<Types.std.string.String>>
    let v60 : (Types.EmitType<Types.std.string.String> []) = [|v56; v59|]
    let v61 : obj = Fable.Core.Rust.emitExpr v60 v28
    let v62 : Types.std.string.String = Fable.Core.Rust.emitExpr v61 v30
    let v63 : Types.EmitType<Types.std.string.String> = v62 |> unbox<Types.EmitType<Types.std.string.String>>
    v53 v63
    0
let v0 : (unit -> int32) = closure0()
()
