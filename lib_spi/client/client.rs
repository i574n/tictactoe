#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Client {
    use super::*;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method1:
            loop  {
                break '_method1
                    (if length(v1.get()) < v0_1.get() {
                         let v0_1_temp: i32 = v0_1.get();
                         let v1_temp: string =
                             stringFrom(format!("0{0}", &v1.get()));
                         v0_1.set(v0_1_temp);
                         v1.set(v1_temp);
                         continue '_method1
                     } else { v1.get() }) ;
            }
    }
    pub fn method2(v0_1: string) -> string { v0_1 }
    pub fn method3() -> string { string("$1=$2") }
    pub fn method4() -> string { string("[$1]") }
    pub fn method5() -> string { string(" ") }
    pub fn method6() -> string { string("387957") }
    pub fn method7() -> string { string("222222") }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let patternInput: (string, string, string, bool) = Client::method0();
        let v5: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v7: i64 = (&v5).timestamp();
        let v9 = web_sys::window().unwrap();
        let v11 = v9.document().unwrap();
        let v13 = v11.body().unwrap();
        let v16: &str = r#"iframe"#;
        let v18 = v11.create_element(v16).unwrap();
        let v40: Array<std::string::String> =
            array(&[(&string("window")).to_string(), format!("{:?}", v9),
                    (&string("document")).to_string(), format!("{:?}", v11),
                    (&string("body")).to_string(), format!("{:?}", v13),
                    (&string("iframe")).to_string(), format!("{:?}", v18)]);
        let v42 = core::ops::Deref::deref(&v40);
        let v45: std::string::String = format!("{:?}", ***v42).clone();
        let v46: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v51: string =
            Client::method1(6i32, toString(&((&v46).timestamp() - v7)));
        let v53: u8 = rand::random::<u8>();
        let v70: Array<std::string::String> =
            array(&[(&string("timestamp")).to_string(), (&v51).to_string(),
                    (&string("run_id")).to_string(), format!("{:?}", &v53),
                    (&string("log_level")).to_string(),
                    (&string("Debug")).to_string()]);
        let v71 = core::ops::Deref::deref(&v70);
        let v73: std::string::String = format!("{:?}", ***v71).clone();
        let v77: Array<std::string::String> =
            array(&[(&string("> app ()")).to_string()]);
        let v78 = core::ops::Deref::deref(&v77);
        let v81: std::string::String = format!("{:?}", ***v78).clone();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#""([^"]+)", "([^"]+)""#;
        let v88: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v90: &regex::Regex = &v88.build().unwrap();
        let v91: string = Client::method2(v83);
        let v93: &str = &v91.as_str();
        let v94: string = Client::method3();
        let v95: &str = &v94.as_str();
        let v97: std::string::String = v90.replace_all(&v93, v95).to_string();
        let v98: string = fable_library_rust::String_::fromStr(&v97);
        let v101: &str = r#"\["(.*?)"\]"#;
        let v102: regex::RegexBuilder = regex::RegexBuilder::new(&v101);
        let v103: &regex::Regex = &v102.build().unwrap();
        let v104: string = Client::method2(v98);
        let v105: &str = &v104.as_str();
        let v106: string = Client::method4();
        let v107: &str = &v106.as_str();
        let v108: std::string::String =
            v103.replace_all(&v105, v107).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v108);
        let v112: &str = r#", "#;
        let v113: regex::RegexBuilder = regex::RegexBuilder::new(&v112);
        let v114: &regex::Regex = &v113.build().unwrap();
        let v115: string = Client::method2(v109);
        let v116: &str = &v115.as_str();
        let v117: string = Client::method5();
        let v118: &str = &v117.as_str();
        let v119: std::string::String =
            v114.replace_all(&v116, v118).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v119);
        let v122: std::string::String = (&v120).to_string().clone();
        let v125: colored::ColoredString =
            colored::Colorize::color(&*v122, string("purple").to_string());
        let v127: std::string::String = format!("{}", &v125);
        let v129: string = fable_library_rust::String_::fromStr(&&v45);
        let v131: &str = r#""([^"]+)", "([^"]+)""#;
        let v132: regex::RegexBuilder = regex::RegexBuilder::new(&v131);
        let v133: &regex::Regex = &v132.build().unwrap();
        let v134: string = Client::method2(v129);
        let v135: &str = &v134.as_str();
        let v136: string = Client::method3();
        let v137: &str = &v136.as_str();
        let v138: std::string::String =
            v133.replace_all(&v135, v137).to_string();
        let v139: string = fable_library_rust::String_::fromStr(&v138);
        let v141: &str = r#"\["(.*?)"\]"#;
        let v142: regex::RegexBuilder = regex::RegexBuilder::new(&v141);
        let v143: &regex::Regex = &v142.build().unwrap();
        let v144: string = Client::method2(v139);
        let v145: &str = &v144.as_str();
        let v146: string = Client::method4();
        let v147: &str = &v146.as_str();
        let v148: std::string::String =
            v143.replace_all(&v145, v147).to_string();
        let v149: string = fable_library_rust::String_::fromStr(&v148);
        let v151: &str = r#", "#;
        let v152: regex::RegexBuilder = regex::RegexBuilder::new(&v151);
        let v153: &regex::Regex = &v152.build().unwrap();
        let v154: string = Client::method2(v149);
        let v155: &str = &v154.as_str();
        let v156: string = Client::method5();
        let v157: &str = &v156.as_str();
        let v158: std::string::String =
            v153.replace_all(&v155, v157).to_string();
        let v159: string = fable_library_rust::String_::fromStr(&v158);
        let v161: std::string::String = (&v159).to_string().clone();
        let v162: string = Client::method6();
        let v163: &str = &v162.as_str();
        let v167: &str = &v163[0i32 as usize..2i32 as usize];
        let v168: string = fable_library_rust::String_::fromStr(&v167);
        let v170: u8 = u8::from_str_radix(&v168, 16).unwrap();
        let v171: string = Client::method6();
        let v172: &str = &v171.as_str();
        let v175: &str = &v172[2i32 as usize..4i32 as usize];
        let v176: string = fable_library_rust::String_::fromStr(&v175);
        let v177: u8 = u8::from_str_radix(&v176, 16).unwrap();
        let v178: string = Client::method6();
        let v179: &str = &v178.as_str();
        let v182: &str = &v179[4i32 as usize..6i32 as usize];
        let v183: string = fable_library_rust::String_::fromStr(&v182);
        let v184: u8 = u8::from_str_radix(&v183, 16).unwrap();
        let v186: colored::ColoredString =
            colored::Colorize::truecolor(&*v161.to_string(), v170, v177, v184);
        let v187: std::string::String = format!("{}", &v186);
        let v189: string = fable_library_rust::String_::fromStr(&&v73);
        let v191: &str = r#""([^"]+)", "([^"]+)""#;
        let v192: regex::RegexBuilder = regex::RegexBuilder::new(&v191);
        let v193: &regex::Regex = &v192.build().unwrap();
        let v194: string = Client::method2(v189);
        let v195: &str = &v194.as_str();
        let v196: string = Client::method3();
        let v197: &str = &v196.as_str();
        let v198: std::string::String =
            v193.replace_all(&v195, v197).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v198);
        let v201: &str = r#"\["(.*?)"\]"#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Client::method2(v199);
        let v205: &str = &v204.as_str();
        let v206: string = Client::method4();
        let v207: &str = &v206.as_str();
        let v208: std::string::String =
            v203.replace_all(&v205, v207).to_string();
        let v209: string = fable_library_rust::String_::fromStr(&v208);
        let v211: &str = r#", "#;
        let v212: regex::RegexBuilder = regex::RegexBuilder::new(&v211);
        let v213: &regex::Regex = &v212.build().unwrap();
        let v214: string = Client::method2(v209);
        let v215: &str = &v214.as_str();
        let v216: string = Client::method5();
        let v217: &str = &v216.as_str();
        let v218: std::string::String =
            v213.replace_all(&v215, v217).to_string();
        let v219: string = fable_library_rust::String_::fromStr(&v218);
        let v221: std::string::String = (&v219).to_string().clone();
        let v222: string = Client::method7();
        let v223: &str = &v222.as_str();
        let v226: &str = &v223[0i32 as usize..2i32 as usize];
        let v227: string = fable_library_rust::String_::fromStr(&v226);
        let v228: u8 = u8::from_str_radix(&v227, 16).unwrap();
        let v229: string = Client::method7();
        let v230: &str = &v229.as_str();
        let v233: &str = &v230[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v233);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Client::method7();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v240);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v243: colored::ColoredString =
            colored::Colorize::truecolor(&*v221.to_string(), v228, v235, v242);
        let v244: std::string::String = format!("{}", &v243);
        web_sys::console::log_1(&wasm_bindgen::JsValue::from_str(&stringFrom(format!("{0} {1} {2}",
                                                                                     &v127,
                                                                                     &v187,
                                                                                     &v244))));
        {
            let v249: &str = r#"src"#;
            let v252: &str = r#"https://time.is"#;
            v18.set_attribute(v249, v252).unwrap();
            {
                let v256: &str = r#"width"#;
                let v259: &str = r#"100%"#;
                v18.set_attribute(v256, v259).unwrap();
                {
                    let v262: &str = r#"style"#;
                    let v265: &str = r#"height: 100vh; border: 0;"#;
                    v18.set_attribute(v262, v265).unwrap();
                    {
                        let v268: &str = r#"data-test"#;
                        let v271: &str = r#"1"#;
                        v18.set_attribute(v268, v271).unwrap();
                        v13.append_child(&v18).unwrap();
                        0i32
                    }
                }
            }
        }
    }
    pub fn v0() -> Func0<i32> {
        static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        v0.get_or_init(move || Func0::new(move || Client::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;
