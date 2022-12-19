namespace Types









    // [<Erase; Emit("Rc<$0>")>]
    // type Rc<'T> = class end

    // [<AutoOpen>]
    // module string =
    //     [<Erase; Emit("String")>]
    //     type String =
    //         [<Emit("String::from($0.as_str())")>]
    //         member _.from(s: string) : String = nativeOnly

    // [<AutoOpen>]
    // module vec =
    //     [<Erase; Emit("Vec<_>")>]
    //     type Vec<'T> =
    //         [<Emit("Vec::new()")>]
    //         static member new_() : Vec<'T> = nativeOnly



    //         [<Emit("std::io::Error::last_os_error()")>]
    //         static member last_os_error() : Error = nativeOnly

    //         [<Emit("$0.raw_os_error()")>]
    //         member _.raw_os_error() : int option = nativeOnly

    //     [<Erase; Emit("std::io::BufReader<_>")>]
    //     type BufReader<'T> =
    //         [<Emit("std::io::BufReader::new($0)")>]
    //         static member new_(inner: 'T) : BufReader<'T> = nativeOnly

    //         [<Emit("$0.lines().map(|res| res.map_err(|e| e.to_string()))")>]
    //         member _.lines() = nativeOnly

    // module fs =
    //     [<Struct>]
    //     [<Erase; Emit("std::fs::File")>]
    //     type File =
    //         [<Emit("std::fs::File::open($0.as_str()).map_err(|e| e.to_string())?")>]
    //         static member open_(path: string) = nativeOnly

    //     [<Emit("std::fs::read($0.as_str()).map_err(|e| e.to_string())")>]
    //     let read (path: string) : Result<Vec<byte>, String> = nativeOnly

    //     [<Emit("std::fs::read_to_string($0.as_str()).map_err(|e| e.to_string())")>]
    //     let read_to_string (path: string) : Result<String, String> = nativeOnly

        // [<Emit("std::path::Path::new($0.as_str())")>]
        // let new_ (path: string) : obj = nativeOnly

//     [<AutoOpen>]

//     [<AutoOpen>]
//     module Native =

//         [<Emit("$0.map_err(|e| e.to_string())")>]
//         let toStringError (s: Result<'T, io.Error>) : Result<'T, String> = nativeOnly

//         [<Emit("$0.lines().map(toString).collect()")>]
//         let allLines (s: String) : Vec<string> = nativeOnly

//         [<Import("String_::toString", "fable_library_rust")>]
//         let toString (v: String inref) : string = nativeOnly

//         [<Import("Native_::arrayFrom", "fable_library_rust")>]
//         let toArray (v: Vec<'T>) : 'T[] = nativeOnly

//         [<Import("Native_::iter_to_seq", "fable_library_rust")>]
//         let iter_to_seq (iter: obj) : 'T seq = nativeOnly

// // #else
// //     ()
// // #endif //FABLE_COMPILER_RUST










// #if FABLE_COMPILER_RUST

open Fable.Core
open Fable.Core.Rust

[<Erase; Emit("$0")>]
type EmitType<'T> = class end
[<Erase; Emit("dyn $0")>]
type Dyn<'T> = class end
[<Erase; Emit("mut $0")>]
type Mut<'T> = class end
[<Erase; Emit("&$0")>]
type Ref<'T> = class end
[<Erase; Emit("&'static $0")>]
type StaticRef<'T> = class end
[<Erase; Emit("str")>]
type Str = class end

module std =
    module io =
        [<Erase; Emit("std::io::Error")>]
        type Error = class end

    module iter =
        // [<Erase; Emit("&'static mut dyn std::iter::Iterator<Item = $0>")>]
        [<Erase; Emit("_")>]
        type Iterator<'T> = class end

    module path =
        [<Erase; Emit("std::path::Ancestors")>]
        type Ancestors = class end
        [<Erase; Emit("std::path::Path")>]
        type Path = class end
        [<Erase; Emit("std::path::StripPrefixError")>]
        type StripPrefixError = class end
        [<Erase; Emit("std::path::PathBuf")>]
        type PathBuf = class end

    module string =
        [<Erase; Emit("std::string::String")>]
        type String = class end

module chrono =
    [<Erase; Emit("chrono::Utc")>]
    type Utc = class end
    [<Erase; Emit("chrono::Local")>]
    type Local = class end
    [<Erase; Emit("chrono::DateTime<$0>")>]
    type DateTime<'T> = class end

module fable_library_rust =
    module Native_ =
        [<Erase; Emit("fable_library_rust::Native_::Box_<$0>")>]
        type Box<'T> = class end
        // [<Erase; Emit("fable_library_rust::Native_::Lrc<$0>")>]
        // type Lrc<'T> = class end
        // [<Erase; Emit("fable_library_rust::Native_::MutCell<$0>")>]
        // type MutCell<'T> = class end
