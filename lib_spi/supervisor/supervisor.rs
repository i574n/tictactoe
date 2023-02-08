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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 {
        US0_0,
        US0_1(string),
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub struct Mut0 {
        pub l0: MutCell<i32>,
        pub l1: MutCell<Supervisor::US0>,
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
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Supervisor::method6(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Supervisor::method8();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Supervisor::method6(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Supervisor::method9();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Supervisor::method6(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Supervisor::method10();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Supervisor::method6(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Supervisor::method7();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Supervisor::method6(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Supervisor::method8();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Supervisor::method6(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Supervisor::method9();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Supervisor::method6(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Supervisor::method10();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Supervisor::method6(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Supervisor::method7();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Supervisor::method6(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Supervisor::method8();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method9();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Supervisor::method6(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Supervisor::method10();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Supervisor::method11();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Supervisor::method11();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Supervisor::method11();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Supervisor::method12();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Supervisor::method12();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Supervisor::method12();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245))
        );
        ()
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
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Supervisor::method6(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Supervisor::method8();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Supervisor::method6(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Supervisor::method9();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Supervisor::method6(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Supervisor::method10();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Supervisor::method6(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Supervisor::method7();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Supervisor::method6(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Supervisor::method8();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Supervisor::method6(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Supervisor::method9();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Supervisor::method6(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Supervisor::method10();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Supervisor::method6(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Supervisor::method7();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Supervisor::method6(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Supervisor::method8();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method9();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Supervisor::method6(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Supervisor::method10();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Supervisor::method15();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Supervisor::method15();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Supervisor::method15();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Supervisor::method12();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Supervisor::method12();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Supervisor::method12();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245))
        );
        ()
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
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Supervisor::method6(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Supervisor::method8();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Supervisor::method6(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Supervisor::method9();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Supervisor::method6(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Supervisor::method10();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Supervisor::method6(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Supervisor::method7();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Supervisor::method6(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Supervisor::method8();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Supervisor::method6(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Supervisor::method9();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Supervisor::method6(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Supervisor::method10();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Supervisor::method6(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Supervisor::method7();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Supervisor::method6(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Supervisor::method8();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method9();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Supervisor::method6(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Supervisor::method10();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Supervisor::method17();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Supervisor::method17();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Supervisor::method17();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Supervisor::method12();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Supervisor::method12();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Supervisor::method12();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245))
        );
        ()
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
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Supervisor::method6(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Supervisor::method8();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Supervisor::method6(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Supervisor::method9();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Supervisor::method6(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Supervisor::method10();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Supervisor::method6(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Supervisor::method7();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Supervisor::method6(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Supervisor::method8();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Supervisor::method6(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Supervisor::method9();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Supervisor::method6(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Supervisor::method10();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Supervisor::method6(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Supervisor::method7();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Supervisor::method6(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Supervisor::method8();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method9();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Supervisor::method6(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Supervisor::method10();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Supervisor::method19();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Supervisor::method19();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Supervisor::method19();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Supervisor::method12();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Supervisor::method12();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Supervisor::method12();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245))
        );
        ()
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
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Supervisor::method6(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Supervisor::method8();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Supervisor::method6(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Supervisor::method9();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Supervisor::method6(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Supervisor::method10();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Supervisor::method6(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Supervisor::method7();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Supervisor::method6(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Supervisor::method8();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Supervisor::method6(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Supervisor::method9();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Supervisor::method6(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Supervisor::method10();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Supervisor::method6(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Supervisor::method7();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Supervisor::method6(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Supervisor::method8();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Supervisor::method6(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Supervisor::method9();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Supervisor::method6(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Supervisor::method10();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Supervisor::method1(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Supervisor::method22();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Supervisor::method22();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Supervisor::method22();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Supervisor::method12();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Supervisor::method12();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Supervisor::method12();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245))
        );
        ()
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
                                                                                                                  MutCell::new(Supervisor::US0::US0_0),});
                                                                                while Supervisor::method23(v249,
                                                                                                           v251.clone())
                                                                                      {
                                                                                    let v253:
                                                                                            i32 =
                                                                                        v251.l0.get();
                                                                                    let v254:
                                                                                            Supervisor::US0 =
                                                                                        v251.l1.get().clone();
                                                                                    let v255:
                                                                                            i32 =
                                                                                        v248[v253].clone();
                                                                                    let v278:
                                                                                            Supervisor::US0 =
                                                                                        match &v254
                                                                                            {
                                                                                            Supervisor::US0::US0_1(v254_1_0)
                                                                                            =>
                                                                                            Supervisor::US0::US0_1(v254_1_0.clone()),
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
                                                                                                    Supervisor::US0::US0_1(fable_library_rust::String_::fromStr(&v269))
                                                                                                } else {
                                                                                                    std::thread::sleep(std::time::Duration::from_millis(*&25u64));
                                                                                                    Supervisor::US0::US0_0
                                                                                                }
                                                                                            }
                                                                                        };
                                                                                    let v279:
                                                                                            i32 =
                                                                                        v253
                                                                                            +
                                                                                            1i32;
                                                                                    v251.l0.set(v279);
                                                                                    v251.l1.set(v278.clone());
                                                                                    ()
                                                                                }
                                                                                {
                                                                                    let v280:
                                                                                            Supervisor::US0 =
                                                                                        v251.l1.get().clone();
                                                                                    let v283:
                                                                                            string =
                                                                                        match &v280
                                                                                            {
                                                                                            Supervisor::US0::US0_1(v280_1_0)
                                                                                            =>
                                                                                            v280_1_0.clone(),
                                                                                            _
                                                                                            =>
                                                                                            v92,
                                                                                        };
                                                                                    Supervisor::method2(v9,
                                                                                                        array(&[Supervisor::method1(string("new_fsx len")),
                                                                                                                Supervisor::method13((&v283).len().try_into().unwrap())]));
                                                                                    {
                                                                                        let v289:
                                                                                                std::path::PathBuf =
                                                                                            defaultValue(v86,
                                                                                                         v1);
                                                                                        let v290:
                                                                                                Result<(),
                                                                                                       std::io::Error> =
                                                                                            std::fs::write(v289, v283.clone().as_str());
                                                                                        *((&v290)
                                                                                            .as_ref(
                                                                                            ))
                                                                                        .unwrap();
                                                                                        Supervisor::method2(v9,
                                                                                                            array(&[Supervisor::method1(string("> fs_write new_fsx_path; ok"))]));
                                                                                        v283
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
