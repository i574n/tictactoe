let rec closure0 () () : unit =
    let v0 : string = "#[rocket::get(\"/<uri..>\")]"
    let v1 : string = " async fn proxy("
    let v2 : string = v0 + v1
    let v3 : string = "   uri: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,"
    let v4 : string = v2 + v3
    let v5 : string = "   client: &rocket::State<reqwest::Client>"
    let v6 : string = v4 + v5
    let v7 : string = " ) -> Result<rocket::response::content::RawHtml<String>, rocket::http::Status> {"
    let v8 : string = v6 + v7
    let v9 : string = "   let uri = uri.clone();"
    let v10 : string = v8 + v9
    let v11 : string = "   let uri = uri.collect::<Vec<_>>();"
    let v12 : string = v10 + v11
    let v13 : string = "   let uri = uri.join(\"/\");"
    let v14 : string = v12 + v13
    let v15 : string = "   let uri = uri.replace(\":/\", \"://\");"
    let v16 : string = v14 + v15
    let v17 : string = "   let (host_url, url) = uri.split_once('|').unwrap_or((\"\", &uri));"
    let v18 : string = v16 + v17
    let v19 : string = "   let (host_protocol, host_host) = host_url.split_once(\"://\").unwrap_or((\"https\", \"www.github.com\"));"
    let v20 : string = v18 + v19
    let v21 : string = "   let (protocol, suffix) = url.split_once(\"://\").unwrap_or((host_protocol, url));"
    let v22 : string = v20 + v21
    let v23 : string = "   let (host, path) = match (url.split_once(\"://\"), suffix.split_once(\"/\")) {"
    let v24 : string = v22 + v23
    let v25 : string = "     (Some(_), None) if suffix != \"\" => (suffix, \"\"),"
    let v26 : string = v24 + v25
    let v27 : string = "     _ => (host_host, suffix),"
    let v28 : string = v26 + v27
    let v29 : string = "   };"
    let v30 : string = v28 + v29
    let v31 : string = "   let new_url = match path {"
    let v32 : string = v30 + v31
    let v33 : string = "     \"\" => format!(\"{protocol}://{host}\"),"
    let v34 : string = v32 + v33
    let v35 : string = "     _ => format!(\"{protocol}://{host}/{path}\"),"
    let v36 : string = v34 + v35
    let v37 : string = "   };"
    let v38 : string = v36 + v37
    let v39 : string = "   println!(\"uri={uri}; new_url={new_url}; host={host}; path={path}; suffix={suffix}; host_url={host_url}; url={url}; host_host={host_host}; host_protocol={host_protocol}; protocol={protocol}\");"
    let v40 : string = v38 + v39
    let v41 : string = "   let res = client"
    let v42 : string = v40 + v41
    let v43 : string = "     .get(new_url)"
    let v44 : string = v42 + v43
    let v45 : string = "     .send()"
    let v46 : string = v44 + v45
    let v47 : string = "     .await"
    let v48 : string = v46 + v47
    let v49 : string = "     .map_err(|_| rocket::http::Status::NotFound);"
    let v50 : string = v48 + v49
    let v51 : string = "   match res {"
    let v52 : string = v50 + v51
    let v53 : string = "       Ok(res) => {"
    let v54 : string = v52 + v53
    let v55 : string = "           let content = res.text();"
    let v56 : string = v54 + v55
    let v57 : string = "           let content = content.await;"
    let v58 : string = v56 + v57
    let v59 : string = "           let content = content.map_err(|_| rocket::http::Status::InternalServerError);"
    let v60 : string = v58 + v59
    let v61 : string = "           let content = content.unwrap();"
    let v62 : string = v60 + v61
    let v63 : string = "           Ok(rocket::response::content::RawHtml(content))"
    let v64 : string = v62 + v63
    let v65 : string = "       }"
    let v66 : string = v64 + v65
    let v67 : string = "       Err(status) => Err(status),"
    let v68 : string = v66 + v67
    let v69 : string = "   }"
    let v70 : string = v68 + v69
    let v71 : string = "} ()"
    let v72 : string = v70 + v71
    Fable.Core.Rust.emitExpr () v72
    let v73 : string = "#[rocket::get(\"/file/<file..>\")]"
    let v74 : string = " async fn file("
    let v75 : string = v73 + v74
    let v76 : string = "   file: std::path::PathBuf,"
    let v77 : string = v75 + v76
    let v78 : string = "   client: &rocket::State<reqwest::Client>"
    let v79 : string = v77 + v78
    let v80 : string = " ) -> std::option::Option<rocket::fs::NamedFile> {"
    let v81 : string = v79 + v80
    let v82 : string = "   rocket::fs::NamedFile::open(std::path::Path::new(\"./\").join(file))"
    let v83 : string = v81 + v82
    let v84 : string = "     .await"
    let v85 : string = v83 + v84
    let v86 : string = "     .ok()"
    let v87 : string = v85 + v86
    let v88 : string = "} ()"
    let v89 : string = v87 + v88
    Fable.Core.Rust.emitExpr () v89
    let v90 : string = "#[rocket::launch]"
    let v91 : string = " fn rocket() -> _ {"
    let v92 : string = v90 + v91
    let v93 : string = "    rocket::build()"
    let v94 : string = v92 + v93
    let v95 : string = "      .manage(reqwest::Client::new())"
    let v96 : string = v94 + v95
    let v97 : string = "      .mount(\"/\", rocket::routes![proxy, file])"
    let v98 : string = v96 + v97
    let v99 : string = "} ()"
    let v100 : string = v98 + v99
    Fable.Core.Rust.emitExpr () v100
    ()
let v0 : (unit -> unit) = closure0()
()
