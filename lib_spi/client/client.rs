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
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
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
    pub fn method6() -> string { string("387957") }
    pub fn method7() -> string { string("385779") }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let patternInput: (string, string, string, bool) = Client::method0();
        let v5: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v7: i64 = (&v5).timestamp();
        let v9 = web_sys::window().unwrap();
        let v11 = v9.document().unwrap();
        let v13 = v11.body().unwrap();
        let v16: &str = r#"iframe"#;
        let v18 = v11.create_element(v16).unwrap();
        let v40: Array<std::string::String> =
            array(&[(&string("window")).to_string(), format!("{:?}", v9),
                    (&string("document")).to_string(), format!("{:?}", v11),
                    (&string("body")).to_string(), format!("{:?}", v13),
                    (&string("iframe")).to_string(), format!("{:?}", v18)]);
        let v42 = core::ops::Deref::deref(&v40);
        let v44 = &***&v42;
        let v45 = &***&v44;
        let v47: std::string::String = format!("{:?}", &v45).clone();
        let v48: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v53: string =
            Client::method1(6i32, toString(&((&v48).timestamp() - v7)));
        let v55: u8 = rand::random::<u8>();
        let v56: string = string("timestamp");
        let v61: string = string("run_id");
        let v66: string = string("log_level");
        let v69: string = string("Debug");
        let v72: Array<std::string::String> =
            array(&[(&v56).to_string(), (&v53).to_string(),
                    (&v61).to_string(), format!("{:?}", &v55),
                    (&v66).to_string(), (&v69).to_string()]);
        let v73 = core::ops::Deref::deref(&v72);
        let v74 = &***&v73;
        let v75 = &***&v74;
        let v77: std::string::String = format!("{:?}", &v75).clone();
        let v78: string = string("> app ()");
        let v81: Array<std::string::String> = array(&[(&v78).to_string()]);
        let v82 = core::ops::Deref::deref(&v81);
        let v83 = &***&v82;
        let v84 = &***&v83;
        let v86: std::string::String = format!("{:?}", &v84).clone();
        let v89: string = toString(&format!("{}", &v86));
        let v92: &str = r#""([^"]+)", "([^"]+)""#;
        let v94: regex::RegexBuilder = regex::RegexBuilder::new(&v92);
        let v96: &regex::Regex = &v94.build().unwrap();
        let v97: string = Client::method2(v89);
        let v99: &str = &v97.as_str();
        let v100: string = Client::method3();
        let v101: &str = &v100.as_str();
        let v103: std::string::String =
            v96.replace_all(&v99, v101).to_string();
        let v105: string = fable_library_rust::String_::fromStr(&v103);
        let v108: &str = r#"\["(.*?)"\]"#;
        let v109: regex::RegexBuilder = regex::RegexBuilder::new(&v108);
        let v110: &regex::Regex = &v109.build().unwrap();
        let v111: string = Client::method2(v105);
        let v112: &str = &v111.as_str();
        let v113: string = Client::method4();
        let v114: &str = &v113.as_str();
        let v115: std::string::String =
            v110.replace_all(&v112, v114).to_string();
        let v116: string = fable_library_rust::String_::fromStr(&v115);
        let v119: &str = r#", "#;
        let v120: regex::RegexBuilder = regex::RegexBuilder::new(&v119);
        let v121: &regex::Regex = &v120.build().unwrap();
        let v122: string = Client::method2(v116);
        let v123: &str = &v122.as_str();
        let v124: string = Client::method5();
        let v125: &str = &v124.as_str();
        let v126: std::string::String =
            v121.replace_all(&v123, v125).to_string();
        let v127: string = fable_library_rust::String_::fromStr(&v126);
        let v129: std::string::String = (&v127).to_string().clone();
        let v131: string = toString(&format!("{}", &v47));
        let v133: &str = r#""([^"]+)", "([^"]+)""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Client::method2(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Client::method3();
        let v139: &str = &v138.as_str();
        let v140: std::string::String =
            v135.replace_all(&v137, v139).to_string();
        let v141: string = fable_library_rust::String_::fromStr(&v140);
        let v143: &str = r#"\["(.*?)"\]"#;
        let v144: regex::RegexBuilder = regex::RegexBuilder::new(&v143);
        let v145: &regex::Regex = &v144.build().unwrap();
        let v146: string = Client::method2(v141);
        let v147: &str = &v146.as_str();
        let v148: string = Client::method4();
        let v149: &str = &v148.as_str();
        let v150: std::string::String =
            v145.replace_all(&v147, v149).to_string();
        let v151: string = fable_library_rust::String_::fromStr(&v150);
        let v153: &str = r#", "#;
        let v154: regex::RegexBuilder = regex::RegexBuilder::new(&v153);
        let v155: &regex::Regex = &v154.build().unwrap();
        let v156: string = Client::method2(v151);
        let v157: &str = &v156.as_str();
        let v158: string = Client::method5();
        let v159: &str = &v158.as_str();
        let v160: std::string::String =
            v155.replace_all(&v157, v159).to_string();
        let v161: string = fable_library_rust::String_::fromStr(&v160);
        let v163: std::string::String = (&v161).to_string().clone();
        let v165: string = toString(&format!("{}", &v77));
        let v167: &str = r#""([^"]+)", "([^"]+)""#;
        let v168: regex::RegexBuilder = regex::RegexBuilder::new(&v167);
        let v169: &regex::Regex = &v168.build().unwrap();
        let v170: string = Client::method2(v165);
        let v171: &str = &v170.as_str();
        let v172: string = Client::method3();
        let v173: &str = &v172.as_str();
        let v174: std::string::String =
            v169.replace_all(&v171, v173).to_string();
        let v175: string = fable_library_rust::String_::fromStr(&v174);
        let v177: &str = r#"\["(.*?)"\]"#;
        let v178: regex::RegexBuilder = regex::RegexBuilder::new(&v177);
        let v179: &regex::Regex = &v178.build().unwrap();
        let v180: string = Client::method2(v175);
        let v181: &str = &v180.as_str();
        let v182: string = Client::method4();
        let v183: &str = &v182.as_str();
        let v184: std::string::String =
            v179.replace_all(&v181, v183).to_string();
        let v185: string = fable_library_rust::String_::fromStr(&v184);
        let v187: &str = r#", "#;
        let v188: regex::RegexBuilder = regex::RegexBuilder::new(&v187);
        let v189: &regex::Regex = &v188.build().unwrap();
        let v190: string = Client::method2(v185);
        let v191: &str = &v190.as_str();
        let v192: string = Client::method5();
        let v193: &str = &v192.as_str();
        let v194: std::string::String =
            v189.replace_all(&v191, v193).to_string();
        let v195: string = fable_library_rust::String_::fromStr(&v194);
        let v197: std::string::String = (&v195).to_string().clone();
        if let Client::US0::US0_1 =
               &if cfg!(target_arch = "wasm32") {
                    Client::US0::US0_1
                } else { Client::US0::US0_0 } {
            let v206: string = string(" %c");
            let v210: string =
                append(append(append(append(toString(&v129), v206.clone()),
                                     toString(&v163)), v206),
                       toString(&v197));
            let v218: Array<std::string::String> =
                array(&[(&v210).as_ref().to_string(),
                        (&stringFrom(format!("color: #{0};",
                                             &string("387957")))).as_ref().to_string(),
                        (&string("color: #385779;")).as_ref().to_string()]);
            let v219 = core::ops::Deref::deref(&v218);
            let v222 = serde_wasm_bindgen::to_value(&*****&v219).unwrap();
            web_sys::console::log(&js_sys::Array::from(&v222));
            ()
        } else {
            let v224: string = Client::method6();
            let v225: &str = &v224.as_str();
            let v229: &str = &v225[0i32 as usize..2i32 as usize];
            let v230: string = fable_library_rust::String_::fromStr(&v229);
            let v232: u8 = u8::from_str_radix(&v230, 16).unwrap();
            let v233: string = Client::method6();
            let v234: &str = &v233.as_str();
            let v237: &str = &v234[2i32 as usize..4i32 as usize];
            let v238: string = fable_library_rust::String_::fromStr(&v237);
            let v239: u8 = u8::from_str_radix(&v238, 16).unwrap();
            let v240: string = Client::method6();
            let v241: &str = &v240.as_str();
            let v244: &str = &v241[4i32 as usize..6i32 as usize];
            let v245: string = fable_library_rust::String_::fromStr(&v244);
            let v246: u8 = u8::from_str_radix(&v245, 16).unwrap();
            let v248: colored::ColoredString =
                colored::Colorize::truecolor(&*v163.to_string(), v232, v239, v246);
            let v249: std::string::String = format!("{}", &v248);
            let v250: string = Client::method7();
            let v251: &str = &v250.as_str();
            let v254: &str = &v251[0i32 as usize..2i32 as usize];
            let v255: string = fable_library_rust::String_::fromStr(&v254);
            let v256: u8 = u8::from_str_radix(&v255, 16).unwrap();
            let v257: string = Client::method7();
            let v258: &str = &v257.as_str();
            let v261: &str = &v258[2i32 as usize..4i32 as usize];
            let v262: string = fable_library_rust::String_::fromStr(&v261);
            let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
            let v264: string = Client::method7();
            let v265: &str = &v264.as_str();
            let v268: &str = &v265[4i32 as usize..6i32 as usize];
            let v269: string = fable_library_rust::String_::fromStr(&v268);
            let v270: u8 = u8::from_str_radix(&v269, 16).unwrap();
            let v271: colored::ColoredString =
                colored::Colorize::truecolor(&*v197.to_string(), v256, v263, v270);
            let v272: std::string::String = format!("{}", &v271);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v129, &v249, &v272)));
            ()
        }
        {
            let v276: &str = r#"src"#;
            let v279: &str = r#"https://time.is"#;
            v18.set_attribute(v276, v279).unwrap();
            {
                let v283: &str = r#"width"#;
                let v286: &str = r#"100%"#;
                v18.set_attribute(v283, v286).unwrap();
                {
                    let v289: &str = r#"style"#;
                    let v292: &str = r#"height: 100vh; border: 0;"#;
                    v18.set_attribute(v289, v292).unwrap();
                    {
                        let v295: &str = r#"data-test"#;
                        let v298: &str = r#"1"#;
                        v18.set_attribute(v295, v298).unwrap();
                        v13.append_child(&v18).unwrap();
                        {
                            let v306: Array<std::string::String> =
                                array(&[(&string("app end")).to_string(),
                                        (&string("???")).to_string()]);
                            let v307 = core::ops::Deref::deref(&v306);
                            let v308 = &***&v307;
                            let v309 = &***&v308;
                            let v311: std::string::String =
                                format!("{:?}", &v309).clone();
                            let v312: chrono::DateTime<chrono::Utc> =
                                chrono::Utc::now();
                            let v317: string =
                                Client::method1(6i32,
                                                toString(&((&v312).timestamp()
                                                               - v7)));
                            let v318: u8 = rand::random::<u8>();
                            let v331: Array<std::string::String> =
                                array(&[(&v56).to_string(),
                                        (&v317).to_string(),
                                        (&v61).to_string(),
                                        format!("{:?}", &v318),
                                        (&v66).to_string(),
                                        (&v69).to_string()]);
                            let v332 = core::ops::Deref::deref(&v331);
                            let v333 = &***&v332;
                            let v334 = &***&v333;
                            let v336: std::string::String =
                                format!("{:?}", &v334).clone();
                            let v339: Array<std::string::String> =
                                array(&[(&v78).to_string()]);
                            let v340 = core::ops::Deref::deref(&v339);
                            let v341 = &***&v340;
                            let v342 = &***&v341;
                            let v344: std::string::String =
                                format!("{:?}", &v342).clone();
                            let v346: string =
                                toString(&format!("{}", &v344));
                            let v348: &str = r#""([^"]+)", "([^"]+)""#;
                            let v349: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v348);
                            let v350: &regex::Regex = &v349.build().unwrap();
                            let v351: string = Client::method2(v346);
                            let v352: &str = &v351.as_str();
                            let v353: string = Client::method3();
                            let v354: &str = &v353.as_str();
                            let v355: std::string::String =
                                v350.replace_all(&v352, v354).to_string();
                            let v356: string =
                                fable_library_rust::String_::fromStr(&v355);
                            let v358: &str = r#"\["(.*?)"\]"#;
                            let v359: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v358);
                            let v360: &regex::Regex = &v359.build().unwrap();
                            let v361: string = Client::method2(v356);
                            let v362: &str = &v361.as_str();
                            let v363: string = Client::method4();
                            let v364: &str = &v363.as_str();
                            let v365: std::string::String =
                                v360.replace_all(&v362, v364).to_string();
                            let v366: string =
                                fable_library_rust::String_::fromStr(&v365);
                            let v368: &str = r#", "#;
                            let v369: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v368);
                            let v370: &regex::Regex = &v369.build().unwrap();
                            let v371: string = Client::method2(v366);
                            let v372: &str = &v371.as_str();
                            let v373: string = Client::method5();
                            let v374: &str = &v373.as_str();
                            let v375: std::string::String =
                                v370.replace_all(&v372, v374).to_string();
                            let v376: string =
                                fable_library_rust::String_::fromStr(&v375);
                            let v378: std::string::String =
                                (&v376).to_string().clone();
                            let v380: string =
                                toString(&format!("{}", &v311));
                            let v382: &str = r#""([^"]+)", "([^"]+)""#;
                            let v383: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v382);
                            let v384: &regex::Regex = &v383.build().unwrap();
                            let v385: string = Client::method2(v380);
                            let v386: &str = &v385.as_str();
                            let v387: string = Client::method3();
                            let v388: &str = &v387.as_str();
                            let v389: std::string::String =
                                v384.replace_all(&v386, v388).to_string();
                            let v390: string =
                                fable_library_rust::String_::fromStr(&v389);
                            let v392: &str = r#"\["(.*?)"\]"#;
                            let v393: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v392);
                            let v394: &regex::Regex = &v393.build().unwrap();
                            let v395: string = Client::method2(v390);
                            let v396: &str = &v395.as_str();
                            let v397: string = Client::method4();
                            let v398: &str = &v397.as_str();
                            let v399: std::string::String =
                                v394.replace_all(&v396, v398).to_string();
                            let v400: string =
                                fable_library_rust::String_::fromStr(&v399);
                            let v402: &str = r#", "#;
                            let v403: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v402);
                            let v404: &regex::Regex = &v403.build().unwrap();
                            let v405: string = Client::method2(v400);
                            let v406: &str = &v405.as_str();
                            let v407: string = Client::method5();
                            let v408: &str = &v407.as_str();
                            let v409: std::string::String =
                                v404.replace_all(&v406, v408).to_string();
                            let v410: string =
                                fable_library_rust::String_::fromStr(&v409);
                            let v412: std::string::String =
                                (&v410).to_string().clone();
                            let v414: string =
                                toString(&format!("{}", &v336));
                            let v416: &str = r#""([^"]+)", "([^"]+)""#;
                            let v417: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v416);
                            let v418: &regex::Regex = &v417.build().unwrap();
                            let v419: string = Client::method2(v414);
                            let v420: &str = &v419.as_str();
                            let v421: string = Client::method3();
                            let v422: &str = &v421.as_str();
                            let v423: std::string::String =
                                v418.replace_all(&v420, v422).to_string();
                            let v424: string =
                                fable_library_rust::String_::fromStr(&v423);
                            let v426: &str = r#"\["(.*?)"\]"#;
                            let v427: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v426);
                            let v428: &regex::Regex = &v427.build().unwrap();
                            let v429: string = Client::method2(v424);
                            let v430: &str = &v429.as_str();
                            let v431: string = Client::method4();
                            let v432: &str = &v431.as_str();
                            let v433: std::string::String =
                                v428.replace_all(&v430, v432).to_string();
                            let v434: string =
                                fable_library_rust::String_::fromStr(&v433);
                            let v436: &str = r#", "#;
                            let v437: regex::RegexBuilder =
                                regex::RegexBuilder::new(&v436);
                            let v438: &regex::Regex = &v437.build().unwrap();
                            let v439: string = Client::method2(v434);
                            let v440: &str = &v439.as_str();
                            let v441: string = Client::method5();
                            let v442: &str = &v441.as_str();
                            let v443: std::string::String =
                                v438.replace_all(&v440, v442).to_string();
                            let v444: string =
                                fable_library_rust::String_::fromStr(&v443);
                            let v446: std::string::String =
                                (&v444).to_string().clone();
                            if let Client::US0::US0_1 =
                                   &if cfg!(target_arch = "wasm32") {
                                        Client::US0::US0_1
                                    } else { Client::US0::US0_0 } {
                                let v454: string = string(" %c");
                                let v458: string =
                                    append(append(append(append(toString(&v378),
                                                                v454.clone()),
                                                         toString(&v412)),
                                                  v454), toString(&v446));
                                let v466: Array<std::string::String> =
                                    array(&[(&v458).as_ref().to_string(),
                                            (&stringFrom(format!("color: #{0};",
                                                                 &string("387957")))).as_ref().to_string(),
                                            (&string("color: #385779;")).as_ref().to_string()]);
                                let v467 = core::ops::Deref::deref(&v466);
                                let v470 =
                                    serde_wasm_bindgen::to_value(&*****&v467).unwrap();
                                web_sys::console::log(&js_sys::Array::from(&v470));
                                ()
                            } else {
                                let v472: string = Client::method6();
                                let v473: &str = &v472.as_str();
                                let v477: &str =
                                    &v473[0i32 as usize..2i32 as usize];
                                let v478: string =
                                    fable_library_rust::String_::fromStr(&v477);
                                let v480: u8 =
                                    u8::from_str_radix(&v478, 16).unwrap();
                                let v481: string = Client::method6();
                                let v482: &str = &v481.as_str();
                                let v485: &str =
                                    &v482[2i32 as usize..4i32 as usize];
                                let v486: string =
                                    fable_library_rust::String_::fromStr(&v485);
                                let v487: u8 =
                                    u8::from_str_radix(&v486, 16).unwrap();
                                let v488: string = Client::method6();
                                let v489: &str = &v488.as_str();
                                let v492: &str =
                                    &v489[4i32 as usize..6i32 as usize];
                                let v493: string =
                                    fable_library_rust::String_::fromStr(&v492);
                                let v494: u8 =
                                    u8::from_str_radix(&v493, 16).unwrap();
                                let v496: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v412.to_string(), v480, v487, v494);
                                let v497: std::string::String =
                                    format!("{}", &v496);
                                let v498: string = Client::method7();
                                let v499: &str = &v498.as_str();
                                let v502: &str =
                                    &v499[0i32 as usize..2i32 as usize];
                                let v503: string =
                                    fable_library_rust::String_::fromStr(&v502);
                                let v504: u8 =
                                    u8::from_str_radix(&v503, 16).unwrap();
                                let v505: string = Client::method7();
                                let v506: &str = &v505.as_str();
                                let v509: &str =
                                    &v506[2i32 as usize..4i32 as usize];
                                let v510: string =
                                    fable_library_rust::String_::fromStr(&v509);
                                let v511: u8 =
                                    u8::from_str_radix(&v510, 16).unwrap();
                                let v512: string = Client::method7();
                                let v513: &str = &v512.as_str();
                                let v516: &str =
                                    &v513[4i32 as usize..6i32 as usize];
                                let v517: string =
                                    fable_library_rust::String_::fromStr(&v516);
                                let v518: u8 =
                                    u8::from_str_radix(&v517, 16).unwrap();
                                let v519: colored::ColoredString =
                                    colored::Colorize::truecolor(&*v446.to_string(), v504, v511, v518);
                                let v520: std::string::String =
                                    format!("{}", &v519);
                                println!("{0}",
                                         stringFrom(format!("{0} {1} {2}", &v378, &v497, &v520)));
                                ()
                            }
                            0i32
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
