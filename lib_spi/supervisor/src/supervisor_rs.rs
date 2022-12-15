fn zmq_request(msg: String) {
    let ctx = zmq::Context::new();
    let sock = ctx.socket(zmq::REQ).unwrap();
    let port = 13805;
    let endpoint = &format!("tcp://localhost:{}", port);
    sock.connect(endpoint).unwrap();
    sock.send(&msg, 0).unwrap();
    let result = sock.recv_string(0).unwrap();
    println!("zmq_request. result: {}", result.unwrap());
    sock.disconnect(endpoint).unwrap();
}

fn spiproj_open(spiproj_path: &std::path::Path, spiproj_text: &str) {
    let msg = serde_json::json!({
        "ProjectFileOpen": {
            "uri": spiproj_path,
            "spiprojText": spiproj_text,
        }
    })
    .to_string();
    zmq_request(msg);
}

fn spi_build_file(spi_path: &std::path::Path, backend: &str) {
    let msg = serde_json::json!({
        "BuildFile": {
            "uri": spi_path,
            "backend": backend,
        }
    })
    .to_string();
    zmq_request(msg);
}

fn wait_file_change(fsx_path: &std::path::Path) -> String {
    let lines: String;
    let get_last_modified = || std::fs::metadata(fsx_path).unwrap().modified().unwrap();
    let start = get_last_modified();
    println!("waiting for file change. start: {:?}", start);

    let mut last_modified: std::time::SystemTime;
    loop {
        last_modified = get_last_modified();
        if last_modified > start {
            lines = std::fs::read_to_string(fsx_path).unwrap();
            break;
        } else {
            std::thread::sleep(std::time::Duration::from_millis(100));
        }
    }

    println!(
        "waiting for file change. last_modified: {:?} lines.len(): {}",
        last_modified,
        lines.len()
    );

    lines
}

trait ToPath {
    fn to_path<'a>(&'a self) -> &'a std::path::Path
    where
        Self: AsRef<std::ffi::OsStr>,
    {
        std::path::Path::new(self)
    }
}

impl ToPath for String {}

fn spi_to_fsx(spi_path: &std::path::Path, new_fsx_path: Option<&std::path::Path>) -> String {
    let spi_path = spi_path.canonicalize().expect(
        format!(
            "spi_path: {} not found. pwd: {}",
            spi_path.display(),
            std::env::current_dir().unwrap().display()
        )
        .as_str(),
    );

    let src_path = spi_path.parent().unwrap().canonicalize().unwrap();

    println!("src_path: {}", src_path.display());

    let spiproj_path = src_path
        .ancestors()
        .take(10)
        .map(|p| p.join("package.spiproj"))
        .find(|p| p.exists())
        .unwrap();
    println!("spiproj_path: {}", spiproj_path.display());

    let fsx_path = spi_path
        .to_str()
        .unwrap()
        .replace(".spir", ".spi")
        .replace(".spi", ".fsx")
        .to_path()
        .canonicalize()
        .unwrap();

    println!("fsx_path: {}", fsx_path.clone().display());

    std::fs::write(fsx_path.clone(), "").unwrap();
    println!("write ok. fsx_path: {}", fsx_path.display());

    spiproj_open(
        &spiproj_path,
        &std::fs::read_to_string(&spiproj_path).unwrap(),
    );
    println!("open ok. spiproj_path: {}", spiproj_path.display());

    spi_build_file(&spi_path, "Fsharp");
    println!("build ok. spi_path: {}", spi_path.display());

    let lines = wait_file_change(&fsx_path);
    println!("lines.len(): {}", lines.len());

    let new_fsx = lines;

    std::fs::write(new_fsx_path.unwrap_or(&fsx_path), new_fsx.clone()).unwrap();
    println!(
        "write ok. new_fsx_path={} fsx_path={} new_fsx.len()={}",
        new_fsx_path.unwrap().display(),
        fsx_path.display(),
        new_fsx.len()
    );

    new_fsx
}

#[derive(clap::Parser, Debug)]
struct Args {
    #[arg(short, long)]
    spi_path: String,

    #[arg(short, long)]
    fsx_path: String,
}

pub fn main() -> Result<(), Box<dyn std::error::Error>> {
    let args: Args = <Args as clap::Parser>::parse();
    let fsx = spi_to_fsx(args.spi_path.to_path(), Some(args.fsx_path.to_path()));
    println!("fsx.len(): {}", fsx.len());

    Ok(())
}
