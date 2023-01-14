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
    use fable_library_rust::String_::substring2;
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
    pub fn method7(v0_1: i64, v1: Lrc<Cli::Mut0>)
     -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       move |v: Vec<u8>|
                           Cli::closure1(v0_1, v1.clone(), v.clone())
                   })
    }
    pub fn method8(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH0>) -> Lrc<Cli::UH0> {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v1.clone());
        '_method8:
            loop  {
                break '_method8
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH0> =
                                 Lrc::new(Cli::UH0::UH0_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method8
                         }
                     }) ;
            }
    }
    pub fn method9(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        match v0_1.as_ref() {
            Cli::UH0::UH0_1 => v1.clone(),
            Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                let v4: Lrc<Cli::UH1> = Cli::method9(v0_1_0_1.clone(), v1);
                Lrc::new(Cli::UH1::UH1_0(fable_library_rust::String_::fromStr(v0_1_0_0),
                                         v4))
            }
        }
    }
    pub fn method10(v0_1: Lrc<Cli::UH1>, v1: i32) -> i32 {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method10:
            loop  {
                break '_method10
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: i32 = v1.get() + 1i32;
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method10
                         }
                     }) ;
            }
    }
    pub fn method11(v0_1: Lrc<Cli::UH1>, v1: i32, v2: Lrc<Cli::UH1>)
     -> (i32, Lrc<Cli::UH1>) {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        let v2: MutCell<Lrc<Cli::UH1>> = MutCell::new(v2.clone());
        '_method11:
            loop  {
                break '_method11
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => (v1.get(), v2.get()),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v3: string = v0_1_0_0.clone();
                             let patternInput: (i32, Lrc<Cli::UH1>) =
                                 if ((&v3).clone()).contains(&*(&string("/node_modules/")).clone())
                                    {
                                     (1i32, v2.get())
                                 } else {
                                     if 0i32 == v1.get() {
                                         (0i32,
                                          Lrc::new(Cli::UH1::UH1_0(v3,
                                                                   v2.get())))
                                     } else {
                                         if 2i32 == v1.get() {
                                             (0i32, v2.get())
                                         } else {
                                             (v1.get() + 1i32, v2.get())
                                         }
                                     }
                                 };
                             {
                                 let v0_1_temp: Lrc<Cli::UH1> =
                                     v0_1_0_1.clone();
                                 let v1_temp: i32 = patternInput.0.clone();
                                 let v2_temp: Lrc<Cli::UH1> =
                                     patternInput.1.clone();
                                 v0_1.set(v0_1_temp);
                                 v1.set(v1_temp);
                                 v2.set(v2_temp);
                                 continue '_method11
                             }
                         }
                     }) ;
            }
    }
    pub fn method12(v0_1: Lrc<Cli::UH1>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        '_method12:
            loop  {
                break '_method12
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH1> =
                                 Lrc::new(Cli::UH1::UH1_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method12
                         }
                     }) ;
            }
    }
    pub fn method13(v0_1: Lrc<Cli::UH1>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method13:
            loop  {
                break '_method13
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: string =
                                 append(v1.get(), v0_1_0_0.clone());
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method13
                         }
                     }) ;
            }
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let patternInput: (string, string, string, bool) = Cli::method0();
        let v5: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v7: i64 = (&v5).timestamp();
        let v10: &str = r#"command"#;
        let v12: clap::builder::Command = clap::Command::new(&v10);
        let v15: &str = r#"rs-path"#;
        let v17: clap::builder::Arg = clap::Arg::new(&v15);
        let v19: clap::builder::Command = v12.arg(v17);
        let v21: &clap::parser::ArgMatches = &v19.get_matches();
        let v22: string = Cli::method1();
        let v24: &str = &v22.as_str();
        let v26: string = Cli::method2(string("--rs-path="));
        let v27: &str = &v26.as_str();
        let v29: &std::string::String =
            &(v21).get_one::<String>(v24).unwrap().replace(v27, "");
        let v31: std::path::PathBuf = std::path::PathBuf::from(&v29);
        let v33: Result<std::path::PathBuf, std::io::Error> =
            (&v31).canonicalize();
        let v35: std::path::PathBuf = (&v33).as_ref().unwrap().to_path_buf();
        let v43: Array<std::string::String> =
            array(&[(&string("rs_path_clean")).to_string(),
                    format!("{:?}", &v35)]);
        let v45 = core::ops::Deref::deref(&v43);
        let v48: std::string::String = format!("{:?}", ***v45).clone();
        let v49: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v54: string =
            Cli::method3(6i32, toString(&((&v49).timestamp() - v7)));
        let v56: u8 = rand::random::<u8>();
        let v57: string = string("timestamp");
        let v62: string = string("run_id");
        let v67: string = string("log_level");
        let v70: string = string("Debug");
        let v73: Array<std::string::String> =
            array(&[(&v57).to_string(), (&v54).to_string(),
                    (&v62).to_string(), format!("{:?}", &v56),
                    (&v67).to_string(), (&v70).to_string()]);
        let v74 = core::ops::Deref::deref(&v73);
        let v76: std::string::String = format!("{:?}", ***v74).clone();
        let v77: string = string("> app ()");
        let v80: Array<std::string::String> = array(&[(&v77).to_string()]);
        let v81 = core::ops::Deref::deref(&v80);
        let v84: std::string::String = format!("{:?}", ***v81).clone();
        let v86: string = fable_library_rust::String_::fromStr(&v84);
        let v89: &str = r#""([^"]+)", "([^"]+)""#;
        let v91: regex::RegexBuilder = regex::RegexBuilder::new(&v89);
        let v93: &regex::Regex = &v91.build().unwrap();
        let v94: string = Cli::method2(v86);
        let v95: &str = &v94.as_str();
        let v96: string = Cli::method4();
        let v97: &str = &v96.as_str();
        let v99: std::string::String = v93.replace_all(&v95, v97).to_string();
        let v100: string = fable_library_rust::String_::fromStr(&v99);
        let v103: &str = r#"\["(.*?)"\]"#;
        let v104: regex::RegexBuilder = regex::RegexBuilder::new(&v103);
        let v105: &regex::Regex = &v104.build().unwrap();
        let v106: string = Cli::method2(v100);
        let v107: &str = &v106.as_str();
        let v108: string = Cli::method5();
        let v109: &str = &v108.as_str();
        let v110: std::string::String =
            v105.replace_all(&v107, v109).to_string();
        let v111: string = fable_library_rust::String_::fromStr(&v110);
        let v114: &str = r#", "#;
        let v115: regex::RegexBuilder = regex::RegexBuilder::new(&v114);
        let v116: &regex::Regex = &v115.build().unwrap();
        let v117: string = Cli::method2(v111);
        let v118: &str = &v117.as_str();
        let v119: string = Cli::method6();
        let v120: &str = &v119.as_str();
        let v121: std::string::String =
            v116.replace_all(&v118, v120).to_string();
        let v122: string = fable_library_rust::String_::fromStr(&v121);
        let v124: std::string::String = (&v122).to_string().clone();
        let v125: string = string("purple");
        let v127: colored::ColoredString =
            colored::Colorize::color(&*v124, v125.clone().to_string());
        let v129: std::string::String = format!("{}", &v127);
        let v131: string = fable_library_rust::String_::fromStr(&&v48);
        let v133: &str = r#""([^"]+)", "([^"]+)""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method2(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Cli::method4();
        let v139: &str = &v138.as_str();
        let v140: std::string::String =
            v135.replace_all(&v137, v139).to_string();
        let v141: string = fable_library_rust::String_::fromStr(&v140);
        let v143: &str = r#"\["(.*?)"\]"#;
        let v144: regex::RegexBuilder = regex::RegexBuilder::new(&v143);
        let v145: &regex::Regex = &v144.build().unwrap();
        let v146: string = Cli::method2(v141);
        let v147: &str = &v146.as_str();
        let v148: string = Cli::method5();
        let v149: &str = &v148.as_str();
        let v150: std::string::String =
            v145.replace_all(&v147, v149).to_string();
        let v151: string = fable_library_rust::String_::fromStr(&v150);
        let v153: &str = r#", "#;
        let v154: regex::RegexBuilder = regex::RegexBuilder::new(&v153);
        let v155: &regex::Regex = &v154.build().unwrap();
        let v156: string = Cli::method2(v151);
        let v157: &str = &v156.as_str();
        let v158: string = Cli::method6();
        let v159: &str = &v158.as_str();
        let v160: std::string::String =
            v155.replace_all(&v157, v159).to_string();
        let v161: string = fable_library_rust::String_::fromStr(&v160);
        let v163: std::string::String = (&v161).to_string().clone();
        let v164: string = string("666666");
        let v165: string = substring2(v164.clone(), 0i32, 2i32);
        let v167: u8 = u8::from_str_radix(&v165, 16).unwrap();
        let v168: string = substring2(v164.clone(), 2i32, 2i32);
        let v169: u8 = u8::from_str_radix(&v168, 16).unwrap();
        let v170: string = substring2(v164.clone(), 4i32, 2i32);
        let v171: u8 = u8::from_str_radix(&v170, 16).unwrap();
        let v173: colored::ColoredString =
            colored::Colorize::truecolor(&*v163.to_string(), v167, v169, v171);
        let v174: std::string::String = format!("{}", &v173);
        let v176: string = fable_library_rust::String_::fromStr(&&v76);
        let v178: &str = r#""([^"]+)", "([^"]+)""#;
        let v179: regex::RegexBuilder = regex::RegexBuilder::new(&v178);
        let v180: &regex::Regex = &v179.build().unwrap();
        let v181: string = Cli::method2(v176);
        let v182: &str = &v181.as_str();
        let v183: string = Cli::method4();
        let v184: &str = &v183.as_str();
        let v185: std::string::String =
            v180.replace_all(&v182, v184).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v185);
        let v188: &str = r#"\["(.*?)"\]"#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method2(v186);
        let v192: &str = &v191.as_str();
        let v193: string = Cli::method5();
        let v194: &str = &v193.as_str();
        let v195: std::string::String =
            v190.replace_all(&v192, v194).to_string();
        let v196: string = fable_library_rust::String_::fromStr(&v195);
        let v198: &str = r#", "#;
        let v199: regex::RegexBuilder = regex::RegexBuilder::new(&v198);
        let v200: &regex::Regex = &v199.build().unwrap();
        let v201: string = Cli::method2(v196);
        let v202: &str = &v201.as_str();
        let v203: string = Cli::method6();
        let v204: &str = &v203.as_str();
        let v205: std::string::String =
            v200.replace_all(&v202, v204).to_string();
        let v206: string = fable_library_rust::String_::fromStr(&v205);
        let v208: std::string::String = (&v206).to_string().clone();
        let v209: string = string("222222");
        let v210: string = substring2(v209.clone(), 0i32, 2i32);
        let v211: u8 = u8::from_str_radix(&v210, 16).unwrap();
        let v212: string = substring2(v209.clone(), 2i32, 2i32);
        let v213: u8 = u8::from_str_radix(&v212, 16).unwrap();
        let v214: string = substring2(v209.clone(), 4i32, 2i32);
        let v215: u8 = u8::from_str_radix(&v214, 16).unwrap();
        let v216: colored::ColoredString =
            colored::Colorize::truecolor(&*v208.to_string(), v211, v213, v215);
        let v217: std::string::String = format!("{}", &v216);
        println!("{0}",
                 stringFrom(format!("{0} {1} {2}", &v129, &v174, &v217)));
        {
            let patternInput_1: (string, string, string, bool) =
                Cli::method0();
            let v223: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v224: i64 = (&v223).timestamp();
            let v225: Result<std::path::PathBuf, std::io::Error> =
                (&v35).canonicalize();
            let v226: std::path::PathBuf =
                (&v225).as_ref().unwrap().to_path_buf();
            let v229: std::string::String =
                (&string("path_clean")).to_string().clone();
            let v231: string =
                fable_library_rust::String_::fromStr(&format!("{}", &v226.display()));
            let v234: Array<std::string::String> =
                array(&[v229, (&v231).to_string()]);
            let v235 = core::ops::Deref::deref(&v234);
            let v237: std::string::String = format!("{:?}", ***v235).clone();
            let v238: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v243: string =
                Cli::method3(6i32, toString(&((&v238).timestamp() - v224)));
            let v244: u8 = rand::random::<u8>();
            let v257: Array<std::string::String> =
                array(&[(&v57).to_string(), (&v243).to_string(),
                        (&v62).to_string(), format!("{:?}", &v244),
                        (&v67).to_string(), (&v70).to_string()]);
            let v258 = core::ops::Deref::deref(&v257);
            let v260: std::string::String = format!("{:?}", ***v258).clone();
            let v261: string = string("> read_lines ()");
            let v264: Array<std::string::String> =
                array(&[(&v261).to_string()]);
            let v265 = core::ops::Deref::deref(&v264);
            let v268: std::string::String = format!("{:?}", ***v265).clone();
            let v269: string = fable_library_rust::String_::fromStr(&v268);
            let v271: &str = r#""([^"]+)", "([^"]+)""#;
            let v272: regex::RegexBuilder = regex::RegexBuilder::new(&v271);
            let v273: &regex::Regex = &v272.build().unwrap();
            let v274: string = Cli::method2(v269);
            let v275: &str = &v274.as_str();
            let v276: string = Cli::method4();
            let v277: &str = &v276.as_str();
            let v278: std::string::String =
                v273.replace_all(&v275, v277).to_string();
            let v279: string = fable_library_rust::String_::fromStr(&v278);
            let v281: &str = r#"\["(.*?)"\]"#;
            let v282: regex::RegexBuilder = regex::RegexBuilder::new(&v281);
            let v283: &regex::Regex = &v282.build().unwrap();
            let v284: string = Cli::method2(v279);
            let v285: &str = &v284.as_str();
            let v286: string = Cli::method5();
            let v287: &str = &v286.as_str();
            let v288: std::string::String =
                v283.replace_all(&v285, v287).to_string();
            let v289: string = fable_library_rust::String_::fromStr(&v288);
            let v291: &str = r#", "#;
            let v292: regex::RegexBuilder = regex::RegexBuilder::new(&v291);
            let v293: &regex::Regex = &v292.build().unwrap();
            let v294: string = Cli::method2(v289);
            let v295: &str = &v294.as_str();
            let v296: string = Cli::method6();
            let v297: &str = &v296.as_str();
            let v298: std::string::String =
                v293.replace_all(&v295, v297).to_string();
            let v299: string = fable_library_rust::String_::fromStr(&v298);
            let v301: std::string::String = (&v299).to_string().clone();
            let v302: colored::ColoredString =
                colored::Colorize::color(&*v301, v125.clone().to_string());
            let v303: std::string::String = format!("{}", &v302);
            let v305: string = fable_library_rust::String_::fromStr(&&v237);
            let v307: &str = r#""([^"]+)", "([^"]+)""#;
            let v308: regex::RegexBuilder = regex::RegexBuilder::new(&v307);
            let v309: &regex::Regex = &v308.build().unwrap();
            let v310: string = Cli::method2(v305);
            let v311: &str = &v310.as_str();
            let v312: string = Cli::method4();
            let v313: &str = &v312.as_str();
            let v314: std::string::String =
                v309.replace_all(&v311, v313).to_string();
            let v315: string = fable_library_rust::String_::fromStr(&v314);
            let v317: &str = r#"\["(.*?)"\]"#;
            let v318: regex::RegexBuilder = regex::RegexBuilder::new(&v317);
            let v319: &regex::Regex = &v318.build().unwrap();
            let v320: string = Cli::method2(v315);
            let v321: &str = &v320.as_str();
            let v322: string = Cli::method5();
            let v323: &str = &v322.as_str();
            let v324: std::string::String =
                v319.replace_all(&v321, v323).to_string();
            let v325: string = fable_library_rust::String_::fromStr(&v324);
            let v327: &str = r#", "#;
            let v328: regex::RegexBuilder = regex::RegexBuilder::new(&v327);
            let v329: &regex::Regex = &v328.build().unwrap();
            let v330: string = Cli::method2(v325);
            let v331: &str = &v330.as_str();
            let v332: string = Cli::method6();
            let v333: &str = &v332.as_str();
            let v334: std::string::String =
                v329.replace_all(&v331, v333).to_string();
            let v335: string = fable_library_rust::String_::fromStr(&v334);
            let v337: std::string::String = (&v335).to_string().clone();
            let v338: string = substring2(v164.clone(), 0i32, 2i32);
            let v339: u8 = u8::from_str_radix(&v338, 16).unwrap();
            let v340: string = substring2(v164.clone(), 2i32, 2i32);
            let v341: u8 = u8::from_str_radix(&v340, 16).unwrap();
            let v342: string = substring2(v164.clone(), 4i32, 2i32);
            let v343: u8 = u8::from_str_radix(&v342, 16).unwrap();
            let v344: colored::ColoredString =
                colored::Colorize::truecolor(&*v337.to_string(), v339, v341, v343);
            let v345: std::string::String = format!("{}", &v344);
            let v347: string = fable_library_rust::String_::fromStr(&&v260);
            let v349: &str = r#""([^"]+)", "([^"]+)""#;
            let v350: regex::RegexBuilder = regex::RegexBuilder::new(&v349);
            let v351: &regex::Regex = &v350.build().unwrap();
            let v352: string = Cli::method2(v347);
            let v353: &str = &v352.as_str();
            let v354: string = Cli::method4();
            let v355: &str = &v354.as_str();
            let v356: std::string::String =
                v351.replace_all(&v353, v355).to_string();
            let v357: string = fable_library_rust::String_::fromStr(&v356);
            let v359: &str = r#"\["(.*?)"\]"#;
            let v360: regex::RegexBuilder = regex::RegexBuilder::new(&v359);
            let v361: &regex::Regex = &v360.build().unwrap();
            let v362: string = Cli::method2(v357);
            let v363: &str = &v362.as_str();
            let v364: string = Cli::method5();
            let v365: &str = &v364.as_str();
            let v366: std::string::String =
                v361.replace_all(&v363, v365).to_string();
            let v367: string = fable_library_rust::String_::fromStr(&v366);
            let v369: &str = r#", "#;
            let v370: regex::RegexBuilder = regex::RegexBuilder::new(&v369);
            let v371: &regex::Regex = &v370.build().unwrap();
            let v372: string = Cli::method2(v367);
            let v373: &str = &v372.as_str();
            let v374: string = Cli::method6();
            let v375: &str = &v374.as_str();
            let v376: std::string::String =
                v371.replace_all(&v373, v375).to_string();
            let v377: string = fable_library_rust::String_::fromStr(&v376);
            let v379: std::string::String = (&v377).to_string().clone();
            let v380: string = substring2(v209.clone(), 0i32, 2i32);
            let v381: u8 = u8::from_str_radix(&v380, 16).unwrap();
            let v382: string = substring2(v209.clone(), 2i32, 2i32);
            let v383: u8 = u8::from_str_radix(&v382, 16).unwrap();
            let v384: string = substring2(v209.clone(), 4i32, 2i32);
            let v385: u8 = u8::from_str_radix(&v384, 16).unwrap();
            let v386: colored::ColoredString =
                colored::Colorize::truecolor(&*v379.to_string(), v381, v383, v385);
            let v387: std::string::String = format!("{}", &v386);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v303, &v345, &v387)));
            {
                let v390: Result<std::fs::File, std::io::Error> =
                    std::fs::File::open(&v226);
                let v392: &std::fs::File = &v390.unwrap();
                let v394:
                        std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                    std::cell::RefCell::new(linereader::LineReader::new(&v392));
                let v400: Array<std::string::String> =
                    array(&[(&string("reader")).to_string(),
                            format!("{:?}", &v394)]);
                let v401 = core::ops::Deref::deref(&v400);
                let v403: std::string::String =
                    format!("{:?}", ***v401).clone();
                let v404: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v409: string =
                    Cli::method3(6i32,
                                 toString(&((&v404).timestamp() - v224)));
                let v410: u8 = rand::random::<u8>();
                let v423: Array<std::string::String> =
                    array(&[(&v57).to_string(), (&v409).to_string(),
                            (&v62).to_string(), format!("{:?}", &v410),
                            (&v67).to_string(), (&v70).to_string()]);
                let v424 = core::ops::Deref::deref(&v423);
                let v426: std::string::String =
                    format!("{:?}", ***v424).clone();
                let v429: Array<std::string::String> =
                    array(&[(&v261).to_string()]);
                let v430 = core::ops::Deref::deref(&v429);
                let v433: std::string::String =
                    format!("{:?}", ***v430).clone();
                let v434: string =
                    fable_library_rust::String_::fromStr(&v433);
                let v436: &str = r#""([^"]+)", "([^"]+)""#;
                let v437: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v436);
                let v438: &regex::Regex = &v437.build().unwrap();
                let v439: string = Cli::method2(v434);
                let v440: &str = &v439.as_str();
                let v441: string = Cli::method4();
                let v442: &str = &v441.as_str();
                let v443: std::string::String =
                    v438.replace_all(&v440, v442).to_string();
                let v444: string =
                    fable_library_rust::String_::fromStr(&v443);
                let v446: &str = r#"\["(.*?)"\]"#;
                let v447: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v446);
                let v448: &regex::Regex = &v447.build().unwrap();
                let v449: string = Cli::method2(v444);
                let v450: &str = &v449.as_str();
                let v451: string = Cli::method5();
                let v452: &str = &v451.as_str();
                let v453: std::string::String =
                    v448.replace_all(&v450, v452).to_string();
                let v454: string =
                    fable_library_rust::String_::fromStr(&v453);
                let v456: &str = r#", "#;
                let v457: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v456);
                let v458: &regex::Regex = &v457.build().unwrap();
                let v459: string = Cli::method2(v454);
                let v460: &str = &v459.as_str();
                let v461: string = Cli::method6();
                let v462: &str = &v461.as_str();
                let v463: std::string::String =
                    v458.replace_all(&v460, v462).to_string();
                let v464: string =
                    fable_library_rust::String_::fromStr(&v463);
                let v466: std::string::String = (&v464).to_string().clone();
                let v467: colored::ColoredString =
                    colored::Colorize::color(&*v466, v125.clone().to_string());
                let v468: std::string::String = format!("{}", &v467);
                let v470: string =
                    fable_library_rust::String_::fromStr(&&v403);
                let v472: &str = r#""([^"]+)", "([^"]+)""#;
                let v473: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v472);
                let v474: &regex::Regex = &v473.build().unwrap();
                let v475: string = Cli::method2(v470);
                let v476: &str = &v475.as_str();
                let v477: string = Cli::method4();
                let v478: &str = &v477.as_str();
                let v479: std::string::String =
                    v474.replace_all(&v476, v478).to_string();
                let v480: string =
                    fable_library_rust::String_::fromStr(&v479);
                let v482: &str = r#"\["(.*?)"\]"#;
                let v483: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v482);
                let v484: &regex::Regex = &v483.build().unwrap();
                let v485: string = Cli::method2(v480);
                let v486: &str = &v485.as_str();
                let v487: string = Cli::method5();
                let v488: &str = &v487.as_str();
                let v489: std::string::String =
                    v484.replace_all(&v486, v488).to_string();
                let v490: string =
                    fable_library_rust::String_::fromStr(&v489);
                let v492: &str = r#", "#;
                let v493: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v492);
                let v494: &regex::Regex = &v493.build().unwrap();
                let v495: string = Cli::method2(v490);
                let v496: &str = &v495.as_str();
                let v497: string = Cli::method6();
                let v498: &str = &v497.as_str();
                let v499: std::string::String =
                    v494.replace_all(&v496, v498).to_string();
                let v500: string =
                    fable_library_rust::String_::fromStr(&v499);
                let v502: std::string::String = (&v500).to_string().clone();
                let v503: string = substring2(v164.clone(), 0i32, 2i32);
                let v504: u8 = u8::from_str_radix(&v503, 16).unwrap();
                let v505: string = substring2(v164.clone(), 2i32, 2i32);
                let v506: u8 = u8::from_str_radix(&v505, 16).unwrap();
                let v507: string = substring2(v164.clone(), 4i32, 2i32);
                let v508: u8 = u8::from_str_radix(&v507, 16).unwrap();
                let v509: colored::ColoredString =
                    colored::Colorize::truecolor(&*v502.to_string(), v504, v506, v508);
                let v510: std::string::String = format!("{}", &v509);
                let v512: string =
                    fable_library_rust::String_::fromStr(&&v426);
                let v514: &str = r#""([^"]+)", "([^"]+)""#;
                let v515: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v514);
                let v516: &regex::Regex = &v515.build().unwrap();
                let v517: string = Cli::method2(v512);
                let v518: &str = &v517.as_str();
                let v519: string = Cli::method4();
                let v520: &str = &v519.as_str();
                let v521: std::string::String =
                    v516.replace_all(&v518, v520).to_string();
                let v522: string =
                    fable_library_rust::String_::fromStr(&v521);
                let v524: &str = r#"\["(.*?)"\]"#;
                let v525: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v524);
                let v526: &regex::Regex = &v525.build().unwrap();
                let v527: string = Cli::method2(v522);
                let v528: &str = &v527.as_str();
                let v529: string = Cli::method5();
                let v530: &str = &v529.as_str();
                let v531: std::string::String =
                    v526.replace_all(&v528, v530).to_string();
                let v532: string =
                    fable_library_rust::String_::fromStr(&v531);
                let v534: &str = r#", "#;
                let v535: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v534);
                let v536: &regex::Regex = &v535.build().unwrap();
                let v537: string = Cli::method2(v532);
                let v538: &str = &v537.as_str();
                let v539: string = Cli::method6();
                let v540: &str = &v539.as_str();
                let v541: std::string::String =
                    v536.replace_all(&v538, v540).to_string();
                let v542: string =
                    fable_library_rust::String_::fromStr(&v541);
                let v544: std::string::String = (&v542).to_string().clone();
                let v545: string = substring2(v209.clone(), 0i32, 2i32);
                let v546: u8 = u8::from_str_radix(&v545, 16).unwrap();
                let v547: string = substring2(v209.clone(), 2i32, 2i32);
                let v548: u8 = u8::from_str_radix(&v547, 16).unwrap();
                let v549: string = substring2(v209.clone(), 4i32, 2i32);
                let v550: u8 = u8::from_str_radix(&v549, 16).unwrap();
                let v551: colored::ColoredString =
                    colored::Colorize::truecolor(&*v544.to_string(), v546, v548, v550);
                let v552: std::string::String = format!("{}", &v551);
                println!("{0}",
                         stringFrom(format!("{0} {1} {2}", &v468, &v510, &v552)));
                {
                    let v555: Lrc<Cli::Mut0> =
                        Lrc::new(Cli::Mut0{l0:
                                               MutCell::new(Lrc::new(Cli::UH0::UH0_1)),});
                    let v556 = Cli::method7(v224, v555.clone());
                    let v558: Result<(), std::io::Error> =
                        (v394).borrow_mut().for_each(move |x| v556(x.to_vec()));
                    *((&v558).as_ref()).unwrap();
                    {
                        let v564: Lrc<Cli::UH1> =
                            Cli::method9(Cli::method8(v555.l0.get().clone(),
                                                      Lrc::new(Cli::UH0::UH0_1)),
                                         Lrc::new(Cli::UH1::UH1_1));
                        let v567: std::string::String =
                            (&string("lines len")).to_string().clone();
                        let v569: i32 = Cli::method10(v564.clone(), 0i32);
                        let v572: Array<std::string::String> =
                            array(&[v567, format!("{:?}", &v569)]);
                        let v573 = core::ops::Deref::deref(&v572);
                        let v575: std::string::String =
                            format!("{:?}", ***v573).clone();
                        let v576: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v581: string =
                            Cli::method3(6i32,
                                         toString(&((&v576).timestamp() -
                                                        v224)));
                        let v582: u8 = rand::random::<u8>();
                        let v595: Array<std::string::String> =
                            array(&[(&v57).to_string(), (&v581).to_string(),
                                    (&v62).to_string(),
                                    format!("{:?}", &v582),
                                    (&v67).to_string(), (&v70).to_string()]);
                        let v596 = core::ops::Deref::deref(&v595);
                        let v598: std::string::String =
                            format!("{:?}", ***v596).clone();
                        let v601: Array<std::string::String> =
                            array(&[(&v261).to_string()]);
                        let v602 = core::ops::Deref::deref(&v601);
                        let v605: std::string::String =
                            format!("{:?}", ***v602).clone();
                        let v606: string =
                            fable_library_rust::String_::fromStr(&v605);
                        let v608: &str = r#""([^"]+)", "([^"]+)""#;
                        let v609: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v608);
                        let v610: &regex::Regex = &v609.build().unwrap();
                        let v611: string = Cli::method2(v606);
                        let v612: &str = &v611.as_str();
                        let v613: string = Cli::method4();
                        let v614: &str = &v613.as_str();
                        let v615: std::string::String =
                            v610.replace_all(&v612, v614).to_string();
                        let v616: string =
                            fable_library_rust::String_::fromStr(&v615);
                        let v618: &str = r#"\["(.*?)"\]"#;
                        let v619: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v618);
                        let v620: &regex::Regex = &v619.build().unwrap();
                        let v621: string = Cli::method2(v616);
                        let v622: &str = &v621.as_str();
                        let v623: string = Cli::method5();
                        let v624: &str = &v623.as_str();
                        let v625: std::string::String =
                            v620.replace_all(&v622, v624).to_string();
                        let v626: string =
                            fable_library_rust::String_::fromStr(&v625);
                        let v628: &str = r#", "#;
                        let v629: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v628);
                        let v630: &regex::Regex = &v629.build().unwrap();
                        let v631: string = Cli::method2(v626);
                        let v632: &str = &v631.as_str();
                        let v633: string = Cli::method6();
                        let v634: &str = &v633.as_str();
                        let v635: std::string::String =
                            v630.replace_all(&v632, v634).to_string();
                        let v636: string =
                            fable_library_rust::String_::fromStr(&v635);
                        let v638: std::string::String =
                            (&v636).to_string().clone();
                        let v639: colored::ColoredString =
                            colored::Colorize::color(&*v638, v125.clone().to_string());
                        let v640: std::string::String = format!("{}", &v639);
                        let v642: string =
                            fable_library_rust::String_::fromStr(&&v575);
                        let v644: &str = r#""([^"]+)", "([^"]+)""#;
                        let v645: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v644);
                        let v646: &regex::Regex = &v645.build().unwrap();
                        let v647: string = Cli::method2(v642);
                        let v648: &str = &v647.as_str();
                        let v649: string = Cli::method4();
                        let v650: &str = &v649.as_str();
                        let v651: std::string::String =
                            v646.replace_all(&v648, v650).to_string();
                        let v652: string =
                            fable_library_rust::String_::fromStr(&v651);
                        let v654: &str = r#"\["(.*?)"\]"#;
                        let v655: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v654);
                        let v656: &regex::Regex = &v655.build().unwrap();
                        let v657: string = Cli::method2(v652);
                        let v658: &str = &v657.as_str();
                        let v659: string = Cli::method5();
                        let v660: &str = &v659.as_str();
                        let v661: std::string::String =
                            v656.replace_all(&v658, v660).to_string();
                        let v662: string =
                            fable_library_rust::String_::fromStr(&v661);
                        let v664: &str = r#", "#;
                        let v665: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v664);
                        let v666: &regex::Regex = &v665.build().unwrap();
                        let v667: string = Cli::method2(v662);
                        let v668: &str = &v667.as_str();
                        let v669: string = Cli::method6();
                        let v670: &str = &v669.as_str();
                        let v671: std::string::String =
                            v666.replace_all(&v668, v670).to_string();
                        let v672: string =
                            fable_library_rust::String_::fromStr(&v671);
                        let v674: std::string::String =
                            (&v672).to_string().clone();
                        let v675: string =
                            substring2(v164.clone(), 0i32, 2i32);
                        let v676: u8 = u8::from_str_radix(&v675, 16).unwrap();
                        let v677: string =
                            substring2(v164.clone(), 2i32, 2i32);
                        let v678: u8 = u8::from_str_radix(&v677, 16).unwrap();
                        let v679: string =
                            substring2(v164.clone(), 4i32, 2i32);
                        let v680: u8 = u8::from_str_radix(&v679, 16).unwrap();
                        let v681: colored::ColoredString =
                            colored::Colorize::truecolor(&*v674.to_string(), v676, v678, v680);
                        let v682: std::string::String = format!("{}", &v681);
                        let v684: string =
                            fable_library_rust::String_::fromStr(&&v598);
                        let v686: &str = r#""([^"]+)", "([^"]+)""#;
                        let v687: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v686);
                        let v688: &regex::Regex = &v687.build().unwrap();
                        let v689: string = Cli::method2(v684);
                        let v690: &str = &v689.as_str();
                        let v691: string = Cli::method4();
                        let v692: &str = &v691.as_str();
                        let v693: std::string::String =
                            v688.replace_all(&v690, v692).to_string();
                        let v694: string =
                            fable_library_rust::String_::fromStr(&v693);
                        let v696: &str = r#"\["(.*?)"\]"#;
                        let v697: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v696);
                        let v698: &regex::Regex = &v697.build().unwrap();
                        let v699: string = Cli::method2(v694);
                        let v700: &str = &v699.as_str();
                        let v701: string = Cli::method5();
                        let v702: &str = &v701.as_str();
                        let v703: std::string::String =
                            v698.replace_all(&v700, v702).to_string();
                        let v704: string =
                            fable_library_rust::String_::fromStr(&v703);
                        let v706: &str = r#", "#;
                        let v707: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v706);
                        let v708: &regex::Regex = &v707.build().unwrap();
                        let v709: string = Cli::method2(v704);
                        let v710: &str = &v709.as_str();
                        let v711: string = Cli::method6();
                        let v712: &str = &v711.as_str();
                        let v713: std::string::String =
                            v708.replace_all(&v710, v712).to_string();
                        let v714: string =
                            fable_library_rust::String_::fromStr(&v713);
                        let v716: std::string::String =
                            (&v714).to_string().clone();
                        let v717: string =
                            substring2(v209.clone(), 0i32, 2i32);
                        let v718: u8 = u8::from_str_radix(&v717, 16).unwrap();
                        let v719: string =
                            substring2(v209.clone(), 2i32, 2i32);
                        let v720: u8 = u8::from_str_radix(&v719, 16).unwrap();
                        let v721: string =
                            substring2(v209.clone(), 4i32, 2i32);
                        let v722: u8 = u8::from_str_radix(&v721, 16).unwrap();
                        let v723: colored::ColoredString =
                            colored::Colorize::truecolor(&*v716.to_string(), v718, v720, v722);
                        let v724: std::string::String = format!("{}", &v723);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v640, &v682, &v724)));
                        {
                            let v733: string =
                                Cli::method13(Cli::method12((Cli::method11(v564,
                                                                           0i32,
                                                                           Lrc::new(Cli::UH1::UH1_1))).1.clone(),
                                                            Lrc::new(Cli::UH1::UH1_1)),
                                              string(""));
                            let v736: std::string::String =
                                (&string("text len")).to_string().clone();
                            let v738: i32 = (&v733).len().try_into().unwrap();
                            let v741: Array<std::string::String> =
                                array(&[v736, format!("{:?}", &v738)]);
                            let v742 = core::ops::Deref::deref(&v741);
                            let v744: std::string::String =
                                format!("{:?}", ***v742).clone();
                            let v745: chrono::DateTime<chrono::Utc> =
                                chrono::Utc::now();
                            let v750: string =
                                Cli::method3(6i32,
                                             toString(&((&v745).timestamp() -
                                                            v7)));
                            let v751: u8 = rand::random::<u8>();
                            let v764: Array<std::string::String> =
                                array(&[(&v57).to_string(),
                                        (&v750).to_string(),
                                        (&v62).to_string(),
                                        format!("{:?}", &v751),
                                        (&v67).to_string(),
                                        (&v70).to_string()]);
                            let v765 = core::ops::Deref::deref(&v764);
                            let v767: std::string::String =
                                format!("{:?}", ***v765).clone();
                            let v770: Array<std::string::String> =
                                array(&[(&v77).to_string()]);
                            let v771 = core::ops::Deref::deref(&v770);
                            let v774: std::string::String =
                                format!("{:?}", ***v771).clone();
                            let v775: string =
                                fable_library_rust::String_::fromStr(&v774);
                            let v777: &str = r#""([^"]+)", "([^"]+)""#;
                            let v778: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v777);
                            let v779: &regex::Regex = &v778.build().unwrap();
                            let v780: string = Cli::method2(v775);
                            let v781: &str = &v780.as_str();
                            let v782: string = Cli::method4();
                            let v783: &str = &v782.as_str();
                            let v784: std::string::String =
                                v779.replace_all(&v781, v783).to_string();
                            let v785: string =
                                fable_library_rust::String_::fromStr(&v784);
                            let v787: &str = r#"\["(.*?)"\]"#;
                            let v788: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v787);
                            let v789: &regex::Regex = &v788.build().unwrap();
                            let v790: string = Cli::method2(v785);
                            let v791: &str = &v790.as_str();
                            let v792: string = Cli::method5();
                            let v793: &str = &v792.as_str();
                            let v794: std::string::String =
                                v789.replace_all(&v791, v793).to_string();
                            let v795: string =
                                fable_library_rust::String_::fromStr(&v794);
                            let v797: &str = r#", "#;
                            let v798: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v797);
                            let v799: &regex::Regex = &v798.build().unwrap();
                            let v800: string = Cli::method2(v795);
                            let v801: &str = &v800.as_str();
                            let v802: string = Cli::method6();
                            let v803: &str = &v802.as_str();
                            let v804: std::string::String =
                                v799.replace_all(&v801, v803).to_string();
                            let v805: string =
                                fable_library_rust::String_::fromStr(&v804);
                            let v807: std::string::String =
                                (&v805).to_string().clone();
                            let v808: colored::ColoredString =
                                colored::Colorize::color(&*v807, v125.clone().to_string());
                            let v809: std::string::String =
                                format!("{}", &v808);
                            let v811: string =
                                fable_library_rust::String_::fromStr(&&v744);
                            let v813: &str = r#""([^"]+)", "([^"]+)""#;
                            let v814: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v813);
                            let v815: &regex::Regex = &v814.build().unwrap();
                            let v816: string = Cli::method2(v811);
                            let v817: &str = &v816.as_str();
                            let v818: string = Cli::method4();
                            let v819: &str = &v818.as_str();
                            let v820: std::string::String =
                                v815.replace_all(&v817, v819).to_string();
                            let v821: string =
                                fable_library_rust::String_::fromStr(&v820);
                            let v823: &str = r#"\["(.*?)"\]"#;
                            let v824: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v823);
                            let v825: &regex::Regex = &v824.build().unwrap();
                            let v826: string = Cli::method2(v821);
                            let v827: &str = &v826.as_str();
                            let v828: string = Cli::method5();
                            let v829: &str = &v828.as_str();
                            let v830: std::string::String =
                                v825.replace_all(&v827, v829).to_string();
                            let v831: string =
                                fable_library_rust::String_::fromStr(&v830);
                            let v833: &str = r#", "#;
                            let v834: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v833);
                            let v835: &regex::Regex = &v834.build().unwrap();
                            let v836: string = Cli::method2(v831);
                            let v837: &str = &v836.as_str();
                            let v838: string = Cli::method6();
                            let v839: &str = &v838.as_str();
                            let v840: std::string::String =
                                v835.replace_all(&v837, v839).to_string();
                            let v841: string =
                                fable_library_rust::String_::fromStr(&v840);
                            let v843: std::string::String =
                                (&v841).to_string().clone();
                            let v844: string =
                                substring2(v164.clone(), 0i32, 2i32);
                            let v845: u8 =
                                u8::from_str_radix(&v844, 16).unwrap();
                            let v846: string =
                                substring2(v164.clone(), 2i32, 2i32);
                            let v847: u8 =
                                u8::from_str_radix(&v846, 16).unwrap();
                            let v848: string =
                                substring2(v164.clone(), 4i32, 2i32);
                            let v849: u8 =
                                u8::from_str_radix(&v848, 16).unwrap();
                            let v850: colored::ColoredString =
                                colored::Colorize::truecolor(&*v843.to_string(), v845, v847, v849);
                            let v851: std::string::String =
                                format!("{}", &v850);
                            let v853: string =
                                fable_library_rust::String_::fromStr(&&v767);
                            let v855: &str = r#""([^"]+)", "([^"]+)""#;
                            let v856: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v855);
                            let v857: &regex::Regex = &v856.build().unwrap();
                            let v858: string = Cli::method2(v853);
                            let v859: &str = &v858.as_str();
                            let v860: string = Cli::method4();
                            let v861: &str = &v860.as_str();
                            let v862: std::string::String =
                                v857.replace_all(&v859, v861).to_string();
                            let v863: string =
                                fable_library_rust::String_::fromStr(&v862);
                            let v865: &str = r#"\["(.*?)"\]"#;
                            let v866: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v865);
                            let v867: &regex::Regex = &v866.build().unwrap();
                            let v868: string = Cli::method2(v863);
                            let v869: &str = &v868.as_str();
                            let v870: string = Cli::method5();
                            let v871: &str = &v870.as_str();
                            let v872: std::string::String =
                                v867.replace_all(&v869, v871).to_string();
                            let v873: string =
                                fable_library_rust::String_::fromStr(&v872);
                            let v875: &str = r#", "#;
                            let v876: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v875);
                            let v877: &regex::Regex = &v876.build().unwrap();
                            let v878: string = Cli::method2(v873);
                            let v879: &str = &v878.as_str();
                            let v880: string = Cli::method6();
                            let v881: &str = &v880.as_str();
                            let v882: std::string::String =
                                v877.replace_all(&v879, v881).to_string();
                            let v883: string =
                                fable_library_rust::String_::fromStr(&v882);
                            let v885: std::string::String =
                                (&v883).to_string().clone();
                            let v886: string =
                                substring2(v209.clone(), 0i32, 2i32);
                            let v887: u8 =
                                u8::from_str_radix(&v886, 16).unwrap();
                            let v888: string =
                                substring2(v209.clone(), 2i32, 2i32);
                            let v889: u8 =
                                u8::from_str_radix(&v888, 16).unwrap();
                            let v890: string =
                                substring2(v209.clone(), 4i32, 2i32);
                            let v891: u8 =
                                u8::from_str_radix(&v890, 16).unwrap();
                            let v892: colored::ColoredString =
                                colored::Colorize::truecolor(&*v885.to_string(), v887, v889, v891);
                            let v893: std::string::String =
                                format!("{}", &v892);
                            println!("{0}",
                                     stringFrom(format!("{0} {1} {2}", &v809, &v851, &v893)));
                            {
                                let v896: Result<(), std::io::Error> =
                                    std::fs::write(v35, v733.as_str());
                                *((&v896).as_ref()).unwrap();
                                {
                                    let v899: std::string::String =
                                        (&string("> fs_write rs_path_clean text; ok")).to_string().clone();
                                    let v900: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v905: string =
                                        Cli::method3(6i32,
                                                     toString(&((&v900).timestamp()
                                                                    - v7)));
                                    let v906: u8 = rand::random::<u8>();
                                    let v919: Array<std::string::String> =
                                        array(&[(&v57).to_string(),
                                                (&v905).to_string(),
                                                (&v62).to_string(),
                                                format!("{:?}", &v906),
                                                (&v67).to_string(),
                                                (&v70).to_string()]);
                                    let v920 = core::ops::Deref::deref(&v919);
                                    let v922: std::string::String =
                                        format!("{:?}", ***v920).clone();
                                    let v925: Array<std::string::String> =
                                        array(&[(&v77).to_string()]);
                                    let v926 = core::ops::Deref::deref(&v925);
                                    let v929: std::string::String =
                                        format!("{:?}", ***v926).clone();
                                    let v930: string =
                                        fable_library_rust::String_::fromStr(&v929);
                                    let v932: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v933: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v932);
                                    let v934: &regex::Regex =
                                        &v933.build().unwrap();
                                    let v935: string = Cli::method2(v930);
                                    let v936: &str = &v935.as_str();
                                    let v937: string = Cli::method4();
                                    let v938: &str = &v937.as_str();
                                    let v939: std::string::String =
                                        v934.replace_all(&v936, v938).to_string();
                                    let v940: string =
                                        fable_library_rust::String_::fromStr(&v939);
                                    let v942: &str = r#"\["(.*?)"\]"#;
                                    let v943: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v942);
                                    let v944: &regex::Regex =
                                        &v943.build().unwrap();
                                    let v945: string = Cli::method2(v940);
                                    let v946: &str = &v945.as_str();
                                    let v947: string = Cli::method5();
                                    let v948: &str = &v947.as_str();
                                    let v949: std::string::String =
                                        v944.replace_all(&v946, v948).to_string();
                                    let v950: string =
                                        fable_library_rust::String_::fromStr(&v949);
                                    let v952: &str = r#", "#;
                                    let v953: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v952);
                                    let v954: &regex::Regex =
                                        &v953.build().unwrap();
                                    let v955: string = Cli::method2(v950);
                                    let v956: &str = &v955.as_str();
                                    let v957: string = Cli::method6();
                                    let v958: &str = &v957.as_str();
                                    let v959: std::string::String =
                                        v954.replace_all(&v956, v958).to_string();
                                    let v960: string =
                                        fable_library_rust::String_::fromStr(&v959);
                                    let v962: std::string::String =
                                        (&v960).to_string().clone();
                                    let v963: colored::ColoredString =
                                        colored::Colorize::color(&*v962, v125.to_string());
                                    let v964: std::string::String =
                                        format!("{}", &v963);
                                    let v966: string =
                                        fable_library_rust::String_::fromStr(&&v899);
                                    let v968: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v969: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v968);
                                    let v970: &regex::Regex =
                                        &v969.build().unwrap();
                                    let v971: string = Cli::method2(v966);
                                    let v972: &str = &v971.as_str();
                                    let v973: string = Cli::method4();
                                    let v974: &str = &v973.as_str();
                                    let v975: std::string::String =
                                        v970.replace_all(&v972, v974).to_string();
                                    let v976: string =
                                        fable_library_rust::String_::fromStr(&v975);
                                    let v978: &str = r#"\["(.*?)"\]"#;
                                    let v979: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v978);
                                    let v980: &regex::Regex =
                                        &v979.build().unwrap();
                                    let v981: string = Cli::method2(v976);
                                    let v982: &str = &v981.as_str();
                                    let v983: string = Cli::method5();
                                    let v984: &str = &v983.as_str();
                                    let v985: std::string::String =
                                        v980.replace_all(&v982, v984).to_string();
                                    let v986: string =
                                        fable_library_rust::String_::fromStr(&v985);
                                    let v988: &str = r#", "#;
                                    let v989: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v988);
                                    let v990: &regex::Regex =
                                        &v989.build().unwrap();
                                    let v991: string = Cli::method2(v986);
                                    let v992: &str = &v991.as_str();
                                    let v993: string = Cli::method6();
                                    let v994: &str = &v993.as_str();
                                    let v995: std::string::String =
                                        v990.replace_all(&v992, v994).to_string();
                                    let v996: string =
                                        fable_library_rust::String_::fromStr(&v995);
                                    let v998: std::string::String =
                                        (&v996).to_string().clone();
                                    let v999: string =
                                        substring2(v164.clone(), 0i32, 2i32);
                                    let v1000: u8 =
                                        u8::from_str_radix(&v999, 16).unwrap();
                                    let v1001: string =
                                        substring2(v164.clone(), 2i32, 2i32);
                                    let v1002: u8 =
                                        u8::from_str_radix(&v1001, 16).unwrap();
                                    let v1003: string =
                                        substring2(v164, 4i32, 2i32);
                                    let v1004: u8 =
                                        u8::from_str_radix(&v1003, 16).unwrap();
                                    let v1005: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v998.to_string(), v1000, v1002, v1004);
                                    let v1006: std::string::String =
                                        format!("{}", &v1005);
                                    let v1008: string =
                                        fable_library_rust::String_::fromStr(&&v922);
                                    let v1010: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1011: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1010);
                                    let v1012: &regex::Regex =
                                        &v1011.build().unwrap();
                                    let v1013: string = Cli::method2(v1008);
                                    let v1014: &str = &v1013.as_str();
                                    let v1015: string = Cli::method4();
                                    let v1016: &str = &v1015.as_str();
                                    let v1017: std::string::String =
                                        v1012.replace_all(&v1014, v1016).to_string();
                                    let v1018: string =
                                        fable_library_rust::String_::fromStr(&v1017);
                                    let v1020: &str = r#"\["(.*?)"\]"#;
                                    let v1021: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1020);
                                    let v1022: &regex::Regex =
                                        &v1021.build().unwrap();
                                    let v1023: string = Cli::method2(v1018);
                                    let v1024: &str = &v1023.as_str();
                                    let v1025: string = Cli::method5();
                                    let v1026: &str = &v1025.as_str();
                                    let v1027: std::string::String =
                                        v1022.replace_all(&v1024, v1026).to_string();
                                    let v1028: string =
                                        fable_library_rust::String_::fromStr(&v1027);
                                    let v1030: &str = r#", "#;
                                    let v1031: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1030);
                                    let v1032: &regex::Regex =
                                        &v1031.build().unwrap();
                                    let v1033: string = Cli::method2(v1028);
                                    let v1034: &str = &v1033.as_str();
                                    let v1035: string = Cli::method6();
                                    let v1036: &str = &v1035.as_str();
                                    let v1037: std::string::String =
                                        v1032.replace_all(&v1034, v1036).to_string();
                                    let v1038: string =
                                        fable_library_rust::String_::fromStr(&v1037);
                                    let v1040: std::string::String =
                                        (&v1038).to_string().clone();
                                    let v1041: string =
                                        substring2(v209.clone(), 0i32, 2i32);
                                    let v1042: u8 =
                                        u8::from_str_radix(&v1041, 16).unwrap();
                                    let v1043: string =
                                        substring2(v209.clone(), 2i32, 2i32);
                                    let v1044: u8 =
                                        u8::from_str_radix(&v1043, 16).unwrap();
                                    let v1045: string =
                                        substring2(v209, 4i32, 2i32);
                                    let v1046: u8 =
                                        u8::from_str_radix(&v1045, 16).unwrap();
                                    let v1047: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v1040.to_string(), v1042, v1044, v1046);
                                    let v1048: std::string::String =
                                        format!("{}", &v1047);
                                    println!("{0}",
                                             stringFrom(format!("{0} {1} {2}", &v964, &v1006, &v1048)));
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
