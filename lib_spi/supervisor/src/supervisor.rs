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
    use fable_library_rust::String_::stringFrom;
    pub fn closure0(unitVar: (), v0_1: string) {
        println!("{0}", string("zmq_request."));
        println!("{0}", string("msg:"));
        println!("{0}", v0_1.clone());
        {
            let v4 = zmq::Context::new();
            let v6 = v4.socket(zmq::REQ).unwrap();
            let v7: string =
                stringFrom(format!("tcp://localhost:{0}", &13805i32));
            v6.connect(&v7.clone()).unwrap();
            v6.send(v0_1.as_str(), 0).unwrap();
            {
                let v11 = v6.recv_string(0).unwrap().unwrap();
                println!("{0}", string("zmq_request. result:"));
                println!("{0}", v11);
                v6.disconnect(&v7).unwrap();
                ()
            }
        }
    }
    pub fn closure2(v0_1:
                        fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>,
                    v1_1:
                        Option<fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>>)
     -> string {
        println!("{0}", string("| spi_to_fsx."));
        println!("{0}", string("spi_path:"));
        {
            let v5: string =
                fable_library_rust::String_::fromStr(Box::leak(format!("{:?}", (&v0_1).strip_prefix("").unwrap().display()).into_boxed_str()));
            println!("{0}", v5);
            {
                let v7:
                        fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>> =
                    std::rc::Rc::new(fable_library_rust::Native_::MutCell::new(Box::from((&v0_1).canonicalize().unwrap().strip_prefix("").unwrap())));
                println!("{0}", string("spi_path_canonicalize:"));
                {
                    let v9: string =
                        fable_library_rust::String_::fromStr(Box::leak(format!("{:?}", (&v7).strip_prefix("").unwrap().display()).into_boxed_str()));
                    println!("{0}", v9);
                    println!("{0}", string("new_fsx_path:"));
                    {
                        let v12:
                                fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>> =
                            (&v1_1).as_ref().unwrap().clone();
                        let v13: string =
                            fable_library_rust::String_::fromStr(Box::leak(format!("{:?}", (&v12).strip_prefix("").unwrap().display()).into_boxed_str()));
                        println!("{0}", v13);
                        string("")
                    }
                }
            }
        }
    }
    pub fn closure1(unitVar: (),
                    v0_1:
                        fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>)
     ->
         Func1<Option<fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>>,
               string> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move
                           |v:
                                Option<fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>>|
                           Supervisor::closure2(v0_1.clone(), v.clone())
                   })
    }
    pub fn v0() -> Func1<string, ()> {
        static v0: MutCell<Option<Func1<string, ()>>> = MutCell::new(None);
        v0.get_or_init(move ||
                           Func1::new(move |v: string|
                                          Supervisor::closure0((),
                                                               v.clone())))
    }
    pub fn v1()
     ->
         Func1<fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>,
               Func1<Option<fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>>,
                     string>> {
        static v1:
         MutCell<Option<Func1<fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>,
                              Func1<Option<fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>>,
                                    string>>>> =
            MutCell::new(None);
        v1.get_or_init(move ||
                           Func1::new(move
                                          |v:
                                               fable_library_rust::Native_::Lrc<fable_library_rust::Native_::MutCell<fable_library_rust::Native_::Box_<std::path::Path>>>|
                                          Supervisor::closure1((),
                                                               v.clone())))
    }
    on_startup!(());
}
#[path = "./std.rs"]
mod module_fee46fe3;
pub use module_fee46fe3::*;
