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
and closure4 () (v0 : string) : unit =
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
and closure6 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : (string -> unit), v3 : string, v4 : int64, v5 : US0) (v6 : Types.EmitType<Types.std.string.String>) : unit =
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
        ()
and closure5 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : (string -> unit), v3 : string, v4 : int64) (v5 : US0) : (Types.EmitType<Types.std.string.String> -> unit) =
    closure6(v0, v1, v2, v3, v4, v5)
and method0 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : (string -> unit), v3 : string) : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) =
    let struct (v4 : string, v5 : string, v6 : string, v7 : bool) = method1()
    let v8 : string = "chrono::Utc::now()"
    let v9 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v8
    let v10 : string = "($0).timestamp()"
    let v11 : int64 = Fable.Core.Rust.emitExpr v9 v10
    closure5(v0, v1, v2, v3, v11)
and closure7 () (v0 : Types.Ref<Types.std.path.Path>) : Types.std.path.PathBuf =
    let v1 : string = "package.spiproj"
    let v2 : string = "$1.join($0.as_str())"
    let v3 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr struct (v1, v0) v2
    v3
and closure8 () (v0 : Types.Ref<Types.std.path.PathBuf>) : bool =
    let v1 : string = "std::path::Path::exists($0)"
    let v2 : bool = Fable.Core.Rust.emitExpr v0 v1
    v2
and closure9 () () : US0 =
    US0_0
and closure10 () () : Types.EmitType<Types.std.string.String> =
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
and closure11 () () : US0 =
    US0_0
and closure12 () () : Types.EmitType<Types.std.string.String> =
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
and closure13 () () : US0 =
    US0_0
and closure14 () () : Types.EmitType<Types.std.string.String> =
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
and closure15 () () : US0 =
    US0_0
and closure16 () () : Types.EmitType<Types.std.string.String> =
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
    let v4 : (string -> unit) = closure4()
    let v5 : string = "de884c"
    let v6 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v2, v3, v4, v5)
    let v7 : US0 = US0_0
    let v8 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v7
    let v9 : string = "pwd:"
    let v10 : string = "($0).to_string()"
    let v11 : Types.std.string.String = Fable.Core.Rust.emitExpr v9 v10
    let v12 : Types.EmitType<Types.std.string.String> = v11 |> unbox<Types.EmitType<Types.std.string.String>>
    let v13 : string = "std::env::current_dir()"
    let v14 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr () v13
    let v15 : string = "($0).as_ref().unwrap().to_path_buf()"
    let v16 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v14 v15
    let v17 : string = "($0).canonicalize()"
    let v18 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v16 v17
    let v19 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v18 v15
    let v20 : string = "fable_library_rust::String_::fromStr(&format!(\"{}\", $0.display()))"
    let v21 : string = Fable.Core.Rust.emitExpr v19 v20
    let v22 : Types.std.string.String = Fable.Core.Rust.emitExpr v21 v10
    let v23 : Types.EmitType<Types.std.string.String> = v22 |> unbox<Types.EmitType<Types.std.string.String>>
    let v24 : string = "spi_path:"
    let v25 : Types.std.string.String = Fable.Core.Rust.emitExpr v24 v10
    let v26 : Types.EmitType<Types.std.string.String> = v25 |> unbox<Types.EmitType<Types.std.string.String>>
    let v27 : string = Fable.Core.Rust.emitExpr v0 v20
    let v28 : Types.std.string.String = Fable.Core.Rust.emitExpr v27 v10
    let v29 : Types.EmitType<Types.std.string.String> = v28 |> unbox<Types.EmitType<Types.std.string.String>>
    let v30 : string = "new_fsx_path:"
    let v31 : Types.std.string.String = Fable.Core.Rust.emitExpr v30 v10
    let v32 : Types.EmitType<Types.std.string.String> = v31 |> unbox<Types.EmitType<Types.std.string.String>>
    let v33 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v1 v15
    let v34 : string = Fable.Core.Rust.emitExpr v33 v20
    let v35 : Types.std.string.String = Fable.Core.Rust.emitExpr v34 v10
    let v36 : Types.EmitType<Types.std.string.String> = v35 |> unbox<Types.EmitType<Types.std.string.String>>
    let v37 : (Types.EmitType<Types.std.string.String> []) = [|v12; v23; v26; v29; v32; v36|]
    let v38 : string = "core::ops::Deref::deref($0)"
    let v39 : obj = Fable.Core.Rust.emitExpr v37 v38
    let v40 : string = "format!(\"{:?}\", ***$0)"
    let v41 : Types.std.string.String = Fable.Core.Rust.emitExpr v39 v40
    let v42 : Types.EmitType<Types.std.string.String> = v41 |> unbox<Types.EmitType<Types.std.string.String>>
    v8 v42
    let v43 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v0 v17
    let v44 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v43 v15
    let v45 : US0 = US0_0
    let v46 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v45
    let v47 : string = "spi_path_clean:"
    let v48 : Types.std.string.String = Fable.Core.Rust.emitExpr v47 v10
    let v49 : Types.EmitType<Types.std.string.String> = v48 |> unbox<Types.EmitType<Types.std.string.String>>
    let v50 : string = Fable.Core.Rust.emitExpr v44 v20
    let v51 : Types.std.string.String = Fable.Core.Rust.emitExpr v50 v10
    let v52 : Types.EmitType<Types.std.string.String> = v51 |> unbox<Types.EmitType<Types.std.string.String>>
    let v53 : (Types.EmitType<Types.std.string.String> []) = [|v49; v52|]
    let v54 : obj = Fable.Core.Rust.emitExpr v53 v38
    let v55 : Types.std.string.String = Fable.Core.Rust.emitExpr v54 v40
    let v56 : Types.EmitType<Types.std.string.String> = v55 |> unbox<Types.EmitType<Types.std.string.String>>
    v46 v56
    let v57 : string = "($0).parent()"
    let v58 : Option<Types.Ref<Types.std.path.Path>> = Fable.Core.Rust.emitExpr v44 v57
    let v59 : string = "($0).unwrap()"
    let v60 : Types.Ref<Types.std.path.Path> = Fable.Core.Rust.emitExpr v58 v59
    let v61 : string = "std::path::PathBuf::from($0)"
    let v62 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v60 v61
    let v63 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v62 v17
    let v64 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v63 v15
    let v65 : US0 = US0_0
    let v66 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v65
    let v67 : string = "src_path:"
    let v68 : Types.std.string.String = Fable.Core.Rust.emitExpr v67 v10
    let v69 : Types.EmitType<Types.std.string.String> = v68 |> unbox<Types.EmitType<Types.std.string.String>>
    let v70 : string = Fable.Core.Rust.emitExpr v64 v20
    let v71 : Types.std.string.String = Fable.Core.Rust.emitExpr v70 v10
    let v72 : Types.EmitType<Types.std.string.String> = v71 |> unbox<Types.EmitType<Types.std.string.String>>
    let v73 : (Types.EmitType<Types.std.string.String> []) = [|v69; v72|]
    let v74 : obj = Fable.Core.Rust.emitExpr v73 v38
    let v75 : Types.std.string.String = Fable.Core.Rust.emitExpr v74 v40
    let v76 : Types.EmitType<Types.std.string.String> = v75 |> unbox<Types.EmitType<Types.std.string.String>>
    v66 v76
    let v77 : string = "$0.ancestors()"
    let v78 : Types.Ref<Types.std.path.Ancestors> = Fable.Core.Rust.emitExpr v64 v77
    let v79 : unativeint = unativeint 10
    let v80 : string = "$1.take($0)"
    let v81 : Types.std.iter.Iterator<Types.Ref<Types.std.path.Path>> = Fable.Core.Rust.emitExpr struct (v79, v78) v80
    let v82 : (Types.Ref<Types.std.path.Path> -> Types.std.path.PathBuf) = closure7()
    let v83 : Types.Ref<(Types.Ref<Types.std.path.Path> -> Types.std.path.PathBuf)> = v82 |> unbox
    let v84 : string = "$1.into_iter().map($0)"
    let v85 : Types.std.iter.Iterator<Types.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v83, v81) v84
    let v86 : (Types.Ref<Types.std.path.PathBuf> -> bool) = closure8()
    let v87 : Types.Ref<(Types.Ref<Types.std.path.PathBuf> -> bool)> = v86 |> unbox
    let v88 : string = "$1.into_iter().find($0)"
    let v89 : Option<Types.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v87, v85) v88
    let v90 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v89 v15
    let v91 : US0 = US0_0
    let v92 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v91
    let v93 : string = "spiproj_path:"
    let v94 : Types.std.string.String = Fable.Core.Rust.emitExpr v93 v10
    let v95 : Types.EmitType<Types.std.string.String> = v94 |> unbox<Types.EmitType<Types.std.string.String>>
    let v96 : string = Fable.Core.Rust.emitExpr v90 v20
    let v97 : Types.std.string.String = Fable.Core.Rust.emitExpr v96 v10
    let v98 : Types.EmitType<Types.std.string.String> = v97 |> unbox<Types.EmitType<Types.std.string.String>>
    let v99 : (Types.EmitType<Types.std.string.String> []) = [|v95; v98|]
    let v100 : obj = Fable.Core.Rust.emitExpr v99 v38
    let v101 : Types.std.string.String = Fable.Core.Rust.emitExpr v100 v40
    let v102 : Types.EmitType<Types.std.string.String> = v101 |> unbox<Types.EmitType<Types.std.string.String>>
    v92 v102
    let v103 : string = "($0).to_str()"
    let v104 : Option<Types.Ref<Types.Str>> = Fable.Core.Rust.emitExpr v44 v103
    let v105 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v104 v59
    let v106 : string = ".spir"
    let v107 : Types.Ref<string> = v106 |> unbox
    let v108 : string = ".spi"
    let v109 : Types.Ref<string> = v108 |> unbox
    let v110 : string = "&$2.replace(&*$0, &$1)"
    let v111 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v107, v109, v105) v110
    let v112 : Types.Ref<string> = v108 |> unbox
    let v113 : string = ".fsx"
    let v114 : Types.Ref<string> = v113 |> unbox
    let v115 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v112, v114, v111) v110
    let v116 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v115 v61
    let v117 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v116 v17
    let v118 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v117 v15
    let v119 : US0 = US0_0
    let v120 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v119
    let v121 : string = "fsx_path:"
    let v122 : Types.std.string.String = Fable.Core.Rust.emitExpr v121 v10
    let v123 : Types.EmitType<Types.std.string.String> = v122 |> unbox<Types.EmitType<Types.std.string.String>>
    let v124 : string = Fable.Core.Rust.emitExpr v118 v20
    let v125 : Types.std.string.String = Fable.Core.Rust.emitExpr v124 v10
    let v126 : Types.EmitType<Types.std.string.String> = v125 |> unbox<Types.EmitType<Types.std.string.String>>
    let v127 : (Types.EmitType<Types.std.string.String> []) = [|v123; v126|]
    let v128 : obj = Fable.Core.Rust.emitExpr v127 v38
    let v129 : Types.std.string.String = Fable.Core.Rust.emitExpr v128 v40
    let v130 : Types.EmitType<Types.std.string.String> = v129 |> unbox<Types.EmitType<Types.std.string.String>>
    v120 v130
    let v131 : string = ""
    let v132 : string = "std::fs::write($0, $1.as_str())"
    let v133 : Result<unit, Types.std.io.Error> = Fable.Core.Rust.emitExpr struct (v118, v131) v132
    let v134 : string = "*(($0).as_ref()).unwrap()"
    Fable.Core.Rust.emitExpr v133 v134
    let v135 : US0 = US0_0
    let v136 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v135
    let v137 : string = "> fs_write fsx_path \"\"; ok"
    let v138 : Types.std.string.String = Fable.Core.Rust.emitExpr v137 v10
    let v139 : Types.EmitType<Types.std.string.String> = v138 |> unbox<Types.EmitType<Types.std.string.String>>
    v136 v139
    let v140 : string = "std::fs::read_to_string($0)"
    let v141 : Result<Types.std.string.String, Types.std.io.Error> = Fable.Core.Rust.emitExpr v90 v140
    let v142 : string = "($0).as_ref().unwrap().to_string()"
    let v143 : Types.std.string.String = Fable.Core.Rust.emitExpr v141 v142
    let v144 : (unit -> US0) = closure9()
    let v145 : (unit -> Types.EmitType<Types.std.string.String>) = closure10()
    let v146 : string = "e36a62"
    let v147 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v144, v145, v4, v146)
    let v148 : US0 = US0_0
    let v149 : (Types.EmitType<Types.std.string.String> -> unit) = v147 v148
    let v150 : Types.std.string.String = Fable.Core.Rust.emitExpr v93 v10
    let v151 : Types.EmitType<Types.std.string.String> = v150 |> unbox<Types.EmitType<Types.std.string.String>>
    let v152 : string = Fable.Core.Rust.emitExpr v90 v20
    let v153 : Types.std.string.String = Fable.Core.Rust.emitExpr v152 v10
    let v154 : Types.EmitType<Types.std.string.String> = v153 |> unbox<Types.EmitType<Types.std.string.String>>
    let v155 : string = "spiproj_text.len():"
    let v156 : Types.std.string.String = Fable.Core.Rust.emitExpr v155 v10
    let v157 : Types.EmitType<Types.std.string.String> = v156 |> unbox<Types.EmitType<Types.std.string.String>>
    let v158 : string = "($0).len().try_into().unwrap()"
    let v159 : int32 = Fable.Core.Rust.emitExpr v143 v158
    let v160 : string = "format!(\"{}\", $0)"
    let v161 : Types.std.string.String = Fable.Core.Rust.emitExpr v159 v160
    let v162 : Types.EmitType<Types.std.string.String> = v161 |> unbox<Types.EmitType<Types.std.string.String>>
    let v163 : (Types.EmitType<Types.std.string.String> []) = [|v151; v154; v157; v162|]
    let v164 : obj = Fable.Core.Rust.emitExpr v163 v38
    let v165 : Types.std.string.String = Fable.Core.Rust.emitExpr v164 v40
    let v166 : Types.EmitType<Types.std.string.String> = v165 |> unbox<Types.EmitType<Types.std.string.String>>
    v149 v166
    let v167 : string = "{"
    let v168 : string = "\"ProjectFileOpen\": {"
    let v169 : string = v167 + v168
    let v170 : string = "\"uri\": $0,"
    let v171 : string = v169 + v170
    let v172 : string = "\"spiprojText\": $1"
    let v173 : string = v171 + v172
    let v174 : string = "}"
    let v175 : string = v173 + v174
    let v176 : string = v175 + v174
    let v177 : string = "serde_json::json!("
    let v178 : string = v177 + v176
    let v179 : string = ").to_string()"
    let v180 : string = v178 + v179
    let v181 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v90, v143) v180
    let v182 : US0 = US0_0
    let v183 : (Types.EmitType<Types.std.string.String> -> unit) = v147 v182
    let v184 : string = "json.len():"
    let v185 : Types.std.string.String = Fable.Core.Rust.emitExpr v184 v10
    let v186 : Types.EmitType<Types.std.string.String> = v185 |> unbox<Types.EmitType<Types.std.string.String>>
    let v187 : int32 = Fable.Core.Rust.emitExpr v181 v158
    let v188 : Types.std.string.String = Fable.Core.Rust.emitExpr v187 v160
    let v189 : Types.EmitType<Types.std.string.String> = v188 |> unbox<Types.EmitType<Types.std.string.String>>
    let v190 : (Types.EmitType<Types.std.string.String> []) = [|v186; v189|]
    let v191 : obj = Fable.Core.Rust.emitExpr v190 v38
    let v192 : Types.std.string.String = Fable.Core.Rust.emitExpr v191 v40
    let v193 : Types.EmitType<Types.std.string.String> = v192 |> unbox<Types.EmitType<Types.std.string.String>>
    v183 v193
    let v194 : (unit -> US0) = closure11()
    let v195 : (unit -> Types.EmitType<Types.std.string.String>) = closure12()
    let v196 : string = "fcfb1b"
    let v197 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v194, v195, v4, v196)
    let v198 : US0 = US0_0
    let v199 : (Types.EmitType<Types.std.string.String> -> unit) = v197 v198
    let v200 : string = "host:"
    let v201 : Types.std.string.String = Fable.Core.Rust.emitExpr v200 v10
    let v202 : Types.EmitType<Types.std.string.String> = v201 |> unbox<Types.EmitType<Types.std.string.String>>
    let v203 : string = "localhost"
    let v204 : Types.std.string.String = Fable.Core.Rust.emitExpr v203 v10
    let v205 : Types.EmitType<Types.std.string.String> = v204 |> unbox<Types.EmitType<Types.std.string.String>>
    let v206 : string = "port:"
    let v207 : Types.std.string.String = Fable.Core.Rust.emitExpr v206 v10
    let v208 : Types.EmitType<Types.std.string.String> = v207 |> unbox<Types.EmitType<Types.std.string.String>>
    let v209 : Types.std.string.String = Fable.Core.Rust.emitExpr 13805 v160
    let v210 : Types.EmitType<Types.std.string.String> = v209 |> unbox<Types.EmitType<Types.std.string.String>>
    let v211 : string = "msg.len():"
    let v212 : Types.std.string.String = Fable.Core.Rust.emitExpr v211 v10
    let v213 : Types.EmitType<Types.std.string.String> = v212 |> unbox<Types.EmitType<Types.std.string.String>>
    let v214 : int32 = Fable.Core.Rust.emitExpr v181 v158
    let v215 : Types.std.string.String = Fable.Core.Rust.emitExpr v214 v160
    let v216 : Types.EmitType<Types.std.string.String> = v215 |> unbox<Types.EmitType<Types.std.string.String>>
    let v217 : (Types.EmitType<Types.std.string.String> []) = [|v202; v205; v208; v210; v213; v216|]
    let v218 : obj = Fable.Core.Rust.emitExpr v217 v38
    let v219 : Types.std.string.String = Fable.Core.Rust.emitExpr v218 v40
    let v220 : Types.EmitType<Types.std.string.String> = v219 |> unbox<Types.EmitType<Types.std.string.String>>
    v199 v220
    let v221 : string = "zmq::Context::new()"
    let v222 : obj = Fable.Core.Rust.emitExpr () v221
    let v223 : string = "$0.socket(zmq::REQ).unwrap()"
    let v224 : obj = Fable.Core.Rust.emitExpr v222 v223
    let v225 : string = $"tcp://{v203}:{13805}"
    let v226 : string = "$0.connect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v224, v225) v226
    let v227 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v224, v181) v227
    let v228 : string = "$0.recv_string(0).unwrap().unwrap()"
    let v229 : Types.std.string.String = Fable.Core.Rust.emitExpr v224 v228
    let v230 : string = "$0.disconnect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v224, v225) v230
    let v231 : US0 = US0_0
    let v232 : (Types.EmitType<Types.std.string.String> -> unit) = v197 v231
    let v233 : string = "result.len():"
    let v234 : Types.std.string.String = Fable.Core.Rust.emitExpr v233 v10
    let v235 : Types.EmitType<Types.std.string.String> = v234 |> unbox<Types.EmitType<Types.std.string.String>>
    let v236 : int32 = Fable.Core.Rust.emitExpr v229 v158
    let v237 : Types.std.string.String = Fable.Core.Rust.emitExpr v236 v160
    let v238 : Types.EmitType<Types.std.string.String> = v237 |> unbox<Types.EmitType<Types.std.string.String>>
    let v239 : (Types.EmitType<Types.std.string.String> []) = [|v235; v238|]
    let v240 : obj = Fable.Core.Rust.emitExpr v239 v38
    let v241 : Types.std.string.String = Fable.Core.Rust.emitExpr v240 v40
    let v242 : Types.EmitType<Types.std.string.String> = v241 |> unbox<Types.EmitType<Types.std.string.String>>
    v232 v242
    let v243 : US0 = US0_0
    let v244 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v243
    let v245 : string = "> spiproj_open; ok"
    let v246 : Types.std.string.String = Fable.Core.Rust.emitExpr v245 v10
    let v247 : Types.EmitType<Types.std.string.String> = v246 |> unbox<Types.EmitType<Types.std.string.String>>
    v244 v247
    let v248 : (unit -> US0) = closure13()
    let v249 : (unit -> Types.EmitType<Types.std.string.String>) = closure14()
    let v250 : string = "98d5ef"
    let v251 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v248, v249, v4, v250)
    let v252 : US0 = US0_0
    let v253 : (Types.EmitType<Types.std.string.String> -> unit) = v251 v252
    let v254 : Types.std.string.String = Fable.Core.Rust.emitExpr v24 v10
    let v255 : Types.EmitType<Types.std.string.String> = v254 |> unbox<Types.EmitType<Types.std.string.String>>
    let v256 : string = Fable.Core.Rust.emitExpr v44 v20
    let v257 : Types.std.string.String = Fable.Core.Rust.emitExpr v256 v10
    let v258 : Types.EmitType<Types.std.string.String> = v257 |> unbox<Types.EmitType<Types.std.string.String>>
    let v259 : string = "backend:"
    let v260 : Types.std.string.String = Fable.Core.Rust.emitExpr v259 v10
    let v261 : Types.EmitType<Types.std.string.String> = v260 |> unbox<Types.EmitType<Types.std.string.String>>
    let v262 : string = "Fsharp"
    let v263 : Types.std.string.String = Fable.Core.Rust.emitExpr v262 v10
    let v264 : Types.EmitType<Types.std.string.String> = v263 |> unbox<Types.EmitType<Types.std.string.String>>
    let v265 : (Types.EmitType<Types.std.string.String> []) = [|v255; v258; v261; v264|]
    let v266 : obj = Fable.Core.Rust.emitExpr v265 v38
    let v267 : Types.std.string.String = Fable.Core.Rust.emitExpr v266 v40
    let v268 : Types.EmitType<Types.std.string.String> = v267 |> unbox<Types.EmitType<Types.std.string.String>>
    v253 v268
    let v269 : Types.std.string.String = Fable.Core.Rust.emitExpr v262 v10
    let v270 : string = "\"BuildFile\": {"
    let v271 : string = v167 + v270
    let v272 : string = v271 + v170
    let v273 : string = "\"backend\": $1"
    let v274 : string = v272 + v273
    let v275 : string = v274 + v174
    let v276 : string = v275 + v174
    let v277 : string = v177 + v276
    let v278 : string = v277 + v179
    let v279 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v44, v269) v278
    let v280 : US0 = US0_0
    let v281 : (Types.EmitType<Types.std.string.String> -> unit) = v251 v280
    let v282 : Types.std.string.String = Fable.Core.Rust.emitExpr v184 v10
    let v283 : Types.EmitType<Types.std.string.String> = v282 |> unbox<Types.EmitType<Types.std.string.String>>
    let v284 : int32 = Fable.Core.Rust.emitExpr v279 v158
    let v285 : Types.std.string.String = Fable.Core.Rust.emitExpr v284 v160
    let v286 : Types.EmitType<Types.std.string.String> = v285 |> unbox<Types.EmitType<Types.std.string.String>>
    let v287 : (Types.EmitType<Types.std.string.String> []) = [|v283; v286|]
    let v288 : obj = Fable.Core.Rust.emitExpr v287 v38
    let v289 : Types.std.string.String = Fable.Core.Rust.emitExpr v288 v40
    let v290 : Types.EmitType<Types.std.string.String> = v289 |> unbox<Types.EmitType<Types.std.string.String>>
    v281 v290
    let v291 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v194, v195, v4, v196)
    let v292 : US0 = US0_0
    let v293 : (Types.EmitType<Types.std.string.String> -> unit) = v291 v292
    let v294 : Types.std.string.String = Fable.Core.Rust.emitExpr v200 v10
    let v295 : Types.EmitType<Types.std.string.String> = v294 |> unbox<Types.EmitType<Types.std.string.String>>
    let v296 : Types.std.string.String = Fable.Core.Rust.emitExpr v203 v10
    let v297 : Types.EmitType<Types.std.string.String> = v296 |> unbox<Types.EmitType<Types.std.string.String>>
    let v298 : Types.std.string.String = Fable.Core.Rust.emitExpr v206 v10
    let v299 : Types.EmitType<Types.std.string.String> = v298 |> unbox<Types.EmitType<Types.std.string.String>>
    let v300 : Types.std.string.String = Fable.Core.Rust.emitExpr 13805 v160
    let v301 : Types.EmitType<Types.std.string.String> = v300 |> unbox<Types.EmitType<Types.std.string.String>>
    let v302 : Types.std.string.String = Fable.Core.Rust.emitExpr v211 v10
    let v303 : Types.EmitType<Types.std.string.String> = v302 |> unbox<Types.EmitType<Types.std.string.String>>
    let v304 : int32 = Fable.Core.Rust.emitExpr v279 v158
    let v305 : Types.std.string.String = Fable.Core.Rust.emitExpr v304 v160
    let v306 : Types.EmitType<Types.std.string.String> = v305 |> unbox<Types.EmitType<Types.std.string.String>>
    let v307 : (Types.EmitType<Types.std.string.String> []) = [|v295; v297; v299; v301; v303; v306|]
    let v308 : obj = Fable.Core.Rust.emitExpr v307 v38
    let v309 : Types.std.string.String = Fable.Core.Rust.emitExpr v308 v40
    let v310 : Types.EmitType<Types.std.string.String> = v309 |> unbox<Types.EmitType<Types.std.string.String>>
    v293 v310
    let v311 : obj = Fable.Core.Rust.emitExpr () v221
    let v312 : obj = Fable.Core.Rust.emitExpr v311 v223
    let v313 : string = $"tcp://{v203}:{13805}"
    Fable.Core.Rust.emitExpr struct (v312, v313) v226
    let v314 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v312, v279) v314
    let v315 : Types.std.string.String = Fable.Core.Rust.emitExpr v312 v228
    Fable.Core.Rust.emitExpr struct (v312, v313) v230
    let v316 : US0 = US0_0
    let v317 : (Types.EmitType<Types.std.string.String> -> unit) = v291 v316
    let v318 : Types.std.string.String = Fable.Core.Rust.emitExpr v233 v10
    let v319 : Types.EmitType<Types.std.string.String> = v318 |> unbox<Types.EmitType<Types.std.string.String>>
    let v320 : int32 = Fable.Core.Rust.emitExpr v315 v158
    let v321 : Types.std.string.String = Fable.Core.Rust.emitExpr v320 v160
    let v322 : Types.EmitType<Types.std.string.String> = v321 |> unbox<Types.EmitType<Types.std.string.String>>
    let v323 : (Types.EmitType<Types.std.string.String> []) = [|v319; v322|]
    let v324 : obj = Fable.Core.Rust.emitExpr v323 v38
    let v325 : Types.std.string.String = Fable.Core.Rust.emitExpr v324 v40
    let v326 : Types.EmitType<Types.std.string.String> = v325 |> unbox<Types.EmitType<Types.std.string.String>>
    v317 v326
    let v327 : US0 = US0_0
    let v328 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v327
    let v329 : string = "> spi_build_file; ok"
    let v330 : Types.std.string.String = Fable.Core.Rust.emitExpr v329 v10
    let v331 : Types.EmitType<Types.std.string.String> = v330 |> unbox<Types.EmitType<Types.std.string.String>>
    v328 v331
    let v332 : (unit -> US0) = closure15()
    let v333 : (unit -> Types.EmitType<Types.std.string.String>) = closure16()
    let v334 : string = "387957"
    let v335 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v332, v333, v4, v334)
    let v336 : string = "std::fs::metadata($0).unwrap().modified().unwrap()"
    let v337 : Types.std.time.SystemTime = Fable.Core.Rust.emitExpr v118 v336
    let v338 : US0 = US0_0
    let v339 : (Types.EmitType<Types.std.string.String> -> unit) = v335 v338
    let v340 : Types.std.string.String = Fable.Core.Rust.emitExpr v121 v10
    let v341 : Types.EmitType<Types.std.string.String> = v340 |> unbox<Types.EmitType<Types.std.string.String>>
    let v342 : string = Fable.Core.Rust.emitExpr v118 v20
    let v343 : Types.std.string.String = Fable.Core.Rust.emitExpr v342 v10
    let v344 : Types.EmitType<Types.std.string.String> = v343 |> unbox<Types.EmitType<Types.std.string.String>>
    let v345 : string = "start:"
    let v346 : Types.std.string.String = Fable.Core.Rust.emitExpr v345 v10
    let v347 : Types.EmitType<Types.std.string.String> = v346 |> unbox<Types.EmitType<Types.std.string.String>>
    let v348 : string = "format!(\"{:?}\", $0)"
    let v349 : Types.std.string.String = Fable.Core.Rust.emitExpr v337 v348
    let v350 : Types.EmitType<Types.std.string.String> = v349 |> unbox<Types.EmitType<Types.std.string.String>>
    let v351 : (Types.EmitType<Types.std.string.String> []) = [|v341; v344; v347; v350|]
    let v352 : obj = Fable.Core.Rust.emitExpr v351 v38
    let v353 : Types.std.string.String = Fable.Core.Rust.emitExpr v352 v40
    let v354 : Types.EmitType<Types.std.string.String> = v353 |> unbox<Types.EmitType<Types.std.string.String>>
    v339 v354
    let v355 : (int32 []) = [| 0..50 |]
    let v356 : int32 = v355.Length
    let v357 : US1 = US1_0
    let v358 : Mut0 = {l0 = 0; l1 = v357} : Mut0
    while method3(v356, v358) do
        let v360 : int32 = v358.l0
        let v361 : US1 = v358.l1
        let v362 : int32 = v355.[int v360]
        let v393 : US1 =
            match v361 with
            | US1_0 -> (* None *)
                let v365 : Types.std.time.SystemTime = Fable.Core.Rust.emitExpr v118 v336
                let v366 : US0 = US0_0
                let v367 : (Types.EmitType<Types.std.string.String> -> unit) = v335 v366
                let v368 : string = "i:"
                let v369 : Types.std.string.String = Fable.Core.Rust.emitExpr v368 v10
                let v370 : Types.EmitType<Types.std.string.String> = v369 |> unbox<Types.EmitType<Types.std.string.String>>
                let v371 : Types.std.string.String = Fable.Core.Rust.emitExpr v362 v160
                let v372 : Types.EmitType<Types.std.string.String> = v371 |> unbox<Types.EmitType<Types.std.string.String>>
                let v373 : string = "last_modified:"
                let v374 : Types.std.string.String = Fable.Core.Rust.emitExpr v373 v10
                let v375 : Types.EmitType<Types.std.string.String> = v374 |> unbox<Types.EmitType<Types.std.string.String>>
                let v376 : Types.std.string.String = Fable.Core.Rust.emitExpr v365 v348
                let v377 : Types.EmitType<Types.std.string.String> = v376 |> unbox<Types.EmitType<Types.std.string.String>>
                let v378 : (Types.EmitType<Types.std.string.String> []) = [|v370; v372; v375; v377|]
                let v379 : obj = Fable.Core.Rust.emitExpr v378 v38
                let v380 : Types.std.string.String = Fable.Core.Rust.emitExpr v379 v40
                let v381 : Types.EmitType<Types.std.string.String> = v380 |> unbox<Types.EmitType<Types.std.string.String>>
                v367 v381
                let v382 : string = "$0 > $1"
                let v383 : bool = Fable.Core.Rust.emitExpr struct (v365, v337) v382
                if v383 then
                    let v384 : Result<Types.std.string.String, Types.std.io.Error> = Fable.Core.Rust.emitExpr v118 v140
                    let v385 : Types.std.string.String = Fable.Core.Rust.emitExpr v384 v142
                    let v386 : string = "fable_library_rust::String_::fromStr($0)"
                    let v387 : string = Fable.Core.Rust.emitExpr v385 v386
                    US1_1(v387)
                else
                    let v389 : string = "std::thread::sleep(std::time::Duration::from_millis(*$0))"
                    Fable.Core.Rust.emitExpr 25UL v389
                    US1_0
            | US1_1(v363) -> (* Some *)
                US1_1(v363)
        let v394 : int32 = v360 + 1
        v358.l0 <- v394
        v358.l1 <- v393
        ()
    let v395 : US1 = v358.l1
    let v398 : string =
        match v395 with
        | US1_0 -> (* None *)
            v131
        | US1_1(v396) -> (* Some *)
            v396
    let v399 : US0 = US0_0
    let v400 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v399
    let v401 : string = "new_fsx.len():"
    let v402 : Types.std.string.String = Fable.Core.Rust.emitExpr v401 v10
    let v403 : Types.EmitType<Types.std.string.String> = v402 |> unbox<Types.EmitType<Types.std.string.String>>
    let v404 : int32 = Fable.Core.Rust.emitExpr v398 v158
    let v405 : Types.std.string.String = Fable.Core.Rust.emitExpr v404 v160
    let v406 : Types.EmitType<Types.std.string.String> = v405 |> unbox<Types.EmitType<Types.std.string.String>>
    let v407 : (Types.EmitType<Types.std.string.String> []) = [|v403; v406|]
    let v408 : obj = Fable.Core.Rust.emitExpr v407 v38
    let v409 : Types.std.string.String = Fable.Core.Rust.emitExpr v408 v40
    let v410 : Types.EmitType<Types.std.string.String> = v409 |> unbox<Types.EmitType<Types.std.string.String>>
    v400 v410
    let v411 : Types.std.path.PathBuf = v1 |> Option.defaultValue v118
    let v412 : Result<unit, Types.std.io.Error> = Fable.Core.Rust.emitExpr struct (v411, v398) v132
    Fable.Core.Rust.emitExpr v412 v134
    let v413 : US0 = US0_0
    let v414 : (Types.EmitType<Types.std.string.String> -> unit) = v6 v413
    let v415 : string = "> fs_write new_fsx_path; ok"
    let v416 : Types.std.string.String = Fable.Core.Rust.emitExpr v415 v10
    let v417 : Types.EmitType<Types.std.string.String> = v416 |> unbox<Types.EmitType<Types.std.string.String>>
    v414 v417
    v398
and closure0 () (v0 : Types.std.path.PathBuf) : (Option<Types.std.path.PathBuf> -> string) =
    closure1(v0)
let v0 : (Types.std.path.PathBuf -> (Option<Types.std.path.PathBuf> -> string)) = closure0()
()
