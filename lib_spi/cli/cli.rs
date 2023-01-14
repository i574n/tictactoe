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
        let v17: std::string::String = format!("{:?}", ***v14).clone();
        let v19: std::string::String =
            std::string::String::from_utf8((&v2).to_owned()).unwrap();
        let v20: Lrc<Cli::UH0> = v1.l0.get().clone();
        v1.l0.set(Lrc::new(Cli::UH0::UH0_0(v19.clone(), v20.clone())));
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
                                     let v25: std::string::String =
                                         format!("{:?}", ***v22).clone();
                                     let v27: chrono::DateTime<chrono::Utc> =
                                         chrono::Utc::now();
                                     let v33: string =
                                         Cli::method3(6i32,
                                                      toString(&((&v27).timestamp()
                                                                     -
                                                                     v0_1.get())));
                                     let v35: u8 = rand::random::<u8>();
                                     let v53: Array<std::string::String> =
                                         array(&[(&string("timestamp")).to_string(),
                                                 (&v33).to_string(),
                                                 (&string("run_id")).to_string(),
                                                 format!("{:?}", &v35),
                                                 (&string("log_level")).to_string(),
                                                 (&string("Debug")).to_string()]);
                                     let v54 = core::ops::Deref::deref(&v53);
                                     let v56: std::string::String =
                                         format!("{:?}", ***v54).clone();
                                     let v60: Array<std::string::String> =
                                         array(&[(&string("> app ()")).to_string()]);
                                     let v61 = core::ops::Deref::deref(&v60);
                                     let v64: std::string::String =
                                         format!("{:?}", ***v61).clone();
                                     let v66: string =
                                         fable_library_rust::String_::fromStr(&v64);
                                     let v69: &str =
                                         r#""([^"]+)", "([^"]+)""#;
                                     let v71: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v69);
                                     let v73: &regex::Regex =
                                         &v71.build().unwrap();
                                     let v74: string = Cli::method2(v66);
                                     let v76: &str = &v74.as_str();
                                     let v77: string = Cli::method4();
                                     let v78: &str = &v77.as_str();
                                     let v80: std::string::String =
                                         v73.replace_all(&v76, v78).to_string();
                                     let v81: string =
                                         fable_library_rust::String_::fromStr(&v80);
                                     let v84: &str = r#"\["(.*?)"\]"#;
                                     let v85: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v84);
                                     let v86: &regex::Regex =
                                         &v85.build().unwrap();
                                     let v87: string = Cli::method2(v81);
                                     let v88: &str = &v87.as_str();
                                     let v89: string = Cli::method5();
                                     let v90: &str = &v89.as_str();
                                     let v91: std::string::String =
                                         v86.replace_all(&v88, v90).to_string();
                                     let v92: string =
                                         fable_library_rust::String_::fromStr(&v91);
                                     let v95: &str = r#", "#;
                                     let v96: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v95);
                                     let v97: &regex::Regex =
                                         &v96.build().unwrap();
                                     let v98: string = Cli::method2(v92);
                                     let v99: &str = &v98.as_str();
                                     let v100: string = Cli::method6();
                                     let v101: &str = &v100.as_str();
                                     let v102: std::string::String =
                                         v97.replace_all(&v99, v101).to_string();
                                     let v103: string =
                                         fable_library_rust::String_::fromStr(&v102);
                                     let v105: std::string::String =
                                         (&v103).to_string().clone();
                                     let v108: colored::ColoredString =
                                         colored::Colorize::color(&*v105, string("purple").to_string());
                                     let v110: std::string::String =
                                         format!("{}", &v108);
                                     let v112: string =
                                         fable_library_rust::String_::fromStr(&&v25);
                                     let v114: &str =
                                         r#""([^"]+)", "([^"]+)""#;
                                     let v115: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v114);
                                     let v116: &regex::Regex =
                                         &v115.build().unwrap();
                                     let v117: string = Cli::method2(v112);
                                     let v118: &str = &v117.as_str();
                                     let v119: string = Cli::method4();
                                     let v120: &str = &v119.as_str();
                                     let v121: std::string::String =
                                         v116.replace_all(&v118, v120).to_string();
                                     let v122: string =
                                         fable_library_rust::String_::fromStr(&v121);
                                     let v124: &str = r#"\["(.*?)"\]"#;
                                     let v125: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v124);
                                     let v126: &regex::Regex =
                                         &v125.build().unwrap();
                                     let v127: string = Cli::method2(v122);
                                     let v128: &str = &v127.as_str();
                                     let v129: string = Cli::method5();
                                     let v130: &str = &v129.as_str();
                                     let v131: std::string::String =
                                         v126.replace_all(&v128, v130).to_string();
                                     let v132: string =
                                         fable_library_rust::String_::fromStr(&v131);
                                     let v134: &str = r#", "#;
                                     let v135: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v134);
                                     let v136: &regex::Regex =
                                         &v135.build().unwrap();
                                     let v137: string = Cli::method2(v132);
                                     let v138: &str = &v137.as_str();
                                     let v139: string = Cli::method6();
                                     let v140: &str = &v139.as_str();
                                     let v141: std::string::String =
                                         v136.replace_all(&v138, v140).to_string();
                                     let v142: string =
                                         fable_library_rust::String_::fromStr(&v141);
                                     let v144: std::string::String =
                                         (&v142).to_string().clone();
                                     let v145: string = Cli::method7();
                                     let v146: &str = &v145.as_str();
                                     let v150: &str =
                                         &v146[0i32 as usize..2i32 as usize];
                                     let v151: string =
                                         fable_library_rust::String_::fromStr(&v150);
                                     let v153: u8 =
                                         u8::from_str_radix(&v151, 16).unwrap();
                                     let v154: string = Cli::method7();
                                     let v155: &str = &v154.as_str();
                                     let v158: &str =
                                         &v155[2i32 as usize..4i32 as usize];
                                     let v159: string =
                                         fable_library_rust::String_::fromStr(&v158);
                                     let v160: u8 =
                                         u8::from_str_radix(&v159, 16).unwrap();
                                     let v161: string = Cli::method7();
                                     let v162: &str = &v161.as_str();
                                     let v165: &str =
                                         &v162[4i32 as usize..6i32 as usize];
                                     let v166: string =
                                         fable_library_rust::String_::fromStr(&v165);
                                     let v167: u8 =
                                         u8::from_str_radix(&v166, 16).unwrap();
                                     let v169: colored::ColoredString =
                                         colored::Colorize::truecolor(&*v144.to_string(), v153, v160, v167);
                                     let v170: std::string::String =
                                         format!("{}", &v169);
                                     let v172: string =
                                         fable_library_rust::String_::fromStr(&&v56);
                                     let v174: &str =
                                         r#""([^"]+)", "([^"]+)""#;
                                     let v175: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v174);
                                     let v176: &regex::Regex =
                                         &v175.build().unwrap();
                                     let v177: string = Cli::method2(v172);
                                     let v178: &str = &v177.as_str();
                                     let v179: string = Cli::method4();
                                     let v180: &str = &v179.as_str();
                                     let v181: std::string::String =
                                         v176.replace_all(&v178, v180).to_string();
                                     let v182: string =
                                         fable_library_rust::String_::fromStr(&v181);
                                     let v184: &str = r#"\["(.*?)"\]"#;
                                     let v185: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v184);
                                     let v186: &regex::Regex =
                                         &v185.build().unwrap();
                                     let v187: string = Cli::method2(v182);
                                     let v188: &str = &v187.as_str();
                                     let v189: string = Cli::method5();
                                     let v190: &str = &v189.as_str();
                                     let v191: std::string::String =
                                         v186.replace_all(&v188, v190).to_string();
                                     let v192: string =
                                         fable_library_rust::String_::fromStr(&v191);
                                     let v194: &str = r#", "#;
                                     let v195: regex::RegexBuilder =
                                         regex::RegexBuilder::new(&v194);
                                     let v196: &regex::Regex =
                                         &v195.build().unwrap();
                                     let v197: string = Cli::method2(v192);
                                     let v198: &str = &v197.as_str();
                                     let v199: string = Cli::method6();
                                     let v200: &str = &v199.as_str();
                                     let v201: std::string::String =
                                         v196.replace_all(&v198, v200).to_string();
                                     let v202: string =
                                         fable_library_rust::String_::fromStr(&v201);
                                     let v204: std::string::String =
                                         (&v202).to_string().clone();
                                     let v205: string = Cli::method8();
                                     let v206: &str = &v205.as_str();
                                     let v209: &str =
                                         &v206[0i32 as usize..2i32 as usize];
                                     let v210: string =
                                         fable_library_rust::String_::fromStr(&v209);
                                     let v211: u8 =
                                         u8::from_str_radix(&v210, 16).unwrap();
                                     let v212: string = Cli::method8();
                                     let v213: &str = &v212.as_str();
                                     let v216: &str =
                                         &v213[2i32 as usize..4i32 as usize];
                                     let v217: string =
                                         fable_library_rust::String_::fromStr(&v216);
                                     let v218: u8 =
                                         u8::from_str_radix(&v217, 16).unwrap();
                                     let v219: string = Cli::method8();
                                     let v220: &str = &v219.as_str();
                                     let v223: &str =
                                         &v220[4i32 as usize..6i32 as usize];
                                     let v224: string =
                                         fable_library_rust::String_::fromStr(&v223);
                                     let v225: u8 =
                                         u8::from_str_radix(&v224, 16).unwrap();
                                     let v226: colored::ColoredString =
                                         colored::Colorize::truecolor(&*v204.to_string(), v211, v218, v225);
                                     let v227: std::string::String =
                                         format!("{}", &v226);
                                     println!("{0}",
                                              stringFrom(format!("{0} {1} {2}", &v110, &v170, &v227)));
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
        let v90: std::string::String = format!("{:?}", ***v87).clone();
        let v91: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v96: string =
            Cli::method3(6i32, toString(&((&v91).timestamp() - v7)));
        let v98: u8 = rand::random::<u8>();
        let v99: string = string("timestamp");
        let v104: string = string("run_id");
        let v109: string = string("log_level");
        let v112: string = string("Debug");
        let v115: Array<std::string::String> =
            array(&[(&v99).to_string(), (&v96).to_string(),
                    (&v104).to_string(), format!("{:?}", &v98),
                    (&v109).to_string(), (&v112).to_string()]);
        let v116 = core::ops::Deref::deref(&v115);
        let v118: std::string::String = format!("{:?}", ***v116).clone();
        let v119: string = string("> app ()");
        let v122: Array<std::string::String> = array(&[(&v119).to_string()]);
        let v123 = core::ops::Deref::deref(&v122);
        let v126: std::string::String = format!("{:?}", ***v123).clone();
        let v128: string = fable_library_rust::String_::fromStr(&v126);
        let v131: &str = r#""([^"]+)", "([^"]+)""#;
        let v133: regex::RegexBuilder = regex::RegexBuilder::new(&v131);
        let v135: &regex::Regex = &v133.build().unwrap();
        let v136: string = Cli::method2(v128);
        let v137: &str = &v136.as_str();
        let v138: string = Cli::method4();
        let v139: &str = &v138.as_str();
        let v141: std::string::String =
            v135.replace_all(&v137, v139).to_string();
        let v142: string = fable_library_rust::String_::fromStr(&v141);
        let v145: &str = r#"\["(.*?)"\]"#;
        let v146: regex::RegexBuilder = regex::RegexBuilder::new(&v145);
        let v147: &regex::Regex = &v146.build().unwrap();
        let v148: string = Cli::method2(v142);
        let v149: &str = &v148.as_str();
        let v150: string = Cli::method5();
        let v151: &str = &v150.as_str();
        let v152: std::string::String =
            v147.replace_all(&v149, v151).to_string();
        let v153: string = fable_library_rust::String_::fromStr(&v152);
        let v156: &str = r#", "#;
        let v157: regex::RegexBuilder = regex::RegexBuilder::new(&v156);
        let v158: &regex::Regex = &v157.build().unwrap();
        let v159: string = Cli::method2(v153);
        let v160: &str = &v159.as_str();
        let v161: string = Cli::method6();
        let v162: &str = &v161.as_str();
        let v163: std::string::String =
            v158.replace_all(&v160, v162).to_string();
        let v164: string = fable_library_rust::String_::fromStr(&v163);
        let v166: std::string::String = (&v164).to_string().clone();
        let v167: string = string("purple");
        let v169: colored::ColoredString =
            colored::Colorize::color(&*v166, v167.clone().to_string());
        let v171: std::string::String = format!("{}", &v169);
        let v173: string = fable_library_rust::String_::fromStr(&&v90);
        let v175: &str = r#""([^"]+)", "([^"]+)""#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method2(v173);
        let v179: &str = &v178.as_str();
        let v180: string = Cli::method4();
        let v181: &str = &v180.as_str();
        let v182: std::string::String =
            v177.replace_all(&v179, v181).to_string();
        let v183: string = fable_library_rust::String_::fromStr(&v182);
        let v185: &str = r#"\["(.*?)"\]"#;
        let v186: regex::RegexBuilder = regex::RegexBuilder::new(&v185);
        let v187: &regex::Regex = &v186.build().unwrap();
        let v188: string = Cli::method2(v183);
        let v189: &str = &v188.as_str();
        let v190: string = Cli::method5();
        let v191: &str = &v190.as_str();
        let v192: std::string::String =
            v187.replace_all(&v189, v191).to_string();
        let v193: string = fable_library_rust::String_::fromStr(&v192);
        let v195: &str = r#", "#;
        let v196: regex::RegexBuilder = regex::RegexBuilder::new(&v195);
        let v197: &regex::Regex = &v196.build().unwrap();
        let v198: string = Cli::method2(v193);
        let v199: &str = &v198.as_str();
        let v200: string = Cli::method6();
        let v201: &str = &v200.as_str();
        let v202: std::string::String =
            v197.replace_all(&v199, v201).to_string();
        let v203: string = fable_library_rust::String_::fromStr(&v202);
        let v205: std::string::String = (&v203).to_string().clone();
        let v206: string = Cli::method7();
        let v207: &str = &v206.as_str();
        let v211: &str = &v207[0i32 as usize..2i32 as usize];
        let v212: string = fable_library_rust::String_::fromStr(&v211);
        let v214: u8 = u8::from_str_radix(&v212, 16).unwrap();
        let v215: string = Cli::method7();
        let v216: &str = &v215.as_str();
        let v219: &str = &v216[2i32 as usize..4i32 as usize];
        let v220: string = fable_library_rust::String_::fromStr(&v219);
        let v221: u8 = u8::from_str_radix(&v220, 16).unwrap();
        let v222: string = Cli::method7();
        let v223: &str = &v222.as_str();
        let v226: &str = &v223[4i32 as usize..6i32 as usize];
        let v227: string = fable_library_rust::String_::fromStr(&v226);
        let v228: u8 = u8::from_str_radix(&v227, 16).unwrap();
        let v230: colored::ColoredString =
            colored::Colorize::truecolor(&*v205.to_string(), v214, v221, v228);
        let v231: std::string::String = format!("{}", &v230);
        let v233: string = fable_library_rust::String_::fromStr(&&v118);
        let v235: &str = r#""([^"]+)", "([^"]+)""#;
        let v236: regex::RegexBuilder = regex::RegexBuilder::new(&v235);
        let v237: &regex::Regex = &v236.build().unwrap();
        let v238: string = Cli::method2(v233);
        let v239: &str = &v238.as_str();
        let v240: string = Cli::method4();
        let v241: &str = &v240.as_str();
        let v242: std::string::String =
            v237.replace_all(&v239, v241).to_string();
        let v243: string = fable_library_rust::String_::fromStr(&v242);
        let v245: &str = r#"\["(.*?)"\]"#;
        let v246: regex::RegexBuilder = regex::RegexBuilder::new(&v245);
        let v247: &regex::Regex = &v246.build().unwrap();
        let v248: string = Cli::method2(v243);
        let v249: &str = &v248.as_str();
        let v250: string = Cli::method5();
        let v251: &str = &v250.as_str();
        let v252: std::string::String =
            v247.replace_all(&v249, v251).to_string();
        let v253: string = fable_library_rust::String_::fromStr(&v252);
        let v255: &str = r#", "#;
        let v256: regex::RegexBuilder = regex::RegexBuilder::new(&v255);
        let v257: &regex::Regex = &v256.build().unwrap();
        let v258: string = Cli::method2(v253);
        let v259: &str = &v258.as_str();
        let v260: string = Cli::method6();
        let v261: &str = &v260.as_str();
        let v262: std::string::String =
            v257.replace_all(&v259, v261).to_string();
        let v263: string = fable_library_rust::String_::fromStr(&v262);
        let v265: std::string::String = (&v263).to_string().clone();
        let v266: string = Cli::method8();
        let v267: &str = &v266.as_str();
        let v270: &str = &v267[0i32 as usize..2i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v270);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: string = Cli::method8();
        let v274: &str = &v273.as_str();
        let v277: &str = &v274[2i32 as usize..4i32 as usize];
        let v278: string = fable_library_rust::String_::fromStr(&v277);
        let v279: u8 = u8::from_str_radix(&v278, 16).unwrap();
        let v280: string = Cli::method8();
        let v281: &str = &v280.as_str();
        let v284: &str = &v281[4i32 as usize..6i32 as usize];
        let v285: string = fable_library_rust::String_::fromStr(&v284);
        let v286: u8 = u8::from_str_radix(&v285, 16).unwrap();
        let v287: colored::ColoredString =
            colored::Colorize::truecolor(&*v265.to_string(), v272, v279, v286);
        let v288: std::string::String = format!("{}", &v287);
        println!("{0}",
                 stringFrom(format!("{0} {1} {2}", &v171, &v231, &v288)));
        {
            let patternInput_2: (string, string, string, bool) =
                Cli::method0();
            let v294: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v295: i64 = (&v294).timestamp();
            let v296: Result<std::path::PathBuf, std::io::Error> =
                (&v77).canonicalize();
            let v297: std::path::PathBuf =
                (&v296).as_ref().unwrap().to_path_buf();
            let v300: std::string::String =
                (&string("path_clean")).to_string().clone();
            let v302: string =
                fable_library_rust::String_::fromStr(&format!("{}", &v297.display()));
            let v305: Array<std::string::String> =
                array(&[v300, (&v302).to_string()]);
            let v306 = core::ops::Deref::deref(&v305);
            let v308: std::string::String = format!("{:?}", ***v306).clone();
            let v309: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v314: string =
                Cli::method3(6i32, toString(&((&v309).timestamp() - v295)));
            let v315: u8 = rand::random::<u8>();
            let v328: Array<std::string::String> =
                array(&[(&v99).to_string(), (&v314).to_string(),
                        (&v104).to_string(), format!("{:?}", &v315),
                        (&v109).to_string(), (&v112).to_string()]);
            let v329 = core::ops::Deref::deref(&v328);
            let v331: std::string::String = format!("{:?}", ***v329).clone();
            let v332: string = string("> read_lines ()");
            let v335: Array<std::string::String> =
                array(&[(&v332).to_string()]);
            let v336 = core::ops::Deref::deref(&v335);
            let v339: std::string::String = format!("{:?}", ***v336).clone();
            let v340: string = fable_library_rust::String_::fromStr(&v339);
            let v342: &str = r#""([^"]+)", "([^"]+)""#;
            let v343: regex::RegexBuilder = regex::RegexBuilder::new(&v342);
            let v344: &regex::Regex = &v343.build().unwrap();
            let v345: string = Cli::method2(v340);
            let v346: &str = &v345.as_str();
            let v347: string = Cli::method4();
            let v348: &str = &v347.as_str();
            let v349: std::string::String =
                v344.replace_all(&v346, v348).to_string();
            let v350: string = fable_library_rust::String_::fromStr(&v349);
            let v352: &str = r#"\["(.*?)"\]"#;
            let v353: regex::RegexBuilder = regex::RegexBuilder::new(&v352);
            let v354: &regex::Regex = &v353.build().unwrap();
            let v355: string = Cli::method2(v350);
            let v356: &str = &v355.as_str();
            let v357: string = Cli::method5();
            let v358: &str = &v357.as_str();
            let v359: std::string::String =
                v354.replace_all(&v356, v358).to_string();
            let v360: string = fable_library_rust::String_::fromStr(&v359);
            let v362: &str = r#", "#;
            let v363: regex::RegexBuilder = regex::RegexBuilder::new(&v362);
            let v364: &regex::Regex = &v363.build().unwrap();
            let v365: string = Cli::method2(v360);
            let v366: &str = &v365.as_str();
            let v367: string = Cli::method6();
            let v368: &str = &v367.as_str();
            let v369: std::string::String =
                v364.replace_all(&v366, v368).to_string();
            let v370: string = fable_library_rust::String_::fromStr(&v369);
            let v372: std::string::String = (&v370).to_string().clone();
            let v373: colored::ColoredString =
                colored::Colorize::color(&*v372, v167.clone().to_string());
            let v374: std::string::String = format!("{}", &v373);
            let v376: string = fable_library_rust::String_::fromStr(&&v308);
            let v378: &str = r#""([^"]+)", "([^"]+)""#;
            let v379: regex::RegexBuilder = regex::RegexBuilder::new(&v378);
            let v380: &regex::Regex = &v379.build().unwrap();
            let v381: string = Cli::method2(v376);
            let v382: &str = &v381.as_str();
            let v383: string = Cli::method4();
            let v384: &str = &v383.as_str();
            let v385: std::string::String =
                v380.replace_all(&v382, v384).to_string();
            let v386: string = fable_library_rust::String_::fromStr(&v385);
            let v388: &str = r#"\["(.*?)"\]"#;
            let v389: regex::RegexBuilder = regex::RegexBuilder::new(&v388);
            let v390: &regex::Regex = &v389.build().unwrap();
            let v391: string = Cli::method2(v386);
            let v392: &str = &v391.as_str();
            let v393: string = Cli::method5();
            let v394: &str = &v393.as_str();
            let v395: std::string::String =
                v390.replace_all(&v392, v394).to_string();
            let v396: string = fable_library_rust::String_::fromStr(&v395);
            let v398: &str = r#", "#;
            let v399: regex::RegexBuilder = regex::RegexBuilder::new(&v398);
            let v400: &regex::Regex = &v399.build().unwrap();
            let v401: string = Cli::method2(v396);
            let v402: &str = &v401.as_str();
            let v403: string = Cli::method6();
            let v404: &str = &v403.as_str();
            let v405: std::string::String =
                v400.replace_all(&v402, v404).to_string();
            let v406: string = fable_library_rust::String_::fromStr(&v405);
            let v408: std::string::String = (&v406).to_string().clone();
            let v409: string = Cli::method7();
            let v410: &str = &v409.as_str();
            let v413: &str = &v410[0i32 as usize..2i32 as usize];
            let v414: string = fable_library_rust::String_::fromStr(&v413);
            let v415: u8 = u8::from_str_radix(&v414, 16).unwrap();
            let v416: string = Cli::method7();
            let v417: &str = &v416.as_str();
            let v420: &str = &v417[2i32 as usize..4i32 as usize];
            let v421: string = fable_library_rust::String_::fromStr(&v420);
            let v422: u8 = u8::from_str_radix(&v421, 16).unwrap();
            let v423: string = Cli::method7();
            let v424: &str = &v423.as_str();
            let v427: &str = &v424[4i32 as usize..6i32 as usize];
            let v428: string = fable_library_rust::String_::fromStr(&v427);
            let v429: u8 = u8::from_str_radix(&v428, 16).unwrap();
            let v430: colored::ColoredString =
                colored::Colorize::truecolor(&*v408.to_string(), v415, v422, v429);
            let v431: std::string::String = format!("{}", &v430);
            let v433: string = fable_library_rust::String_::fromStr(&&v331);
            let v435: &str = r#""([^"]+)", "([^"]+)""#;
            let v436: regex::RegexBuilder = regex::RegexBuilder::new(&v435);
            let v437: &regex::Regex = &v436.build().unwrap();
            let v438: string = Cli::method2(v433);
            let v439: &str = &v438.as_str();
            let v440: string = Cli::method4();
            let v441: &str = &v440.as_str();
            let v442: std::string::String =
                v437.replace_all(&v439, v441).to_string();
            let v443: string = fable_library_rust::String_::fromStr(&v442);
            let v445: &str = r#"\["(.*?)"\]"#;
            let v446: regex::RegexBuilder = regex::RegexBuilder::new(&v445);
            let v447: &regex::Regex = &v446.build().unwrap();
            let v448: string = Cli::method2(v443);
            let v449: &str = &v448.as_str();
            let v450: string = Cli::method5();
            let v451: &str = &v450.as_str();
            let v452: std::string::String =
                v447.replace_all(&v449, v451).to_string();
            let v453: string = fable_library_rust::String_::fromStr(&v452);
            let v455: &str = r#", "#;
            let v456: regex::RegexBuilder = regex::RegexBuilder::new(&v455);
            let v457: &regex::Regex = &v456.build().unwrap();
            let v458: string = Cli::method2(v453);
            let v459: &str = &v458.as_str();
            let v460: string = Cli::method6();
            let v461: &str = &v460.as_str();
            let v462: std::string::String =
                v457.replace_all(&v459, v461).to_string();
            let v463: string = fable_library_rust::String_::fromStr(&v462);
            let v465: std::string::String = (&v463).to_string().clone();
            let v466: string = Cli::method8();
            let v467: &str = &v466.as_str();
            let v470: &str = &v467[0i32 as usize..2i32 as usize];
            let v471: string = fable_library_rust::String_::fromStr(&v470);
            let v472: u8 = u8::from_str_radix(&v471, 16).unwrap();
            let v473: string = Cli::method8();
            let v474: &str = &v473.as_str();
            let v477: &str = &v474[2i32 as usize..4i32 as usize];
            let v478: string = fable_library_rust::String_::fromStr(&v477);
            let v479: u8 = u8::from_str_radix(&v478, 16).unwrap();
            let v480: string = Cli::method8();
            let v481: &str = &v480.as_str();
            let v484: &str = &v481[4i32 as usize..6i32 as usize];
            let v485: string = fable_library_rust::String_::fromStr(&v484);
            let v486: u8 = u8::from_str_radix(&v485, 16).unwrap();
            let v487: colored::ColoredString =
                colored::Colorize::truecolor(&*v465.to_string(), v472, v479, v486);
            let v488: std::string::String = format!("{}", &v487);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v374, &v431, &v488)));
            {
                let v491: Result<std::fs::File, std::io::Error> =
                    std::fs::File::open(&v297);
                let v493: &std::fs::File = &v491.unwrap();
                let v495:
                        std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                    std::cell::RefCell::new(linereader::LineReader::new(&v493));
                let v501: Array<std::string::String> =
                    array(&[(&string("reader")).to_string(),
                            format!("{:?}", &v495)]);
                let v502 = core::ops::Deref::deref(&v501);
                let v504: std::string::String =
                    format!("{:?}", ***v502).clone();
                let v505: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v510: string =
                    Cli::method3(6i32,
                                 toString(&((&v505).timestamp() - v295)));
                let v511: u8 = rand::random::<u8>();
                let v524: Array<std::string::String> =
                    array(&[(&v99).to_string(), (&v510).to_string(),
                            (&v104).to_string(), format!("{:?}", &v511),
                            (&v109).to_string(), (&v112).to_string()]);
                let v525 = core::ops::Deref::deref(&v524);
                let v527: std::string::String =
                    format!("{:?}", ***v525).clone();
                let v530: Array<std::string::String> =
                    array(&[(&v332).to_string()]);
                let v531 = core::ops::Deref::deref(&v530);
                let v534: std::string::String =
                    format!("{:?}", ***v531).clone();
                let v535: string =
                    fable_library_rust::String_::fromStr(&v534);
                let v537: &str = r#""([^"]+)", "([^"]+)""#;
                let v538: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v537);
                let v539: &regex::Regex = &v538.build().unwrap();
                let v540: string = Cli::method2(v535);
                let v541: &str = &v540.as_str();
                let v542: string = Cli::method4();
                let v543: &str = &v542.as_str();
                let v544: std::string::String =
                    v539.replace_all(&v541, v543).to_string();
                let v545: string =
                    fable_library_rust::String_::fromStr(&v544);
                let v547: &str = r#"\["(.*?)"\]"#;
                let v548: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v547);
                let v549: &regex::Regex = &v548.build().unwrap();
                let v550: string = Cli::method2(v545);
                let v551: &str = &v550.as_str();
                let v552: string = Cli::method5();
                let v553: &str = &v552.as_str();
                let v554: std::string::String =
                    v549.replace_all(&v551, v553).to_string();
                let v555: string =
                    fable_library_rust::String_::fromStr(&v554);
                let v557: &str = r#", "#;
                let v558: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v557);
                let v559: &regex::Regex = &v558.build().unwrap();
                let v560: string = Cli::method2(v555);
                let v561: &str = &v560.as_str();
                let v562: string = Cli::method6();
                let v563: &str = &v562.as_str();
                let v564: std::string::String =
                    v559.replace_all(&v561, v563).to_string();
                let v565: string =
                    fable_library_rust::String_::fromStr(&v564);
                let v567: std::string::String = (&v565).to_string().clone();
                let v568: colored::ColoredString =
                    colored::Colorize::color(&*v567, v167.clone().to_string());
                let v569: std::string::String = format!("{}", &v568);
                let v571: string =
                    fable_library_rust::String_::fromStr(&&v504);
                let v573: &str = r#""([^"]+)", "([^"]+)""#;
                let v574: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v573);
                let v575: &regex::Regex = &v574.build().unwrap();
                let v576: string = Cli::method2(v571);
                let v577: &str = &v576.as_str();
                let v578: string = Cli::method4();
                let v579: &str = &v578.as_str();
                let v580: std::string::String =
                    v575.replace_all(&v577, v579).to_string();
                let v581: string =
                    fable_library_rust::String_::fromStr(&v580);
                let v583: &str = r#"\["(.*?)"\]"#;
                let v584: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v583);
                let v585: &regex::Regex = &v584.build().unwrap();
                let v586: string = Cli::method2(v581);
                let v587: &str = &v586.as_str();
                let v588: string = Cli::method5();
                let v589: &str = &v588.as_str();
                let v590: std::string::String =
                    v585.replace_all(&v587, v589).to_string();
                let v591: string =
                    fable_library_rust::String_::fromStr(&v590);
                let v593: &str = r#", "#;
                let v594: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v593);
                let v595: &regex::Regex = &v594.build().unwrap();
                let v596: string = Cli::method2(v591);
                let v597: &str = &v596.as_str();
                let v598: string = Cli::method6();
                let v599: &str = &v598.as_str();
                let v600: std::string::String =
                    v595.replace_all(&v597, v599).to_string();
                let v601: string =
                    fable_library_rust::String_::fromStr(&v600);
                let v603: std::string::String = (&v601).to_string().clone();
                let v604: string = Cli::method7();
                let v605: &str = &v604.as_str();
                let v608: &str = &v605[0i32 as usize..2i32 as usize];
                let v609: string =
                    fable_library_rust::String_::fromStr(&v608);
                let v610: u8 = u8::from_str_radix(&v609, 16).unwrap();
                let v611: string = Cli::method7();
                let v612: &str = &v611.as_str();
                let v615: &str = &v612[2i32 as usize..4i32 as usize];
                let v616: string =
                    fable_library_rust::String_::fromStr(&v615);
                let v617: u8 = u8::from_str_radix(&v616, 16).unwrap();
                let v618: string = Cli::method7();
                let v619: &str = &v618.as_str();
                let v622: &str = &v619[4i32 as usize..6i32 as usize];
                let v623: string =
                    fable_library_rust::String_::fromStr(&v622);
                let v624: u8 = u8::from_str_radix(&v623, 16).unwrap();
                let v625: colored::ColoredString =
                    colored::Colorize::truecolor(&*v603.to_string(), v610, v617, v624);
                let v626: std::string::String = format!("{}", &v625);
                let v628: string =
                    fable_library_rust::String_::fromStr(&&v527);
                let v630: &str = r#""([^"]+)", "([^"]+)""#;
                let v631: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v630);
                let v632: &regex::Regex = &v631.build().unwrap();
                let v633: string = Cli::method2(v628);
                let v634: &str = &v633.as_str();
                let v635: string = Cli::method4();
                let v636: &str = &v635.as_str();
                let v637: std::string::String =
                    v632.replace_all(&v634, v636).to_string();
                let v638: string =
                    fable_library_rust::String_::fromStr(&v637);
                let v640: &str = r#"\["(.*?)"\]"#;
                let v641: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v640);
                let v642: &regex::Regex = &v641.build().unwrap();
                let v643: string = Cli::method2(v638);
                let v644: &str = &v643.as_str();
                let v645: string = Cli::method5();
                let v646: &str = &v645.as_str();
                let v647: std::string::String =
                    v642.replace_all(&v644, v646).to_string();
                let v648: string =
                    fable_library_rust::String_::fromStr(&v647);
                let v650: &str = r#", "#;
                let v651: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v650);
                let v652: &regex::Regex = &v651.build().unwrap();
                let v653: string = Cli::method2(v648);
                let v654: &str = &v653.as_str();
                let v655: string = Cli::method6();
                let v656: &str = &v655.as_str();
                let v657: std::string::String =
                    v652.replace_all(&v654, v656).to_string();
                let v658: string =
                    fable_library_rust::String_::fromStr(&v657);
                let v660: std::string::String = (&v658).to_string().clone();
                let v661: string = Cli::method8();
                let v662: &str = &v661.as_str();
                let v665: &str = &v662[0i32 as usize..2i32 as usize];
                let v666: string =
                    fable_library_rust::String_::fromStr(&v665);
                let v667: u8 = u8::from_str_radix(&v666, 16).unwrap();
                let v668: string = Cli::method8();
                let v669: &str = &v668.as_str();
                let v672: &str = &v669[2i32 as usize..4i32 as usize];
                let v673: string =
                    fable_library_rust::String_::fromStr(&v672);
                let v674: u8 = u8::from_str_radix(&v673, 16).unwrap();
                let v675: string = Cli::method8();
                let v676: &str = &v675.as_str();
                let v679: &str = &v676[4i32 as usize..6i32 as usize];
                let v680: string =
                    fable_library_rust::String_::fromStr(&v679);
                let v681: u8 = u8::from_str_radix(&v680, 16).unwrap();
                let v682: colored::ColoredString =
                    colored::Colorize::truecolor(&*v660.to_string(), v667, v674, v681);
                let v683: std::string::String = format!("{}", &v682);
                println!("{0}",
                         stringFrom(format!("{0} {1} {2}", &v569, &v626, &v683)));
                {
                    let v686: Lrc<Cli::Mut0> =
                        Lrc::new(Cli::Mut0{l0:
                                               MutCell::new(Lrc::new(Cli::UH0::UH0_1)),});
                    let v687 = Cli::method9(v295, v686.clone());
                    let v689: Result<(), std::io::Error> =
                        (v495).borrow_mut().for_each(move |x| v687(x.to_vec()));
                    *((&v689).as_ref()).unwrap();
                    {
                        let v694: Lrc<Cli::UH1> =
                            Cli::method11(Cli::method10(v686.l0.get().clone(),
                                                        Lrc::new(Cli::UH0::UH0_1)),
                                          Lrc::new(Cli::UH1::UH1_1));
                        let v697: std::string::String =
                            (&string("lines len")).to_string().clone();
                        let v699: i32 = Cli::method12(v694.clone(), 0i32);
                        let v702: Array<std::string::String> =
                            array(&[v697, format!("{:?}", &v699)]);
                        let v703 = core::ops::Deref::deref(&v702);
                        let v705: std::string::String =
                            format!("{:?}", ***v703).clone();
                        let v706: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v711: string =
                            Cli::method3(6i32,
                                         toString(&((&v706).timestamp() -
                                                        v295)));
                        let v712: u8 = rand::random::<u8>();
                        let v725: Array<std::string::String> =
                            array(&[(&v99).to_string(), (&v711).to_string(),
                                    (&v104).to_string(),
                                    format!("{:?}", &v712),
                                    (&v109).to_string(),
                                    (&v112).to_string()]);
                        let v726 = core::ops::Deref::deref(&v725);
                        let v728: std::string::String =
                            format!("{:?}", ***v726).clone();
                        let v731: Array<std::string::String> =
                            array(&[(&v332).to_string()]);
                        let v732 = core::ops::Deref::deref(&v731);
                        let v735: std::string::String =
                            format!("{:?}", ***v732).clone();
                        let v736: string =
                            fable_library_rust::String_::fromStr(&v735);
                        let v738: &str = r#""([^"]+)", "([^"]+)""#;
                        let v739: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v738);
                        let v740: &regex::Regex = &v739.build().unwrap();
                        let v741: string = Cli::method2(v736);
                        let v742: &str = &v741.as_str();
                        let v743: string = Cli::method4();
                        let v744: &str = &v743.as_str();
                        let v745: std::string::String =
                            v740.replace_all(&v742, v744).to_string();
                        let v746: string =
                            fable_library_rust::String_::fromStr(&v745);
                        let v748: &str = r#"\["(.*?)"\]"#;
                        let v749: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v748);
                        let v750: &regex::Regex = &v749.build().unwrap();
                        let v751: string = Cli::method2(v746);
                        let v752: &str = &v751.as_str();
                        let v753: string = Cli::method5();
                        let v754: &str = &v753.as_str();
                        let v755: std::string::String =
                            v750.replace_all(&v752, v754).to_string();
                        let v756: string =
                            fable_library_rust::String_::fromStr(&v755);
                        let v758: &str = r#", "#;
                        let v759: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v758);
                        let v760: &regex::Regex = &v759.build().unwrap();
                        let v761: string = Cli::method2(v756);
                        let v762: &str = &v761.as_str();
                        let v763: string = Cli::method6();
                        let v764: &str = &v763.as_str();
                        let v765: std::string::String =
                            v760.replace_all(&v762, v764).to_string();
                        let v766: string =
                            fable_library_rust::String_::fromStr(&v765);
                        let v768: std::string::String =
                            (&v766).to_string().clone();
                        let v769: colored::ColoredString =
                            colored::Colorize::color(&*v768, v167.clone().to_string());
                        let v770: std::string::String = format!("{}", &v769);
                        let v772: string =
                            fable_library_rust::String_::fromStr(&&v705);
                        let v774: &str = r#""([^"]+)", "([^"]+)""#;
                        let v775: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v774);
                        let v776: &regex::Regex = &v775.build().unwrap();
                        let v777: string = Cli::method2(v772);
                        let v778: &str = &v777.as_str();
                        let v779: string = Cli::method4();
                        let v780: &str = &v779.as_str();
                        let v781: std::string::String =
                            v776.replace_all(&v778, v780).to_string();
                        let v782: string =
                            fable_library_rust::String_::fromStr(&v781);
                        let v784: &str = r#"\["(.*?)"\]"#;
                        let v785: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v784);
                        let v786: &regex::Regex = &v785.build().unwrap();
                        let v787: string = Cli::method2(v782);
                        let v788: &str = &v787.as_str();
                        let v789: string = Cli::method5();
                        let v790: &str = &v789.as_str();
                        let v791: std::string::String =
                            v786.replace_all(&v788, v790).to_string();
                        let v792: string =
                            fable_library_rust::String_::fromStr(&v791);
                        let v794: &str = r#", "#;
                        let v795: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v794);
                        let v796: &regex::Regex = &v795.build().unwrap();
                        let v797: string = Cli::method2(v792);
                        let v798: &str = &v797.as_str();
                        let v799: string = Cli::method6();
                        let v800: &str = &v799.as_str();
                        let v801: std::string::String =
                            v796.replace_all(&v798, v800).to_string();
                        let v802: string =
                            fable_library_rust::String_::fromStr(&v801);
                        let v804: std::string::String =
                            (&v802).to_string().clone();
                        let v805: string = Cli::method7();
                        let v806: &str = &v805.as_str();
                        let v809: &str = &v806[0i32 as usize..2i32 as usize];
                        let v810: string =
                            fable_library_rust::String_::fromStr(&v809);
                        let v811: u8 = u8::from_str_radix(&v810, 16).unwrap();
                        let v812: string = Cli::method7();
                        let v813: &str = &v812.as_str();
                        let v816: &str = &v813[2i32 as usize..4i32 as usize];
                        let v817: string =
                            fable_library_rust::String_::fromStr(&v816);
                        let v818: u8 = u8::from_str_radix(&v817, 16).unwrap();
                        let v819: string = Cli::method7();
                        let v820: &str = &v819.as_str();
                        let v823: &str = &v820[4i32 as usize..6i32 as usize];
                        let v824: string =
                            fable_library_rust::String_::fromStr(&v823);
                        let v825: u8 = u8::from_str_radix(&v824, 16).unwrap();
                        let v826: colored::ColoredString =
                            colored::Colorize::truecolor(&*v804.to_string(), v811, v818, v825);
                        let v827: std::string::String = format!("{}", &v826);
                        let v829: string =
                            fable_library_rust::String_::fromStr(&&v728);
                        let v831: &str = r#""([^"]+)", "([^"]+)""#;
                        let v832: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v831);
                        let v833: &regex::Regex = &v832.build().unwrap();
                        let v834: string = Cli::method2(v829);
                        let v835: &str = &v834.as_str();
                        let v836: string = Cli::method4();
                        let v837: &str = &v836.as_str();
                        let v838: std::string::String =
                            v833.replace_all(&v835, v837).to_string();
                        let v839: string =
                            fable_library_rust::String_::fromStr(&v838);
                        let v841: &str = r#"\["(.*?)"\]"#;
                        let v842: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v841);
                        let v843: &regex::Regex = &v842.build().unwrap();
                        let v844: string = Cli::method2(v839);
                        let v845: &str = &v844.as_str();
                        let v846: string = Cli::method5();
                        let v847: &str = &v846.as_str();
                        let v848: std::string::String =
                            v843.replace_all(&v845, v847).to_string();
                        let v849: string =
                            fable_library_rust::String_::fromStr(&v848);
                        let v851: &str = r#", "#;
                        let v852: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v851);
                        let v853: &regex::Regex = &v852.build().unwrap();
                        let v854: string = Cli::method2(v849);
                        let v855: &str = &v854.as_str();
                        let v856: string = Cli::method6();
                        let v857: &str = &v856.as_str();
                        let v858: std::string::String =
                            v853.replace_all(&v855, v857).to_string();
                        let v859: string =
                            fable_library_rust::String_::fromStr(&v858);
                        let v861: std::string::String =
                            (&v859).to_string().clone();
                        let v862: string = Cli::method8();
                        let v863: &str = &v862.as_str();
                        let v866: &str = &v863[0i32 as usize..2i32 as usize];
                        let v867: string =
                            fable_library_rust::String_::fromStr(&v866);
                        let v868: u8 = u8::from_str_radix(&v867, 16).unwrap();
                        let v869: string = Cli::method8();
                        let v870: &str = &v869.as_str();
                        let v873: &str = &v870[2i32 as usize..4i32 as usize];
                        let v874: string =
                            fable_library_rust::String_::fromStr(&v873);
                        let v875: u8 = u8::from_str_radix(&v874, 16).unwrap();
                        let v876: string = Cli::method8();
                        let v877: &str = &v876.as_str();
                        let v880: &str = &v877[4i32 as usize..6i32 as usize];
                        let v881: string =
                            fable_library_rust::String_::fromStr(&v880);
                        let v882: u8 = u8::from_str_radix(&v881, 16).unwrap();
                        let v883: colored::ColoredString =
                            colored::Colorize::truecolor(&*v861.to_string(), v868, v875, v882);
                        let v884: std::string::String = format!("{}", &v883);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v770, &v827, &v884)));
                        {
                            let v893: string =
                                Cli::method15(Cli::method14((Cli::method13(v7,
                                                                           v694,
                                                                           0i32,
                                                                           Lrc::new(Cli::UH1::UH1_1))).1.clone(),
                                                            Lrc::new(Cli::UH1::UH1_1)),
                                              string(""));
                            let v896: std::string::String =
                                (&string("text len")).to_string().clone();
                            let v898: i32 = (&v893).len().try_into().unwrap();
                            let v901: Array<std::string::String> =
                                array(&[v896, format!("{:?}", &v898)]);
                            let v902 = core::ops::Deref::deref(&v901);
                            let v904: std::string::String =
                                format!("{:?}", ***v902).clone();
                            let v905: chrono::DateTime<chrono::Utc> =
                                chrono::Utc::now();
                            let v910: string =
                                Cli::method3(6i32,
                                             toString(&((&v905).timestamp() -
                                                            v7)));
                            let v911: u8 = rand::random::<u8>();
                            let v924: Array<std::string::String> =
                                array(&[(&v99).to_string(),
                                        (&v910).to_string(),
                                        (&v104).to_string(),
                                        format!("{:?}", &v911),
                                        (&v109).to_string(),
                                        (&v112).to_string()]);
                            let v925 = core::ops::Deref::deref(&v924);
                            let v927: std::string::String =
                                format!("{:?}", ***v925).clone();
                            let v930: Array<std::string::String> =
                                array(&[(&v119).to_string()]);
                            let v931 = core::ops::Deref::deref(&v930);
                            let v934: std::string::String =
                                format!("{:?}", ***v931).clone();
                            let v935: string =
                                fable_library_rust::String_::fromStr(&v934);
                            let v937: &str = r#""([^"]+)", "([^"]+)""#;
                            let v938: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v937);
                            let v939: &regex::Regex = &v938.build().unwrap();
                            let v940: string = Cli::method2(v935);
                            let v941: &str = &v940.as_str();
                            let v942: string = Cli::method4();
                            let v943: &str = &v942.as_str();
                            let v944: std::string::String =
                                v939.replace_all(&v941, v943).to_string();
                            let v945: string =
                                fable_library_rust::String_::fromStr(&v944);
                            let v947: &str = r#"\["(.*?)"\]"#;
                            let v948: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v947);
                            let v949: &regex::Regex = &v948.build().unwrap();
                            let v950: string = Cli::method2(v945);
                            let v951: &str = &v950.as_str();
                            let v952: string = Cli::method5();
                            let v953: &str = &v952.as_str();
                            let v954: std::string::String =
                                v949.replace_all(&v951, v953).to_string();
                            let v955: string =
                                fable_library_rust::String_::fromStr(&v954);
                            let v957: &str = r#", "#;
                            let v958: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v957);
                            let v959: &regex::Regex = &v958.build().unwrap();
                            let v960: string = Cli::method2(v955);
                            let v961: &str = &v960.as_str();
                            let v962: string = Cli::method6();
                            let v963: &str = &v962.as_str();
                            let v964: std::string::String =
                                v959.replace_all(&v961, v963).to_string();
                            let v965: string =
                                fable_library_rust::String_::fromStr(&v964);
                            let v967: std::string::String =
                                (&v965).to_string().clone();
                            let v968: colored::ColoredString =
                                colored::Colorize::color(&*v967, v167.clone().to_string());
                            let v969: std::string::String =
                                format!("{}", &v968);
                            let v971: string =
                                fable_library_rust::String_::fromStr(&&v904);
                            let v973: &str = r#""([^"]+)", "([^"]+)""#;
                            let v974: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v973);
                            let v975: &regex::Regex = &v974.build().unwrap();
                            let v976: string = Cli::method2(v971);
                            let v977: &str = &v976.as_str();
                            let v978: string = Cli::method4();
                            let v979: &str = &v978.as_str();
                            let v980: std::string::String =
                                v975.replace_all(&v977, v979).to_string();
                            let v981: string =
                                fable_library_rust::String_::fromStr(&v980);
                            let v983: &str = r#"\["(.*?)"\]"#;
                            let v984: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v983);
                            let v985: &regex::Regex = &v984.build().unwrap();
                            let v986: string = Cli::method2(v981);
                            let v987: &str = &v986.as_str();
                            let v988: string = Cli::method5();
                            let v989: &str = &v988.as_str();
                            let v990: std::string::String =
                                v985.replace_all(&v987, v989).to_string();
                            let v991: string =
                                fable_library_rust::String_::fromStr(&v990);
                            let v993: &str = r#", "#;
                            let v994: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v993);
                            let v995: &regex::Regex = &v994.build().unwrap();
                            let v996: string = Cli::method2(v991);
                            let v997: &str = &v996.as_str();
                            let v998: string = Cli::method6();
                            let v999: &str = &v998.as_str();
                            let v1000: std::string::String =
                                v995.replace_all(&v997, v999).to_string();
                            let v1001: string =
                                fable_library_rust::String_::fromStr(&v1000);
                            let v1003: std::string::String =
                                (&v1001).to_string().clone();
                            let v1004: string = Cli::method7();
                            let v1005: &str = &v1004.as_str();
                            let v1008: &str =
                                &v1005[0i32 as usize..2i32 as usize];
                            let v1009: string =
                                fable_library_rust::String_::fromStr(&v1008);
                            let v1010: u8 =
                                u8::from_str_radix(&v1009, 16).unwrap();
                            let v1011: string = Cli::method7();
                            let v1012: &str = &v1011.as_str();
                            let v1015: &str =
                                &v1012[2i32 as usize..4i32 as usize];
                            let v1016: string =
                                fable_library_rust::String_::fromStr(&v1015);
                            let v1017: u8 =
                                u8::from_str_radix(&v1016, 16).unwrap();
                            let v1018: string = Cli::method7();
                            let v1019: &str = &v1018.as_str();
                            let v1022: &str =
                                &v1019[4i32 as usize..6i32 as usize];
                            let v1023: string =
                                fable_library_rust::String_::fromStr(&v1022);
                            let v1024: u8 =
                                u8::from_str_radix(&v1023, 16).unwrap();
                            let v1025: colored::ColoredString =
                                colored::Colorize::truecolor(&*v1003.to_string(), v1010, v1017, v1024);
                            let v1026: std::string::String =
                                format!("{}", &v1025);
                            let v1028: string =
                                fable_library_rust::String_::fromStr(&&v927);
                            let v1030: &str = r#""([^"]+)", "([^"]+)""#;
                            let v1031: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1030);
                            let v1032: &regex::Regex =
                                &v1031.build().unwrap();
                            let v1033: string = Cli::method2(v1028);
                            let v1034: &str = &v1033.as_str();
                            let v1035: string = Cli::method4();
                            let v1036: &str = &v1035.as_str();
                            let v1037: std::string::String =
                                v1032.replace_all(&v1034, v1036).to_string();
                            let v1038: string =
                                fable_library_rust::String_::fromStr(&v1037);
                            let v1040: &str = r#"\["(.*?)"\]"#;
                            let v1041: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1040);
                            let v1042: &regex::Regex =
                                &v1041.build().unwrap();
                            let v1043: string = Cli::method2(v1038);
                            let v1044: &str = &v1043.as_str();
                            let v1045: string = Cli::method5();
                            let v1046: &str = &v1045.as_str();
                            let v1047: std::string::String =
                                v1042.replace_all(&v1044, v1046).to_string();
                            let v1048: string =
                                fable_library_rust::String_::fromStr(&v1047);
                            let v1050: &str = r#", "#;
                            let v1051: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v1050);
                            let v1052: &regex::Regex =
                                &v1051.build().unwrap();
                            let v1053: string = Cli::method2(v1048);
                            let v1054: &str = &v1053.as_str();
                            let v1055: string = Cli::method6();
                            let v1056: &str = &v1055.as_str();
                            let v1057: std::string::String =
                                v1052.replace_all(&v1054, v1056).to_string();
                            let v1058: string =
                                fable_library_rust::String_::fromStr(&v1057);
                            let v1060: std::string::String =
                                (&v1058).to_string().clone();
                            let v1061: string = Cli::method8();
                            let v1062: &str = &v1061.as_str();
                            let v1065: &str =
                                &v1062[0i32 as usize..2i32 as usize];
                            let v1066: string =
                                fable_library_rust::String_::fromStr(&v1065);
                            let v1067: u8 =
                                u8::from_str_radix(&v1066, 16).unwrap();
                            let v1068: string = Cli::method8();
                            let v1069: &str = &v1068.as_str();
                            let v1072: &str =
                                &v1069[2i32 as usize..4i32 as usize];
                            let v1073: string =
                                fable_library_rust::String_::fromStr(&v1072);
                            let v1074: u8 =
                                u8::from_str_radix(&v1073, 16).unwrap();
                            let v1075: string = Cli::method8();
                            let v1076: &str = &v1075.as_str();
                            let v1079: &str =
                                &v1076[4i32 as usize..6i32 as usize];
                            let v1080: string =
                                fable_library_rust::String_::fromStr(&v1079);
                            let v1081: u8 =
                                u8::from_str_radix(&v1080, 16).unwrap();
                            let v1082: colored::ColoredString =
                                colored::Colorize::truecolor(&*v1060.to_string(), v1067, v1074, v1081);
                            let v1083: std::string::String =
                                format!("{}", &v1082);
                            println!("{0}",
                                     stringFrom(format!("{0} {1} {2}", &v969, &v1026, &v1083)));
                            {
                                let v1086: Result<(), std::io::Error> =
                                    std::fs::write(v77, v893.as_str());
                                *((&v1086).as_ref()).unwrap();
                                {
                                    let v1089: std::string::String =
                                        (&string("> fs_write rs_path_clean text; ok")).to_string().clone();
                                    let v1090: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v1095: string =
                                        Cli::method3(6i32,
                                                     toString(&((&v1090).timestamp()
                                                                    - v7)));
                                    let v1096: u8 = rand::random::<u8>();
                                    let v1109: Array<std::string::String> =
                                        array(&[(&v99).to_string(),
                                                (&v1095).to_string(),
                                                (&v104).to_string(),
                                                format!("{:?}", &v1096),
                                                (&v109).to_string(),
                                                (&v112).to_string()]);
                                    let v1110 =
                                        core::ops::Deref::deref(&v1109);
                                    let v1112: std::string::String =
                                        format!("{:?}", ***v1110).clone();
                                    let v1115: Array<std::string::String> =
                                        array(&[(&v119).to_string()]);
                                    let v1116 =
                                        core::ops::Deref::deref(&v1115);
                                    let v1119: std::string::String =
                                        format!("{:?}", ***v1116).clone();
                                    let v1120: string =
                                        fable_library_rust::String_::fromStr(&v1119);
                                    let v1122: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1123: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1122);
                                    let v1124: &regex::Regex =
                                        &v1123.build().unwrap();
                                    let v1125: string = Cli::method2(v1120);
                                    let v1126: &str = &v1125.as_str();
                                    let v1127: string = Cli::method4();
                                    let v1128: &str = &v1127.as_str();
                                    let v1129: std::string::String =
                                        v1124.replace_all(&v1126, v1128).to_string();
                                    let v1130: string =
                                        fable_library_rust::String_::fromStr(&v1129);
                                    let v1132: &str = r#"\["(.*?)"\]"#;
                                    let v1133: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1132);
                                    let v1134: &regex::Regex =
                                        &v1133.build().unwrap();
                                    let v1135: string = Cli::method2(v1130);
                                    let v1136: &str = &v1135.as_str();
                                    let v1137: string = Cli::method5();
                                    let v1138: &str = &v1137.as_str();
                                    let v1139: std::string::String =
                                        v1134.replace_all(&v1136, v1138).to_string();
                                    let v1140: string =
                                        fable_library_rust::String_::fromStr(&v1139);
                                    let v1142: &str = r#", "#;
                                    let v1143: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1142);
                                    let v1144: &regex::Regex =
                                        &v1143.build().unwrap();
                                    let v1145: string = Cli::method2(v1140);
                                    let v1146: &str = &v1145.as_str();
                                    let v1147: string = Cli::method6();
                                    let v1148: &str = &v1147.as_str();
                                    let v1149: std::string::String =
                                        v1144.replace_all(&v1146, v1148).to_string();
                                    let v1150: string =
                                        fable_library_rust::String_::fromStr(&v1149);
                                    let v1152: std::string::String =
                                        (&v1150).to_string().clone();
                                    let v1153: colored::ColoredString =
                                        colored::Colorize::color(&*v1152, v167.to_string());
                                    let v1154: std::string::String =
                                        format!("{}", &v1153);
                                    let v1156: string =
                                        fable_library_rust::String_::fromStr(&&v1089);
                                    let v1158: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1159: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1158);
                                    let v1160: &regex::Regex =
                                        &v1159.build().unwrap();
                                    let v1161: string = Cli::method2(v1156);
                                    let v1162: &str = &v1161.as_str();
                                    let v1163: string = Cli::method4();
                                    let v1164: &str = &v1163.as_str();
                                    let v1165: std::string::String =
                                        v1160.replace_all(&v1162, v1164).to_string();
                                    let v1166: string =
                                        fable_library_rust::String_::fromStr(&v1165);
                                    let v1168: &str = r#"\["(.*?)"\]"#;
                                    let v1169: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1168);
                                    let v1170: &regex::Regex =
                                        &v1169.build().unwrap();
                                    let v1171: string = Cli::method2(v1166);
                                    let v1172: &str = &v1171.as_str();
                                    let v1173: string = Cli::method5();
                                    let v1174: &str = &v1173.as_str();
                                    let v1175: std::string::String =
                                        v1170.replace_all(&v1172, v1174).to_string();
                                    let v1176: string =
                                        fable_library_rust::String_::fromStr(&v1175);
                                    let v1178: &str = r#", "#;
                                    let v1179: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1178);
                                    let v1180: &regex::Regex =
                                        &v1179.build().unwrap();
                                    let v1181: string = Cli::method2(v1176);
                                    let v1182: &str = &v1181.as_str();
                                    let v1183: string = Cli::method6();
                                    let v1184: &str = &v1183.as_str();
                                    let v1185: std::string::String =
                                        v1180.replace_all(&v1182, v1184).to_string();
                                    let v1186: string =
                                        fable_library_rust::String_::fromStr(&v1185);
                                    let v1188: std::string::String =
                                        (&v1186).to_string().clone();
                                    let v1189: string = Cli::method7();
                                    let v1190: &str = &v1189.as_str();
                                    let v1193: &str =
                                        &v1190[0i32 as usize..2i32 as usize];
                                    let v1194: string =
                                        fable_library_rust::String_::fromStr(&v1193);
                                    let v1195: u8 =
                                        u8::from_str_radix(&v1194, 16).unwrap();
                                    let v1196: string = Cli::method7();
                                    let v1197: &str = &v1196.as_str();
                                    let v1200: &str =
                                        &v1197[2i32 as usize..4i32 as usize];
                                    let v1201: string =
                                        fable_library_rust::String_::fromStr(&v1200);
                                    let v1202: u8 =
                                        u8::from_str_radix(&v1201, 16).unwrap();
                                    let v1203: string = Cli::method7();
                                    let v1204: &str = &v1203.as_str();
                                    let v1207: &str =
                                        &v1204[4i32 as usize..6i32 as usize];
                                    let v1208: string =
                                        fable_library_rust::String_::fromStr(&v1207);
                                    let v1209: u8 =
                                        u8::from_str_radix(&v1208, 16).unwrap();
                                    let v1210: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v1188.to_string(), v1195, v1202, v1209);
                                    let v1211: std::string::String =
                                        format!("{}", &v1210);
                                    let v1213: string =
                                        fable_library_rust::String_::fromStr(&&v1112);
                                    let v1215: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1216: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1215);
                                    let v1217: &regex::Regex =
                                        &v1216.build().unwrap();
                                    let v1218: string = Cli::method2(v1213);
                                    let v1219: &str = &v1218.as_str();
                                    let v1220: string = Cli::method4();
                                    let v1221: &str = &v1220.as_str();
                                    let v1222: std::string::String =
                                        v1217.replace_all(&v1219, v1221).to_string();
                                    let v1223: string =
                                        fable_library_rust::String_::fromStr(&v1222);
                                    let v1225: &str = r#"\["(.*?)"\]"#;
                                    let v1226: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1225);
                                    let v1227: &regex::Regex =
                                        &v1226.build().unwrap();
                                    let v1228: string = Cli::method2(v1223);
                                    let v1229: &str = &v1228.as_str();
                                    let v1230: string = Cli::method5();
                                    let v1231: &str = &v1230.as_str();
                                    let v1232: std::string::String =
                                        v1227.replace_all(&v1229, v1231).to_string();
                                    let v1233: string =
                                        fable_library_rust::String_::fromStr(&v1232);
                                    let v1235: &str = r#", "#;
                                    let v1236: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1235);
                                    let v1237: &regex::Regex =
                                        &v1236.build().unwrap();
                                    let v1238: string = Cli::method2(v1233);
                                    let v1239: &str = &v1238.as_str();
                                    let v1240: string = Cli::method6();
                                    let v1241: &str = &v1240.as_str();
                                    let v1242: std::string::String =
                                        v1237.replace_all(&v1239, v1241).to_string();
                                    let v1243: string =
                                        fable_library_rust::String_::fromStr(&v1242);
                                    let v1245: std::string::String =
                                        (&v1243).to_string().clone();
                                    let v1246: string = Cli::method8();
                                    let v1247: &str = &v1246.as_str();
                                    let v1250: &str =
                                        &v1247[0i32 as usize..2i32 as usize];
                                    let v1251: string =
                                        fable_library_rust::String_::fromStr(&v1250);
                                    let v1252: u8 =
                                        u8::from_str_radix(&v1251, 16).unwrap();
                                    let v1253: string = Cli::method8();
                                    let v1254: &str = &v1253.as_str();
                                    let v1257: &str =
                                        &v1254[2i32 as usize..4i32 as usize];
                                    let v1258: string =
                                        fable_library_rust::String_::fromStr(&v1257);
                                    let v1259: u8 =
                                        u8::from_str_radix(&v1258, 16).unwrap();
                                    let v1260: string = Cli::method8();
                                    let v1261: &str = &v1260.as_str();
                                    let v1264: &str =
                                        &v1261[4i32 as usize..6i32 as usize];
                                    let v1265: string =
                                        fable_library_rust::String_::fromStr(&v1264);
                                    let v1266: u8 =
                                        u8::from_str_radix(&v1265, 16).unwrap();
                                    let v1267: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v1245.to_string(), v1252, v1259, v1266);
                                    let v1268: std::string::String =
                                        format!("{}", &v1267);
                                    println!("{0}",
                                             stringFrom(format!("{0} {1} {2}", &v1154, &v1211, &v1268)));
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
