let rec closure0 () () : unit =
    let v0 : string = "#[rocket::get(\"/<uri..>\")]"
    let v1 : string = " async fn proxy("
    let v2 : string = v0 + v1
    let v3 : string = "   url: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,"
    let v4 : string = v2 + v3
    let v5 : string = "   client: &rocket::State<reqwest::Client>"
    let v6 : string = v4 + v5
    let v7 : string = " ) -> Result<rocket::response::content::RawHtml<String>, rocket::http::Status> {"
    let v8 : string = v6 + v7
    let v9 : string = "   let uri : String = match uri.clone().get(0).unwrap().find(\":\") {"
    let v10 : string = v8 + v9
    let v11 : string = "     Some(_) => uri.clone().skip(1).collect::<Vec<_>>().join(\"/\"),"
    let v12 : string = v10 + v11
    let v13 : string = "     None => format!(\"github.com/{}\", uri.clone().collect::<Vec<_>>().join(\"/\"))"
    let v14 : string = v12 + v13
    let v15 : string = "   };"
    let v16 : string = v14 + v15
    let v17 : string = "   let uri = format!(\"https://{}\", uri);"
    let v18 : string = v16 + v17
    let v19 : string = "   let res = client"
    let v20 : string = v18 + v19
    let v21 : string = "     .get(uri)"
    let v22 : string = v20 + v21
    let v23 : string = "     .send()"
    let v24 : string = v22 + v23
    let v25 : string = "     .await"
    let v26 : string = v24 + v25
    let v27 : string = "     .map_err(|_| rocket::http::Status::NotFound)"
    let v28 : string = v26 + v27
    let v29 : string = "     .unwrap();"
    let v30 : string = v28 + v29
    let v31 : string = "   let content = res.text();"
    let v32 : string = v30 + v31
    let v33 : string = "   let content = content.await;"
    let v34 : string = v32 + v33
    let v35 : string = "   let content = content.map_err(|_| rocket::http::Status::InternalServerError);"
    let v36 : string = v34 + v35
    let v37 : string = "   let content = content.unwrap();"
    let v38 : string = v36 + v37
    let v39 : string = "   Ok(rocket::response::content::RawHtml(content))"
    let v40 : string = v38 + v39
    let v41 : string = "} ()"
    let v42 : string = v40 + v41
    Fable.Core.Rust.emitExpr () v42
    let v43 : string = "#[rocket::get(\"/file/<file..>\")]"
    let v44 : string = " async fn file(file: std::path::PathBuf, client: &rocket::State<reqwest::Client>) -> std::option::Option<rocket::fs::NamedFile> {"
    let v45 : string = v43 + v44
    let v46 : string = "   rocket::fs::NamedFile::open(std::path::Path::new(\"./\").join(file))"
    let v47 : string = v45 + v46
    let v48 : string = "     .await"
    let v49 : string = v47 + v48
    let v50 : string = "     .ok()"
    let v51 : string = v49 + v50
    let v52 : string = "} ()"
    let v53 : string = v51 + v52
    Fable.Core.Rust.emitExpr () v53
    let v54 : string = "#[rocket::launch]"
    let v55 : string = " fn rocket() -> _ {"
    let v56 : string = v54 + v55
    let v57 : string = "    rocket::build()"
    let v58 : string = v56 + v57
    let v59 : string = "      .manage(reqwest::Client::new())"
    let v60 : string = v58 + v59
    let v61 : string = "      .mount(\"/\", rocket::routes![proxy, file])"
    let v62 : string = v60 + v61
    let v63 : string = "} ()"
    let v64 : string = v62 + v63
    Fable.Core.Rust.emitExpr () v64
    ()
let v0 : (unit -> unit) = closure0()
()
