type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
let rec closure2 () () : US0 =
    US0_0
and closure3 (v0 : Types.std.path.PathBuf, v1 : Option<Types.std.path.PathBuf>) () : Types.EmitType<Types.std.string.String> =
    let v2 : string = "spi_path:"
    let v3 : string = "($0).to_string()"
    let v4 : Types.std.string.String = Fable.Core.Rust.emitExpr v2 v3
    let v5 : Types.EmitType<Types.std.string.String> = v4 |> unbox<Types.EmitType<Types.std.string.String>>
    let v6 : string = "fable_library_rust::String_::fromStr(&format!(\"{:?}\", $0.display()))"
    let v7 : string = Fable.Core.Rust.emitExpr v0 v6
    let v8 : Types.std.string.String = Fable.Core.Rust.emitExpr v7 v3
    let v9 : Types.EmitType<Types.std.string.String> = v8 |> unbox<Types.EmitType<Types.std.string.String>>
    let v10 : string = "new_fsx_path:"
    let v11 : Types.std.string.String = Fable.Core.Rust.emitExpr v10 v3
    let v12 : Types.EmitType<Types.std.string.String> = v11 |> unbox<Types.EmitType<Types.std.string.String>>
    let v13 : string = "($0).as_ref().unwrap().to_path_buf()"
    let v14 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v1 v13
    let v15 : string = Fable.Core.Rust.emitExpr v14 v6
    let v16 : Types.std.string.String = Fable.Core.Rust.emitExpr v15 v3
    let v17 : Types.EmitType<Types.std.string.String> = v16 |> unbox<Types.EmitType<Types.std.string.String>>
    let v18 : (Types.EmitType<Types.std.string.String> []) = [|v5; v9; v12; v17|]
    let v19 : string = "core::ops::Deref::deref($0)"
    let v20 : obj = Fable.Core.Rust.emitExpr v18 v19
    let v21 : string = "format!(\"{:?}\", $0)"
    let v22 : Types.std.string.String = Fable.Core.Rust.emitExpr v20 v21
    let v23 : Types.EmitType<Types.std.string.String> = v22 |> unbox<Types.EmitType<Types.std.string.String>>
    v23
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
and closure5 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : int64, v3 : US0) (v4 : Types.EmitType<Types.std.string.String>) : unit =
    let v5 : US0 = v0 ()
    let v6 : int32 =
        match v5 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v7 : int32 =
        match v3 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v8 : bool = v6 <= v7
    if v8 then
        let v9 : string = "chrono::Utc::now()"
        let v10 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v9
        let v11 : string = "($0).timestamp()"
        let v12 : int64 = Fable.Core.Rust.emitExpr v10 v11
        let v13 : int64 = v12 - v2
        let v14 : string = v13.ToString ()
        let v15 : int32 = 6
        let v16 : string = method2(v15, v14)
        let v17 : string = "timestamp:"
        let v18 : string = "($0).to_string()"
        let v19 : Types.std.string.String = Fable.Core.Rust.emitExpr v17 v18
        let v20 : Types.EmitType<Types.std.string.String> = v19 |> unbox<Types.EmitType<Types.std.string.String>>
        let v21 : Types.std.string.String = Fable.Core.Rust.emitExpr v16 v18
        let v22 : Types.EmitType<Types.std.string.String> = v21 |> unbox<Types.EmitType<Types.std.string.String>>
        let v23 : string = "run_id:"
        let v24 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v18
        let v25 : Types.EmitType<Types.std.string.String> = v24 |> unbox<Types.EmitType<Types.std.string.String>>
        let v26 : string = "format!(\"{:?}\", $0)"
        let v27 : Types.std.string.String = Fable.Core.Rust.emitExpr 999 v26
        let v28 : Types.EmitType<Types.std.string.String> = v27 |> unbox<Types.EmitType<Types.std.string.String>>
        let v29 : (Types.EmitType<Types.std.string.String> []) = [|v20; v22; v25; v28|]
        let v30 : string = "core::ops::Deref::deref($0)"
        let v31 : obj = Fable.Core.Rust.emitExpr v29 v30
        let v32 : Types.std.string.String = Fable.Core.Rust.emitExpr v31 v26
        let v33 : Types.EmitType<Types.std.string.String> = v32 |> unbox<Types.EmitType<Types.std.string.String>>
        let v34 : string = $"{v4} {v1 ()} {v33}"
        System.Console.WriteLine v34
        ()
and closure4 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>), v2 : int64) (v3 : US0) : (Types.EmitType<Types.std.string.String> -> unit) =
    closure5(v0, v1, v2, v3)
and method0 (v0 : (unit -> US0), v1 : (unit -> Types.EmitType<Types.std.string.String>)) : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) =
    let struct (v2 : string, v3 : string, v4 : string, v5 : bool) = method1()
    let v6 : string = "chrono::Utc::now()"
    let v7 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v6
    let v8 : string = "($0).timestamp()"
    let v9 : int64 = Fable.Core.Rust.emitExpr v7 v8
    closure4(v0, v1, v9)
and closure6 () (v0 : Types.Ref<Types.std.path.Path>) : Types.std.path.PathBuf =
    let v1 : string = "package.spiproj"
    let v2 : string = "$1.join($0.as_str())"
    let v3 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr struct (v1, v0) v2
    v3
and closure7 () (v0 : Types.Ref<Types.std.path.PathBuf>) : bool =
    let v1 : string = "std::path::Path::exists($0)"
    let v2 : bool = Fable.Core.Rust.emitExpr v0 v1
    v2
and closure1 (v0 : Types.std.path.PathBuf) (v1 : Option<Types.std.path.PathBuf>) : string =
    let v2 : (unit -> US0) = closure2()
    let v3 : (unit -> Types.EmitType<Types.std.string.String>) = closure3(v0, v1)
    let v4 : string = "#666"
    let v5 : (US0 -> (Types.EmitType<Types.std.string.String> -> unit)) = method0(v2, v3)
    let v6 : string = "($0).canonicalize()"
    let v7 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v0 v6
    let v8 : string = "($0).as_ref().unwrap().to_path_buf()"
    let v9 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v7 v8
    let v10 : string = "($0).parent()"
    let v11 : Option<Types.Ref<Types.std.path.Path>> = Fable.Core.Rust.emitExpr v9 v10
    let v12 : string = "($0).unwrap()"
    let v13 : Types.Ref<Types.std.path.Path> = Fable.Core.Rust.emitExpr v11 v12
    let v14 : string = "std::path::PathBuf::from($0)"
    let v15 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v13 v14
    let v16 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v15 v6
    let v17 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v16 v8
    let v18 : string = "$0.ancestors()"
    let v19 : Types.Ref<Types.std.path.Ancestors> = Fable.Core.Rust.emitExpr v17 v18
    let v20 : unativeint = unativeint 10
    let v21 : string = "$1.take($0)"
    let v22 : Types.std.iter.Iterator<Types.Ref<Types.std.path.Path>> = Fable.Core.Rust.emitExpr struct (v20, v19) v21
    let v23 : (Types.Ref<Types.std.path.Path> -> Types.std.path.PathBuf) = closure6()
    let v24 : Types.Ref<(Types.Ref<Types.std.path.Path> -> Types.std.path.PathBuf)> = v23 |> unbox
    let v25 : string = "$1.into_iter().map($0)"
    let v26 : Types.std.iter.Iterator<Types.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v24, v22) v25
    let v27 : (Types.Ref<Types.std.path.PathBuf> -> bool) = closure7()
    let v28 : Types.Ref<(Types.Ref<Types.std.path.PathBuf> -> bool)> = v27 |> unbox
    let v29 : string = "$1.into_iter().find($0)"
    let v30 : Option<Types.std.path.PathBuf> = Fable.Core.Rust.emitExpr struct (v28, v26) v29
    let v31 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v30 v8
    let v32 : string = "($0).to_str()"
    let v33 : Option<Types.Ref<Types.Str>> = Fable.Core.Rust.emitExpr v9 v32
    let v34 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v33 v12
    let v35 : string = ".spir"
    let v36 : Types.Ref<string> = v35 |> unbox
    let v37 : string = ".spi"
    let v38 : Types.Ref<string> = v37 |> unbox
    let v39 : string = "&$2.replace(&*$0, &$1)"
    let v40 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v36, v38, v34) v39
    let v41 : Types.Ref<string> = v37 |> unbox
    let v42 : string = ".fsx"
    let v43 : Types.Ref<string> = v42 |> unbox
    let v44 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v41, v43, v40) v39
    let v45 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v44 v14
    let v46 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v45 v6
    let v47 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v46 v8
    let v48 : string = ""
    let v49 : string = "std::fs::write($0, $1.as_str())"
    let v50 : Result<unit, Types.std.io.Error> = Fable.Core.Rust.emitExpr struct (v47, v48) v49
    let v51 : string = "*(($0).as_ref()).unwrap()"
    Fable.Core.Rust.emitExpr v50 v51
    let v52 : string = "std::fs::read_to_string($0)"
    let v53 : Result<Types.std.string.String, Types.std.io.Error> = Fable.Core.Rust.emitExpr v31 v52
    let v54 : string = "($0).as_ref().unwrap().to_string()"
    let v55 : Types.std.string.String = Fable.Core.Rust.emitExpr v53 v54
    let v56 : string = "serde_json::json!({\"ProjectFileOpen\": {\"uri\": $0, \"spiprojText\": $1}})"
    let v57 : obj = Fable.Core.Rust.emitExpr struct (v31, v55) v56
    let v58 : string = "$0.to_string()"
    let v59 : Types.std.string.String = Fable.Core.Rust.emitExpr v57 v58
    let v60 : string = "zmq::Context::new()"
    let v61 : obj = Fable.Core.Rust.emitExpr () v60
    let v62 : string = "$0.socket(zmq::REQ).unwrap()"
    let v63 : obj = Fable.Core.Rust.emitExpr v61 v62
    let v64 : string = $"tcp://localhost:{13805}"
    let v65 : string = "$0.connect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v63, v64) v65
    let v66 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v63, v59) v66
    let v67 : string = "$0.recv_string(0).unwrap().unwrap()"
    let v68 : obj = Fable.Core.Rust.emitExpr v63 v67
    let v69 : string = "$0.disconnect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v63, v64) v69
    let v70 : string = "Fsharp"
    let v71 : string = "serde_json::json!({\"BuildFile\": {\"uri\": $0, \"backend\": *$1}})"
    let v72 : obj = Fable.Core.Rust.emitExpr struct (v9, v70) v71
    let v73 : Types.std.string.String = Fable.Core.Rust.emitExpr v72 v58
    let v74 : obj = Fable.Core.Rust.emitExpr () v60
    let v75 : obj = Fable.Core.Rust.emitExpr v74 v62
    let v76 : string = $"tcp://localhost:{13805}"
    Fable.Core.Rust.emitExpr struct (v75, v76) v65
    let v77 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v75, v73) v77
    let v78 : obj = Fable.Core.Rust.emitExpr v75 v67
    Fable.Core.Rust.emitExpr struct (v75, v76) v69
    let v79 : US0 = US0_0
    let v80 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v79
    let v81 : string = "> spi_to_fsx ()"
    let v82 : string = "($0).to_string()"
    let v83 : Types.std.string.String = Fable.Core.Rust.emitExpr v81 v82
    let v84 : Types.EmitType<Types.std.string.String> = v83 |> unbox<Types.EmitType<Types.std.string.String>>
    let v85 : string = "pwd:"
    let v86 : Types.std.string.String = Fable.Core.Rust.emitExpr v85 v82
    let v87 : Types.EmitType<Types.std.string.String> = v86 |> unbox<Types.EmitType<Types.std.string.String>>
    let v88 : string = "std::env::current_dir()"
    let v89 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr () v88
    let v90 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v89 v8
    let v91 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v90 v6
    let v92 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v91 v8
    let v93 : string = "fable_library_rust::String_::fromStr(&format!(\"{:?}\", $0.display()))"
    let v94 : string = Fable.Core.Rust.emitExpr v92 v93
    let v95 : Types.std.string.String = Fable.Core.Rust.emitExpr v94 v82
    let v96 : Types.EmitType<Types.std.string.String> = v95 |> unbox<Types.EmitType<Types.std.string.String>>
    let v97 : string = "spi_path_clean:"
    let v98 : Types.std.string.String = Fable.Core.Rust.emitExpr v97 v82
    let v99 : Types.EmitType<Types.std.string.String> = v98 |> unbox<Types.EmitType<Types.std.string.String>>
    let v100 : string = Fable.Core.Rust.emitExpr v9 v93
    let v101 : Types.std.string.String = Fable.Core.Rust.emitExpr v100 v82
    let v102 : Types.EmitType<Types.std.string.String> = v101 |> unbox<Types.EmitType<Types.std.string.String>>
    let v103 : string = "src_path:"
    let v104 : Types.std.string.String = Fable.Core.Rust.emitExpr v103 v82
    let v105 : Types.EmitType<Types.std.string.String> = v104 |> unbox<Types.EmitType<Types.std.string.String>>
    let v106 : string = Fable.Core.Rust.emitExpr v17 v93
    let v107 : Types.std.string.String = Fable.Core.Rust.emitExpr v106 v82
    let v108 : Types.EmitType<Types.std.string.String> = v107 |> unbox<Types.EmitType<Types.std.string.String>>
    let v109 : string = "spiproj_path:"
    let v110 : Types.std.string.String = Fable.Core.Rust.emitExpr v109 v82
    let v111 : Types.EmitType<Types.std.string.String> = v110 |> unbox<Types.EmitType<Types.std.string.String>>
    let v112 : string = Fable.Core.Rust.emitExpr v31 v93
    let v113 : Types.std.string.String = Fable.Core.Rust.emitExpr v112 v82
    let v114 : Types.EmitType<Types.std.string.String> = v113 |> unbox<Types.EmitType<Types.std.string.String>>
    let v115 : string = "fsx_path:"
    let v116 : Types.std.string.String = Fable.Core.Rust.emitExpr v115 v82
    let v117 : Types.EmitType<Types.std.string.String> = v116 |> unbox<Types.EmitType<Types.std.string.String>>
    let v118 : string = Fable.Core.Rust.emitExpr v47 v93
    let v119 : Types.std.string.String = Fable.Core.Rust.emitExpr v118 v82
    let v120 : Types.EmitType<Types.std.string.String> = v119 |> unbox<Types.EmitType<Types.std.string.String>>
    let v121 : (Types.EmitType<Types.std.string.String> []) = [|v84; v87; v96; v99; v102; v105; v108; v111; v114; v117; v120|]
    let v122 : string = "core::ops::Deref::deref($0)"
    let v123 : obj = Fable.Core.Rust.emitExpr v121 v122
    let v124 : string = "format!(\"{:?}\", $0)"
    let v125 : Types.std.string.String = Fable.Core.Rust.emitExpr v123 v124
    let v126 : Types.EmitType<Types.std.string.String> = v125 |> unbox<Types.EmitType<Types.std.string.String>>
    v80 v126
    let v127 : string = "???"
    v127
and closure0 () (v0 : Types.std.path.PathBuf) : (Option<Types.std.path.PathBuf> -> string) =
    closure1(v0)
let v0 : (Types.std.path.PathBuf -> (Option<Types.std.path.PathBuf> -> string)) = closure0()
()
