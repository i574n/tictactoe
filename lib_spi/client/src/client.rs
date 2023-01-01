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
    use fable_library_rust::Native_::on_startup;
    on_startup!(());
}
#[path = "../../supervisor/src/Types.rs"]
mod module_6e8b5e6f;
pub use module_6e8b5e6f::*;
