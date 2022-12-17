#![crate_name = "supervisor"]

mod supervisor;

#[derive(clap::Parser, Debug)]
struct Args {
    #[arg(short, long)]
    spi_path: String,

    #[arg(short, long)]
    fsx_path: String,
}

pub fn main() -> Result<(), Box<dyn std::error::Error>> {
    let args: Args = <Args as clap::Parser>::parse();
    let spi_to_fsx = supervisor::Supervisor::closure1;
    // let fsx = spi_to_fsx(
    //     std::rc::Rc::new(fable_library_rust::Native_::MutCell::new(Box::from(
    //         args.spi_path.to_path().strip_prefix("").unwrap(),
    //     ))),
    //     Some(std::rc::Rc::new(fable_library_rust::Native_::MutCell::new(
    //         Box::from(args.fsx_path.to_path().strip_prefix("").unwrap()),
    //     ))),
    // );
    let fsx = spi_to_fsx(
        std::path::PathBuf::from(&args.spi_path),
        Some(std::path::PathBuf::from(&args.fsx_path)),
    );
    println!("fsx.len(): {}", fsx.len());
    Ok(())
}
