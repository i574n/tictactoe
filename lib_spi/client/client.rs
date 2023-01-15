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
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::arrayCreate;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub struct Mut0 {
        pub l0: MutCell<i32>,
    }
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
    pub fn method8(v0_1: i32, v1: Lrc<Client::Mut0>) -> bool {
        v1.l0.get() < v0_1
    }
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
        let v44 = *&v42;
        let v45 = *&v44;
        let v46 = *&v45;
        let v48: std::string::String = format!("{:?}", &v46).clone();
        let v49: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v54: string =
            Client::method1(6i32, toString(&((&v49).timestamp() - v7)));
        let v56: u8 = rand::random::<u8>();
        let v73: Array<std::string::String> =
            array(&[(&string("timestamp")).to_string(), (&v54).to_string(),
                    (&string("run_id")).to_string(), format!("{:?}", &v56),
                    (&string("log_level")).to_string(),
                    (&string("Debug")).to_string()]);
        let v74 = core::ops::Deref::deref(&v73);
        let v75 = *&v74;
        let v76 = *&v75;
        let v77 = *&v76;
        let v79: std::string::String = format!("{:?}", &v77).clone();
        let v83: Array<std::string::String> =
            array(&[(&string("> app ()")).to_string()]);
        let v84 = core::ops::Deref::deref(&v83);
        let v85 = *&v84;
        let v86 = *&v85;
        let v87 = *&v86;
        let v90: std::string::String = format!("{:?}", &v87).clone();
        let v92: string = fable_library_rust::String_::fromStr(&v90);
        let v95: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v95);
        let v99: &regex::Regex = &v97.build().unwrap();
        let v100: string = Client::method2(v92);
        let v102: &str = &v100.as_str();
        let v103: string = Client::method3();
        let v104: &str = &v103.as_str();
        let v106: std::string::String =
            v99.replace_all(&v102, v104).to_string();
        let v107: string = fable_library_rust::String_::fromStr(&v106);
        let v110: &str = r#"\["(.*?)"\]"#;
        let v111: regex::RegexBuilder = regex::RegexBuilder::new(&v110);
        let v112: &regex::Regex = &v111.build().unwrap();
        let v113: string = Client::method2(v107);
        let v114: &str = &v113.as_str();
        let v115: string = Client::method4();
        let v116: &str = &v115.as_str();
        let v117: std::string::String =
            v112.replace_all(&v114, v116).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v117);
        let v121: &str = r#", "#;
        let v122: regex::RegexBuilder = regex::RegexBuilder::new(&v121);
        let v123: &regex::Regex = &v122.build().unwrap();
        let v124: string = Client::method2(v118);
        let v125: &str = &v124.as_str();
        let v126: string = Client::method5();
        let v127: &str = &v126.as_str();
        let v128: std::string::String =
            v123.replace_all(&v125, v127).to_string();
        let v129: string = fable_library_rust::String_::fromStr(&v128);
        let v131: std::string::String = (&v129).to_string().clone();
        let v134: colored::ColoredString =
            colored::Colorize::color(&*v131, string("purple").to_string());
        let v136: std::string::String = format!("{}", &v134);
        let v138: string = fable_library_rust::String_::fromStr(&&v48);
        let v140: &str = r#""([^"]+)", "([^"]+)""#;
        let v141: regex::RegexBuilder = regex::RegexBuilder::new(&v140);
        let v142: &regex::Regex = &v141.build().unwrap();
        let v143: string = Client::method2(v138);
        let v144: &str = &v143.as_str();
        let v145: string = Client::method3();
        let v146: &str = &v145.as_str();
        let v147: std::string::String =
            v142.replace_all(&v144, v146).to_string();
        let v148: string = fable_library_rust::String_::fromStr(&v147);
        let v150: &str = r#"\["(.*?)"\]"#;
        let v151: regex::RegexBuilder = regex::RegexBuilder::new(&v150);
        let v152: &regex::Regex = &v151.build().unwrap();
        let v153: string = Client::method2(v148);
        let v154: &str = &v153.as_str();
        let v155: string = Client::method4();
        let v156: &str = &v155.as_str();
        let v157: std::string::String =
            v152.replace_all(&v154, v156).to_string();
        let v158: string = fable_library_rust::String_::fromStr(&v157);
        let v160: &str = r#", "#;
        let v161: regex::RegexBuilder = regex::RegexBuilder::new(&v160);
        let v162: &regex::Regex = &v161.build().unwrap();
        let v163: string = Client::method2(v158);
        let v164: &str = &v163.as_str();
        let v165: string = Client::method5();
        let v166: &str = &v165.as_str();
        let v167: std::string::String =
            v162.replace_all(&v164, v166).to_string();
        let v168: string = fable_library_rust::String_::fromStr(&v167);
        let v170: std::string::String = (&v168).to_string().clone();
        let v171: string = Client::method6();
        let v172: &str = &v171.as_str();
        let v176: &str = &v172[0i32 as usize..2i32 as usize];
        let v177: string = fable_library_rust::String_::fromStr(&v176);
        let v179: u8 = u8::from_str_radix(&v177, 16).unwrap();
        let v180: string = Client::method6();
        let v181: &str = &v180.as_str();
        let v184: &str = &v181[2i32 as usize..4i32 as usize];
        let v185: string = fable_library_rust::String_::fromStr(&v184);
        let v186: u8 = u8::from_str_radix(&v185, 16).unwrap();
        let v187: string = Client::method6();
        let v188: &str = &v187.as_str();
        let v191: &str = &v188[4i32 as usize..6i32 as usize];
        let v192: string = fable_library_rust::String_::fromStr(&v191);
        let v193: u8 = u8::from_str_radix(&v192, 16).unwrap();
        let v195: colored::ColoredString =
            colored::Colorize::truecolor(&*v170.to_string(), v179, v186, v193);
        let v196: std::string::String = format!("{}", &v195);
        let v198: string = fable_library_rust::String_::fromStr(&&v79);
        let v200: &str = r#""([^"]+)", "([^"]+)""#;
        let v201: regex::RegexBuilder = regex::RegexBuilder::new(&v200);
        let v202: &regex::Regex = &v201.build().unwrap();
        let v203: string = Client::method2(v198);
        let v204: &str = &v203.as_str();
        let v205: string = Client::method3();
        let v206: &str = &v205.as_str();
        let v207: std::string::String =
            v202.replace_all(&v204, v206).to_string();
        let v208: string = fable_library_rust::String_::fromStr(&v207);
        let v210: &str = r#"\["(.*?)"\]"#;
        let v211: regex::RegexBuilder = regex::RegexBuilder::new(&v210);
        let v212: &regex::Regex = &v211.build().unwrap();
        let v213: string = Client::method2(v208);
        let v214: &str = &v213.as_str();
        let v215: string = Client::method4();
        let v216: &str = &v215.as_str();
        let v217: std::string::String =
            v212.replace_all(&v214, v216).to_string();
        let v218: string = fable_library_rust::String_::fromStr(&v217);
        let v220: &str = r#", "#;
        let v221: regex::RegexBuilder = regex::RegexBuilder::new(&v220);
        let v222: &regex::Regex = &v221.build().unwrap();
        let v223: string = Client::method2(v218);
        let v224: &str = &v223.as_str();
        let v225: string = Client::method5();
        let v226: &str = &v225.as_str();
        let v227: std::string::String =
            v222.replace_all(&v224, v226).to_string();
        let v228: string = fable_library_rust::String_::fromStr(&v227);
        let v230: std::string::String = (&v228).to_string().clone();
        let v231: string = Client::method7();
        let v232: &str = &v231.as_str();
        let v235: &str = &v232[0i32 as usize..2i32 as usize];
        let v236: string = fable_library_rust::String_::fromStr(&v235);
        let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
        let v238: string = Client::method7();
        let v239: &str = &v238.as_str();
        let v242: &str = &v239[2i32 as usize..4i32 as usize];
        let v243: string = fable_library_rust::String_::fromStr(&v242);
        let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
        let v245: string = Client::method7();
        let v246: &str = &v245.as_str();
        let v249: &str = &v246[4i32 as usize..6i32 as usize];
        let v250: string = fable_library_rust::String_::fromStr(&v249);
        let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
        let v252: colored::ColoredString =
            colored::Colorize::truecolor(&*v230.to_string(), v237, v244, v251);
        let v253: std::string::String = format!("{}", &v252);
        let v256 =
            wasm_bindgen::JsValue::from_str(&stringFrom(format!("{0} {1} {2}",
                                                                &v136, &v196,
                                                                &v253)));
        web_sys::console::log_1(&v256);
        {
            let v260: &str = r#"src"#;
            let v263: &str = r#"https://time.is"#;
            v18.set_attribute(v260, v263).unwrap();
            {
                let v267: &str = r#"width"#;
                let v270: &str = r#"100%"#;
                v18.set_attribute(v267, v270).unwrap();
                {
                    let v273: &str = r#"style"#;
                    let v276: &str = r#"height: 100vh; border: 0;"#;
                    v18.set_attribute(v273, v276).unwrap();
                    {
                        let v279: &str = r#"data-test"#;
                        let v282: &str = r#"1"#;
                        v18.set_attribute(v279, v282).unwrap();
                        v13.append_child(&v18).unwrap();
                        {
                            let v286: Array<string> =
                                array(&[string("a"), string("b")]);
                            let v287: i32 = v286.len() as i32;
                            let v288: Array<std::string::String> =
                                arrayCreate(&v287,
                                            &defaultOf::<std::string::String>());
                            let v289: Lrc<Client::Mut0> =
                                Lrc::new(Client::Mut0{l0:
                                                          MutCell::new(0i32),});
                            while Client::method8(v287, v289.clone()) {
                                let v291: i32 = v289.l0.get();
                                let v292: string = v286[v291].clone();
                                let v293: std::string::String =
                                    (&v292).to_string();
                                v288.get_mut()[v291 as usize] = v293.clone();
                                {
                                    let v294: i32 = v291 + 1i32;
                                    v289.l0.set(v294);
                                    ()
                                }
                            }
                            {
                                let v295 = core::ops::Deref::deref(&v288);
                                let v296 = *&v295;
                                let v297 = *&v296;
                                let v298 = *&v297;
                                let v301 =
                                    serde_wasm_bindgen::to_value(&****&v298).unwrap();
                                web_sys::console::log(&js_sys::Array::from(&v301));
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
        v0.get_or_init(move || Func0::new(move || Client::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;
