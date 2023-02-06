type UH0 =
    | UH0_0 of Types.std.string.String * UH0
    | UH0_1
and Mut0 = {mutable l0 : UH0}
and UH1 =
    | UH1_0 of string * UH1
    | UH1_1
let rec method0 () : struct (string * string * string * bool) =
    let v0 : string = ""
    let v1 : obj = v0
    struct (v0, v0, v0, true)
and method1 () : string =
    let v0 : string = "rs-path"
    v0
and method2 (v0 : string) : string =
    v0
and method3 (v0 : string) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "($0).to_string()"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method4 (v0 : Types.std.path.PathBuf) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method6 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method6(v0, v4)
    else
        v1
and method7 (v0 : uint8) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method8 (v0 : (Types.EmitType<Types.std.string.String> [])) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "core::ops::Deref::deref($0)"
    let v2 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v0 v1
    let v3 : string = "&***$0"
    let v4 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v2 v3
    let v5 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v4 v3
    let v6 : string = "format!(\"{:?}\", $0)"
    let v7 : Types.std.string.String = Fable.Core.Rust.emitExpr v5 v6
    let v8 : Types.EmitType<Types.std.string.String> = v7 |> unbox<Types.EmitType<Types.std.string.String>>
    v8
and method9 () : string =
    let v0 : string = "$1=$2"
    v0
and method10 () : string =
    let v0 : string = "[$1]"
    v0
and method11 () : string =
    let v0 : string = "\""
    v0
and method12 () : string =
    let v0 : string = " "
    v0
and method13 () : string =
    let v0 : string = "387957"
    v0
and method14 () : string =
    let v0 : string = "385779"
    v0
and method5 (v0 : int64, v1 : (Types.EmitType<Types.std.string.String> [])) : unit =
    let v2 : string = "chrono::Utc::now()"
    let v3 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v2
    let v4 : string = "($0).timestamp()"
    let v5 : int64 = Fable.Core.Rust.emitExpr v3 v4
    let v6 : int64 = v5 - v0
    let v7 : string = (v6).ToString ()
    let v8 : int32 = 6
    let v9 : string = method6(v8, v7)
    let v10 : string = "rand::random::<u8>()"
    let v11 : uint8 = Fable.Core.Rust.emitExpr () v10
    let v12 : string = "timestamp"
    let v13 : Types.EmitType<Types.std.string.String> = method3(v12)
    let v14 : Types.EmitType<Types.std.string.String> = method3(v9)
    let v15 : string = "run_id"
    let v16 : Types.EmitType<Types.std.string.String> = method3(v15)
    let v17 : Types.EmitType<Types.std.string.String> = method7(v11)
    let v18 : string = "log_level"
    let v19 : Types.EmitType<Types.std.string.String> = method3(v18)
    let v20 : string = "Debug"
    let v21 : Types.EmitType<Types.std.string.String> = method3(v20)
    let v22 : (Types.EmitType<Types.std.string.String> []) = [|v13; v14; v16; v17; v19; v21|]
    let v23 : Types.EmitType<Types.std.string.String> = method8(v22)
    let v24 : string = "> app ()"
    let v25 : Types.EmitType<Types.std.string.String> = method3(v24)
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
    let v45 : string = method2(v37)
    let v46 : string = "$0.as_str()"
    let v47 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v45 v46
    let v48 : string = method9()
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
    let v60 : string = method2(v54)
    let v61 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v60 v46
    let v62 : string = method10()
    let v63 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v62 v46
    let v64 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v59, v61, v63) v50
    let v65 : obj = v64
    let v66 : string = Fable.Core.Rust.emitExpr v65 v53
    let v67 : string = "\\\\\""
    let v68 : string = $"r#\"{v67}\"#"
    let v69 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v68
    let v70 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v69 v41
    let v71 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v70 v43
    let v72 : string = method2(v66)
    let v73 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v72 v46
    let v74 : string = method11()
    let v75 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v74 v46
    let v76 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v71, v73, v75) v50
    let v77 : obj = v76
    let v78 : string = Fable.Core.Rust.emitExpr v77 v53
    let v79 : string = ", "
    let v80 : string = $"r#\"{v79}\"#"
    let v81 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v80
    let v82 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v81 v41
    let v83 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v82 v43
    let v84 : string = method2(v78)
    let v85 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v84 v46
    let v86 : string = method12()
    let v87 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v86 v46
    let v88 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v83, v85, v87) v50
    let v89 : obj = v88
    let v90 : string = Fable.Core.Rust.emitExpr v89 v53
    let v91 : Types.EmitType<Types.std.string.String> = method3(v90)
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
    let v103 : string = method2(v98)
    let v104 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v103 v46
    let v105 : string = method9()
    let v106 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v105 v46
    let v107 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v102, v104, v106) v50
    let v108 : obj = v107
    let v109 : string = Fable.Core.Rust.emitExpr v108 v53
    let v110 : string = $"r#\"{v55}\"#"
    let v111 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v110
    let v112 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v111 v41
    let v113 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v112 v43
    let v114 : string = method2(v109)
    let v115 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v114 v46
    let v116 : string = method10()
    let v117 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v116 v46
    let v118 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v113, v115, v117) v50
    let v119 : obj = v118
    let v120 : string = Fable.Core.Rust.emitExpr v119 v53
    let v121 : string = $"r#\"{v67}\"#"
    let v122 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v121
    let v123 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v122 v41
    let v124 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v123 v43
    let v125 : string = method2(v120)
    let v126 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v125 v46
    let v127 : string = method11()
    let v128 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v127 v46
    let v129 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v124, v126, v128) v50
    let v130 : obj = v129
    let v131 : string = Fable.Core.Rust.emitExpr v130 v53
    let v132 : string = $"r#\"{v79}\"#"
    let v133 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v132
    let v134 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v133 v41
    let v135 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v134 v43
    let v136 : string = method2(v131)
    let v137 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v136 v46
    let v138 : string = method12()
    let v139 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v138 v46
    let v140 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v135, v137, v139) v50
    let v141 : obj = v140
    let v142 : string = Fable.Core.Rust.emitExpr v141 v53
    let v143 : Types.EmitType<Types.std.string.String> = method3(v142)
    let v144 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v35
    let v145 : string = (v144).ToString ()
    let v146 : string = $"r#\"{v38}\"#"
    let v147 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v146
    let v148 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v147 v41
    let v149 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v148 v43
    let v150 : string = method2(v145)
    let v151 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v150 v46
    let v152 : string = method9()
    let v153 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v152 v46
    let v154 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v149, v151, v153) v50
    let v155 : obj = v154
    let v156 : string = Fable.Core.Rust.emitExpr v155 v53
    let v157 : string = $"r#\"{v55}\"#"
    let v158 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v157
    let v159 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v158 v41
    let v160 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v159 v43
    let v161 : string = method2(v156)
    let v162 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v161 v46
    let v163 : string = method10()
    let v164 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v163 v46
    let v165 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v160, v162, v164) v50
    let v166 : obj = v165
    let v167 : string = Fable.Core.Rust.emitExpr v166 v53
    let v168 : string = $"r#\"{v67}\"#"
    let v169 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v168
    let v170 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v169 v41
    let v171 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v170 v43
    let v172 : string = method2(v167)
    let v173 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v172 v46
    let v174 : string = method11()
    let v175 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v174 v46
    let v176 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v171, v173, v175) v50
    let v177 : obj = v176
    let v178 : string = Fable.Core.Rust.emitExpr v177 v53
    let v179 : string = $"r#\"{v79}\"#"
    let v180 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v179
    let v181 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v180 v41
    let v182 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v181 v43
    let v183 : string = method2(v178)
    let v184 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v183 v46
    let v185 : string = method12()
    let v186 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v185 v46
    let v187 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v182, v184, v186) v50
    let v188 : obj = v187
    let v189 : string = Fable.Core.Rust.emitExpr v188 v53
    let v190 : Types.EmitType<Types.std.string.String> = method3(v189)
    let v191 : string = method13()
    let v192 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v191 v46
    let v193 : unativeint = unativeint 0
    let v194 : unativeint = unativeint 2
    let v195 : string = "&$0[$1..$2]"
    let v196 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v192, v193, v194) v195
    let v197 : obj = v196
    let v198 : string = Fable.Core.Rust.emitExpr v197 v53
    let v199 : string = "u8::from_str_radix($0, 16).unwrap()"
    let v200 : uint8 = Fable.Core.Rust.emitExpr v198 v199
    let v201 : string = method13()
    let v202 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v201 v46
    let v203 : unativeint = unativeint 2
    let v204 : unativeint = unativeint 4
    let v205 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v202, v203, v204) v195
    let v206 : obj = v205
    let v207 : string = Fable.Core.Rust.emitExpr v206 v53
    let v208 : uint8 = Fable.Core.Rust.emitExpr v207 v199
    let v209 : string = method13()
    let v210 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v209 v46
    let v211 : unativeint = unativeint 4
    let v212 : unativeint = unativeint 6
    let v213 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v210, v211, v212) v195
    let v214 : obj = v213
    let v215 : string = Fable.Core.Rust.emitExpr v214 v53
    let v216 : uint8 = Fable.Core.Rust.emitExpr v215 v199
    let v217 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
    let v218 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v143, v200, v208, v216) v217
    let v219 : Types.std.string.String = Fable.Core.Rust.emitExpr v218 v35
    let v220 : string = method14()
    let v221 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v220 v46
    let v222 : unativeint = unativeint 0
    let v223 : unativeint = unativeint 2
    let v224 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v221, v222, v223) v195
    let v225 : obj = v224
    let v226 : string = Fable.Core.Rust.emitExpr v225 v53
    let v227 : uint8 = Fable.Core.Rust.emitExpr v226 v199
    let v228 : string = method14()
    let v229 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v228 v46
    let v230 : unativeint = unativeint 2
    let v231 : unativeint = unativeint 4
    let v232 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v229, v230, v231) v195
    let v233 : obj = v232
    let v234 : string = Fable.Core.Rust.emitExpr v233 v53
    let v235 : uint8 = Fable.Core.Rust.emitExpr v234 v199
    let v236 : string = method14()
    let v237 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v236 v46
    let v238 : unativeint = unativeint 4
    let v239 : unativeint = unativeint 6
    let v240 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v237, v238, v239) v195
    let v241 : obj = v240
    let v242 : string = Fable.Core.Rust.emitExpr v241 v53
    let v243 : uint8 = Fable.Core.Rust.emitExpr v242 v199
    let v244 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v190, v227, v235, v243) v217
    let v245 : Types.std.string.String = Fable.Core.Rust.emitExpr v244 v35
    let v246 : string = $"{v91} {v219} {v245}"
    System.Console.WriteLine v246
    ()
and method16 () : string =
    let v0 : string = "881749"
    v0
and method15 (v0 : int64, v1 : (Types.EmitType<Types.std.string.String> [])) : unit =
    let v2 : string = "chrono::Utc::now()"
    let v3 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v2
    let v4 : string = "($0).timestamp()"
    let v5 : int64 = Fable.Core.Rust.emitExpr v3 v4
    let v6 : int64 = v5 - v0
    let v7 : string = (v6).ToString ()
    let v8 : int32 = 6
    let v9 : string = method6(v8, v7)
    let v10 : string = "rand::random::<u8>()"
    let v11 : uint8 = Fable.Core.Rust.emitExpr () v10
    let v12 : string = "timestamp"
    let v13 : Types.EmitType<Types.std.string.String> = method3(v12)
    let v14 : Types.EmitType<Types.std.string.String> = method3(v9)
    let v15 : string = "run_id"
    let v16 : Types.EmitType<Types.std.string.String> = method3(v15)
    let v17 : Types.EmitType<Types.std.string.String> = method7(v11)
    let v18 : string = "log_level"
    let v19 : Types.EmitType<Types.std.string.String> = method3(v18)
    let v20 : string = "Debug"
    let v21 : Types.EmitType<Types.std.string.String> = method3(v20)
    let v22 : (Types.EmitType<Types.std.string.String> []) = [|v13; v14; v16; v17; v19; v21|]
    let v23 : Types.EmitType<Types.std.string.String> = method8(v22)
    let v24 : string = "> read_lines ()"
    let v25 : Types.EmitType<Types.std.string.String> = method3(v24)
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
    let v45 : string = method2(v37)
    let v46 : string = "$0.as_str()"
    let v47 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v45 v46
    let v48 : string = method9()
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
    let v60 : string = method2(v54)
    let v61 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v60 v46
    let v62 : string = method10()
    let v63 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v62 v46
    let v64 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v59, v61, v63) v50
    let v65 : obj = v64
    let v66 : string = Fable.Core.Rust.emitExpr v65 v53
    let v67 : string = "\\\\\""
    let v68 : string = $"r#\"{v67}\"#"
    let v69 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v68
    let v70 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v69 v41
    let v71 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v70 v43
    let v72 : string = method2(v66)
    let v73 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v72 v46
    let v74 : string = method11()
    let v75 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v74 v46
    let v76 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v71, v73, v75) v50
    let v77 : obj = v76
    let v78 : string = Fable.Core.Rust.emitExpr v77 v53
    let v79 : string = ", "
    let v80 : string = $"r#\"{v79}\"#"
    let v81 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v80
    let v82 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v81 v41
    let v83 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v82 v43
    let v84 : string = method2(v78)
    let v85 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v84 v46
    let v86 : string = method12()
    let v87 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v86 v46
    let v88 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v83, v85, v87) v50
    let v89 : obj = v88
    let v90 : string = Fable.Core.Rust.emitExpr v89 v53
    let v91 : Types.EmitType<Types.std.string.String> = method3(v90)
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
    let v103 : string = method2(v98)
    let v104 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v103 v46
    let v105 : string = method9()
    let v106 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v105 v46
    let v107 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v102, v104, v106) v50
    let v108 : obj = v107
    let v109 : string = Fable.Core.Rust.emitExpr v108 v53
    let v110 : string = $"r#\"{v55}\"#"
    let v111 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v110
    let v112 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v111 v41
    let v113 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v112 v43
    let v114 : string = method2(v109)
    let v115 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v114 v46
    let v116 : string = method10()
    let v117 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v116 v46
    let v118 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v113, v115, v117) v50
    let v119 : obj = v118
    let v120 : string = Fable.Core.Rust.emitExpr v119 v53
    let v121 : string = $"r#\"{v67}\"#"
    let v122 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v121
    let v123 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v122 v41
    let v124 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v123 v43
    let v125 : string = method2(v120)
    let v126 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v125 v46
    let v127 : string = method11()
    let v128 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v127 v46
    let v129 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v124, v126, v128) v50
    let v130 : obj = v129
    let v131 : string = Fable.Core.Rust.emitExpr v130 v53
    let v132 : string = $"r#\"{v79}\"#"
    let v133 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v132
    let v134 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v133 v41
    let v135 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v134 v43
    let v136 : string = method2(v131)
    let v137 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v136 v46
    let v138 : string = method12()
    let v139 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v138 v46
    let v140 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v135, v137, v139) v50
    let v141 : obj = v140
    let v142 : string = Fable.Core.Rust.emitExpr v141 v53
    let v143 : Types.EmitType<Types.std.string.String> = method3(v142)
    let v144 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v35
    let v145 : string = (v144).ToString ()
    let v146 : string = $"r#\"{v38}\"#"
    let v147 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v146
    let v148 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v147 v41
    let v149 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v148 v43
    let v150 : string = method2(v145)
    let v151 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v150 v46
    let v152 : string = method9()
    let v153 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v152 v46
    let v154 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v149, v151, v153) v50
    let v155 : obj = v154
    let v156 : string = Fable.Core.Rust.emitExpr v155 v53
    let v157 : string = $"r#\"{v55}\"#"
    let v158 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v157
    let v159 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v158 v41
    let v160 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v159 v43
    let v161 : string = method2(v156)
    let v162 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v161 v46
    let v163 : string = method10()
    let v164 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v163 v46
    let v165 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v160, v162, v164) v50
    let v166 : obj = v165
    let v167 : string = Fable.Core.Rust.emitExpr v166 v53
    let v168 : string = $"r#\"{v67}\"#"
    let v169 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v168
    let v170 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v169 v41
    let v171 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v170 v43
    let v172 : string = method2(v167)
    let v173 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v172 v46
    let v174 : string = method11()
    let v175 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v174 v46
    let v176 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v171, v173, v175) v50
    let v177 : obj = v176
    let v178 : string = Fable.Core.Rust.emitExpr v177 v53
    let v179 : string = $"r#\"{v79}\"#"
    let v180 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v179
    let v181 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v180 v41
    let v182 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v181 v43
    let v183 : string = method2(v178)
    let v184 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v183 v46
    let v185 : string = method12()
    let v186 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v185 v46
    let v187 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v182, v184, v186) v50
    let v188 : obj = v187
    let v189 : string = Fable.Core.Rust.emitExpr v188 v53
    let v190 : Types.EmitType<Types.std.string.String> = method3(v189)
    let v191 : string = method16()
    let v192 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v191 v46
    let v193 : unativeint = unativeint 0
    let v194 : unativeint = unativeint 2
    let v195 : string = "&$0[$1..$2]"
    let v196 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v192, v193, v194) v195
    let v197 : obj = v196
    let v198 : string = Fable.Core.Rust.emitExpr v197 v53
    let v199 : string = "u8::from_str_radix($0, 16).unwrap()"
    let v200 : uint8 = Fable.Core.Rust.emitExpr v198 v199
    let v201 : string = method16()
    let v202 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v201 v46
    let v203 : unativeint = unativeint 2
    let v204 : unativeint = unativeint 4
    let v205 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v202, v203, v204) v195
    let v206 : obj = v205
    let v207 : string = Fable.Core.Rust.emitExpr v206 v53
    let v208 : uint8 = Fable.Core.Rust.emitExpr v207 v199
    let v209 : string = method16()
    let v210 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v209 v46
    let v211 : unativeint = unativeint 4
    let v212 : unativeint = unativeint 6
    let v213 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v210, v211, v212) v195
    let v214 : obj = v213
    let v215 : string = Fable.Core.Rust.emitExpr v214 v53
    let v216 : uint8 = Fable.Core.Rust.emitExpr v215 v199
    let v217 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
    let v218 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v143, v200, v208, v216) v217
    let v219 : Types.std.string.String = Fable.Core.Rust.emitExpr v218 v35
    let v220 : string = method14()
    let v221 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v220 v46
    let v222 : unativeint = unativeint 0
    let v223 : unativeint = unativeint 2
    let v224 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v221, v222, v223) v195
    let v225 : obj = v224
    let v226 : string = Fable.Core.Rust.emitExpr v225 v53
    let v227 : uint8 = Fable.Core.Rust.emitExpr v226 v199
    let v228 : string = method14()
    let v229 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v228 v46
    let v230 : unativeint = unativeint 2
    let v231 : unativeint = unativeint 4
    let v232 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v229, v230, v231) v195
    let v233 : obj = v232
    let v234 : string = Fable.Core.Rust.emitExpr v233 v53
    let v235 : uint8 = Fable.Core.Rust.emitExpr v234 v199
    let v236 : string = method14()
    let v237 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v236 v46
    let v238 : unativeint = unativeint 4
    let v239 : unativeint = unativeint 6
    let v240 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v237, v238, v239) v195
    let v241 : obj = v240
    let v242 : string = Fable.Core.Rust.emitExpr v241 v53
    let v243 : uint8 = Fable.Core.Rust.emitExpr v242 v199
    let v244 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v190, v227, v235, v243) v217
    let v245 : Types.std.string.String = Fable.Core.Rust.emitExpr v244 v35
    let v246 : string = $"{v91} {v219} {v245}"
    System.Console.WriteLine v246
    ()
and method17 (v0 : Types.std.string.String) : Types.EmitType<Types.std.string.String> =
    let v1 : Types.EmitType<Types.std.string.String> = v0 |> unbox<Types.EmitType<Types.std.string.String>>
    v1
and method19 (v0 : int32) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method20 (v0 : int64, v1 : (Types.EmitType<Types.std.string.String> [])) : unit =
    ()
and closure1 (v0 : int64, v1 : Mut0) (v2 : Types.Vec<uint8>) : Result<bool, Types.std.io.Error> =
    let v3 : string = "line len"
    let v4 : Types.EmitType<Types.std.string.String> = method3(v3)
    let v5 : string = "($0).len().try_into().unwrap()"
    let v6 : int32 = Fable.Core.Rust.emitExpr v2 v5
    let v7 : Types.EmitType<Types.std.string.String> = method19(v6)
    let v8 : (Types.EmitType<Types.std.string.String> []) = [|v4; v7|]
    method20(v0, v8)
    let v9 : string = "v2.to_owned()"
    let v10 : Types.Vec<uint8> = Fable.Core.Rust.emitExpr () v9
    let v11 : string = "std::string::String::from_utf8(v10).unwrap()"
    let v12 : Types.std.string.String = Fable.Core.Rust.emitExpr () v11
    let v13 : UH0 = v1.l0
    let v14 : UH0 = UH0_0(v12, v13)
    v1.l0 <- v14
    let v15 : Result<bool, Types.std.io.Error> = Ok true
    v15
and method18 (v0 : int64, v1 : Mut0) : (Types.Vec<uint8> -> Result<bool, Types.std.io.Error>) =
    closure1(v0, v1)
and method21 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_0(v2, v1)
        method21(v3, v4)
    | UH0_1 -> (* Nil *)
        v1
and method22 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : UH1 = method22(v3, v1)
        let v5 : obj = v2
        let v6 : string = "fable_library_rust::String_::fromStr($0)"
        let v7 : string = Fable.Core.Rust.emitExpr v5 v6
        UH1_0(v7, v4)
    | UH0_1 -> (* Nil *)
        v1
and method23 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method23(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and method24 (v0 : int64, v1 : UH1, v2 : int32, v3 : UH1) : struct (int32 * UH1) =
    match v1 with
    | UH1_0(v4, v5) -> (* Cons *)
        let v6 : string = "/node_modules/"
        let v7 : Types.Ref<string> = v6 |> unbox
        let v8 : Types.Ref<string> = v4 |> unbox
        let v9 : string = "($1).contains(&*$0)"
        let v10 : bool = Fable.Core.Rust.emitExpr struct (v7, v8) v9
        let v15 : bool =
            if v10 then
                let v11 : string = ".cs"
                let v12 : Types.Ref<string> = v11 |> unbox
                let v13 : Types.Ref<string> = v4 |> unbox
                let v14 : bool = Fable.Core.Rust.emitExpr struct (v12, v13) v9
                v14
            else
                false
        let struct (v30 : int32, v31 : UH1) =
            if v15 then
                let v16 : string = "found line. removing."
                let v17 : Types.EmitType<Types.std.string.String> = method3(v16)
                let v18 : string = " line"
                let v19 : Types.EmitType<Types.std.string.String> = method3(v18)
                let v20 : Types.EmitType<Types.std.string.String> = method3(v4)
                let v21 : (Types.EmitType<Types.std.string.String> []) = [|v17; v19; v20|]
                method5(v0, v21)
                struct (1, v3)
            else
                let v22 : bool = 0 = v2
                if v22 then
                    let v23 : UH1 = UH1_0(v4, v3)
                    struct (0, v23)
                else
                    let v24 : bool = 2 = v2
                    if v24 then
                        struct (0, v3)
                    else
                        let v25 : int32 = v2 + 1
                        struct (v25, v3)
        method24(v0, v5, v30, v31)
    | UH1_1 -> (* Nil *)
        struct (v2, v3)
and method25 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_0(v2, v1)
        method25(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and method26 (v0 : UH1, v1 : string) : string =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : string = v1 + v2
        method26(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and closure0 () () : int32 =
    let struct (v0 : string, v1 : string, v2 : string, v3 : bool) = method0()
    let v4 : string = "chrono::Utc::now()"
    let v5 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v4
    let v6 : string = "($0).timestamp()"
    let v7 : int64 = Fable.Core.Rust.emitExpr v5 v6
    let v8 : string = "app1"
    let v9 : string = $"r#\"{v8}\"#"
    let v10 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v9
    let v11 : string = "clap::Command::new($0)"
    let v12 : string = ".propagate_version(true)"
    let v13 : string = v11 + v12
    let v14 : string = ".subcommand_required(false)"
    let v15 : string = v13 + v14
    let v16 : string = ".about(\"command about\")"
    let v17 : string = v15 + v16
    let v18 : string = ".arg_required_else_help(true)"
    let v19 : string = v17 + v18
    let v20 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr v10 v19
    let v21 : string = "PostFsxRsBuild"
    let v22 : string = $"r#\"{v21}\"#"
    let v23 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v22
    let v24 : string = v11 + v12
    let v25 : string = v24 + v14
    let v26 : string = v25 + v16
    let v27 : string = v26 + v18
    let v28 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr v23 v27
    let v29 : string = "rs-path"
    let v30 : string = $"r#\"{v29}\"#"
    let v31 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v30
    let v32 : string = "clap::Arg::new($0)"
    let v33 : Types.clap.builder.Arg = Fable.Core.Rust.emitExpr v31 v32
    let v34 : string = "$0.arg($1)"
    let v35 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr struct (v28, v33) v34
    let v36 : string = "$0.subcommand($1)"
    let v37 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr struct (v20, v35) v36
    let v38 : string = "SpiFsxBuild"
    let v39 : string = $"r#\"{v38}\"#"
    let v40 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v39
    let v41 : string = v11 + v12
    let v42 : string = v41 + v14
    let v43 : string = v42 + v16
    let v44 : string = v43 + v18
    let v45 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr v40 v44
    let v46 : string = "spi-path"
    let v47 : string = $"r#\"{v46}\"#"
    let v48 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v47
    let v49 : Types.clap.builder.Arg = Fable.Core.Rust.emitExpr v48 v32
    let v50 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr struct (v45, v49) v34
    let v51 : string = "fsx-path"
    let v52 : string = $"r#\"{v51}\"#"
    let v53 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v52
    let v54 : Types.clap.builder.Arg = Fable.Core.Rust.emitExpr v53 v32
    let v55 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr struct (v50, v54) v34
    let v56 : Types.clap.builder.Command = Fable.Core.Rust.emitExpr struct (v37, v55) v36
    let v57 : string = "$0.get_matches()"
    let v58 : Types.Ref<Types.clap.parser.ArgMatches> = Fable.Core.Rust.emitExpr v56 v57
    let v59 : string = "$0.subcommand()"
    let v60 : Types.Ref<Option<struct (Types.Ref<Types.Str> * Types.Ref<Types.clap.parser.ArgMatches>)>> = Fable.Core.Rust.emitExpr v58 v59
    let v61 : string = "*(($0).as_ref()).unwrap()"
    let struct (v62 : Types.Ref<Types.Str>, v63 : Types.Ref<Types.clap.parser.ArgMatches>) = Fable.Core.Rust.emitExpr v60 v61
    let v64 : string = method1()
    let v65 : string = "$0.as_str()"
    let v66 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v64 v65
    let v67 : string = "--" + v29 + "="
    let v68 : string = method2(v67)
    let v69 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v68 v65
    let v70 : string = "&($0).get_one::<String>($1).unwrap().replace($2, \"\")"
    let v71 : Types.Ref<Types.std.string.String> = Fable.Core.Rust.emitExpr struct (v63, v66, v69) v70
    let v72 : string = "std::path::PathBuf::from($0)"
    let v73 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v71 v72
    let v74 : string = "($0).canonicalize()"
    let v75 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v73 v74
    let v76 : string = "($0).as_ref().unwrap().to_path_buf()"
    let v77 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v75 v76
    let v78 : string = "rs_path_clean"
    let v79 : Types.EmitType<Types.std.string.String> = method3(v78)
    let v80 : Types.EmitType<Types.std.string.String> = method4(v77)
    let v81 : (Types.EmitType<Types.std.string.String> []) = [|v79; v80|]
    method5(v7, v81)
    let struct (v82 : string, v83 : string, v84 : string, v85 : bool) = method0()
    let v86 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v4
    let v87 : int64 = Fable.Core.Rust.emitExpr v86 v6
    let v88 : Result<Types.std.path.PathBuf, Types.std.io.Error> = Fable.Core.Rust.emitExpr v77 v74
    let v89 : Types.std.path.PathBuf = Fable.Core.Rust.emitExpr v88 v76
    let v90 : string = "path_clean"
    let v91 : Types.EmitType<Types.std.string.String> = method3(v90)
    let v92 : string = "fable_library_rust::String_::fromStr(&format!(\"{}\", $0.display()))"
    let v93 : string = Fable.Core.Rust.emitExpr v89 v92
    let v94 : Types.EmitType<Types.std.string.String> = method3(v93)
    let v95 : (Types.EmitType<Types.std.string.String> []) = [|v91; v94|]
    method15(v87, v95)
    let v96 : string = "std::fs::File::open($0)"
    let v97 : Result<Types.std.fs.File, Types.std.io.Error> = Fable.Core.Rust.emitExpr v89 v96
    let v98 : string = "$0.unwrap()"
    let v99 : Types.Ref<Types.std.fs.File> = Fable.Core.Rust.emitExpr v97 v98
    let v100 : string = "std::cell::RefCell::new(linereader::LineReader::new($0))"
    let v101 : Types.std.cell.RefCell<Types.linereader.LineReader<Types.Ref<Types.std.fs.File>>> = Fable.Core.Rust.emitExpr v99 v100
    let v102 : string = "reader"
    let v103 : Types.EmitType<Types.std.string.String> = method3(v102)
    let v104 : string = "format!(\"{:?}\", $0)"
    let v105 : Types.std.string.String = Fable.Core.Rust.emitExpr v101 v104
    let v106 : Types.EmitType<Types.std.string.String> = method17(v105)
    let v107 : (Types.EmitType<Types.std.string.String> []) = [|v103; v106|]
    method15(v87, v107)
    let v108 : UH0 = UH0_1
    let v109 : Mut0 = {l0 = v108} : Mut0
    let v110 : (Types.Vec<uint8> -> Result<bool, Types.std.io.Error>) = method18(v87, v109)
    let v111 : string = "($0).borrow_mut().for_each(move |x| $1(x.to_vec()))"
    let v112 : Result<unit, Types.std.io.Error> = Fable.Core.Rust.emitExpr struct (v101, v110) v111
    Fable.Core.Rust.emitExpr v112 v61
    let v113 : UH0 = v109.l0
    let v114 : UH0 = UH0_1
    let v115 : UH0 = method21(v113, v114)
    let v116 : UH1 = UH1_1
    let v117 : UH1 = method22(v115, v116)
    let v118 : string = "lines len"
    let v119 : Types.EmitType<Types.std.string.String> = method3(v118)
    let v120 : int32 = 0
    let v121 : int32 = method23(v117, v120)
    let v122 : Types.EmitType<Types.std.string.String> = method19(v121)
    let v123 : (Types.EmitType<Types.std.string.String> []) = [|v119; v122|]
    method15(v87, v123)
    let v124 : int32 = 0
    let v125 : UH1 = UH1_1
    let struct (v126 : int32, v127 : UH1) = method24(v7, v117, v124, v125)
    let v128 : UH1 = UH1_1
    let v129 : UH1 = method25(v127, v128)
    let v130 : string = ""
    let v131 : string = method26(v129, v130)
    let v132 : string = "text len"
    let v133 : Types.EmitType<Types.std.string.String> = method3(v132)
    let v134 : string = "($0).len().try_into().unwrap()"
    let v135 : int32 = Fable.Core.Rust.emitExpr v131 v134
    let v136 : Types.EmitType<Types.std.string.String> = method19(v135)
    let v137 : (Types.EmitType<Types.std.string.String> []) = [|v133; v136|]
    method5(v7, v137)
    let v138 : string = "std::fs::write($0, $1.as_str())"
    let v139 : Result<unit, Types.std.io.Error> = Fable.Core.Rust.emitExpr struct (v77, v131) v138
    Fable.Core.Rust.emitExpr v139 v61
    let v140 : string = "> fs_write rs_path_clean text; ok"
    let v141 : Types.EmitType<Types.std.string.String> = method3(v140)
    let v142 : (Types.EmitType<Types.std.string.String> []) = [|v141|]
    method5(v7, v142)
    0
let v0 : (unit -> int32) = closure0()
()
