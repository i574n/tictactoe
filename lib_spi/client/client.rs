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
        let v44: std::string::String = format!("{:?}", &v42).clone();
        let v45: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v50: string =
            Client::method1(6i32, toString(&((&v45).timestamp() - v7)));
        let v52: u8 = rand::random::<u8>();
        let v69: Array<std::string::String> =
            array(&[(&string("timestamp")).to_string(), (&v50).to_string(),
                    (&string("run_id")).to_string(), format!("{:?}", &v52),
                    (&string("log_level")).to_string(),
                    (&string("Debug")).to_string()]);
        let v70 = core::ops::Deref::deref(&v69);
        let v72: std::string::String = format!("{:?}", &v70).clone();
        let v76: Array<std::string::String> =
            array(&[(&string("> app ()")).to_string()]);
        let v77 = core::ops::Deref::deref(&v76);
        let v80: std::string::String = format!("{:?}", &v77).clone();
        let v82: string = fable_library_rust::String_::fromStr(&v80);
        let v85: &str = r#""([^"]+)", "([^"]+)""#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v85);
        let v89: &regex::Regex = &v87.build().unwrap();
        let v90: string = Client::method2(v82);
        let v92: &str = &v90.as_str();
        let v93: string = Client::method3();
        let v94: &str = &v93.as_str();
        let v96: std::string::String = v89.replace_all(&v92, v94).to_string();
        let v97: string = fable_library_rust::String_::fromStr(&v96);
        let v100: &str = r#"\["(.*?)"\]"#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Client::method2(v97);
        let v104: &str = &v103.as_str();
        let v105: string = Client::method4();
        let v106: &str = &v105.as_str();
        let v107: std::string::String =
            v102.replace_all(&v104, v106).to_string();
        let v108: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#", "#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Client::method2(v108);
        let v115: &str = &v114.as_str();
        let v116: string = Client::method5();
        let v117: &str = &v116.as_str();
        let v118: std::string::String =
            v113.replace_all(&v115, v117).to_string();
        let v119: string = fable_library_rust::String_::fromStr(&v118);
        let v121: std::string::String = (&v119).to_string().clone();
        let v124: colored::ColoredString =
            colored::Colorize::color(&*v121, string("purple").to_string());
        let v126: std::string::String = format!("{}", &v124);
        let v128: string = fable_library_rust::String_::fromStr(&&v44);
        let v130: &str = r#""([^"]+)", "([^"]+)""#;
        let v131: regex::RegexBuilder = regex::RegexBuilder::new(&v130);
        let v132: &regex::Regex = &v131.build().unwrap();
        let v133: string = Client::method2(v128);
        let v134: &str = &v133.as_str();
        let v135: string = Client::method3();
        let v136: &str = &v135.as_str();
        let v137: std::string::String =
            v132.replace_all(&v134, v136).to_string();
        let v138: string = fable_library_rust::String_::fromStr(&v137);
        let v140: &str = r#"\["(.*?)"\]"#;
        let v141: regex::RegexBuilder = regex::RegexBuilder::new(&v140);
        let v142: &regex::Regex = &v141.build().unwrap();
        let v143: string = Client::method2(v138);
        let v144: &str = &v143.as_str();
        let v145: string = Client::method4();
        let v146: &str = &v145.as_str();
        let v147: std::string::String =
            v142.replace_all(&v144, v146).to_string();
        let v148: string = fable_library_rust::String_::fromStr(&v147);
        let v150: &str = r#", "#;
        let v151: regex::RegexBuilder = regex::RegexBuilder::new(&v150);
        let v152: &regex::Regex = &v151.build().unwrap();
        let v153: string = Client::method2(v148);
        let v154: &str = &v153.as_str();
        let v155: string = Client::method5();
        let v156: &str = &v155.as_str();
        let v157: std::string::String =
            v152.replace_all(&v154, v156).to_string();
        let v158: string = fable_library_rust::String_::fromStr(&v157);
        let v160: std::string::String = (&v158).to_string().clone();
        let v161: string = Client::method6();
        let v162: &str = &v161.as_str();
        let v166: &str = &v162[0i32 as usize..2i32 as usize];
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: u8 = u8::from_str_radix(&v167, 16).unwrap();
        let v170: string = Client::method6();
        let v171: &str = &v170.as_str();
        let v174: &str = &v171[2i32 as usize..4i32 as usize];
        let v175: string = fable_library_rust::String_::fromStr(&v174);
        let v176: u8 = u8::from_str_radix(&v175, 16).unwrap();
        let v177: string = Client::method6();
        let v178: &str = &v177.as_str();
        let v181: &str = &v178[4i32 as usize..6i32 as usize];
        let v182: string = fable_library_rust::String_::fromStr(&v181);
        let v183: u8 = u8::from_str_radix(&v182, 16).unwrap();
        let v185: colored::ColoredString =
            colored::Colorize::truecolor(&*v160.to_string(), v169, v176, v183);
        let v186: std::string::String = format!("{}", &v185);
        let v188: string = fable_library_rust::String_::fromStr(&&v72);
        let v190: &str = r#""([^"]+)", "([^"]+)""#;
        let v191: regex::RegexBuilder = regex::RegexBuilder::new(&v190);
        let v192: &regex::Regex = &v191.build().unwrap();
        let v193: string = Client::method2(v188);
        let v194: &str = &v193.as_str();
        let v195: string = Client::method3();
        let v196: &str = &v195.as_str();
        let v197: std::string::String =
            v192.replace_all(&v194, v196).to_string();
        let v198: string = fable_library_rust::String_::fromStr(&v197);
        let v200: &str = r#"\["(.*?)"\]"#;
        let v201: regex::RegexBuilder = regex::RegexBuilder::new(&v200);
        let v202: &regex::Regex = &v201.build().unwrap();
        let v203: string = Client::method2(v198);
        let v204: &str = &v203.as_str();
        let v205: string = Client::method4();
        let v206: &str = &v205.as_str();
        let v207: std::string::String =
            v202.replace_all(&v204, v206).to_string();
        let v208: string = fable_library_rust::String_::fromStr(&v207);
        let v210: &str = r#", "#;
        let v211: regex::RegexBuilder = regex::RegexBuilder::new(&v210);
        let v212: &regex::Regex = &v211.build().unwrap();
        let v213: string = Client::method2(v208);
        let v214: &str = &v213.as_str();
        let v215: string = Client::method5();
        let v216: &str = &v215.as_str();
        let v217: std::string::String =
            v212.replace_all(&v214, v216).to_string();
        let v218: string = fable_library_rust::String_::fromStr(&v217);
        let v220: std::string::String = (&v218).to_string().clone();
        let v221: string = Client::method7();
        let v222: &str = &v221.as_str();
        let v225: &str = &v222[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v225);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Client::method7();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v233: string = fable_library_rust::String_::fromStr(&v232);
        let v234: u8 = u8::from_str_radix(&v233, 16).unwrap();
        let v235: string = Client::method7();
        let v236: &str = &v235.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v240: string = fable_library_rust::String_::fromStr(&v239);
        let v241: u8 = u8::from_str_radix(&v240, 16).unwrap();
        let v242: colored::ColoredString =
            colored::Colorize::truecolor(&*v220.to_string(), v227, v234, v241);
        let v243: std::string::String = format!("{}", &v242);
        let v246 =
            wasm_bindgen::JsValue::from_str(&stringFrom(format!("{0} {1} {2}",
                                                                &v126, &v186,
                                                                &v243)));
        web_sys::console::log_1(&v246);
        {
            let v250: &str = r#"src"#;
            let v253: &str = r#"https://time.is"#;
            v18.set_attribute(v250, v253).unwrap();
            {
                let v257: &str = r#"width"#;
                let v260: &str = r#"100%"#;
                v18.set_attribute(v257, v260).unwrap();
                {
                    let v263: &str = r#"style"#;
                    let v266: &str = r#"height: 100vh; border: 0;"#;
                    v18.set_attribute(v263, v266).unwrap();
                    {
                        let v269: &str = r#"data-test"#;
                        let v272: &str = r#"1"#;
                        v18.set_attribute(v269, v272).unwrap();
                        v13.append_child(&v18).unwrap();
                        {
                            let v279: Array<std::string::String> =
                                array(&[(&string("a")).as_ref().to_string(),
                                        (&string("b")).as_ref().to_string()]);
                            let v280 = core::ops::Deref::deref(&v279);
                            let v282 = &v280;
                            let v285 =
                                serde_wasm_bindgen::to_value(&*****&v282).unwrap();
                            web_sys::console::log(&js_sys::Array::from(&v285));
                            0i32
                        }
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
