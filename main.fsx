type [<Struct>] US0 =
    | US0_0
let rec method0 () : int32 =
    180
and closure0 () () : int32 =
    method0()
and method1 () : unit =
    let v0 : (int32 -> Color) = Color.FromInt32
    let v1 : Color = v0 5
    let v2 : Style = Style v1
    let v3 : Rule = Rule "[white bold underline]Title 1[/]"
    let v4 : Rule = v3.LeftAligned ()
    let v5 : Rule = v4.RuleStyle v2
    AnsiConsole.Write v5
    let v6 : string = System.String ('w', 17)
    printfn $"%A{v6}"
    let v7 : (int32 []) = [|6|]
    printfn $"%A{v7}"
    AnsiConsole.WriteLine ()
    AnsiConsole.WriteLine "end"
    let v8 : US0 = US0_0
    let v9 : (struct (int32 * int32 * int32 * US0) []) = [|struct (24, 12, 2022, v8)|]
    let v10 : US0 = US0_0
    let v11 : US0 = US0_0
    let v12 : (struct (int32 * int32 * int32 * US0) []) = [|struct (24, 12, 2022, v10); struct (24, 12, 2022, v11)|]
    let v13 : int32 = 0
    let v14 : int32 = 0
    let v15 : int32 = 26
    let v16 : int32 = 12
    let v17 : int32 = 2022
    printfn $"%A{struct (v13, v14, v15, v16, v17, v9, v12)}"
    AnsiConsole.WriteLine "jan      fe"
    AnsiConsole.WriteLine "29 30 31 01"
    AnsiConsole.WriteLine "su mo tu we"
    let v18 : (int32 -> Color) = Color.FromInt32
    let v19 : Color = v18 2
    AnsiConsole.Foreground <- v19
    AnsiConsole.WriteLine "░░ ▒▒ ▓▓ ██"
    AnsiConsole.ResetColors ()
    let v20 : (int32 -> Color) = Color.FromInt32
    let v21 : Color = v20 5
    let v22 : Style = Style v21
    let v23 : Rule = Rule ()
    let v24 : Rule = v23.LeftAligned ()
    let v25 : Rule = v24.RuleStyle v22
    AnsiConsole.Write v25
    AnsiConsole.WriteLine "de"
    AnsiConsole.WriteLine "26"
    AnsiConsole.WriteLine "xx"
    let v26 : (int32 -> Color) = Color.FromInt32
    let v27 : Color = v26 2
    AnsiConsole.Foreground <- v27
    AnsiConsole.WriteLine "██"
    AnsiConsole.ResetColors ()
    let v28 : (string []) = [|"de"; "26"; "xx"|]
    let v29 : (string []) = [|"██"|]
    printfn $"%A{struct (v28, v29)}"
    let v30 : (int32 -> Color) = Color.FromInt32
    let v31 : Color = v30 5
    let v32 : Style = Style v31
    let v33 : Rule = Rule ()
    let v34 : Rule = v33.LeftAligned ()
    let v35 : Rule = v34.RuleStyle v32
    AnsiConsole.Write v35
let v0 : (unit -> int32) = closure0()
let v1 : string = $"main.spi Loaded. Width: {v0 ()}"
printfn $"%A{v1}"
#r "nuget: Spectre.Console"
open Spectre.Console
method1()
