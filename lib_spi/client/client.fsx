let rec closure0 () () : int32 =
    let v0 : string = "app ()"
    let v1 : string = "web_sys::console::log_1(&wasm_bindgen::JsValue::from_str($0))"
    Fable.Core.Rust.emitExpr v0 v1
    0
let v0 : (unit -> int32) = closure0()
()
