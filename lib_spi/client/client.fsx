type [<Struct>] US0 =
    | US0_0
    | US0_1
let rec method0 () : struct (string * string * string * bool) =
    let v0 : string = ""
    let v1 : obj = v0
    struct (v0, v0, v0, true)
and method1 () : bool =
    false
and method2 (v0 : Types.Tuple<Types.async_std.sync.Mutex<bool>, Types.async_std.sync.Condvar>) : Types.Tuple<Types.async_std.sync.Mutex<bool>, Types.async_std.sync.Condvar> =
    v0
and method3 (v0 : Option<Types.ehttp.Response>) : Option<Types.ehttp.Response> =
    v0
and method4 (v0 : Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>) : Types.async_std.sync.Mutex<Option<Types.ehttp.Response>> =
    v0
and method5 (v0 : Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>>) : Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>> =
    v0
and method6 (v0 : string) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "($0).to_string()"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method8 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method8(v0, v4)
    else
        v1
and method9 (v0 : uint8) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method10 (v0 : (Types.EmitType<Types.std.string.String> [])) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "core::ops::Deref::deref($0)"
    let v2 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v0 v1
    let v3 : string = "&***$0"
    let v4 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v2 v3
    let v5 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v4 v3
    let v6 : string = "format!(\"{:?}\", $0)"
    let v7 : Types.std.string.String = Fable.Core.Rust.emitExpr v5 v6
    let v8 : Types.EmitType<Types.std.string.String> = v7 |> unbox<Types.EmitType<Types.std.string.String>>
    v8
and method11 (v0 : string) : string =
    v0
and method12 () : string =
    let v0 : string = "$1=$2"
    v0
and method13 () : string =
    let v0 : string = "[$1]"
    v0
and method14 () : string =
    let v0 : string = "\""
    v0
and method15 () : string =
    let v0 : string = " "
    v0
and method16 () : string =
    let v0 : string = "387957"
    v0
and method17 () : string =
    let v0 : string = "385779"
    v0
and method7 (v0 : int64, v1 : (Types.EmitType<Types.std.string.String> [])) : unit =
    let v2 : string = "chrono::Utc::now()"
    let v3 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v2
    let v4 : string = "($0).timestamp()"
    let v5 : int64 = Fable.Core.Rust.emitExpr v3 v4
    let v6 : int64 = v5 - v0
    let v7 : string = (v6).ToString ()
    let v8 : int32 = 6
    let v9 : string = method8(v8, v7)
    let v10 : string = "rand::random::<u8>()"
    let v11 : uint8 = Fable.Core.Rust.emitExpr () v10
    let v12 : string = "timestamp"
    let v13 : Types.EmitType<Types.std.string.String> = method6(v12)
    let v14 : Types.EmitType<Types.std.string.String> = method6(v9)
    let v15 : string = "run_id"
    let v16 : Types.EmitType<Types.std.string.String> = method6(v15)
    let v17 : Types.EmitType<Types.std.string.String> = method9(v11)
    let v18 : string = "log_level"
    let v19 : Types.EmitType<Types.std.string.String> = method6(v18)
    let v20 : string = "Debug"
    let v21 : Types.EmitType<Types.std.string.String> = method6(v20)
    let v22 : (Types.EmitType<Types.std.string.String> []) = [|v13; v14; v16; v17; v19; v21|]
    let v23 : Types.EmitType<Types.std.string.String> = method10(v22)
    let v24 : string = "> app ()"
    let v25 : Types.EmitType<Types.std.string.String> = method6(v24)
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
    let v45 : string = method11(v37)
    let v46 : string = "$0.as_str()"
    let v47 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v45 v46
    let v48 : string = method12()
    let v49 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v48 v46
    let v50 : string = "$0.replace_all(&$1, $2).to_string()"
    let v51 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v44, v47, v49) v50
    let v52 : obj = v51
    let v53 : string = "fable_library_rust::String_::fromStr($0)"
    let v54 : string = Fable.Core.Rust.emitExpr v52 v53
    let v55 : string = "\\[\"(.*?)\"\\]"
    let v56 : string = $"r#\"{v55}\"#"
    let v57 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v56
    let v58 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v57 v41
    let v59 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v58 v43
    let v60 : string = method11(v54)
    let v61 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v60 v46
    let v62 : string = method13()
    let v63 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v62 v46
    let v64 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v59, v61, v63) v50
    let v65 : obj = v64
    let v66 : string = Fable.Core.Rust.emitExpr v65 v53
    let v67 : string = "\\\\\""
    let v68 : string = $"r#\"{v67}\"#"
    let v69 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v68
    let v70 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v69 v41
    let v71 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v70 v43
    let v72 : string = method11(v66)
    let v73 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v72 v46
    let v74 : string = method14()
    let v75 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v74 v46
    let v76 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v71, v73, v75) v50
    let v77 : obj = v76
    let v78 : string = Fable.Core.Rust.emitExpr v77 v53
    let v79 : string = ", "
    let v80 : string = $"r#\"{v79}\"#"
    let v81 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v80
    let v82 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v81 v41
    let v83 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v82 v43
    let v84 : string = method11(v78)
    let v85 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v84 v46
    let v86 : string = method15()
    let v87 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v86 v46
    let v88 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v83, v85, v87) v50
    let v89 : obj = v88
    let v90 : string = Fable.Core.Rust.emitExpr v89 v53
    let v91 : Types.EmitType<Types.std.string.String> = method6(v90)
    let v92 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v1 v27
    let v93 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v92 v29
    let v94 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v93 v29
    let v95 : Types.std.string.String = Fable.Core.Rust.emitExpr v94 v32
    let v96 : Types.EmitType<Types.std.string.String> = v95 |> unbox<Types.EmitType<Types.std.string.String>>
    let v97 : Types.std.string.String = Fable.Core.Rust.emitExpr v96 v35
    let v98 : string = (v97).ToString ()
    let v99 : string = $"r#\"{v38}\"#"
    let v100 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v99
    let v101 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v100 v41
    let v102 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v101 v43
    let v103 : string = method11(v98)
    let v104 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v103 v46
    let v105 : string = method12()
    let v106 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v105 v46
    let v107 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v102, v104, v106) v50
    let v108 : obj = v107
    let v109 : string = Fable.Core.Rust.emitExpr v108 v53
    let v110 : string = $"r#\"{v55}\"#"
    let v111 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v110
    let v112 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v111 v41
    let v113 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v112 v43
    let v114 : string = method11(v109)
    let v115 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v114 v46
    let v116 : string = method13()
    let v117 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v116 v46
    let v118 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v113, v115, v117) v50
    let v119 : obj = v118
    let v120 : string = Fable.Core.Rust.emitExpr v119 v53
    let v121 : string = $"r#\"{v67}\"#"
    let v122 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v121
    let v123 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v122 v41
    let v124 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v123 v43
    let v125 : string = method11(v120)
    let v126 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v125 v46
    let v127 : string = method14()
    let v128 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v127 v46
    let v129 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v124, v126, v128) v50
    let v130 : obj = v129
    let v131 : string = Fable.Core.Rust.emitExpr v130 v53
    let v132 : string = $"r#\"{v79}\"#"
    let v133 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v132
    let v134 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v133 v41
    let v135 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v134 v43
    let v136 : string = method11(v131)
    let v137 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v136 v46
    let v138 : string = method15()
    let v139 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v138 v46
    let v140 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v135, v137, v139) v50
    let v141 : obj = v140
    let v142 : string = Fable.Core.Rust.emitExpr v141 v53
    let v143 : Types.EmitType<Types.std.string.String> = method6(v142)
    let v144 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v35
    let v145 : string = (v144).ToString ()
    let v146 : string = $"r#\"{v38}\"#"
    let v147 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v146
    let v148 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v147 v41
    let v149 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v148 v43
    let v150 : string = method11(v145)
    let v151 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v150 v46
    let v152 : string = method12()
    let v153 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v152 v46
    let v154 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v149, v151, v153) v50
    let v155 : obj = v154
    let v156 : string = Fable.Core.Rust.emitExpr v155 v53
    let v157 : string = $"r#\"{v55}\"#"
    let v158 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v157
    let v159 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v158 v41
    let v160 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v159 v43
    let v161 : string = method11(v156)
    let v162 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v161 v46
    let v163 : string = method13()
    let v164 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v163 v46
    let v165 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v160, v162, v164) v50
    let v166 : obj = v165
    let v167 : string = Fable.Core.Rust.emitExpr v166 v53
    let v168 : string = $"r#\"{v67}\"#"
    let v169 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v168
    let v170 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v169 v41
    let v171 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v170 v43
    let v172 : string = method11(v167)
    let v173 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v172 v46
    let v174 : string = method14()
    let v175 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v174 v46
    let v176 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v171, v173, v175) v50
    let v177 : obj = v176
    let v178 : string = Fable.Core.Rust.emitExpr v177 v53
    let v179 : string = $"r#\"{v79}\"#"
    let v180 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v179
    let v181 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v180 v41
    let v182 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v181 v43
    let v183 : string = method11(v178)
    let v184 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v183 v46
    let v185 : string = method15()
    let v186 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v185 v46
    let v187 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v182, v184, v186) v50
    let v188 : obj = v187
    let v189 : string = Fable.Core.Rust.emitExpr v188 v53
    let v190 : Types.EmitType<Types.std.string.String> = method6(v189)
    let v191 : string = "cfg!(target_arch = \"wasm32\")"
    let v192 : bool = Fable.Core.Rust.emitExpr () v191
    let v195 : US0 =
        if v192 then
            US0_1
        else
            US0_0
    match v195 with
    | US0_1 -> (* Wasm32 *)
        let v196 : string = (v91).ToString ()
        let v197 : string = (v143).ToString ()
        let v198 : string = (v190).ToString ()
        let v199 : string = " %c"
        let v200 : string = v196 + v199
        let v201 : string = v200 + v197
        let v202 : string = v201 + v199
        let v203 : string = v202 + v198
        let v204 : string = "($0).as_ref().to_string()"
        let v205 : Types.std.string.String = Fable.Core.Rust.emitExpr v203 v204
        let v206 : string = "387957"
        let v207 : string = $"color: #{v206};"
        let v208 : Types.std.string.String = Fable.Core.Rust.emitExpr v207 v204
        let v209 : string = "color: #385779;"
        let v210 : Types.std.string.String = Fable.Core.Rust.emitExpr v209 v204
        let v211 : (Types.std.string.String []) = [|v205; v208; v210|]
        let v212 : Types.Ref<Types.Vec<obj>> = Fable.Core.Rust.emitExpr v211 v27
        let v213 : obj = v212
        let v214 : string = "serde_wasm_bindgen::to_value(&*****$0).unwrap()"
        let v215 : Types.wasm_bindgen.JsValue = Fable.Core.Rust.emitExpr v213 v214
        let v216 : string = "web_sys::console::log(&js_sys::Array::from(&$0))"
        Fable.Core.Rust.emitExpr v215 v216
        ()
    | _ ->
        let v217 : string = method16()
        let v218 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v217 v46
        let v219 : unativeint = unativeint 0
        let v220 : unativeint = unativeint 2
        let v221 : string = "&$0[$1..$2]"
        let v222 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v218, v219, v220) v221
        let v223 : obj = v222
        let v224 : string = Fable.Core.Rust.emitExpr v223 v53
        let v225 : string = "u8::from_str_radix($0, 16).unwrap()"
        let v226 : uint8 = Fable.Core.Rust.emitExpr v224 v225
        let v227 : string = method16()
        let v228 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v227 v46
        let v229 : unativeint = unativeint 2
        let v230 : unativeint = unativeint 4
        let v231 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v228, v229, v230) v221
        let v232 : obj = v231
        let v233 : string = Fable.Core.Rust.emitExpr v232 v53
        let v234 : uint8 = Fable.Core.Rust.emitExpr v233 v225
        let v235 : string = method16()
        let v236 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v235 v46
        let v237 : unativeint = unativeint 4
        let v238 : unativeint = unativeint 6
        let v239 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v236, v237, v238) v221
        let v240 : obj = v239
        let v241 : string = Fable.Core.Rust.emitExpr v240 v53
        let v242 : uint8 = Fable.Core.Rust.emitExpr v241 v225
        let v243 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
        let v244 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v143, v226, v234, v242) v243
        let v245 : Types.std.string.String = Fable.Core.Rust.emitExpr v244 v35
        let v246 : string = method17()
        let v247 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v246 v46
        let v248 : unativeint = unativeint 0
        let v249 : unativeint = unativeint 2
        let v250 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v247, v248, v249) v221
        let v251 : obj = v250
        let v252 : string = Fable.Core.Rust.emitExpr v251 v53
        let v253 : uint8 = Fable.Core.Rust.emitExpr v252 v225
        let v254 : string = method17()
        let v255 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v254 v46
        let v256 : unativeint = unativeint 2
        let v257 : unativeint = unativeint 4
        let v258 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v255, v256, v257) v221
        let v259 : obj = v258
        let v260 : string = Fable.Core.Rust.emitExpr v259 v53
        let v261 : uint8 = Fable.Core.Rust.emitExpr v260 v225
        let v262 : string = method17()
        let v263 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v262 v46
        let v264 : unativeint = unativeint 4
        let v265 : unativeint = unativeint 6
        let v266 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v263, v264, v265) v221
        let v267 : obj = v266
        let v268 : string = Fable.Core.Rust.emitExpr v267 v53
        let v269 : uint8 = Fable.Core.Rust.emitExpr v268 v225
        let v270 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v190, v253, v261, v269) v243
        let v271 : Types.std.string.String = Fable.Core.Rust.emitExpr v270 v35
        let v272 : string = $"{v91} {v245} {v271}"
        System.Console.WriteLine v272
        ()
and method18 (v0 : Types.std.string.String) : Types.EmitType<Types.std.string.String> =
    let v1 : Types.EmitType<Types.std.string.String> = v0 |> unbox<Types.EmitType<Types.std.string.String>>
    v1
and closure1 (v0 : int64) (v1 : Types.std.cell.RefCell<Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>>>) : unit =
    let v2 : string = "app > fetch ()"
    let v3 : Types.EmitType<Types.std.string.String> = method6(v2)
    let v4 : (Types.EmitType<Types.std.string.String> []) = [|v3|]
    method7(v0, v4)
    let v5 : string = "v1.borrow()"
    let v6 : Types.std.cell.CellRef<Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>>> = Fable.Core.Rust.emitExpr () v5
    let v7 : string = "v6.try_lock()"
    let v8 : Option<Types.core.future.Future<Types.async_std.sync.Mutex<Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>>>>> = Fable.Core.Rust.emitExpr () v7
    let v9 : string = "response"
    let v10 : Types.EmitType<Types.std.string.String> = method6(v9)
    let v11 : string = "format!(\"{:?}\", $0)"
    let v12 : Types.std.string.String = Fable.Core.Rust.emitExpr v8 v11
    let v13 : Types.EmitType<Types.std.string.String> = method18(v12)
    let v14 : (Types.EmitType<Types.std.string.String> []) = [|v10; v13|]
    method7(v0, v14)
and method19 (v0 : Types.futures_signals.signal.MutableSignal<Types.StaticRef<Types.Str>>) : Types.futures_signals.signal.MutableSignal<Types.StaticRef<Types.Str>> =
    v0
and closure3 (v0 : Types.std.rc.Rc<Types.futures_signals.signal.Mutable<Types.StaticRef<Types.Str>>>) (v1 : Types.StaticRef<Types.Str>) : unit =
    let v2 : string = "*$0.set_neq(v1)"
    Fable.Core.Rust.emitExpr v0 v2
    ()
and closure2 (v0 : Types.std.rc.Rc<Types.futures_signals.signal.Mutable<Types.StaticRef<Types.Str>>>) (v1 : Types.std.rc.Rc<Types.web_sys.HtmlInputElement>) : unit =
    let v2 : string = ""
    let v3 : string = "let value0 = v1;"
    let v4 : string = v2 + v3
    let v5 : string = "let value0 = value0.value();"
    let v6 : string = v4 + v5
    let v7 : string = "let value0 = value0.into_boxed_str();"
    let v8 : string = v6 + v7
    let v9 : string = "let value0 = Box::leak(value0);"
    let v10 : string = v8 + v9
    let v11 : (Types.StaticRef<Types.Str> -> unit) = closure3(v0)
    let v12 : string = "v11(value0);"
    let v13 : string = v10 + v12
    let v14 : string = "()"
    let v15 : string = v13 + v14
    Fable.Core.Rust.emitExpr () v15
    ()
and closure0 () () : int32 =
    let v0 : string = "console_error_panic_hook::set_once()"
    Fable.Core.Rust.emitExpr () v0
    let struct (v1 : string, v2 : string, v3 : string, v4 : bool) = method0()
    let v5 : string = "chrono::Utc::now()"
    let v6 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v5
    let v7 : string = "($0).timestamp()"
    let v8 : int64 = Fable.Core.Rust.emitExpr v6 v7
    let v9 : string = "https://dummyjson.com/users"
    let v10 : string = "($0).to_string()"
    let v11 : Types.std.string.String = Fable.Core.Rust.emitExpr v9 v10
    let v12 : string = "ehttp::Request::get($0)"
    let v13 : Types.ehttp.Request = Fable.Core.Rust.emitExpr v11 v12
    let v14 : bool = method1()
    let v15 : string = "async_std::sync::Mutex::new(v14)"
    let v16 : Types.async_std.sync.Mutex<bool> = Fable.Core.Rust.emitExpr () v15
    let v17 : string = "async_std::sync::Condvar::new()"
    let v18 : Types.async_std.sync.Condvar = Fable.Core.Rust.emitExpr () v17
    let v19 : string = "(v16, v18)"
    let v20 : Types.Tuple<Types.async_std.sync.Mutex<bool>, Types.async_std.sync.Condvar> = Fable.Core.Rust.emitExpr () v19
    let v21 : Types.Tuple<Types.async_std.sync.Mutex<bool>, Types.async_std.sync.Condvar> = method2(v20)
    let v22 : string = "std::sync::Arc::new(v21)"
    let v23 : Types.std.sync.Arc<Types.Tuple<Types.async_std.sync.Mutex<bool>, Types.async_std.sync.Condvar>> = Fable.Core.Rust.emitExpr () v22
    let v24 : string = "v23.clone()"
    let v25 : Types.std.sync.Arc<Types.Tuple<Types.async_std.sync.Mutex<bool>, Types.async_std.sync.Condvar>> = Fable.Core.Rust.emitExpr () v24
    let v26 : Option<Types.ehttp.Response> = None |> unbox
    let v27 : Option<Types.ehttp.Response> = method3(v26)
    let v28 : string = "async_std::sync::Mutex::new(v27)"
    let v29 : Types.async_std.sync.Mutex<Option<Types.ehttp.Response>> = Fable.Core.Rust.emitExpr () v28
    let v30 : Types.async_std.sync.Mutex<Option<Types.ehttp.Response>> = method4(v29)
    let v31 : string = "std::sync::Arc::new(v30)"
    let v32 : Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>> = Fable.Core.Rust.emitExpr () v31
    let v33 : Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>> = method5(v32)
    let v34 : string = "std::cell::RefCell::new(v33)"
    let v35 : Types.std.cell.RefCell<Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>>> = Fable.Core.Rust.emitExpr () v34
    let v36 : string = "v35.clone()"
    let v37 : Types.std.cell.RefCell<Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>>> = Fable.Core.Rust.emitExpr () v36
    let v38 : string = "move |x: ehttp::Result<ehttp::Response>| {"
    let v39 : string = "  let r = x.clone().unwrap();"
    let v40 : string = v38 + v39
    let v41 : string = "  *v35.borrow_mut().try_lock().unwrap() = Some(r);"
    let v42 : string = v40 + v41
    let v43 : string = "  async_std::task::block_on(async move {"
    let v44 : string = v42 + v43
    let v45 : string = "    let (lock, cvar) = &*v25;"
    let v46 : string = v44 + v45
    let v47 : string = "    let mut started = lock.lock().await;"
    let v48 : string = v46 + v47
    let v49 : string = "    *started = true;"
    let v50 : string = v48 + v49
    let v51 : string = "    cvar.notify_one();"
    let v52 : string = v50 + v51
    let v53 : string = "  });"
    let v54 : string = v52 + v53
    let v55 : string = "}"
    let v56 : string = v54 + v55
    let v57 : obj = Fable.Core.Rust.emitExpr () v56
    let v58 : string = "Box::new(v57)"
    let v59 : Types.Box<obj> = Fable.Core.Rust.emitExpr () v58
    let v60 : string = "ehttp::fetch(v13, v59)"
    Fable.Core.Rust.emitExpr () v60
    let v61 : string = "  let (lock, cvar) = &*v23;"
    let v62 : string = "async move {"
    let v63 : string = v62 + v61
    let v64 : string = "  let mut started = lock.lock().await;"
    let v65 : string = v63 + v64
    let v66 : string = "  while !*started {"
    let v67 : string = v65 + v66
    let v68 : string = "    started = cvar.wait(started).await;"
    let v69 : string = v67 + v68
    let v70 : string = "  }"
    let v71 : string = v69 + v70
    let v72 : (Types.std.cell.RefCell<Types.std.sync.Arc<Types.async_std.sync.Mutex<Option<Types.ehttp.Response>>>> -> unit) = closure1(v8)
    let v73 : string = "  v72(v37);"
    let v74 : string = v71 + v73
    let v75 : string = v74 + v55
    let v76 : Types.core.future.Future<obj> = Fable.Core.Rust.emitExpr () v75
    let v77 : string = "async_std::task::block_on(v76)"
    Fable.Core.Rust.emitExpr () v77
    let v78 : string = "https://time.is"
    let v79 : string = $"r#\"{v78}\"#"
    let v80 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v79
    let v81 : Types.StaticRef<Types.Str> = v80 |> unbox
    let v82 : string = "futures_signals::signal::Mutable::new(v81)"
    let v83 : Types.futures_signals.signal.Mutable<Types.StaticRef<Types.Str>> = Fable.Core.Rust.emitExpr () v82
    let v84 : string = "std::rc::Rc::new(v83)"
    let v85 : Types.std.rc.Rc<Types.futures_signals.signal.Mutable<Types.StaticRef<Types.Str>>> = Fable.Core.Rust.emitExpr () v84
    let v86 : string = "input"
    let v87 : string = $"r#\"{v86}\"#"
    let v88 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v87
    let v89 : string = "dominator::DomBuilder::new_html($0)"
    let v90 : Types.dominator.DomBuilder<Types.web_sys.HtmlInputElement> = Fable.Core.Rust.emitExpr v88 v89
    let v91 : string = "color"
    let v92 : string = $"r#\"{v91}\"#"
    let v93 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v92
    let v94 : string = "#666"
    let v95 : string = $"r#\"{v94}\"#"
    let v96 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v95
    let v97 : string = " .style(v93, v96) "
    let v98 : string = ""
    let v99 : string = v98 + v97
    let v100 : string = "dominator::class! {"
    let v101 : string = v100 + v99
    let v102 : string = v101 + v55
    let v103 : obj = Fable.Core.Rust.emitExpr () v102
    let v104 : string = "v90.class(&*v103)"
    let v105 : Types.dominator.DomBuilder<Types.web_sys.HtmlInputElement> = Fable.Core.Rust.emitExpr () v104
    let v106 : string = "placeholder"
    let v107 : string = $"r#\"{v106}\"#"
    let v108 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v107
    let v109 : string = "url"
    let v110 : string = $"r#\"{v109}\"#"
    let v111 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v110
    let v112 : string = "v105.attr(v108, v111)"
    let v113 : Types.dominator.DomBuilder<Types.web_sys.HtmlInputElement> = Fable.Core.Rust.emitExpr () v112
    let v114 : string = "v85.signal()"
    let v115 : Types.futures_signals.signal.MutableSignal<Types.StaticRef<Types.Str>> = Fable.Core.Rust.emitExpr () v114
    let v116 : string = "value"
    let v117 : string = $"r#\"{v116}\"#"
    let v118 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v117
    let v119 : Types.futures_signals.signal.MutableSignal<Types.StaticRef<Types.Str>> = method19(v115)
    let v120 : string = "v113.prop_signal(v118, v119)"
    let v121 : Types.dominator.DomBuilder<Types.web_sys.HtmlInputElement> = Fable.Core.Rust.emitExpr () v120
    let v122 : string = ".event(dominator::clone!("
    let v123 : (Types.std.rc.Rc<Types.web_sys.HtmlInputElement> -> unit) = closure2(v85)
    let v124 : string = "  v123 => move |_: dominator::events::Input| {"
    let v125 : string = v122 + v124
    let v126 : string = "    let element_ = std::rc::Rc::new(&element); "
    let v127 : string = v125 + v126
    let v128 : string = "    let el = (*element_).clone().into(); "
    let v129 : string = v127 + v128
    let v130 : string = "    v123(el); "
    let v131 : string = v129 + v130
    let v132 : string = "  }"
    let v133 : string = v131 + v132
    let v134 : string = "))"
    let v135 : string = v133 + v134
    let v136 : string = v135 + v98
    let v137 : string = "dominator::with_node!("
    let v138 : string = "   v121,"
    let v139 : string = v137 + v138
    let v140 : string = "   element => {"
    let v141 : string = v139 + v140
    let v142 : string = "      "
    let v143 : string = v141 + v142
    let v144 : string = v143 + v136
    let v145 : string = " "
    let v146 : string = v144 + v145
    let v147 : string = "   }"
    let v148 : string = v146 + v147
    let v149 : string = ")"
    let v150 : string = v148 + v149
    let v151 : Types.dominator.DomBuilder<Types.web_sys.HtmlInputElement> = Fable.Core.Rust.emitExpr () v150
    let v152 : string = "v151.into_dom()"
    let v153 : Types.dominator.Dom = Fable.Core.Rust.emitExpr () v152
    let v154 : string = "iframe"
    let v155 : string = $"r#\"{v154}\"#"
    let v156 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v155
    let v157 : string = "dominator::DomBuilder::new_html($0)"
    let v158 : Types.dominator.DomBuilder<Types.web_sys.HtmlElement> = Fable.Core.Rust.emitExpr v156 v157
    let v159 : string = "width"
    let v160 : string = $"r#\"{v159}\"#"
    let v161 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v160
    let v162 : string = "100%"
    let v163 : string = $"r#\"{v162}\"#"
    let v164 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v163
    let v165 : string = " .style(v161, v164) "
    let v166 : string = v98 + v165
    let v167 : string = "flex"
    let v168 : string = $"r#\"{v167}\"#"
    let v169 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v168
    let v170 : string = "1"
    let v171 : string = $"r#\"{v170}\"#"
    let v172 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v171
    let v173 : string = " .style(v169, v172) "
    let v174 : string = v166 + v173
    let v175 : string = "border"
    let v176 : string = $"r#\"{v175}\"#"
    let v177 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v176
    let v178 : string = "0"
    let v179 : string = $"r#\"{v178}\"#"
    let v180 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v179
    let v181 : string = " .style(v177, v180) "
    let v182 : string = v174 + v181
    let v183 : string = "dominator::class! {"
    let v184 : string = v183 + v182
    let v185 : string = v184 + v55
    let v186 : obj = Fable.Core.Rust.emitExpr () v185
    let v187 : string = "v158.class(&*v186)"
    let v188 : Types.dominator.DomBuilder<Types.web_sys.HtmlElement> = Fable.Core.Rust.emitExpr () v187
    let v189 : string = "title"
    let v190 : string = $"r#\"{v189}\"#"
    let v191 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v190
    let v192 : string = $"r#\"{v189}\"#"
    let v193 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v192
    let v194 : string = "v188.attr(v191, v193)"
    let v195 : Types.dominator.DomBuilder<Types.web_sys.HtmlElement> = Fable.Core.Rust.emitExpr () v194
    let v196 : string = "v85.signal()"
    let v197 : Types.futures_signals.signal.MutableSignal<Types.StaticRef<Types.Str>> = Fable.Core.Rust.emitExpr () v196
    let v198 : string = "src"
    let v199 : string = $"r#\"{v198}\"#"
    let v200 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v199
    let v201 : Types.futures_signals.signal.MutableSignal<Types.StaticRef<Types.Str>> = method19(v197)
    let v202 : string = "v195.prop_signal(v200, v201)"
    let v203 : Types.dominator.DomBuilder<Types.web_sys.HtmlElement> = Fable.Core.Rust.emitExpr () v202
    let v204 : string = "v203.into_dom()"
    let v205 : Types.dominator.Dom = Fable.Core.Rust.emitExpr () v204
    let v206 : string = "div"
    let v207 : string = $"r#\"{v206}\"#"
    let v208 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v207
    let v209 : string = "dominator::DomBuilder::new_html($0)"
    let v210 : Types.dominator.DomBuilder<Types.web_sys.HtmlElement> = Fable.Core.Rust.emitExpr v208 v209
    let v211 : string = "background-color"
    let v212 : string = $"r#\"{v211}\"#"
    let v213 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v212
    let v214 : string = $"r#\"{v94}\"#"
    let v215 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v214
    let v216 : string = " .style(v213, v215) "
    let v217 : string = v98 + v216
    let v218 : string = "height"
    let v219 : string = $"r#\"{v218}\"#"
    let v220 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v219
    let v221 : string = $"r#\"{v162}\"#"
    let v222 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v221
    let v223 : string = " .style(v220, v222) "
    let v224 : string = v217 + v223
    let v225 : string = "display"
    let v226 : string = $"r#\"{v225}\"#"
    let v227 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v226
    let v228 : string = $"r#\"{v167}\"#"
    let v229 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v228
    let v230 : string = " .style(v227, v229) "
    let v231 : string = v224 + v230
    let v232 : string = "flex-direction"
    let v233 : string = $"r#\"{v232}\"#"
    let v234 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v233
    let v235 : string = "column"
    let v236 : string = $"r#\"{v235}\"#"
    let v237 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v236
    let v238 : string = " .style(v234, v237) "
    let v239 : string = v231 + v238
    let v240 : string = "dominator::class! {"
    let v241 : string = v240 + v239
    let v242 : string = v241 + v55
    let v243 : obj = Fable.Core.Rust.emitExpr () v242
    let v244 : string = "v210.class(&*v243)"
    let v245 : Types.dominator.DomBuilder<Types.web_sys.HtmlElement> = Fable.Core.Rust.emitExpr () v244
    let v246 : string = "v153"
    let v247 : string = v98 + v246
    let v248 : string = ", v205"
    let v249 : string = v247 + v248
    let v250 : string = "["
    let v251 : string = v250 + v249
    let v252 : string = "]"
    let v253 : string = v251 + v252
    let v254 : obj = Fable.Core.Rust.emitExpr () v253
    let v255 : string = "v245.children(v254)"
    let v256 : Types.dominator.DomBuilder<Types.web_sys.HtmlElement> = Fable.Core.Rust.emitExpr () v255
    let v257 : string = "v256.into_dom()"
    let v258 : Types.dominator.Dom = Fable.Core.Rust.emitExpr () v257
    let v259 : string = "dominator::body()"
    let v260 : Types.web_sys.HtmlElement = Fable.Core.Rust.emitExpr () v259
    let v261 : string = "dominator::append_dom(&v260, v258)"
    Fable.Core.Rust.emitExpr () v261
    let v262 : string = "app end"
    let v263 : Types.EmitType<Types.std.string.String> = method6(v262)
    let v264 : string = "???"
    let v265 : Types.EmitType<Types.std.string.String> = method6(v264)
    let v266 : (Types.EmitType<Types.std.string.String> []) = [|v263; v265|]
    method7(v8, v266)
    0
let v0 : (unit -> int32) = closure0()
()
