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
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
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
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1(v0_1: string) -> std::string::String {
        (&v0_1).to_string().clone()
    }
    pub fn method2(v0_1: &dyn Any) -> std::string::String {
        format!("{:?}", v0_1.clone()).clone()
    }
    pub fn method4(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method4:
            loop  {
                break '_method4
                    (if length(v1.get()) < v0_1.get() {
                         let v0_1_temp: i32 = v0_1.get();
                         let v1_temp: string =
                             stringFrom(format!("0{0}", &v1.get()));
                         v0_1.set(v0_1_temp);
                         v1.set(v1_temp);
                         continue '_method4
                     } else { v1.get() }) ;
            }
    }
    pub fn method5(v0_1: u8) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method6(v0_1: Array<std::string::String>) -> std::string::String {
        let v2 = core::ops::Deref::deref(&v0_1);
        let v4 = &***&v2;
        let v5 = &***&v4;
        format!("{:?}", &v5).clone()
    }
    pub fn method7(v0_1: string) -> string { v0_1 }
    pub fn method8() -> string { string("$1=$2") }
    pub fn method9() -> string { string("[$1]") }
    pub fn method10() -> string { string("\"") }
    pub fn method11() -> string { string(" ") }
    pub fn method12() -> string { string("387957") }
    pub fn method13() -> string { string("385779") }
    pub fn method3(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string =
            Client::method4(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String =
            Client::method6(array(&[Client::method1(string("timestamp")),
                                    Client::method1(v9),
                                    Client::method1(string("run_id")),
                                    Client::method5(v11),
                                    Client::method1(string("log_level")),
                                    Client::method1(string("Debug"))]));
        let v26: Array<std::string::String> =
            array(&[Client::method1(string("> app ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Client::method7(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Client::method8();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v53: string = fable_library_rust::String_::fromStr(&v51);
        let v56: &str = r#"\["(.*?)"\]"#;
        let v57: regex::RegexBuilder = regex::RegexBuilder::new(&v56);
        let v58: &regex::Regex = &v57.build().unwrap();
        let v59: string = Client::method7(v53);
        let v60: &str = &v59.as_str();
        let v61: string = Client::method9();
        let v62: &str = &v61.as_str();
        let v63: std::string::String = v58.replace_all(&v60, v62).to_string();
        let v64: string = fable_library_rust::String_::fromStr(&v63);
        let v67: &str = r#"\\""#;
        let v68: regex::RegexBuilder = regex::RegexBuilder::new(&v67);
        let v69: &regex::Regex = &v68.build().unwrap();
        let v70: string = Client::method7(v64);
        let v71: &str = &v70.as_str();
        let v72: string = Client::method10();
        let v73: &str = &v72.as_str();
        let v74: std::string::String = v69.replace_all(&v71, v73).to_string();
        let v75: string = fable_library_rust::String_::fromStr(&v74);
        let v78: &str = r#", "#;
        let v79: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v80: &regex::Regex = &v79.build().unwrap();
        let v81: string = Client::method7(v75);
        let v82: &str = &v81.as_str();
        let v83: string = Client::method11();
        let v84: &str = &v83.as_str();
        let v85: std::string::String = v80.replace_all(&v82, v84).to_string();
        let v87: std::string::String =
            Client::method1(fable_library_rust::String_::fromStr(&v85));
        let v88 = core::ops::Deref::deref(&v1);
        let v89 = &***&v88;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v94: string = toString(&format!("{}", &v92));
        let v96: &str = r#""([^"]+)", "([^"]+)""#;
        let v97: regex::RegexBuilder = regex::RegexBuilder::new(&v96);
        let v98: &regex::Regex = &v97.build().unwrap();
        let v99: string = Client::method7(v94);
        let v100: &str = &v99.as_str();
        let v101: string = Client::method8();
        let v102: &str = &v101.as_str();
        let v103: std::string::String =
            v98.replace_all(&v100, v102).to_string();
        let v104: string = fable_library_rust::String_::fromStr(&v103);
        let v106: &str = r#"\["(.*?)"\]"#;
        let v107: regex::RegexBuilder = regex::RegexBuilder::new(&v106);
        let v108: &regex::Regex = &v107.build().unwrap();
        let v109: string = Client::method7(v104);
        let v110: &str = &v109.as_str();
        let v111: string = Client::method9();
        let v112: &str = &v111.as_str();
        let v113: std::string::String =
            v108.replace_all(&v110, v112).to_string();
        let v114: string = fable_library_rust::String_::fromStr(&v113);
        let v116: &str = r#"\\""#;
        let v117: regex::RegexBuilder = regex::RegexBuilder::new(&v116);
        let v118: &regex::Regex = &v117.build().unwrap();
        let v119: string = Client::method7(v114);
        let v120: &str = &v119.as_str();
        let v121: string = Client::method10();
        let v122: &str = &v121.as_str();
        let v123: std::string::String =
            v118.replace_all(&v120, v122).to_string();
        let v124: string = fable_library_rust::String_::fromStr(&v123);
        let v126: &str = r#", "#;
        let v127: regex::RegexBuilder = regex::RegexBuilder::new(&v126);
        let v128: &regex::Regex = &v127.build().unwrap();
        let v129: string = Client::method7(v124);
        let v130: &str = &v129.as_str();
        let v131: string = Client::method11();
        let v132: &str = &v131.as_str();
        let v133: std::string::String =
            v128.replace_all(&v130, v132).to_string();
        let v135: std::string::String =
            Client::method1(fable_library_rust::String_::fromStr(&v133));
        let v137: string = toString(&format!("{}", &v23));
        let v139: &str = r#""([^"]+)", "([^"]+)""#;
        let v140: regex::RegexBuilder = regex::RegexBuilder::new(&v139);
        let v141: &regex::Regex = &v140.build().unwrap();
        let v142: string = Client::method7(v137);
        let v143: &str = &v142.as_str();
        let v144: string = Client::method8();
        let v145: &str = &v144.as_str();
        let v146: std::string::String =
            v141.replace_all(&v143, v145).to_string();
        let v147: string = fable_library_rust::String_::fromStr(&v146);
        let v149: &str = r#"\["(.*?)"\]"#;
        let v150: regex::RegexBuilder = regex::RegexBuilder::new(&v149);
        let v151: &regex::Regex = &v150.build().unwrap();
        let v152: string = Client::method7(v147);
        let v153: &str = &v152.as_str();
        let v154: string = Client::method9();
        let v155: &str = &v154.as_str();
        let v156: std::string::String =
            v151.replace_all(&v153, v155).to_string();
        let v157: string = fable_library_rust::String_::fromStr(&v156);
        let v159: &str = r#"\\""#;
        let v160: regex::RegexBuilder = regex::RegexBuilder::new(&v159);
        let v161: &regex::Regex = &v160.build().unwrap();
        let v162: string = Client::method7(v157);
        let v163: &str = &v162.as_str();
        let v164: string = Client::method10();
        let v165: &str = &v164.as_str();
        let v166: std::string::String =
            v161.replace_all(&v163, v165).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: &str = r#", "#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Client::method7(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Client::method11();
        let v175: &str = &v174.as_str();
        let v176: std::string::String =
            v171.replace_all(&v173, v175).to_string();
        let v178: std::string::String =
            Client::method1(fable_library_rust::String_::fromStr(&v176));
        if let Client::US0::US0_1 =
               &if cfg!(target_arch = "wasm32") {
                    Client::US0::US0_1
                } else { Client::US0::US0_0 } {
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
            let v205: string = Client::method12();
            let v206: &str = &v205.as_str();
            let v210: &str = &v206[0i32 as usize..2i32 as usize];
            let v211: string = fable_library_rust::String_::fromStr(&v210);
            let v213: u8 = u8::from_str_radix(&v211, 16).unwrap();
            let v214: string = Client::method12();
            let v215: &str = &v214.as_str();
            let v218: &str = &v215[2i32 as usize..4i32 as usize];
            let v219: string = fable_library_rust::String_::fromStr(&v218);
            let v220: u8 = u8::from_str_radix(&v219, 16).unwrap();
            let v221: string = Client::method12();
            let v222: &str = &v221.as_str();
            let v225: &str = &v222[4i32 as usize..6i32 as usize];
            let v226: string = fable_library_rust::String_::fromStr(&v225);
            let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
            let v229: colored::ColoredString =
                colored::Colorize::truecolor(&*v135.to_string(), v213, v220, v227);
            let v230: std::string::String = format!("{}", &v229);
            let v231: string = Client::method13();
            let v232: &str = &v231.as_str();
            let v235: &str = &v232[0i32 as usize..2i32 as usize];
            let v236: string = fable_library_rust::String_::fromStr(&v235);
            let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
            let v238: string = Client::method13();
            let v239: &str = &v238.as_str();
            let v242: &str = &v239[2i32 as usize..4i32 as usize];
            let v243: string = fable_library_rust::String_::fromStr(&v242);
            let v244: u8 = u8::from_str_radix(&v243, 16).unwrap();
            let v245: string = Client::method13();
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
    pub fn method14() -> bool { false }
    pub fn method15(v0_1:
                        (async_std::sync::Mutex<bool>, async_std::sync::Condvar))
     -> (async_std::sync::Mutex<bool>, async_std::sync::Condvar) {
        v0_1
    }
    pub fn method16(v0_1: Option<ehttp::Response>)
     -> Option<ehttp::Response> {
        v0_1
    }
    pub fn method17(v0_1: async_std::sync::Mutex<Option<ehttp::Response>>)
     -> async_std::sync::Mutex<Option<ehttp::Response>> {
        v0_1
    }
    pub fn method18(v0_1:
                        std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>)
     -> std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>> {
        v0_1
    }
    pub fn method19(v0_1: std::string::String) -> std::string::String {
        (&v0_1).clone()
    }
    pub fn closure1(v0_1: i64,
                    v1:
                        std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>) {
        Client::method3(v0_1,
                        array(&[Client::method1(string("app > fetch ()"))]));
        {
            let v6:
                    std::cell::Ref<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
                v1.borrow();
            let v8: Option<_> = v6.try_lock();
            Client::method3(v0_1,
                            array(&[Client::method1(string("response")),
                                    Client::method19(format!("{:?}", &v8))]))
        }
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        console_error_panic_hook::set_once();
        {
            let patternInput: (string, string, string, bool) =
                Client::method0();
            let v6: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v8: i64 = (&v6).timestamp();
            let v10 = web_sys::window().unwrap();
            let v12 = v10.document().unwrap();
            let v14 = v12.body().unwrap();
            let v17: &str = r#"iframe"#;
            let v19 = v12.create_element(v17).unwrap();
            Client::method3(v8,
                            array(&[Client::method1(string("window")),
                                    Client::method2(&v10),
                                    Client::method1(string("document")),
                                    Client::method2(&v12),
                                    Client::method1(string("body")),
                                    Client::method2(&v14),
                                    Client::method1(string("iframe")),
                                    Client::method2(&v19)]));
            {
                let v34: &str = r#"src"#;
                let v37: &str = r#"https://time.is"#;
                v19.set_attribute(v34, v37).unwrap();
                {
                    let v41: &str = r#"width"#;
                    let v44: &str = r#"100%"#;
                    v19.set_attribute(v41, v44).unwrap();
                    {
                        let v47: &str = r#"style"#;
                        let v50: &str = r#"height: 100vh; border: 0;"#;
                        v19.set_attribute(v47, v50).unwrap();
                        {
                            let v53: &str = r#"data-test"#;
                            let v56: &str = r#"1"#;
                            v19.set_attribute(v53, v56).unwrap();
                            v14.append_child(&v19).unwrap();
                            {
                                let v60: std::string::String =
                                    (&string("https://dummyjson.com/users")).to_string();
                                let v62: ehttp::Request =
                                    ehttp::Request::get(&v60);
                                let v63: bool = Client::method14();
                                let v65: async_std::sync::Mutex<bool> =
                                    async_std::sync::Mutex::new(v63);
                                let v67: async_std::sync::Condvar =
                                    async_std::sync::Condvar::new();
                                let v70:
                                        (async_std::sync::Mutex<bool>, async_std::sync::Condvar) =
                                    Client::method15((v65, v67));
                                let v72:
                                        std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                                    std::sync::Arc::new(v70);
                                let v74:
                                        std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                                    v72.clone();
                                let v76: Option<ehttp::Response> =
                                    Client::method16((&None::<_>).clone());
                                let v79:
                                        async_std::sync::Mutex<Option<ehttp::Response>> =
                                    Client::method17(async_std::sync::Mutex::new(v76));
                                let v82:
                                        std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>> =
                                    Client::method18(std::sync::Arc::new(v79));
                                let v84:
                                        std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
                                    std::cell::RefCell::new(v82);
                                let v86:
                                        std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
                                    v84.clone();
                                let v104: string = string("}");
                                let v105: string =
                                    append(string("move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v84.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v74;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });"),
                                           v104.clone());
                                let v106 =
                                    move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v84.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v74;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });};
                                let v108 = Box::new(v106);
                                ehttp::fetch(v62, v108);
                                {
                                    let v121 =
                                        Func1::new({
                                                       let v8 = v8.clone();
                                                       move
                                                           |v:
                                                                std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>|
                                                           Client::closure1(v8,
                                                                            v.clone())
                                                   });
                                    let v124: string =
                                        append(string("async move {  let (lock, cvar) = &*v72;  let mut started = lock.lock().await;  while !*started {    started = cvar.wait(started).await;  }  v121(v86);"),
                                               v104);
                                    let v125 =
                                        async move {  let (lock, cvar) = &*v72;  let mut started = lock.lock().await;  while !*started {    started = cvar.wait(started).await;  }  v121(v86);};
                                    async_std::task::block_on(v125);
                                    Client::method3(v8,
                                                    array(&[Client::method1(string("app end")),
                                                            Client::method1(string("???"))]));
                                    0i32
                                }
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
