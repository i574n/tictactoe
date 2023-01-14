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
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::string;
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        web_sys::console::log_1(&wasm_bindgen::JsValue::from_str(&string("app ()")));
        {
            let v3 = web_sys::window().unwrap();
            let v5 = v3.document().unwrap();
            let v7 = v5.body().unwrap();
            let v9 = v5.create_element("iframe").unwrap();
            v9.set_attribute("src", "https://time.is").unwrap();
            v9.set_attribute("width", "100%").unwrap();
            v9.set_attribute("height", "50vh").unwrap();
            v7.append_child(&v9).unwrap();
            0i32
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
