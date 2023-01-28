#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Supervisor {
    use super::*;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Range_::rangeNumeric;
    use fable_library_rust::Seq_::toArray;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 {
        US0_0,
        US0_1,
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US1 {
        US1_0,
        US1_1(string),
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub struct Mut0 {
        pub l0: MutCell<i32>,
        pub l1: MutCell<Supervisor::US1>,
    }
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1(v0_1: string) -> std::string::String {
        (&v0_1).to_string().clone()
    }
    pub fn method3(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method3: loop {
            break '_method3 (if length(v1.get()) < v0_1.get() {
                let v0_1_temp: i32 = v0_1.get();
                let v1_temp: string = stringFrom(format!("0{0}", &v1.get()));
                v0_1.set(v0_1_temp);
                v1.set(v1_temp);
                continue '_method3;
            } else {
                v1.get()
            });
        }
    }
    pub fn method4(v0_1: u8) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method5(v0_1: Array<std::string::String>) -> std::string::String {
        let v2 = core::ops::Deref::deref(&v0_1);
        let v4 = &***&v2;
        let v5 = &***&v4;
        format!("{:?}", &v5).clone()
    }
    pub fn method6(v0_1: string) -> string {
        v0_1
    }
    pub fn method7() -> string {
        string("$1=$2")
    }
    pub fn method8() -> string {
        string("[$1]")
    }
    pub fn method9() -> string {
        string("\"")
    }
    pub fn method10() -> string {
        string(" ")
    }
    pub fn method11() -> string {
        string("de884c")
    }
    pub fn method12() -> string {
        string("385779")
    }
    pub fn method2(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Supervisor::method3(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Supervisor::method5(array(&[
            Supervisor::method1(string("timestamp")),
            Supervisor::method1(v9),
            Supervisor::method1(string("run_id")),
            Supervisor::method4(v11),
            Supervisor::method1(string("log_level")),
            Supervisor::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Supervisor::method1(string("> spi_to_fsx ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Supervisor::method6(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Supervisor::method7();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Supervisor::method6(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Supervisor::method8();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Supervisor::method6(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Supervisor::method9();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Supervisor::method6(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Supervisor::method10();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Supervisor::method6(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Supervisor::method7();
        let v102: &str = &v101.as_str();
        let v103: std::string::String = v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Supervisor::method6(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Supervisor::method8();
        let v112: &str = &v111.as_str();
        let v113: std::string::String = v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Supervisor::method6(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Supervisor::method9();
        let v122: &str = &v121.as_str();
        let v123: std::string::String = v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Supervisor::method6(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Supervisor::method10();
        let v132: &str = &v131.as_str();
        let v133: std::string::String = v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Supervisor::method6(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Supervisor::method7();
        let v145: &str = &v144.as_str();
        let v146: std::string::String = v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Supervisor::method6(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Supervisor::method8();
        let v155: &str = &v154.as_str();
        let v156: std::string::String = v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Supervisor::method6(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Supervisor::method9();
        let v165: &str = &v164.as_str();
        let v166: std::string::String = v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v176));
        if let Supervisor::US0::US0_1 = &if cfg!(target_arch = "wasm32") {
            Supervisor::US0::US0_1
        } else {
            Supervisor::US0::US0_0
        } {
            let v187: string = string(" %c");
            let v191: string = append(
                append(
                    append(append(toString(&v87), v187.clone()), toString(&v135)),
                    v187,
                ),
                toString(&v178),
            );
            let v199: Array<std::string::String> = array(&[
                (&v191).as_ref().to_string(),
                (&stringFrom(format!("color: #{0};", &string("de884c"))))
                    .as_ref()
                    .to_string(),
                (&string("color: #385779;")).as_ref().to_string(),
            ]);
            let v200 = core::ops::Deref::deref(&v199);
            let v203 = serde_wasm_bindgen::to_value(&*****&v200).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v203));
            ()
        } else {
            let v205: string = Supervisor::method11();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Supervisor::method11();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Supervisor::method11();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Supervisor::method12();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Supervisor::method12();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Supervisor::method12();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v252: colored::ColoredString =
                colored::Colorize::truecolor(&*v178.to_string(), v237, v244, v251);
            let v253: std::string::String = format!("{}", &v252);
            println!(
                "{0}",
                stringFrom(format!("{0} {1} {2}", &v87, &v230, &v253))
            );
            ()
        }
    }
    pub fn closure2(unitVar: (), v0_1: &std::path::Path) -> std::path::PathBuf {
        v0_1.join(string("package.spiproj").as_str())
    }
    pub fn closure3(unitVar: (), v0_1: &std::path::PathBuf) -> bool {
        std::path::Path::exists(&v0_1)
    }
    pub fn method13(v0_1: i32) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method15() -> string {
        string("e36a62")
    }
    pub fn method14(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Supervisor::method3(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Supervisor::method5(array(&[
            Supervisor::method1(string("timestamp")),
            Supervisor::method1(v9),
            Supervisor::method1(string("run_id")),
            Supervisor::method4(v11),
            Supervisor::method1(string("log_level")),
            Supervisor::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Supervisor::method1(string("> spiproj_open ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Supervisor::method6(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Supervisor::method7();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Supervisor::method6(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Supervisor::method8();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Supervisor::method6(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Supervisor::method9();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Supervisor::method6(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Supervisor::method10();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Supervisor::method6(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Supervisor::method7();
        let v102: &str = &v101.as_str();
        let v103: std::string::String = v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Supervisor::method6(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Supervisor::method8();
        let v112: &str = &v111.as_str();
        let v113: std::string::String = v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Supervisor::method6(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Supervisor::method9();
        let v122: &str = &v121.as_str();
        let v123: std::string::String = v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Supervisor::method6(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Supervisor::method10();
        let v132: &str = &v131.as_str();
        let v133: std::string::String = v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Supervisor::method6(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Supervisor::method7();
        let v145: &str = &v144.as_str();
        let v146: std::string::String = v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Supervisor::method6(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Supervisor::method8();
        let v155: &str = &v154.as_str();
        let v156: std::string::String = v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Supervisor::method6(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Supervisor::method9();
        let v165: &str = &v164.as_str();
        let v166: std::string::String = v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v176));
        if let Supervisor::US0::US0_1 = &if cfg!(target_arch = "wasm32") {
            Supervisor::US0::US0_1
        } else {
            Supervisor::US0::US0_0
        } {
            let v187: string = string(" %c");
            let v191: string = append(
                append(
                    append(append(toString(&v87), v187.clone()), toString(&v135)),
                    v187,
                ),
                toString(&v178),
            );
            let v199: Array<std::string::String> = array(&[
                (&v191).as_ref().to_string(),
                (&stringFrom(format!("color: #{0};", &string("e36a62"))))
                    .as_ref()
                    .to_string(),
                (&string("color: #385779;")).as_ref().to_string(),
            ]);
            let v200 = core::ops::Deref::deref(&v199);
            let v203 = serde_wasm_bindgen::to_value(&*****&v200).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v203));
            ()
        } else {
            let v205: string = Supervisor::method15();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Supervisor::method15();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Supervisor::method15();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Supervisor::method12();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Supervisor::method12();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Supervisor::method12();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v252: colored::ColoredString =
                colored::Colorize::truecolor(&*v178.to_string(), v237, v244, v251);
            let v253: std::string::String = format!("{}", &v252);
            println!(
                "{0}",
                stringFrom(format!("{0} {1} {2}", &v87, &v230, &v253))
            );
            ()
        }
    }
    pub fn method17() -> string {
        string("fcfb1b")
    }
    pub fn method16(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Supervisor::method3(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Supervisor::method5(array(&[
            Supervisor::method1(string("timestamp")),
            Supervisor::method1(v9),
            Supervisor::method1(string("run_id")),
            Supervisor::method4(v11),
            Supervisor::method1(string("log_level")),
            Supervisor::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Supervisor::method1(string("> zmq_request ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Supervisor::method6(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Supervisor::method7();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Supervisor::method6(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Supervisor::method8();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Supervisor::method6(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Supervisor::method9();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Supervisor::method6(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Supervisor::method10();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Supervisor::method6(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Supervisor::method7();
        let v102: &str = &v101.as_str();
        let v103: std::string::String = v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Supervisor::method6(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Supervisor::method8();
        let v112: &str = &v111.as_str();
        let v113: std::string::String = v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Supervisor::method6(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Supervisor::method9();
        let v122: &str = &v121.as_str();
        let v123: std::string::String = v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Supervisor::method6(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Supervisor::method10();
        let v132: &str = &v131.as_str();
        let v133: std::string::String = v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Supervisor::method6(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Supervisor::method7();
        let v145: &str = &v144.as_str();
        let v146: std::string::String = v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Supervisor::method6(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Supervisor::method8();
        let v155: &str = &v154.as_str();
        let v156: std::string::String = v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Supervisor::method6(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Supervisor::method9();
        let v165: &str = &v164.as_str();
        let v166: std::string::String = v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v176));
        if let Supervisor::US0::US0_1 = &if cfg!(target_arch = "wasm32") {
            Supervisor::US0::US0_1
        } else {
            Supervisor::US0::US0_0
        } {
            let v187: string = string(" %c");
            let v191: string = append(
                append(
                    append(append(toString(&v87), v187.clone()), toString(&v135)),
                    v187,
                ),
                toString(&v178),
            );
            let v199: Array<std::string::String> = array(&[
                (&v191).as_ref().to_string(),
                (&stringFrom(format!("color: #{0};", &string("fcfb1b"))))
                    .as_ref()
                    .to_string(),
                (&string("color: #385779;")).as_ref().to_string(),
            ]);
            let v200 = core::ops::Deref::deref(&v199);
            let v203 = serde_wasm_bindgen::to_value(&*****&v200).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v203));
            ()
        } else {
            let v205: string = Supervisor::method17();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Supervisor::method17();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Supervisor::method17();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Supervisor::method12();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Supervisor::method12();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Supervisor::method12();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v252: colored::ColoredString =
                colored::Colorize::truecolor(&*v178.to_string(), v237, v244, v251);
            let v253: std::string::String = format!("{}", &v252);
            println!(
                "{0}",
                stringFrom(format!("{0} {1} {2}", &v87, &v230, &v253))
            );
            ()
        }
    }
    pub fn method19() -> string {
        string("98d5ef")
    }
    pub fn method18(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Supervisor::method3(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Supervisor::method5(array(&[
            Supervisor::method1(string("timestamp")),
            Supervisor::method1(v9),
            Supervisor::method1(string("run_id")),
            Supervisor::method4(v11),
            Supervisor::method1(string("log_level")),
            Supervisor::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Supervisor::method1(string("> spi_build_file ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Supervisor::method6(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Supervisor::method7();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Supervisor::method6(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Supervisor::method8();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Supervisor::method6(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Supervisor::method9();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Supervisor::method6(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Supervisor::method10();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Supervisor::method6(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Supervisor::method7();
        let v102: &str = &v101.as_str();
        let v103: std::string::String = v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Supervisor::method6(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Supervisor::method8();
        let v112: &str = &v111.as_str();
        let v113: std::string::String = v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Supervisor::method6(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Supervisor::method9();
        let v122: &str = &v121.as_str();
        let v123: std::string::String = v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Supervisor::method6(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Supervisor::method10();
        let v132: &str = &v131.as_str();
        let v133: std::string::String = v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Supervisor::method6(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Supervisor::method7();
        let v145: &str = &v144.as_str();
        let v146: std::string::String = v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Supervisor::method6(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Supervisor::method8();
        let v155: &str = &v154.as_str();
        let v156: std::string::String = v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Supervisor::method6(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Supervisor::method9();
        let v165: &str = &v164.as_str();
        let v166: std::string::String = v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v176));
        if let Supervisor::US0::US0_1 = &if cfg!(target_arch = "wasm32") {
            Supervisor::US0::US0_1
        } else {
            Supervisor::US0::US0_0
        } {
            let v187: string = string(" %c");
            let v191: string = append(
                append(
                    append(append(toString(&v87), v187.clone()), toString(&v135)),
                    v187,
                ),
                toString(&v178),
            );
            let v199: Array<std::string::String> = array(&[
                (&v191).as_ref().to_string(),
                (&stringFrom(format!("color: #{0};", &string("98d5ef"))))
                    .as_ref()
                    .to_string(),
                (&string("color: #385779;")).as_ref().to_string(),
            ]);
            let v200 = core::ops::Deref::deref(&v199);
            let v203 = serde_wasm_bindgen::to_value(&*****&v200).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v203));
            ()
        } else {
            let v205: string = Supervisor::method19();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Supervisor::method19();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Supervisor::method19();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Supervisor::method12();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Supervisor::method12();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Supervisor::method12();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v252: colored::ColoredString =
                colored::Colorize::truecolor(&*v178.to_string(), v237, v244, v251);
            let v253: std::string::String = format!("{}", &v252);
            println!(
                "{0}",
                stringFrom(format!("{0} {1} {2}", &v87, &v230, &v253))
            );
            ()
        }
    }
    pub fn method20(v0_1: std::time::SystemTime) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method22() -> string {
        string("387957")
    }
    pub fn method21(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Supervisor::method3(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Supervisor::method5(array(&[
            Supervisor::method1(string("timestamp")),
            Supervisor::method1(v9),
            Supervisor::method1(string("run_id")),
            Supervisor::method4(v11),
            Supervisor::method1(string("log_level")),
            Supervisor::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Supervisor::method1(string("> wait_file_change ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Supervisor::method6(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Supervisor::method7();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Supervisor::method6(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Supervisor::method8();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Supervisor::method6(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Supervisor::method9();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Supervisor::method6(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Supervisor::method10();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Supervisor::method6(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Supervisor::method7();
        let v102: &str = &v101.as_str();
        let v103: std::string::String = v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Supervisor::method6(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Supervisor::method8();
        let v112: &str = &v111.as_str();
        let v113: std::string::String = v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Supervisor::method6(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Supervisor::method9();
        let v122: &str = &v121.as_str();
        let v123: std::string::String = v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Supervisor::method6(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Supervisor::method10();
        let v132: &str = &v131.as_str();
        let v133: std::string::String = v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Supervisor::method6(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Supervisor::method7();
        let v145: &str = &v144.as_str();
        let v146: std::string::String = v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Supervisor::method6(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Supervisor::method8();
        let v155: &str = &v154.as_str();
        let v156: std::string::String = v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Supervisor::method6(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Supervisor::method9();
        let v165: &str = &v164.as_str();
        let v166: std::string::String = v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v176));
        if let Supervisor::US0::US0_1 = &if cfg!(target_arch = "wasm32") {
            Supervisor::US0::US0_1
        } else {
            Supervisor::US0::US0_0
        } {
            let v187: string = string(" %c");
            let v191: string = append(
                append(
                    append(append(toString(&v87), v187.clone()), toString(&v135)),
                    v187,
                ),
                toString(&v178),
            );
            let v199: Array<std::string::String> = array(&[
                (&v191).as_ref().to_string(),
                (&stringFrom(format!("color: #{0};", &string("387957"))))
                    .as_ref()
                    .to_string(),
                (&string("color: #385779;")).as_ref().to_string(),
            ]);
            let v200 = core::ops::Deref::deref(&v199);
            let v203 = serde_wasm_bindgen::to_value(&*****&v200).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v203));
            ()
        } else {
            let v205: string = Supervisor::method22();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Supervisor::method22();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Supervisor::method22();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Supervisor::method12();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Supervisor::method12();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Supervisor::method12();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v252: colored::ColoredString =
                colored::Colorize::truecolor(&*v178.to_string(), v237, v244, v251);
            let v253: std::string::String = format!("{}", &v252);
            println!(
                "{0}",
                stringFrom(format!("{0} {1} {2}", &v87, &v230, &v253))
            );
            ()
        }
    }
    pub fn method23(v0_1: i32, v1: Lrc<Supervisor::Mut0>) -> bool {
        v1.l0.get() < v0_1
    }
    pub fn closure1(v0_1: std::path::PathBuf, v1: Option<std::path::PathBuf>) -> string {
        let patternInput: (string, string, string, bool) = Supervisor::method0();
        let v7: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: i64 = (&v7).timestamp();
        let v11: std::string::String = Supervisor::method1(string("pwd"));
        let v13: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
        let v15: std::path::PathBuf = (&v13).as_ref().unwrap().to_path_buf();
        let v17: Result<std::path::PathBuf, std::io::Error> = (&v15).canonicalize();
        let v18: std::path::PathBuf = (&v17).as_ref().unwrap().to_path_buf();
        let v21: std::string::String = Supervisor::method1(fable_library_rust::String_::fromStr(
            &format!("{}", &v18.display()),
        ));
        let v22: string = string("spi_path");
        let v23: std::string::String = Supervisor::method1(v22.clone());
        let v25: std::string::String = Supervisor::method1(fable_library_rust::String_::fromStr(
            &format!("{}", &v0_1.display()),
        ));
        let v27: std::string::String = Supervisor::method1(string("new_fsx_path"));
        let v28: std::path::PathBuf = (&v1).as_ref().unwrap().to_path_buf();
        Supervisor::method2(
            v9,
            array(&[
                v11,
                v21,
                v23,
                v25,
                v27,
                Supervisor::method1(fable_library_rust::String_::fromStr(&format!(
                    "{}",
                    &v28.display()
                ))),
            ]),
        );
        {
            let v32: Result<std::path::PathBuf, std::io::Error> = (&v0_1).canonicalize();
            let v33: std::path::PathBuf = (&v32).as_ref().unwrap().to_path_buf();
            Supervisor::method2(
                v9,
                array(&[
                    Supervisor::method1(string("spi_path_clean")),
                    Supervisor::method1(fable_library_rust::String_::fromStr(&format!(
                        "{}",
                        &v33.display()
                    ))),
                ]),
            );
            {
                let v40: Option<&std::path::Path> = (&v33).parent();
                let v42: &std::path::Path = &v40.unwrap();
                let v44: std::path::PathBuf = std::path::PathBuf::from(&v42);
                let v45: Result<std::path::PathBuf, std::io::Error> = (&v44).canonicalize();
                let v46: std::path::PathBuf = (&v45).as_ref().unwrap().to_path_buf();
                Supervisor::method2(
                    v9,
                    array(&[
                        Supervisor::method1(string("src_path")),
                        Supervisor::method1(fable_library_rust::String_::fromStr(&format!(
                            "{}",
                            &v46.display()
                        ))),
                    ]),
                );
                {
                    let v53: &std::path::Ancestors = &v46.ancestors();
                    let v56: _ = v53.take(10i32 as usize);
                    fn v57(v: &std::path::Path) -> std::path::PathBuf {
                        Supervisor::closure2((), v)
                    }
                    let v60: _ = v56.into_iter().map((&v57).clone());
                    fn v61(v_1: &std::path::PathBuf) -> bool {
                        Supervisor::closure3((), v_1)
                    }
                    let v64: Option<std::path::PathBuf> = v60.into_iter().find((&v61).clone());
                    let v65: std::path::PathBuf = (&v64).as_ref().unwrap().to_path_buf();
                    let v66: string = string("spiproj_path");
                    Supervisor::method2(
                        v9,
                        array(&[
                            Supervisor::method1(v66.clone()),
                            Supervisor::method1(fable_library_rust::String_::fromStr(&format!(
                                "{}",
                                &v65.display()
                            ))),
                        ]),
                    );
                    {
                        let v72: Option<&str> = (&v33).to_str();
                        let v73: &str = &v72.unwrap();
                        let v76: string = string(".spi");
                        let v79: &str = &v73.replace(&*(&string(".spir")).clone(), &(&v76).clone());
                        let v83: &str = &v79.replace(&*(&v76).clone(), &(&string(".fsx")).clone());
                        let v84: std::path::PathBuf = std::path::PathBuf::from(&v83);
                        let v85: Result<std::path::PathBuf, std::io::Error> = (&v84).canonicalize();
                        let v86: std::path::PathBuf = (&v85).as_ref().unwrap().to_path_buf();
                        let v87: string = string("fsx_path");
                        Supervisor::method2(
                            v9,
                            array(&[
                                Supervisor::method1(v87.clone()),
                                Supervisor::method1(fable_library_rust::String_::fromStr(
                                    &format!("{}", &v86.display()),
                                )),
                            ]),
                        );
                        {
                            let v92: string = string("");
                            let v94: Result<(), std::io::Error> =
                                std::fs::write(v86.clone(), v92.clone().as_str());
                            *((&v94).as_ref()).unwrap();
                            Supervisor::method2(
                                v9,
                                array(&[Supervisor::method1(string(
                                    "> fs_write fsx_path \"\"; ok",
                                ))]),
                            );
                            {
                                let v100: Result<std::string::String, std::io::Error> =
                                    std::fs::read_to_string(&v65);
                                let v102: std::string::String =
                                    (&v100).as_ref().unwrap().to_string();
                                let patternInput_1: (string, string, string, bool) =
                                    Supervisor::method0();
                                let v107: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                                let v108: i64 = (&v107).timestamp();
                                Supervisor::method14(
                                    v108,
                                    array(&[
                                        Supervisor::method1(v66),
                                        Supervisor::method1(fable_library_rust::String_::fromStr(
                                            &format!("{}", &v65.display()),
                                        )),
                                        Supervisor::method1(string("spiproj_text len")),
                                        Supervisor::method13((&v102).len().try_into().unwrap()),
                                    ]),
                                );
                                {
                                    let v118: string = string("{");
                                    let v121: string = string("\"uri\": $0,");
                                    let v125: string = string("}");
                                    let v128: string = string("serde_json::json!(");
                                    let v130: string = string(").to_string()");
                                    let v131: string = append(
                                        append(
                                            v128.clone(),
                                            append(
                                                append(
                                                    append(
                                                        append(
                                                            append(
                                                                v118.clone(),
                                                                string("\"ProjectFileOpen\": {"),
                                                            ),
                                                            v121.clone(),
                                                        ),
                                                        string("\"spiprojText\": $1"),
                                                    ),
                                                    v125.clone(),
                                                ),
                                                v125.clone(),
                                            ),
                                        ),
                                        v130.clone(),
                                    );
                                    let v132: std::string::String =
                                        serde_json::json!({"ProjectFileOpen": {"uri": v65,"spiprojText": v102}}).to_string();
                                    Supervisor::method14(
                                        v108,
                                        array(&[
                                            Supervisor::method1(string("json len=")),
                                            Supervisor::method13((&v132).len().try_into().unwrap()),
                                        ]),
                                    );
                                    {
                                        let patternInput_2: (string, string, string, bool) =
                                            Supervisor::method0();
                                        let v142: chrono::DateTime<chrono::Utc> =
                                            chrono::Utc::now();
                                        let v143: i64 = (&v142).timestamp();
                                        let v144: string = string("host");
                                        let v146: string = string("localhost");
                                        let v148: string = string("port");
                                        let v152: string = string("msg len");
                                        Supervisor::method16(
                                            v143,
                                            array(&[
                                                Supervisor::method1(v144.clone()),
                                                Supervisor::method1(v146.clone()),
                                                Supervisor::method1(v148.clone()),
                                                Supervisor::method13(13805i32),
                                                Supervisor::method1(v152.clone()),
                                                Supervisor::method13(
                                                    (&v132).len().try_into().unwrap(),
                                                ),
                                            ]),
                                        );
                                        {
                                            let v158 = zmq::Context::new();
                                            let v160 = v158.socket(zmq::REQ).unwrap();
                                            let v161: string = stringFrom(format!(
                                                "tcp://{0}:{1}",
                                                &v146, &13805i32
                                            ));
                                            v160.connect(&v161.clone()).unwrap();
                                            v160.send(v132.as_str(), 0).unwrap();
                                            {
                                                let v165: std::string::String =
                                                    v160.recv_string(0).unwrap().unwrap();
                                                v160.disconnect(&v161).unwrap();
                                                {
                                                    let v167: string = string("result len");
                                                    Supervisor::method16(
                                                        v143,
                                                        array(&[
                                                            Supervisor::method1(v167.clone()),
                                                            Supervisor::method13(
                                                                (&v165).len().try_into().unwrap(),
                                                            ),
                                                        ]),
                                                    );
                                                    Supervisor::method2(
                                                        v9,
                                                        array(&[Supervisor::method1(string(
                                                            "> spiproj_open; ok",
                                                        ))]),
                                                    );
                                                    {
                                                        let patternInput_3: (
                                                            string,
                                                            string,
                                                            string,
                                                            bool,
                                                        ) = Supervisor::method0();
                                                        let v179: chrono::DateTime<chrono::Utc> =
                                                            chrono::Utc::now();
                                                        let v180: i64 = (&v179).timestamp();
                                                        let v186: string = string("Fsharp");
                                                        Supervisor::method18(v180,
                                                                             array(&[Supervisor::method1(v22),
                                                                                     Supervisor::method1(fable_library_rust::String_::fromStr(&format!("{}", &v33.display()))),
                                                                                     Supervisor::method1(string("backend")),
                                                                                     Supervisor::method1(v186.clone())]));
                                                        {
                                                            let v190: std::string::String =
                                                                (&v186).to_string();
                                                            let v199: string =
                                                                append(append(v128,
                                                                              append(append(append(append(append(v118,
                                                                                                                 string("\"BuildFile\": {")),
                                                                                                          v121),
                                                                                                   string("\"backend\": $1")),
                                                                                            v125.clone()),
                                                                                     v125)),
                                                                       v130);
                                                            let v200:
                                                                    std::string::String =
                                                                serde_json::json!({"BuildFile": {"uri": v33,"backend": v190}}).to_string();
                                                            Supervisor::method18(
                                                                v180,
                                                                array(&[
                                                                    Supervisor::method1(string(
                                                                        "json len",
                                                                    )),
                                                                    Supervisor::method13(
                                                                        (&v200)
                                                                            .len()
                                                                            .try_into()
                                                                            .unwrap(),
                                                                    ),
                                                                ]),
                                                            );
                                                            {
                                                                let patternInput_4: (
                                                                    string,
                                                                    string,
                                                                    string,
                                                                    bool,
                                                                ) = Supervisor::method0();
                                                                let v210: chrono::DateTime<
                                                                    chrono::Utc,
                                                                > = chrono::Utc::now();
                                                                let v211: i64 = (&v210).timestamp();
                                                                Supervisor::method16(
                                                                    v211,
                                                                    array(&[
                                                                        Supervisor::method1(v144),
                                                                        Supervisor::method1(
                                                                            v146.clone(),
                                                                        ),
                                                                        Supervisor::method1(v148),
                                                                        Supervisor::method13(
                                                                            13805i32,
                                                                        ),
                                                                        Supervisor::method1(v152),
                                                                        Supervisor::method13(
                                                                            (&v200)
                                                                                .len()
                                                                                .try_into()
                                                                                .unwrap(),
                                                                        ),
                                                                    ]),
                                                                );
                                                                {
                                                                    let v221 = zmq::Context::new();
                                                                    let v222 = v221
                                                                        .socket(zmq::REQ)
                                                                        .unwrap();
                                                                    let v223: string =
                                                                        stringFrom(format!(
                                                                            "tcp://{0}:{1}",
                                                                            &v146, &13805i32
                                                                        ));
                                                                    v222.connect(&v223.clone())
                                                                        .unwrap();
                                                                    v222.send(v200.as_str(), 0)
                                                                        .unwrap();
                                                                    {
                                                                        let v225:
                                                                                std::string::String =
                                                                            v222.recv_string(0).unwrap().unwrap();
                                                                        v222.disconnect(&v223)
                                                                            .unwrap();
                                                                        Supervisor::method16(v211,
                                                                                             array(&[Supervisor::method1(v167),
                                                                                                     Supervisor::method13((&v225).len().try_into().unwrap())]));
                                                                        Supervisor::method2(v9,
                                                                                            array(&[Supervisor::method1(string("> spi_build_file; ok"))]));
                                                                        {
                                                                            let patternInput_5: (
                                                                                string,
                                                                                string,
                                                                                string,
                                                                                bool,
                                                                            ) = Supervisor::method0(
                                                                            );
                                                                            let v237:
                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                chrono::Utc::now();
                                                                            let v238: i64 =
                                                                                (&v237).timestamp();
                                                                            let v240:
                                                                                    std::time::SystemTime =
                                                                                std::fs::metadata(&v86).unwrap().modified().unwrap();
                                                                            Supervisor::method21(v238,
                                                                                                 array(&[Supervisor::method1(v87),
                                                                                                         Supervisor::method1(fable_library_rust::String_::fromStr(&format!("{}", &v86.display()))),
                                                                                                         Supervisor::method1(string("start")),
                                                                                                         Supervisor::method20(v240.clone())]));
                                                                            {
                                                                                let v248: Array<
                                                                                    i32,
                                                                                > = toArray(
                                                                                    rangeNumeric(
                                                                                        0i32, 1i32,
                                                                                        50i32,
                                                                                    )
                                                                                    .clone(),
                                                                                );
                                                                                let v249: i32 = v248
                                                                                    .len()
                                                                                    as i32;
                                                                                let v251:
                                                                                        Lrc<Supervisor::Mut0> =
                                                                                    Lrc::new(Supervisor::Mut0{l0:
                                                                                                                  MutCell::new(0i32),
                                                                                                              l1:
                                                                                                                  MutCell::new(Supervisor::US1::US1_0),});
                                                                                while Supervisor::method23(v249,
                                                                                                           v251.clone())
                                                                                      {
                                                                                    let v253:
                                                                                            i32 =
                                                                                        v251.l0.get();
                                                                                    let v254:
                                                                                            Supervisor::US1 =
                                                                                        v251.l1.get().clone();
                                                                                    let v255:
                                                                                            i32 =
                                                                                        v248[v253].clone();
                                                                                    let v277:
                                                                                            Supervisor::US1 =
                                                                                        match &v254
                                                                                            {
                                                                                            Supervisor::US1::US1_1(v254_1_0)
                                                                                            =>
                                                                                            Supervisor::US1::US1_1(v254_1_0.clone()),
                                                                                            _
                                                                                            =>
                                                                                            {
                                                                                                let v258:
                                                                                                        std::time::SystemTime =
                                                                                                    std::fs::metadata(&v86).unwrap().modified().unwrap();
                                                                                                Supervisor::method21(v238,
                                                                                                                     array(&[Supervisor::method1(string("i")),
                                                                                                                             Supervisor::method13(v255),
                                                                                                                             Supervisor::method1(string("last_modified")),
                                                                                                                             Supervisor::method20(v258.clone())]));
                                                                                                if v258 > v240
                                                                                                   {
                                                                                                    let v268:
                                                                                                            Result<std::string::String,
                                                                                                                   std::io::Error> =
                                                                                                        std::fs::read_to_string(&v86);
                                                                                                    let v269:
                                                                                                            std::string::String =
                                                                                                        (&v268).as_ref().unwrap().to_string();
                                                                                                    Supervisor::US1::US1_1(fable_library_rust::String_::fromStr(&v269))
                                                                                                } else {
                                                                                                    std::thread::sleep(std::time::Duration::from_millis(*&25u64));
                                                                                                    Supervisor::US1::US1_0
                                                                                                }
                                                                                            }
                                                                                        };
                                                                                    let v278:
                                                                                            i32 =
                                                                                        v253
                                                                                            +
                                                                                            1i32;
                                                                                    v251.l0.set(v278);
                                                                                    v251.l1.set(v277.clone());
                                                                                    ()
                                                                                }
                                                                                {
                                                                                    let v279:
                                                                                            Supervisor::US1 =
                                                                                        v251.l1.get().clone();
                                                                                    let v282:
                                                                                            string =
                                                                                        match &v279
                                                                                            {
                                                                                            Supervisor::US1::US1_1(v279_1_0)
                                                                                            =>
                                                                                            v279_1_0.clone(),
                                                                                            _
                                                                                            =>
                                                                                            v92,
                                                                                        };
                                                                                    Supervisor::method2(v9,
                                                                                                        array(&[Supervisor::method1(string("new_fsx len")),
                                                                                                                Supervisor::method13((&v282).len().try_into().unwrap())]));
                                                                                    {
                                                                                        let v288:
                                                                                                std::path::PathBuf =
                                                                                            defaultValue(v86,
                                                                                                         v1);
                                                                                        let v289:
                                                                                                Result<(),
                                                                                                       std::io::Error> =
                                                                                            std::fs::write(v288, v282.clone().as_str());
                                                                                        *((&v289)
                                                                                            .as_ref(
                                                                                            ))
                                                                                        .unwrap();
                                                                                        Supervisor::method2(v9,
                                                                                                            array(&[Supervisor::method1(string("> fs_write new_fsx_path; ok"))]));
                                                                                        v282
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    pub fn closure0(
        unitVar: (),
        v0_1: std::path::PathBuf,
    ) -> Func1<Option<std::path::PathBuf>, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Option<std::path::PathBuf>| Supervisor::closure1(v0_1.clone(), v.clone())
        })
    }
    pub fn v0() -> Func1<std::path::PathBuf, Func1<Option<std::path::PathBuf>, string>> {
        static v0: MutCell<
            Option<Func1<std::path::PathBuf, Func1<Option<std::path::PathBuf>, string>>>,
        > = MutCell::new(None);
        v0.get_or_init(move || {
            Func1::new(move |v: std::path::PathBuf| Supervisor::closure0((), v.clone()))
        })
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;
