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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 { US0_0, US0_1, }
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
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Cli::method2(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Cli::method10();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Cli::method2(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Cli::method11();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Cli::method2(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Cli::method12();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Cli::method2(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Cli::method9();
        let v102: &str = &v101.as_str();
        let v103: std::string::String =
            v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Cli::method2(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Cli::method10();
        let v112: &str = &v111.as_str();
        let v113: std::string::String =
            v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Cli::method2(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Cli::method11();
        let v122: &str = &v121.as_str();
        let v123: std::string::String =
            v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Cli::method2(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Cli::method12();
        let v132: &str = &v131.as_str();
        let v133: std::string::String =
            v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Cli::method2(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Cli::method9();
        let v145: &str = &v144.as_str();
        let v146: std::string::String =
            v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Cli::method2(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Cli::method10();
        let v155: &str = &v154.as_str();
        let v156: std::string::String =
            v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Cli::method2(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Cli::method11();
        let v165: &str = &v164.as_str();
        let v166: std::string::String =
            v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Cli::method2(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Cli::method12();
        let v175: &str = &v174.as_str();
        let v176: std::string::String =
            v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v176));
        if let Cli::US0::US0_1 =
               &if cfg!(target_arch = "wasm32") {
                    Cli::US0::US0_1
                } else { Cli::US0::US0_0 } {
            let v187: string = string(" %c");
            let v191: string =
                append(append(append(append(toString(&v87), v187.clone()),
                                     toString(&v135)), v187),
                       toString(&v178));
            let v199: Array<std::string::String> =
                array(&[(&v191).as_ref().to_string(),
                        (&stringFrom(format!("color: #{0};",
                                             &string("387957")))).as_ref().to_string(),
                        (&string("color: #385779;")).as_ref().to_string()]);
            let v200 = core::ops::Deref::deref(&v199);
            let v203 = serde_wasm_bindgen::to_value(&*****&v200).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v203));
            ()
        } else {
            let v205: string = Cli::method13();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Cli::method13();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Cli::method13();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Cli::method14();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Cli::method14();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Cli::method14();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v252: colored::ColoredString =
                colored::Colorize::truecolor(&*v178.to_string(), v237, v244, v251);
            let v253: std::string::String = format!("{}", &v252);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v87, &v230, &v253)));
            ()
        }
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
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Cli::method2(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Cli::method10();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Cli::method2(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Cli::method11();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Cli::method2(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Cli::method12();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Cli::method2(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Cli::method9();
        let v102: &str = &v101.as_str();
        let v103: std::string::String =
            v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Cli::method2(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Cli::method10();
        let v112: &str = &v111.as_str();
        let v113: std::string::String =
            v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Cli::method2(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Cli::method11();
        let v122: &str = &v121.as_str();
        let v123: std::string::String =
            v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Cli::method2(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Cli::method12();
        let v132: &str = &v131.as_str();
        let v133: std::string::String =
            v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Cli::method2(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Cli::method9();
        let v145: &str = &v144.as_str();
        let v146: std::string::String =
            v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Cli::method2(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Cli::method10();
        let v155: &str = &v154.as_str();
        let v156: std::string::String =
            v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Cli::method2(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Cli::method11();
        let v165: &str = &v164.as_str();
        let v166: std::string::String =
            v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Cli::method2(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Cli::method12();
        let v175: &str = &v174.as_str();
        let v176: std::string::String =
            v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Cli::method3(fable_library_rust::String_::fromStr(&v176));
        if let Cli::US0::US0_1 =
               &if cfg!(target_arch = "wasm32") {
                    Cli::US0::US0_1
                } else { Cli::US0::US0_0 } {
            let v187: string = string(" %c");
            let v191: string =
                append(append(append(append(toString(&v87), v187.clone()),
                                     toString(&v135)), v187),
                       toString(&v178));
            let v199: Array<std::string::String> =
                array(&[(&v191).as_ref().to_string(),
                        (&stringFrom(format!("color: #{0};",
                                             &string("881749")))).as_ref().to_string(),
                        (&string("color: #385779;")).as_ref().to_string()]);
            let v200 = core::ops::Deref::deref(&v199);
            let v203 = serde_wasm_bindgen::to_value(&*****&v200).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v203));
            ()
        } else {
            let v205: string = Cli::method16();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Cli::method16();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Cli::method16();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Cli::method14();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Cli::method14();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Cli::method14();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v252: colored::ColoredString =
                colored::Colorize::truecolor(&*v178.to_string(), v237, v244, v251);
            let v253: std::string::String = format!("{}", &v252);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v87, &v230, &v253)));
            ()
        }
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
            let v10: std::string::String =
                std::string::String::from_utf8((&v2).to_owned()).unwrap();
            let v11: Lrc<Cli::UH0> = v1.l0.get().clone();
            v1.l0.set(Lrc::new(Cli::UH0::UH0_0(v10.clone(), v11.clone())));
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
                                 if ((&v4).clone()).contains(&*(&string("/node_modules/")).clone())
                                    {
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
