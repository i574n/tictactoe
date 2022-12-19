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
    use fable_library_rust::String_::toString;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 { US0_0, US0_1, US0_2, US0_3, }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> Supervisor::US0 {
        Supervisor::US0::US0_0
    }
    pub fn closure3(v0_1: std::path::PathBuf, v1: Option<std::path::PathBuf>,
                    unitVar: ()) -> std::string::String {
        let v5: std::string::String =
            (&string("spi_path:")).to_string().clone();
        let v7: string =
            fable_library_rust::String_::fromStr(&format!("{:?}", &v0_1.display()));
        let v9: std::string::String = (&v7).to_string().clone();
        let v12: std::string::String =
            (&string("new_fsx_path:")).to_string().clone();
        let v14: std::path::PathBuf = (&v1).as_ref().unwrap().to_path_buf();
        let v15: string =
            fable_library_rust::String_::fromStr(&format!("{:?}", &v14.display()));
        let v18: Array<std::string::String> =
            array(&[v5, v9, v12, (&v15).to_string()]);
        let v20 = core::ops::Deref::deref(&v18);
        format!("{:?}", v20).clone()
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
                    v1: Func0<std::string::String>, v2: i64,
                    v3: Supervisor::US0, v4: std::string::String) {
        let v5: Supervisor::US0 = v0_1();
        if match &v5 {
               Supervisor::US0::US0_1 => 3i32,
               Supervisor::US0::US0_2 => 1i32,
               Supervisor::US0::US0_3 => 2i32,
               _ => 0i32,
           } <=
               match &v3 {
                   Supervisor::US0::US0_1 => 3i32,
                   Supervisor::US0::US0_2 => 1i32,
                   Supervisor::US0::US0_3 => 2i32,
                   _ => 0i32,
               } {
            let v10: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v16: string =
                Supervisor::method2(6i32,
                                    toString(&((&v10).timestamp() - v2)));
            let v29: Array<std::string::String> =
                array(&[(&string("timestamp:")).to_string(),
                        (&v16).to_string(), (&string("run_id:")).to_string(),
                        format!("{:?}", &999i32)]);
            let v31 = core::ops::Deref::deref(&v29);
            let v33: std::string::String = format!("{:?}", v31).clone();
            let v34: string =
                stringFrom(format!("{0} {1} {2}", &v4, &v1(), &v33));
            println!("{0}", v34);
            ()
        }
    }
    pub fn closure4(v0_1: Func0<Supervisor::US0>,
                    v1: Func0<std::string::String>, v2: i64,
                    v3: Supervisor::US0) -> Func1<std::string::String, ()> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       let v2 = v2.clone();
                       let v3 = v3.clone();
                       move |v: std::string::String|
                           Supervisor::closure5(v0_1.clone(), v1.clone(), v2,
                                                v3.clone(), v.clone())
                   })
    }
    pub fn method0(v0_1: Func0<Supervisor::US0>,
                   v1: Func0<std::string::String>)
     -> Func1<Supervisor::US0, Func1<std::string::String, ()>> {
        let patternInput: (string, string, string, bool) =
            Supervisor::method1();
        let v7: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: i64 = (&v7).timestamp();
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       let v9 = v9.clone();
                       move |v: Supervisor::US0|
                           Supervisor::closure4(v0_1.clone(), v1.clone(), v9,
                                                v.clone())
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
        let v3 =
            Func0::new({
                           let v0_1 = v0_1.clone();
                           let v1 = v1.clone();
                           move ||
                               Supervisor::closure3(v0_1.clone(), v1.clone(),
                                                    ())
                       });
        let v5 = Supervisor::method0(Func0::from(v2), v3);
        let v7: Result<std::path::PathBuf, std::io::Error> =
            (&v0_1).canonicalize();
        let v9: std::path::PathBuf = (&v7).as_ref().unwrap().to_path_buf();
        let v11: Option<&std::path::Path> = (&v9).parent();
        let v13: &std::path::Path = (&v11).unwrap();
        let v15: std::path::PathBuf = std::path::PathBuf::from(&v13);
        let v16: Result<std::path::PathBuf, std::io::Error> =
            (&v15).canonicalize();
        let v17: std::path::PathBuf = (&v16).as_ref().unwrap().to_path_buf();
        let v19: &std::path::Ancestors = &v17.ancestors();
        let v22: _ = v19.take(10i32 as usize);
        fn v23(v: &std::path::Path) -> std::path::PathBuf {
            Supervisor::closure6((), v)
        }
        let v26: _ = v22.into_iter().map((&v23).clone());
        fn v27(v_1: &std::path::PathBuf) -> bool {
            Supervisor::closure7((), v_1)
        }
        let v30: Option<std::path::PathBuf> =
            v26.into_iter().find((&v27).clone());
        let v31: std::path::PathBuf = (&v30).as_ref().unwrap().to_path_buf();
        let v33: Option<&str> = (&v9).to_str();
        let v34: &str = (&v33).unwrap();
        let v37: string = string(".spi");
        let v40: &str =
            &v34.replace(&*(&string(".spir")).clone(), &(&v37).clone());
        let v44: &str =
            &v40.replace(&*(&v37).clone(), &(&string(".fsx")).clone());
        let v45: std::path::PathBuf = std::path::PathBuf::from(&v44);
        let v46: Result<std::path::PathBuf, std::io::Error> =
            (&v45).canonicalize();
        let v47: std::path::PathBuf = (&v46).as_ref().unwrap().to_path_buf();
        let v50: Result<(), std::io::Error> =
            std::fs::write(v47.clone(), string("").as_str());
        *((&v50).as_ref()).unwrap();
        {
            let v53: Result<std::string::String, std::io::Error> =
                std::fs::read_to_string(&v31);
            let v55: std::string::String =
                (&v53).as_ref().unwrap().to_string();
            let v57 =
                serde_json::json!({"ProjectFileOpen": {"uri": v31.clone(), "spiprojText": v55}});
            let v59: std::string::String = v57.to_string();
            let v61 = zmq::Context::new();
            let v63 = v61.socket(zmq::REQ).unwrap();
            let v64: string =
                stringFrom(format!("tcp://localhost:{0}", &13805i32));
            v63.connect(&v64.clone()).unwrap();
            v63.send(v59.as_str(), 0).unwrap();
            {
                let v68 = v63.recv_string(0).unwrap().unwrap();
                v63.disconnect(&v64).unwrap();
                {
                    let v72 =
                        serde_json::json!({"BuildFile": {"uri": v9.clone(), "backend": *string("Fsharp")}});
                    let v73: std::string::String = v72.to_string();
                    let v74 = zmq::Context::new();
                    let v75 = v74.socket(zmq::REQ).unwrap();
                    let v76: string =
                        stringFrom(format!("tcp://localhost:{0}", &13805i32));
                    v75.connect(&v76.clone()).unwrap();
                    v75.send(v73.as_str(), 0).unwrap();
                    {
                        let v78 = v75.recv_string(0).unwrap().unwrap();
                        v75.disconnect(&v76).unwrap();
                        {
                            let v80 = v5(Supervisor::US0::US0_0);
                            let v84: std::string::String =
                                (&string("> spi_to_fsx ()")).to_string().clone();
                            let v87: std::string::String =
                                (&string("pwd:")).to_string().clone();
                            let v89:
                                    Result<std::path::PathBuf,
                                           std::io::Error> =
                                std::env::current_dir();
                            let v90: std::path::PathBuf =
                                (&v89).as_ref().unwrap().to_path_buf();
                            let v91:
                                    Result<std::path::PathBuf,
                                           std::io::Error> =
                                (&v90).canonicalize();
                            let v92: std::path::PathBuf =
                                (&v91).as_ref().unwrap().to_path_buf();
                            let v94: string =
                                fable_library_rust::String_::fromStr(&format!("{:?}", &v92.display()));
                            let v96: std::string::String =
                                (&v94).to_string().clone();
                            let v99: std::string::String =
                                (&string("spi_path_clean:")).to_string().clone();
                            let v100: string =
                                fable_library_rust::String_::fromStr(&format!("{:?}", &v9.display()));
                            let v102: std::string::String =
                                (&v100).to_string().clone();
                            let v105: std::string::String =
                                (&string("src_path:")).to_string().clone();
                            let v106: string =
                                fable_library_rust::String_::fromStr(&format!("{:?}", &v17.display()));
                            let v108: std::string::String =
                                (&v106).to_string().clone();
                            let v111: std::string::String =
                                (&string("spiproj_path:")).to_string().clone();
                            let v112: string =
                                fable_library_rust::String_::fromStr(&format!("{:?}", &v31.display()));
                            let v114: std::string::String =
                                (&v112).to_string().clone();
                            let v117: std::string::String =
                                (&string("fsx_path:")).to_string().clone();
                            let v118: string =
                                fable_library_rust::String_::fromStr(&format!("{:?}", &v47.display()));
                            let v121: Array<std::string::String> =
                                array(&[v84, v87, v96, v99, v102, v105, v108,
                                        v111, v114, v117,
                                        (&v118).to_string()]);
                            let v123 = core::ops::Deref::deref(&v121);
                            v80(format!("{:?}", v123).clone());
                            string("???")
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
