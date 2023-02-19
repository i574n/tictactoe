#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::MutCell;
        #[rocket::get("/<uri..>")]
        async fn proxy(
            uri: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,
            client: &rocket::State<reqwest::Client>,
        ) -> Result<rocket::response::content::RawHtml<String>, rocket::http::Status> {
            let uri = uri.clone();
            let uri = uri.collect::<Vec<_>>();
            let uri = uri.join("/");
            let uri = uri.replace(":/", "://");
            let (host_url, url) = uri.split_once('|').unwrap_or(("", &uri));
            let (host_protocol, host_host) = host_url
                .split_once("://")
                .unwrap_or(("https", "www.github.com"));
            let (protocol, suffix) = url.split_once("://").unwrap_or((host_protocol, url));
            let (host, path) = match (url.split_once("://"), suffix.split_once("/")) {
                (Some(_), None) if suffix != "" => (suffix, ""),
                _ => (host_host, suffix),
            };
            let new_url = match path {
                "" => format!("{protocol}://{host}"),
                _ => format!("{protocol}://{host}/{path}"),
            };
            println!("uri={uri}; new_url={new_url}; host={host}; path={path}; suffix={suffix}; host_url={host_url}; url={url}; host_host={host_host}; host_protocol={host_protocol}; protocol={protocol}");
            let res = client
                .get(new_url)
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
