#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Cli {
    use super::*;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
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
    #[derive(Clone, Debug, Hash)]
    pub enum UH0 { UH0_0(std::string::String, Lrc<Cli::UH0>), UH0_1, }
    #[derive(Clone, Debug, Hash)]
    pub struct Mut0 {
        pub l0: MutCell<Lrc<Cli::UH0>>,
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum UH1 { UH1_0(string, Lrc<Cli::UH1>), UH1_1, }
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1() -> string { string("rs-path") }
    pub fn method2(v0_1: string) -> string { v0_1 }
    pub fn method3(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method3:
            loop  {
                break '_method3
                    (if length(v1.get()) < v0_1.get() {
                         let v0_1_temp: i32 = v0_1.get();
                         let v1_temp: string =
                             stringFrom(format!("0{0}", &v1.get()));
                         v0_1.set(v0_1_temp);
                         v1.set(v1_temp);
                         continue '_method3
                     } else { v1.get() }) ;
            }
    }
    pub fn method4() -> string { string("$1=$2") }
    pub fn method5() -> string { string("[$1]") }
    pub fn method6() -> string { string(" ") }
    pub fn method7() -> string { string("387957") }
    pub fn method8() -> string { string("385779") }
    pub fn method9() -> string { string("881749") }
    pub fn closure1(v0_1: i64, v1: Lrc<Cli::Mut0>, v2: Vec<u8>)
     -> Result<bool, std::io::Error> {
        let v6: std::string::String =
            (&string("line len")).to_string().clone();
        let v8: i32 = (&v2).len().try_into().unwrap();
        let v12: Array<std::string::String> =
            array(&[v6, format!("{:?}", &v8)]);
        let v14 = core::ops::Deref::deref(&v12);
        let v16 = &***&v14;
        let v17 = &***&v16;
        let v19: std::string::String = format!("{:?}", &v17).clone();
        let v21: std::string::String =
            std::string::String::from_utf8((&v2).to_owned()).unwrap();
        let v22: Lrc<Cli::UH0> = v1.l0.get().clone();
        v1.l0.set(Lrc::new(Cli::UH0::UH0_0(v21.clone(), v22.clone())));
        Ok(true)
    }
    pub fn method10(v0_1: i64, v1: Lrc<Cli::Mut0>)
     -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       move |v: Vec<u8>|
                           Cli::closure1(v0_1, v1.clone(), v.clone())
                   })
    }
    pub fn method11(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH0>) -> Lrc<Cli::UH0> {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v1.clone());
        '_method11:
            loop  {
                break '_method11
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH0> =
                                 Lrc::new(Cli::UH0::UH0_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method11
                         }
                     }) ;
            }
    }
    pub fn method12(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        match v0_1.as_ref() {
            Cli::UH0::UH0_1 => v1.clone(),
            Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                let v4: Lrc<Cli::UH1> = Cli::method12(v0_1_0_1.clone(), v1);
                Lrc::new(Cli::UH1::UH1_0(fable_library_rust::String_::fromStr(v0_1_0_0),
                                         v4))
            }
        }
    }
    pub fn method13(v0_1: Lrc<Cli::UH1>, v1: i32) -> i32 {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method13:
            loop  {
                break '_method13
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: i32 = v1.get() + 1i32;
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method13
                         }
                     }) ;
            }
    }
    pub fn method14(v0_1: i64, v1: Lrc<Cli::UH1>, v2: i32, v3: Lrc<Cli::UH1>)
     -> (i32, Lrc<Cli::UH1>) {
        let v0_1: MutCell<i64> = MutCell::new(v0_1);
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        let v2: MutCell<i32> = MutCell::new(v2);
        let v3: MutCell<Lrc<Cli::UH1>> = MutCell::new(v3.clone());
        '_method14:
            loop  {
                break '_method14
                    (match v1.get().as_ref() {
                         Cli::UH1::UH1_1 => (v2.get(), v3.get()),
                         Cli::UH1::UH1_0(v1_0_0, v1_0_1) => {
                             let v4: string = v1_0_0.clone();
                             let patternInput: (i32, Lrc<Cli::UH1>) =
                                 if ((&v4).clone()).contains(&*(&string("/node_modules/")).clone())
                                    {
                                     let v20: Array<std::string::String> =
                                         array(&[(&string("found line. removing.")).to_string(),
                                                 (&string(" line")).to_string(),
                                                 (&v4).to_string()]);
                                     let v22 = core::ops::Deref::deref(&v20);
                                     let v24 = &***&v22;
                                     let v25 = &***&v24;
                                     let v28: std::string::String =
                                         format!("{:?}", &v25).clone();
                                     let v30: chrono::DateTime<chrono::Utc> =
                                         chrono::Utc::now();
                                     let v36: string =
                                         Cli::method3(6i32,
                                                      toString(&((&v30).timestamp()
                                                                     -
                                                                     v0_1.get())));
                                     let v38: u8 = rand::random::<u8>();
                                     let v55: Array<std::string::String> =
                                         array(&[(&string("timestamp")).to_string(),
                                                 (&v36).to_string(),
                                                 (&string("run_id")).to_string(),
                                                 format!("{:?}", &v38),
                                                 (&string("log_level")).to_string(),
                                                 (&string("Debug")).to_string()]);
                                     let v56 = core::ops::Deref::deref(&v55);
                                     let v57 = &***&v56;
                                     let v58 = &***&v57;
                                     let v60: std::string::String =
                                         format!("{:?}", &v58).clone();
                                     let v64: Array<std::string::String> =
                                         array(&[(&string("> app ()")).to_string()]);
                                     let v65 = core::ops::Deref::deref(&v64);
                                     let v66 = &***&v65;
                                     let v67 = &***&v66;
                                     let v69: std::string::String =
                                         format!("{:?}", &v67).clone();
                                     let v72: string =
                                         toString(&format!("{}", &v69));
                                     let v75: &str =
                                         r#""([^"]+)", "([^"]+)""#;
                                     let v77: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v75);
                                     let v79: &regex::Regex =
                                         &v77.build().unwrap();
                                     let v80: string = Cli::method2(v72);
                                     let v82: &str = &v80.as_str();
                                     let v83: string = Cli::method4();
                                     let v84: &str = &v83.as_str();
                                     let v86: std::string::String =
                                         v79.replace_all(&v82, v84).to_string();
                                     let v88: string =
                                         fable_library_rust::String_::fromStr(&v86);
                                     let v91: &str = r#"\["(.*?)"\]"#;
                                     let v92: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v91);
                                     let v93: &regex::Regex =
                                         &v92.build().unwrap();
                                     let v94: string = Cli::method2(v88);
                                     let v95: &str = &v94.as_str();
                                     let v96: string = Cli::method5();
                                     let v97: &str = &v96.as_str();
                                     let v98: std::string::String =
                                         v93.replace_all(&v95, v97).to_string();
                                     let v99: string =
                                         fable_library_rust::String_::fromStr(&v98);
                                     let v102: &str = r#", "#;
                                     let v103: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v102);
                                     let v104: &regex::Regex =
                                         &v103.build().unwrap();
                                     let v105: string = Cli::method2(v99);
                                     let v106: &str = &v105.as_str();
                                     let v107: string = Cli::method6();
                                     let v108: &str = &v107.as_str();
                                     let v109: std::string::String =
                                         v104.replace_all(&v106, v108).to_string();
                                     let v110: string =
                                         fable_library_rust::String_::fromStr(&v109);
                                     let v112: std::string::String =
                                         (&v110).to_string().clone();
                                     let v114: string =
                                         toString(&format!("{}", &v28));
                                     let v116: &str =
                                         r#""([^"]+)", "([^"]+)""#;
                                     let v117: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v116);
                                     let v118: &regex::Regex =
                                         &v117.build().unwrap();
                                     let v119: string = Cli::method2(v114);
                                     let v120: &str = &v119.as_str();
                                     let v121: string = Cli::method4();
                                     let v122: &str = &v121.as_str();
                                     let v123: std::string::String =
                                         v118.replace_all(&v120, v122).to_string();
                                     let v124: string =
                                         fable_library_rust::String_::fromStr(&v123);
                                     let v126: &str = r#"\["(.*?)"\]"#;
                                     let v127: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v126);
                                     let v128: &regex::Regex =
                                         &v127.build().unwrap();
                                     let v129: string = Cli::method2(v124);
                                     let v130: &str = &v129.as_str();
                                     let v131: string = Cli::method5();
                                     let v132: &str = &v131.as_str();
                                     let v133: std::string::String =
                                         v128.replace_all(&v130, v132).to_string();
                                     let v134: string =
                                         fable_library_rust::String_::fromStr(&v133);
                                     let v136: &str = r#", "#;
                                     let v137: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v136);
                                     let v138: &regex::Regex =
                                         &v137.build().unwrap();
                                     let v139: string = Cli::method2(v134);
                                     let v140: &str = &v139.as_str();
                                     let v141: string = Cli::method6();
                                     let v142: &str = &v141.as_str();
                                     let v143: std::string::String =
                                         v138.replace_all(&v140, v142).to_string();
                                     let v144: string =
                                         fable_library_rust::String_::fromStr(&v143);
                                     let v146: std::string::String =
                                         (&v144).to_string().clone();
                                     let v148: string =
                                         toString(&format!("{}", &v60));
                                     let v150: &str =
                                         r#""([^"]+)", "([^"]+)""#;
                                     let v151: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v150);
                                     let v152: &regex::Regex =
                                         &v151.build().unwrap();
                                     let v153: string = Cli::method2(v148);
                                     let v154: &str = &v153.as_str();
                                     let v155: string = Cli::method4();
                                     let v156: &str = &v155.as_str();
                                     let v157: std::string::String =
                                         v152.replace_all(&v154, v156).to_string();
                                     let v158: string =
                                         fable_library_rust::String_::fromStr(&v157);
                                     let v160: &str = r#"\["(.*?)"\]"#;
                                     let v161: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v160);
                                     let v162: &regex::Regex =
                                         &v161.build().unwrap();
                                     let v163: string = Cli::method2(v158);
                                     let v164: &str = &v163.as_str();
                                     let v165: string = Cli::method5();
                                     let v166: &str = &v165.as_str();
                                     let v167: std::string::String =
                                         v162.replace_all(&v164, v166).to_string();
                                     let v168: string =
                                         fable_library_rust::String_::fromStr(&v167);
                                     let v170: &str = r#", "#;
                                     let v171: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v170);
                                     let v172: &regex::Regex =
                                         &v171.build().unwrap();
                                     let v173: string = Cli::method2(v168);
                                     let v174: &str = &v173.as_str();
                                     let v175: string = Cli::method6();
                                     let v176: &str = &v175.as_str();
                                     let v177: std::string::String =
                                         v172.replace_all(&v174, v176).to_string();
                                     let v178: string =
                                         fable_library_rust::String_::fromStr(&v177);
                                     let v180: std::string::String =
                                         (&v178).to_string().clone();
                                     if let Cli::US0::US0_1 =
                                            &if cfg!(target_arch = "wasm32") {
                                                 Cli::US0::US0_1
                                             } else { Cli::US0::US0_0 } {
                                         let v189: string = string(" %c");
                                         let v193: string =
                                             append(append(append(append(toString(&v112),
                                                                         v189.clone()),
                                                                  toString(&v146)),
                                                           v189),
                                                    toString(&v180));
                                         let v201:
                                                 Array<std::string::String> =
                                             array(&[(&v193).as_ref().to_string(),
                                                     (&stringFrom(format!("color: #{0};",
                                                                          &string("387957")))).as_ref().to_string(),
                                                     (&string("color: #385779;")).as_ref().to_string()]);
                                         let v202 =
                                             core::ops::Deref::deref(&v201);
                                         let v205 =
                                             serde_wasm_bindgen::to_value(&*****&v202).unwrap();
                                         web_sys::console::log(&js_sys::Array::from(&v205));
                                         ()
                                     } else {
                                         let v207: string = Cli::method7();
                                         let v208: &str = &v207.as_str();
                                         let v212: &str =
                                             &v208[0i32 as
                                                       usize..2i32 as usize];
                                         let v213: string =
                                             fable_library_rust::String_::fromStr(&v212);
                                         let v215: u8 =
                                             u8::from_str_radix(&v213, 16).unwrap();
                                         let v216: string = Cli::method7();
                                         let v217: &str = &v216.as_str();
                                         let v220: &str =
                                             &v217[2i32 as
                                                       usize..4i32 as usize];
                                         let v221: string =
                                             fable_library_rust::String_::fromStr(&v220);
                                         let v222: u8 =
                                             u8::from_str_radix(&v221, 16).unwrap();
                                         let v223: string = Cli::method7();
                                         let v224: &str = &v223.as_str();
                                         let v227: &str =
                                             &v224[4i32 as
                                                       usize..6i32 as usize];
                                         let v228: string =
                                             fable_library_rust::String_::fromStr(&v227);
                                         let v229: u8 =
                                             u8::from_str_radix(&v228, 16).unwrap();
                                         let v231: colored::ColoredString =
                                             colored::Colorize::truecolor(&*v146.to_string(), v215, v222, v229);
                                         let v232: std::string::String =
                                             format!("{}", &v231);
                                         let v233: string = Cli::method8();
                                         let v234: &str = &v233.as_str();
                                         let v237: &str =
                                             &v234[0i32 as
                                                       usize..2i32 as usize];
                                         let v238: string =
                                             fable_library_rust::String_::fromStr(&v237);
                                         let v239: u8 =
                                             u8::from_str_radix(&v238, 16).unwrap();
                                         let v240: string = Cli::method8();
                                         let v241: &str = &v240.as_str();
                                         let v244: &str =
                                             &v241[2i32 as
                                                       usize..4i32 as usize];
                                         let v245: string =
                                             fable_library_rust::String_::fromStr(&v244);
                                         let v246: u8 =
                                             u8::from_str_radix(&v245, 16).unwrap();
                                         let v247: string = Cli::method8();
                                         let v248: &str = &v247.as_str();
                                         let v251: &str =
                                             &v248[4i32 as
                                                       usize..6i32 as usize];
                                         let v252: string =
                                             fable_library_rust::String_::fromStr(&v251);
                                         let v253: u8 =
                                             u8::from_str_radix(&v252, 16).unwrap();
                                         let v254: colored::ColoredString =
                                             colored::Colorize::truecolor(&*v180.to_string(), v239, v246, v253);
                                         let v255: std::string::String =
                                             format!("{}", &v254);
                                         println!("{0}",
                                                  stringFrom(format!("{0} {1} {2}", &v112, &v232, &v255)));
                                         ()
                                     }
                                     (1i32, v3.get())
                                 } else {
                                     if 0i32 == v2.get() {
                                         (0i32,
                                          Lrc::new(Cli::UH1::UH1_0(v4,
                                                                   v3.get())))
                                     } else {
                                         if 2i32 == v2.get() {
                                             (0i32, v3.get())
                                         } else {
                                             (v2.get() + 1i32, v3.get())
                                         }
                                     }
                                 };
                             {
                                 let v0_1_temp: i64 = v0_1.get();
                                 let v1_temp: Lrc<Cli::UH1> = v1_0_1.clone();
                                 let v2_temp: i32 = patternInput.0.clone();
                                 let v3_temp: Lrc<Cli::UH1> =
                                     patternInput.1.clone();
                                 v0_1.set(v0_1_temp);
                                 v1.set(v1_temp);
                                 v2.set(v2_temp);
                                 v3.set(v3_temp);
                                 continue '_method14
                             }
                         }
                     }) ;
            }
    }
    pub fn method15(v0_1: Lrc<Cli::UH1>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        '_method15:
            loop  {
                break '_method15
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH1> =
                                 Lrc::new(Cli::UH1::UH1_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method15
                         }
                     }) ;
            }
    }
    pub fn method16(v0_1: Lrc<Cli::UH1>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method16:
            loop  {
                break '_method16
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: string =
                                 append(v1.get(), v0_1_0_0.clone());
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method16
                         }
                     }) ;
            }
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let patternInput: (string, string, string, bool) = Cli::method0();
        let v5: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v7: i64 = (&v5).timestamp();
        let v10: &str = r#"app1"#;
        let v11: string = string("clap::Command::new($0)");
        let v12: string = string(".propagate_version(true)");
        let v14: string = string(".subcommand_required(false)");
        let v16: string = string(".about(\"command about\")");
        let v18: string = string(".arg_required_else_help(true)");
        let v19: string =
            append(append(append(append(v11.clone(), v12.clone()),
                                 v14.clone()), v16.clone()), v18.clone());
        let v20: clap::builder::Command =
            clap::Command::new(&v10).propagate_version(true).subcommand_required(false).about("command about").arg_required_else_help(true);
        let v23: &str = r#"PostFsxRsBuild"#;
        let v27: string =
            append(append(append(append(v11.clone(), v12.clone()),
                                 v14.clone()), v16.clone()), v18.clone());
        let v28: clap::builder::Command =
            clap::Command::new(&v23).propagate_version(true).subcommand_required(false).about("command about").arg_required_else_help(true);
        let v31: &str = r#"rs-path"#;
        let v33: clap::builder::Arg = clap::Arg::new(&v31);
        let v35: clap::builder::Command = v28.arg(v33);
        let v37: clap::builder::Command = v20.subcommand(v35);
        let v40: &str = r#"SpiFsxBuild"#;
        let v44: string =
            append(append(append(append(v11, v12), v14), v16), v18);
        let v45: clap::builder::Command =
            clap::Command::new(&v40).propagate_version(true).subcommand_required(false).about("command about").arg_required_else_help(true);
        let v48: &str = r#"spi-path"#;
        let v49: clap::builder::Arg = clap::Arg::new(&v48);
        let v50: clap::builder::Command = v45.arg(v49);
        let v53: &str = r#"fsx-path"#;
        let v54: clap::builder::Arg = clap::Arg::new(&v53);
        let v55: clap::builder::Command = v50.arg(v54);
        let v56: clap::builder::Command = v37.subcommand(v55);
        let v58: &clap::parser::ArgMatches = &v56.get_matches();
        let v60: &Option<(&str, &clap::parser::ArgMatches)> =
            &v58.subcommand();
        let patternInput_1: (&str, &clap::parser::ArgMatches) =
            *((&v60).as_ref()).unwrap();
        let v64: string = Cli::method1();
        let v66: &str = &v64.as_str();
        let v68: string = Cli::method2(string("--rs-path="));
        let v69: &str = &v68.as_str();
        let v71: &std::string::String =
            &(patternInput_1.1.clone()).get_one::<String>(v66).unwrap().replace(v69, "");
        let v73: std::path::PathBuf = std::path::PathBuf::from(&v71);
        let v75: Result<std::path::PathBuf, std::io::Error> =
            (&v73).canonicalize();
        let v77: std::path::PathBuf = (&v75).as_ref().unwrap().to_path_buf();
        let v85: Array<std::string::String> =
            array(&[(&string("rs_path_clean")).to_string(),
                    format!("{:?}", &v77)]);
        let v87 = core::ops::Deref::deref(&v85);
        let v89 = &***&v87;
        let v90 = &***&v89;
        let v92: std::string::String = format!("{:?}", &v90).clone();
        let v93: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v98: string =
            Cli::method3(6i32, toString(&((&v93).timestamp() - v7)));
        let v100: u8 = rand::random::<u8>();
        let v101: string = string("timestamp");
        let v106: string = string("run_id");
        let v111: string = string("log_level");
        let v114: string = string("Debug");
        let v117: Array<std::string::String> =
            array(&[(&v101).to_string(), (&v98).to_string(),
                    (&v106).to_string(), format!("{:?}", &v100),
                    (&v111).to_string(), (&v114).to_string()]);
        let v118 = core::ops::Deref::deref(&v117);
        let v119 = &***&v118;
        let v120 = &***&v119;
        let v122: std::string::String = format!("{:?}", &v120).clone();
        let v123: string = string("> app ()");
        let v126: Array<std::string::String> = array(&[(&v123).to_string()]);
        let v127 = core::ops::Deref::deref(&v126);
        let v128 = &***&v127;
        let v129 = &***&v128;
        let v131: std::string::String = format!("{:?}", &v129).clone();
        let v134: string = toString(&format!("{}", &v131));
        let v137: &str = r#""([^"]+)", "([^"]+)""#;
        let v139: regex::RegexBuilder = regex::RegexBuilder::new(&v137);
        let v141: &regex::Regex = &v139.build().unwrap();
        let v142: string = Cli::method2(v134);
        let v143: &str = &v142.as_str();
        let v144: string = Cli::method4();
        let v145: &str = &v144.as_str();
        let v147: std::string::String =
            v141.replace_all(&v143, v145).to_string();
        let v149: string = fable_library_rust::String_::fromStr(&v147);
        let v152: &str = r#"\["(.*?)"\]"#;
        let v153: regex::RegexBuilder = regex::RegexBuilder::new(&v152);
        let v154: &regex::Regex = &v153.build().unwrap();
        let v155: string = Cli::method2(v149);
        let v156: &str = &v155.as_str();
        let v157: string = Cli::method5();
        let v158: &str = &v157.as_str();
        let v159: std::string::String =
            v154.replace_all(&v156, v158).to_string();
        let v160: string = fable_library_rust::String_::fromStr(&v159);
        let v163: &str = r#", "#;
        let v164: regex::RegexBuilder = regex::RegexBuilder::new(&v163);
        let v165: &regex::Regex = &v164.build().unwrap();
        let v166: string = Cli::method2(v160);
        let v167: &str = &v166.as_str();
        let v168: string = Cli::method6();
        let v169: &str = &v168.as_str();
        let v170: std::string::String =
            v165.replace_all(&v167, v169).to_string();
        let v171: string = fable_library_rust::String_::fromStr(&v170);
        let v173: std::string::String = (&v171).to_string().clone();
        let v175: string = toString(&format!("{}", &v92));
        let v177: &str = r#""([^"]+)", "([^"]+)""#;
        let v178: regex::RegexBuilder = regex::RegexBuilder::new(&v177);
        let v179: &regex::Regex = &v178.build().unwrap();
        let v180: string = Cli::method2(v175);
        let v181: &str = &v180.as_str();
        let v182: string = Cli::method4();
        let v183: &str = &v182.as_str();
        let v184: std::string::String =
            v179.replace_all(&v181, v183).to_string();
        let v185: string = fable_library_rust::String_::fromStr(&v184);
        let v187: &str = r#"\["(.*?)"\]"#;
        let v188: regex::RegexBuilder = regex::RegexBuilder::new(&v187);
        let v189: &regex::Regex = &v188.build().unwrap();
        let v190: string = Cli::method2(v185);
        let v191: &str = &v190.as_str();
        let v192: string = Cli::method5();
        let v193: &str = &v192.as_str();
        let v194: std::string::String =
            v189.replace_all(&v191, v193).to_string();
        let v195: string = fable_library_rust::String_::fromStr(&v194);
        let v197: &str = r#", "#;
        let v198: regex::RegexBuilder = regex::RegexBuilder::new(&v197);
        let v199: &regex::Regex = &v198.build().unwrap();
        let v200: string = Cli::method2(v195);
        let v201: &str = &v200.as_str();
        let v202: string = Cli::method6();
        let v203: &str = &v202.as_str();
        let v204: std::string::String =
            v199.replace_all(&v201, v203).to_string();
        let v205: string = fable_library_rust::String_::fromStr(&v204);
        let v207: std::string::String = (&v205).to_string().clone();
        let v209: string = toString(&format!("{}", &v122));
        let v211: &str = r#""([^"]+)", "([^"]+)""#;
        let v212: regex::RegexBuilder = regex::RegexBuilder::new(&v211);
        let v213: &regex::Regex = &v212.build().unwrap();
        let v214: string = Cli::method2(v209);
        let v215: &str = &v214.as_str();
        let v216: string = Cli::method4();
        let v217: &str = &v216.as_str();
        let v218: std::string::String =
            v213.replace_all(&v215, v217).to_string();
        let v219: string = fable_library_rust::String_::fromStr(&v218);
        let v221: &str = r#"\["(.*?)"\]"#;
        let v222: regex::RegexBuilder = regex::RegexBuilder::new(&v221);
        let v223: &regex::Regex = &v222.build().unwrap();
        let v224: string = Cli::method2(v219);
        let v225: &str = &v224.as_str();
        let v226: string = Cli::method5();
        let v227: &str = &v226.as_str();
        let v228: std::string::String =
            v223.replace_all(&v225, v227).to_string();
        let v229: string = fable_library_rust::String_::fromStr(&v228);
        let v231: &str = r#", "#;
        let v232: regex::RegexBuilder = regex::RegexBuilder::new(&v231);
        let v233: &regex::Regex = &v232.build().unwrap();
        let v234: string = Cli::method2(v229);
        let v235: &str = &v234.as_str();
        let v236: string = Cli::method6();
        let v237: &str = &v236.as_str();
        let v238: std::string::String =
            v233.replace_all(&v235, v237).to_string();
        let v239: string = fable_library_rust::String_::fromStr(&v238);
        let v241: std::string::String = (&v239).to_string().clone();
        if let Cli::US0::US0_1 =
               &if cfg!(target_arch = "wasm32") {
                    Cli::US0::US0_1
                } else { Cli::US0::US0_0 } {
            let v250: string = string(" %c");
            let v254: string =
                append(append(append(append(toString(&v173), v250.clone()),
                                     toString(&v207)), v250),
                       toString(&v241));
            let v262: Array<std::string::String> =
                array(&[(&v254).as_ref().to_string(),
                        (&stringFrom(format!("color: #{0};",
                                             &string("387957")))).as_ref().to_string(),
                        (&string("color: #385779;")).as_ref().to_string()]);
            let v263 = core::ops::Deref::deref(&v262);
            let v266 = serde_wasm_bindgen::to_value(&*****&v263).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v266));
            ()
        } else {
            let v268: string = Cli::method7();
            let v269: &str = &v268.as_str();
            let v273: &str = &v269[0i32 as usize..2i32 as usize];
            let v274: string = fable_library_rust::String_::fromStr(&v273);
            let v276: u8 = u8::from_str_radix(&v274, 16).unwrap();
            let v277: string = Cli::method7();
            let v278: &str = &v277.as_str();
            let v281: &str = &v278[2i32 as usize..4i32 as usize];
            let v282: string = fable_library_rust::String_::fromStr(&v281);
            let v283: u8 = u8::from_str_radix(&v282, 16).unwrap();
            let v284: string = Cli::method7();
            let v285: &str = &v284.as_str();
            let v288: &str = &v285[4i32 as usize..6i32 as usize];
            let v289: string = fable_library_rust::String_::fromStr(&v288);
            let v290: u8 = u8::from_str_radix(&v289, 16).unwrap();
            let v292: colored::ColoredString =
                colored::Colorize::truecolor(&*v207.to_string(), v276, v283, v290);
            let v293: std::string::String = format!("{}", &v292);
            let v294: string = Cli::method8();
            let v295: &str = &v294.as_str();
            let v298: &str = &v295[0i32 as usize..2i32 as usize];
            let v299: string = fable_library_rust::String_::fromStr(&v298);
            let v300: u8 = u8::from_str_radix(&v299, 16).unwrap();
            let v301: string = Cli::method8();
            let v302: &str = &v301.as_str();
            let v305: &str = &v302[2i32 as usize..4i32 as usize];
            let v306: string = fable_library_rust::String_::fromStr(&v305);
            let v307: u8 = u8::from_str_radix(&v306, 16).unwrap();
            let v308: string = Cli::method8();
            let v309: &str = &v308.as_str();
            let v312: &str = &v309[4i32 as usize..6i32 as usize];
            let v313: string = fable_library_rust::String_::fromStr(&v312);
            let v314: u8 = u8::from_str_radix(&v313, 16).unwrap();
            let v315: colored::ColoredString =
                colored::Colorize::truecolor(&*v241.to_string(), v300, v307, v314);
            let v316: std::string::String = format!("{}", &v315);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v173, &v293, &v316)));
            ()
        }
        {
            let patternInput_2: (string, string, string, bool) =
                Cli::method0();
            let v322: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v323: i64 = (&v322).timestamp();
            let v324: Result<std::path::PathBuf, std::io::Error> =
                (&v77).canonicalize();
            let v325: std::path::PathBuf =
                (&v324).as_ref().unwrap().to_path_buf();
            let v328: std::string::String =
                (&string("path_clean")).to_string().clone();
            let v330: string =
                fable_library_rust::String_::fromStr(&format!("{}", &v325.display()));
            let v333: Array<std::string::String> =
                array(&[v328, (&v330).to_string()]);
            let v334 = core::ops::Deref::deref(&v333);
            let v335 = &***&v334;
            let v336 = &***&v335;
            let v338: std::string::String = format!("{:?}", &v336).clone();
            let v339: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v344: string =
                Cli::method3(6i32, toString(&((&v339).timestamp() - v323)));
            let v345: u8 = rand::random::<u8>();
            let v358: Array<std::string::String> =
                array(&[(&v101).to_string(), (&v344).to_string(),
                        (&v106).to_string(), format!("{:?}", &v345),
                        (&v111).to_string(), (&v114).to_string()]);
            let v359 = core::ops::Deref::deref(&v358);
            let v360 = &***&v359;
            let v361 = &***&v360;
            let v363: std::string::String = format!("{:?}", &v361).clone();
            let v364: string = string("> read_lines ()");
            let v367: Array<std::string::String> =
                array(&[(&v364).to_string()]);
            let v368 = core::ops::Deref::deref(&v367);
            let v369 = &***&v368;
            let v370 = &***&v369;
            let v372: std::string::String = format!("{:?}", &v370).clone();
            let v374: string = toString(&format!("{}", &v372));
            let v376: &str = r#""([^"]+)", "([^"]+)""#;
            let v377: regex::RegexBuilder = regex::RegexBuilder::new(&v376);
            let v378: &regex::Regex = &v377.build().unwrap();
            let v379: string = Cli::method2(v374);
            let v380: &str = &v379.as_str();
            let v381: string = Cli::method4();
            let v382: &str = &v381.as_str();
            let v383: std::string::String =
                v378.replace_all(&v380, v382).to_string();
            let v384: string = fable_library_rust::String_::fromStr(&v383);
            let v386: &str = r#"\["(.*?)"\]"#;
            let v387: regex::RegexBuilder = regex::RegexBuilder::new(&v386);
            let v388: &regex::Regex = &v387.build().unwrap();
            let v389: string = Cli::method2(v384);
            let v390: &str = &v389.as_str();
            let v391: string = Cli::method5();
            let v392: &str = &v391.as_str();
            let v393: std::string::String =
                v388.replace_all(&v390, v392).to_string();
            let v394: string = fable_library_rust::String_::fromStr(&v393);
            let v396: &str = r#", "#;
            let v397: regex::RegexBuilder = regex::RegexBuilder::new(&v396);
            let v398: &regex::Regex = &v397.build().unwrap();
            let v399: string = Cli::method2(v394);
            let v400: &str = &v399.as_str();
            let v401: string = Cli::method6();
            let v402: &str = &v401.as_str();
            let v403: std::string::String =
                v398.replace_all(&v400, v402).to_string();
            let v404: string = fable_library_rust::String_::fromStr(&v403);
            let v406: std::string::String = (&v404).to_string().clone();
            let v408: string = toString(&format!("{}", &v338));
            let v410: &str = r#""([^"]+)", "([^"]+)""#;
            let v411: regex::RegexBuilder = regex::RegexBuilder::new(&v410);
            let v412: &regex::Regex = &v411.build().unwrap();
            let v413: string = Cli::method2(v408);
            let v414: &str = &v413.as_str();
            let v415: string = Cli::method4();
            let v416: &str = &v415.as_str();
            let v417: std::string::String =
                v412.replace_all(&v414, v416).to_string();
            let v418: string = fable_library_rust::String_::fromStr(&v417);
            let v420: &str = r#"\["(.*?)"\]"#;
            let v421: regex::RegexBuilder = regex::RegexBuilder::new(&v420);
            let v422: &regex::Regex = &v421.build().unwrap();
            let v423: string = Cli::method2(v418);
            let v424: &str = &v423.as_str();
            let v425: string = Cli::method5();
            let v426: &str = &v425.as_str();
            let v427: std::string::String =
                v422.replace_all(&v424, v426).to_string();
            let v428: string = fable_library_rust::String_::fromStr(&v427);
            let v430: &str = r#", "#;
            let v431: regex::RegexBuilder = regex::RegexBuilder::new(&v430);
            let v432: &regex::Regex = &v431.build().unwrap();
            let v433: string = Cli::method2(v428);
            let v434: &str = &v433.as_str();
            let v435: string = Cli::method6();
            let v436: &str = &v435.as_str();
            let v437: std::string::String =
                v432.replace_all(&v434, v436).to_string();
            let v438: string = fable_library_rust::String_::fromStr(&v437);
            let v440: std::string::String = (&v438).to_string().clone();
            let v442: string = toString(&format!("{}", &v363));
            let v444: &str = r#""([^"]+)", "([^"]+)""#;
            let v445: regex::RegexBuilder = regex::RegexBuilder::new(&v444);
            let v446: &regex::Regex = &v445.build().unwrap();
            let v447: string = Cli::method2(v442);
            let v448: &str = &v447.as_str();
            let v449: string = Cli::method4();
            let v450: &str = &v449.as_str();
            let v451: std::string::String =
                v446.replace_all(&v448, v450).to_string();
            let v452: string = fable_library_rust::String_::fromStr(&v451);
            let v454: &str = r#"\["(.*?)"\]"#;
            let v455: regex::RegexBuilder = regex::RegexBuilder::new(&v454);
            let v456: &regex::Regex = &v455.build().unwrap();
            let v457: string = Cli::method2(v452);
            let v458: &str = &v457.as_str();
            let v459: string = Cli::method5();
            let v460: &str = &v459.as_str();
            let v461: std::string::String =
                v456.replace_all(&v458, v460).to_string();
            let v462: string = fable_library_rust::String_::fromStr(&v461);
            let v464: &str = r#", "#;
            let v465: regex::RegexBuilder = regex::RegexBuilder::new(&v464);
            let v466: &regex::Regex = &v465.build().unwrap();
            let v467: string = Cli::method2(v462);
            let v468: &str = &v467.as_str();
            let v469: string = Cli::method6();
            let v470: &str = &v469.as_str();
            let v471: std::string::String =
                v466.replace_all(&v468, v470).to_string();
            let v472: string = fable_library_rust::String_::fromStr(&v471);
            let v474: std::string::String = (&v472).to_string().clone();
            if let Cli::US0::US0_1 =
                   &if cfg!(target_arch = "wasm32") {
                        Cli::US0::US0_1
                    } else { Cli::US0::US0_0 } {
                let v482: string = string(" %c");
                let v486: string =
                    append(append(append(append(toString(&v406),
                                                v482.clone()),
                                         toString(&v440)), v482),
                           toString(&v474));
                let v494: Array<std::string::String> =
                    array(&[(&v486).as_ref().to_string(),
                            (&stringFrom(format!("color: #{0};",
                                                 &string("881749")))).as_ref().to_string(),
                            (&string("color: #385779;")).as_ref().to_string()]);
                let v495 = core::ops::Deref::deref(&v494);
                let v498 = serde_wasm_bindgen::to_value(&*****&v495).unwrap();
                web_sys::console::log(&js_sys::Array::from(&v498));
                ()
            } else {
                let v500: string = Cli::method9();
                let v501: &str = &v500.as_str();
                let v505: &str = &v501[0i32 as usize..2i32 as usize];
                let v506: string =
                    fable_library_rust::String_::fromStr(&v505);
                let v508: u8 = u8::from_str_radix(&v506, 16).unwrap();
                let v509: string = Cli::method9();
                let v510: &str = &v509.as_str();
                let v513: &str = &v510[2i32 as usize..4i32 as usize];
                let v514: string =
                    fable_library_rust::String_::fromStr(&v513);
                let v515: u8 = u8::from_str_radix(&v514, 16).unwrap();
                let v516: string = Cli::method9();
                let v517: &str = &v516.as_str();
                let v520: &str = &v517[4i32 as usize..6i32 as usize];
                let v521: string =
                    fable_library_rust::String_::fromStr(&v520);
                let v522: u8 = u8::from_str_radix(&v521, 16).unwrap();
                let v524: colored::ColoredString =
                    colored::Colorize::truecolor(&*v440.to_string(), v508, v515, v522);
                let v525: std::string::String = format!("{}", &v524);
                let v526: string = Cli::method8();
                let v527: &str = &v526.as_str();
                let v530: &str = &v527[0i32 as usize..2i32 as usize];
                let v531: string =
                    fable_library_rust::String_::fromStr(&v530);
                let v532: u8 = u8::from_str_radix(&v531, 16).unwrap();
                let v533: string = Cli::method8();
                let v534: &str = &v533.as_str();
                let v537: &str = &v534[2i32 as usize..4i32 as usize];
                let v538: string =
                    fable_library_rust::String_::fromStr(&v537);
                let v539: u8 = u8::from_str_radix(&v538, 16).unwrap();
                let v540: string = Cli::method8();
                let v541: &str = &v540.as_str();
                let v544: &str = &v541[4i32 as usize..6i32 as usize];
                let v545: string =
                    fable_library_rust::String_::fromStr(&v544);
                let v546: u8 = u8::from_str_radix(&v545, 16).unwrap();
                let v547: colored::ColoredString =
                    colored::Colorize::truecolor(&*v474.to_string(), v532, v539, v546);
                let v548: std::string::String = format!("{}", &v547);
                println!("{0}",
                         stringFrom(format!("{0} {1} {2}", &v406, &v525, &v548)));
                ()
            }
            {
                let v551: Result<std::fs::File, std::io::Error> =
                    std::fs::File::open(&v325);
                let v553: &std::fs::File = &v551.unwrap();
                let v555:
                        std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                    std::cell::RefCell::new(linereader::LineReader::new(&v553));
                let v561: Array<std::string::String> =
                    array(&[(&string("reader")).to_string(),
                            format!("{:?}", &v555)]);
                let v562 = core::ops::Deref::deref(&v561);
                let v563 = &***&v562;
                let v564 = &***&v563;
                let v566: std::string::String =
                    format!("{:?}", &v564).clone();
                let v567: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v572: string =
                    Cli::method3(6i32,
                                 toString(&((&v567).timestamp() - v323)));
                let v573: u8 = rand::random::<u8>();
                let v586: Array<std::string::String> =
                    array(&[(&v101).to_string(), (&v572).to_string(),
                            (&v106).to_string(), format!("{:?}", &v573),
                            (&v111).to_string(), (&v114).to_string()]);
                let v587 = core::ops::Deref::deref(&v586);
                let v588 = &***&v587;
                let v589 = &***&v588;
                let v591: std::string::String =
                    format!("{:?}", &v589).clone();
                let v594: Array<std::string::String> =
                    array(&[(&v364).to_string()]);
                let v595 = core::ops::Deref::deref(&v594);
                let v596 = &***&v595;
                let v597 = &***&v596;
                let v599: std::string::String =
                    format!("{:?}", &v597).clone();
                let v601: string = toString(&format!("{}", &v599));
                let v603: &str = r#""([^"]+)", "([^"]+)""#;
                let v604: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v603);
                let v605: &regex::Regex = &v604.build().unwrap();
                let v606: string = Cli::method2(v601);
                let v607: &str = &v606.as_str();
                let v608: string = Cli::method4();
                let v609: &str = &v608.as_str();
                let v610: std::string::String =
                    v605.replace_all(&v607, v609).to_string();
                let v611: string =
                    fable_library_rust::String_::fromStr(&v610);
                let v613: &str = r#"\["(.*?)"\]"#;
                let v614: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v613);
                let v615: &regex::Regex = &v614.build().unwrap();
                let v616: string = Cli::method2(v611);
                let v617: &str = &v616.as_str();
                let v618: string = Cli::method5();
                let v619: &str = &v618.as_str();
                let v620: std::string::String =
                    v615.replace_all(&v617, v619).to_string();
                let v621: string =
                    fable_library_rust::String_::fromStr(&v620);
                let v623: &str = r#", "#;
                let v624: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v623);
                let v625: &regex::Regex = &v624.build().unwrap();
                let v626: string = Cli::method2(v621);
                let v627: &str = &v626.as_str();
                let v628: string = Cli::method6();
                let v629: &str = &v628.as_str();
                let v630: std::string::String =
                    v625.replace_all(&v627, v629).to_string();
                let v631: string =
                    fable_library_rust::String_::fromStr(&v630);
                let v633: std::string::String = (&v631).to_string().clone();
                let v635: string = toString(&format!("{}", &v566));
                let v637: &str = r#""([^"]+)", "([^"]+)""#;
                let v638: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v637);
                let v639: &regex::Regex = &v638.build().unwrap();
                let v640: string = Cli::method2(v635);
                let v641: &str = &v640.as_str();
                let v642: string = Cli::method4();
                let v643: &str = &v642.as_str();
                let v644: std::string::String =
                    v639.replace_all(&v641, v643).to_string();
                let v645: string =
                    fable_library_rust::String_::fromStr(&v644);
                let v647: &str = r#"\["(.*?)"\]"#;
                let v648: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v647);
                let v649: &regex::Regex = &v648.build().unwrap();
                let v650: string = Cli::method2(v645);
                let v651: &str = &v650.as_str();
                let v652: string = Cli::method5();
                let v653: &str = &v652.as_str();
                let v654: std::string::String =
                    v649.replace_all(&v651, v653).to_string();
                let v655: string =
                    fable_library_rust::String_::fromStr(&v654);
                let v657: &str = r#", "#;
                let v658: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v657);
                let v659: &regex::Regex = &v658.build().unwrap();
                let v660: string = Cli::method2(v655);
                let v661: &str = &v660.as_str();
                let v662: string = Cli::method6();
                let v663: &str = &v662.as_str();
                let v664: std::string::String =
                    v659.replace_all(&v661, v663).to_string();
                let v665: string =
                    fable_library_rust::String_::fromStr(&v664);
                let v667: std::string::String = (&v665).to_string().clone();
                let v669: string = toString(&format!("{}", &v591));
                let v671: &str = r#""([^"]+)", "([^"]+)""#;
                let v672: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v671);
                let v673: &regex::Regex = &v672.build().unwrap();
                let v674: string = Cli::method2(v669);
                let v675: &str = &v674.as_str();
                let v676: string = Cli::method4();
                let v677: &str = &v676.as_str();
                let v678: std::string::String =
                    v673.replace_all(&v675, v677).to_string();
                let v679: string =
                    fable_library_rust::String_::fromStr(&v678);
                let v681: &str = r#"\["(.*?)"\]"#;
                let v682: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v681);
                let v683: &regex::Regex = &v682.build().unwrap();
                let v684: string = Cli::method2(v679);
                let v685: &str = &v684.as_str();
                let v686: string = Cli::method5();
                let v687: &str = &v686.as_str();
                let v688: std::string::String =
                    v683.replace_all(&v685, v687).to_string();
                let v689: string =
                    fable_library_rust::String_::fromStr(&v688);
                let v691: &str = r#", "#;
                let v692: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v691);
                let v693: &regex::Regex = &v692.build().unwrap();
                let v694: string = Cli::method2(v689);
                let v695: &str = &v694.as_str();
                let v696: string = Cli::method6();
                let v697: &str = &v696.as_str();
                let v698: std::string::String =
                    v693.replace_all(&v695, v697).to_string();
                let v699: string =
                    fable_library_rust::String_::fromStr(&v698);
                let v701: std::string::String = (&v699).to_string().clone();
                if let Cli::US0::US0_1 =
                       &if cfg!(target_arch = "wasm32") {
                            Cli::US0::US0_1
                        } else { Cli::US0::US0_0 } {
                    let v709: string = string(" %c");
                    let v713: string =
                        append(append(append(append(toString(&v633),
                                                    v709.clone()),
                                             toString(&v667)), v709),
                               toString(&v701));
                    let v721: Array<std::string::String> =
                        array(&[(&v713).as_ref().to_string(),
                                (&stringFrom(format!("color: #{0};",
                                                     &string("881749")))).as_ref().to_string(),
                                (&string("color: #385779;")).as_ref().to_string()]);
                    let v722 = core::ops::Deref::deref(&v721);
                    let v725 =
                        serde_wasm_bindgen::to_value(&*****&v722).unwrap();
                    web_sys::console::log(&js_sys::Array::from(&v725));
                    ()
                } else {
                    let v727: string = Cli::method9();
                    let v728: &str = &v727.as_str();
                    let v732: &str = &v728[0i32 as usize..2i32 as usize];
                    let v733: string =
                        fable_library_rust::String_::fromStr(&v732);
                    let v735: u8 = u8::from_str_radix(&v733, 16).unwrap();
                    let v736: string = Cli::method9();
                    let v737: &str = &v736.as_str();
                    let v740: &str = &v737[2i32 as usize..4i32 as usize];
                    let v741: string =
                        fable_library_rust::String_::fromStr(&v740);
                    let v742: u8 = u8::from_str_radix(&v741, 16).unwrap();
                    let v743: string = Cli::method9();
                    let v744: &str = &v743.as_str();
                    let v747: &str = &v744[4i32 as usize..6i32 as usize];
                    let v748: string =
                        fable_library_rust::String_::fromStr(&v747);
                    let v749: u8 = u8::from_str_radix(&v748, 16).unwrap();
                    let v751: colored::ColoredString =
                        colored::Colorize::truecolor(&*v667.to_string(), v735, v742, v749);
                    let v752: std::string::String = format!("{}", &v751);
                    let v753: string = Cli::method8();
                    let v754: &str = &v753.as_str();
                    let v757: &str = &v754[0i32 as usize..2i32 as usize];
                    let v758: string =
                        fable_library_rust::String_::fromStr(&v757);
                    let v759: u8 = u8::from_str_radix(&v758, 16).unwrap();
                    let v760: string = Cli::method8();
                    let v761: &str = &v760.as_str();
                    let v764: &str = &v761[2i32 as usize..4i32 as usize];
                    let v765: string =
                        fable_library_rust::String_::fromStr(&v764);
                    let v766: u8 = u8::from_str_radix(&v765, 16).unwrap();
                    let v767: string = Cli::method8();
                    let v768: &str = &v767.as_str();
                    let v771: &str = &v768[4i32 as usize..6i32 as usize];
                    let v772: string =
                        fable_library_rust::String_::fromStr(&v771);
                    let v773: u8 = u8::from_str_radix(&v772, 16).unwrap();
                    let v774: colored::ColoredString =
                        colored::Colorize::truecolor(&*v701.to_string(), v759, v766, v773);
                    let v775: std::string::String = format!("{}", &v774);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v633, &v752, &v775)));
                    ()
                }
                {
                    let v778: Lrc<Cli::Mut0> =
                        Lrc::new(Cli::Mut0{l0:
                                               MutCell::new(Lrc::new(Cli::UH0::UH0_1)),});
                    let v779 = Cli::method10(v323, v778.clone());
                    let v781: Result<(), std::io::Error> =
                        (v555).borrow_mut().for_each(move |x| v779(x.to_vec()));
                    *((&v781).as_ref()).unwrap();
                    {
                        let v786: Lrc<Cli::UH1> =
                            Cli::method12(Cli::method11(v778.l0.get().clone(),
                                                        Lrc::new(Cli::UH0::UH0_1)),
                                          Lrc::new(Cli::UH1::UH1_1));
                        let v789: std::string::String =
                            (&string("lines len")).to_string().clone();
                        let v791: i32 = Cli::method13(v786.clone(), 0i32);
                        let v794: Array<std::string::String> =
                            array(&[v789, format!("{:?}", &v791)]);
                        let v795 = core::ops::Deref::deref(&v794);
                        let v796 = &***&v795;
                        let v797 = &***&v796;
                        let v799: std::string::String =
                            format!("{:?}", &v797).clone();
                        let v800: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v805: string =
                            Cli::method3(6i32,
                                         toString(&((&v800).timestamp() -
                                                        v323)));
                        let v806: u8 = rand::random::<u8>();
                        let v819: Array<std::string::String> =
                            array(&[(&v101).to_string(), (&v805).to_string(),
                                    (&v106).to_string(),
                                    format!("{:?}", &v806),
                                    (&v111).to_string(),
                                    (&v114).to_string()]);
                        let v820 = core::ops::Deref::deref(&v819);
                        let v821 = &***&v820;
                        let v822 = &***&v821;
                        let v824: std::string::String =
                            format!("{:?}", &v822).clone();
                        let v827: Array<std::string::String> =
                            array(&[(&v364).to_string()]);
                        let v828 = core::ops::Deref::deref(&v827);
                        let v829 = &***&v828;
                        let v830 = &***&v829;
                        let v832: std::string::String =
                            format!("{:?}", &v830).clone();
                        let v834: string = toString(&format!("{}", &v832));
                        let v836: &str = r#""([^"]+)", "([^"]+)""#;
                        let v837: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v836);
                        let v838: &regex::Regex = &v837.build().unwrap();
                        let v839: string = Cli::method2(v834);
                        let v840: &str = &v839.as_str();
                        let v841: string = Cli::method4();
                        let v842: &str = &v841.as_str();
                        let v843: std::string::String =
                            v838.replace_all(&v840, v842).to_string();
                        let v844: string =
                            fable_library_rust::String_::fromStr(&v843);
                        let v846: &str = r#"\["(.*?)"\]"#;
                        let v847: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v846);
                        let v848: &regex::Regex = &v847.build().unwrap();
                        let v849: string = Cli::method2(v844);
                        let v850: &str = &v849.as_str();
                        let v851: string = Cli::method5();
                        let v852: &str = &v851.as_str();
                        let v853: std::string::String =
                            v848.replace_all(&v850, v852).to_string();
                        let v854: string =
                            fable_library_rust::String_::fromStr(&v853);
                        let v856: &str = r#", "#;
                        let v857: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v856);
                        let v858: &regex::Regex = &v857.build().unwrap();
                        let v859: string = Cli::method2(v854);
                        let v860: &str = &v859.as_str();
                        let v861: string = Cli::method6();
                        let v862: &str = &v861.as_str();
                        let v863: std::string::String =
                            v858.replace_all(&v860, v862).to_string();
                        let v864: string =
                            fable_library_rust::String_::fromStr(&v863);
                        let v866: std::string::String =
                            (&v864).to_string().clone();
                        let v868: string = toString(&format!("{}", &v799));
                        let v870: &str = r#""([^"]+)", "([^"]+)""#;
                        let v871: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v870);
                        let v872: &regex::Regex = &v871.build().unwrap();
                        let v873: string = Cli::method2(v868);
                        let v874: &str = &v873.as_str();
                        let v875: string = Cli::method4();
                        let v876: &str = &v875.as_str();
                        let v877: std::string::String =
                            v872.replace_all(&v874, v876).to_string();
                        let v878: string =
                            fable_library_rust::String_::fromStr(&v877);
                        let v880: &str = r#"\["(.*?)"\]"#;
                        let v881: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v880);
                        let v882: &regex::Regex = &v881.build().unwrap();
                        let v883: string = Cli::method2(v878);
                        let v884: &str = &v883.as_str();
                        let v885: string = Cli::method5();
                        let v886: &str = &v885.as_str();
                        let v887: std::string::String =
                            v882.replace_all(&v884, v886).to_string();
                        let v888: string =
                            fable_library_rust::String_::fromStr(&v887);
                        let v890: &str = r#", "#;
                        let v891: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v890);
                        let v892: &regex::Regex = &v891.build().unwrap();
                        let v893: string = Cli::method2(v888);
                        let v894: &str = &v893.as_str();
                        let v895: string = Cli::method6();
                        let v896: &str = &v895.as_str();
                        let v897: std::string::String =
                            v892.replace_all(&v894, v896).to_string();
                        let v898: string =
                            fable_library_rust::String_::fromStr(&v897);
                        let v900: std::string::String =
                            (&v898).to_string().clone();
                        let v902: string = toString(&format!("{}", &v824));
                        let v904: &str = r#""([^"]+)", "([^"]+)""#;
                        let v905: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v904);
                        let v906: &regex::Regex = &v905.build().unwrap();
                        let v907: string = Cli::method2(v902);
                        let v908: &str = &v907.as_str();
                        let v909: string = Cli::method4();
                        let v910: &str = &v909.as_str();
                        let v911: std::string::String =
                            v906.replace_all(&v908, v910).to_string();
                        let v912: string =
                            fable_library_rust::String_::fromStr(&v911);
                        let v914: &str = r#"\["(.*?)"\]"#;
                        let v915: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v914);
                        let v916: &regex::Regex = &v915.build().unwrap();
                        let v917: string = Cli::method2(v912);
                        let v918: &str = &v917.as_str();
                        let v919: string = Cli::method5();
                        let v920: &str = &v919.as_str();
                        let v921: std::string::String =
                            v916.replace_all(&v918, v920).to_string();
                        let v922: string =
                            fable_library_rust::String_::fromStr(&v921);
                        let v924: &str = r#", "#;
                        let v925: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v924);
                        let v926: &regex::Regex = &v925.build().unwrap();
                        let v927: string = Cli::method2(v922);
                        let v928: &str = &v927.as_str();
                        let v929: string = Cli::method6();
                        let v930: &str = &v929.as_str();
                        let v931: std::string::String =
                            v926.replace_all(&v928, v930).to_string();
                        let v932: string =
                            fable_library_rust::String_::fromStr(&v931);
                        let v934: std::string::String =
                            (&v932).to_string().clone();
                        if let Cli::US0::US0_1 =
                               &if cfg!(target_arch = "wasm32") {
                                    Cli::US0::US0_1
                                } else { Cli::US0::US0_0 } {
                            let v942: string = string(" %c");
                            let v946: string =
                                append(append(append(append(toString(&v866),
                                                            v942.clone()),
                                                     toString(&v900)), v942),
                                       toString(&v934));
                            let v954: Array<std::string::String> =
                                array(&[(&v946).as_ref().to_string(),
                                        (&stringFrom(format!("color: #{0};",
                                                             &string("881749")))).as_ref().to_string(),
                                        (&string("color: #385779;")).as_ref().to_string()]);
                            let v955 = core::ops::Deref::deref(&v954);
                            let v958 =
                                serde_wasm_bindgen::to_value(&*****&v955).unwrap();
                            web_sys::console::log(&js_sys::Array::from(&v958));
                            ()
                        } else {
                            let v960: string = Cli::method9();
                            let v961: &str = &v960.as_str();
                            let v965: &str =
                                &v961[0i32 as usize..2i32 as usize];
                            let v966: string =
                                fable_library_rust::String_::fromStr(&v965);
                            let v968: u8 =
                                u8::from_str_radix(&v966, 16).unwrap();
                            let v969: string = Cli::method9();
                            let v970: &str = &v969.as_str();
                            let v973: &str =
                                &v970[2i32 as usize..4i32 as usize];
                            let v974: string =
                                fable_library_rust::String_::fromStr(&v973);
                            let v975: u8 =
                                u8::from_str_radix(&v974, 16).unwrap();
                            let v976: string = Cli::method9();
                            let v977: &str = &v976.as_str();
                            let v980: &str =
                                &v977[4i32 as usize..6i32 as usize];
                            let v981: string =
                                fable_library_rust::String_::fromStr(&v980);
                            let v982: u8 =
                                u8::from_str_radix(&v981, 16).unwrap();
                            let v984: colored::ColoredString =
                                colored::Colorize::truecolor(&*v900.to_string(), v968, v975, v982);
                            let v985: std::string::String =
                                format!("{}", &v984);
                            let v986: string = Cli::method8();
                            let v987: &str = &v986.as_str();
                            let v990: &str =
                                &v987[0i32 as usize..2i32 as usize];
                            let v991: string =
                                fable_library_rust::String_::fromStr(&v990);
                            let v992: u8 =
                                u8::from_str_radix(&v991, 16).unwrap();
                            let v993: string = Cli::method8();
                            let v994: &str = &v993.as_str();
                            let v997: &str =
                                &v994[2i32 as usize..4i32 as usize];
                            let v998: string =
                                fable_library_rust::String_::fromStr(&v997);
                            let v999: u8 =
                                u8::from_str_radix(&v998, 16).unwrap();
                            let v1000: string = Cli::method8();
                            let v1001: &str = &v1000.as_str();
                            let v1004: &str =
                                &v1001[4i32 as usize..6i32 as usize];
                            let v1005: string =
                                fable_library_rust::String_::fromStr(&v1004);
                            let v1006: u8 =
                                u8::from_str_radix(&v1005, 16).unwrap();
                            let v1007: colored::ColoredString =
                                colored::Colorize::truecolor(&*v934.to_string(), v992, v999, v1006);
                            let v1008: std::string::String =
                                format!("{}", &v1007);
                            println!("{0}",
                                     stringFrom(format!("{0} {1} {2}", &v866, &v985, &v1008)));
                            ()
                        }
                        {
                            let v1017: string =
                                Cli::method16(Cli::method15((Cli::method14(v7,
                                                                           v786,
                                                                           0i32,
                                                                           Lrc::new(Cli::UH1::UH1_1))).1.clone(),
                                                            Lrc::new(Cli::UH1::UH1_1)),
                                              string(""));
                            let v1020: std::string::String =
                                (&string("text len")).to_string().clone();
                            let v1022: i32 =
                                (&v1017).len().try_into().unwrap();
                            let v1025: Array<std::string::String> =
                                array(&[v1020, format!("{:?}", &v1022)]);
                            let v1026 = core::ops::Deref::deref(&v1025);
                            let v1027 = &***&v1026;
                            let v1028 = &***&v1027;
                            let v1030: std::string::String =
                                format!("{:?}", &v1028).clone();
                            let v1031: chrono::DateTime<chrono::Utc> =
                                chrono::Utc::now();
                            let v1036: string =
                                Cli::method3(6i32,
                                             toString(&((&v1031).timestamp() -
                                                            v7)));
                            let v1037: u8 = rand::random::<u8>();
                            let v1050: Array<std::string::String> =
                                array(&[(&v101).to_string(),
                                        (&v1036).to_string(),
                                        (&v106).to_string(),
                                        format!("{:?}", &v1037),
                                        (&v111).to_string(),
                                        (&v114).to_string()]);
                            let v1051 = core::ops::Deref::deref(&v1050);
                            let v1052 = &***&v1051;
                            let v1053 = &***&v1052;
                            let v1055: std::string::String =
                                format!("{:?}", &v1053).clone();
                            let v1058: Array<std::string::String> =
                                array(&[(&v123).to_string()]);
                            let v1059 = core::ops::Deref::deref(&v1058);
                            let v1060 = &***&v1059;
                            let v1061 = &***&v1060;
                            let v1063: std::string::String =
                                format!("{:?}", &v1061).clone();
                            let v1065: string =
                                toString(&format!("{}", &v1063));
                            let v1067: &str = r#""([^"]+)", "([^"]+)""#;
                            let v1068: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1067);
                            let v1069: &regex::Regex =
                                &v1068.build().unwrap();
                            let v1070: string = Cli::method2(v1065);
                            let v1071: &str = &v1070.as_str();
                            let v1072: string = Cli::method4();
                            let v1073: &str = &v1072.as_str();
                            let v1074: std::string::String =
                                v1069.replace_all(&v1071, v1073).to_string();
                            let v1075: string =
                                fable_library_rust::String_::fromStr(&v1074);
                            let v1077: &str = r#"\["(.*?)"\]"#;
                            let v1078: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1077);
                            let v1079: &regex::Regex =
                                &v1078.build().unwrap();
                            let v1080: string = Cli::method2(v1075);
                            let v1081: &str = &v1080.as_str();
                            let v1082: string = Cli::method5();
                            let v1083: &str = &v1082.as_str();
                            let v1084: std::string::String =
                                v1079.replace_all(&v1081, v1083).to_string();
                            let v1085: string =
                                fable_library_rust::String_::fromStr(&v1084);
                            let v1087: &str = r#", "#;
                            let v1088: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1087);
                            let v1089: &regex::Regex =
                                &v1088.build().unwrap();
                            let v1090: string = Cli::method2(v1085);
                            let v1091: &str = &v1090.as_str();
                            let v1092: string = Cli::method6();
                            let v1093: &str = &v1092.as_str();
                            let v1094: std::string::String =
                                v1089.replace_all(&v1091, v1093).to_string();
                            let v1095: string =
                                fable_library_rust::String_::fromStr(&v1094);
                            let v1097: std::string::String =
                                (&v1095).to_string().clone();
                            let v1099: string =
                                toString(&format!("{}", &v1030));
                            let v1101: &str = r#""([^"]+)", "([^"]+)""#;
                            let v1102: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1101);
                            let v1103: &regex::Regex =
                                &v1102.build().unwrap();
                            let v1104: string = Cli::method2(v1099);
                            let v1105: &str = &v1104.as_str();
                            let v1106: string = Cli::method4();
                            let v1107: &str = &v1106.as_str();
                            let v1108: std::string::String =
                                v1103.replace_all(&v1105, v1107).to_string();
                            let v1109: string =
                                fable_library_rust::String_::fromStr(&v1108);
                            let v1111: &str = r#"\["(.*?)"\]"#;
                            let v1112: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1111);
                            let v1113: &regex::Regex =
                                &v1112.build().unwrap();
                            let v1114: string = Cli::method2(v1109);
                            let v1115: &str = &v1114.as_str();
                            let v1116: string = Cli::method5();
                            let v1117: &str = &v1116.as_str();
                            let v1118: std::string::String =
                                v1113.replace_all(&v1115, v1117).to_string();
                            let v1119: string =
                                fable_library_rust::String_::fromStr(&v1118);
                            let v1121: &str = r#", "#;
                            let v1122: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1121);
                            let v1123: &regex::Regex =
                                &v1122.build().unwrap();
                            let v1124: string = Cli::method2(v1119);
                            let v1125: &str = &v1124.as_str();
                            let v1126: string = Cli::method6();
                            let v1127: &str = &v1126.as_str();
                            let v1128: std::string::String =
                                v1123.replace_all(&v1125, v1127).to_string();
                            let v1129: string =
                                fable_library_rust::String_::fromStr(&v1128);
                            let v1131: std::string::String =
                                (&v1129).to_string().clone();
                            let v1133: string =
                                toString(&format!("{}", &v1055));
                            let v1135: &str = r#""([^"]+)", "([^"]+)""#;
                            let v1136: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1135);
                            let v1137: &regex::Regex =
                                &v1136.build().unwrap();
                            let v1138: string = Cli::method2(v1133);
                            let v1139: &str = &v1138.as_str();
                            let v1140: string = Cli::method4();
                            let v1141: &str = &v1140.as_str();
                            let v1142: std::string::String =
                                v1137.replace_all(&v1139, v1141).to_string();
                            let v1143: string =
                                fable_library_rust::String_::fromStr(&v1142);
                            let v1145: &str = r#"\["(.*?)"\]"#;
                            let v1146: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1145);
                            let v1147: &regex::Regex =
                                &v1146.build().unwrap();
                            let v1148: string = Cli::method2(v1143);
                            let v1149: &str = &v1148.as_str();
                            let v1150: string = Cli::method5();
                            let v1151: &str = &v1150.as_str();
                            let v1152: std::string::String =
                                v1147.replace_all(&v1149, v1151).to_string();
                            let v1153: string =
                                fable_library_rust::String_::fromStr(&v1152);
                            let v1155: &str = r#", "#;
                            let v1156: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1155);
                            let v1157: &regex::Regex =
                                &v1156.build().unwrap();
                            let v1158: string = Cli::method2(v1153);
                            let v1159: &str = &v1158.as_str();
                            let v1160: string = Cli::method6();
                            let v1161: &str = &v1160.as_str();
                            let v1162: std::string::String =
                                v1157.replace_all(&v1159, v1161).to_string();
                            let v1163: string =
                                fable_library_rust::String_::fromStr(&v1162);
                            let v1165: std::string::String =
                                (&v1163).to_string().clone();
                            if let Cli::US0::US0_1 =
                                   &if cfg!(target_arch = "wasm32") {
                                        Cli::US0::US0_1
                                    } else { Cli::US0::US0_0 } {
                                let v1173: string = string(" %c");
                                let v1177: string =
                                    append(append(append(append(toString(&v1097),
                                                                v1173.clone()),
                                                         toString(&v1131)),
                                                  v1173), toString(&v1165));
                                let v1185: Array<std::string::String> =
                                    array(&[(&v1177).as_ref().to_string(),
                                            (&stringFrom(format!("color: #{0};",
                                                                 &string("387957")))).as_ref().to_string(),
                                            (&string("color: #385779;")).as_ref().to_string()]);
                                let v1186 = core::ops::Deref::deref(&v1185);
                                let v1189 =
                                    serde_wasm_bindgen::to_value(&*****&v1186).unwrap();
                                web_sys::console::log(&js_sys::Array::from(&v1189));
                                ()
                            } else {
                                let v1191: string = Cli::method7();
                                let v1192: &str = &v1191.as_str();
                                let v1196: &str =
                                    &v1192[0i32 as usize..2i32 as usize];
                                let v1197: string =
                                    fable_library_rust::String_::fromStr(&v1196);
                                let v1199: u8 =
                                    u8::from_str_radix(&v1197, 16).unwrap();
                                let v1200: string = Cli::method7();
                                let v1201: &str = &v1200.as_str();
                                let v1204: &str =
                                    &v1201[2i32 as usize..4i32 as usize];
                                let v1205: string =
                                    fable_library_rust::String_::fromStr(&v1204);
                                let v1206: u8 =
                                    u8::from_str_radix(&v1205, 16).unwrap();
                                let v1207: string = Cli::method7();
                                let v1208: &str = &v1207.as_str();
                                let v1211: &str =
                                    &v1208[4i32 as usize..6i32 as usize];
                                let v1212: string =
                                    fable_library_rust::String_::fromStr(&v1211);
                                let v1213: u8 =
                                    u8::from_str_radix(&v1212, 16).unwrap();
                                let v1215: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1131.to_string(), v1199, v1206, v1213);
                                let v1216: std::string::String =
                                    format!("{}", &v1215);
                                let v1217: string = Cli::method8();
                                let v1218: &str = &v1217.as_str();
                                let v1221: &str =
                                    &v1218[0i32 as usize..2i32 as usize];
                                let v1222: string =
                                    fable_library_rust::String_::fromStr(&v1221);
                                let v1223: u8 =
                                    u8::from_str_radix(&v1222, 16).unwrap();
                                let v1224: string = Cli::method8();
                                let v1225: &str = &v1224.as_str();
                                let v1228: &str =
                                    &v1225[2i32 as usize..4i32 as usize];
                                let v1229: string =
                                    fable_library_rust::String_::fromStr(&v1228);
                                let v1230: u8 =
                                    u8::from_str_radix(&v1229, 16).unwrap();
                                let v1231: string = Cli::method8();
                                let v1232: &str = &v1231.as_str();
                                let v1235: &str =
                                    &v1232[4i32 as usize..6i32 as usize];
                                let v1236: string =
                                    fable_library_rust::String_::fromStr(&v1235);
                                let v1237: u8 =
                                    u8::from_str_radix(&v1236, 16).unwrap();
                                let v1238: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1165.to_string(), v1223, v1230, v1237);
                                let v1239: std::string::String =
                                    format!("{}", &v1238);
                                println!("{0}",
                                         stringFrom(format!("{0} {1} {2}", &v1097, &v1216, &v1239)));
                                ()
                            }
                            {
                                let v1242: Result<(), std::io::Error> =
                                    std::fs::write(v77, v1017.as_str());
                                *((&v1242).as_ref()).unwrap();
                                {
                                    let v1245: std::string::String =
                                        (&string("> fs_write rs_path_clean text; ok")).to_string().clone();
                                    let v1246: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v1251: string =
                                        Cli::method3(6i32,
                                                     toString(&((&v1246).timestamp()
                                                                    - v7)));
                                    let v1252: u8 = rand::random::<u8>();
                                    let v1265: Array<std::string::String> =
                                        array(&[(&v101).to_string(),
                                                (&v1251).to_string(),
                                                (&v106).to_string(),
                                                format!("{:?}", &v1252),
                                                (&v111).to_string(),
                                                (&v114).to_string()]);
                                    let v1266 =
                                        core::ops::Deref::deref(&v1265);
                                    let v1267 = &***&v1266;
                                    let v1268 = &***&v1267;
                                    let v1270: std::string::String =
                                        format!("{:?}", &v1268).clone();
                                    let v1273: Array<std::string::String> =
                                        array(&[(&v123).to_string()]);
                                    let v1274 =
                                        core::ops::Deref::deref(&v1273);
                                    let v1275 = &***&v1274;
                                    let v1276 = &***&v1275;
                                    let v1278: std::string::String =
                                        format!("{:?}", &v1276).clone();
                                    let v1280: string =
                                        toString(&format!("{}", &v1278));
                                    let v1282: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1283: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1282);
                                    let v1284: &regex::Regex =
                                        &v1283.build().unwrap();
                                    let v1285: string = Cli::method2(v1280);
                                    let v1286: &str = &v1285.as_str();
                                    let v1287: string = Cli::method4();
                                    let v1288: &str = &v1287.as_str();
                                    let v1289: std::string::String =
                                        v1284.replace_all(&v1286, v1288).to_string();
                                    let v1290: string =
                                        fable_library_rust::String_::fromStr(&v1289);
                                    let v1292: &str = r#"\["(.*?)"\]"#;
                                    let v1293: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1292);
                                    let v1294: &regex::Regex =
                                        &v1293.build().unwrap();
                                    let v1295: string = Cli::method2(v1290);
                                    let v1296: &str = &v1295.as_str();
                                    let v1297: string = Cli::method5();
                                    let v1298: &str = &v1297.as_str();
                                    let v1299: std::string::String =
                                        v1294.replace_all(&v1296, v1298).to_string();
                                    let v1300: string =
                                        fable_library_rust::String_::fromStr(&v1299);
                                    let v1302: &str = r#", "#;
                                    let v1303: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1302);
                                    let v1304: &regex::Regex =
                                        &v1303.build().unwrap();
                                    let v1305: string = Cli::method2(v1300);
                                    let v1306: &str = &v1305.as_str();
                                    let v1307: string = Cli::method6();
                                    let v1308: &str = &v1307.as_str();
                                    let v1309: std::string::String =
                                        v1304.replace_all(&v1306, v1308).to_string();
                                    let v1310: string =
                                        fable_library_rust::String_::fromStr(&v1309);
                                    let v1312: std::string::String =
                                        (&v1310).to_string().clone();
                                    let v1314: string =
                                        toString(&format!("{}", &v1245));
                                    let v1316: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1317: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1316);
                                    let v1318: &regex::Regex =
                                        &v1317.build().unwrap();
                                    let v1319: string = Cli::method2(v1314);
                                    let v1320: &str = &v1319.as_str();
                                    let v1321: string = Cli::method4();
                                    let v1322: &str = &v1321.as_str();
                                    let v1323: std::string::String =
                                        v1318.replace_all(&v1320, v1322).to_string();
                                    let v1324: string =
                                        fable_library_rust::String_::fromStr(&v1323);
                                    let v1326: &str = r#"\["(.*?)"\]"#;
                                    let v1327: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1326);
                                    let v1328: &regex::Regex =
                                        &v1327.build().unwrap();
                                    let v1329: string = Cli::method2(v1324);
                                    let v1330: &str = &v1329.as_str();
                                    let v1331: string = Cli::method5();
                                    let v1332: &str = &v1331.as_str();
                                    let v1333: std::string::String =
                                        v1328.replace_all(&v1330, v1332).to_string();
                                    let v1334: string =
                                        fable_library_rust::String_::fromStr(&v1333);
                                    let v1336: &str = r#", "#;
                                    let v1337: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1336);
                                    let v1338: &regex::Regex =
                                        &v1337.build().unwrap();
                                    let v1339: string = Cli::method2(v1334);
                                    let v1340: &str = &v1339.as_str();
                                    let v1341: string = Cli::method6();
                                    let v1342: &str = &v1341.as_str();
                                    let v1343: std::string::String =
                                        v1338.replace_all(&v1340, v1342).to_string();
                                    let v1344: string =
                                        fable_library_rust::String_::fromStr(&v1343);
                                    let v1346: std::string::String =
                                        (&v1344).to_string().clone();
                                    let v1348: string =
                                        toString(&format!("{}", &v1270));
                                    let v1350: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1351: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1350);
                                    let v1352: &regex::Regex =
                                        &v1351.build().unwrap();
                                    let v1353: string = Cli::method2(v1348);
                                    let v1354: &str = &v1353.as_str();
                                    let v1355: string = Cli::method4();
                                    let v1356: &str = &v1355.as_str();
                                    let v1357: std::string::String =
                                        v1352.replace_all(&v1354, v1356).to_string();
                                    let v1358: string =
                                        fable_library_rust::String_::fromStr(&v1357);
                                    let v1360: &str = r#"\["(.*?)"\]"#;
                                    let v1361: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1360);
                                    let v1362: &regex::Regex =
                                        &v1361.build().unwrap();
                                    let v1363: string = Cli::method2(v1358);
                                    let v1364: &str = &v1363.as_str();
                                    let v1365: string = Cli::method5();
                                    let v1366: &str = &v1365.as_str();
                                    let v1367: std::string::String =
                                        v1362.replace_all(&v1364, v1366).to_string();
                                    let v1368: string =
                                        fable_library_rust::String_::fromStr(&v1367);
                                    let v1370: &str = r#", "#;
                                    let v1371: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1370);
                                    let v1372: &regex::Regex =
                                        &v1371.build().unwrap();
                                    let v1373: string = Cli::method2(v1368);
                                    let v1374: &str = &v1373.as_str();
                                    let v1375: string = Cli::method6();
                                    let v1376: &str = &v1375.as_str();
                                    let v1377: std::string::String =
                                        v1372.replace_all(&v1374, v1376).to_string();
                                    let v1378: string =
                                        fable_library_rust::String_::fromStr(&v1377);
                                    let v1380: std::string::String =
                                        (&v1378).to_string().clone();
                                    if let Cli::US0::US0_1 =
                                           &if cfg!(target_arch = "wasm32") {
                                                Cli::US0::US0_1
                                            } else { Cli::US0::US0_0 } {
                                        let v1388: string = string(" %c");
                                        let v1392: string =
                                            append(append(append(append(toString(&v1312),
                                                                        v1388.clone()),
                                                                 toString(&v1346)),
                                                          v1388),
                                                   toString(&v1380));
                                        let v1400:
                                                Array<std::string::String> =
                                            array(&[(&v1392).as_ref().to_string(),
                                                    (&stringFrom(format!("color: #{0};",
                                                                         &string("387957")))).as_ref().to_string(),
                                                    (&string("color: #385779;")).as_ref().to_string()]);
                                        let v1401 =
                                            core::ops::Deref::deref(&v1400);
                                        let v1404 =
                                            serde_wasm_bindgen::to_value(&*****&v1401).unwrap();
                                        web_sys::console::log(&js_sys::Array::from(&v1404));
                                        ()
                                    } else {
                                        let v1406: string = Cli::method7();
                                        let v1407: &str = &v1406.as_str();
                                        let v1411: &str =
                                            &v1407[0i32 as
                                                       usize..2i32 as usize];
                                        let v1412: string =
                                            fable_library_rust::String_::fromStr(&v1411);
                                        let v1414: u8 =
                                            u8::from_str_radix(&v1412, 16).unwrap();
                                        let v1415: string = Cli::method7();
                                        let v1416: &str = &v1415.as_str();
                                        let v1419: &str =
                                            &v1416[2i32 as
                                                       usize..4i32 as usize];
                                        let v1420: string =
                                            fable_library_rust::String_::fromStr(&v1419);
                                        let v1421: u8 =
                                            u8::from_str_radix(&v1420, 16).unwrap();
                                        let v1422: string = Cli::method7();
                                        let v1423: &str = &v1422.as_str();
                                        let v1426: &str =
                                            &v1423[4i32 as
                                                       usize..6i32 as usize];
                                        let v1427: string =
                                            fable_library_rust::String_::fromStr(&v1426);
                                        let v1428: u8 =
                                            u8::from_str_radix(&v1427, 16).unwrap();
                                        let v1430: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1346.to_string(), v1414, v1421, v1428);
                                        let v1431: std::string::String =
                                            format!("{}", &v1430);
                                        let v1432: string = Cli::method8();
                                        let v1433: &str = &v1432.as_str();
                                        let v1436: &str =
                                            &v1433[0i32 as
                                                       usize..2i32 as usize];
                                        let v1437: string =
                                            fable_library_rust::String_::fromStr(&v1436);
                                        let v1438: u8 =
                                            u8::from_str_radix(&v1437, 16).unwrap();
                                        let v1439: string = Cli::method8();
                                        let v1440: &str = &v1439.as_str();
                                        let v1443: &str =
                                            &v1440[2i32 as
                                                       usize..4i32 as usize];
                                        let v1444: string =
                                            fable_library_rust::String_::fromStr(&v1443);
                                        let v1445: u8 =
                                            u8::from_str_radix(&v1444, 16).unwrap();
                                        let v1446: string = Cli::method8();
                                        let v1447: &str = &v1446.as_str();
                                        let v1450: &str =
                                            &v1447[4i32 as
                                                       usize..6i32 as usize];
                                        let v1451: string =
                                            fable_library_rust::String_::fromStr(&v1450);
                                        let v1452: u8 =
                                            u8::from_str_radix(&v1451, 16).unwrap();
                                        let v1453: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1380.to_string(), v1438, v1445, v1452);
                                        let v1454: std::string::String =
                                            format!("{}", &v1453);
                                        println!("{0}",
                                                 stringFrom(format!("{0} {1} {2}", &v1312, &v1431, &v1454)));
                                        ()
                                    }
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
        v0.get_or_init(move || Func0::new(move || Cli::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;
