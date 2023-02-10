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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 {
        US0_0,
        US0_1(string),
    }
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
    pub fn method14(v0_1: i64, v1: Array<std::string::String>) {
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
            array(&[Client::method1(string("> set_local_storage_value ()"))]);
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
    pub fn method15(v0_1: Client::US0) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method16(v0_1: i64, v1: Array<std::string::String>) {
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
            array(&[Client::method1(string("> get_local_storage_value ()"))]);
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
    pub fn method17(v0_1: i64, v1: Array<std::string::String>) {
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
            array(&[Client::method1(string("> delete_local_storage_value ()"))]);
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
    pub fn method19(v0_1: i32) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn closure1(v0_1: i64, v1: i32) {
        Client::method3(
            v0_1,
            array(&[Client::method1(string("log_n")), Client::method19(v1)]),
        );
    }
    pub fn method18(v0_1: i64) -> Func1<i32, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Client::closure1(v0_1, v)
        })
    }
    pub fn method20() -> string {
        string("name")
    }
    pub fn method21() -> std::string::String {
        (&string("store")).to_string()
    }
    pub fn method22() -> std::string::String {
        (&string("store")).to_string()
    }
    pub fn method23() -> wasm_bindgen::JsValue {
        wasm_bindgen::JsValue::from_str(&string("key"))
    }
    pub fn method24() -> wasm_bindgen::JsValue {
        wasm_bindgen::JsValue::from_str(&string("value"))
    }
    pub fn closure2(unitVar: (), v0_1: string) -> indexed_db_futures::request::OpenDbRequest {
        let v2: std::string::String = (&v0_1).to_string();
        indexed_db_futures::IdbDatabase::open_u32(&v2, 1).unwrap()
    }
    pub fn method25() -> bool {
        false
    }
    pub fn method26(
        v0_1: (async_std::sync::Mutex<bool>, async_std::sync::Condvar),
    ) -> (async_std::sync::Mutex<bool>, async_std::sync::Condvar) {
        v0_1
    }
    pub fn method27(v0_1: Option<ehttp::Response>) -> Option<ehttp::Response> {
        v0_1
    }
    pub fn method28(
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
    pub fn method29(
        v0_1: futures_signals::signal::MutableSignal<&'static str>,
    ) -> futures_signals::signal::MutableSignal<&'static str> {
        v0_1
    }
    pub fn closure5(
        v0_1: i64,
        v1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v2: &'static str,
    ) {
        Client::method3(v0_1, array(&[Client::method1(string("<with_on_change>"))]));
        Client::method3(
            v0_1,
            array(&[
                Client::method1(string("url")),
                Client::method2(format!("{:?}", &v2)),
            ]),
        );
        *&v1.set_neq(v2);
        Client::method3(v0_1, array(&[Client::method1(string("</with_on_change>"))]))
    }
    pub fn closure4(
        v0_1: i64,
        v1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v2: std::rc::Rc<web_sys::HtmlInputElement>,
    ) {
        let v12 = Func1::new({
            let v0_1 = v0_1.clone();
            let v1 = v1.clone();
            move |v: &'static str| Client::closure5(v0_1, v1.clone(), v.clone())
        });
        let value0 = v2;
        let value0 = value0.value();
        let value0 = value0.into_boxed_str();
        let value0 = Box::leak(value0);
        v12(value0);
        ();
        ()
    }
    pub fn method30(
        v0_1: i64,
        v1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
    ) -> Func1<std::rc::Rc<web_sys::HtmlInputElement>, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1 = v1.clone();
            move |v: std::rc::Rc<web_sys::HtmlInputElement>| {
                Client::closure4(v0_1, v1.clone(), v.clone())
            }
        })
    }
    pub fn closure7(
        v0_1: i64,
        v1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v2: &'static str,
    ) {
        Client::method3(v0_1, array(&[Client::method1(string("<with_load_event>"))]));
        Client::method3(
            v0_1,
            array(&[
                Client::method1(string("url")),
                Client::method2(format!("{:?}", &v2)),
            ]),
        );
        *&v1.set_neq(v2);
        Client::method3(
            v0_1,
            array(&[Client::method1(string("</with_load_event>"))]),
        )
    }
    pub fn closure6(
        v0_1: i64,
        v1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
        v2: std::rc::Rc<web_sys::HtmlIFrameElement>,
    ) {
        let v20 = Func1::new({
            let v0_1 = v0_1.clone();
            let v1 = v1.clone();
            move |v: &'static str| Client::closure7(v0_1, v1.clone(), v.clone())
        });
        let value0 = &&v2;
        let dom = value0;
        let value0 = (*value0).clone();
        let value0 = value0
            .content_window()
            .unwrap()
            .location()
            // .unwrap()
            .to_string()
            .as_string()
            .unwrap();
        // let value0 = value0.unwrap_or(std::string::String::new());
        let value0 = value0.into_boxed_str();
        let value0 = Box::leak(value0);
        if value0 != "" {
            v20(value0);
        }
        ();
        ()
    }
    pub fn method31(
        v0_1: i64,
        v1: std::rc::Rc<futures_signals::signal::Mutable<&'static str>>,
    ) -> Func1<std::rc::Rc<web_sys::HtmlIFrameElement>, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1 = v1.clone();
            move |v: std::rc::Rc<web_sys::HtmlIFrameElement>| {
                Client::closure6(v0_1, v1.clone(), v.clone())
            }
        })
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
                                                        let patternInput_9: (
                                                            string,
                                                            string,
                                                            string,
                                                            bool,
                                                        ) = Client::method0();
                                                        let v512: chrono::DateTime<chrono::Utc> =
                                                            chrono::Utc::now();
                                                        let v513: i64 = (&v512).timestamp();
                                                        let v514: string = string("key");
                                                        let v516: &str = r#"key"#;
                                                        let v517: string = string("value");
                                                        let v519: &str = r#"value"#;
                                                        Client::method14(
                                                            v513,
                                                            array(&[
                                                                Client::method1(v514.clone()),
                                                                Client::method13(v516),
                                                                Client::method1(v517.clone()),
                                                                Client::method13(v519),
                                                            ]),
                                                        );
                                                        v507.set_item(v516, v519).unwrap();
                                                        {
                                                            let patternInput_10: (
                                                                string,
                                                                string,
                                                                string,
                                                                bool,
                                                            ) = Client::method0();
                                                            let v530: chrono::DateTime<
                                                                chrono::Utc,
                                                            > = chrono::Utc::now();
                                                            let v531: i64 = (&v530).timestamp();
                                                            let v533: &str = r#"key"#;
                                                            let v535: Option<std::string::String> =
                                                                v507.get_item(v533).unwrap();
                                                            let v544: Client::US0 = if v535
                                                                .is_none()
                                                            {
                                                                Client::US0::US0_0
                                                            } else {
                                                                let v540: std::string::String =
                                                                    v535.unwrap();
                                                                Client::US0::US0_1(fable_library_rust::String_::fromStr(&v540))
                                                            };
                                                            Client::method16(
                                                                v531,
                                                                array(&[
                                                                    Client::method1(v514.clone()),
                                                                    Client::method13(v533),
                                                                    Client::method1(v517.clone()),
                                                                    Client::method15(v544),
                                                                ]),
                                                            );
                                                            {
                                                                let patternInput_11: (
                                                                    string,
                                                                    string,
                                                                    string,
                                                                    bool,
                                                                ) = Client::method0();
                                                                let v554: chrono::DateTime<
                                                                    chrono::Utc,
                                                                > = chrono::Utc::now();
                                                                let v555: i64 = (&v554).timestamp();
                                                                let v557: &str = r#"key"#;
                                                                Client::method17(
                                                                    v555,
                                                                    array(&[
                                                                        Client::method1(
                                                                            v514.clone(),
                                                                        ),
                                                                        Client::method13(v557),
                                                                    ]),
                                                                );
                                                                v507.remove_item(v557).unwrap();
                                                                {
                                                                    let patternInput_12: (
                                                                        string,
                                                                        string,
                                                                        string,
                                                                        bool,
                                                                    ) = Client::method0();
                                                                    let v566: chrono::DateTime<
                                                                        chrono::Utc,
                                                                    > = chrono::Utc::now();
                                                                    let v567: i64 =
                                                                        (&v566).timestamp();
                                                                    let v569: &str = r#"key"#;
                                                                    let v571: Option<
                                                                        std::string::String,
                                                                    > = v507
                                                                        .get_item(v569)
                                                                        .unwrap();
                                                                    let v580: Client::US0 = if v571
                                                                        .is_none()
                                                                    {
                                                                        Client::US0::US0_0
                                                                    } else {
                                                                        let v576:
                                                                                    std::string::String =
                                                                                v571.unwrap();
                                                                        Client::US0::US0_1(fable_library_rust::String_::fromStr(&v576))
                                                                    };
                                                                    Client::method16(
                                                                        v567,
                                                                        array(&[
                                                                            Client::method1(v514),
                                                                            Client::method13(v569),
                                                                            Client::method1(v517),
                                                                            Client::method15(v580),
                                                                        ]),
                                                                    );
                                                                    {
                                                                        let v586 =
                                                                            Client::method18(v8);
                                                                        let v587: string =
                                                                            Client::method20();
                                                                        let v588:
                                                                                std::string::String =
                                                                            Client::method21();
                                                                        let v589:
                                                                                std::string::String =
                                                                            Client::method22();
                                                                        let v590:
                                                                                wasm_bindgen::JsValue =
                                                                            Client::method23();
                                                                        let v591:
                                                                                wasm_bindgen::JsValue =
                                                                            Client::method24();
                                                                        let v592 = Func1::new({
                                                                            let v8 = v8.clone();
                                                                            move |v: i32| {
                                                                                Client::closure1(
                                                                                    v8, v,
                                                                                )
                                                                            }
                                                                        });
                                                                        let v594: string =
                                                                            string("async move {");
                                                                        fn v596(v_1:
                                                                                    string)
                                                                         ->
                                                                        indexed_db_futures::request::OpenDbRequest{
                                                                            Client::closure2(
                                                                                (),
                                                                                v_1,
                                                                            )
                                                                        }
                                                                        let v661: string =
                                                                            string("}");
                                                                        let v662:
                                                                                string =
                                                                            append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(v594.clone(),
                                                                                                                                                                                                                                                                                                                          string("  v592(0);")),
                                                                                                                                                                                                                                                                                                                   string("  let mut db_ref_____ = v596(v587);")),
                                                                                                                                                                                                                                                                                                            string("  let db_param_ = &mut db_ref_____;")),
                                                                                                                                                                                                                                                                                                     string("  indexed_db_futures::prelude::IdbOpenDbRequestLike::set_on_upgrade_needed(")),
                                                                                                                                                                                                                                                                                              string("    db_param_,")),
                                                                                                                                                                                                                                                                                       string("    Some(move |event: &indexed_db_futures::IdbVersionChangeEvent| {")),
                                                                                                                                                                                                                                                                                string("      let db: &indexed_db_futures::IdbDatabase = event.db();")),
                                                                                                                                                                                                                                                                         string("      if !db.object_store_names().any(|n| &n == &v589.clone()) {")),
                                                                                                                                                                                                                                                                  string("        let object_store = db.create_object_store(&v589.clone());")),
                                                                                                                                                                                                                                                           string("        let object_store: indexed_db_futures::prelude::IdbObjectStore = object_store.unwrap();")),
                                                                                                                                                                                                                                                    string("        ();")),
                                                                                                                                                                                                                                             string("      };")),
                                                                                                                                                                                                                                      string("      Ok(())")),
                                                                                                                                                                                                                               string("    })")),
                                                                                                                                                                                                                        string("  );")),
                                                                                                                                                                                                                 string("  let db_future_ = db_ref_____;")),
                                                                                                                                                                                                          string("  let db_future = db_future_.into_future();")),
                                                                                                                                                                                                   string("  let db = db_future.await;")),
                                                                                                                                                                                            string("  let db = db.unwrap();")),
                                                                                                                                                                                     string("  let tx = db.transaction_on_one_with_mode(&v588.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readwrite);")),
                                                                                                                                                                              string("  let tx = tx.unwrap();")),
                                                                                                                                                                       string("  let store = tx.object_store(&v588.clone()).unwrap();")),
                                                                                                                                                                string("  store.put_key_val_owned(")),
                                                                                                                                                         string("    &v590,")),
                                                                                                                                                  string("    &v591")),
                                                                                                                                           string("  ).unwrap();")),
                                                                                                                                    string("  tx.await.into_result().unwrap();")),
                                                                                                                             string("  let tx = db.transaction_on_one_with_mode(&v588.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readonly);")),
                                                                                                                      string("  let tx = tx.unwrap();")),
                                                                                                               string("  let store = tx.object_store(&v588.clone()).unwrap();")),
                                                                                                        string("  drop(tx);")),
                                                                                                 string("  db.delete().unwrap();")),
                                                                                          string("  Ok::<(), web_sys::DomException>(())")),
                                                                                   v661.clone());
                                                                        let v663 = async move {
                                                                            v592(0);
                                                                            let mut db_ref_____ =
                                                                                v596(v587);
                                                                            let db_param_ =
                                                                                &mut db_ref_____;
                                                                            indexed_db_futures::prelude::IdbOpenDbRequestLike::set_on_upgrade_needed(    db_param_,    Some(move |event: &indexed_db_futures::IdbVersionChangeEvent| {      let db: &indexed_db_futures::IdbDatabase = event.db();      if !db.object_store_names().any(|n| &n == &v589.clone()) {        let object_store = db.create_object_store(&v589.clone());        let object_store: indexed_db_futures::prelude::IdbObjectStore = object_store.unwrap();        ();      };      Ok(())    })  );
                                                                            let db_future_ =
                                                                                db_ref_____;
                                                                            let db_future =
                                                                                db_future_
                                                                                    .into_future();
                                                                            let db =
                                                                                db_future.await;
                                                                            let db = db.unwrap();
                                                                            let tx = db.transaction_on_one_with_mode(&v588.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readwrite);
                                                                            let tx = tx.unwrap();
                                                                            let store = tx
                                                                                .object_store(
                                                                                    &v588.clone(),
                                                                                )
                                                                                .unwrap();
                                                                            store
                                                                                .put_key_val_owned(
                                                                                    &v590, &v591,
                                                                                )
                                                                                .unwrap();
                                                                            tx.await
                                                                                .into_result()
                                                                                .unwrap();
                                                                            let tx = db.transaction_on_one_with_mode(&v588.clone(), indexed_db_futures::prelude::IdbTransactionMode::Readonly);
                                                                            let tx = tx.unwrap();
                                                                            let store = tx
                                                                                .object_store(
                                                                                    &v588.clone(),
                                                                                )
                                                                                .unwrap();
                                                                            drop(tx);
                                                                            db.delete().unwrap();
                                                                            Ok::<(), web_sys::DomException>(())
                                                                        };
                                                                        async_std::task::block_on(
                                                                            v663,
                                                                        );
                                                                        {
                                                                            let v667:
                                                                                    std::string::String =
                                                                                (&string("https://dummyjson.com/users")).to_string();
                                                                            let v669:
                                                                                    ehttp::Request =
                                                                                ehttp::Request::get(&v667);
                                                                            let v670: bool =
                                                                                Client::method25();
                                                                            let v672:
                                                                                    async_std::sync::Mutex<bool> =
                                                                                async_std::sync::Mutex::new(v670);
                                                                            let v674:
                                                                                    async_std::sync::Condvar =
                                                                                async_std::sync::Condvar::new();
                                                                            let v677:
                                                                                    (async_std::sync::Mutex<bool>, async_std::sync::Condvar) =
                                                                                Client::method26((v672, v674));
                                                                            let v679:
                                                                                    std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                                                                                std::sync::Arc::new(v677);
                                                                            let v681:
                                                                                    std::sync::Arc<(async_std::sync::Mutex<bool>, async_std::sync::Condvar)> =
                                                                                v679.clone();
                                                                            let v683: Option<
                                                                                ehttp::Response,
                                                                            > = Client::method27(
                                                                                (&None::<_>)
                                                                                    .clone(),
                                                                            );
                                                                            let v686:
                                                                                    async_std::sync::Mutex<Option<ehttp::Response>> =
                                                                                Client::method28(async_std::sync::Mutex::new(v683));
                                                                            let v688:
                                                                                    std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>> =
                                                                                std::sync::Arc::new(v686);
                                                                            let v690:
                                                                                    std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
                                                                                std::cell::RefCell::new(v688);
                                                                            let v692:
                                                                                    std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>> =
                                                                                v690.clone();
                                                                            let v710:
                                                                                    string =
                                                                                append(string("move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v690.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v681;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });"),
                                                                                       v661.clone());
                                                                            let v711 =
                                                                                move |x: ehttp::Result<ehttp::Response>| {  let r = x.clone().unwrap();  *v690.borrow_mut().try_lock().unwrap() = Some(r);  async_std::task::block_on(async move {    let (lock, cvar) = &*v681;    let mut started = lock.lock().await;    *started = true;    cvar.notify_one();  });};
                                                                            let v713 =
                                                                                Box::new(v711);
                                                                            ehttp::fetch(
                                                                                v669, v713,
                                                                            );
                                                                            {
                                                                                let v725 =
                                                                                    Func1::new({
                                                                                        let v8 = v8
                                                                                            .clone(
                                                                                            );
                                                                                        move
                                                                                                       |v_2:
                                                                                                            std::cell::RefCell<std::sync::Arc<async_std::sync::Mutex<Option<ehttp::Response>>>>|
                                                                                                       Client::closure3(v8,
                                                                                                                        v_2.clone())
                                                                                    });
                                                                                let v728:
                                                                                        string =
                                                                                    append(append(append(append(append(append(append(v594,
                                                                                                                                     string("  let (lock, cvar) = &*v679;")),
                                                                                                                              string("  let mut started = lock.lock().await;")),
                                                                                                                       string("  while !*started {")),
                                                                                                                string("    started = cvar.wait(started).await;")),
                                                                                                         string("  }")),
                                                                                                  string("  v725(v692);")),
                                                                                           v661.clone());
                                                                                let v729 = async move {
                                                                                    let (
                                                                                        lock,
                                                                                        cvar,
                                                                                    ) = &*v679;
                                                                                    let mut started =
                                                                                        lock.lock()
                                                                                            .await;
                                                                                    while !*started
                                                                                    {
                                                                                        started = cvar.wait(started).await;
                                                                                    }
                                                                                    v725(v692);
                                                                                };
                                                                                async_std::task::block_on(v729);
                                                                                {
                                                                                    let v734:
                                                                                            &'static str =
                                                                                        r#"https://time.is"#.clone();
                                                                                    let v736:
                                                                                            futures_signals::signal::Mutable<&'static str> =
                                                                                        futures_signals::signal::Mutable::new(v734);
                                                                                    let v738:
                                                                                            std::rc::Rc<futures_signals::signal::Mutable<&'static str>> =
                                                                                        std::rc::Rc::new(v736);
                                                                                    let v741: &str =
                                                                                        r#"input"#;
                                                                                    let v743:
                                                                                            dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                        dominator::DomBuilder::new_html(&v741);
                                                                                    let v746: &str =
                                                                                        r#"color"#;
                                                                                    let v749: &str =
                                                                                        r#"#666"#;
                                                                                    let v754:
                                                                                            string =
                                                                                        append(append(string("dominator::class! {"),
                                                                                                      append(v66.clone(),
                                                                                                             string(" .style(v746, v749) "))),
                                                                                               v661.clone());
                                                                                    let v755 = dominator::class! { .style(v746, v749) };
                                                                                    let v757:
                                                                                            dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                        v743.class(&*v755);
                                                                                    let v760: &str = r#"placeholder"#;
                                                                                    let v763: &str =
                                                                                        r#"url"#;
                                                                                    let v765:
                                                                                            dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                        v757.attr(v760, v763);
                                                                                    let v767:
                                                                                            futures_signals::signal::MutableSignal<&'static str> =
                                                                                        v738.signal();
                                                                                    let v769: &str =
                                                                                        r#"value"#;
                                                                                    let v770:
                                                                                            futures_signals::signal::MutableSignal<&'static str> =
                                                                                        Client::method29(v767);
                                                                                    let v772:
                                                                                            dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                        v765.prop_signal(v769, v770);
                                                                                    let v774 =
                                                                                        Client::method30(v8,
                                                                                                         v738.clone());
                                                                                    let v811:
                                                                                            string =
                                                                                        append(append(append(append(string("dominator::with_node!(   v772,   element => {      "),
                                                                                                                    append(string(".event(dominator::clone!(  v774 => move |_: dominator::events::Input| {    let el = &element;     let el = (*el).clone();     let el = wasm_bindgen::JsCast::dyn_into(el);     let el = el.unwrap();     let el = std::rc::Rc::new(el);     v774(el);   }))"),
                                                                                                                           v66.clone())),
                                                                                                             string(" ")),
                                                                                                      string("   }")),
                                                                                               string(")"));
                                                                                    let v812:
                                                                                            dominator::DomBuilder<web_sys::HtmlInputElement> =
                                                                                        dominator::with_node!(   v772,   element => {      .event(dominator::clone!(  v774 => move |_: dominator::events::Input| {    let el = &element;     let el = (*el).clone();     let el = wasm_bindgen::JsCast::dyn_into(el);     let el = el.unwrap();     let el = std::rc::Rc::new(el);     v774(el);   }))    });
                                                                                    let v814:
                                                                                            dominator::Dom =
                                                                                        v812.into_dom();
                                                                                    let v817: &str =
                                                                                        r#"iframe"#;
                                                                                    let v819:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        dominator::DomBuilder::new_html(&v817);
                                                                                    let v821: &str =
                                                                                        r#"width"#;
                                                                                    let v823: &str =
                                                                                        r#"100%"#;
                                                                                    let v825:
                                                                                            string =
                                                                                        append(v66.clone(),
                                                                                               string(" .style(v821, v823) "));
                                                                                    let v827: &str =
                                                                                        r#"flex"#;
                                                                                    let v830: &str =
                                                                                        r#"1"#;
                                                                                    let v832:
                                                                                            string =
                                                                                        append(v825,
                                                                                               string(" .style(v827, v830) "));
                                                                                    let v835: &str =
                                                                                        r#"border"#;
                                                                                    let v837: &str =
                                                                                        r#"0"#;
                                                                                    let v842:
                                                                                            string =
                                                                                        append(append(string("dominator::class! {"),
                                                                                                      append(v832,
                                                                                                             string(" .style(v835, v837) "))),
                                                                                               v661.clone());
                                                                                    let v843 = dominator::class! { .style(v821, v823)  .style(v827, v830)  .style(v835, v837) };
                                                                                    let v845:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        v819.class(&*v843);
                                                                                    let v848: &str =
                                                                                        r#"title"#;
                                                                                    let v850: &str =
                                                                                        r#"title"#;
                                                                                    let v852:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        v845.attr(v848, v850);
                                                                                    let v854:
                                                                                            futures_signals::signal::MutableSignal<&'static str> =
                                                                                        v738.signal();
                                                                                    let v857: &str =
                                                                                        r#"src"#;
                                                                                    let v858:
                                                                                            futures_signals::signal::MutableSignal<&'static str> =
                                                                                        Client::method29(v854);
                                                                                    let v860:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        v852.prop_signal(v857, v858);
                                                                                    let v862 =
                                                                                        Client::method31(v8,
                                                                                                         v738);
                                                                                    let v899:
                                                                                            string =
                                                                                        append(append(append(append(string("dominator::with_node!(   v860,   element => {      "),
                                                                                                                    append(string(".event(dominator::clone!(  v862 => move |_: dominator::events::Load| {    let el = &element;     let el = (*el).clone();     let el = wasm_bindgen::JsCast::dyn_into(el);     let el = el.unwrap();     let el = std::rc::Rc::new(el);     v862(el);   }))"),
                                                                                                                           v66.clone())),
                                                                                                             string(" ")),
                                                                                                      string("   }")),
                                                                                               string(")"));
                                                                                    let v900:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        dominator::with_node!(   v860,   element => {      .event(dominator::clone!(  v862 => move |_: dominator::events::Load| {    let el = &element;     let el = (*el).clone();     let el = wasm_bindgen::JsCast::dyn_into(el);     let el = el.unwrap();     let el = std::rc::Rc::new(el);     v862(el);   }))    });
                                                                                    let v902:
                                                                                            dominator::Dom =
                                                                                        v900.into_dom();
                                                                                    let v905: &str =
                                                                                        r#"div"#;
                                                                                    let v907:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        dominator::DomBuilder::new_html(&v905);
                                                                                    let v910: &str = r#"background-color"#;
                                                                                    let v912: &str =
                                                                                        r#"#666"#;
                                                                                    let v914:
                                                                                            string =
                                                                                        append(v66.clone(),
                                                                                               string(" .style(v910, v912) "));
                                                                                    let v916: &str =
                                                                                        r#"display"#;
                                                                                    let v918: &str =
                                                                                        r#"flex"#;
                                                                                    let v920:
                                                                                            string =
                                                                                        append(v914,
                                                                                               string(" .style(v916, v918) "));
                                                                                    let v922: &str =
                                                                                        r#"flex"#;
                                                                                    let v924: &str =
                                                                                        r#"1"#;
                                                                                    let v926:
                                                                                            string =
                                                                                        append(v920,
                                                                                               string(" .style(v922, v924) "));
                                                                                    let v928: &str = r#"flex-direction"#;
                                                                                    let v931: &str =
                                                                                        r#"column"#;
                                                                                    let v936:
                                                                                            string =
                                                                                        append(append(string("dominator::class! {"),
                                                                                                      append(v926,
                                                                                                             string(" .style(v928, v931) "))),
                                                                                               v661);
                                                                                    let v937 = dominator::class! { .style(v910, v912)  .style(v916, v918)  .style(v922, v924)  .style(v928, v931) };
                                                                                    let v939:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        v907.class(&*v937);
                                                                                    let v947:
                                                                                            string =
                                                                                        append(append(string("["),
                                                                                                      append(append(v66,
                                                                                                                    string("v814")),
                                                                                                             string(", v902"))),
                                                                                               string("]"));
                                                                                    let v948 = [
                                                                                        v814, v902,
                                                                                    ];
                                                                                    let v950:
                                                                                            dominator::DomBuilder<web_sys::HtmlElement> =
                                                                                        v939.children(v948);
                                                                                    let v952:
                                                                                            dominator::Dom =
                                                                                        v950.into_dom();
                                                                                    let v954:
                                                                                            web_sys::HtmlElement =
                                                                                        dominator::body();
                                                                                    dominator::append_dom(&v954, v952);
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
