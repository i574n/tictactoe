use wasm_bindgen::prelude::*;

pub mod client;

#[wasm_bindgen]
pub fn client() {
    // std::panic::set_hook(Box::new(console_error_panic_hook::hook));
    let _x = client::Client::v0()();
    web_sys::console::log_1(&"client end".into());
    ()
}
