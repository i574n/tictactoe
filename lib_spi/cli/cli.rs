#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Cli {
    use super::*;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Debug, Hash)]
    pub enum UH0 { UH0_0(std::string::String, Lrc<Cli::UH0>), UH0_1, }
    #[derive(Clone, Debug, Hash)]
    pub struct Mut0 {
        pub l0: MutCell<Lrc<Cli::UH0>>,
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum UH1 { UH1_0(string, Lrc<Cli::UH1>), UH1_1, }
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1() -> string { string("rs-path") }
    pub fn method2(v0_1: string) -> string { v0_1 }
    pub fn method3(v0_1: string) -> std::string::String {
        (&v0_1).to_string().clone()
    }
    pub fn method4(v0_1: std::path::PathBuf) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method6(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method6:
            loop  {
                break '_method6
                    (if length(v1.get()) < v0_1.get() {
                         let v0_1_temp: i32 = v0_1.get();
                         let v1_temp: string =
                             stringFrom(format!("0{0}", &v1.get()));
                         v0_1.set(v0_1_temp);
                         v1.set(v1_temp);
                         continue '_method6
                     } else { v1.get() }) ;
            }
    }
    pub fn method7(v0_1: u8) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method8(v0_1: Array<std::string::String>) -> std::string::String {
        let v2 = core::ops::Deref::deref(&v0_1);
        let v4 = &***&v2;
        let v5 = &***&v4;
        format!("{:?}", &v5).clone()
    }
    pub fn method9() -> string { string("$1=$2") }
    pub fn method10() -> string { string("[$1]") }
    pub fn method11() -> string { string("\"") }
    pub fn method12() -> string { string(" ") }
    pub fn method13() -> string { string("387957") }
    pub fn method14() -> string { string("385779") }
    pub fn method5(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string =
            Cli::method6(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String =
            Cli::method8(array(&[Cli::method3(string("timestamp")),
                                 Cli::method3(v9),
                                 Cli::method3(string("run_id")),
                                 Cli::method7(v11),
                                 Cli::method3(string("log_level")),
                                 Cli::method3(string("Debug"))]));
        let v26: Array<std::string::String> =
            array(&[Cli::method3(string("> app ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method2(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Cli::method9();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Cli::method2(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Cli::method10();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Cli::method2(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Cli::method11();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Cli::method2(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Cli::method12();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Cli::method2(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Cli::method9();
        let v106: &str = &v105.as_str();
        let v107: std::string::String =
            v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Cli::method2(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Cli::method10();
        let v117: &str = &v116.as_str();
        let v118: std::string::String =
            v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Cli::method2(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Cli::method11();
        let v128: &str = &v127.as_str();
        let v129: std::string::String =
            v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method2(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Cli::method12();
        let v139: &str = &v138.as_str();
        let v140: std::string::String =
            v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Cli::method2(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Cli::method9();
        let v153: &str = &v152.as_str();
        let v154: std::string::String =
            v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Cli::method2(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Cli::method10();
        let v164: &str = &v163.as_str();
        let v165: std::string::String =
            v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Cli::method2(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Cli::method11();
        let v175: &str = &v174.as_str();
        let v176: std::string::String =
            v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Cli::method2(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Cli::method12();
        let v186: &str = &v185.as_str();
        let v187: std::string::String =
            v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Cli::method13();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Cli::method13();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Cli::method13();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Cli::method14();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Cli::method14();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Cli::method14();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!("{0}",
                 stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245)));
        ()
    }
    pub fn method16() -> string { string("881749") }
    pub fn method15(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string =
            Cli::method6(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String =
            Cli::method8(array(&[Cli::method3(string("timestamp")),
                                 Cli::method3(v9),
                                 Cli::method3(string("run_id")),
                                 Cli::method7(v11),
                                 Cli::method3(string("log_level")),
                                 Cli::method3(string("Debug"))]));
        let v26: Array<std::string::String> =
            array(&[Cli::method3(string("> read_lines ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method2(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Cli::method9();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Cli::method2(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Cli::method10();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Cli::method2(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Cli::method11();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Cli::method2(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Cli::method12();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Cli::method2(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Cli::method9();
        let v106: &str = &v105.as_str();
        let v107: std::string::String =
            v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Cli::method2(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Cli::method10();
        let v117: &str = &v116.as_str();
        let v118: std::string::String =
            v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Cli::method2(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Cli::method11();
        let v128: &str = &v127.as_str();
        let v129: std::string::String =
            v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method2(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Cli::method12();
        let v139: &str = &v138.as_str();
        let v140: std::string::String =
            v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Cli::method2(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Cli::method9();
        let v153: &str = &v152.as_str();
        let v154: std::string::String =
            v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Cli::method2(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Cli::method10();
        let v164: &str = &v163.as_str();
        let v165: std::string::String =
            v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Cli::method2(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Cli::method11();
        let v175: &str = &v174.as_str();
        let v176: std::string::String =
            v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Cli::method2(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Cli::method12();
        let v186: &str = &v185.as_str();
        let v187: std::string::String =
            v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Cli::method16();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Cli::method16();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Cli::method16();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Cli::method14();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Cli::method14();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Cli::method14();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!("{0}",
                 stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245)));
        ()
    }
    pub fn method17(v0_1: std::string::String) -> std::string::String {
        (&v0_1).clone()
    }
    pub fn method19(v0_1: i32) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method20(v0_1: i64, v1: Array<std::string::String>) { (); }
    pub fn closure1(v0_1: i64, v1: Lrc<Cli::Mut0>, v2: Vec<u8>)
     -> Result<bool, std::io::Error> {
        Cli::method20(v0_1,
                      array(&[Cli::method3(string("line len")),
                              Cli::method19((&v2).len().try_into().unwrap())]));
        {
            let v10: Vec<u8> = v2.to_owned();
            let v12: std::string::String =
                std::string::String::from_utf8(v10).unwrap();
            let v13: Lrc<Cli::UH0> = v1.l0.get().clone();
            v1.l0.set(Lrc::new(Cli::UH0::UH0_0(v12.clone(), v13.clone())));
            Ok(true)
        }
    }
    pub fn method18(v0_1: i64, v1: Lrc<Cli::Mut0>)
     -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       move |v: Vec<u8>|
                           Cli::closure1(v0_1, v1.clone(), v.clone())
                   })
    }
    pub fn method21(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH0>) -> Lrc<Cli::UH0> {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v1.clone());
        '_method21:
            loop  {
                break '_method21
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH0> =
                                 Lrc::new(Cli::UH0::UH0_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method21
                         }
                     }) ;
            }
    }
    pub fn method22(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        match v0_1.as_ref() {
            Cli::UH0::UH0_1 => v1.clone(),
            Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                let v4: Lrc<Cli::UH1> = Cli::method22(v0_1_0_1.clone(), v1);
                Lrc::new(Cli::UH1::UH1_0(fable_library_rust::String_::fromStr(v0_1_0_0),
                                         v4))
            }
        }
    }
    pub fn method23(v0_1: Lrc<Cli::UH1>, v1: i32) -> i32 {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method23:
            loop  {
                break '_method23
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: i32 = v1.get() + 1i32;
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method23
                         }
                     }) ;
            }
    }
    pub fn method24(v0_1: i64, v1: Lrc<Cli::UH1>, v2: i32, v3: Lrc<Cli::UH1>)
     -> (i32, Lrc<Cli::UH1>) {
        let v0_1: MutCell<i64> = MutCell::new(v0_1);
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        let v2: MutCell<i32> = MutCell::new(v2);
        let v3: MutCell<Lrc<Cli::UH1>> = MutCell::new(v3.clone());
        '_method24:
            loop  {
                break '_method24
                    (match v1.get().as_ref() {
                         Cli::UH1::UH1_1 => (v2.get(), v3.get()),
                         Cli::UH1::UH1_0(v1_0_0, v1_0_1) => {
                             let v4: string = v1_0_0.clone();
                             let patternInput: (i32, Lrc<Cli::UH1>) =
                                 if if ((&v4).clone()).contains(&*(&string("/node_modules/")).clone())
                                       {
                                        ((&v4).clone()).contains(&*(&string(".cs")).clone())
                                    } else { false } {
                                     Cli::method5(v0_1.get(),
                                                  array(&[Cli::method3(string("found line. removing.")),
                                                          Cli::method3(string(" line")),
                                                          Cli::method3(v4.clone())]));
                                     (1i32, v3.get())
                                 } else {
                                     if 0i32 == v2.get() {
                                         (0i32,
                                          Lrc::new(Cli::UH1::UH1_0(v4,
                                                                   v3.get())))
                                     } else {
                                         if 2i32 == v2.get() {
                                             (0i32, v3.get())
                                         } else {
                                             (v2.get() + 1i32, v3.get())
                                         }
                                     }
                                 };
                             {
                                 let v0_1_temp: i64 = v0_1.get();
                                 let v1_temp: Lrc<Cli::UH1> = v1_0_1.clone();
                                 let v2_temp: i32 = patternInput.0.clone();
                                 let v3_temp: Lrc<Cli::UH1> =
                                     patternInput.1.clone();
                                 v0_1.set(v0_1_temp);
                                 v1.set(v1_temp);
                                 v2.set(v2_temp);
                                 v3.set(v3_temp);
                                 continue '_method24
                             }
                         }
                     }) ;
            }
    }
    pub fn method25(v0_1: Lrc<Cli::UH1>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        '_method25:
            loop  {
                break '_method25
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH1> =
                                 Lrc::new(Cli::UH1::UH1_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method25
                         }
                     }) ;
            }
    }
    pub fn method26(v0_1: Lrc<Cli::UH1>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method26:
            loop  {
                break '_method26
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: string =
                                 append(v1.get(), v0_1_0_0.clone());
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method26
                         }
                     }) ;
            }
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let patternInput: (string, string, string, bool) = Cli::method0();
        let v5: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v7: i64 = (&v5).timestamp();
        let v10: &str = r#"app1"#;
        let v11: string = string("clap::Command::new($0)");
        let v12: string = string(".propagate_version(true)");
        let v14: string = string(".subcommand_required(false)");
        let v16: string = string(".about(\"command about\")");
        let v18: string = string(".arg_required_else_help(true)");
        let v19: string =
            append(append(append(append(v11.clone(), v12.clone()),
                                 v14.clone()), v16.clone()), v18.clone());
        let v20: clap::builder::Command =
            clap::Command::new(&v10).propagate_version(true).subcommand_required(false).about("command about").arg_required_else_help(true);
        let v23: &str = r#"PostFsxRsBuild"#;
        let v27: string =
            append(append(append(append(v11.clone(), v12.clone()),
                                 v14.clone()), v16.clone()), v18.clone());
        let v28: clap::builder::Command =
            clap::Command::new(&v23).propagate_version(true).subcommand_required(false).about("command about").arg_required_else_help(true);
        let v31: &str = r#"rs-path"#;
        let v33: clap::builder::Arg = clap::Arg::new(&v31);
        let v35: clap::builder::Command = v28.arg(v33);
        let v37: clap::builder::Command = v20.subcommand(v35);
        let v40: &str = r#"SpiFsxBuild"#;
        let v44: string =
            append(append(append(append(v11, v12), v14), v16), v18);
        let v45: clap::builder::Command =
            clap::Command::new(&v40).propagate_version(true).subcommand_required(false).about("command about").arg_required_else_help(true);
        let v48: &str = r#"spi-path"#;
        let v49: clap::builder::Arg = clap::Arg::new(&v48);
        let v50: clap::builder::Command = v45.arg(v49);
        let v53: &str = r#"fsx-path"#;
        let v54: clap::builder::Arg = clap::Arg::new(&v53);
        let v55: clap::builder::Command = v50.arg(v54);
        let v56: clap::builder::Command = v37.subcommand(v55);
        let v58: &clap::parser::ArgMatches = &v56.get_matches();
        let v60: &Option<(&str, &clap::parser::ArgMatches)> =
            &v58.subcommand();
        let patternInput_1: (&str, &clap::parser::ArgMatches) =
            *((&v60).as_ref()).unwrap();
        let v64: string = Cli::method1();
        let v66: &str = &v64.as_str();
        let v68: string = Cli::method2(string("--rs-path="));
        let v69: &str = &v68.as_str();
        let v71: &std::string::String =
            &(patternInput_1.1.clone()).get_one::<String>(v66).unwrap().replace(v69, "");
        let v73: std::path::PathBuf = std::path::PathBuf::from(&v71);
        let v75: Result<std::path::PathBuf, std::io::Error> =
            (&v73).canonicalize();
        let v77: std::path::PathBuf = (&v75).as_ref().unwrap().to_path_buf();
        Cli::method5(v7,
                     array(&[Cli::method3(string("rs_path_clean")),
                             Cli::method4(v77.clone())]));
        {
            let patternInput_2: (string, string, string, bool) =
                Cli::method0();
            let v86: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v87: i64 = (&v86).timestamp();
            let v88: Result<std::path::PathBuf, std::io::Error> =
                (&v77).canonicalize();
            let v89: std::path::PathBuf =
                (&v88).as_ref().unwrap().to_path_buf();
            Cli::method15(v87,
                          array(&[Cli::method3(string("path_clean")),
                                  Cli::method3(fable_library_rust::String_::fromStr(&format!("{}", &v89.display())))]));
            {
                let v97: Result<std::fs::File, std::io::Error> =
                    std::fs::File::open(&v89);
                let v99: &std::fs::File = &v97.unwrap();
                let v101:
                        std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                    std::cell::RefCell::new(linereader::LineReader::new(&v99));
                Cli::method15(v87,
                              array(&[Cli::method3(string("reader")),
                                      Cli::method17(format!("{:?}", &v101))]));
                {
                    let v109: Lrc<Cli::Mut0> =
                        Lrc::new(Cli::Mut0{l0:
                                               MutCell::new(Lrc::new(Cli::UH0::UH0_1)),});
                    let v110 = Cli::method18(v87, v109.clone());
                    let v112: Result<(), std::io::Error> =
                        (v101).borrow_mut().for_each(move |x| v110(x.to_vec()));
                    *((&v112).as_ref()).unwrap();
                    {
                        let v117: Lrc<Cli::UH1> =
                            Cli::method22(Cli::method21(v109.l0.get().clone(),
                                                        Lrc::new(Cli::UH0::UH0_1)),
                                          Lrc::new(Cli::UH1::UH1_1));
                        Cli::method15(v87,
                                      array(&[Cli::method3(string("lines len")),
                                              Cli::method19(Cli::method23(v117.clone(),
                                                                          0i32))]));
                        {
                            let v131: string =
                                Cli::method26(Cli::method25((Cli::method24(v7,
                                                                           v117,
                                                                           0i32,
                                                                           Lrc::new(Cli::UH1::UH1_1))).1.clone(),
                                                            Lrc::new(Cli::UH1::UH1_1)),
                                              string(""));
                            Cli::method5(v7,
                                         array(&[Cli::method3(string("text len")),
                                                 Cli::method19((&v131).len().try_into().unwrap())]));
                            {
                                let v139: Result<(), std::io::Error> =
                                    std::fs::write(v77, v131.as_str());
                                *((&v139).as_ref()).unwrap();
                                Cli::method5(v7,
                                             array(&[Cli::method3(string("> fs_write rs_path_clean text; ok"))]));
                                0i32
                            }
                        }
                    }
                }
            }
        }
    }
    pub fn v0() -> Func0<i32> {
        static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        v0.get_or_init(move || Func0::new(move || Cli::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;
