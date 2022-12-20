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
    use fable_library_rust::Native_::Func0;
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 { US0_0, US0_1, US0_2, US0_3, }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US1 { US1_0, US1_1(string), }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub struct Mut0 {
        pub l0: MutCell<i32>,
        pub l1: MutCell<Supervisor::US1>,
    }
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
            let v19: u8 = rand::random::<u8>();
            let v32: Array<std::string::String> =
                array(&[(&string("timestamp:")).to_string(),
                        (&v17).to_string(), (&string("run_id:")).to_string(),
                        format!("{}", &v19)]);
            let v34 = core::ops::Deref::deref(&v32);
            let v37: std::string::String = format!("{:?}", ***v34).clone();
            let v38: std::string::String = v1();
            let v41 =
                colored::Colorize::color(&*v38, string("purple").to_string());
            let v42: std::string::String = format!("{}", v41);
            let v43: string = substring2(v2.clone(), 0i32, 2i32);
            let v45: u8 = u8::from_str_radix(&v43, 16).unwrap();
            let v46: string = substring2(v2.clone(), 2i32, 2i32);
            let v47: u8 = u8::from_str_radix(&v46, 16).unwrap();
            let v48: string = substring2(v2, 4i32, 2i32);
            let v49: u8 = u8::from_str_radix(&v48, 16).unwrap();
            let v51 =
                colored::Colorize::truecolor(&*v5.to_string(), v45, v47, v49);
            let v52: std::string::String = format!("{}", v51);
            let v53: string = string("222222");
            let v54: string = substring2(v53.clone(), 0i32, 2i32);
            let v55: u8 = u8::from_str_radix(&v54, 16).unwrap();
            let v56: string = substring2(v53.clone(), 2i32, 2i32);
            let v57: u8 = u8::from_str_radix(&v56, 16).unwrap();
            let v58: string = substring2(v53, 4i32, 2i32);
            let v59: u8 = u8::from_str_radix(&v58, 16).unwrap();
            let v60 =
                colored::Colorize::truecolor(&*v37.to_string(), v55, v57, v59);
            let v61: std::string::String = format!("{}", v60);
            println!("{0}",
                     stringFrom(format!("{0} {1} {2}", &v42, &v52, &v61)));
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
            array(&[(&string("> zmq_request ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) -> Supervisor::US0 {
        Supervisor::US0::US0_0
    }
    pub fn closure13(unitVar: (), unitVar_1: ()) -> std::string::String {
        let v4: Array<std::string::String> =
            array(&[(&string("> spi_build_file ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn closure14(unitVar: (), unitVar_1: ()) -> Supervisor::US0 {
        Supervisor::US0::US0_0
    }
    pub fn closure15(unitVar: (), unitVar_1: ()) -> std::string::String {
        let v4: Array<std::string::String> =
            array(&[(&string("> wait_file_change ()")).to_string()]);
        let v6 = core::ops::Deref::deref(&v4);
        format!("{:?}", ***v6).clone()
    }
    pub fn method3(v0_1: i32, v1: Lrc<Supervisor::Mut0>) -> bool {
        v1.l0.get() < v0_1
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
                        let v120: string = string("fsx_path:");
                        let v122: std::string::String =
                            (&v120).to_string().clone();
                        let v123: string =
                            fable_library_rust::String_::fromStr(&format!("{}", &v117.display()));
                        let v126: Array<std::string::String> =
                            array(&[v122, (&v123).to_string()]);
                        let v127 = core::ops::Deref::deref(&v126);
                        v119(format!("{:?}", ***v127).clone());
                        {
                            let v130: string = string("");
                            let v132: Result<(), std::io::Error> =
                                std::fs::write(v117.clone(), v130.clone().as_str());
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
                                        fn v193() -> Supervisor::US0 {
                                            Supervisor::closure10((), ())
                                        }
                                        fn v194() -> std::string::String {
                                            Supervisor::closure11((), ())
                                        }
                                        let v195: string = string("fcfb1b");
                                        let v196 =
                                            Supervisor::method0(Func0::from(v193),
                                                                Func0::from(v194),
                                                                v195.clone());
                                        let v198 =
                                            v196(Supervisor::US0::US0_0);
                                        let v199: string = string("host:");
                                        let v201: std::string::String =
                                            (&v199).to_string().clone();
                                        let v202: string =
                                            string("localhost");
                                        let v204: std::string::String =
                                            (&v202).to_string().clone();
                                        let v205: string = string("port:");
                                        let v207: std::string::String =
                                            (&v205).to_string().clone();
                                        let v209: std::string::String =
                                            format!("{}", &13805i32).clone();
                                        let v210: string =
                                            string("msg.len():");
                                        let v212: std::string::String =
                                            (&v210).to_string().clone();
                                        let v213: i32 =
                                            (&v180).len().try_into().unwrap();
                                        let v216: Array<std::string::String> =
                                            array(&[v201, v204, v207, v209,
                                                    v212,
                                                    format!("{}", &v213)]);
                                        let v217 =
                                            core::ops::Deref::deref(&v216);
                                        v198(format!("{:?}", ***v217).clone());
                                        {
                                            let v221 = zmq::Context::new();
                                            let v223 =
                                                v221.socket(zmq::REQ).unwrap();
                                            let v224: string =
                                                stringFrom(format!("tcp://{0}:{1}",
                                                                   &v202,
                                                                   &13805i32));
                                            v223.connect(&v224.clone()).unwrap();
                                            v223.send(v180.as_str(), 0).unwrap();
                                            {
                                                let v228:
                                                        std::string::String =
                                                    v223.recv_string(0).unwrap().unwrap();
                                                v223.disconnect(&v224).unwrap();
                                                {
                                                    let v231 =
                                                        v196(Supervisor::US0::US0_0);
                                                    let v232: string =
                                                        string("result.len():");
                                                    let v234:
                                                            std::string::String =
                                                        (&v232).to_string().clone();
                                                    let v235: i32 =
                                                        (&v228).len().try_into().unwrap();
                                                    let v238:
                                                            Array<std::string::String> =
                                                        array(&[v234,
                                                                format!("{}", &v235)]);
                                                    let v239 =
                                                        core::ops::Deref::deref(&v238);
                                                    v231(format!("{:?}", ***v239).clone());
                                                    v5(Supervisor::US0::US0_0)((&string("> spiproj_open; ok")).to_string().clone());
                                                    {
                                                        fn v247()
                                                         -> Supervisor::US0 {
                                                            Supervisor::closure12((),
                                                                                  ())
                                                        }
                                                        fn v248()
                                                         ->
                                                             std::string::String {
                                                            Supervisor::closure13((),
                                                                                  ())
                                                        }
                                                        let v250 =
                                                            Supervisor::method0(Func0::from(v247),
                                                                                Func0::from(v248),
                                                                                string("98d5ef"));
                                                        let v252 =
                                                            v250(Supervisor::US0::US0_0);
                                                        let v254:
                                                                std::string::String =
                                                            (&v23).to_string().clone();
                                                        let v255: string =
                                                            fable_library_rust::String_::fromStr(&format!("{}", &v43.display()));
                                                        let v261: string =
                                                            string("Fsharp");
                                                        let v264:
                                                                Array<std::string::String> =
                                                            array(&[v254,
                                                                    (&v255).to_string(),
                                                                    (&string("backend:")).to_string(),
                                                                    (&v261).to_string()]);
                                                        let v265 =
                                                            core::ops::Deref::deref(&v264);
                                                        v252(format!("{:?}", ***v265).clone());
                                                        {
                                                            let v268:
                                                                    std::string::String =
                                                                (&v261).to_string();
                                                            let v277: string =
                                                                append(append(v176,
                                                                              append(append(append(append(append(v166,
                                                                                                                 string("\"BuildFile\": {")),
                                                                                                          v169),
                                                                                                   string("\"backend\": $1")),
                                                                                            v173.clone()),
                                                                                     v173)),
                                                                       v178);
                                                            let v278:
                                                                    std::string::String =
                                                                serde_json::json!({"BuildFile": {"uri": v43,"backend": v268}}).to_string();
                                                            let v280 =
                                                                v250(Supervisor::US0::US0_0);
                                                            let v282:
                                                                    std::string::String =
                                                                (&v183).to_string().clone();
                                                            let v283: i32 =
                                                                (&v278).len().try_into().unwrap();
                                                            let v286:
                                                                    Array<std::string::String> =
                                                                array(&[v282,
                                                                        format!("{}", &v283)]);
                                                            let v287 =
                                                                core::ops::Deref::deref(&v286);
                                                            v280(format!("{:?}", ***v287).clone());
                                                            {
                                                                let v290 =
                                                                    Supervisor::method0(Func0::from(v193),
                                                                                        Func0::from(v194),
                                                                                        v195);
                                                                let v292 =
                                                                    v290(Supervisor::US0::US0_0);
                                                                let v294:
                                                                        std::string::String =
                                                                    (&v199).to_string().clone();
                                                                let v296:
                                                                        std::string::String =
                                                                    (&v202).to_string().clone();
                                                                let v298:
                                                                        std::string::String =
                                                                    (&v205).to_string().clone();
                                                                let v300:
                                                                        std::string::String =
                                                                    format!("{}", &13805i32).clone();
                                                                let v302:
                                                                        std::string::String =
                                                                    (&v210).to_string().clone();
                                                                let v303:
                                                                        i32 =
                                                                    (&v278).len().try_into().unwrap();
                                                                let v306:
                                                                        Array<std::string::String> =
                                                                    array(&[v294,
                                                                            v296,
                                                                            v298,
                                                                            v300,
                                                                            v302,
                                                                            format!("{}", &v303)]);
                                                                let v307 =
                                                                    core::ops::Deref::deref(&v306);
                                                                v292(format!("{:?}", ***v307).clone());
                                                                {
                                                                    let v310 =
                                                                        zmq::Context::new();
                                                                    let v311 =
                                                                        v310.socket(zmq::REQ).unwrap();
                                                                    let v312:
                                                                            string =
                                                                        stringFrom(format!("tcp://{0}:{1}",
                                                                                           &v202,
                                                                                           &13805i32));
                                                                    v311.connect(&v312.clone()).unwrap();
                                                                    v311.send(v278.as_str(), 0).unwrap();
                                                                    {
                                                                        let v314:
                                                                                std::string::String =
                                                                            v311.recv_string(0).unwrap().unwrap();
                                                                        v311.disconnect(&v312).unwrap();
                                                                        {
                                                                            let v316 =
                                                                                v290(Supervisor::US0::US0_0);
                                                                            let v318:
                                                                                    std::string::String =
                                                                                (&v232).to_string().clone();
                                                                            let v319:
                                                                                    i32 =
                                                                                (&v314).len().try_into().unwrap();
                                                                            let v322:
                                                                                    Array<std::string::String> =
                                                                                array(&[v318,
                                                                                        format!("{}", &v319)]);
                                                                            let v323 =
                                                                                core::ops::Deref::deref(&v322);
                                                                            v316(format!("{:?}", ***v323).clone());
                                                                            v5(Supervisor::US0::US0_0)((&string("> spi_build_file; ok")).to_string().clone());
                                                                            {
                                                                                fn v331()
                                                                                 ->
                                                                                     Supervisor::US0 {
                                                                                    Supervisor::closure14((),
                                                                                                          ())
                                                                                }
                                                                                fn v332()
                                                                                 ->
                                                                                     std::string::String {
                                                                                    Supervisor::closure15((),
                                                                                                          ())
                                                                                }
                                                                                let v334 =
                                                                                    Supervisor::method0(Func0::from(v331),
                                                                                                        Func0::from(v332),
                                                                                                        string("387957"));
                                                                                let v336:
                                                                                        std::time::SystemTime =
                                                                                    std::fs::metadata(&v117).unwrap().modified().unwrap();
                                                                                let v338 =
                                                                                    v334(Supervisor::US0::US0_0);
                                                                                let v340:
                                                                                        std::string::String =
                                                                                    (&v120).to_string().clone();
                                                                                let v341:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromStr(&format!("{}", &v117.display()));
                                                                                let v350:
                                                                                        Array<std::string::String> =
                                                                                    array(&[v340,
                                                                                            (&v341).to_string(),
                                                                                            (&string("start:")).to_string(),
                                                                                            format!("{:?}", &v336)]);
                                                                                let v351 =
                                                                                    core::ops::Deref::deref(&v350);
                                                                                v338(format!("{:?}", ***v351).clone());
                                                                                {
                                                                                    let v354:
                                                                                            Array<i32> =
                                                                                        toArray(rangeNumeric(0i32,
                                                                                                             1i32,
                                                                                                             50i32).clone());
                                                                                    let v355:
                                                                                            i32 =
                                                                                        v354.len()
                                                                                            as
                                                                                            i32;
                                                                                    let v357:
                                                                                            Lrc<Supervisor::Mut0> =
                                                                                        Lrc::new(Supervisor::Mut0{l0:
                                                                                                                      MutCell::new(0i32),
                                                                                                                  l1:
                                                                                                                      MutCell::new(Supervisor::US1::US1_0),});
                                                                                    while Supervisor::method3(v355,
                                                                                                              v357.clone())
                                                                                          {
                                                                                        let v359:
                                                                                                i32 =
                                                                                            v357.l0.get();
                                                                                        let v360:
                                                                                                Supervisor::US1 =
                                                                                            v357.l1.get().clone();
                                                                                        let v361:
                                                                                                i32 =
                                                                                            v354[v359].clone();
                                                                                        let v391:
                                                                                                Supervisor::US1 =
                                                                                            match &v360
                                                                                                {
                                                                                                Supervisor::US1::US1_1(v360_1_0)
                                                                                                =>
                                                                                                Supervisor::US1::US1_1(v360_1_0.clone()),
                                                                                                _
                                                                                                =>
                                                                                                {
                                                                                                    let v362:
                                                                                                            std::time::SystemTime =
                                                                                                        std::fs::metadata(&v117).unwrap().modified().unwrap();
                                                                                                    let v364 =
                                                                                                        v334(Supervisor::US0::US0_0);
                                                                                                    let v375:
                                                                                                            Array<std::string::String> =
                                                                                                        array(&[(&string("i:")).to_string(),
                                                                                                                format!("{}", &v361),
                                                                                                                (&string("last_modified:")).to_string(),
                                                                                                                format!("{:?}", &v362)]);
                                                                                                    let v376 =
                                                                                                        core::ops::Deref::deref(&v375);
                                                                                                    v364(format!("{:?}", ***v376).clone());
                                                                                                    if v362 > v336
                                                                                                       {
                                                                                                        let v381:
                                                                                                                Result<std::string::String,
                                                                                                                       std::io::Error> =
                                                                                                            std::fs::read_to_string(&v117);
                                                                                                        let v382:
                                                                                                                std::string::String =
                                                                                                            (&v381).as_ref().unwrap().to_string();
                                                                                                        Supervisor::US1::US1_1(fable_library_rust::String_::fromStr(&v382))
                                                                                                    } else {
                                                                                                        std::thread::sleep(std::time::Duration::from_millis(*&100u64));
                                                                                                        Supervisor::US1::US1_0
                                                                                                    }
                                                                                                }
                                                                                            };
                                                                                        let v392:
                                                                                                i32 =
                                                                                            v359
                                                                                                +
                                                                                                1i32;
                                                                                        v357.l0.set(v392);
                                                                                        v357.l1.set(v391.clone());
                                                                                        ()
                                                                                    }
                                                                                    {
                                                                                        let v393:
                                                                                                Supervisor::US1 =
                                                                                            v357.l1.get().clone();
                                                                                        let v395:
                                                                                                string =
                                                                                            match &v393
                                                                                                {
                                                                                                Supervisor::US1::US1_1(v393_1_0)
                                                                                                =>
                                                                                                v393_1_0.clone(),
                                                                                                _
                                                                                                =>
                                                                                                v130,
                                                                                            };
                                                                                        let v397 =
                                                                                            v5(Supervisor::US0::US0_0);
                                                                                        let v400:
                                                                                                std::string::String =
                                                                                            (&string("new_fsx.len():")).to_string().clone();
                                                                                        let v401:
                                                                                                i32 =
                                                                                            (&v395).len().try_into().unwrap();
                                                                                        let v404:
                                                                                                Array<std::string::String> =
                                                                                            array(&[v400,
                                                                                                    format!("{}", &v401)]);
                                                                                        let v405 =
                                                                                            core::ops::Deref::deref(&v404);
                                                                                        v397(format!("{:?}", ***v405).clone());
                                                                                        {
                                                                                            let v408:
                                                                                                    std::path::PathBuf =
                                                                                                defaultValue(v117,
                                                                                                             v1);
                                                                                            let v409:
                                                                                                    Result<(),
                                                                                                           std::io::Error> =
                                                                                                std::fs::write(v408, v395.clone().as_str());
                                                                                            *((&v409).as_ref()).unwrap();
                                                                                            v5(Supervisor::US0::US0_0)((&string("> fs_write new_fsx_path; ok")).to_string().clone());
                                                                                            v395
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
#[path = "./Types.rs"]
mod module_b10c81cb;
pub use module_b10c81cb::*;
