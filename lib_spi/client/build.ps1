dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot"

. "$PSScriptRoot/../cli/build.ps1"
. "$PSScriptRoot/../cli/target/release/cli" PostFsxRsBuild -- --rs-path="$PSScriptRoot/client.rs"

~/.cargo/bin/wasm-pack build --target web --dev "$PSScriptRoot"
