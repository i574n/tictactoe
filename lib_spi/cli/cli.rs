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
    pub fn method11(v0_1: Lrc<Cli::UH1>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method11:
            loop  {
                break '_method11
                    (match v0_1.get().as_ref() {
                         Cli::UH1::UH1_1 => v1.get(),
                         Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                             let v1_temp: string =
                                 append(v1.get(), v0_1_0_0.clone());
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method11
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
                        let v546: string = Cli::method11(v383, string(""));
                        let v549: std::string::String =
                            (&string("text len")).to_string().clone();
                        let v551: i32 = (&v546).len().try_into().unwrap();
                        let v554: Array<std::string::String> =
                            array(&[v549, format!("{:?}", &v551)]);
                        let v555 = core::ops::Deref::deref(&v554);
                        let v557: std::string::String =
                            format!("{:?}", ***v555).clone();
                        let v558: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v563: string =
                            Cli::method2(6i32,
                                         toString(&((&v558).timestamp() -
                                                        v7)));
                        let v564: u8 = rand::random::<u8>();
                        let v577: Array<std::string::String> =
                            array(&[(&v45).to_string(), (&v563).to_string(),
                                    (&v50).to_string(),
                                    format!("{:?}", &v564),
                                    (&v56).to_string(), (&v59).to_string()]);
                        let v578 = core::ops::Deref::deref(&v577);
                        let v580: std::string::String =
                            format!("{:?}", ***v578).clone();
                        let v581: string = string("> app ()");
                        let v584: Array<std::string::String> =
                            array(&[(&v581).to_string()]);
                        let v585 = core::ops::Deref::deref(&v584);
                        let v588: std::string::String =
                            format!("{:?}", ***v585).clone();
                        let v589: string =
                            fable_library_rust::String_::fromStr(&v588);
                        let v591: &str = r#""([^"]+)", "([^"]+)""#;
                        let v592: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v591);
                        let v593: &regex::Regex = &v592.build().unwrap();
                        let v594: string = Cli::method3(v589);
                        let v595: &str = &v594.as_str();
                        let v596: string = Cli::method4();
                        let v597: &str = &v596.as_str();
                        let v598: std::string::String =
                            v593.replace_all(&v595, v597).to_string();
                        let v599: string =
                            fable_library_rust::String_::fromStr(&v598);
                        let v601: &str = r#"\["(.*?)"\]"#;
                        let v602: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v601);
                        let v603: &regex::Regex = &v602.build().unwrap();
                        let v604: string = Cli::method3(v599);
                        let v605: &str = &v604.as_str();
                        let v606: string = Cli::method5();
                        let v607: &str = &v606.as_str();
                        let v608: std::string::String =
                            v603.replace_all(&v605, v607).to_string();
                        let v609: string =
                            fable_library_rust::String_::fromStr(&v608);
                        let v611: &str = r#", "#;
                        let v612: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v611);
                        let v613: &regex::Regex = &v612.build().unwrap();
                        let v614: string = Cli::method3(v609);
                        let v615: &str = &v614.as_str();
                        let v616: string = Cli::method6();
                        let v617: &str = &v616.as_str();
                        let v618: std::string::String =
                            v613.replace_all(&v615, v617).to_string();
                        let v619: string =
                            fable_library_rust::String_::fromStr(&v618);
                        let v621: std::string::String =
                            (&v619).to_string().clone();
                        let v622: colored::ColoredString =
                            colored::Colorize::color(&*v621, v114.clone().to_string());
                        let v623: std::string::String = format!("{}", &v622);
                        let v625: string =
                            fable_library_rust::String_::fromStr(&&v557);
                        let v627: &str = r#""([^"]+)", "([^"]+)""#;
                        let v628: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v627);
                        let v629: &regex::Regex = &v628.build().unwrap();
                        let v630: string = Cli::method3(v625);
                        let v631: &str = &v630.as_str();
                        let v632: string = Cli::method4();
                        let v633: &str = &v632.as_str();
                        let v634: std::string::String =
                            v629.replace_all(&v631, v633).to_string();
                        let v635: string =
                            fable_library_rust::String_::fromStr(&v634);
                        let v637: &str = r#"\["(.*?)"\]"#;
                        let v638: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v637);
                        let v639: &regex::Regex = &v638.build().unwrap();
                        let v640: string = Cli::method3(v635);
                        let v641: &str = &v640.as_str();
                        let v642: string = Cli::method5();
                        let v643: &str = &v642.as_str();
                        let v644: std::string::String =
                            v639.replace_all(&v641, v643).to_string();
                        let v645: string =
                            fable_library_rust::String_::fromStr(&v644);
                        let v647: &str = r#", "#;
                        let v648: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v647);
                        let v649: &regex::Regex = &v648.build().unwrap();
                        let v650: string = Cli::method3(v645);
                        let v651: &str = &v650.as_str();
                        let v652: string = Cli::method6();
                        let v653: &str = &v652.as_str();
                        let v654: std::string::String =
                            v649.replace_all(&v651, v653).to_string();
                        let v655: string =
                            fable_library_rust::String_::fromStr(&v654);
                        let v657: std::string::String =
                            (&v655).to_string().clone();
                        let v658: string =
                            substring2(v153.clone(), 0i32, 2i32);
                        let v659: u8 = u8::from_str_radix(&v658, 16).unwrap();
                        let v660: string =
                            substring2(v153.clone(), 2i32, 2i32);
                        let v661: u8 = u8::from_str_radix(&v660, 16).unwrap();
                        let v662: string =
                            substring2(v153.clone(), 4i32, 2i32);
                        let v663: u8 = u8::from_str_radix(&v662, 16).unwrap();
                        let v664: colored::ColoredString =
                            colored::Colorize::truecolor(&*v657.to_string(), v659, v661, v663);
                        let v665: std::string::String = format!("{}", &v664);
                        let v667: string =
                            fable_library_rust::String_::fromStr(&&v580);
                        let v669: &str = r#""([^"]+)", "([^"]+)""#;
                        let v670: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v669);
                        let v671: &regex::Regex = &v670.build().unwrap();
                        let v672: string = Cli::method3(v667);
                        let v673: &str = &v672.as_str();
                        let v674: string = Cli::method4();
                        let v675: &str = &v674.as_str();
                        let v676: std::string::String =
                            v671.replace_all(&v673, v675).to_string();
                        let v677: string =
                            fable_library_rust::String_::fromStr(&v676);
                        let v679: &str = r#"\["(.*?)"\]"#;
                        let v680: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v679);
                        let v681: &regex::Regex = &v680.build().unwrap();
                        let v682: string = Cli::method3(v677);
                        let v683: &str = &v682.as_str();
                        let v684: string = Cli::method5();
                        let v685: &str = &v684.as_str();
                        let v686: std::string::String =
                            v681.replace_all(&v683, v685).to_string();
                        let v687: string =
                            fable_library_rust::String_::fromStr(&v686);
                        let v689: &str = r#", "#;
                        let v690: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v689);
                        let v691: &regex::Regex = &v690.build().unwrap();
                        let v692: string = Cli::method3(v687);
                        let v693: &str = &v692.as_str();
                        let v694: string = Cli::method6();
                        let v695: &str = &v694.as_str();
                        let v696: std::string::String =
                            v691.replace_all(&v693, v695).to_string();
                        let v697: string =
                            fable_library_rust::String_::fromStr(&v696);
                        let v699: std::string::String =
                            (&v697).to_string().clone();
                        let v700: string =
                            substring2(v198.clone(), 0i32, 2i32);
                        let v701: u8 = u8::from_str_radix(&v700, 16).unwrap();
                        let v702: string =
                            substring2(v198.clone(), 2i32, 2i32);
                        let v703: u8 = u8::from_str_radix(&v702, 16).unwrap();
                        let v704: string =
                            substring2(v198.clone(), 4i32, 2i32);
                        let v705: u8 = u8::from_str_radix(&v704, 16).unwrap();
                        let v706: colored::ColoredString =
                            colored::Colorize::truecolor(&*v699.to_string(), v701, v703, v705);
                        let v707: std::string::String = format!("{}", &v706);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v623, &v665, &v707)));
                        {
                            let v714: Array<std::string::String> =
                                array(&[(&string("text")).to_string(),
                                        (&v546).to_string()]);
                            let v715 = core::ops::Deref::deref(&v714);
                            let v717: std::string::String =
                                format!("{:?}", ***v715).clone();
                            let v718: chrono::DateTime<chrono::Utc> =
                                chrono::Utc::now();
                            let v723: string =
                                Cli::method2(6i32,
                                             toString(&((&v718).timestamp() -
                                                            v7)));
                            let v724: u8 = rand::random::<u8>();
                            let v737: Array<std::string::String> =
                                array(&[(&v45).to_string(),
                                        (&v723).to_string(),
                                        (&v50).to_string(),
                                        format!("{:?}", &v724),
                                        (&v56).to_string(),
                                        (&v59).to_string()]);
                            let v738 = core::ops::Deref::deref(&v737);
                            let v740: std::string::String =
                                format!("{:?}", ***v738).clone();
                            let v743: Array<std::string::String> =
                                array(&[(&v581).to_string()]);
                            let v744 = core::ops::Deref::deref(&v743);
                            let v747: std::string::String =
                                format!("{:?}", ***v744).clone();
                            let v748: string =
                                fable_library_rust::String_::fromStr(&v747);
                            let v750: &str = r#""([^"]+)", "([^"]+)""#;
                            let v751: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v750);
                            let v752: &regex::Regex = &v751.build().unwrap();
                            let v753: string = Cli::method3(v748);
                            let v754: &str = &v753.as_str();
                            let v755: string = Cli::method4();
                            let v756: &str = &v755.as_str();
                            let v757: std::string::String =
                                v752.replace_all(&v754, v756).to_string();
                            let v758: string =
                                fable_library_rust::String_::fromStr(&v757);
                            let v760: &str = r#"\["(.*?)"\]"#;
                            let v761: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v760);
                            let v762: &regex::Regex = &v761.build().unwrap();
                            let v763: string = Cli::method3(v758);
                            let v764: &str = &v763.as_str();
                            let v765: string = Cli::method5();
                            let v766: &str = &v765.as_str();
                            let v767: std::string::String =
                                v762.replace_all(&v764, v766).to_string();
                            let v768: string =
                                fable_library_rust::String_::fromStr(&v767);
                            let v770: &str = r#", "#;
                            let v771: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v770);
                            let v772: &regex::Regex = &v771.build().unwrap();
                            let v773: string = Cli::method3(v768);
                            let v774: &str = &v773.as_str();
                            let v775: string = Cli::method6();
                            let v776: &str = &v775.as_str();
                            let v777: std::string::String =
                                v772.replace_all(&v774, v776).to_string();
                            let v778: string =
                                fable_library_rust::String_::fromStr(&v777);
                            let v780: std::string::String =
                                (&v778).to_string().clone();
                            let v781: colored::ColoredString =
                                colored::Colorize::color(&*v780, v114.to_string());
                            let v782: std::string::String =
                                format!("{}", &v781);
                            let v784: string =
                                fable_library_rust::String_::fromStr(&&v717);
                            let v786: &str = r#""([^"]+)", "([^"]+)""#;
                            let v787: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v786);
                            let v788: &regex::Regex = &v787.build().unwrap();
                            let v789: string = Cli::method3(v784);
                            let v790: &str = &v789.as_str();
                            let v791: string = Cli::method4();
                            let v792: &str = &v791.as_str();
                            let v793: std::string::String =
                                v788.replace_all(&v790, v792).to_string();
                            let v794: string =
                                fable_library_rust::String_::fromStr(&v793);
                            let v796: &str = r#"\["(.*?)"\]"#;
                            let v797: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v796);
                            let v798: &regex::Regex = &v797.build().unwrap();
                            let v799: string = Cli::method3(v794);
                            let v800: &str = &v799.as_str();
                            let v801: string = Cli::method5();
                            let v802: &str = &v801.as_str();
                            let v803: std::string::String =
                                v798.replace_all(&v800, v802).to_string();
                            let v804: string =
                                fable_library_rust::String_::fromStr(&v803);
                            let v806: &str = r#", "#;
                            let v807: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v806);
                            let v808: &regex::Regex = &v807.build().unwrap();
                            let v809: string = Cli::method3(v804);
                            let v810: &str = &v809.as_str();
                            let v811: string = Cli::method6();
                            let v812: &str = &v811.as_str();
                            let v813: std::string::String =
                                v808.replace_all(&v810, v812).to_string();
                            let v814: string =
                                fable_library_rust::String_::fromStr(&v813);
                            let v816: std::string::String =
                                (&v814).to_string().clone();
                            let v817: string =
                                substring2(v153.clone(), 0i32, 2i32);
                            let v818: u8 =
                                u8::from_str_radix(&v817, 16).unwrap();
                            let v819: string =
                                substring2(v153.clone(), 2i32, 2i32);
                            let v820: u8 =
                                u8::from_str_radix(&v819, 16).unwrap();
                            let v821: string = substring2(v153, 4i32, 2i32);
                            let v822: u8 =
                                u8::from_str_radix(&v821, 16).unwrap();
                            let v823: colored::ColoredString =
                                colored::Colorize::truecolor(&*v816.to_string(), v818, v820, v822);
                            let v824: std::string::String =
                                format!("{}", &v823);
                            let v826: string =
                                fable_library_rust::String_::fromStr(&&v740);
                            let v828: &str = r#""([^"]+)", "([^"]+)""#;
                            let v829: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v828);
                            let v830: &regex::Regex = &v829.build().unwrap();
                            let v831: string = Cli::method3(v826);
                            let v832: &str = &v831.as_str();
                            let v833: string = Cli::method4();
                            let v834: &str = &v833.as_str();
                            let v835: std::string::String =
                                v830.replace_all(&v832, v834).to_string();
                            let v836: string =
                                fable_library_rust::String_::fromStr(&v835);
                            let v838: &str = r#"\["(.*?)"\]"#;
                            let v839: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v838);
                            let v840: &regex::Regex = &v839.build().unwrap();
                            let v841: string = Cli::method3(v836);
                            let v842: &str = &v841.as_str();
                            let v843: string = Cli::method5();
                            let v844: &str = &v843.as_str();
                            let v845: std::string::String =
                                v840.replace_all(&v842, v844).to_string();
                            let v846: string =
                                fable_library_rust::String_::fromStr(&v845);
                            let v848: &str = r#", "#;
                            let v849: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v848);
                            let v850: &regex::Regex = &v849.build().unwrap();
                            let v851: string = Cli::method3(v846);
                            let v852: &str = &v851.as_str();
                            let v853: string = Cli::method6();
                            let v854: &str = &v853.as_str();
                            let v855: std::string::String =
                                v850.replace_all(&v852, v854).to_string();
                            let v856: string =
                                fable_library_rust::String_::fromStr(&v855);
                            let v858: std::string::String =
                                (&v856).to_string().clone();
                            let v859: string =
                                substring2(v198.clone(), 0i32, 2i32);
                            let v860: u8 =
                                u8::from_str_radix(&v859, 16).unwrap();
                            let v861: string =
                                substring2(v198.clone(), 2i32, 2i32);
                            let v862: u8 =
                                u8::from_str_radix(&v861, 16).unwrap();
                            let v863: string = substring2(v198, 4i32, 2i32);
                            let v864: u8 =
                                u8::from_str_radix(&v863, 16).unwrap();
                            let v865: colored::ColoredString =
                                colored::Colorize::truecolor(&*v858.to_string(), v860, v862, v864);
                            let v866: std::string::String =
                                format!("{}", &v865);
                            println!("{0}",
                                     stringFrom(format!("{0} {1} {2}", &v782, &v824, &v866)));
                            0i32
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
