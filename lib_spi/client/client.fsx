let rec closure0 () () : int32 =
    let v0 : string = "app ()"
    let v1 : string = "web_sys::console::log_1(&wasm_bindgen::JsValue::from_str($0))"
    Fable.Core.Rust.emitExpr v0 v1
    let v2 : string = "web_sys::window().unwrap()"
    let v3 : obj = Fable.Core.Rust.emitExpr () v2
    let v4 : string = "$0.document().unwrap()"
    let v5 : obj = Fable.Core.Rust.emitExpr v3 v4
    let v6 : string = "$0.body().unwrap()"
    let v7 : obj = Fable.Core.Rust.emitExpr v5 v6
    let v8 : string = "$0.create_element(\"iframe\").unwrap()"
    let v9 : obj = Fable.Core.Rust.emitExpr v5 v8
    let v10 : string = "$0.set_attribute(\"src\", \"https://time.is\").unwrap()"
    Fable.Core.Rust.emitExpr v9 v10
    let v11 : string = "$0.set_attribute(\"width\", \"100%\").unwrap()"
    Fable.Core.Rust.emitExpr v9 v11
    let v12 : string = "$0.set_attribute(\"height\", \"50vh\").unwrap()"
    Fable.Core.Rust.emitExpr v9 v12
    let v13 : string = "$0.append_child(&$1).unwrap()"
    Fable.Core.Rust.emitExpr struct (v7, v9) v13
    0
let v0 : (unit -> int32) = closure0()
()
