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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 {
        US0_0,
        US0_1,
    }
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1() -> bool {
        false
    }
    pub fn method2(
        v0_1: (async_std::sync::Mutex<bool>, async_std::sync::Condvar),
    ) -> (async_std::sync::Mutex<bool>, async_std::sync::Condvar) {
        v0_1
    }
    pub fn method3(v0_1: Option<ehttp::Response>) -> Option<ehttp::Response> {
        v0_1
    }
    pub fn method4(
        v0_1: async_std::sync::Mutex<Option<ehttp::Response>>,
    ) -> async_std::sync::Mutex<Option<ehttp::Response>> {
        v0_1
    }
    pub fn method5(
        v0_1: std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>,
    ) -> std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>> {
        v0_1
    }
    pub fn method6(v0_1: string) -> std::string::String {
        (&v0_1).to_string().clone()
    }
    pub fn method8(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method8: loop {
            break '_method8 (if length(v1.get()) < v0_1.get() {
                let v0_1_temp: i32 = v0_1.get();
                let v1_temp: string = stringFrom(format!("0{0}", &v1.get()));
                v0_1.set(v0_1_temp);
                v1.set(v1_temp);
                continue '_method8;
            } else {
                v1.get()
            });
        }
    }
    pub fn method9(v0_1: u8) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method10(v0_1: Array<std::string::String>) -> std::string::String {
        let v2 = core::ops::Deref::deref(&v0_1);
        let v4 = &***&v2;
        let v5 = &***&v4;
        format!("{:?}", &v5).clone()
    }
    pub fn method11(v0_1: string) -> string {
        v0_1
    }
    pub fn method12() -> string {
        string("$1=$2")
    }
    pub fn method13() -> string {
        string("[$1]")
    }
    pub fn method14() -> string {
        string("\"")
    }
    pub fn method15() -> string {
        string(" ")
    }
    pub fn method16() -> string {
        string("387957")
    }
    pub fn method17() -> string {
        string("385779")
    }
    pub fn method7(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Client::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Client::method10(array(&[
            Client::method6(string("timestamp")),
            Client::method6(v9),
            Client::method6(string("run_id")),
            Client::method9(v11),
            Client::method6(string("log_level")),
            Client::method6(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Client::method6(string("> app ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Client::method11(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Client::method12();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Client::method11(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Client::method13();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Client::method11(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Client::method14();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Client::method11(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Client::method15();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String = Client::method6(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Client::method11(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Client::method12();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Client::method11(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Client::method13();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Client::method11(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Client::method14();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Client::method11(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Client::method15();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String =
            Client::method6(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Client::method11(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Client::method12();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Client::method11(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Client::method13();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Client::method11(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Client::method14();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Client::method11(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Client::method15();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String =
            Client::method6(fable_library_rust::String_::fromStr(&v187));
        if let Client::US0::US0_1 = &if cfg!(target_arch = "wasm32") {
            Client::US0::US0_1
        } else {
            Client::US0::US0_0
        } {
            let v199: string = string(" %c");
            let v203: string = append(
                append(
                    append(append(toString(&v91), v199.clone()), toString(&v143)),
                    v199,
                ),
                toString(&v190),
            );
            let v211: Array<std::string::String> = array(&[
                (&v203).as_ref().to_string(),
                (&stringFrom(format!("color: #{0};", &string("387957"))))
                    .as_ref()
                    .to_string(),
                (&string("color: #385779;")).as_ref().to_string(),
            ]);
            let v212 = core::ops::Deref::deref(&v211);
            let v215: wasm_bindgen::JsValue = serde_wasm_bindgen::to_value(&*****&v212).unwrap();
            web_sys::console::log(&js_sys::Array::from(&&v215));
            ()
        } else {
            let v217: string = Client::method16();
            let v218: &str = &v217.as_str();
            let v222: &str = &v218[0i32 as usize..2i32 as usize];
            let v224: string = fable_library_rust::String_::fromStr(&v222);
            let v226: u8 = u8::from_str_radix(&v224, 16).unwrap();
            let v227: string = Client::method16();
            let v228: &str = &v227.as_str();
            let v231: &str = &v228[2i32 as usize..4i32 as usize];
            let v233: string = fable_library_rust::String_::fromStr(&v231);
            let v234: u8 = u8::from_str_radix(&v233, 16).unwrap();
            let v235: string = Client::method16();
            let v236: &str = &v235.as_str();
            let v239: &str = &v236[4i32 as usize..6i32 as usize];
            let v241: string = fable_library_rust::String_::fromStr(&v239);
            let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
            let v244: colored::ColoredString =
                colored::Colorize::truecolor(&*v143.to_string(), v226, v234, v242);
            let v245: std::string::String = format!("{}", &v244);
            let v246: string = Client::method17();
            let v247: &str = &v246.as_str();
            let v250: &str = &v247[0i32 as usize..2i32 as usize];
            let v252: string = fable_library_rust::String_::fromStr(&v250);
            let v253: u8 = u8::from_str_radix(&v252, 16).unwrap();
            let v254: string = Client::method17();
            let v255: &str = &v254.as_str();
            let v258: &str = &v255[2i32 as usize..4i32 as usize];
            let v260: string = fable_library_rust::String_::fromStr(&v258);
            let v261: u8 = u8::from_str_radix(&v260, 16).unwrap();
            let v262: string = Client::method17();
            let v263: &str = &v262.as_str();
            let v266: &str = &v263[4i32 as usize..6i32 as usize];
            let v268: string = fable_library_rust::String_::fromStr(&v266);
            let v269: u8 = u8::from_str_radix(&v268, 16).unwrap();
            let v270: colored::ColoredString =
                colored::Colorize::truecolor(&*v190.to_string(), v253, v261, v269);
            let v271: std::string::String = format!("{}", &v270);
            println!(
                "{0}",
                stringFrom(format!("{0} {1} {2}", &v91, &v245, &v271))
            );
            ()
        }
    }
    pub fn method18(v0_1: std::string::String) -> std::string::String {
        (&v0_1).clone()
    }
    pub fn closure1(
        v0_1: i64,
        v1: std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>,
    ) {
        Client::method7(v0_1, array(&[Client::method6(string("app > fetch ()"))]));
        {
            let v6: std::cell::Ref<
                std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>,
            > = v1.borrow();
            let v8: Option<_> = v6.try_lock();
            Client::method7(
                v0_1,
                array(&[
                    Client::method6(string("response")),
                    Client::method18(format!("{:?}", &v8)),
                ]),
            )
        }
    }
    pub fn method19(
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
            let v11: std::string::String = (&string("https://dummyjson.com/users")).to_string();
            let v13: ehttp::Request = ehttp::Request::get(&v11);
            let v14: bool = Client::method1();
            let v16: async_std::sync::Mutex<bool> = async_std::sync::Mutex::new(v14);
            let v18: async_std::sync::Condvar = async_std::sync::Condvar::new();
            let v21: (async_std::sync::Mutex<bool>, async_std::sync::Condvar) =
                Client::method2((v16, v18));
            let v23: std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                std::sync::Arc::new(v21);
            let v25: std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                v23.clone();
            let v27: Option<ehttp::Response> = Client::method3((&None::<_>).clone());
            let v30: async_std::sync::Mutex<Option<ehttp::Response>> =
                Client::method4(async_std::sync::Mutex::new(v27));
            let v33: std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>> =
                Client::method5(std::sync::Arc::new(v30));
            let v35: std::cell::RefCell<
                std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>,
            > = std::cell::RefCell::new(v33);
            let v37: std::cell::RefCell<
                std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>,
            > = v35.clone();
            let v55: string = string("}");
            let v56: string =
                append(string("move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v35.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v25;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });"),
                       v55.clone());
            let v57 = move |x: ehttp::Result<ehttp::Response>| {
                let r = x.clone().unwrap();
                *v35.borrow_mut().try_lock().unwrap() = Some(r);
                async_std::task::block_on(async move {
                    let (lock, cvar) = &*v25;
                    let mut started = lock.lock().await;
                    *started = true;
                    cvar.notify_one();
                });
            };
            let v59 = Box::new(v57);
            ehttp::fetch(v13, v59);
            {
                let v72 = Func1::new({
                    let v8 = v8.clone();
                    move |v: std::cell::RefCell<
                        std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>,
                    >| Client::closure1(v8, v.clone())
                });
                let v75: string =
                    append(string("async move {  let (lock, cvar) = &*v23;  let mut started = lock.lock().await;  while !*started {    started = cvar.wait(started).await;  }  v72(v37);"),
                           v55.clone());
                let v76 = async move {
                    let (lock, cvar) = &*v23;
                    let mut started = lock.lock().await;
                    while !*started {
                        started = cvar.wait(started).await;
                    }
                    v72(v37);
                };
                async_std::task::block_on(v76);
                {
                    let v81: &'static str = r#"https://time.is"#.clone();
                    let v83: futures_signals::signal::Mutable<&'static str> =
                        futures_signals::signal::Mutable::new(v81);
                    let v85: std::rc::Rc<futures_signals::signal::Mutable<&'static str>> =
                        std::rc::Rc::new(v83);
                    let v88: &str = r#"input"#;
                    let v90: dominator::DomBuilder<web_sys::HtmlInputElement> =
                        dominator::DomBuilder::new_html(&v88);
                    let v93: &str = r#"color"#;
                    let v96: &str = r#"#666"#;
                    let v98: string = string("");
                    let v102: string = append(
                        append(
                            string("dominator::class! {"),
                            append(v98.clone(), string(" .style(v93, v96) ")),
                        ),
                        v55.clone(),
                    );
                    let v103 = dominator::class! { .style(v93, v96) };
                    let v105: dominator::DomBuilder<web_sys::HtmlInputElement> = v90.class(&*v103);
                    let v108: &str = r#"placeholder"#;
                    let v111: &str = r#"url"#;
                    let v113: dominator::DomBuilder<web_sys::HtmlInputElement> =
                        v105.attr(v108, v111);
                    let v115: futures_signals::signal::MutableSignal<&'static str> = v85.signal();
                    let v118: &str = r#"value"#;
                    let v119: futures_signals::signal::MutableSignal<&'static str> =
                        Client::method19(v115);
                    let v121: dominator::DomBuilder<web_sys::HtmlInputElement> =
                        v113.prop_signal(v118, v119);
                    let v123 = Func1::new({
                        let v85 = v85.clone();
                        move |v_1: std::rc::Rc<web_sys::HtmlInputElement>| {
                            Client::closure2(v85.clone(), v_1.clone())
                        }
                    });
                    let v150: string =
                        append(append(append(append(string("dominator::with_node!(   v121,   element => {      "),
                                                    append(string(".event(dominator::clone!(  v123 => move |_: dominator::events::Input| {    let element_ = std::rc::Rc::new(&element);     let el = (*element_).clone().into();     v123(el);   }))"),
                                                           v98.clone())),
                                             string(" ")), string("   }")),
                               string(")"));
                    let v151: dominator::DomBuilder<web_sys::HtmlInputElement> = dominator::with_node!(   v121,   element => {      .event(dominator::clone!(  v123 => move |_: dominator::events::Input| {    let element_ = std::rc::Rc::new(&element);     let el = (*element_).clone().into();     v123(el);   }))    });
                    let v153: dominator::Dom = v151.into_dom();
                    let v156: &str = r#"iframe"#;
                    let v158: dominator::DomBuilder<web_sys::HtmlElement> =
                        dominator::DomBuilder::new_html(&v156);
                    let v161: &str = r#"width"#;
                    let v164: &str = r#"100%"#;
                    let v166: string = append(v98.clone(), string(" .style(v161, v164) "));
                    let v169: &str = r#"flex"#;
                    let v172: &str = r#"1"#;
                    let v174: string = append(v166, string(" .style(v169, v172) "));
                    let v177: &str = r#"border"#;
                    let v180: &str = r#"0"#;
                    let v185: string = append(
                        append(
                            string("dominator::class! {"),
                            append(v174, string(" .style(v177, v180) ")),
                        ),
                        v55.clone(),
                    );
                    let v186 = dominator::class! { .style(v161, v164)  .style(v169, v172)  .style(v177, v180) };
                    let v188: dominator::DomBuilder<web_sys::HtmlElement> = v158.class(&*v186);
                    let v191: &str = r#"title"#;
                    let v193: &str = r#"title"#;
                    let v195: dominator::DomBuilder<web_sys::HtmlElement> = v188.attr(v191, v193);
                    let v197: futures_signals::signal::MutableSignal<&'static str> = v85.signal();
                    let v200: &str = r#"src"#;
                    let v201: futures_signals::signal::MutableSignal<&'static str> =
                        Client::method19(v197);
                    let v203: dominator::DomBuilder<web_sys::HtmlElement> =
                        v195.prop_signal(v200, v201);
                    let v205: dominator::Dom = v203.into_dom();
                    let v208: &str = r#"div"#;
                    let v210: dominator::DomBuilder<web_sys::HtmlElement> =
                        dominator::DomBuilder::new_html(&v208);
                    let v213: &str = r#"background-color"#;
                    let v215: &str = r#"#666"#;
                    let v217: string = append(v98.clone(), string(" .style(v213, v215) "));
                    let v220: &str = r#"height"#;
                    let v222: &str = r#"100%"#;
                    let v224: string = append(v217, string(" .style(v220, v222) "));
                    let v227: &str = r#"display"#;
                    let v229: &str = r#"flex"#;
                    let v231: string = append(v224, string(" .style(v227, v229) "));
                    let v234: &str = r#"flex-direction"#;
                    let v237: &str = r#"column"#;
                    let v242: string = append(
                        append(
                            string("dominator::class! {"),
                            append(v231, string(" .style(v234, v237) ")),
                        ),
                        v55,
                    );
                    let v243 = dominator::class! { .style(v213, v215)  .style(v220, v222)  .style(v227, v229)  .style(v234, v237) };
                    let v245: dominator::DomBuilder<web_sys::HtmlElement> = v210.class(&*v243);
                    let v253: string = append(
                        append(
                            string("["),
                            append(append(v98, string("v153")), string(", v205")),
                        ),
                        string("]"),
                    );
                    let v254 = [v153, v205];
                    let v256: dominator::DomBuilder<web_sys::HtmlElement> = v245.children(v254);
                    let v258: dominator::Dom = v256.into_dom();
                    let v260: web_sys::HtmlElement = dominator::body();
                    dominator::append_dom(&v260, v258);
                    Client::method7(
                        v8,
                        array(&[
                            Client::method6(string("app end")),
                            Client::method6(string("???")),
                        ]),
                    );
                    0i32
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
