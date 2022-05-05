let rec method0 () : int32 =
    180
and closure0 () () : int32 =
    method0()
and closure1 () (v0 : string) : unit =
    AnsiConsole.WriteLine v0
and method2 () : (string -> unit) =
    closure1()
and method1 () : unit =
    AnsiConsole.WriteLine ()
    let v0 : (int32 -> Color) = Color.FromInt32
    let v1 : Color = v0 5
    let v2 : Style = Style v1
    let v3 : Rule = Rule "[white bold underline]Title 1[/]"
    let v4 : Rule = v3.LeftAligned ()
    let v5 : Rule = v4.RuleStyle v2
    AnsiConsole.Write v5
    let v6 : string = System.String ('w', 17)
    printfn $"%A{v6}"
    let v7 : (int32 []) = [|5|]
    printfn $"%A{v7}"
    let v8 : (string -> unit) = method2()
    v8 "end"
    let v9 : (int32 -> Color) = Color.FromInt32
    let v10 : Color = v9 5
    let v11 : Style = Style v10
    let v12 : Rule = Rule ()
    let v13 : Rule = v12.LeftAligned ()
    let v14 : Rule = v13.RuleStyle v11
    AnsiConsole.Write v14
let v0 : (unit -> int32) = closure0()
let v1 : string = $"main.spi Loaded. Width: {v0 ()}"
printfn $"%A{v1}"
#r "nuget: Spectre.Console"
open Spectre.Console
method1()
