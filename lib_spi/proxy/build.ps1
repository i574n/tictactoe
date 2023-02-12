dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot"

. "$PSScriptRoot/../cli/build.ps1"
. "$PSScriptRoot/../../target/release/cli" PostFsxRsBuild -- --rs-path="$PSScriptRoot/proxy.rs"

cargo fmt

cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"
