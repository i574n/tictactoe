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
    let v63 : string = ""
    let v64 : string = "std::fs::write($0, $1.as_str())"
    let v65 : Result<unit, Std.std.io.Error> = Fable.Core.Rust.emitExpr struct (v60, v63) v64
    let v66 : string = "*(($0).as_ref()).unwrap()"
    Fable.Core.Rust.emitExpr v65 v66
    let v67 : string = "\nwrite ok. fsx_path:"
    System.Console.WriteLine v67
    let v68 : string = Fable.Core.Rust.emitExpr v60 v11
    System.Console.WriteLine v68
    let v69 : string = "std::fs::read_to_string($0)"
    let v70 : Result<Std.std.String, Std.std.io.Error> = Fable.Core.Rust.emitExpr v42 v69
    let v71 : string = "($0).as_ref().unwrap().to_string()"
    let v72 : Std.std.String = Fable.Core.Rust.emitExpr v70 v71
    let v73 : string = "spiproj_open."
    System.Console.WriteLine v73
    let v74 : string = "spiproj_path:"
    System.Console.WriteLine v74
    let v75 : string = Fable.Core.Rust.emitExpr v42 v11
    System.Console.WriteLine v75
    let v76 : string = "spiproj_text:"
    System.Console.WriteLine v76
    System.Console.WriteLine v72
    let v77 : string = "serde_json::json!({\"ProjectFileOpen\": {\"uri\": $0, \"spiprojText\": $1}})"
    let v78 : obj = Fable.Core.Rust.emitExpr struct (v42, v72) v77
    let v79 : string = "$0.to_string()"
    let v80 : Std.std.String = Fable.Core.Rust.emitExpr v78 v79
    let v81 : string = "str:"
    System.Console.WriteLine v81
    System.Console.WriteLine v80
    let v82 : string = "zmq_request."
    System.Console.WriteLine v82
    let v83 : string = "msg:"
    System.Console.WriteLine v83
    System.Console.WriteLine v80
    let v84 : string = "zmq::Context::new()"
    let v85 : obj = Fable.Core.Rust.emitExpr () v84
    let v86 : string = "$0.socket(zmq::REQ).unwrap()"
    let v87 : obj = Fable.Core.Rust.emitExpr v85 v86
    let v88 : string = $"tcp://localhost:{13805}"
    let v89 : string = "$0.connect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v87, v88) v89
    let v90 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v87, v80) v90
    let v91 : string = "$0.recv_string(0).unwrap().unwrap()"
    let v92 : obj = Fable.Core.Rust.emitExpr v87 v91
    let v93 : string = "zmq_request. result:"
    System.Console.WriteLine v93
    System.Console.WriteLine v92
    let v94 : string = "$0.disconnect(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v87, v88) v94
    let v95 : string = "\nopen ok. spiproj_path:"
    System.Console.WriteLine v95
    let v96 : string = Fable.Core.Rust.emitExpr v42 v11
    System.Console.WriteLine v96
    let v97 : string = "spi_build_file."
    System.Console.WriteLine v97
    let v98 : string = "spi_path:"
    System.Console.WriteLine v98
    let v99 : string = Fable.Core.Rust.emitExpr v16 v11
    System.Console.WriteLine v99
    let v100 : string = "backend:"
    System.Console.WriteLine v100
    let v101 : string = "Fsharp"
    System.Console.WriteLine v101
    let v102 : string = "serde_json::json!({\"BuildFile\": {\"uri\": $0, \"backend\": *$1}})"
    let v103 : obj = Fable.Core.Rust.emitExpr struct (v16, v101) v102
    let v104 : Std.std.String = Fable.Core.Rust.emitExpr v103 v79
    System.Console.WriteLine v81
    System.Console.WriteLine v104
    System.Console.WriteLine v82
    System.Console.WriteLine v83
    System.Console.WriteLine v104
    let v105 : obj = Fable.Core.Rust.emitExpr () v84
    let v106 : obj = Fable.Core.Rust.emitExpr v105 v86
    let v107 : string = $"tcp://localhost:{13805}"
    Fable.Core.Rust.emitExpr struct (v106, v107) v89
    let v108 : string = $"$0.send($1.as_str(), 0).unwrap()"
    Fable.Core.Rust.emitExpr struct (v106, v104) v108
    let v109 : obj = Fable.Core.Rust.emitExpr v106 v91
    System.Console.WriteLine v93
    System.Console.WriteLine v109
    Fable.Core.Rust.emitExpr struct (v106, v107) v94
    let v110 : string = "\nbuild ok. spi_path_clean:"
    System.Console.WriteLine v110
    let v111 : string = Fable.Core.Rust.emitExpr v16 v11
    System.Console.WriteLine v111
    let v112 : string = "\nnew_fsx_path:"
    System.Console.WriteLine v112
    let v113 : Std.std.path.PathBuf = Fable.Core.Rust.emitExpr v1 v6
    let v114 : string = Fable.Core.Rust.emitExpr v113 v11
    System.Console.WriteLine v114
    let v115 : string = "???"
    v115
and closure0 () (v0 : Std.std.path.PathBuf) : (Option<Std.std.path.PathBuf> -> string) =
    closure1(v0)
let v0 : (Std.std.path.PathBuf -> (Option<Std.std.path.PathBuf> -> string)) = closure0()
()
