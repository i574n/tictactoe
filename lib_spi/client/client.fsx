type [<Struct>] US0 =
    | US0_0
    | US0_1
let rec method0 () : struct (string * string * string * bool) =
    let v0 : string = ""
    let v1 : obj = v0
    struct (v0, v0, v0, true)
and method1 (v0 : string) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "($0).to_string()"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method2 (v0 : obj) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method4 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method4(v0, v4)
    else
        v1
and method5 (v0 : uint8) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method6 (v0 : (Types.EmitType<Types.std.string.String> [])) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "core::ops::Deref::deref($0)"
    let v2 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v0 v1
    let v3 : string = "&***$0"
    let v4 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v2 v3
    let v5 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v4 v3
    let v6 : string = "format!(\"{:?}\", $0)"
    let v7 : Types.std.string.String = Fable.Core.Rust.emitExpr v5 v6
    let v8 : Types.EmitType<Types.std.string.String> = v7 |> unbox<Types.EmitType<Types.std.string.String>>
    v8
and method7 (v0 : string) : string =
    v0
and method8 () : string =
    let v0 : string = "$1=$2"
    v0
and method9 () : string =
    let v0 : string = "[$1]"
    v0
and method10 () : string =
    let v0 : string = "\""
    v0
and method11 () : string =
    let v0 : string = " "
    v0
and method12 () : string =
    let v0 : string = "387957"
    v0
and method13 () : string =
    let v0 : string = "385779"
    v0
and method3 (v0 : int64, v1 : (Types.EmitType<Types.std.string.String> [])) : unit =
    let v2 : string = "chrono::Utc::now()"
    let v3 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v2
    let v4 : string = "($0).timestamp()"
    let v5 : int64 = Fable.Core.Rust.emitExpr v3 v4
    let v6 : int64 = v5 - v0
    let v7 : string = (v6).ToString ()
    let v8 : int32 = 6
    let v9 : string = method4(v8, v7)
    let v10 : string = "rand::random::<u8>()"
    let v11 : uint8 = Fable.Core.Rust.emitExpr () v10
    let v12 : string = "timestamp"
    let v13 : Types.EmitType<Types.std.string.String> = method1(v12)
    let v14 : Types.EmitType<Types.std.string.String> = method1(v9)
    let v15 : string = "run_id"
    let v16 : Types.EmitType<Types.std.string.String> = method1(v15)
    let v17 : Types.EmitType<Types.std.string.String> = method5(v11)
    let v18 : string = "log_level"
    let v19 : Types.EmitType<Types.std.string.String> = method1(v18)
    let v20 : string = "Debug"
    let v21 : Types.EmitType<Types.std.string.String> = method1(v20)
    let v22 : (Types.EmitType<Types.std.string.String> []) = [|v13; v14; v16; v17; v19; v21|]
    let v23 : Types.EmitType<Types.std.string.String> = method6(v22)
    let v24 : string = "> app ()"
    let v25 : Types.EmitType<Types.std.string.String> = method1(v24)
    let v26 : (Types.EmitType<Types.std.string.String> []) = [|v25|]
    let v27 : string = "core::ops::Deref::deref($0)"
    let v28 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v26 v27
    let v29 : string = "&***$0"
    let v30 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v28 v29
    let v31 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v30 v29
    let v32 : string = "format!(\"{:?}\", $0)"
    let v33 : Types.std.string.String = Fable.Core.Rust.emitExpr v31 v32
    let v34 : Types.EmitType<Types.std.string.String> = v33 |> unbox<Types.EmitType<Types.std.string.String>>
    let v35 : string = "format!(\"{}\", $0)"
    let v36 : Types.std.string.String = Fable.Core.Rust.emitExpr v34 v35
    let v37 : string = (v36).ToString ()
    let v38 : string = "\"([^\"]+)\", \"([^\"]+)\""
    let v39 : string = $"r#\"{v38}\"#"
    let v40 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v39
    let v41 : string = "regex::RegexBuilder::new($0)"
    let v42 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v40 v41
    let v43 : string = "$0.build().unwrap()"
    let v44 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v42 v43
    let v45 : string = method7(v37)
    let v46 : string = "$0.as_str()"
    let v47 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v45 v46
    let v48 : string = method8()
    let v49 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v48 v46
    let v50 : string = "$0.replace_all(&$1, $2).to_string()"
    let v51 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v44, v47, v49) v50
    let v52 : string = "fable_library_rust::String_::fromStr($0)"
    let v53 : string = Fable.Core.Rust.emitExpr v51 v52
    let v54 : string = "\\[\"(.*?)\"\\]"
    let v55 : string = $"r#\"{v54}\"#"
    let v56 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v55
    let v57 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v56 v41
    let v58 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v57 v43
    let v59 : string = method7(v53)
    let v60 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v59 v46
    let v61 : string = method9()
    let v62 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v61 v46
    let v63 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v58, v60, v62) v50
    let v64 : string = Fable.Core.Rust.emitExpr v63 v52
    let v65 : string = "\\\\\""
    let v66 : string = $"r#\"{v65}\"#"
    let v67 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v66
    let v68 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v67 v41
    let v69 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v68 v43
    let v70 : string = method7(v64)
    let v71 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v70 v46
    let v72 : string = method10()
    let v73 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v72 v46
    let v74 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v69, v71, v73) v50
    let v75 : string = Fable.Core.Rust.emitExpr v74 v52
    let v76 : string = ", "
    let v77 : string = $"r#\"{v76}\"#"
    let v78 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v77
    let v79 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v78 v41
    let v80 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v79 v43
    let v81 : string = method7(v75)
    let v82 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v81 v46
    let v83 : string = method11()
    let v84 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v83 v46
    let v85 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v80, v82, v84) v50
    let v86 : string = Fable.Core.Rust.emitExpr v85 v52
    let v87 : Types.EmitType<Types.std.string.String> = method1(v86)
    let v88 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v1 v27
    let v89 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v88 v29
    let v90 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v89 v29
    let v91 : Types.std.string.String = Fable.Core.Rust.emitExpr v90 v32
    let v92 : Types.EmitType<Types.std.string.String> = v91 |> unbox<Types.EmitType<Types.std.string.String>>
    let v93 : Types.std.string.String = Fable.Core.Rust.emitExpr v92 v35
    let v94 : string = (v93).ToString ()
    let v95 : string = $"r#\"{v38}\"#"
    let v96 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v95
    let v97 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v96 v41
    let v98 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v97 v43
    let v99 : string = method7(v94)
    let v100 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v99 v46
    let v101 : string = method8()
    let v102 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v101 v46
    let v103 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v98, v100, v102) v50
    let v104 : string = Fable.Core.Rust.emitExpr v103 v52
    let v105 : string = $"r#\"{v54}\"#"
    let v106 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v105
    let v107 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v106 v41
    let v108 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v107 v43
    let v109 : string = method7(v104)
    let v110 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v109 v46
    let v111 : string = method9()
    let v112 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v111 v46
    let v113 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v108, v110, v112) v50
    let v114 : string = Fable.Core.Rust.emitExpr v113 v52
    let v115 : string = $"r#\"{v65}\"#"
    let v116 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v115
    let v117 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v116 v41
    let v118 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v117 v43
    let v119 : string = method7(v114)
    let v120 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v119 v46
    let v121 : string = method10()
    let v122 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v121 v46
    let v123 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v118, v120, v122) v50
    let v124 : string = Fable.Core.Rust.emitExpr v123 v52
    let v125 : string = $"r#\"{v76}\"#"
    let v126 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v125
    let v127 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v126 v41
    let v128 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v127 v43
    let v129 : string = method7(v124)
    let v130 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v129 v46
    let v131 : string = method11()
    let v132 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v131 v46
    let v133 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v128, v130, v132) v50
    let v134 : string = Fable.Core.Rust.emitExpr v133 v52
    let v135 : Types.EmitType<Types.std.string.String> = method1(v134)
    let v136 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v35
    let v137 : string = (v136).ToString ()
    let v138 : string = $"r#\"{v38}\"#"
    let v139 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v138
    let v140 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v139 v41
    let v141 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v140 v43
    let v142 : string = method7(v137)
    let v143 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v142 v46
    let v144 : string = method8()
    let v145 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v144 v46
    let v146 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v141, v143, v145) v50
    let v147 : string = Fable.Core.Rust.emitExpr v146 v52
    let v148 : string = $"r#\"{v54}\"#"
    let v149 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v148
    let v150 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v149 v41
    let v151 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v150 v43
    let v152 : string = method7(v147)
    let v153 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v152 v46
    let v154 : string = method9()
    let v155 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v154 v46
    let v156 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v151, v153, v155) v50
    let v157 : string = Fable.Core.Rust.emitExpr v156 v52
    let v158 : string = $"r#\"{v65}\"#"
    let v159 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v158
    let v160 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v159 v41
    let v161 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v160 v43
    let v162 : string = method7(v157)
    let v163 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v162 v46
    let v164 : string = method10()
    let v165 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v164 v46
    let v166 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v161, v163, v165) v50
    let v167 : string = Fable.Core.Rust.emitExpr v166 v52
    let v168 : string = $"r#\"{v76}\"#"
    let v169 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v168
    let v170 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v169 v41
    let v171 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v170 v43
    let v172 : string = method7(v167)
    let v173 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v172 v46
    let v174 : string = method11()
    let v175 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v174 v46
    let v176 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v171, v173, v175) v50
    let v177 : string = Fable.Core.Rust.emitExpr v176 v52
    let v178 : Types.EmitType<Types.std.string.String> = method1(v177)
    let v179 : string = "cfg!(target_arch = \"wasm32\")"
    let v180 : bool = Fable.Core.Rust.emitExpr () v179
    let v183 : US0 =
        if v180 then
            US0_1
        else
            US0_0
    match v183 with
    | US0_1 -> (* Wasm32 *)
        let v184 : string = (v87).ToString ()
        let v185 : string = (v135).ToString ()
        let v186 : string = (v178).ToString ()
        let v187 : string = " %c"
        let v188 : string = v184 + v187
        let v189 : string = v188 + v185
        let v190 : string = v189 + v187
        let v191 : string = v190 + v186
        let v192 : string = "($0).as_ref().to_string()"
        let v193 : Types.std.string.String = Fable.Core.Rust.emitExpr v191 v192
        let v194 : string = "387957"
        let v195 : string = $"color: #{v194};"
        let v196 : Types.std.string.String = Fable.Core.Rust.emitExpr v195 v192
        let v197 : string = "color: #385779;"
        let v198 : Types.std.string.String = Fable.Core.Rust.emitExpr v197 v192
        let v199 : (Types.std.string.String []) = [|v193; v196; v198|]
        let v200 : Types.Ref<Types.Vec<obj>> = Fable.Core.Rust.emitExpr v199 v27
        let v201 : obj = v200
        let v202 : string = "serde_wasm_bindgen::to_value(&*****$0).unwrap()"
        let v203 : obj = Fable.Core.Rust.emitExpr v201 v202
        let v204 : string = "web_sys::console::log(&js_sys::Array::from(&$0))"
        Fable.Core.Rust.emitExpr v203 v204
        ()
    | _ ->
        let v205 : string = method12()
        let v206 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v205 v46
        let v207 : unativeint = unativeint 0
        let v208 : unativeint = unativeint 2
        let v209 : string = "&$0[$1..$2]"
        let v210 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v206, v207, v208) v209
        let v211 : string = Fable.Core.Rust.emitExpr v210 v52
        let v212 : string = "u8::from_str_radix($0, 16).unwrap()"
        let v213 : uint8 = Fable.Core.Rust.emitExpr v211 v212
        let v214 : string = method12()
        let v215 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v214 v46
        let v216 : unativeint = unativeint 2
        let v217 : unativeint = unativeint 4
        let v218 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v215, v216, v217) v209
        let v219 : string = Fable.Core.Rust.emitExpr v218 v52
        let v220 : uint8 = Fable.Core.Rust.emitExpr v219 v212
        let v221 : string = method12()
        let v222 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v221 v46
        let v223 : unativeint = unativeint 4
        let v224 : unativeint = unativeint 6
        let v225 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v222, v223, v224) v209
        let v226 : string = Fable.Core.Rust.emitExpr v225 v52
        let v227 : uint8 = Fable.Core.Rust.emitExpr v226 v212
        let v228 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
        let v229 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v135, v213, v220, v227) v228
        let v230 : Types.std.string.String = Fable.Core.Rust.emitExpr v229 v35
        let v231 : string = method13()
        let v232 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v231 v46
        let v233 : unativeint = unativeint 0
        let v234 : unativeint = unativeint 2
        let v235 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v232, v233, v234) v209
        let v236 : string = Fable.Core.Rust.emitExpr v235 v52
        let v237 : uint8 = Fable.Core.Rust.emitExpr v236 v212
        let v238 : string = method13()
        let v239 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v238 v46
        let v240 : unativeint = unativeint 2
        let v241 : unativeint = unativeint 4
        let v242 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v239, v240, v241) v209
        let v243 : string = Fable.Core.Rust.emitExpr v242 v52
        let v244 : uint8 = Fable.Core.Rust.emitExpr v243 v212
        let v245 : string = method13()
        let v246 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v245 v46
        let v247 : unativeint = unativeint 4
        let v248 : unativeint = unativeint 6
        let v249 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v246, v247, v248) v209
        let v250 : string = Fable.Core.Rust.emitExpr v249 v52
        let v251 : uint8 = Fable.Core.Rust.emitExpr v250 v212
        let v252 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v178, v237, v244, v251) v228
        let v253 : Types.std.string.String = Fable.Core.Rust.emitExpr v252 v35
        let v254 : string = $"{v87} {v230} {v253}"
        System.Console.WriteLine v254
        ()
and method14 () : bool =
    false
and method15 (v0 : Types.Tuple<Types.std.sync.Mutex<bool>, Types.async_std.sync.Condvar>) : Types.Tuple<Types.std.sync.Mutex<bool>, Types.async_std.sync.Condvar> =
    v0
and method16 (v0 : Option<Types.ehttp.Response>) : Option<Types.ehttp.Response> =
    v0
and method17 (v0 : Types.std.sync.Mutex<Option<Types.ehttp.Response>>) : Types.std.sync.Mutex<Option<Types.ehttp.Response>> =
    v0
and method18 (v0 : Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>>) : Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>> =
    v0
and method19 (v0 : Types.std.string.String) : Types.EmitType<Types.std.string.String> =
    let v1 : Types.EmitType<Types.std.string.String> = v0 |> unbox<Types.EmitType<Types.std.string.String>>
    v1
and closure1 (v0 : int64) (v1 : Types.std.cell.RefCell<Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>>>) : unit =
    let v2 : string = "app > fetch ()"
    let v3 : Types.EmitType<Types.std.string.String> = method1(v2)
    let v4 : (Types.EmitType<Types.std.string.String> []) = [|v3|]
    method3(v0, v4)
    let v5 : string = "v1.borrow()"
    let v6 : Types.std.cell.CellRef<Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>>> = Fable.Core.Rust.emitExpr () v5
    let v7 : string = "v6.try_lock()"
    let v8 : Option<Types.core.future.Future<Types.std.sync.Mutex<Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>>>>> = Fable.Core.Rust.emitExpr () v7
    let v9 : string = "response"
    let v10 : Types.EmitType<Types.std.string.String> = method1(v9)
    let v11 : string = "format!(\"{:?}\", $0)"
    let v12 : Types.std.string.String = Fable.Core.Rust.emitExpr v8 v11
    let v13 : Types.EmitType<Types.std.string.String> = method19(v12)
    let v14 : (Types.EmitType<Types.std.string.String> []) = [|v10; v13|]
    method3(v0, v14)
and closure0 () () : int32 =
    let v0 : string = "console_error_panic_hook::set_once()"
    Fable.Core.Rust.emitExpr () v0
    let struct (v1 : string, v2 : string, v3 : string, v4 : bool) = method0()
    let v5 : string = "chrono::Utc::now()"
    let v6 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v5
    let v7 : string = "($0).timestamp()"
    let v8 : int64 = Fable.Core.Rust.emitExpr v6 v7
    let v9 : string = "web_sys::window().unwrap()"
    let v10 : obj = Fable.Core.Rust.emitExpr () v9
    let v11 : string = "$0.document().unwrap()"
    let v12 : obj = Fable.Core.Rust.emitExpr v10 v11
    let v13 : string = "$0.body().unwrap()"
    let v14 : obj = Fable.Core.Rust.emitExpr v12 v13
    let v15 : string = "iframe"
    let v16 : string = $"r#\"{v15}\"#"
    let v17 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v16
    let v18 : string = "$0.create_element($1).unwrap()"
    let v19 : obj = Fable.Core.Rust.emitExpr struct (v12, v17) v18
    let v20 : string = "window"
    let v21 : Types.EmitType<Types.std.string.String> = method1(v20)
    let v22 : Types.EmitType<Types.std.string.String> = method2(v10)
    let v23 : string = "document"
    let v24 : Types.EmitType<Types.std.string.String> = method1(v23)
    let v25 : Types.EmitType<Types.std.string.String> = method2(v12)
    let v26 : string = "body"
    let v27 : Types.EmitType<Types.std.string.String> = method1(v26)
    let v28 : Types.EmitType<Types.std.string.String> = method2(v14)
    let v29 : Types.EmitType<Types.std.string.String> = method1(v15)
    let v30 : Types.EmitType<Types.std.string.String> = method2(v19)
    let v31 : (Types.EmitType<Types.std.string.String> []) = [|v21; v22; v24; v25; v27; v28; v29; v30|]
    method3(v8, v31)
    let v32 : string = "src"
    let v33 : string = $"r#\"{v32}\"#"
    let v34 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v33
    let v35 : string = "https://time.is"
    let v36 : string = $"r#\"{v35}\"#"
    let v37 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v36
    let v38 : string = "$0.set_attribute($1, $2).unwrap()"
    Fable.Core.Rust.emitExpr struct (v19, v34, v37) v38
    let v39 : string = "width"
    let v40 : string = $"r#\"{v39}\"#"
    let v41 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v40
    let v42 : string = "100%"
    let v43 : string = $"r#\"{v42}\"#"
    let v44 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v43
    Fable.Core.Rust.emitExpr struct (v19, v41, v44) v38
    let v45 : string = "style"
    let v46 : string = $"r#\"{v45}\"#"
    let v47 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v46
    let v48 : string = "height: 100vh; border: 0;"
    let v49 : string = $"r#\"{v48}\"#"
    let v50 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v49
    Fable.Core.Rust.emitExpr struct (v19, v47, v50) v38
    let v51 : string = "data-test"
    let v52 : string = $"r#\"{v51}\"#"
    let v53 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v52
    let v54 : string = "1"
    let v55 : string = $"r#\"{v54}\"#"
    let v56 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v55
    Fable.Core.Rust.emitExpr struct (v19, v53, v56) v38
    let v57 : string = "$0.append_child(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v14, v19) v57
    let v58 : string = "https://dummyjson.com/users"
    let v59 : string = "($0).to_string()"
    let v60 : Types.std.string.String = Fable.Core.Rust.emitExpr v58 v59
    let v61 : string = "ehttp::Request::get($0)"
    let v62 : Types.ehttp.Request = Fable.Core.Rust.emitExpr v60 v61
    let v63 : bool = method14()
    let v64 : string = "async_std::sync::Mutex::new(v63)"
    let v65 : Types.std.sync.Mutex<bool> = Fable.Core.Rust.emitExpr () v64
    let v66 : string = "async_std::sync::Condvar::new()"
    let v67 : Types.async_std.sync.Condvar = Fable.Core.Rust.emitExpr () v66
    let v68 : string = "(v65, v67)"
    let v69 : Types.Tuple<Types.std.sync.Mutex<bool>, Types.async_std.sync.Condvar> = Fable.Core.Rust.emitExpr () v68
    let v70 : Types.Tuple<Types.std.sync.Mutex<bool>, Types.async_std.sync.Condvar> = method15(v69)
    let v71 : string = "std::sync::Arc::new(v70)"
    let v72 : Types.std.sync.Arc<Types.Tuple<Types.std.sync.Mutex<bool>, Types.async_std.sync.Condvar>> = Fable.Core.Rust.emitExpr () v71
    let v73 : string = "v72.clone()"
    let v74 : Types.std.sync.Arc<Types.Tuple<Types.std.sync.Mutex<bool>, Types.async_std.sync.Condvar>> = Fable.Core.Rust.emitExpr () v73
    let v75 : Option<Types.ehttp.Response> = None |> unbox
    let v76 : Option<Types.ehttp.Response> = method16(v75)
    let v77 : string = "async_std::sync::Mutex::new(v76)"
    let v78 : Types.std.sync.Mutex<Option<Types.ehttp.Response>> = Fable.Core.Rust.emitExpr () v77
    let v79 : Types.std.sync.Mutex<Option<Types.ehttp.Response>> = method17(v78)
    let v80 : string = "std::sync::Arc::new(v79)"
    let v81 : Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>> = Fable.Core.Rust.emitExpr () v80
    let v82 : Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>> = method18(v81)
    let v83 : string = "std::cell::RefCell::new(v82)"
    let v84 : Types.std.cell.RefCell<Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>>> = Fable.Core.Rust.emitExpr () v83
    let v85 : string = "v84.clone()"
    let v86 : Types.std.cell.RefCell<Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>>> = Fable.Core.Rust.emitExpr () v85
    let v87 : string = "move |x: ehttp::Result<ehttp::Response>| {"
    let v88 : string = "  let r = x.clone().unwrap();"
    let v89 : string = v87 + v88
    let v90 : string = "  *v84.borrow_mut().try_lock().unwrap() = Some(r);"
    let v91 : string = v89 + v90
    let v92 : string = "  async_std::task::block_on(async move {"
    let v93 : string = v91 + v92
    let v94 : string = "    let (lock, cvar) = &*v74;"
    let v95 : string = v93 + v94
    let v96 : string = "    let mut started = lock.lock().await;"
    let v97 : string = v95 + v96
    let v98 : string = "    *started = true;"
    let v99 : string = v97 + v98
    let v100 : string = "    cvar.notify_one();"
    let v101 : string = v99 + v100
    let v102 : string = "  });"
    let v103 : string = v101 + v102
    let v104 : string = "}"
    let v105 : string = v103 + v104
    let v106 : obj = Fable.Core.Rust.emitExpr () v105
    let v107 : string = "Box::new(v106)"
    let v108 : Types.Box<obj> = Fable.Core.Rust.emitExpr () v107
    let v109 : string = "ehttp::fetch(v62, v108)"
    Fable.Core.Rust.emitExpr () v109
    let v110 : string = "  let (lock, cvar) = &*v72;"
    let v111 : string = "async move {"
    let v112 : string = v111 + v110
    let v113 : string = "  let mut started = lock.lock().await;"
    let v114 : string = v112 + v113
    let v115 : string = "  while !*started {"
    let v116 : string = v114 + v115
    let v117 : string = "    started = cvar.wait(started).await;"
    let v118 : string = v116 + v117
    let v119 : string = "  }"
    let v120 : string = v118 + v119
    let v121 : (Types.std.cell.RefCell<Types.std.sync.Arc<Types.std.sync.Mutex<Option<Types.ehttp.Response>>>> -> unit) = closure1(v8)
    let v122 : string = "  v121(v86);"
    let v123 : string = v120 + v122
    let v124 : string = v123 + v104
    let v125 : Types.core.future.Future<obj> = Fable.Core.Rust.emitExpr () v124
    let v126 : string = "async_std::task::block_on(v125)"
    Fable.Core.Rust.emitExpr () v126
    let v127 : string = "app end"
    let v128 : Types.EmitType<Types.std.string.String> = method1(v127)
    let v129 : string = "???"
    let v130 : Types.EmitType<Types.std.string.String> = method1(v129)
    let v131 : (Types.EmitType<Types.std.string.String> []) = [|v128; v130|]
    method3(v8, v131)
    0
let v0 : (unit -> int32) = closure0()
()
