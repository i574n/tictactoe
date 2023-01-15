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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 { US0_0, US0_1, }
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
        let v44 = &***&v42;
        let v45 = &***&v44;
        let v47: std::string::String = format!("{:?}", &v45).clone();
        let v48: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v53: string =
            Client::method1(6i32, toString(&((&v48).timestamp() - v7)));
        let v55: u8 = rand::random::<u8>();
        let v72: Array<std::string::String> =
            array(&[(&string("timestamp")).to_string(), (&v53).to_string(),
                    (&string("run_id")).to_string(), format!("{:?}", &v55),
                    (&string("log_level")).to_string(),
                    (&string("Debug")).to_string()]);
        let v73 = core::ops::Deref::deref(&v72);
        let v74 = &***&v73;
        let v75 = &***&v74;
        let v77: std::string::String = format!("{:?}", &v75).clone();
        let v81: Array<std::string::String> =
            array(&[(&string("> app ()")).to_string()]);
        let v82 = core::ops::Deref::deref(&v81);
        let v83 = &***&v82;
        let v84 = &***&v83;
        let v86: std::string::String = format!("{:?}", &v84).clone();
        let v89: string = toString(&format!("{}", &v86));
        let v92: &str = r#""([^"]+)", "([^"]+)""#;
        let v94: regex::RegexBuilder = regex::RegexBuilder::new(&v92);
        let v96: &regex::Regex = &v94.build().unwrap();
        let v97: string = Client::method2(v89);
        let v99: &str = &v97.as_str();
        let v100: string = Client::method3();
        let v101: &str = &v100.as_str();
        let v103: std::string::String =
            v96.replace_all(&v99, v101).to_string();
        let v105: string = fable_library_rust::String_::fromStr(&v103);
        let v108: &str = r#"\["(.*?)"\]"#;
        let v109: regex::RegexBuilder = regex::RegexBuilder::new(&v108);
        let v110: &regex::Regex = &v109.build().unwrap();
        let v111: string = Client::method2(v105);
        let v112: &str = &v111.as_str();
        let v113: string = Client::method4();
        let v114: &str = &v113.as_str();
        let v115: std::string::String =
            v110.replace_all(&v112, v114).to_string();
        let v116: string = fable_library_rust::String_::fromStr(&v115);
        let v119: &str = r#", "#;
        let v120: regex::RegexBuilder = regex::RegexBuilder::new(&v119);
        let v121: &regex::Regex = &v120.build().unwrap();
        let v122: string = Client::method2(v116);
        let v123: &str = &v122.as_str();
        let v124: string = Client::method5();
        let v125: &str = &v124.as_str();
        let v126: std::string::String =
            v121.replace_all(&v123, v125).to_string();
        let v127: string = fable_library_rust::String_::fromStr(&v126);
        let v129: std::string::String = (&v127).to_string().clone();
        let v131: string = toString(&format!("{}", &v47));
        let v133: &str = r#""([^"]+)", "([^"]+)""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Client::method2(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Client::method3();
        let v139: &str = &v138.as_str();
        let v140: std::string::String =
            v135.replace_all(&v137, v139).to_string();
        let v141: string = fable_library_rust::String_::fromStr(&v140);
        let v143: &str = r#"\["(.*?)"\]"#;
        let v144: regex::RegexBuilder = regex::RegexBuilder::new(&v143);
        let v145: &regex::Regex = &v144.build().unwrap();
        let v146: string = Client::method2(v141);
        let v147: &str = &v146.as_str();
        let v148: string = Client::method4();
        let v149: &str = &v148.as_str();
        let v150: std::string::String =
            v145.replace_all(&v147, v149).to_string();
        let v151: string = fable_library_rust::String_::fromStr(&v150);
        let v153: &str = r#", "#;
        let v154: regex::RegexBuilder = regex::RegexBuilder::new(&v153);
        let v155: &regex::Regex = &v154.build().unwrap();
        let v156: string = Client::method2(v151);
        let v157: &str = &v156.as_str();
        let v158: string = Client::method5();
        let v159: &str = &v158.as_str();
        let v160: std::string::String =
            v155.replace_all(&v157, v159).to_string();
        let v161: string = fable_library_rust::String_::fromStr(&v160);
        let v163: std::string::String = (&v161).to_string().clone();
        let v165: string = toString(&format!("{}", &v77));
        let v167: &str = r#""([^"]+)", "([^"]+)""#;
        let v168: regex::RegexBuilder = regex::RegexBuilder::new(&v167);
        let v169: &regex::Regex = &v168.build().unwrap();
        let v170: string = Client::method2(v165);
        let v171: &str = &v170.as_str();
        let v172: string = Client::method3();
        let v173: &str = &v172.as_str();
        let v174: std::string::String =
            v169.replace_all(&v171, v173).to_string();
        let v175: string = fable_library_rust::String_::fromStr(&v174);
        let v177: &str = r#"\["(.*?)"\]"#;
        let v178: regex::RegexBuilder = regex::RegexBuilder::new(&v177);
        let v179: &regex::Regex = &v178.build().unwrap();
        let v180: string = Client::method2(v175);
        let v181: &str = &v180.as_str();
        let v182: string = Client::method4();
        let v183: &str = &v182.as_str();
        let v184: std::string::String =
            v179.replace_all(&v181, v183).to_string();
        let v185: string = fable_library_rust::String_::fromStr(&v184);
        let v187: &str = r#", "#;
        let v188: regex::RegexBuilder = regex::RegexBuilder::new(&v187);
        let v189: &regex::Regex = &v188.build().unwrap();
        let v190: string = Client::method2(v185);
        let v191: &str = &v190.as_str();
        let v192: string = Client::method5();
        let v193: &str = &v192.as_str();
        let v194: std::string::String =
            v189.replace_all(&v191, v193).to_string();
        let v195: string = fable_library_rust::String_::fromStr(&v194);
        let v197: std::string::String = (&v195).to_string().clone();
        if let Client::US0::US0_1 =
               &if cfg!(target_arch = "wasm32") {
                    Client::US0::US0_1
                } else { Client::US0::US0_0 } {
            let v219: Array<std::string::String> =
                array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                        (&string("color: purple")).as_ref().to_string(),
                        (&stringFrom(format!("{0}",
                                             &v129))).as_ref().to_string(),
                        (&stringFrom(format!("color: {0}",
                                             &string("387957")))).as_ref().to_string(),
                        (&stringFrom(format!("{0} {1}", &v163,
                                             &v197))).as_ref().to_string(),
                        (&string("color: #222222")).as_ref().to_string(),
                        (&stringFrom(format!("{0}",
                                             &v197))).as_ref().to_string()]);
            let v220 = core::ops::Deref::deref(&v219);
            let v223 = serde_wasm_bindgen::to_value(&*****&v220).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v223));
            ()
        } else {
            let v227: colored::ColoredString =
                colored::Colorize::color(&*v129, string("purple").to_string());
            let v228: std::string::String = format!("{}", &v227);
            let v229: string = Client::method6();
            let v230: &str = &v229.as_str();
            let v234: &str = &v230[0i32 as usize..2i32 as usize];
            let v235: string = fable_library_rust::String_::fromStr(&v234);
            let v237: u8 = u8::from_str_radix(&v235, 16).unwrap();
            let v238: string = Client::method6();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Client::method6();
            let v246: &str = &v245.as_str();
            let v249: &str = &v246[4i32 as usize..6i32 as usize];
            let v250: string = fable_library_rust::String_::fromStr(&v249);
            let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
            let v253: colored::ColoredString =
                colored::Colorize::truecolor(&*v163.to_string(), v237, v244, v251);
            let v254: std::string::String = format!("{}", &v253);
            let v255: string = Client::method7();
            let v256: &str = &v255.as_str();
            let v259: &str = &v256[0i32 as usize..2i32 as usize];
            let v260: string = fable_library_rust::String_::fromStr(&v259);
            let v261: u8 = u8::from_str_radix(&v260, 16).unwrap();
            let v262: string = Client::method7();
            let v263: &str = &v262.as_str();
            let v266: &str = &v263[2i32 as usize..4i32 as usize];
            let v267: string = fable_library_rust::String_::fromStr(&v266);
            let v268: u8 = u8::from_str_radix(&v267, 16).unwrap();
            let v269: string = Client::method7();
            let v270: &str = &v269.as_str();
            let v273: &str = &v270[4i32 as usize..6i32 as usize];
            let v274: string = fable_library_rust::String_::fromStr(&v273);
            let v275: u8 = u8::from_str_radix(&v274, 16).unwrap();
            let v276: colored::ColoredString =
                colored::Colorize::truecolor(&*v197.to_string(), v261, v268, v275);
            let v277: std::string::String = format!("{}", &v276);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v228, &v254, &v277)));
            ()
        }
        {
            let v281: &str = r#"src"#;
            let v284: &str = r#"https://time.is"#;
            v18.set_attribute(v281, v284).unwrap();
            {
                let v288: &str = r#"width"#;
                let v291: &str = r#"100%"#;
                v18.set_attribute(v288, v291).unwrap();
                {
                    let v294: &str = r#"style"#;
                    let v297: &str = r#"height: 100vh; border: 0;"#;
                    v18.set_attribute(v294, v297).unwrap();
                    {
                        let v300: &str = r#"data-test"#;
                        let v303: &str = r#"1"#;
                        v18.set_attribute(v300, v303).unwrap();
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
