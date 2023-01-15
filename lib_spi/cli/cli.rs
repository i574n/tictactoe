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
    pub fn method7() -> string { string("666666") }
    pub fn method8() -> string { string("222222") }
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
    pub fn method9(v0_1: i64, v1: Lrc<Cli::Mut0>)
     -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       move |v: Vec<u8>|
                           Cli::closure1(v0_1, v1.clone(), v.clone())
                   })
    }
    pub fn method10(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH0>) -> Lrc<Cli::UH0> {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v1.clone());
        '_method10:
            loop  {
                break '_method10
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH0> =
                                 Lrc::new(Cli::UH0::UH0_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method10
                         }
                     }) ;
            }
    }
    pub fn method11(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        match v0_1.as_ref() {
            Cli::UH0::UH0_1 => v1.clone(),
            Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                let v4: Lrc<Cli::UH1> = Cli::method11(v0_1_0_1.clone(), v1);
                Lrc::new(Cli::UH1::UH1_0(fable_library_rust::String_::fromStr(v0_1_0_0),
                                         v4))
            }
        }
    }
    pub fn method12(v0_1: Lrc<Cli::UH1>, v1: i32) -> i32 {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method12:
            loop  {
                break '_method12
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: i32 = v1.get() + 1i32;
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method12
                         }
                     }) ;
            }
    }
    pub fn method13(v0_1: i64, v1: Lrc<Cli::UH1>, v2: i32, v3: Lrc<Cli::UH1>)
     -> (i32, Lrc<Cli::UH1>) {
        let v0_1: MutCell<i64> = MutCell::new(v0_1);
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        let v2: MutCell<i32> = MutCell::new(v2);
        let v3: MutCell<Lrc<Cli::UH1>> = MutCell::new(v3.clone());
        '_method13:
            loop  {
                break '_method13
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
                                         let v202:
                                                 Array<std::string::String> =
                                             array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                                                     (&string("color: purple")).as_ref().to_string(),
                                                     (&stringFrom(format!("{0}",
                                                                          &v112))).as_ref().to_string(),
                                                     (&stringFrom(format!("color: {0}",
                                                                          &string("666666")))).as_ref().to_string(),
                                                     (&stringFrom(format!("{0} {1}",
                                                                          &v146,
                                                                          &v180))).as_ref().to_string(),
                                                     (&string("color: #222222")).as_ref().to_string(),
                                                     (&stringFrom(format!("{0}",
                                                                          &v180))).as_ref().to_string()]);
                                         let v203 =
                                             core::ops::Deref::deref(&v202);
                                         let v206 =
                                             serde_wasm_bindgen::to_value(&*****&v203).unwrap();
                                         web_sys::console::log(&js_sys::Array::from(&v206));
                                         ()
                                     } else {
                                         let v210: colored::ColoredString =
                                             colored::Colorize::color(&*v112, string("purple").to_string());
                                         let v211: std::string::String =
                                             format!("{}", &v210);
                                         let v212: string = Cli::method7();
                                         let v213: &str = &v212.as_str();
                                         let v217: &str =
                                             &v213[0i32 as
                                                       usize..2i32 as usize];
                                         let v218: string =
                                             fable_library_rust::String_::fromStr(&v217);
                                         let v220: u8 =
                                             u8::from_str_radix(&v218, 16).unwrap();
                                         let v221: string = Cli::method7();
                                         let v222: &str = &v221.as_str();
                                         let v225: &str =
                                             &v222[2i32 as
                                                       usize..4i32 as usize];
                                         let v226: string =
                                             fable_library_rust::String_::fromStr(&v225);
                                         let v227: u8 =
                                             u8::from_str_radix(&v226, 16).unwrap();
                                         let v228: string = Cli::method7();
                                         let v229: &str = &v228.as_str();
                                         let v232: &str =
                                             &v229[4i32 as
                                                       usize..6i32 as usize];
                                         let v233: string =
                                             fable_library_rust::String_::fromStr(&v232);
                                         let v234: u8 =
                                             u8::from_str_radix(&v233, 16).unwrap();
                                         let v236: colored::ColoredString =
                                             colored::Colorize::truecolor(&*v146.to_string(), v220, v227, v234);
                                         let v237: std::string::String =
                                             format!("{}", &v236);
                                         let v238: string = Cli::method8();
                                         let v239: &str = &v238.as_str();
                                         let v242: &str =
                                             &v239[0i32 as
                                                       usize..2i32 as usize];
                                         let v243: string =
                                             fable_library_rust::String_::fromStr(&v242);
                                         let v244: u8 =
                                             u8::from_str_radix(&v243, 16).unwrap();
                                         let v245: string = Cli::method8();
                                         let v246: &str = &v245.as_str();
                                         let v249: &str =
                                             &v246[2i32 as
                                                       usize..4i32 as usize];
                                         let v250: string =
                                             fable_library_rust::String_::fromStr(&v249);
                                         let v251: u8 =
                                             u8::from_str_radix(&v250, 16).unwrap();
                                         let v252: string = Cli::method8();
                                         let v253: &str = &v252.as_str();
                                         let v256: &str =
                                             &v253[4i32 as
                                                       usize..6i32 as usize];
                                         let v257: string =
                                             fable_library_rust::String_::fromStr(&v256);
                                         let v258: u8 =
                                             u8::from_str_radix(&v257, 16).unwrap();
                                         let v259: colored::ColoredString =
                                             colored::Colorize::truecolor(&*v180.to_string(), v244, v251, v258);
                                         let v260: std::string::String =
                                             format!("{}", &v259);
                                         println!("{0}",
                                                  stringFrom(format!("{0} {1} {2}", &v211, &v237, &v260)));
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
                                 continue '_method13
                             }
                         }
                     }) ;
            }
    }
    pub fn method14(v0_1: Lrc<Cli::UH1>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        '_method14:
            loop  {
                break '_method14
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH1> =
                                 Lrc::new(Cli::UH1::UH1_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method14
                         }
                     }) ;
            }
    }
    pub fn method15(v0_1: Lrc<Cli::UH1>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method15:
            loop  {
                break '_method15
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: string =
                                 append(v1.get(), v0_1_0_0.clone());
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method15
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
            let v263: Array<std::string::String> =
                array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                        (&string("color: purple")).as_ref().to_string(),
                        (&stringFrom(format!("{0}",
                                             &v173))).as_ref().to_string(),
                        (&stringFrom(format!("color: {0}",
                                             &string("666666")))).as_ref().to_string(),
                        (&stringFrom(format!("{0} {1}", &v207,
                                             &v241))).as_ref().to_string(),
                        (&string("color: #222222")).as_ref().to_string(),
                        (&stringFrom(format!("{0}",
                                             &v241))).as_ref().to_string()]);
            let v264 = core::ops::Deref::deref(&v263);
            let v267 = serde_wasm_bindgen::to_value(&*****&v264).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v267));
            ()
        } else {
            let v271: colored::ColoredString =
                colored::Colorize::color(&*v173, string("purple").to_string());
            let v272: std::string::String = format!("{}", &v271);
            let v273: string = Cli::method7();
            let v274: &str = &v273.as_str();
            let v278: &str = &v274[0i32 as usize..2i32 as usize];
            let v279: string = fable_library_rust::String_::fromStr(&v278);
            let v281: u8 = u8::from_str_radix(&v279, 16).unwrap();
            let v282: string = Cli::method7();
            let v283: &str = &v282.as_str();
            let v286: &str = &v283[2i32 as usize..4i32 as usize];
            let v287: string = fable_library_rust::String_::fromStr(&v286);
            let v288: u8 = u8::from_str_radix(&v287, 16).unwrap();
            let v289: string = Cli::method7();
            let v290: &str = &v289.as_str();
            let v293: &str = &v290[4i32 as usize..6i32 as usize];
            let v294: string = fable_library_rust::String_::fromStr(&v293);
            let v295: u8 = u8::from_str_radix(&v294, 16).unwrap();
            let v297: colored::ColoredString =
                colored::Colorize::truecolor(&*v207.to_string(), v281, v288, v295);
            let v298: std::string::String = format!("{}", &v297);
            let v299: string = Cli::method8();
            let v300: &str = &v299.as_str();
            let v303: &str = &v300[0i32 as usize..2i32 as usize];
            let v304: string = fable_library_rust::String_::fromStr(&v303);
            let v305: u8 = u8::from_str_radix(&v304, 16).unwrap();
            let v306: string = Cli::method8();
            let v307: &str = &v306.as_str();
            let v310: &str = &v307[2i32 as usize..4i32 as usize];
            let v311: string = fable_library_rust::String_::fromStr(&v310);
            let v312: u8 = u8::from_str_radix(&v311, 16).unwrap();
            let v313: string = Cli::method8();
            let v314: &str = &v313.as_str();
            let v317: &str = &v314[4i32 as usize..6i32 as usize];
            let v318: string = fable_library_rust::String_::fromStr(&v317);
            let v319: u8 = u8::from_str_radix(&v318, 16).unwrap();
            let v320: colored::ColoredString =
                colored::Colorize::truecolor(&*v241.to_string(), v305, v312, v319);
            let v321: std::string::String = format!("{}", &v320);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v272, &v298, &v321)));
            ()
        }
        {
            let patternInput_2: (string, string, string, bool) =
                Cli::method0();
            let v327: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v328: i64 = (&v327).timestamp();
            let v329: Result<std::path::PathBuf, std::io::Error> =
                (&v77).canonicalize();
            let v330: std::path::PathBuf =
                (&v329).as_ref().unwrap().to_path_buf();
            let v333: std::string::String =
                (&string("path_clean")).to_string().clone();
            let v335: string =
                fable_library_rust::String_::fromStr(&format!("{}", &v330.display()));
            let v338: Array<std::string::String> =
                array(&[v333, (&v335).to_string()]);
            let v339 = core::ops::Deref::deref(&v338);
            let v340 = &***&v339;
            let v341 = &***&v340;
            let v343: std::string::String = format!("{:?}", &v341).clone();
            let v344: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v349: string =
                Cli::method3(6i32, toString(&((&v344).timestamp() - v328)));
            let v350: u8 = rand::random::<u8>();
            let v363: Array<std::string::String> =
                array(&[(&v101).to_string(), (&v349).to_string(),
                        (&v106).to_string(), format!("{:?}", &v350),
                        (&v111).to_string(), (&v114).to_string()]);
            let v364 = core::ops::Deref::deref(&v363);
            let v365 = &***&v364;
            let v366 = &***&v365;
            let v368: std::string::String = format!("{:?}", &v366).clone();
            let v369: string = string("> read_lines ()");
            let v372: Array<std::string::String> =
                array(&[(&v369).to_string()]);
            let v373 = core::ops::Deref::deref(&v372);
            let v374 = &***&v373;
            let v375 = &***&v374;
            let v377: std::string::String = format!("{:?}", &v375).clone();
            let v379: string = toString(&format!("{}", &v377));
            let v381: &str = r#""([^"]+)", "([^"]+)""#;
            let v382: regex::RegexBuilder = regex::RegexBuilder::new(&v381);
            let v383: &regex::Regex = &v382.build().unwrap();
            let v384: string = Cli::method2(v379);
            let v385: &str = &v384.as_str();
            let v386: string = Cli::method4();
            let v387: &str = &v386.as_str();
            let v388: std::string::String =
                v383.replace_all(&v385, v387).to_string();
            let v389: string = fable_library_rust::String_::fromStr(&v388);
            let v391: &str = r#"\["(.*?)"\]"#;
            let v392: regex::RegexBuilder = regex::RegexBuilder::new(&v391);
            let v393: &regex::Regex = &v392.build().unwrap();
            let v394: string = Cli::method2(v389);
            let v395: &str = &v394.as_str();
            let v396: string = Cli::method5();
            let v397: &str = &v396.as_str();
            let v398: std::string::String =
                v393.replace_all(&v395, v397).to_string();
            let v399: string = fable_library_rust::String_::fromStr(&v398);
            let v401: &str = r#", "#;
            let v402: regex::RegexBuilder = regex::RegexBuilder::new(&v401);
            let v403: &regex::Regex = &v402.build().unwrap();
            let v404: string = Cli::method2(v399);
            let v405: &str = &v404.as_str();
            let v406: string = Cli::method6();
            let v407: &str = &v406.as_str();
            let v408: std::string::String =
                v403.replace_all(&v405, v407).to_string();
            let v409: string = fable_library_rust::String_::fromStr(&v408);
            let v411: std::string::String = (&v409).to_string().clone();
            let v413: string = toString(&format!("{}", &v343));
            let v415: &str = r#""([^"]+)", "([^"]+)""#;
            let v416: regex::RegexBuilder = regex::RegexBuilder::new(&v415);
            let v417: &regex::Regex = &v416.build().unwrap();
            let v418: string = Cli::method2(v413);
            let v419: &str = &v418.as_str();
            let v420: string = Cli::method4();
            let v421: &str = &v420.as_str();
            let v422: std::string::String =
                v417.replace_all(&v419, v421).to_string();
            let v423: string = fable_library_rust::String_::fromStr(&v422);
            let v425: &str = r#"\["(.*?)"\]"#;
            let v426: regex::RegexBuilder = regex::RegexBuilder::new(&v425);
            let v427: &regex::Regex = &v426.build().unwrap();
            let v428: string = Cli::method2(v423);
            let v429: &str = &v428.as_str();
            let v430: string = Cli::method5();
            let v431: &str = &v430.as_str();
            let v432: std::string::String =
                v427.replace_all(&v429, v431).to_string();
            let v433: string = fable_library_rust::String_::fromStr(&v432);
            let v435: &str = r#", "#;
            let v436: regex::RegexBuilder = regex::RegexBuilder::new(&v435);
            let v437: &regex::Regex = &v436.build().unwrap();
            let v438: string = Cli::method2(v433);
            let v439: &str = &v438.as_str();
            let v440: string = Cli::method6();
            let v441: &str = &v440.as_str();
            let v442: std::string::String =
                v437.replace_all(&v439, v441).to_string();
            let v443: string = fable_library_rust::String_::fromStr(&v442);
            let v445: std::string::String = (&v443).to_string().clone();
            let v447: string = toString(&format!("{}", &v368));
            let v449: &str = r#""([^"]+)", "([^"]+)""#;
            let v450: regex::RegexBuilder = regex::RegexBuilder::new(&v449);
            let v451: &regex::Regex = &v450.build().unwrap();
            let v452: string = Cli::method2(v447);
            let v453: &str = &v452.as_str();
            let v454: string = Cli::method4();
            let v455: &str = &v454.as_str();
            let v456: std::string::String =
                v451.replace_all(&v453, v455).to_string();
            let v457: string = fable_library_rust::String_::fromStr(&v456);
            let v459: &str = r#"\["(.*?)"\]"#;
            let v460: regex::RegexBuilder = regex::RegexBuilder::new(&v459);
            let v461: &regex::Regex = &v460.build().unwrap();
            let v462: string = Cli::method2(v457);
            let v463: &str = &v462.as_str();
            let v464: string = Cli::method5();
            let v465: &str = &v464.as_str();
            let v466: std::string::String =
                v461.replace_all(&v463, v465).to_string();
            let v467: string = fable_library_rust::String_::fromStr(&v466);
            let v469: &str = r#", "#;
            let v470: regex::RegexBuilder = regex::RegexBuilder::new(&v469);
            let v471: &regex::Regex = &v470.build().unwrap();
            let v472: string = Cli::method2(v467);
            let v473: &str = &v472.as_str();
            let v474: string = Cli::method6();
            let v475: &str = &v474.as_str();
            let v476: std::string::String =
                v471.replace_all(&v473, v475).to_string();
            let v477: string = fable_library_rust::String_::fromStr(&v476);
            let v479: std::string::String = (&v477).to_string().clone();
            if let Cli::US0::US0_1 =
                   &if cfg!(target_arch = "wasm32") {
                        Cli::US0::US0_1
                    } else { Cli::US0::US0_0 } {
                let v500: Array<std::string::String> =
                    array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                            (&string("color: purple")).as_ref().to_string(),
                            (&stringFrom(format!("{0}",
                                                 &v411))).as_ref().to_string(),
                            (&stringFrom(format!("color: {0}",
                                                 &string("666666")))).as_ref().to_string(),
                            (&stringFrom(format!("{0} {1}", &v445,
                                                 &v479))).as_ref().to_string(),
                            (&string("color: #222222")).as_ref().to_string(),
                            (&stringFrom(format!("{0}",
                                                 &v479))).as_ref().to_string()]);
                let v501 = core::ops::Deref::deref(&v500);
                let v504 = serde_wasm_bindgen::to_value(&*****&v501).unwrap();
                web_sys::console::log(&js_sys::Array::from(&v504));
                ()
            } else {
                let v508: colored::ColoredString =
                    colored::Colorize::color(&*v411, string("purple").to_string());
                let v509: std::string::String = format!("{}", &v508);
                let v510: string = Cli::method7();
                let v511: &str = &v510.as_str();
                let v515: &str = &v511[0i32 as usize..2i32 as usize];
                let v516: string =
                    fable_library_rust::String_::fromStr(&v515);
                let v518: u8 = u8::from_str_radix(&v516, 16).unwrap();
                let v519: string = Cli::method7();
                let v520: &str = &v519.as_str();
                let v523: &str = &v520[2i32 as usize..4i32 as usize];
                let v524: string =
                    fable_library_rust::String_::fromStr(&v523);
                let v525: u8 = u8::from_str_radix(&v524, 16).unwrap();
                let v526: string = Cli::method7();
                let v527: &str = &v526.as_str();
                let v530: &str = &v527[4i32 as usize..6i32 as usize];
                let v531: string =
                    fable_library_rust::String_::fromStr(&v530);
                let v532: u8 = u8::from_str_radix(&v531, 16).unwrap();
                let v534: colored::ColoredString =
                    colored::Colorize::truecolor(&*v445.to_string(), v518, v525, v532);
                let v535: std::string::String = format!("{}", &v534);
                let v536: string = Cli::method8();
                let v537: &str = &v536.as_str();
                let v540: &str = &v537[0i32 as usize..2i32 as usize];
                let v541: string =
                    fable_library_rust::String_::fromStr(&v540);
                let v542: u8 = u8::from_str_radix(&v541, 16).unwrap();
                let v543: string = Cli::method8();
                let v544: &str = &v543.as_str();
                let v547: &str = &v544[2i32 as usize..4i32 as usize];
                let v548: string =
                    fable_library_rust::String_::fromStr(&v547);
                let v549: u8 = u8::from_str_radix(&v548, 16).unwrap();
                let v550: string = Cli::method8();
                let v551: &str = &v550.as_str();
                let v554: &str = &v551[4i32 as usize..6i32 as usize];
                let v555: string =
                    fable_library_rust::String_::fromStr(&v554);
                let v556: u8 = u8::from_str_radix(&v555, 16).unwrap();
                let v557: colored::ColoredString =
                    colored::Colorize::truecolor(&*v479.to_string(), v542, v549, v556);
                let v558: std::string::String = format!("{}", &v557);
                println!("{0}",
                         stringFrom(format!("{0} {1} {2}", &v509, &v535, &v558)));
                ()
            }
            {
                let v561: Result<std::fs::File, std::io::Error> =
                    std::fs::File::open(&v330);
                let v563: &std::fs::File = &v561.unwrap();
                let v565:
                        std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                    std::cell::RefCell::new(linereader::LineReader::new(&v563));
                let v571: Array<std::string::String> =
                    array(&[(&string("reader")).to_string(),
                            format!("{:?}", &v565)]);
                let v572 = core::ops::Deref::deref(&v571);
                let v573 = &***&v572;
                let v574 = &***&v573;
                let v576: std::string::String =
                    format!("{:?}", &v574).clone();
                let v577: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v582: string =
                    Cli::method3(6i32,
                                 toString(&((&v577).timestamp() - v328)));
                let v583: u8 = rand::random::<u8>();
                let v596: Array<std::string::String> =
                    array(&[(&v101).to_string(), (&v582).to_string(),
                            (&v106).to_string(), format!("{:?}", &v583),
                            (&v111).to_string(), (&v114).to_string()]);
                let v597 = core::ops::Deref::deref(&v596);
                let v598 = &***&v597;
                let v599 = &***&v598;
                let v601: std::string::String =
                    format!("{:?}", &v599).clone();
                let v604: Array<std::string::String> =
                    array(&[(&v369).to_string()]);
                let v605 = core::ops::Deref::deref(&v604);
                let v606 = &***&v605;
                let v607 = &***&v606;
                let v609: std::string::String =
                    format!("{:?}", &v607).clone();
                let v611: string = toString(&format!("{}", &v609));
                let v613: &str = r#""([^"]+)", "([^"]+)""#;
                let v614: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v613);
                let v615: &regex::Regex = &v614.build().unwrap();
                let v616: string = Cli::method2(v611);
                let v617: &str = &v616.as_str();
                let v618: string = Cli::method4();
                let v619: &str = &v618.as_str();
                let v620: std::string::String =
                    v615.replace_all(&v617, v619).to_string();
                let v621: string =
                    fable_library_rust::String_::fromStr(&v620);
                let v623: &str = r#"\["(.*?)"\]"#;
                let v624: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v623);
                let v625: &regex::Regex = &v624.build().unwrap();
                let v626: string = Cli::method2(v621);
                let v627: &str = &v626.as_str();
                let v628: string = Cli::method5();
                let v629: &str = &v628.as_str();
                let v630: std::string::String =
                    v625.replace_all(&v627, v629).to_string();
                let v631: string =
                    fable_library_rust::String_::fromStr(&v630);
                let v633: &str = r#", "#;
                let v634: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v633);
                let v635: &regex::Regex = &v634.build().unwrap();
                let v636: string = Cli::method2(v631);
                let v637: &str = &v636.as_str();
                let v638: string = Cli::method6();
                let v639: &str = &v638.as_str();
                let v640: std::string::String =
                    v635.replace_all(&v637, v639).to_string();
                let v641: string =
                    fable_library_rust::String_::fromStr(&v640);
                let v643: std::string::String = (&v641).to_string().clone();
                let v645: string = toString(&format!("{}", &v576));
                let v647: &str = r#""([^"]+)", "([^"]+)""#;
                let v648: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v647);
                let v649: &regex::Regex = &v648.build().unwrap();
                let v650: string = Cli::method2(v645);
                let v651: &str = &v650.as_str();
                let v652: string = Cli::method4();
                let v653: &str = &v652.as_str();
                let v654: std::string::String =
                    v649.replace_all(&v651, v653).to_string();
                let v655: string =
                    fable_library_rust::String_::fromStr(&v654);
                let v657: &str = r#"\["(.*?)"\]"#;
                let v658: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v657);
                let v659: &regex::Regex = &v658.build().unwrap();
                let v660: string = Cli::method2(v655);
                let v661: &str = &v660.as_str();
                let v662: string = Cli::method5();
                let v663: &str = &v662.as_str();
                let v664: std::string::String =
                    v659.replace_all(&v661, v663).to_string();
                let v665: string =
                    fable_library_rust::String_::fromStr(&v664);
                let v667: &str = r#", "#;
                let v668: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v667);
                let v669: &regex::Regex = &v668.build().unwrap();
                let v670: string = Cli::method2(v665);
                let v671: &str = &v670.as_str();
                let v672: string = Cli::method6();
                let v673: &str = &v672.as_str();
                let v674: std::string::String =
                    v669.replace_all(&v671, v673).to_string();
                let v675: string =
                    fable_library_rust::String_::fromStr(&v674);
                let v677: std::string::String = (&v675).to_string().clone();
                let v679: string = toString(&format!("{}", &v601));
                let v681: &str = r#""([^"]+)", "([^"]+)""#;
                let v682: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v681);
                let v683: &regex::Regex = &v682.build().unwrap();
                let v684: string = Cli::method2(v679);
                let v685: &str = &v684.as_str();
                let v686: string = Cli::method4();
                let v687: &str = &v686.as_str();
                let v688: std::string::String =
                    v683.replace_all(&v685, v687).to_string();
                let v689: string =
                    fable_library_rust::String_::fromStr(&v688);
                let v691: &str = r#"\["(.*?)"\]"#;
                let v692: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v691);
                let v693: &regex::Regex = &v692.build().unwrap();
                let v694: string = Cli::method2(v689);
                let v695: &str = &v694.as_str();
                let v696: string = Cli::method5();
                let v697: &str = &v696.as_str();
                let v698: std::string::String =
                    v693.replace_all(&v695, v697).to_string();
                let v699: string =
                    fable_library_rust::String_::fromStr(&v698);
                let v701: &str = r#", "#;
                let v702: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v701);
                let v703: &regex::Regex = &v702.build().unwrap();
                let v704: string = Cli::method2(v699);
                let v705: &str = &v704.as_str();
                let v706: string = Cli::method6();
                let v707: &str = &v706.as_str();
                let v708: std::string::String =
                    v703.replace_all(&v705, v707).to_string();
                let v709: string =
                    fable_library_rust::String_::fromStr(&v708);
                let v711: std::string::String = (&v709).to_string().clone();
                if let Cli::US0::US0_1 =
                       &if cfg!(target_arch = "wasm32") {
                            Cli::US0::US0_1
                        } else { Cli::US0::US0_0 } {
                    let v732: Array<std::string::String> =
                        array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                                (&string("color: purple")).as_ref().to_string(),
                                (&stringFrom(format!("{0}",
                                                     &v643))).as_ref().to_string(),
                                (&stringFrom(format!("color: {0}",
                                                     &string("666666")))).as_ref().to_string(),
                                (&stringFrom(format!("{0} {1}", &v677,
                                                     &v711))).as_ref().to_string(),
                                (&string("color: #222222")).as_ref().to_string(),
                                (&stringFrom(format!("{0}",
                                                     &v711))).as_ref().to_string()]);
                    let v733 = core::ops::Deref::deref(&v732);
                    let v736 =
                        serde_wasm_bindgen::to_value(&*****&v733).unwrap();
                    web_sys::console::log(&js_sys::Array::from(&v736));
                    ()
                } else {
                    let v740: colored::ColoredString =
                        colored::Colorize::color(&*v643, string("purple").to_string());
                    let v741: std::string::String = format!("{}", &v740);
                    let v742: string = Cli::method7();
                    let v743: &str = &v742.as_str();
                    let v747: &str = &v743[0i32 as usize..2i32 as usize];
                    let v748: string =
                        fable_library_rust::String_::fromStr(&v747);
                    let v750: u8 = u8::from_str_radix(&v748, 16).unwrap();
                    let v751: string = Cli::method7();
                    let v752: &str = &v751.as_str();
                    let v755: &str = &v752[2i32 as usize..4i32 as usize];
                    let v756: string =
                        fable_library_rust::String_::fromStr(&v755);
                    let v757: u8 = u8::from_str_radix(&v756, 16).unwrap();
                    let v758: string = Cli::method7();
                    let v759: &str = &v758.as_str();
                    let v762: &str = &v759[4i32 as usize..6i32 as usize];
                    let v763: string =
                        fable_library_rust::String_::fromStr(&v762);
                    let v764: u8 = u8::from_str_radix(&v763, 16).unwrap();
                    let v766: colored::ColoredString =
                        colored::Colorize::truecolor(&*v677.to_string(), v750, v757, v764);
                    let v767: std::string::String = format!("{}", &v766);
                    let v768: string = Cli::method8();
                    let v769: &str = &v768.as_str();
                    let v772: &str = &v769[0i32 as usize..2i32 as usize];
                    let v773: string =
                        fable_library_rust::String_::fromStr(&v772);
                    let v774: u8 = u8::from_str_radix(&v773, 16).unwrap();
                    let v775: string = Cli::method8();
                    let v776: &str = &v775.as_str();
                    let v779: &str = &v776[2i32 as usize..4i32 as usize];
                    let v780: string =
                        fable_library_rust::String_::fromStr(&v779);
                    let v781: u8 = u8::from_str_radix(&v780, 16).unwrap();
                    let v782: string = Cli::method8();
                    let v783: &str = &v782.as_str();
                    let v786: &str = &v783[4i32 as usize..6i32 as usize];
                    let v787: string =
                        fable_library_rust::String_::fromStr(&v786);
                    let v788: u8 = u8::from_str_radix(&v787, 16).unwrap();
                    let v789: colored::ColoredString =
                        colored::Colorize::truecolor(&*v711.to_string(), v774, v781, v788);
                    let v790: std::string::String = format!("{}", &v789);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v741, &v767, &v790)));
                    ()
                }
                {
                    let v793: Lrc<Cli::Mut0> =
                        Lrc::new(Cli::Mut0{l0:
                                               MutCell::new(Lrc::new(Cli::UH0::UH0_1)),});
                    let v794 = Cli::method9(v328, v793.clone());
                    let v796: Result<(), std::io::Error> =
                        (v565).borrow_mut().for_each(move |x| v794(x.to_vec()));
                    *((&v796).as_ref()).unwrap();
                    {
                        let v801: Lrc<Cli::UH1> =
                            Cli::method11(Cli::method10(v793.l0.get().clone(),
                                                        Lrc::new(Cli::UH0::UH0_1)),
                                          Lrc::new(Cli::UH1::UH1_1));
                        let v804: std::string::String =
                            (&string("lines len")).to_string().clone();
                        let v806: i32 = Cli::method12(v801.clone(), 0i32);
                        let v809: Array<std::string::String> =
                            array(&[v804, format!("{:?}", &v806)]);
                        let v810 = core::ops::Deref::deref(&v809);
                        let v811 = &***&v810;
                        let v812 = &***&v811;
                        let v814: std::string::String =
                            format!("{:?}", &v812).clone();
                        let v815: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v820: string =
                            Cli::method3(6i32,
                                         toString(&((&v815).timestamp() -
                                                        v328)));
                        let v821: u8 = rand::random::<u8>();
                        let v834: Array<std::string::String> =
                            array(&[(&v101).to_string(), (&v820).to_string(),
                                    (&v106).to_string(),
                                    format!("{:?}", &v821),
                                    (&v111).to_string(),
                                    (&v114).to_string()]);
                        let v835 = core::ops::Deref::deref(&v834);
                        let v836 = &***&v835;
                        let v837 = &***&v836;
                        let v839: std::string::String =
                            format!("{:?}", &v837).clone();
                        let v842: Array<std::string::String> =
                            array(&[(&v369).to_string()]);
                        let v843 = core::ops::Deref::deref(&v842);
                        let v844 = &***&v843;
                        let v845 = &***&v844;
                        let v847: std::string::String =
                            format!("{:?}", &v845).clone();
                        let v849: string = toString(&format!("{}", &v847));
                        let v851: &str = r#""([^"]+)", "([^"]+)""#;
                        let v852: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v851);
                        let v853: &regex::Regex = &v852.build().unwrap();
                        let v854: string = Cli::method2(v849);
                        let v855: &str = &v854.as_str();
                        let v856: string = Cli::method4();
                        let v857: &str = &v856.as_str();
                        let v858: std::string::String =
                            v853.replace_all(&v855, v857).to_string();
                        let v859: string =
                            fable_library_rust::String_::fromStr(&v858);
                        let v861: &str = r#"\["(.*?)"\]"#;
                        let v862: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v861);
                        let v863: &regex::Regex = &v862.build().unwrap();
                        let v864: string = Cli::method2(v859);
                        let v865: &str = &v864.as_str();
                        let v866: string = Cli::method5();
                        let v867: &str = &v866.as_str();
                        let v868: std::string::String =
                            v863.replace_all(&v865, v867).to_string();
                        let v869: string =
                            fable_library_rust::String_::fromStr(&v868);
                        let v871: &str = r#", "#;
                        let v872: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v871);
                        let v873: &regex::Regex = &v872.build().unwrap();
                        let v874: string = Cli::method2(v869);
                        let v875: &str = &v874.as_str();
                        let v876: string = Cli::method6();
                        let v877: &str = &v876.as_str();
                        let v878: std::string::String =
                            v873.replace_all(&v875, v877).to_string();
                        let v879: string =
                            fable_library_rust::String_::fromStr(&v878);
                        let v881: std::string::String =
                            (&v879).to_string().clone();
                        let v883: string = toString(&format!("{}", &v814));
                        let v885: &str = r#""([^"]+)", "([^"]+)""#;
                        let v886: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v885);
                        let v887: &regex::Regex = &v886.build().unwrap();
                        let v888: string = Cli::method2(v883);
                        let v889: &str = &v888.as_str();
                        let v890: string = Cli::method4();
                        let v891: &str = &v890.as_str();
                        let v892: std::string::String =
                            v887.replace_all(&v889, v891).to_string();
                        let v893: string =
                            fable_library_rust::String_::fromStr(&v892);
                        let v895: &str = r#"\["(.*?)"\]"#;
                        let v896: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v895);
                        let v897: &regex::Regex = &v896.build().unwrap();
                        let v898: string = Cli::method2(v893);
                        let v899: &str = &v898.as_str();
                        let v900: string = Cli::method5();
                        let v901: &str = &v900.as_str();
                        let v902: std::string::String =
                            v897.replace_all(&v899, v901).to_string();
                        let v903: string =
                            fable_library_rust::String_::fromStr(&v902);
                        let v905: &str = r#", "#;
                        let v906: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v905);
                        let v907: &regex::Regex = &v906.build().unwrap();
                        let v908: string = Cli::method2(v903);
                        let v909: &str = &v908.as_str();
                        let v910: string = Cli::method6();
                        let v911: &str = &v910.as_str();
                        let v912: std::string::String =
                            v907.replace_all(&v909, v911).to_string();
                        let v913: string =
                            fable_library_rust::String_::fromStr(&v912);
                        let v915: std::string::String =
                            (&v913).to_string().clone();
                        let v917: string = toString(&format!("{}", &v839));
                        let v919: &str = r#""([^"]+)", "([^"]+)""#;
                        let v920: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v919);
                        let v921: &regex::Regex = &v920.build().unwrap();
                        let v922: string = Cli::method2(v917);
                        let v923: &str = &v922.as_str();
                        let v924: string = Cli::method4();
                        let v925: &str = &v924.as_str();
                        let v926: std::string::String =
                            v921.replace_all(&v923, v925).to_string();
                        let v927: string =
                            fable_library_rust::String_::fromStr(&v926);
                        let v929: &str = r#"\["(.*?)"\]"#;
                        let v930: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v929);
                        let v931: &regex::Regex = &v930.build().unwrap();
                        let v932: string = Cli::method2(v927);
                        let v933: &str = &v932.as_str();
                        let v934: string = Cli::method5();
                        let v935: &str = &v934.as_str();
                        let v936: std::string::String =
                            v931.replace_all(&v933, v935).to_string();
                        let v937: string =
                            fable_library_rust::String_::fromStr(&v936);
                        let v939: &str = r#", "#;
                        let v940: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v939);
                        let v941: &regex::Regex = &v940.build().unwrap();
                        let v942: string = Cli::method2(v937);
                        let v943: &str = &v942.as_str();
                        let v944: string = Cli::method6();
                        let v945: &str = &v944.as_str();
                        let v946: std::string::String =
                            v941.replace_all(&v943, v945).to_string();
                        let v947: string =
                            fable_library_rust::String_::fromStr(&v946);
                        let v949: std::string::String =
                            (&v947).to_string().clone();
                        if let Cli::US0::US0_1 =
                               &if cfg!(target_arch = "wasm32") {
                                    Cli::US0::US0_1
                                } else { Cli::US0::US0_0 } {
                            let v970: Array<std::string::String> =
                                array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                                        (&string("color: purple")).as_ref().to_string(),
                                        (&stringFrom(format!("{0}",
                                                             &v881))).as_ref().to_string(),
                                        (&stringFrom(format!("color: {0}",
                                                             &string("666666")))).as_ref().to_string(),
                                        (&stringFrom(format!("{0} {1}", &v915,
                                                             &v949))).as_ref().to_string(),
                                        (&string("color: #222222")).as_ref().to_string(),
                                        (&stringFrom(format!("{0}",
                                                             &v949))).as_ref().to_string()]);
                            let v971 = core::ops::Deref::deref(&v970);
                            let v974 =
                                serde_wasm_bindgen::to_value(&*****&v971).unwrap();
                            web_sys::console::log(&js_sys::Array::from(&v974));
                            ()
                        } else {
                            let v978: colored::ColoredString =
                                colored::Colorize::color(&*v881, string("purple").to_string());
                            let v979: std::string::String =
                                format!("{}", &v978);
                            let v980: string = Cli::method7();
                            let v981: &str = &v980.as_str();
                            let v985: &str =
                                &v981[0i32 as usize..2i32 as usize];
                            let v986: string =
                                fable_library_rust::String_::fromStr(&v985);
                            let v988: u8 =
                                u8::from_str_radix(&v986, 16).unwrap();
                            let v989: string = Cli::method7();
                            let v990: &str = &v989.as_str();
                            let v993: &str =
                                &v990[2i32 as usize..4i32 as usize];
                            let v994: string =
                                fable_library_rust::String_::fromStr(&v993);
                            let v995: u8 =
                                u8::from_str_radix(&v994, 16).unwrap();
                            let v996: string = Cli::method7();
                            let v997: &str = &v996.as_str();
                            let v1000: &str =
                                &v997[4i32 as usize..6i32 as usize];
                            let v1001: string =
                                fable_library_rust::String_::fromStr(&v1000);
                            let v1002: u8 =
                                u8::from_str_radix(&v1001, 16).unwrap();
                            let v1004: colored::ColoredString =
                                colored::Colorize::truecolor(&*v915.to_string(), v988, v995, v1002);
                            let v1005: std::string::String =
                                format!("{}", &v1004);
                            let v1006: string = Cli::method8();
                            let v1007: &str = &v1006.as_str();
                            let v1010: &str =
                                &v1007[0i32 as usize..2i32 as usize];
                            let v1011: string =
                                fable_library_rust::String_::fromStr(&v1010);
                            let v1012: u8 =
                                u8::from_str_radix(&v1011, 16).unwrap();
                            let v1013: string = Cli::method8();
                            let v1014: &str = &v1013.as_str();
                            let v1017: &str =
                                &v1014[2i32 as usize..4i32 as usize];
                            let v1018: string =
                                fable_library_rust::String_::fromStr(&v1017);
                            let v1019: u8 =
                                u8::from_str_radix(&v1018, 16).unwrap();
                            let v1020: string = Cli::method8();
                            let v1021: &str = &v1020.as_str();
                            let v1024: &str =
                                &v1021[4i32 as usize..6i32 as usize];
                            let v1025: string =
                                fable_library_rust::String_::fromStr(&v1024);
                            let v1026: u8 =
                                u8::from_str_radix(&v1025, 16).unwrap();
                            let v1027: colored::ColoredString =
                                colored::Colorize::truecolor(&*v949.to_string(), v1012, v1019, v1026);
                            let v1028: std::string::String =
                                format!("{}", &v1027);
                            println!("{0}",
                                     stringFrom(format!("{0} {1} {2}", &v979, &v1005, &v1028)));
                            ()
                        }
                        {
                            let v1037: string =
                                Cli::method15(Cli::method14((Cli::method13(v7,
                                                                           v801,
                                                                           0i32,
                                                                           Lrc::new(Cli::UH1::UH1_1))).1.clone(),
                                                            Lrc::new(Cli::UH1::UH1_1)),
                                              string(""));
                            let v1040: std::string::String =
                                (&string("text len")).to_string().clone();
                            let v1042: i32 =
                                (&v1037).len().try_into().unwrap();
                            let v1045: Array<std::string::String> =
                                array(&[v1040, format!("{:?}", &v1042)]);
                            let v1046 = core::ops::Deref::deref(&v1045);
                            let v1047 = &***&v1046;
                            let v1048 = &***&v1047;
                            let v1050: std::string::String =
                                format!("{:?}", &v1048).clone();
                            let v1051: chrono::DateTime<chrono::Utc> =
                                chrono::Utc::now();
                            let v1056: string =
                                Cli::method3(6i32,
                                             toString(&((&v1051).timestamp() -
                                                            v7)));
                            let v1057: u8 = rand::random::<u8>();
                            let v1070: Array<std::string::String> =
                                array(&[(&v101).to_string(),
                                        (&v1056).to_string(),
                                        (&v106).to_string(),
                                        format!("{:?}", &v1057),
                                        (&v111).to_string(),
                                        (&v114).to_string()]);
                            let v1071 = core::ops::Deref::deref(&v1070);
                            let v1072 = &***&v1071;
                            let v1073 = &***&v1072;
                            let v1075: std::string::String =
                                format!("{:?}", &v1073).clone();
                            let v1078: Array<std::string::String> =
                                array(&[(&v123).to_string()]);
                            let v1079 = core::ops::Deref::deref(&v1078);
                            let v1080 = &***&v1079;
                            let v1081 = &***&v1080;
                            let v1083: std::string::String =
                                format!("{:?}", &v1081).clone();
                            let v1085: string =
                                toString(&format!("{}", &v1083));
                            let v1087: &str = r#""([^"]+)", "([^"]+)""#;
                            let v1088: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1087);
                            let v1089: &regex::Regex =
                                &v1088.build().unwrap();
                            let v1090: string = Cli::method2(v1085);
                            let v1091: &str = &v1090.as_str();
                            let v1092: string = Cli::method4();
                            let v1093: &str = &v1092.as_str();
                            let v1094: std::string::String =
                                v1089.replace_all(&v1091, v1093).to_string();
                            let v1095: string =
                                fable_library_rust::String_::fromStr(&v1094);
                            let v1097: &str = r#"\["(.*?)"\]"#;
                            let v1098: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1097);
                            let v1099: &regex::Regex =
                                &v1098.build().unwrap();
                            let v1100: string = Cli::method2(v1095);
                            let v1101: &str = &v1100.as_str();
                            let v1102: string = Cli::method5();
                            let v1103: &str = &v1102.as_str();
                            let v1104: std::string::String =
                                v1099.replace_all(&v1101, v1103).to_string();
                            let v1105: string =
                                fable_library_rust::String_::fromStr(&v1104);
                            let v1107: &str = r#", "#;
                            let v1108: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1107);
                            let v1109: &regex::Regex =
                                &v1108.build().unwrap();
                            let v1110: string = Cli::method2(v1105);
                            let v1111: &str = &v1110.as_str();
                            let v1112: string = Cli::method6();
                            let v1113: &str = &v1112.as_str();
                            let v1114: std::string::String =
                                v1109.replace_all(&v1111, v1113).to_string();
                            let v1115: string =
                                fable_library_rust::String_::fromStr(&v1114);
                            let v1117: std::string::String =
                                (&v1115).to_string().clone();
                            let v1119: string =
                                toString(&format!("{}", &v1050));
                            let v1121: &str = r#""([^"]+)", "([^"]+)""#;
                            let v1122: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1121);
                            let v1123: &regex::Regex =
                                &v1122.build().unwrap();
                            let v1124: string = Cli::method2(v1119);
                            let v1125: &str = &v1124.as_str();
                            let v1126: string = Cli::method4();
                            let v1127: &str = &v1126.as_str();
                            let v1128: std::string::String =
                                v1123.replace_all(&v1125, v1127).to_string();
                            let v1129: string =
                                fable_library_rust::String_::fromStr(&v1128);
                            let v1131: &str = r#"\["(.*?)"\]"#;
                            let v1132: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1131);
                            let v1133: &regex::Regex =
                                &v1132.build().unwrap();
                            let v1134: string = Cli::method2(v1129);
                            let v1135: &str = &v1134.as_str();
                            let v1136: string = Cli::method5();
                            let v1137: &str = &v1136.as_str();
                            let v1138: std::string::String =
                                v1133.replace_all(&v1135, v1137).to_string();
                            let v1139: string =
                                fable_library_rust::String_::fromStr(&v1138);
                            let v1141: &str = r#", "#;
                            let v1142: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1141);
                            let v1143: &regex::Regex =
                                &v1142.build().unwrap();
                            let v1144: string = Cli::method2(v1139);
                            let v1145: &str = &v1144.as_str();
                            let v1146: string = Cli::method6();
                            let v1147: &str = &v1146.as_str();
                            let v1148: std::string::String =
                                v1143.replace_all(&v1145, v1147).to_string();
                            let v1149: string =
                                fable_library_rust::String_::fromStr(&v1148);
                            let v1151: std::string::String =
                                (&v1149).to_string().clone();
                            let v1153: string =
                                toString(&format!("{}", &v1075));
                            let v1155: &str = r#""([^"]+)", "([^"]+)""#;
                            let v1156: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1155);
                            let v1157: &regex::Regex =
                                &v1156.build().unwrap();
                            let v1158: string = Cli::method2(v1153);
                            let v1159: &str = &v1158.as_str();
                            let v1160: string = Cli::method4();
                            let v1161: &str = &v1160.as_str();
                            let v1162: std::string::String =
                                v1157.replace_all(&v1159, v1161).to_string();
                            let v1163: string =
                                fable_library_rust::String_::fromStr(&v1162);
                            let v1165: &str = r#"\["(.*?)"\]"#;
                            let v1166: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1165);
                            let v1167: &regex::Regex =
                                &v1166.build().unwrap();
                            let v1168: string = Cli::method2(v1163);
                            let v1169: &str = &v1168.as_str();
                            let v1170: string = Cli::method5();
                            let v1171: &str = &v1170.as_str();
                            let v1172: std::string::String =
                                v1167.replace_all(&v1169, v1171).to_string();
                            let v1173: string =
                                fable_library_rust::String_::fromStr(&v1172);
                            let v1175: &str = r#", "#;
                            let v1176: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1175);
                            let v1177: &regex::Regex =
                                &v1176.build().unwrap();
                            let v1178: string = Cli::method2(v1173);
                            let v1179: &str = &v1178.as_str();
                            let v1180: string = Cli::method6();
                            let v1181: &str = &v1180.as_str();
                            let v1182: std::string::String =
                                v1177.replace_all(&v1179, v1181).to_string();
                            let v1183: string =
                                fable_library_rust::String_::fromStr(&v1182);
                            let v1185: std::string::String =
                                (&v1183).to_string().clone();
                            if let Cli::US0::US0_1 =
                                   &if cfg!(target_arch = "wasm32") {
                                        Cli::US0::US0_1
                                    } else { Cli::US0::US0_0 } {
                                let v1206: Array<std::string::String> =
                                    array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                                            (&string("color: purple")).as_ref().to_string(),
                                            (&stringFrom(format!("{0}",
                                                                 &v1117))).as_ref().to_string(),
                                            (&stringFrom(format!("color: {0}",
                                                                 &string("666666")))).as_ref().to_string(),
                                            (&stringFrom(format!("{0} {1}",
                                                                 &v1151,
                                                                 &v1185))).as_ref().to_string(),
                                            (&string("color: #222222")).as_ref().to_string(),
                                            (&stringFrom(format!("{0}",
                                                                 &v1185))).as_ref().to_string()]);
                                let v1207 = core::ops::Deref::deref(&v1206);
                                let v1210 =
                                    serde_wasm_bindgen::to_value(&*****&v1207).unwrap();
                                web_sys::console::log(&js_sys::Array::from(&v1210));
                                ()
                            } else {
                                let v1214: colored::ColoredString =
                                    colored::Colorize::color(&*v1117, string("purple").to_string());
                                let v1215: std::string::String =
                                    format!("{}", &v1214);
                                let v1216: string = Cli::method7();
                                let v1217: &str = &v1216.as_str();
                                let v1221: &str =
                                    &v1217[0i32 as usize..2i32 as usize];
                                let v1222: string =
                                    fable_library_rust::String_::fromStr(&v1221);
                                let v1224: u8 =
                                    u8::from_str_radix(&v1222, 16).unwrap();
                                let v1225: string = Cli::method7();
                                let v1226: &str = &v1225.as_str();
                                let v1229: &str =
                                    &v1226[2i32 as usize..4i32 as usize];
                                let v1230: string =
                                    fable_library_rust::String_::fromStr(&v1229);
                                let v1231: u8 =
                                    u8::from_str_radix(&v1230, 16).unwrap();
                                let v1232: string = Cli::method7();
                                let v1233: &str = &v1232.as_str();
                                let v1236: &str =
                                    &v1233[4i32 as usize..6i32 as usize];
                                let v1237: string =
                                    fable_library_rust::String_::fromStr(&v1236);
                                let v1238: u8 =
                                    u8::from_str_radix(&v1237, 16).unwrap();
                                let v1240: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1151.to_string(), v1224, v1231, v1238);
                                let v1241: std::string::String =
                                    format!("{}", &v1240);
                                let v1242: string = Cli::method8();
                                let v1243: &str = &v1242.as_str();
                                let v1246: &str =
                                    &v1243[0i32 as usize..2i32 as usize];
                                let v1247: string =
                                    fable_library_rust::String_::fromStr(&v1246);
                                let v1248: u8 =
                                    u8::from_str_radix(&v1247, 16).unwrap();
                                let v1249: string = Cli::method8();
                                let v1250: &str = &v1249.as_str();
                                let v1253: &str =
                                    &v1250[2i32 as usize..4i32 as usize];
                                let v1254: string =
                                    fable_library_rust::String_::fromStr(&v1253);
                                let v1255: u8 =
                                    u8::from_str_radix(&v1254, 16).unwrap();
                                let v1256: string = Cli::method8();
                                let v1257: &str = &v1256.as_str();
                                let v1260: &str =
                                    &v1257[4i32 as usize..6i32 as usize];
                                let v1261: string =
                                    fable_library_rust::String_::fromStr(&v1260);
                                let v1262: u8 =
                                    u8::from_str_radix(&v1261, 16).unwrap();
                                let v1263: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1185.to_string(), v1248, v1255, v1262);
                                let v1264: std::string::String =
                                    format!("{}", &v1263);
                                println!("{0}",
                                         stringFrom(format!("{0} {1} {2}", &v1215, &v1241, &v1264)));
                                ()
                            }
                            {
                                let v1267: Result<(), std::io::Error> =
                                    std::fs::write(v77, v1037.as_str());
                                *((&v1267).as_ref()).unwrap();
                                {
                                    let v1270: std::string::String =
                                        (&string("> fs_write rs_path_clean text; ok")).to_string().clone();
                                    let v1271: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v1276: string =
                                        Cli::method3(6i32,
                                                     toString(&((&v1271).timestamp()
                                                                    - v7)));
                                    let v1277: u8 = rand::random::<u8>();
                                    let v1290: Array<std::string::String> =
                                        array(&[(&v101).to_string(),
                                                (&v1276).to_string(),
                                                (&v106).to_string(),
                                                format!("{:?}", &v1277),
                                                (&v111).to_string(),
                                                (&v114).to_string()]);
                                    let v1291 =
                                        core::ops::Deref::deref(&v1290);
                                    let v1292 = &***&v1291;
                                    let v1293 = &***&v1292;
                                    let v1295: std::string::String =
                                        format!("{:?}", &v1293).clone();
                                    let v1298: Array<std::string::String> =
                                        array(&[(&v123).to_string()]);
                                    let v1299 =
                                        core::ops::Deref::deref(&v1298);
                                    let v1300 = &***&v1299;
                                    let v1301 = &***&v1300;
                                    let v1303: std::string::String =
                                        format!("{:?}", &v1301).clone();
                                    let v1305: string =
                                        toString(&format!("{}", &v1303));
                                    let v1307: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1308: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1307);
                                    let v1309: &regex::Regex =
                                        &v1308.build().unwrap();
                                    let v1310: string = Cli::method2(v1305);
                                    let v1311: &str = &v1310.as_str();
                                    let v1312: string = Cli::method4();
                                    let v1313: &str = &v1312.as_str();
                                    let v1314: std::string::String =
                                        v1309.replace_all(&v1311, v1313).to_string();
                                    let v1315: string =
                                        fable_library_rust::String_::fromStr(&v1314);
                                    let v1317: &str = r#"\["(.*?)"\]"#;
                                    let v1318: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1317);
                                    let v1319: &regex::Regex =
                                        &v1318.build().unwrap();
                                    let v1320: string = Cli::method2(v1315);
                                    let v1321: &str = &v1320.as_str();
                                    let v1322: string = Cli::method5();
                                    let v1323: &str = &v1322.as_str();
                                    let v1324: std::string::String =
                                        v1319.replace_all(&v1321, v1323).to_string();
                                    let v1325: string =
                                        fable_library_rust::String_::fromStr(&v1324);
                                    let v1327: &str = r#", "#;
                                    let v1328: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1327);
                                    let v1329: &regex::Regex =
                                        &v1328.build().unwrap();
                                    let v1330: string = Cli::method2(v1325);
                                    let v1331: &str = &v1330.as_str();
                                    let v1332: string = Cli::method6();
                                    let v1333: &str = &v1332.as_str();
                                    let v1334: std::string::String =
                                        v1329.replace_all(&v1331, v1333).to_string();
                                    let v1335: string =
                                        fable_library_rust::String_::fromStr(&v1334);
                                    let v1337: std::string::String =
                                        (&v1335).to_string().clone();
                                    let v1339: string =
                                        toString(&format!("{}", &v1270));
                                    let v1341: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1342: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1341);
                                    let v1343: &regex::Regex =
                                        &v1342.build().unwrap();
                                    let v1344: string = Cli::method2(v1339);
                                    let v1345: &str = &v1344.as_str();
                                    let v1346: string = Cli::method4();
                                    let v1347: &str = &v1346.as_str();
                                    let v1348: std::string::String =
                                        v1343.replace_all(&v1345, v1347).to_string();
                                    let v1349: string =
                                        fable_library_rust::String_::fromStr(&v1348);
                                    let v1351: &str = r#"\["(.*?)"\]"#;
                                    let v1352: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1351);
                                    let v1353: &regex::Regex =
                                        &v1352.build().unwrap();
                                    let v1354: string = Cli::method2(v1349);
                                    let v1355: &str = &v1354.as_str();
                                    let v1356: string = Cli::method5();
                                    let v1357: &str = &v1356.as_str();
                                    let v1358: std::string::String =
                                        v1353.replace_all(&v1355, v1357).to_string();
                                    let v1359: string =
                                        fable_library_rust::String_::fromStr(&v1358);
                                    let v1361: &str = r#", "#;
                                    let v1362: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1361);
                                    let v1363: &regex::Regex =
                                        &v1362.build().unwrap();
                                    let v1364: string = Cli::method2(v1359);
                                    let v1365: &str = &v1364.as_str();
                                    let v1366: string = Cli::method6();
                                    let v1367: &str = &v1366.as_str();
                                    let v1368: std::string::String =
                                        v1363.replace_all(&v1365, v1367).to_string();
                                    let v1369: string =
                                        fable_library_rust::String_::fromStr(&v1368);
                                    let v1371: std::string::String =
                                        (&v1369).to_string().clone();
                                    let v1373: string =
                                        toString(&format!("{}", &v1295));
                                    let v1375: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1376: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1375);
                                    let v1377: &regex::Regex =
                                        &v1376.build().unwrap();
                                    let v1378: string = Cli::method2(v1373);
                                    let v1379: &str = &v1378.as_str();
                                    let v1380: string = Cli::method4();
                                    let v1381: &str = &v1380.as_str();
                                    let v1382: std::string::String =
                                        v1377.replace_all(&v1379, v1381).to_string();
                                    let v1383: string =
                                        fable_library_rust::String_::fromStr(&v1382);
                                    let v1385: &str = r#"\["(.*?)"\]"#;
                                    let v1386: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1385);
                                    let v1387: &regex::Regex =
                                        &v1386.build().unwrap();
                                    let v1388: string = Cli::method2(v1383);
                                    let v1389: &str = &v1388.as_str();
                                    let v1390: string = Cli::method5();
                                    let v1391: &str = &v1390.as_str();
                                    let v1392: std::string::String =
                                        v1387.replace_all(&v1389, v1391).to_string();
                                    let v1393: string =
                                        fable_library_rust::String_::fromStr(&v1392);
                                    let v1395: &str = r#", "#;
                                    let v1396: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1395);
                                    let v1397: &regex::Regex =
                                        &v1396.build().unwrap();
                                    let v1398: string = Cli::method2(v1393);
                                    let v1399: &str = &v1398.as_str();
                                    let v1400: string = Cli::method6();
                                    let v1401: &str = &v1400.as_str();
                                    let v1402: std::string::String =
                                        v1397.replace_all(&v1399, v1401).to_string();
                                    let v1403: string =
                                        fable_library_rust::String_::fromStr(&v1402);
                                    let v1405: std::string::String =
                                        (&v1403).to_string().clone();
                                    if let Cli::US0::US0_1 =
                                           &if cfg!(target_arch = "wasm32") {
                                                Cli::US0::US0_1
                                            } else { Cli::US0::US0_0 } {
                                        let v1426:
                                                Array<std::string::String> =
                                            array(&[(&string("%c%s %c%s %c%s")).as_ref().to_string(),
                                                    (&string("color: purple")).as_ref().to_string(),
                                                    (&stringFrom(format!("{0}",
                                                                         &v1337))).as_ref().to_string(),
                                                    (&stringFrom(format!("color: {0}",
                                                                         &string("666666")))).as_ref().to_string(),
                                                    (&stringFrom(format!("{0} {1}",
                                                                         &v1371,
                                                                         &v1405))).as_ref().to_string(),
                                                    (&string("color: #222222")).as_ref().to_string(),
                                                    (&stringFrom(format!("{0}",
                                                                         &v1405))).as_ref().to_string()]);
                                        let v1427 =
                                            core::ops::Deref::deref(&v1426);
                                        let v1430 =
                                            serde_wasm_bindgen::to_value(&*****&v1427).unwrap();
                                        web_sys::console::log(&js_sys::Array::from(&v1430));
                                        ()
                                    } else {
                                        let v1434: colored::ColoredString =
                                            colored::Colorize::color(&*v1337, string("purple").to_string());
                                        let v1435: std::string::String =
                                            format!("{}", &v1434);
                                        let v1436: string = Cli::method7();
                                        let v1437: &str = &v1436.as_str();
                                        let v1441: &str =
                                            &v1437[0i32 as
                                                       usize..2i32 as usize];
                                        let v1442: string =
                                            fable_library_rust::String_::fromStr(&v1441);
                                        let v1444: u8 =
                                            u8::from_str_radix(&v1442, 16).unwrap();
                                        let v1445: string = Cli::method7();
                                        let v1446: &str = &v1445.as_str();
                                        let v1449: &str =
                                            &v1446[2i32 as
                                                       usize..4i32 as usize];
                                        let v1450: string =
                                            fable_library_rust::String_::fromStr(&v1449);
                                        let v1451: u8 =
                                            u8::from_str_radix(&v1450, 16).unwrap();
                                        let v1452: string = Cli::method7();
                                        let v1453: &str = &v1452.as_str();
                                        let v1456: &str =
                                            &v1453[4i32 as
                                                       usize..6i32 as usize];
                                        let v1457: string =
                                            fable_library_rust::String_::fromStr(&v1456);
                                        let v1458: u8 =
                                            u8::from_str_radix(&v1457, 16).unwrap();
                                        let v1460: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1371.to_string(), v1444, v1451, v1458);
                                        let v1461: std::string::String =
                                            format!("{}", &v1460);
                                        let v1462: string = Cli::method8();
                                        let v1463: &str = &v1462.as_str();
                                        let v1466: &str =
                                            &v1463[0i32 as
                                                       usize..2i32 as usize];
                                        let v1467: string =
                                            fable_library_rust::String_::fromStr(&v1466);
                                        let v1468: u8 =
                                            u8::from_str_radix(&v1467, 16).unwrap();
                                        let v1469: string = Cli::method8();
                                        let v1470: &str = &v1469.as_str();
                                        let v1473: &str =
                                            &v1470[2i32 as
                                                       usize..4i32 as usize];
                                        let v1474: string =
                                            fable_library_rust::String_::fromStr(&v1473);
                                        let v1475: u8 =
                                            u8::from_str_radix(&v1474, 16).unwrap();
                                        let v1476: string = Cli::method8();
                                        let v1477: &str = &v1476.as_str();
                                        let v1480: &str =
                                            &v1477[4i32 as
                                                       usize..6i32 as usize];
                                        let v1481: string =
                                            fable_library_rust::String_::fromStr(&v1480);
                                        let v1482: u8 =
                                            u8::from_str_radix(&v1481, 16).unwrap();
                                        let v1483: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1405.to_string(), v1468, v1475, v1482);
                                        let v1484: std::string::String =
                                            format!("{}", &v1483);
                                        println!("{0}",
                                                 stringFrom(format!("{0} {1} {2}", &v1435, &v1461, &v1484)));
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
