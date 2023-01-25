dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot"

. "$PSScriptRoot/../cli/build.ps1"

cargo build --release --manifest-path "$PSScriptRoot/../cli/Cargo.toml"

. "$PSScriptRoot/../../target/release/cli" PostFsxRsBuild -- --rs-path="$PSScriptRoot/client.rs"

~/.cargo/bin/wasm-pack build --target web --dev "$PSScriptRoot"
