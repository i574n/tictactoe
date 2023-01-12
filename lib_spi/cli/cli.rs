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
    use fable_library_rust::Native_::arrayEmpty;
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
    pub fn closure1(v0_1: Lrc<Cli::Mut0>, v1: Vec<u8>)
     -> Result<bool, std::io::Error> {
        let v3: std::string::String =
            std::string::String::from_utf8((&v1).to_owned()).unwrap();
        let v4: Lrc<Cli::UH0> = v0_1.l0.get().clone();
        v0_1.l0.set(Lrc::new(Cli::UH0::UH0_0(v3.clone(), v4.clone())));
        Ok(true)
    }
    pub fn method3(v0_1: Lrc<Cli::Mut0>)
     -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: Vec<u8>|
                           Cli::closure1(v0_1.clone(), v.clone())
                   })
    }
    pub fn method4(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH0>) -> Lrc<Cli::UH0> {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v1.clone());
        '_method4:
            loop  {
                break '_method4
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: Lrc<Cli::UH0> =
                                 Lrc::new(Cli::UH0::UH0_0(v0_1_0_0.clone(),
                                                          v1.get()));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method4
                         }
                     }) ;
            }
    }
    pub fn method5(v0_1: Lrc<Cli::UH0>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method5:
            loop  {
                break '_method5
                    (match v0_1.get().as_ref() {
                         Cli::UH0::UH0_1 => v1.get(),
                         Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                             let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                             let v1_temp: string =
                                 stringFrom(format!("{0}{1}", &v1.get(),
                                                    v0_1_0_0));
                             v0_1.set(v0_1_temp);
                             v1.set(v1_temp);
                             continue '_method5
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
                    (&v50).to_string(), format!("{:?}", &v44)]);
        let v57 = core::ops::Deref::deref(&v56);
        let v59: std::string::String = format!("{:?}", ***v57).clone();
        let v60: string = string("> read_lines ()");
        let v63: Array<std::string::String> = array(&[(&v60).to_string()]);
        let v64 = core::ops::Deref::deref(&v63);
        let v66: std::string::String = format!("{:?}", ***v64).clone();
        let v67: string = string("purple");
        let v69: colored::ColoredString =
            colored::Colorize::color(&*v66, v67.clone().to_string());
        let v71: std::string::String = format!("{}", &v69);
        let v72: string = string("666666");
        let v73: string = substring2(v72.clone(), 0i32, 2i32);
        let v75: u8 = u8::from_str_radix(&v73, 16).unwrap();
        let v76: string = substring2(v72.clone(), 2i32, 2i32);
        let v77: u8 = u8::from_str_radix(&v76, 16).unwrap();
        let v78: string = substring2(v72.clone(), 4i32, 2i32);
        let v79: u8 = u8::from_str_radix(&v78, 16).unwrap();
        let v81: colored::ColoredString =
            colored::Colorize::truecolor(&*v36.to_string(), v75, v77, v79);
        let v82: std::string::String = format!("{}", &v81);
        let v83: string = string("222222");
        let v84: string = substring2(v83.clone(), 0i32, 2i32);
        let v85: u8 = u8::from_str_radix(&v84, 16).unwrap();
        let v86: string = substring2(v83.clone(), 2i32, 2i32);
        let v87: u8 = u8::from_str_radix(&v86, 16).unwrap();
        let v88: string = substring2(v83.clone(), 4i32, 2i32);
        let v89: u8 = u8::from_str_radix(&v88, 16).unwrap();
        let v90: colored::ColoredString =
            colored::Colorize::truecolor(&*v59.to_string(), v85, v87, v89);
        let v91: std::string::String = format!("{}", &v90);
        println!("{0}", stringFrom(format!("{0} {1} {2}", &v71, &v82, &v91)));
        {
            let v94: Result<std::fs::File, std::io::Error> =
                std::fs::File::open(&v22);
            let v96: &std::fs::File = &v94.unwrap();
            let v98:
                    std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                std::cell::RefCell::new(linereader::LineReader::new(&v96));
            let v104: Array<std::string::String> =
                array(&[(&string("reader:")).to_string(),
                        format!("{:?}", &v98)]);
            let v105 = core::ops::Deref::deref(&v104);
            let v107: std::string::String = format!("{:?}", ***v105).clone();
            let v108: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v113: string =
                Cli::method2(6i32, toString(&((&v108).timestamp() - v18)));
            let v114: u8 = rand::random::<u8>();
            let v123: Array<std::string::String> =
                array(&[(&v45).to_string(), (&v113).to_string(),
                        (&v50).to_string(), format!("{:?}", &v114)]);
            let v124 = core::ops::Deref::deref(&v123);
            let v126: std::string::String = format!("{:?}", ***v124).clone();
            let v129: Array<std::string::String> =
                array(&[(&v60).to_string()]);
            let v130 = core::ops::Deref::deref(&v129);
            let v132: std::string::String = format!("{:?}", ***v130).clone();
            let v133: colored::ColoredString =
                colored::Colorize::color(&*v132, v67.clone().to_string());
            let v134: std::string::String = format!("{}", &v133);
            let v135: string = substring2(v72.clone(), 0i32, 2i32);
            let v136: u8 = u8::from_str_radix(&v135, 16).unwrap();
            let v137: string = substring2(v72.clone(), 2i32, 2i32);
            let v138: u8 = u8::from_str_radix(&v137, 16).unwrap();
            let v139: string = substring2(v72.clone(), 4i32, 2i32);
            let v140: u8 = u8::from_str_radix(&v139, 16).unwrap();
            let v141: colored::ColoredString =
                colored::Colorize::truecolor(&*v107.to_string(), v136, v138, v140);
            let v142: std::string::String = format!("{}", &v141);
            let v143: string = substring2(v83.clone(), 0i32, 2i32);
            let v144: u8 = u8::from_str_radix(&v143, 16).unwrap();
            let v145: string = substring2(v83.clone(), 2i32, 2i32);
            let v146: u8 = u8::from_str_radix(&v145, 16).unwrap();
            let v147: string = substring2(v83.clone(), 4i32, 2i32);
            let v148: u8 = u8::from_str_radix(&v147, 16).unwrap();
            let v149: colored::ColoredString =
                colored::Colorize::truecolor(&*v126.to_string(), v144, v146, v148);
            let v150: std::string::String = format!("{}", &v149);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v134, &v142, &v150)));
            {
                let v153: Lrc<Cli::Mut0> =
                    Lrc::new(Cli::Mut0{l0:
                                           MutCell::new(Lrc::new(Cli::UH0::UH0_1)),});
                let v154 = Cli::method3(v153.clone());
                let v156: Result<(), std::io::Error> =
                    (v98).borrow_mut().for_each(move |x| v154(x.to_vec()));
                *((&v156).as_ref()).unwrap();
                {
                    let v162: string =
                        Cli::method5(Cli::method4(v153.l0.get().clone(),
                                                  Lrc::new(Cli::UH0::UH0_1)),
                                     string(""));
                    let v163: string = string("lines:");
                    let v168: Array<std::string::String> =
                        array(&[(&v163).to_string(), (&v162).to_string()]);
                    let v169 = core::ops::Deref::deref(&v168);
                    let v171: std::string::String =
                        format!("{:?}", ***v169).clone();
                    let v172: chrono::DateTime<chrono::Utc> =
                        chrono::Utc::now();
                    let v177: string =
                        Cli::method2(6i32,
                                     toString(&((&v172).timestamp() - v18)));
                    let v178: u8 = rand::random::<u8>();
                    let v187: Array<std::string::String> =
                        array(&[(&v45).to_string(), (&v177).to_string(),
                                (&v50).to_string(), format!("{:?}", &v178)]);
                    let v188 = core::ops::Deref::deref(&v187);
                    let v190: std::string::String =
                        format!("{:?}", ***v188).clone();
                    let v193: Array<std::string::String> =
                        array(&[(&v60).to_string()]);
                    let v194 = core::ops::Deref::deref(&v193);
                    let v196: std::string::String =
                        format!("{:?}", ***v194).clone();
                    let v197: colored::ColoredString =
                        colored::Colorize::color(&*v196, v67.clone().to_string());
                    let v198: std::string::String = format!("{}", &v197);
                    let v199: string = substring2(v72.clone(), 0i32, 2i32);
                    let v200: u8 = u8::from_str_radix(&v199, 16).unwrap();
                    let v201: string = substring2(v72.clone(), 2i32, 2i32);
                    let v202: u8 = u8::from_str_radix(&v201, 16).unwrap();
                    let v203: string = substring2(v72.clone(), 4i32, 2i32);
                    let v204: u8 = u8::from_str_radix(&v203, 16).unwrap();
                    let v205: colored::ColoredString =
                        colored::Colorize::truecolor(&*v171.to_string(), v200, v202, v204);
                    let v206: std::string::String = format!("{}", &v205);
                    let v207: string = substring2(v83.clone(), 0i32, 2i32);
                    let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
                    let v209: string = substring2(v83.clone(), 2i32, 2i32);
                    let v210: u8 = u8::from_str_radix(&v209, 16).unwrap();
                    let v211: string = substring2(v83.clone(), 4i32, 2i32);
                    let v212: u8 = u8::from_str_radix(&v211, 16).unwrap();
                    let v213: colored::ColoredString =
                        colored::Colorize::truecolor(&*v190.to_string(), v208, v210, v212);
                    let v214: std::string::String = format!("{}", &v213);
                    println!("{0}",
                             stringFrom(format!("{0} {1} {2}", &v198, &v206, &v214)));
                    {
                        let v221: Array<std::string::String> =
                            array(&[(&v163).to_string(),
                                    format!("{:?}", &arrayEmpty::<string>())]);
                        let v222 = core::ops::Deref::deref(&v221);
                        let v224: std::string::String =
                            format!("{:?}", ***v222).clone();
                        let v225: chrono::DateTime<chrono::Utc> =
                            chrono::Utc::now();
                        let v230: string =
                            Cli::method2(6i32,
                                         toString(&((&v225).timestamp() -
                                                        v7)));
                        let v231: u8 = rand::random::<u8>();
                        let v240: Array<std::string::String> =
                            array(&[(&v45).to_string(), (&v230).to_string(),
                                    (&v50).to_string(),
                                    format!("{:?}", &v231)]);
                        let v241 = core::ops::Deref::deref(&v240);
                        let v243: std::string::String =
                            format!("{:?}", ***v241).clone();
                        let v247: Array<std::string::String> =
                            array(&[(&string("> app ()")).to_string()]);
                        let v248 = core::ops::Deref::deref(&v247);
                        let v250: std::string::String =
                            format!("{:?}", ***v248).clone();
                        let v251: colored::ColoredString =
                            colored::Colorize::color(&*v250, v67.to_string());
                        let v252: std::string::String = format!("{}", &v251);
                        let v253: string =
                            substring2(v72.clone(), 0i32, 2i32);
                        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
                        let v255: string =
                            substring2(v72.clone(), 2i32, 2i32);
                        let v256: u8 = u8::from_str_radix(&v255, 16).unwrap();
                        let v257: string = substring2(v72, 4i32, 2i32);
                        let v258: u8 = u8::from_str_radix(&v257, 16).unwrap();
                        let v259: colored::ColoredString =
                            colored::Colorize::truecolor(&*v224.to_string(), v254, v256, v258);
                        let v260: std::string::String = format!("{}", &v259);
                        let v261: string =
                            substring2(v83.clone(), 0i32, 2i32);
                        let v262: u8 = u8::from_str_radix(&v261, 16).unwrap();
                        let v263: string =
                            substring2(v83.clone(), 2i32, 2i32);
                        let v264: u8 = u8::from_str_radix(&v263, 16).unwrap();
                        let v265: string = substring2(v83, 4i32, 2i32);
                        let v266: u8 = u8::from_str_radix(&v265, 16).unwrap();
                        let v267: colored::ColoredString =
                            colored::Colorize::truecolor(&*v243.to_string(), v262, v264, v266);
                        let v268: std::string::String = format!("{}", &v267);
                        println!("{0}",
                                 stringFrom(format!("{0} {1} {2}", &v252, &v260, &v268)));
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
