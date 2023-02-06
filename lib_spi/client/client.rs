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
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1(v0_1: string) -> std::string::String {
        (&v0_1).to_string().clone()
    }
    pub fn method2(v0_1: std::string::String) -> std::string::String {
        (&v0_1).clone()
    }
    pub fn method4(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method4: loop {
            break '_method4 (if length(v1.get()) < v0_1.get() {
                let v0_1_temp: i32 = v0_1.get();
                let v1_temp: string = stringFrom(format!("0{0}", &v1.get()));
                v0_1.set(v0_1_temp);
                v1.set(v1_temp);
                continue '_method4;
            } else {
                v1.get()
            });
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
    pub fn method7(v0_1: string) -> string {
        v0_1
    }
    pub fn method8() -> string {
        string("$1=$2")
    }
    pub fn method9() -> string {
        string("[$1]")
    }
    pub fn method10() -> string {
        string("\"")
    }
    pub fn method11() -> string {
        string(" ")
    }
    pub fn method3(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Client::method4(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Client::method6(array(&[
            Client::method1(string("timestamp")),
            Client::method1(v9),
            Client::method1(string("run_id")),
            Client::method5(v11),
            Client::method1(string("log_level")),
            Client::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Client::method1(string("> app ()"))]);
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
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Client::method7(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Client::method9();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Client::method7(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Client::method10();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Client::method7(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Client::method11();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String = Client::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Client::method7(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Client::method8();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Client::method7(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Client::method9();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Client::method7(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Client::method10();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Client::method7(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Client::method11();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Client::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Client::method7(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Client::method8();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Client::method7(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Client::method9();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Client::method7(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Client::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Client::method7(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Client::method11();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Client::method1(fable_library_rust::String_::fromStr(&v187));
        let v194: string = string(" %c");
        let v198: string = append(
            append(
                append(append(toString(&v91), v194.clone()), toString(&v143)),
                v194,
            ),
            toString(&v190),
        );
        let v206: Array<std::string::String> = array(&[
            (&v198).as_ref().to_string(),
            (&stringFrom(format!("color: #{0};", &string("387957"))))
                .as_ref()
                .to_string(),
            (&string("color: #385779;")).as_ref().to_string(),
        ]);
        let v207 = core::ops::Deref::deref(&v206);
        let v210: wasm_bindgen::JsValue = serde_wasm_bindgen::to_value(&*****&v207).unwrap();
        web_sys::console::log(&js_sys::Array::from(&&v210));
        ()
    }
    pub fn method12(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Client::method4(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Client::method6(array(&[
            Client::method1(string("timestamp")),
            Client::method1(v9),
            Client::method1(string("run_id")),
            Client::method5(v11),
            Client::method1(string("log_level")),
            Client::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Client::method1(string("> append_css_rule ()"))]);
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
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Client::method7(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Client::method9();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Client::method7(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Client::method10();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Client::method7(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Client::method11();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String = Client::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Client::method7(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Client::method8();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Client::method7(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Client::method9();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Client::method7(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Client::method10();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Client::method7(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Client::method11();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Client::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Client::method7(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Client::method8();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Client::method7(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Client::method9();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Client::method7(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Client::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Client::method7(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Client::method11();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Client::method1(fable_library_rust::String_::fromStr(&v187));
        let v194: string = string(" %c");
        let v198: string = append(
            append(
                append(append(toString(&v91), v194.clone()), toString(&v143)),
                v194,
            ),
            toString(&v190),
        );
        let v206: Array<std::string::String> = array(&[
            (&v198).as_ref().to_string(),
            (&stringFrom(format!("color: #{0};", &string("666666"))))
                .as_ref()
                .to_string(),
            (&string("color: #385779;")).as_ref().to_string(),
        ]);
        let v207 = core::ops::Deref::deref(&v206);
        let v210: wasm_bindgen::JsValue = serde_wasm_bindgen::to_value(&*****&v207).unwrap();
        web_sys::console::log(&js_sys::Array::from(&&v210));
        ()
    }
    pub fn method13() -> bool {
        false
    }
    pub fn method14(
        v0_1: (async_std::sync::Mutex<bool>, async_std::sync::Condvar),
    ) -> (async_std::sync::Mutex<bool>, async_std::sync::Condvar) {
        v0_1
    }
    pub fn method15(v0_1: Option<ehttp::Response>) -> Option<ehttp::Response> {
        v0_1
    }
    pub fn method16(
        v0_1: async_std::sync::Mutex<Option<ehttp::Response>>,
    ) -> async_std::sync::Mutex<Option<ehttp::Response>> {
        v0_1
    }
    pub fn method17(
        v0_1: std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>,
    ) -> std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>> {
        v0_1
    }
    pub fn closure1(
        v0_1: i64,
        v1: std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>,
    ) {
        Client::method3(v0_1, array(&[Client::method1(string("app > fetch ()"))]));
        {
            let v6: std::cell::Ref<
                std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>,
            > = v1.borrow();
            let v8: Option<_> = v6.try_lock();
            Client::method3(
                v0_1,
                array(&[
                    Client::method1(string("response")),
                    Client::method2(format!("{:?}", &v8)),
                ]),
            )
        }
    }
    pub fn method18(
        v0_1: futures_signals::signal::MutableSignal<&'static str>,
    ) -> futures_signals::signal::MutableSignal<&'static str> {
        v0_1
    }
    pub fn closure3(
        v0_1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v1: &'static str,
    ) {
        *&v0_1.set_neq(v1);
        ()
    }
    pub fn closure2(
        v0_1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v1: std::rc::Rc<web_sys::HtmlInputElement>,
    ) {
        let v11 = Func1::new({
            let v0_1 = v0_1.clone();
            move |v: &'static str| Client::closure3(v0_1.clone(), v.clone())
        });
        let value0 = v1;
        let value0 = value0.value();
        let value0 = value0.into_boxed_str();
        let value0 = Box::leak(value0);
        v11(value0);
        ();
        ()
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        console_error_panic_hook::set_once();
        {
            let patternInput: (string, string, string, bool) = Client::method0();
            let v6: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v8: i64 = (&v6).timestamp();
            let v10 = web_sys::window().unwrap();
            let v12 = v10.document().unwrap();
            let v14 = v12.head().unwrap();
            let v17: &str = r#"style"#;
            let v19 = v12.create_element(v17).unwrap();
            let v21: web_sys::HtmlStyleElement = wasm_bindgen::JsCast::unchecked_into(v19);
            let v23: std::rc::Rc<web_sys::HtmlStyleElement> = std::rc::Rc::new(v21);
            Client::method3(
                v8,
                array(&[
                    Client::method1(string("window")),
                    Client::method2(format!("{:?}", v10)),
                    Client::method1(string("document")),
                    Client::method2(format!("{:?}", v12)),
                    Client::method1(string("head")),
                    Client::method2(format!("{:?}", v14)),
                    Client::method1(string("style")),
                    Client::method2(format!("{:?}", &v23)),
                ]),
            );
            {
                let v43: &str = r#"type"#;
                let v46: &str = r#"text/css"#;
                v23.clone().set_attribute(v43, v46).unwrap();
                {
                    let v50: &str = r#"data-id"#;
                    let v53: &str = r#"global-css"#;
                    v23.clone().set_attribute(v50, v53).unwrap();
                    v14.append_child(&v23).unwrap();
                    {
                        let patternInput_1: (string, string, string, bool) = Client::method0();
                        let v59: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                        let v60: i64 = (&v59).timestamp();
                        let v62 = v23.sheet();
                        let v64 = v62.unwrap();
                        let v66: string = string("web_sys::CssStyleSheet");
                        let v69: string = append(
                            append(
                                string("wasm_bindgen::JsCast::unchecked_into::<"),
                                v66.clone(),
                            ),
                            string(">(v64)"),
                        );
                        let v70 =
                            wasm_bindgen::JsCast::unchecked_into::<web_sys::CssStyleSheet>(v64);
                        let v74: string = string("0");
                        let v78: string = string("");
                        let v88: string = string("width");
                        let v90: string = string("100%");
                        let v96: string = string("height");
                        let v111: string = string("html, body");
                        let v119: string = append(
                            append(
                                append(
                                    append(append(v111.clone(), string(" {")), string("  ")),
                                    append(
                                        string("overflow: hidden;"),
                                        append(
                                            append(
                                                append(
                                                    append(v96.clone(), string(": ")),
                                                    v90.clone(),
                                                ),
                                                string(";"),
                                            ),
                                            append(
                                                append(
                                                    append(append(v88.clone(), string(": ")), v90),
                                                    string(";"),
                                                ),
                                                append(
                                                    append(
                                                        append(string("padding: "), v74.clone()),
                                                        string(";"),
                                                    ),
                                                    append(
                                                        append(
                                                            append(string("margin: "), v74),
                                                            string(";"),
                                                        ),
                                                        v78.clone(),
                                                    ),
                                                ),
                                            ),
                                        ),
                                    ),
                                ),
                                string(" "),
                            ),
                            string("}"),
                        );
                        let v121: &str = r#"html, body {  overflow: hidden;height: 100%;width: 100%;padding: 0;margin: 0; }"#;
                        let v123 = v70.insert_rule(v121).unwrap();
                        let v124: string = string("rule");
                        let v127: string = string("idx");
                        Client::method12(
                            v60,
                            array(&[
                                Client::method1(v124.clone()),
                                Client::method1(v111),
                                Client::method1(v127.clone()),
                                Client::method2(format!("{:?}", v123)),
                            ]),
                        );
                        {
                            let patternInput_2: (string, string, string, bool) = Client::method0();
                            let v136: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                            let v137: i64 = (&v136).timestamp();
                            let v139 = v23.sheet();
                            let v141 = v139.unwrap();
                            let v145: string = append(
                                append(
                                    string("wasm_bindgen::JsCast::unchecked_into::<"),
                                    v66.clone(),
                                ),
                                string(">(v141)"),
                            );
                            let v146 = wasm_bindgen::JsCast::unchecked_into::<web_sys::CssStyleSheet>(
                                v141,
                            );
                            let v172: string = string("display");
                            let v198: string = string("stretch");
                            let v211: string = string("body");
                            let v219: string =
                                append(append(append(append(append(v211.clone(),
                                                                   string(" {")),
                                                            string("  ")),
                                                     append(append(append(string("align-content: "),
                                                                          v198.clone()),
                                                                   string(";")),
                                                            append(append(append(string("align-items: "),
                                                                                 v198),
                                                                          string(";")),
                                                                   append(string("box-sizing: border-box;"),
                                                                          append(string("flex-direction: row;"),
                                                                                 append(append(append(append(v172.clone(),
                                                                                                             string(": ")),
                                                                                                      string("flex")),
                                                                                               string(";")),
                                                                                        append(string("-moz-osx-font-smoothing: grayscale;"),
                                                                                               append(string("-webkit-font-smoothing: antialiased;"),
                                                                                                      append(string("font-family: system-ui, -apple-system, BlinkMacSystemFont, \"Roboto\", sans-serif;"),
                                                                                                             v78.clone()))))))))),
                                              string(" ")), string("}"));
                            let v221: &str = r#"body {  align-content: stretch;align-items: stretch;box-sizing: border-box;flex-direction: row;display: flex;-moz-osx-font-smoothing: grayscale;-webkit-font-smoothing: antialiased;font-family: system-ui, -apple-system, BlinkMacSystemFont, "Roboto", sans-serif; }"#;
                            let v223 = v146.insert_rule(v221).unwrap();
                            Client::method12(
                                v137,
                                array(&[
                                    Client::method1(v124.clone()),
                                    Client::method1(v211),
                                    Client::method1(v127.clone()),
                                    Client::method2(format!("{:?}", v223)),
                                ]),
                            );
                            {
                                let patternInput_3: (string, string, string, bool) =
                                    Client::method0();
                                let v234: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                                let v235: i64 = (&v234).timestamp();
                                let v237 = v23.sheet();
                                let v239 = v237.unwrap();
                                let v243: string = append(
                                    append(
                                        string("wasm_bindgen::JsCast::unchecked_into::<"),
                                        v66.clone(),
                                    ),
                                    string(">(v239)"),
                                );
                                let v244 = wasm_bindgen::JsCast::unchecked_into::<
                                    web_sys::CssStyleSheet,
                                >(v239);
                                let v253: string = string("*::-webkit-scrollbar");
                                let v261: string = append(
                                    append(
                                        append(
                                            append(
                                                append(v253.clone(), string(" {")),
                                                string("  "),
                                            ),
                                            append(
                                                append(
                                                    append(
                                                        append(v88, string(": ")),
                                                        string("11px"),
                                                    ),
                                                    string(";"),
                                                ),
                                                v78.clone(),
                                            ),
                                        ),
                                        string(" "),
                                    ),
                                    string("}"),
                                );
                                let v263: &str = r#"*::-webkit-scrollbar {  width: 11px; }"#;
                                let v265 = v244.insert_rule(v263).unwrap();
                                Client::method12(
                                    v235,
                                    array(&[
                                        Client::method1(v124.clone()),
                                        Client::method1(v253),
                                        Client::method1(v127.clone()),
                                        Client::method2(format!("{:?}", v265)),
                                    ]),
                                );
                                {
                                    let patternInput_4: (string, string, string, bool) =
                                        Client::method0();
                                    let v276: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                                    let v277: i64 = (&v276).timestamp();
                                    let v279 = v23.sheet();
                                    let v281 = v279.unwrap();
                                    let v285: string = append(
                                        append(
                                            string("wasm_bindgen::JsCast::unchecked_into::<"),
                                            v66.clone(),
                                        ),
                                        string(">(v281)"),
                                    );
                                    let v286 = wasm_bindgen::JsCast::unchecked_into::<
                                        web_sys::CssStyleSheet,
                                    >(v281);
                                    let v295: string = string("*::-webkit-scrollbar:horizontal");
                                    let v303: string = append(
                                        append(
                                            append(
                                                append(
                                                    append(v295.clone(), string(" {")),
                                                    string("  "),
                                                ),
                                                append(
                                                    append(
                                                        append(
                                                            append(v96, string(": ")),
                                                            string("8px"),
                                                        ),
                                                        string(";"),
                                                    ),
                                                    v78.clone(),
                                                ),
                                            ),
                                            string(" "),
                                        ),
                                        string("}"),
                                    );
                                    let v305: &str =
                                        r#"*::-webkit-scrollbar:horizontal {  height: 8px; }"#;
                                    let v307 = v286.insert_rule(v305).unwrap();
                                    Client::method12(
                                        v277,
                                        array(&[
                                            Client::method1(v124.clone()),
                                            Client::method1(v295),
                                            Client::method1(v127.clone()),
                                            Client::method2(format!("{:?}", v307)),
                                        ]),
                                    );
                                    {
                                        let patternInput_5: (string, string, string, bool) =
                                            Client::method0();
                                        let v318: chrono::DateTime<chrono::Utc> =
                                            chrono::Utc::now();
                                        let v319: i64 = (&v318).timestamp();
                                        let v321 = v23.sheet();
                                        let v323 = v321.unwrap();
                                        let v327: string = append(
                                            append(
                                                string("wasm_bindgen::JsCast::unchecked_into::<"),
                                                v66.clone(),
                                            ),
                                            string(">(v323)"),
                                        );
                                        let v328 = wasm_bindgen::JsCast::unchecked_into::<
                                            web_sys::CssStyleSheet,
                                        >(v323);
                                        let v331: string = string("none");
                                        let v337: string = string("*::-webkit-scrollbar-track");
                                        let v345: string = append(
                                            append(
                                                append(
                                                    append(
                                                        append(v337.clone(), string(" {")),
                                                        string("  "),
                                                    ),
                                                    append(
                                                        append(
                                                            append(
                                                                append(v172.clone(), string(": ")),
                                                                v331.clone(),
                                                            ),
                                                            string(";"),
                                                        ),
                                                        v78.clone(),
                                                    ),
                                                ),
                                                string(" "),
                                            ),
                                            string("}"),
                                        );
                                        let v347: &str =
                                            r#"*::-webkit-scrollbar-track {  display: none; }"#;
                                        let v349 = v328.insert_rule(v347).unwrap();
                                        Client::method12(
                                            v319,
                                            array(&[
                                                Client::method1(v124.clone()),
                                                Client::method1(v337),
                                                Client::method1(v127.clone()),
                                                Client::method2(format!("{:?}", v349)),
                                            ]),
                                        );
                                        {
                                            let patternInput_6: (string, string, string, bool) =
                                                Client::method0();
                                            let v360: chrono::DateTime<chrono::Utc> =
                                                chrono::Utc::now();
                                            let v361: i64 = (&v360).timestamp();
                                            let v363 = v23.sheet();
                                            let v365 = v363.unwrap();
                                            let v369: string = append(
                                                append(
                                                    string(
                                                        "wasm_bindgen::JsCast::unchecked_into::<",
                                                    ),
                                                    v66.clone(),
                                                ),
                                                string(">(v365)"),
                                            );
                                            let v370 = wasm_bindgen::JsCast::unchecked_into::<
                                                web_sys::CssStyleSheet,
                                            >(
                                                v365
                                            );
                                            let v378: string =
                                                string("*::-webkit-scrollbar-corner");
                                            let v386: string = append(
                                                append(
                                                    append(
                                                        append(
                                                            append(v378.clone(), string(" {")),
                                                            string("  "),
                                                        ),
                                                        append(
                                                            append(
                                                                append(
                                                                    append(v172, string(": ")),
                                                                    v331,
                                                                ),
                                                                string(";"),
                                                            ),
                                                            v78.clone(),
                                                        ),
                                                    ),
                                                    string(" "),
                                                ),
                                                string("}"),
                                            );
                                            let v388: &str = r#"*::-webkit-scrollbar-corner {  display: none; }"#;
                                            let v390 = v370.insert_rule(v388).unwrap();
                                            Client::method12(
                                                v361,
                                                array(&[
                                                    Client::method1(v124.clone()),
                                                    Client::method1(v378),
                                                    Client::method1(v127.clone()),
                                                    Client::method2(format!("{:?}", v390)),
                                                ]),
                                            );
                                            {
                                                let patternInput_7: (string, string, string, bool) =
                                                    Client::method0();
                                                let v401: chrono::DateTime<chrono::Utc> =
                                                    chrono::Utc::now();
                                                let v402: i64 = (&v401).timestamp();
                                                let v404 = v23.sheet();
                                                let v406 = v404.unwrap();
                                                let v410: string =
                                                    append(append(string("wasm_bindgen::JsCast::unchecked_into::<"),
                                                                  v66.clone()),
                                                           string(">(v406)"));
                                                let v411 = wasm_bindgen::JsCast::unchecked_into::<
                                                    web_sys::CssStyleSheet,
                                                >(
                                                    v406
                                                );
                                                let v413: string = string("background");
                                                let v429: string = string("background-clip");
                                                let v431: string = string("content-box");
                                                let v437: string = string("border-left");
                                                let v439: string = string("2px solid transparent");
                                                let v445: string =
                                                    string("*::-webkit-scrollbar-thumb");
                                                let v453: string = append(
                                                    append(
                                                        append(
                                                            append(
                                                                append(v445.clone(), string(" {")),
                                                                string("  "),
                                                            ),
                                                            append(
                                                                append(
                                                                    append(
                                                                        append(
                                                                            v437.clone(),
                                                                            string(": "),
                                                                        ),
                                                                        v439.clone(),
                                                                    ),
                                                                    string(";"),
                                                                ),
                                                                append(
                                                                    append(
                                                                        append(
                                                                            append(
                                                                                v429.clone(),
                                                                                string(": "),
                                                                            ),
                                                                            v431.clone(),
                                                                        ),
                                                                        string(";"),
                                                                    ),
                                                                    append(
                                                                        string("opacity: 0.8;"),
                                                                        append(
                                                                            append(
                                                                                append(
                                                                                    append(
                                                                                        v413.clone(
                                                                                        ),
                                                                                        string(
                                                                                            ": ",
                                                                                        ),
                                                                                    ),
                                                                                    string("#555"),
                                                                                ),
                                                                                string(";"),
                                                                            ),
                                                                            v78.clone(),
                                                                        ),
                                                                    ),
                                                                ),
                                                            ),
                                                        ),
                                                        string(" "),
                                                    ),
                                                    string("}"),
                                                );
                                                let v455: &str = r#"*::-webkit-scrollbar-thumb {  border-left: 2px solid transparent;background-clip: content-box;opacity: 0.8;background: #555; }"#;
                                                let v457 = v411.insert_rule(v455).unwrap();
                                                Client::method12(
                                                    v402,
                                                    array(&[
                                                        Client::method1(v124.clone()),
                                                        Client::method1(v445),
                                                        Client::method1(v127.clone()),
                                                        Client::method2(format!("{:?}", v457)),
                                                    ]),
                                                );
                                                {
                                                    let patternInput_8: (
                                                        string,
                                                        string,
                                                        string,
                                                        bool,
                                                    ) = Client::method0();
                                                    let v468: chrono::DateTime<chrono::Utc> =
                                                        chrono::Utc::now();
                                                    let v469: i64 = (&v468).timestamp();
                                                    let v471 = v23.sheet();
                                                    let v473 = v471.unwrap();
                                                    let v477: string =
                                                        append(append(string("wasm_bindgen::JsCast::unchecked_into::<"),
                                                                      v66),
                                                               string(">(v473)"));
                                                    let v478 = wasm_bindgen::JsCast::unchecked_into::<
                                                        web_sys::CssStyleSheet,
                                                    >(
                                                        v473
                                                    );
                                                    let v499: string =
                                                        string("*::-webkit-scrollbar-thumb:hover");
                                                    let v507: string = append(
                                                        append(
                                                            append(
                                                                append(
                                                                    append(
                                                                        v499.clone(),
                                                                        string(" {"),
                                                                    ),
                                                                    string("  "),
                                                                ),
                                                                append(
                                                                    append(
                                                                        append(
                                                                            append(
                                                                                v437,
                                                                                string(": "),
                                                                            ),
                                                                            v439,
                                                                        ),
                                                                        string(";"),
                                                                    ),
                                                                    append(
                                                                        append(
                                                                            append(
                                                                                append(
                                                                                    v429,
                                                                                    string(": "),
                                                                                ),
                                                                                v431,
                                                                            ),
                                                                            string(";"),
                                                                        ),
                                                                        append(
                                                                            append(
                                                                                append(
                                                                                    append(
                                                                                        v413,
                                                                                        string(
                                                                                            ": ",
                                                                                        ),
                                                                                    ),
                                                                                    string("#ccc"),
                                                                                ),
                                                                                string(";"),
                                                                            ),
                                                                            v78.clone(),
                                                                        ),
                                                                    ),
                                                                ),
                                                            ),
                                                            string(" "),
                                                        ),
                                                        string("}"),
                                                    );
                                                    let v509: &str = r#"*::-webkit-scrollbar-thumb:hover {  border-left: 2px solid transparent;background-clip: content-box;background: #ccc; }"#;
                                                    let v511 = v478.insert_rule(v509).unwrap();
                                                    Client::method12(
                                                        v469,
                                                        array(&[
                                                            Client::method1(v124),
                                                            Client::method1(v499),
                                                            Client::method1(v127),
                                                            Client::method2(format!("{:?}", v511)),
                                                        ]),
                                                    );
                                                    {
                                                        let v520: std::string::String = (&string(
                                                            "https://dummyjson.com/users",
                                                        ))
                                                            .to_string();
                                                        let v522: ehttp::Request =
                                                            ehttp::Request::get(&v520);
                                                        let v523: bool = Client::method13();
                                                        let v525: async_std::sync::Mutex<bool> =
                                                            async_std::sync::Mutex::new(v523);
                                                        let v527: async_std::sync::Condvar =
                                                            async_std::sync::Condvar::new();
                                                        let v530: (
                                                            async_std::sync::Mutex<bool>,
                                                            async_std::sync::Condvar,
                                                        ) = Client::method14((v525, v527));
                                                        let v532: std::sync::Arc<(
                                                            async_std::sync::Mutex<bool>,
                                                            async_std::sync::Condvar,
                                                        )> = std::sync::Arc::new(v530);
                                                        let v534: std::sync::Arc<(
                                                            async_std::sync::Mutex<bool>,
                                                            async_std::sync::Condvar,
                                                        )> = v532.clone();
                                                        let v536: Option<ehttp::Response> =
                                                            Client::method15((&None::<_>).clone());
                                                        let v539: async_std::sync::Mutex<
                                                            Option<ehttp::Response>,
                                                        > = Client::method16(
                                                            async_std::sync::Mutex::new(v536),
                                                        );
                                                        let v542: std::sync::Arc<
                                                            async_std::sync::Mutex<
                                                                Option<ehttp::Response>,
                                                            >,
                                                        > = Client::method17(std::sync::Arc::new(
                                                            v539,
                                                        ));
                                                        let v544: std::cell::RefCell<
                                                            std::sync::Arc<
                                                                async_std::sync::Mutex<
                                                                    Option<ehttp::Response>,
                                                                >,
                                                            >,
                                                        > = std::cell::RefCell::new(v542);
                                                        let v546: std::cell::RefCell<
                                                            std::sync::Arc<
                                                                async_std::sync::Mutex<
                                                                    Option<ehttp::Response>,
                                                                >,
                                                            >,
                                                        > = v544.clone();
                                                        let v564: string = string("}");
                                                        let v565: string =
                                                            append(string("move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v544.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v534;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });"),
                                                                   v564.clone());
                                                        let v566 =
                                                            move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v544.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v534;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });};
                                                        let v568 = Box::new(v566);
                                                        ehttp::fetch(v522, v568);
                                                        {
                                                            let v581 = Func1::new({
                                                                let v8 = v8.clone();
                                                                move
                                                                                   |v:
                                                                                        std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>|
                                                                                   Client::closure1(v8,
                                                                                                    v.clone())
                                                            });
                                                            let v584: string =
                                                                append(string("async move {  let (lock, cvar) = &*v532;  let mut started = lock.lock().await;  while !*started {    started = cvar.wait(started).await;  }  v581(v546);"),
                                                                       v564.clone());
                                                            let v585 = async move {
                                                                let (lock, cvar) = &*v532;
                                                                let mut started = lock.lock().await;
                                                                while !*started {
                                                                    started =
                                                                        cvar.wait(started).await;
                                                                }
                                                                v581(v546);
                                                            };
                                                            async_std::task::block_on(v585);
                                                            {
                                                                let v590: &'static str =
                                                                    r#"https://time.is"#.clone();
                                                                let v592:
                                                                        futures_signals::signal::Mutable<&'static str> =
                                                                    futures_signals::signal::Mutable::new(v590);
                                                                let v594:
                                                                        std::rc::Rc<futures_signals::signal::Mutable<&'static str>> =
                                                                    std::rc::Rc::new(v592);
                                                                let v597: &str = r#"input"#;
                                                                let v599: dominator::DomBuilder<
                                                                    web_sys::HtmlInputElement,
                                                                > = dominator::DomBuilder::new_html(
                                                                    &v597,
                                                                );
                                                                let v602: &str = r#"color"#;
                                                                let v605: &str = r#"#666"#;
                                                                let v610:
                                                                        string =
                                                                    append(append(string("dominator::class! {"),
                                                                                  append(v78.clone(),
                                                                                         string(" .style(v602, v605) "))),
                                                                           v564.clone());
                                                                let v611 = dominator::class! { .style(v602, v605) };
                                                                let v613: dominator::DomBuilder<
                                                                    web_sys::HtmlInputElement,
                                                                > = v599.class(&*v611);
                                                                let v616: &str = r#"placeholder"#;
                                                                let v619: &str = r#"url"#;
                                                                let v621: dominator::DomBuilder<
                                                                    web_sys::HtmlInputElement,
                                                                > = v613.attr(v616, v619);
                                                                let v623:
                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                    v594.signal();
                                                                let v626: &str = r#"value"#;
                                                                let v627:
                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                    Client::method18(v623);
                                                                let v629: dominator::DomBuilder<
                                                                    web_sys::HtmlInputElement,
                                                                > = v621.prop_signal(v626, v627);
                                                                let v631 = Func1::new({
                                                                    let v594 = v594.clone();
                                                                    move
                                                                                       |v_1:
                                                                                            std::rc::Rc<web_sys::HtmlInputElement>|
                                                                                       Client::closure2(v594.clone(),
                                                                                                        v_1.clone())
                                                                });
                                                                let v658:
                                                                        string =
                                                                    append(append(append(append(string("dominator::with_node!(   v629,   element => {      "),
                                                                                                append(string(".event(dominator::clone!(  v631 => move |_: dominator::events::Input| {    let element_ = std::rc::Rc::new(&element);     let el = (*element_).clone().into();     v631(el);   }))"),
                                                                                                       v78.clone())),
                                                                                         string(" ")),
                                                                                  string("   }")),
                                                                           string(")"));
                                                                let v659: dominator::DomBuilder<
                                                                    web_sys::HtmlInputElement,
                                                                > = dominator::with_node!(   v629,   element => {      .event(dominator::clone!(  v631 => move |_: dominator::events::Input| {    let element_ = std::rc::Rc::new(&element);     let el = (*element_).clone().into();     v631(el);   }))    });
                                                                let v661: dominator::Dom =
                                                                    v659.into_dom();
                                                                let v664: &str = r#"iframe"#;
                                                                let v666: dominator::DomBuilder<
                                                                    web_sys::HtmlElement,
                                                                > = dominator::DomBuilder::new_html(
                                                                    &v664,
                                                                );
                                                                let v668: &str = r#"width"#;
                                                                let v670: &str = r#"100%"#;
                                                                let v672: string = append(
                                                                    v78.clone(),
                                                                    string(" .style(v668, v670) "),
                                                                );
                                                                let v674: &str = r#"flex"#;
                                                                let v677: &str = r#"1"#;
                                                                let v679: string = append(
                                                                    v672,
                                                                    string(" .style(v674, v677) "),
                                                                );
                                                                let v682: &str = r#"border"#;
                                                                let v684: &str = r#"0"#;
                                                                let v689:
                                                                        string =
                                                                    append(append(string("dominator::class! {"),
                                                                                  append(v679,
                                                                                         string(" .style(v682, v684) "))),
                                                                           v564.clone());
                                                                let v690 = dominator::class! { .style(v668, v670)  .style(v674, v677)  .style(v682, v684) };
                                                                let v692: dominator::DomBuilder<
                                                                    web_sys::HtmlElement,
                                                                > = v666.class(&*v690);
                                                                let v695: &str = r#"title"#;
                                                                let v697: &str = r#"title"#;
                                                                let v699: dominator::DomBuilder<
                                                                    web_sys::HtmlElement,
                                                                > = v692.attr(v695, v697);
                                                                let v701:
                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                    v594.signal();
                                                                let v704: &str = r#"src"#;
                                                                let v705:
                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                    Client::method18(v701);
                                                                let v707: dominator::DomBuilder<
                                                                    web_sys::HtmlElement,
                                                                > = v699.prop_signal(v704, v705);
                                                                let v709: dominator::Dom =
                                                                    v707.into_dom();
                                                                let v712: &str = r#"div"#;
                                                                let v714: dominator::DomBuilder<
                                                                    web_sys::HtmlElement,
                                                                > = dominator::DomBuilder::new_html(
                                                                    &v712,
                                                                );
                                                                let v717: &str =
                                                                    r#"background-color"#;
                                                                let v719: &str = r#"#666"#;
                                                                let v721: string = append(
                                                                    v78.clone(),
                                                                    string(" .style(v717, v719) "),
                                                                );
                                                                let v723: &str = r#"display"#;
                                                                let v725: &str = r#"flex"#;
                                                                let v727: string = append(
                                                                    v721,
                                                                    string(" .style(v723, v725) "),
                                                                );
                                                                let v729: &str = r#"flex"#;
                                                                let v731: &str = r#"1"#;
                                                                let v733: string = append(
                                                                    v727,
                                                                    string(" .style(v729, v731) "),
                                                                );
                                                                let v735: &str =
                                                                    r#"flex-direction"#;
                                                                let v738: &str = r#"column"#;
                                                                let v743:
                                                                        string =
                                                                    append(append(string("dominator::class! {"),
                                                                                  append(v733,
                                                                                         string(" .style(v735, v738) "))),
                                                                           v564);
                                                                let v744 = dominator::class! { .style(v717, v719)  .style(v723, v725)  .style(v729, v731)  .style(v735, v738) };
                                                                let v746: dominator::DomBuilder<
                                                                    web_sys::HtmlElement,
                                                                > = v714.class(&*v744);
                                                                let v754: string = append(
                                                                    append(
                                                                        string("["),
                                                                        append(
                                                                            append(
                                                                                v78,
                                                                                string("v661"),
                                                                            ),
                                                                            string(", v709"),
                                                                        ),
                                                                    ),
                                                                    string("]"),
                                                                );
                                                                let v755 = [v661, v709];
                                                                let v757: dominator::DomBuilder<
                                                                    web_sys::HtmlElement,
                                                                > = v746.children(v755);
                                                                let v759: dominator::Dom =
                                                                    v757.into_dom();
                                                                let v761: web_sys::HtmlElement =
                                                                    dominator::body();
                                                                dominator::append_dom(&v761, v759);
                                                                Client::method3(
                                                                    v8,
                                                                    array(&[
                                                                        Client::method1(string(
                                                                            "app end",
                                                                        )),
                                                                        Client::method1(string(
                                                                            "???",
                                                                        )),
                                                                    ]),
                                                                );
                                                                0i32
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
    pub fn v0() -> Func0<i32> {
        static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        v0.get_or_init(move || Func0::new(move || Client::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;
