dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot"

cargo fmt

cargo build --release --manifest-path "$PSScriptRoot/../cli/Cargo.toml"

. "$PSScriptRoot/../../target/release/cli" PostFsxRsBuild -- --rs-path="$PSScriptRoot/cli.rs"
