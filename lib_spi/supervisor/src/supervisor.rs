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
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::string;
    pub fn closure2(unitVar: (), v0_1: &std::path::Path)
     -> std::path::PathBuf {
        v0_1.join(string("package.spiproj").as_str())
    }
    pub fn closure3(unitVar: (), v0_1: &std::path::PathBuf) -> bool {
        std::path::Path::exists(&v0_1)
    }
    pub fn closure1(v0_1: std::path::PathBuf, v1: Option<std::path::PathBuf>)
     -> string {
        println!("{0}", string("\n| spi_to_fsx."));
        println!("{0}", string("\npwd:"));
        {
            let v5: Result<std::path::PathBuf, std::io::Error> =
                std::env::current_dir();
            let v7: std::path::PathBuf =
                (&v5).as_ref().unwrap().to_path_buf();
            let v9: Result<std::path::PathBuf, std::io::Error> =
                (&v7).canonicalize();
            let v10: std::path::PathBuf =
                (&v9).as_ref().unwrap().to_path_buf();
            let v12: string =
                fable_library_rust::String_::fromStr(&format!("{:?}", &v10.display()));
            println!("{0}", v12);
            println!("{0}", string("\nspi_path:"));
            {
                let v14: string =
                    fable_library_rust::String_::fromStr(&format!("{:?}", &v0_1.display()));
                println!("{0}", v14);
                {
                    let v15: Result<std::path::PathBuf, std::io::Error> =
                        (&v0_1).canonicalize();
                    let v16: std::path::PathBuf =
                        (&v15).as_ref().unwrap().to_path_buf();
                    println!("{0}", string("\nspi_path_clean:"));
                    {
                        let v18: string =
                            fable_library_rust::String_::fromStr(&format!("{:?}", &v16.display()));
                        println!("{0}", v18);
                        {
                            let v20: Option<&std::path::Path> =
                                (&v16).parent();
                            let v22: &std::path::Path = (&v20).unwrap();
                            let v24: std::path::PathBuf =
                                std::path::PathBuf::from(&v22);
                            let v25:
                                    Result<std::path::PathBuf,
                                           std::io::Error> =
                                (&v24).canonicalize();
                            let v26: std::path::PathBuf =
                                (&v25).as_ref().unwrap().to_path_buf();
                            println!("{0}", string("\nsrc_path:"));
                            {
                                let v28: string =
                                    fable_library_rust::String_::fromStr(&format!("{:?}", &v26.display()));
                                println!("{0}", v28);
                                {
                                    let v30: &std::path::Ancestors =
                                        &v26.ancestors();
                                    let v33: _ = v30.take(10i32 as usize);
                                    fn v34(v: &std::path::Path)
                                     -> std::path::PathBuf {
                                        Supervisor::closure2((), v)
                                    }
                                    let v36: _ =
                                        v33.into_iter().map(v34);
                                    fn v37(v_1: &std::path::PathBuf) -> bool {
                                        Supervisor::closure3((), v_1)
                                    }
                                    let v39: Option<std::path::PathBuf> =
                                        v36.into_iter().find(v37);
                                    let v40: std::path::PathBuf =
                                        (&v39).as_ref().unwrap().to_path_buf();
                                    println!("{0}",
                                             string("\nspiproj_path:"));
                                    {
                                        let v42: string =
                                            fable_library_rust::String_::fromStr(&format!("{:?}", &v40.display()));
                                        println!("{0}", v42);
                                        println!("{0}",
                                                 string("\nnew_fsx_path:"));
                                        {
                                            let v44: std::path::PathBuf =
                                                (&v1).as_ref().unwrap().to_path_buf();
                                            let v45: string =
                                                fable_library_rust::String_::fromStr(&format!("{:?}", &v44.display()));
                                            println!("{0}", v45);
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
#[path = "./std.rs"]
mod module_fee46fe3;
pub use module_fee46fe3::*;
