#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Supervisor {
    use super::*;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Range_::rangeNumeric;
    use fable_library_rust::Seq_::toArray;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 { US0_0, US0_1(string), }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub struct Mut0 {
        pub l0: MutCell<i32>,
        pub l1: MutCell<Supervisor::US0>,
    }
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method1:
            loop  {
                break '_method1
                    (if length(v1.get()) < v0_1.get() {
                         let v0_1_temp: i32 = v0_1.get();
                         let v1_temp: string =
                             stringFrom(format!("0{0}", &v1.get()));
                         v0_1.set(v0_1_temp);
                         v1.set(v1_temp);
                         continue '_method1
                     } else { v1.get() }) ;
            }
    }
    pub fn method2(v0_1: string) -> string { v0_1 }
    pub fn method3() -> string { string("$1=$2") }
    pub fn method4() -> string { string("[$1]") }
    pub fn method5() -> string { string(" ") }
    pub fn method6() -> string { string("de884c") }
    pub fn method7() -> string { string("222222") }
    pub fn closure2(unitVar: (), v0_1: &std::path::Path)
     -> std::path::PathBuf {
        v0_1.join(string("package.spiproj").as_str())
    }
    pub fn closure3(unitVar: (), v0_1: &std::path::PathBuf) -> bool {
        std::path::Path::exists(&v0_1)
    }
    pub fn method8() -> string { string("e36a62") }
    pub fn method9() -> string { string("fcfb1b") }
    pub fn method10() -> string { string("98d5ef") }
    pub fn method11() -> string { string("387957") }
    pub fn method12(v0_1: i32, v1: Lrc<Supervisor::Mut0>) -> bool {
        v1.l0.get() < v0_1
    }
    pub fn closure1(v0_1: std::path::PathBuf, v1: Option<std::path::PathBuf>)
     -> string {
        let patternInput: (string, string, string, bool) =
            Supervisor::method0();
        let v7: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: i64 = (&v7).timestamp();
        let v13: std::string::String = (&string("pwd")).to_string().clone();
        let v15: Result<std::path::PathBuf, std::io::Error> =
            std::env::current_dir();
        let v17: std::path::PathBuf = (&v15).as_ref().unwrap().to_path_buf();
        let v19: Result<std::path::PathBuf, std::io::Error> =
            (&v17).canonicalize();
        let v20: std::path::PathBuf = (&v19).as_ref().unwrap().to_path_buf();
        let v22: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v20.display()));
        let v24: std::string::String = (&v22).to_string().clone();
        let v25: string = string("spi_path");
        let v27: std::string::String = (&v25).to_string().clone();
        let v28: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v0_1.display()));
        let v30: std::string::String = (&v28).to_string().clone();
        let v33: std::string::String =
            (&string("new_fsx_path")).to_string().clone();
        let v34: std::path::PathBuf = (&v1).as_ref().unwrap().to_path_buf();
        let v35: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v34.display()));
        let v38: Array<std::string::String> =
            array(&[v13, v24, v27, v30, v33, (&v35).to_string()]);
        let v40 = core::ops::Deref::deref(&v38);
        let v43: std::string::String = format!("{:?}", ***v40).clone();
        let v44: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v49: string =
            Supervisor::method1(6i32, toString(&((&v44).timestamp() - v9)));
        let v51: u8 = rand::random::<u8>();
        let v52: string = string("timestamp");
        let v57: string = string("run_id");
        let v63: string = string("log_level");
        let v66: string = string("Debug");
        let v69: Array<std::string::String> =
            array(&[(&v52).to_string(), (&v49).to_string(),
                    (&v57).to_string(), format!("{:?}", &v51),
                    (&v63).to_string(), (&v66).to_string()]);
        let v70 = core::ops::Deref::deref(&v69);
        let v72: std::string::String = format!("{:?}", ***v70).clone();
        let v73: string = string("> spi_to_fsx ()");
        let v76: Array<std::string::String> = array(&[(&v73).to_string()]);
        let v77 = core::ops::Deref::deref(&v76);
        let v80: std::string::String = format!("{:?}", ***v77).clone();
        let v82: string = fable_library_rust::String_::fromStr(&v80);
        let v85: &str = r#""([^"]+)", "([^"]+)""#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v85);
        let v89: &regex::Regex = &v87.build().unwrap();
        let v90: string = Supervisor::method2(v82);
        let v92: &str = &v90.as_str();
        let v93: string = Supervisor::method3();
        let v94: &str = &v93.as_str();
        let v96: std::string::String = v89.replace_all(&v92, v94).to_string();
        let v97: string = fable_library_rust::String_::fromStr(&v96);
        let v100: &str = r#"\["(.*?)"\]"#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Supervisor::method2(v97);
        let v104: &str = &v103.as_str();
        let v105: string = Supervisor::method4();
        let v106: &str = &v105.as_str();
        let v107: std::string::String =
            v102.replace_all(&v104, v106).to_string();
        let v108: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#", "#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Supervisor::method2(v108);
        let v115: &str = &v114.as_str();
        let v116: string = Supervisor::method5();
        let v117: &str = &v116.as_str();
        let v118: std::string::String =
            v113.replace_all(&v115, v117).to_string();
        let v119: string = fable_library_rust::String_::fromStr(&v118);
        let v121: std::string::String = (&v119).to_string().clone();
        let v122: string = string("purple");
        let v124: colored::ColoredString =
            colored::Colorize::color(&*v121, v122.clone().to_string());
        let v126: std::string::String = format!("{}", &v124);
        let v128: string = fable_library_rust::String_::fromStr(&&v43);
        let v130: &str = r#""([^"]+)", "([^"]+)""#;
        let v131: regex::RegexBuilder = regex::RegexBuilder::new(&v130);
        let v132: &regex::Regex = &v131.build().unwrap();
        let v133: string = Supervisor::method2(v128);
        let v134: &str = &v133.as_str();
        let v135: string = Supervisor::method3();
        let v136: &str = &v135.as_str();
        let v137: std::string::String =
            v132.replace_all(&v134, v136).to_string();
        let v138: string = fable_library_rust::String_::fromStr(&v137);
        let v140: &str = r#"\["(.*?)"\]"#;
        let v141: regex::RegexBuilder = regex::RegexBuilder::new(&v140);
        let v142: &regex::Regex = &v141.build().unwrap();
        let v143: string = Supervisor::method2(v138);
        let v144: &str = &v143.as_str();
        let v145: string = Supervisor::method4();
        let v146: &str = &v145.as_str();
        let v147: std::string::String =
            v142.replace_all(&v144, v146).to_string();
        let v148: string = fable_library_rust::String_::fromStr(&v147);
        let v150: &str = r#", "#;
        let v151: regex::RegexBuilder = regex::RegexBuilder::new(&v150);
        let v152: &regex::Regex = &v151.build().unwrap();
        let v153: string = Supervisor::method2(v148);
        let v154: &str = &v153.as_str();
        let v155: string = Supervisor::method5();
        let v156: &str = &v155.as_str();
        let v157: std::string::String =
            v152.replace_all(&v154, v156).to_string();
        let v158: string = fable_library_rust::String_::fromStr(&v157);
        let v160: std::string::String = (&v158).to_string().clone();
        let v161: string = Supervisor::method6();
        let v162: &str = &v161.as_str();
        let v166: &str = &v162[0i32 as usize..2i32 as usize];
        let v167: string = fable_library_rust::String_::fromStr(&v166);
        let v169: u8 = u8::from_str_radix(&v167, 16).unwrap();
        let v170: string = Supervisor::method6();
        let v171: &str = &v170.as_str();
        let v174: &str = &v171[2i32 as usize..4i32 as usize];
        let v175: string = fable_library_rust::String_::fromStr(&v174);
        let v176: u8 = u8::from_str_radix(&v175, 16).unwrap();
        let v177: string = Supervisor::method6();
        let v178: &str = &v177.as_str();
        let v181: &str = &v178[4i32 as usize..6i32 as usize];
        let v182: string = fable_library_rust::String_::fromStr(&v181);
        let v183: u8 = u8::from_str_radix(&v182, 16).unwrap();
        let v185: colored::ColoredString =
            colored::Colorize::truecolor(&*v160.to_string(), v169, v176, v183);
        let v186: std::string::String = format!("{}", &v185);
        let v188: string = fable_library_rust::String_::fromStr(&&v72);
        let v190: &str = r#""([^"]+)", "([^"]+)""#;
        let v191: regex::RegexBuilder = regex::RegexBuilder::new(&v190);
        let v192: &regex::Regex = &v191.build().unwrap();
        let v193: string = Supervisor::method2(v188);
        let v194: &str = &v193.as_str();
        let v195: string = Supervisor::method3();
        let v196: &str = &v195.as_str();
        let v197: std::string::String =
            v192.replace_all(&v194, v196).to_string();
        let v198: string = fable_library_rust::String_::fromStr(&v197);
        let v200: &str = r#"\["(.*?)"\]"#;
        let v201: regex::RegexBuilder = regex::RegexBuilder::new(&v200);
        let v202: &regex::Regex = &v201.build().unwrap();
        let v203: string = Supervisor::method2(v198);
        let v204: &str = &v203.as_str();
        let v205: string = Supervisor::method4();
        let v206: &str = &v205.as_str();
        let v207: std::string::String =
            v202.replace_all(&v204, v206).to_string();
        let v208: string = fable_library_rust::String_::fromStr(&v207);
        let v210: &str = r#", "#;
        let v211: regex::RegexBuilder = regex::RegexBuilder::new(&v210);
        let v212: &regex::Regex = &v211.build().unwrap();
        let v213: string = Supervisor::method2(v208);
        let v214: &str = &v213.as_str();
        let v215: string = Supervisor::method5();
        let v216: &str = &v215.as_str();
        let v217: std::string::String =
            v212.replace_all(&v214, v216).to_string();
        let v218: string = fable_library_rust::String_::fromStr(&v217);
        let v220: std::string::String = (&v218).to_string().clone();
        let v221: string = Supervisor::method7();
        let v222: &str = &v221.as_str();
        let v225: &str = &v222[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v225);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Supervisor::method7();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v233: string = fable_library_rust::String_::fromStr(&v232);
        let v234: u8 = u8::from_str_radix(&v233, 16).unwrap();
        let v235: string = Supervisor::method7();
        let v236: &str = &v235.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v240: string = fable_library_rust::String_::fromStr(&v239);
        let v241: u8 = u8::from_str_radix(&v240, 16).unwrap();
        let v242: colored::ColoredString =
            colored::Colorize::truecolor(&*v220.to_string(), v227, v234, v241);
        let v243: std::string::String = format!("{}", &v242);
        println!("{0}",
                 stringFrom(format!("{0} {1} {2}", &v126, &v186, &v243)));
        {
            let v245: Result<std::path::PathBuf, std::io::Error> =
                (&v0_1).canonicalize();
            let v246: std::path::PathBuf =
                (&v245).as_ref().unwrap().to_path_buf();
            let v249: std::string::String =
                (&string("spi_path_clean")).to_string().clone();
            let v250: string =
                fable_library_rust::String_::fromStr(&format!("{}", &v246.display()));
            let v253: Array<std::string::String> =
                array(&[v249, (&v250).to_string()]);
            let v254 = core::ops::Deref::deref(&v253);
            let v256: std::string::String = format!("{:?}", ***v254).clone();
            let v257: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v262: string =
                Supervisor::method1(6i32,
                                    toString(&((&v257).timestamp() - v9)));
            let v263: u8 = rand::random::<u8>();
            let v276: Array<std::string::String> =
                array(&[(&v52).to_string(), (&v262).to_string(),
                        (&v57).to_string(), format!("{:?}", &v263),
                        (&v63).to_string(), (&v66).to_string()]);
            let v277 = core::ops::Deref::deref(&v276);
            let v279: std::string::String = format!("{:?}", ***v277).clone();
            let v282: Array<std::string::String> =
                array(&[(&v73).to_string()]);
            let v283 = core::ops::Deref::deref(&v282);
            let v286: std::string::String = format!("{:?}", ***v283).clone();
            let v287: string = fable_library_rust::String_::fromStr(&v286);
            let v289: &str = r#""([^"]+)", "([^"]+)""#;
            let v290: regex::RegexBuilder = regex::RegexBuilder::new(&v289);
            let v291: &regex::Regex = &v290.build().unwrap();
            let v292: string = Supervisor::method2(v287);
            let v293: &str = &v292.as_str();
            let v294: string = Supervisor::method3();
            let v295: &str = &v294.as_str();
            let v296: std::string::String =
                v291.replace_all(&v293, v295).to_string();
            let v297: string = fable_library_rust::String_::fromStr(&v296);
            let v299: &str = r#"\["(.*?)"\]"#;
            let v300: regex::RegexBuilder = regex::RegexBuilder::new(&v299);
            let v301: &regex::Regex = &v300.build().unwrap();
            let v302: string = Supervisor::method2(v297);
            let v303: &str = &v302.as_str();
            let v304: string = Supervisor::method4();
            let v305: &str = &v304.as_str();
            let v306: std::string::String =
                v301.replace_all(&v303, v305).to_string();
            let v307: string = fable_library_rust::String_::fromStr(&v306);
            let v309: &str = r#", "#;
            let v310: regex::RegexBuilder = regex::RegexBuilder::new(&v309);
            let v311: &regex::Regex = &v310.build().unwrap();
            let v312: string = Supervisor::method2(v307);
            let v313: &str = &v312.as_str();
            let v314: string = Supervisor::method5();
            let v315: &str = &v314.as_str();
            let v316: std::string::String =
                v311.replace_all(&v313, v315).to_string();
            let v317: string = fable_library_rust::String_::fromStr(&v316);
            let v319: std::string::String = (&v317).to_string().clone();
            let v320: colored::ColoredString =
                colored::Colorize::color(&*v319, v122.clone().to_string());
            let v321: std::string::String = format!("{}", &v320);
            let v323: string = fable_library_rust::String_::fromStr(&&v256);
            let v325: &str = r#""([^"]+)", "([^"]+)""#;
            let v326: regex::RegexBuilder = regex::RegexBuilder::new(&v325);
            let v327: &regex::Regex = &v326.build().unwrap();
            let v328: string = Supervisor::method2(v323);
            let v329: &str = &v328.as_str();
            let v330: string = Supervisor::method3();
            let v331: &str = &v330.as_str();
            let v332: std::string::String =
                v327.replace_all(&v329, v331).to_string();
            let v333: string = fable_library_rust::String_::fromStr(&v332);
            let v335: &str = r#"\["(.*?)"\]"#;
            let v336: regex::RegexBuilder = regex::RegexBuilder::new(&v335);
            let v337: &regex::Regex = &v336.build().unwrap();
            let v338: string = Supervisor::method2(v333);
            let v339: &str = &v338.as_str();
            let v340: string = Supervisor::method4();
            let v341: &str = &v340.as_str();
            let v342: std::string::String =
                v337.replace_all(&v339, v341).to_string();
            let v343: string = fable_library_rust::String_::fromStr(&v342);
            let v345: &str = r#", "#;
            let v346: regex::RegexBuilder = regex::RegexBuilder::new(&v345);
            let v347: &regex::Regex = &v346.build().unwrap();
            let v348: string = Supervisor::method2(v343);
            let v349: &str = &v348.as_str();
            let v350: string = Supervisor::method5();
            let v351: &str = &v350.as_str();
            let v352: std::string::String =
                v347.replace_all(&v349, v351).to_string();
            let v353: string = fable_library_rust::String_::fromStr(&v352);
            let v355: std::string::String = (&v353).to_string().clone();
            let v356: string = Supervisor::method6();
            let v357: &str = &v356.as_str();
            let v360: &str = &v357[0i32 as usize..2i32 as usize];
            let v361: string = fable_library_rust::String_::fromStr(&v360);
            let v362: u8 = u8::from_str_radix(&v361, 16).unwrap();
            let v363: string = Supervisor::method6();
            let v364: &str = &v363.as_str();
            let v367: &str = &v364[2i32 as usize..4i32 as usize];
            let v368: string = fable_library_rust::String_::fromStr(&v367);
            let v369: u8 = u8::from_str_radix(&v368, 16).unwrap();
            let v370: string = Supervisor::method6();
            let v371: &str = &v370.as_str();
            let v374: &str = &v371[4i32 as usize..6i32 as usize];
            let v375: string = fable_library_rust::String_::fromStr(&v374);
            let v376: u8 = u8::from_str_radix(&v375, 16).unwrap();
            let v377: colored::ColoredString =
                colored::Colorize::truecolor(&*v355.to_string(), v362, v369, v376);
            let v378: std::string::String = format!("{}", &v377);
            let v380: string = fable_library_rust::String_::fromStr(&&v279);
            let v382: &str = r#""([^"]+)", "([^"]+)""#;
            let v383: regex::RegexBuilder = regex::RegexBuilder::new(&v382);
            let v384: &regex::Regex = &v383.build().unwrap();
            let v385: string = Supervisor::method2(v380);
            let v386: &str = &v385.as_str();
            let v387: string = Supervisor::method3();
            let v388: &str = &v387.as_str();
            let v389: std::string::String =
                v384.replace_all(&v386, v388).to_string();
            let v390: string = fable_library_rust::String_::fromStr(&v389);
            let v392: &str = r#"\["(.*?)"\]"#;
            let v393: regex::RegexBuilder = regex::RegexBuilder::new(&v392);
            let v394: &regex::Regex = &v393.build().unwrap();
            let v395: string = Supervisor::method2(v390);
            let v396: &str = &v395.as_str();
            let v397: string = Supervisor::method4();
            let v398: &str = &v397.as_str();
            let v399: std::string::String =
                v394.replace_all(&v396, v398).to_string();
            let v400: string = fable_library_rust::String_::fromStr(&v399);
            let v402: &str = r#", "#;
            let v403: regex::RegexBuilder = regex::RegexBuilder::new(&v402);
            let v404: &regex::Regex = &v403.build().unwrap();
            let v405: string = Supervisor::method2(v400);
            let v406: &str = &v405.as_str();
            let v407: string = Supervisor::method5();
            let v408: &str = &v407.as_str();
            let v409: std::string::String =
                v404.replace_all(&v406, v408).to_string();
            let v410: string = fable_library_rust::String_::fromStr(&v409);
            let v412: std::string::String = (&v410).to_string().clone();
            let v413: string = Supervisor::method7();
            let v414: &str = &v413.as_str();
            let v417: &str = &v414[0i32 as usize..2i32 as usize];
            let v418: string = fable_library_rust::String_::fromStr(&v417);
            let v419: u8 = u8::from_str_radix(&v418, 16).unwrap();
            let v420: string = Supervisor::method7();
            let v421: &str = &v420.as_str();
            let v424: &str = &v421[2i32 as usize..4i32 as usize];
            let v425: string = fable_library_rust::String_::fromStr(&v424);
            let v426: u8 = u8::from_str_radix(&v425, 16).unwrap();
            let v427: string = Supervisor::method7();
            let v428: &str = &v427.as_str();
            let v431: &str = &v428[4i32 as usize..6i32 as usize];
            let v432: string = fable_library_rust::String_::fromStr(&v431);
            let v433: u8 = u8::from_str_radix(&v432, 16).unwrap();
            let v434: colored::ColoredString =
                colored::Colorize::truecolor(&*v412.to_string(), v419, v426, v433);
            let v435: std::string::String = format!("{}", &v434);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v321, &v378, &v435)));
            {
                let v438: Option<&std::path::Path> = (&v246).parent();
                let v440: &std::path::Path = &v438.unwrap();
                let v442: std::path::PathBuf =
                    std::path::PathBuf::from(&v440);
                let v443: Result<std::path::PathBuf, std::io::Error> =
                    (&v442).canonicalize();
                let v444: std::path::PathBuf =
                    (&v443).as_ref().unwrap().to_path_buf();
                let v447: std::string::String =
                    (&string("src_path")).to_string().clone();
                let v448: string =
                    fable_library_rust::String_::fromStr(&format!("{}", &v444.display()));
                let v451: Array<std::string::String> =
                    array(&[v447, (&v448).to_string()]);
                let v452 = core::ops::Deref::deref(&v451);
                let v454: std::string::String =
                    format!("{:?}", ***v452).clone();
                let v455: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v460: string =
                    Supervisor::method1(6i32,
                                        toString(&((&v455).timestamp() -
                                                       v9)));
                let v461: u8 = rand::random::<u8>();
                let v474: Array<std::string::String> =
                    array(&[(&v52).to_string(), (&v460).to_string(),
                            (&v57).to_string(), format!("{:?}", &v461),
                            (&v63).to_string(), (&v66).to_string()]);
                let v475 = core::ops::Deref::deref(&v474);
                let v477: std::string::String =
                    format!("{:?}", ***v475).clone();
                let v480: Array<std::string::String> =
                    array(&[(&v73).to_string()]);
                let v481 = core::ops::Deref::deref(&v480);
                let v484: std::string::String =
                    format!("{:?}", ***v481).clone();
                let v485: string =
                    fable_library_rust::String_::fromStr(&v484);
                let v487: &str = r#""([^"]+)", "([^"]+)""#;
                let v488: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v487);
                let v489: &regex::Regex = &v488.build().unwrap();
                let v490: string = Supervisor::method2(v485);
                let v491: &str = &v490.as_str();
                let v492: string = Supervisor::method3();
                let v493: &str = &v492.as_str();
                let v494: std::string::String =
                    v489.replace_all(&v491, v493).to_string();
                let v495: string =
                    fable_library_rust::String_::fromStr(&v494);
                let v497: &str = r#"\["(.*?)"\]"#;
                let v498: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v497);
                let v499: &regex::Regex = &v498.build().unwrap();
                let v500: string = Supervisor::method2(v495);
                let v501: &str = &v500.as_str();
                let v502: string = Supervisor::method4();
                let v503: &str = &v502.as_str();
                let v504: std::string::String =
                    v499.replace_all(&v501, v503).to_string();
                let v505: string =
                    fable_library_rust::String_::fromStr(&v504);
                let v507: &str = r#", "#;
                let v508: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v507);
                let v509: &regex::Regex = &v508.build().unwrap();
                let v510: string = Supervisor::method2(v505);
                let v511: &str = &v510.as_str();
                let v512: string = Supervisor::method5();
                let v513: &str = &v512.as_str();
                let v514: std::string::String =
                    v509.replace_all(&v511, v513).to_string();
                let v515: string =
                    fable_library_rust::String_::fromStr(&v514);
                let v517: std::string::String = (&v515).to_string().clone();
                let v518: colored::ColoredString =
                    colored::Colorize::color(&*v517, v122.clone().to_string());
                let v519: std::string::String = format!("{}", &v518);
                let v521: string =
                    fable_library_rust::String_::fromStr(&&v454);
                let v523: &str = r#""([^"]+)", "([^"]+)""#;
                let v524: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v523);
                let v525: &regex::Regex = &v524.build().unwrap();
                let v526: string = Supervisor::method2(v521);
                let v527: &str = &v526.as_str();
                let v528: string = Supervisor::method3();
                let v529: &str = &v528.as_str();
                let v530: std::string::String =
                    v525.replace_all(&v527, v529).to_string();
                let v531: string =
                    fable_library_rust::String_::fromStr(&v530);
                let v533: &str = r#"\["(.*?)"\]"#;
                let v534: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v533);
                let v535: &regex::Regex = &v534.build().unwrap();
                let v536: string = Supervisor::method2(v531);
                let v537: &str = &v536.as_str();
                let v538: string = Supervisor::method4();
                let v539: &str = &v538.as_str();
                let v540: std::string::String =
                    v535.replace_all(&v537, v539).to_string();
                let v541: string =
                    fable_library_rust::String_::fromStr(&v540);
                let v543: &str = r#", "#;
                let v544: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v543);
                let v545: &regex::Regex = &v544.build().unwrap();
                let v546: string = Supervisor::method2(v541);
                let v547: &str = &v546.as_str();
                let v548: string = Supervisor::method5();
                let v549: &str = &v548.as_str();
                let v550: std::string::String =
                    v545.replace_all(&v547, v549).to_string();
                let v551: string =
                    fable_library_rust::String_::fromStr(&v550);
                let v553: std::string::String = (&v551).to_string().clone();
                let v554: string = Supervisor::method6();
                let v555: &str = &v554.as_str();
                let v558: &str = &v555[0i32 as usize..2i32 as usize];
                let v559: string =
                    fable_library_rust::String_::fromStr(&v558);
                let v560: u8 = u8::from_str_radix(&v559, 16).unwrap();
                let v561: string = Supervisor::method6();
                let v562: &str = &v561.as_str();
                let v565: &str = &v562[2i32 as usize..4i32 as usize];
                let v566: string =
                    fable_library_rust::String_::fromStr(&v565);
                let v567: u8 = u8::from_str_radix(&v566, 16).unwrap();
                let v568: string = Supervisor::method6();
                let v569: &str = &v568.as_str();
                let v572: &str = &v569[4i32 as usize..6i32 as usize];
                let v573: string =
                    fable_library_rust::String_::fromStr(&v572);
                let v574: u8 = u8::from_str_radix(&v573, 16).unwrap();
                let v575: colored::ColoredString =
                    colored::Colorize::truecolor(&*v553.to_string(), v560, v567, v574);
                let v576: std::string::String = format!("{}", &v575);
                let v578: string =
                    fable_library_rust::String_::fromStr(&&v477);
                let v580: &str = r#""([^"]+)", "([^"]+)""#;
                let v581: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v580);
                let v582: &regex::Regex = &v581.build().unwrap();
                let v583: string = Supervisor::method2(v578);
                let v584: &str = &v583.as_str();
                let v585: string = Supervisor::method3();
                let v586: &str = &v585.as_str();
                let v587: std::string::String =
                    v582.replace_all(&v584, v586).to_string();
                let v588: string =
                    fable_library_rust::String_::fromStr(&v587);
                let v590: &str = r#"\["(.*?)"\]"#;
                let v591: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v590);
                let v592: &regex::Regex = &v591.build().unwrap();
                let v593: string = Supervisor::method2(v588);
                let v594: &str = &v593.as_str();
                let v595: string = Supervisor::method4();
                let v596: &str = &v595.as_str();
                let v597: std::string::String =
                    v592.replace_all(&v594, v596).to_string();
                let v598: string =
                    fable_library_rust::String_::fromStr(&v597);
                let v600: &str = r#", "#;
                let v601: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v600);
                let v602: &regex::Regex = &v601.build().unwrap();
                let v603: string = Supervisor::method2(v598);
                let v604: &str = &v603.as_str();
                let v605: string = Supervisor::method5();
                let v606: &str = &v605.as_str();
                let v607: std::string::String =
                    v602.replace_all(&v604, v606).to_string();
                let v608: string =
                    fable_library_rust::String_::fromStr(&v607);
                let v610: std::string::String = (&v608).to_string().clone();
                let v611: string = Supervisor::method7();
                let v612: &str = &v611.as_str();
                let v615: &str = &v612[0i32 as usize..2i32 as usize];
                let v616: string =
                    fable_library_rust::String_::fromStr(&v615);
                let v617: u8 = u8::from_str_radix(&v616, 16).unwrap();
                let v618: string = Supervisor::method7();
                let v619: &str = &v618.as_str();
                let v622: &str = &v619[2i32 as usize..4i32 as usize];
                let v623: string =
                    fable_library_rust::String_::fromStr(&v622);
                let v624: u8 = u8::from_str_radix(&v623, 16).unwrap();
                let v625: string = Supervisor::method7();
                let v626: &str = &v625.as_str();
                let v629: &str = &v626[4i32 as usize..6i32 as usize];
                let v630: string =
                    fable_library_rust::String_::fromStr(&v629);
                let v631: u8 = u8::from_str_radix(&v630, 16).unwrap();
                let v632: colored::ColoredString =
                    colored::Colorize::truecolor(&*v610.to_string(), v617, v624, v631);
                let v633: std::string::String = format!("{}", &v632);
                println!("{0}",
                         stringFrom(format!("{0} {1} {2}", &v519, &v576, &v633)));
                {
                    let v636: &std::path::Ancestors = &v444.ancestors();
                    let v639: _ = v636.take(10i32 as usize);
                    fn v640(v: &std::path::Path) -> std::path::PathBuf {
                        Supervisor::closure2((), v)
                    }
                    let v643: _ = v639.into_iter().map((&v640).clone());
                    fn v644(v_1: &std::path::PathBuf) -> bool {
                        Supervisor::closure3((), v_1)
                    }
                    let v647: Option<std::path::PathBuf> =
                        v643.into_iter().find((&v644).clone());
                    let v648: std::path::PathBuf =
                        (&v647).as_ref().unwrap().to_path_buf();
                    let v649: string = string("spiproj_path");
                    let v651: std::string::String =
                        (&v649).to_string().clone();
                    let v652: string =
                        fable_library_rust::String_::fromStr(&format!("{}", &v648.display()));
                    let v655: Array<std::string::String> =
                        array(&[v651, (&v652).to_string()]);
                    let v656 = core::ops::Deref::deref(&v655);
                    let v658: std::string::String =
                        format!("{:?}", ***v656).clone();
                    let v659: chrono::DateTime<chrono::Utc> =
                        chrono::Utc::now();
                    let v664: string =
                        Supervisor::method1(6i32,
                                            toString(&((&v659).timestamp() -
                                                           v9)));
                    let v665: u8 = rand::random::<u8>();
                    let v678: Array<std::string::String> =
                        array(&[(&v52).to_string(), (&v664).to_string(),
                                (&v57).to_string(), format!("{:?}", &v665),
                                (&v63).to_string(), (&v66).to_string()]);
                    let v679 = core::ops::Deref::deref(&v678);
                    let v681: std::string::String =
                        format!("{:?}", ***v679).clone();
                    let v684: Array<std::string::String> =
                        array(&[(&v73).to_string()]);
                    let v685 = core::ops::Deref::deref(&v684);
                    let v688: std::string::String =
                        format!("{:?}", ***v685).clone();
                    let v689: string =
                        fable_library_rust::String_::fromStr(&v688);
                    let v691: &str = r#""([^"]+)", "([^"]+)""#;
                    let v692: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v691);
                    let v693: &regex::Regex = &v692.build().unwrap();
                    let v694: string = Supervisor::method2(v689);
                    let v695: &str = &v694.as_str();
                    let v696: string = Supervisor::method3();
                    let v697: &str = &v696.as_str();
                    let v698: std::string::String =
                        v693.replace_all(&v695, v697).to_string();
                    let v699: string =
                        fable_library_rust::String_::fromStr(&v698);
                    let v701: &str = r#"\["(.*?)"\]"#;
                    let v702: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v701);
                    let v703: &regex::Regex = &v702.build().unwrap();
                    let v704: string = Supervisor::method2(v699);
                    let v705: &str = &v704.as_str();
                    let v706: string = Supervisor::method4();
                    let v707: &str = &v706.as_str();
                    let v708: std::string::String =
                        v703.replace_all(&v705, v707).to_string();
                    let v709: string =
                        fable_library_rust::String_::fromStr(&v708);
                    let v711: &str = r#", "#;
                    let v712: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v711);
                    let v713: &regex::Regex = &v712.build().unwrap();
                    let v714: string = Supervisor::method2(v709);
                    let v715: &str = &v714.as_str();
                    let v716: string = Supervisor::method5();
                    let v717: &str = &v716.as_str();
                    let v718: std::string::String =
                        v713.replace_all(&v715, v717).to_string();
                    let v719: string =
                        fable_library_rust::String_::fromStr(&v718);
                    let v721: std::string::String =
                        (&v719).to_string().clone();
                    let v722: colored::ColoredString =
                        colored::Colorize::color(&*v721, v122.clone().to_string());
                    let v723: std::string::String = format!("{}", &v722);
                    let v725: string =
                        fable_library_rust::String_::fromStr(&&v658);
                    let v727: &str = r#""([^"]+)", "([^"]+)""#;
                    let v728: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v727);
                    let v729: &regex::Regex = &v728.build().unwrap();
                    let v730: string = Supervisor::method2(v725);
                    let v731: &str = &v730.as_str();
                    let v732: string = Supervisor::method3();
                    let v733: &str = &v732.as_str();
                    let v734: std::string::String =
                        v729.replace_all(&v731, v733).to_string();
                    let v735: string =
                        fable_library_rust::String_::fromStr(&v734);
                    let v737: &str = r#"\["(.*?)"\]"#;
                    let v738: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v737);
                    let v739: &regex::Regex = &v738.build().unwrap();
                    let v740: string = Supervisor::method2(v735);
                    let v741: &str = &v740.as_str();
                    let v742: string = Supervisor::method4();
                    let v743: &str = &v742.as_str();
                    let v744: std::string::String =
                        v739.replace_all(&v741, v743).to_string();
                    let v745: string =
                        fable_library_rust::String_::fromStr(&v744);
                    let v747: &str = r#", "#;
                    let v748: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v747);
                    let v749: &regex::Regex = &v748.build().unwrap();
                    let v750: string = Supervisor::method2(v745);
                    let v751: &str = &v750.as_str();
                    let v752: string = Supervisor::method5();
                    let v753: &str = &v752.as_str();
                    let v754: std::string::String =
                        v749.replace_all(&v751, v753).to_string();
                    let v755: string =
                        fable_library_rust::String_::fromStr(&v754);
                    let v757: std::string::String =
                        (&v755).to_string().clone();
                    let v758: string = Supervisor::method6();
                    let v759: &str = &v758.as_str();
                    let v762: &str = &v759[0i32 as usize..2i32 as usize];
                    let v763: string =
                        fable_library_rust::String_::fromStr(&v762);
                    let v764: u8 = u8::from_str_radix(&v763, 16).unwrap();
                    let v765: string = Supervisor::method6();
                    let v766: &str = &v765.as_str();
                    let v769: &str = &v766[2i32 as usize..4i32 as usize];
                    let v770: string =
                        fable_library_rust::String_::fromStr(&v769);
                    let v771: u8 = u8::from_str_radix(&v770, 16).unwrap();
                    let v772: string = Supervisor::method6();
                    let v773: &str = &v772.as_str();
                    let v776: &str = &v773[4i32 as usize..6i32 as usize];
                    let v777: string =
                        fable_library_rust::String_::fromStr(&v776);
                    let v778: u8 = u8::from_str_radix(&v777, 16).unwrap();
                    let v779: colored::ColoredString =
                        colored::Colorize::truecolor(&*v757.to_string(), v764, v771, v778);
                    let v780: std::string::String = format!("{}", &v779);
                    let v782: string =
                        fable_library_rust::String_::fromStr(&&v681);
                    let v784: &str = r#""([^"]+)", "([^"]+)""#;
                    let v785: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v784);
                    let v786: &regex::Regex = &v785.build().unwrap();
                    let v787: string = Supervisor::method2(v782);
                    let v788: &str = &v787.as_str();
                    let v789: string = Supervisor::method3();
                    let v790: &str = &v789.as_str();
                    let v791: std::string::String =
                        v786.replace_all(&v788, v790).to_string();
                    let v792: string =
                        fable_library_rust::String_::fromStr(&v791);
                    let v794: &str = r#"\["(.*?)"\]"#;
                    let v795: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v794);
                    let v796: &regex::Regex = &v795.build().unwrap();
                    let v797: string = Supervisor::method2(v792);
                    let v798: &str = &v797.as_str();
                    let v799: string = Supervisor::method4();
                    let v800: &str = &v799.as_str();
                    let v801: std::string::String =
                        v796.replace_all(&v798, v800).to_string();
                    let v802: string =
                        fable_library_rust::String_::fromStr(&v801);
                    let v804: &str = r#", "#;
                    let v805: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v804);
                    let v806: &regex::Regex = &v805.build().unwrap();
                    let v807: string = Supervisor::method2(v802);
                    let v808: &str = &v807.as_str();
                    let v809: string = Supervisor::method5();
                    let v810: &str = &v809.as_str();
                    let v811: std::string::String =
                        v806.replace_all(&v808, v810).to_string();
                    let v812: string =
                        fable_library_rust::String_::fromStr(&v811);
                    let v814: std::string::String =
                        (&v812).to_string().clone();
                    let v815: string = Supervisor::method7();
                    let v816: &str = &v815.as_str();
                    let v819: &str = &v816[0i32 as usize..2i32 as usize];
                    let v820: string =
                        fable_library_rust::String_::fromStr(&v819);
                    let v821: u8 = u8::from_str_radix(&v820, 16).unwrap();
                    let v822: string = Supervisor::method7();
                    let v823: &str = &v822.as_str();
                    let v826: &str = &v823[2i32 as usize..4i32 as usize];
                    let v827: string =
                        fable_library_rust::String_::fromStr(&v826);
                    let v828: u8 = u8::from_str_radix(&v827, 16).unwrap();
                    let v829: string = Supervisor::method7();
                    let v830: &str = &v829.as_str();
                    let v833: &str = &v830[4i32 as usize..6i32 as usize];
                    let v834: string =
                        fable_library_rust::String_::fromStr(&v833);
                    let v835: u8 = u8::from_str_radix(&v834, 16).unwrap();
                    let v836: colored::ColoredString =
                        colored::Colorize::truecolor(&*v814.to_string(), v821, v828, v835);
                    let v837: std::string::String = format!("{}", &v836);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v723, &v780, &v837)));
                    {
                        let v840: Option<&str> = (&v246).to_str();
                        let v841: &str = &v840.unwrap();
                        let v844: string = string(".spi");
                        let v847: &str =
                            &v841.replace(&*(&string(".spir")).clone(), &(&v844).clone());
                        let v851: &str =
                            &v847.replace(&*(&v844).clone(), &(&string(".fsx")).clone());
                        let v852: std::path::PathBuf =
                            std::path::PathBuf::from(&v851);
                        let v853: Result<std::path::PathBuf, std::io::Error> =
                            (&v852).canonicalize();
                        let v854: std::path::PathBuf =
                            (&v853).as_ref().unwrap().to_path_buf();
                        let v855: string = string("fsx_path");
                        let v857: std::string::String =
                            (&v855).to_string().clone();
                        let v858: string =
                            fable_library_rust::String_::fromStr(&format!("{}", &v854.display()));
                        let v861: Array<std::string::String> =
                            array(&[v857, (&v858).to_string()]);
                        let v862 = core::ops::Deref::deref(&v861);
                        let v864: std::string::String =
                            format!("{:?}", ***v862).clone();
                        let v865: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v870: string =
                            Supervisor::method1(6i32,
                                                toString(&((&v865).timestamp()
                                                               - v9)));
                        let v871: u8 = rand::random::<u8>();
                        let v884: Array<std::string::String> =
                            array(&[(&v52).to_string(), (&v870).to_string(),
                                    (&v57).to_string(),
                                    format!("{:?}", &v871),
                                    (&v63).to_string(), (&v66).to_string()]);
                        let v885 = core::ops::Deref::deref(&v884);
                        let v887: std::string::String =
                            format!("{:?}", ***v885).clone();
                        let v890: Array<std::string::String> =
                            array(&[(&v73).to_string()]);
                        let v891 = core::ops::Deref::deref(&v890);
                        let v894: std::string::String =
                            format!("{:?}", ***v891).clone();
                        let v895: string =
                            fable_library_rust::String_::fromStr(&v894);
                        let v897: &str = r#""([^"]+)", "([^"]+)""#;
                        let v898: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v897);
                        let v899: &regex::Regex = &v898.build().unwrap();
                        let v900: string = Supervisor::method2(v895);
                        let v901: &str = &v900.as_str();
                        let v902: string = Supervisor::method3();
                        let v903: &str = &v902.as_str();
                        let v904: std::string::String =
                            v899.replace_all(&v901, v903).to_string();
                        let v905: string =
                            fable_library_rust::String_::fromStr(&v904);
                        let v907: &str = r#"\["(.*?)"\]"#;
                        let v908: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v907);
                        let v909: &regex::Regex = &v908.build().unwrap();
                        let v910: string = Supervisor::method2(v905);
                        let v911: &str = &v910.as_str();
                        let v912: string = Supervisor::method4();
                        let v913: &str = &v912.as_str();
                        let v914: std::string::String =
                            v909.replace_all(&v911, v913).to_string();
                        let v915: string =
                            fable_library_rust::String_::fromStr(&v914);
                        let v917: &str = r#", "#;
                        let v918: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v917);
                        let v919: &regex::Regex = &v918.build().unwrap();
                        let v920: string = Supervisor::method2(v915);
                        let v921: &str = &v920.as_str();
                        let v922: string = Supervisor::method5();
                        let v923: &str = &v922.as_str();
                        let v924: std::string::String =
                            v919.replace_all(&v921, v923).to_string();
                        let v925: string =
                            fable_library_rust::String_::fromStr(&v924);
                        let v927: std::string::String =
                            (&v925).to_string().clone();
                        let v928: colored::ColoredString =
                            colored::Colorize::color(&*v927, v122.clone().to_string());
                        let v929: std::string::String = format!("{}", &v928);
                        let v931: string =
                            fable_library_rust::String_::fromStr(&&v864);
                        let v933: &str = r#""([^"]+)", "([^"]+)""#;
                        let v934: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v933);
                        let v935: &regex::Regex = &v934.build().unwrap();
                        let v936: string = Supervisor::method2(v931);
                        let v937: &str = &v936.as_str();
                        let v938: string = Supervisor::method3();
                        let v939: &str = &v938.as_str();
                        let v940: std::string::String =
                            v935.replace_all(&v937, v939).to_string();
                        let v941: string =
                            fable_library_rust::String_::fromStr(&v940);
                        let v943: &str = r#"\["(.*?)"\]"#;
                        let v944: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v943);
                        let v945: &regex::Regex = &v944.build().unwrap();
                        let v946: string = Supervisor::method2(v941);
                        let v947: &str = &v946.as_str();
                        let v948: string = Supervisor::method4();
                        let v949: &str = &v948.as_str();
                        let v950: std::string::String =
                            v945.replace_all(&v947, v949).to_string();
                        let v951: string =
                            fable_library_rust::String_::fromStr(&v950);
                        let v953: &str = r#", "#;
                        let v954: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v953);
                        let v955: &regex::Regex = &v954.build().unwrap();
                        let v956: string = Supervisor::method2(v951);
                        let v957: &str = &v956.as_str();
                        let v958: string = Supervisor::method5();
                        let v959: &str = &v958.as_str();
                        let v960: std::string::String =
                            v955.replace_all(&v957, v959).to_string();
                        let v961: string =
                            fable_library_rust::String_::fromStr(&v960);
                        let v963: std::string::String =
                            (&v961).to_string().clone();
                        let v964: string = Supervisor::method6();
                        let v965: &str = &v964.as_str();
                        let v968: &str = &v965[0i32 as usize..2i32 as usize];
                        let v969: string =
                            fable_library_rust::String_::fromStr(&v968);
                        let v970: u8 = u8::from_str_radix(&v969, 16).unwrap();
                        let v971: string = Supervisor::method6();
                        let v972: &str = &v971.as_str();
                        let v975: &str = &v972[2i32 as usize..4i32 as usize];
                        let v976: string =
                            fable_library_rust::String_::fromStr(&v975);
                        let v977: u8 = u8::from_str_radix(&v976, 16).unwrap();
                        let v978: string = Supervisor::method6();
                        let v979: &str = &v978.as_str();
                        let v982: &str = &v979[4i32 as usize..6i32 as usize];
                        let v983: string =
                            fable_library_rust::String_::fromStr(&v982);
                        let v984: u8 = u8::from_str_radix(&v983, 16).unwrap();
                        let v985: colored::ColoredString =
                            colored::Colorize::truecolor(&*v963.to_string(), v970, v977, v984);
                        let v986: std::string::String = format!("{}", &v985);
                        let v988: string =
                            fable_library_rust::String_::fromStr(&&v887);
                        let v990: &str = r#""([^"]+)", "([^"]+)""#;
                        let v991: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v990);
                        let v992: &regex::Regex = &v991.build().unwrap();
                        let v993: string = Supervisor::method2(v988);
                        let v994: &str = &v993.as_str();
                        let v995: string = Supervisor::method3();
                        let v996: &str = &v995.as_str();
                        let v997: std::string::String =
                            v992.replace_all(&v994, v996).to_string();
                        let v998: string =
                            fable_library_rust::String_::fromStr(&v997);
                        let v1000: &str = r#"\["(.*?)"\]"#;
                        let v1001: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v1000);
                        let v1002: &regex::Regex = &v1001.build().unwrap();
                        let v1003: string = Supervisor::method2(v998);
                        let v1004: &str = &v1003.as_str();
                        let v1005: string = Supervisor::method4();
                        let v1006: &str = &v1005.as_str();
                        let v1007: std::string::String =
                            v1002.replace_all(&v1004, v1006).to_string();
                        let v1008: string =
                            fable_library_rust::String_::fromStr(&v1007);
                        let v1010: &str = r#", "#;
                        let v1011: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v1010);
                        let v1012: &regex::Regex = &v1011.build().unwrap();
                        let v1013: string = Supervisor::method2(v1008);
                        let v1014: &str = &v1013.as_str();
                        let v1015: string = Supervisor::method5();
                        let v1016: &str = &v1015.as_str();
                        let v1017: std::string::String =
                            v1012.replace_all(&v1014, v1016).to_string();
                        let v1018: string =
                            fable_library_rust::String_::fromStr(&v1017);
                        let v1020: std::string::String =
                            (&v1018).to_string().clone();
                        let v1021: string = Supervisor::method7();
                        let v1022: &str = &v1021.as_str();
                        let v1025: &str =
                            &v1022[0i32 as usize..2i32 as usize];
                        let v1026: string =
                            fable_library_rust::String_::fromStr(&v1025);
                        let v1027: u8 =
                            u8::from_str_radix(&v1026, 16).unwrap();
                        let v1028: string = Supervisor::method7();
                        let v1029: &str = &v1028.as_str();
                        let v1032: &str =
                            &v1029[2i32 as usize..4i32 as usize];
                        let v1033: string =
                            fable_library_rust::String_::fromStr(&v1032);
                        let v1034: u8 =
                            u8::from_str_radix(&v1033, 16).unwrap();
                        let v1035: string = Supervisor::method7();
                        let v1036: &str = &v1035.as_str();
                        let v1039: &str =
                            &v1036[4i32 as usize..6i32 as usize];
                        let v1040: string =
                            fable_library_rust::String_::fromStr(&v1039);
                        let v1041: u8 =
                            u8::from_str_radix(&v1040, 16).unwrap();
                        let v1042: colored::ColoredString =
                            colored::Colorize::truecolor(&*v1020.to_string(), v1027, v1034, v1041);
                        let v1043: std::string::String =
                            format!("{}", &v1042);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v929, &v986, &v1043)));
                        {
                            let v1045: string = string("");
                            let v1047: Result<(), std::io::Error> =
                                std::fs::write(v854.clone(), v1045.clone().as_str());
                            *((&v1047).as_ref()).unwrap();
                            {
                                let v1051: std::string::String =
                                    (&string("> fs_write fsx_path \"\"; ok")).to_string().clone();
                                let v1052: chrono::DateTime<chrono::Utc> =
                                    chrono::Utc::now();
                                let v1057: string =
                                    Supervisor::method1(6i32,
                                                        toString(&((&v1052).timestamp()
                                                                       -
                                                                       v9)));
                                let v1058: u8 = rand::random::<u8>();
                                let v1071: Array<std::string::String> =
                                    array(&[(&v52).to_string(),
                                            (&v1057).to_string(),
                                            (&v57).to_string(),
                                            format!("{:?}", &v1058),
                                            (&v63).to_string(),
                                            (&v66).to_string()]);
                                let v1072 = core::ops::Deref::deref(&v1071);
                                let v1074: std::string::String =
                                    format!("{:?}", ***v1072).clone();
                                let v1077: Array<std::string::String> =
                                    array(&[(&v73).to_string()]);
                                let v1078 = core::ops::Deref::deref(&v1077);
                                let v1081: std::string::String =
                                    format!("{:?}", ***v1078).clone();
                                let v1082: string =
                                    fable_library_rust::String_::fromStr(&v1081);
                                let v1084: &str = r#""([^"]+)", "([^"]+)""#;
                                let v1085: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1084);
                                let v1086: &regex::Regex =
                                    &v1085.build().unwrap();
                                let v1087: string =
                                    Supervisor::method2(v1082);
                                let v1088: &str = &v1087.as_str();
                                let v1089: string = Supervisor::method3();
                                let v1090: &str = &v1089.as_str();
                                let v1091: std::string::String =
                                    v1086.replace_all(&v1088, v1090).to_string();
                                let v1092: string =
                                    fable_library_rust::String_::fromStr(&v1091);
                                let v1094: &str = r#"\["(.*?)"\]"#;
                                let v1095: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1094);
                                let v1096: &regex::Regex =
                                    &v1095.build().unwrap();
                                let v1097: string =
                                    Supervisor::method2(v1092);
                                let v1098: &str = &v1097.as_str();
                                let v1099: string = Supervisor::method4();
                                let v1100: &str = &v1099.as_str();
                                let v1101: std::string::String =
                                    v1096.replace_all(&v1098, v1100).to_string();
                                let v1102: string =
                                    fable_library_rust::String_::fromStr(&v1101);
                                let v1104: &str = r#", "#;
                                let v1105: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1104);
                                let v1106: &regex::Regex =
                                    &v1105.build().unwrap();
                                let v1107: string =
                                    Supervisor::method2(v1102);
                                let v1108: &str = &v1107.as_str();
                                let v1109: string = Supervisor::method5();
                                let v1110: &str = &v1109.as_str();
                                let v1111: std::string::String =
                                    v1106.replace_all(&v1108, v1110).to_string();
                                let v1112: string =
                                    fable_library_rust::String_::fromStr(&v1111);
                                let v1114: std::string::String =
                                    (&v1112).to_string().clone();
                                let v1115: colored::ColoredString =
                                    colored::Colorize::color(&*v1114, v122.clone().to_string());
                                let v1116: std::string::String =
                                    format!("{}", &v1115);
                                let v1118: string =
                                    fable_library_rust::String_::fromStr(&&v1051);
                                let v1120: &str = r#""([^"]+)", "([^"]+)""#;
                                let v1121: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1120);
                                let v1122: &regex::Regex =
                                    &v1121.build().unwrap();
                                let v1123: string =
                                    Supervisor::method2(v1118);
                                let v1124: &str = &v1123.as_str();
                                let v1125: string = Supervisor::method3();
                                let v1126: &str = &v1125.as_str();
                                let v1127: std::string::String =
                                    v1122.replace_all(&v1124, v1126).to_string();
                                let v1128: string =
                                    fable_library_rust::String_::fromStr(&v1127);
                                let v1130: &str = r#"\["(.*?)"\]"#;
                                let v1131: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1130);
                                let v1132: &regex::Regex =
                                    &v1131.build().unwrap();
                                let v1133: string =
                                    Supervisor::method2(v1128);
                                let v1134: &str = &v1133.as_str();
                                let v1135: string = Supervisor::method4();
                                let v1136: &str = &v1135.as_str();
                                let v1137: std::string::String =
                                    v1132.replace_all(&v1134, v1136).to_string();
                                let v1138: string =
                                    fable_library_rust::String_::fromStr(&v1137);
                                let v1140: &str = r#", "#;
                                let v1141: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1140);
                                let v1142: &regex::Regex =
                                    &v1141.build().unwrap();
                                let v1143: string =
                                    Supervisor::method2(v1138);
                                let v1144: &str = &v1143.as_str();
                                let v1145: string = Supervisor::method5();
                                let v1146: &str = &v1145.as_str();
                                let v1147: std::string::String =
                                    v1142.replace_all(&v1144, v1146).to_string();
                                let v1148: string =
                                    fable_library_rust::String_::fromStr(&v1147);
                                let v1150: std::string::String =
                                    (&v1148).to_string().clone();
                                let v1151: string = Supervisor::method6();
                                let v1152: &str = &v1151.as_str();
                                let v1155: &str =
                                    &v1152[0i32 as usize..2i32 as usize];
                                let v1156: string =
                                    fable_library_rust::String_::fromStr(&v1155);
                                let v1157: u8 =
                                    u8::from_str_radix(&v1156, 16).unwrap();
                                let v1158: string = Supervisor::method6();
                                let v1159: &str = &v1158.as_str();
                                let v1162: &str =
                                    &v1159[2i32 as usize..4i32 as usize];
                                let v1163: string =
                                    fable_library_rust::String_::fromStr(&v1162);
                                let v1164: u8 =
                                    u8::from_str_radix(&v1163, 16).unwrap();
                                let v1165: string = Supervisor::method6();
                                let v1166: &str = &v1165.as_str();
                                let v1169: &str =
                                    &v1166[4i32 as usize..6i32 as usize];
                                let v1170: string =
                                    fable_library_rust::String_::fromStr(&v1169);
                                let v1171: u8 =
                                    u8::from_str_radix(&v1170, 16).unwrap();
                                let v1172: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1150.to_string(), v1157, v1164, v1171);
                                let v1173: std::string::String =
                                    format!("{}", &v1172);
                                let v1175: string =
                                    fable_library_rust::String_::fromStr(&&v1074);
                                let v1177: &str = r#""([^"]+)", "([^"]+)""#;
                                let v1178: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1177);
                                let v1179: &regex::Regex =
                                    &v1178.build().unwrap();
                                let v1180: string =
                                    Supervisor::method2(v1175);
                                let v1181: &str = &v1180.as_str();
                                let v1182: string = Supervisor::method3();
                                let v1183: &str = &v1182.as_str();
                                let v1184: std::string::String =
                                    v1179.replace_all(&v1181, v1183).to_string();
                                let v1185: string =
                                    fable_library_rust::String_::fromStr(&v1184);
                                let v1187: &str = r#"\["(.*?)"\]"#;
                                let v1188: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1187);
                                let v1189: &regex::Regex =
                                    &v1188.build().unwrap();
                                let v1190: string =
                                    Supervisor::method2(v1185);
                                let v1191: &str = &v1190.as_str();
                                let v1192: string = Supervisor::method4();
                                let v1193: &str = &v1192.as_str();
                                let v1194: std::string::String =
                                    v1189.replace_all(&v1191, v1193).to_string();
                                let v1195: string =
                                    fable_library_rust::String_::fromStr(&v1194);
                                let v1197: &str = r#", "#;
                                let v1198: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1197);
                                let v1199: &regex::Regex =
                                    &v1198.build().unwrap();
                                let v1200: string =
                                    Supervisor::method2(v1195);
                                let v1201: &str = &v1200.as_str();
                                let v1202: string = Supervisor::method5();
                                let v1203: &str = &v1202.as_str();
                                let v1204: std::string::String =
                                    v1199.replace_all(&v1201, v1203).to_string();
                                let v1205: string =
                                    fable_library_rust::String_::fromStr(&v1204);
                                let v1207: std::string::String =
                                    (&v1205).to_string().clone();
                                let v1208: string = Supervisor::method7();
                                let v1209: &str = &v1208.as_str();
                                let v1212: &str =
                                    &v1209[0i32 as usize..2i32 as usize];
                                let v1213: string =
                                    fable_library_rust::String_::fromStr(&v1212);
                                let v1214: u8 =
                                    u8::from_str_radix(&v1213, 16).unwrap();
                                let v1215: string = Supervisor::method7();
                                let v1216: &str = &v1215.as_str();
                                let v1219: &str =
                                    &v1216[2i32 as usize..4i32 as usize];
                                let v1220: string =
                                    fable_library_rust::String_::fromStr(&v1219);
                                let v1221: u8 =
                                    u8::from_str_radix(&v1220, 16).unwrap();
                                let v1222: string = Supervisor::method7();
                                let v1223: &str = &v1222.as_str();
                                let v1226: &str =
                                    &v1223[4i32 as usize..6i32 as usize];
                                let v1227: string =
                                    fable_library_rust::String_::fromStr(&v1226);
                                let v1228: u8 =
                                    u8::from_str_radix(&v1227, 16).unwrap();
                                let v1229: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1207.to_string(), v1214, v1221, v1228);
                                let v1230: std::string::String =
                                    format!("{}", &v1229);
                                println!("{0}",
                                         stringFrom(format!("{0} {1} {2}", &v1116, &v1173, &v1230)));
                                {
                                    let v1233:
                                            Result<std::string::String,
                                                   std::io::Error> =
                                        std::fs::read_to_string(&v648);
                                    let v1235: std::string::String =
                                        (&v1233).as_ref().unwrap().to_string();
                                    let patternInput_1:
                                            (string, string, string, bool) =
                                        Supervisor::method0();
                                    let v1240: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v1241: i64 = (&v1240).timestamp();
                                    let v1243: std::string::String =
                                        (&v649).to_string().clone();
                                    let v1244: string =
                                        fable_library_rust::String_::fromStr(&format!("{}", &v648.display()));
                                    let v1246: std::string::String =
                                        (&v1244).to_string().clone();
                                    let v1249: std::string::String =
                                        (&string("spiproj_text len")).to_string().clone();
                                    let v1251: i32 =
                                        (&v1235).len().try_into().unwrap();
                                    let v1254: Array<std::string::String> =
                                        array(&[v1243, v1246, v1249,
                                                format!("{:?}", &v1251)]);
                                    let v1255 =
                                        core::ops::Deref::deref(&v1254);
                                    let v1257: std::string::String =
                                        format!("{:?}", ***v1255).clone();
                                    let v1258: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v1263: string =
                                        Supervisor::method1(6i32,
                                                            toString(&((&v1258).timestamp()
                                                                           -
                                                                           v1241)));
                                    let v1264: u8 = rand::random::<u8>();
                                    let v1277: Array<std::string::String> =
                                        array(&[(&v52).to_string(),
                                                (&v1263).to_string(),
                                                (&v57).to_string(),
                                                format!("{:?}", &v1264),
                                                (&v63).to_string(),
                                                (&v66).to_string()]);
                                    let v1278 =
                                        core::ops::Deref::deref(&v1277);
                                    let v1280: std::string::String =
                                        format!("{:?}", ***v1278).clone();
                                    let v1281: string =
                                        string("> spiproj_open ()");
                                    let v1284: Array<std::string::String> =
                                        array(&[(&v1281).to_string()]);
                                    let v1285 =
                                        core::ops::Deref::deref(&v1284);
                                    let v1288: std::string::String =
                                        format!("{:?}", ***v1285).clone();
                                    let v1289: string =
                                        fable_library_rust::String_::fromStr(&v1288);
                                    let v1291: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1292: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1291);
                                    let v1293: &regex::Regex =
                                        &v1292.build().unwrap();
                                    let v1294: string =
                                        Supervisor::method2(v1289);
                                    let v1295: &str = &v1294.as_str();
                                    let v1296: string = Supervisor::method3();
                                    let v1297: &str = &v1296.as_str();
                                    let v1298: std::string::String =
                                        v1293.replace_all(&v1295, v1297).to_string();
                                    let v1299: string =
                                        fable_library_rust::String_::fromStr(&v1298);
                                    let v1301: &str = r#"\["(.*?)"\]"#;
                                    let v1302: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1301);
                                    let v1303: &regex::Regex =
                                        &v1302.build().unwrap();
                                    let v1304: string =
                                        Supervisor::method2(v1299);
                                    let v1305: &str = &v1304.as_str();
                                    let v1306: string = Supervisor::method4();
                                    let v1307: &str = &v1306.as_str();
                                    let v1308: std::string::String =
                                        v1303.replace_all(&v1305, v1307).to_string();
                                    let v1309: string =
                                        fable_library_rust::String_::fromStr(&v1308);
                                    let v1311: &str = r#", "#;
                                    let v1312: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1311);
                                    let v1313: &regex::Regex =
                                        &v1312.build().unwrap();
                                    let v1314: string =
                                        Supervisor::method2(v1309);
                                    let v1315: &str = &v1314.as_str();
                                    let v1316: string = Supervisor::method5();
                                    let v1317: &str = &v1316.as_str();
                                    let v1318: std::string::String =
                                        v1313.replace_all(&v1315, v1317).to_string();
                                    let v1319: string =
                                        fable_library_rust::String_::fromStr(&v1318);
                                    let v1321: std::string::String =
                                        (&v1319).to_string().clone();
                                    let v1322: colored::ColoredString =
                                        colored::Colorize::color(&*v1321, v122.clone().to_string());
                                    let v1323: std::string::String =
                                        format!("{}", &v1322);
                                    let v1325: string =
                                        fable_library_rust::String_::fromStr(&&v1257);
                                    let v1327: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1328: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1327);
                                    let v1329: &regex::Regex =
                                        &v1328.build().unwrap();
                                    let v1330: string =
                                        Supervisor::method2(v1325);
                                    let v1331: &str = &v1330.as_str();
                                    let v1332: string = Supervisor::method3();
                                    let v1333: &str = &v1332.as_str();
                                    let v1334: std::string::String =
                                        v1329.replace_all(&v1331, v1333).to_string();
                                    let v1335: string =
                                        fable_library_rust::String_::fromStr(&v1334);
                                    let v1337: &str = r#"\["(.*?)"\]"#;
                                    let v1338: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1337);
                                    let v1339: &regex::Regex =
                                        &v1338.build().unwrap();
                                    let v1340: string =
                                        Supervisor::method2(v1335);
                                    let v1341: &str = &v1340.as_str();
                                    let v1342: string = Supervisor::method4();
                                    let v1343: &str = &v1342.as_str();
                                    let v1344: std::string::String =
                                        v1339.replace_all(&v1341, v1343).to_string();
                                    let v1345: string =
                                        fable_library_rust::String_::fromStr(&v1344);
                                    let v1347: &str = r#", "#;
                                    let v1348: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1347);
                                    let v1349: &regex::Regex =
                                        &v1348.build().unwrap();
                                    let v1350: string =
                                        Supervisor::method2(v1345);
                                    let v1351: &str = &v1350.as_str();
                                    let v1352: string = Supervisor::method5();
                                    let v1353: &str = &v1352.as_str();
                                    let v1354: std::string::String =
                                        v1349.replace_all(&v1351, v1353).to_string();
                                    let v1355: string =
                                        fable_library_rust::String_::fromStr(&v1354);
                                    let v1357: std::string::String =
                                        (&v1355).to_string().clone();
                                    let v1358: string = Supervisor::method8();
                                    let v1359: &str = &v1358.as_str();
                                    let v1362: &str =
                                        &v1359[0i32 as usize..2i32 as usize];
                                    let v1363: string =
                                        fable_library_rust::String_::fromStr(&v1362);
                                    let v1364: u8 =
                                        u8::from_str_radix(&v1363, 16).unwrap();
                                    let v1365: string = Supervisor::method8();
                                    let v1366: &str = &v1365.as_str();
                                    let v1369: &str =
                                        &v1366[2i32 as usize..4i32 as usize];
                                    let v1370: string =
                                        fable_library_rust::String_::fromStr(&v1369);
                                    let v1371: u8 =
                                        u8::from_str_radix(&v1370, 16).unwrap();
                                    let v1372: string = Supervisor::method8();
                                    let v1373: &str = &v1372.as_str();
                                    let v1376: &str =
                                        &v1373[4i32 as usize..6i32 as usize];
                                    let v1377: string =
                                        fable_library_rust::String_::fromStr(&v1376);
                                    let v1378: u8 =
                                        u8::from_str_radix(&v1377, 16).unwrap();
                                    let v1379: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v1357.to_string(), v1364, v1371, v1378);
                                    let v1380: std::string::String =
                                        format!("{}", &v1379);
                                    let v1382: string =
                                        fable_library_rust::String_::fromStr(&&v1280);
                                    let v1384: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1385: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1384);
                                    let v1386: &regex::Regex =
                                        &v1385.build().unwrap();
                                    let v1387: string =
                                        Supervisor::method2(v1382);
                                    let v1388: &str = &v1387.as_str();
                                    let v1389: string = Supervisor::method3();
                                    let v1390: &str = &v1389.as_str();
                                    let v1391: std::string::String =
                                        v1386.replace_all(&v1388, v1390).to_string();
                                    let v1392: string =
                                        fable_library_rust::String_::fromStr(&v1391);
                                    let v1394: &str = r#"\["(.*?)"\]"#;
                                    let v1395: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1394);
                                    let v1396: &regex::Regex =
                                        &v1395.build().unwrap();
                                    let v1397: string =
                                        Supervisor::method2(v1392);
                                    let v1398: &str = &v1397.as_str();
                                    let v1399: string = Supervisor::method4();
                                    let v1400: &str = &v1399.as_str();
                                    let v1401: std::string::String =
                                        v1396.replace_all(&v1398, v1400).to_string();
                                    let v1402: string =
                                        fable_library_rust::String_::fromStr(&v1401);
                                    let v1404: &str = r#", "#;
                                    let v1405: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1404);
                                    let v1406: &regex::Regex =
                                        &v1405.build().unwrap();
                                    let v1407: string =
                                        Supervisor::method2(v1402);
                                    let v1408: &str = &v1407.as_str();
                                    let v1409: string = Supervisor::method5();
                                    let v1410: &str = &v1409.as_str();
                                    let v1411: std::string::String =
                                        v1406.replace_all(&v1408, v1410).to_string();
                                    let v1412: string =
                                        fable_library_rust::String_::fromStr(&v1411);
                                    let v1414: std::string::String =
                                        (&v1412).to_string().clone();
                                    let v1415: string = Supervisor::method7();
                                    let v1416: &str = &v1415.as_str();
                                    let v1419: &str =
                                        &v1416[0i32 as usize..2i32 as usize];
                                    let v1420: string =
                                        fable_library_rust::String_::fromStr(&v1419);
                                    let v1421: u8 =
                                        u8::from_str_radix(&v1420, 16).unwrap();
                                    let v1422: string = Supervisor::method7();
                                    let v1423: &str = &v1422.as_str();
                                    let v1426: &str =
                                        &v1423[2i32 as usize..4i32 as usize];
                                    let v1427: string =
                                        fable_library_rust::String_::fromStr(&v1426);
                                    let v1428: u8 =
                                        u8::from_str_radix(&v1427, 16).unwrap();
                                    let v1429: string = Supervisor::method7();
                                    let v1430: &str = &v1429.as_str();
                                    let v1433: &str =
                                        &v1430[4i32 as usize..6i32 as usize];
                                    let v1434: string =
                                        fable_library_rust::String_::fromStr(&v1433);
                                    let v1435: u8 =
                                        u8::from_str_radix(&v1434, 16).unwrap();
                                    let v1436: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v1414.to_string(), v1421, v1428, v1435);
                                    let v1437: std::string::String =
                                        format!("{}", &v1436);
                                    println!("{0}",
                                             stringFrom(format!("{0} {1} {2}", &v1323, &v1380, &v1437)));
                                    {
                                        let v1439: string = string("{");
                                        let v1442: string =
                                            string("\"uri\": $0,");
                                        let v1446: string = string("}");
                                        let v1449: string =
                                            string("serde_json::json!(");
                                        let v1451: string =
                                            string(").to_string()");
                                        let v1452: string =
                                            append(append(v1449.clone(),
                                                          append(append(append(append(append(v1439.clone(),
                                                                                             string("\"ProjectFileOpen\": {")),
                                                                                      v1442.clone()),
                                                                               string("\"spiprojText\": $1")),
                                                                        v1446.clone()),
                                                                 v1446.clone())),
                                                   v1451.clone());
                                        let v1453: std::string::String =
                                            serde_json::json!({"ProjectFileOpen": {"uri": v648,"spiprojText": v1235}}).to_string();
                                        let v1456: std::string::String =
                                            (&string("json len=")).to_string().clone();
                                        let v1457: i32 =
                                            (&v1453).len().try_into().unwrap();
                                        let v1460:
                                                Array<std::string::String> =
                                            array(&[v1456,
                                                    format!("{:?}", &v1457)]);
                                        let v1461 =
                                            core::ops::Deref::deref(&v1460);
                                        let v1463: std::string::String =
                                            format!("{:?}", ***v1461).clone();
                                        let v1464:
                                                chrono::DateTime<chrono::Utc> =
                                            chrono::Utc::now();
                                        let v1469: string =
                                            Supervisor::method1(6i32,
                                                                toString(&((&v1464).timestamp()
                                                                               -
                                                                               v1241)));
                                        let v1470: u8 = rand::random::<u8>();
                                        let v1483:
                                                Array<std::string::String> =
                                            array(&[(&v52).to_string(),
                                                    (&v1469).to_string(),
                                                    (&v57).to_string(),
                                                    format!("{:?}", &v1470),
                                                    (&v63).to_string(),
                                                    (&v66).to_string()]);
                                        let v1484 =
                                            core::ops::Deref::deref(&v1483);
                                        let v1486: std::string::String =
                                            format!("{:?}", ***v1484).clone();
                                        let v1489:
                                                Array<std::string::String> =
                                            array(&[(&v1281).to_string()]);
                                        let v1490 =
                                            core::ops::Deref::deref(&v1489);
                                        let v1493: std::string::String =
                                            format!("{:?}", ***v1490).clone();
                                        let v1494: string =
                                            fable_library_rust::String_::fromStr(&v1493);
                                        let v1496: &str =
                                            r#""([^"]+)", "([^"]+)""#;
                                        let v1497: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1496);
                                        let v1498: &regex::Regex =
                                            &v1497.build().unwrap();
                                        let v1499: string =
                                            Supervisor::method2(v1494);
                                        let v1500: &str = &v1499.as_str();
                                        let v1501: string =
                                            Supervisor::method3();
                                        let v1502: &str = &v1501.as_str();
                                        let v1503: std::string::String =
                                            v1498.replace_all(&v1500, v1502).to_string();
                                        let v1504: string =
                                            fable_library_rust::String_::fromStr(&v1503);
                                        let v1506: &str = r#"\["(.*?)"\]"#;
                                        let v1507: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1506);
                                        let v1508: &regex::Regex =
                                            &v1507.build().unwrap();
                                        let v1509: string =
                                            Supervisor::method2(v1504);
                                        let v1510: &str = &v1509.as_str();
                                        let v1511: string =
                                            Supervisor::method4();
                                        let v1512: &str = &v1511.as_str();
                                        let v1513: std::string::String =
                                            v1508.replace_all(&v1510, v1512).to_string();
                                        let v1514: string =
                                            fable_library_rust::String_::fromStr(&v1513);
                                        let v1516: &str = r#", "#;
                                        let v1517: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1516);
                                        let v1518: &regex::Regex =
                                            &v1517.build().unwrap();
                                        let v1519: string =
                                            Supervisor::method2(v1514);
                                        let v1520: &str = &v1519.as_str();
                                        let v1521: string =
                                            Supervisor::method5();
                                        let v1522: &str = &v1521.as_str();
                                        let v1523: std::string::String =
                                            v1518.replace_all(&v1520, v1522).to_string();
                                        let v1524: string =
                                            fable_library_rust::String_::fromStr(&v1523);
                                        let v1526: std::string::String =
                                            (&v1524).to_string().clone();
                                        let v1527: colored::ColoredString =
                                            colored::Colorize::color(&*v1526, v122.clone().to_string());
                                        let v1528: std::string::String =
                                            format!("{}", &v1527);
                                        let v1530: string =
                                            fable_library_rust::String_::fromStr(&&v1463);
                                        let v1532: &str =
                                            r#""([^"]+)", "([^"]+)""#;
                                        let v1533: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1532);
                                        let v1534: &regex::Regex =
                                            &v1533.build().unwrap();
                                        let v1535: string =
                                            Supervisor::method2(v1530);
                                        let v1536: &str = &v1535.as_str();
                                        let v1537: string =
                                            Supervisor::method3();
                                        let v1538: &str = &v1537.as_str();
                                        let v1539: std::string::String =
                                            v1534.replace_all(&v1536, v1538).to_string();
                                        let v1540: string =
                                            fable_library_rust::String_::fromStr(&v1539);
                                        let v1542: &str = r#"\["(.*?)"\]"#;
                                        let v1543: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1542);
                                        let v1544: &regex::Regex =
                                            &v1543.build().unwrap();
                                        let v1545: string =
                                            Supervisor::method2(v1540);
                                        let v1546: &str = &v1545.as_str();
                                        let v1547: string =
                                            Supervisor::method4();
                                        let v1548: &str = &v1547.as_str();
                                        let v1549: std::string::String =
                                            v1544.replace_all(&v1546, v1548).to_string();
                                        let v1550: string =
                                            fable_library_rust::String_::fromStr(&v1549);
                                        let v1552: &str = r#", "#;
                                        let v1553: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1552);
                                        let v1554: &regex::Regex =
                                            &v1553.build().unwrap();
                                        let v1555: string =
                                            Supervisor::method2(v1550);
                                        let v1556: &str = &v1555.as_str();
                                        let v1557: string =
                                            Supervisor::method5();
                                        let v1558: &str = &v1557.as_str();
                                        let v1559: std::string::String =
                                            v1554.replace_all(&v1556, v1558).to_string();
                                        let v1560: string =
                                            fable_library_rust::String_::fromStr(&v1559);
                                        let v1562: std::string::String =
                                            (&v1560).to_string().clone();
                                        let v1563: string =
                                            Supervisor::method8();
                                        let v1564: &str = &v1563.as_str();
                                        let v1567: &str =
                                            &v1564[0i32 as
                                                       usize..2i32 as usize];
                                        let v1568: string =
                                            fable_library_rust::String_::fromStr(&v1567);
                                        let v1569: u8 =
                                            u8::from_str_radix(&v1568, 16).unwrap();
                                        let v1570: string =
                                            Supervisor::method8();
                                        let v1571: &str = &v1570.as_str();
                                        let v1574: &str =
                                            &v1571[2i32 as
                                                       usize..4i32 as usize];
                                        let v1575: string =
                                            fable_library_rust::String_::fromStr(&v1574);
                                        let v1576: u8 =
                                            u8::from_str_radix(&v1575, 16).unwrap();
                                        let v1577: string =
                                            Supervisor::method8();
                                        let v1578: &str = &v1577.as_str();
                                        let v1581: &str =
                                            &v1578[4i32 as
                                                       usize..6i32 as usize];
                                        let v1582: string =
                                            fable_library_rust::String_::fromStr(&v1581);
                                        let v1583: u8 =
                                            u8::from_str_radix(&v1582, 16).unwrap();
                                        let v1584: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1562.to_string(), v1569, v1576, v1583);
                                        let v1585: std::string::String =
                                            format!("{}", &v1584);
                                        let v1587: string =
                                            fable_library_rust::String_::fromStr(&&v1486);
                                        let v1589: &str =
                                            r#""([^"]+)", "([^"]+)""#;
                                        let v1590: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1589);
                                        let v1591: &regex::Regex =
                                            &v1590.build().unwrap();
                                        let v1592: string =
                                            Supervisor::method2(v1587);
                                        let v1593: &str = &v1592.as_str();
                                        let v1594: string =
                                            Supervisor::method3();
                                        let v1595: &str = &v1594.as_str();
                                        let v1596: std::string::String =
                                            v1591.replace_all(&v1593, v1595).to_string();
                                        let v1597: string =
                                            fable_library_rust::String_::fromStr(&v1596);
                                        let v1599: &str = r#"\["(.*?)"\]"#;
                                        let v1600: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1599);
                                        let v1601: &regex::Regex =
                                            &v1600.build().unwrap();
                                        let v1602: string =
                                            Supervisor::method2(v1597);
                                        let v1603: &str = &v1602.as_str();
                                        let v1604: string =
                                            Supervisor::method4();
                                        let v1605: &str = &v1604.as_str();
                                        let v1606: std::string::String =
                                            v1601.replace_all(&v1603, v1605).to_string();
                                        let v1607: string =
                                            fable_library_rust::String_::fromStr(&v1606);
                                        let v1609: &str = r#", "#;
                                        let v1610: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1609);
                                        let v1611: &regex::Regex =
                                            &v1610.build().unwrap();
                                        let v1612: string =
                                            Supervisor::method2(v1607);
                                        let v1613: &str = &v1612.as_str();
                                        let v1614: string =
                                            Supervisor::method5();
                                        let v1615: &str = &v1614.as_str();
                                        let v1616: std::string::String =
                                            v1611.replace_all(&v1613, v1615).to_string();
                                        let v1617: string =
                                            fable_library_rust::String_::fromStr(&v1616);
                                        let v1619: std::string::String =
                                            (&v1617).to_string().clone();
                                        let v1620: string =
                                            Supervisor::method7();
                                        let v1621: &str = &v1620.as_str();
                                        let v1624: &str =
                                            &v1621[0i32 as
                                                       usize..2i32 as usize];
                                        let v1625: string =
                                            fable_library_rust::String_::fromStr(&v1624);
                                        let v1626: u8 =
                                            u8::from_str_radix(&v1625, 16).unwrap();
                                        let v1627: string =
                                            Supervisor::method7();
                                        let v1628: &str = &v1627.as_str();
                                        let v1631: &str =
                                            &v1628[2i32 as
                                                       usize..4i32 as usize];
                                        let v1632: string =
                                            fable_library_rust::String_::fromStr(&v1631);
                                        let v1633: u8 =
                                            u8::from_str_radix(&v1632, 16).unwrap();
                                        let v1634: string =
                                            Supervisor::method7();
                                        let v1635: &str = &v1634.as_str();
                                        let v1638: &str =
                                            &v1635[4i32 as
                                                       usize..6i32 as usize];
                                        let v1639: string =
                                            fable_library_rust::String_::fromStr(&v1638);
                                        let v1640: u8 =
                                            u8::from_str_radix(&v1639, 16).unwrap();
                                        let v1641: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1619.to_string(), v1626, v1633, v1640);
                                        let v1642: std::string::String =
                                            format!("{}", &v1641);
                                        println!("{0}",
                                                 stringFrom(format!("{0} {1} {2}", &v1528, &v1585, &v1642)));
                                        {
                                            let patternInput_2:
                                                    (string, string, string,
                                                     bool) =
                                                Supervisor::method0();
                                            let v1648:
                                                    chrono::DateTime<chrono::Utc> =
                                                chrono::Utc::now();
                                            let v1649: i64 =
                                                (&v1648).timestamp();
                                            let v1650: string =
                                                string("host");
                                            let v1652: std::string::String =
                                                (&v1650).to_string().clone();
                                            let v1653: string =
                                                string("localhost");
                                            let v1655: std::string::String =
                                                (&v1653).to_string().clone();
                                            let v1656: string =
                                                string("port");
                                            let v1658: std::string::String =
                                                (&v1656).to_string().clone();
                                            let v1660: std::string::String =
                                                format!("{:?}", &13805i32).clone();
                                            let v1661: string =
                                                string("msg len");
                                            let v1663: std::string::String =
                                                (&v1661).to_string().clone();
                                            let v1664: i32 =
                                                (&v1453).len().try_into().unwrap();
                                            let v1667:
                                                    Array<std::string::String> =
                                                array(&[v1652, v1655, v1658,
                                                        v1660, v1663,
                                                        format!("{:?}", &v1664)]);
                                            let v1668 =
                                                core::ops::Deref::deref(&v1667);
                                            let v1670: std::string::String =
                                                format!("{:?}", ***v1668).clone();
                                            let v1671:
                                                    chrono::DateTime<chrono::Utc> =
                                                chrono::Utc::now();
                                            let v1676: string =
                                                Supervisor::method1(6i32,
                                                                    toString(&((&v1671).timestamp()
                                                                                   -
                                                                                   v1649)));
                                            let v1677: u8 =
                                                rand::random::<u8>();
                                            let v1690:
                                                    Array<std::string::String> =
                                                array(&[(&v52).to_string(),
                                                        (&v1676).to_string(),
                                                        (&v57).to_string(),
                                                        format!("{:?}", &v1677),
                                                        (&v63).to_string(),
                                                        (&v66).to_string()]);
                                            let v1691 =
                                                core::ops::Deref::deref(&v1690);
                                            let v1693: std::string::String =
                                                format!("{:?}", ***v1691).clone();
                                            let v1694: string =
                                                string("> zmq_request ()");
                                            let v1697:
                                                    Array<std::string::String> =
                                                array(&[(&v1694).to_string()]);
                                            let v1698 =
                                                core::ops::Deref::deref(&v1697);
                                            let v1701: std::string::String =
                                                format!("{:?}", ***v1698).clone();
                                            let v1702: string =
                                                fable_library_rust::String_::fromStr(&v1701);
                                            let v1704: &str =
                                                r#""([^"]+)", "([^"]+)""#;
                                            let v1705: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1704);
                                            let v1706: &regex::Regex =
                                                &v1705.build().unwrap();
                                            let v1707: string =
                                                Supervisor::method2(v1702);
                                            let v1708: &str = &v1707.as_str();
                                            let v1709: string =
                                                Supervisor::method3();
                                            let v1710: &str = &v1709.as_str();
                                            let v1711: std::string::String =
                                                v1706.replace_all(&v1708, v1710).to_string();
                                            let v1712: string =
                                                fable_library_rust::String_::fromStr(&v1711);
                                            let v1714: &str =
                                                r#"\["(.*?)"\]"#;
                                            let v1715: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1714);
                                            let v1716: &regex::Regex =
                                                &v1715.build().unwrap();
                                            let v1717: string =
                                                Supervisor::method2(v1712);
                                            let v1718: &str = &v1717.as_str();
                                            let v1719: string =
                                                Supervisor::method4();
                                            let v1720: &str = &v1719.as_str();
                                            let v1721: std::string::String =
                                                v1716.replace_all(&v1718, v1720).to_string();
                                            let v1722: string =
                                                fable_library_rust::String_::fromStr(&v1721);
                                            let v1724: &str = r#", "#;
                                            let v1725: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1724);
                                            let v1726: &regex::Regex =
                                                &v1725.build().unwrap();
                                            let v1727: string =
                                                Supervisor::method2(v1722);
                                            let v1728: &str = &v1727.as_str();
                                            let v1729: string =
                                                Supervisor::method5();
                                            let v1730: &str = &v1729.as_str();
                                            let v1731: std::string::String =
                                                v1726.replace_all(&v1728, v1730).to_string();
                                            let v1732: string =
                                                fable_library_rust::String_::fromStr(&v1731);
                                            let v1734: std::string::String =
                                                (&v1732).to_string().clone();
                                            let v1735:
                                                    colored::ColoredString =
                                                colored::Colorize::color(&*v1734, v122.clone().to_string());
                                            let v1736: std::string::String =
                                                format!("{}", &v1735);
                                            let v1738: string =
                                                fable_library_rust::String_::fromStr(&&v1670);
                                            let v1740: &str =
                                                r#""([^"]+)", "([^"]+)""#;
                                            let v1741: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1740);
                                            let v1742: &regex::Regex =
                                                &v1741.build().unwrap();
                                            let v1743: string =
                                                Supervisor::method2(v1738);
                                            let v1744: &str = &v1743.as_str();
                                            let v1745: string =
                                                Supervisor::method3();
                                            let v1746: &str = &v1745.as_str();
                                            let v1747: std::string::String =
                                                v1742.replace_all(&v1744, v1746).to_string();
                                            let v1748: string =
                                                fable_library_rust::String_::fromStr(&v1747);
                                            let v1750: &str =
                                                r#"\["(.*?)"\]"#;
                                            let v1751: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1750);
                                            let v1752: &regex::Regex =
                                                &v1751.build().unwrap();
                                            let v1753: string =
                                                Supervisor::method2(v1748);
                                            let v1754: &str = &v1753.as_str();
                                            let v1755: string =
                                                Supervisor::method4();
                                            let v1756: &str = &v1755.as_str();
                                            let v1757: std::string::String =
                                                v1752.replace_all(&v1754, v1756).to_string();
                                            let v1758: string =
                                                fable_library_rust::String_::fromStr(&v1757);
                                            let v1760: &str = r#", "#;
                                            let v1761: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1760);
                                            let v1762: &regex::Regex =
                                                &v1761.build().unwrap();
                                            let v1763: string =
                                                Supervisor::method2(v1758);
                                            let v1764: &str = &v1763.as_str();
                                            let v1765: string =
                                                Supervisor::method5();
                                            let v1766: &str = &v1765.as_str();
                                            let v1767: std::string::String =
                                                v1762.replace_all(&v1764, v1766).to_string();
                                            let v1768: string =
                                                fable_library_rust::String_::fromStr(&v1767);
                                            let v1770: std::string::String =
                                                (&v1768).to_string().clone();
                                            let v1771: string =
                                                Supervisor::method9();
                                            let v1772: &str = &v1771.as_str();
                                            let v1775: &str =
                                                &v1772[0i32 as
                                                           usize..2i32 as
                                                                      usize];
                                            let v1776: string =
                                                fable_library_rust::String_::fromStr(&v1775);
                                            let v1777: u8 =
                                                u8::from_str_radix(&v1776, 16).unwrap();
                                            let v1778: string =
                                                Supervisor::method9();
                                            let v1779: &str = &v1778.as_str();
                                            let v1782: &str =
                                                &v1779[2i32 as
                                                           usize..4i32 as
                                                                      usize];
                                            let v1783: string =
                                                fable_library_rust::String_::fromStr(&v1782);
                                            let v1784: u8 =
                                                u8::from_str_radix(&v1783, 16).unwrap();
                                            let v1785: string =
                                                Supervisor::method9();
                                            let v1786: &str = &v1785.as_str();
                                            let v1789: &str =
                                                &v1786[4i32 as
                                                           usize..6i32 as
                                                                      usize];
                                            let v1790: string =
                                                fable_library_rust::String_::fromStr(&v1789);
                                            let v1791: u8 =
                                                u8::from_str_radix(&v1790, 16).unwrap();
                                            let v1792:
                                                    colored::ColoredString =
                                                colored::Colorize::truecolor(&*v1770.to_string(), v1777, v1784, v1791);
                                            let v1793: std::string::String =
                                                format!("{}", &v1792);
                                            let v1795: string =
                                                fable_library_rust::String_::fromStr(&&v1693);
                                            let v1797: &str =
                                                r#""([^"]+)", "([^"]+)""#;
                                            let v1798: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1797);
                                            let v1799: &regex::Regex =
                                                &v1798.build().unwrap();
                                            let v1800: string =
                                                Supervisor::method2(v1795);
                                            let v1801: &str = &v1800.as_str();
                                            let v1802: string =
                                                Supervisor::method3();
                                            let v1803: &str = &v1802.as_str();
                                            let v1804: std::string::String =
                                                v1799.replace_all(&v1801, v1803).to_string();
                                            let v1805: string =
                                                fable_library_rust::String_::fromStr(&v1804);
                                            let v1807: &str =
                                                r#"\["(.*?)"\]"#;
                                            let v1808: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1807);
                                            let v1809: &regex::Regex =
                                                &v1808.build().unwrap();
                                            let v1810: string =
                                                Supervisor::method2(v1805);
                                            let v1811: &str = &v1810.as_str();
                                            let v1812: string =
                                                Supervisor::method4();
                                            let v1813: &str = &v1812.as_str();
                                            let v1814: std::string::String =
                                                v1809.replace_all(&v1811, v1813).to_string();
                                            let v1815: string =
                                                fable_library_rust::String_::fromStr(&v1814);
                                            let v1817: &str = r#", "#;
                                            let v1818: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1817);
                                            let v1819: &regex::Regex =
                                                &v1818.build().unwrap();
                                            let v1820: string =
                                                Supervisor::method2(v1815);
                                            let v1821: &str = &v1820.as_str();
                                            let v1822: string =
                                                Supervisor::method5();
                                            let v1823: &str = &v1822.as_str();
                                            let v1824: std::string::String =
                                                v1819.replace_all(&v1821, v1823).to_string();
                                            let v1825: string =
                                                fable_library_rust::String_::fromStr(&v1824);
                                            let v1827: std::string::String =
                                                (&v1825).to_string().clone();
                                            let v1828: string =
                                                Supervisor::method7();
                                            let v1829: &str = &v1828.as_str();
                                            let v1832: &str =
                                                &v1829[0i32 as
                                                           usize..2i32 as
                                                                      usize];
                                            let v1833: string =
                                                fable_library_rust::String_::fromStr(&v1832);
                                            let v1834: u8 =
                                                u8::from_str_radix(&v1833, 16).unwrap();
                                            let v1835: string =
                                                Supervisor::method7();
                                            let v1836: &str = &v1835.as_str();
                                            let v1839: &str =
                                                &v1836[2i32 as
                                                           usize..4i32 as
                                                                      usize];
                                            let v1840: string =
                                                fable_library_rust::String_::fromStr(&v1839);
                                            let v1841: u8 =
                                                u8::from_str_radix(&v1840, 16).unwrap();
                                            let v1842: string =
                                                Supervisor::method7();
                                            let v1843: &str = &v1842.as_str();
                                            let v1846: &str =
                                                &v1843[4i32 as
                                                           usize..6i32 as
                                                                      usize];
                                            let v1847: string =
                                                fable_library_rust::String_::fromStr(&v1846);
                                            let v1848: u8 =
                                                u8::from_str_radix(&v1847, 16).unwrap();
                                            let v1849:
                                                    colored::ColoredString =
                                                colored::Colorize::truecolor(&*v1827.to_string(), v1834, v1841, v1848);
                                            let v1850: std::string::String =
                                                format!("{}", &v1849);
                                            println!("{0}",
                                                     stringFrom(format!("{0} {1} {2}", &v1736, &v1793, &v1850)));
                                            {
                                                let v1853 =
                                                    zmq::Context::new();
                                                let v1855 =
                                                    v1853.socket(zmq::REQ).unwrap();
                                                let v1856: string =
                                                    stringFrom(format!("tcp://{0}:{1}",
                                                                       &v1653,
                                                                       &13805i32));
                                                v1855.connect(&v1856.clone()).unwrap();
                                                v1855.send(v1453.as_str(), 0).unwrap();
                                                {
                                                    let v1860:
                                                            std::string::String =
                                                        v1855.recv_string(0).unwrap().unwrap();
                                                    v1855.disconnect(&v1856).unwrap();
                                                    {
                                                        let v1862: string =
                                                            string("result len");
                                                        let v1864:
                                                                std::string::String =
                                                            (&v1862).to_string().clone();
                                                        let v1865: i32 =
                                                            (&v1860).len().try_into().unwrap();
                                                        let v1868:
                                                                Array<std::string::String> =
                                                            array(&[v1864,
                                                                    format!("{:?}", &v1865)]);
                                                        let v1869 =
                                                            core::ops::Deref::deref(&v1868);
                                                        let v1871:
                                                                std::string::String =
                                                            format!("{:?}", ***v1869).clone();
                                                        let v1872:
                                                                chrono::DateTime<chrono::Utc> =
                                                            chrono::Utc::now();
                                                        let v1877: string =
                                                            Supervisor::method1(6i32,
                                                                                toString(&((&v1872).timestamp()
                                                                                               -
                                                                                               v1649)));
                                                        let v1878: u8 =
                                                            rand::random::<u8>();
                                                        let v1891:
                                                                Array<std::string::String> =
                                                            array(&[(&v52).to_string(),
                                                                    (&v1877).to_string(),
                                                                    (&v57).to_string(),
                                                                    format!("{:?}", &v1878),
                                                                    (&v63).to_string(),
                                                                    (&v66).to_string()]);
                                                        let v1892 =
                                                            core::ops::Deref::deref(&v1891);
                                                        let v1894:
                                                                std::string::String =
                                                            format!("{:?}", ***v1892).clone();
                                                        let v1897:
                                                                Array<std::string::String> =
                                                            array(&[(&v1694).to_string()]);
                                                        let v1898 =
                                                            core::ops::Deref::deref(&v1897);
                                                        let v1901:
                                                                std::string::String =
                                                            format!("{:?}", ***v1898).clone();
                                                        let v1902: string =
                                                            fable_library_rust::String_::fromStr(&v1901);
                                                        let v1904: &str =
                                                            r#""([^"]+)", "([^"]+)""#;
                                                        let v1905:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1904);
                                                        let v1906:
                                                                &regex::Regex =
                                                            &v1905.build().unwrap();
                                                        let v1907: string =
                                                            Supervisor::method2(v1902);
                                                        let v1908: &str =
                                                            &v1907.as_str();
                                                        let v1909: string =
                                                            Supervisor::method3();
                                                        let v1910: &str =
                                                            &v1909.as_str();
                                                        let v1911:
                                                                std::string::String =
                                                            v1906.replace_all(&v1908, v1910).to_string();
                                                        let v1912: string =
                                                            fable_library_rust::String_::fromStr(&v1911);
                                                        let v1914: &str =
                                                            r#"\["(.*?)"\]"#;
                                                        let v1915:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1914);
                                                        let v1916:
                                                                &regex::Regex =
                                                            &v1915.build().unwrap();
                                                        let v1917: string =
                                                            Supervisor::method2(v1912);
                                                        let v1918: &str =
                                                            &v1917.as_str();
                                                        let v1919: string =
                                                            Supervisor::method4();
                                                        let v1920: &str =
                                                            &v1919.as_str();
                                                        let v1921:
                                                                std::string::String =
                                                            v1916.replace_all(&v1918, v1920).to_string();
                                                        let v1922: string =
                                                            fable_library_rust::String_::fromStr(&v1921);
                                                        let v1924: &str =
                                                            r#", "#;
                                                        let v1925:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1924);
                                                        let v1926:
                                                                &regex::Regex =
                                                            &v1925.build().unwrap();
                                                        let v1927: string =
                                                            Supervisor::method2(v1922);
                                                        let v1928: &str =
                                                            &v1927.as_str();
                                                        let v1929: string =
                                                            Supervisor::method5();
                                                        let v1930: &str =
                                                            &v1929.as_str();
                                                        let v1931:
                                                                std::string::String =
                                                            v1926.replace_all(&v1928, v1930).to_string();
                                                        let v1932: string =
                                                            fable_library_rust::String_::fromStr(&v1931);
                                                        let v1934:
                                                                std::string::String =
                                                            (&v1932).to_string().clone();
                                                        let v1935:
                                                                colored::ColoredString =
                                                            colored::Colorize::color(&*v1934, v122.clone().to_string());
                                                        let v1936:
                                                                std::string::String =
                                                            format!("{}", &v1935);
                                                        let v1938: string =
                                                            fable_library_rust::String_::fromStr(&&v1871);
                                                        let v1940: &str =
                                                            r#""([^"]+)", "([^"]+)""#;
                                                        let v1941:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1940);
                                                        let v1942:
                                                                &regex::Regex =
                                                            &v1941.build().unwrap();
                                                        let v1943: string =
                                                            Supervisor::method2(v1938);
                                                        let v1944: &str =
                                                            &v1943.as_str();
                                                        let v1945: string =
                                                            Supervisor::method3();
                                                        let v1946: &str =
                                                            &v1945.as_str();
                                                        let v1947:
                                                                std::string::String =
                                                            v1942.replace_all(&v1944, v1946).to_string();
                                                        let v1948: string =
                                                            fable_library_rust::String_::fromStr(&v1947);
                                                        let v1950: &str =
                                                            r#"\["(.*?)"\]"#;
                                                        let v1951:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1950);
                                                        let v1952:
                                                                &regex::Regex =
                                                            &v1951.build().unwrap();
                                                        let v1953: string =
                                                            Supervisor::method2(v1948);
                                                        let v1954: &str =
                                                            &v1953.as_str();
                                                        let v1955: string =
                                                            Supervisor::method4();
                                                        let v1956: &str =
                                                            &v1955.as_str();
                                                        let v1957:
                                                                std::string::String =
                                                            v1952.replace_all(&v1954, v1956).to_string();
                                                        let v1958: string =
                                                            fable_library_rust::String_::fromStr(&v1957);
                                                        let v1960: &str =
                                                            r#", "#;
                                                        let v1961:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1960);
                                                        let v1962:
                                                                &regex::Regex =
                                                            &v1961.build().unwrap();
                                                        let v1963: string =
                                                            Supervisor::method2(v1958);
                                                        let v1964: &str =
                                                            &v1963.as_str();
                                                        let v1965: string =
                                                            Supervisor::method5();
                                                        let v1966: &str =
                                                            &v1965.as_str();
                                                        let v1967:
                                                                std::string::String =
                                                            v1962.replace_all(&v1964, v1966).to_string();
                                                        let v1968: string =
                                                            fable_library_rust::String_::fromStr(&v1967);
                                                        let v1970:
                                                                std::string::String =
                                                            (&v1968).to_string().clone();
                                                        let v1971: string =
                                                            Supervisor::method9();
                                                        let v1972: &str =
                                                            &v1971.as_str();
                                                        let v1975: &str =
                                                            &v1972[0i32 as
                                                                       usize..2i32
                                                                                  as
                                                                                  usize];
                                                        let v1976: string =
                                                            fable_library_rust::String_::fromStr(&v1975);
                                                        let v1977: u8 =
                                                            u8::from_str_radix(&v1976, 16).unwrap();
                                                        let v1978: string =
                                                            Supervisor::method9();
                                                        let v1979: &str =
                                                            &v1978.as_str();
                                                        let v1982: &str =
                                                            &v1979[2i32 as
                                                                       usize..4i32
                                                                                  as
                                                                                  usize];
                                                        let v1983: string =
                                                            fable_library_rust::String_::fromStr(&v1982);
                                                        let v1984: u8 =
                                                            u8::from_str_radix(&v1983, 16).unwrap();
                                                        let v1985: string =
                                                            Supervisor::method9();
                                                        let v1986: &str =
                                                            &v1985.as_str();
                                                        let v1989: &str =
                                                            &v1986[4i32 as
                                                                       usize..6i32
                                                                                  as
                                                                                  usize];
                                                        let v1990: string =
                                                            fable_library_rust::String_::fromStr(&v1989);
                                                        let v1991: u8 =
                                                            u8::from_str_radix(&v1990, 16).unwrap();
                                                        let v1992:
                                                                colored::ColoredString =
                                                            colored::Colorize::truecolor(&*v1970.to_string(), v1977, v1984, v1991);
                                                        let v1993:
                                                                std::string::String =
                                                            format!("{}", &v1992);
                                                        let v1995: string =
                                                            fable_library_rust::String_::fromStr(&&v1894);
                                                        let v1997: &str =
                                                            r#""([^"]+)", "([^"]+)""#;
                                                        let v1998:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1997);
                                                        let v1999:
                                                                &regex::Regex =
                                                            &v1998.build().unwrap();
                                                        let v2000: string =
                                                            Supervisor::method2(v1995);
                                                        let v2001: &str =
                                                            &v2000.as_str();
                                                        let v2002: string =
                                                            Supervisor::method3();
                                                        let v2003: &str =
                                                            &v2002.as_str();
                                                        let v2004:
                                                                std::string::String =
                                                            v1999.replace_all(&v2001, v2003).to_string();
                                                        let v2005: string =
                                                            fable_library_rust::String_::fromStr(&v2004);
                                                        let v2007: &str =
                                                            r#"\["(.*?)"\]"#;
                                                        let v2008:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v2007);
                                                        let v2009:
                                                                &regex::Regex =
                                                            &v2008.build().unwrap();
                                                        let v2010: string =
                                                            Supervisor::method2(v2005);
                                                        let v2011: &str =
                                                            &v2010.as_str();
                                                        let v2012: string =
                                                            Supervisor::method4();
                                                        let v2013: &str =
                                                            &v2012.as_str();
                                                        let v2014:
                                                                std::string::String =
                                                            v2009.replace_all(&v2011, v2013).to_string();
                                                        let v2015: string =
                                                            fable_library_rust::String_::fromStr(&v2014);
                                                        let v2017: &str =
                                                            r#", "#;
                                                        let v2018:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v2017);
                                                        let v2019:
                                                                &regex::Regex =
                                                            &v2018.build().unwrap();
                                                        let v2020: string =
                                                            Supervisor::method2(v2015);
                                                        let v2021: &str =
                                                            &v2020.as_str();
                                                        let v2022: string =
                                                            Supervisor::method5();
                                                        let v2023: &str =
                                                            &v2022.as_str();
                                                        let v2024:
                                                                std::string::String =
                                                            v2019.replace_all(&v2021, v2023).to_string();
                                                        let v2025: string =
                                                            fable_library_rust::String_::fromStr(&v2024);
                                                        let v2027:
                                                                std::string::String =
                                                            (&v2025).to_string().clone();
                                                        let v2028: string =
                                                            Supervisor::method7();
                                                        let v2029: &str =
                                                            &v2028.as_str();
                                                        let v2032: &str =
                                                            &v2029[0i32 as
                                                                       usize..2i32
                                                                                  as
                                                                                  usize];
                                                        let v2033: string =
                                                            fable_library_rust::String_::fromStr(&v2032);
                                                        let v2034: u8 =
                                                            u8::from_str_radix(&v2033, 16).unwrap();
                                                        let v2035: string =
                                                            Supervisor::method7();
                                                        let v2036: &str =
                                                            &v2035.as_str();
                                                        let v2039: &str =
                                                            &v2036[2i32 as
                                                                       usize..4i32
                                                                                  as
                                                                                  usize];
                                                        let v2040: string =
                                                            fable_library_rust::String_::fromStr(&v2039);
                                                        let v2041: u8 =
                                                            u8::from_str_radix(&v2040, 16).unwrap();
                                                        let v2042: string =
                                                            Supervisor::method7();
                                                        let v2043: &str =
                                                            &v2042.as_str();
                                                        let v2046: &str =
                                                            &v2043[4i32 as
                                                                       usize..6i32
                                                                                  as
                                                                                  usize];
                                                        let v2047: string =
                                                            fable_library_rust::String_::fromStr(&v2046);
                                                        let v2048: u8 =
                                                            u8::from_str_radix(&v2047, 16).unwrap();
                                                        let v2049:
                                                                colored::ColoredString =
                                                            colored::Colorize::truecolor(&*v2027.to_string(), v2034, v2041, v2048);
                                                        let v2050:
                                                                std::string::String =
                                                            format!("{}", &v2049);
                                                        println!("{0}",
                                                                 stringFrom(format!("{0} {1} {2}", &v1936, &v1993, &v2050)));
                                                        {
                                                            let v2054:
                                                                    std::string::String =
                                                                (&string("> spiproj_open; ok")).to_string().clone();
                                                            let v2055:
                                                                    chrono::DateTime<chrono::Utc> =
                                                                chrono::Utc::now();
                                                            let v2060:
                                                                    string =
                                                                Supervisor::method1(6i32,
                                                                                    toString(&((&v2055).timestamp()
                                                                                                   -
                                                                                                   v9)));
                                                            let v2061: u8 =
                                                                rand::random::<u8>();
                                                            let v2074:
                                                                    Array<std::string::String> =
                                                                array(&[(&v52).to_string(),
                                                                        (&v2060).to_string(),
                                                                        (&v57).to_string(),
                                                                        format!("{:?}", &v2061),
                                                                        (&v63).to_string(),
                                                                        (&v66).to_string()]);
                                                            let v2075 =
                                                                core::ops::Deref::deref(&v2074);
                                                            let v2077:
                                                                    std::string::String =
                                                                format!("{:?}", ***v2075).clone();
                                                            let v2080:
                                                                    Array<std::string::String> =
                                                                array(&[(&v73).to_string()]);
                                                            let v2081 =
                                                                core::ops::Deref::deref(&v2080);
                                                            let v2084:
                                                                    std::string::String =
                                                                format!("{:?}", ***v2081).clone();
                                                            let v2085:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2084);
                                                            let v2087: &str =
                                                                r#""([^"]+)", "([^"]+)""#;
                                                            let v2088:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2087);
                                                            let v2089:
                                                                    &regex::Regex =
                                                                &v2088.build().unwrap();
                                                            let v2090:
                                                                    string =
                                                                Supervisor::method2(v2085);
                                                            let v2091: &str =
                                                                &v2090.as_str();
                                                            let v2092:
                                                                    string =
                                                                Supervisor::method3();
                                                            let v2093: &str =
                                                                &v2092.as_str();
                                                            let v2094:
                                                                    std::string::String =
                                                                v2089.replace_all(&v2091, v2093).to_string();
                                                            let v2095:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2094);
                                                            let v2097: &str =
                                                                r#"\["(.*?)"\]"#;
                                                            let v2098:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2097);
                                                            let v2099:
                                                                    &regex::Regex =
                                                                &v2098.build().unwrap();
                                                            let v2100:
                                                                    string =
                                                                Supervisor::method2(v2095);
                                                            let v2101: &str =
                                                                &v2100.as_str();
                                                            let v2102:
                                                                    string =
                                                                Supervisor::method4();
                                                            let v2103: &str =
                                                                &v2102.as_str();
                                                            let v2104:
                                                                    std::string::String =
                                                                v2099.replace_all(&v2101, v2103).to_string();
                                                            let v2105:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2104);
                                                            let v2107: &str =
                                                                r#", "#;
                                                            let v2108:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2107);
                                                            let v2109:
                                                                    &regex::Regex =
                                                                &v2108.build().unwrap();
                                                            let v2110:
                                                                    string =
                                                                Supervisor::method2(v2105);
                                                            let v2111: &str =
                                                                &v2110.as_str();
                                                            let v2112:
                                                                    string =
                                                                Supervisor::method5();
                                                            let v2113: &str =
                                                                &v2112.as_str();
                                                            let v2114:
                                                                    std::string::String =
                                                                v2109.replace_all(&v2111, v2113).to_string();
                                                            let v2115:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2114);
                                                            let v2117:
                                                                    std::string::String =
                                                                (&v2115).to_string().clone();
                                                            let v2118:
                                                                    colored::ColoredString =
                                                                colored::Colorize::color(&*v2117, v122.clone().to_string());
                                                            let v2119:
                                                                    std::string::String =
                                                                format!("{}", &v2118);
                                                            let v2121:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&&v2054);
                                                            let v2123: &str =
                                                                r#""([^"]+)", "([^"]+)""#;
                                                            let v2124:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2123);
                                                            let v2125:
                                                                    &regex::Regex =
                                                                &v2124.build().unwrap();
                                                            let v2126:
                                                                    string =
                                                                Supervisor::method2(v2121);
                                                            let v2127: &str =
                                                                &v2126.as_str();
                                                            let v2128:
                                                                    string =
                                                                Supervisor::method3();
                                                            let v2129: &str =
                                                                &v2128.as_str();
                                                            let v2130:
                                                                    std::string::String =
                                                                v2125.replace_all(&v2127, v2129).to_string();
                                                            let v2131:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2130);
                                                            let v2133: &str =
                                                                r#"\["(.*?)"\]"#;
                                                            let v2134:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2133);
                                                            let v2135:
                                                                    &regex::Regex =
                                                                &v2134.build().unwrap();
                                                            let v2136:
                                                                    string =
                                                                Supervisor::method2(v2131);
                                                            let v2137: &str =
                                                                &v2136.as_str();
                                                            let v2138:
                                                                    string =
                                                                Supervisor::method4();
                                                            let v2139: &str =
                                                                &v2138.as_str();
                                                            let v2140:
                                                                    std::string::String =
                                                                v2135.replace_all(&v2137, v2139).to_string();
                                                            let v2141:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2140);
                                                            let v2143: &str =
                                                                r#", "#;
                                                            let v2144:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2143);
                                                            let v2145:
                                                                    &regex::Regex =
                                                                &v2144.build().unwrap();
                                                            let v2146:
                                                                    string =
                                                                Supervisor::method2(v2141);
                                                            let v2147: &str =
                                                                &v2146.as_str();
                                                            let v2148:
                                                                    string =
                                                                Supervisor::method5();
                                                            let v2149: &str =
                                                                &v2148.as_str();
                                                            let v2150:
                                                                    std::string::String =
                                                                v2145.replace_all(&v2147, v2149).to_string();
                                                            let v2151:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2150);
                                                            let v2153:
                                                                    std::string::String =
                                                                (&v2151).to_string().clone();
                                                            let v2154:
                                                                    string =
                                                                Supervisor::method6();
                                                            let v2155: &str =
                                                                &v2154.as_str();
                                                            let v2158: &str =
                                                                &v2155[0i32 as
                                                                           usize..2i32
                                                                                      as
                                                                                      usize];
                                                            let v2159:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2158);
                                                            let v2160: u8 =
                                                                u8::from_str_radix(&v2159, 16).unwrap();
                                                            let v2161:
                                                                    string =
                                                                Supervisor::method6();
                                                            let v2162: &str =
                                                                &v2161.as_str();
                                                            let v2165: &str =
                                                                &v2162[2i32 as
                                                                           usize..4i32
                                                                                      as
                                                                                      usize];
                                                            let v2166:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2165);
                                                            let v2167: u8 =
                                                                u8::from_str_radix(&v2166, 16).unwrap();
                                                            let v2168:
                                                                    string =
                                                                Supervisor::method6();
                                                            let v2169: &str =
                                                                &v2168.as_str();
                                                            let v2172: &str =
                                                                &v2169[4i32 as
                                                                           usize..6i32
                                                                                      as
                                                                                      usize];
                                                            let v2173:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2172);
                                                            let v2174: u8 =
                                                                u8::from_str_radix(&v2173, 16).unwrap();
                                                            let v2175:
                                                                    colored::ColoredString =
                                                                colored::Colorize::truecolor(&*v2153.to_string(), v2160, v2167, v2174);
                                                            let v2176:
                                                                    std::string::String =
                                                                format!("{}", &v2175);
                                                            let v2178:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&&v2077);
                                                            let v2180: &str =
                                                                r#""([^"]+)", "([^"]+)""#;
                                                            let v2181:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2180);
                                                            let v2182:
                                                                    &regex::Regex =
                                                                &v2181.build().unwrap();
                                                            let v2183:
                                                                    string =
                                                                Supervisor::method2(v2178);
                                                            let v2184: &str =
                                                                &v2183.as_str();
                                                            let v2185:
                                                                    string =
                                                                Supervisor::method3();
                                                            let v2186: &str =
                                                                &v2185.as_str();
                                                            let v2187:
                                                                    std::string::String =
                                                                v2182.replace_all(&v2184, v2186).to_string();
                                                            let v2188:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2187);
                                                            let v2190: &str =
                                                                r#"\["(.*?)"\]"#;
                                                            let v2191:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2190);
                                                            let v2192:
                                                                    &regex::Regex =
                                                                &v2191.build().unwrap();
                                                            let v2193:
                                                                    string =
                                                                Supervisor::method2(v2188);
                                                            let v2194: &str =
                                                                &v2193.as_str();
                                                            let v2195:
                                                                    string =
                                                                Supervisor::method4();
                                                            let v2196: &str =
                                                                &v2195.as_str();
                                                            let v2197:
                                                                    std::string::String =
                                                                v2192.replace_all(&v2194, v2196).to_string();
                                                            let v2198:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2197);
                                                            let v2200: &str =
                                                                r#", "#;
                                                            let v2201:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v2200);
                                                            let v2202:
                                                                    &regex::Regex =
                                                                &v2201.build().unwrap();
                                                            let v2203:
                                                                    string =
                                                                Supervisor::method2(v2198);
                                                            let v2204: &str =
                                                                &v2203.as_str();
                                                            let v2205:
                                                                    string =
                                                                Supervisor::method5();
                                                            let v2206: &str =
                                                                &v2205.as_str();
                                                            let v2207:
                                                                    std::string::String =
                                                                v2202.replace_all(&v2204, v2206).to_string();
                                                            let v2208:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2207);
                                                            let v2210:
                                                                    std::string::String =
                                                                (&v2208).to_string().clone();
                                                            let v2211:
                                                                    string =
                                                                Supervisor::method7();
                                                            let v2212: &str =
                                                                &v2211.as_str();
                                                            let v2215: &str =
                                                                &v2212[0i32 as
                                                                           usize..2i32
                                                                                      as
                                                                                      usize];
                                                            let v2216:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2215);
                                                            let v2217: u8 =
                                                                u8::from_str_radix(&v2216, 16).unwrap();
                                                            let v2218:
                                                                    string =
                                                                Supervisor::method7();
                                                            let v2219: &str =
                                                                &v2218.as_str();
                                                            let v2222: &str =
                                                                &v2219[2i32 as
                                                                           usize..4i32
                                                                                      as
                                                                                      usize];
                                                            let v2223:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2222);
                                                            let v2224: u8 =
                                                                u8::from_str_radix(&v2223, 16).unwrap();
                                                            let v2225:
                                                                    string =
                                                                Supervisor::method7();
                                                            let v2226: &str =
                                                                &v2225.as_str();
                                                            let v2229: &str =
                                                                &v2226[4i32 as
                                                                           usize..6i32
                                                                                      as
                                                                                      usize];
                                                            let v2230:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v2229);
                                                            let v2231: u8 =
                                                                u8::from_str_radix(&v2230, 16).unwrap();
                                                            let v2232:
                                                                    colored::ColoredString =
                                                                colored::Colorize::truecolor(&*v2210.to_string(), v2217, v2224, v2231);
                                                            let v2233:
                                                                    std::string::String =
                                                                format!("{}", &v2232);
                                                            println!("{0}",
                                                                     stringFrom(format!("{0} {1} {2}", &v2119, &v2176, &v2233)));
                                                            {
                                                                let patternInput_3:
                                                                        (string,
                                                                         string,
                                                                         string,
                                                                         bool) =
                                                                    Supervisor::method0();
                                                                let v2239:
                                                                        chrono::DateTime<chrono::Utc> =
                                                                    chrono::Utc::now();
                                                                let v2240:
                                                                        i64 =
                                                                    (&v2239).timestamp();
                                                                let v2242:
                                                                        std::string::String =
                                                                    (&v25).to_string().clone();
                                                                let v2243:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&format!("{}", &v246.display()));
                                                                let v2249:
                                                                        string =
                                                                    string("Fsharp");
                                                                let v2252:
                                                                        Array<std::string::String> =
                                                                    array(&[v2242,
                                                                            (&v2243).to_string(),
                                                                            (&string("backend")).to_string(),
                                                                            (&v2249).to_string()]);
                                                                let v2253 =
                                                                    core::ops::Deref::deref(&v2252);
                                                                let v2255:
                                                                        std::string::String =
                                                                    format!("{:?}", ***v2253).clone();
                                                                let v2256:
                                                                        chrono::DateTime<chrono::Utc> =
                                                                    chrono::Utc::now();
                                                                let v2261:
                                                                        string =
                                                                    Supervisor::method1(6i32,
                                                                                        toString(&((&v2256).timestamp()
                                                                                                       -
                                                                                                       v2240)));
                                                                let v2262:
                                                                        u8 =
                                                                    rand::random::<u8>();
                                                                let v2275:
                                                                        Array<std::string::String> =
                                                                    array(&[(&v52).to_string(),
                                                                            (&v2261).to_string(),
                                                                            (&v57).to_string(),
                                                                            format!("{:?}", &v2262),
                                                                            (&v63).to_string(),
                                                                            (&v66).to_string()]);
                                                                let v2276 =
                                                                    core::ops::Deref::deref(&v2275);
                                                                let v2278:
                                                                        std::string::String =
                                                                    format!("{:?}", ***v2276).clone();
                                                                let v2279:
                                                                        string =
                                                                    string("> spi_build_file ()");
                                                                let v2282:
                                                                        Array<std::string::String> =
                                                                    array(&[(&v2279).to_string()]);
                                                                let v2283 =
                                                                    core::ops::Deref::deref(&v2282);
                                                                let v2286:
                                                                        std::string::String =
                                                                    format!("{:?}", ***v2283).clone();
                                                                let v2287:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2286);
                                                                let v2289:
                                                                        &str =
                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                let v2290:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2289);
                                                                let v2291:
                                                                        &regex::Regex =
                                                                    &v2290.build().unwrap();
                                                                let v2292:
                                                                        string =
                                                                    Supervisor::method2(v2287);
                                                                let v2293:
                                                                        &str =
                                                                    &v2292.as_str();
                                                                let v2294:
                                                                        string =
                                                                    Supervisor::method3();
                                                                let v2295:
                                                                        &str =
                                                                    &v2294.as_str();
                                                                let v2296:
                                                                        std::string::String =
                                                                    v2291.replace_all(&v2293, v2295).to_string();
                                                                let v2297:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2296);
                                                                let v2299:
                                                                        &str =
                                                                    r#"\["(.*?)"\]"#;
                                                                let v2300:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2299);
                                                                let v2301:
                                                                        &regex::Regex =
                                                                    &v2300.build().unwrap();
                                                                let v2302:
                                                                        string =
                                                                    Supervisor::method2(v2297);
                                                                let v2303:
                                                                        &str =
                                                                    &v2302.as_str();
                                                                let v2304:
                                                                        string =
                                                                    Supervisor::method4();
                                                                let v2305:
                                                                        &str =
                                                                    &v2304.as_str();
                                                                let v2306:
                                                                        std::string::String =
                                                                    v2301.replace_all(&v2303, v2305).to_string();
                                                                let v2307:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2306);
                                                                let v2309:
                                                                        &str =
                                                                    r#", "#;
                                                                let v2310:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2309);
                                                                let v2311:
                                                                        &regex::Regex =
                                                                    &v2310.build().unwrap();
                                                                let v2312:
                                                                        string =
                                                                    Supervisor::method2(v2307);
                                                                let v2313:
                                                                        &str =
                                                                    &v2312.as_str();
                                                                let v2314:
                                                                        string =
                                                                    Supervisor::method5();
                                                                let v2315:
                                                                        &str =
                                                                    &v2314.as_str();
                                                                let v2316:
                                                                        std::string::String =
                                                                    v2311.replace_all(&v2313, v2315).to_string();
                                                                let v2317:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2316);
                                                                let v2319:
                                                                        std::string::String =
                                                                    (&v2317).to_string().clone();
                                                                let v2320:
                                                                        colored::ColoredString =
                                                                    colored::Colorize::color(&*v2319, v122.clone().to_string());
                                                                let v2321:
                                                                        std::string::String =
                                                                    format!("{}", &v2320);
                                                                let v2323:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&&v2255);
                                                                let v2325:
                                                                        &str =
                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                let v2326:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2325);
                                                                let v2327:
                                                                        &regex::Regex =
                                                                    &v2326.build().unwrap();
                                                                let v2328:
                                                                        string =
                                                                    Supervisor::method2(v2323);
                                                                let v2329:
                                                                        &str =
                                                                    &v2328.as_str();
                                                                let v2330:
                                                                        string =
                                                                    Supervisor::method3();
                                                                let v2331:
                                                                        &str =
                                                                    &v2330.as_str();
                                                                let v2332:
                                                                        std::string::String =
                                                                    v2327.replace_all(&v2329, v2331).to_string();
                                                                let v2333:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2332);
                                                                let v2335:
                                                                        &str =
                                                                    r#"\["(.*?)"\]"#;
                                                                let v2336:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2335);
                                                                let v2337:
                                                                        &regex::Regex =
                                                                    &v2336.build().unwrap();
                                                                let v2338:
                                                                        string =
                                                                    Supervisor::method2(v2333);
                                                                let v2339:
                                                                        &str =
                                                                    &v2338.as_str();
                                                                let v2340:
                                                                        string =
                                                                    Supervisor::method4();
                                                                let v2341:
                                                                        &str =
                                                                    &v2340.as_str();
                                                                let v2342:
                                                                        std::string::String =
                                                                    v2337.replace_all(&v2339, v2341).to_string();
                                                                let v2343:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2342);
                                                                let v2345:
                                                                        &str =
                                                                    r#", "#;
                                                                let v2346:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2345);
                                                                let v2347:
                                                                        &regex::Regex =
                                                                    &v2346.build().unwrap();
                                                                let v2348:
                                                                        string =
                                                                    Supervisor::method2(v2343);
                                                                let v2349:
                                                                        &str =
                                                                    &v2348.as_str();
                                                                let v2350:
                                                                        string =
                                                                    Supervisor::method5();
                                                                let v2351:
                                                                        &str =
                                                                    &v2350.as_str();
                                                                let v2352:
                                                                        std::string::String =
                                                                    v2347.replace_all(&v2349, v2351).to_string();
                                                                let v2353:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2352);
                                                                let v2355:
                                                                        std::string::String =
                                                                    (&v2353).to_string().clone();
                                                                let v2356:
                                                                        string =
                                                                    Supervisor::method10();
                                                                let v2357:
                                                                        &str =
                                                                    &v2356.as_str();
                                                                let v2360:
                                                                        &str =
                                                                    &v2357[0i32
                                                                               as
                                                                               usize..2i32
                                                                                          as
                                                                                          usize];
                                                                let v2361:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2360);
                                                                let v2362:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2361, 16).unwrap();
                                                                let v2363:
                                                                        string =
                                                                    Supervisor::method10();
                                                                let v2364:
                                                                        &str =
                                                                    &v2363.as_str();
                                                                let v2367:
                                                                        &str =
                                                                    &v2364[2i32
                                                                               as
                                                                               usize..4i32
                                                                                          as
                                                                                          usize];
                                                                let v2368:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2367);
                                                                let v2369:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2368, 16).unwrap();
                                                                let v2370:
                                                                        string =
                                                                    Supervisor::method10();
                                                                let v2371:
                                                                        &str =
                                                                    &v2370.as_str();
                                                                let v2374:
                                                                        &str =
                                                                    &v2371[4i32
                                                                               as
                                                                               usize..6i32
                                                                                          as
                                                                                          usize];
                                                                let v2375:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2374);
                                                                let v2376:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2375, 16).unwrap();
                                                                let v2377:
                                                                        colored::ColoredString =
                                                                    colored::Colorize::truecolor(&*v2355.to_string(), v2362, v2369, v2376);
                                                                let v2378:
                                                                        std::string::String =
                                                                    format!("{}", &v2377);
                                                                let v2380:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&&v2278);
                                                                let v2382:
                                                                        &str =
                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                let v2383:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2382);
                                                                let v2384:
                                                                        &regex::Regex =
                                                                    &v2383.build().unwrap();
                                                                let v2385:
                                                                        string =
                                                                    Supervisor::method2(v2380);
                                                                let v2386:
                                                                        &str =
                                                                    &v2385.as_str();
                                                                let v2387:
                                                                        string =
                                                                    Supervisor::method3();
                                                                let v2388:
                                                                        &str =
                                                                    &v2387.as_str();
                                                                let v2389:
                                                                        std::string::String =
                                                                    v2384.replace_all(&v2386, v2388).to_string();
                                                                let v2390:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2389);
                                                                let v2392:
                                                                        &str =
                                                                    r#"\["(.*?)"\]"#;
                                                                let v2393:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2392);
                                                                let v2394:
                                                                        &regex::Regex =
                                                                    &v2393.build().unwrap();
                                                                let v2395:
                                                                        string =
                                                                    Supervisor::method2(v2390);
                                                                let v2396:
                                                                        &str =
                                                                    &v2395.as_str();
                                                                let v2397:
                                                                        string =
                                                                    Supervisor::method4();
                                                                let v2398:
                                                                        &str =
                                                                    &v2397.as_str();
                                                                let v2399:
                                                                        std::string::String =
                                                                    v2394.replace_all(&v2396, v2398).to_string();
                                                                let v2400:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2399);
                                                                let v2402:
                                                                        &str =
                                                                    r#", "#;
                                                                let v2403:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2402);
                                                                let v2404:
                                                                        &regex::Regex =
                                                                    &v2403.build().unwrap();
                                                                let v2405:
                                                                        string =
                                                                    Supervisor::method2(v2400);
                                                                let v2406:
                                                                        &str =
                                                                    &v2405.as_str();
                                                                let v2407:
                                                                        string =
                                                                    Supervisor::method5();
                                                                let v2408:
                                                                        &str =
                                                                    &v2407.as_str();
                                                                let v2409:
                                                                        std::string::String =
                                                                    v2404.replace_all(&v2406, v2408).to_string();
                                                                let v2410:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2409);
                                                                let v2412:
                                                                        std::string::String =
                                                                    (&v2410).to_string().clone();
                                                                let v2413:
                                                                        string =
                                                                    Supervisor::method7();
                                                                let v2414:
                                                                        &str =
                                                                    &v2413.as_str();
                                                                let v2417:
                                                                        &str =
                                                                    &v2414[0i32
                                                                               as
                                                                               usize..2i32
                                                                                          as
                                                                                          usize];
                                                                let v2418:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2417);
                                                                let v2419:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2418, 16).unwrap();
                                                                let v2420:
                                                                        string =
                                                                    Supervisor::method7();
                                                                let v2421:
                                                                        &str =
                                                                    &v2420.as_str();
                                                                let v2424:
                                                                        &str =
                                                                    &v2421[2i32
                                                                               as
                                                                               usize..4i32
                                                                                          as
                                                                                          usize];
                                                                let v2425:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2424);
                                                                let v2426:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2425, 16).unwrap();
                                                                let v2427:
                                                                        string =
                                                                    Supervisor::method7();
                                                                let v2428:
                                                                        &str =
                                                                    &v2427.as_str();
                                                                let v2431:
                                                                        &str =
                                                                    &v2428[4i32
                                                                               as
                                                                               usize..6i32
                                                                                          as
                                                                                          usize];
                                                                let v2432:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2431);
                                                                let v2433:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2432, 16).unwrap();
                                                                let v2434:
                                                                        colored::ColoredString =
                                                                    colored::Colorize::truecolor(&*v2412.to_string(), v2419, v2426, v2433);
                                                                let v2435:
                                                                        std::string::String =
                                                                    format!("{}", &v2434);
                                                                println!("{0}",
                                                                         stringFrom(format!("{0} {1} {2}", &v2321, &v2378, &v2435)));
                                                                {
                                                                    let v2437:
                                                                            std::string::String =
                                                                        (&v2249).to_string();
                                                                    let v2446:
                                                                            string =
                                                                        append(append(v1449,
                                                                                      append(append(append(append(append(v1439,
                                                                                                                         string("\"BuildFile\": {")),
                                                                                                                  v1442),
                                                                                                           string("\"backend\": $1")),
                                                                                                    v1446.clone()),
                                                                                             v1446)),
                                                                               v1451);
                                                                    let v2447:
                                                                            std::string::String =
                                                                        serde_json::json!({"BuildFile": {"uri": v246,"backend": v2437}}).to_string();
                                                                    let v2450:
                                                                            std::string::String =
                                                                        (&string("json len")).to_string().clone();
                                                                    let v2451:
                                                                            i32 =
                                                                        (&v2447).len().try_into().unwrap();
                                                                    let v2454:
                                                                            Array<std::string::String> =
                                                                        array(&[v2450,
                                                                                format!("{:?}", &v2451)]);
                                                                    let v2455 =
                                                                        core::ops::Deref::deref(&v2454);
                                                                    let v2457:
                                                                            std::string::String =
                                                                        format!("{:?}", ***v2455).clone();
                                                                    let v2458:
                                                                            chrono::DateTime<chrono::Utc> =
                                                                        chrono::Utc::now();
                                                                    let v2463:
                                                                            string =
                                                                        Supervisor::method1(6i32,
                                                                                            toString(&((&v2458).timestamp()
                                                                                                           -
                                                                                                           v2240)));
                                                                    let v2464:
                                                                            u8 =
                                                                        rand::random::<u8>();
                                                                    let v2477:
                                                                            Array<std::string::String> =
                                                                        array(&[(&v52).to_string(),
                                                                                (&v2463).to_string(),
                                                                                (&v57).to_string(),
                                                                                format!("{:?}", &v2464),
                                                                                (&v63).to_string(),
                                                                                (&v66).to_string()]);
                                                                    let v2478 =
                                                                        core::ops::Deref::deref(&v2477);
                                                                    let v2480:
                                                                            std::string::String =
                                                                        format!("{:?}", ***v2478).clone();
                                                                    let v2483:
                                                                            Array<std::string::String> =
                                                                        array(&[(&v2279).to_string()]);
                                                                    let v2484 =
                                                                        core::ops::Deref::deref(&v2483);
                                                                    let v2487:
                                                                            std::string::String =
                                                                        format!("{:?}", ***v2484).clone();
                                                                    let v2488:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2487);
                                                                    let v2490:
                                                                            &str =
                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                    let v2491:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2490);
                                                                    let v2492:
                                                                            &regex::Regex =
                                                                        &v2491.build().unwrap();
                                                                    let v2493:
                                                                            string =
                                                                        Supervisor::method2(v2488);
                                                                    let v2494:
                                                                            &str =
                                                                        &v2493.as_str();
                                                                    let v2495:
                                                                            string =
                                                                        Supervisor::method3();
                                                                    let v2496:
                                                                            &str =
                                                                        &v2495.as_str();
                                                                    let v2497:
                                                                            std::string::String =
                                                                        v2492.replace_all(&v2494, v2496).to_string();
                                                                    let v2498:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2497);
                                                                    let v2500:
                                                                            &str =
                                                                        r#"\["(.*?)"\]"#;
                                                                    let v2501:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2500);
                                                                    let v2502:
                                                                            &regex::Regex =
                                                                        &v2501.build().unwrap();
                                                                    let v2503:
                                                                            string =
                                                                        Supervisor::method2(v2498);
                                                                    let v2504:
                                                                            &str =
                                                                        &v2503.as_str();
                                                                    let v2505:
                                                                            string =
                                                                        Supervisor::method4();
                                                                    let v2506:
                                                                            &str =
                                                                        &v2505.as_str();
                                                                    let v2507:
                                                                            std::string::String =
                                                                        v2502.replace_all(&v2504, v2506).to_string();
                                                                    let v2508:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2507);
                                                                    let v2510:
                                                                            &str =
                                                                        r#", "#;
                                                                    let v2511:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2510);
                                                                    let v2512:
                                                                            &regex::Regex =
                                                                        &v2511.build().unwrap();
                                                                    let v2513:
                                                                            string =
                                                                        Supervisor::method2(v2508);
                                                                    let v2514:
                                                                            &str =
                                                                        &v2513.as_str();
                                                                    let v2515:
                                                                            string =
                                                                        Supervisor::method5();
                                                                    let v2516:
                                                                            &str =
                                                                        &v2515.as_str();
                                                                    let v2517:
                                                                            std::string::String =
                                                                        v2512.replace_all(&v2514, v2516).to_string();
                                                                    let v2518:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2517);
                                                                    let v2520:
                                                                            std::string::String =
                                                                        (&v2518).to_string().clone();
                                                                    let v2521:
                                                                            colored::ColoredString =
                                                                        colored::Colorize::color(&*v2520, v122.clone().to_string());
                                                                    let v2522:
                                                                            std::string::String =
                                                                        format!("{}", &v2521);
                                                                    let v2524:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&&v2457);
                                                                    let v2526:
                                                                            &str =
                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                    let v2527:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2526);
                                                                    let v2528:
                                                                            &regex::Regex =
                                                                        &v2527.build().unwrap();
                                                                    let v2529:
                                                                            string =
                                                                        Supervisor::method2(v2524);
                                                                    let v2530:
                                                                            &str =
                                                                        &v2529.as_str();
                                                                    let v2531:
                                                                            string =
                                                                        Supervisor::method3();
                                                                    let v2532:
                                                                            &str =
                                                                        &v2531.as_str();
                                                                    let v2533:
                                                                            std::string::String =
                                                                        v2528.replace_all(&v2530, v2532).to_string();
                                                                    let v2534:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2533);
                                                                    let v2536:
                                                                            &str =
                                                                        r#"\["(.*?)"\]"#;
                                                                    let v2537:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2536);
                                                                    let v2538:
                                                                            &regex::Regex =
                                                                        &v2537.build().unwrap();
                                                                    let v2539:
                                                                            string =
                                                                        Supervisor::method2(v2534);
                                                                    let v2540:
                                                                            &str =
                                                                        &v2539.as_str();
                                                                    let v2541:
                                                                            string =
                                                                        Supervisor::method4();
                                                                    let v2542:
                                                                            &str =
                                                                        &v2541.as_str();
                                                                    let v2543:
                                                                            std::string::String =
                                                                        v2538.replace_all(&v2540, v2542).to_string();
                                                                    let v2544:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2543);
                                                                    let v2546:
                                                                            &str =
                                                                        r#", "#;
                                                                    let v2547:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2546);
                                                                    let v2548:
                                                                            &regex::Regex =
                                                                        &v2547.build().unwrap();
                                                                    let v2549:
                                                                            string =
                                                                        Supervisor::method2(v2544);
                                                                    let v2550:
                                                                            &str =
                                                                        &v2549.as_str();
                                                                    let v2551:
                                                                            string =
                                                                        Supervisor::method5();
                                                                    let v2552:
                                                                            &str =
                                                                        &v2551.as_str();
                                                                    let v2553:
                                                                            std::string::String =
                                                                        v2548.replace_all(&v2550, v2552).to_string();
                                                                    let v2554:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2553);
                                                                    let v2556:
                                                                            std::string::String =
                                                                        (&v2554).to_string().clone();
                                                                    let v2557:
                                                                            string =
                                                                        Supervisor::method10();
                                                                    let v2558:
                                                                            &str =
                                                                        &v2557.as_str();
                                                                    let v2561:
                                                                            &str =
                                                                        &v2558[0i32
                                                                                   as
                                                                                   usize..2i32
                                                                                              as
                                                                                              usize];
                                                                    let v2562:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2561);
                                                                    let v2563:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2562, 16).unwrap();
                                                                    let v2564:
                                                                            string =
                                                                        Supervisor::method10();
                                                                    let v2565:
                                                                            &str =
                                                                        &v2564.as_str();
                                                                    let v2568:
                                                                            &str =
                                                                        &v2565[2i32
                                                                                   as
                                                                                   usize..4i32
                                                                                              as
                                                                                              usize];
                                                                    let v2569:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2568);
                                                                    let v2570:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2569, 16).unwrap();
                                                                    let v2571:
                                                                            string =
                                                                        Supervisor::method10();
                                                                    let v2572:
                                                                            &str =
                                                                        &v2571.as_str();
                                                                    let v2575:
                                                                            &str =
                                                                        &v2572[4i32
                                                                                   as
                                                                                   usize..6i32
                                                                                              as
                                                                                              usize];
                                                                    let v2576:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2575);
                                                                    let v2577:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2576, 16).unwrap();
                                                                    let v2578:
                                                                            colored::ColoredString =
                                                                        colored::Colorize::truecolor(&*v2556.to_string(), v2563, v2570, v2577);
                                                                    let v2579:
                                                                            std::string::String =
                                                                        format!("{}", &v2578);
                                                                    let v2581:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&&v2480);
                                                                    let v2583:
                                                                            &str =
                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                    let v2584:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2583);
                                                                    let v2585:
                                                                            &regex::Regex =
                                                                        &v2584.build().unwrap();
                                                                    let v2586:
                                                                            string =
                                                                        Supervisor::method2(v2581);
                                                                    let v2587:
                                                                            &str =
                                                                        &v2586.as_str();
                                                                    let v2588:
                                                                            string =
                                                                        Supervisor::method3();
                                                                    let v2589:
                                                                            &str =
                                                                        &v2588.as_str();
                                                                    let v2590:
                                                                            std::string::String =
                                                                        v2585.replace_all(&v2587, v2589).to_string();
                                                                    let v2591:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2590);
                                                                    let v2593:
                                                                            &str =
                                                                        r#"\["(.*?)"\]"#;
                                                                    let v2594:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2593);
                                                                    let v2595:
                                                                            &regex::Regex =
                                                                        &v2594.build().unwrap();
                                                                    let v2596:
                                                                            string =
                                                                        Supervisor::method2(v2591);
                                                                    let v2597:
                                                                            &str =
                                                                        &v2596.as_str();
                                                                    let v2598:
                                                                            string =
                                                                        Supervisor::method4();
                                                                    let v2599:
                                                                            &str =
                                                                        &v2598.as_str();
                                                                    let v2600:
                                                                            std::string::String =
                                                                        v2595.replace_all(&v2597, v2599).to_string();
                                                                    let v2601:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2600);
                                                                    let v2603:
                                                                            &str =
                                                                        r#", "#;
                                                                    let v2604:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2603);
                                                                    let v2605:
                                                                            &regex::Regex =
                                                                        &v2604.build().unwrap();
                                                                    let v2606:
                                                                            string =
                                                                        Supervisor::method2(v2601);
                                                                    let v2607:
                                                                            &str =
                                                                        &v2606.as_str();
                                                                    let v2608:
                                                                            string =
                                                                        Supervisor::method5();
                                                                    let v2609:
                                                                            &str =
                                                                        &v2608.as_str();
                                                                    let v2610:
                                                                            std::string::String =
                                                                        v2605.replace_all(&v2607, v2609).to_string();
                                                                    let v2611:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2610);
                                                                    let v2613:
                                                                            std::string::String =
                                                                        (&v2611).to_string().clone();
                                                                    let v2614:
                                                                            string =
                                                                        Supervisor::method7();
                                                                    let v2615:
                                                                            &str =
                                                                        &v2614.as_str();
                                                                    let v2618:
                                                                            &str =
                                                                        &v2615[0i32
                                                                                   as
                                                                                   usize..2i32
                                                                                              as
                                                                                              usize];
                                                                    let v2619:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2618);
                                                                    let v2620:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2619, 16).unwrap();
                                                                    let v2621:
                                                                            string =
                                                                        Supervisor::method7();
                                                                    let v2622:
                                                                            &str =
                                                                        &v2621.as_str();
                                                                    let v2625:
                                                                            &str =
                                                                        &v2622[2i32
                                                                                   as
                                                                                   usize..4i32
                                                                                              as
                                                                                              usize];
                                                                    let v2626:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2625);
                                                                    let v2627:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2626, 16).unwrap();
                                                                    let v2628:
                                                                            string =
                                                                        Supervisor::method7();
                                                                    let v2629:
                                                                            &str =
                                                                        &v2628.as_str();
                                                                    let v2632:
                                                                            &str =
                                                                        &v2629[4i32
                                                                                   as
                                                                                   usize..6i32
                                                                                              as
                                                                                              usize];
                                                                    let v2633:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2632);
                                                                    let v2634:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2633, 16).unwrap();
                                                                    let v2635:
                                                                            colored::ColoredString =
                                                                        colored::Colorize::truecolor(&*v2613.to_string(), v2620, v2627, v2634);
                                                                    let v2636:
                                                                            std::string::String =
                                                                        format!("{}", &v2635);
                                                                    println!("{0}",
                                                                             stringFrom(format!("{0} {1} {2}", &v2522, &v2579, &v2636)));
                                                                    {
                                                                        let patternInput_4:
                                                                                (string,
                                                                                 string,
                                                                                 string,
                                                                                 bool) =
                                                                            Supervisor::method0();
                                                                        let v2642:
                                                                                chrono::DateTime<chrono::Utc> =
                                                                            chrono::Utc::now();
                                                                        let v2643:
                                                                                i64 =
                                                                            (&v2642).timestamp();
                                                                        let v2645:
                                                                                std::string::String =
                                                                            (&v1650).to_string().clone();
                                                                        let v2647:
                                                                                std::string::String =
                                                                            (&v1653).to_string().clone();
                                                                        let v2649:
                                                                                std::string::String =
                                                                            (&v1656).to_string().clone();
                                                                        let v2651:
                                                                                std::string::String =
                                                                            format!("{:?}", &13805i32).clone();
                                                                        let v2653:
                                                                                std::string::String =
                                                                            (&v1661).to_string().clone();
                                                                        let v2654:
                                                                                i32 =
                                                                            (&v2447).len().try_into().unwrap();
                                                                        let v2657:
                                                                                Array<std::string::String> =
                                                                            array(&[v2645,
                                                                                    v2647,
                                                                                    v2649,
                                                                                    v2651,
                                                                                    v2653,
                                                                                    format!("{:?}", &v2654)]);
                                                                        let v2658 =
                                                                            core::ops::Deref::deref(&v2657);
                                                                        let v2660:
                                                                                std::string::String =
                                                                            format!("{:?}", ***v2658).clone();
                                                                        let v2661:
                                                                                chrono::DateTime<chrono::Utc> =
                                                                            chrono::Utc::now();
                                                                        let v2666:
                                                                                string =
                                                                            Supervisor::method1(6i32,
                                                                                                toString(&((&v2661).timestamp()
                                                                                                               -
                                                                                                               v2643)));
                                                                        let v2667:
                                                                                u8 =
                                                                            rand::random::<u8>();
                                                                        let v2680:
                                                                                Array<std::string::String> =
                                                                            array(&[(&v52).to_string(),
                                                                                    (&v2666).to_string(),
                                                                                    (&v57).to_string(),
                                                                                    format!("{:?}", &v2667),
                                                                                    (&v63).to_string(),
                                                                                    (&v66).to_string()]);
                                                                        let v2681 =
                                                                            core::ops::Deref::deref(&v2680);
                                                                        let v2683:
                                                                                std::string::String =
                                                                            format!("{:?}", ***v2681).clone();
                                                                        let v2686:
                                                                                Array<std::string::String> =
                                                                            array(&[(&v1694).to_string()]);
                                                                        let v2687 =
                                                                            core::ops::Deref::deref(&v2686);
                                                                        let v2690:
                                                                                std::string::String =
                                                                            format!("{:?}", ***v2687).clone();
                                                                        let v2691:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2690);
                                                                        let v2693:
                                                                                &str =
                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                        let v2694:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2693);
                                                                        let v2695:
                                                                                &regex::Regex =
                                                                            &v2694.build().unwrap();
                                                                        let v2696:
                                                                                string =
                                                                            Supervisor::method2(v2691);
                                                                        let v2697:
                                                                                &str =
                                                                            &v2696.as_str();
                                                                        let v2698:
                                                                                string =
                                                                            Supervisor::method3();
                                                                        let v2699:
                                                                                &str =
                                                                            &v2698.as_str();
                                                                        let v2700:
                                                                                std::string::String =
                                                                            v2695.replace_all(&v2697, v2699).to_string();
                                                                        let v2701:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2700);
                                                                        let v2703:
                                                                                &str =
                                                                            r#"\["(.*?)"\]"#;
                                                                        let v2704:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2703);
                                                                        let v2705:
                                                                                &regex::Regex =
                                                                            &v2704.build().unwrap();
                                                                        let v2706:
                                                                                string =
                                                                            Supervisor::method2(v2701);
                                                                        let v2707:
                                                                                &str =
                                                                            &v2706.as_str();
                                                                        let v2708:
                                                                                string =
                                                                            Supervisor::method4();
                                                                        let v2709:
                                                                                &str =
                                                                            &v2708.as_str();
                                                                        let v2710:
                                                                                std::string::String =
                                                                            v2705.replace_all(&v2707, v2709).to_string();
                                                                        let v2711:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2710);
                                                                        let v2713:
                                                                                &str =
                                                                            r#", "#;
                                                                        let v2714:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2713);
                                                                        let v2715:
                                                                                &regex::Regex =
                                                                            &v2714.build().unwrap();
                                                                        let v2716:
                                                                                string =
                                                                            Supervisor::method2(v2711);
                                                                        let v2717:
                                                                                &str =
                                                                            &v2716.as_str();
                                                                        let v2718:
                                                                                string =
                                                                            Supervisor::method5();
                                                                        let v2719:
                                                                                &str =
                                                                            &v2718.as_str();
                                                                        let v2720:
                                                                                std::string::String =
                                                                            v2715.replace_all(&v2717, v2719).to_string();
                                                                        let v2721:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2720);
                                                                        let v2723:
                                                                                std::string::String =
                                                                            (&v2721).to_string().clone();
                                                                        let v2724:
                                                                                colored::ColoredString =
                                                                            colored::Colorize::color(&*v2723, v122.clone().to_string());
                                                                        let v2725:
                                                                                std::string::String =
                                                                            format!("{}", &v2724);
                                                                        let v2727:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&&v2660);
                                                                        let v2729:
                                                                                &str =
                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                        let v2730:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2729);
                                                                        let v2731:
                                                                                &regex::Regex =
                                                                            &v2730.build().unwrap();
                                                                        let v2732:
                                                                                string =
                                                                            Supervisor::method2(v2727);
                                                                        let v2733:
                                                                                &str =
                                                                            &v2732.as_str();
                                                                        let v2734:
                                                                                string =
                                                                            Supervisor::method3();
                                                                        let v2735:
                                                                                &str =
                                                                            &v2734.as_str();
                                                                        let v2736:
                                                                                std::string::String =
                                                                            v2731.replace_all(&v2733, v2735).to_string();
                                                                        let v2737:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2736);
                                                                        let v2739:
                                                                                &str =
                                                                            r#"\["(.*?)"\]"#;
                                                                        let v2740:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2739);
                                                                        let v2741:
                                                                                &regex::Regex =
                                                                            &v2740.build().unwrap();
                                                                        let v2742:
                                                                                string =
                                                                            Supervisor::method2(v2737);
                                                                        let v2743:
                                                                                &str =
                                                                            &v2742.as_str();
                                                                        let v2744:
                                                                                string =
                                                                            Supervisor::method4();
                                                                        let v2745:
                                                                                &str =
                                                                            &v2744.as_str();
                                                                        let v2746:
                                                                                std::string::String =
                                                                            v2741.replace_all(&v2743, v2745).to_string();
                                                                        let v2747:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2746);
                                                                        let v2749:
                                                                                &str =
                                                                            r#", "#;
                                                                        let v2750:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2749);
                                                                        let v2751:
                                                                                &regex::Regex =
                                                                            &v2750.build().unwrap();
                                                                        let v2752:
                                                                                string =
                                                                            Supervisor::method2(v2747);
                                                                        let v2753:
                                                                                &str =
                                                                            &v2752.as_str();
                                                                        let v2754:
                                                                                string =
                                                                            Supervisor::method5();
                                                                        let v2755:
                                                                                &str =
                                                                            &v2754.as_str();
                                                                        let v2756:
                                                                                std::string::String =
                                                                            v2751.replace_all(&v2753, v2755).to_string();
                                                                        let v2757:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2756);
                                                                        let v2759:
                                                                                std::string::String =
                                                                            (&v2757).to_string().clone();
                                                                        let v2760:
                                                                                string =
                                                                            Supervisor::method9();
                                                                        let v2761:
                                                                                &str =
                                                                            &v2760.as_str();
                                                                        let v2764:
                                                                                &str =
                                                                            &v2761[0i32
                                                                                       as
                                                                                       usize..2i32
                                                                                                  as
                                                                                                  usize];
                                                                        let v2765:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2764);
                                                                        let v2766:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2765, 16).unwrap();
                                                                        let v2767:
                                                                                string =
                                                                            Supervisor::method9();
                                                                        let v2768:
                                                                                &str =
                                                                            &v2767.as_str();
                                                                        let v2771:
                                                                                &str =
                                                                            &v2768[2i32
                                                                                       as
                                                                                       usize..4i32
                                                                                                  as
                                                                                                  usize];
                                                                        let v2772:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2771);
                                                                        let v2773:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2772, 16).unwrap();
                                                                        let v2774:
                                                                                string =
                                                                            Supervisor::method9();
                                                                        let v2775:
                                                                                &str =
                                                                            &v2774.as_str();
                                                                        let v2778:
                                                                                &str =
                                                                            &v2775[4i32
                                                                                       as
                                                                                       usize..6i32
                                                                                                  as
                                                                                                  usize];
                                                                        let v2779:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2778);
                                                                        let v2780:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2779, 16).unwrap();
                                                                        let v2781:
                                                                                colored::ColoredString =
                                                                            colored::Colorize::truecolor(&*v2759.to_string(), v2766, v2773, v2780);
                                                                        let v2782:
                                                                                std::string::String =
                                                                            format!("{}", &v2781);
                                                                        let v2784:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&&v2683);
                                                                        let v2786:
                                                                                &str =
                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                        let v2787:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2786);
                                                                        let v2788:
                                                                                &regex::Regex =
                                                                            &v2787.build().unwrap();
                                                                        let v2789:
                                                                                string =
                                                                            Supervisor::method2(v2784);
                                                                        let v2790:
                                                                                &str =
                                                                            &v2789.as_str();
                                                                        let v2791:
                                                                                string =
                                                                            Supervisor::method3();
                                                                        let v2792:
                                                                                &str =
                                                                            &v2791.as_str();
                                                                        let v2793:
                                                                                std::string::String =
                                                                            v2788.replace_all(&v2790, v2792).to_string();
                                                                        let v2794:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2793);
                                                                        let v2796:
                                                                                &str =
                                                                            r#"\["(.*?)"\]"#;
                                                                        let v2797:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2796);
                                                                        let v2798:
                                                                                &regex::Regex =
                                                                            &v2797.build().unwrap();
                                                                        let v2799:
                                                                                string =
                                                                            Supervisor::method2(v2794);
                                                                        let v2800:
                                                                                &str =
                                                                            &v2799.as_str();
                                                                        let v2801:
                                                                                string =
                                                                            Supervisor::method4();
                                                                        let v2802:
                                                                                &str =
                                                                            &v2801.as_str();
                                                                        let v2803:
                                                                                std::string::String =
                                                                            v2798.replace_all(&v2800, v2802).to_string();
                                                                        let v2804:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2803);
                                                                        let v2806:
                                                                                &str =
                                                                            r#", "#;
                                                                        let v2807:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2806);
                                                                        let v2808:
                                                                                &regex::Regex =
                                                                            &v2807.build().unwrap();
                                                                        let v2809:
                                                                                string =
                                                                            Supervisor::method2(v2804);
                                                                        let v2810:
                                                                                &str =
                                                                            &v2809.as_str();
                                                                        let v2811:
                                                                                string =
                                                                            Supervisor::method5();
                                                                        let v2812:
                                                                                &str =
                                                                            &v2811.as_str();
                                                                        let v2813:
                                                                                std::string::String =
                                                                            v2808.replace_all(&v2810, v2812).to_string();
                                                                        let v2814:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2813);
                                                                        let v2816:
                                                                                std::string::String =
                                                                            (&v2814).to_string().clone();
                                                                        let v2817:
                                                                                string =
                                                                            Supervisor::method7();
                                                                        let v2818:
                                                                                &str =
                                                                            &v2817.as_str();
                                                                        let v2821:
                                                                                &str =
                                                                            &v2818[0i32
                                                                                       as
                                                                                       usize..2i32
                                                                                                  as
                                                                                                  usize];
                                                                        let v2822:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2821);
                                                                        let v2823:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2822, 16).unwrap();
                                                                        let v2824:
                                                                                string =
                                                                            Supervisor::method7();
                                                                        let v2825:
                                                                                &str =
                                                                            &v2824.as_str();
                                                                        let v2828:
                                                                                &str =
                                                                            &v2825[2i32
                                                                                       as
                                                                                       usize..4i32
                                                                                                  as
                                                                                                  usize];
                                                                        let v2829:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2828);
                                                                        let v2830:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2829, 16).unwrap();
                                                                        let v2831:
                                                                                string =
                                                                            Supervisor::method7();
                                                                        let v2832:
                                                                                &str =
                                                                            &v2831.as_str();
                                                                        let v2835:
                                                                                &str =
                                                                            &v2832[4i32
                                                                                       as
                                                                                       usize..6i32
                                                                                                  as
                                                                                                  usize];
                                                                        let v2836:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2835);
                                                                        let v2837:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2836, 16).unwrap();
                                                                        let v2838:
                                                                                colored::ColoredString =
                                                                            colored::Colorize::truecolor(&*v2816.to_string(), v2823, v2830, v2837);
                                                                        let v2839:
                                                                                std::string::String =
                                                                            format!("{}", &v2838);
                                                                        println!("{0}",
                                                                                 stringFrom(format!("{0} {1} {2}", &v2725, &v2782, &v2839)));
                                                                        {
                                                                            let v2841 =
                                                                                zmq::Context::new();
                                                                            let v2842 =
                                                                                v2841.socket(zmq::REQ).unwrap();
                                                                            let v2843:
                                                                                    string =
                                                                                stringFrom(format!("tcp://{0}:{1}",
                                                                                                   &v1653,
                                                                                                   &13805i32));
                                                                            v2842.connect(&v2843.clone()).unwrap();
                                                                            v2842.send(v2447.as_str(), 0).unwrap();
                                                                            {
                                                                                let v2845:
                                                                                        std::string::String =
                                                                                    v2842.recv_string(0).unwrap().unwrap();
                                                                                v2842.disconnect(&v2843).unwrap();
                                                                                {
                                                                                    let v2847:
                                                                                            std::string::String =
                                                                                        (&v1862).to_string().clone();
                                                                                    let v2848:
                                                                                            i32 =
                                                                                        (&v2845).len().try_into().unwrap();
                                                                                    let v2851:
                                                                                            Array<std::string::String> =
                                                                                        array(&[v2847,
                                                                                                format!("{:?}", &v2848)]);
                                                                                    let v2852 =
                                                                                        core::ops::Deref::deref(&v2851);
                                                                                    let v2854:
                                                                                            std::string::String =
                                                                                        format!("{:?}", ***v2852).clone();
                                                                                    let v2855:
                                                                                            chrono::DateTime<chrono::Utc> =
                                                                                        chrono::Utc::now();
                                                                                    let v2860:
                                                                                            string =
                                                                                        Supervisor::method1(6i32,
                                                                                                            toString(&((&v2855).timestamp()
                                                                                                                           -
                                                                                                                           v2643)));
                                                                                    let v2861:
                                                                                            u8 =
                                                                                        rand::random::<u8>();
                                                                                    let v2874:
                                                                                            Array<std::string::String> =
                                                                                        array(&[(&v52).to_string(),
                                                                                                (&v2860).to_string(),
                                                                                                (&v57).to_string(),
                                                                                                format!("{:?}", &v2861),
                                                                                                (&v63).to_string(),
                                                                                                (&v66).to_string()]);
                                                                                    let v2875 =
                                                                                        core::ops::Deref::deref(&v2874);
                                                                                    let v2877:
                                                                                            std::string::String =
                                                                                        format!("{:?}", ***v2875).clone();
                                                                                    let v2880:
                                                                                            Array<std::string::String> =
                                                                                        array(&[(&v1694).to_string()]);
                                                                                    let v2881 =
                                                                                        core::ops::Deref::deref(&v2880);
                                                                                    let v2884:
                                                                                            std::string::String =
                                                                                        format!("{:?}", ***v2881).clone();
                                                                                    let v2885:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2884);
                                                                                    let v2887:
                                                                                            &str =
                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                    let v2888:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2887);
                                                                                    let v2889:
                                                                                            &regex::Regex =
                                                                                        &v2888.build().unwrap();
                                                                                    let v2890:
                                                                                            string =
                                                                                        Supervisor::method2(v2885);
                                                                                    let v2891:
                                                                                            &str =
                                                                                        &v2890.as_str();
                                                                                    let v2892:
                                                                                            string =
                                                                                        Supervisor::method3();
                                                                                    let v2893:
                                                                                            &str =
                                                                                        &v2892.as_str();
                                                                                    let v2894:
                                                                                            std::string::String =
                                                                                        v2889.replace_all(&v2891, v2893).to_string();
                                                                                    let v2895:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2894);
                                                                                    let v2897:
                                                                                            &str =
                                                                                        r#"\["(.*?)"\]"#;
                                                                                    let v2898:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2897);
                                                                                    let v2899:
                                                                                            &regex::Regex =
                                                                                        &v2898.build().unwrap();
                                                                                    let v2900:
                                                                                            string =
                                                                                        Supervisor::method2(v2895);
                                                                                    let v2901:
                                                                                            &str =
                                                                                        &v2900.as_str();
                                                                                    let v2902:
                                                                                            string =
                                                                                        Supervisor::method4();
                                                                                    let v2903:
                                                                                            &str =
                                                                                        &v2902.as_str();
                                                                                    let v2904:
                                                                                            std::string::String =
                                                                                        v2899.replace_all(&v2901, v2903).to_string();
                                                                                    let v2905:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2904);
                                                                                    let v2907:
                                                                                            &str =
                                                                                        r#", "#;
                                                                                    let v2908:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2907);
                                                                                    let v2909:
                                                                                            &regex::Regex =
                                                                                        &v2908.build().unwrap();
                                                                                    let v2910:
                                                                                            string =
                                                                                        Supervisor::method2(v2905);
                                                                                    let v2911:
                                                                                            &str =
                                                                                        &v2910.as_str();
                                                                                    let v2912:
                                                                                            string =
                                                                                        Supervisor::method5();
                                                                                    let v2913:
                                                                                            &str =
                                                                                        &v2912.as_str();
                                                                                    let v2914:
                                                                                            std::string::String =
                                                                                        v2909.replace_all(&v2911, v2913).to_string();
                                                                                    let v2915:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2914);
                                                                                    let v2917:
                                                                                            std::string::String =
                                                                                        (&v2915).to_string().clone();
                                                                                    let v2918:
                                                                                            colored::ColoredString =
                                                                                        colored::Colorize::color(&*v2917, v122.clone().to_string());
                                                                                    let v2919:
                                                                                            std::string::String =
                                                                                        format!("{}", &v2918);
                                                                                    let v2921:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&&v2854);
                                                                                    let v2923:
                                                                                            &str =
                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                    let v2924:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2923);
                                                                                    let v2925:
                                                                                            &regex::Regex =
                                                                                        &v2924.build().unwrap();
                                                                                    let v2926:
                                                                                            string =
                                                                                        Supervisor::method2(v2921);
                                                                                    let v2927:
                                                                                            &str =
                                                                                        &v2926.as_str();
                                                                                    let v2928:
                                                                                            string =
                                                                                        Supervisor::method3();
                                                                                    let v2929:
                                                                                            &str =
                                                                                        &v2928.as_str();
                                                                                    let v2930:
                                                                                            std::string::String =
                                                                                        v2925.replace_all(&v2927, v2929).to_string();
                                                                                    let v2931:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2930);
                                                                                    let v2933:
                                                                                            &str =
                                                                                        r#"\["(.*?)"\]"#;
                                                                                    let v2934:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2933);
                                                                                    let v2935:
                                                                                            &regex::Regex =
                                                                                        &v2934.build().unwrap();
                                                                                    let v2936:
                                                                                            string =
                                                                                        Supervisor::method2(v2931);
                                                                                    let v2937:
                                                                                            &str =
                                                                                        &v2936.as_str();
                                                                                    let v2938:
                                                                                            string =
                                                                                        Supervisor::method4();
                                                                                    let v2939:
                                                                                            &str =
                                                                                        &v2938.as_str();
                                                                                    let v2940:
                                                                                            std::string::String =
                                                                                        v2935.replace_all(&v2937, v2939).to_string();
                                                                                    let v2941:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2940);
                                                                                    let v2943:
                                                                                            &str =
                                                                                        r#", "#;
                                                                                    let v2944:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2943);
                                                                                    let v2945:
                                                                                            &regex::Regex =
                                                                                        &v2944.build().unwrap();
                                                                                    let v2946:
                                                                                            string =
                                                                                        Supervisor::method2(v2941);
                                                                                    let v2947:
                                                                                            &str =
                                                                                        &v2946.as_str();
                                                                                    let v2948:
                                                                                            string =
                                                                                        Supervisor::method5();
                                                                                    let v2949:
                                                                                            &str =
                                                                                        &v2948.as_str();
                                                                                    let v2950:
                                                                                            std::string::String =
                                                                                        v2945.replace_all(&v2947, v2949).to_string();
                                                                                    let v2951:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2950);
                                                                                    let v2953:
                                                                                            std::string::String =
                                                                                        (&v2951).to_string().clone();
                                                                                    let v2954:
                                                                                            string =
                                                                                        Supervisor::method9();
                                                                                    let v2955:
                                                                                            &str =
                                                                                        &v2954.as_str();
                                                                                    let v2958:
                                                                                            &str =
                                                                                        &v2955[0i32
                                                                                                   as
                                                                                                   usize..2i32
                                                                                                              as
                                                                                                              usize];
                                                                                    let v2959:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2958);
                                                                                    let v2960:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2959, 16).unwrap();
                                                                                    let v2961:
                                                                                            string =
                                                                                        Supervisor::method9();
                                                                                    let v2962:
                                                                                            &str =
                                                                                        &v2961.as_str();
                                                                                    let v2965:
                                                                                            &str =
                                                                                        &v2962[2i32
                                                                                                   as
                                                                                                   usize..4i32
                                                                                                              as
                                                                                                              usize];
                                                                                    let v2966:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2965);
                                                                                    let v2967:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2966, 16).unwrap();
                                                                                    let v2968:
                                                                                            string =
                                                                                        Supervisor::method9();
                                                                                    let v2969:
                                                                                            &str =
                                                                                        &v2968.as_str();
                                                                                    let v2972:
                                                                                            &str =
                                                                                        &v2969[4i32
                                                                                                   as
                                                                                                   usize..6i32
                                                                                                              as
                                                                                                              usize];
                                                                                    let v2973:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2972);
                                                                                    let v2974:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2973, 16).unwrap();
                                                                                    let v2975:
                                                                                            colored::ColoredString =
                                                                                        colored::Colorize::truecolor(&*v2953.to_string(), v2960, v2967, v2974);
                                                                                    let v2976:
                                                                                            std::string::String =
                                                                                        format!("{}", &v2975);
                                                                                    let v2978:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&&v2877);
                                                                                    let v2980:
                                                                                            &str =
                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                    let v2981:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2980);
                                                                                    let v2982:
                                                                                            &regex::Regex =
                                                                                        &v2981.build().unwrap();
                                                                                    let v2983:
                                                                                            string =
                                                                                        Supervisor::method2(v2978);
                                                                                    let v2984:
                                                                                            &str =
                                                                                        &v2983.as_str();
                                                                                    let v2985:
                                                                                            string =
                                                                                        Supervisor::method3();
                                                                                    let v2986:
                                                                                            &str =
                                                                                        &v2985.as_str();
                                                                                    let v2987:
                                                                                            std::string::String =
                                                                                        v2982.replace_all(&v2984, v2986).to_string();
                                                                                    let v2988:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2987);
                                                                                    let v2990:
                                                                                            &str =
                                                                                        r#"\["(.*?)"\]"#;
                                                                                    let v2991:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2990);
                                                                                    let v2992:
                                                                                            &regex::Regex =
                                                                                        &v2991.build().unwrap();
                                                                                    let v2993:
                                                                                            string =
                                                                                        Supervisor::method2(v2988);
                                                                                    let v2994:
                                                                                            &str =
                                                                                        &v2993.as_str();
                                                                                    let v2995:
                                                                                            string =
                                                                                        Supervisor::method4();
                                                                                    let v2996:
                                                                                            &str =
                                                                                        &v2995.as_str();
                                                                                    let v2997:
                                                                                            std::string::String =
                                                                                        v2992.replace_all(&v2994, v2996).to_string();
                                                                                    let v2998:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2997);
                                                                                    let v3000:
                                                                                            &str =
                                                                                        r#", "#;
                                                                                    let v3001:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v3000);
                                                                                    let v3002:
                                                                                            &regex::Regex =
                                                                                        &v3001.build().unwrap();
                                                                                    let v3003:
                                                                                            string =
                                                                                        Supervisor::method2(v2998);
                                                                                    let v3004:
                                                                                            &str =
                                                                                        &v3003.as_str();
                                                                                    let v3005:
                                                                                            string =
                                                                                        Supervisor::method5();
                                                                                    let v3006:
                                                                                            &str =
                                                                                        &v3005.as_str();
                                                                                    let v3007:
                                                                                            std::string::String =
                                                                                        v3002.replace_all(&v3004, v3006).to_string();
                                                                                    let v3008:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v3007);
                                                                                    let v3010:
                                                                                            std::string::String =
                                                                                        (&v3008).to_string().clone();
                                                                                    let v3011:
                                                                                            string =
                                                                                        Supervisor::method7();
                                                                                    let v3012:
                                                                                            &str =
                                                                                        &v3011.as_str();
                                                                                    let v3015:
                                                                                            &str =
                                                                                        &v3012[0i32
                                                                                                   as
                                                                                                   usize..2i32
                                                                                                              as
                                                                                                              usize];
                                                                                    let v3016:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v3015);
                                                                                    let v3017:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v3016, 16).unwrap();
                                                                                    let v3018:
                                                                                            string =
                                                                                        Supervisor::method7();
                                                                                    let v3019:
                                                                                            &str =
                                                                                        &v3018.as_str();
                                                                                    let v3022:
                                                                                            &str =
                                                                                        &v3019[2i32
                                                                                                   as
                                                                                                   usize..4i32
                                                                                                              as
                                                                                                              usize];
                                                                                    let v3023:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v3022);
                                                                                    let v3024:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v3023, 16).unwrap();
                                                                                    let v3025:
                                                                                            string =
                                                                                        Supervisor::method7();
                                                                                    let v3026:
                                                                                            &str =
                                                                                        &v3025.as_str();
                                                                                    let v3029:
                                                                                            &str =
                                                                                        &v3026[4i32
                                                                                                   as
                                                                                                   usize..6i32
                                                                                                              as
                                                                                                              usize];
                                                                                    let v3030:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v3029);
                                                                                    let v3031:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v3030, 16).unwrap();
                                                                                    let v3032:
                                                                                            colored::ColoredString =
                                                                                        colored::Colorize::truecolor(&*v3010.to_string(), v3017, v3024, v3031);
                                                                                    let v3033:
                                                                                            std::string::String =
                                                                                        format!("{}", &v3032);
                                                                                    println!("{0}",
                                                                                             stringFrom(format!("{0} {1} {2}", &v2919, &v2976, &v3033)));
                                                                                    {
                                                                                        let v3037:
                                                                                                std::string::String =
                                                                                            (&string("> spi_build_file; ok")).to_string().clone();
                                                                                        let v3038:
                                                                                                chrono::DateTime<chrono::Utc> =
                                                                                            chrono::Utc::now();
                                                                                        let v3043:
                                                                                                string =
                                                                                            Supervisor::method1(6i32,
                                                                                                                toString(&((&v3038).timestamp()
                                                                                                                               -
                                                                                                                               v9)));
                                                                                        let v3044:
                                                                                                u8 =
                                                                                            rand::random::<u8>();
                                                                                        let v3057:
                                                                                                Array<std::string::String> =
                                                                                            array(&[(&v52).to_string(),
                                                                                                    (&v3043).to_string(),
                                                                                                    (&v57).to_string(),
                                                                                                    format!("{:?}", &v3044),
                                                                                                    (&v63).to_string(),
                                                                                                    (&v66).to_string()]);
                                                                                        let v3058 =
                                                                                            core::ops::Deref::deref(&v3057);
                                                                                        let v3060:
                                                                                                std::string::String =
                                                                                            format!("{:?}", ***v3058).clone();
                                                                                        let v3063:
                                                                                                Array<std::string::String> =
                                                                                            array(&[(&v73).to_string()]);
                                                                                        let v3064 =
                                                                                            core::ops::Deref::deref(&v3063);
                                                                                        let v3067:
                                                                                                std::string::String =
                                                                                            format!("{:?}", ***v3064).clone();
                                                                                        let v3068:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3067);
                                                                                        let v3070:
                                                                                                &str =
                                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                                        let v3071:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3070);
                                                                                        let v3072:
                                                                                                &regex::Regex =
                                                                                            &v3071.build().unwrap();
                                                                                        let v3073:
                                                                                                string =
                                                                                            Supervisor::method2(v3068);
                                                                                        let v3074:
                                                                                                &str =
                                                                                            &v3073.as_str();
                                                                                        let v3075:
                                                                                                string =
                                                                                            Supervisor::method3();
                                                                                        let v3076:
                                                                                                &str =
                                                                                            &v3075.as_str();
                                                                                        let v3077:
                                                                                                std::string::String =
                                                                                            v3072.replace_all(&v3074, v3076).to_string();
                                                                                        let v3078:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3077);
                                                                                        let v3080:
                                                                                                &str =
                                                                                            r#"\["(.*?)"\]"#;
                                                                                        let v3081:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3080);
                                                                                        let v3082:
                                                                                                &regex::Regex =
                                                                                            &v3081.build().unwrap();
                                                                                        let v3083:
                                                                                                string =
                                                                                            Supervisor::method2(v3078);
                                                                                        let v3084:
                                                                                                &str =
                                                                                            &v3083.as_str();
                                                                                        let v3085:
                                                                                                string =
                                                                                            Supervisor::method4();
                                                                                        let v3086:
                                                                                                &str =
                                                                                            &v3085.as_str();
                                                                                        let v3087:
                                                                                                std::string::String =
                                                                                            v3082.replace_all(&v3084, v3086).to_string();
                                                                                        let v3088:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3087);
                                                                                        let v3090:
                                                                                                &str =
                                                                                            r#", "#;
                                                                                        let v3091:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3090);
                                                                                        let v3092:
                                                                                                &regex::Regex =
                                                                                            &v3091.build().unwrap();
                                                                                        let v3093:
                                                                                                string =
                                                                                            Supervisor::method2(v3088);
                                                                                        let v3094:
                                                                                                &str =
                                                                                            &v3093.as_str();
                                                                                        let v3095:
                                                                                                string =
                                                                                            Supervisor::method5();
                                                                                        let v3096:
                                                                                                &str =
                                                                                            &v3095.as_str();
                                                                                        let v3097:
                                                                                                std::string::String =
                                                                                            v3092.replace_all(&v3094, v3096).to_string();
                                                                                        let v3098:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3097);
                                                                                        let v3100:
                                                                                                std::string::String =
                                                                                            (&v3098).to_string().clone();
                                                                                        let v3101:
                                                                                                colored::ColoredString =
                                                                                            colored::Colorize::color(&*v3100, v122.clone().to_string());
                                                                                        let v3102:
                                                                                                std::string::String =
                                                                                            format!("{}", &v3101);
                                                                                        let v3104:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&&v3037);
                                                                                        let v3106:
                                                                                                &str =
                                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                                        let v3107:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3106);
                                                                                        let v3108:
                                                                                                &regex::Regex =
                                                                                            &v3107.build().unwrap();
                                                                                        let v3109:
                                                                                                string =
                                                                                            Supervisor::method2(v3104);
                                                                                        let v3110:
                                                                                                &str =
                                                                                            &v3109.as_str();
                                                                                        let v3111:
                                                                                                string =
                                                                                            Supervisor::method3();
                                                                                        let v3112:
                                                                                                &str =
                                                                                            &v3111.as_str();
                                                                                        let v3113:
                                                                                                std::string::String =
                                                                                            v3108.replace_all(&v3110, v3112).to_string();
                                                                                        let v3114:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3113);
                                                                                        let v3116:
                                                                                                &str =
                                                                                            r#"\["(.*?)"\]"#;
                                                                                        let v3117:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3116);
                                                                                        let v3118:
                                                                                                &regex::Regex =
                                                                                            &v3117.build().unwrap();
                                                                                        let v3119:
                                                                                                string =
                                                                                            Supervisor::method2(v3114);
                                                                                        let v3120:
                                                                                                &str =
                                                                                            &v3119.as_str();
                                                                                        let v3121:
                                                                                                string =
                                                                                            Supervisor::method4();
                                                                                        let v3122:
                                                                                                &str =
                                                                                            &v3121.as_str();
                                                                                        let v3123:
                                                                                                std::string::String =
                                                                                            v3118.replace_all(&v3120, v3122).to_string();
                                                                                        let v3124:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3123);
                                                                                        let v3126:
                                                                                                &str =
                                                                                            r#", "#;
                                                                                        let v3127:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3126);
                                                                                        let v3128:
                                                                                                &regex::Regex =
                                                                                            &v3127.build().unwrap();
                                                                                        let v3129:
                                                                                                string =
                                                                                            Supervisor::method2(v3124);
                                                                                        let v3130:
                                                                                                &str =
                                                                                            &v3129.as_str();
                                                                                        let v3131:
                                                                                                string =
                                                                                            Supervisor::method5();
                                                                                        let v3132:
                                                                                                &str =
                                                                                            &v3131.as_str();
                                                                                        let v3133:
                                                                                                std::string::String =
                                                                                            v3128.replace_all(&v3130, v3132).to_string();
                                                                                        let v3134:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3133);
                                                                                        let v3136:
                                                                                                std::string::String =
                                                                                            (&v3134).to_string().clone();
                                                                                        let v3137:
                                                                                                string =
                                                                                            Supervisor::method6();
                                                                                        let v3138:
                                                                                                &str =
                                                                                            &v3137.as_str();
                                                                                        let v3141:
                                                                                                &str =
                                                                                            &v3138[0i32
                                                                                                       as
                                                                                                       usize..2i32
                                                                                                                  as
                                                                                                                  usize];
                                                                                        let v3142:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3141);
                                                                                        let v3143:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v3142, 16).unwrap();
                                                                                        let v3144:
                                                                                                string =
                                                                                            Supervisor::method6();
                                                                                        let v3145:
                                                                                                &str =
                                                                                            &v3144.as_str();
                                                                                        let v3148:
                                                                                                &str =
                                                                                            &v3145[2i32
                                                                                                       as
                                                                                                       usize..4i32
                                                                                                                  as
                                                                                                                  usize];
                                                                                        let v3149:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3148);
                                                                                        let v3150:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v3149, 16).unwrap();
                                                                                        let v3151:
                                                                                                string =
                                                                                            Supervisor::method6();
                                                                                        let v3152:
                                                                                                &str =
                                                                                            &v3151.as_str();
                                                                                        let v3155:
                                                                                                &str =
                                                                                            &v3152[4i32
                                                                                                       as
                                                                                                       usize..6i32
                                                                                                                  as
                                                                                                                  usize];
                                                                                        let v3156:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3155);
                                                                                        let v3157:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v3156, 16).unwrap();
                                                                                        let v3158:
                                                                                                colored::ColoredString =
                                                                                            colored::Colorize::truecolor(&*v3136.to_string(), v3143, v3150, v3157);
                                                                                        let v3159:
                                                                                                std::string::String =
                                                                                            format!("{}", &v3158);
                                                                                        let v3161:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&&v3060);
                                                                                        let v3163:
                                                                                                &str =
                                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                                        let v3164:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3163);
                                                                                        let v3165:
                                                                                                &regex::Regex =
                                                                                            &v3164.build().unwrap();
                                                                                        let v3166:
                                                                                                string =
                                                                                            Supervisor::method2(v3161);
                                                                                        let v3167:
                                                                                                &str =
                                                                                            &v3166.as_str();
                                                                                        let v3168:
                                                                                                string =
                                                                                            Supervisor::method3();
                                                                                        let v3169:
                                                                                                &str =
                                                                                            &v3168.as_str();
                                                                                        let v3170:
                                                                                                std::string::String =
                                                                                            v3165.replace_all(&v3167, v3169).to_string();
                                                                                        let v3171:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3170);
                                                                                        let v3173:
                                                                                                &str =
                                                                                            r#"\["(.*?)"\]"#;
                                                                                        let v3174:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3173);
                                                                                        let v3175:
                                                                                                &regex::Regex =
                                                                                            &v3174.build().unwrap();
                                                                                        let v3176:
                                                                                                string =
                                                                                            Supervisor::method2(v3171);
                                                                                        let v3177:
                                                                                                &str =
                                                                                            &v3176.as_str();
                                                                                        let v3178:
                                                                                                string =
                                                                                            Supervisor::method4();
                                                                                        let v3179:
                                                                                                &str =
                                                                                            &v3178.as_str();
                                                                                        let v3180:
                                                                                                std::string::String =
                                                                                            v3175.replace_all(&v3177, v3179).to_string();
                                                                                        let v3181:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3180);
                                                                                        let v3183:
                                                                                                &str =
                                                                                            r#", "#;
                                                                                        let v3184:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v3183);
                                                                                        let v3185:
                                                                                                &regex::Regex =
                                                                                            &v3184.build().unwrap();
                                                                                        let v3186:
                                                                                                string =
                                                                                            Supervisor::method2(v3181);
                                                                                        let v3187:
                                                                                                &str =
                                                                                            &v3186.as_str();
                                                                                        let v3188:
                                                                                                string =
                                                                                            Supervisor::method5();
                                                                                        let v3189:
                                                                                                &str =
                                                                                            &v3188.as_str();
                                                                                        let v3190:
                                                                                                std::string::String =
                                                                                            v3185.replace_all(&v3187, v3189).to_string();
                                                                                        let v3191:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3190);
                                                                                        let v3193:
                                                                                                std::string::String =
                                                                                            (&v3191).to_string().clone();
                                                                                        let v3194:
                                                                                                string =
                                                                                            Supervisor::method7();
                                                                                        let v3195:
                                                                                                &str =
                                                                                            &v3194.as_str();
                                                                                        let v3198:
                                                                                                &str =
                                                                                            &v3195[0i32
                                                                                                       as
                                                                                                       usize..2i32
                                                                                                                  as
                                                                                                                  usize];
                                                                                        let v3199:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3198);
                                                                                        let v3200:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v3199, 16).unwrap();
                                                                                        let v3201:
                                                                                                string =
                                                                                            Supervisor::method7();
                                                                                        let v3202:
                                                                                                &str =
                                                                                            &v3201.as_str();
                                                                                        let v3205:
                                                                                                &str =
                                                                                            &v3202[2i32
                                                                                                       as
                                                                                                       usize..4i32
                                                                                                                  as
                                                                                                                  usize];
                                                                                        let v3206:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3205);
                                                                                        let v3207:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v3206, 16).unwrap();
                                                                                        let v3208:
                                                                                                string =
                                                                                            Supervisor::method7();
                                                                                        let v3209:
                                                                                                &str =
                                                                                            &v3208.as_str();
                                                                                        let v3212:
                                                                                                &str =
                                                                                            &v3209[4i32
                                                                                                       as
                                                                                                       usize..6i32
                                                                                                                  as
                                                                                                                  usize];
                                                                                        let v3213:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v3212);
                                                                                        let v3214:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v3213, 16).unwrap();
                                                                                        let v3215:
                                                                                                colored::ColoredString =
                                                                                            colored::Colorize::truecolor(&*v3193.to_string(), v3200, v3207, v3214);
                                                                                        let v3216:
                                                                                                std::string::String =
                                                                                            format!("{}", &v3215);
                                                                                        println!("{0}",
                                                                                                 stringFrom(format!("{0} {1} {2}", &v3102, &v3159, &v3216)));
                                                                                        {
                                                                                            let patternInput_5:
                                                                                                    (string,
                                                                                                     string,
                                                                                                     string,
                                                                                                     bool) =
                                                                                                Supervisor::method0();
                                                                                            let v3222:
                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                chrono::Utc::now();
                                                                                            let v3223:
                                                                                                    i64 =
                                                                                                (&v3222).timestamp();
                                                                                            let v3225:
                                                                                                    std::time::SystemTime =
                                                                                                std::fs::metadata(&v854).unwrap().modified().unwrap();
                                                                                            let v3227:
                                                                                                    std::string::String =
                                                                                                (&v855).to_string().clone();
                                                                                            let v3228:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&format!("{}", &v854.display()));
                                                                                            let v3236:
                                                                                                    Array<std::string::String> =
                                                                                                array(&[v3227,
                                                                                                        (&v3228).to_string(),
                                                                                                        (&string("start")).to_string(),
                                                                                                        format!("{:?}", &v3225)]);
                                                                                            let v3237 =
                                                                                                core::ops::Deref::deref(&v3236);
                                                                                            let v3239:
                                                                                                    std::string::String =
                                                                                                format!("{:?}", ***v3237).clone();
                                                                                            let v3240:
                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                chrono::Utc::now();
                                                                                            let v3245:
                                                                                                    string =
                                                                                                Supervisor::method1(6i32,
                                                                                                                    toString(&((&v3240).timestamp()
                                                                                                                                   -
                                                                                                                                   v3223)));
                                                                                            let v3246:
                                                                                                    u8 =
                                                                                                rand::random::<u8>();
                                                                                            let v3259:
                                                                                                    Array<std::string::String> =
                                                                                                array(&[(&v52).to_string(),
                                                                                                        (&v3245).to_string(),
                                                                                                        (&v57).to_string(),
                                                                                                        format!("{:?}", &v3246),
                                                                                                        (&v63).to_string(),
                                                                                                        (&v66).to_string()]);
                                                                                            let v3260 =
                                                                                                core::ops::Deref::deref(&v3259);
                                                                                            let v3262:
                                                                                                    std::string::String =
                                                                                                format!("{:?}", ***v3260).clone();
                                                                                            let v3263:
                                                                                                    string =
                                                                                                string("> wait_file_change ()");
                                                                                            let v3266:
                                                                                                    Array<std::string::String> =
                                                                                                array(&[(&v3263).to_string()]);
                                                                                            let v3267 =
                                                                                                core::ops::Deref::deref(&v3266);
                                                                                            let v3270:
                                                                                                    std::string::String =
                                                                                                format!("{:?}", ***v3267).clone();
                                                                                            let v3271:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3270);
                                                                                            let v3273:
                                                                                                    &str =
                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                            let v3274:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3273);
                                                                                            let v3275:
                                                                                                    &regex::Regex =
                                                                                                &v3274.build().unwrap();
                                                                                            let v3276:
                                                                                                    string =
                                                                                                Supervisor::method2(v3271);
                                                                                            let v3277:
                                                                                                    &str =
                                                                                                &v3276.as_str();
                                                                                            let v3278:
                                                                                                    string =
                                                                                                Supervisor::method3();
                                                                                            let v3279:
                                                                                                    &str =
                                                                                                &v3278.as_str();
                                                                                            let v3280:
                                                                                                    std::string::String =
                                                                                                v3275.replace_all(&v3277, v3279).to_string();
                                                                                            let v3281:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3280);
                                                                                            let v3283:
                                                                                                    &str =
                                                                                                r#"\["(.*?)"\]"#;
                                                                                            let v3284:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3283);
                                                                                            let v3285:
                                                                                                    &regex::Regex =
                                                                                                &v3284.build().unwrap();
                                                                                            let v3286:
                                                                                                    string =
                                                                                                Supervisor::method2(v3281);
                                                                                            let v3287:
                                                                                                    &str =
                                                                                                &v3286.as_str();
                                                                                            let v3288:
                                                                                                    string =
                                                                                                Supervisor::method4();
                                                                                            let v3289:
                                                                                                    &str =
                                                                                                &v3288.as_str();
                                                                                            let v3290:
                                                                                                    std::string::String =
                                                                                                v3285.replace_all(&v3287, v3289).to_string();
                                                                                            let v3291:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3290);
                                                                                            let v3293:
                                                                                                    &str =
                                                                                                r#", "#;
                                                                                            let v3294:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3293);
                                                                                            let v3295:
                                                                                                    &regex::Regex =
                                                                                                &v3294.build().unwrap();
                                                                                            let v3296:
                                                                                                    string =
                                                                                                Supervisor::method2(v3291);
                                                                                            let v3297:
                                                                                                    &str =
                                                                                                &v3296.as_str();
                                                                                            let v3298:
                                                                                                    string =
                                                                                                Supervisor::method5();
                                                                                            let v3299:
                                                                                                    &str =
                                                                                                &v3298.as_str();
                                                                                            let v3300:
                                                                                                    std::string::String =
                                                                                                v3295.replace_all(&v3297, v3299).to_string();
                                                                                            let v3301:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3300);
                                                                                            let v3303:
                                                                                                    std::string::String =
                                                                                                (&v3301).to_string().clone();
                                                                                            let v3304:
                                                                                                    colored::ColoredString =
                                                                                                colored::Colorize::color(&*v3303, v122.clone().to_string());
                                                                                            let v3305:
                                                                                                    std::string::String =
                                                                                                format!("{}", &v3304);
                                                                                            let v3307:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&&v3239);
                                                                                            let v3309:
                                                                                                    &str =
                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                            let v3310:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3309);
                                                                                            let v3311:
                                                                                                    &regex::Regex =
                                                                                                &v3310.build().unwrap();
                                                                                            let v3312:
                                                                                                    string =
                                                                                                Supervisor::method2(v3307);
                                                                                            let v3313:
                                                                                                    &str =
                                                                                                &v3312.as_str();
                                                                                            let v3314:
                                                                                                    string =
                                                                                                Supervisor::method3();
                                                                                            let v3315:
                                                                                                    &str =
                                                                                                &v3314.as_str();
                                                                                            let v3316:
                                                                                                    std::string::String =
                                                                                                v3311.replace_all(&v3313, v3315).to_string();
                                                                                            let v3317:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3316);
                                                                                            let v3319:
                                                                                                    &str =
                                                                                                r#"\["(.*?)"\]"#;
                                                                                            let v3320:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3319);
                                                                                            let v3321:
                                                                                                    &regex::Regex =
                                                                                                &v3320.build().unwrap();
                                                                                            let v3322:
                                                                                                    string =
                                                                                                Supervisor::method2(v3317);
                                                                                            let v3323:
                                                                                                    &str =
                                                                                                &v3322.as_str();
                                                                                            let v3324:
                                                                                                    string =
                                                                                                Supervisor::method4();
                                                                                            let v3325:
                                                                                                    &str =
                                                                                                &v3324.as_str();
                                                                                            let v3326:
                                                                                                    std::string::String =
                                                                                                v3321.replace_all(&v3323, v3325).to_string();
                                                                                            let v3327:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3326);
                                                                                            let v3329:
                                                                                                    &str =
                                                                                                r#", "#;
                                                                                            let v3330:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3329);
                                                                                            let v3331:
                                                                                                    &regex::Regex =
                                                                                                &v3330.build().unwrap();
                                                                                            let v3332:
                                                                                                    string =
                                                                                                Supervisor::method2(v3327);
                                                                                            let v3333:
                                                                                                    &str =
                                                                                                &v3332.as_str();
                                                                                            let v3334:
                                                                                                    string =
                                                                                                Supervisor::method5();
                                                                                            let v3335:
                                                                                                    &str =
                                                                                                &v3334.as_str();
                                                                                            let v3336:
                                                                                                    std::string::String =
                                                                                                v3331.replace_all(&v3333, v3335).to_string();
                                                                                            let v3337:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3336);
                                                                                            let v3339:
                                                                                                    std::string::String =
                                                                                                (&v3337).to_string().clone();
                                                                                            let v3340:
                                                                                                    string =
                                                                                                Supervisor::method11();
                                                                                            let v3341:
                                                                                                    &str =
                                                                                                &v3340.as_str();
                                                                                            let v3344:
                                                                                                    &str =
                                                                                                &v3341[0i32
                                                                                                           as
                                                                                                           usize..2i32
                                                                                                                      as
                                                                                                                      usize];
                                                                                            let v3345:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3344);
                                                                                            let v3346:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v3345, 16).unwrap();
                                                                                            let v3347:
                                                                                                    string =
                                                                                                Supervisor::method11();
                                                                                            let v3348:
                                                                                                    &str =
                                                                                                &v3347.as_str();
                                                                                            let v3351:
                                                                                                    &str =
                                                                                                &v3348[2i32
                                                                                                           as
                                                                                                           usize..4i32
                                                                                                                      as
                                                                                                                      usize];
                                                                                            let v3352:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3351);
                                                                                            let v3353:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v3352, 16).unwrap();
                                                                                            let v3354:
                                                                                                    string =
                                                                                                Supervisor::method11();
                                                                                            let v3355:
                                                                                                    &str =
                                                                                                &v3354.as_str();
                                                                                            let v3358:
                                                                                                    &str =
                                                                                                &v3355[4i32
                                                                                                           as
                                                                                                           usize..6i32
                                                                                                                      as
                                                                                                                      usize];
                                                                                            let v3359:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3358);
                                                                                            let v3360:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v3359, 16).unwrap();
                                                                                            let v3361:
                                                                                                    colored::ColoredString =
                                                                                                colored::Colorize::truecolor(&*v3339.to_string(), v3346, v3353, v3360);
                                                                                            let v3362:
                                                                                                    std::string::String =
                                                                                                format!("{}", &v3361);
                                                                                            let v3364:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&&v3262);
                                                                                            let v3366:
                                                                                                    &str =
                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                            let v3367:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3366);
                                                                                            let v3368:
                                                                                                    &regex::Regex =
                                                                                                &v3367.build().unwrap();
                                                                                            let v3369:
                                                                                                    string =
                                                                                                Supervisor::method2(v3364);
                                                                                            let v3370:
                                                                                                    &str =
                                                                                                &v3369.as_str();
                                                                                            let v3371:
                                                                                                    string =
                                                                                                Supervisor::method3();
                                                                                            let v3372:
                                                                                                    &str =
                                                                                                &v3371.as_str();
                                                                                            let v3373:
                                                                                                    std::string::String =
                                                                                                v3368.replace_all(&v3370, v3372).to_string();
                                                                                            let v3374:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3373);
                                                                                            let v3376:
                                                                                                    &str =
                                                                                                r#"\["(.*?)"\]"#;
                                                                                            let v3377:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3376);
                                                                                            let v3378:
                                                                                                    &regex::Regex =
                                                                                                &v3377.build().unwrap();
                                                                                            let v3379:
                                                                                                    string =
                                                                                                Supervisor::method2(v3374);
                                                                                            let v3380:
                                                                                                    &str =
                                                                                                &v3379.as_str();
                                                                                            let v3381:
                                                                                                    string =
                                                                                                Supervisor::method4();
                                                                                            let v3382:
                                                                                                    &str =
                                                                                                &v3381.as_str();
                                                                                            let v3383:
                                                                                                    std::string::String =
                                                                                                v3378.replace_all(&v3380, v3382).to_string();
                                                                                            let v3384:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3383);
                                                                                            let v3386:
                                                                                                    &str =
                                                                                                r#", "#;
                                                                                            let v3387:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v3386);
                                                                                            let v3388:
                                                                                                    &regex::Regex =
                                                                                                &v3387.build().unwrap();
                                                                                            let v3389:
                                                                                                    string =
                                                                                                Supervisor::method2(v3384);
                                                                                            let v3390:
                                                                                                    &str =
                                                                                                &v3389.as_str();
                                                                                            let v3391:
                                                                                                    string =
                                                                                                Supervisor::method5();
                                                                                            let v3392:
                                                                                                    &str =
                                                                                                &v3391.as_str();
                                                                                            let v3393:
                                                                                                    std::string::String =
                                                                                                v3388.replace_all(&v3390, v3392).to_string();
                                                                                            let v3394:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3393);
                                                                                            let v3396:
                                                                                                    std::string::String =
                                                                                                (&v3394).to_string().clone();
                                                                                            let v3397:
                                                                                                    string =
                                                                                                Supervisor::method7();
                                                                                            let v3398:
                                                                                                    &str =
                                                                                                &v3397.as_str();
                                                                                            let v3401:
                                                                                                    &str =
                                                                                                &v3398[0i32
                                                                                                           as
                                                                                                           usize..2i32
                                                                                                                      as
                                                                                                                      usize];
                                                                                            let v3402:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3401);
                                                                                            let v3403:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v3402, 16).unwrap();
                                                                                            let v3404:
                                                                                                    string =
                                                                                                Supervisor::method7();
                                                                                            let v3405:
                                                                                                    &str =
                                                                                                &v3404.as_str();
                                                                                            let v3408:
                                                                                                    &str =
                                                                                                &v3405[2i32
                                                                                                           as
                                                                                                           usize..4i32
                                                                                                                      as
                                                                                                                      usize];
                                                                                            let v3409:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3408);
                                                                                            let v3410:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v3409, 16).unwrap();
                                                                                            let v3411:
                                                                                                    string =
                                                                                                Supervisor::method7();
                                                                                            let v3412:
                                                                                                    &str =
                                                                                                &v3411.as_str();
                                                                                            let v3415:
                                                                                                    &str =
                                                                                                &v3412[4i32
                                                                                                           as
                                                                                                           usize..6i32
                                                                                                                      as
                                                                                                                      usize];
                                                                                            let v3416:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v3415);
                                                                                            let v3417:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v3416, 16).unwrap();
                                                                                            let v3418:
                                                                                                    colored::ColoredString =
                                                                                                colored::Colorize::truecolor(&*v3396.to_string(), v3403, v3410, v3417);
                                                                                            let v3419:
                                                                                                    std::string::String =
                                                                                                format!("{}", &v3418);
                                                                                            println!("{0}",
                                                                                                     stringFrom(format!("{0} {1} {2}", &v3305, &v3362, &v3419)));
                                                                                            {
                                                                                                let v3421:
                                                                                                        Array<i32> =
                                                                                                    toArray(rangeNumeric(0i32,
                                                                                                                         1i32,
                                                                                                                         50i32).clone());
                                                                                                let v3422:
                                                                                                        i32 =
                                                                                                    v3421.len()
                                                                                                        as
                                                                                                        i32;
                                                                                                let v3424:
                                                                                                        Lrc<Supervisor::Mut0> =
                                                                                                    Lrc::new(Supervisor::Mut0{l0:
                                                                                                                                  MutCell::new(0i32),
                                                                                                                              l1:
                                                                                                                                  MutCell::new(Supervisor::US0::US0_0),});
                                                                                                while Supervisor::method12(v3422,
                                                                                                                           v3424.clone())
                                                                                                      {
                                                                                                    let v3426:
                                                                                                            i32 =
                                                                                                        v3424.l0.get();
                                                                                                    let v3427:
                                                                                                            Supervisor::US0 =
                                                                                                        v3424.l1.get().clone();
                                                                                                    let v3428:
                                                                                                            i32 =
                                                                                                        v3421[v3426].clone();
                                                                                                    let v3636:
                                                                                                            Supervisor::US0 =
                                                                                                        match &v3427
                                                                                                            {
                                                                                                            Supervisor::US0::US0_1(v3427_1_0)
                                                                                                            =>
                                                                                                            Supervisor::US0::US0_1(v3427_1_0.clone()),
                                                                                                            _
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3431:
                                                                                                                        std::time::SystemTime =
                                                                                                                    std::fs::metadata(&v854).unwrap().modified().unwrap();
                                                                                                                let v3442:
                                                                                                                        Array<std::string::String> =
                                                                                                                    array(&[(&string("i")).to_string(),
                                                                                                                            format!("{:?}", &v3428),
                                                                                                                            (&string("last_modified")).to_string(),
                                                                                                                            format!("{:?}", &v3431)]);
                                                                                                                let v3443 =
                                                                                                                    core::ops::Deref::deref(&v3442);
                                                                                                                let v3445:
                                                                                                                        std::string::String =
                                                                                                                    format!("{:?}", ***v3443).clone();
                                                                                                                let v3446:
                                                                                                                        chrono::DateTime<chrono::Utc> =
                                                                                                                    chrono::Utc::now();
                                                                                                                let v3451:
                                                                                                                        string =
                                                                                                                    Supervisor::method1(6i32,
                                                                                                                                        toString(&((&v3446).timestamp()
                                                                                                                                                       -
                                                                                                                                                       v3223)));
                                                                                                                let v3452:
                                                                                                                        u8 =
                                                                                                                    rand::random::<u8>();
                                                                                                                let v3465:
                                                                                                                        Array<std::string::String> =
                                                                                                                    array(&[(&v52).to_string(),
                                                                                                                            (&v3451).to_string(),
                                                                                                                            (&v57).to_string(),
                                                                                                                            format!("{:?}", &v3452),
                                                                                                                            (&v63).to_string(),
                                                                                                                            (&v66).to_string()]);
                                                                                                                let v3466 =
                                                                                                                    core::ops::Deref::deref(&v3465);
                                                                                                                let v3468:
                                                                                                                        std::string::String =
                                                                                                                    format!("{:?}", ***v3466).clone();
                                                                                                                let v3471:
                                                                                                                        Array<std::string::String> =
                                                                                                                    array(&[(&v3263).to_string()]);
                                                                                                                let v3472 =
                                                                                                                    core::ops::Deref::deref(&v3471);
                                                                                                                let v3475:
                                                                                                                        std::string::String =
                                                                                                                    format!("{:?}", ***v3472).clone();
                                                                                                                let v3476:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3475);
                                                                                                                let v3478:
                                                                                                                        &str =
                                                                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                                                                let v3479:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3478);
                                                                                                                let v3480:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3479.build().unwrap();
                                                                                                                let v3481:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3476);
                                                                                                                let v3482:
                                                                                                                        &str =
                                                                                                                    &v3481.as_str();
                                                                                                                let v3483:
                                                                                                                        string =
                                                                                                                    Supervisor::method3();
                                                                                                                let v3484:
                                                                                                                        &str =
                                                                                                                    &v3483.as_str();
                                                                                                                let v3485:
                                                                                                                        std::string::String =
                                                                                                                    v3480.replace_all(&v3482, v3484).to_string();
                                                                                                                let v3486:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3485);
                                                                                                                let v3488:
                                                                                                                        &str =
                                                                                                                    r#"\["(.*?)"\]"#;
                                                                                                                let v3489:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3488);
                                                                                                                let v3490:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3489.build().unwrap();
                                                                                                                let v3491:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3486);
                                                                                                                let v3492:
                                                                                                                        &str =
                                                                                                                    &v3491.as_str();
                                                                                                                let v3493:
                                                                                                                        string =
                                                                                                                    Supervisor::method4();
                                                                                                                let v3494:
                                                                                                                        &str =
                                                                                                                    &v3493.as_str();
                                                                                                                let v3495:
                                                                                                                        std::string::String =
                                                                                                                    v3490.replace_all(&v3492, v3494).to_string();
                                                                                                                let v3496:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3495);
                                                                                                                let v3498:
                                                                                                                        &str =
                                                                                                                    r#", "#;
                                                                                                                let v3499:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3498);
                                                                                                                let v3500:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3499.build().unwrap();
                                                                                                                let v3501:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3496);
                                                                                                                let v3502:
                                                                                                                        &str =
                                                                                                                    &v3501.as_str();
                                                                                                                let v3503:
                                                                                                                        string =
                                                                                                                    Supervisor::method5();
                                                                                                                let v3504:
                                                                                                                        &str =
                                                                                                                    &v3503.as_str();
                                                                                                                let v3505:
                                                                                                                        std::string::String =
                                                                                                                    v3500.replace_all(&v3502, v3504).to_string();
                                                                                                                let v3506:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3505);
                                                                                                                let v3508:
                                                                                                                        std::string::String =
                                                                                                                    (&v3506).to_string().clone();
                                                                                                                let v3509:
                                                                                                                        colored::ColoredString =
                                                                                                                    colored::Colorize::color(&*v3508, v122.clone().to_string());
                                                                                                                let v3510:
                                                                                                                        std::string::String =
                                                                                                                    format!("{}", &v3509);
                                                                                                                let v3512:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&&v3445);
                                                                                                                let v3514:
                                                                                                                        &str =
                                                                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                                                                let v3515:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3514);
                                                                                                                let v3516:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3515.build().unwrap();
                                                                                                                let v3517:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3512);
                                                                                                                let v3518:
                                                                                                                        &str =
                                                                                                                    &v3517.as_str();
                                                                                                                let v3519:
                                                                                                                        string =
                                                                                                                    Supervisor::method3();
                                                                                                                let v3520:
                                                                                                                        &str =
                                                                                                                    &v3519.as_str();
                                                                                                                let v3521:
                                                                                                                        std::string::String =
                                                                                                                    v3516.replace_all(&v3518, v3520).to_string();
                                                                                                                let v3522:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3521);
                                                                                                                let v3524:
                                                                                                                        &str =
                                                                                                                    r#"\["(.*?)"\]"#;
                                                                                                                let v3525:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3524);
                                                                                                                let v3526:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3525.build().unwrap();
                                                                                                                let v3527:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3522);
                                                                                                                let v3528:
                                                                                                                        &str =
                                                                                                                    &v3527.as_str();
                                                                                                                let v3529:
                                                                                                                        string =
                                                                                                                    Supervisor::method4();
                                                                                                                let v3530:
                                                                                                                        &str =
                                                                                                                    &v3529.as_str();
                                                                                                                let v3531:
                                                                                                                        std::string::String =
                                                                                                                    v3526.replace_all(&v3528, v3530).to_string();
                                                                                                                let v3532:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3531);
                                                                                                                let v3534:
                                                                                                                        &str =
                                                                                                                    r#", "#;
                                                                                                                let v3535:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3534);
                                                                                                                let v3536:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3535.build().unwrap();
                                                                                                                let v3537:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3532);
                                                                                                                let v3538:
                                                                                                                        &str =
                                                                                                                    &v3537.as_str();
                                                                                                                let v3539:
                                                                                                                        string =
                                                                                                                    Supervisor::method5();
                                                                                                                let v3540:
                                                                                                                        &str =
                                                                                                                    &v3539.as_str();
                                                                                                                let v3541:
                                                                                                                        std::string::String =
                                                                                                                    v3536.replace_all(&v3538, v3540).to_string();
                                                                                                                let v3542:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3541);
                                                                                                                let v3544:
                                                                                                                        std::string::String =
                                                                                                                    (&v3542).to_string().clone();
                                                                                                                let v3545:
                                                                                                                        string =
                                                                                                                    Supervisor::method11();
                                                                                                                let v3546:
                                                                                                                        &str =
                                                                                                                    &v3545.as_str();
                                                                                                                let v3549:
                                                                                                                        &str =
                                                                                                                    &v3546[0i32
                                                                                                                               as
                                                                                                                               usize..2i32
                                                                                                                                          as
                                                                                                                                          usize];
                                                                                                                let v3550:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3549);
                                                                                                                let v3551:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3550, 16).unwrap();
                                                                                                                let v3552:
                                                                                                                        string =
                                                                                                                    Supervisor::method11();
                                                                                                                let v3553:
                                                                                                                        &str =
                                                                                                                    &v3552.as_str();
                                                                                                                let v3556:
                                                                                                                        &str =
                                                                                                                    &v3553[2i32
                                                                                                                               as
                                                                                                                               usize..4i32
                                                                                                                                          as
                                                                                                                                          usize];
                                                                                                                let v3557:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3556);
                                                                                                                let v3558:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3557, 16).unwrap();
                                                                                                                let v3559:
                                                                                                                        string =
                                                                                                                    Supervisor::method11();
                                                                                                                let v3560:
                                                                                                                        &str =
                                                                                                                    &v3559.as_str();
                                                                                                                let v3563:
                                                                                                                        &str =
                                                                                                                    &v3560[4i32
                                                                                                                               as
                                                                                                                               usize..6i32
                                                                                                                                          as
                                                                                                                                          usize];
                                                                                                                let v3564:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3563);
                                                                                                                let v3565:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3564, 16).unwrap();
                                                                                                                let v3566:
                                                                                                                        colored::ColoredString =
                                                                                                                    colored::Colorize::truecolor(&*v3544.to_string(), v3551, v3558, v3565);
                                                                                                                let v3567:
                                                                                                                        std::string::String =
                                                                                                                    format!("{}", &v3566);
                                                                                                                let v3569:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&&v3468);
                                                                                                                let v3571:
                                                                                                                        &str =
                                                                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                                                                let v3572:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3571);
                                                                                                                let v3573:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3572.build().unwrap();
                                                                                                                let v3574:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3569);
                                                                                                                let v3575:
                                                                                                                        &str =
                                                                                                                    &v3574.as_str();
                                                                                                                let v3576:
                                                                                                                        string =
                                                                                                                    Supervisor::method3();
                                                                                                                let v3577:
                                                                                                                        &str =
                                                                                                                    &v3576.as_str();
                                                                                                                let v3578:
                                                                                                                        std::string::String =
                                                                                                                    v3573.replace_all(&v3575, v3577).to_string();
                                                                                                                let v3579:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3578);
                                                                                                                let v3581:
                                                                                                                        &str =
                                                                                                                    r#"\["(.*?)"\]"#;
                                                                                                                let v3582:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3581);
                                                                                                                let v3583:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3582.build().unwrap();
                                                                                                                let v3584:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3579);
                                                                                                                let v3585:
                                                                                                                        &str =
                                                                                                                    &v3584.as_str();
                                                                                                                let v3586:
                                                                                                                        string =
                                                                                                                    Supervisor::method4();
                                                                                                                let v3587:
                                                                                                                        &str =
                                                                                                                    &v3586.as_str();
                                                                                                                let v3588:
                                                                                                                        std::string::String =
                                                                                                                    v3583.replace_all(&v3585, v3587).to_string();
                                                                                                                let v3589:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3588);
                                                                                                                let v3591:
                                                                                                                        &str =
                                                                                                                    r#", "#;
                                                                                                                let v3592:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3591);
                                                                                                                let v3593:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3592.build().unwrap();
                                                                                                                let v3594:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3589);
                                                                                                                let v3595:
                                                                                                                        &str =
                                                                                                                    &v3594.as_str();
                                                                                                                let v3596:
                                                                                                                        string =
                                                                                                                    Supervisor::method5();
                                                                                                                let v3597:
                                                                                                                        &str =
                                                                                                                    &v3596.as_str();
                                                                                                                let v3598:
                                                                                                                        std::string::String =
                                                                                                                    v3593.replace_all(&v3595, v3597).to_string();
                                                                                                                let v3599:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3598);
                                                                                                                let v3601:
                                                                                                                        std::string::String =
                                                                                                                    (&v3599).to_string().clone();
                                                                                                                let v3602:
                                                                                                                        string =
                                                                                                                    Supervisor::method7();
                                                                                                                let v3603:
                                                                                                                        &str =
                                                                                                                    &v3602.as_str();
                                                                                                                let v3606:
                                                                                                                        &str =
                                                                                                                    &v3603[0i32
                                                                                                                               as
                                                                                                                               usize..2i32
                                                                                                                                          as
                                                                                                                                          usize];
                                                                                                                let v3607:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3606);
                                                                                                                let v3608:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3607, 16).unwrap();
                                                                                                                let v3609:
                                                                                                                        string =
                                                                                                                    Supervisor::method7();
                                                                                                                let v3610:
                                                                                                                        &str =
                                                                                                                    &v3609.as_str();
                                                                                                                let v3613:
                                                                                                                        &str =
                                                                                                                    &v3610[2i32
                                                                                                                               as
                                                                                                                               usize..4i32
                                                                                                                                          as
                                                                                                                                          usize];
                                                                                                                let v3614:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3613);
                                                                                                                let v3615:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3614, 16).unwrap();
                                                                                                                let v3616:
                                                                                                                        string =
                                                                                                                    Supervisor::method7();
                                                                                                                let v3617:
                                                                                                                        &str =
                                                                                                                    &v3616.as_str();
                                                                                                                let v3620:
                                                                                                                        &str =
                                                                                                                    &v3617[4i32
                                                                                                                               as
                                                                                                                               usize..6i32
                                                                                                                                          as
                                                                                                                                          usize];
                                                                                                                let v3621:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3620);
                                                                                                                let v3622:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3621, 16).unwrap();
                                                                                                                let v3623:
                                                                                                                        colored::ColoredString =
                                                                                                                    colored::Colorize::truecolor(&*v3601.to_string(), v3608, v3615, v3622);
                                                                                                                let v3624:
                                                                                                                        std::string::String =
                                                                                                                    format!("{}", &v3623);
                                                                                                                println!("{0}",
                                                                                                                         stringFrom(format!("{0} {1} {2}", &v3510, &v3567, &v3624)));
                                                                                                                if v3431 > v3225
                                                                                                                   {
                                                                                                                    let v3628:
                                                                                                                            Result<std::string::String,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_to_string(&v854);
                                                                                                                    let v3629:
                                                                                                                            std::string::String =
                                                                                                                        (&v3628).as_ref().unwrap().to_string();
                                                                                                                    Supervisor::US0::US0_1(fable_library_rust::String_::fromStr(&v3629))
                                                                                                                } else {
                                                                                                                    std::thread::sleep(std::time::Duration::from_millis(*&25u64));
                                                                                                                    Supervisor::US0::US0_0
                                                                                                                }
                                                                                                            }
                                                                                                        };
                                                                                                    let v3637:
                                                                                                            i32 =
                                                                                                        v3426
                                                                                                            +
                                                                                                            1i32;
                                                                                                    v3424.l0.set(v3637);
                                                                                                    v3424.l1.set(v3636.clone());
                                                                                                    ()
                                                                                                }
                                                                                                {
                                                                                                    let v3638:
                                                                                                            Supervisor::US0 =
                                                                                                        v3424.l1.get().clone();
                                                                                                    let v3641:
                                                                                                            string =
                                                                                                        match &v3638
                                                                                                            {
                                                                                                            Supervisor::US0::US0_1(v3638_1_0)
                                                                                                            =>
                                                                                                            v3638_1_0.clone(),
                                                                                                            _
                                                                                                            =>
                                                                                                            v1045,
                                                                                                        };
                                                                                                    let v3644:
                                                                                                            std::string::String =
                                                                                                        (&string("new_fsx len")).to_string().clone();
                                                                                                    let v3645:
                                                                                                            i32 =
                                                                                                        (&v3641).len().try_into().unwrap();
                                                                                                    let v3648:
                                                                                                            Array<std::string::String> =
                                                                                                        array(&[v3644,
                                                                                                                format!("{:?}", &v3645)]);
                                                                                                    let v3649 =
                                                                                                        core::ops::Deref::deref(&v3648);
                                                                                                    let v3651:
                                                                                                            std::string::String =
                                                                                                        format!("{:?}", ***v3649).clone();
                                                                                                    let v3652:
                                                                                                            chrono::DateTime<chrono::Utc> =
                                                                                                        chrono::Utc::now();
                                                                                                    let v3657:
                                                                                                            string =
                                                                                                        Supervisor::method1(6i32,
                                                                                                                            toString(&((&v3652).timestamp()
                                                                                                                                           -
                                                                                                                                           v9)));
                                                                                                    let v3658:
                                                                                                            u8 =
                                                                                                        rand::random::<u8>();
                                                                                                    let v3671:
                                                                                                            Array<std::string::String> =
                                                                                                        array(&[(&v52).to_string(),
                                                                                                                (&v3657).to_string(),
                                                                                                                (&v57).to_string(),
                                                                                                                format!("{:?}", &v3658),
                                                                                                                (&v63).to_string(),
                                                                                                                (&v66).to_string()]);
                                                                                                    let v3672 =
                                                                                                        core::ops::Deref::deref(&v3671);
                                                                                                    let v3674:
                                                                                                            std::string::String =
                                                                                                        format!("{:?}", ***v3672).clone();
                                                                                                    let v3677:
                                                                                                            Array<std::string::String> =
                                                                                                        array(&[(&v73).to_string()]);
                                                                                                    let v3678 =
                                                                                                        core::ops::Deref::deref(&v3677);
                                                                                                    let v3681:
                                                                                                            std::string::String =
                                                                                                        format!("{:?}", ***v3678).clone();
                                                                                                    let v3682:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3681);
                                                                                                    let v3684:
                                                                                                            &str =
                                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                                    let v3685:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3684);
                                                                                                    let v3686:
                                                                                                            &regex::Regex =
                                                                                                        &v3685.build().unwrap();
                                                                                                    let v3687:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3682);
                                                                                                    let v3688:
                                                                                                            &str =
                                                                                                        &v3687.as_str();
                                                                                                    let v3689:
                                                                                                            string =
                                                                                                        Supervisor::method3();
                                                                                                    let v3690:
                                                                                                            &str =
                                                                                                        &v3689.as_str();
                                                                                                    let v3691:
                                                                                                            std::string::String =
                                                                                                        v3686.replace_all(&v3688, v3690).to_string();
                                                                                                    let v3692:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3691);
                                                                                                    let v3694:
                                                                                                            &str =
                                                                                                        r#"\["(.*?)"\]"#;
                                                                                                    let v3695:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3694);
                                                                                                    let v3696:
                                                                                                            &regex::Regex =
                                                                                                        &v3695.build().unwrap();
                                                                                                    let v3697:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3692);
                                                                                                    let v3698:
                                                                                                            &str =
                                                                                                        &v3697.as_str();
                                                                                                    let v3699:
                                                                                                            string =
                                                                                                        Supervisor::method4();
                                                                                                    let v3700:
                                                                                                            &str =
                                                                                                        &v3699.as_str();
                                                                                                    let v3701:
                                                                                                            std::string::String =
                                                                                                        v3696.replace_all(&v3698, v3700).to_string();
                                                                                                    let v3702:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3701);
                                                                                                    let v3704:
                                                                                                            &str =
                                                                                                        r#", "#;
                                                                                                    let v3705:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3704);
                                                                                                    let v3706:
                                                                                                            &regex::Regex =
                                                                                                        &v3705.build().unwrap();
                                                                                                    let v3707:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3702);
                                                                                                    let v3708:
                                                                                                            &str =
                                                                                                        &v3707.as_str();
                                                                                                    let v3709:
                                                                                                            string =
                                                                                                        Supervisor::method5();
                                                                                                    let v3710:
                                                                                                            &str =
                                                                                                        &v3709.as_str();
                                                                                                    let v3711:
                                                                                                            std::string::String =
                                                                                                        v3706.replace_all(&v3708, v3710).to_string();
                                                                                                    let v3712:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3711);
                                                                                                    let v3714:
                                                                                                            std::string::String =
                                                                                                        (&v3712).to_string().clone();
                                                                                                    let v3715:
                                                                                                            colored::ColoredString =
                                                                                                        colored::Colorize::color(&*v3714, v122.clone().to_string());
                                                                                                    let v3716:
                                                                                                            std::string::String =
                                                                                                        format!("{}", &v3715);
                                                                                                    let v3718:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&&v3651);
                                                                                                    let v3720:
                                                                                                            &str =
                                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                                    let v3721:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3720);
                                                                                                    let v3722:
                                                                                                            &regex::Regex =
                                                                                                        &v3721.build().unwrap();
                                                                                                    let v3723:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3718);
                                                                                                    let v3724:
                                                                                                            &str =
                                                                                                        &v3723.as_str();
                                                                                                    let v3725:
                                                                                                            string =
                                                                                                        Supervisor::method3();
                                                                                                    let v3726:
                                                                                                            &str =
                                                                                                        &v3725.as_str();
                                                                                                    let v3727:
                                                                                                            std::string::String =
                                                                                                        v3722.replace_all(&v3724, v3726).to_string();
                                                                                                    let v3728:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3727);
                                                                                                    let v3730:
                                                                                                            &str =
                                                                                                        r#"\["(.*?)"\]"#;
                                                                                                    let v3731:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3730);
                                                                                                    let v3732:
                                                                                                            &regex::Regex =
                                                                                                        &v3731.build().unwrap();
                                                                                                    let v3733:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3728);
                                                                                                    let v3734:
                                                                                                            &str =
                                                                                                        &v3733.as_str();
                                                                                                    let v3735:
                                                                                                            string =
                                                                                                        Supervisor::method4();
                                                                                                    let v3736:
                                                                                                            &str =
                                                                                                        &v3735.as_str();
                                                                                                    let v3737:
                                                                                                            std::string::String =
                                                                                                        v3732.replace_all(&v3734, v3736).to_string();
                                                                                                    let v3738:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3737);
                                                                                                    let v3740:
                                                                                                            &str =
                                                                                                        r#", "#;
                                                                                                    let v3741:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3740);
                                                                                                    let v3742:
                                                                                                            &regex::Regex =
                                                                                                        &v3741.build().unwrap();
                                                                                                    let v3743:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3738);
                                                                                                    let v3744:
                                                                                                            &str =
                                                                                                        &v3743.as_str();
                                                                                                    let v3745:
                                                                                                            string =
                                                                                                        Supervisor::method5();
                                                                                                    let v3746:
                                                                                                            &str =
                                                                                                        &v3745.as_str();
                                                                                                    let v3747:
                                                                                                            std::string::String =
                                                                                                        v3742.replace_all(&v3744, v3746).to_string();
                                                                                                    let v3748:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3747);
                                                                                                    let v3750:
                                                                                                            std::string::String =
                                                                                                        (&v3748).to_string().clone();
                                                                                                    let v3751:
                                                                                                            string =
                                                                                                        Supervisor::method6();
                                                                                                    let v3752:
                                                                                                            &str =
                                                                                                        &v3751.as_str();
                                                                                                    let v3755:
                                                                                                            &str =
                                                                                                        &v3752[0i32
                                                                                                                   as
                                                                                                                   usize..2i32
                                                                                                                              as
                                                                                                                              usize];
                                                                                                    let v3756:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3755);
                                                                                                    let v3757:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3756, 16).unwrap();
                                                                                                    let v3758:
                                                                                                            string =
                                                                                                        Supervisor::method6();
                                                                                                    let v3759:
                                                                                                            &str =
                                                                                                        &v3758.as_str();
                                                                                                    let v3762:
                                                                                                            &str =
                                                                                                        &v3759[2i32
                                                                                                                   as
                                                                                                                   usize..4i32
                                                                                                                              as
                                                                                                                              usize];
                                                                                                    let v3763:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3762);
                                                                                                    let v3764:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3763, 16).unwrap();
                                                                                                    let v3765:
                                                                                                            string =
                                                                                                        Supervisor::method6();
                                                                                                    let v3766:
                                                                                                            &str =
                                                                                                        &v3765.as_str();
                                                                                                    let v3769:
                                                                                                            &str =
                                                                                                        &v3766[4i32
                                                                                                                   as
                                                                                                                   usize..6i32
                                                                                                                              as
                                                                                                                              usize];
                                                                                                    let v3770:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3769);
                                                                                                    let v3771:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3770, 16).unwrap();
                                                                                                    let v3772:
                                                                                                            colored::ColoredString =
                                                                                                        colored::Colorize::truecolor(&*v3750.to_string(), v3757, v3764, v3771);
                                                                                                    let v3773:
                                                                                                            std::string::String =
                                                                                                        format!("{}", &v3772);
                                                                                                    let v3775:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&&v3674);
                                                                                                    let v3777:
                                                                                                            &str =
                                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                                    let v3778:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3777);
                                                                                                    let v3779:
                                                                                                            &regex::Regex =
                                                                                                        &v3778.build().unwrap();
                                                                                                    let v3780:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3775);
                                                                                                    let v3781:
                                                                                                            &str =
                                                                                                        &v3780.as_str();
                                                                                                    let v3782:
                                                                                                            string =
                                                                                                        Supervisor::method3();
                                                                                                    let v3783:
                                                                                                            &str =
                                                                                                        &v3782.as_str();
                                                                                                    let v3784:
                                                                                                            std::string::String =
                                                                                                        v3779.replace_all(&v3781, v3783).to_string();
                                                                                                    let v3785:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3784);
                                                                                                    let v3787:
                                                                                                            &str =
                                                                                                        r#"\["(.*?)"\]"#;
                                                                                                    let v3788:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3787);
                                                                                                    let v3789:
                                                                                                            &regex::Regex =
                                                                                                        &v3788.build().unwrap();
                                                                                                    let v3790:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3785);
                                                                                                    let v3791:
                                                                                                            &str =
                                                                                                        &v3790.as_str();
                                                                                                    let v3792:
                                                                                                            string =
                                                                                                        Supervisor::method4();
                                                                                                    let v3793:
                                                                                                            &str =
                                                                                                        &v3792.as_str();
                                                                                                    let v3794:
                                                                                                            std::string::String =
                                                                                                        v3789.replace_all(&v3791, v3793).to_string();
                                                                                                    let v3795:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3794);
                                                                                                    let v3797:
                                                                                                            &str =
                                                                                                        r#", "#;
                                                                                                    let v3798:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3797);
                                                                                                    let v3799:
                                                                                                            &regex::Regex =
                                                                                                        &v3798.build().unwrap();
                                                                                                    let v3800:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3795);
                                                                                                    let v3801:
                                                                                                            &str =
                                                                                                        &v3800.as_str();
                                                                                                    let v3802:
                                                                                                            string =
                                                                                                        Supervisor::method5();
                                                                                                    let v3803:
                                                                                                            &str =
                                                                                                        &v3802.as_str();
                                                                                                    let v3804:
                                                                                                            std::string::String =
                                                                                                        v3799.replace_all(&v3801, v3803).to_string();
                                                                                                    let v3805:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3804);
                                                                                                    let v3807:
                                                                                                            std::string::String =
                                                                                                        (&v3805).to_string().clone();
                                                                                                    let v3808:
                                                                                                            string =
                                                                                                        Supervisor::method7();
                                                                                                    let v3809:
                                                                                                            &str =
                                                                                                        &v3808.as_str();
                                                                                                    let v3812:
                                                                                                            &str =
                                                                                                        &v3809[0i32
                                                                                                                   as
                                                                                                                   usize..2i32
                                                                                                                              as
                                                                                                                              usize];
                                                                                                    let v3813:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3812);
                                                                                                    let v3814:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3813, 16).unwrap();
                                                                                                    let v3815:
                                                                                                            string =
                                                                                                        Supervisor::method7();
                                                                                                    let v3816:
                                                                                                            &str =
                                                                                                        &v3815.as_str();
                                                                                                    let v3819:
                                                                                                            &str =
                                                                                                        &v3816[2i32
                                                                                                                   as
                                                                                                                   usize..4i32
                                                                                                                              as
                                                                                                                              usize];
                                                                                                    let v3820:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3819);
                                                                                                    let v3821:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3820, 16).unwrap();
                                                                                                    let v3822:
                                                                                                            string =
                                                                                                        Supervisor::method7();
                                                                                                    let v3823:
                                                                                                            &str =
                                                                                                        &v3822.as_str();
                                                                                                    let v3826:
                                                                                                            &str =
                                                                                                        &v3823[4i32
                                                                                                                   as
                                                                                                                   usize..6i32
                                                                                                                              as
                                                                                                                              usize];
                                                                                                    let v3827:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3826);
                                                                                                    let v3828:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3827, 16).unwrap();
                                                                                                    let v3829:
                                                                                                            colored::ColoredString =
                                                                                                        colored::Colorize::truecolor(&*v3807.to_string(), v3814, v3821, v3828);
                                                                                                    let v3830:
                                                                                                            std::string::String =
                                                                                                        format!("{}", &v3829);
                                                                                                    println!("{0}",
                                                                                                             stringFrom(format!("{0} {1} {2}", &v3716, &v3773, &v3830)));
                                                                                                    {
                                                                                                        let v3832:
                                                                                                                std::path::PathBuf =
                                                                                                            defaultValue(v854,
                                                                                                                         v1);
                                                                                                        let v3833:
                                                                                                                Result<(),
                                                                                                                       std::io::Error> =
                                                                                                            std::fs::write(v3832, v3641.clone().as_str());
                                                                                                        *((&v3833).as_ref()).unwrap();
                                                                                                        {
                                                                                                            let v3836:
                                                                                                                    std::string::String =
                                                                                                                (&string("> fs_write new_fsx_path; ok")).to_string().clone();
                                                                                                            let v3837:
                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                chrono::Utc::now();
                                                                                                            let v3842:
                                                                                                                    string =
                                                                                                                Supervisor::method1(6i32,
                                                                                                                                    toString(&((&v3837).timestamp()
                                                                                                                                                   -
                                                                                                                                                   v9)));
                                                                                                            let v3843:
                                                                                                                    u8 =
                                                                                                                rand::random::<u8>();
                                                                                                            let v3856:
                                                                                                                    Array<std::string::String> =
                                                                                                                array(&[(&v52).to_string(),
                                                                                                                        (&v3842).to_string(),
                                                                                                                        (&v57).to_string(),
                                                                                                                        format!("{:?}", &v3843),
                                                                                                                        (&v63).to_string(),
                                                                                                                        (&v66).to_string()]);
                                                                                                            let v3857 =
                                                                                                                core::ops::Deref::deref(&v3856);
                                                                                                            let v3859:
                                                                                                                    std::string::String =
                                                                                                                format!("{:?}", ***v3857).clone();
                                                                                                            let v3862:
                                                                                                                    Array<std::string::String> =
                                                                                                                array(&[(&v73).to_string()]);
                                                                                                            let v3863 =
                                                                                                                core::ops::Deref::deref(&v3862);
                                                                                                            let v3866:
                                                                                                                    std::string::String =
                                                                                                                format!("{:?}", ***v3863).clone();
                                                                                                            let v3867:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3866);
                                                                                                            let v3869:
                                                                                                                    &str =
                                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                                            let v3870:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3869);
                                                                                                            let v3871:
                                                                                                                    &regex::Regex =
                                                                                                                &v3870.build().unwrap();
                                                                                                            let v3872:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3867);
                                                                                                            let v3873:
                                                                                                                    &str =
                                                                                                                &v3872.as_str();
                                                                                                            let v3874:
                                                                                                                    string =
                                                                                                                Supervisor::method3();
                                                                                                            let v3875:
                                                                                                                    &str =
                                                                                                                &v3874.as_str();
                                                                                                            let v3876:
                                                                                                                    std::string::String =
                                                                                                                v3871.replace_all(&v3873, v3875).to_string();
                                                                                                            let v3877:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3876);
                                                                                                            let v3879:
                                                                                                                    &str =
                                                                                                                r#"\["(.*?)"\]"#;
                                                                                                            let v3880:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3879);
                                                                                                            let v3881:
                                                                                                                    &regex::Regex =
                                                                                                                &v3880.build().unwrap();
                                                                                                            let v3882:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3877);
                                                                                                            let v3883:
                                                                                                                    &str =
                                                                                                                &v3882.as_str();
                                                                                                            let v3884:
                                                                                                                    string =
                                                                                                                Supervisor::method4();
                                                                                                            let v3885:
                                                                                                                    &str =
                                                                                                                &v3884.as_str();
                                                                                                            let v3886:
                                                                                                                    std::string::String =
                                                                                                                v3881.replace_all(&v3883, v3885).to_string();
                                                                                                            let v3887:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3886);
                                                                                                            let v3889:
                                                                                                                    &str =
                                                                                                                r#", "#;
                                                                                                            let v3890:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3889);
                                                                                                            let v3891:
                                                                                                                    &regex::Regex =
                                                                                                                &v3890.build().unwrap();
                                                                                                            let v3892:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3887);
                                                                                                            let v3893:
                                                                                                                    &str =
                                                                                                                &v3892.as_str();
                                                                                                            let v3894:
                                                                                                                    string =
                                                                                                                Supervisor::method5();
                                                                                                            let v3895:
                                                                                                                    &str =
                                                                                                                &v3894.as_str();
                                                                                                            let v3896:
                                                                                                                    std::string::String =
                                                                                                                v3891.replace_all(&v3893, v3895).to_string();
                                                                                                            let v3897:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3896);
                                                                                                            let v3899:
                                                                                                                    std::string::String =
                                                                                                                (&v3897).to_string().clone();
                                                                                                            let v3900:
                                                                                                                    colored::ColoredString =
                                                                                                                colored::Colorize::color(&*v3899, v122.to_string());
                                                                                                            let v3901:
                                                                                                                    std::string::String =
                                                                                                                format!("{}", &v3900);
                                                                                                            let v3903:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&&v3836);
                                                                                                            let v3905:
                                                                                                                    &str =
                                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                                            let v3906:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3905);
                                                                                                            let v3907:
                                                                                                                    &regex::Regex =
                                                                                                                &v3906.build().unwrap();
                                                                                                            let v3908:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3903);
                                                                                                            let v3909:
                                                                                                                    &str =
                                                                                                                &v3908.as_str();
                                                                                                            let v3910:
                                                                                                                    string =
                                                                                                                Supervisor::method3();
                                                                                                            let v3911:
                                                                                                                    &str =
                                                                                                                &v3910.as_str();
                                                                                                            let v3912:
                                                                                                                    std::string::String =
                                                                                                                v3907.replace_all(&v3909, v3911).to_string();
                                                                                                            let v3913:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3912);
                                                                                                            let v3915:
                                                                                                                    &str =
                                                                                                                r#"\["(.*?)"\]"#;
                                                                                                            let v3916:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3915);
                                                                                                            let v3917:
                                                                                                                    &regex::Regex =
                                                                                                                &v3916.build().unwrap();
                                                                                                            let v3918:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3913);
                                                                                                            let v3919:
                                                                                                                    &str =
                                                                                                                &v3918.as_str();
                                                                                                            let v3920:
                                                                                                                    string =
                                                                                                                Supervisor::method4();
                                                                                                            let v3921:
                                                                                                                    &str =
                                                                                                                &v3920.as_str();
                                                                                                            let v3922:
                                                                                                                    std::string::String =
                                                                                                                v3917.replace_all(&v3919, v3921).to_string();
                                                                                                            let v3923:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3922);
                                                                                                            let v3925:
                                                                                                                    &str =
                                                                                                                r#", "#;
                                                                                                            let v3926:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3925);
                                                                                                            let v3927:
                                                                                                                    &regex::Regex =
                                                                                                                &v3926.build().unwrap();
                                                                                                            let v3928:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3923);
                                                                                                            let v3929:
                                                                                                                    &str =
                                                                                                                &v3928.as_str();
                                                                                                            let v3930:
                                                                                                                    string =
                                                                                                                Supervisor::method5();
                                                                                                            let v3931:
                                                                                                                    &str =
                                                                                                                &v3930.as_str();
                                                                                                            let v3932:
                                                                                                                    std::string::String =
                                                                                                                v3927.replace_all(&v3929, v3931).to_string();
                                                                                                            let v3933:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3932);
                                                                                                            let v3935:
                                                                                                                    std::string::String =
                                                                                                                (&v3933).to_string().clone();
                                                                                                            let v3936:
                                                                                                                    string =
                                                                                                                Supervisor::method6();
                                                                                                            let v3937:
                                                                                                                    &str =
                                                                                                                &v3936.as_str();
                                                                                                            let v3940:
                                                                                                                    &str =
                                                                                                                &v3937[0i32
                                                                                                                           as
                                                                                                                           usize..2i32
                                                                                                                                      as
                                                                                                                                      usize];
                                                                                                            let v3941:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3940);
                                                                                                            let v3942:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3941, 16).unwrap();
                                                                                                            let v3943:
                                                                                                                    string =
                                                                                                                Supervisor::method6();
                                                                                                            let v3944:
                                                                                                                    &str =
                                                                                                                &v3943.as_str();
                                                                                                            let v3947:
                                                                                                                    &str =
                                                                                                                &v3944[2i32
                                                                                                                           as
                                                                                                                           usize..4i32
                                                                                                                                      as
                                                                                                                                      usize];
                                                                                                            let v3948:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3947);
                                                                                                            let v3949:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3948, 16).unwrap();
                                                                                                            let v3950:
                                                                                                                    string =
                                                                                                                Supervisor::method6();
                                                                                                            let v3951:
                                                                                                                    &str =
                                                                                                                &v3950.as_str();
                                                                                                            let v3954:
                                                                                                                    &str =
                                                                                                                &v3951[4i32
                                                                                                                           as
                                                                                                                           usize..6i32
                                                                                                                                      as
                                                                                                                                      usize];
                                                                                                            let v3955:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3954);
                                                                                                            let v3956:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3955, 16).unwrap();
                                                                                                            let v3957:
                                                                                                                    colored::ColoredString =
                                                                                                                colored::Colorize::truecolor(&*v3935.to_string(), v3942, v3949, v3956);
                                                                                                            let v3958:
                                                                                                                    std::string::String =
                                                                                                                format!("{}", &v3957);
                                                                                                            let v3960:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&&v3859);
                                                                                                            let v3962:
                                                                                                                    &str =
                                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                                            let v3963:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3962);
                                                                                                            let v3964:
                                                                                                                    &regex::Regex =
                                                                                                                &v3963.build().unwrap();
                                                                                                            let v3965:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3960);
                                                                                                            let v3966:
                                                                                                                    &str =
                                                                                                                &v3965.as_str();
                                                                                                            let v3967:
                                                                                                                    string =
                                                                                                                Supervisor::method3();
                                                                                                            let v3968:
                                                                                                                    &str =
                                                                                                                &v3967.as_str();
                                                                                                            let v3969:
                                                                                                                    std::string::String =
                                                                                                                v3964.replace_all(&v3966, v3968).to_string();
                                                                                                            let v3970:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3969);
                                                                                                            let v3972:
                                                                                                                    &str =
                                                                                                                r#"\["(.*?)"\]"#;
                                                                                                            let v3973:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3972);
                                                                                                            let v3974:
                                                                                                                    &regex::Regex =
                                                                                                                &v3973.build().unwrap();
                                                                                                            let v3975:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3970);
                                                                                                            let v3976:
                                                                                                                    &str =
                                                                                                                &v3975.as_str();
                                                                                                            let v3977:
                                                                                                                    string =
                                                                                                                Supervisor::method4();
                                                                                                            let v3978:
                                                                                                                    &str =
                                                                                                                &v3977.as_str();
                                                                                                            let v3979:
                                                                                                                    std::string::String =
                                                                                                                v3974.replace_all(&v3976, v3978).to_string();
                                                                                                            let v3980:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3979);
                                                                                                            let v3982:
                                                                                                                    &str =
                                                                                                                r#", "#;
                                                                                                            let v3983:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3982);
                                                                                                            let v3984:
                                                                                                                    &regex::Regex =
                                                                                                                &v3983.build().unwrap();
                                                                                                            let v3985:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3980);
                                                                                                            let v3986:
                                                                                                                    &str =
                                                                                                                &v3985.as_str();
                                                                                                            let v3987:
                                                                                                                    string =
                                                                                                                Supervisor::method5();
                                                                                                            let v3988:
                                                                                                                    &str =
                                                                                                                &v3987.as_str();
                                                                                                            let v3989:
                                                                                                                    std::string::String =
                                                                                                                v3984.replace_all(&v3986, v3988).to_string();
                                                                                                            let v3990:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3989);
                                                                                                            let v3992:
                                                                                                                    std::string::String =
                                                                                                                (&v3990).to_string().clone();
                                                                                                            let v3993:
                                                                                                                    string =
                                                                                                                Supervisor::method7();
                                                                                                            let v3994:
                                                                                                                    &str =
                                                                                                                &v3993.as_str();
                                                                                                            let v3997:
                                                                                                                    &str =
                                                                                                                &v3994[0i32
                                                                                                                           as
                                                                                                                           usize..2i32
                                                                                                                                      as
                                                                                                                                      usize];
                                                                                                            let v3998:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3997);
                                                                                                            let v3999:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3998, 16).unwrap();
                                                                                                            let v4000:
                                                                                                                    string =
                                                                                                                Supervisor::method7();
                                                                                                            let v4001:
                                                                                                                    &str =
                                                                                                                &v4000.as_str();
                                                                                                            let v4004:
                                                                                                                    &str =
                                                                                                                &v4001[2i32
                                                                                                                           as
                                                                                                                           usize..4i32
                                                                                                                                      as
                                                                                                                                      usize];
                                                                                                            let v4005:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v4004);
                                                                                                            let v4006:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v4005, 16).unwrap();
                                                                                                            let v4007:
                                                                                                                    string =
                                                                                                                Supervisor::method7();
                                                                                                            let v4008:
                                                                                                                    &str =
                                                                                                                &v4007.as_str();
                                                                                                            let v4011:
                                                                                                                    &str =
                                                                                                                &v4008[4i32
                                                                                                                           as
                                                                                                                           usize..6i32
                                                                                                                                      as
                                                                                                                                      usize];
                                                                                                            let v4012:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v4011);
                                                                                                            let v4013:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v4012, 16).unwrap();
                                                                                                            let v4014:
                                                                                                                    colored::ColoredString =
                                                                                                                colored::Colorize::truecolor(&*v3992.to_string(), v3999, v4006, v4013);
                                                                                                            let v4015:
                                                                                                                    std::string::String =
                                                                                                                format!("{}", &v4014);
                                                                                                            println!("{0}",
                                                                                                                     stringFrom(format!("{0} {1} {2}", &v3901, &v3958, &v4015)));
                                                                                                            v3641
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
                        }
                    }
                }
            }
        }
    }
    pub fn closure0(unitVar: (), v0_1: std::path::PathBuf)
     -> Func1<Option<std::path::PathBuf>, string> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: Option<std::path::PathBuf>|
                           Supervisor::closure1(v0_1.clone(), v.clone())
                   })
    }
    pub fn v0()
     -> Func1<std::path::PathBuf, Func1<Option<std::path::PathBuf>, string>> {
        static v0:
         MutCell<Option<Func1<std::path::PathBuf,
                              Func1<Option<std::path::PathBuf>, string>>>> =
            MutCell::new(None);
        v0.get_or_init(move ||
                           Func1::new(move |v: std::path::PathBuf|
                                          Supervisor::closure0((),
                                                               v.clone())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;
