dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot"

cargo fmt

cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"
