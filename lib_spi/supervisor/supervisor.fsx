type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
and [<Struct>] US1 =
    | US1_0
    | US1_1 of f1_0 : string
and Mut0 = {mutable l0 : int32; mutable l1 : US1}
let rec closure2 () () : US0 =
    US0_0
and closure3 () () : Types.EmitType<Types.std.string.String> =
    let v0 : string = "> spi_to_fsx ()"
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
and closure5 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : string, v3 : int64, v4 : US0) (v5 : Types.EmitType<Types.std.string.String>) : unit =
    let v6 : US0 = v0 ()
    let v10 : int32 =
        match v6 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v14 : int32 =
        match v4 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v15 : bool = v10 <= v14
    if v15 then
        let v16 : string = "chrono::Utc::now()"
        let v17 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v16
        let v18 : string = "($0).timestamp()"
        let v19 : int64 = Fable.Core.Rust.emitExpr v17 v18
        let v20 : int64 = v19 - v3
        let v21 : string = (v20).ToString ()
        let v22 : int32 = 6
        let v23 : string = method2(v22, v21)
        let v24 : string = "rand::random::<u8>()"
        let v25 : uint8 = Fable.Core.Rust.emitExpr () v24
        let v26 : string = "timestamp:"
        let v27 : string = "($0).to_string()"
        let v28 : Types.std.string.String = Fable.Core.Rust.emitExpr v26 v27
        let v29 : Types.EmitType<Types.std.string.String> = v28 |> unbox<Types.EmitType<Types.std.string.String>>
        let v30 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v27
        let v31 : Types.EmitType<Types.std.string.String> = v30 |> unbox<Types.EmitType<Types.std.string.String>>
        let v32 : string = "run_id:"
        let v33 : Types.std.string.String = Fable.Core.Rust.emitExpr v32 v27
        let v34 : Types.EmitType<Types.std.string.String> = v33 |> unbox<Types.EmitType<Types.std.string.String>>
        let v35 : string = "format!(\"{}\", $0)"
        let v36 : Types.std.string.String = Fable.Core.Rust.emitExpr v25 v35
        let v37 : Types.EmitType<Types.std.string.String> = v36 |> unbox<Types.EmitType<Types.std.string.String>>
        let v38 : (Types.EmitType<Types.std.string.String> []) = [|v29; v31; v34; v37|]
        let v39 : string = "core::ops::Deref::deref($0)"
        let v40 : obj = Fable.Core.Rust.emitExpr v38 v39
        let v41 : string = "format!(\"{:?}\", ***$0)"
        let v42 : Types.std.string.String = Fable.Core.Rust.emitExpr v40 v41
        let v43 : Types.EmitType<Types.std.string.String> = v42 |> unbox<Types.EmitType<Types.std.string.String>>
        let v44 : Types.EmitType<Types.std.string.String> = v1 ()
        let v45 : string = "purple"
        let v46 : string = "colored::Colorize::color(&*$0, $1.to_string())"
        let v47 : obj = Fable.Core.Rust.emitExpr struct (v44, v45) v46
        let v48 : Types.std.string.String = Fable.Core.Rust.emitExpr v47 v35
        let v49 : string = v2.Substring (0, 2)
        let v50 : string = "u8::from_str_radix($0, 16).unwrap()"
        let v51 : uint8 = Fable.Core.Rust.emitExpr v49 v50
        let v52 : string = v2.Substring (2, 2)
        let v53 : uint8 = Fable.Core.Rust.emitExpr v52 v50
        let v54 : string = v2.Substring (4, 2)
        let v55 : uint8 = Fable.Core.Rust.emitExpr v54 v50
        let v56 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
        let v57 : obj = Fable.Core.Rust.emitExpr struct (v5, v51, v53, v55) v56
        let v58 : Types.std.string.String = Fable.Core.Rust.emitExpr v57 v35
        let v59 : string = "222222"
        let v60 : string = v59.Substring (0, 2)
        let v61 : uint8 = Fable.Core.Rust.emitExpr v60 v50
        let v62 : string = v59.Substring (2, 2)
        let v63 : uint8 = Fable.Core.Rust.emitExpr v62 v50
        let v64 : string = v59.Substring (4, 2)
        let v65 : uint8 = Fable.Core.Rust.emitExpr v64 v50
        let v66 : obj = Fable.Core.Rust.emitExpr struct (v43, v61, v63, v65) v56
        let v67 : Types.std.string.String = Fable.Core.Rust.emitExpr v66 v35
        let v68 : string = $"{v48} {v58} {v67}"
        System.Console.WriteLine v68
        ()
and closure4 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : string, v3 : int64) (v4 : US0) : (Types.EmitType<Types.std.string.String> -> unit) =
    closure5(v0, v1, v2, v3, v4)
and method0 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : string) : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) =
    let struct (v3 : string, v4 : string, v5 : string, v6 : bool) = method1()
    let v7 : string = "chrono::Utc::now()"
    let v8 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v7
    let v9 : string = "($0).timestamp()"
    let v10 : int64 = Fable.Core.Rust.emitExpr v8 v9
    closure4(v0, v1, v2, v10)
and closure6 () (v0 : Types.Ref<Types.std.path.Path>) : Types.std.path.PathBuf =
    let v1 : string = "package.spiproj"
    let v2 : string = "$1.join($0.as_str())"
    let v3 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr struct (v1, v0) v2
    v3
and closure7 () (v0 : Types.Ref<Types.std.path.PathBuf>) : bool =
    let v1 : string = "std::path::Path::exists($0)"
    let v2 : bool = Fable.Core.Rust.emitExpr v0 v1
    v2
and closure8 () () : US0 =
    US0_0
and closure9 () () : Types.EmitType<Types.std.string.String> =
    let v0 : string = "> spiproj_open ()"
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
and closure10 () () : US0 =
    US0_0
and closure11 () () : Types.EmitType<Types.std.string.String> =
    let v0 : string = "> zmq_request ()"
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
and closure12 () () : US0 =
    US0_0
and closure13 () () : Types.EmitType<Types.std.string.String> =
    let v0 : string = "> spi_build_file ()"
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
and closure14 () () : US0 =
    US0_0
and closure15 () () : Types.EmitType<Types.std.string.String> =
    let v0 : string = "> wait_file_change ()"
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
and method3 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure1 (v0 : Types.std.path.PathBuf) (v1 : Option<Types.std.path.PathBuf>) : string =
    let v2 : (unit -> US0) = closure2()
    let v3 : (unit -> Types.EmitType<Types.std.string.String>) = closure3()
    let v4 : string = "de884c"
    let v5 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v2, v3, v4)
    let v6 : US0 = US0_0
    let v7 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v6
    let v8 : string = "pwd:"
    let v9 : string = "($0).to_string()"
    let v10 : Types.std.string.String = Fable.Core.Rust.emitExpr v8 v9
    let v11 : Types.EmitType<Types.std.string.String> = v10 |> unbox<Types.EmitType<Types.std.string.String>>
    let v12 : string = "std::env::current_dir()"
    let v13 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr () v12
    let v14 : string = "($0).as_ref().unwrap().to_path_buf()"
    let v15 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v13 v14
    let v16 : string = "($0).canonicalize()"
    let v17 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v15 v16
    let v18 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v17 v14
    let v19 : string = "fable_library_rust::String_::fromStr(&format!(\"{}\", $0.display()))"
    let v20 : string = Fable.Core.Rust.emitExpr v18 v19
    let v21 : Types.std.string.String = Fable.Core.Rust.emitExpr v20 v9
    let v22 : Types.EmitType<Types.std.string.String> = v21 |> unbox<Types.EmitType<Types.std.string.String>>
    let v23 : string = "spi_path:"
    let v24 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v9
    let v25 : Types.EmitType<Types.std.string.String> = v24 |> unbox<Types.EmitType<Types.std.string.String>>
    let v26 : string = Fable.Core.Rust.emitExpr v0 v19
    let v27 : Types.std.string.String = Fable.Core.Rust.emitExpr v26 v9
    let v28 : Types.EmitType<Types.std.string.String> = v27 |> unbox<Types.EmitType<Types.std.string.String>>
    let v29 : string = "new_fsx_path:"
    let v30 : Types.std.string.String = Fable.Core.Rust.emitExpr v29 v9
    let v31 : Types.EmitType<Types.std.string.String> = v30 |> unbox<Types.EmitType<Types.std.string.String>>
    let v32 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v1 v14
    let v33 : string = Fable.Core.Rust.emitExpr v32 v19
    let v34 : Types.std.string.String = Fable.Core.Rust.emitExpr v33 v9
    let v35 : Types.EmitType<Types.std.string.String> = v34 |> unbox<Types.EmitType<Types.std.string.String>>
    let v36 : (Types.EmitType<Types.std.string.String> []) = [|v11; v22; v25; v28; v31; v35|]
    let v37 : string = "core::ops::Deref::deref($0)"
    let v38 : obj = Fable.Core.Rust.emitExpr v36 v37
    let v39 : string = "format!(\"{:?}\", ***$0)"
    let v40 : Types.std.string.String = Fable.Core.Rust.emitExpr v38 v39
    let v41 : Types.EmitType<Types.std.string.String> = v40 |> unbox<Types.EmitType<Types.std.string.String>>
    v7 v41
    let v42 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v0 v16
    let v43 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v42 v14
    let v44 : US0 = US0_0
    let v45 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v44
    let v46 : string = "spi_path_clean:"
    let v47 : Types.std.string.String = Fable.Core.Rust.emitExpr v46 v9
    let v48 : Types.EmitType<Types.std.string.String> = v47 |> unbox<Types.EmitType<Types.std.string.String>>
    let v49 : string = Fable.Core.Rust.emitExpr v43 v19
    let v50 : Types.std.string.String = Fable.Core.Rust.emitExpr v49 v9
    let v51 : Types.EmitType<Types.std.string.String> = v50 |> unbox<Types.EmitType<Types.std.string.String>>
    let v52 : (Types.EmitType<Types.std.string.String> []) = [|v48; v51|]
    let v53 : obj = Fable.Core.Rust.emitExpr v52 v37
    let v54 : Types.std.string.String = Fable.Core.Rust.emitExpr v53 v39
    let v55 : Types.EmitType<Types.std.string.String> = v54 |> unbox<Types.EmitType<Types.std.string.String>>
    v45 v55
    let v56 : string = "($0).parent()"
    let v57 : Option<Types.Ref<Types.std.path.Path>> = Fable.Core.Rust.emitExpr v43 v56
    let v58 : string = "($0).unwrap()"
    let v59 : Types.Ref<Types.std.path.Path> = Fable.Core.Rust.emitExpr v57 v58
    let v60 : string = "std::path::PathBuf::from($0)"
    let v61 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v59 v60
    let v62 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v61 v16
    let v63 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v62 v14
    let v64 : US0 = US0_0
    let v65 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v64
    let v66 : string = "src_path:"
    let v67 : Types.std.string.String = Fable.Core.Rust.emitExpr v66 v9
    let v68 : Types.EmitType<Types.std.string.String> = v67 |> unbox<Types.EmitType<Types.std.string.String>>
    let v69 : string = Fable.Core.Rust.emitExpr v63 v19
    let v70 : Types.std.string.String = Fable.Core.Rust.emitExpr v69 v9
    let v71 : Types.EmitType<Types.std.string.String> = v70 |> unbox<Types.EmitType<Types.std.string.String>>
    let v72 : (Types.EmitType<Types.std.string.String> []) = [|v68; v71|]
    let v73 : obj = Fable.Core.Rust.emitExpr v72 v37
    let v74 : Types.std.string.String = Fable.Core.Rust.emitExpr v73 v39
    let v75 : Types.EmitType<Types.std.string.String> = v74 |> unbox<Types.EmitType<Types.std.string.String>>
    v65 v75
    let v76 : string = "$0.ancestors()"
    let v77 : Types.Ref<Types.std.path.Ancestors> = Fable.Core.Rust.emitExpr v63 v76
    let v78 : unativeint = unativeint 10
    let v79 : string = "$1.take($0)"
    let v80 : Types.std.iter.Iterator<Types.Ref<Types.std.path.Path>> = Fable.Core.Rust.emitExpr struct (v78, v77) v79
    let v81 : (Types.Ref<Types.std.path.Path> -> Types.std.path.PathBuf) = closure6()
    let v82 : Types.Ref<(Types.Ref<Types.std.path.Path> -> Types.std.path.PathBuf)> = v81 |> unbox
    let v83 : string = "$1.into_iter().map($0)"
    let v84 : Types.std.iter.Iterator<Types.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v82, v80) v83
    let v85 : (Types.Ref<Types.std.path.PathBuf> -> bool) = closure7()
    let v86 : Types.Ref<(Types.Ref<Types.std.path.PathBuf> -> bool)> = v85 |> unbox
    let v87 : string = "$1.into_iter().find($0)"
    let v88 : Option<Types.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v86, v84) v87
    let v89 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v88 v14
    let v90 : US0 = US0_0
    let v91 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v90
    let v92 : string = "spiproj_path:"
    let v93 : Types.std.string.String = Fable.Core.Rust.emitExpr v92 v9
    let v94 : Types.EmitType<Types.std.string.String> = v93 |> unbox<Types.EmitType<Types.std.string.String>>
    let v95 : string = Fable.Core.Rust.emitExpr v89 v19
    let v96 : Types.std.string.String = Fable.Core.Rust.emitExpr v95 v9
    let v97 : Types.EmitType<Types.std.string.String> = v96 |> unbox<Types.EmitType<Types.std.string.String>>
    let v98 : (Types.EmitType<Types.std.string.String> []) = [|v94; v97|]
    let v99 : obj = Fable.Core.Rust.emitExpr v98 v37
    let v100 : Types.std.string.String = Fable.Core.Rust.emitExpr v99 v39
    let v101 : Types.EmitType<Types.std.string.String> = v100 |> unbox<Types.EmitType<Types.std.string.String>>
    v91 v101
    let v102 : string = "($0).to_str()"
    let v103 : Option<Types.Ref<Types.Str>> = Fable.Core.Rust.emitExpr v43 v102
    let v104 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v103 v58
    let v105 : string = ".spir"
    let v106 : Types.Ref<string> = v105 |> unbox
    let v107 : string = ".spi"
    let v108 : Types.Ref<string> = v107 |> unbox
    let v109 : string = "&$2.replace(&*$0, &$1)"
    let v110 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v106, v108, v104) v109
    let v111 : Types.Ref<string> = v107 |> unbox
    let v112 : string = ".fsx"
    let v113 : Types.Ref<string> = v112 |> unbox
    let v114 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v111, v113, v110) v109
    let v115 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v114 v60
    let v116 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v115 v16
    let v117 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v116 v14
    let v118 : US0 = US0_0
    let v119 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v118
    let v120 : string = "fsx_path:"
    let v121 : Types.std.string.String = Fable.Core.Rust.emitExpr v120 v9
    let v122 : Types.EmitType<Types.std.string.String> = v121 |> unbox<Types.EmitType<Types.std.string.String>>
    let v123 : string = Fable.Core.Rust.emitExpr v117 v19
    let v124 : Types.std.string.String = Fable.Core.Rust.emitExpr v123 v9
    let v125 : Types.EmitType<Types.std.string.String> = v124 |> unbox<Types.EmitType<Types.std.string.String>>
    let v126 : (Types.EmitType<Types.std.string.String> []) = [|v122; v125|]
    let v127 : obj = Fable.Core.Rust.emitExpr v126 v37
    let v128 : Types.std.string.String = Fable.Core.Rust.emitExpr v127 v39
    let v129 : Types.EmitType<Types.std.string.String> = v128 |> unbox<Types.EmitType<Types.std.string.String>>
    v119 v129
    let v130 : string = ""
    let v131 : string = "std::fs::write($0, $1.as_str())"
    let v132 : Result<unit, Types.std.io.Error> = Fable.Core.Rust.emitExpr struct (v117, v130) v131
    let v133 : string = "*(($0).as_ref()).unwrap()"
    Fable.Core.Rust.emitExpr v132 v133
    let v134 : US0 = US0_0
    let v135 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v134
    let v136 : string = "> fs_write fsx_path \"\"; ok"
    let v137 : Types.std.string.String = Fable.Core.Rust.emitExpr v136 v9
    let v138 : Types.EmitType<Types.std.string.String> = v137 |> unbox<Types.EmitType<Types.std.string.String>>
    v135 v138
    let v139 : string = "std::fs::read_to_string($0)"
    let v140 : Result<Types.std.string.String, Types.std.io.Error> = Fable.Core.Rust.emitExpr v89 v139
    let v141 : string = "($0).as_ref().unwrap().to_string()"
    let v142 : Types.std.string.String = Fable.Core.Rust.emitExpr v140 v141
    let v143 : (unit -> US0) = closure8()
    let v144 : (unit -> Types.EmitType<Types.std.string.String>) = closure9()
    let v145 : string = "e36a62"
    let v146 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v143, v144, v145)
    let v147 : US0 = US0_0
    let v148 : (Types.EmitType<Types.std.string.String> -> unit) = v146 v147
    let v149 : Types.std.string.String = Fable.Core.Rust.emitExpr v92 v9
    let v150 : Types.EmitType<Types.std.string.String> = v149 |> unbox<Types.EmitType<Types.std.string.String>>
    let v151 : string = Fable.Core.Rust.emitExpr v89 v19
    let v152 : Types.std.string.String = Fable.Core.Rust.emitExpr v151 v9
    let v153 : Types.EmitType<Types.std.string.String> = v152 |> unbox<Types.EmitType<Types.std.string.String>>
    let v154 : string = "spiproj_text.len():"
    let v155 : Types.std.string.String = Fable.Core.Rust.emitExpr v154 v9
    let v156 : Types.EmitType<Types.std.string.String> = v155 |> unbox<Types.EmitType<Types.std.string.String>>
    let v157 : string = "($0).len().try_into().unwrap()"
    let v158 : int32 = Fable.Core.Rust.emitExpr v142 v157
    let v159 : string = "format!(\"{}\", $0)"
    let v160 : Types.std.string.String = Fable.Core.Rust.emitExpr v158 v159
    let v161 : Types.EmitType<Types.std.string.String> = v160 |> unbox<Types.EmitType<Types.std.string.String>>
    let v162 : (Types.EmitType<Types.std.string.String> []) = [|v150; v153; v156; v161|]
    let v163 : obj = Fable.Core.Rust.emitExpr v162 v37
    let v164 : Types.std.string.String = Fable.Core.Rust.emitExpr v163 v39
    let v165 : Types.EmitType<Types.std.string.String> = v164 |> unbox<Types.EmitType<Types.std.string.String>>
    v148 v165
    let v166 : string = "{"
    let v167 : string = "\"ProjectFileOpen\": {"
    let v168 : string = v166 + v167
    let v169 : string = "\"uri\": $0,"
    let v170 : string = v168 + v169
    let v171 : string = "\"spiprojText\": $1"
    let v172 : string = v170 + v171
    let v173 : string = "}"
    let v174 : string = v172 + v173
    let v175 : string = v174 + v173
    let v176 : string = "serde_json::json!("
    let v177 : string = v176 + v175
    let v178 : string = ").to_string()"
    let v179 : string = v177 + v178
    let v180 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v89, v142) v179
    let v181 : US0 = US0_0
    let v182 : (Types.EmitType<Types.std.string.String> -> unit) = v146 v181
    let v183 : string = "json.len():"
    let v184 : Types.std.string.String = Fable.Core.Rust.emitExpr v183 v9
    let v185 : Types.EmitType<Types.std.string.String> = v184 |> unbox<Types.EmitType<Types.std.string.String>>
    let v186 : int32 = Fable.Core.Rust.emitExpr v180 v157
    let v187 : Types.std.string.String = Fable.Core.Rust.emitExpr v186 v159
    let v188 : Types.EmitType<Types.std.string.String> = v187 |> unbox<Types.EmitType<Types.std.string.String>>
    let v189 : (Types.EmitType<Types.std.string.String> []) = [|v185; v188|]
    let v190 : obj = Fable.Core.Rust.emitExpr v189 v37
    let v191 : Types.std.string.String = Fable.Core.Rust.emitExpr v190 v39
    let v192 : Types.EmitType<Types.std.string.String> = v191 |> unbox<Types.EmitType<Types.std.string.String>>
    v182 v192
    let v193 : (unit -> US0) = closure10()
    let v194 : (unit -> Types.EmitType<Types.std.string.String>) = closure11()
    let v195 : string = "fcfb1b"
    let v196 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v193, v194, v195)
    let v197 : US0 = US0_0
    let v198 : (Types.EmitType<Types.std.string.String> -> unit) = v196 v197
    let v199 : string = "host:"
    let v200 : Types.std.string.String = Fable.Core.Rust.emitExpr v199 v9
    let v201 : Types.EmitType<Types.std.string.String> = v200 |> unbox<Types.EmitType<Types.std.string.String>>
    let v202 : string = "localhost"
    let v203 : Types.std.string.String = Fable.Core.Rust.emitExpr v202 v9
    let v204 : Types.EmitType<Types.std.string.String> = v203 |> unbox<Types.EmitType<Types.std.string.String>>
    let v205 : string = "port:"
    let v206 : Types.std.string.String = Fable.Core.Rust.emitExpr v205 v9
    let v207 : Types.EmitType<Types.std.string.String> = v206 |> unbox<Types.EmitType<Types.std.string.String>>
    let v208 : Types.std.string.String = Fable.Core.Rust.emitExpr 13805 v159
    let v209 : Types.EmitType<Types.std.string.String> = v208 |> unbox<Types.EmitType<Types.std.string.String>>
    let v210 : string = "msg.len():"
    let v211 : Types.std.string.String = Fable.Core.Rust.emitExpr v210 v9
    let v212 : Types.EmitType<Types.std.string.String> = v211 |> unbox<Types.EmitType<Types.std.string.String>>
    let v213 : int32 = Fable.Core.Rust.emitExpr v180 v157
    let v214 : Types.std.string.String = Fable.Core.Rust.emitExpr v213 v159
    let v215 : Types.EmitType<Types.std.string.String> = v214 |> unbox<Types.EmitType<Types.std.string.String>>
    let v216 : (Types.EmitType<Types.std.string.String> []) = [|v201; v204; v207; v209; v212; v215|]
    let v217 : obj = Fable.Core.Rust.emitExpr v216 v37
    let v218 : Types.std.string.String = Fable.Core.Rust.emitExpr v217 v39
    let v219 : Types.EmitType<Types.std.string.String> = v218 |> unbox<Types.EmitType<Types.std.string.String>>
    v198 v219
    let v220 : string = "zmq::Context::new()"
    let v221 : obj = Fable.Core.Rust.emitExpr () v220
    let v222 : string = "$0.socket(zmq::REQ).unwrap()"
    let v223 : obj = Fable.Core.Rust.emitExpr v221 v222
    let v224 : string = $"tcp://{v202}:{13805}"
    let v225 : string = "$0.connect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v223, v224) v225
    let v226 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v223, v180) v226
    let v227 : string = "$0.recv_string(0).unwrap().unwrap()"
    let v228 : Types.std.string.String = Fable.Core.Rust.emitExpr v223 v227
    let v229 : string = "$0.disconnect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v223, v224) v229
    let v230 : US0 = US0_0
    let v231 : (Types.EmitType<Types.std.string.String> -> unit) = v196 v230
    let v232 : string = "result.len():"
    let v233 : Types.std.string.String = Fable.Core.Rust.emitExpr v232 v9
    let v234 : Types.EmitType<Types.std.string.String> = v233 |> unbox<Types.EmitType<Types.std.string.String>>
    let v235 : int32 = Fable.Core.Rust.emitExpr v228 v157
    let v236 : Types.std.string.String = Fable.Core.Rust.emitExpr v235 v159
    let v237 : Types.EmitType<Types.std.string.String> = v236 |> unbox<Types.EmitType<Types.std.string.String>>
    let v238 : (Types.EmitType<Types.std.string.String> []) = [|v234; v237|]
    let v239 : obj = Fable.Core.Rust.emitExpr v238 v37
    let v240 : Types.std.string.String = Fable.Core.Rust.emitExpr v239 v39
    let v241 : Types.EmitType<Types.std.string.String> = v240 |> unbox<Types.EmitType<Types.std.string.String>>
    v231 v241
    let v242 : US0 = US0_0
    let v243 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v242
    let v244 : string = "> spiproj_open; ok"
    let v245 : Types.std.string.String = Fable.Core.Rust.emitExpr v244 v9
    let v246 : Types.EmitType<Types.std.string.String> = v245 |> unbox<Types.EmitType<Types.std.string.String>>
    v243 v246
    let v247 : (unit -> US0) = closure12()
    let v248 : (unit -> Types.EmitType<Types.std.string.String>) = closure13()
    let v249 : string = "98d5ef"
    let v250 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v247, v248, v249)
    let v251 : US0 = US0_0
    let v252 : (Types.EmitType<Types.std.string.String> -> unit) = v250 v251
    let v253 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v9
    let v254 : Types.EmitType<Types.std.string.String> = v253 |> unbox<Types.EmitType<Types.std.string.String>>
    let v255 : string = Fable.Core.Rust.emitExpr v43 v19
    let v256 : Types.std.string.String = Fable.Core.Rust.emitExpr v255 v9
    let v257 : Types.EmitType<Types.std.string.String> = v256 |> unbox<Types.EmitType<Types.std.string.String>>
    let v258 : string = "backend:"
    let v259 : Types.std.string.String = Fable.Core.Rust.emitExpr v258 v9
    let v260 : Types.EmitType<Types.std.string.String> = v259 |> unbox<Types.EmitType<Types.std.string.String>>
    let v261 : string = "Fsharp"
    let v262 : Types.std.string.String = Fable.Core.Rust.emitExpr v261 v9
    let v263 : Types.EmitType<Types.std.string.String> = v262 |> unbox<Types.EmitType<Types.std.string.String>>
    let v264 : (Types.EmitType<Types.std.string.String> []) = [|v254; v257; v260; v263|]
    let v265 : obj = Fable.Core.Rust.emitExpr v264 v37
    let v266 : Types.std.string.String = Fable.Core.Rust.emitExpr v265 v39
    let v267 : Types.EmitType<Types.std.string.String> = v266 |> unbox<Types.EmitType<Types.std.string.String>>
    v252 v267
    let v268 : Types.std.string.String = Fable.Core.Rust.emitExpr v261 v9
    let v269 : string = "\"BuildFile\": {"
    let v270 : string = v166 + v269
    let v271 : string = v270 + v169
    let v272 : string = "\"backend\": $1"
    let v273 : string = v271 + v272
    let v274 : string = v273 + v173
    let v275 : string = v274 + v173
    let v276 : string = v176 + v275
    let v277 : string = v276 + v178
    let v278 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v43, v268) v277
    let v279 : US0 = US0_0
    let v280 : (Types.EmitType<Types.std.string.String> -> unit) = v250 v279
    let v281 : Types.std.string.String = Fable.Core.Rust.emitExpr v183 v9
    let v282 : Types.EmitType<Types.std.string.String> = v281 |> unbox<Types.EmitType<Types.std.string.String>>
    let v283 : int32 = Fable.Core.Rust.emitExpr v278 v157
    let v284 : Types.std.string.String = Fable.Core.Rust.emitExpr v283 v159
    let v285 : Types.EmitType<Types.std.string.String> = v284 |> unbox<Types.EmitType<Types.std.string.String>>
    let v286 : (Types.EmitType<Types.std.string.String> []) = [|v282; v285|]
    let v287 : obj = Fable.Core.Rust.emitExpr v286 v37
    let v288 : Types.std.string.String = Fable.Core.Rust.emitExpr v287 v39
    let v289 : Types.EmitType<Types.std.string.String> = v288 |> unbox<Types.EmitType<Types.std.string.String>>
    v280 v289
    let v290 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v193, v194, v195)
    let v291 : US0 = US0_0
    let v292 : (Types.EmitType<Types.std.string.String> -> unit) = v290 v291
    let v293 : Types.std.string.String = Fable.Core.Rust.emitExpr v199 v9
    let v294 : Types.EmitType<Types.std.string.String> = v293 |> unbox<Types.EmitType<Types.std.string.String>>
    let v295 : Types.std.string.String = Fable.Core.Rust.emitExpr v202 v9
    let v296 : Types.EmitType<Types.std.string.String> = v295 |> unbox<Types.EmitType<Types.std.string.String>>
    let v297 : Types.std.string.String = Fable.Core.Rust.emitExpr v205 v9
    let v298 : Types.EmitType<Types.std.string.String> = v297 |> unbox<Types.EmitType<Types.std.string.String>>
    let v299 : Types.std.string.String = Fable.Core.Rust.emitExpr 13805 v159
    let v300 : Types.EmitType<Types.std.string.String> = v299 |> unbox<Types.EmitType<Types.std.string.String>>
    let v301 : Types.std.string.String = Fable.Core.Rust.emitExpr v210 v9
    let v302 : Types.EmitType<Types.std.string.String> = v301 |> unbox<Types.EmitType<Types.std.string.String>>
    let v303 : int32 = Fable.Core.Rust.emitExpr v278 v157
    let v304 : Types.std.string.String = Fable.Core.Rust.emitExpr v303 v159
    let v305 : Types.EmitType<Types.std.string.String> = v304 |> unbox<Types.EmitType<Types.std.string.String>>
    let v306 : (Types.EmitType<Types.std.string.String> []) = [|v294; v296; v298; v300; v302; v305|]
    let v307 : obj = Fable.Core.Rust.emitExpr v306 v37
    let v308 : Types.std.string.String = Fable.Core.Rust.emitExpr v307 v39
    let v309 : Types.EmitType<Types.std.string.String> = v308 |> unbox<Types.EmitType<Types.std.string.String>>
    v292 v309
    let v310 : obj = Fable.Core.Rust.emitExpr () v220
    let v311 : obj = Fable.Core.Rust.emitExpr v310 v222
    let v312 : string = $"tcp://{v202}:{13805}"
    Fable.Core.Rust.emitExpr struct (v311, v312) v225
    let v313 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v311, v278) v313
    let v314 : Types.std.string.String = Fable.Core.Rust.emitExpr v311 v227
    Fable.Core.Rust.emitExpr struct (v311, v312) v229
    let v315 : US0 = US0_0
    let v316 : (Types.EmitType<Types.std.string.String> -> unit) = v290 v315
    let v317 : Types.std.string.String = Fable.Core.Rust.emitExpr v232 v9
    let v318 : Types.EmitType<Types.std.string.String> = v317 |> unbox<Types.EmitType<Types.std.string.String>>
    let v319 : int32 = Fable.Core.Rust.emitExpr v314 v157
    let v320 : Types.std.string.String = Fable.Core.Rust.emitExpr v319 v159
    let v321 : Types.EmitType<Types.std.string.String> = v320 |> unbox<Types.EmitType<Types.std.string.String>>
    let v322 : (Types.EmitType<Types.std.string.String> []) = [|v318; v321|]
    let v323 : obj = Fable.Core.Rust.emitExpr v322 v37
    let v324 : Types.std.string.String = Fable.Core.Rust.emitExpr v323 v39
    let v325 : Types.EmitType<Types.std.string.String> = v324 |> unbox<Types.EmitType<Types.std.string.String>>
    v316 v325
    let v326 : US0 = US0_0
    let v327 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v326
    let v328 : string = "> spi_build_file; ok"
    let v329 : Types.std.string.String = Fable.Core.Rust.emitExpr v328 v9
    let v330 : Types.EmitType<Types.std.string.String> = v329 |> unbox<Types.EmitType<Types.std.string.String>>
    v327 v330
    let v331 : (unit -> US0) = closure14()
    let v332 : (unit -> Types.EmitType<Types.std.string.String>) = closure15()
    let v333 : string = "387957"
    let v334 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v331, v332, v333)
    let v335 : string = "std::fs::metadata($0).unwrap().modified().unwrap()"
    let v336 : Types.std.time.SystemTime = Fable.Core.Rust.emitExpr v117 v335
    let v337 : US0 = US0_0
    let v338 : (Types.EmitType<Types.std.string.String> -> unit) = v334 v337
    let v339 : Types.std.string.String = Fable.Core.Rust.emitExpr v120 v9
    let v340 : Types.EmitType<Types.std.string.String> = v339 |> unbox<Types.EmitType<Types.std.string.String>>
    let v341 : string = Fable.Core.Rust.emitExpr v117 v19
    let v342 : Types.std.string.String = Fable.Core.Rust.emitExpr v341 v9
    let v343 : Types.EmitType<Types.std.string.String> = v342 |> unbox<Types.EmitType<Types.std.string.String>>
    let v344 : string = "start:"
    let v345 : Types.std.string.String = Fable.Core.Rust.emitExpr v344 v9
    let v346 : Types.EmitType<Types.std.string.String> = v345 |> unbox<Types.EmitType<Types.std.string.String>>
    let v347 : string = "format!(\"{:?}\", $0)"
    let v348 : Types.std.string.String = Fable.Core.Rust.emitExpr v336 v347
    let v349 : Types.EmitType<Types.std.string.String> = v348 |> unbox<Types.EmitType<Types.std.string.String>>
    let v350 : (Types.EmitType<Types.std.string.String> []) = [|v340; v343; v346; v349|]
    let v351 : obj = Fable.Core.Rust.emitExpr v350 v37
    let v352 : Types.std.string.String = Fable.Core.Rust.emitExpr v351 v39
    let v353 : Types.EmitType<Types.std.string.String> = v352 |> unbox<Types.EmitType<Types.std.string.String>>
    v338 v353
    let v354 : (int32 []) = [| 0..50 |]
    let v355 : int32 = v354.Length
    let v356 : US1 = US1_0
    let v357 : Mut0 = {l0 = 0; l1 = v356} : Mut0
    while method3(v355, v357) do
        let v359 : int32 = v357.l0
        let v360 : US1 = v357.l1
        let v361 : int32 = v354.[int v359]
        let v392 : US1 =
            match v360 with
            | US1_0 -> (* None *)
                let v364 : Types.std.time.SystemTime = Fable.Core.Rust.emitExpr v117 v335
                let v365 : US0 = US0_0
                let v366 : (Types.EmitType<Types.std.string.String> -> unit) = v334 v365
                let v367 : string = "i:"
                let v368 : Types.std.string.String = Fable.Core.Rust.emitExpr v367 v9
                let v369 : Types.EmitType<Types.std.string.String> = v368 |> unbox<Types.EmitType<Types.std.string.String>>
                let v370 : Types.std.string.String = Fable.Core.Rust.emitExpr v361 v159
                let v371 : Types.EmitType<Types.std.string.String> = v370 |> unbox<Types.EmitType<Types.std.string.String>>
                let v372 : string = "last_modified:"
                let v373 : Types.std.string.String = Fable.Core.Rust.emitExpr v372 v9
                let v374 : Types.EmitType<Types.std.string.String> = v373 |> unbox<Types.EmitType<Types.std.string.String>>
                let v375 : Types.std.string.String = Fable.Core.Rust.emitExpr v364 v347
                let v376 : Types.EmitType<Types.std.string.String> = v375 |> unbox<Types.EmitType<Types.std.string.String>>
                let v377 : (Types.EmitType<Types.std.string.String> []) = [|v369; v371; v374; v376|]
                let v378 : obj = Fable.Core.Rust.emitExpr v377 v37
                let v379 : Types.std.string.String = Fable.Core.Rust.emitExpr v378 v39
                let v380 : Types.EmitType<Types.std.string.String> = v379 |> unbox<Types.EmitType<Types.std.string.String>>
                v366 v380
                let v381 : string = "$0 > $1"
                let v382 : bool = Fable.Core.Rust.emitExpr struct (v364, v336) v381
                if v382 then
                    let v383 : Result<Types.std.string.String, Types.std.io.Error> = Fable.Core.Rust.emitExpr v117 v139
                    let v384 : Types.std.string.String = Fable.Core.Rust.emitExpr v383 v141
                    let v385 : string = "fable_library_rust::String_::fromStr($0)"
                    let v386 : string = Fable.Core.Rust.emitExpr v384 v385
                    US1_1(v386)
                else
                    let v388 : string = "std::thread::sleep(std::time::Duration::from_millis(*$0))"
                    Fable.Core.Rust.emitExpr 25UL v388
                    US1_0
            | US1_1(v362) -> (* Some *)
                US1_1(v362)
        let v393 : int32 = v359 + 1
        v357.l0 <- v393
        v357.l1 <- v392
        ()
    let v394 : US1 = v357.l1
    let v397 : string =
        match v394 with
        | US1_0 -> (* None *)
            v130
        | US1_1(v395) -> (* Some *)
            v395
    let v398 : US0 = US0_0
    let v399 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v398
    let v400 : string = "new_fsx.len():"
    let v401 : Types.std.string.String = Fable.Core.Rust.emitExpr v400 v9
    let v402 : Types.EmitType<Types.std.string.String> = v401 |> unbox<Types.EmitType<Types.std.string.String>>
    let v403 : int32 = Fable.Core.Rust.emitExpr v397 v157
    let v404 : Types.std.string.String = Fable.Core.Rust.emitExpr v403 v159
    let v405 : Types.EmitType<Types.std.string.String> = v404 |> unbox<Types.EmitType<Types.std.string.String>>
    let v406 : (Types.EmitType<Types.std.string.String> []) = [|v402; v405|]
    let v407 : obj = Fable.Core.Rust.emitExpr v406 v37
    let v408 : Types.std.string.String = Fable.Core.Rust.emitExpr v407 v39
    let v409 : Types.EmitType<Types.std.string.String> = v408 |> unbox<Types.EmitType<Types.std.string.String>>
    v399 v409
    let v410 : Types.std.path.PathBuf = v1 |> Option.defaultValue v117
    let v411 : Result<unit, Types.std.io.Error> = Fable.Core.Rust.emitExpr struct (v410, v397) v131
    Fable.Core.Rust.emitExpr v411 v133
    let v412 : US0 = US0_0
    let v413 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v412
    let v414 : string = "> fs_write new_fsx_path; ok"
    let v415 : Types.std.string.String = Fable.Core.Rust.emitExpr v414 v9
    let v416 : Types.EmitType<Types.std.string.String> = v415 |> unbox<Types.EmitType<Types.std.string.String>>
    v413 v416
    v397
and closure0 () (v0 : Types.std.path.PathBuf) : (Option<Types.std.path.PathBuf> -> string) =
    closure1(v0)
let v0 : (Types.std.path.PathBuf -> (Option<Types.std.path.PathBuf> -> string)) = closure0()
()
