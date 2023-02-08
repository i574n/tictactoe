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
    use fable_library_rust::Native_::Any;
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
    pub fn method13(v0_1: &str) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method14(v0_1: &dyn Any) -> std::string::String {
        format!("{:?}", v0_1.clone()).clone()
    }
    pub fn method16(v0_1: i32) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn closure1(v0_1: i64, v1: i32) {
        Client::method3(
            v0_1,
            array(&[Client::method1(string("log_n")), Client::method16(v1)]),
        );
    }
    pub fn method15(v0_1: i64) -> Func1<i32, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Client::closure1(v0_1, v)
        })
    }
    pub fn method17() -> string {
        string("name")
    }
    pub fn method18() -> std::string::String {
        (&string("store")).to_string()
    }
    pub fn method19() -> std::string::String {
        (&string("store")).to_string()
    }
    pub fn method20() -> wasm_bindgen::JsValue {
        wasm_bindgen::JsValue::from_str(&string("key"))
    }
    pub fn method21() -> wasm_bindgen::JsValue {
        wasm_bindgen::JsValue::from_str(&string("value"))
    }
    pub fn closure2(unitVar: (), v0_1: string) -> indexed_db_futures::request::OpenDbRequest {
        let v2: std::string::String = (&v0_1).to_string();
        indexed_db_futures::IdbDatabase::open_u32(&v2, 1).unwrap()
    }
    pub fn method22() -> bool {
        false
    }
    pub fn method23(
        v0_1: (async_std::sync::Mutex<bool>, async_std::sync::Condvar),
    ) -> (async_std::sync::Mutex<bool>, async_std::sync::Condvar) {
        v0_1
    }
    pub fn method24(v0_1: Option<ehttp::Response>) -> Option<ehttp::Response> {
        v0_1
    }
    pub fn method25(
        v0_1: async_std::sync::Mutex<Option<ehttp::Response>>,
    ) -> async_std::sync::Mutex<Option<ehttp::Response>> {
        v0_1
    }
    pub fn closure3(
        v0_1: i64,
        v1: std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>,
    ) {
        let v3: std::cell::Ref<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
            v1.borrow();
        let v5: Option<_> = v3.try_lock();
        Client::method3(
            v0_1,
            array(&[
                Client::method1(string("app > fetch ()")),
                Client::method1(string("")),
                Client::method1(string("response")),
                Client::method2(format!("{:?}", &v5)),
            ]),
        )
    }
    pub fn method26(
        v0_1: futures_signals::signal::MutableSignal<&'static str>,
    ) -> futures_signals::signal::MutableSignal<&'static str> {
        v0_1
    }
    pub fn closure5(
        v0_1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v1: &'static str,
    ) {
        *&v0_1.set_neq(v1);
        ()
    }
    pub fn closure4(
        v0_1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v1: std::rc::Rc<web_sys::HtmlInputElement>,
    ) {
        let v11 = Func1::new({
            let v0_1 = v0_1.clone();
            move |v: &'static str| Client::closure5(v0_1.clone(), v.clone())
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
                    Client::method1(string("style")),
                    Client::method2(format!("{:?}", &v23)),
                ]),
            );
            {
                let v31: &str = r#"type"#;
                let v34: &str = r#"text/css"#;
                v23.clone().set_attribute(v31, v34).unwrap();
                {
                    let v38: &str = r#"data-id"#;
                    let v41: &str = r#"global-css"#;
                    v23.clone().set_attribute(v38, v41).unwrap();
                    v14.append_child(&v23).unwrap();
                    {
                        let patternInput_1: (string, string, string, bool) = Client::method0();
                        let v47: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                        let v48: i64 = (&v47).timestamp();
                        let v50 = v23.sheet();
                        let v52 = v50.unwrap();
                        let v54: string = string("web_sys::CssStyleSheet");
                        let v57: string = append(
                            append(
                                string("wasm_bindgen::JsCast::unchecked_into::<"),
                                v54.clone(),
                            ),
                            string(">(v52)"),
                        );
                        let v58 =
                            wasm_bindgen::JsCast::unchecked_into::<web_sys::CssStyleSheet>(v52);
                        let v62: string = string("0");
                        let v66: string = string("");
                        let v76: string = string("width");
                        let v78: string = string("100%");
                        let v84: string = string("height");
                        let v99: string = string("html, body");
                        let v107: string = append(
                            append(
                                append(
                                    append(append(v99.clone(), string(" {")), string("  ")),
                                    append(
                                        string("overflow: hidden;"),
                                        append(
                                            append(
                                                append(
                                                    append(v84.clone(), string(": ")),
                                                    v78.clone(),
                                                ),
                                                string(";"),
                                            ),
                                            append(
                                                append(
                                                    append(append(v76.clone(), string(": ")), v78),
                                                    string(";"),
                                                ),
                                                append(
                                                    append(
                                                        append(string("padding: "), v62.clone()),
                                                        string(";"),
                                                    ),
                                                    append(
                                                        append(
                                                            append(string("margin: "), v62),
                                                            string(";"),
                                                        ),
                                                        v66.clone(),
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
                        let v109: &str = r#"html, body {  overflow: hidden;height: 100%;width: 100%;padding: 0;margin: 0; }"#;
                        let v111 = v58.insert_rule(v109).unwrap();
                        let v112: string = string("rule");
                        let v115: string = string("idx");
                        Client::method12(
                            v48,
                            array(&[
                                Client::method1(v112.clone()),
                                Client::method1(v99),
                                Client::method1(v115.clone()),
                                Client::method2(format!("{:?}", v111)),
                            ]),
                        );
                        {
                            let patternInput_2: (string, string, string, bool) = Client::method0();
                            let v124: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                            let v125: i64 = (&v124).timestamp();
                            let v127 = v23.sheet();
                            let v129 = v127.unwrap();
                            let v133: string = append(
                                append(
                                    string("wasm_bindgen::JsCast::unchecked_into::<"),
                                    v54.clone(),
                                ),
                                string(">(v129)"),
                            );
                            let v134 = wasm_bindgen::JsCast::unchecked_into::<web_sys::CssStyleSheet>(
                                v129,
                            );
                            let v160: string = string("display");
                            let v186: string = string("stretch");
                            let v199: string = string("body");
                            let v207: string =
                                append(append(append(append(append(v199.clone(),
                                                                   string(" {")),
                                                            string("  ")),
                                                     append(append(append(string("align-content: "),
                                                                          v186.clone()),
                                                                   string(";")),
                                                            append(append(append(string("align-items: "),
                                                                                 v186),
                                                                          string(";")),
                                                                   append(string("box-sizing: border-box;"),
                                                                          append(string("flex-direction: row;"),
                                                                                 append(append(append(append(v160.clone(),
                                                                                                             string(": ")),
                                                                                                      string("flex")),
                                                                                               string(";")),
                                                                                        append(string("-moz-osx-font-smoothing: grayscale;"),
                                                                                               append(string("-webkit-font-smoothing: antialiased;"),
                                                                                                      append(string("font-family: system-ui, -apple-system, BlinkMacSystemFont, \"Roboto\", sans-serif;"),
                                                                                                             v66.clone()))))))))),
                                              string(" ")), string("}"));
                            let v209: &str = r#"body {  align-content: stretch;align-items: stretch;box-sizing: border-box;flex-direction: row;display: flex;-moz-osx-font-smoothing: grayscale;-webkit-font-smoothing: antialiased;font-family: system-ui, -apple-system, BlinkMacSystemFont, "Roboto", sans-serif; }"#;
                            let v211 = v134.insert_rule(v209).unwrap();
                            Client::method12(
                                v125,
                                array(&[
                                    Client::method1(v112.clone()),
                                    Client::method1(v199),
                                    Client::method1(v115.clone()),
                                    Client::method2(format!("{:?}", v211)),
                                ]),
                            );
                            {
                                let patternInput_3: (string, string, string, bool) =
                                    Client::method0();
                                let v222: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                                let v223: i64 = (&v222).timestamp();
                                let v225 = v23.sheet();
                                let v227 = v225.unwrap();
                                let v231: string = append(
                                    append(
                                        string("wasm_bindgen::JsCast::unchecked_into::<"),
                                        v54.clone(),
                                    ),
                                    string(">(v227)"),
                                );
                                let v232 = wasm_bindgen::JsCast::unchecked_into::<
                                    web_sys::CssStyleSheet,
                                >(v227);
                                let v241: string = string("*::-webkit-scrollbar");
                                let v249: string = append(
                                    append(
                                        append(
                                            append(
                                                append(v241.clone(), string(" {")),
                                                string("  "),
                                            ),
                                            append(
                                                append(
                                                    append(
                                                        append(v76, string(": ")),
                                                        string("11px"),
                                                    ),
                                                    string(";"),
                                                ),
                                                v66.clone(),
                                            ),
                                        ),
                                        string(" "),
                                    ),
                                    string("}"),
                                );
                                let v251: &str = r#"*::-webkit-scrollbar {  width: 11px; }"#;
                                let v253 = v232.insert_rule(v251).unwrap();
                                Client::method12(
                                    v223,
                                    array(&[
                                        Client::method1(v112.clone()),
                                        Client::method1(v241),
                                        Client::method1(v115.clone()),
                                        Client::method2(format!("{:?}", v253)),
                                    ]),
                                );
                                {
                                    let patternInput_4: (string, string, string, bool) =
                                        Client::method0();
                                    let v264: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                                    let v265: i64 = (&v264).timestamp();
                                    let v267 = v23.sheet();
                                    let v269 = v267.unwrap();
                                    let v273: string = append(
                                        append(
                                            string("wasm_bindgen::JsCast::unchecked_into::<"),
                                            v54.clone(),
                                        ),
                                        string(">(v269)"),
                                    );
                                    let v274 = wasm_bindgen::JsCast::unchecked_into::<
                                        web_sys::CssStyleSheet,
                                    >(v269);
                                    let v283: string = string("*::-webkit-scrollbar:horizontal");
                                    let v291: string = append(
                                        append(
                                            append(
                                                append(
                                                    append(v283.clone(), string(" {")),
                                                    string("  "),
                                                ),
                                                append(
                                                    append(
                                                        append(
                                                            append(v84, string(": ")),
                                                            string("8px"),
                                                        ),
                                                        string(";"),
                                                    ),
                                                    v66.clone(),
                                                ),
                                            ),
                                            string(" "),
                                        ),
                                        string("}"),
                                    );
                                    let v293: &str =
                                        r#"*::-webkit-scrollbar:horizontal {  height: 8px; }"#;
                                    let v295 = v274.insert_rule(v293).unwrap();
                                    Client::method12(
                                        v265,
                                        array(&[
                                            Client::method1(v112.clone()),
                                            Client::method1(v283),
                                            Client::method1(v115.clone()),
                                            Client::method2(format!("{:?}", v295)),
                                        ]),
                                    );
                                    {
                                        let patternInput_5: (string, string, string, bool) =
                                            Client::method0();
                                        let v306: chrono::DateTime<chrono::Utc> =
                                            chrono::Utc::now();
                                        let v307: i64 = (&v306).timestamp();
                                        let v309 = v23.sheet();
                                        let v311 = v309.unwrap();
                                        let v315: string = append(
                                            append(
                                                string("wasm_bindgen::JsCast::unchecked_into::<"),
                                                v54.clone(),
                                            ),
                                            string(">(v311)"),
                                        );
                                        let v316 = wasm_bindgen::JsCast::unchecked_into::<
                                            web_sys::CssStyleSheet,
                                        >(v311);
                                        let v319: string = string("none");
                                        let v325: string = string("*::-webkit-scrollbar-track");
                                        let v333: string = append(
                                            append(
                                                append(
                                                    append(
                                                        append(v325.clone(), string(" {")),
                                                        string("  "),
                                                    ),
                                                    append(
                                                        append(
                                                            append(
                                                                append(v160.clone(), string(": ")),
                                                                v319.clone(),
                                                            ),
                                                            string(";"),
                                                        ),
                                                        v66.clone(),
                                                    ),
                                                ),
                                                string(" "),
                                            ),
                                            string("}"),
                                        );
                                        let v335: &str =
                                            r#"*::-webkit-scrollbar-track {  display: none; }"#;
                                        let v337 = v316.insert_rule(v335).unwrap();
                                        Client::method12(
                                            v307,
                                            array(&[
                                                Client::method1(v112.clone()),
                                                Client::method1(v325),
                                                Client::method1(v115.clone()),
                                                Client::method2(format!("{:?}", v337)),
                                            ]),
                                        );
                                        {
                                            let patternInput_6: (string, string, string, bool) =
                                                Client::method0();
                                            let v348: chrono::DateTime<chrono::Utc> =
                                                chrono::Utc::now();
                                            let v349: i64 = (&v348).timestamp();
                                            let v351 = v23.sheet();
                                            let v353 = v351.unwrap();
                                            let v357: string = append(
                                                append(
                                                    string(
                                                        "wasm_bindgen::JsCast::unchecked_into::<",
                                                    ),
                                                    v54.clone(),
                                                ),
                                                string(">(v353)"),
                                            );
                                            let v358 = wasm_bindgen::JsCast::unchecked_into::<
                                                web_sys::CssStyleSheet,
                                            >(
                                                v353
                                            );
                                            let v366: string =
                                                string("*::-webkit-scrollbar-corner");
                                            let v374: string = append(
                                                append(
                                                    append(
                                                        append(
                                                            append(v366.clone(), string(" {")),
                                                            string("  "),
                                                        ),
                                                        append(
                                                            append(
                                                                append(
                                                                    append(v160, string(": ")),
                                                                    v319,
                                                                ),
                                                                string(";"),
                                                            ),
                                                            v66.clone(),
                                                        ),
                                                    ),
                                                    string(" "),
                                                ),
                                                string("}"),
                                            );
                                            let v376: &str = r#"*::-webkit-scrollbar-corner {  display: none; }"#;
                                            let v378 = v358.insert_rule(v376).unwrap();
                                            Client::method12(
                                                v349,
                                                array(&[
                                                    Client::method1(v112.clone()),
                                                    Client::method1(v366),
                                                    Client::method1(v115.clone()),
                                                    Client::method2(format!("{:?}", v378)),
                                                ]),
                                            );
                                            {
                                                let patternInput_7: (string, string, string, bool) =
                                                    Client::method0();
                                                let v389: chrono::DateTime<chrono::Utc> =
                                                    chrono::Utc::now();
                                                let v390: i64 = (&v389).timestamp();
                                                let v392 = v23.sheet();
                                                let v394 = v392.unwrap();
                                                let v398: string =
                                                    append(append(string("wasm_bindgen::JsCast::unchecked_into::<"),
                                                                  v54.clone()),
                                                           string(">(v394)"));
                                                let v399 = wasm_bindgen::JsCast::unchecked_into::<
                                                    web_sys::CssStyleSheet,
                                                >(
                                                    v394
                                                );
                                                let v401: string = string("background");
                                                let v417: string = string("background-clip");
                                                let v419: string = string("content-box");
                                                let v425: string = string("border-left");
                                                let v427: string = string("2px solid transparent");
                                                let v433: string =
                                                    string("*::-webkit-scrollbar-thumb");
                                                let v441: string = append(
                                                    append(
                                                        append(
                                                            append(
                                                                append(v433.clone(), string(" {")),
                                                                string("  "),
                                                            ),
                                                            append(
                                                                append(
                                                                    append(
                                                                        append(
                                                                            v425.clone(),
                                                                            string(": "),
                                                                        ),
                                                                        v427.clone(),
                                                                    ),
                                                                    string(";"),
                                                                ),
                                                                append(
                                                                    append(
                                                                        append(
                                                                            append(
                                                                                v417.clone(),
                                                                                string(": "),
                                                                            ),
                                                                            v419.clone(),
                                                                        ),
                                                                        string(";"),
                                                                    ),
                                                                    append(
                                                                        string("opacity: 0.8;"),
                                                                        append(
                                                                            append(
                                                                                append(
                                                                                    append(
                                                                                        v401.clone(
                                                                                        ),
                                                                                        string(
                                                                                            ": ",
                                                                                        ),
                                                                                    ),
                                                                                    string("#555"),
                                                                                ),
                                                                                string(";"),
                                                                            ),
                                                                            v66.clone(),
                                                                        ),
                                                                    ),
                                                                ),
                                                            ),
                                                        ),
                                                        string(" "),
                                                    ),
                                                    string("}"),
                                                );
                                                let v443: &str = r#"*::-webkit-scrollbar-thumb {  border-left: 2px solid transparent;background-clip: content-box;opacity: 0.8;background: #555; }"#;
                                                let v445 = v399.insert_rule(v443).unwrap();
                                                Client::method12(
                                                    v390,
                                                    array(&[
                                                        Client::method1(v112.clone()),
                                                        Client::method1(v433),
                                                        Client::method1(v115.clone()),
                                                        Client::method2(format!("{:?}", v445)),
                                                    ]),
                                                );
                                                {
                                                    let patternInput_8: (
                                                        string,
                                                        string,
                                                        string,
                                                        bool,
                                                    ) = Client::method0();
                                                    let v456: chrono::DateTime<chrono::Utc> =
                                                        chrono::Utc::now();
                                                    let v457: i64 = (&v456).timestamp();
                                                    let v459 = v23.sheet();
                                                    let v461 = v459.unwrap();
                                                    let v465: string =
                                                        append(append(string("wasm_bindgen::JsCast::unchecked_into::<"),
                                                                      v54),
                                                               string(">(v461)"));
                                                    let v466 = wasm_bindgen::JsCast::unchecked_into::<
                                                        web_sys::CssStyleSheet,
                                                    >(
                                                        v461
                                                    );
                                                    let v487: string =
                                                        string("*::-webkit-scrollbar-thumb:hover");
                                                    let v495: string = append(
                                                        append(
                                                            append(
                                                                append(
                                                                    append(
                                                                        v487.clone(),
                                                                        string(" {"),
                                                                    ),
                                                                    string("  "),
                                                                ),
                                                                append(
                                                                    append(
                                                                        append(
                                                                            append(
                                                                                v425,
                                                                                string(": "),
                                                                            ),
                                                                            v427,
                                                                        ),
                                                                        string(";"),
                                                                    ),
                                                                    append(
                                                                        append(
                                                                            append(
                                                                                append(
                                                                                    v417,
                                                                                    string(": "),
                                                                                ),
                                                                                v419,
                                                                            ),
                                                                            string(";"),
                                                                        ),
                                                                        append(
                                                                            append(
                                                                                append(
                                                                                    append(
                                                                                        v401,
                                                                                        string(
                                                                                            ": ",
                                                                                        ),
                                                                                    ),
                                                                                    string("#ccc"),
                                                                                ),
                                                                                string(";"),
                                                                            ),
                                                                            v66.clone(),
                                                                        ),
                                                                    ),
                                                                ),
                                                            ),
                                                            string(" "),
                                                        ),
                                                        string("}"),
                                                    );
                                                    let v497: &str = r#"*::-webkit-scrollbar-thumb:hover {  border-left: 2px solid transparent;background-clip: content-box;background: #ccc; }"#;
                                                    let v499 = v466.insert_rule(v497).unwrap();
                                                    Client::method12(
                                                        v457,
                                                        array(&[
                                                            Client::method1(v112),
                                                            Client::method1(v487),
                                                            Client::method1(v115),
                                                            Client::method2(format!("{:?}", v499)),
                                                        ]),
                                                    );
                                                    {
                                                        let v507 =
                                                            v10.local_storage().unwrap().unwrap();
                                                        Client::method3(
                                                            v8,
                                                            array(&[Client::method1(string(
                                                                "set_local_storage_value",
                                                            ))]),
                                                        );
                                                        {
                                                            let v513: &str = r#"key"#;
                                                            let v516: &str = r#"value"#;
                                                            Client::method3(
                                                                v8,
                                                                array(&[
                                                                    Client::method1(string("key")),
                                                                    Client::method13(v513),
                                                                    Client::method1(string(
                                                                        "value",
                                                                    )),
                                                                    Client::method13(v516),
                                                                ]),
                                                            );
                                                            {
                                                                let v523 = v507
                                                                    .set_item(v513, v516)
                                                                    .unwrap();
                                                                Client::method3(
                                                                    v8,
                                                                    array(&[
                                                                        Client::method1(string(
                                                                            "set_result",
                                                                        )),
                                                                        Client::method14(&v523),
                                                                    ]),
                                                                );
                                                                {
                                                                    let v528 = Client::method15(v8);
                                                                    let v529: string =
                                                                        Client::method17();
                                                                    let v530: std::string::String =
                                                                        Client::method18();
                                                                    let v531: std::string::String =
                                                                        Client::method19();
                                                                    let v532:
                                                                            wasm_bindgen::JsValue =
                                                                        Client::method20();
                                                                    let v533:
                                                                            wasm_bindgen::JsValue =
                                                                        Client::method21();
                                                                    let v534 = Func1::new({
                                                                        let v8 = v8.clone();
                                                                        move |v: i32| {
                                                                            Client::closure1(v8, v)
                                                                        }
                                                                    });
                                                                    let v536: string =
                                                                        string("async move {");
                                                                    fn v538(v_1:
                                                                                string)
                                                                     ->
                                                                    indexed_db_futures::request::OpenDbRequest{
                                                                        Client::closure2((), v_1)
                                                                    }
                                                                    let v629: string = string("}");
                                                                    let v630:
                                                                            string =
                                                                        append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(v536.clone(),
                                                                                                                                                                                                                                                                                                                                                                                                                 string("  v534(0);")),
                                                                                                                                                                                                                                                                                                                                                                                                          string("  let mut db_ref_____ = v538(v529);")),
                                                                                                                                                                                                                                                                                                                                                                                                   string("  v534(1);")),
                                                                                                                                                                                                                                                                                                                                                                                            string("  let db_param_ = &mut db_ref_____;")),
                                                                                                                                                                                                                                                                                                                                                                                     string("  indexed_db_futures::prelude::IdbOpenDbRequestLike::set_on_upgrade_needed(")),
                                                                                                                                                                                                                                                                                                                                                                              string("    db_param_,")),
                                                                                                                                                                                                                                                                                                                                                                       string("    Some(move |event: &indexed_db_futures::IdbVersionChangeEvent| {")),
                                                                                                                                                                                                                                                                                                                                                                string("      v528(2);")),
                                                                                                                                                                                                                                                                                                                                                         string("      let db: &indexed_db_futures::IdbDatabase = event.db();")),
                                                                                                                                                                                                                                                                                                                                                  string("      v528(3);")),
                                                                                                                                                                                                                                                                                                                                           string("      if !db.object_store_names().any(|n| &n == &v531.clone()) {")),
                                                                                                                                                                                                                                                                                                                                    string("        let object_store = db.create_object_store(&v531.clone());")),
                                                                                                                                                                                                                                                                                                                             string("        let object_store: indexed_db_futures::prelude::IdbObjectStore = object_store.unwrap();")),
                                                                                                                                                                                                                                                                                                                      string("        ();")),
                                                                                                                                                                                                                                                                                                               string("      };")),
                                                                                                                                                                                                                                                                                                        string("      v528(4);")),
                                                                                                                                                                                                                                                                                                 string("      Ok(())")),
                                                                                                                                                                                                                                                                                          string("    })")),
                                                                                                                                                                                                                                                                                   string("  );")),
                                                                                                                                                                                                                                                                            string("  v534(5);")),
                                                                                                                                                                                                                                                                     string("  let db_future_ = db_ref_____;")),
                                                                                                                                                                                                                                                              string("  let db_future = db_future_.into_future();")),
                                                                                                                                                                                                                                                       string("  let db = db_future.await;")),
                                                                                                                                                                                                                                                string("  v534(6);")),
                                                                                                                                                                                                                                         string("  let db = db.unwrap();")),
                                                                                                                                                                                                                                  string("  v534(7);")),
                                                                                                                                                                                                                           string("  let tx = db.transaction_on_one_with_mode(&v530.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readwrite);")),
                                                                                                                                                                                                                    string("  v534(8);")),
                                                                                                                                                                                                             string("  let tx = tx.unwrap();")),
                                                                                                                                                                                                      string("  v534(9);")),
                                                                                                                                                                                               string("  let store = tx.object_store(&v530.clone()).unwrap();")),
                                                                                                                                                                                        string("  v534(10);")),
                                                                                                                                                                                 string("  store.put_key_val_owned(")),
                                                                                                                                                                          string("    &v532,")),
                                                                                                                                                                   string("    &v533")),
                                                                                                                                                            string("  ).unwrap();")),
                                                                                                                                                     string("  v534(11);")),
                                                                                                                                              string("  tx.await.into_result().unwrap();")),
                                                                                                                                       string("  v534(12);")),
                                                                                                                                string("  let tx = db.transaction_on_one_with_mode(&v530.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readonly);")),
                                                                                                                         string("  v534(13);")),
                                                                                                                  string("  let tx = tx.unwrap();")),
                                                                                                           string("  v534(14);")),
                                                                                                    string("  let store = tx.object_store(&v530.clone()).unwrap();")),
                                                                                             string("  v534(-1);")),
                                                                                      string("  Ok::<(), web_sys::DomException>(())")),
                                                                               v629.clone());
                                                                    let v631 = async move {
                                                                        v534(0);
                                                                        let mut db_ref_____ =
                                                                            v538(v529);
                                                                        v534(1);
                                                                        let db_param_ =
                                                                            &mut db_ref_____;
                                                                        indexed_db_futures::prelude::IdbOpenDbRequestLike::set_on_upgrade_needed(    db_param_,    Some(move |event: &indexed_db_futures::IdbVersionChangeEvent| {      v528(2);      let db: &indexed_db_futures::IdbDatabase = event.db();      v528(3);      if !db.object_store_names().any(|n| &n == &v531.clone()) {        let object_store = db.create_object_store(&v531.clone());        let object_store: indexed_db_futures::prelude::IdbObjectStore = object_store.unwrap();        ();      };      v528(4);      Ok(())    })  );
                                                                        v534(5);
                                                                        let db_future_ =
                                                                            db_ref_____;
                                                                        let db_future = db_future_
                                                                            .into_future();
                                                                        let db = db_future.await;
                                                                        v534(6);
                                                                        let db = db.unwrap();
                                                                        v534(7);
                                                                        let tx = db.transaction_on_one_with_mode(&v530.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readwrite);
                                                                        v534(8);
                                                                        let tx = tx.unwrap();
                                                                        v534(9);
                                                                        let store = tx
                                                                            .object_store(
                                                                                &v530.clone(),
                                                                            )
                                                                            .unwrap();
                                                                        v534(10);
                                                                        store
                                                                            .put_key_val_owned(
                                                                                &v532, &v533,
                                                                            )
                                                                            .unwrap();
                                                                        v534(11);
                                                                        tx.await
                                                                            .into_result()
                                                                            .unwrap();
                                                                        v534(12);
                                                                        let tx = db.transaction_on_one_with_mode(&v530.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readonly);
                                                                        v534(13);
                                                                        let tx = tx.unwrap();
                                                                        v534(14);
                                                                        let store = tx
                                                                            .object_store(
                                                                                &v530.clone(),
                                                                            )
                                                                            .unwrap();
                                                                        v534(-1);
                                                                        Ok::<
                                                                            (),
                                                                            web_sys::DomException,
                                                                        >(
                                                                            ()
                                                                        )
                                                                    };
                                                                    async_std::task::block_on(v631);
                                                                    {
                                                                        let v635:
                                                                                std::string::String =
                                                                            (&string("https://dummyjson.com/users")).to_string();
                                                                        let v637: ehttp::Request =
                                                                            ehttp::Request::get(
                                                                                &v635,
                                                                            );
                                                                        let v638: bool =
                                                                            Client::method22();
                                                                        let v640:
                                                                                async_std::sync::Mutex<bool> =
                                                                            async_std::sync::Mutex::new(v638);
                                                                        let v642:
                                                                                async_std::sync::Condvar =
                                                                            async_std::sync::Condvar::new();
                                                                        let v645:
                                                                                (async_std::sync::Mutex<bool>, async_std::sync::Condvar) =
                                                                            Client::method23((v640, v642));
                                                                        let v647:
                                                                                std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                                                                            std::sync::Arc::new(v645);
                                                                        let v649:
                                                                                std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                                                                            v647.clone();
                                                                        let v651: Option<
                                                                            ehttp::Response,
                                                                        > = Client::method24(
                                                                            (&None::<_>).clone(),
                                                                        );
                                                                        let v654:
                                                                                async_std::sync::Mutex<Option<ehttp::Response>> =
                                                                            Client::method25(async_std::sync::Mutex::new(v651));
                                                                        let v656: std::sync::Arc<
                                                                            async_std::sync::Mutex<
                                                                                Option<
                                                                                    ehttp::Response,
                                                                                >,
                                                                            >,
                                                                        > = std::sync::Arc::new(
                                                                            v654,
                                                                        );
                                                                        let v658:
                                                                                std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
                                                                            std::cell::RefCell::new(v656);
                                                                        let v660:
                                                                                std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
                                                                            v658.clone();
                                                                        let v678:
                                                                                string =
                                                                            append(string("move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v658.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v649;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });"),
                                                                                   v629.clone());
                                                                        let v679 =
                                                                            move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v658.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v649;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });};
                                                                        let v681 = Box::new(v679);
                                                                        ehttp::fetch(v637, v681);
                                                                        {
                                                                            let v693 = Func1::new(
                                                                                {
                                                                                    let v8 =
                                                                                        v8.clone();
                                                                                    move
                                                                                                   |v_2:
                                                                                                        std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>|
                                                                                                   Client::closure3(v8,
                                                                                                                    v_2.clone())
                                                                                },
                                                                            );
                                                                            let v696:
                                                                                    string =
                                                                                append(append(append(append(append(append(append(v536,
                                                                                                                                 string("  let (lock, cvar) = &*v647;")),
                                                                                                                          string("  let mut started = lock.lock().await;")),
                                                                                                                   string("  while !*started {")),
                                                                                                            string("    started = cvar.wait(started).await;")),
                                                                                                     string("  }")),
                                                                                              string("  v693(v660);")),
                                                                                       v629.clone());
                                                                            let v697 = async move {
                                                                                let (lock, cvar) =
                                                                                    &*v647;
                                                                                let mut started =
                                                                                    lock.lock()
                                                                                        .await;
                                                                                while !*started {
                                                                                    started = cvar
                                                                                        .wait(
                                                                                            started,
                                                                                        )
                                                                                        .await;
                                                                                }
                                                                                v693(v660);
                                                                            };
                                                                            async_std::task::block_on(v697);
                                                                            {
                                                                                let v702:
                                                                                        &'static str =
                                                                                    r#"https://time.is"#.clone();
                                                                                let v704:
                                                                                        futures_signals::signal::Mutable<&'static str> =
                                                                                    futures_signals::signal::Mutable::new(v702);
                                                                                let v706:
                                                                                        std::rc::Rc<futures_signals::signal::Mutable<&'static str>> =
                                                                                    std::rc::Rc::new(v704);
                                                                                let v709: &str =
                                                                                    r#"input"#;
                                                                                let v711:
                                                                                        dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                    dominator::DomBuilder::new_html(&v709);
                                                                                let v714: &str =
                                                                                    r#"color"#;
                                                                                let v717: &str =
                                                                                    r#"#666"#;
                                                                                let v722:
                                                                                        string =
                                                                                    append(append(string("dominator::class! {"),
                                                                                                  append(v66.clone(),
                                                                                                         string(" .style(v714, v717) "))),
                                                                                           v629.clone());
                                                                                let v723 = dominator::class! { .style(v714, v717) };
                                                                                let v725:
                                                                                        dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                    v711.class(&*v723);
                                                                                let v728: &str = r#"placeholder"#;
                                                                                let v731: &str =
                                                                                    r#"url"#;
                                                                                let v733:
                                                                                        dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                    v725.attr(v728, v731);
                                                                                let v735:
                                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                                    v706.signal();
                                                                                let v737: &str =
                                                                                    r#"value"#;
                                                                                let v738:
                                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                                    Client::method26(v735);
                                                                                let v740:
                                                                                        dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                    v733.prop_signal(v737, v738);
                                                                                let v742 =
                                                                                    Func1::new({
                                                                                        let v706
                                                                                                       =
                                                                                                       v706.clone();
                                                                                        move
                                                                                                       |v_3:
                                                                                                            std::rc::Rc<web_sys::HtmlInputElement>|
                                                                                                       Client::closure4(v706.clone(),
                                                                                                                        v_3.clone())
                                                                                    });
                                                                                let v769:
                                                                                        string =
                                                                                    append(append(append(append(string("dominator::with_node!(   v740,   element => {      "),
                                                                                                                append(string(".event(dominator::clone!(  v742 => move |_: dominator::events::Input| {    let element_ = std::rc::Rc::new(&element);     let el = (*element_).clone().into();     v742(el);   }))"),
                                                                                                                       v66.clone())),
                                                                                                         string(" ")),
                                                                                                  string("   }")),
                                                                                           string(")"));
                                                                                let v770:
                                                                                        dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                    dominator::with_node!(   v740,   element => {      .event(dominator::clone!(  v742 => move |_: dominator::events::Input| {    let element_ = std::rc::Rc::new(&element);     let el = (*element_).clone().into();     v742(el);   }))    });
                                                                                let v772:
                                                                                        dominator::Dom =
                                                                                    v770.into_dom();
                                                                                let v775: &str =
                                                                                    r#"iframe"#;
                                                                                let v777:
                                                                                        dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                    dominator::DomBuilder::new_html(&v775);
                                                                                let v779: &str =
                                                                                    r#"width"#;
                                                                                let v781: &str =
                                                                                    r#"100%"#;
                                                                                let v783:
                                                                                        string =
                                                                                    append(v66.clone(),
                                                                                           string(" .style(v779, v781) "));
                                                                                let v785: &str =
                                                                                    r#"flex"#;
                                                                                let v788: &str =
                                                                                    r#"1"#;
                                                                                let v790:
                                                                                        string =
                                                                                    append(v783,
                                                                                           string(" .style(v785, v788) "));
                                                                                let v793: &str =
                                                                                    r#"border"#;
                                                                                let v795: &str =
                                                                                    r#"0"#;
                                                                                let v800:
                                                                                        string =
                                                                                    append(append(string("dominator::class! {"),
                                                                                                  append(v790,
                                                                                                         string(" .style(v793, v795) "))),
                                                                                           v629.clone());
                                                                                let v801 = dominator::class! { .style(v779, v781)  .style(v785, v788)  .style(v793, v795) };
                                                                                let v803:
                                                                                        dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                    v777.class(&*v801);
                                                                                let v806: &str =
                                                                                    r#"title"#;
                                                                                let v808: &str =
                                                                                    r#"title"#;
                                                                                let v810:
                                                                                        dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                    v803.attr(v806, v808);
                                                                                let v812:
                                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                                    v706.signal();
                                                                                let v815: &str =
                                                                                    r#"src"#;
                                                                                let v816:
                                                                                        futures_signals::signal::MutableSignal<&'static str> =
                                                                                    Client::method26(v812);
                                                                                let v818:
                                                                                        dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                    v810.prop_signal(v815, v816);
                                                                                let v820:
                                                                                        dominator::Dom =
                                                                                    v818.into_dom();
                                                                                let v823: &str =
                                                                                    r#"div"#;
                                                                                let v825:
                                                                                        dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                    dominator::DomBuilder::new_html(&v823);
                                                                                let v828: &str = r#"background-color"#;
                                                                                let v830: &str =
                                                                                    r#"#666"#;
                                                                                let v832:
                                                                                        string =
                                                                                    append(v66.clone(),
                                                                                           string(" .style(v828, v830) "));
                                                                                let v834: &str =
                                                                                    r#"display"#;
                                                                                let v836: &str =
                                                                                    r#"flex"#;
                                                                                let v838:
                                                                                        string =
                                                                                    append(v832,
                                                                                           string(" .style(v834, v836) "));
                                                                                let v840: &str =
                                                                                    r#"flex"#;
                                                                                let v842: &str =
                                                                                    r#"1"#;
                                                                                let v844:
                                                                                        string =
                                                                                    append(v838,
                                                                                           string(" .style(v840, v842) "));
                                                                                let v846: &str = r#"flex-direction"#;
                                                                                let v849: &str =
                                                                                    r#"column"#;
                                                                                let v854:
                                                                                        string =
                                                                                    append(append(string("dominator::class! {"),
                                                                                                  append(v844,
                                                                                                         string(" .style(v846, v849) "))),
                                                                                           v629);
                                                                                let v855 = dominator::class! { .style(v828, v830)  .style(v834, v836)  .style(v840, v842)  .style(v846, v849) };
                                                                                let v857:
                                                                                        dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                    v825.class(&*v855);
                                                                                let v865:
                                                                                        string =
                                                                                    append(append(string("["),
                                                                                                  append(append(v66,
                                                                                                                string("v772")),
                                                                                                         string(", v820"))),
                                                                                           string("]"));
                                                                                let v866 =
                                                                                    [v772, v820];
                                                                                let v868:
                                                                                        dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                    v857.children(v866);
                                                                                let v870:
                                                                                        dominator::Dom =
                                                                                    v868.into_dom();
                                                                                let v872:
                                                                                        web_sys::HtmlElement =
                                                                                    dominator::body();
                                                                                dominator::append_dom(&v872, v870);
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
