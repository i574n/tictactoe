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
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1() -> string { string("./cli.rs") }
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
    pub fn method9(v0_1: Lrc<Cli::UH0>, v1: i32) -> i32 {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method9:
            loop  {
                break '_method9
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: i32 = v1.get() + 1i32;
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method9
                         }
                     }) ;
            }
    }
    pub fn method10(v0_1: Lrc<Cli::UH0>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method10:
            loop  {
                break '_method10
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: string =
                                 stringFrom(format!("{0}{1}", &v1.get(),
                                                    v0_1_0_0));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method10
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
                    let v381: Lrc<Cli::UH0> =
                        Cli::method8(v374.l0.get().clone(),
                                     Lrc::new(Cli::UH0::UH0_1));
                    let v384: std::string::String =
                        (&string("lines len")).to_string().clone();
                    let v386: i32 = Cli::method9(v381.clone(), 0i32);
                    let v389: Array<std::string::String> =
                        array(&[v384, format!("{:?}", &v386)]);
                    let v390 = core::ops::Deref::deref(&v389);
                    let v392: std::string::String =
                        format!("{:?}", ***v390).clone();
                    let v393: chrono::DateTime<chrono::Utc> =
                        chrono::Utc::now();
                    let v398: string =
                        Cli::method2(6i32,
                                     toString(&((&v393).timestamp() - v18)));
                    let v399: u8 = rand::random::<u8>();
                    let v412: Array<std::string::String> =
                        array(&[(&v45).to_string(), (&v398).to_string(),
                                (&v50).to_string(), format!("{:?}", &v399),
                                (&v56).to_string(), (&v59).to_string()]);
                    let v413 = core::ops::Deref::deref(&v412);
                    let v415: std::string::String =
                        format!("{:?}", ***v413).clone();
                    let v418: Array<std::string::String> =
                        array(&[(&v66).to_string()]);
                    let v419 = core::ops::Deref::deref(&v418);
                    let v422: std::string::String =
                        format!("{:?}", ***v419).clone();
                    let v423: string =
                        fable_library_rust::String_::fromStr(&v422);
                    let v425: &str = r#""([^"]+)", "([^"]+)""#;
                    let v426: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v425);
                    let v427: &regex::Regex = &v426.build().unwrap();
                    let v428: string = Cli::method3(v423);
                    let v429: &str = &v428.as_str();
                    let v430: string = Cli::method4();
                    let v431: &str = &v430.as_str();
                    let v432: std::string::String =
                        v427.replace_all(&v429, v431).to_string();
                    let v433: string =
                        fable_library_rust::String_::fromStr(&v432);
                    let v435: &str = r#"\["(.*?)"\]"#;
                    let v436: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v435);
                    let v437: &regex::Regex = &v436.build().unwrap();
                    let v438: string = Cli::method3(v433);
                    let v439: &str = &v438.as_str();
                    let v440: string = Cli::method5();
                    let v441: &str = &v440.as_str();
                    let v442: std::string::String =
                        v437.replace_all(&v439, v441).to_string();
                    let v443: string =
                        fable_library_rust::String_::fromStr(&v442);
                    let v445: &str = r#", "#;
                    let v446: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v445);
                    let v447: &regex::Regex = &v446.build().unwrap();
                    let v448: string = Cli::method3(v443);
                    let v449: &str = &v448.as_str();
                    let v450: string = Cli::method6();
                    let v451: &str = &v450.as_str();
                    let v452: std::string::String =
                        v447.replace_all(&v449, v451).to_string();
                    let v453: string =
                        fable_library_rust::String_::fromStr(&v452);
                    let v455: std::string::String =
                        (&v453).to_string().clone();
                    let v456: colored::ColoredString =
                        colored::Colorize::color(&*v455, v114.clone().to_string());
                    let v457: std::string::String = format!("{}", &v456);
                    let v459: string =
                        fable_library_rust::String_::fromStr(&&v392);
                    let v461: &str = r#""([^"]+)", "([^"]+)""#;
                    let v462: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v461);
                    let v463: &regex::Regex = &v462.build().unwrap();
                    let v464: string = Cli::method3(v459);
                    let v465: &str = &v464.as_str();
                    let v466: string = Cli::method4();
                    let v467: &str = &v466.as_str();
                    let v468: std::string::String =
                        v463.replace_all(&v465, v467).to_string();
                    let v469: string =
                        fable_library_rust::String_::fromStr(&v468);
                    let v471: &str = r#"\["(.*?)"\]"#;
                    let v472: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v471);
                    let v473: &regex::Regex = &v472.build().unwrap();
                    let v474: string = Cli::method3(v469);
                    let v475: &str = &v474.as_str();
                    let v476: string = Cli::method5();
                    let v477: &str = &v476.as_str();
                    let v478: std::string::String =
                        v473.replace_all(&v475, v477).to_string();
                    let v479: string =
                        fable_library_rust::String_::fromStr(&v478);
                    let v481: &str = r#", "#;
                    let v482: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v481);
                    let v483: &regex::Regex = &v482.build().unwrap();
                    let v484: string = Cli::method3(v479);
                    let v485: &str = &v484.as_str();
                    let v486: string = Cli::method6();
                    let v487: &str = &v486.as_str();
                    let v488: std::string::String =
                        v483.replace_all(&v485, v487).to_string();
                    let v489: string =
                        fable_library_rust::String_::fromStr(&v488);
                    let v491: std::string::String =
                        (&v489).to_string().clone();
                    let v492: string = substring2(v153.clone(), 0i32, 2i32);
                    let v493: u8 = u8::from_str_radix(&v492, 16).unwrap();
                    let v494: string = substring2(v153.clone(), 2i32, 2i32);
                    let v495: u8 = u8::from_str_radix(&v494, 16).unwrap();
                    let v496: string = substring2(v153.clone(), 4i32, 2i32);
                    let v497: u8 = u8::from_str_radix(&v496, 16).unwrap();
                    let v498: colored::ColoredString =
                        colored::Colorize::truecolor(&*v491.to_string(), v493, v495, v497);
                    let v499: std::string::String = format!("{}", &v498);
                    let v501: string =
                        fable_library_rust::String_::fromStr(&&v415);
                    let v503: &str = r#""([^"]+)", "([^"]+)""#;
                    let v504: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v503);
                    let v505: &regex::Regex = &v504.build().unwrap();
                    let v506: string = Cli::method3(v501);
                    let v507: &str = &v506.as_str();
                    let v508: string = Cli::method4();
                    let v509: &str = &v508.as_str();
                    let v510: std::string::String =
                        v505.replace_all(&v507, v509).to_string();
                    let v511: string =
                        fable_library_rust::String_::fromStr(&v510);
                    let v513: &str = r#"\["(.*?)"\]"#;
                    let v514: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v513);
                    let v515: &regex::Regex = &v514.build().unwrap();
                    let v516: string = Cli::method3(v511);
                    let v517: &str = &v516.as_str();
                    let v518: string = Cli::method5();
                    let v519: &str = &v518.as_str();
                    let v520: std::string::String =
                        v515.replace_all(&v517, v519).to_string();
                    let v521: string =
                        fable_library_rust::String_::fromStr(&v520);
                    let v523: &str = r#", "#;
                    let v524: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v523);
                    let v525: &regex::Regex = &v524.build().unwrap();
                    let v526: string = Cli::method3(v521);
                    let v527: &str = &v526.as_str();
                    let v528: string = Cli::method6();
                    let v529: &str = &v528.as_str();
                    let v530: std::string::String =
                        v525.replace_all(&v527, v529).to_string();
                    let v531: string =
                        fable_library_rust::String_::fromStr(&v530);
                    let v533: std::string::String =
                        (&v531).to_string().clone();
                    let v534: string = substring2(v198.clone(), 0i32, 2i32);
                    let v535: u8 = u8::from_str_radix(&v534, 16).unwrap();
                    let v536: string = substring2(v198.clone(), 2i32, 2i32);
                    let v537: u8 = u8::from_str_radix(&v536, 16).unwrap();
                    let v538: string = substring2(v198.clone(), 4i32, 2i32);
                    let v539: u8 = u8::from_str_radix(&v538, 16).unwrap();
                    let v540: colored::ColoredString =
                        colored::Colorize::truecolor(&*v533.to_string(), v535, v537, v539);
                    let v541: std::string::String = format!("{}", &v540);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v457, &v499, &v541)));
                    {
                        let v544: string = Cli::method10(v381, string(""));
                        let v547: std::string::String =
                            (&string("text len")).to_string().clone();
                        let v549: i32 = (&v544).len().try_into().unwrap();
                        let v552: Array<std::string::String> =
                            array(&[v547, format!("{:?}", &v549)]);
                        let v553 = core::ops::Deref::deref(&v552);
                        let v555: std::string::String =
                            format!("{:?}", ***v553).clone();
                        let v556: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v561: string =
                            Cli::method2(6i32,
                                         toString(&((&v556).timestamp() -
                                                        v7)));
                        let v562: u8 = rand::random::<u8>();
                        let v575: Array<std::string::String> =
                            array(&[(&v45).to_string(), (&v561).to_string(),
                                    (&v50).to_string(),
                                    format!("{:?}", &v562),
                                    (&v56).to_string(), (&v59).to_string()]);
                        let v576 = core::ops::Deref::deref(&v575);
                        let v578: std::string::String =
                            format!("{:?}", ***v576).clone();
                        let v582: Array<std::string::String> =
                            array(&[(&string("> app ()")).to_string()]);
                        let v583 = core::ops::Deref::deref(&v582);
                        let v586: std::string::String =
                            format!("{:?}", ***v583).clone();
                        let v587: string =
                            fable_library_rust::String_::fromStr(&v586);
                        let v589: &str = r#""([^"]+)", "([^"]+)""#;
                        let v590: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v589);
                        let v591: &regex::Regex = &v590.build().unwrap();
                        let v592: string = Cli::method3(v587);
                        let v593: &str = &v592.as_str();
                        let v594: string = Cli::method4();
                        let v595: &str = &v594.as_str();
                        let v596: std::string::String =
                            v591.replace_all(&v593, v595).to_string();
                        let v597: string =
                            fable_library_rust::String_::fromStr(&v596);
                        let v599: &str = r#"\["(.*?)"\]"#;
                        let v600: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v599);
                        let v601: &regex::Regex = &v600.build().unwrap();
                        let v602: string = Cli::method3(v597);
                        let v603: &str = &v602.as_str();
                        let v604: string = Cli::method5();
                        let v605: &str = &v604.as_str();
                        let v606: std::string::String =
                            v601.replace_all(&v603, v605).to_string();
                        let v607: string =
                            fable_library_rust::String_::fromStr(&v606);
                        let v609: &str = r#", "#;
                        let v610: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v609);
                        let v611: &regex::Regex = &v610.build().unwrap();
                        let v612: string = Cli::method3(v607);
                        let v613: &str = &v612.as_str();
                        let v614: string = Cli::method6();
                        let v615: &str = &v614.as_str();
                        let v616: std::string::String =
                            v611.replace_all(&v613, v615).to_string();
                        let v617: string =
                            fable_library_rust::String_::fromStr(&v616);
                        let v619: std::string::String =
                            (&v617).to_string().clone();
                        let v620: colored::ColoredString =
                            colored::Colorize::color(&*v619, v114.to_string());
                        let v621: std::string::String = format!("{}", &v620);
                        let v623: string =
                            fable_library_rust::String_::fromStr(&&v555);
                        let v625: &str = r#""([^"]+)", "([^"]+)""#;
                        let v626: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v625);
                        let v627: &regex::Regex = &v626.build().unwrap();
                        let v628: string = Cli::method3(v623);
                        let v629: &str = &v628.as_str();
                        let v630: string = Cli::method4();
                        let v631: &str = &v630.as_str();
                        let v632: std::string::String =
                            v627.replace_all(&v629, v631).to_string();
                        let v633: string =
                            fable_library_rust::String_::fromStr(&v632);
                        let v635: &str = r#"\["(.*?)"\]"#;
                        let v636: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v635);
                        let v637: &regex::Regex = &v636.build().unwrap();
                        let v638: string = Cli::method3(v633);
                        let v639: &str = &v638.as_str();
                        let v640: string = Cli::method5();
                        let v641: &str = &v640.as_str();
                        let v642: std::string::String =
                            v637.replace_all(&v639, v641).to_string();
                        let v643: string =
                            fable_library_rust::String_::fromStr(&v642);
                        let v645: &str = r#", "#;
                        let v646: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v645);
                        let v647: &regex::Regex = &v646.build().unwrap();
                        let v648: string = Cli::method3(v643);
                        let v649: &str = &v648.as_str();
                        let v650: string = Cli::method6();
                        let v651: &str = &v650.as_str();
                        let v652: std::string::String =
                            v647.replace_all(&v649, v651).to_string();
                        let v653: string =
                            fable_library_rust::String_::fromStr(&v652);
                        let v655: std::string::String =
                            (&v653).to_string().clone();
                        let v656: string =
                            substring2(v153.clone(), 0i32, 2i32);
                        let v657: u8 = u8::from_str_radix(&v656, 16).unwrap();
                        let v658: string =
                            substring2(v153.clone(), 2i32, 2i32);
                        let v659: u8 = u8::from_str_radix(&v658, 16).unwrap();
                        let v660: string = substring2(v153, 4i32, 2i32);
                        let v661: u8 = u8::from_str_radix(&v660, 16).unwrap();
                        let v662: colored::ColoredString =
                            colored::Colorize::truecolor(&*v655.to_string(), v657, v659, v661);
                        let v663: std::string::String = format!("{}", &v662);
                        let v665: string =
                            fable_library_rust::String_::fromStr(&&v578);
                        let v667: &str = r#""([^"]+)", "([^"]+)""#;
                        let v668: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v667);
                        let v669: &regex::Regex = &v668.build().unwrap();
                        let v670: string = Cli::method3(v665);
                        let v671: &str = &v670.as_str();
                        let v672: string = Cli::method4();
                        let v673: &str = &v672.as_str();
                        let v674: std::string::String =
                            v669.replace_all(&v671, v673).to_string();
                        let v675: string =
                            fable_library_rust::String_::fromStr(&v674);
                        let v677: &str = r#"\["(.*?)"\]"#;
                        let v678: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v677);
                        let v679: &regex::Regex = &v678.build().unwrap();
                        let v680: string = Cli::method3(v675);
                        let v681: &str = &v680.as_str();
                        let v682: string = Cli::method5();
                        let v683: &str = &v682.as_str();
                        let v684: std::string::String =
                            v679.replace_all(&v681, v683).to_string();
                        let v685: string =
                            fable_library_rust::String_::fromStr(&v684);
                        let v687: &str = r#", "#;
                        let v688: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v687);
                        let v689: &regex::Regex = &v688.build().unwrap();
                        let v690: string = Cli::method3(v685);
                        let v691: &str = &v690.as_str();
                        let v692: string = Cli::method6();
                        let v693: &str = &v692.as_str();
                        let v694: std::string::String =
                            v689.replace_all(&v691, v693).to_string();
                        let v695: string =
                            fable_library_rust::String_::fromStr(&v694);
                        let v697: std::string::String =
                            (&v695).to_string().clone();
                        let v698: string =
                            substring2(v198.clone(), 0i32, 2i32);
                        let v699: u8 = u8::from_str_radix(&v698, 16).unwrap();
                        let v700: string =
                            substring2(v198.clone(), 2i32, 2i32);
                        let v701: u8 = u8::from_str_radix(&v700, 16).unwrap();
                        let v702: string = substring2(v198, 4i32, 2i32);
                        let v703: u8 = u8::from_str_radix(&v702, 16).unwrap();
                        let v704: colored::ColoredString =
                            colored::Colorize::truecolor(&*v697.to_string(), v699, v701, v703);
                        let v705: std::string::String = format!("{}", &v704);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v621, &v663, &v705)));
                        0i32
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
