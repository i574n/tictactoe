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
    use fable_library_rust::Native_::Func2;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::arrayEmpty;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::substring2;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 { US0_0, US0_1, US0_2, US0_3, }
    pub fn closure1(unitVar: (), unitVar_1: ()) -> Cli::US0 {
        Cli::US0::US0_0
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> std::string::String {
        let v4: Array<std::string::String> =
            array(&[(&string("> app ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn closure3(unitVar: (), v0_1: string) { println!("{0}", v0_1); () }
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
    pub fn closure5(v0_1: Func0<Cli::US0>, v1: Func0<std::string::String>,
                    v2: Func1<string, ()>, v3: string, v4: i64, v5: Cli::US0,
                    v6: std::string::String) {
        let v7: Cli::US0 = v0_1();
        if match &v7 {
               Cli::US0::US0_1 => 3i32,
               Cli::US0::US0_2 => 1i32,
               Cli::US0::US0_3 => 2i32,
               _ => 0i32,
           } <=
               match &v5 {
                   Cli::US0::US0_1 => 3i32,
                   Cli::US0::US0_2 => 1i32,
                   Cli::US0::US0_3 => 2i32,
                   _ => 0i32,
               } {
            let v18: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v24: string =
                Cli::method2(6i32, toString(&((&v18).timestamp() - v4)));
            let v26: u8 = rand::random::<u8>();
            let v39: Array<std::string::String> =
                array(&[(&string("timestamp:")).to_string(),
                        (&v24).to_string(), (&string("run_id:")).to_string(),
                        format!("{}", &v26)]);
            let v41 = core::ops::Deref::deref(&v39);
            let v44: std::string::String = format!("{:?}", ***v41).clone();
            let v45: std::string::String = v1();
            let v48 =
                colored::Colorize::color(&*v45, string("purple").to_string());
            let v49: std::string::String = format!("{}", v48);
            let v50: string = substring2(v3.clone(), 0i32, 2i32);
            let v52: u8 = u8::from_str_radix(&v50, 16).unwrap();
            let v53: string = substring2(v3.clone(), 2i32, 2i32);
            let v54: u8 = u8::from_str_radix(&v53, 16).unwrap();
            let v55: string = substring2(v3, 4i32, 2i32);
            let v56: u8 = u8::from_str_radix(&v55, 16).unwrap();
            let v58 =
                colored::Colorize::truecolor(&*v6.to_string(), v52, v54, v56);
            let v59: std::string::String = format!("{}", v58);
            let v60: string = string("222222");
            let v61: string = substring2(v60.clone(), 0i32, 2i32);
            let v62: u8 = u8::from_str_radix(&v61, 16).unwrap();
            let v63: string = substring2(v60.clone(), 2i32, 2i32);
            let v64: u8 = u8::from_str_radix(&v63, 16).unwrap();
            let v65: string = substring2(v60, 4i32, 2i32);
            let v66: u8 = u8::from_str_radix(&v65, 16).unwrap();
            let v67 =
                colored::Colorize::truecolor(&*v44.to_string(), v62, v64, v66);
            v2(stringFrom(format!("{0} {1} {2}", &v49, &v59,
                                  format!("{}", v67))))
        }
    }
    pub fn closure4(v0_1: Func0<Cli::US0>, v1: Func0<std::string::String>,
                    v2: Func1<string, ()>, v3: string, v4: i64, v5: Cli::US0)
     -> Func1<std::string::String, ()> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       let v2 = v2.clone();
                       let v3 = v3.clone();
                       let v4 = v4.clone();
                       let v5 = v5.clone();
                       move |v: std::string::String|
                           Cli::closure5(v0_1.clone(), v1.clone(), v2.clone(),
                                         v3.clone(), v4, v5.clone(),
                                         v.clone())
                   })
    }
    pub fn method0(v0_1: Func0<Cli::US0>, v1: Func0<std::string::String>,
                   v2: Func1<string, ()>, v3: string)
     -> Func1<Cli::US0, Func1<std::string::String, ()>> {
        let patternInput: (string, string, string, bool) = Cli::method1();
        let v9: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v11: i64 = (&v9).timestamp();
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       let v11 = v11.clone();
                       let v2 = v2.clone();
                       let v3 = v3.clone();
                       move |v: Cli::US0|
                           Cli::closure4(v0_1.clone(), v1.clone(), v2.clone(),
                                         v3.clone(), v11, v.clone())
                   })
    }
    pub fn method3() -> string { string("./cli.rs") }
    pub fn closure6(unitVar: (), unitVar_1: ()) -> Cli::US0 {
        Cli::US0::US0_0
    }
    pub fn closure7(unitVar: (), unitVar_1: ()) -> std::string::String {
        let v4: Array<std::string::String> =
            array(&[(&string("> read_lines ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn closure8(v0_1: Func2<Cli::US0, std::string::String, ()>,
                    v1: Vec<u8>) -> Result<bool, std::io::Error> {
        let v3 = Func1::new(move |arg0| v0_1(Cli::US0::US0_0, arg0));
        let v11: Array<std::string::String> =
            array(&[(&string("line:")).to_string(), format!("{:?}", &v1)]);
        let v13 = core::ops::Deref::deref(&v11);
        v3(format!("{:?}", ***v13).clone());
        Ok(true)
    }
    pub fn method4(v0_1: Func2<Cli::US0, std::string::String, ()>)
     -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        let v = v0_1;
        Func1::new({
                       let v = v.clone();
                       move |v_1: Vec<u8>|
                           Cli::closure8(v.clone(), v_1.clone())
                   })
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        fn v0_1() -> Cli::US0 { Cli::closure1((), ()) }
        fn v1() -> std::string::String { Cli::closure2((), ()) }
        fn v2(v: string) { Cli::closure3((), v); }
        let v3: string = string("666666");
        let v4 =
            Cli::method0(Func0::from(v0_1), Func0::from(v1), Func1::from(v2),
                         v3.clone());
        let v5: string = Cli::method3();
        let v7: &str = &v5.as_str();
        let v9: std::path::PathBuf = std::path::PathBuf::from(&v7);
        fn v10() -> Cli::US0 { Cli::closure6((), ()) }
        fn v11() -> std::string::String { Cli::closure7((), ()) }
        let v12 =
            Cli::method0(Func0::from(v10), Func0::from(v11), Func1::from(v2),
                         v3);
        let v14: Result<std::path::PathBuf, std::io::Error> =
            (&v9).canonicalize();
        let v16: std::path::PathBuf = (&v14).as_ref().unwrap().to_path_buf();
        let v18 = v12(Cli::US0::US0_0);
        let v22: std::string::String =
            (&string("path_clean:")).to_string().clone();
        let v24: string =
            fable_library_rust::String_::fromStr(&format!("{}", &v16.display()));
        let v27: Array<std::string::String> =
            array(&[v22, (&v24).to_string()]);
        let v29 = core::ops::Deref::deref(&v27);
        v18(format!("{:?}", ***v29).clone());
        {
            let v34: Result<std::fs::File, std::io::Error> =
                std::fs::File::open(&v16);
            let v36: &std::fs::File = &v34.unwrap();
            let v38:
                    std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                std::cell::RefCell::new(linereader::LineReader::new(&v36));
            let v40 = v12(Cli::US0::US0_0);
            let v47: Array<std::string::String> =
                array(&[(&string("reader:")).to_string(),
                        format!("{:?}", &v38)]);
            let v48 = core::ops::Deref::deref(&v47);
            v40(format!("{:?}", ***v48).clone());
            {
                let v52: Vec<string> = vec![];
                let v53 =
                    Cli::method4(Func2::new(move |arg0, arg1| v12(arg0)(arg1)));
                let v55: Result<(), std::io::Error> =
                    (v38).borrow_mut().for_each(move |x| v53(x.to_vec()));
                *((&v55).as_ref()).unwrap();
                {
                    let v59 = v4(Cli::US0::US0_0);
                    let v66: Array<std::string::String> =
                        array(&[(&string("lines:")).to_string(),
                                format!("{}", &arrayEmpty::<string>())]);
                    let v67 = core::ops::Deref::deref(&v66);
                    v59(format!("{:?}", ***v67).clone());
                    0i32
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
