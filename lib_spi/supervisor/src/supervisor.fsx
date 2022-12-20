type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
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
    let v7 : int32 =
        match v6 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v8 : int32 =
        match v4 with
        | US0_0 -> (* Debug *)
            0
        | US0_1 -> (* Error *)
            3
        | US0_2 -> (* Info *)
            1
        | US0_3 -> (* Warn *)
            2
    let v9 : bool = v7 <= v8
    if v9 then
        let v10 : string = "chrono::Utc::now()"
        let v11 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v10
        let v12 : string = "($0).timestamp()"
        let v13 : int64 = Fable.Core.Rust.emitExpr v11 v12
        let v14 : int64 = v13 - v3
        let v15 : string = v14.ToString ()
        let v16 : int32 = 6
        let v17 : string = method2(v16, v15)
        let v18 : string = "timestamp:"
        let v19 : string = "($0).to_string()"
        let v20 : Types.std.string.String = Fable.Core.Rust.emitExpr v18 v19
        let v21 : Types.EmitType<Types.std.string.String> = v20 |> unbox<Types.EmitType<Types.std.string.String>>
        let v22 : Types.std.string.String = Fable.Core.Rust.emitExpr v17 v19
        let v23 : Types.EmitType<Types.std.string.String> = v22 |> unbox<Types.EmitType<Types.std.string.String>>
        let v24 : string = "run_id:"
        let v25 : Types.std.string.String = Fable.Core.Rust.emitExpr v24 v19
        let v26 : Types.EmitType<Types.std.string.String> = v25 |> unbox<Types.EmitType<Types.std.string.String>>
        let v27 : string = "format!(\"{}\", $0)"
        let v28 : Types.std.string.String = Fable.Core.Rust.emitExpr 999 v27
        let v29 : Types.EmitType<Types.std.string.String> = v28 |> unbox<Types.EmitType<Types.std.string.String>>
        let v30 : (Types.EmitType<Types.std.string.String> []) = [|v21; v23; v26; v29|]
        let v31 : string = "core::ops::Deref::deref($0)"
        let v32 : obj = Fable.Core.Rust.emitExpr v30 v31
        let v33 : string = "format!(\"{:?}\", ***$0)"
        let v34 : Types.std.string.String = Fable.Core.Rust.emitExpr v32 v33
        let v35 : Types.EmitType<Types.std.string.String> = v34 |> unbox<Types.EmitType<Types.std.string.String>>
        let v36 : Types.EmitType<Types.std.string.String> = v1 ()
        let v37 : string = "purple"
        let v38 : string = "colored::Colorize::color(&*$0, $1.to_string())"
        let v39 : obj = Fable.Core.Rust.emitExpr struct (v36, v37) v38
        let v40 : Types.std.string.String = Fable.Core.Rust.emitExpr v39 v27
        let v41 : string = v2.Substring (0, 2)
        let v42 : string = "u8::from_str_radix($0, 16).unwrap()"
        let v43 : uint8 = Fable.Core.Rust.emitExpr v41 v42
        let v44 : string = v2.Substring (2, 2)
        let v45 : uint8 = Fable.Core.Rust.emitExpr v44 v42
        let v46 : string = v2.Substring (4, 2)
        let v47 : uint8 = Fable.Core.Rust.emitExpr v46 v42
        let v48 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
        let v49 : obj = Fable.Core.Rust.emitExpr struct (v5, v43, v45, v47) v48
        let v50 : Types.std.string.String = Fable.Core.Rust.emitExpr v49 v27
        let v51 : string = "222222"
        let v52 : string = v51.Substring (0, 2)
        let v53 : uint8 = Fable.Core.Rust.emitExpr v52 v42
        let v54 : string = v51.Substring (2, 2)
        let v55 : uint8 = Fable.Core.Rust.emitExpr v54 v42
        let v56 : string = v51.Substring (4, 2)
        let v57 : uint8 = Fable.Core.Rust.emitExpr v56 v42
        let v58 : obj = Fable.Core.Rust.emitExpr struct (v35, v53, v55, v57) v48
        let v59 : Types.std.string.String = Fable.Core.Rust.emitExpr v58 v27
        let v60 : string = $"{v40} {v50} {v59}"
        System.Console.WriteLine v60
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
    let v143 : string = "serde_json::json!({\"ProjectFileOpen\": {\"uri\": $0, \"spiprojText\": $1}})"
    let v144 : obj = Fable.Core.Rust.emitExpr struct (v89, v142) v143
    let v145 : string = "$0.to_string()"
    let v146 : Types.std.string.String = Fable.Core.Rust.emitExpr v144 v145
    let v147 : string = "zmq::Context::new()"
    let v148 : obj = Fable.Core.Rust.emitExpr () v147
    let v149 : string = "$0.socket(zmq::REQ).unwrap()"
    let v150 : obj = Fable.Core.Rust.emitExpr v148 v149
    let v151 : string = $"tcp://localhost:{13805}"
    let v152 : string = "$0.connect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v150, v151) v152
    let v153 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v150, v146) v153
    let v154 : string = "$0.recv_string(0).unwrap().unwrap()"
    let v155 : obj = Fable.Core.Rust.emitExpr v150 v154
    let v156 : string = "$0.disconnect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v150, v151) v156
    let v157 : US0 = US0_0
    let v158 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v157
    let v159 : string = "> spiproj_open; ok"
    let v160 : Types.std.string.String = Fable.Core.Rust.emitExpr v159 v9
    let v161 : Types.EmitType<Types.std.string.String> = v160 |> unbox<Types.EmitType<Types.std.string.String>>
    v158 v161
    let v162 : string = "Fsharp"
    let v163 : string = "serde_json::json!({\"BuildFile\": {\"uri\": $0, \"backend\": *$1}})"
    let v164 : obj = Fable.Core.Rust.emitExpr struct (v43, v162) v163
    let v165 : Types.std.string.String = Fable.Core.Rust.emitExpr v164 v145
    let v166 : obj = Fable.Core.Rust.emitExpr () v147
    let v167 : obj = Fable.Core.Rust.emitExpr v166 v149
    let v168 : string = $"tcp://localhost:{13805}"
    Fable.Core.Rust.emitExpr struct (v167, v168) v152
    let v169 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v167, v165) v169
    let v170 : obj = Fable.Core.Rust.emitExpr v167 v154
    Fable.Core.Rust.emitExpr struct (v167, v168) v156
    let v171 : US0 = US0_0
    let v172 : (Types.EmitType<Types.std.string.String> -> unit) = v5 v171
    let v173 : string = "> spi_build_file; ok"
    let v174 : Types.std.string.String = Fable.Core.Rust.emitExpr v173 v9
    let v175 : Types.EmitType<Types.std.string.String> = v174 |> unbox<Types.EmitType<Types.std.string.String>>
    v172 v175
    let v176 : string = "???"
    v176
and closure0 () (v0 : Types.std.path.PathBuf) : (Option<Types.std.path.PathBuf> -> string) =
    closure1(v0)
let v0 : (Types.std.path.PathBuf -> (Option<Types.std.path.PathBuf> -> string)) = closure0()
()
