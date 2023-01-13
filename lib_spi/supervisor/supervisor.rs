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
    use fable_library_rust::String_::substring2;
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
    pub fn closure2(unitVar: (), v0_1: &std::path::Path)
     -> std::path::PathBuf {
        v0_1.join(string("package.spiproj").as_str())
    }
    pub fn closure3(unitVar: (), v0_1: &std::path::PathBuf) -> bool {
        std::path::Path::exists(&v0_1)
    }
    pub fn method6(v0_1: i32, v1: Lrc<Supervisor::Mut0>) -> bool {
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
        let v161: string = string("de884c");
        let v162: string = substring2(v161.clone(), 0i32, 2i32);
        let v164: u8 = u8::from_str_radix(&v162, 16).unwrap();
        let v165: string = substring2(v161.clone(), 2i32, 2i32);
        let v166: u8 = u8::from_str_radix(&v165, 16).unwrap();
        let v167: string = substring2(v161.clone(), 4i32, 2i32);
        let v168: u8 = u8::from_str_radix(&v167, 16).unwrap();
        let v170: colored::ColoredString =
            colored::Colorize::truecolor(&*v160.to_string(), v164, v166, v168);
        let v171: std::string::String = format!("{}", &v170);
        let v173: string = fable_library_rust::String_::fromStr(&&v72);
        let v175: &str = r#""([^"]+)", "([^"]+)""#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Supervisor::method2(v173);
        let v179: &str = &v178.as_str();
        let v180: string = Supervisor::method3();
        let v181: &str = &v180.as_str();
        let v182: std::string::String =
            v177.replace_all(&v179, v181).to_string();
        let v183: string = fable_library_rust::String_::fromStr(&v182);
        let v185: &str = r#"\["(.*?)"\]"#;
        let v186: regex::RegexBuilder = regex::RegexBuilder::new(&v185);
        let v187: &regex::Regex = &v186.build().unwrap();
        let v188: string = Supervisor::method2(v183);
        let v189: &str = &v188.as_str();
        let v190: string = Supervisor::method4();
        let v191: &str = &v190.as_str();
        let v192: std::string::String =
            v187.replace_all(&v189, v191).to_string();
        let v193: string = fable_library_rust::String_::fromStr(&v192);
        let v195: &str = r#", "#;
        let v196: regex::RegexBuilder = regex::RegexBuilder::new(&v195);
        let v197: &regex::Regex = &v196.build().unwrap();
        let v198: string = Supervisor::method2(v193);
        let v199: &str = &v198.as_str();
        let v200: string = Supervisor::method5();
        let v201: &str = &v200.as_str();
        let v202: std::string::String =
            v197.replace_all(&v199, v201).to_string();
        let v203: string = fable_library_rust::String_::fromStr(&v202);
        let v205: std::string::String = (&v203).to_string().clone();
        let v206: string = string("222222");
        let v207: string = substring2(v206.clone(), 0i32, 2i32);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = substring2(v206.clone(), 2i32, 2i32);
        let v210: u8 = u8::from_str_radix(&v209, 16).unwrap();
        let v211: string = substring2(v206.clone(), 4i32, 2i32);
        let v212: u8 = u8::from_str_radix(&v211, 16).unwrap();
        let v213: colored::ColoredString =
            colored::Colorize::truecolor(&*v205.to_string(), v208, v210, v212);
        let v214: std::string::String = format!("{}", &v213);
        println!("{0}",
                 stringFrom(format!("{0} {1} {2}", &v126, &v171, &v214)));
        {
            let v216: Result<std::path::PathBuf, std::io::Error> =
                (&v0_1).canonicalize();
            let v217: std::path::PathBuf =
                (&v216).as_ref().unwrap().to_path_buf();
            let v220: std::string::String =
                (&string("spi_path_clean")).to_string().clone();
            let v221: string =
                fable_library_rust::String_::fromStr(&format!("{}", &v217.display()));
            let v224: Array<std::string::String> =
                array(&[v220, (&v221).to_string()]);
            let v225 = core::ops::Deref::deref(&v224);
            let v227: std::string::String = format!("{:?}", ***v225).clone();
            let v228: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v233: string =
                Supervisor::method1(6i32,
                                    toString(&((&v228).timestamp() - v9)));
            let v234: u8 = rand::random::<u8>();
            let v247: Array<std::string::String> =
                array(&[(&v52).to_string(), (&v233).to_string(),
                        (&v57).to_string(), format!("{:?}", &v234),
                        (&v63).to_string(), (&v66).to_string()]);
            let v248 = core::ops::Deref::deref(&v247);
            let v250: std::string::String = format!("{:?}", ***v248).clone();
            let v253: Array<std::string::String> =
                array(&[(&v73).to_string()]);
            let v254 = core::ops::Deref::deref(&v253);
            let v257: std::string::String = format!("{:?}", ***v254).clone();
            let v258: string = fable_library_rust::String_::fromStr(&v257);
            let v260: &str = r#""([^"]+)", "([^"]+)""#;
            let v261: regex::RegexBuilder = regex::RegexBuilder::new(&v260);
            let v262: &regex::Regex = &v261.build().unwrap();
            let v263: string = Supervisor::method2(v258);
            let v264: &str = &v263.as_str();
            let v265: string = Supervisor::method3();
            let v266: &str = &v265.as_str();
            let v267: std::string::String =
                v262.replace_all(&v264, v266).to_string();
            let v268: string = fable_library_rust::String_::fromStr(&v267);
            let v270: &str = r#"\["(.*?)"\]"#;
            let v271: regex::RegexBuilder = regex::RegexBuilder::new(&v270);
            let v272: &regex::Regex = &v271.build().unwrap();
            let v273: string = Supervisor::method2(v268);
            let v274: &str = &v273.as_str();
            let v275: string = Supervisor::method4();
            let v276: &str = &v275.as_str();
            let v277: std::string::String =
                v272.replace_all(&v274, v276).to_string();
            let v278: string = fable_library_rust::String_::fromStr(&v277);
            let v280: &str = r#", "#;
            let v281: regex::RegexBuilder = regex::RegexBuilder::new(&v280);
            let v282: &regex::Regex = &v281.build().unwrap();
            let v283: string = Supervisor::method2(v278);
            let v284: &str = &v283.as_str();
            let v285: string = Supervisor::method5();
            let v286: &str = &v285.as_str();
            let v287: std::string::String =
                v282.replace_all(&v284, v286).to_string();
            let v288: string = fable_library_rust::String_::fromStr(&v287);
            let v290: std::string::String = (&v288).to_string().clone();
            let v291: colored::ColoredString =
                colored::Colorize::color(&*v290, v122.clone().to_string());
            let v292: std::string::String = format!("{}", &v291);
            let v294: string = fable_library_rust::String_::fromStr(&&v227);
            let v296: &str = r#""([^"]+)", "([^"]+)""#;
            let v297: regex::RegexBuilder = regex::RegexBuilder::new(&v296);
            let v298: &regex::Regex = &v297.build().unwrap();
            let v299: string = Supervisor::method2(v294);
            let v300: &str = &v299.as_str();
            let v301: string = Supervisor::method3();
            let v302: &str = &v301.as_str();
            let v303: std::string::String =
                v298.replace_all(&v300, v302).to_string();
            let v304: string = fable_library_rust::String_::fromStr(&v303);
            let v306: &str = r#"\["(.*?)"\]"#;
            let v307: regex::RegexBuilder = regex::RegexBuilder::new(&v306);
            let v308: &regex::Regex = &v307.build().unwrap();
            let v309: string = Supervisor::method2(v304);
            let v310: &str = &v309.as_str();
            let v311: string = Supervisor::method4();
            let v312: &str = &v311.as_str();
            let v313: std::string::String =
                v308.replace_all(&v310, v312).to_string();
            let v314: string = fable_library_rust::String_::fromStr(&v313);
            let v316: &str = r#", "#;
            let v317: regex::RegexBuilder = regex::RegexBuilder::new(&v316);
            let v318: &regex::Regex = &v317.build().unwrap();
            let v319: string = Supervisor::method2(v314);
            let v320: &str = &v319.as_str();
            let v321: string = Supervisor::method5();
            let v322: &str = &v321.as_str();
            let v323: std::string::String =
                v318.replace_all(&v320, v322).to_string();
            let v324: string = fable_library_rust::String_::fromStr(&v323);
            let v326: std::string::String = (&v324).to_string().clone();
            let v327: string = substring2(v161.clone(), 0i32, 2i32);
            let v328: u8 = u8::from_str_radix(&v327, 16).unwrap();
            let v329: string = substring2(v161.clone(), 2i32, 2i32);
            let v330: u8 = u8::from_str_radix(&v329, 16).unwrap();
            let v331: string = substring2(v161.clone(), 4i32, 2i32);
            let v332: u8 = u8::from_str_radix(&v331, 16).unwrap();
            let v333: colored::ColoredString =
                colored::Colorize::truecolor(&*v326.to_string(), v328, v330, v332);
            let v334: std::string::String = format!("{}", &v333);
            let v336: string = fable_library_rust::String_::fromStr(&&v250);
            let v338: &str = r#""([^"]+)", "([^"]+)""#;
            let v339: regex::RegexBuilder = regex::RegexBuilder::new(&v338);
            let v340: &regex::Regex = &v339.build().unwrap();
            let v341: string = Supervisor::method2(v336);
            let v342: &str = &v341.as_str();
            let v343: string = Supervisor::method3();
            let v344: &str = &v343.as_str();
            let v345: std::string::String =
                v340.replace_all(&v342, v344).to_string();
            let v346: string = fable_library_rust::String_::fromStr(&v345);
            let v348: &str = r#"\["(.*?)"\]"#;
            let v349: regex::RegexBuilder = regex::RegexBuilder::new(&v348);
            let v350: &regex::Regex = &v349.build().unwrap();
            let v351: string = Supervisor::method2(v346);
            let v352: &str = &v351.as_str();
            let v353: string = Supervisor::method4();
            let v354: &str = &v353.as_str();
            let v355: std::string::String =
                v350.replace_all(&v352, v354).to_string();
            let v356: string = fable_library_rust::String_::fromStr(&v355);
            let v358: &str = r#", "#;
            let v359: regex::RegexBuilder = regex::RegexBuilder::new(&v358);
            let v360: &regex::Regex = &v359.build().unwrap();
            let v361: string = Supervisor::method2(v356);
            let v362: &str = &v361.as_str();
            let v363: string = Supervisor::method5();
            let v364: &str = &v363.as_str();
            let v365: std::string::String =
                v360.replace_all(&v362, v364).to_string();
            let v366: string = fable_library_rust::String_::fromStr(&v365);
            let v368: std::string::String = (&v366).to_string().clone();
            let v369: string = substring2(v206.clone(), 0i32, 2i32);
            let v370: u8 = u8::from_str_radix(&v369, 16).unwrap();
            let v371: string = substring2(v206.clone(), 2i32, 2i32);
            let v372: u8 = u8::from_str_radix(&v371, 16).unwrap();
            let v373: string = substring2(v206.clone(), 4i32, 2i32);
            let v374: u8 = u8::from_str_radix(&v373, 16).unwrap();
            let v375: colored::ColoredString =
                colored::Colorize::truecolor(&*v368.to_string(), v370, v372, v374);
            let v376: std::string::String = format!("{}", &v375);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v292, &v334, &v376)));
            {
                let v379: Option<&std::path::Path> = (&v217).parent();
                let v381: &std::path::Path = &v379.unwrap();
                let v383: std::path::PathBuf =
                    std::path::PathBuf::from(&v381);
                let v384: Result<std::path::PathBuf, std::io::Error> =
                    (&v383).canonicalize();
                let v385: std::path::PathBuf =
                    (&v384).as_ref().unwrap().to_path_buf();
                let v388: std::string::String =
                    (&string("src_path")).to_string().clone();
                let v389: string =
                    fable_library_rust::String_::fromStr(&format!("{}", &v385.display()));
                let v392: Array<std::string::String> =
                    array(&[v388, (&v389).to_string()]);
                let v393 = core::ops::Deref::deref(&v392);
                let v395: std::string::String =
                    format!("{:?}", ***v393).clone();
                let v396: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v401: string =
                    Supervisor::method1(6i32,
                                        toString(&((&v396).timestamp() -
                                                       v9)));
                let v402: u8 = rand::random::<u8>();
                let v415: Array<std::string::String> =
                    array(&[(&v52).to_string(), (&v401).to_string(),
                            (&v57).to_string(), format!("{:?}", &v402),
                            (&v63).to_string(), (&v66).to_string()]);
                let v416 = core::ops::Deref::deref(&v415);
                let v418: std::string::String =
                    format!("{:?}", ***v416).clone();
                let v421: Array<std::string::String> =
                    array(&[(&v73).to_string()]);
                let v422 = core::ops::Deref::deref(&v421);
                let v425: std::string::String =
                    format!("{:?}", ***v422).clone();
                let v426: string =
                    fable_library_rust::String_::fromStr(&v425);
                let v428: &str = r#""([^"]+)", "([^"]+)""#;
                let v429: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v428);
                let v430: &regex::Regex = &v429.build().unwrap();
                let v431: string = Supervisor::method2(v426);
                let v432: &str = &v431.as_str();
                let v433: string = Supervisor::method3();
                let v434: &str = &v433.as_str();
                let v435: std::string::String =
                    v430.replace_all(&v432, v434).to_string();
                let v436: string =
                    fable_library_rust::String_::fromStr(&v435);
                let v438: &str = r#"\["(.*?)"\]"#;
                let v439: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v438);
                let v440: &regex::Regex = &v439.build().unwrap();
                let v441: string = Supervisor::method2(v436);
                let v442: &str = &v441.as_str();
                let v443: string = Supervisor::method4();
                let v444: &str = &v443.as_str();
                let v445: std::string::String =
                    v440.replace_all(&v442, v444).to_string();
                let v446: string =
                    fable_library_rust::String_::fromStr(&v445);
                let v448: &str = r#", "#;
                let v449: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v448);
                let v450: &regex::Regex = &v449.build().unwrap();
                let v451: string = Supervisor::method2(v446);
                let v452: &str = &v451.as_str();
                let v453: string = Supervisor::method5();
                let v454: &str = &v453.as_str();
                let v455: std::string::String =
                    v450.replace_all(&v452, v454).to_string();
                let v456: string =
                    fable_library_rust::String_::fromStr(&v455);
                let v458: std::string::String = (&v456).to_string().clone();
                let v459: colored::ColoredString =
                    colored::Colorize::color(&*v458, v122.clone().to_string());
                let v460: std::string::String = format!("{}", &v459);
                let v462: string =
                    fable_library_rust::String_::fromStr(&&v395);
                let v464: &str = r#""([^"]+)", "([^"]+)""#;
                let v465: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v464);
                let v466: &regex::Regex = &v465.build().unwrap();
                let v467: string = Supervisor::method2(v462);
                let v468: &str = &v467.as_str();
                let v469: string = Supervisor::method3();
                let v470: &str = &v469.as_str();
                let v471: std::string::String =
                    v466.replace_all(&v468, v470).to_string();
                let v472: string =
                    fable_library_rust::String_::fromStr(&v471);
                let v474: &str = r#"\["(.*?)"\]"#;
                let v475: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v474);
                let v476: &regex::Regex = &v475.build().unwrap();
                let v477: string = Supervisor::method2(v472);
                let v478: &str = &v477.as_str();
                let v479: string = Supervisor::method4();
                let v480: &str = &v479.as_str();
                let v481: std::string::String =
                    v476.replace_all(&v478, v480).to_string();
                let v482: string =
                    fable_library_rust::String_::fromStr(&v481);
                let v484: &str = r#", "#;
                let v485: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v484);
                let v486: &regex::Regex = &v485.build().unwrap();
                let v487: string = Supervisor::method2(v482);
                let v488: &str = &v487.as_str();
                let v489: string = Supervisor::method5();
                let v490: &str = &v489.as_str();
                let v491: std::string::String =
                    v486.replace_all(&v488, v490).to_string();
                let v492: string =
                    fable_library_rust::String_::fromStr(&v491);
                let v494: std::string::String = (&v492).to_string().clone();
                let v495: string = substring2(v161.clone(), 0i32, 2i32);
                let v496: u8 = u8::from_str_radix(&v495, 16).unwrap();
                let v497: string = substring2(v161.clone(), 2i32, 2i32);
                let v498: u8 = u8::from_str_radix(&v497, 16).unwrap();
                let v499: string = substring2(v161.clone(), 4i32, 2i32);
                let v500: u8 = u8::from_str_radix(&v499, 16).unwrap();
                let v501: colored::ColoredString =
                    colored::Colorize::truecolor(&*v494.to_string(), v496, v498, v500);
                let v502: std::string::String = format!("{}", &v501);
                let v504: string =
                    fable_library_rust::String_::fromStr(&&v418);
                let v506: &str = r#""([^"]+)", "([^"]+)""#;
                let v507: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v506);
                let v508: &regex::Regex = &v507.build().unwrap();
                let v509: string = Supervisor::method2(v504);
                let v510: &str = &v509.as_str();
                let v511: string = Supervisor::method3();
                let v512: &str = &v511.as_str();
                let v513: std::string::String =
                    v508.replace_all(&v510, v512).to_string();
                let v514: string =
                    fable_library_rust::String_::fromStr(&v513);
                let v516: &str = r#"\["(.*?)"\]"#;
                let v517: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v516);
                let v518: &regex::Regex = &v517.build().unwrap();
                let v519: string = Supervisor::method2(v514);
                let v520: &str = &v519.as_str();
                let v521: string = Supervisor::method4();
                let v522: &str = &v521.as_str();
                let v523: std::string::String =
                    v518.replace_all(&v520, v522).to_string();
                let v524: string =
                    fable_library_rust::String_::fromStr(&v523);
                let v526: &str = r#", "#;
                let v527: regex::RegexBuilder =
                    regex::RegexBuilder::new(&v526);
                let v528: &regex::Regex = &v527.build().unwrap();
                let v529: string = Supervisor::method2(v524);
                let v530: &str = &v529.as_str();
                let v531: string = Supervisor::method5();
                let v532: &str = &v531.as_str();
                let v533: std::string::String =
                    v528.replace_all(&v530, v532).to_string();
                let v534: string =
                    fable_library_rust::String_::fromStr(&v533);
                let v536: std::string::String = (&v534).to_string().clone();
                let v537: string = substring2(v206.clone(), 0i32, 2i32);
                let v538: u8 = u8::from_str_radix(&v537, 16).unwrap();
                let v539: string = substring2(v206.clone(), 2i32, 2i32);
                let v540: u8 = u8::from_str_radix(&v539, 16).unwrap();
                let v541: string = substring2(v206.clone(), 4i32, 2i32);
                let v542: u8 = u8::from_str_radix(&v541, 16).unwrap();
                let v543: colored::ColoredString =
                    colored::Colorize::truecolor(&*v536.to_string(), v538, v540, v542);
                let v544: std::string::String = format!("{}", &v543);
                println!("{0}",
                         stringFrom(format!("{0} {1} {2}", &v460, &v502, &v544)));
                {
                    let v547: &std::path::Ancestors = &v385.ancestors();
                    let v550: _ = v547.take(10i32 as usize);
                    fn v551(v: &std::path::Path) -> std::path::PathBuf {
                        Supervisor::closure2((), v)
                    }
                    let v554: _ = v550.into_iter().map((&v551).clone());
                    fn v555(v_1: &std::path::PathBuf) -> bool {
                        Supervisor::closure3((), v_1)
                    }
                    let v558: Option<std::path::PathBuf> =
                        v554.into_iter().find((&v555).clone());
                    let v559: std::path::PathBuf =
                        (&v558).as_ref().unwrap().to_path_buf();
                    let v560: string = string("spiproj_path");
                    let v562: std::string::String =
                        (&v560).to_string().clone();
                    let v563: string =
                        fable_library_rust::String_::fromStr(&format!("{}", &v559.display()));
                    let v566: Array<std::string::String> =
                        array(&[v562, (&v563).to_string()]);
                    let v567 = core::ops::Deref::deref(&v566);
                    let v569: std::string::String =
                        format!("{:?}", ***v567).clone();
                    let v570: chrono::DateTime<chrono::Utc> =
                        chrono::Utc::now();
                    let v575: string =
                        Supervisor::method1(6i32,
                                            toString(&((&v570).timestamp() -
                                                           v9)));
                    let v576: u8 = rand::random::<u8>();
                    let v589: Array<std::string::String> =
                        array(&[(&v52).to_string(), (&v575).to_string(),
                                (&v57).to_string(), format!("{:?}", &v576),
                                (&v63).to_string(), (&v66).to_string()]);
                    let v590 = core::ops::Deref::deref(&v589);
                    let v592: std::string::String =
                        format!("{:?}", ***v590).clone();
                    let v595: Array<std::string::String> =
                        array(&[(&v73).to_string()]);
                    let v596 = core::ops::Deref::deref(&v595);
                    let v599: std::string::String =
                        format!("{:?}", ***v596).clone();
                    let v600: string =
                        fable_library_rust::String_::fromStr(&v599);
                    let v602: &str = r#""([^"]+)", "([^"]+)""#;
                    let v603: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v602);
                    let v604: &regex::Regex = &v603.build().unwrap();
                    let v605: string = Supervisor::method2(v600);
                    let v606: &str = &v605.as_str();
                    let v607: string = Supervisor::method3();
                    let v608: &str = &v607.as_str();
                    let v609: std::string::String =
                        v604.replace_all(&v606, v608).to_string();
                    let v610: string =
                        fable_library_rust::String_::fromStr(&v609);
                    let v612: &str = r#"\["(.*?)"\]"#;
                    let v613: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v612);
                    let v614: &regex::Regex = &v613.build().unwrap();
                    let v615: string = Supervisor::method2(v610);
                    let v616: &str = &v615.as_str();
                    let v617: string = Supervisor::method4();
                    let v618: &str = &v617.as_str();
                    let v619: std::string::String =
                        v614.replace_all(&v616, v618).to_string();
                    let v620: string =
                        fable_library_rust::String_::fromStr(&v619);
                    let v622: &str = r#", "#;
                    let v623: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v622);
                    let v624: &regex::Regex = &v623.build().unwrap();
                    let v625: string = Supervisor::method2(v620);
                    let v626: &str = &v625.as_str();
                    let v627: string = Supervisor::method5();
                    let v628: &str = &v627.as_str();
                    let v629: std::string::String =
                        v624.replace_all(&v626, v628).to_string();
                    let v630: string =
                        fable_library_rust::String_::fromStr(&v629);
                    let v632: std::string::String =
                        (&v630).to_string().clone();
                    let v633: colored::ColoredString =
                        colored::Colorize::color(&*v632, v122.clone().to_string());
                    let v634: std::string::String = format!("{}", &v633);
                    let v636: string =
                        fable_library_rust::String_::fromStr(&&v569);
                    let v638: &str = r#""([^"]+)", "([^"]+)""#;
                    let v639: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v638);
                    let v640: &regex::Regex = &v639.build().unwrap();
                    let v641: string = Supervisor::method2(v636);
                    let v642: &str = &v641.as_str();
                    let v643: string = Supervisor::method3();
                    let v644: &str = &v643.as_str();
                    let v645: std::string::String =
                        v640.replace_all(&v642, v644).to_string();
                    let v646: string =
                        fable_library_rust::String_::fromStr(&v645);
                    let v648: &str = r#"\["(.*?)"\]"#;
                    let v649: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v648);
                    let v650: &regex::Regex = &v649.build().unwrap();
                    let v651: string = Supervisor::method2(v646);
                    let v652: &str = &v651.as_str();
                    let v653: string = Supervisor::method4();
                    let v654: &str = &v653.as_str();
                    let v655: std::string::String =
                        v650.replace_all(&v652, v654).to_string();
                    let v656: string =
                        fable_library_rust::String_::fromStr(&v655);
                    let v658: &str = r#", "#;
                    let v659: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v658);
                    let v660: &regex::Regex = &v659.build().unwrap();
                    let v661: string = Supervisor::method2(v656);
                    let v662: &str = &v661.as_str();
                    let v663: string = Supervisor::method5();
                    let v664: &str = &v663.as_str();
                    let v665: std::string::String =
                        v660.replace_all(&v662, v664).to_string();
                    let v666: string =
                        fable_library_rust::String_::fromStr(&v665);
                    let v668: std::string::String =
                        (&v666).to_string().clone();
                    let v669: string = substring2(v161.clone(), 0i32, 2i32);
                    let v670: u8 = u8::from_str_radix(&v669, 16).unwrap();
                    let v671: string = substring2(v161.clone(), 2i32, 2i32);
                    let v672: u8 = u8::from_str_radix(&v671, 16).unwrap();
                    let v673: string = substring2(v161.clone(), 4i32, 2i32);
                    let v674: u8 = u8::from_str_radix(&v673, 16).unwrap();
                    let v675: colored::ColoredString =
                        colored::Colorize::truecolor(&*v668.to_string(), v670, v672, v674);
                    let v676: std::string::String = format!("{}", &v675);
                    let v678: string =
                        fable_library_rust::String_::fromStr(&&v592);
                    let v680: &str = r#""([^"]+)", "([^"]+)""#;
                    let v681: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v680);
                    let v682: &regex::Regex = &v681.build().unwrap();
                    let v683: string = Supervisor::method2(v678);
                    let v684: &str = &v683.as_str();
                    let v685: string = Supervisor::method3();
                    let v686: &str = &v685.as_str();
                    let v687: std::string::String =
                        v682.replace_all(&v684, v686).to_string();
                    let v688: string =
                        fable_library_rust::String_::fromStr(&v687);
                    let v690: &str = r#"\["(.*?)"\]"#;
                    let v691: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v690);
                    let v692: &regex::Regex = &v691.build().unwrap();
                    let v693: string = Supervisor::method2(v688);
                    let v694: &str = &v693.as_str();
                    let v695: string = Supervisor::method4();
                    let v696: &str = &v695.as_str();
                    let v697: std::string::String =
                        v692.replace_all(&v694, v696).to_string();
                    let v698: string =
                        fable_library_rust::String_::fromStr(&v697);
                    let v700: &str = r#", "#;
                    let v701: regex::RegexBuilder =
                        regex::RegexBuilder::new(&v700);
                    let v702: &regex::Regex = &v701.build().unwrap();
                    let v703: string = Supervisor::method2(v698);
                    let v704: &str = &v703.as_str();
                    let v705: string = Supervisor::method5();
                    let v706: &str = &v705.as_str();
                    let v707: std::string::String =
                        v702.replace_all(&v704, v706).to_string();
                    let v708: string =
                        fable_library_rust::String_::fromStr(&v707);
                    let v710: std::string::String =
                        (&v708).to_string().clone();
                    let v711: string = substring2(v206.clone(), 0i32, 2i32);
                    let v712: u8 = u8::from_str_radix(&v711, 16).unwrap();
                    let v713: string = substring2(v206.clone(), 2i32, 2i32);
                    let v714: u8 = u8::from_str_radix(&v713, 16).unwrap();
                    let v715: string = substring2(v206.clone(), 4i32, 2i32);
                    let v716: u8 = u8::from_str_radix(&v715, 16).unwrap();
                    let v717: colored::ColoredString =
                        colored::Colorize::truecolor(&*v710.to_string(), v712, v714, v716);
                    let v718: std::string::String = format!("{}", &v717);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v634, &v676, &v718)));
                    {
                        let v721: Option<&str> = (&v217).to_str();
                        let v722: &str = &v721.unwrap();
                        let v725: string = string(".spi");
                        let v728: &str =
                            &v722.replace(&*(&string(".spir")).clone(), &(&v725).clone());
                        let v732: &str =
                            &v728.replace(&*(&v725).clone(), &(&string(".fsx")).clone());
                        let v733: std::path::PathBuf =
                            std::path::PathBuf::from(&v732);
                        let v734: Result<std::path::PathBuf, std::io::Error> =
                            (&v733).canonicalize();
                        let v735: std::path::PathBuf =
                            (&v734).as_ref().unwrap().to_path_buf();
                        let v736: string = string("fsx_path");
                        let v738: std::string::String =
                            (&v736).to_string().clone();
                        let v739: string =
                            fable_library_rust::String_::fromStr(&format!("{}", &v735.display()));
                        let v742: Array<std::string::String> =
                            array(&[v738, (&v739).to_string()]);
                        let v743 = core::ops::Deref::deref(&v742);
                        let v745: std::string::String =
                            format!("{:?}", ***v743).clone();
                        let v746: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v751: string =
                            Supervisor::method1(6i32,
                                                toString(&((&v746).timestamp()
                                                               - v9)));
                        let v752: u8 = rand::random::<u8>();
                        let v765: Array<std::string::String> =
                            array(&[(&v52).to_string(), (&v751).to_string(),
                                    (&v57).to_string(),
                                    format!("{:?}", &v752),
                                    (&v63).to_string(), (&v66).to_string()]);
                        let v766 = core::ops::Deref::deref(&v765);
                        let v768: std::string::String =
                            format!("{:?}", ***v766).clone();
                        let v771: Array<std::string::String> =
                            array(&[(&v73).to_string()]);
                        let v772 = core::ops::Deref::deref(&v771);
                        let v775: std::string::String =
                            format!("{:?}", ***v772).clone();
                        let v776: string =
                            fable_library_rust::String_::fromStr(&v775);
                        let v778: &str = r#""([^"]+)", "([^"]+)""#;
                        let v779: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v778);
                        let v780: &regex::Regex = &v779.build().unwrap();
                        let v781: string = Supervisor::method2(v776);
                        let v782: &str = &v781.as_str();
                        let v783: string = Supervisor::method3();
                        let v784: &str = &v783.as_str();
                        let v785: std::string::String =
                            v780.replace_all(&v782, v784).to_string();
                        let v786: string =
                            fable_library_rust::String_::fromStr(&v785);
                        let v788: &str = r#"\["(.*?)"\]"#;
                        let v789: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v788);
                        let v790: &regex::Regex = &v789.build().unwrap();
                        let v791: string = Supervisor::method2(v786);
                        let v792: &str = &v791.as_str();
                        let v793: string = Supervisor::method4();
                        let v794: &str = &v793.as_str();
                        let v795: std::string::String =
                            v790.replace_all(&v792, v794).to_string();
                        let v796: string =
                            fable_library_rust::String_::fromStr(&v795);
                        let v798: &str = r#", "#;
                        let v799: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v798);
                        let v800: &regex::Regex = &v799.build().unwrap();
                        let v801: string = Supervisor::method2(v796);
                        let v802: &str = &v801.as_str();
                        let v803: string = Supervisor::method5();
                        let v804: &str = &v803.as_str();
                        let v805: std::string::String =
                            v800.replace_all(&v802, v804).to_string();
                        let v806: string =
                            fable_library_rust::String_::fromStr(&v805);
                        let v808: std::string::String =
                            (&v806).to_string().clone();
                        let v809: colored::ColoredString =
                            colored::Colorize::color(&*v808, v122.clone().to_string());
                        let v810: std::string::String = format!("{}", &v809);
                        let v812: string =
                            fable_library_rust::String_::fromStr(&&v745);
                        let v814: &str = r#""([^"]+)", "([^"]+)""#;
                        let v815: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v814);
                        let v816: &regex::Regex = &v815.build().unwrap();
                        let v817: string = Supervisor::method2(v812);
                        let v818: &str = &v817.as_str();
                        let v819: string = Supervisor::method3();
                        let v820: &str = &v819.as_str();
                        let v821: std::string::String =
                            v816.replace_all(&v818, v820).to_string();
                        let v822: string =
                            fable_library_rust::String_::fromStr(&v821);
                        let v824: &str = r#"\["(.*?)"\]"#;
                        let v825: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v824);
                        let v826: &regex::Regex = &v825.build().unwrap();
                        let v827: string = Supervisor::method2(v822);
                        let v828: &str = &v827.as_str();
                        let v829: string = Supervisor::method4();
                        let v830: &str = &v829.as_str();
                        let v831: std::string::String =
                            v826.replace_all(&v828, v830).to_string();
                        let v832: string =
                            fable_library_rust::String_::fromStr(&v831);
                        let v834: &str = r#", "#;
                        let v835: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v834);
                        let v836: &regex::Regex = &v835.build().unwrap();
                        let v837: string = Supervisor::method2(v832);
                        let v838: &str = &v837.as_str();
                        let v839: string = Supervisor::method5();
                        let v840: &str = &v839.as_str();
                        let v841: std::string::String =
                            v836.replace_all(&v838, v840).to_string();
                        let v842: string =
                            fable_library_rust::String_::fromStr(&v841);
                        let v844: std::string::String =
                            (&v842).to_string().clone();
                        let v845: string =
                            substring2(v161.clone(), 0i32, 2i32);
                        let v846: u8 = u8::from_str_radix(&v845, 16).unwrap();
                        let v847: string =
                            substring2(v161.clone(), 2i32, 2i32);
                        let v848: u8 = u8::from_str_radix(&v847, 16).unwrap();
                        let v849: string =
                            substring2(v161.clone(), 4i32, 2i32);
                        let v850: u8 = u8::from_str_radix(&v849, 16).unwrap();
                        let v851: colored::ColoredString =
                            colored::Colorize::truecolor(&*v844.to_string(), v846, v848, v850);
                        let v852: std::string::String = format!("{}", &v851);
                        let v854: string =
                            fable_library_rust::String_::fromStr(&&v768);
                        let v856: &str = r#""([^"]+)", "([^"]+)""#;
                        let v857: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v856);
                        let v858: &regex::Regex = &v857.build().unwrap();
                        let v859: string = Supervisor::method2(v854);
                        let v860: &str = &v859.as_str();
                        let v861: string = Supervisor::method3();
                        let v862: &str = &v861.as_str();
                        let v863: std::string::String =
                            v858.replace_all(&v860, v862).to_string();
                        let v864: string =
                            fable_library_rust::String_::fromStr(&v863);
                        let v866: &str = r#"\["(.*?)"\]"#;
                        let v867: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v866);
                        let v868: &regex::Regex = &v867.build().unwrap();
                        let v869: string = Supervisor::method2(v864);
                        let v870: &str = &v869.as_str();
                        let v871: string = Supervisor::method4();
                        let v872: &str = &v871.as_str();
                        let v873: std::string::String =
                            v868.replace_all(&v870, v872).to_string();
                        let v874: string =
                            fable_library_rust::String_::fromStr(&v873);
                        let v876: &str = r#", "#;
                        let v877: regex::RegexBuilder =
                            regex::RegexBuilder::new(&v876);
                        let v878: &regex::Regex = &v877.build().unwrap();
                        let v879: string = Supervisor::method2(v874);
                        let v880: &str = &v879.as_str();
                        let v881: string = Supervisor::method5();
                        let v882: &str = &v881.as_str();
                        let v883: std::string::String =
                            v878.replace_all(&v880, v882).to_string();
                        let v884: string =
                            fable_library_rust::String_::fromStr(&v883);
                        let v886: std::string::String =
                            (&v884).to_string().clone();
                        let v887: string =
                            substring2(v206.clone(), 0i32, 2i32);
                        let v888: u8 = u8::from_str_radix(&v887, 16).unwrap();
                        let v889: string =
                            substring2(v206.clone(), 2i32, 2i32);
                        let v890: u8 = u8::from_str_radix(&v889, 16).unwrap();
                        let v891: string =
                            substring2(v206.clone(), 4i32, 2i32);
                        let v892: u8 = u8::from_str_radix(&v891, 16).unwrap();
                        let v893: colored::ColoredString =
                            colored::Colorize::truecolor(&*v886.to_string(), v888, v890, v892);
                        let v894: std::string::String = format!("{}", &v893);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v810, &v852, &v894)));
                        {
                            let v896: string = string("");
                            let v898: Result<(), std::io::Error> =
                                std::fs::write(v735.clone(), v896.clone().as_str());
                            *((&v898).as_ref()).unwrap();
                            {
                                let v902: std::string::String =
                                    (&string("> fs_write fsx_path \"\"; ok")).to_string().clone();
                                let v903: chrono::DateTime<chrono::Utc> =
                                    chrono::Utc::now();
                                let v908: string =
                                    Supervisor::method1(6i32,
                                                        toString(&((&v903).timestamp()
                                                                       -
                                                                       v9)));
                                let v909: u8 = rand::random::<u8>();
                                let v922: Array<std::string::String> =
                                    array(&[(&v52).to_string(),
                                            (&v908).to_string(),
                                            (&v57).to_string(),
                                            format!("{:?}", &v909),
                                            (&v63).to_string(),
                                            (&v66).to_string()]);
                                let v923 = core::ops::Deref::deref(&v922);
                                let v925: std::string::String =
                                    format!("{:?}", ***v923).clone();
                                let v928: Array<std::string::String> =
                                    array(&[(&v73).to_string()]);
                                let v929 = core::ops::Deref::deref(&v928);
                                let v932: std::string::String =
                                    format!("{:?}", ***v929).clone();
                                let v933: string =
                                    fable_library_rust::String_::fromStr(&v932);
                                let v935: &str = r#""([^"]+)", "([^"]+)""#;
                                let v936: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v935);
                                let v937: &regex::Regex =
                                    &v936.build().unwrap();
                                let v938: string = Supervisor::method2(v933);
                                let v939: &str = &v938.as_str();
                                let v940: string = Supervisor::method3();
                                let v941: &str = &v940.as_str();
                                let v942: std::string::String =
                                    v937.replace_all(&v939, v941).to_string();
                                let v943: string =
                                    fable_library_rust::String_::fromStr(&v942);
                                let v945: &str = r#"\["(.*?)"\]"#;
                                let v946: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v945);
                                let v947: &regex::Regex =
                                    &v946.build().unwrap();
                                let v948: string = Supervisor::method2(v943);
                                let v949: &str = &v948.as_str();
                                let v950: string = Supervisor::method4();
                                let v951: &str = &v950.as_str();
                                let v952: std::string::String =
                                    v947.replace_all(&v949, v951).to_string();
                                let v953: string =
                                    fable_library_rust::String_::fromStr(&v952);
                                let v955: &str = r#", "#;
                                let v956: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v955);
                                let v957: &regex::Regex =
                                    &v956.build().unwrap();
                                let v958: string = Supervisor::method2(v953);
                                let v959: &str = &v958.as_str();
                                let v960: string = Supervisor::method5();
                                let v961: &str = &v960.as_str();
                                let v962: std::string::String =
                                    v957.replace_all(&v959, v961).to_string();
                                let v963: string =
                                    fable_library_rust::String_::fromStr(&v962);
                                let v965: std::string::String =
                                    (&v963).to_string().clone();
                                let v966: colored::ColoredString =
                                    colored::Colorize::color(&*v965, v122.clone().to_string());
                                let v967: std::string::String =
                                    format!("{}", &v966);
                                let v969: string =
                                    fable_library_rust::String_::fromStr(&&v902);
                                let v971: &str = r#""([^"]+)", "([^"]+)""#;
                                let v972: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v971);
                                let v973: &regex::Regex =
                                    &v972.build().unwrap();
                                let v974: string = Supervisor::method2(v969);
                                let v975: &str = &v974.as_str();
                                let v976: string = Supervisor::method3();
                                let v977: &str = &v976.as_str();
                                let v978: std::string::String =
                                    v973.replace_all(&v975, v977).to_string();
                                let v979: string =
                                    fable_library_rust::String_::fromStr(&v978);
                                let v981: &str = r#"\["(.*?)"\]"#;
                                let v982: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v981);
                                let v983: &regex::Regex =
                                    &v982.build().unwrap();
                                let v984: string = Supervisor::method2(v979);
                                let v985: &str = &v984.as_str();
                                let v986: string = Supervisor::method4();
                                let v987: &str = &v986.as_str();
                                let v988: std::string::String =
                                    v983.replace_all(&v985, v987).to_string();
                                let v989: string =
                                    fable_library_rust::String_::fromStr(&v988);
                                let v991: &str = r#", "#;
                                let v992: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v991);
                                let v993: &regex::Regex =
                                    &v992.build().unwrap();
                                let v994: string = Supervisor::method2(v989);
                                let v995: &str = &v994.as_str();
                                let v996: string = Supervisor::method5();
                                let v997: &str = &v996.as_str();
                                let v998: std::string::String =
                                    v993.replace_all(&v995, v997).to_string();
                                let v999: string =
                                    fable_library_rust::String_::fromStr(&v998);
                                let v1001: std::string::String =
                                    (&v999).to_string().clone();
                                let v1002: string =
                                    substring2(v161.clone(), 0i32, 2i32);
                                let v1003: u8 =
                                    u8::from_str_radix(&v1002, 16).unwrap();
                                let v1004: string =
                                    substring2(v161.clone(), 2i32, 2i32);
                                let v1005: u8 =
                                    u8::from_str_radix(&v1004, 16).unwrap();
                                let v1006: string =
                                    substring2(v161.clone(), 4i32, 2i32);
                                let v1007: u8 =
                                    u8::from_str_radix(&v1006, 16).unwrap();
                                let v1008: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1001.to_string(), v1003, v1005, v1007);
                                let v1009: std::string::String =
                                    format!("{}", &v1008);
                                let v1011: string =
                                    fable_library_rust::String_::fromStr(&&v925);
                                let v1013: &str = r#""([^"]+)", "([^"]+)""#;
                                let v1014: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1013);
                                let v1015: &regex::Regex =
                                    &v1014.build().unwrap();
                                let v1016: string =
                                    Supervisor::method2(v1011);
                                let v1017: &str = &v1016.as_str();
                                let v1018: string = Supervisor::method3();
                                let v1019: &str = &v1018.as_str();
                                let v1020: std::string::String =
                                    v1015.replace_all(&v1017, v1019).to_string();
                                let v1021: string =
                                    fable_library_rust::String_::fromStr(&v1020);
                                let v1023: &str = r#"\["(.*?)"\]"#;
                                let v1024: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1023);
                                let v1025: &regex::Regex =
                                    &v1024.build().unwrap();
                                let v1026: string =
                                    Supervisor::method2(v1021);
                                let v1027: &str = &v1026.as_str();
                                let v1028: string = Supervisor::method4();
                                let v1029: &str = &v1028.as_str();
                                let v1030: std::string::String =
                                    v1025.replace_all(&v1027, v1029).to_string();
                                let v1031: string =
                                    fable_library_rust::String_::fromStr(&v1030);
                                let v1033: &str = r#", "#;
                                let v1034: regex::RegexBuilder =
                                    regex::RegexBuilder::new(&v1033);
                                let v1035: &regex::Regex =
                                    &v1034.build().unwrap();
                                let v1036: string =
                                    Supervisor::method2(v1031);
                                let v1037: &str = &v1036.as_str();
                                let v1038: string = Supervisor::method5();
                                let v1039: &str = &v1038.as_str();
                                let v1040: std::string::String =
                                    v1035.replace_all(&v1037, v1039).to_string();
                                let v1041: string =
                                    fable_library_rust::String_::fromStr(&v1040);
                                let v1043: std::string::String =
                                    (&v1041).to_string().clone();
                                let v1044: string =
                                    substring2(v206.clone(), 0i32, 2i32);
                                let v1045: u8 =
                                    u8::from_str_radix(&v1044, 16).unwrap();
                                let v1046: string =
                                    substring2(v206.clone(), 2i32, 2i32);
                                let v1047: u8 =
                                    u8::from_str_radix(&v1046, 16).unwrap();
                                let v1048: string =
                                    substring2(v206.clone(), 4i32, 2i32);
                                let v1049: u8 =
                                    u8::from_str_radix(&v1048, 16).unwrap();
                                let v1050: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v1043.to_string(), v1045, v1047, v1049);
                                let v1051: std::string::String =
                                    format!("{}", &v1050);
                                println!("{0}",
                                         stringFrom(format!("{0} {1} {2}", &v967, &v1009, &v1051)));
                                {
                                    let v1054:
                                            Result<std::string::String,
                                                   std::io::Error> =
                                        std::fs::read_to_string(&v559);
                                    let v1056: std::string::String =
                                        (&v1054).as_ref().unwrap().to_string();
                                    let patternInput_1:
                                            (string, string, string, bool) =
                                        Supervisor::method0();
                                    let v1061: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v1062: i64 = (&v1061).timestamp();
                                    let v1064: std::string::String =
                                        (&v560).to_string().clone();
                                    let v1065: string =
                                        fable_library_rust::String_::fromStr(&format!("{}", &v559.display()));
                                    let v1067: std::string::String =
                                        (&v1065).to_string().clone();
                                    let v1070: std::string::String =
                                        (&string("spiproj_text len")).to_string().clone();
                                    let v1072: i32 =
                                        (&v1056).len().try_into().unwrap();
                                    let v1075: Array<std::string::String> =
                                        array(&[v1064, v1067, v1070,
                                                format!("{:?}", &v1072)]);
                                    let v1076 =
                                        core::ops::Deref::deref(&v1075);
                                    let v1078: std::string::String =
                                        format!("{:?}", ***v1076).clone();
                                    let v1079: chrono::DateTime<chrono::Utc> =
                                        chrono::Utc::now();
                                    let v1084: string =
                                        Supervisor::method1(6i32,
                                                            toString(&((&v1079).timestamp()
                                                                           -
                                                                           v1062)));
                                    let v1085: u8 = rand::random::<u8>();
                                    let v1098: Array<std::string::String> =
                                        array(&[(&v52).to_string(),
                                                (&v1084).to_string(),
                                                (&v57).to_string(),
                                                format!("{:?}", &v1085),
                                                (&v63).to_string(),
                                                (&v66).to_string()]);
                                    let v1099 =
                                        core::ops::Deref::deref(&v1098);
                                    let v1101: std::string::String =
                                        format!("{:?}", ***v1099).clone();
                                    let v1102: string =
                                        string("> spiproj_open ()");
                                    let v1105: Array<std::string::String> =
                                        array(&[(&v1102).to_string()]);
                                    let v1106 =
                                        core::ops::Deref::deref(&v1105);
                                    let v1109: std::string::String =
                                        format!("{:?}", ***v1106).clone();
                                    let v1110: string =
                                        fable_library_rust::String_::fromStr(&v1109);
                                    let v1112: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1113: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1112);
                                    let v1114: &regex::Regex =
                                        &v1113.build().unwrap();
                                    let v1115: string =
                                        Supervisor::method2(v1110);
                                    let v1116: &str = &v1115.as_str();
                                    let v1117: string = Supervisor::method3();
                                    let v1118: &str = &v1117.as_str();
                                    let v1119: std::string::String =
                                        v1114.replace_all(&v1116, v1118).to_string();
                                    let v1120: string =
                                        fable_library_rust::String_::fromStr(&v1119);
                                    let v1122: &str = r#"\["(.*?)"\]"#;
                                    let v1123: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1122);
                                    let v1124: &regex::Regex =
                                        &v1123.build().unwrap();
                                    let v1125: string =
                                        Supervisor::method2(v1120);
                                    let v1126: &str = &v1125.as_str();
                                    let v1127: string = Supervisor::method4();
                                    let v1128: &str = &v1127.as_str();
                                    let v1129: std::string::String =
                                        v1124.replace_all(&v1126, v1128).to_string();
                                    let v1130: string =
                                        fable_library_rust::String_::fromStr(&v1129);
                                    let v1132: &str = r#", "#;
                                    let v1133: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1132);
                                    let v1134: &regex::Regex =
                                        &v1133.build().unwrap();
                                    let v1135: string =
                                        Supervisor::method2(v1130);
                                    let v1136: &str = &v1135.as_str();
                                    let v1137: string = Supervisor::method5();
                                    let v1138: &str = &v1137.as_str();
                                    let v1139: std::string::String =
                                        v1134.replace_all(&v1136, v1138).to_string();
                                    let v1140: string =
                                        fable_library_rust::String_::fromStr(&v1139);
                                    let v1142: std::string::String =
                                        (&v1140).to_string().clone();
                                    let v1143: colored::ColoredString =
                                        colored::Colorize::color(&*v1142, v122.clone().to_string());
                                    let v1144: std::string::String =
                                        format!("{}", &v1143);
                                    let v1146: string =
                                        fable_library_rust::String_::fromStr(&&v1078);
                                    let v1148: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1149: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1148);
                                    let v1150: &regex::Regex =
                                        &v1149.build().unwrap();
                                    let v1151: string =
                                        Supervisor::method2(v1146);
                                    let v1152: &str = &v1151.as_str();
                                    let v1153: string = Supervisor::method3();
                                    let v1154: &str = &v1153.as_str();
                                    let v1155: std::string::String =
                                        v1150.replace_all(&v1152, v1154).to_string();
                                    let v1156: string =
                                        fable_library_rust::String_::fromStr(&v1155);
                                    let v1158: &str = r#"\["(.*?)"\]"#;
                                    let v1159: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1158);
                                    let v1160: &regex::Regex =
                                        &v1159.build().unwrap();
                                    let v1161: string =
                                        Supervisor::method2(v1156);
                                    let v1162: &str = &v1161.as_str();
                                    let v1163: string = Supervisor::method4();
                                    let v1164: &str = &v1163.as_str();
                                    let v1165: std::string::String =
                                        v1160.replace_all(&v1162, v1164).to_string();
                                    let v1166: string =
                                        fable_library_rust::String_::fromStr(&v1165);
                                    let v1168: &str = r#", "#;
                                    let v1169: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1168);
                                    let v1170: &regex::Regex =
                                        &v1169.build().unwrap();
                                    let v1171: string =
                                        Supervisor::method2(v1166);
                                    let v1172: &str = &v1171.as_str();
                                    let v1173: string = Supervisor::method5();
                                    let v1174: &str = &v1173.as_str();
                                    let v1175: std::string::String =
                                        v1170.replace_all(&v1172, v1174).to_string();
                                    let v1176: string =
                                        fable_library_rust::String_::fromStr(&v1175);
                                    let v1178: std::string::String =
                                        (&v1176).to_string().clone();
                                    let v1179: string = string("e36a62");
                                    let v1180: string =
                                        substring2(v1179.clone(), 0i32, 2i32);
                                    let v1181: u8 =
                                        u8::from_str_radix(&v1180, 16).unwrap();
                                    let v1182: string =
                                        substring2(v1179.clone(), 2i32, 2i32);
                                    let v1183: u8 =
                                        u8::from_str_radix(&v1182, 16).unwrap();
                                    let v1184: string =
                                        substring2(v1179.clone(), 4i32, 2i32);
                                    let v1185: u8 =
                                        u8::from_str_radix(&v1184, 16).unwrap();
                                    let v1186: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v1178.to_string(), v1181, v1183, v1185);
                                    let v1187: std::string::String =
                                        format!("{}", &v1186);
                                    let v1189: string =
                                        fable_library_rust::String_::fromStr(&&v1101);
                                    let v1191: &str =
                                        r#""([^"]+)", "([^"]+)""#;
                                    let v1192: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1191);
                                    let v1193: &regex::Regex =
                                        &v1192.build().unwrap();
                                    let v1194: string =
                                        Supervisor::method2(v1189);
                                    let v1195: &str = &v1194.as_str();
                                    let v1196: string = Supervisor::method3();
                                    let v1197: &str = &v1196.as_str();
                                    let v1198: std::string::String =
                                        v1193.replace_all(&v1195, v1197).to_string();
                                    let v1199: string =
                                        fable_library_rust::String_::fromStr(&v1198);
                                    let v1201: &str = r#"\["(.*?)"\]"#;
                                    let v1202: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1201);
                                    let v1203: &regex::Regex =
                                        &v1202.build().unwrap();
                                    let v1204: string =
                                        Supervisor::method2(v1199);
                                    let v1205: &str = &v1204.as_str();
                                    let v1206: string = Supervisor::method4();
                                    let v1207: &str = &v1206.as_str();
                                    let v1208: std::string::String =
                                        v1203.replace_all(&v1205, v1207).to_string();
                                    let v1209: string =
                                        fable_library_rust::String_::fromStr(&v1208);
                                    let v1211: &str = r#", "#;
                                    let v1212: regex::RegexBuilder =
                                        regex::RegexBuilder::new(&v1211);
                                    let v1213: &regex::Regex =
                                        &v1212.build().unwrap();
                                    let v1214: string =
                                        Supervisor::method2(v1209);
                                    let v1215: &str = &v1214.as_str();
                                    let v1216: string = Supervisor::method5();
                                    let v1217: &str = &v1216.as_str();
                                    let v1218: std::string::String =
                                        v1213.replace_all(&v1215, v1217).to_string();
                                    let v1219: string =
                                        fable_library_rust::String_::fromStr(&v1218);
                                    let v1221: std::string::String =
                                        (&v1219).to_string().clone();
                                    let v1222: string =
                                        substring2(v206.clone(), 0i32, 2i32);
                                    let v1223: u8 =
                                        u8::from_str_radix(&v1222, 16).unwrap();
                                    let v1224: string =
                                        substring2(v206.clone(), 2i32, 2i32);
                                    let v1225: u8 =
                                        u8::from_str_radix(&v1224, 16).unwrap();
                                    let v1226: string =
                                        substring2(v206.clone(), 4i32, 2i32);
                                    let v1227: u8 =
                                        u8::from_str_radix(&v1226, 16).unwrap();
                                    let v1228: colored::ColoredString =
                                        colored::Colorize::truecolor(&*v1221.to_string(), v1223, v1225, v1227);
                                    let v1229: std::string::String =
                                        format!("{}", &v1228);
                                    println!("{0}",
                                             stringFrom(format!("{0} {1} {2}", &v1144, &v1187, &v1229)));
                                    {
                                        let v1231: string = string("{");
                                        let v1234: string =
                                            string("\"uri\": $0,");
                                        let v1238: string = string("}");
                                        let v1241: string =
                                            string("serde_json::json!(");
                                        let v1243: string =
                                            string(").to_string()");
                                        let v1244: string =
                                            append(append(v1241.clone(),
                                                          append(append(append(append(append(v1231.clone(),
                                                                                             string("\"ProjectFileOpen\": {")),
                                                                                      v1234.clone()),
                                                                               string("\"spiprojText\": $1")),
                                                                        v1238.clone()),
                                                                 v1238.clone())),
                                                   v1243.clone());
                                        let v1245: std::string::String =
                                            serde_json::json!({"ProjectFileOpen": {"uri": v559,"spiprojText": v1056}}).to_string();
                                        let v1248: std::string::String =
                                            (&string("json len=")).to_string().clone();
                                        let v1249: i32 =
                                            (&v1245).len().try_into().unwrap();
                                        let v1252:
                                                Array<std::string::String> =
                                            array(&[v1248,
                                                    format!("{:?}", &v1249)]);
                                        let v1253 =
                                            core::ops::Deref::deref(&v1252);
                                        let v1255: std::string::String =
                                            format!("{:?}", ***v1253).clone();
                                        let v1256:
                                                chrono::DateTime<chrono::Utc> =
                                            chrono::Utc::now();
                                        let v1261: string =
                                            Supervisor::method1(6i32,
                                                                toString(&((&v1256).timestamp()
                                                                               -
                                                                               v1062)));
                                        let v1262: u8 = rand::random::<u8>();
                                        let v1275:
                                                Array<std::string::String> =
                                            array(&[(&v52).to_string(),
                                                    (&v1261).to_string(),
                                                    (&v57).to_string(),
                                                    format!("{:?}", &v1262),
                                                    (&v63).to_string(),
                                                    (&v66).to_string()]);
                                        let v1276 =
                                            core::ops::Deref::deref(&v1275);
                                        let v1278: std::string::String =
                                            format!("{:?}", ***v1276).clone();
                                        let v1281:
                                                Array<std::string::String> =
                                            array(&[(&v1102).to_string()]);
                                        let v1282 =
                                            core::ops::Deref::deref(&v1281);
                                        let v1285: std::string::String =
                                            format!("{:?}", ***v1282).clone();
                                        let v1286: string =
                                            fable_library_rust::String_::fromStr(&v1285);
                                        let v1288: &str =
                                            r#""([^"]+)", "([^"]+)""#;
                                        let v1289: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1288);
                                        let v1290: &regex::Regex =
                                            &v1289.build().unwrap();
                                        let v1291: string =
                                            Supervisor::method2(v1286);
                                        let v1292: &str = &v1291.as_str();
                                        let v1293: string =
                                            Supervisor::method3();
                                        let v1294: &str = &v1293.as_str();
                                        let v1295: std::string::String =
                                            v1290.replace_all(&v1292, v1294).to_string();
                                        let v1296: string =
                                            fable_library_rust::String_::fromStr(&v1295);
                                        let v1298: &str = r#"\["(.*?)"\]"#;
                                        let v1299: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1298);
                                        let v1300: &regex::Regex =
                                            &v1299.build().unwrap();
                                        let v1301: string =
                                            Supervisor::method2(v1296);
                                        let v1302: &str = &v1301.as_str();
                                        let v1303: string =
                                            Supervisor::method4();
                                        let v1304: &str = &v1303.as_str();
                                        let v1305: std::string::String =
                                            v1300.replace_all(&v1302, v1304).to_string();
                                        let v1306: string =
                                            fable_library_rust::String_::fromStr(&v1305);
                                        let v1308: &str = r#", "#;
                                        let v1309: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1308);
                                        let v1310: &regex::Regex =
                                            &v1309.build().unwrap();
                                        let v1311: string =
                                            Supervisor::method2(v1306);
                                        let v1312: &str = &v1311.as_str();
                                        let v1313: string =
                                            Supervisor::method5();
                                        let v1314: &str = &v1313.as_str();
                                        let v1315: std::string::String =
                                            v1310.replace_all(&v1312, v1314).to_string();
                                        let v1316: string =
                                            fable_library_rust::String_::fromStr(&v1315);
                                        let v1318: std::string::String =
                                            (&v1316).to_string().clone();
                                        let v1319: colored::ColoredString =
                                            colored::Colorize::color(&*v1318, v122.clone().to_string());
                                        let v1320: std::string::String =
                                            format!("{}", &v1319);
                                        let v1322: string =
                                            fable_library_rust::String_::fromStr(&&v1255);
                                        let v1324: &str =
                                            r#""([^"]+)", "([^"]+)""#;
                                        let v1325: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1324);
                                        let v1326: &regex::Regex =
                                            &v1325.build().unwrap();
                                        let v1327: string =
                                            Supervisor::method2(v1322);
                                        let v1328: &str = &v1327.as_str();
                                        let v1329: string =
                                            Supervisor::method3();
                                        let v1330: &str = &v1329.as_str();
                                        let v1331: std::string::String =
                                            v1326.replace_all(&v1328, v1330).to_string();
                                        let v1332: string =
                                            fable_library_rust::String_::fromStr(&v1331);
                                        let v1334: &str = r#"\["(.*?)"\]"#;
                                        let v1335: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1334);
                                        let v1336: &regex::Regex =
                                            &v1335.build().unwrap();
                                        let v1337: string =
                                            Supervisor::method2(v1332);
                                        let v1338: &str = &v1337.as_str();
                                        let v1339: string =
                                            Supervisor::method4();
                                        let v1340: &str = &v1339.as_str();
                                        let v1341: std::string::String =
                                            v1336.replace_all(&v1338, v1340).to_string();
                                        let v1342: string =
                                            fable_library_rust::String_::fromStr(&v1341);
                                        let v1344: &str = r#", "#;
                                        let v1345: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1344);
                                        let v1346: &regex::Regex =
                                            &v1345.build().unwrap();
                                        let v1347: string =
                                            Supervisor::method2(v1342);
                                        let v1348: &str = &v1347.as_str();
                                        let v1349: string =
                                            Supervisor::method5();
                                        let v1350: &str = &v1349.as_str();
                                        let v1351: std::string::String =
                                            v1346.replace_all(&v1348, v1350).to_string();
                                        let v1352: string =
                                            fable_library_rust::String_::fromStr(&v1351);
                                        let v1354: std::string::String =
                                            (&v1352).to_string().clone();
                                        let v1355: string =
                                            substring2(v1179.clone(), 0i32,
                                                       2i32);
                                        let v1356: u8 =
                                            u8::from_str_radix(&v1355, 16).unwrap();
                                        let v1357: string =
                                            substring2(v1179.clone(), 2i32,
                                                       2i32);
                                        let v1358: u8 =
                                            u8::from_str_radix(&v1357, 16).unwrap();
                                        let v1359: string =
                                            substring2(v1179, 4i32, 2i32);
                                        let v1360: u8 =
                                            u8::from_str_radix(&v1359, 16).unwrap();
                                        let v1361: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1354.to_string(), v1356, v1358, v1360);
                                        let v1362: std::string::String =
                                            format!("{}", &v1361);
                                        let v1364: string =
                                            fable_library_rust::String_::fromStr(&&v1278);
                                        let v1366: &str =
                                            r#""([^"]+)", "([^"]+)""#;
                                        let v1367: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1366);
                                        let v1368: &regex::Regex =
                                            &v1367.build().unwrap();
                                        let v1369: string =
                                            Supervisor::method2(v1364);
                                        let v1370: &str = &v1369.as_str();
                                        let v1371: string =
                                            Supervisor::method3();
                                        let v1372: &str = &v1371.as_str();
                                        let v1373: std::string::String =
                                            v1368.replace_all(&v1370, v1372).to_string();
                                        let v1374: string =
                                            fable_library_rust::String_::fromStr(&v1373);
                                        let v1376: &str = r#"\["(.*?)"\]"#;
                                        let v1377: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1376);
                                        let v1378: &regex::Regex =
                                            &v1377.build().unwrap();
                                        let v1379: string =
                                            Supervisor::method2(v1374);
                                        let v1380: &str = &v1379.as_str();
                                        let v1381: string =
                                            Supervisor::method4();
                                        let v1382: &str = &v1381.as_str();
                                        let v1383: std::string::String =
                                            v1378.replace_all(&v1380, v1382).to_string();
                                        let v1384: string =
                                            fable_library_rust::String_::fromStr(&v1383);
                                        let v1386: &str = r#", "#;
                                        let v1387: regex::RegexBuilder =
                                            regex::RegexBuilder::new(&v1386);
                                        let v1388: &regex::Regex =
                                            &v1387.build().unwrap();
                                        let v1389: string =
                                            Supervisor::method2(v1384);
                                        let v1390: &str = &v1389.as_str();
                                        let v1391: string =
                                            Supervisor::method5();
                                        let v1392: &str = &v1391.as_str();
                                        let v1393: std::string::String =
                                            v1388.replace_all(&v1390, v1392).to_string();
                                        let v1394: string =
                                            fable_library_rust::String_::fromStr(&v1393);
                                        let v1396: std::string::String =
                                            (&v1394).to_string().clone();
                                        let v1397: string =
                                            substring2(v206.clone(), 0i32,
                                                       2i32);
                                        let v1398: u8 =
                                            u8::from_str_radix(&v1397, 16).unwrap();
                                        let v1399: string =
                                            substring2(v206.clone(), 2i32,
                                                       2i32);
                                        let v1400: u8 =
                                            u8::from_str_radix(&v1399, 16).unwrap();
                                        let v1401: string =
                                            substring2(v206.clone(), 4i32,
                                                       2i32);
                                        let v1402: u8 =
                                            u8::from_str_radix(&v1401, 16).unwrap();
                                        let v1403: colored::ColoredString =
                                            colored::Colorize::truecolor(&*v1396.to_string(), v1398, v1400, v1402);
                                        let v1404: std::string::String =
                                            format!("{}", &v1403);
                                        println!("{0}",
                                                 stringFrom(format!("{0} {1} {2}", &v1320, &v1362, &v1404)));
                                        {
                                            let patternInput_2:
                                                    (string, string, string,
                                                     bool) =
                                                Supervisor::method0();
                                            let v1410:
                                                    chrono::DateTime<chrono::Utc> =
                                                chrono::Utc::now();
                                            let v1411: i64 =
                                                (&v1410).timestamp();
                                            let v1412: string =
                                                string("host");
                                            let v1414: std::string::String =
                                                (&v1412).to_string().clone();
                                            let v1415: string =
                                                string("localhost");
                                            let v1417: std::string::String =
                                                (&v1415).to_string().clone();
                                            let v1418: string =
                                                string("port");
                                            let v1420: std::string::String =
                                                (&v1418).to_string().clone();
                                            let v1422: std::string::String =
                                                format!("{:?}", &13805i32).clone();
                                            let v1423: string =
                                                string("msg len");
                                            let v1425: std::string::String =
                                                (&v1423).to_string().clone();
                                            let v1426: i32 =
                                                (&v1245).len().try_into().unwrap();
                                            let v1429:
                                                    Array<std::string::String> =
                                                array(&[v1414, v1417, v1420,
                                                        v1422, v1425,
                                                        format!("{:?}", &v1426)]);
                                            let v1430 =
                                                core::ops::Deref::deref(&v1429);
                                            let v1432: std::string::String =
                                                format!("{:?}", ***v1430).clone();
                                            let v1433:
                                                    chrono::DateTime<chrono::Utc> =
                                                chrono::Utc::now();
                                            let v1438: string =
                                                Supervisor::method1(6i32,
                                                                    toString(&((&v1433).timestamp()
                                                                                   -
                                                                                   v1411)));
                                            let v1439: u8 =
                                                rand::random::<u8>();
                                            let v1452:
                                                    Array<std::string::String> =
                                                array(&[(&v52).to_string(),
                                                        (&v1438).to_string(),
                                                        (&v57).to_string(),
                                                        format!("{:?}", &v1439),
                                                        (&v63).to_string(),
                                                        (&v66).to_string()]);
                                            let v1453 =
                                                core::ops::Deref::deref(&v1452);
                                            let v1455: std::string::String =
                                                format!("{:?}", ***v1453).clone();
                                            let v1456: string =
                                                string("> zmq_request ()");
                                            let v1459:
                                                    Array<std::string::String> =
                                                array(&[(&v1456).to_string()]);
                                            let v1460 =
                                                core::ops::Deref::deref(&v1459);
                                            let v1463: std::string::String =
                                                format!("{:?}", ***v1460).clone();
                                            let v1464: string =
                                                fable_library_rust::String_::fromStr(&v1463);
                                            let v1466: &str =
                                                r#""([^"]+)", "([^"]+)""#;
                                            let v1467: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1466);
                                            let v1468: &regex::Regex =
                                                &v1467.build().unwrap();
                                            let v1469: string =
                                                Supervisor::method2(v1464);
                                            let v1470: &str = &v1469.as_str();
                                            let v1471: string =
                                                Supervisor::method3();
                                            let v1472: &str = &v1471.as_str();
                                            let v1473: std::string::String =
                                                v1468.replace_all(&v1470, v1472).to_string();
                                            let v1474: string =
                                                fable_library_rust::String_::fromStr(&v1473);
                                            let v1476: &str =
                                                r#"\["(.*?)"\]"#;
                                            let v1477: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1476);
                                            let v1478: &regex::Regex =
                                                &v1477.build().unwrap();
                                            let v1479: string =
                                                Supervisor::method2(v1474);
                                            let v1480: &str = &v1479.as_str();
                                            let v1481: string =
                                                Supervisor::method4();
                                            let v1482: &str = &v1481.as_str();
                                            let v1483: std::string::String =
                                                v1478.replace_all(&v1480, v1482).to_string();
                                            let v1484: string =
                                                fable_library_rust::String_::fromStr(&v1483);
                                            let v1486: &str = r#", "#;
                                            let v1487: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1486);
                                            let v1488: &regex::Regex =
                                                &v1487.build().unwrap();
                                            let v1489: string =
                                                Supervisor::method2(v1484);
                                            let v1490: &str = &v1489.as_str();
                                            let v1491: string =
                                                Supervisor::method5();
                                            let v1492: &str = &v1491.as_str();
                                            let v1493: std::string::String =
                                                v1488.replace_all(&v1490, v1492).to_string();
                                            let v1494: string =
                                                fable_library_rust::String_::fromStr(&v1493);
                                            let v1496: std::string::String =
                                                (&v1494).to_string().clone();
                                            let v1497:
                                                    colored::ColoredString =
                                                colored::Colorize::color(&*v1496, v122.clone().to_string());
                                            let v1498: std::string::String =
                                                format!("{}", &v1497);
                                            let v1500: string =
                                                fable_library_rust::String_::fromStr(&&v1432);
                                            let v1502: &str =
                                                r#""([^"]+)", "([^"]+)""#;
                                            let v1503: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1502);
                                            let v1504: &regex::Regex =
                                                &v1503.build().unwrap();
                                            let v1505: string =
                                                Supervisor::method2(v1500);
                                            let v1506: &str = &v1505.as_str();
                                            let v1507: string =
                                                Supervisor::method3();
                                            let v1508: &str = &v1507.as_str();
                                            let v1509: std::string::String =
                                                v1504.replace_all(&v1506, v1508).to_string();
                                            let v1510: string =
                                                fable_library_rust::String_::fromStr(&v1509);
                                            let v1512: &str =
                                                r#"\["(.*?)"\]"#;
                                            let v1513: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1512);
                                            let v1514: &regex::Regex =
                                                &v1513.build().unwrap();
                                            let v1515: string =
                                                Supervisor::method2(v1510);
                                            let v1516: &str = &v1515.as_str();
                                            let v1517: string =
                                                Supervisor::method4();
                                            let v1518: &str = &v1517.as_str();
                                            let v1519: std::string::String =
                                                v1514.replace_all(&v1516, v1518).to_string();
                                            let v1520: string =
                                                fable_library_rust::String_::fromStr(&v1519);
                                            let v1522: &str = r#", "#;
                                            let v1523: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1522);
                                            let v1524: &regex::Regex =
                                                &v1523.build().unwrap();
                                            let v1525: string =
                                                Supervisor::method2(v1520);
                                            let v1526: &str = &v1525.as_str();
                                            let v1527: string =
                                                Supervisor::method5();
                                            let v1528: &str = &v1527.as_str();
                                            let v1529: std::string::String =
                                                v1524.replace_all(&v1526, v1528).to_string();
                                            let v1530: string =
                                                fable_library_rust::String_::fromStr(&v1529);
                                            let v1532: std::string::String =
                                                (&v1530).to_string().clone();
                                            let v1533: string =
                                                string("fcfb1b");
                                            let v1534: string =
                                                substring2(v1533.clone(),
                                                           0i32, 2i32);
                                            let v1535: u8 =
                                                u8::from_str_radix(&v1534, 16).unwrap();
                                            let v1536: string =
                                                substring2(v1533.clone(),
                                                           2i32, 2i32);
                                            let v1537: u8 =
                                                u8::from_str_radix(&v1536, 16).unwrap();
                                            let v1538: string =
                                                substring2(v1533.clone(),
                                                           4i32, 2i32);
                                            let v1539: u8 =
                                                u8::from_str_radix(&v1538, 16).unwrap();
                                            let v1540:
                                                    colored::ColoredString =
                                                colored::Colorize::truecolor(&*v1532.to_string(), v1535, v1537, v1539);
                                            let v1541: std::string::String =
                                                format!("{}", &v1540);
                                            let v1543: string =
                                                fable_library_rust::String_::fromStr(&&v1455);
                                            let v1545: &str =
                                                r#""([^"]+)", "([^"]+)""#;
                                            let v1546: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1545);
                                            let v1547: &regex::Regex =
                                                &v1546.build().unwrap();
                                            let v1548: string =
                                                Supervisor::method2(v1543);
                                            let v1549: &str = &v1548.as_str();
                                            let v1550: string =
                                                Supervisor::method3();
                                            let v1551: &str = &v1550.as_str();
                                            let v1552: std::string::String =
                                                v1547.replace_all(&v1549, v1551).to_string();
                                            let v1553: string =
                                                fable_library_rust::String_::fromStr(&v1552);
                                            let v1555: &str =
                                                r#"\["(.*?)"\]"#;
                                            let v1556: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1555);
                                            let v1557: &regex::Regex =
                                                &v1556.build().unwrap();
                                            let v1558: string =
                                                Supervisor::method2(v1553);
                                            let v1559: &str = &v1558.as_str();
                                            let v1560: string =
                                                Supervisor::method4();
                                            let v1561: &str = &v1560.as_str();
                                            let v1562: std::string::String =
                                                v1557.replace_all(&v1559, v1561).to_string();
                                            let v1563: string =
                                                fable_library_rust::String_::fromStr(&v1562);
                                            let v1565: &str = r#", "#;
                                            let v1566: regex::RegexBuilder =
                                                regex::RegexBuilder::new(&v1565);
                                            let v1567: &regex::Regex =
                                                &v1566.build().unwrap();
                                            let v1568: string =
                                                Supervisor::method2(v1563);
                                            let v1569: &str = &v1568.as_str();
                                            let v1570: string =
                                                Supervisor::method5();
                                            let v1571: &str = &v1570.as_str();
                                            let v1572: std::string::String =
                                                v1567.replace_all(&v1569, v1571).to_string();
                                            let v1573: string =
                                                fable_library_rust::String_::fromStr(&v1572);
                                            let v1575: std::string::String =
                                                (&v1573).to_string().clone();
                                            let v1576: string =
                                                substring2(v206.clone(), 0i32,
                                                           2i32);
                                            let v1577: u8 =
                                                u8::from_str_radix(&v1576, 16).unwrap();
                                            let v1578: string =
                                                substring2(v206.clone(), 2i32,
                                                           2i32);
                                            let v1579: u8 =
                                                u8::from_str_radix(&v1578, 16).unwrap();
                                            let v1580: string =
                                                substring2(v206.clone(), 4i32,
                                                           2i32);
                                            let v1581: u8 =
                                                u8::from_str_radix(&v1580, 16).unwrap();
                                            let v1582:
                                                    colored::ColoredString =
                                                colored::Colorize::truecolor(&*v1575.to_string(), v1577, v1579, v1581);
                                            let v1583: std::string::String =
                                                format!("{}", &v1582);
                                            println!("{0}",
                                                     stringFrom(format!("{0} {1} {2}", &v1498, &v1541, &v1583)));
                                            {
                                                let v1586 =
                                                    zmq::Context::new();
                                                let v1588 =
                                                    v1586.socket(zmq::REQ).unwrap();
                                                let v1589: string =
                                                    stringFrom(format!("tcp://{0}:{1}",
                                                                       &v1415,
                                                                       &13805i32));
                                                v1588.connect(&v1589.clone()).unwrap();
                                                v1588.send(v1245.as_str(), 0).unwrap();
                                                {
                                                    let v1593:
                                                            std::string::String =
                                                        v1588.recv_string(0).unwrap().unwrap();
                                                    v1588.disconnect(&v1589).unwrap();
                                                    {
                                                        let v1595: string =
                                                            string("result len");
                                                        let v1597:
                                                                std::string::String =
                                                            (&v1595).to_string().clone();
                                                        let v1598: i32 =
                                                            (&v1593).len().try_into().unwrap();
                                                        let v1601:
                                                                Array<std::string::String> =
                                                            array(&[v1597,
                                                                    format!("{:?}", &v1598)]);
                                                        let v1602 =
                                                            core::ops::Deref::deref(&v1601);
                                                        let v1604:
                                                                std::string::String =
                                                            format!("{:?}", ***v1602).clone();
                                                        let v1605:
                                                                chrono::DateTime<chrono::Utc> =
                                                            chrono::Utc::now();
                                                        let v1610: string =
                                                            Supervisor::method1(6i32,
                                                                                toString(&((&v1605).timestamp()
                                                                                               -
                                                                                               v1411)));
                                                        let v1611: u8 =
                                                            rand::random::<u8>();
                                                        let v1624:
                                                                Array<std::string::String> =
                                                            array(&[(&v52).to_string(),
                                                                    (&v1610).to_string(),
                                                                    (&v57).to_string(),
                                                                    format!("{:?}", &v1611),
                                                                    (&v63).to_string(),
                                                                    (&v66).to_string()]);
                                                        let v1625 =
                                                            core::ops::Deref::deref(&v1624);
                                                        let v1627:
                                                                std::string::String =
                                                            format!("{:?}", ***v1625).clone();
                                                        let v1630:
                                                                Array<std::string::String> =
                                                            array(&[(&v1456).to_string()]);
                                                        let v1631 =
                                                            core::ops::Deref::deref(&v1630);
                                                        let v1634:
                                                                std::string::String =
                                                            format!("{:?}", ***v1631).clone();
                                                        let v1635: string =
                                                            fable_library_rust::String_::fromStr(&v1634);
                                                        let v1637: &str =
                                                            r#""([^"]+)", "([^"]+)""#;
                                                        let v1638:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1637);
                                                        let v1639:
                                                                &regex::Regex =
                                                            &v1638.build().unwrap();
                                                        let v1640: string =
                                                            Supervisor::method2(v1635);
                                                        let v1641: &str =
                                                            &v1640.as_str();
                                                        let v1642: string =
                                                            Supervisor::method3();
                                                        let v1643: &str =
                                                            &v1642.as_str();
                                                        let v1644:
                                                                std::string::String =
                                                            v1639.replace_all(&v1641, v1643).to_string();
                                                        let v1645: string =
                                                            fable_library_rust::String_::fromStr(&v1644);
                                                        let v1647: &str =
                                                            r#"\["(.*?)"\]"#;
                                                        let v1648:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1647);
                                                        let v1649:
                                                                &regex::Regex =
                                                            &v1648.build().unwrap();
                                                        let v1650: string =
                                                            Supervisor::method2(v1645);
                                                        let v1651: &str =
                                                            &v1650.as_str();
                                                        let v1652: string =
                                                            Supervisor::method4();
                                                        let v1653: &str =
                                                            &v1652.as_str();
                                                        let v1654:
                                                                std::string::String =
                                                            v1649.replace_all(&v1651, v1653).to_string();
                                                        let v1655: string =
                                                            fable_library_rust::String_::fromStr(&v1654);
                                                        let v1657: &str =
                                                            r#", "#;
                                                        let v1658:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1657);
                                                        let v1659:
                                                                &regex::Regex =
                                                            &v1658.build().unwrap();
                                                        let v1660: string =
                                                            Supervisor::method2(v1655);
                                                        let v1661: &str =
                                                            &v1660.as_str();
                                                        let v1662: string =
                                                            Supervisor::method5();
                                                        let v1663: &str =
                                                            &v1662.as_str();
                                                        let v1664:
                                                                std::string::String =
                                                            v1659.replace_all(&v1661, v1663).to_string();
                                                        let v1665: string =
                                                            fable_library_rust::String_::fromStr(&v1664);
                                                        let v1667:
                                                                std::string::String =
                                                            (&v1665).to_string().clone();
                                                        let v1668:
                                                                colored::ColoredString =
                                                            colored::Colorize::color(&*v1667, v122.clone().to_string());
                                                        let v1669:
                                                                std::string::String =
                                                            format!("{}", &v1668);
                                                        let v1671: string =
                                                            fable_library_rust::String_::fromStr(&&v1604);
                                                        let v1673: &str =
                                                            r#""([^"]+)", "([^"]+)""#;
                                                        let v1674:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1673);
                                                        let v1675:
                                                                &regex::Regex =
                                                            &v1674.build().unwrap();
                                                        let v1676: string =
                                                            Supervisor::method2(v1671);
                                                        let v1677: &str =
                                                            &v1676.as_str();
                                                        let v1678: string =
                                                            Supervisor::method3();
                                                        let v1679: &str =
                                                            &v1678.as_str();
                                                        let v1680:
                                                                std::string::String =
                                                            v1675.replace_all(&v1677, v1679).to_string();
                                                        let v1681: string =
                                                            fable_library_rust::String_::fromStr(&v1680);
                                                        let v1683: &str =
                                                            r#"\["(.*?)"\]"#;
                                                        let v1684:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1683);
                                                        let v1685:
                                                                &regex::Regex =
                                                            &v1684.build().unwrap();
                                                        let v1686: string =
                                                            Supervisor::method2(v1681);
                                                        let v1687: &str =
                                                            &v1686.as_str();
                                                        let v1688: string =
                                                            Supervisor::method4();
                                                        let v1689: &str =
                                                            &v1688.as_str();
                                                        let v1690:
                                                                std::string::String =
                                                            v1685.replace_all(&v1687, v1689).to_string();
                                                        let v1691: string =
                                                            fable_library_rust::String_::fromStr(&v1690);
                                                        let v1693: &str =
                                                            r#", "#;
                                                        let v1694:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1693);
                                                        let v1695:
                                                                &regex::Regex =
                                                            &v1694.build().unwrap();
                                                        let v1696: string =
                                                            Supervisor::method2(v1691);
                                                        let v1697: &str =
                                                            &v1696.as_str();
                                                        let v1698: string =
                                                            Supervisor::method5();
                                                        let v1699: &str =
                                                            &v1698.as_str();
                                                        let v1700:
                                                                std::string::String =
                                                            v1695.replace_all(&v1697, v1699).to_string();
                                                        let v1701: string =
                                                            fable_library_rust::String_::fromStr(&v1700);
                                                        let v1703:
                                                                std::string::String =
                                                            (&v1701).to_string().clone();
                                                        let v1704: string =
                                                            substring2(v1533.clone(),
                                                                       0i32,
                                                                       2i32);
                                                        let v1705: u8 =
                                                            u8::from_str_radix(&v1704, 16).unwrap();
                                                        let v1706: string =
                                                            substring2(v1533.clone(),
                                                                       2i32,
                                                                       2i32);
                                                        let v1707: u8 =
                                                            u8::from_str_radix(&v1706, 16).unwrap();
                                                        let v1708: string =
                                                            substring2(v1533.clone(),
                                                                       4i32,
                                                                       2i32);
                                                        let v1709: u8 =
                                                            u8::from_str_radix(&v1708, 16).unwrap();
                                                        let v1710:
                                                                colored::ColoredString =
                                                            colored::Colorize::truecolor(&*v1703.to_string(), v1705, v1707, v1709);
                                                        let v1711:
                                                                std::string::String =
                                                            format!("{}", &v1710);
                                                        let v1713: string =
                                                            fable_library_rust::String_::fromStr(&&v1627);
                                                        let v1715: &str =
                                                            r#""([^"]+)", "([^"]+)""#;
                                                        let v1716:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1715);
                                                        let v1717:
                                                                &regex::Regex =
                                                            &v1716.build().unwrap();
                                                        let v1718: string =
                                                            Supervisor::method2(v1713);
                                                        let v1719: &str =
                                                            &v1718.as_str();
                                                        let v1720: string =
                                                            Supervisor::method3();
                                                        let v1721: &str =
                                                            &v1720.as_str();
                                                        let v1722:
                                                                std::string::String =
                                                            v1717.replace_all(&v1719, v1721).to_string();
                                                        let v1723: string =
                                                            fable_library_rust::String_::fromStr(&v1722);
                                                        let v1725: &str =
                                                            r#"\["(.*?)"\]"#;
                                                        let v1726:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1725);
                                                        let v1727:
                                                                &regex::Regex =
                                                            &v1726.build().unwrap();
                                                        let v1728: string =
                                                            Supervisor::method2(v1723);
                                                        let v1729: &str =
                                                            &v1728.as_str();
                                                        let v1730: string =
                                                            Supervisor::method4();
                                                        let v1731: &str =
                                                            &v1730.as_str();
                                                        let v1732:
                                                                std::string::String =
                                                            v1727.replace_all(&v1729, v1731).to_string();
                                                        let v1733: string =
                                                            fable_library_rust::String_::fromStr(&v1732);
                                                        let v1735: &str =
                                                            r#", "#;
                                                        let v1736:
                                                                regex::RegexBuilder =
                                                            regex::RegexBuilder::new(&v1735);
                                                        let v1737:
                                                                &regex::Regex =
                                                            &v1736.build().unwrap();
                                                        let v1738: string =
                                                            Supervisor::method2(v1733);
                                                        let v1739: &str =
                                                            &v1738.as_str();
                                                        let v1740: string =
                                                            Supervisor::method5();
                                                        let v1741: &str =
                                                            &v1740.as_str();
                                                        let v1742:
                                                                std::string::String =
                                                            v1737.replace_all(&v1739, v1741).to_string();
                                                        let v1743: string =
                                                            fable_library_rust::String_::fromStr(&v1742);
                                                        let v1745:
                                                                std::string::String =
                                                            (&v1743).to_string().clone();
                                                        let v1746: string =
                                                            substring2(v206.clone(),
                                                                       0i32,
                                                                       2i32);
                                                        let v1747: u8 =
                                                            u8::from_str_radix(&v1746, 16).unwrap();
                                                        let v1748: string =
                                                            substring2(v206.clone(),
                                                                       2i32,
                                                                       2i32);
                                                        let v1749: u8 =
                                                            u8::from_str_radix(&v1748, 16).unwrap();
                                                        let v1750: string =
                                                            substring2(v206.clone(),
                                                                       4i32,
                                                                       2i32);
                                                        let v1751: u8 =
                                                            u8::from_str_radix(&v1750, 16).unwrap();
                                                        let v1752:
                                                                colored::ColoredString =
                                                            colored::Colorize::truecolor(&*v1745.to_string(), v1747, v1749, v1751);
                                                        let v1753:
                                                                std::string::String =
                                                            format!("{}", &v1752);
                                                        println!("{0}",
                                                                 stringFrom(format!("{0} {1} {2}", &v1669, &v1711, &v1753)));
                                                        {
                                                            let v1757:
                                                                    std::string::String =
                                                                (&string("> spiproj_open; ok")).to_string().clone();
                                                            let v1758:
                                                                    chrono::DateTime<chrono::Utc> =
                                                                chrono::Utc::now();
                                                            let v1763:
                                                                    string =
                                                                Supervisor::method1(6i32,
                                                                                    toString(&((&v1758).timestamp()
                                                                                                   -
                                                                                                   v9)));
                                                            let v1764: u8 =
                                                                rand::random::<u8>();
                                                            let v1777:
                                                                    Array<std::string::String> =
                                                                array(&[(&v52).to_string(),
                                                                        (&v1763).to_string(),
                                                                        (&v57).to_string(),
                                                                        format!("{:?}", &v1764),
                                                                        (&v63).to_string(),
                                                                        (&v66).to_string()]);
                                                            let v1778 =
                                                                core::ops::Deref::deref(&v1777);
                                                            let v1780:
                                                                    std::string::String =
                                                                format!("{:?}", ***v1778).clone();
                                                            let v1783:
                                                                    Array<std::string::String> =
                                                                array(&[(&v73).to_string()]);
                                                            let v1784 =
                                                                core::ops::Deref::deref(&v1783);
                                                            let v1787:
                                                                    std::string::String =
                                                                format!("{:?}", ***v1784).clone();
                                                            let v1788:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1787);
                                                            let v1790: &str =
                                                                r#""([^"]+)", "([^"]+)""#;
                                                            let v1791:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1790);
                                                            let v1792:
                                                                    &regex::Regex =
                                                                &v1791.build().unwrap();
                                                            let v1793:
                                                                    string =
                                                                Supervisor::method2(v1788);
                                                            let v1794: &str =
                                                                &v1793.as_str();
                                                            let v1795:
                                                                    string =
                                                                Supervisor::method3();
                                                            let v1796: &str =
                                                                &v1795.as_str();
                                                            let v1797:
                                                                    std::string::String =
                                                                v1792.replace_all(&v1794, v1796).to_string();
                                                            let v1798:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1797);
                                                            let v1800: &str =
                                                                r#"\["(.*?)"\]"#;
                                                            let v1801:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1800);
                                                            let v1802:
                                                                    &regex::Regex =
                                                                &v1801.build().unwrap();
                                                            let v1803:
                                                                    string =
                                                                Supervisor::method2(v1798);
                                                            let v1804: &str =
                                                                &v1803.as_str();
                                                            let v1805:
                                                                    string =
                                                                Supervisor::method4();
                                                            let v1806: &str =
                                                                &v1805.as_str();
                                                            let v1807:
                                                                    std::string::String =
                                                                v1802.replace_all(&v1804, v1806).to_string();
                                                            let v1808:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1807);
                                                            let v1810: &str =
                                                                r#", "#;
                                                            let v1811:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1810);
                                                            let v1812:
                                                                    &regex::Regex =
                                                                &v1811.build().unwrap();
                                                            let v1813:
                                                                    string =
                                                                Supervisor::method2(v1808);
                                                            let v1814: &str =
                                                                &v1813.as_str();
                                                            let v1815:
                                                                    string =
                                                                Supervisor::method5();
                                                            let v1816: &str =
                                                                &v1815.as_str();
                                                            let v1817:
                                                                    std::string::String =
                                                                v1812.replace_all(&v1814, v1816).to_string();
                                                            let v1818:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1817);
                                                            let v1820:
                                                                    std::string::String =
                                                                (&v1818).to_string().clone();
                                                            let v1821:
                                                                    colored::ColoredString =
                                                                colored::Colorize::color(&*v1820, v122.clone().to_string());
                                                            let v1822:
                                                                    std::string::String =
                                                                format!("{}", &v1821);
                                                            let v1824:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&&v1757);
                                                            let v1826: &str =
                                                                r#""([^"]+)", "([^"]+)""#;
                                                            let v1827:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1826);
                                                            let v1828:
                                                                    &regex::Regex =
                                                                &v1827.build().unwrap();
                                                            let v1829:
                                                                    string =
                                                                Supervisor::method2(v1824);
                                                            let v1830: &str =
                                                                &v1829.as_str();
                                                            let v1831:
                                                                    string =
                                                                Supervisor::method3();
                                                            let v1832: &str =
                                                                &v1831.as_str();
                                                            let v1833:
                                                                    std::string::String =
                                                                v1828.replace_all(&v1830, v1832).to_string();
                                                            let v1834:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1833);
                                                            let v1836: &str =
                                                                r#"\["(.*?)"\]"#;
                                                            let v1837:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1836);
                                                            let v1838:
                                                                    &regex::Regex =
                                                                &v1837.build().unwrap();
                                                            let v1839:
                                                                    string =
                                                                Supervisor::method2(v1834);
                                                            let v1840: &str =
                                                                &v1839.as_str();
                                                            let v1841:
                                                                    string =
                                                                Supervisor::method4();
                                                            let v1842: &str =
                                                                &v1841.as_str();
                                                            let v1843:
                                                                    std::string::String =
                                                                v1838.replace_all(&v1840, v1842).to_string();
                                                            let v1844:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1843);
                                                            let v1846: &str =
                                                                r#", "#;
                                                            let v1847:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1846);
                                                            let v1848:
                                                                    &regex::Regex =
                                                                &v1847.build().unwrap();
                                                            let v1849:
                                                                    string =
                                                                Supervisor::method2(v1844);
                                                            let v1850: &str =
                                                                &v1849.as_str();
                                                            let v1851:
                                                                    string =
                                                                Supervisor::method5();
                                                            let v1852: &str =
                                                                &v1851.as_str();
                                                            let v1853:
                                                                    std::string::String =
                                                                v1848.replace_all(&v1850, v1852).to_string();
                                                            let v1854:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1853);
                                                            let v1856:
                                                                    std::string::String =
                                                                (&v1854).to_string().clone();
                                                            let v1857:
                                                                    string =
                                                                substring2(v161.clone(),
                                                                           0i32,
                                                                           2i32);
                                                            let v1858: u8 =
                                                                u8::from_str_radix(&v1857, 16).unwrap();
                                                            let v1859:
                                                                    string =
                                                                substring2(v161.clone(),
                                                                           2i32,
                                                                           2i32);
                                                            let v1860: u8 =
                                                                u8::from_str_radix(&v1859, 16).unwrap();
                                                            let v1861:
                                                                    string =
                                                                substring2(v161.clone(),
                                                                           4i32,
                                                                           2i32);
                                                            let v1862: u8 =
                                                                u8::from_str_radix(&v1861, 16).unwrap();
                                                            let v1863:
                                                                    colored::ColoredString =
                                                                colored::Colorize::truecolor(&*v1856.to_string(), v1858, v1860, v1862);
                                                            let v1864:
                                                                    std::string::String =
                                                                format!("{}", &v1863);
                                                            let v1866:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&&v1780);
                                                            let v1868: &str =
                                                                r#""([^"]+)", "([^"]+)""#;
                                                            let v1869:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1868);
                                                            let v1870:
                                                                    &regex::Regex =
                                                                &v1869.build().unwrap();
                                                            let v1871:
                                                                    string =
                                                                Supervisor::method2(v1866);
                                                            let v1872: &str =
                                                                &v1871.as_str();
                                                            let v1873:
                                                                    string =
                                                                Supervisor::method3();
                                                            let v1874: &str =
                                                                &v1873.as_str();
                                                            let v1875:
                                                                    std::string::String =
                                                                v1870.replace_all(&v1872, v1874).to_string();
                                                            let v1876:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1875);
                                                            let v1878: &str =
                                                                r#"\["(.*?)"\]"#;
                                                            let v1879:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1878);
                                                            let v1880:
                                                                    &regex::Regex =
                                                                &v1879.build().unwrap();
                                                            let v1881:
                                                                    string =
                                                                Supervisor::method2(v1876);
                                                            let v1882: &str =
                                                                &v1881.as_str();
                                                            let v1883:
                                                                    string =
                                                                Supervisor::method4();
                                                            let v1884: &str =
                                                                &v1883.as_str();
                                                            let v1885:
                                                                    std::string::String =
                                                                v1880.replace_all(&v1882, v1884).to_string();
                                                            let v1886:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1885);
                                                            let v1888: &str =
                                                                r#", "#;
                                                            let v1889:
                                                                    regex::RegexBuilder =
                                                                regex::RegexBuilder::new(&v1888);
                                                            let v1890:
                                                                    &regex::Regex =
                                                                &v1889.build().unwrap();
                                                            let v1891:
                                                                    string =
                                                                Supervisor::method2(v1886);
                                                            let v1892: &str =
                                                                &v1891.as_str();
                                                            let v1893:
                                                                    string =
                                                                Supervisor::method5();
                                                            let v1894: &str =
                                                                &v1893.as_str();
                                                            let v1895:
                                                                    std::string::String =
                                                                v1890.replace_all(&v1892, v1894).to_string();
                                                            let v1896:
                                                                    string =
                                                                fable_library_rust::String_::fromStr(&v1895);
                                                            let v1898:
                                                                    std::string::String =
                                                                (&v1896).to_string().clone();
                                                            let v1899:
                                                                    string =
                                                                substring2(v206.clone(),
                                                                           0i32,
                                                                           2i32);
                                                            let v1900: u8 =
                                                                u8::from_str_radix(&v1899, 16).unwrap();
                                                            let v1901:
                                                                    string =
                                                                substring2(v206.clone(),
                                                                           2i32,
                                                                           2i32);
                                                            let v1902: u8 =
                                                                u8::from_str_radix(&v1901, 16).unwrap();
                                                            let v1903:
                                                                    string =
                                                                substring2(v206.clone(),
                                                                           4i32,
                                                                           2i32);
                                                            let v1904: u8 =
                                                                u8::from_str_radix(&v1903, 16).unwrap();
                                                            let v1905:
                                                                    colored::ColoredString =
                                                                colored::Colorize::truecolor(&*v1898.to_string(), v1900, v1902, v1904);
                                                            let v1906:
                                                                    std::string::String =
                                                                format!("{}", &v1905);
                                                            println!("{0}",
                                                                     stringFrom(format!("{0} {1} {2}", &v1822, &v1864, &v1906)));
                                                            {
                                                                let patternInput_3:
                                                                        (string,
                                                                         string,
                                                                         string,
                                                                         bool) =
                                                                    Supervisor::method0();
                                                                let v1912:
                                                                        chrono::DateTime<chrono::Utc> =
                                                                    chrono::Utc::now();
                                                                let v1913:
                                                                        i64 =
                                                                    (&v1912).timestamp();
                                                                let v1915:
                                                                        std::string::String =
                                                                    (&v25).to_string().clone();
                                                                let v1916:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&format!("{}", &v217.display()));
                                                                let v1922:
                                                                        string =
                                                                    string("Fsharp");
                                                                let v1925:
                                                                        Array<std::string::String> =
                                                                    array(&[v1915,
                                                                            (&v1916).to_string(),
                                                                            (&string("backend")).to_string(),
                                                                            (&v1922).to_string()]);
                                                                let v1926 =
                                                                    core::ops::Deref::deref(&v1925);
                                                                let v1928:
                                                                        std::string::String =
                                                                    format!("{:?}", ***v1926).clone();
                                                                let v1929:
                                                                        chrono::DateTime<chrono::Utc> =
                                                                    chrono::Utc::now();
                                                                let v1934:
                                                                        string =
                                                                    Supervisor::method1(6i32,
                                                                                        toString(&((&v1929).timestamp()
                                                                                                       -
                                                                                                       v1913)));
                                                                let v1935:
                                                                        u8 =
                                                                    rand::random::<u8>();
                                                                let v1948:
                                                                        Array<std::string::String> =
                                                                    array(&[(&v52).to_string(),
                                                                            (&v1934).to_string(),
                                                                            (&v57).to_string(),
                                                                            format!("{:?}", &v1935),
                                                                            (&v63).to_string(),
                                                                            (&v66).to_string()]);
                                                                let v1949 =
                                                                    core::ops::Deref::deref(&v1948);
                                                                let v1951:
                                                                        std::string::String =
                                                                    format!("{:?}", ***v1949).clone();
                                                                let v1952:
                                                                        string =
                                                                    string("> spi_build_file ()");
                                                                let v1955:
                                                                        Array<std::string::String> =
                                                                    array(&[(&v1952).to_string()]);
                                                                let v1956 =
                                                                    core::ops::Deref::deref(&v1955);
                                                                let v1959:
                                                                        std::string::String =
                                                                    format!("{:?}", ***v1956).clone();
                                                                let v1960:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v1959);
                                                                let v1962:
                                                                        &str =
                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                let v1963:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v1962);
                                                                let v1964:
                                                                        &regex::Regex =
                                                                    &v1963.build().unwrap();
                                                                let v1965:
                                                                        string =
                                                                    Supervisor::method2(v1960);
                                                                let v1966:
                                                                        &str =
                                                                    &v1965.as_str();
                                                                let v1967:
                                                                        string =
                                                                    Supervisor::method3();
                                                                let v1968:
                                                                        &str =
                                                                    &v1967.as_str();
                                                                let v1969:
                                                                        std::string::String =
                                                                    v1964.replace_all(&v1966, v1968).to_string();
                                                                let v1970:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v1969);
                                                                let v1972:
                                                                        &str =
                                                                    r#"\["(.*?)"\]"#;
                                                                let v1973:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v1972);
                                                                let v1974:
                                                                        &regex::Regex =
                                                                    &v1973.build().unwrap();
                                                                let v1975:
                                                                        string =
                                                                    Supervisor::method2(v1970);
                                                                let v1976:
                                                                        &str =
                                                                    &v1975.as_str();
                                                                let v1977:
                                                                        string =
                                                                    Supervisor::method4();
                                                                let v1978:
                                                                        &str =
                                                                    &v1977.as_str();
                                                                let v1979:
                                                                        std::string::String =
                                                                    v1974.replace_all(&v1976, v1978).to_string();
                                                                let v1980:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v1979);
                                                                let v1982:
                                                                        &str =
                                                                    r#", "#;
                                                                let v1983:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v1982);
                                                                let v1984:
                                                                        &regex::Regex =
                                                                    &v1983.build().unwrap();
                                                                let v1985:
                                                                        string =
                                                                    Supervisor::method2(v1980);
                                                                let v1986:
                                                                        &str =
                                                                    &v1985.as_str();
                                                                let v1987:
                                                                        string =
                                                                    Supervisor::method5();
                                                                let v1988:
                                                                        &str =
                                                                    &v1987.as_str();
                                                                let v1989:
                                                                        std::string::String =
                                                                    v1984.replace_all(&v1986, v1988).to_string();
                                                                let v1990:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v1989);
                                                                let v1992:
                                                                        std::string::String =
                                                                    (&v1990).to_string().clone();
                                                                let v1993:
                                                                        colored::ColoredString =
                                                                    colored::Colorize::color(&*v1992, v122.clone().to_string());
                                                                let v1994:
                                                                        std::string::String =
                                                                    format!("{}", &v1993);
                                                                let v1996:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&&v1928);
                                                                let v1998:
                                                                        &str =
                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                let v1999:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v1998);
                                                                let v2000:
                                                                        &regex::Regex =
                                                                    &v1999.build().unwrap();
                                                                let v2001:
                                                                        string =
                                                                    Supervisor::method2(v1996);
                                                                let v2002:
                                                                        &str =
                                                                    &v2001.as_str();
                                                                let v2003:
                                                                        string =
                                                                    Supervisor::method3();
                                                                let v2004:
                                                                        &str =
                                                                    &v2003.as_str();
                                                                let v2005:
                                                                        std::string::String =
                                                                    v2000.replace_all(&v2002, v2004).to_string();
                                                                let v2006:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2005);
                                                                let v2008:
                                                                        &str =
                                                                    r#"\["(.*?)"\]"#;
                                                                let v2009:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2008);
                                                                let v2010:
                                                                        &regex::Regex =
                                                                    &v2009.build().unwrap();
                                                                let v2011:
                                                                        string =
                                                                    Supervisor::method2(v2006);
                                                                let v2012:
                                                                        &str =
                                                                    &v2011.as_str();
                                                                let v2013:
                                                                        string =
                                                                    Supervisor::method4();
                                                                let v2014:
                                                                        &str =
                                                                    &v2013.as_str();
                                                                let v2015:
                                                                        std::string::String =
                                                                    v2010.replace_all(&v2012, v2014).to_string();
                                                                let v2016:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2015);
                                                                let v2018:
                                                                        &str =
                                                                    r#", "#;
                                                                let v2019:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2018);
                                                                let v2020:
                                                                        &regex::Regex =
                                                                    &v2019.build().unwrap();
                                                                let v2021:
                                                                        string =
                                                                    Supervisor::method2(v2016);
                                                                let v2022:
                                                                        &str =
                                                                    &v2021.as_str();
                                                                let v2023:
                                                                        string =
                                                                    Supervisor::method5();
                                                                let v2024:
                                                                        &str =
                                                                    &v2023.as_str();
                                                                let v2025:
                                                                        std::string::String =
                                                                    v2020.replace_all(&v2022, v2024).to_string();
                                                                let v2026:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2025);
                                                                let v2028:
                                                                        std::string::String =
                                                                    (&v2026).to_string().clone();
                                                                let v2029:
                                                                        string =
                                                                    string("98d5ef");
                                                                let v2030:
                                                                        string =
                                                                    substring2(v2029.clone(),
                                                                               0i32,
                                                                               2i32);
                                                                let v2031:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2030, 16).unwrap();
                                                                let v2032:
                                                                        string =
                                                                    substring2(v2029.clone(),
                                                                               2i32,
                                                                               2i32);
                                                                let v2033:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2032, 16).unwrap();
                                                                let v2034:
                                                                        string =
                                                                    substring2(v2029.clone(),
                                                                               4i32,
                                                                               2i32);
                                                                let v2035:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2034, 16).unwrap();
                                                                let v2036:
                                                                        colored::ColoredString =
                                                                    colored::Colorize::truecolor(&*v2028.to_string(), v2031, v2033, v2035);
                                                                let v2037:
                                                                        std::string::String =
                                                                    format!("{}", &v2036);
                                                                let v2039:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&&v1951);
                                                                let v2041:
                                                                        &str =
                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                let v2042:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2041);
                                                                let v2043:
                                                                        &regex::Regex =
                                                                    &v2042.build().unwrap();
                                                                let v2044:
                                                                        string =
                                                                    Supervisor::method2(v2039);
                                                                let v2045:
                                                                        &str =
                                                                    &v2044.as_str();
                                                                let v2046:
                                                                        string =
                                                                    Supervisor::method3();
                                                                let v2047:
                                                                        &str =
                                                                    &v2046.as_str();
                                                                let v2048:
                                                                        std::string::String =
                                                                    v2043.replace_all(&v2045, v2047).to_string();
                                                                let v2049:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2048);
                                                                let v2051:
                                                                        &str =
                                                                    r#"\["(.*?)"\]"#;
                                                                let v2052:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2051);
                                                                let v2053:
                                                                        &regex::Regex =
                                                                    &v2052.build().unwrap();
                                                                let v2054:
                                                                        string =
                                                                    Supervisor::method2(v2049);
                                                                let v2055:
                                                                        &str =
                                                                    &v2054.as_str();
                                                                let v2056:
                                                                        string =
                                                                    Supervisor::method4();
                                                                let v2057:
                                                                        &str =
                                                                    &v2056.as_str();
                                                                let v2058:
                                                                        std::string::String =
                                                                    v2053.replace_all(&v2055, v2057).to_string();
                                                                let v2059:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2058);
                                                                let v2061:
                                                                        &str =
                                                                    r#", "#;
                                                                let v2062:
                                                                        regex::RegexBuilder =
                                                                    regex::RegexBuilder::new(&v2061);
                                                                let v2063:
                                                                        &regex::Regex =
                                                                    &v2062.build().unwrap();
                                                                let v2064:
                                                                        string =
                                                                    Supervisor::method2(v2059);
                                                                let v2065:
                                                                        &str =
                                                                    &v2064.as_str();
                                                                let v2066:
                                                                        string =
                                                                    Supervisor::method5();
                                                                let v2067:
                                                                        &str =
                                                                    &v2066.as_str();
                                                                let v2068:
                                                                        std::string::String =
                                                                    v2063.replace_all(&v2065, v2067).to_string();
                                                                let v2069:
                                                                        string =
                                                                    fable_library_rust::String_::fromStr(&v2068);
                                                                let v2071:
                                                                        std::string::String =
                                                                    (&v2069).to_string().clone();
                                                                let v2072:
                                                                        string =
                                                                    substring2(v206.clone(),
                                                                               0i32,
                                                                               2i32);
                                                                let v2073:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2072, 16).unwrap();
                                                                let v2074:
                                                                        string =
                                                                    substring2(v206.clone(),
                                                                               2i32,
                                                                               2i32);
                                                                let v2075:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2074, 16).unwrap();
                                                                let v2076:
                                                                        string =
                                                                    substring2(v206.clone(),
                                                                               4i32,
                                                                               2i32);
                                                                let v2077:
                                                                        u8 =
                                                                    u8::from_str_radix(&v2076, 16).unwrap();
                                                                let v2078:
                                                                        colored::ColoredString =
                                                                    colored::Colorize::truecolor(&*v2071.to_string(), v2073, v2075, v2077);
                                                                let v2079:
                                                                        std::string::String =
                                                                    format!("{}", &v2078);
                                                                println!("{0}",
                                                                         stringFrom(format!("{0} {1} {2}", &v1994, &v2037, &v2079)));
                                                                {
                                                                    let v2081:
                                                                            std::string::String =
                                                                        (&v1922).to_string();
                                                                    let v2090:
                                                                            string =
                                                                        append(append(v1241,
                                                                                      append(append(append(append(append(v1231,
                                                                                                                         string("\"BuildFile\": {")),
                                                                                                                  v1234),
                                                                                                           string("\"backend\": $1")),
                                                                                                    v1238.clone()),
                                                                                             v1238)),
                                                                               v1243);
                                                                    let v2091:
                                                                            std::string::String =
                                                                        serde_json::json!({"BuildFile": {"uri": v217,"backend": v2081}}).to_string();
                                                                    let v2094:
                                                                            std::string::String =
                                                                        (&string("json len")).to_string().clone();
                                                                    let v2095:
                                                                            i32 =
                                                                        (&v2091).len().try_into().unwrap();
                                                                    let v2098:
                                                                            Array<std::string::String> =
                                                                        array(&[v2094,
                                                                                format!("{:?}", &v2095)]);
                                                                    let v2099 =
                                                                        core::ops::Deref::deref(&v2098);
                                                                    let v2101:
                                                                            std::string::String =
                                                                        format!("{:?}", ***v2099).clone();
                                                                    let v2102:
                                                                            chrono::DateTime<chrono::Utc> =
                                                                        chrono::Utc::now();
                                                                    let v2107:
                                                                            string =
                                                                        Supervisor::method1(6i32,
                                                                                            toString(&((&v2102).timestamp()
                                                                                                           -
                                                                                                           v1913)));
                                                                    let v2108:
                                                                            u8 =
                                                                        rand::random::<u8>();
                                                                    let v2121:
                                                                            Array<std::string::String> =
                                                                        array(&[(&v52).to_string(),
                                                                                (&v2107).to_string(),
                                                                                (&v57).to_string(),
                                                                                format!("{:?}", &v2108),
                                                                                (&v63).to_string(),
                                                                                (&v66).to_string()]);
                                                                    let v2122 =
                                                                        core::ops::Deref::deref(&v2121);
                                                                    let v2124:
                                                                            std::string::String =
                                                                        format!("{:?}", ***v2122).clone();
                                                                    let v2127:
                                                                            Array<std::string::String> =
                                                                        array(&[(&v1952).to_string()]);
                                                                    let v2128 =
                                                                        core::ops::Deref::deref(&v2127);
                                                                    let v2131:
                                                                            std::string::String =
                                                                        format!("{:?}", ***v2128).clone();
                                                                    let v2132:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2131);
                                                                    let v2134:
                                                                            &str =
                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                    let v2135:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2134);
                                                                    let v2136:
                                                                            &regex::Regex =
                                                                        &v2135.build().unwrap();
                                                                    let v2137:
                                                                            string =
                                                                        Supervisor::method2(v2132);
                                                                    let v2138:
                                                                            &str =
                                                                        &v2137.as_str();
                                                                    let v2139:
                                                                            string =
                                                                        Supervisor::method3();
                                                                    let v2140:
                                                                            &str =
                                                                        &v2139.as_str();
                                                                    let v2141:
                                                                            std::string::String =
                                                                        v2136.replace_all(&v2138, v2140).to_string();
                                                                    let v2142:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2141);
                                                                    let v2144:
                                                                            &str =
                                                                        r#"\["(.*?)"\]"#;
                                                                    let v2145:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2144);
                                                                    let v2146:
                                                                            &regex::Regex =
                                                                        &v2145.build().unwrap();
                                                                    let v2147:
                                                                            string =
                                                                        Supervisor::method2(v2142);
                                                                    let v2148:
                                                                            &str =
                                                                        &v2147.as_str();
                                                                    let v2149:
                                                                            string =
                                                                        Supervisor::method4();
                                                                    let v2150:
                                                                            &str =
                                                                        &v2149.as_str();
                                                                    let v2151:
                                                                            std::string::String =
                                                                        v2146.replace_all(&v2148, v2150).to_string();
                                                                    let v2152:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2151);
                                                                    let v2154:
                                                                            &str =
                                                                        r#", "#;
                                                                    let v2155:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2154);
                                                                    let v2156:
                                                                            &regex::Regex =
                                                                        &v2155.build().unwrap();
                                                                    let v2157:
                                                                            string =
                                                                        Supervisor::method2(v2152);
                                                                    let v2158:
                                                                            &str =
                                                                        &v2157.as_str();
                                                                    let v2159:
                                                                            string =
                                                                        Supervisor::method5();
                                                                    let v2160:
                                                                            &str =
                                                                        &v2159.as_str();
                                                                    let v2161:
                                                                            std::string::String =
                                                                        v2156.replace_all(&v2158, v2160).to_string();
                                                                    let v2162:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2161);
                                                                    let v2164:
                                                                            std::string::String =
                                                                        (&v2162).to_string().clone();
                                                                    let v2165:
                                                                            colored::ColoredString =
                                                                        colored::Colorize::color(&*v2164, v122.clone().to_string());
                                                                    let v2166:
                                                                            std::string::String =
                                                                        format!("{}", &v2165);
                                                                    let v2168:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&&v2101);
                                                                    let v2170:
                                                                            &str =
                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                    let v2171:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2170);
                                                                    let v2172:
                                                                            &regex::Regex =
                                                                        &v2171.build().unwrap();
                                                                    let v2173:
                                                                            string =
                                                                        Supervisor::method2(v2168);
                                                                    let v2174:
                                                                            &str =
                                                                        &v2173.as_str();
                                                                    let v2175:
                                                                            string =
                                                                        Supervisor::method3();
                                                                    let v2176:
                                                                            &str =
                                                                        &v2175.as_str();
                                                                    let v2177:
                                                                            std::string::String =
                                                                        v2172.replace_all(&v2174, v2176).to_string();
                                                                    let v2178:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2177);
                                                                    let v2180:
                                                                            &str =
                                                                        r#"\["(.*?)"\]"#;
                                                                    let v2181:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2180);
                                                                    let v2182:
                                                                            &regex::Regex =
                                                                        &v2181.build().unwrap();
                                                                    let v2183:
                                                                            string =
                                                                        Supervisor::method2(v2178);
                                                                    let v2184:
                                                                            &str =
                                                                        &v2183.as_str();
                                                                    let v2185:
                                                                            string =
                                                                        Supervisor::method4();
                                                                    let v2186:
                                                                            &str =
                                                                        &v2185.as_str();
                                                                    let v2187:
                                                                            std::string::String =
                                                                        v2182.replace_all(&v2184, v2186).to_string();
                                                                    let v2188:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2187);
                                                                    let v2190:
                                                                            &str =
                                                                        r#", "#;
                                                                    let v2191:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2190);
                                                                    let v2192:
                                                                            &regex::Regex =
                                                                        &v2191.build().unwrap();
                                                                    let v2193:
                                                                            string =
                                                                        Supervisor::method2(v2188);
                                                                    let v2194:
                                                                            &str =
                                                                        &v2193.as_str();
                                                                    let v2195:
                                                                            string =
                                                                        Supervisor::method5();
                                                                    let v2196:
                                                                            &str =
                                                                        &v2195.as_str();
                                                                    let v2197:
                                                                            std::string::String =
                                                                        v2192.replace_all(&v2194, v2196).to_string();
                                                                    let v2198:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2197);
                                                                    let v2200:
                                                                            std::string::String =
                                                                        (&v2198).to_string().clone();
                                                                    let v2201:
                                                                            string =
                                                                        substring2(v2029.clone(),
                                                                                   0i32,
                                                                                   2i32);
                                                                    let v2202:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2201, 16).unwrap();
                                                                    let v2203:
                                                                            string =
                                                                        substring2(v2029.clone(),
                                                                                   2i32,
                                                                                   2i32);
                                                                    let v2204:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2203, 16).unwrap();
                                                                    let v2205:
                                                                            string =
                                                                        substring2(v2029,
                                                                                   4i32,
                                                                                   2i32);
                                                                    let v2206:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2205, 16).unwrap();
                                                                    let v2207:
                                                                            colored::ColoredString =
                                                                        colored::Colorize::truecolor(&*v2200.to_string(), v2202, v2204, v2206);
                                                                    let v2208:
                                                                            std::string::String =
                                                                        format!("{}", &v2207);
                                                                    let v2210:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&&v2124);
                                                                    let v2212:
                                                                            &str =
                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                    let v2213:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2212);
                                                                    let v2214:
                                                                            &regex::Regex =
                                                                        &v2213.build().unwrap();
                                                                    let v2215:
                                                                            string =
                                                                        Supervisor::method2(v2210);
                                                                    let v2216:
                                                                            &str =
                                                                        &v2215.as_str();
                                                                    let v2217:
                                                                            string =
                                                                        Supervisor::method3();
                                                                    let v2218:
                                                                            &str =
                                                                        &v2217.as_str();
                                                                    let v2219:
                                                                            std::string::String =
                                                                        v2214.replace_all(&v2216, v2218).to_string();
                                                                    let v2220:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2219);
                                                                    let v2222:
                                                                            &str =
                                                                        r#"\["(.*?)"\]"#;
                                                                    let v2223:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2222);
                                                                    let v2224:
                                                                            &regex::Regex =
                                                                        &v2223.build().unwrap();
                                                                    let v2225:
                                                                            string =
                                                                        Supervisor::method2(v2220);
                                                                    let v2226:
                                                                            &str =
                                                                        &v2225.as_str();
                                                                    let v2227:
                                                                            string =
                                                                        Supervisor::method4();
                                                                    let v2228:
                                                                            &str =
                                                                        &v2227.as_str();
                                                                    let v2229:
                                                                            std::string::String =
                                                                        v2224.replace_all(&v2226, v2228).to_string();
                                                                    let v2230:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2229);
                                                                    let v2232:
                                                                            &str =
                                                                        r#", "#;
                                                                    let v2233:
                                                                            regex::RegexBuilder =
                                                                        regex::RegexBuilder::new(&v2232);
                                                                    let v2234:
                                                                            &regex::Regex =
                                                                        &v2233.build().unwrap();
                                                                    let v2235:
                                                                            string =
                                                                        Supervisor::method2(v2230);
                                                                    let v2236:
                                                                            &str =
                                                                        &v2235.as_str();
                                                                    let v2237:
                                                                            string =
                                                                        Supervisor::method5();
                                                                    let v2238:
                                                                            &str =
                                                                        &v2237.as_str();
                                                                    let v2239:
                                                                            std::string::String =
                                                                        v2234.replace_all(&v2236, v2238).to_string();
                                                                    let v2240:
                                                                            string =
                                                                        fable_library_rust::String_::fromStr(&v2239);
                                                                    let v2242:
                                                                            std::string::String =
                                                                        (&v2240).to_string().clone();
                                                                    let v2243:
                                                                            string =
                                                                        substring2(v206.clone(),
                                                                                   0i32,
                                                                                   2i32);
                                                                    let v2244:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2243, 16).unwrap();
                                                                    let v2245:
                                                                            string =
                                                                        substring2(v206.clone(),
                                                                                   2i32,
                                                                                   2i32);
                                                                    let v2246:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2245, 16).unwrap();
                                                                    let v2247:
                                                                            string =
                                                                        substring2(v206.clone(),
                                                                                   4i32,
                                                                                   2i32);
                                                                    let v2248:
                                                                            u8 =
                                                                        u8::from_str_radix(&v2247, 16).unwrap();
                                                                    let v2249:
                                                                            colored::ColoredString =
                                                                        colored::Colorize::truecolor(&*v2242.to_string(), v2244, v2246, v2248);
                                                                    let v2250:
                                                                            std::string::String =
                                                                        format!("{}", &v2249);
                                                                    println!("{0}",
                                                                             stringFrom(format!("{0} {1} {2}", &v2166, &v2208, &v2250)));
                                                                    {
                                                                        let patternInput_4:
                                                                                (string,
                                                                                 string,
                                                                                 string,
                                                                                 bool) =
                                                                            Supervisor::method0();
                                                                        let v2256:
                                                                                chrono::DateTime<chrono::Utc> =
                                                                            chrono::Utc::now();
                                                                        let v2257:
                                                                                i64 =
                                                                            (&v2256).timestamp();
                                                                        let v2259:
                                                                                std::string::String =
                                                                            (&v1412).to_string().clone();
                                                                        let v2261:
                                                                                std::string::String =
                                                                            (&v1415).to_string().clone();
                                                                        let v2263:
                                                                                std::string::String =
                                                                            (&v1418).to_string().clone();
                                                                        let v2265:
                                                                                std::string::String =
                                                                            format!("{:?}", &13805i32).clone();
                                                                        let v2267:
                                                                                std::string::String =
                                                                            (&v1423).to_string().clone();
                                                                        let v2268:
                                                                                i32 =
                                                                            (&v2091).len().try_into().unwrap();
                                                                        let v2271:
                                                                                Array<std::string::String> =
                                                                            array(&[v2259,
                                                                                    v2261,
                                                                                    v2263,
                                                                                    v2265,
                                                                                    v2267,
                                                                                    format!("{:?}", &v2268)]);
                                                                        let v2272 =
                                                                            core::ops::Deref::deref(&v2271);
                                                                        let v2274:
                                                                                std::string::String =
                                                                            format!("{:?}", ***v2272).clone();
                                                                        let v2275:
                                                                                chrono::DateTime<chrono::Utc> =
                                                                            chrono::Utc::now();
                                                                        let v2280:
                                                                                string =
                                                                            Supervisor::method1(6i32,
                                                                                                toString(&((&v2275).timestamp()
                                                                                                               -
                                                                                                               v2257)));
                                                                        let v2281:
                                                                                u8 =
                                                                            rand::random::<u8>();
                                                                        let v2294:
                                                                                Array<std::string::String> =
                                                                            array(&[(&v52).to_string(),
                                                                                    (&v2280).to_string(),
                                                                                    (&v57).to_string(),
                                                                                    format!("{:?}", &v2281),
                                                                                    (&v63).to_string(),
                                                                                    (&v66).to_string()]);
                                                                        let v2295 =
                                                                            core::ops::Deref::deref(&v2294);
                                                                        let v2297:
                                                                                std::string::String =
                                                                            format!("{:?}", ***v2295).clone();
                                                                        let v2300:
                                                                                Array<std::string::String> =
                                                                            array(&[(&v1456).to_string()]);
                                                                        let v2301 =
                                                                            core::ops::Deref::deref(&v2300);
                                                                        let v2304:
                                                                                std::string::String =
                                                                            format!("{:?}", ***v2301).clone();
                                                                        let v2305:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2304);
                                                                        let v2307:
                                                                                &str =
                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                        let v2308:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2307);
                                                                        let v2309:
                                                                                &regex::Regex =
                                                                            &v2308.build().unwrap();
                                                                        let v2310:
                                                                                string =
                                                                            Supervisor::method2(v2305);
                                                                        let v2311:
                                                                                &str =
                                                                            &v2310.as_str();
                                                                        let v2312:
                                                                                string =
                                                                            Supervisor::method3();
                                                                        let v2313:
                                                                                &str =
                                                                            &v2312.as_str();
                                                                        let v2314:
                                                                                std::string::String =
                                                                            v2309.replace_all(&v2311, v2313).to_string();
                                                                        let v2315:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2314);
                                                                        let v2317:
                                                                                &str =
                                                                            r#"\["(.*?)"\]"#;
                                                                        let v2318:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2317);
                                                                        let v2319:
                                                                                &regex::Regex =
                                                                            &v2318.build().unwrap();
                                                                        let v2320:
                                                                                string =
                                                                            Supervisor::method2(v2315);
                                                                        let v2321:
                                                                                &str =
                                                                            &v2320.as_str();
                                                                        let v2322:
                                                                                string =
                                                                            Supervisor::method4();
                                                                        let v2323:
                                                                                &str =
                                                                            &v2322.as_str();
                                                                        let v2324:
                                                                                std::string::String =
                                                                            v2319.replace_all(&v2321, v2323).to_string();
                                                                        let v2325:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2324);
                                                                        let v2327:
                                                                                &str =
                                                                            r#", "#;
                                                                        let v2328:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2327);
                                                                        let v2329:
                                                                                &regex::Regex =
                                                                            &v2328.build().unwrap();
                                                                        let v2330:
                                                                                string =
                                                                            Supervisor::method2(v2325);
                                                                        let v2331:
                                                                                &str =
                                                                            &v2330.as_str();
                                                                        let v2332:
                                                                                string =
                                                                            Supervisor::method5();
                                                                        let v2333:
                                                                                &str =
                                                                            &v2332.as_str();
                                                                        let v2334:
                                                                                std::string::String =
                                                                            v2329.replace_all(&v2331, v2333).to_string();
                                                                        let v2335:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2334);
                                                                        let v2337:
                                                                                std::string::String =
                                                                            (&v2335).to_string().clone();
                                                                        let v2338:
                                                                                colored::ColoredString =
                                                                            colored::Colorize::color(&*v2337, v122.clone().to_string());
                                                                        let v2339:
                                                                                std::string::String =
                                                                            format!("{}", &v2338);
                                                                        let v2341:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&&v2274);
                                                                        let v2343:
                                                                                &str =
                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                        let v2344:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2343);
                                                                        let v2345:
                                                                                &regex::Regex =
                                                                            &v2344.build().unwrap();
                                                                        let v2346:
                                                                                string =
                                                                            Supervisor::method2(v2341);
                                                                        let v2347:
                                                                                &str =
                                                                            &v2346.as_str();
                                                                        let v2348:
                                                                                string =
                                                                            Supervisor::method3();
                                                                        let v2349:
                                                                                &str =
                                                                            &v2348.as_str();
                                                                        let v2350:
                                                                                std::string::String =
                                                                            v2345.replace_all(&v2347, v2349).to_string();
                                                                        let v2351:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2350);
                                                                        let v2353:
                                                                                &str =
                                                                            r#"\["(.*?)"\]"#;
                                                                        let v2354:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2353);
                                                                        let v2355:
                                                                                &regex::Regex =
                                                                            &v2354.build().unwrap();
                                                                        let v2356:
                                                                                string =
                                                                            Supervisor::method2(v2351);
                                                                        let v2357:
                                                                                &str =
                                                                            &v2356.as_str();
                                                                        let v2358:
                                                                                string =
                                                                            Supervisor::method4();
                                                                        let v2359:
                                                                                &str =
                                                                            &v2358.as_str();
                                                                        let v2360:
                                                                                std::string::String =
                                                                            v2355.replace_all(&v2357, v2359).to_string();
                                                                        let v2361:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2360);
                                                                        let v2363:
                                                                                &str =
                                                                            r#", "#;
                                                                        let v2364:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2363);
                                                                        let v2365:
                                                                                &regex::Regex =
                                                                            &v2364.build().unwrap();
                                                                        let v2366:
                                                                                string =
                                                                            Supervisor::method2(v2361);
                                                                        let v2367:
                                                                                &str =
                                                                            &v2366.as_str();
                                                                        let v2368:
                                                                                string =
                                                                            Supervisor::method5();
                                                                        let v2369:
                                                                                &str =
                                                                            &v2368.as_str();
                                                                        let v2370:
                                                                                std::string::String =
                                                                            v2365.replace_all(&v2367, v2369).to_string();
                                                                        let v2371:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2370);
                                                                        let v2373:
                                                                                std::string::String =
                                                                            (&v2371).to_string().clone();
                                                                        let v2374:
                                                                                string =
                                                                            substring2(v1533.clone(),
                                                                                       0i32,
                                                                                       2i32);
                                                                        let v2375:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2374, 16).unwrap();
                                                                        let v2376:
                                                                                string =
                                                                            substring2(v1533.clone(),
                                                                                       2i32,
                                                                                       2i32);
                                                                        let v2377:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2376, 16).unwrap();
                                                                        let v2378:
                                                                                string =
                                                                            substring2(v1533.clone(),
                                                                                       4i32,
                                                                                       2i32);
                                                                        let v2379:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2378, 16).unwrap();
                                                                        let v2380:
                                                                                colored::ColoredString =
                                                                            colored::Colorize::truecolor(&*v2373.to_string(), v2375, v2377, v2379);
                                                                        let v2381:
                                                                                std::string::String =
                                                                            format!("{}", &v2380);
                                                                        let v2383:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&&v2297);
                                                                        let v2385:
                                                                                &str =
                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                        let v2386:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2385);
                                                                        let v2387:
                                                                                &regex::Regex =
                                                                            &v2386.build().unwrap();
                                                                        let v2388:
                                                                                string =
                                                                            Supervisor::method2(v2383);
                                                                        let v2389:
                                                                                &str =
                                                                            &v2388.as_str();
                                                                        let v2390:
                                                                                string =
                                                                            Supervisor::method3();
                                                                        let v2391:
                                                                                &str =
                                                                            &v2390.as_str();
                                                                        let v2392:
                                                                                std::string::String =
                                                                            v2387.replace_all(&v2389, v2391).to_string();
                                                                        let v2393:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2392);
                                                                        let v2395:
                                                                                &str =
                                                                            r#"\["(.*?)"\]"#;
                                                                        let v2396:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2395);
                                                                        let v2397:
                                                                                &regex::Regex =
                                                                            &v2396.build().unwrap();
                                                                        let v2398:
                                                                                string =
                                                                            Supervisor::method2(v2393);
                                                                        let v2399:
                                                                                &str =
                                                                            &v2398.as_str();
                                                                        let v2400:
                                                                                string =
                                                                            Supervisor::method4();
                                                                        let v2401:
                                                                                &str =
                                                                            &v2400.as_str();
                                                                        let v2402:
                                                                                std::string::String =
                                                                            v2397.replace_all(&v2399, v2401).to_string();
                                                                        let v2403:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2402);
                                                                        let v2405:
                                                                                &str =
                                                                            r#", "#;
                                                                        let v2406:
                                                                                regex::RegexBuilder =
                                                                            regex::RegexBuilder::new(&v2405);
                                                                        let v2407:
                                                                                &regex::Regex =
                                                                            &v2406.build().unwrap();
                                                                        let v2408:
                                                                                string =
                                                                            Supervisor::method2(v2403);
                                                                        let v2409:
                                                                                &str =
                                                                            &v2408.as_str();
                                                                        let v2410:
                                                                                string =
                                                                            Supervisor::method5();
                                                                        let v2411:
                                                                                &str =
                                                                            &v2410.as_str();
                                                                        let v2412:
                                                                                std::string::String =
                                                                            v2407.replace_all(&v2409, v2411).to_string();
                                                                        let v2413:
                                                                                string =
                                                                            fable_library_rust::String_::fromStr(&v2412);
                                                                        let v2415:
                                                                                std::string::String =
                                                                            (&v2413).to_string().clone();
                                                                        let v2416:
                                                                                string =
                                                                            substring2(v206.clone(),
                                                                                       0i32,
                                                                                       2i32);
                                                                        let v2417:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2416, 16).unwrap();
                                                                        let v2418:
                                                                                string =
                                                                            substring2(v206.clone(),
                                                                                       2i32,
                                                                                       2i32);
                                                                        let v2419:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2418, 16).unwrap();
                                                                        let v2420:
                                                                                string =
                                                                            substring2(v206.clone(),
                                                                                       4i32,
                                                                                       2i32);
                                                                        let v2421:
                                                                                u8 =
                                                                            u8::from_str_radix(&v2420, 16).unwrap();
                                                                        let v2422:
                                                                                colored::ColoredString =
                                                                            colored::Colorize::truecolor(&*v2415.to_string(), v2417, v2419, v2421);
                                                                        let v2423:
                                                                                std::string::String =
                                                                            format!("{}", &v2422);
                                                                        println!("{0}",
                                                                                 stringFrom(format!("{0} {1} {2}", &v2339, &v2381, &v2423)));
                                                                        {
                                                                            let v2425 =
                                                                                zmq::Context::new();
                                                                            let v2426 =
                                                                                v2425.socket(zmq::REQ).unwrap();
                                                                            let v2427:
                                                                                    string =
                                                                                stringFrom(format!("tcp://{0}:{1}",
                                                                                                   &v1415,
                                                                                                   &13805i32));
                                                                            v2426.connect(&v2427.clone()).unwrap();
                                                                            v2426.send(v2091.as_str(), 0).unwrap();
                                                                            {
                                                                                let v2429:
                                                                                        std::string::String =
                                                                                    v2426.recv_string(0).unwrap().unwrap();
                                                                                v2426.disconnect(&v2427).unwrap();
                                                                                {
                                                                                    let v2431:
                                                                                            std::string::String =
                                                                                        (&v1595).to_string().clone();
                                                                                    let v2432:
                                                                                            i32 =
                                                                                        (&v2429).len().try_into().unwrap();
                                                                                    let v2435:
                                                                                            Array<std::string::String> =
                                                                                        array(&[v2431,
                                                                                                format!("{:?}", &v2432)]);
                                                                                    let v2436 =
                                                                                        core::ops::Deref::deref(&v2435);
                                                                                    let v2438:
                                                                                            std::string::String =
                                                                                        format!("{:?}", ***v2436).clone();
                                                                                    let v2439:
                                                                                            chrono::DateTime<chrono::Utc> =
                                                                                        chrono::Utc::now();
                                                                                    let v2444:
                                                                                            string =
                                                                                        Supervisor::method1(6i32,
                                                                                                            toString(&((&v2439).timestamp()
                                                                                                                           -
                                                                                                                           v2257)));
                                                                                    let v2445:
                                                                                            u8 =
                                                                                        rand::random::<u8>();
                                                                                    let v2458:
                                                                                            Array<std::string::String> =
                                                                                        array(&[(&v52).to_string(),
                                                                                                (&v2444).to_string(),
                                                                                                (&v57).to_string(),
                                                                                                format!("{:?}", &v2445),
                                                                                                (&v63).to_string(),
                                                                                                (&v66).to_string()]);
                                                                                    let v2459 =
                                                                                        core::ops::Deref::deref(&v2458);
                                                                                    let v2461:
                                                                                            std::string::String =
                                                                                        format!("{:?}", ***v2459).clone();
                                                                                    let v2464:
                                                                                            Array<std::string::String> =
                                                                                        array(&[(&v1456).to_string()]);
                                                                                    let v2465 =
                                                                                        core::ops::Deref::deref(&v2464);
                                                                                    let v2468:
                                                                                            std::string::String =
                                                                                        format!("{:?}", ***v2465).clone();
                                                                                    let v2469:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2468);
                                                                                    let v2471:
                                                                                            &str =
                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                    let v2472:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2471);
                                                                                    let v2473:
                                                                                            &regex::Regex =
                                                                                        &v2472.build().unwrap();
                                                                                    let v2474:
                                                                                            string =
                                                                                        Supervisor::method2(v2469);
                                                                                    let v2475:
                                                                                            &str =
                                                                                        &v2474.as_str();
                                                                                    let v2476:
                                                                                            string =
                                                                                        Supervisor::method3();
                                                                                    let v2477:
                                                                                            &str =
                                                                                        &v2476.as_str();
                                                                                    let v2478:
                                                                                            std::string::String =
                                                                                        v2473.replace_all(&v2475, v2477).to_string();
                                                                                    let v2479:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2478);
                                                                                    let v2481:
                                                                                            &str =
                                                                                        r#"\["(.*?)"\]"#;
                                                                                    let v2482:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2481);
                                                                                    let v2483:
                                                                                            &regex::Regex =
                                                                                        &v2482.build().unwrap();
                                                                                    let v2484:
                                                                                            string =
                                                                                        Supervisor::method2(v2479);
                                                                                    let v2485:
                                                                                            &str =
                                                                                        &v2484.as_str();
                                                                                    let v2486:
                                                                                            string =
                                                                                        Supervisor::method4();
                                                                                    let v2487:
                                                                                            &str =
                                                                                        &v2486.as_str();
                                                                                    let v2488:
                                                                                            std::string::String =
                                                                                        v2483.replace_all(&v2485, v2487).to_string();
                                                                                    let v2489:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2488);
                                                                                    let v2491:
                                                                                            &str =
                                                                                        r#", "#;
                                                                                    let v2492:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2491);
                                                                                    let v2493:
                                                                                            &regex::Regex =
                                                                                        &v2492.build().unwrap();
                                                                                    let v2494:
                                                                                            string =
                                                                                        Supervisor::method2(v2489);
                                                                                    let v2495:
                                                                                            &str =
                                                                                        &v2494.as_str();
                                                                                    let v2496:
                                                                                            string =
                                                                                        Supervisor::method5();
                                                                                    let v2497:
                                                                                            &str =
                                                                                        &v2496.as_str();
                                                                                    let v2498:
                                                                                            std::string::String =
                                                                                        v2493.replace_all(&v2495, v2497).to_string();
                                                                                    let v2499:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2498);
                                                                                    let v2501:
                                                                                            std::string::String =
                                                                                        (&v2499).to_string().clone();
                                                                                    let v2502:
                                                                                            colored::ColoredString =
                                                                                        colored::Colorize::color(&*v2501, v122.clone().to_string());
                                                                                    let v2503:
                                                                                            std::string::String =
                                                                                        format!("{}", &v2502);
                                                                                    let v2505:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&&v2438);
                                                                                    let v2507:
                                                                                            &str =
                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                    let v2508:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2507);
                                                                                    let v2509:
                                                                                            &regex::Regex =
                                                                                        &v2508.build().unwrap();
                                                                                    let v2510:
                                                                                            string =
                                                                                        Supervisor::method2(v2505);
                                                                                    let v2511:
                                                                                            &str =
                                                                                        &v2510.as_str();
                                                                                    let v2512:
                                                                                            string =
                                                                                        Supervisor::method3();
                                                                                    let v2513:
                                                                                            &str =
                                                                                        &v2512.as_str();
                                                                                    let v2514:
                                                                                            std::string::String =
                                                                                        v2509.replace_all(&v2511, v2513).to_string();
                                                                                    let v2515:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2514);
                                                                                    let v2517:
                                                                                            &str =
                                                                                        r#"\["(.*?)"\]"#;
                                                                                    let v2518:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2517);
                                                                                    let v2519:
                                                                                            &regex::Regex =
                                                                                        &v2518.build().unwrap();
                                                                                    let v2520:
                                                                                            string =
                                                                                        Supervisor::method2(v2515);
                                                                                    let v2521:
                                                                                            &str =
                                                                                        &v2520.as_str();
                                                                                    let v2522:
                                                                                            string =
                                                                                        Supervisor::method4();
                                                                                    let v2523:
                                                                                            &str =
                                                                                        &v2522.as_str();
                                                                                    let v2524:
                                                                                            std::string::String =
                                                                                        v2519.replace_all(&v2521, v2523).to_string();
                                                                                    let v2525:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2524);
                                                                                    let v2527:
                                                                                            &str =
                                                                                        r#", "#;
                                                                                    let v2528:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2527);
                                                                                    let v2529:
                                                                                            &regex::Regex =
                                                                                        &v2528.build().unwrap();
                                                                                    let v2530:
                                                                                            string =
                                                                                        Supervisor::method2(v2525);
                                                                                    let v2531:
                                                                                            &str =
                                                                                        &v2530.as_str();
                                                                                    let v2532:
                                                                                            string =
                                                                                        Supervisor::method5();
                                                                                    let v2533:
                                                                                            &str =
                                                                                        &v2532.as_str();
                                                                                    let v2534:
                                                                                            std::string::String =
                                                                                        v2529.replace_all(&v2531, v2533).to_string();
                                                                                    let v2535:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2534);
                                                                                    let v2537:
                                                                                            std::string::String =
                                                                                        (&v2535).to_string().clone();
                                                                                    let v2538:
                                                                                            string =
                                                                                        substring2(v1533.clone(),
                                                                                                   0i32,
                                                                                                   2i32);
                                                                                    let v2539:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2538, 16).unwrap();
                                                                                    let v2540:
                                                                                            string =
                                                                                        substring2(v1533.clone(),
                                                                                                   2i32,
                                                                                                   2i32);
                                                                                    let v2541:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2540, 16).unwrap();
                                                                                    let v2542:
                                                                                            string =
                                                                                        substring2(v1533,
                                                                                                   4i32,
                                                                                                   2i32);
                                                                                    let v2543:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2542, 16).unwrap();
                                                                                    let v2544:
                                                                                            colored::ColoredString =
                                                                                        colored::Colorize::truecolor(&*v2537.to_string(), v2539, v2541, v2543);
                                                                                    let v2545:
                                                                                            std::string::String =
                                                                                        format!("{}", &v2544);
                                                                                    let v2547:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&&v2461);
                                                                                    let v2549:
                                                                                            &str =
                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                    let v2550:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2549);
                                                                                    let v2551:
                                                                                            &regex::Regex =
                                                                                        &v2550.build().unwrap();
                                                                                    let v2552:
                                                                                            string =
                                                                                        Supervisor::method2(v2547);
                                                                                    let v2553:
                                                                                            &str =
                                                                                        &v2552.as_str();
                                                                                    let v2554:
                                                                                            string =
                                                                                        Supervisor::method3();
                                                                                    let v2555:
                                                                                            &str =
                                                                                        &v2554.as_str();
                                                                                    let v2556:
                                                                                            std::string::String =
                                                                                        v2551.replace_all(&v2553, v2555).to_string();
                                                                                    let v2557:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2556);
                                                                                    let v2559:
                                                                                            &str =
                                                                                        r#"\["(.*?)"\]"#;
                                                                                    let v2560:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2559);
                                                                                    let v2561:
                                                                                            &regex::Regex =
                                                                                        &v2560.build().unwrap();
                                                                                    let v2562:
                                                                                            string =
                                                                                        Supervisor::method2(v2557);
                                                                                    let v2563:
                                                                                            &str =
                                                                                        &v2562.as_str();
                                                                                    let v2564:
                                                                                            string =
                                                                                        Supervisor::method4();
                                                                                    let v2565:
                                                                                            &str =
                                                                                        &v2564.as_str();
                                                                                    let v2566:
                                                                                            std::string::String =
                                                                                        v2561.replace_all(&v2563, v2565).to_string();
                                                                                    let v2567:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2566);
                                                                                    let v2569:
                                                                                            &str =
                                                                                        r#", "#;
                                                                                    let v2570:
                                                                                            regex::RegexBuilder =
                                                                                        regex::RegexBuilder::new(&v2569);
                                                                                    let v2571:
                                                                                            &regex::Regex =
                                                                                        &v2570.build().unwrap();
                                                                                    let v2572:
                                                                                            string =
                                                                                        Supervisor::method2(v2567);
                                                                                    let v2573:
                                                                                            &str =
                                                                                        &v2572.as_str();
                                                                                    let v2574:
                                                                                            string =
                                                                                        Supervisor::method5();
                                                                                    let v2575:
                                                                                            &str =
                                                                                        &v2574.as_str();
                                                                                    let v2576:
                                                                                            std::string::String =
                                                                                        v2571.replace_all(&v2573, v2575).to_string();
                                                                                    let v2577:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromStr(&v2576);
                                                                                    let v2579:
                                                                                            std::string::String =
                                                                                        (&v2577).to_string().clone();
                                                                                    let v2580:
                                                                                            string =
                                                                                        substring2(v206.clone(),
                                                                                                   0i32,
                                                                                                   2i32);
                                                                                    let v2581:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2580, 16).unwrap();
                                                                                    let v2582:
                                                                                            string =
                                                                                        substring2(v206.clone(),
                                                                                                   2i32,
                                                                                                   2i32);
                                                                                    let v2583:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2582, 16).unwrap();
                                                                                    let v2584:
                                                                                            string =
                                                                                        substring2(v206.clone(),
                                                                                                   4i32,
                                                                                                   2i32);
                                                                                    let v2585:
                                                                                            u8 =
                                                                                        u8::from_str_radix(&v2584, 16).unwrap();
                                                                                    let v2586:
                                                                                            colored::ColoredString =
                                                                                        colored::Colorize::truecolor(&*v2579.to_string(), v2581, v2583, v2585);
                                                                                    let v2587:
                                                                                            std::string::String =
                                                                                        format!("{}", &v2586);
                                                                                    println!("{0}",
                                                                                             stringFrom(format!("{0} {1} {2}", &v2503, &v2545, &v2587)));
                                                                                    {
                                                                                        let v2591:
                                                                                                std::string::String =
                                                                                            (&string("> spi_build_file; ok")).to_string().clone();
                                                                                        let v2592:
                                                                                                chrono::DateTime<chrono::Utc> =
                                                                                            chrono::Utc::now();
                                                                                        let v2597:
                                                                                                string =
                                                                                            Supervisor::method1(6i32,
                                                                                                                toString(&((&v2592).timestamp()
                                                                                                                               -
                                                                                                                               v9)));
                                                                                        let v2598:
                                                                                                u8 =
                                                                                            rand::random::<u8>();
                                                                                        let v2611:
                                                                                                Array<std::string::String> =
                                                                                            array(&[(&v52).to_string(),
                                                                                                    (&v2597).to_string(),
                                                                                                    (&v57).to_string(),
                                                                                                    format!("{:?}", &v2598),
                                                                                                    (&v63).to_string(),
                                                                                                    (&v66).to_string()]);
                                                                                        let v2612 =
                                                                                            core::ops::Deref::deref(&v2611);
                                                                                        let v2614:
                                                                                                std::string::String =
                                                                                            format!("{:?}", ***v2612).clone();
                                                                                        let v2617:
                                                                                                Array<std::string::String> =
                                                                                            array(&[(&v73).to_string()]);
                                                                                        let v2618 =
                                                                                            core::ops::Deref::deref(&v2617);
                                                                                        let v2621:
                                                                                                std::string::String =
                                                                                            format!("{:?}", ***v2618).clone();
                                                                                        let v2622:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2621);
                                                                                        let v2624:
                                                                                                &str =
                                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                                        let v2625:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2624);
                                                                                        let v2626:
                                                                                                &regex::Regex =
                                                                                            &v2625.build().unwrap();
                                                                                        let v2627:
                                                                                                string =
                                                                                            Supervisor::method2(v2622);
                                                                                        let v2628:
                                                                                                &str =
                                                                                            &v2627.as_str();
                                                                                        let v2629:
                                                                                                string =
                                                                                            Supervisor::method3();
                                                                                        let v2630:
                                                                                                &str =
                                                                                            &v2629.as_str();
                                                                                        let v2631:
                                                                                                std::string::String =
                                                                                            v2626.replace_all(&v2628, v2630).to_string();
                                                                                        let v2632:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2631);
                                                                                        let v2634:
                                                                                                &str =
                                                                                            r#"\["(.*?)"\]"#;
                                                                                        let v2635:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2634);
                                                                                        let v2636:
                                                                                                &regex::Regex =
                                                                                            &v2635.build().unwrap();
                                                                                        let v2637:
                                                                                                string =
                                                                                            Supervisor::method2(v2632);
                                                                                        let v2638:
                                                                                                &str =
                                                                                            &v2637.as_str();
                                                                                        let v2639:
                                                                                                string =
                                                                                            Supervisor::method4();
                                                                                        let v2640:
                                                                                                &str =
                                                                                            &v2639.as_str();
                                                                                        let v2641:
                                                                                                std::string::String =
                                                                                            v2636.replace_all(&v2638, v2640).to_string();
                                                                                        let v2642:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2641);
                                                                                        let v2644:
                                                                                                &str =
                                                                                            r#", "#;
                                                                                        let v2645:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2644);
                                                                                        let v2646:
                                                                                                &regex::Regex =
                                                                                            &v2645.build().unwrap();
                                                                                        let v2647:
                                                                                                string =
                                                                                            Supervisor::method2(v2642);
                                                                                        let v2648:
                                                                                                &str =
                                                                                            &v2647.as_str();
                                                                                        let v2649:
                                                                                                string =
                                                                                            Supervisor::method5();
                                                                                        let v2650:
                                                                                                &str =
                                                                                            &v2649.as_str();
                                                                                        let v2651:
                                                                                                std::string::String =
                                                                                            v2646.replace_all(&v2648, v2650).to_string();
                                                                                        let v2652:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2651);
                                                                                        let v2654:
                                                                                                std::string::String =
                                                                                            (&v2652).to_string().clone();
                                                                                        let v2655:
                                                                                                colored::ColoredString =
                                                                                            colored::Colorize::color(&*v2654, v122.clone().to_string());
                                                                                        let v2656:
                                                                                                std::string::String =
                                                                                            format!("{}", &v2655);
                                                                                        let v2658:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&&v2591);
                                                                                        let v2660:
                                                                                                &str =
                                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                                        let v2661:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2660);
                                                                                        let v2662:
                                                                                                &regex::Regex =
                                                                                            &v2661.build().unwrap();
                                                                                        let v2663:
                                                                                                string =
                                                                                            Supervisor::method2(v2658);
                                                                                        let v2664:
                                                                                                &str =
                                                                                            &v2663.as_str();
                                                                                        let v2665:
                                                                                                string =
                                                                                            Supervisor::method3();
                                                                                        let v2666:
                                                                                                &str =
                                                                                            &v2665.as_str();
                                                                                        let v2667:
                                                                                                std::string::String =
                                                                                            v2662.replace_all(&v2664, v2666).to_string();
                                                                                        let v2668:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2667);
                                                                                        let v2670:
                                                                                                &str =
                                                                                            r#"\["(.*?)"\]"#;
                                                                                        let v2671:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2670);
                                                                                        let v2672:
                                                                                                &regex::Regex =
                                                                                            &v2671.build().unwrap();
                                                                                        let v2673:
                                                                                                string =
                                                                                            Supervisor::method2(v2668);
                                                                                        let v2674:
                                                                                                &str =
                                                                                            &v2673.as_str();
                                                                                        let v2675:
                                                                                                string =
                                                                                            Supervisor::method4();
                                                                                        let v2676:
                                                                                                &str =
                                                                                            &v2675.as_str();
                                                                                        let v2677:
                                                                                                std::string::String =
                                                                                            v2672.replace_all(&v2674, v2676).to_string();
                                                                                        let v2678:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2677);
                                                                                        let v2680:
                                                                                                &str =
                                                                                            r#", "#;
                                                                                        let v2681:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2680);
                                                                                        let v2682:
                                                                                                &regex::Regex =
                                                                                            &v2681.build().unwrap();
                                                                                        let v2683:
                                                                                                string =
                                                                                            Supervisor::method2(v2678);
                                                                                        let v2684:
                                                                                                &str =
                                                                                            &v2683.as_str();
                                                                                        let v2685:
                                                                                                string =
                                                                                            Supervisor::method5();
                                                                                        let v2686:
                                                                                                &str =
                                                                                            &v2685.as_str();
                                                                                        let v2687:
                                                                                                std::string::String =
                                                                                            v2682.replace_all(&v2684, v2686).to_string();
                                                                                        let v2688:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2687);
                                                                                        let v2690:
                                                                                                std::string::String =
                                                                                            (&v2688).to_string().clone();
                                                                                        let v2691:
                                                                                                string =
                                                                                            substring2(v161.clone(),
                                                                                                       0i32,
                                                                                                       2i32);
                                                                                        let v2692:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v2691, 16).unwrap();
                                                                                        let v2693:
                                                                                                string =
                                                                                            substring2(v161.clone(),
                                                                                                       2i32,
                                                                                                       2i32);
                                                                                        let v2694:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v2693, 16).unwrap();
                                                                                        let v2695:
                                                                                                string =
                                                                                            substring2(v161.clone(),
                                                                                                       4i32,
                                                                                                       2i32);
                                                                                        let v2696:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v2695, 16).unwrap();
                                                                                        let v2697:
                                                                                                colored::ColoredString =
                                                                                            colored::Colorize::truecolor(&*v2690.to_string(), v2692, v2694, v2696);
                                                                                        let v2698:
                                                                                                std::string::String =
                                                                                            format!("{}", &v2697);
                                                                                        let v2700:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&&v2614);
                                                                                        let v2702:
                                                                                                &str =
                                                                                            r#""([^"]+)", "([^"]+)""#;
                                                                                        let v2703:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2702);
                                                                                        let v2704:
                                                                                                &regex::Regex =
                                                                                            &v2703.build().unwrap();
                                                                                        let v2705:
                                                                                                string =
                                                                                            Supervisor::method2(v2700);
                                                                                        let v2706:
                                                                                                &str =
                                                                                            &v2705.as_str();
                                                                                        let v2707:
                                                                                                string =
                                                                                            Supervisor::method3();
                                                                                        let v2708:
                                                                                                &str =
                                                                                            &v2707.as_str();
                                                                                        let v2709:
                                                                                                std::string::String =
                                                                                            v2704.replace_all(&v2706, v2708).to_string();
                                                                                        let v2710:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2709);
                                                                                        let v2712:
                                                                                                &str =
                                                                                            r#"\["(.*?)"\]"#;
                                                                                        let v2713:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2712);
                                                                                        let v2714:
                                                                                                &regex::Regex =
                                                                                            &v2713.build().unwrap();
                                                                                        let v2715:
                                                                                                string =
                                                                                            Supervisor::method2(v2710);
                                                                                        let v2716:
                                                                                                &str =
                                                                                            &v2715.as_str();
                                                                                        let v2717:
                                                                                                string =
                                                                                            Supervisor::method4();
                                                                                        let v2718:
                                                                                                &str =
                                                                                            &v2717.as_str();
                                                                                        let v2719:
                                                                                                std::string::String =
                                                                                            v2714.replace_all(&v2716, v2718).to_string();
                                                                                        let v2720:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2719);
                                                                                        let v2722:
                                                                                                &str =
                                                                                            r#", "#;
                                                                                        let v2723:
                                                                                                regex::RegexBuilder =
                                                                                            regex::RegexBuilder::new(&v2722);
                                                                                        let v2724:
                                                                                                &regex::Regex =
                                                                                            &v2723.build().unwrap();
                                                                                        let v2725:
                                                                                                string =
                                                                                            Supervisor::method2(v2720);
                                                                                        let v2726:
                                                                                                &str =
                                                                                            &v2725.as_str();
                                                                                        let v2727:
                                                                                                string =
                                                                                            Supervisor::method5();
                                                                                        let v2728:
                                                                                                &str =
                                                                                            &v2727.as_str();
                                                                                        let v2729:
                                                                                                std::string::String =
                                                                                            v2724.replace_all(&v2726, v2728).to_string();
                                                                                        let v2730:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromStr(&v2729);
                                                                                        let v2732:
                                                                                                std::string::String =
                                                                                            (&v2730).to_string().clone();
                                                                                        let v2733:
                                                                                                string =
                                                                                            substring2(v206.clone(),
                                                                                                       0i32,
                                                                                                       2i32);
                                                                                        let v2734:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v2733, 16).unwrap();
                                                                                        let v2735:
                                                                                                string =
                                                                                            substring2(v206.clone(),
                                                                                                       2i32,
                                                                                                       2i32);
                                                                                        let v2736:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v2735, 16).unwrap();
                                                                                        let v2737:
                                                                                                string =
                                                                                            substring2(v206.clone(),
                                                                                                       4i32,
                                                                                                       2i32);
                                                                                        let v2738:
                                                                                                u8 =
                                                                                            u8::from_str_radix(&v2737, 16).unwrap();
                                                                                        let v2739:
                                                                                                colored::ColoredString =
                                                                                            colored::Colorize::truecolor(&*v2732.to_string(), v2734, v2736, v2738);
                                                                                        let v2740:
                                                                                                std::string::String =
                                                                                            format!("{}", &v2739);
                                                                                        println!("{0}",
                                                                                                 stringFrom(format!("{0} {1} {2}", &v2656, &v2698, &v2740)));
                                                                                        {
                                                                                            let patternInput_5:
                                                                                                    (string,
                                                                                                     string,
                                                                                                     string,
                                                                                                     bool) =
                                                                                                Supervisor::method0();
                                                                                            let v2746:
                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                chrono::Utc::now();
                                                                                            let v2747:
                                                                                                    i64 =
                                                                                                (&v2746).timestamp();
                                                                                            let v2749:
                                                                                                    std::time::SystemTime =
                                                                                                std::fs::metadata(&v735).unwrap().modified().unwrap();
                                                                                            let v2751:
                                                                                                    std::string::String =
                                                                                                (&v736).to_string().clone();
                                                                                            let v2752:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&format!("{}", &v735.display()));
                                                                                            let v2760:
                                                                                                    Array<std::string::String> =
                                                                                                array(&[v2751,
                                                                                                        (&v2752).to_string(),
                                                                                                        (&string("start")).to_string(),
                                                                                                        format!("{:?}", &v2749)]);
                                                                                            let v2761 =
                                                                                                core::ops::Deref::deref(&v2760);
                                                                                            let v2763:
                                                                                                    std::string::String =
                                                                                                format!("{:?}", ***v2761).clone();
                                                                                            let v2764:
                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                chrono::Utc::now();
                                                                                            let v2769:
                                                                                                    string =
                                                                                                Supervisor::method1(6i32,
                                                                                                                    toString(&((&v2764).timestamp()
                                                                                                                                   -
                                                                                                                                   v2747)));
                                                                                            let v2770:
                                                                                                    u8 =
                                                                                                rand::random::<u8>();
                                                                                            let v2783:
                                                                                                    Array<std::string::String> =
                                                                                                array(&[(&v52).to_string(),
                                                                                                        (&v2769).to_string(),
                                                                                                        (&v57).to_string(),
                                                                                                        format!("{:?}", &v2770),
                                                                                                        (&v63).to_string(),
                                                                                                        (&v66).to_string()]);
                                                                                            let v2784 =
                                                                                                core::ops::Deref::deref(&v2783);
                                                                                            let v2786:
                                                                                                    std::string::String =
                                                                                                format!("{:?}", ***v2784).clone();
                                                                                            let v2787:
                                                                                                    string =
                                                                                                string("> wait_file_change ()");
                                                                                            let v2790:
                                                                                                    Array<std::string::String> =
                                                                                                array(&[(&v2787).to_string()]);
                                                                                            let v2791 =
                                                                                                core::ops::Deref::deref(&v2790);
                                                                                            let v2794:
                                                                                                    std::string::String =
                                                                                                format!("{:?}", ***v2791).clone();
                                                                                            let v2795:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2794);
                                                                                            let v2797:
                                                                                                    &str =
                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                            let v2798:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2797);
                                                                                            let v2799:
                                                                                                    &regex::Regex =
                                                                                                &v2798.build().unwrap();
                                                                                            let v2800:
                                                                                                    string =
                                                                                                Supervisor::method2(v2795);
                                                                                            let v2801:
                                                                                                    &str =
                                                                                                &v2800.as_str();
                                                                                            let v2802:
                                                                                                    string =
                                                                                                Supervisor::method3();
                                                                                            let v2803:
                                                                                                    &str =
                                                                                                &v2802.as_str();
                                                                                            let v2804:
                                                                                                    std::string::String =
                                                                                                v2799.replace_all(&v2801, v2803).to_string();
                                                                                            let v2805:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2804);
                                                                                            let v2807:
                                                                                                    &str =
                                                                                                r#"\["(.*?)"\]"#;
                                                                                            let v2808:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2807);
                                                                                            let v2809:
                                                                                                    &regex::Regex =
                                                                                                &v2808.build().unwrap();
                                                                                            let v2810:
                                                                                                    string =
                                                                                                Supervisor::method2(v2805);
                                                                                            let v2811:
                                                                                                    &str =
                                                                                                &v2810.as_str();
                                                                                            let v2812:
                                                                                                    string =
                                                                                                Supervisor::method4();
                                                                                            let v2813:
                                                                                                    &str =
                                                                                                &v2812.as_str();
                                                                                            let v2814:
                                                                                                    std::string::String =
                                                                                                v2809.replace_all(&v2811, v2813).to_string();
                                                                                            let v2815:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2814);
                                                                                            let v2817:
                                                                                                    &str =
                                                                                                r#", "#;
                                                                                            let v2818:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2817);
                                                                                            let v2819:
                                                                                                    &regex::Regex =
                                                                                                &v2818.build().unwrap();
                                                                                            let v2820:
                                                                                                    string =
                                                                                                Supervisor::method2(v2815);
                                                                                            let v2821:
                                                                                                    &str =
                                                                                                &v2820.as_str();
                                                                                            let v2822:
                                                                                                    string =
                                                                                                Supervisor::method5();
                                                                                            let v2823:
                                                                                                    &str =
                                                                                                &v2822.as_str();
                                                                                            let v2824:
                                                                                                    std::string::String =
                                                                                                v2819.replace_all(&v2821, v2823).to_string();
                                                                                            let v2825:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2824);
                                                                                            let v2827:
                                                                                                    std::string::String =
                                                                                                (&v2825).to_string().clone();
                                                                                            let v2828:
                                                                                                    colored::ColoredString =
                                                                                                colored::Colorize::color(&*v2827, v122.clone().to_string());
                                                                                            let v2829:
                                                                                                    std::string::String =
                                                                                                format!("{}", &v2828);
                                                                                            let v2831:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&&v2763);
                                                                                            let v2833:
                                                                                                    &str =
                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                            let v2834:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2833);
                                                                                            let v2835:
                                                                                                    &regex::Regex =
                                                                                                &v2834.build().unwrap();
                                                                                            let v2836:
                                                                                                    string =
                                                                                                Supervisor::method2(v2831);
                                                                                            let v2837:
                                                                                                    &str =
                                                                                                &v2836.as_str();
                                                                                            let v2838:
                                                                                                    string =
                                                                                                Supervisor::method3();
                                                                                            let v2839:
                                                                                                    &str =
                                                                                                &v2838.as_str();
                                                                                            let v2840:
                                                                                                    std::string::String =
                                                                                                v2835.replace_all(&v2837, v2839).to_string();
                                                                                            let v2841:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2840);
                                                                                            let v2843:
                                                                                                    &str =
                                                                                                r#"\["(.*?)"\]"#;
                                                                                            let v2844:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2843);
                                                                                            let v2845:
                                                                                                    &regex::Regex =
                                                                                                &v2844.build().unwrap();
                                                                                            let v2846:
                                                                                                    string =
                                                                                                Supervisor::method2(v2841);
                                                                                            let v2847:
                                                                                                    &str =
                                                                                                &v2846.as_str();
                                                                                            let v2848:
                                                                                                    string =
                                                                                                Supervisor::method4();
                                                                                            let v2849:
                                                                                                    &str =
                                                                                                &v2848.as_str();
                                                                                            let v2850:
                                                                                                    std::string::String =
                                                                                                v2845.replace_all(&v2847, v2849).to_string();
                                                                                            let v2851:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2850);
                                                                                            let v2853:
                                                                                                    &str =
                                                                                                r#", "#;
                                                                                            let v2854:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2853);
                                                                                            let v2855:
                                                                                                    &regex::Regex =
                                                                                                &v2854.build().unwrap();
                                                                                            let v2856:
                                                                                                    string =
                                                                                                Supervisor::method2(v2851);
                                                                                            let v2857:
                                                                                                    &str =
                                                                                                &v2856.as_str();
                                                                                            let v2858:
                                                                                                    string =
                                                                                                Supervisor::method5();
                                                                                            let v2859:
                                                                                                    &str =
                                                                                                &v2858.as_str();
                                                                                            let v2860:
                                                                                                    std::string::String =
                                                                                                v2855.replace_all(&v2857, v2859).to_string();
                                                                                            let v2861:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2860);
                                                                                            let v2863:
                                                                                                    std::string::String =
                                                                                                (&v2861).to_string().clone();
                                                                                            let v2864:
                                                                                                    string =
                                                                                                string("387957");
                                                                                            let v2865:
                                                                                                    string =
                                                                                                substring2(v2864.clone(),
                                                                                                           0i32,
                                                                                                           2i32);
                                                                                            let v2866:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v2865, 16).unwrap();
                                                                                            let v2867:
                                                                                                    string =
                                                                                                substring2(v2864.clone(),
                                                                                                           2i32,
                                                                                                           2i32);
                                                                                            let v2868:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v2867, 16).unwrap();
                                                                                            let v2869:
                                                                                                    string =
                                                                                                substring2(v2864.clone(),
                                                                                                           4i32,
                                                                                                           2i32);
                                                                                            let v2870:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v2869, 16).unwrap();
                                                                                            let v2871:
                                                                                                    colored::ColoredString =
                                                                                                colored::Colorize::truecolor(&*v2863.to_string(), v2866, v2868, v2870);
                                                                                            let v2872:
                                                                                                    std::string::String =
                                                                                                format!("{}", &v2871);
                                                                                            let v2874:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&&v2786);
                                                                                            let v2876:
                                                                                                    &str =
                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                            let v2877:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2876);
                                                                                            let v2878:
                                                                                                    &regex::Regex =
                                                                                                &v2877.build().unwrap();
                                                                                            let v2879:
                                                                                                    string =
                                                                                                Supervisor::method2(v2874);
                                                                                            let v2880:
                                                                                                    &str =
                                                                                                &v2879.as_str();
                                                                                            let v2881:
                                                                                                    string =
                                                                                                Supervisor::method3();
                                                                                            let v2882:
                                                                                                    &str =
                                                                                                &v2881.as_str();
                                                                                            let v2883:
                                                                                                    std::string::String =
                                                                                                v2878.replace_all(&v2880, v2882).to_string();
                                                                                            let v2884:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2883);
                                                                                            let v2886:
                                                                                                    &str =
                                                                                                r#"\["(.*?)"\]"#;
                                                                                            let v2887:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2886);
                                                                                            let v2888:
                                                                                                    &regex::Regex =
                                                                                                &v2887.build().unwrap();
                                                                                            let v2889:
                                                                                                    string =
                                                                                                Supervisor::method2(v2884);
                                                                                            let v2890:
                                                                                                    &str =
                                                                                                &v2889.as_str();
                                                                                            let v2891:
                                                                                                    string =
                                                                                                Supervisor::method4();
                                                                                            let v2892:
                                                                                                    &str =
                                                                                                &v2891.as_str();
                                                                                            let v2893:
                                                                                                    std::string::String =
                                                                                                v2888.replace_all(&v2890, v2892).to_string();
                                                                                            let v2894:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2893);
                                                                                            let v2896:
                                                                                                    &str =
                                                                                                r#", "#;
                                                                                            let v2897:
                                                                                                    regex::RegexBuilder =
                                                                                                regex::RegexBuilder::new(&v2896);
                                                                                            let v2898:
                                                                                                    &regex::Regex =
                                                                                                &v2897.build().unwrap();
                                                                                            let v2899:
                                                                                                    string =
                                                                                                Supervisor::method2(v2894);
                                                                                            let v2900:
                                                                                                    &str =
                                                                                                &v2899.as_str();
                                                                                            let v2901:
                                                                                                    string =
                                                                                                Supervisor::method5();
                                                                                            let v2902:
                                                                                                    &str =
                                                                                                &v2901.as_str();
                                                                                            let v2903:
                                                                                                    std::string::String =
                                                                                                v2898.replace_all(&v2900, v2902).to_string();
                                                                                            let v2904:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromStr(&v2903);
                                                                                            let v2906:
                                                                                                    std::string::String =
                                                                                                (&v2904).to_string().clone();
                                                                                            let v2907:
                                                                                                    string =
                                                                                                substring2(v206.clone(),
                                                                                                           0i32,
                                                                                                           2i32);
                                                                                            let v2908:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v2907, 16).unwrap();
                                                                                            let v2909:
                                                                                                    string =
                                                                                                substring2(v206.clone(),
                                                                                                           2i32,
                                                                                                           2i32);
                                                                                            let v2910:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v2909, 16).unwrap();
                                                                                            let v2911:
                                                                                                    string =
                                                                                                substring2(v206.clone(),
                                                                                                           4i32,
                                                                                                           2i32);
                                                                                            let v2912:
                                                                                                    u8 =
                                                                                                u8::from_str_radix(&v2911, 16).unwrap();
                                                                                            let v2913:
                                                                                                    colored::ColoredString =
                                                                                                colored::Colorize::truecolor(&*v2906.to_string(), v2908, v2910, v2912);
                                                                                            let v2914:
                                                                                                    std::string::String =
                                                                                                format!("{}", &v2913);
                                                                                            println!("{0}",
                                                                                                     stringFrom(format!("{0} {1} {2}", &v2829, &v2872, &v2914)));
                                                                                            {
                                                                                                let v2916:
                                                                                                        Array<i32> =
                                                                                                    toArray(rangeNumeric(0i32,
                                                                                                                         1i32,
                                                                                                                         50i32).clone());
                                                                                                let v2917:
                                                                                                        i32 =
                                                                                                    v2916.len()
                                                                                                        as
                                                                                                        i32;
                                                                                                let v2919:
                                                                                                        Lrc<Supervisor::Mut0> =
                                                                                                    Lrc::new(Supervisor::Mut0{l0:
                                                                                                                                  MutCell::new(0i32),
                                                                                                                              l1:
                                                                                                                                  MutCell::new(Supervisor::US0::US0_0),});
                                                                                                while Supervisor::method6(v2917,
                                                                                                                          v2919.clone())
                                                                                                      {
                                                                                                    let v2921:
                                                                                                            i32 =
                                                                                                        v2919.l0.get();
                                                                                                    let v2922:
                                                                                                            Supervisor::US0 =
                                                                                                        v2919.l1.get().clone();
                                                                                                    let v2923:
                                                                                                            i32 =
                                                                                                        v2916[v2921].clone();
                                                                                                    let v3101:
                                                                                                            Supervisor::US0 =
                                                                                                        match &v2922
                                                                                                            {
                                                                                                            Supervisor::US0::US0_1(v2922_1_0)
                                                                                                            =>
                                                                                                            Supervisor::US0::US0_1(v2922_1_0.clone()),
                                                                                                            _
                                                                                                            =>
                                                                                                            {
                                                                                                                let v2926:
                                                                                                                        std::time::SystemTime =
                                                                                                                    std::fs::metadata(&v735).unwrap().modified().unwrap();
                                                                                                                let v2937:
                                                                                                                        Array<std::string::String> =
                                                                                                                    array(&[(&string("i")).to_string(),
                                                                                                                            format!("{:?}", &v2923),
                                                                                                                            (&string("last_modified")).to_string(),
                                                                                                                            format!("{:?}", &v2926)]);
                                                                                                                let v2938 =
                                                                                                                    core::ops::Deref::deref(&v2937);
                                                                                                                let v2940:
                                                                                                                        std::string::String =
                                                                                                                    format!("{:?}", ***v2938).clone();
                                                                                                                let v2941:
                                                                                                                        chrono::DateTime<chrono::Utc> =
                                                                                                                    chrono::Utc::now();
                                                                                                                let v2946:
                                                                                                                        string =
                                                                                                                    Supervisor::method1(6i32,
                                                                                                                                        toString(&((&v2941).timestamp()
                                                                                                                                                       -
                                                                                                                                                       v2747)));
                                                                                                                let v2947:
                                                                                                                        u8 =
                                                                                                                    rand::random::<u8>();
                                                                                                                let v2960:
                                                                                                                        Array<std::string::String> =
                                                                                                                    array(&[(&v52).to_string(),
                                                                                                                            (&v2946).to_string(),
                                                                                                                            (&v57).to_string(),
                                                                                                                            format!("{:?}", &v2947),
                                                                                                                            (&v63).to_string(),
                                                                                                                            (&v66).to_string()]);
                                                                                                                let v2961 =
                                                                                                                    core::ops::Deref::deref(&v2960);
                                                                                                                let v2963:
                                                                                                                        std::string::String =
                                                                                                                    format!("{:?}", ***v2961).clone();
                                                                                                                let v2966:
                                                                                                                        Array<std::string::String> =
                                                                                                                    array(&[(&v2787).to_string()]);
                                                                                                                let v2967 =
                                                                                                                    core::ops::Deref::deref(&v2966);
                                                                                                                let v2970:
                                                                                                                        std::string::String =
                                                                                                                    format!("{:?}", ***v2967).clone();
                                                                                                                let v2971:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v2970);
                                                                                                                let v2973:
                                                                                                                        &str =
                                                                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                                                                let v2974:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v2973);
                                                                                                                let v2975:
                                                                                                                        &regex::Regex =
                                                                                                                    &v2974.build().unwrap();
                                                                                                                let v2976:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v2971);
                                                                                                                let v2977:
                                                                                                                        &str =
                                                                                                                    &v2976.as_str();
                                                                                                                let v2978:
                                                                                                                        string =
                                                                                                                    Supervisor::method3();
                                                                                                                let v2979:
                                                                                                                        &str =
                                                                                                                    &v2978.as_str();
                                                                                                                let v2980:
                                                                                                                        std::string::String =
                                                                                                                    v2975.replace_all(&v2977, v2979).to_string();
                                                                                                                let v2981:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v2980);
                                                                                                                let v2983:
                                                                                                                        &str =
                                                                                                                    r#"\["(.*?)"\]"#;
                                                                                                                let v2984:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v2983);
                                                                                                                let v2985:
                                                                                                                        &regex::Regex =
                                                                                                                    &v2984.build().unwrap();
                                                                                                                let v2986:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v2981);
                                                                                                                let v2987:
                                                                                                                        &str =
                                                                                                                    &v2986.as_str();
                                                                                                                let v2988:
                                                                                                                        string =
                                                                                                                    Supervisor::method4();
                                                                                                                let v2989:
                                                                                                                        &str =
                                                                                                                    &v2988.as_str();
                                                                                                                let v2990:
                                                                                                                        std::string::String =
                                                                                                                    v2985.replace_all(&v2987, v2989).to_string();
                                                                                                                let v2991:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v2990);
                                                                                                                let v2993:
                                                                                                                        &str =
                                                                                                                    r#", "#;
                                                                                                                let v2994:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v2993);
                                                                                                                let v2995:
                                                                                                                        &regex::Regex =
                                                                                                                    &v2994.build().unwrap();
                                                                                                                let v2996:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v2991);
                                                                                                                let v2997:
                                                                                                                        &str =
                                                                                                                    &v2996.as_str();
                                                                                                                let v2998:
                                                                                                                        string =
                                                                                                                    Supervisor::method5();
                                                                                                                let v2999:
                                                                                                                        &str =
                                                                                                                    &v2998.as_str();
                                                                                                                let v3000:
                                                                                                                        std::string::String =
                                                                                                                    v2995.replace_all(&v2997, v2999).to_string();
                                                                                                                let v3001:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3000);
                                                                                                                let v3003:
                                                                                                                        std::string::String =
                                                                                                                    (&v3001).to_string().clone();
                                                                                                                let v3004:
                                                                                                                        colored::ColoredString =
                                                                                                                    colored::Colorize::color(&*v3003, v122.clone().to_string());
                                                                                                                let v3005:
                                                                                                                        std::string::String =
                                                                                                                    format!("{}", &v3004);
                                                                                                                let v3007:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&&v2940);
                                                                                                                let v3009:
                                                                                                                        &str =
                                                                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                                                                let v3010:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3009);
                                                                                                                let v3011:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3010.build().unwrap();
                                                                                                                let v3012:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3007);
                                                                                                                let v3013:
                                                                                                                        &str =
                                                                                                                    &v3012.as_str();
                                                                                                                let v3014:
                                                                                                                        string =
                                                                                                                    Supervisor::method3();
                                                                                                                let v3015:
                                                                                                                        &str =
                                                                                                                    &v3014.as_str();
                                                                                                                let v3016:
                                                                                                                        std::string::String =
                                                                                                                    v3011.replace_all(&v3013, v3015).to_string();
                                                                                                                let v3017:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3016);
                                                                                                                let v3019:
                                                                                                                        &str =
                                                                                                                    r#"\["(.*?)"\]"#;
                                                                                                                let v3020:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3019);
                                                                                                                let v3021:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3020.build().unwrap();
                                                                                                                let v3022:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3017);
                                                                                                                let v3023:
                                                                                                                        &str =
                                                                                                                    &v3022.as_str();
                                                                                                                let v3024:
                                                                                                                        string =
                                                                                                                    Supervisor::method4();
                                                                                                                let v3025:
                                                                                                                        &str =
                                                                                                                    &v3024.as_str();
                                                                                                                let v3026:
                                                                                                                        std::string::String =
                                                                                                                    v3021.replace_all(&v3023, v3025).to_string();
                                                                                                                let v3027:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3026);
                                                                                                                let v3029:
                                                                                                                        &str =
                                                                                                                    r#", "#;
                                                                                                                let v3030:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3029);
                                                                                                                let v3031:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3030.build().unwrap();
                                                                                                                let v3032:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3027);
                                                                                                                let v3033:
                                                                                                                        &str =
                                                                                                                    &v3032.as_str();
                                                                                                                let v3034:
                                                                                                                        string =
                                                                                                                    Supervisor::method5();
                                                                                                                let v3035:
                                                                                                                        &str =
                                                                                                                    &v3034.as_str();
                                                                                                                let v3036:
                                                                                                                        std::string::String =
                                                                                                                    v3031.replace_all(&v3033, v3035).to_string();
                                                                                                                let v3037:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3036);
                                                                                                                let v3039:
                                                                                                                        std::string::String =
                                                                                                                    (&v3037).to_string().clone();
                                                                                                                let v3040:
                                                                                                                        string =
                                                                                                                    substring2(v2864.clone(),
                                                                                                                               0i32,
                                                                                                                               2i32);
                                                                                                                let v3041:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3040, 16).unwrap();
                                                                                                                let v3042:
                                                                                                                        string =
                                                                                                                    substring2(v2864.clone(),
                                                                                                                               2i32,
                                                                                                                               2i32);
                                                                                                                let v3043:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3042, 16).unwrap();
                                                                                                                let v3044:
                                                                                                                        string =
                                                                                                                    substring2(v2864,
                                                                                                                               4i32,
                                                                                                                               2i32);
                                                                                                                let v3045:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3044, 16).unwrap();
                                                                                                                let v3046:
                                                                                                                        colored::ColoredString =
                                                                                                                    colored::Colorize::truecolor(&*v3039.to_string(), v3041, v3043, v3045);
                                                                                                                let v3047:
                                                                                                                        std::string::String =
                                                                                                                    format!("{}", &v3046);
                                                                                                                let v3049:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&&v2963);
                                                                                                                let v3051:
                                                                                                                        &str =
                                                                                                                    r#""([^"]+)", "([^"]+)""#;
                                                                                                                let v3052:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3051);
                                                                                                                let v3053:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3052.build().unwrap();
                                                                                                                let v3054:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3049);
                                                                                                                let v3055:
                                                                                                                        &str =
                                                                                                                    &v3054.as_str();
                                                                                                                let v3056:
                                                                                                                        string =
                                                                                                                    Supervisor::method3();
                                                                                                                let v3057:
                                                                                                                        &str =
                                                                                                                    &v3056.as_str();
                                                                                                                let v3058:
                                                                                                                        std::string::String =
                                                                                                                    v3053.replace_all(&v3055, v3057).to_string();
                                                                                                                let v3059:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3058);
                                                                                                                let v3061:
                                                                                                                        &str =
                                                                                                                    r#"\["(.*?)"\]"#;
                                                                                                                let v3062:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3061);
                                                                                                                let v3063:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3062.build().unwrap();
                                                                                                                let v3064:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3059);
                                                                                                                let v3065:
                                                                                                                        &str =
                                                                                                                    &v3064.as_str();
                                                                                                                let v3066:
                                                                                                                        string =
                                                                                                                    Supervisor::method4();
                                                                                                                let v3067:
                                                                                                                        &str =
                                                                                                                    &v3066.as_str();
                                                                                                                let v3068:
                                                                                                                        std::string::String =
                                                                                                                    v3063.replace_all(&v3065, v3067).to_string();
                                                                                                                let v3069:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3068);
                                                                                                                let v3071:
                                                                                                                        &str =
                                                                                                                    r#", "#;
                                                                                                                let v3072:
                                                                                                                        regex::RegexBuilder =
                                                                                                                    regex::RegexBuilder::new(&v3071);
                                                                                                                let v3073:
                                                                                                                        &regex::Regex =
                                                                                                                    &v3072.build().unwrap();
                                                                                                                let v3074:
                                                                                                                        string =
                                                                                                                    Supervisor::method2(v3069);
                                                                                                                let v3075:
                                                                                                                        &str =
                                                                                                                    &v3074.as_str();
                                                                                                                let v3076:
                                                                                                                        string =
                                                                                                                    Supervisor::method5();
                                                                                                                let v3077:
                                                                                                                        &str =
                                                                                                                    &v3076.as_str();
                                                                                                                let v3078:
                                                                                                                        std::string::String =
                                                                                                                    v3073.replace_all(&v3075, v3077).to_string();
                                                                                                                let v3079:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromStr(&v3078);
                                                                                                                let v3081:
                                                                                                                        std::string::String =
                                                                                                                    (&v3079).to_string().clone();
                                                                                                                let v3082:
                                                                                                                        string =
                                                                                                                    substring2(v206.clone(),
                                                                                                                               0i32,
                                                                                                                               2i32);
                                                                                                                let v3083:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3082, 16).unwrap();
                                                                                                                let v3084:
                                                                                                                        string =
                                                                                                                    substring2(v206.clone(),
                                                                                                                               2i32,
                                                                                                                               2i32);
                                                                                                                let v3085:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3084, 16).unwrap();
                                                                                                                let v3086:
                                                                                                                        string =
                                                                                                                    substring2(v206.clone(),
                                                                                                                               4i32,
                                                                                                                               2i32);
                                                                                                                let v3087:
                                                                                                                        u8 =
                                                                                                                    u8::from_str_radix(&v3086, 16).unwrap();
                                                                                                                let v3088:
                                                                                                                        colored::ColoredString =
                                                                                                                    colored::Colorize::truecolor(&*v3081.to_string(), v3083, v3085, v3087);
                                                                                                                let v3089:
                                                                                                                        std::string::String =
                                                                                                                    format!("{}", &v3088);
                                                                                                                println!("{0}",
                                                                                                                         stringFrom(format!("{0} {1} {2}", &v3005, &v3047, &v3089)));
                                                                                                                if v2926 > v2749
                                                                                                                   {
                                                                                                                    let v3093:
                                                                                                                            Result<std::string::String,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_to_string(&v735);
                                                                                                                    let v3094:
                                                                                                                            std::string::String =
                                                                                                                        (&v3093).as_ref().unwrap().to_string();
                                                                                                                    Supervisor::US0::US0_1(fable_library_rust::String_::fromStr(&v3094))
                                                                                                                } else {
                                                                                                                    std::thread::sleep(std::time::Duration::from_millis(*&25u64));
                                                                                                                    Supervisor::US0::US0_0
                                                                                                                }
                                                                                                            }
                                                                                                        };
                                                                                                    let v3102:
                                                                                                            i32 =
                                                                                                        v2921
                                                                                                            +
                                                                                                            1i32;
                                                                                                    v2919.l0.set(v3102);
                                                                                                    v2919.l1.set(v3101.clone());
                                                                                                    ()
                                                                                                }
                                                                                                {
                                                                                                    let v3103:
                                                                                                            Supervisor::US0 =
                                                                                                        v2919.l1.get().clone();
                                                                                                    let v3106:
                                                                                                            string =
                                                                                                        match &v3103
                                                                                                            {
                                                                                                            Supervisor::US0::US0_1(v3103_1_0)
                                                                                                            =>
                                                                                                            v3103_1_0.clone(),
                                                                                                            _
                                                                                                            =>
                                                                                                            v896,
                                                                                                        };
                                                                                                    let v3109:
                                                                                                            std::string::String =
                                                                                                        (&string("new_fsx len")).to_string().clone();
                                                                                                    let v3110:
                                                                                                            i32 =
                                                                                                        (&v3106).len().try_into().unwrap();
                                                                                                    let v3113:
                                                                                                            Array<std::string::String> =
                                                                                                        array(&[v3109,
                                                                                                                format!("{:?}", &v3110)]);
                                                                                                    let v3114 =
                                                                                                        core::ops::Deref::deref(&v3113);
                                                                                                    let v3116:
                                                                                                            std::string::String =
                                                                                                        format!("{:?}", ***v3114).clone();
                                                                                                    let v3117:
                                                                                                            chrono::DateTime<chrono::Utc> =
                                                                                                        chrono::Utc::now();
                                                                                                    let v3122:
                                                                                                            string =
                                                                                                        Supervisor::method1(6i32,
                                                                                                                            toString(&((&v3117).timestamp()
                                                                                                                                           -
                                                                                                                                           v9)));
                                                                                                    let v3123:
                                                                                                            u8 =
                                                                                                        rand::random::<u8>();
                                                                                                    let v3136:
                                                                                                            Array<std::string::String> =
                                                                                                        array(&[(&v52).to_string(),
                                                                                                                (&v3122).to_string(),
                                                                                                                (&v57).to_string(),
                                                                                                                format!("{:?}", &v3123),
                                                                                                                (&v63).to_string(),
                                                                                                                (&v66).to_string()]);
                                                                                                    let v3137 =
                                                                                                        core::ops::Deref::deref(&v3136);
                                                                                                    let v3139:
                                                                                                            std::string::String =
                                                                                                        format!("{:?}", ***v3137).clone();
                                                                                                    let v3142:
                                                                                                            Array<std::string::String> =
                                                                                                        array(&[(&v73).to_string()]);
                                                                                                    let v3143 =
                                                                                                        core::ops::Deref::deref(&v3142);
                                                                                                    let v3146:
                                                                                                            std::string::String =
                                                                                                        format!("{:?}", ***v3143).clone();
                                                                                                    let v3147:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3146);
                                                                                                    let v3149:
                                                                                                            &str =
                                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                                    let v3150:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3149);
                                                                                                    let v3151:
                                                                                                            &regex::Regex =
                                                                                                        &v3150.build().unwrap();
                                                                                                    let v3152:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3147);
                                                                                                    let v3153:
                                                                                                            &str =
                                                                                                        &v3152.as_str();
                                                                                                    let v3154:
                                                                                                            string =
                                                                                                        Supervisor::method3();
                                                                                                    let v3155:
                                                                                                            &str =
                                                                                                        &v3154.as_str();
                                                                                                    let v3156:
                                                                                                            std::string::String =
                                                                                                        v3151.replace_all(&v3153, v3155).to_string();
                                                                                                    let v3157:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3156);
                                                                                                    let v3159:
                                                                                                            &str =
                                                                                                        r#"\["(.*?)"\]"#;
                                                                                                    let v3160:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3159);
                                                                                                    let v3161:
                                                                                                            &regex::Regex =
                                                                                                        &v3160.build().unwrap();
                                                                                                    let v3162:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3157);
                                                                                                    let v3163:
                                                                                                            &str =
                                                                                                        &v3162.as_str();
                                                                                                    let v3164:
                                                                                                            string =
                                                                                                        Supervisor::method4();
                                                                                                    let v3165:
                                                                                                            &str =
                                                                                                        &v3164.as_str();
                                                                                                    let v3166:
                                                                                                            std::string::String =
                                                                                                        v3161.replace_all(&v3163, v3165).to_string();
                                                                                                    let v3167:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3166);
                                                                                                    let v3169:
                                                                                                            &str =
                                                                                                        r#", "#;
                                                                                                    let v3170:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3169);
                                                                                                    let v3171:
                                                                                                            &regex::Regex =
                                                                                                        &v3170.build().unwrap();
                                                                                                    let v3172:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3167);
                                                                                                    let v3173:
                                                                                                            &str =
                                                                                                        &v3172.as_str();
                                                                                                    let v3174:
                                                                                                            string =
                                                                                                        Supervisor::method5();
                                                                                                    let v3175:
                                                                                                            &str =
                                                                                                        &v3174.as_str();
                                                                                                    let v3176:
                                                                                                            std::string::String =
                                                                                                        v3171.replace_all(&v3173, v3175).to_string();
                                                                                                    let v3177:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3176);
                                                                                                    let v3179:
                                                                                                            std::string::String =
                                                                                                        (&v3177).to_string().clone();
                                                                                                    let v3180:
                                                                                                            colored::ColoredString =
                                                                                                        colored::Colorize::color(&*v3179, v122.clone().to_string());
                                                                                                    let v3181:
                                                                                                            std::string::String =
                                                                                                        format!("{}", &v3180);
                                                                                                    let v3183:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&&v3116);
                                                                                                    let v3185:
                                                                                                            &str =
                                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                                    let v3186:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3185);
                                                                                                    let v3187:
                                                                                                            &regex::Regex =
                                                                                                        &v3186.build().unwrap();
                                                                                                    let v3188:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3183);
                                                                                                    let v3189:
                                                                                                            &str =
                                                                                                        &v3188.as_str();
                                                                                                    let v3190:
                                                                                                            string =
                                                                                                        Supervisor::method3();
                                                                                                    let v3191:
                                                                                                            &str =
                                                                                                        &v3190.as_str();
                                                                                                    let v3192:
                                                                                                            std::string::String =
                                                                                                        v3187.replace_all(&v3189, v3191).to_string();
                                                                                                    let v3193:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3192);
                                                                                                    let v3195:
                                                                                                            &str =
                                                                                                        r#"\["(.*?)"\]"#;
                                                                                                    let v3196:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3195);
                                                                                                    let v3197:
                                                                                                            &regex::Regex =
                                                                                                        &v3196.build().unwrap();
                                                                                                    let v3198:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3193);
                                                                                                    let v3199:
                                                                                                            &str =
                                                                                                        &v3198.as_str();
                                                                                                    let v3200:
                                                                                                            string =
                                                                                                        Supervisor::method4();
                                                                                                    let v3201:
                                                                                                            &str =
                                                                                                        &v3200.as_str();
                                                                                                    let v3202:
                                                                                                            std::string::String =
                                                                                                        v3197.replace_all(&v3199, v3201).to_string();
                                                                                                    let v3203:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3202);
                                                                                                    let v3205:
                                                                                                            &str =
                                                                                                        r#", "#;
                                                                                                    let v3206:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3205);
                                                                                                    let v3207:
                                                                                                            &regex::Regex =
                                                                                                        &v3206.build().unwrap();
                                                                                                    let v3208:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3203);
                                                                                                    let v3209:
                                                                                                            &str =
                                                                                                        &v3208.as_str();
                                                                                                    let v3210:
                                                                                                            string =
                                                                                                        Supervisor::method5();
                                                                                                    let v3211:
                                                                                                            &str =
                                                                                                        &v3210.as_str();
                                                                                                    let v3212:
                                                                                                            std::string::String =
                                                                                                        v3207.replace_all(&v3209, v3211).to_string();
                                                                                                    let v3213:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3212);
                                                                                                    let v3215:
                                                                                                            std::string::String =
                                                                                                        (&v3213).to_string().clone();
                                                                                                    let v3216:
                                                                                                            string =
                                                                                                        substring2(v161.clone(),
                                                                                                                   0i32,
                                                                                                                   2i32);
                                                                                                    let v3217:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3216, 16).unwrap();
                                                                                                    let v3218:
                                                                                                            string =
                                                                                                        substring2(v161.clone(),
                                                                                                                   2i32,
                                                                                                                   2i32);
                                                                                                    let v3219:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3218, 16).unwrap();
                                                                                                    let v3220:
                                                                                                            string =
                                                                                                        substring2(v161.clone(),
                                                                                                                   4i32,
                                                                                                                   2i32);
                                                                                                    let v3221:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3220, 16).unwrap();
                                                                                                    let v3222:
                                                                                                            colored::ColoredString =
                                                                                                        colored::Colorize::truecolor(&*v3215.to_string(), v3217, v3219, v3221);
                                                                                                    let v3223:
                                                                                                            std::string::String =
                                                                                                        format!("{}", &v3222);
                                                                                                    let v3225:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&&v3139);
                                                                                                    let v3227:
                                                                                                            &str =
                                                                                                        r#""([^"]+)", "([^"]+)""#;
                                                                                                    let v3228:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3227);
                                                                                                    let v3229:
                                                                                                            &regex::Regex =
                                                                                                        &v3228.build().unwrap();
                                                                                                    let v3230:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3225);
                                                                                                    let v3231:
                                                                                                            &str =
                                                                                                        &v3230.as_str();
                                                                                                    let v3232:
                                                                                                            string =
                                                                                                        Supervisor::method3();
                                                                                                    let v3233:
                                                                                                            &str =
                                                                                                        &v3232.as_str();
                                                                                                    let v3234:
                                                                                                            std::string::String =
                                                                                                        v3229.replace_all(&v3231, v3233).to_string();
                                                                                                    let v3235:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3234);
                                                                                                    let v3237:
                                                                                                            &str =
                                                                                                        r#"\["(.*?)"\]"#;
                                                                                                    let v3238:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3237);
                                                                                                    let v3239:
                                                                                                            &regex::Regex =
                                                                                                        &v3238.build().unwrap();
                                                                                                    let v3240:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3235);
                                                                                                    let v3241:
                                                                                                            &str =
                                                                                                        &v3240.as_str();
                                                                                                    let v3242:
                                                                                                            string =
                                                                                                        Supervisor::method4();
                                                                                                    let v3243:
                                                                                                            &str =
                                                                                                        &v3242.as_str();
                                                                                                    let v3244:
                                                                                                            std::string::String =
                                                                                                        v3239.replace_all(&v3241, v3243).to_string();
                                                                                                    let v3245:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3244);
                                                                                                    let v3247:
                                                                                                            &str =
                                                                                                        r#", "#;
                                                                                                    let v3248:
                                                                                                            regex::RegexBuilder =
                                                                                                        regex::RegexBuilder::new(&v3247);
                                                                                                    let v3249:
                                                                                                            &regex::Regex =
                                                                                                        &v3248.build().unwrap();
                                                                                                    let v3250:
                                                                                                            string =
                                                                                                        Supervisor::method2(v3245);
                                                                                                    let v3251:
                                                                                                            &str =
                                                                                                        &v3250.as_str();
                                                                                                    let v3252:
                                                                                                            string =
                                                                                                        Supervisor::method5();
                                                                                                    let v3253:
                                                                                                            &str =
                                                                                                        &v3252.as_str();
                                                                                                    let v3254:
                                                                                                            std::string::String =
                                                                                                        v3249.replace_all(&v3251, v3253).to_string();
                                                                                                    let v3255:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromStr(&v3254);
                                                                                                    let v3257:
                                                                                                            std::string::String =
                                                                                                        (&v3255).to_string().clone();
                                                                                                    let v3258:
                                                                                                            string =
                                                                                                        substring2(v206.clone(),
                                                                                                                   0i32,
                                                                                                                   2i32);
                                                                                                    let v3259:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3258, 16).unwrap();
                                                                                                    let v3260:
                                                                                                            string =
                                                                                                        substring2(v206.clone(),
                                                                                                                   2i32,
                                                                                                                   2i32);
                                                                                                    let v3261:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3260, 16).unwrap();
                                                                                                    let v3262:
                                                                                                            string =
                                                                                                        substring2(v206.clone(),
                                                                                                                   4i32,
                                                                                                                   2i32);
                                                                                                    let v3263:
                                                                                                            u8 =
                                                                                                        u8::from_str_radix(&v3262, 16).unwrap();
                                                                                                    let v3264:
                                                                                                            colored::ColoredString =
                                                                                                        colored::Colorize::truecolor(&*v3257.to_string(), v3259, v3261, v3263);
                                                                                                    let v3265:
                                                                                                            std::string::String =
                                                                                                        format!("{}", &v3264);
                                                                                                    println!("{0}",
                                                                                                             stringFrom(format!("{0} {1} {2}", &v3181, &v3223, &v3265)));
                                                                                                    {
                                                                                                        let v3267:
                                                                                                                std::path::PathBuf =
                                                                                                            defaultValue(v735,
                                                                                                                         v1);
                                                                                                        let v3268:
                                                                                                                Result<(),
                                                                                                                       std::io::Error> =
                                                                                                            std::fs::write(v3267, v3106.clone().as_str());
                                                                                                        *((&v3268).as_ref()).unwrap();
                                                                                                        {
                                                                                                            let v3271:
                                                                                                                    std::string::String =
                                                                                                                (&string("> fs_write new_fsx_path; ok")).to_string().clone();
                                                                                                            let v3272:
                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                chrono::Utc::now();
                                                                                                            let v3277:
                                                                                                                    string =
                                                                                                                Supervisor::method1(6i32,
                                                                                                                                    toString(&((&v3272).timestamp()
                                                                                                                                                   -
                                                                                                                                                   v9)));
                                                                                                            let v3278:
                                                                                                                    u8 =
                                                                                                                rand::random::<u8>();
                                                                                                            let v3291:
                                                                                                                    Array<std::string::String> =
                                                                                                                array(&[(&v52).to_string(),
                                                                                                                        (&v3277).to_string(),
                                                                                                                        (&v57).to_string(),
                                                                                                                        format!("{:?}", &v3278),
                                                                                                                        (&v63).to_string(),
                                                                                                                        (&v66).to_string()]);
                                                                                                            let v3292 =
                                                                                                                core::ops::Deref::deref(&v3291);
                                                                                                            let v3294:
                                                                                                                    std::string::String =
                                                                                                                format!("{:?}", ***v3292).clone();
                                                                                                            let v3297:
                                                                                                                    Array<std::string::String> =
                                                                                                                array(&[(&v73).to_string()]);
                                                                                                            let v3298 =
                                                                                                                core::ops::Deref::deref(&v3297);
                                                                                                            let v3301:
                                                                                                                    std::string::String =
                                                                                                                format!("{:?}", ***v3298).clone();
                                                                                                            let v3302:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3301);
                                                                                                            let v3304:
                                                                                                                    &str =
                                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                                            let v3305:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3304);
                                                                                                            let v3306:
                                                                                                                    &regex::Regex =
                                                                                                                &v3305.build().unwrap();
                                                                                                            let v3307:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3302);
                                                                                                            let v3308:
                                                                                                                    &str =
                                                                                                                &v3307.as_str();
                                                                                                            let v3309:
                                                                                                                    string =
                                                                                                                Supervisor::method3();
                                                                                                            let v3310:
                                                                                                                    &str =
                                                                                                                &v3309.as_str();
                                                                                                            let v3311:
                                                                                                                    std::string::String =
                                                                                                                v3306.replace_all(&v3308, v3310).to_string();
                                                                                                            let v3312:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3311);
                                                                                                            let v3314:
                                                                                                                    &str =
                                                                                                                r#"\["(.*?)"\]"#;
                                                                                                            let v3315:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3314);
                                                                                                            let v3316:
                                                                                                                    &regex::Regex =
                                                                                                                &v3315.build().unwrap();
                                                                                                            let v3317:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3312);
                                                                                                            let v3318:
                                                                                                                    &str =
                                                                                                                &v3317.as_str();
                                                                                                            let v3319:
                                                                                                                    string =
                                                                                                                Supervisor::method4();
                                                                                                            let v3320:
                                                                                                                    &str =
                                                                                                                &v3319.as_str();
                                                                                                            let v3321:
                                                                                                                    std::string::String =
                                                                                                                v3316.replace_all(&v3318, v3320).to_string();
                                                                                                            let v3322:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3321);
                                                                                                            let v3324:
                                                                                                                    &str =
                                                                                                                r#", "#;
                                                                                                            let v3325:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3324);
                                                                                                            let v3326:
                                                                                                                    &regex::Regex =
                                                                                                                &v3325.build().unwrap();
                                                                                                            let v3327:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3322);
                                                                                                            let v3328:
                                                                                                                    &str =
                                                                                                                &v3327.as_str();
                                                                                                            let v3329:
                                                                                                                    string =
                                                                                                                Supervisor::method5();
                                                                                                            let v3330:
                                                                                                                    &str =
                                                                                                                &v3329.as_str();
                                                                                                            let v3331:
                                                                                                                    std::string::String =
                                                                                                                v3326.replace_all(&v3328, v3330).to_string();
                                                                                                            let v3332:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3331);
                                                                                                            let v3334:
                                                                                                                    std::string::String =
                                                                                                                (&v3332).to_string().clone();
                                                                                                            let v3335:
                                                                                                                    colored::ColoredString =
                                                                                                                colored::Colorize::color(&*v3334, v122.to_string());
                                                                                                            let v3336:
                                                                                                                    std::string::String =
                                                                                                                format!("{}", &v3335);
                                                                                                            let v3338:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&&v3271);
                                                                                                            let v3340:
                                                                                                                    &str =
                                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                                            let v3341:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3340);
                                                                                                            let v3342:
                                                                                                                    &regex::Regex =
                                                                                                                &v3341.build().unwrap();
                                                                                                            let v3343:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3338);
                                                                                                            let v3344:
                                                                                                                    &str =
                                                                                                                &v3343.as_str();
                                                                                                            let v3345:
                                                                                                                    string =
                                                                                                                Supervisor::method3();
                                                                                                            let v3346:
                                                                                                                    &str =
                                                                                                                &v3345.as_str();
                                                                                                            let v3347:
                                                                                                                    std::string::String =
                                                                                                                v3342.replace_all(&v3344, v3346).to_string();
                                                                                                            let v3348:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3347);
                                                                                                            let v3350:
                                                                                                                    &str =
                                                                                                                r#"\["(.*?)"\]"#;
                                                                                                            let v3351:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3350);
                                                                                                            let v3352:
                                                                                                                    &regex::Regex =
                                                                                                                &v3351.build().unwrap();
                                                                                                            let v3353:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3348);
                                                                                                            let v3354:
                                                                                                                    &str =
                                                                                                                &v3353.as_str();
                                                                                                            let v3355:
                                                                                                                    string =
                                                                                                                Supervisor::method4();
                                                                                                            let v3356:
                                                                                                                    &str =
                                                                                                                &v3355.as_str();
                                                                                                            let v3357:
                                                                                                                    std::string::String =
                                                                                                                v3352.replace_all(&v3354, v3356).to_string();
                                                                                                            let v3358:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3357);
                                                                                                            let v3360:
                                                                                                                    &str =
                                                                                                                r#", "#;
                                                                                                            let v3361:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3360);
                                                                                                            let v3362:
                                                                                                                    &regex::Regex =
                                                                                                                &v3361.build().unwrap();
                                                                                                            let v3363:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3358);
                                                                                                            let v3364:
                                                                                                                    &str =
                                                                                                                &v3363.as_str();
                                                                                                            let v3365:
                                                                                                                    string =
                                                                                                                Supervisor::method5();
                                                                                                            let v3366:
                                                                                                                    &str =
                                                                                                                &v3365.as_str();
                                                                                                            let v3367:
                                                                                                                    std::string::String =
                                                                                                                v3362.replace_all(&v3364, v3366).to_string();
                                                                                                            let v3368:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3367);
                                                                                                            let v3370:
                                                                                                                    std::string::String =
                                                                                                                (&v3368).to_string().clone();
                                                                                                            let v3371:
                                                                                                                    string =
                                                                                                                substring2(v161.clone(),
                                                                                                                           0i32,
                                                                                                                           2i32);
                                                                                                            let v3372:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3371, 16).unwrap();
                                                                                                            let v3373:
                                                                                                                    string =
                                                                                                                substring2(v161.clone(),
                                                                                                                           2i32,
                                                                                                                           2i32);
                                                                                                            let v3374:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3373, 16).unwrap();
                                                                                                            let v3375:
                                                                                                                    string =
                                                                                                                substring2(v161,
                                                                                                                           4i32,
                                                                                                                           2i32);
                                                                                                            let v3376:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3375, 16).unwrap();
                                                                                                            let v3377:
                                                                                                                    colored::ColoredString =
                                                                                                                colored::Colorize::truecolor(&*v3370.to_string(), v3372, v3374, v3376);
                                                                                                            let v3378:
                                                                                                                    std::string::String =
                                                                                                                format!("{}", &v3377);
                                                                                                            let v3380:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&&v3294);
                                                                                                            let v3382:
                                                                                                                    &str =
                                                                                                                r#""([^"]+)", "([^"]+)""#;
                                                                                                            let v3383:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3382);
                                                                                                            let v3384:
                                                                                                                    &regex::Regex =
                                                                                                                &v3383.build().unwrap();
                                                                                                            let v3385:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3380);
                                                                                                            let v3386:
                                                                                                                    &str =
                                                                                                                &v3385.as_str();
                                                                                                            let v3387:
                                                                                                                    string =
                                                                                                                Supervisor::method3();
                                                                                                            let v3388:
                                                                                                                    &str =
                                                                                                                &v3387.as_str();
                                                                                                            let v3389:
                                                                                                                    std::string::String =
                                                                                                                v3384.replace_all(&v3386, v3388).to_string();
                                                                                                            let v3390:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3389);
                                                                                                            let v3392:
                                                                                                                    &str =
                                                                                                                r#"\["(.*?)"\]"#;
                                                                                                            let v3393:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3392);
                                                                                                            let v3394:
                                                                                                                    &regex::Regex =
                                                                                                                &v3393.build().unwrap();
                                                                                                            let v3395:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3390);
                                                                                                            let v3396:
                                                                                                                    &str =
                                                                                                                &v3395.as_str();
                                                                                                            let v3397:
                                                                                                                    string =
                                                                                                                Supervisor::method4();
                                                                                                            let v3398:
                                                                                                                    &str =
                                                                                                                &v3397.as_str();
                                                                                                            let v3399:
                                                                                                                    std::string::String =
                                                                                                                v3394.replace_all(&v3396, v3398).to_string();
                                                                                                            let v3400:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3399);
                                                                                                            let v3402:
                                                                                                                    &str =
                                                                                                                r#", "#;
                                                                                                            let v3403:
                                                                                                                    regex::RegexBuilder =
                                                                                                                regex::RegexBuilder::new(&v3402);
                                                                                                            let v3404:
                                                                                                                    &regex::Regex =
                                                                                                                &v3403.build().unwrap();
                                                                                                            let v3405:
                                                                                                                    string =
                                                                                                                Supervisor::method2(v3400);
                                                                                                            let v3406:
                                                                                                                    &str =
                                                                                                                &v3405.as_str();
                                                                                                            let v3407:
                                                                                                                    string =
                                                                                                                Supervisor::method5();
                                                                                                            let v3408:
                                                                                                                    &str =
                                                                                                                &v3407.as_str();
                                                                                                            let v3409:
                                                                                                                    std::string::String =
                                                                                                                v3404.replace_all(&v3406, v3408).to_string();
                                                                                                            let v3410:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromStr(&v3409);
                                                                                                            let v3412:
                                                                                                                    std::string::String =
                                                                                                                (&v3410).to_string().clone();
                                                                                                            let v3413:
                                                                                                                    string =
                                                                                                                substring2(v206.clone(),
                                                                                                                           0i32,
                                                                                                                           2i32);
                                                                                                            let v3414:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3413, 16).unwrap();
                                                                                                            let v3415:
                                                                                                                    string =
                                                                                                                substring2(v206.clone(),
                                                                                                                           2i32,
                                                                                                                           2i32);
                                                                                                            let v3416:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3415, 16).unwrap();
                                                                                                            let v3417:
                                                                                                                    string =
                                                                                                                substring2(v206,
                                                                                                                           4i32,
                                                                                                                           2i32);
                                                                                                            let v3418:
                                                                                                                    u8 =
                                                                                                                u8::from_str_radix(&v3417, 16).unwrap();
                                                                                                            let v3419:
                                                                                                                    colored::ColoredString =
                                                                                                                colored::Colorize::truecolor(&*v3412.to_string(), v3414, v3416, v3418);
                                                                                                            let v3420:
                                                                                                                    std::string::String =
                                                                                                                format!("{}", &v3419);
                                                                                                            println!("{0}",
                                                                                                                     stringFrom(format!("{0} {1} {2}", &v3336, &v3378, &v3420)));
                                                                                                            v3106
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
