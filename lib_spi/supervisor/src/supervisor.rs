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
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::substring2;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 { US0_0, US0_1, US0_2, US0_3, }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> Supervisor::US0 {
        Supervisor::US0::US0_0
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> std::string::String {
        let v4: Array<std::string::String> =
            array(&[(&string("> spi_to_fsx ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn method1() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn closure5(v0_1: Func0<Supervisor::US0>,
                    v1: Func0<std::string::String>, v2: string, v3: i64,
                    v4: Supervisor::US0, v5: std::string::String) {
        let v6: Supervisor::US0 = v0_1();
        if match &v6 {
               Supervisor::US0::US0_1 => 3i32,
               Supervisor::US0::US0_2 => 1i32,
               Supervisor::US0::US0_3 => 2i32,
               _ => 0i32,
           } <=
               match &v4 {
                   Supervisor::US0::US0_1 => 3i32,
                   Supervisor::US0::US0_2 => 1i32,
                   Supervisor::US0::US0_3 => 2i32,
                   _ => 0i32,
               } {
            let v11: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v15: string = toString(&((&v11).timestamp() - v3));
            let v17: u8 = rand::random::<u8>();
            let v30: Array<std::string::String> =
                array(&[(&string("timestamp:")).to_string(),
                        (&v15).to_string(), (&string("run_id:")).to_string(),
                        format!("{}", &v17)]);
            let v32 = core::ops::Deref::deref(&v30);
            let v35: std::string::String = format!("{:?}", ***v32).clone();
            let v36: std::string::String = v1();
            let v39 =
                colored::Colorize::color(&*v36, string("purple").to_string());
            let v40: std::string::String = format!("{}", v39);
            let v41: string = substring2(v2.clone(), 0i32, 2i32);
            let v43: u8 = u8::from_str_radix(&v41, 16).unwrap();
            let v44: string = substring2(v2.clone(), 2i32, 2i32);
            let v45: u8 = u8::from_str_radix(&v44, 16).unwrap();
            let v46: string = substring2(v2, 4i32, 2i32);
            let v47: u8 = u8::from_str_radix(&v46, 16).unwrap();
            let v49 =
                colored::Colorize::truecolor(&*v5.to_string(), v43, v45, v47);
            let v50: std::string::String = format!("{}", v49);
            let v51: string = string("222222");
            let v52: string = substring2(v51.clone(), 0i32, 2i32);
            let v53: u8 = u8::from_str_radix(&v52, 16).unwrap();
            let v54: string = substring2(v51.clone(), 2i32, 2i32);
            let v55: u8 = u8::from_str_radix(&v54, 16).unwrap();
            let v56: string = substring2(v51, 4i32, 2i32);
            let v57: u8 = u8::from_str_radix(&v56, 16).unwrap();
            let v58 =
                colored::Colorize::truecolor(&*v35.to_string(), v53, v55, v57);
            let v59: std::string::String = format!("{}", v58);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v40, &v50, &v59)));
            ()
        }
    }
    pub fn closure4(v0_1: Func0<Supervisor::US0>,
                    v1: Func0<std::string::String>, v2: string, v3: i64,
                    v4: Supervisor::US0) -> Func1<std::string::String, ()> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       let v2 = v2.clone();
                       let v3 = v3.clone();
                       let v4 = v4.clone();
                       move |v: std::string::String|
                           Supervisor::closure5(v0_1.clone(), v1.clone(),
                                                v2.clone(), v3, v4.clone(),
                                                v.clone())
                   })
    }
    pub fn method0(v0_1: Func0<Supervisor::US0>,
                   v1: Func0<std::string::String>, v2: string)
     -> Func1<Supervisor::US0, Func1<std::string::String, ()>> {
        let patternInput: (string, string, string, bool) =
            Supervisor::method1();
        let v8: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v10: i64 = (&v8).timestamp();
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       let v10 = v10.clone();
                       let v2 = v2.clone();
                       move |v: Supervisor::US0|
                           Supervisor::closure4(v0_1.clone(), v1.clone(),
                                                v2.clone(), v10, v.clone())
                   })
    }
    pub fn closure6(unitVar: (), v0_1: &std::path::Path)
     -> std::path::PathBuf {
        v0_1.join(string("package.spiproj").as_str())
    }
    pub fn closure7(unitVar: (), v0_1: &std::path::PathBuf) -> bool {
        std::path::Path::exists(&v0_1)
    }
    pub fn closure8(unitVar: (), unitVar_1: ()) -> Supervisor::US0 {
        Supervisor::US0::US0_0
    }
    pub fn closure9(unitVar: (), unitVar_1: ()) -> std::string::String {
        let v4: Array<std::string::String> =
            array(&[(&string("> spiproj_open ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> Supervisor::US0 {
        Supervisor::US0::US0_0
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) -> std::string::String {
        let v4: Array<std::string::String> =
            array(&[(&string("> spi_build_file ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn closure1(v0_1: std::path::PathBuf, v1: Option<std::path::PathBuf>)
     -> string {
        fn v2() -> Supervisor::US0 { Supervisor::closure2((), ()) }
        fn v3() -> std::string::String { Supervisor::closure3((), ()) }
        let v5 =
            Supervisor::method0(Func0::from(v2), Func0::from(v3),
                                string("de884c"));
        let v7 = v5(Supervisor::US0::US0_0);
        let v11: std::string::String = (&string("pwd:")).to_string().clone();
        let v13: Result<std::path::PathBuf, std::io::Error> =
            std::env::current_dir();
        let v15: std::path::PathBuf = (&v13).as_ref().unwrap().to_path_buf();
        let v17: Result<std::path::PathBuf, std::io::Error> =
            (&v15).canonicalize();
        let v18: std::path::PathBuf = (&v17).as_ref().unwrap().to_path_buf();
        let v20: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v18.display()));
        let v22: std::string::String = (&v20).to_string().clone();
        let v23: string = string("spi_path:");
        let v25: std::string::String = (&v23).to_string().clone();
        let v26: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v0_1.display()));
        let v28: std::string::String = (&v26).to_string().clone();
        let v31: std::string::String =
            (&string("new_fsx_path:")).to_string().clone();
        let v32: std::path::PathBuf = (&v1).as_ref().unwrap().to_path_buf();
        let v33: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v32.display()));
        let v36: Array<std::string::String> =
            array(&[v11, v22, v25, v28, v31, (&v33).to_string()]);
        let v38 = core::ops::Deref::deref(&v36);
        v7(format!("{:?}", ***v38).clone());
        {
            let v42: Result<std::path::PathBuf, std::io::Error> =
                (&v0_1).canonicalize();
            let v43: std::path::PathBuf =
                (&v42).as_ref().unwrap().to_path_buf();
            let v45 = v5(Supervisor::US0::US0_0);
            let v48: std::string::String =
                (&string("spi_path_clean:")).to_string().clone();
            let v49: string =
                fable_library_rust::String_::fromStr(&format!("{}", &v43.display()));
            let v52: Array<std::string::String> =
                array(&[v48, (&v49).to_string()]);
            let v53 = core::ops::Deref::deref(&v52);
            v45(format!("{:?}", ***v53).clone());
            {
                let v57: Option<&std::path::Path> = (&v43).parent();
                let v59: &std::path::Path = (&v57).unwrap();
                let v61: std::path::PathBuf = std::path::PathBuf::from(&v59);
                let v62: Result<std::path::PathBuf, std::io::Error> =
                    (&v61).canonicalize();
                let v63: std::path::PathBuf =
                    (&v62).as_ref().unwrap().to_path_buf();
                let v65 = v5(Supervisor::US0::US0_0);
                let v68: std::string::String =
                    (&string("src_path:")).to_string().clone();
                let v69: string =
                    fable_library_rust::String_::fromStr(&format!("{}", &v63.display()));
                let v72: Array<std::string::String> =
                    array(&[v68, (&v69).to_string()]);
                let v73 = core::ops::Deref::deref(&v72);
                v65(format!("{:?}", ***v73).clone());
                {
                    let v77: &std::path::Ancestors = &v63.ancestors();
                    let v80: _ = v77.take(10i32 as usize);
                    fn v81(v: &std::path::Path) -> std::path::PathBuf {
                        Supervisor::closure6((), v)
                    }
                    let v84: _ = v80.into_iter().map((&v81).clone());
                    fn v85(v_1: &std::path::PathBuf) -> bool {
                        Supervisor::closure7((), v_1)
                    }
                    let v88: Option<std::path::PathBuf> =
                        v84.into_iter().find((&v85).clone());
                    let v89: std::path::PathBuf =
                        (&v88).as_ref().unwrap().to_path_buf();
                    let v91 = v5(Supervisor::US0::US0_0);
                    let v92: string = string("spiproj_path:");
                    let v94: std::string::String = (&v92).to_string().clone();
                    let v95: string =
                        fable_library_rust::String_::fromStr(&format!("{}", &v89.display()));
                    let v98: Array<std::string::String> =
                        array(&[v94, (&v95).to_string()]);
                    let v99 = core::ops::Deref::deref(&v98);
                    v91(format!("{:?}", ***v99).clone());
                    {
                        let v103: Option<&str> = (&v43).to_str();
                        let v104: &str = (&v103).unwrap();
                        let v107: string = string(".spi");
                        let v110: &str =
                            &v104.replace(&*(&string(".spir")).clone(), &(&v107).clone());
                        let v114: &str =
                            &v110.replace(&*(&v107).clone(), &(&string(".fsx")).clone());
                        let v115: std::path::PathBuf =
                            std::path::PathBuf::from(&v114);
                        let v116: Result<std::path::PathBuf, std::io::Error> =
                            (&v115).canonicalize();
                        let v117: std::path::PathBuf =
                            (&v116).as_ref().unwrap().to_path_buf();
                        let v119 = v5(Supervisor::US0::US0_0);
                        let v122: std::string::String =
                            (&string("fsx_path:")).to_string().clone();
                        let v123: string =
                            fable_library_rust::String_::fromStr(&format!("{}", &v117.display()));
                        let v126: Array<std::string::String> =
                            array(&[v122, (&v123).to_string()]);
                        let v127 = core::ops::Deref::deref(&v126);
                        v119(format!("{:?}", ***v127).clone());
                        {
                            let v132: Result<(), std::io::Error> =
                                std::fs::write(v117, string("").as_str());
                            *((&v132).as_ref()).unwrap();
                            v5(Supervisor::US0::US0_0)((&string("> fs_write fsx_path \"\"; ok")).to_string().clone());
                            {
                                let v140:
                                        Result<std::string::String,
                                               std::io::Error> =
                                    std::fs::read_to_string(&v89);
                                let v142: std::string::String =
                                    (&v140).as_ref().unwrap().to_string();
                                fn v143() -> Supervisor::US0 {
                                    Supervisor::closure8((), ())
                                }
                                fn v144() -> std::string::String {
                                    Supervisor::closure9((), ())
                                }
                                let v146 =
                                    Supervisor::method0(Func0::from(v143),
                                                        Func0::from(v144),
                                                        string("e36a62"));
                                let v148 = v146(Supervisor::US0::US0_0);
                                let v150: std::string::String =
                                    (&v92).to_string().clone();
                                let v151: string =
                                    fable_library_rust::String_::fromStr(&format!("{}", &v89.display()));
                                let v153: std::string::String =
                                    (&v151).to_string().clone();
                                let v156: std::string::String =
                                    (&string("spiproj_text.len():")).to_string().clone();
                                let v158: i32 =
                                    (&v142).len().try_into().unwrap();
                                let v162: Array<std::string::String> =
                                    array(&[v150, v153, v156,
                                            format!("{}", &v158)]);
                                let v163 = core::ops::Deref::deref(&v162);
                                v148(format!("{:?}", ***v163).clone());
                                {
                                    let v166: string = string("{");
                                    let v169: string = string("\"uri\": $0,");
                                    let v173: string = string("}");
                                    let v176: string =
                                        string("serde_json::json!(");
                                    let v178: string =
                                        string(").to_string()");
                                    let v179: string =
                                        append(append(v176.clone(),
                                                      append(append(append(append(append(v166.clone(),
                                                                                         string("\"ProjectFileOpen\": {")),
                                                                                  v169.clone()),
                                                                           string("\"spiprojText\": $1")),
                                                                    v173.clone()),
                                                             v173.clone())),
                                               v178.clone());
                                    let v180: std::string::String =
                                        serde_json::json!({"ProjectFileOpen": {"uri": v89,"spiprojText": v142}}).to_string();
                                    let v182 = v146(Supervisor::US0::US0_0);
                                    let v183: string = string("json.len():");
                                    let v185: std::string::String =
                                        (&v183).to_string().clone();
                                    let v186: i32 =
                                        (&v180).len().try_into().unwrap();
                                    let v189: Array<std::string::String> =
                                        array(&[v185, format!("{}", &v186)]);
                                    let v190 = core::ops::Deref::deref(&v189);
                                    v182(format!("{:?}", ***v190).clone());
                                    {
                                        let v194 = zmq::Context::new();
                                        let v196 =
                                            v194.socket(zmq::REQ).unwrap();
                                        let v197: string =
                                            stringFrom(format!("tcp://localhost:{0}",
                                                               &13805i32));
                                        v196.connect(&v197.clone()).unwrap();
                                        v196.send(v180.as_str(), 0).unwrap();
                                        {
                                            let v201 =
                                                v196.recv_string(0).unwrap().unwrap();
                                            v196.disconnect(&v197).unwrap();
                                            v5(Supervisor::US0::US0_0)((&string("> spiproj_open; ok")).to_string().clone());
                                            {
                                                fn v208() -> Supervisor::US0 {
                                                    Supervisor::closure10((),
                                                                          ())
                                                }
                                                fn v209()
                                                 -> std::string::String {
                                                    Supervisor::closure11((),
                                                                          ())
                                                }
                                                let v211 =
                                                    Supervisor::method0(Func0::from(v208),
                                                                        Func0::from(v209),
                                                                        string("98d5ef"));
                                                let v213 =
                                                    v211(Supervisor::US0::US0_0);
                                                let v215:
                                                        std::string::String =
                                                    (&v23).to_string().clone();
                                                let v216: string =
                                                    fable_library_rust::String_::fromStr(&format!("{}", &v43.display()));
                                                let v222: string =
                                                    string("Fsharp");
                                                let v225:
                                                        Array<std::string::String> =
                                                    array(&[v215,
                                                            (&v216).to_string(),
                                                            (&string("backend:")).to_string(),
                                                            (&v222).to_string()]);
                                                let v226 =
                                                    core::ops::Deref::deref(&v225);
                                                v213(format!("{:?}", ***v226).clone());
                                                {
                                                    let v229:
                                                            std::string::String =
                                                        (&v222).to_string();
                                                    let v238: string =
                                                        append(append(v176,
                                                                      append(append(append(append(append(v166,
                                                                                                         string("\"BuildFile\": {")),
                                                                                                  v169),
                                                                                           string("\"backend\": $1")),
                                                                                    v173.clone()),
                                                                             v173)),
                                                               v178);
                                                    let v239:
                                                            std::string::String =
                                                        serde_json::json!({"BuildFile": {"uri": v43,"backend": v229}}).to_string();
                                                    let v241 =
                                                        v211(Supervisor::US0::US0_0);
                                                    let v243:
                                                            std::string::String =
                                                        (&v183).to_string().clone();
                                                    let v244: i32 =
                                                        (&v239).len().try_into().unwrap();
                                                    let v247:
                                                            Array<std::string::String> =
                                                        array(&[v243,
                                                                format!("{}", &v244)]);
                                                    let v248 =
                                                        core::ops::Deref::deref(&v247);
                                                    v241(format!("{:?}", ***v248).clone());
                                                    {
                                                        let v251 =
                                                            zmq::Context::new();
                                                        let v252 =
                                                            v251.socket(zmq::REQ).unwrap();
                                                        let v253: string =
                                                            stringFrom(format!("tcp://localhost:{0}",
                                                                               &13805i32));
                                                        v252.connect(&v253.clone()).unwrap();
                                                        v252.send(v239.as_str(), 0).unwrap();
                                                        {
                                                            let v255 =
                                                                v252.recv_string(0).unwrap().unwrap();
                                                            v252.disconnect(&v253).unwrap();
                                                            v5(Supervisor::US0::US0_0)((&string("> spi_build_file; ok")).to_string().clone());
                                                            string("???")
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
#[path = "./Types.rs"]
mod module_b10c81cb;
pub use module_b10c81cb::*;
