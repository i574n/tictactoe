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
    // use fable_library_rust::Native_::Func0;
    // use fable_library_rust::Native_::MutCell;
    // use fable_library_rust::Native_::on_startup;
    // use fable_library_rust::String_::string;
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        // web_sys::console::log_1(&wasm_bindgen::JsValue::from_str(&string("app ()")));
        web_sys::console::log_1(&wasm_bindgen::JsValue::from_str("app ()"));
        1i32
    }
    pub fn v0() -> i32 {
        let x = Client::closure0((), ());
        x
        // static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        // v0.get_or_init(move || Func0::new(move || Client::closure0((), ())))
    }
    // on_startup!(());
}
#[path = "../../supervisor/src/Types.rs"]
mod module_6e8b5e6f;
pub use module_6e8b5e6f::*;
