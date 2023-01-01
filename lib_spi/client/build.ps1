dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot/src"

~/.cargo/bin/wasm-pack build --target web --dev "$PSScriptRoot"
