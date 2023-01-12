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
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::arrayEmpty;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::substring2;
    use fable_library_rust::String_::toString;
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
    pub fn closure1(v0_1: i64, v1: Vec<u8>) -> Result<bool, std::io::Error> {
        let v3: i32 = (&v1).len().try_into().unwrap();
        let v11: Array<std::string::String> =
            array(&[(&string("line.len():")).to_string(),
                    format!("{}", &v3)]);
        let v13 = core::ops::Deref::deref(&v11);
        let v16: std::string::String = format!("{:?}", ***v13).clone();
        let v18: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v24: string =
            Cli::method2(6i32, toString(&((&v18).timestamp() - v0_1)));
        let v26: u8 = rand::random::<u8>();
        let v37: Array<std::string::String> =
            array(&[(&string("timestamp:")).to_string(), (&v24).to_string(),
                    (&string("run_id:")).to_string(), format!("{}", &v26)]);
        let v38 = core::ops::Deref::deref(&v37);
        let v40: std::string::String = format!("{:?}", ***v38).clone();
        let v44: Array<std::string::String> =
            array(&[(&string("> read_lines ()")).to_string()]);
        let v45 = core::ops::Deref::deref(&v44);
        let v47: std::string::String = format!("{:?}", ***v45).clone();
        let v50 =
            colored::Colorize::color(&*v47, string("purple").to_string());
        let v51: std::string::String = format!("{}", v50);
        let v52: string = string("666666");
        let v53: string = substring2(v52.clone(), 0i32, 2i32);
        let v55: u8 = u8::from_str_radix(&v53, 16).unwrap();
        let v56: string = substring2(v52.clone(), 2i32, 2i32);
        let v57: u8 = u8::from_str_radix(&v56, 16).unwrap();
        let v58: string = substring2(v52, 4i32, 2i32);
        let v59: u8 = u8::from_str_radix(&v58, 16).unwrap();
        let v61 =
            colored::Colorize::truecolor(&*v16.to_string(), v55, v57, v59);
        let v62: std::string::String = format!("{}", v61);
        let v63: string = string("222222");
        let v64: string = substring2(v63.clone(), 0i32, 2i32);
        let v65: u8 = u8::from_str_radix(&v64, 16).unwrap();
        let v66: string = substring2(v63.clone(), 2i32, 2i32);
        let v67: u8 = u8::from_str_radix(&v66, 16).unwrap();
        let v68: string = substring2(v63, 4i32, 2i32);
        let v69: u8 = u8::from_str_radix(&v68, 16).unwrap();
        let v70 =
            colored::Colorize::truecolor(&*v40.to_string(), v65, v67, v69);
        let v71: std::string::String = format!("{}", v70);
        println!("{0}", stringFrom(format!("{0} {1} {2}", &v51, &v62, &v71)));
        Ok(true)
    }
    pub fn method3(v0_1: i64)
     -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: Vec<u8>| Cli::closure1(v0_1, v.clone())
                   })
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
            (&string("path_clean:")).to_string().clone();
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
        let v45: string = string("timestamp:");
        let v50: string = string("run_id:");
        let v56: Array<std::string::String> =
            array(&[(&v45).to_string(), (&v42).to_string(),
                    (&v50).to_string(), format!("{}", &v44)]);
        let v57 = core::ops::Deref::deref(&v56);
        let v59: std::string::String = format!("{:?}", ***v57).clone();
        let v60: string = string("> read_lines ()");
        let v63: Array<std::string::String> = array(&[(&v60).to_string()]);
        let v64 = core::ops::Deref::deref(&v63);
        let v66: std::string::String = format!("{:?}", ***v64).clone();
        let v67: string = string("purple");
        let v69 = colored::Colorize::color(&*v66, v67.clone().to_string());
        let v70: std::string::String = format!("{}", v69);
        let v71: string = string("666666");
        let v72: string = substring2(v71.clone(), 0i32, 2i32);
        let v74: u8 = u8::from_str_radix(&v72, 16).unwrap();
        let v75: string = substring2(v71.clone(), 2i32, 2i32);
        let v76: u8 = u8::from_str_radix(&v75, 16).unwrap();
        let v77: string = substring2(v71.clone(), 4i32, 2i32);
        let v78: u8 = u8::from_str_radix(&v77, 16).unwrap();
        let v80 =
            colored::Colorize::truecolor(&*v36.to_string(), v74, v76, v78);
        let v81: std::string::String = format!("{}", v80);
        let v82: string = string("222222");
        let v83: string = substring2(v82.clone(), 0i32, 2i32);
        let v84: u8 = u8::from_str_radix(&v83, 16).unwrap();
        let v85: string = substring2(v82.clone(), 2i32, 2i32);
        let v86: u8 = u8::from_str_radix(&v85, 16).unwrap();
        let v87: string = substring2(v82.clone(), 4i32, 2i32);
        let v88: u8 = u8::from_str_radix(&v87, 16).unwrap();
        let v89 =
            colored::Colorize::truecolor(&*v59.to_string(), v84, v86, v88);
        let v90: std::string::String = format!("{}", v89);
        println!("{0}", stringFrom(format!("{0} {1} {2}", &v70, &v81, &v90)));
        {
            let v93: Result<std::fs::File, std::io::Error> =
                std::fs::File::open(&v22);
            let v95: &std::fs::File = &v93.unwrap();
            let v97:
                    std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                std::cell::RefCell::new(linereader::LineReader::new(&v95));
            let v104: Array<std::string::String> =
                array(&[(&string("reader:")).to_string(),
                        format!("{:?}", &v97)]);
            let v105 = core::ops::Deref::deref(&v104);
            let v107: std::string::String = format!("{:?}", ***v105).clone();
            let v108: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v113: string =
                Cli::method2(6i32, toString(&((&v108).timestamp() - v18)));
            let v114: u8 = rand::random::<u8>();
            let v123: Array<std::string::String> =
                array(&[(&v45).to_string(), (&v113).to_string(),
                        (&v50).to_string(), format!("{}", &v114)]);
            let v124 = core::ops::Deref::deref(&v123);
            let v126: std::string::String = format!("{:?}", ***v124).clone();
            let v129: Array<std::string::String> =
                array(&[(&v60).to_string()]);
            let v130 = core::ops::Deref::deref(&v129);
            let v132: std::string::String = format!("{:?}", ***v130).clone();
            let v133 =
                colored::Colorize::color(&*v132, v67.clone().to_string());
            let v134: std::string::String = format!("{}", v133);
            let v135: string = substring2(v71.clone(), 0i32, 2i32);
            let v136: u8 = u8::from_str_radix(&v135, 16).unwrap();
            let v137: string = substring2(v71.clone(), 2i32, 2i32);
            let v138: u8 = u8::from_str_radix(&v137, 16).unwrap();
            let v139: string = substring2(v71.clone(), 4i32, 2i32);
            let v140: u8 = u8::from_str_radix(&v139, 16).unwrap();
            let v141 =
                colored::Colorize::truecolor(&*v107.to_string(), v136, v138, v140);
            let v142: std::string::String = format!("{}", v141);
            let v143: string = substring2(v82.clone(), 0i32, 2i32);
            let v144: u8 = u8::from_str_radix(&v143, 16).unwrap();
            let v145: string = substring2(v82.clone(), 2i32, 2i32);
            let v146: u8 = u8::from_str_radix(&v145, 16).unwrap();
            let v147: string = substring2(v82.clone(), 4i32, 2i32);
            let v148: u8 = u8::from_str_radix(&v147, 16).unwrap();
            let v149 =
                colored::Colorize::truecolor(&*v126.to_string(), v144, v146, v148);
            let v150: std::string::String = format!("{}", v149);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v134, &v142, &v150)));
            {
                let v153: Vec<Vec<u8>> = Vec::new();
                let v154 = Cli::method3(v18);
                let v156: Result<(), std::io::Error> =
                    (v97).borrow_mut().for_each(move |x| v154(x.to_vec()));
                *((&v156).as_ref()).unwrap();
                {
                    let v158: string = string("lines:");
                    let v163: Array<std::string::String> =
                        array(&[(&v158).to_string(), format!("{:?}", &v153)]);
                    let v164 = core::ops::Deref::deref(&v163);
                    let v166: std::string::String =
                        format!("{:?}", ***v164).clone();
                    let v167: chrono::DateTime<chrono::Utc> =
                        chrono::Utc::now();
                    let v172: string =
                        Cli::method2(6i32,
                                     toString(&((&v167).timestamp() - v18)));
                    let v173: u8 = rand::random::<u8>();
                    let v182: Array<std::string::String> =
                        array(&[(&v45).to_string(), (&v172).to_string(),
                                (&v50).to_string(), format!("{}", &v173)]);
                    let v183 = core::ops::Deref::deref(&v182);
                    let v185: std::string::String =
                        format!("{:?}", ***v183).clone();
                    let v188: Array<std::string::String> =
                        array(&[(&v60).to_string()]);
                    let v189 = core::ops::Deref::deref(&v188);
                    let v191: std::string::String =
                        format!("{:?}", ***v189).clone();
                    let v192 =
                        colored::Colorize::color(&*v191, v67.clone().to_string());
                    let v193: std::string::String = format!("{}", v192);
                    let v194: string = substring2(v71.clone(), 0i32, 2i32);
                    let v195: u8 = u8::from_str_radix(&v194, 16).unwrap();
                    let v196: string = substring2(v71.clone(), 2i32, 2i32);
                    let v197: u8 = u8::from_str_radix(&v196, 16).unwrap();
                    let v198: string = substring2(v71.clone(), 4i32, 2i32);
                    let v199: u8 = u8::from_str_radix(&v198, 16).unwrap();
                    let v200 =
                        colored::Colorize::truecolor(&*v166.to_string(), v195, v197, v199);
                    let v201: std::string::String = format!("{}", v200);
                    let v202: string = substring2(v82.clone(), 0i32, 2i32);
                    let v203: u8 = u8::from_str_radix(&v202, 16).unwrap();
                    let v204: string = substring2(v82.clone(), 2i32, 2i32);
                    let v205: u8 = u8::from_str_radix(&v204, 16).unwrap();
                    let v206: string = substring2(v82.clone(), 4i32, 2i32);
                    let v207: u8 = u8::from_str_radix(&v206, 16).unwrap();
                    let v208 =
                        colored::Colorize::truecolor(&*v185.to_string(), v203, v205, v207);
                    let v209: std::string::String = format!("{}", v208);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v193, &v201, &v209)));
                    {
                        let v216: Array<std::string::String> =
                            array(&[(&v158).to_string(),
                                    format!("{}", &arrayEmpty::<string>())]);
                        let v217 = core::ops::Deref::deref(&v216);
                        let v219: std::string::String =
                            format!("{:?}", ***v217).clone();
                        let v220: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v225: string =
                            Cli::method2(6i32,
                                         toString(&((&v220).timestamp() -
                                                        v7)));
                        let v226: u8 = rand::random::<u8>();
                        let v235: Array<std::string::String> =
                            array(&[(&v45).to_string(), (&v225).to_string(),
                                    (&v50).to_string(),
                                    format!("{}", &v226)]);
                        let v236 = core::ops::Deref::deref(&v235);
                        let v238: std::string::String =
                            format!("{:?}", ***v236).clone();
                        let v242: Array<std::string::String> =
                            array(&[(&string("> app ()")).to_string()]);
                        let v243 = core::ops::Deref::deref(&v242);
                        let v245: std::string::String =
                            format!("{:?}", ***v243).clone();
                        let v246 =
                            colored::Colorize::color(&*v245, v67.to_string());
                        let v247: std::string::String = format!("{}", v246);
                        let v248: string =
                            substring2(v71.clone(), 0i32, 2i32);
                        let v249: u8 = u8::from_str_radix(&v248, 16).unwrap();
                        let v250: string =
                            substring2(v71.clone(), 2i32, 2i32);
                        let v251: u8 = u8::from_str_radix(&v250, 16).unwrap();
                        let v252: string = substring2(v71, 4i32, 2i32);
                        let v253: u8 = u8::from_str_radix(&v252, 16).unwrap();
                        let v254 =
                            colored::Colorize::truecolor(&*v219.to_string(), v249, v251, v253);
                        let v255: std::string::String = format!("{}", v254);
                        let v256: string =
                            substring2(v82.clone(), 0i32, 2i32);
                        let v257: u8 = u8::from_str_radix(&v256, 16).unwrap();
                        let v258: string =
                            substring2(v82.clone(), 2i32, 2i32);
                        let v259: u8 = u8::from_str_radix(&v258, 16).unwrap();
                        let v260: string = substring2(v82, 4i32, 2i32);
                        let v261: u8 = u8::from_str_radix(&v260, 16).unwrap();
                        let v262 =
                            colored::Colorize::truecolor(&*v238.to_string(), v257, v259, v261);
                        let v263: std::string::String = format!("{}", v262);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v247, &v255, &v263)));
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
