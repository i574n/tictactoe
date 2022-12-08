dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang typescript `
    --typedArrays false `
    --extension .tsx `
    --outDir "$PSScriptRoot/../lib_ts"
