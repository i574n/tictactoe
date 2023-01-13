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
    pub fn method1() -> string { string("../client/client.rs") }
    pub fn method2(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method2:
            loop  {
                break '_method2
                    (if length(v1.get()) < v0_1.get() {
                         let v0_1_temp: i32 = v0_1.get();
                         let v1_temp: string =
                             stringFrom(format!("0{0}", &v1.get()));
                         v0_1.set(v0_1_temp);
                         v1.set(v1_temp);
                         continue '_method2
                     } else { v1.get() }) ;
            }
    }
    pub fn method3(v0_1: string) -> string { v0_1 }
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
        let v8: string = Cli::method1();
        let v10: &str = &v8.as_str();
        let v12: std::path::PathBuf = std::path::PathBuf::from(&v10);
        let patternInput_1: (string, string, string, bool) = Cli::method0();
        let v17: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v18: i64 = (&v17).timestamp();
        let v20: Result<std::path::PathBuf, std::io::Error> =
            (&v12).canonicalize();
        let v22: std::path::PathBuf = (&v20).as_ref().unwrap().to_path_buf();
        let v26: std::string::String =
            (&string("path_clean")).to_string().clone();
        let v28: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v22.display()));
        let v31: Array<std::string::String> =
            array(&[v26, (&v28).to_string()]);
        let v33 = core::ops::Deref::deref(&v31);
        let v36: std::string::String = format!("{:?}", ***v33).clone();
        let v37: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v42: string =
            Cli::method2(6i32, toString(&((&v37).timestamp() - v18)));
        let v44: u8 = rand::random::<u8>();
        let v45: string = string("timestamp");
        let v50: string = string("run_id");
        let v56: string = string("log_level");
        let v59: string = string("Debug");
        let v62: Array<std::string::String> =
            array(&[(&v45).to_string(), (&v42).to_string(),
                    (&v50).to_string(), format!("{:?}", &v44),
                    (&v56).to_string(), (&v59).to_string()]);
        let v63 = core::ops::Deref::deref(&v62);
        let v65: std::string::String = format!("{:?}", ***v63).clone();
        let v66: string = string("> read_lines ()");
        let v69: Array<std::string::String> = array(&[(&v66).to_string()]);
        let v70 = core::ops::Deref::deref(&v69);
        let v73: std::string::String = format!("{:?}", ***v70).clone();
        let v75: string = fable_library_rust::String_::fromStr(&v73);
        let v78: &str = r#""([^"]+)", "([^"]+)""#;
        let v80: regex::RegexBuilder = regex::RegexBuilder::new(&v78);
        let v82: &regex::Regex = &v80.build().unwrap();
        let v83: string = Cli::method3(v75);
        let v84: &str = &v83.as_str();
        let v85: string = Cli::method4();
        let v86: &str = &v85.as_str();
        let v88: std::string::String = v82.replace_all(&v84, v86).to_string();
        let v89: string = fable_library_rust::String_::fromStr(&v88);
        let v92: &str = r#"\["(.*?)"\]"#;
        let v93: regex::RegexBuilder = regex::RegexBuilder::new(&v92);
        let v94: &regex::Regex = &v93.build().unwrap();
        let v95: string = Cli::method3(v89);
        let v96: &str = &v95.as_str();
        let v97: string = Cli::method5();
        let v98: &str = &v97.as_str();
        let v99: std::string::String = v94.replace_all(&v96, v98).to_string();
        let v100: string = fable_library_rust::String_::fromStr(&v99);
        let v103: &str = r#", "#;
        let v104: regex::RegexBuilder = regex::RegexBuilder::new(&v103);
        let v105: &regex::Regex = &v104.build().unwrap();
        let v106: string = Cli::method3(v100);
        let v107: &str = &v106.as_str();
        let v108: string = Cli::method6();
        let v109: &str = &v108.as_str();
        let v110: std::string::String =
            v105.replace_all(&v107, v109).to_string();
        let v111: string = fable_library_rust::String_::fromStr(&v110);
        let v113: std::string::String = (&v111).to_string().clone();
        let v114: string = string("purple");
        let v116: colored::ColoredString =
            colored::Colorize::color(&*v113, v114.clone().to_string());
        let v118: std::string::String = format!("{}", &v116);
        let v120: string = fable_library_rust::String_::fromStr(&&v36);
        let v122: &str = r#""([^"]+)", "([^"]+)""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Cli::method3(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Cli::method4();
        let v128: &str = &v127.as_str();
        let v129: std::string::String =
            v124.replace_all(&v126, v128).to_string();
        let v130: string = fable_library_rust::String_::fromStr(&v129);
        let v132: &str = r#"\["(.*?)"\]"#;
        let v133: regex::RegexBuilder = regex::RegexBuilder::new(&v132);
        let v134: &regex::Regex = &v133.build().unwrap();
        let v135: string = Cli::method3(v130);
        let v136: &str = &v135.as_str();
        let v137: string = Cli::method5();
        let v138: &str = &v137.as_str();
        let v139: std::string::String =
            v134.replace_all(&v136, v138).to_string();
        let v140: string = fable_library_rust::String_::fromStr(&v139);
        let v142: &str = r#", "#;
        let v143: regex::RegexBuilder = regex::RegexBuilder::new(&v142);
        let v144: &regex::Regex = &v143.build().unwrap();
        let v145: string = Cli::method3(v140);
        let v146: &str = &v145.as_str();
        let v147: string = Cli::method6();
        let v148: &str = &v147.as_str();
        let v149: std::string::String =
            v144.replace_all(&v146, v148).to_string();
        let v150: string = fable_library_rust::String_::fromStr(&v149);
        let v152: std::string::String = (&v150).to_string().clone();
        let v153: string = string("666666");
        let v154: string = substring2(v153.clone(), 0i32, 2i32);
        let v156: u8 = u8::from_str_radix(&v154, 16).unwrap();
        let v157: string = substring2(v153.clone(), 2i32, 2i32);
        let v158: u8 = u8::from_str_radix(&v157, 16).unwrap();
        let v159: string = substring2(v153.clone(), 4i32, 2i32);
        let v160: u8 = u8::from_str_radix(&v159, 16).unwrap();
        let v162: colored::ColoredString =
            colored::Colorize::truecolor(&*v152.to_string(), v156, v158, v160);
        let v163: std::string::String = format!("{}", &v162);
        let v165: string = fable_library_rust::String_::fromStr(&&v65);
        let v167: &str = r#""([^"]+)", "([^"]+)""#;
        let v168: regex::RegexBuilder = regex::RegexBuilder::new(&v167);
        let v169: &regex::Regex = &v168.build().unwrap();
        let v170: string = Cli::method3(v165);
        let v171: &str = &v170.as_str();
        let v172: string = Cli::method4();
        let v173: &str = &v172.as_str();
        let v174: std::string::String =
            v169.replace_all(&v171, v173).to_string();
        let v175: string = fable_library_rust::String_::fromStr(&v174);
        let v177: &str = r#"\["(.*?)"\]"#;
        let v178: regex::RegexBuilder = regex::RegexBuilder::new(&v177);
        let v179: &regex::Regex = &v178.build().unwrap();
        let v180: string = Cli::method3(v175);
        let v181: &str = &v180.as_str();
        let v182: string = Cli::method5();
        let v183: &str = &v182.as_str();
        let v184: std::string::String =
            v179.replace_all(&v181, v183).to_string();
        let v185: string = fable_library_rust::String_::fromStr(&v184);
        let v187: &str = r#", "#;
        let v188: regex::RegexBuilder = regex::RegexBuilder::new(&v187);
        let v189: &regex::Regex = &v188.build().unwrap();
        let v190: string = Cli::method3(v185);
        let v191: &str = &v190.as_str();
        let v192: string = Cli::method6();
        let v193: &str = &v192.as_str();
        let v194: std::string::String =
            v189.replace_all(&v191, v193).to_string();
        let v195: string = fable_library_rust::String_::fromStr(&v194);
        let v197: std::string::String = (&v195).to_string().clone();
        let v198: string = string("222222");
        let v199: string = substring2(v198.clone(), 0i32, 2i32);
        let v200: u8 = u8::from_str_radix(&v199, 16).unwrap();
        let v201: string = substring2(v198.clone(), 2i32, 2i32);
        let v202: u8 = u8::from_str_radix(&v201, 16).unwrap();
        let v203: string = substring2(v198.clone(), 4i32, 2i32);
        let v204: u8 = u8::from_str_radix(&v203, 16).unwrap();
        let v205: colored::ColoredString =
            colored::Colorize::truecolor(&*v197.to_string(), v200, v202, v204);
        let v206: std::string::String = format!("{}", &v205);
        println!("{0}",
                 stringFrom(format!("{0} {1} {2}", &v118, &v163, &v206)));
        {
            let v209: Result<std::fs::File, std::io::Error> =
                std::fs::File::open(&v22);
            let v211: &std::fs::File = &v209.unwrap();
            let v213:
                    std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                std::cell::RefCell::new(linereader::LineReader::new(&v211));
            let v219: Array<std::string::String> =
                array(&[(&string("reader")).to_string(),
                        format!("{:?}", &v213)]);
            let v220 = core::ops::Deref::deref(&v219);
            let v222: std::string::String = format!("{:?}", ***v220).clone();
            let v223: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v228: string =
                Cli::method2(6i32, toString(&((&v223).timestamp() - v18)));
            let v229: u8 = rand::random::<u8>();
            let v242: Array<std::string::String> =
                array(&[(&v45).to_string(), (&v228).to_string(),
                        (&v50).to_string(), format!("{:?}", &v229),
                        (&v56).to_string(), (&v59).to_string()]);
            let v243 = core::ops::Deref::deref(&v242);
            let v245: std::string::String = format!("{:?}", ***v243).clone();
            let v248: Array<std::string::String> =
                array(&[(&v66).to_string()]);
            let v249 = core::ops::Deref::deref(&v248);
            let v252: std::string::String = format!("{:?}", ***v249).clone();
            let v253: string = fable_library_rust::String_::fromStr(&v252);
            let v255: &str = r#""([^"]+)", "([^"]+)""#;
            let v256: regex::RegexBuilder = regex::RegexBuilder::new(&v255);
            let v257: &regex::Regex = &v256.build().unwrap();
            let v258: string = Cli::method3(v253);
            let v259: &str = &v258.as_str();
            let v260: string = Cli::method4();
            let v261: &str = &v260.as_str();
            let v262: std::string::String =
                v257.replace_all(&v259, v261).to_string();
            let v263: string = fable_library_rust::String_::fromStr(&v262);
            let v265: &str = r#"\["(.*?)"\]"#;
            let v266: regex::RegexBuilder = regex::RegexBuilder::new(&v265);
            let v267: &regex::Regex = &v266.build().unwrap();
            let v268: string = Cli::method3(v263);
            let v269: &str = &v268.as_str();
            let v270: string = Cli::method5();
            let v271: &str = &v270.as_str();
            let v272: std::string::String =
                v267.replace_all(&v269, v271).to_string();
            let v273: string = fable_library_rust::String_::fromStr(&v272);
            let v275: &str = r#", "#;
            let v276: regex::RegexBuilder = regex::RegexBuilder::new(&v275);
            let v277: &regex::Regex = &v276.build().unwrap();
            let v278: string = Cli::method3(v273);
            let v279: &str = &v278.as_str();
            let v280: string = Cli::method6();
            let v281: &str = &v280.as_str();
            let v282: std::string::String =
                v277.replace_all(&v279, v281).to_string();
            let v283: string = fable_library_rust::String_::fromStr(&v282);
            let v285: std::string::String = (&v283).to_string().clone();
            let v286: colored::ColoredString =
                colored::Colorize::color(&*v285, v114.clone().to_string());
            let v287: std::string::String = format!("{}", &v286);
            let v289: string = fable_library_rust::String_::fromStr(&&v222);
            let v291: &str = r#""([^"]+)", "([^"]+)""#;
            let v292: regex::RegexBuilder = regex::RegexBuilder::new(&v291);
            let v293: &regex::Regex = &v292.build().unwrap();
            let v294: string = Cli::method3(v289);
            let v295: &str = &v294.as_str();
            let v296: string = Cli::method4();
            let v297: &str = &v296.as_str();
            let v298: std::string::String =
                v293.replace_all(&v295, v297).to_string();
            let v299: string = fable_library_rust::String_::fromStr(&v298);
            let v301: &str = r#"\["(.*?)"\]"#;
            let v302: regex::RegexBuilder = regex::RegexBuilder::new(&v301);
            let v303: &regex::Regex = &v302.build().unwrap();
            let v304: string = Cli::method3(v299);
            let v305: &str = &v304.as_str();
            let v306: string = Cli::method5();
            let v307: &str = &v306.as_str();
            let v308: std::string::String =
                v303.replace_all(&v305, v307).to_string();
            let v309: string = fable_library_rust::String_::fromStr(&v308);
            let v311: &str = r#", "#;
            let v312: regex::RegexBuilder = regex::RegexBuilder::new(&v311);
            let v313: &regex::Regex = &v312.build().unwrap();
            let v314: string = Cli::method3(v309);
            let v315: &str = &v314.as_str();
            let v316: string = Cli::method6();
            let v317: &str = &v316.as_str();
            let v318: std::string::String =
                v313.replace_all(&v315, v317).to_string();
            let v319: string = fable_library_rust::String_::fromStr(&v318);
            let v321: std::string::String = (&v319).to_string().clone();
            let v322: string = substring2(v153.clone(), 0i32, 2i32);
            let v323: u8 = u8::from_str_radix(&v322, 16).unwrap();
            let v324: string = substring2(v153.clone(), 2i32, 2i32);
            let v325: u8 = u8::from_str_radix(&v324, 16).unwrap();
            let v326: string = substring2(v153.clone(), 4i32, 2i32);
            let v327: u8 = u8::from_str_radix(&v326, 16).unwrap();
            let v328: colored::ColoredString =
                colored::Colorize::truecolor(&*v321.to_string(), v323, v325, v327);
            let v329: std::string::String = format!("{}", &v328);
            let v331: string = fable_library_rust::String_::fromStr(&&v245);
            let v333: &str = r#""([^"]+)", "([^"]+)""#;
            let v334: regex::RegexBuilder = regex::RegexBuilder::new(&v333);
            let v335: &regex::Regex = &v334.build().unwrap();
            let v336: string = Cli::method3(v331);
            let v337: &str = &v336.as_str();
            let v338: string = Cli::method4();
            let v339: &str = &v338.as_str();
            let v340: std::string::String =
                v335.replace_all(&v337, v339).to_string();
            let v341: string = fable_library_rust::String_::fromStr(&v340);
            let v343: &str = r#"\["(.*?)"\]"#;
            let v344: regex::RegexBuilder = regex::RegexBuilder::new(&v343);
            let v345: &regex::Regex = &v344.build().unwrap();
            let v346: string = Cli::method3(v341);
            let v347: &str = &v346.as_str();
            let v348: string = Cli::method5();
            let v349: &str = &v348.as_str();
            let v350: std::string::String =
                v345.replace_all(&v347, v349).to_string();
            let v351: string = fable_library_rust::String_::fromStr(&v350);
            let v353: &str = r#", "#;
            let v354: regex::RegexBuilder = regex::RegexBuilder::new(&v353);
            let v355: &regex::Regex = &v354.build().unwrap();
            let v356: string = Cli::method3(v351);
            let v357: &str = &v356.as_str();
            let v358: string = Cli::method6();
            let v359: &str = &v358.as_str();
            let v360: std::string::String =
                v355.replace_all(&v357, v359).to_string();
            let v361: string = fable_library_rust::String_::fromStr(&v360);
            let v363: std::string::String = (&v361).to_string().clone();
            let v364: string = substring2(v198.clone(), 0i32, 2i32);
            let v365: u8 = u8::from_str_radix(&v364, 16).unwrap();
            let v366: string = substring2(v198.clone(), 2i32, 2i32);
            let v367: u8 = u8::from_str_radix(&v366, 16).unwrap();
            let v368: string = substring2(v198.clone(), 4i32, 2i32);
            let v369: u8 = u8::from_str_radix(&v368, 16).unwrap();
            let v370: colored::ColoredString =
                colored::Colorize::truecolor(&*v363.to_string(), v365, v367, v369);
            let v371: std::string::String = format!("{}", &v370);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v287, &v329, &v371)));
            {
                let v374: Lrc<Cli::Mut0> =
                    Lrc::new(Cli::Mut0{l0:
                                           MutCell::new(Lrc::new(Cli::UH0::UH0_1)),});
                let v375 = Cli::method7(v18, v374.clone());
                let v377: Result<(), std::io::Error> =
                    (v213).borrow_mut().for_each(move |x| v375(x.to_vec()));
                *((&v377).as_ref()).unwrap();
                {
                    let v383: Lrc<Cli::UH1> =
                        Cli::method9(Cli::method8(v374.l0.get().clone(),
                                                  Lrc::new(Cli::UH0::UH0_1)),
                                     Lrc::new(Cli::UH1::UH1_1));
                    let v386: std::string::String =
                        (&string("lines len")).to_string().clone();
                    let v388: i32 = Cli::method10(v383.clone(), 0i32);
                    let v391: Array<std::string::String> =
                        array(&[v386, format!("{:?}", &v388)]);
                    let v392 = core::ops::Deref::deref(&v391);
                    let v394: std::string::String =
                        format!("{:?}", ***v392).clone();
                    let v395: chrono::DateTime<chrono::Utc> =
                        chrono::Utc::now();
                    let v400: string =
                        Cli::method2(6i32,
                                     toString(&((&v395).timestamp() - v18)));
                    let v401: u8 = rand::random::<u8>();
                    let v414: Array<std::string::String> =
                        array(&[(&v45).to_string(), (&v400).to_string(),
                                (&v50).to_string(), format!("{:?}", &v401),
                                (&v56).to_string(), (&v59).to_string()]);
                    let v415 = core::ops::Deref::deref(&v414);
                    let v417: std::string::String =
                        format!("{:?}", ***v415).clone();
                    let v420: Array<std::string::String> =
                        array(&[(&v66).to_string()]);
                    let v421 = core::ops::Deref::deref(&v420);
                    let v424: std::string::String =
                        format!("{:?}", ***v421).clone();
                    let v425: string =
                        fable_library_rust::String_::fromStr(&v424);
                    let v427: &str = r#""([^"]+)", "([^"]+)""#;
                    let v428: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v427);
                    let v429: &regex::Regex = &v428.build().unwrap();
                    let v430: string = Cli::method3(v425);
                    let v431: &str = &v430.as_str();
                    let v432: string = Cli::method4();
                    let v433: &str = &v432.as_str();
                    let v434: std::string::String =
                        v429.replace_all(&v431, v433).to_string();
                    let v435: string =
                        fable_library_rust::String_::fromStr(&v434);
                    let v437: &str = r#"\["(.*?)"\]"#;
                    let v438: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v437);
                    let v439: &regex::Regex = &v438.build().unwrap();
                    let v440: string = Cli::method3(v435);
                    let v441: &str = &v440.as_str();
                    let v442: string = Cli::method5();
                    let v443: &str = &v442.as_str();
                    let v444: std::string::String =
                        v439.replace_all(&v441, v443).to_string();
                    let v445: string =
                        fable_library_rust::String_::fromStr(&v444);
                    let v447: &str = r#", "#;
                    let v448: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v447);
                    let v449: &regex::Regex = &v448.build().unwrap();
                    let v450: string = Cli::method3(v445);
                    let v451: &str = &v450.as_str();
                    let v452: string = Cli::method6();
                    let v453: &str = &v452.as_str();
                    let v454: std::string::String =
                        v449.replace_all(&v451, v453).to_string();
                    let v455: string =
                        fable_library_rust::String_::fromStr(&v454);
                    let v457: std::string::String =
                        (&v455).to_string().clone();
                    let v458: colored::ColoredString =
                        colored::Colorize::color(&*v457, v114.clone().to_string());
                    let v459: std::string::String = format!("{}", &v458);
                    let v461: string =
                        fable_library_rust::String_::fromStr(&&v394);
                    let v463: &str = r#""([^"]+)", "([^"]+)""#;
                    let v464: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v463);
                    let v465: &regex::Regex = &v464.build().unwrap();
                    let v466: string = Cli::method3(v461);
                    let v467: &str = &v466.as_str();
                    let v468: string = Cli::method4();
                    let v469: &str = &v468.as_str();
                    let v470: std::string::String =
                        v465.replace_all(&v467, v469).to_string();
                    let v471: string =
                        fable_library_rust::String_::fromStr(&v470);
                    let v473: &str = r#"\["(.*?)"\]"#;
                    let v474: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v473);
                    let v475: &regex::Regex = &v474.build().unwrap();
                    let v476: string = Cli::method3(v471);
                    let v477: &str = &v476.as_str();
                    let v478: string = Cli::method5();
                    let v479: &str = &v478.as_str();
                    let v480: std::string::String =
                        v475.replace_all(&v477, v479).to_string();
                    let v481: string =
                        fable_library_rust::String_::fromStr(&v480);
                    let v483: &str = r#", "#;
                    let v484: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v483);
                    let v485: &regex::Regex = &v484.build().unwrap();
                    let v486: string = Cli::method3(v481);
                    let v487: &str = &v486.as_str();
                    let v488: string = Cli::method6();
                    let v489: &str = &v488.as_str();
                    let v490: std::string::String =
                        v485.replace_all(&v487, v489).to_string();
                    let v491: string =
                        fable_library_rust::String_::fromStr(&v490);
                    let v493: std::string::String =
                        (&v491).to_string().clone();
                    let v494: string = substring2(v153.clone(), 0i32, 2i32);
                    let v495: u8 = u8::from_str_radix(&v494, 16).unwrap();
                    let v496: string = substring2(v153.clone(), 2i32, 2i32);
                    let v497: u8 = u8::from_str_radix(&v496, 16).unwrap();
                    let v498: string = substring2(v153.clone(), 4i32, 2i32);
                    let v499: u8 = u8::from_str_radix(&v498, 16).unwrap();
                    let v500: colored::ColoredString =
                        colored::Colorize::truecolor(&*v493.to_string(), v495, v497, v499);
                    let v501: std::string::String = format!("{}", &v500);
                    let v503: string =
                        fable_library_rust::String_::fromStr(&&v417);
                    let v505: &str = r#""([^"]+)", "([^"]+)""#;
                    let v506: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v505);
                    let v507: &regex::Regex = &v506.build().unwrap();
                    let v508: string = Cli::method3(v503);
                    let v509: &str = &v508.as_str();
                    let v510: string = Cli::method4();
                    let v511: &str = &v510.as_str();
                    let v512: std::string::String =
                        v507.replace_all(&v509, v511).to_string();
                    let v513: string =
                        fable_library_rust::String_::fromStr(&v512);
                    let v515: &str = r#"\["(.*?)"\]"#;
                    let v516: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v515);
                    let v517: &regex::Regex = &v516.build().unwrap();
                    let v518: string = Cli::method3(v513);
                    let v519: &str = &v518.as_str();
                    let v520: string = Cli::method5();
                    let v521: &str = &v520.as_str();
                    let v522: std::string::String =
                        v517.replace_all(&v519, v521).to_string();
                    let v523: string =
                        fable_library_rust::String_::fromStr(&v522);
                    let v525: &str = r#", "#;
                    let v526: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v525);
                    let v527: &regex::Regex = &v526.build().unwrap();
                    let v528: string = Cli::method3(v523);
                    let v529: &str = &v528.as_str();
                    let v530: string = Cli::method6();
                    let v531: &str = &v530.as_str();
                    let v532: std::string::String =
                        v527.replace_all(&v529, v531).to_string();
                    let v533: string =
                        fable_library_rust::String_::fromStr(&v532);
                    let v535: std::string::String =
                        (&v533).to_string().clone();
                    let v536: string = substring2(v198.clone(), 0i32, 2i32);
                    let v537: u8 = u8::from_str_radix(&v536, 16).unwrap();
                    let v538: string = substring2(v198.clone(), 2i32, 2i32);
                    let v539: u8 = u8::from_str_radix(&v538, 16).unwrap();
                    let v540: string = substring2(v198.clone(), 4i32, 2i32);
                    let v541: u8 = u8::from_str_radix(&v540, 16).unwrap();
                    let v542: colored::ColoredString =
                        colored::Colorize::truecolor(&*v535.to_string(), v537, v539, v541);
                    let v543: std::string::String = format!("{}", &v542);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v459, &v501, &v543)));
                    {
                        let v552: string =
                            Cli::method13(Cli::method12((Cli::method11(v383,
                                                                       0i32,
                                                                       Lrc::new(Cli::UH1::UH1_1))).1.clone(),
                                                        Lrc::new(Cli::UH1::UH1_1)),
                                          string(""));
                        let v555: std::string::String =
                            (&string("text len")).to_string().clone();
                        let v557: i32 = (&v552).len().try_into().unwrap();
                        let v560: Array<std::string::String> =
                            array(&[v555, format!("{:?}", &v557)]);
                        let v561 = core::ops::Deref::deref(&v560);
                        let v563: std::string::String =
                            format!("{:?}", ***v561).clone();
                        let v564: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v569: string =
                            Cli::method2(6i32,
                                         toString(&((&v564).timestamp() -
                                                        v7)));
                        let v570: u8 = rand::random::<u8>();
                        let v583: Array<std::string::String> =
                            array(&[(&v45).to_string(), (&v569).to_string(),
                                    (&v50).to_string(),
                                    format!("{:?}", &v570),
                                    (&v56).to_string(), (&v59).to_string()]);
                        let v584 = core::ops::Deref::deref(&v583);
                        let v586: std::string::String =
                            format!("{:?}", ***v584).clone();
                        let v587: string = string("> app ()");
                        let v590: Array<std::string::String> =
                            array(&[(&v587).to_string()]);
                        let v591 = core::ops::Deref::deref(&v590);
                        let v594: std::string::String =
                            format!("{:?}", ***v591).clone();
                        let v595: string =
                            fable_library_rust::String_::fromStr(&v594);
                        let v597: &str = r#""([^"]+)", "([^"]+)""#;
                        let v598: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v597);
                        let v599: &regex::Regex = &v598.build().unwrap();
                        let v600: string = Cli::method3(v595);
                        let v601: &str = &v600.as_str();
                        let v602: string = Cli::method4();
                        let v603: &str = &v602.as_str();
                        let v604: std::string::String =
                            v599.replace_all(&v601, v603).to_string();
                        let v605: string =
                            fable_library_rust::String_::fromStr(&v604);
                        let v607: &str = r#"\["(.*?)"\]"#;
                        let v608: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v607);
                        let v609: &regex::Regex = &v608.build().unwrap();
                        let v610: string = Cli::method3(v605);
                        let v611: &str = &v610.as_str();
                        let v612: string = Cli::method5();
                        let v613: &str = &v612.as_str();
                        let v614: std::string::String =
                            v609.replace_all(&v611, v613).to_string();
                        let v615: string =
                            fable_library_rust::String_::fromStr(&v614);
                        let v617: &str = r#", "#;
                        let v618: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v617);
                        let v619: &regex::Regex = &v618.build().unwrap();
                        let v620: string = Cli::method3(v615);
                        let v621: &str = &v620.as_str();
                        let v622: string = Cli::method6();
                        let v623: &str = &v622.as_str();
                        let v624: std::string::String =
                            v619.replace_all(&v621, v623).to_string();
                        let v625: string =
                            fable_library_rust::String_::fromStr(&v624);
                        let v627: std::string::String =
                            (&v625).to_string().clone();
                        let v628: colored::ColoredString =
                            colored::Colorize::color(&*v627, v114.clone().to_string());
                        let v629: std::string::String = format!("{}", &v628);
                        let v631: string =
                            fable_library_rust::String_::fromStr(&&v563);
                        let v633: &str = r#""([^"]+)", "([^"]+)""#;
                        let v634: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v633);
                        let v635: &regex::Regex = &v634.build().unwrap();
                        let v636: string = Cli::method3(v631);
                        let v637: &str = &v636.as_str();
                        let v638: string = Cli::method4();
                        let v639: &str = &v638.as_str();
                        let v640: std::string::String =
                            v635.replace_all(&v637, v639).to_string();
                        let v641: string =
                            fable_library_rust::String_::fromStr(&v640);
                        let v643: &str = r#"\["(.*?)"\]"#;
                        let v644: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v643);
                        let v645: &regex::Regex = &v644.build().unwrap();
                        let v646: string = Cli::method3(v641);
                        let v647: &str = &v646.as_str();
                        let v648: string = Cli::method5();
                        let v649: &str = &v648.as_str();
                        let v650: std::string::String =
                            v645.replace_all(&v647, v649).to_string();
                        let v651: string =
                            fable_library_rust::String_::fromStr(&v650);
                        let v653: &str = r#", "#;
                        let v654: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v653);
                        let v655: &regex::Regex = &v654.build().unwrap();
                        let v656: string = Cli::method3(v651);
                        let v657: &str = &v656.as_str();
                        let v658: string = Cli::method6();
                        let v659: &str = &v658.as_str();
                        let v660: std::string::String =
                            v655.replace_all(&v657, v659).to_string();
                        let v661: string =
                            fable_library_rust::String_::fromStr(&v660);
                        let v663: std::string::String =
                            (&v661).to_string().clone();
                        let v664: string =
                            substring2(v153.clone(), 0i32, 2i32);
                        let v665: u8 = u8::from_str_radix(&v664, 16).unwrap();
                        let v666: string =
                            substring2(v153.clone(), 2i32, 2i32);
                        let v667: u8 = u8::from_str_radix(&v666, 16).unwrap();
                        let v668: string =
                            substring2(v153.clone(), 4i32, 2i32);
                        let v669: u8 = u8::from_str_radix(&v668, 16).unwrap();
                        let v670: colored::ColoredString =
                            colored::Colorize::truecolor(&*v663.to_string(), v665, v667, v669);
                        let v671: std::string::String = format!("{}", &v670);
                        let v673: string =
                            fable_library_rust::String_::fromStr(&&v586);
                        let v675: &str = r#""([^"]+)", "([^"]+)""#;
                        let v676: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v675);
                        let v677: &regex::Regex = &v676.build().unwrap();
                        let v678: string = Cli::method3(v673);
                        let v679: &str = &v678.as_str();
                        let v680: string = Cli::method4();
                        let v681: &str = &v680.as_str();
                        let v682: std::string::String =
                            v677.replace_all(&v679, v681).to_string();
                        let v683: string =
                            fable_library_rust::String_::fromStr(&v682);
                        let v685: &str = r#"\["(.*?)"\]"#;
                        let v686: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v685);
                        let v687: &regex::Regex = &v686.build().unwrap();
                        let v688: string = Cli::method3(v683);
                        let v689: &str = &v688.as_str();
                        let v690: string = Cli::method5();
                        let v691: &str = &v690.as_str();
                        let v692: std::string::String =
                            v687.replace_all(&v689, v691).to_string();
                        let v693: string =
                            fable_library_rust::String_::fromStr(&v692);
                        let v695: &str = r#", "#;
                        let v696: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v695);
                        let v697: &regex::Regex = &v696.build().unwrap();
                        let v698: string = Cli::method3(v693);
                        let v699: &str = &v698.as_str();
                        let v700: string = Cli::method6();
                        let v701: &str = &v700.as_str();
                        let v702: std::string::String =
                            v697.replace_all(&v699, v701).to_string();
                        let v703: string =
                            fable_library_rust::String_::fromStr(&v702);
                        let v705: std::string::String =
                            (&v703).to_string().clone();
                        let v706: string =
                            substring2(v198.clone(), 0i32, 2i32);
                        let v707: u8 = u8::from_str_radix(&v706, 16).unwrap();
                        let v708: string =
                            substring2(v198.clone(), 2i32, 2i32);
                        let v709: u8 = u8::from_str_radix(&v708, 16).unwrap();
                        let v710: string =
                            substring2(v198.clone(), 4i32, 2i32);
                        let v711: u8 = u8::from_str_radix(&v710, 16).unwrap();
                        let v712: colored::ColoredString =
                            colored::Colorize::truecolor(&*v705.to_string(), v707, v709, v711);
                        let v713: std::string::String = format!("{}", &v712);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v629, &v671, &v713)));
                        {
                            let v716: Result<(), std::io::Error> =
                                std::fs::write(v12, v552.as_str());
                            *((&v716).as_ref()).unwrap();
                            {
                                let v719: std::string::String =
                                    (&string("> fs_write path text; ok")).to_string().clone();
                                let v720: chrono::DateTime<chrono::Utc> =
                                    chrono::Utc::now();
                                let v725: string =
                                    Cli::method2(6i32,
                                                 toString(&((&v720).timestamp()
                                                                - v7)));
                                let v726: u8 = rand::random::<u8>();
                                let v739: Array<std::string::String> =
                                    array(&[(&v45).to_string(),
                                            (&v725).to_string(),
                                            (&v50).to_string(),
                                            format!("{:?}", &v726),
                                            (&v56).to_string(),
                                            (&v59).to_string()]);
                                let v740 = core::ops::Deref::deref(&v739);
                                let v742: std::string::String =
                                    format!("{:?}", ***v740).clone();
                                let v745: Array<std::string::String> =
                                    array(&[(&v587).to_string()]);
                                let v746 = core::ops::Deref::deref(&v745);
                                let v749: std::string::String =
                                    format!("{:?}", ***v746).clone();
                                let v750: string =
                                    fable_library_rust::String_::fromStr(&v749);
                                let v752: &str = r#""([^"]+)", "([^"]+)""#;
                                let v753: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v752);
                                let v754: &regex::Regex =
                                    &v753.build().unwrap();
                                let v755: string = Cli::method3(v750);
                                let v756: &str = &v755.as_str();
                                let v757: string = Cli::method4();
                                let v758: &str = &v757.as_str();
                                let v759: std::string::String =
                                    v754.replace_all(&v756, v758).to_string();
                                let v760: string =
                                    fable_library_rust::String_::fromStr(&v759);
                                let v762: &str = r#"\["(.*?)"\]"#;
                                let v763: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v762);
                                let v764: &regex::Regex =
                                    &v763.build().unwrap();
                                let v765: string = Cli::method3(v760);
                                let v766: &str = &v765.as_str();
                                let v767: string = Cli::method5();
                                let v768: &str = &v767.as_str();
                                let v769: std::string::String =
                                    v764.replace_all(&v766, v768).to_string();
                                let v770: string =
                                    fable_library_rust::String_::fromStr(&v769);
                                let v772: &str = r#", "#;
                                let v773: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v772);
                                let v774: &regex::Regex =
                                    &v773.build().unwrap();
                                let v775: string = Cli::method3(v770);
                                let v776: &str = &v775.as_str();
                                let v777: string = Cli::method6();
                                let v778: &str = &v777.as_str();
                                let v779: std::string::String =
                                    v774.replace_all(&v776, v778).to_string();
                                let v780: string =
                                    fable_library_rust::String_::fromStr(&v779);
                                let v782: std::string::String =
                                    (&v780).to_string().clone();
                                let v783: colored::ColoredString =
                                    colored::Colorize::color(&*v782, v114.to_string());
                                let v784: std::string::String =
                                    format!("{}", &v783);
                                let v786: string =
                                    fable_library_rust::String_::fromStr(&&v719);
                                let v788: &str = r#""([^"]+)", "([^"]+)""#;
                                let v789: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v788);
                                let v790: &regex::Regex =
                                    &v789.build().unwrap();
                                let v791: string = Cli::method3(v786);
                                let v792: &str = &v791.as_str();
                                let v793: string = Cli::method4();
                                let v794: &str = &v793.as_str();
                                let v795: std::string::String =
                                    v790.replace_all(&v792, v794).to_string();
                                let v796: string =
                                    fable_library_rust::String_::fromStr(&v795);
                                let v798: &str = r#"\["(.*?)"\]"#;
                                let v799: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v798);
                                let v800: &regex::Regex =
                                    &v799.build().unwrap();
                                let v801: string = Cli::method3(v796);
                                let v802: &str = &v801.as_str();
                                let v803: string = Cli::method5();
                                let v804: &str = &v803.as_str();
                                let v805: std::string::String =
                                    v800.replace_all(&v802, v804).to_string();
                                let v806: string =
                                    fable_library_rust::String_::fromStr(&v805);
                                let v808: &str = r#", "#;
                                let v809: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v808);
                                let v810: &regex::Regex =
                                    &v809.build().unwrap();
                                let v811: string = Cli::method3(v806);
                                let v812: &str = &v811.as_str();
                                let v813: string = Cli::method6();
                                let v814: &str = &v813.as_str();
                                let v815: std::string::String =
                                    v810.replace_all(&v812, v814).to_string();
                                let v816: string =
                                    fable_library_rust::String_::fromStr(&v815);
                                let v818: std::string::String =
                                    (&v816).to_string().clone();
                                let v819: string =
                                    substring2(v153.clone(), 0i32, 2i32);
                                let v820: u8 =
                                    u8::from_str_radix(&v819, 16).unwrap();
                                let v821: string =
                                    substring2(v153.clone(), 2i32, 2i32);
                                let v822: u8 =
                                    u8::from_str_radix(&v821, 16).unwrap();
                                let v823: string =
                                    substring2(v153, 4i32, 2i32);
                                let v824: u8 =
                                    u8::from_str_radix(&v823, 16).unwrap();
                                let v825: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v818.to_string(), v820, v822, v824);
                                let v826: std::string::String =
                                    format!("{}", &v825);
                                let v828: string =
                                    fable_library_rust::String_::fromStr(&&v742);
                                let v830: &str = r#""([^"]+)", "([^"]+)""#;
                                let v831: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v830);
                                let v832: &regex::Regex =
                                    &v831.build().unwrap();
                                let v833: string = Cli::method3(v828);
                                let v834: &str = &v833.as_str();
                                let v835: string = Cli::method4();
                                let v836: &str = &v835.as_str();
                                let v837: std::string::String =
                                    v832.replace_all(&v834, v836).to_string();
                                let v838: string =
                                    fable_library_rust::String_::fromStr(&v837);
                                let v840: &str = r#"\["(.*?)"\]"#;
                                let v841: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v840);
                                let v842: &regex::Regex =
                                    &v841.build().unwrap();
                                let v843: string = Cli::method3(v838);
                                let v844: &str = &v843.as_str();
                                let v845: string = Cli::method5();
                                let v846: &str = &v845.as_str();
                                let v847: std::string::String =
                                    v842.replace_all(&v844, v846).to_string();
                                let v848: string =
                                    fable_library_rust::String_::fromStr(&v847);
                                let v850: &str = r#", "#;
                                let v851: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v850);
                                let v852: &regex::Regex =
                                    &v851.build().unwrap();
                                let v853: string = Cli::method3(v848);
                                let v854: &str = &v853.as_str();
                                let v855: string = Cli::method6();
                                let v856: &str = &v855.as_str();
                                let v857: std::string::String =
                                    v852.replace_all(&v854, v856).to_string();
                                let v858: string =
                                    fable_library_rust::String_::fromStr(&v857);
                                let v860: std::string::String =
                                    (&v858).to_string().clone();
                                let v861: string =
                                    substring2(v198.clone(), 0i32, 2i32);
                                let v862: u8 =
                                    u8::from_str_radix(&v861, 16).unwrap();
                                let v863: string =
                                    substring2(v198.clone(), 2i32, 2i32);
                                let v864: u8 =
                                    u8::from_str_radix(&v863, 16).unwrap();
                                let v865: string =
                                    substring2(v198, 4i32, 2i32);
                                let v866: u8 =
                                    u8::from_str_radix(&v865, 16).unwrap();
                                let v867: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v860.to_string(), v862, v864, v866);
                                let v868: std::string::String =
                                    format!("{}", &v867);
                                println!("{0}",
                                         stringFrom(format!("{0} {1} {2}", &v784, &v826, &v868)));
                                0i32
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
