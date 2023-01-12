mod lib_spi;

use lib_spi::supervisor;
use lib_spi::cli;
use lib_spi::client;

/// ???
fn main() {
    supervisor::main::main();
    cli::main::main();
    client::lib::client();
}
