#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Proxy {
    use super::*;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::MutCell;
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        ();
        ()
    }
    pub fn v0() -> Func0<()> {
        static v0: MutCell<Option<Func0<()>>> = MutCell::new(None);
        v0.get_or_init(move || Func0::new(move || Proxy::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;

#[rocket::get("/<uri..>")]
async fn proxy(
    uri: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,
    client: &rocket::State<reqwest::Client>,
) -> Result<rocket::response::content::RawHtml<String>, rocket::http::Status> {
    let uri: String = match uri.clone().get(0).unwrap().find(":") {
        Some(_) => uri.clone().skip(1).collect::<Vec<_>>().join("/"),
        None => format!("github.com/{}", uri.clone().collect::<Vec<_>>().join("/")),
    };
    let uri = format!("https://{}", uri);
    let res = client
        .get(uri)
        .send()
        .await
        .map_err(|_| rocket::http::Status::NotFound);

    match res {
        Ok(res) => {
            let content = res.text();
            let content = content.await;
            let content = content.map_err(|_| rocket::http::Status::InternalServerError);
            let content = content.unwrap();
            Ok(rocket::response::content::RawHtml(content))
        }
        Err(status) => Err(status),
    }
}

#[rocket::get("/file/<file..>")]
async fn file(
    file: std::path::PathBuf,
    client: &rocket::State<reqwest::Client>,
) -> std::option::Option<rocket::fs::NamedFile> {
    rocket::fs::NamedFile::open(std::path::Path::new("./").join(file))
        .await
        .ok()
}

#[rocket::launch]
fn rocket() -> _ {
    rocket::build()
        .manage(reqwest::Client::new())
        .mount("/", rocket::routes![proxy, file])
}
