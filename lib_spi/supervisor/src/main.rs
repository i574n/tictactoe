#![crate_name = "supervisor"]

mod supervisor;

trait ToPath {
    fn to_path<'a>(&'a self) -> &'a std::path::Path
    where
        Self: AsRef<std::ffi::OsStr>,
    {
        std::path::Path::new(self)
    }
}

impl ToPath for String {}

#[derive(clap::Parser, Debug)]
struct Args {
    #[arg(short, long)]
    spi_path: String,

    #[arg(short, long)]
    fsx_path: String,
}

pub fn main() -> Result<(), Box<dyn std::error::Error>> {
    let args: Args = <Args as clap::Parser>::parse();
    let spi_to_fsx = supervisor::Supervisor::closure2;
    let fsx = spi_to_fsx(
        std::rc::Rc::new(fable_library_rust::Native_::MutCell::new(Box::from(
            args.spi_path.to_path().strip_prefix("").unwrap(),
        ))),
        Some(std::rc::Rc::new(fable_library_rust::Native_::MutCell::new(
            Box::from(args.fsx_path.to_path().strip_prefix("").unwrap()),
        ))),
    );
    println!("fsx.len(): {}", fsx.len());
    Ok(())
}
