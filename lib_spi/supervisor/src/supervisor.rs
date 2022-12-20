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
    use fable_library_rust::String_::length;
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
            let v17: string =
                Supervisor::method2(6i32,
                                    toString(&((&v11).timestamp() - v3)));
            let v30: Array<std::string::String> =
                array(&[(&string("timestamp:")).to_string(),
                        (&v17).to_string(), (&string("run_id:")).to_string(),
                        format!("{}", &999i32)]);
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
        let v25: std::string::String =
            (&string("spi_path:")).to_string().clone();
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
                    let v94: std::string::String =
                        (&string("spiproj_path:")).to_string().clone();
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
                                let v144 =
                                    serde_json::json!({"ProjectFileOpen": {"uri": v89, "spiprojText": v142}});
                                let v146: std::string::String =
                                    v144.to_string();
                                let v148 = zmq::Context::new();
                                let v150 = v148.socket(zmq::REQ).unwrap();
                                let v151: string =
                                    stringFrom(format!("tcp://localhost:{0}",
                                                       &13805i32));
                                v150.connect(&v151.clone()).unwrap();
                                v150.send(v146.as_str(), 0).unwrap();
                                {
                                    let v155 =
                                        v150.recv_string(0).unwrap().unwrap();
                                    v150.disconnect(&v151).unwrap();
                                    v5(Supervisor::US0::US0_0)((&string("> spiproj_open; ok")).to_string().clone());
                                    {
                                        let v164 =
                                            serde_json::json!({"BuildFile": {"uri": v43, "backend": *string("Fsharp")}});
                                        let v165: std::string::String =
                                            v164.to_string();
                                        let v166 = zmq::Context::new();
                                        let v167 =
                                            v166.socket(zmq::REQ).unwrap();
                                        let v168: string =
                                            stringFrom(format!("tcp://localhost:{0}",
                                                               &13805i32));
                                        v167.connect(&v168.clone()).unwrap();
                                        v167.send(v165.as_str(), 0).unwrap();
                                        {
                                            let v170 =
                                                v167.recv_string(0).unwrap().unwrap();
                                            v167.disconnect(&v168).unwrap();
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
