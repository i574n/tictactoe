dotnet fable `
    "$PSScriptRoot/lib_fsx" `
    --optimize `
    --lang typescript `
    --typedArrays false `
    --extension .tsx `
    --outDir "$PSScriptRoot/lib_ts"
