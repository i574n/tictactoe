use wasm_bindgen::prelude::*;

pub mod client;

#[wasm_bindgen]
pub fn client() -> i32 {
    web_sys::console::log_1(&"Hello using web-sys".into());
    std::panic::set_hook(Box::new(console_error_panic_hook::hook));
    let a = client::Client::v0()();
    println!("a={}", a);
    2i32
}
