import { Union, Record } from "../fable_modules/fable-library-ts/Types.js";
import { enum_type, uint64_type, getUnionFields, int64_type, tuple_type, lambda_type, unit_type, class_type, bool_type, array_type, string_type, int32_type, union_type, record_type, obj_type, TypeInfo } from "../fable_modules/fable-library-ts/Reflection.js";
import { uint8, op_UnaryNegation_Int32, int32 } from "../fable_modules/fable-library-ts/Int32.js";
import { defaultOf, equals, equalArrays, int32ToString, partialApply, uncurry, createObj, IDisposable } from "../fable_modules/fable-library-ts/Util.js";
import { fromInteger, uint64, fromBits, op_Addition, compare, parse, op_Subtraction, toString, int64 } from "../fable_modules/fable-library-ts/Long.js";
import { Index, For, onCleanup, createEffect, useContext, createSignal, createComponent, children as children_1, createContext } from "solid-js";
import { choose, addRangeInPlace, equalsWith, fill } from "../fable_modules/fable-library-ts/Array.js";
import { Input, Anchor, Stack, IconButton, Icon, Button, Box, hope } from "@hope-ui/core";
import { utcNow, getTicks } from "../fable_modules/fable-library-ts/Date.js";
import { BiRegularMinus, BiRegularPlus, BiRegularLinkExternal, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh } from "solid-icons/bi";
import { nonSeeded } from "../fable_modules/fable-library-ts/Random.js";
import { HubConnection$5, HubConnection$5__startNow, HubConnection$5__streamFromAsPromise_2B594, HubConnection$5__invokeAsPromise_2B595 } from "../deps/Fable.SignalR/HubConnection.tsx";
import { parse as parse_1, newGuid } from "../fable_modules/fable-library-ts/Guid.js";
import { get_UTF8 } from "../fable_modules/fable-library-ts/Encoding.js";
import { debounce } from "@solid-primitives/scheduled";
import { RetryPolicy } from "../deps/Fable.SignalR/Types.tsx";
import { HubConnectionBuilder$5, HubConnectionBuilder$5__withUrl_Z721C83C5, HubConnectionBuilder$5__withAutomaticReconnect_3C7EFEAD, HubConnectionBuilder$5__onReconnecting_Z5D4DDAB0, HubConnectionBuilder$5__onReconnected_20659392, HubConnectionBuilder$5__onClose_Z5D4DDAB0, HubConnectionBuilder$5__configureLogging_2D37BB17, HubConnectionBuilder$5__onMessage_2163CAFC } from "../deps/Fable.SignalR/SignalR.tsx";
import { some, map, value as value_10, Option } from "../fable_modules/fable-library-ts/Option.js";
import { Node as Node$ } from "rusty-gun";
import { HubConnectionBuilder$5_$ctor_Z66CB2AA1 } from "../deps/Fable.SignalR/SignalR.tsx";
import { HubConnection$5_$ctor_Z78FDE58B, Bindings_signalR } from "../deps/Fable.SignalR/HubConnection.tsx";
import { Json_TextMessageFormat_write, Json_TextMessageFormat_parse, Json_JsonProtocol_$ctor, MsgPack_parseMsg, MsgPack_MsgPackProtocol_$ctor } from "../deps/Fable.SignalR/Protocols.tsx";
import { singleton, reverse, cons, empty, FSharpList } from "../fable_modules/fable-library-ts/List.js";
import { toFail, printf, toText } from "../fable_modules/fable-library-ts/String.js";
import { Reader__Read_24524716, Reader_$ctor_Z3F6BC7B1 } from "../fable_modules/Fable.Remoting.MsgPack.1.18.0/Read.fs.js";
import { Reader } from "../fable_modules/Fable.Remoting.MsgPack.1.18.0/Read.fs.js";
import { InvokeArg$1$reflection, InvokeArg$1, MsgPack_Msg$4_Close, MsgPack_Msg$4_Ping, MsgPack_Msg$4_CancelInvocation, MsgPack_Msg$4_StreamInvocation, MsgPack_Msg$4_Completion, MsgPack_Msg$4_StreamItem, MsgPack_Msg$4_Invocation, MsgPack_Msg$4_InvocationExplicit, MsgPack_Msg$4_InvokeInvocation, MsgPack_Msg$4$reflection } from "../deps/Fable.SignalR/Shared.tsx";
import { writeObject } from "../fable_modules/Fable.Remoting.MsgPack.1.18.0/Write.fs.js";
import { SimpleJson_readPath, SimpleJson_parse } from "../fable_modules/Fable.SimpleJson.3.24.0/SimpleJson.fs.js";
import { Json } from "../fable_modules/Fable.SimpleJson.3.24.0/Json.fs.js";
import { Result_Map, FSharpResult$2_Tag, FSharpResult$2_Ok, FSharpResult$2_Error, FSharpResult$2 } from "../fable_modules/fable-library-ts/Choice.js";
import { Convert_serialize, Convert_fromJson } from "../fable_modules/Fable.SimpleJson.3.24.0/Json.Converter.fs.js";
import { createTypeInfo } from "../fable_modules/Fable.SimpleJson.3.24.0/TypeInfo.Converter.fs.js";
import { Json_JsonProtocol, MsgPack_MsgPackProtocol, HubRecords_CloseMessage$reflection, HubRecords_CloseMessage, HubRecords_PingMessage$reflection, HubRecords_PingMessage, HubRecords_CancelInvocationMessage$reflection, HubRecords_CancelInvocationMessage, HubRecords_StreamInvocationMessage$1$reflection, HubRecords_StreamInvocationMessage$1, HubRecords_CompletionMessage$1$reflection, HubRecords_CompletionMessage$1, HubRecords_StreamItemMessage$1$reflection, HubRecords_StreamItemMessage$1, HubRecords_InvocationMessage$1$reflection, HubRecords_InvocationMessage$1 } from "../deps/Fable.SignalR/Protocols.tsx";
import gun from "gun/gun";
import "gun/lib/radix";
import "gun/lib/radisk";
import "gun/lib/store";
import "gun/lib/rindexed";

export class Mut0 extends Record {
    l0: any;
    constructor(l0: any) {
        super();
        this.l0 = l0;
    }
}

export function Mut0$reflection(): TypeInfo {
    return record_type("Components\'.Mut0", [], Mut0, () => [["l0", obj_type]]);
}

export const enum US1_Tag {
    US1_0 = 0,
    US1_1 = 1
}

export type US1_Fields = [[], []];

export type US1 = US1_Cons<US1_Tag.US1_0> | US1_Cons<US1_Tag.US1_1>;

export function US1_US1_0() {
    return new US1_Cons<US1_Tag.US1_0>(US1_Tag.US1_0, []);
}

export function US1_US1_1() {
    return new US1_Cons<US1_Tag.US1_1>(US1_Tag.US1_1, []);
}

export class US1_Cons<Tag extends keyof US1_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US1_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US1_0", "US1_1"];
    }
}

export function US1$reflection(): TypeInfo {
    return union_type("Components\'.US1", [], US1_Cons, () => [[], []]);
}

export const enum US0_Tag {
    US0_0 = 0,
    US0_1 = 1
}

export type US0_Fields = [[], [US1]];

export type US0 = US0_Cons<US0_Tag.US0_0> | US0_Cons<US0_Tag.US0_1>;

export function US0_US0_0() {
    return new US0_Cons<US0_Tag.US0_0>(US0_Tag.US0_0, []);
}

export function US0_US0_1(f1_0: US1) {
    return new US0_Cons<US0_Tag.US0_1>(US0_Tag.US0_1, [f1_0]);
}

export class US0_Cons<Tag extends keyof US0_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US0_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1"];
    }
}

export function US0$reflection(): TypeInfo {
    return union_type("Components\'.US0", [], US0_Cons, () => [[], [["f1_0", US1$reflection()]]]);
}

export const enum US2_Tag {
    US2_0 = 0,
    US2_1 = 1,
    US2_2 = 2,
    US2_3 = 3
}

export type US2_Fields = [[], [], [], []];

export type US2 = US2_Cons<US2_Tag.US2_0> | US2_Cons<US2_Tag.US2_1> | US2_Cons<US2_Tag.US2_2> | US2_Cons<US2_Tag.US2_3>;

export function US2_US2_0() {
    return new US2_Cons<US2_Tag.US2_0>(US2_Tag.US2_0, []);
}

export function US2_US2_1() {
    return new US2_Cons<US2_Tag.US2_1>(US2_Tag.US2_1, []);
}

export function US2_US2_2() {
    return new US2_Cons<US2_Tag.US2_2>(US2_Tag.US2_2, []);
}

export function US2_US2_3() {
    return new US2_Cons<US2_Tag.US2_3>(US2_Tag.US2_3, []);
}

export class US2_Cons<Tag extends keyof US2_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US2_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1", "US2_2", "US2_3"];
    }
}

export function US2$reflection(): TypeInfo {
    return union_type("Components\'.US2", [], US2_Cons, () => [[], [], [], []]);
}

export const enum US3_Tag {
    US3_0 = 0,
    US3_1 = 1,
    US3_2 = 2
}

export type US3_Fields = [[], [], []];

export type US3 = US3_Cons<US3_Tag.US3_0> | US3_Cons<US3_Tag.US3_1> | US3_Cons<US3_Tag.US3_2>;

export function US3_US3_0() {
    return new US3_Cons<US3_Tag.US3_0>(US3_Tag.US3_0, []);
}

export function US3_US3_1() {
    return new US3_Cons<US3_Tag.US3_1>(US3_Tag.US3_1, []);
}

export function US3_US3_2() {
    return new US3_Cons<US3_Tag.US3_2>(US3_Tag.US3_2, []);
}

export class US3_Cons<Tag extends keyof US3_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US3_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1", "US3_2"];
    }
}

export function US3$reflection(): TypeInfo {
    return union_type("Components\'.US3", [], US3_Cons, () => [[], [], []]);
}

export const enum US4_Tag {
    US4_0 = 0,
    US4_1 = 1,
    US4_2 = 2,
    US4_3 = 3,
    US4_4 = 4
}

export type US4_Fields = [[], [], [], [], []];

export type US4 = US4_Cons<US4_Tag.US4_0> | US4_Cons<US4_Tag.US4_1> | US4_Cons<US4_Tag.US4_2> | US4_Cons<US4_Tag.US4_3> | US4_Cons<US4_Tag.US4_4>;

export function US4_US4_0() {
    return new US4_Cons<US4_Tag.US4_0>(US4_Tag.US4_0, []);
}

export function US4_US4_1() {
    return new US4_Cons<US4_Tag.US4_1>(US4_Tag.US4_1, []);
}

export function US4_US4_2() {
    return new US4_Cons<US4_Tag.US4_2>(US4_Tag.US4_2, []);
}

export function US4_US4_3() {
    return new US4_Cons<US4_Tag.US4_3>(US4_Tag.US4_3, []);
}

export function US4_US4_4() {
    return new US4_Cons<US4_Tag.US4_4>(US4_Tag.US4_4, []);
}

export class US4_Cons<Tag extends keyof US4_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US4_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"];
    }
}

export function US4$reflection(): TypeInfo {
    return union_type("Components\'.US4", [], US4_Cons, () => [[], [], [], [], []]);
}

export const enum US5_Tag {
    US5_0 = 0,
    US5_1 = 1
}

export type US5_Fields = [[], [int32]];

export type US5 = US5_Cons<US5_Tag.US5_0> | US5_Cons<US5_Tag.US5_1>;

export function US5_US5_0() {
    return new US5_Cons<US5_Tag.US5_0>(US5_Tag.US5_0, []);
}

export function US5_US5_1(f1_0: int32) {
    return new US5_Cons<US5_Tag.US5_1>(US5_Tag.US5_1, [f1_0]);
}

export class US5_Cons<Tag extends keyof US5_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US5_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US5_0", "US5_1"];
    }
}

export function US5$reflection(): TypeInfo {
    return union_type("Components\'.US5", [], US5_Cons, () => [[], [["f1_0", int32_type]]]);
}

export const enum UH0_Tag {
    UH0_0 = 0,
    UH0_1 = 1,
    UH0_2 = 2,
    UH0_3 = 3
}

export type UH0_Fields = [[string], [string, string], [string, string], [string, string, string]];

export type UH0 = UH0_Cons<UH0_Tag.UH0_0> | UH0_Cons<UH0_Tag.UH0_1> | UH0_Cons<UH0_Tag.UH0_2> | UH0_Cons<UH0_Tag.UH0_3>;

export function UH0_UH0_0(Item: string) {
    return new UH0_Cons<UH0_Tag.UH0_0>(UH0_Tag.UH0_0, [Item]);
}

export function UH0_UH0_1(Item1: string, Item2: string) {
    return new UH0_Cons<UH0_Tag.UH0_1>(UH0_Tag.UH0_1, [Item1, Item2]);
}

export function UH0_UH0_2(Item1: string, Item2: string) {
    return new UH0_Cons<UH0_Tag.UH0_2>(UH0_Tag.UH0_2, [Item1, Item2]);
}

export function UH0_UH0_3(Item1: string, Item2: string, Item3: string) {
    return new UH0_Cons<UH0_Tag.UH0_3>(UH0_Tag.UH0_3, [Item1, Item2, Item3]);
}

export class UH0_Cons<Tag extends keyof UH0_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: UH0_Fields[Tag]) {
        super();
    }
    cases() {
        return ["UH0_0", "UH0_1", "UH0_2", "UH0_3"];
    }
}

export function UH0$reflection(): TypeInfo {
    return union_type("Components\'.UH0", [], UH0_Cons, () => [[["Item", string_type]], [["Item1", string_type], ["Item2", string_type]], [["Item1", string_type], ["Item2", string_type]], [["Item1", string_type], ["Item2", string_type], ["Item3", string_type]]]);
}

export const enum US6_Tag {
    US6_0 = 0,
    US6_1 = 1
}

export type US6_Fields = [[], [string]];

export type US6 = US6_Cons<US6_Tag.US6_0> | US6_Cons<US6_Tag.US6_1>;

export function US6_US6_0() {
    return new US6_Cons<US6_Tag.US6_0>(US6_Tag.US6_0, []);
}

export function US6_US6_1(f1_0: string) {
    return new US6_Cons<US6_Tag.US6_1>(US6_Tag.US6_1, [f1_0]);
}

export class US6_Cons<Tag extends keyof US6_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US6_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US6_0", "US6_1"];
    }
}

export function US6$reflection(): TypeInfo {
    return union_type("Components\'.US6", [], US6_Cons, () => [[], [["f1_0", string_type]]]);
}

export const enum UH1_Tag {
    UH1_0 = 0,
    UH1_1 = 1,
    UH1_2 = 2,
    UH1_3 = 3,
    UH1_4 = 4,
    UH1_5 = 5
}

export type UH1_Fields = [[], [US6], [string, string, US6], [string[]], [string, string, string[], string[]], [boolean]];

export type UH1 = UH1_Cons<UH1_Tag.UH1_0> | UH1_Cons<UH1_Tag.UH1_1> | UH1_Cons<UH1_Tag.UH1_2> | UH1_Cons<UH1_Tag.UH1_3> | UH1_Cons<UH1_Tag.UH1_4> | UH1_Cons<UH1_Tag.UH1_5>;

export function UH1_UH1_0() {
    return new UH1_Cons<UH1_Tag.UH1_0>(UH1_Tag.UH1_0, []);
}

export function UH1_UH1_1(Item: US6) {
    return new UH1_Cons<UH1_Tag.UH1_1>(UH1_Tag.UH1_1, [Item]);
}

export function UH1_UH1_2(Item1: string, Item2: string, Item3: US6) {
    return new UH1_Cons<UH1_Tag.UH1_2>(UH1_Tag.UH1_2, [Item1, Item2, Item3]);
}

export function UH1_UH1_3(Item: string[]) {
    return new UH1_Cons<UH1_Tag.UH1_3>(UH1_Tag.UH1_3, [Item]);
}

export function UH1_UH1_4(Item1: string, Item2: string, Item3: string[], Item4: string[]) {
    return new UH1_Cons<UH1_Tag.UH1_4>(UH1_Tag.UH1_4, [Item1, Item2, Item3, Item4]);
}

export function UH1_UH1_5(Item: boolean) {
    return new UH1_Cons<UH1_Tag.UH1_5>(UH1_Tag.UH1_5, [Item]);
}

export class UH1_Cons<Tag extends keyof UH1_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: UH1_Fields[Tag]) {
        super();
    }
    cases() {
        return ["UH1_0", "UH1_1", "UH1_2", "UH1_3", "UH1_4", "UH1_5"];
    }
}

export function UH1$reflection(): TypeInfo {
    return union_type("Components\'.UH1", [], UH1_Cons, () => [[], [["Item", US6$reflection()]], [["Item1", string_type], ["Item2", string_type], ["Item3", US6$reflection()]], [["Item", array_type(string_type)]], [["Item1", string_type], ["Item2", string_type], ["Item3", array_type(string_type)], ["Item4", array_type(string_type)]], [["Item", bool_type]]]);
}

export const enum US7_Tag {
    US7_0 = 0,
    US7_1 = 1
}

export type US7_Fields = [[], [any]];

export type US7 = US7_Cons<US7_Tag.US7_0> | US7_Cons<US7_Tag.US7_1>;

export function US7_US7_0() {
    return new US7_Cons<US7_Tag.US7_0>(US7_Tag.US7_0, []);
}

export function US7_US7_1(f1_0: any) {
    return new US7_Cons<US7_Tag.US7_1>(US7_Tag.US7_1, [f1_0]);
}

export class US7_Cons<Tag extends keyof US7_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US7_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US7_0", "US7_1"];
    }
}

export function US7$reflection(): TypeInfo {
    return union_type("Components\'.US7", [], US7_Cons, () => [[], [["f1_0", class_type("Fable.Core.JS.Function")]]]);
}

export const enum US8_Tag {
    US8_0 = 0,
    US8_1 = 1
}

export type US8_Fields = [[], [boolean]];

export type US8 = US8_Cons<US8_Tag.US8_0> | US8_Cons<US8_Tag.US8_1>;

export function US8_US8_0() {
    return new US8_Cons<US8_Tag.US8_0>(US8_Tag.US8_0, []);
}

export function US8_US8_1(f1_0: boolean) {
    return new US8_Cons<US8_Tag.US8_1>(US8_Tag.US8_1, [f1_0]);
}

export class US8_Cons<Tag extends keyof US8_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US8_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US8_0", "US8_1"];
    }
}

export function US8$reflection(): TypeInfo {
    return union_type("Components\'.US8", [], US8_Cons, () => [[], [["f1_0", bool_type]]]);
}

export const enum US9_Tag {
    US9_0 = 0,
    US9_1 = 1
}

export type US9_Fields = [[], [() => any[]]];

export type US9 = US9_Cons<US9_Tag.US9_0> | US9_Cons<US9_Tag.US9_1>;

export function US9_US9_0() {
    return new US9_Cons<US9_Tag.US9_0>(US9_Tag.US9_0, []);
}

export function US9_US9_1(f1_0: () => any[]) {
    return new US9_Cons<US9_Tag.US9_1>(US9_Tag.US9_1, [f1_0]);
}

export class US9_Cons<Tag extends keyof US9_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US9_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US9_0", "US9_1"];
    }
}

export function US9$reflection(): TypeInfo {
    return union_type("Components\'.US9", [], US9_Cons, () => [[], [["f1_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]]]);
}

export const enum US10_Tag {
    US10_0 = 0,
    US10_1 = 1
}

export type US10_Fields = [[], [any[]]];

export type US10 = US10_Cons<US10_Tag.US10_0> | US10_Cons<US10_Tag.US10_1>;

export function US10_US10_0() {
    return new US10_Cons<US10_Tag.US10_0>(US10_Tag.US10_0, []);
}

export function US10_US10_1(f1_0: any[]) {
    return new US10_Cons<US10_Tag.US10_1>(US10_Tag.US10_1, [f1_0]);
}

export class US10_Cons<Tag extends keyof US10_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US10_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US10_0", "US10_1"];
    }
}

export function US10$reflection(): TypeInfo {
    return union_type("Components\'.US10", [], US10_Cons, () => [[], [["f1_0", array_type(obj_type)]]]);
}

export const enum US11_Tag {
    US11_0 = 0,
    US11_1 = 1
}

export type US11_Fields = [[], [any]];

export type US11 = US11_Cons<US11_Tag.US11_0> | US11_Cons<US11_Tag.US11_1>;

export function US11_US11_0() {
    return new US11_Cons<US11_Tag.US11_0>(US11_Tag.US11_0, []);
}

export function US11_US11_1(f1_0: any) {
    return new US11_Cons<US11_Tag.US11_1>(US11_Tag.US11_1, [f1_0]);
}

export class US11_Cons<Tag extends keyof US11_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US11_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US11_0", "US11_1"];
    }
}

export function US11$reflection(): TypeInfo {
    return union_type("Components\'.US11", [], US11_Cons, () => [[], [["f1_0", class_type("Fable.Core.JSX.Element")]]]);
}

export const enum US12_Tag {
    US12_0 = 0,
    US12_1 = 1
}

export type US12_Fields = [[], [(arg0: any) => void]];

export type US12 = US12_Cons<US12_Tag.US12_0> | US12_Cons<US12_Tag.US12_1>;

export function US12_US12_0() {
    return new US12_Cons<US12_Tag.US12_0>(US12_Tag.US12_0, []);
}

export function US12_US12_1(f1_0: (arg0: any) => void) {
    return new US12_Cons<US12_Tag.US12_1>(US12_Tag.US12_1, [f1_0]);
}

export class US12_Cons<Tag extends keyof US12_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US12_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US12_0", "US12_1"];
    }
}

export function US12$reflection(): TypeInfo {
    return union_type("Components\'.US12", [], US12_Cons, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
}

export const enum US13_Tag {
    US13_0 = 0,
    US13_1 = 1
}

export type US13_Fields = [[], [() => void]];

export type US13 = US13_Cons<US13_Tag.US13_0> | US13_Cons<US13_Tag.US13_1>;

export function US13_US13_0() {
    return new US13_Cons<US13_Tag.US13_0>(US13_Tag.US13_0, []);
}

export function US13_US13_1(f1_0: () => void) {
    return new US13_Cons<US13_Tag.US13_1>(US13_Tag.US13_1, [f1_0]);
}

export class US13_Cons<Tag extends keyof US13_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US13_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US13_0", "US13_1"];
    }
}

export function US13$reflection(): TypeInfo {
    return union_type("Components\'.US13", [], US13_Cons, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
}

export const enum US14_Tag {
    US14_0 = 0,
    US14_1 = 1
}

export type US14_Fields = [[], [any]];

export type US14 = US14_Cons<US14_Tag.US14_0> | US14_Cons<US14_Tag.US14_1>;

export function US14_US14_0() {
    return new US14_Cons<US14_Tag.US14_0>(US14_Tag.US14_0, []);
}

export function US14_US14_1(f1_0: any) {
    return new US14_Cons<US14_Tag.US14_1>(US14_Tag.US14_1, [f1_0]);
}

export class US14_Cons<Tag extends keyof US14_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US14_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US14_0", "US14_1"];
    }
}

export function US14$reflection(): TypeInfo {
    return union_type("Components\'.US14", [], US14_Cons, () => [[], [["f1_0", obj_type]]]);
}

export class Mut1 extends Record {
    l0: US6;
    l1: US6;
    l2: US6;
    l3: US7;
    l4: US6;
    l5: US6;
    l6: US6;
    l7: US6;
    l8: US6;
    l9: US6;
    l10: US8;
    l11: US9;
    l12: US6;
    l13: US6;
    l14: US8;
    l15: US6;
    l16: US6;
    l17: US6;
    l18: US10;
    l19: US8;
    l20: US6;
    l21: US6;
    l22: US6;
    l23: US6;
    l24: US6;
    l25: US6;
    l26: US11;
    l27: US6;
    l28: US6;
    l29: US6;
    l30: US11;
    l31: US6;
    l32: US6;
    l33: US6;
    l34: US6;
    l35: US6;
    l36: US6;
    l37: US6;
    l38: US6;
    l39: US6;
    l40: US6;
    l41: US12;
    l42: US13;
    l43: US12;
    l44: US6;
    l45: US6;
    l46: US6;
    l47: US6;
    l48: US6;
    l49: US6;
    l50: US6;
    l51: US6;
    l52: US6;
    l53: US6;
    l54: US6;
    l55: US6;
    l56: US6;
    l57: US6;
    l58: US6;
    l59: US6;
    l60: US14;
    l61: US6;
    l62: US11;
    l63: US6;
    l64: US6;
    l65: US14;
    l66: US14;
    l67: US6;
    l68: US5;
    l69: US6;
    constructor(l0: US6, l1: US6, l2: US6, l3: US7, l4: US6, l5: US6, l6: US6, l7: US6, l8: US6, l9: US6, l10: US8, l11: US9, l12: US6, l13: US6, l14: US8, l15: US6, l16: US6, l17: US6, l18: US10, l19: US8, l20: US6, l21: US6, l22: US6, l23: US6, l24: US6, l25: US6, l26: US11, l27: US6, l28: US6, l29: US6, l30: US11, l31: US6, l32: US6, l33: US6, l34: US6, l35: US6, l36: US6, l37: US6, l38: US6, l39: US6, l40: US6, l41: US12, l42: US13, l43: US12, l44: US6, l45: US6, l46: US6, l47: US6, l48: US6, l49: US6, l50: US6, l51: US6, l52: US6, l53: US6, l54: US6, l55: US6, l56: US6, l57: US6, l58: US6, l59: US6, l60: US14, l61: US6, l62: US11, l63: US6, l64: US6, l65: US14, l66: US14, l67: US6, l68: US5, l69: US6) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
        this.l5 = l5;
        this.l6 = l6;
        this.l7 = l7;
        this.l8 = l8;
        this.l9 = l9;
        this.l10 = l10;
        this.l11 = l11;
        this.l12 = l12;
        this.l13 = l13;
        this.l14 = l14;
        this.l15 = l15;
        this.l16 = l16;
        this.l17 = l17;
        this.l18 = l18;
        this.l19 = l19;
        this.l20 = l20;
        this.l21 = l21;
        this.l22 = l22;
        this.l23 = l23;
        this.l24 = l24;
        this.l25 = l25;
        this.l26 = l26;
        this.l27 = l27;
        this.l28 = l28;
        this.l29 = l29;
        this.l30 = l30;
        this.l31 = l31;
        this.l32 = l32;
        this.l33 = l33;
        this.l34 = l34;
        this.l35 = l35;
        this.l36 = l36;
        this.l37 = l37;
        this.l38 = l38;
        this.l39 = l39;
        this.l40 = l40;
        this.l41 = l41;
        this.l42 = l42;
        this.l43 = l43;
        this.l44 = l44;
        this.l45 = l45;
        this.l46 = l46;
        this.l47 = l47;
        this.l48 = l48;
        this.l49 = l49;
        this.l50 = l50;
        this.l51 = l51;
        this.l52 = l52;
        this.l53 = l53;
        this.l54 = l54;
        this.l55 = l55;
        this.l56 = l56;
        this.l57 = l57;
        this.l58 = l58;
        this.l59 = l59;
        this.l60 = l60;
        this.l61 = l61;
        this.l62 = l62;
        this.l63 = l63;
        this.l64 = l64;
        this.l65 = l65;
        this.l66 = l66;
        this.l67 = l67;
        this.l68 = l68;
        this.l69 = l69;
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components\'.Mut1", [], Mut1, () => [["l0", US6$reflection()], ["l1", US6$reflection()], ["l2", US6$reflection()], ["l3", US7$reflection()], ["l4", US6$reflection()], ["l5", US6$reflection()], ["l6", US6$reflection()], ["l7", US6$reflection()], ["l8", US6$reflection()], ["l9", US6$reflection()], ["l10", US8$reflection()], ["l11", US9$reflection()], ["l12", US6$reflection()], ["l13", US6$reflection()], ["l14", US8$reflection()], ["l15", US6$reflection()], ["l16", US6$reflection()], ["l17", US6$reflection()], ["l18", US10$reflection()], ["l19", US8$reflection()], ["l20", US6$reflection()], ["l21", US6$reflection()], ["l22", US6$reflection()], ["l23", US6$reflection()], ["l24", US6$reflection()], ["l25", US6$reflection()], ["l26", US11$reflection()], ["l27", US6$reflection()], ["l28", US6$reflection()], ["l29", US6$reflection()], ["l30", US11$reflection()], ["l31", US6$reflection()], ["l32", US6$reflection()], ["l33", US6$reflection()], ["l34", US6$reflection()], ["l35", US6$reflection()], ["l36", US6$reflection()], ["l37", US6$reflection()], ["l38", US6$reflection()], ["l39", US6$reflection()], ["l40", US6$reflection()], ["l41", US12$reflection()], ["l42", US13$reflection()], ["l43", US12$reflection()], ["l44", US6$reflection()], ["l45", US6$reflection()], ["l46", US6$reflection()], ["l47", US6$reflection()], ["l48", US6$reflection()], ["l49", US6$reflection()], ["l50", US6$reflection()], ["l51", US6$reflection()], ["l52", US6$reflection()], ["l53", US6$reflection()], ["l54", US6$reflection()], ["l55", US6$reflection()], ["l56", US6$reflection()], ["l57", US6$reflection()], ["l58", US6$reflection()], ["l59", US6$reflection()], ["l60", US14$reflection()], ["l61", US6$reflection()], ["l62", US11$reflection()], ["l63", US6$reflection()], ["l64", US6$reflection()], ["l65", US14$reflection()], ["l66", US14$reflection()], ["l67", US6$reflection()], ["l68", US5$reflection()], ["l69", US6$reflection()]]);
}

export class Mut2 {
    constructor() {
    }
}

export function Mut2$reflection(): TypeInfo {
    return class_type("Components\'.Mut2", void 0, Mut2);
}

export function Mut2_$ctor(): Mut2 {
    return new Mut2();
}

export const enum UH2_Tag {
    UH2_0 = 0,
    UH2_1 = 1
}

export type UH2_Fields = [[[string, any], UH2], []];

export type UH2 = UH2_Cons<UH2_Tag.UH2_0> | UH2_Cons<UH2_Tag.UH2_1>;

export function UH2_UH2_0(Item1: [string, any], Item2: UH2) {
    return new UH2_Cons<UH2_Tag.UH2_0>(UH2_Tag.UH2_0, [Item1, Item2]);
}

export function UH2_UH2_1() {
    return new UH2_Cons<UH2_Tag.UH2_1>(UH2_Tag.UH2_1, []);
}

export class UH2_Cons<Tag extends keyof UH2_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: UH2_Fields[Tag]) {
        super();
    }
    cases() {
        return ["UH2_0", "UH2_1"];
    }
}

export function UH2$reflection(): TypeInfo {
    return union_type("Components\'.UH2", [], UH2_Cons, () => [[["Item1", tuple_type(string_type, obj_type)], ["Item2", UH2$reflection()]], []]);
}

export const enum US15_Tag {
    US15_0 = 0,
    US15_1 = 1,
    US15_2 = 2
}

export type US15_Fields = [[], [], []];

export type US15 = US15_Cons<US15_Tag.US15_0> | US15_Cons<US15_Tag.US15_1> | US15_Cons<US15_Tag.US15_2>;

export function US15_US15_0() {
    return new US15_Cons<US15_Tag.US15_0>(US15_Tag.US15_0, []);
}

export function US15_US15_1() {
    return new US15_Cons<US15_Tag.US15_1>(US15_Tag.US15_1, []);
}

export function US15_US15_2() {
    return new US15_Cons<US15_Tag.US15_2>(US15_Tag.US15_2, []);
}

export class US15_Cons<Tag extends keyof US15_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US15_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US15_0", "US15_1", "US15_2"];
    }
}

export function US15$reflection(): TypeInfo {
    return union_type("Components\'.US15", [], US15_Cons, () => [[], [], []]);
}

export class Mut3 extends Record {
    l0: US13;
    l1: US13;
    l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    l3: US15;
    constructor(l0: US13, l1: US13, l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], l3: US15) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
    }
}

export function Mut3$reflection(): TypeInfo {
    return record_type("Components\'.Mut3", [], Mut3, () => [["l0", US13$reflection()], ["l1", US13$reflection()], ["l2", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))], ["l3", US15$reflection()]]);
}

export class Mut4 extends Record {
    l0: () => boolean;
    l1: (arg0: boolean) => void;
    l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    constructor(l0: () => boolean, l1: (arg0: boolean) => void, l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut4$reflection(): TypeInfo {
    return record_type("Components\'.Mut4", [], Mut4, () => [["l0", lambda_type(unit_type, bool_type)], ["l1", lambda_type(bool_type, unit_type)], ["l2", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))]]);
}

export class Mut5 extends Record {
    l0: boolean;
    l1: boolean;
    l2: US13;
    l3: US13;
    l4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    constructor(l0: boolean, l1: boolean, l2: US13, l3: US13, l4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
    }
}

export function Mut5$reflection(): TypeInfo {
    return record_type("Components\'.Mut5", [], Mut5, () => [["l0", bool_type], ["l1", bool_type], ["l2", US13$reflection()], ["l3", US13$reflection()], ["l4", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))]]);
}

export class Mut6 extends Record {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut6$reflection(): TypeInfo {
    return record_type("Components\'.Mut6", [], Mut6, () => [["l0", int32_type]]);
}

export class Mut7 extends Record {
    l0: () => any;
    l1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    constructor(l0: () => any, l1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut7$reflection(): TypeInfo {
    return record_type("Components\'.Mut7", [], Mut7, () => [["l0", lambda_type(unit_type, class_type("Fable.Core.JS.Function"))], ["l1", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))], ["l2", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US6$reflection(), US11$reflection(), US6$reflection(), US6$reflection(), US14$reflection(), US14$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))]]);
}

export class Mut8 extends Record {
    l0: (arg0: string) => any;
    l1: () => [() => string, (arg0: string) => void];
    l2: string;
    constructor(l0: (arg0: string) => any, l1: () => [() => string, (arg0: string) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut8$reflection(): TypeInfo {
    return record_type("Components\'.Mut8", [], Mut8, () => [["l0", lambda_type(string_type, obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, string_type), lambda_type(string_type, unit_type)))], ["l2", string_type]]);
}

export class Mut9 extends Record {
    l0: (arg0: int32) => any;
    l1: () => [() => int32, (arg0: int32) => void];
    l2: string;
    constructor(l0: (arg0: int32) => any, l1: () => [() => int32, (arg0: int32) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut9$reflection(): TypeInfo {
    return record_type("Components\'.Mut9", [], Mut9, () => [["l0", lambda_type(int32_type, obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, int32_type), lambda_type(int32_type, unit_type)))], ["l2", string_type]]);
}

export class Mut10 extends Record {
    l0: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => any;
    l1: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void];
    l2: string;
    constructor(l0: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => any, l1: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut10$reflection(): TypeInfo {
    return record_type("Components\'.Mut10", [], Mut10, () => [["l0", lambda_type(array_type(tuple_type(lambda_type(unit_type, US0$reflection()), lambda_type(US0$reflection(), unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type))), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(lambda_type(unit_type, US0$reflection()), lambda_type(US0$reflection(), unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type)))), lambda_type(array_type(tuple_type(lambda_type(unit_type, US0$reflection()), lambda_type(US0$reflection(), unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type))), unit_type)))], ["l2", string_type]]);
}

export class Mut11 extends Record {
    l0: (arg0: [US2, any, string][]) => any;
    l1: () => [() => [US2, any, string][], (arg0: [US2, any, string][]) => void];
    l2: string;
    constructor(l0: (arg0: [US2, any, string][]) => any, l1: () => [() => [US2, any, string][], (arg0: [US2, any, string][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut11$reflection(): TypeInfo {
    return record_type("Components\'.Mut11", [], Mut11, () => [["l0", lambda_type(array_type(tuple_type(US2$reflection(), obj_type, string_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(US2$reflection(), obj_type, string_type))), lambda_type(array_type(tuple_type(US2$reflection(), obj_type, string_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut12 extends Record {
    l0: (arg0: [US2[], int32, US3, string, string][]) => any;
    l1: () => [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void];
    l2: string;
    constructor(l0: (arg0: [US2[], int32, US3, string, string][]) => any, l1: () => [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut12$reflection(): TypeInfo {
    return record_type("Components\'.Mut12", [], Mut12, () => [["l0", lambda_type(array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type))), lambda_type(array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut13 extends Record {
    l0: (arg0: US4) => any;
    l1: () => [() => US4, (arg0: US4) => void];
    l2: string;
    constructor(l0: (arg0: US4) => any, l1: () => [() => US4, (arg0: US4) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut13$reflection(): TypeInfo {
    return record_type("Components\'.Mut13", [], Mut13, () => [["l0", lambda_type(US4$reflection(), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, US4$reflection()), lambda_type(US4$reflection(), unit_type)))], ["l2", string_type]]);
}

export class Mut14 extends Record {
    l0: (arg0: US5) => any;
    l1: () => [() => US5, (arg0: US5) => void];
    l2: string;
    constructor(l0: (arg0: US5) => any, l1: () => [() => US5, (arg0: US5) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut14$reflection(): TypeInfo {
    return record_type("Components\'.Mut14", [], Mut14, () => [["l0", lambda_type(US5$reflection(), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, US5$reflection()), lambda_type(US5$reflection(), unit_type)))], ["l2", string_type]]);
}

export class Mut15 extends Record {
    l0: (arg0: [string, int32][]) => any;
    l1: () => [() => [string, int32][], (arg0: [string, int32][]) => void];
    l2: string;
    constructor(l0: (arg0: [string, int32][]) => any, l1: () => [() => [string, int32][], (arg0: [string, int32][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut15$reflection(): TypeInfo {
    return record_type("Components\'.Mut15", [], Mut15, () => [["l0", lambda_type(array_type(tuple_type(class_type("System.Guid"), int32_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(class_type("System.Guid"), int32_type))), lambda_type(array_type(tuple_type(class_type("System.Guid"), int32_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut16 extends Record {
    l0: (arg0: [string, any][]) => any;
    l1: () => [() => [string, any][], (arg0: [string, any][]) => void];
    l2: string;
    constructor(l0: (arg0: [string, any][]) => any, l1: () => [() => [string, any][], (arg0: [string, any][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut16$reflection(): TypeInfo {
    return record_type("Components\'.Mut16", [], Mut16, () => [["l0", lambda_type(array_type(tuple_type(class_type("System.Guid"), obj_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(class_type("System.Guid"), obj_type))), lambda_type(array_type(tuple_type(class_type("System.Guid"), obj_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut17 extends Record {
    l0: () => US6;
    l1: (arg0: US6) => void;
    constructor(l0: () => US6, l1: (arg0: US6) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut17$reflection(): TypeInfo {
    return record_type("Components\'.Mut17", [], Mut17, () => [["l0", lambda_type(unit_type, US6$reflection())], ["l1", lambda_type(US6$reflection(), unit_type)]]);
}

export class Mut18 extends Record {
    l0: () => US5;
    l1: (arg0: US5) => void;
    constructor(l0: () => US5, l1: (arg0: US5) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut18$reflection(): TypeInfo {
    return record_type("Components\'.Mut18", [], Mut18, () => [["l0", lambda_type(unit_type, US5$reflection())], ["l1", lambda_type(US5$reflection(), unit_type)]]);
}

export class Mut19 extends Record {
    l0: US3;
    constructor(l0: US3) {
        super();
        this.l0 = l0;
    }
}

export function Mut19$reflection(): TypeInfo {
    return record_type("Components\'.Mut19", [], Mut19, () => [["l0", US3$reflection()]]);
}

export class Mut20 extends Record {
    l0: (arg0: [US2[], int32, US3, string, string]) => US6;
    l1: US3;
    l2: (arg0: [US2[], int32, US3, string, string], arg1: US6) => [US2[], int32, US3, string, string];
    constructor(l0: (arg0: [US2[], int32, US3, string, string]) => US6, l1: US3, l2: (arg0: [US2[], int32, US3, string, string], arg1: US6) => [US2[], int32, US3, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut20$reflection(): TypeInfo {
    return record_type("Components\'.Mut20", [], Mut20, () => [["l0", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), US6$reflection())], ["l1", US3$reflection()], ["l2", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), lambda_type(US6$reflection(), tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)))]]);
}

export class Mut21 extends Record {
    l0: int32;
    l1: US6;
    constructor(l0: int32, l1: US6) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut21$reflection(): TypeInfo {
    return record_type("Components\'.Mut21", [], Mut21, () => [["l0", int32_type], ["l1", US6$reflection()]]);
}

export class Mut22 extends Record {
    l0: (arg0: [US2[], int32, US3, string, string]) => US5;
    l1: US3;
    l2: (arg0: [US2[], int32, US3, string, string], arg1: US5) => [US2[], int32, US3, string, string];
    constructor(l0: (arg0: [US2[], int32, US3, string, string]) => US5, l1: US3, l2: (arg0: [US2[], int32, US3, string, string], arg1: US5) => [US2[], int32, US3, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut22$reflection(): TypeInfo {
    return record_type("Components\'.Mut22", [], Mut22, () => [["l0", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), US5$reflection())], ["l1", US3$reflection()], ["l2", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), lambda_type(US5$reflection(), tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)))]]);
}

export class Mut23 extends Record {
    l0: int32;
    l1: US5;
    constructor(l0: int32, l1: US5) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut23$reflection(): TypeInfo {
    return record_type("Components\'.Mut23", [], Mut23, () => [["l0", int32_type], ["l1", US5$reflection()]]);
}

export class Mut24 extends Record {
    l0: US2;
    l1: US3;
    constructor(l0: US2, l1: US3) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut24$reflection(): TypeInfo {
    return record_type("Components\'.Mut24", [], Mut24, () => [["l0", US2$reflection()], ["l1", US3$reflection()]]);
}

export class Mut25 extends Record {
    l0: int32;
    l1: int32;
    constructor(l0: int32, l1: int32) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = (l1 | 0);
    }
}

export function Mut25$reflection(): TypeInfo {
    return record_type("Components\'.Mut25", [], Mut25, () => [["l0", int32_type], ["l1", int32_type]]);
}

export const enum US16_Tag {
    US16_0 = 0,
    US16_1 = 1
}

export type US16_Fields = [[], [US2, string, int32]];

export type US16 = US16_Cons<US16_Tag.US16_0> | US16_Cons<US16_Tag.US16_1>;

export function US16_US16_0() {
    return new US16_Cons<US16_Tag.US16_0>(US16_Tag.US16_0, []);
}

export function US16_US16_1(f1_0: US2, f1_1: string, f1_2: int32) {
    return new US16_Cons<US16_Tag.US16_1>(US16_Tag.US16_1, [f1_0, f1_1, f1_2]);
}

export class US16_Cons<Tag extends keyof US16_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US16_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US16_0", "US16_1"];
    }
}

export function US16$reflection(): TypeInfo {
    return union_type("Components\'.US16", [], US16_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", class_type("System.Guid")], ["f1_2", int32_type]]]);
}

export const enum US17_Tag {
    US17_0 = 0,
    US17_1 = 1
}

export type US17_Fields = [[IDisposable], [int64]];

export type US17 = US17_Cons<US17_Tag.US17_0> | US17_Cons<US17_Tag.US17_1>;

export function US17_US17_0(f0_0: IDisposable) {
    return new US17_Cons<US17_Tag.US17_0>(US17_Tag.US17_0, [f0_0]);
}

export function US17_US17_1(f1_0: int64) {
    return new US17_Cons<US17_Tag.US17_1>(US17_Tag.US17_1, [f1_0]);
}

export class US17_Cons<Tag extends keyof US17_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US17_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US17_0", "US17_1"];
    }
}

export function US17$reflection(): TypeInfo {
    return union_type("Components\'.US17", [], US17_Cons, () => [[["f0_0", class_type("System.IDisposable")]], [["f1_0", int64_type]]]);
}

export const enum US18_Tag {
    US18_0 = 0,
    US18_1 = 1
}

export type US18_Fields = [[], [US2, any, string]];

export type US18 = US18_Cons<US18_Tag.US18_0> | US18_Cons<US18_Tag.US18_1>;

export function US18_US18_0() {
    return new US18_Cons<US18_Tag.US18_0>(US18_Tag.US18_0, []);
}

export function US18_US18_1(f1_0: US2, f1_1: any, f1_2: string) {
    return new US18_Cons<US18_Tag.US18_1>(US18_Tag.US18_1, [f1_0, f1_1, f1_2]);
}

export class US18_Cons<Tag extends keyof US18_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US18_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US18_0", "US18_1"];
    }
}

export function US18$reflection(): TypeInfo {
    return union_type("Components\'.US18", [], US18_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", class_type("Fable.Core.JS.Promise`1", [US17$reflection()])], ["f1_2", string_type]]]);
}

export class Mut26 extends Record {
    l0: int32;
    l1: US18;
    constructor(l0: int32, l1: US18) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut26$reflection(): TypeInfo {
    return record_type("Components\'.Mut26", [], Mut26, () => [["l0", int32_type], ["l1", US18$reflection()]]);
}

export class Mut27 extends Record {
    l0: int32;
    l1: any;
    constructor(l0: int32, l1: any) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut27$reflection(): TypeInfo {
    return record_type("Components\'.Mut27", [], Mut27, () => [["l0", int32_type], ["l1", obj_type]]);
}

export const enum UH3_Tag {
    UH3_0 = 0,
    UH3_1 = 1
}

export type UH3_Fields = [[string, int32, UH3], []];

export type UH3 = UH3_Cons<UH3_Tag.UH3_0> | UH3_Cons<UH3_Tag.UH3_1>;

export function UH3_UH3_0(Item1: string, Item2: int32, Item3: UH3) {
    return new UH3_Cons<UH3_Tag.UH3_0>(UH3_Tag.UH3_0, [Item1, Item2, Item3]);
}

export function UH3_UH3_1() {
    return new UH3_Cons<UH3_Tag.UH3_1>(UH3_Tag.UH3_1, []);
}

export class UH3_Cons<Tag extends keyof UH3_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: UH3_Fields[Tag]) {
        super();
    }
    cases() {
        return ["UH3_0", "UH3_1"];
    }
}

export function UH3$reflection(): TypeInfo {
    return union_type("Components\'.UH3", [], UH3_Cons, () => [[["Item1", class_type("System.Guid")], ["Item2", int32_type], ["Item3", UH3$reflection()]], []]);
}

export class Mut28 extends Record {
    l0: int32;
    l1: UH3;
    constructor(l0: int32, l1: UH3) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut28$reflection(): TypeInfo {
    return record_type("Components\'.Mut28", [], Mut28, () => [["l0", int32_type], ["l1", UH3$reflection()]]);
}

export const enum US19_Tag {
    US19_0 = 0,
    US19_1 = 1
}

export type US19_Fields = [[], [US2, string, [string, any][]]];

export type US19 = US19_Cons<US19_Tag.US19_0> | US19_Cons<US19_Tag.US19_1>;

export function US19_US19_0() {
    return new US19_Cons<US19_Tag.US19_0>(US19_Tag.US19_0, []);
}

export function US19_US19_1(f1_0: US2, f1_1: string, f1_2: [string, any][]) {
    return new US19_Cons<US19_Tag.US19_1>(US19_Tag.US19_1, [f1_0, f1_1, f1_2]);
}

export class US19_Cons<Tag extends keyof US19_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US19_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US19_0", "US19_1"];
    }
}

export function US19$reflection(): TypeInfo {
    return union_type("Components\'.US19", [], US19_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", class_type("System.Guid")], ["f1_2", array_type(tuple_type(class_type("System.Guid"), obj_type))]]]);
}

export const enum UH4_Tag {
    UH4_0 = 0,
    UH4_1 = 1
}

export type UH4_Fields = [[string, any, UH4], []];

export type UH4 = UH4_Cons<UH4_Tag.UH4_0> | UH4_Cons<UH4_Tag.UH4_1>;

export function UH4_UH4_0(Item1: string, Item2: any, Item3: UH4) {
    return new UH4_Cons<UH4_Tag.UH4_0>(UH4_Tag.UH4_0, [Item1, Item2, Item3]);
}

export function UH4_UH4_1() {
    return new UH4_Cons<UH4_Tag.UH4_1>(UH4_Tag.UH4_1, []);
}

export class UH4_Cons<Tag extends keyof UH4_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: UH4_Fields[Tag]) {
        super();
    }
    cases() {
        return ["UH4_0", "UH4_1"];
    }
}

export function UH4$reflection(): TypeInfo {
    return union_type("Components\'.UH4", [], UH4_Cons, () => [[["Item1", class_type("System.Guid")], ["Item2", obj_type], ["Item3", UH4$reflection()]], []]);
}

export class Mut29 extends Record {
    l0: int32;
    l1: UH4;
    constructor(l0: int32, l1: UH4) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut29$reflection(): TypeInfo {
    return record_type("Components\'.Mut29", [], Mut29, () => [["l0", int32_type], ["l1", UH4$reflection()]]);
}

export const enum US20_Tag {
    US20_0 = 0,
    US20_1 = 1
}

export type US20_Fields = [[], [US2, any, string]];

export type US20 = US20_Cons<US20_Tag.US20_0> | US20_Cons<US20_Tag.US20_1>;

export function US20_US20_0() {
    return new US20_Cons<US20_Tag.US20_0>(US20_Tag.US20_0, []);
}

export function US20_US20_1(f1_0: US2, f1_1: any, f1_2: string) {
    return new US20_Cons<US20_Tag.US20_1>(US20_Tag.US20_1, [f1_0, f1_1, f1_2]);
}

export class US20_Cons<Tag extends keyof US20_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US20_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US20_0", "US20_1"];
    }
}

export function US20$reflection(): TypeInfo {
    return union_type("Components\'.US20", [], US20_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", obj_type], ["f1_2", string_type]]]);
}

export class Mut30 extends Record {
    l0: int32;
    l1: US20;
    constructor(l0: int32, l1: US20) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut30$reflection(): TypeInfo {
    return record_type("Components\'.Mut30", [], Mut30, () => [["l0", int32_type], ["l1", US20$reflection()]]);
}

export const enum US21_Tag {
    US21_0 = 0,
    US21_1 = 1
}

export type US21_Fields = [[], [US2[], int32, US3, string, string]];

export type US21 = US21_Cons<US21_Tag.US21_0> | US21_Cons<US21_Tag.US21_1>;

export function US21_US21_0() {
    return new US21_Cons<US21_Tag.US21_0>(US21_Tag.US21_0, []);
}

export function US21_US21_1(f1_0: US2[], f1_1: int32, f1_2: US3, f1_3: string, f1_4: string) {
    return new US21_Cons<US21_Tag.US21_1>(US21_Tag.US21_1, [f1_0, f1_1, f1_2, f1_3, f1_4]);
}

export class US21_Cons<Tag extends keyof US21_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US21_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US21_0", "US21_1"];
    }
}

export function US21$reflection(): TypeInfo {
    return union_type("Components\'.US21", [], US21_Cons, () => [[], [["f1_0", array_type(US2$reflection())], ["f1_1", int32_type], ["f1_2", US3$reflection()], ["f1_3", string_type], ["f1_4", string_type]]]);
}

export class Mut31 extends Record {
    l0: int32;
    l1: US21;
    constructor(l0: int32, l1: US21) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut31$reflection(): TypeInfo {
    return record_type("Components\'.Mut31", [], Mut31, () => [["l0", int32_type], ["l1", US21$reflection()]]);
}

export class Mut32 extends Record {
    l0: int32;
    l1: [US2, any, string][];
    constructor(l0: int32, l1: [US2, any, string][]) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut32$reflection(): TypeInfo {
    return record_type("Components\'.Mut32", [], Mut32, () => [["l0", int32_type], ["l1", array_type(tuple_type(US2$reflection(), obj_type, string_type))]]);
}

export function closure0(unitVar: void, unitVar_1: void): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] {
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = void 0;
    return [patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21]];
}

export function method0(): any {
    const v2: any = createContext;
    const v3: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = (): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] => closure0(void 0, void 0);
    return v2<ReturnType<typeof v3>>();
}

export function method2(): [string, any, string, string, boolean] {
    const v0_1: any = components.env;
    const v1_1: string = v0_1.CODESPACE_NAME || "";
    const v2: string = v0_1.GITHUB_RUN_ID || "";
    const v3: string = v0_1.GITHUB_SHA || "";
    const v5: any = v0_1.IS_TEST;
    return [v1_1, v0_1, v2, v3, (!v5) === false];
}

export function closure2(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], US6_US6_1("neutral.900"), _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], US6_US6_1("neutral.400"), _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("1"), US6_US6_1("column"), _arg[22], US6_US6_1("sm"), US6_US6_1("100vh"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], US6_US6_1("100vw"), _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("1px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure5(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], US6_US6_1("blackAlpha.900"), _arg[5], _arg[6], _arg[7], _arg[8], US6_US6_1(v72_1), _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], _arg[20], US6_US6_1("column"), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], US6_US6_1("80vh"), US6_US6_1("50vw"), _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], US6_US6_1("auto"), _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], US6_US6_1("absolute"), US6_US6_1(v72_1), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], US5_US5_1(2), _arg[69]];
}

export function closure8(v0_1: Mut1, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: US6 = v0_1.l46;
    const v75_1: string = (v71.tag === US6_Tag.US6_1) ? v71.fields[0] : "hidden";
    const v76_1: US6 = v0_1.l47;
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("1"), US6_US6_1("column"), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], US6_US6_1(v75_1), US6_US6_1((v76_1.tag === US6_Tag.US6_1) ? v76_1.fields[0] : "hidden"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure10(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], US6_US6_1("blackAlpha.700"), _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], _arg[20], US6_US6_1("column"), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], US6_US6_1("-1px"), _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure11(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method6(): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [US6_US6_0(), US6_US6_0(), US6_US6_0(), US7_US7_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US8_US8_0(), US9_US9_0(), US6_US6_0(), US6_US6_0(), US8_US8_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US10_US10_0(), US8_US8_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US11_US11_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US11_US11_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US12_US12_0(), US13_US13_0(), US12_US12_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US14_US14_0(), US6_US6_0(), US11_US11_0(), US6_US6_0(), US6_US6_0(), US14_US14_0(), US14_US14_0(), US6_US6_0(), US5_US5_0(), US6_US6_0()];
}

export function method9(v0_1_mut: UH2, v1_1_mut: int32): int32 {
    method9:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v1_1 + 1);
            continue method9;
        }
        break;
    }
}

export function method10(v0_1_mut: [string, any][], v1_1_mut: UH2, v2_mut: int32): int32 {
    method10:
    while (true) {
        const v0_1: [string, any][] = v0_1_mut, v1_1: UH2 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH2_Tag.UH2_1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = v1_1.fields[0];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[1];
            v2_mut = (v2 + 1);
            continue method10;
        }
        break;
    }
}

export function method8(v0_1: UH2): [string, any][] {
    const v2: int32 = method9(v0_1, 0) | 0;
    const v3: [string, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method10(v3, v0_1, 0) | 0;
    return v3;
}

export function method7(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6): [string, any][] {
    const v73_1: any = (v0_1.tag === US6_Tag.US6_1) ? v0_1.fields[0] : (void 0);
    const v80: UH2 = (!v73_1) ? UH2_UH2_1() : UH2_UH2_0(["alignItems", v73_1], UH2_UH2_1());
    const v84: any = (v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : (void 0);
    const v89: UH2 = (!v84) ? v80 : UH2_UH2_0(["alignSelf", v84], v80);
    const v93: any = (v2.tag === US6_Tag.US6_1) ? v2.fields[0] : (void 0);
    const v98: UH2 = (!v93) ? v89 : UH2_UH2_0(["aria-label", v93], v89);
    const v102: any = (v3.tag === US7_Tag.US7_1) ? v3.fields[0] : (void 0);
    const v107: UH2 = (!v102) ? v98 : UH2_UH2_0(["as", v102], v98);
    const v111: any = (v4.tag === US6_Tag.US6_1) ? v4.fields[0] : (void 0);
    const v116: UH2 = (!v111) ? v107 : UH2_UH2_0(["backgroundColor", v111], v107);
    const v120: any = (v5.tag === US6_Tag.US6_1) ? v5.fields[0] : (void 0);
    const v125: UH2 = (!v120) ? v116 : UH2_UH2_0(["border", v120], v116);
    const v129: any = (v6.tag === US6_Tag.US6_1) ? v6.fields[0] : (void 0);
    const v134: UH2 = (!v129) ? v125 : UH2_UH2_0(["borderBottomWidth", v129], v125);
    const v138: any = (v7.tag === US6_Tag.US6_1) ? v7.fields[0] : (void 0);
    const v143: UH2 = (!v138) ? v134 : UH2_UH2_0(["borderColor", v138], v134);
    const v147: any = (v8.tag === US6_Tag.US6_1) ? v8.fields[0] : (void 0);
    const v152: UH2 = (!v147) ? v143 : UH2_UH2_0(["borderWidth", v147], v143);
    const v156: any = (v9.tag === US6_Tag.US6_1) ? v9.fields[0] : (void 0);
    const v161: UH2 = (!v156) ? v152 : UH2_UH2_0(["bottom", v156], v152);
    const v165: any = (v10.tag === US8_Tag.US8_1) ? v10.fields[0] : (void 0);
    const v170: UH2 = (!v165) ? v161 : UH2_UH2_0(["checked", v165], v161);
    const v174_1: any = (v11.tag === US9_Tag.US9_1) ? v11.fields[0] : (void 0);
    const v179_1: UH2 = (!v174_1) ? v170 : UH2_UH2_0(["children", v174_1], v170);
    const v183_1: any = (v12.tag === US6_Tag.US6_1) ? v12.fields[0] : (void 0);
    const v188_1: UH2 = (!v183_1) ? v179_1 : UH2_UH2_0(["color", v183_1], v179_1);
    const v192_1: any = (v13.tag === US6_Tag.US6_1) ? v13.fields[0] : (void 0);
    const v197: UH2 = (!v192_1) ? v188_1 : UH2_UH2_0(["colorScheme", v192_1], v188_1);
    const v201: any = (v14.tag === US8_Tag.US8_1) ? v14.fields[0] : (void 0);
    const v206: UH2 = (!v201) ? v197 : UH2_UH2_0(["compact", v201], v197);
    const v210: any = (v15.tag === US6_Tag.US6_1) ? v15.fields[0] : (void 0);
    const v215: UH2 = (!v210) ? v206 : UH2_UH2_0(["defaultValue", v210], v206);
    const v219: any = (v16.tag === US6_Tag.US6_1) ? v16.fields[0] : (void 0);
    const v224: UH2 = (!v219) ? v215 : UH2_UH2_0(["direction", v219], v215);
    const v228: any = (v17.tag === US6_Tag.US6_1) ? v17.fields[0] : (void 0);
    const v233: UH2 = (!v228) ? v224 : UH2_UH2_0(["display", v228], v224);
    const v237: any = (v18.tag === US10_Tag.US10_1) ? v18.fields[0] : (void 0);
    const v242: UH2 = (!v237) ? v233 : UH2_UH2_0(["each", v237], v233);
    const v246: any = (v19.tag === US8_Tag.US8_1) ? v19.fields[0] : (void 0);
    const v251: UH2 = (!v246) ? v242 : UH2_UH2_0(["external", v246], v242);
    const v255: any = (v20.tag === US6_Tag.US6_1) ? v20.fields[0] : (void 0);
    const v260: UH2 = (!v255) ? v251 : UH2_UH2_0(["flex", v255], v251);
    const v264: any = (v21.tag === US6_Tag.US6_1) ? v21.fields[0] : (void 0);
    const v269: UH2 = (!v264) ? v260 : UH2_UH2_0(["flexDirection", v264], v260);
    const v273: any = (v22.tag === US6_Tag.US6_1) ? v22.fields[0] : (void 0);
    const v278: UH2 = (!v273) ? v269 : UH2_UH2_0(["flexFlow", v273], v269);
    const v282: any = (v23.tag === US6_Tag.US6_1) ? v23.fields[0] : (void 0);
    const v287: UH2 = (!v282) ? v278 : UH2_UH2_0(["fontSize", v282], v278);
    const v291: any = (v24.tag === US6_Tag.US6_1) ? v24.fields[0] : (void 0);
    const v296: UH2 = (!v291) ? v287 : UH2_UH2_0(["height", v291], v287);
    const v300: any = (v25.tag === US6_Tag.US6_1) ? v25.fields[0] : (void 0);
    const v305: UH2 = (!v300) ? v296 : UH2_UH2_0(["href", v300], v296);
    const v309: any = (v26.tag === US11_Tag.US11_1) ? v26.fields[0] : (void 0);
    const v314: UH2 = (!v309) ? v305 : UH2_UH2_0(["icon", v309], v305);
    const v318: any = (v27.tag === US6_Tag.US6_1) ? v27.fields[0] : (void 0);
    const v323: UH2 = (!v318) ? v314 : UH2_UH2_0(["id", v318], v314);
    const v327: any = (v28.tag === US6_Tag.US6_1) ? v28.fields[0] : (void 0);
    const v332: UH2 = (!v327) ? v323 : UH2_UH2_0(["justifyContent", v327], v323);
    const v336: any = (v29.tag === US6_Tag.US6_1) ? v29.fields[0] : (void 0);
    const v341: UH2 = (!v336) ? v332 : UH2_UH2_0(["left", v336], v332);
    const v345: any = (v30.tag === US11_Tag.US11_1) ? v30.fields[0] : (void 0);
    const v350: UH2 = (!v345) ? v341 : UH2_UH2_0(["leftIcon", v345], v341);
    const v354: any = (v31.tag === US6_Tag.US6_1) ? v31.fields[0] : (void 0);
    const v359: UH2 = (!v354) ? v350 : UH2_UH2_0(["lineHeight", v354], v350);
    const v363: any = (v32.tag === US6_Tag.US6_1) ? v32.fields[0] : (void 0);
    const v368: UH2 = (!v363) ? v359 : UH2_UH2_0(["margin", v363], v359);
    const v372: any = (v33.tag === US6_Tag.US6_1) ? v33.fields[0] : (void 0);
    const v377: UH2 = (!v372) ? v368 : UH2_UH2_0(["marginBottom", v372], v368);
    const v381: any = (v34.tag === US6_Tag.US6_1) ? v34.fields[0] : (void 0);
    const v386: UH2 = (!v381) ? v377 : UH2_UH2_0(["marginLeft", v381], v377);
    const v390: any = (v35.tag === US6_Tag.US6_1) ? v35.fields[0] : (void 0);
    const v395: UH2 = (!v390) ? v386 : UH2_UH2_0(["marginRight", v390], v386);
    const v399: any = (v36.tag === US6_Tag.US6_1) ? v36.fields[0] : (void 0);
    const v404: UH2 = (!v399) ? v395 : UH2_UH2_0(["marginTop", v399], v395);
    const v408: any = (v37.tag === US6_Tag.US6_1) ? v37.fields[0] : (void 0);
    const v413: UH2 = (!v408) ? v404 : UH2_UH2_0(["maxHeight", v408], v404);
    const v417: any = (v38.tag === US6_Tag.US6_1) ? v38.fields[0] : (void 0);
    const v422: UH2 = (!v417) ? v413 : UH2_UH2_0(["maxWidth", v417], v413);
    const v426: any = (v39.tag === US6_Tag.US6_1) ? v39.fields[0] : (void 0);
    const v431: UH2 = (!v426) ? v422 : UH2_UH2_0(["minHeight", v426], v422);
    const v435: any = (v40.tag === US6_Tag.US6_1) ? v40.fields[0] : (void 0);
    const v440: UH2 = (!v435) ? v431 : UH2_UH2_0(["minWidth", v435], v431);
    const v444: any = (v41.tag === US12_Tag.US12_1) ? v41.fields[0] : (void 0);
    const v449: UH2 = (!v444) ? v440 : UH2_UH2_0(["onChange", v444], v440);
    const v453: any = (v42.tag === US13_Tag.US13_1) ? v42.fields[0] : (void 0);
    const v458: UH2 = (!v453) ? v449 : UH2_UH2_0(["onClick", v453], v449);
    const v462: any = (v43.tag === US12_Tag.US12_1) ? v43.fields[0] : (void 0);
    const v467: UH2 = (!v462) ? v458 : UH2_UH2_0(["onInput", v462], v458);
    const v471: any = (v44.tag === US6_Tag.US6_1) ? v44.fields[0] : (void 0);
    const v476: UH2 = (!v471) ? v467 : UH2_UH2_0(["outline", v471], v467);
    const v480: any = (v45.tag === US6_Tag.US6_1) ? v45.fields[0] : (void 0);
    const v485: UH2 = (!v480) ? v476 : UH2_UH2_0(["overflow", v480], v476);
    const v489: any = (v46.tag === US6_Tag.US6_1) ? v46.fields[0] : (void 0);
    const v494: UH2 = (!v489) ? v485 : UH2_UH2_0(["overflowX", v489], v485);
    const v498: any = (v47.tag === US6_Tag.US6_1) ? v47.fields[0] : (void 0);
    const v503: UH2 = (!v498) ? v494 : UH2_UH2_0(["overflowY", v498], v494);
    const v507: any = (v48.tag === US6_Tag.US6_1) ? v48.fields[0] : (void 0);
    const v512: UH2 = (!v507) ? v503 : UH2_UH2_0(["padding", v507], v503);
    const v516: any = (v49.tag === US6_Tag.US6_1) ? v49.fields[0] : (void 0);
    const v521: UH2 = (!v516) ? v512 : UH2_UH2_0(["paddingBottom", v516], v512);
    const v525: any = (v50.tag === US6_Tag.US6_1) ? v50.fields[0] : (void 0);
    const v530: UH2 = (!v525) ? v521 : UH2_UH2_0(["paddingLeft", v525], v521);
    const v534: any = (v51.tag === US6_Tag.US6_1) ? v51.fields[0] : (void 0);
    const v539: UH2 = (!v534) ? v530 : UH2_UH2_0(["paddingRight", v534], v530);
    const v543: any = (v52.tag === US6_Tag.US6_1) ? v52.fields[0] : (void 0);
    const v548: UH2 = (!v543) ? v539 : UH2_UH2_0(["paddingTop", v543], v539);
    const v552: any = (v53.tag === US6_Tag.US6_1) ? v53.fields[0] : (void 0);
    const v557: UH2 = (!v552) ? v548 : UH2_UH2_0(["placeholder", v552], v548);
    const v561: any = (v54.tag === US6_Tag.US6_1) ? v54.fields[0] : (void 0);
    const v566: UH2 = (!v561) ? v557 : UH2_UH2_0(["position", v561], v557);
    const v570: any = (v55.tag === US6_Tag.US6_1) ? v55.fields[0] : (void 0);
    const v575: UH2 = (!v570) ? v566 : UH2_UH2_0(["right", v570], v566);
    const v579: any = (v56.tag === US6_Tag.US6_1) ? v56.fields[0] : (void 0);
    const v584: UH2 = (!v579) ? v575 : UH2_UH2_0(["size", v579], v575);
    const v588: any = (v57.tag === US6_Tag.US6_1) ? v57.fields[0] : (void 0);
    const v593: UH2 = (!v588) ? v584 : UH2_UH2_0(["spacing", v588], v584);
    const v597: any = (v58.tag === US6_Tag.US6_1) ? v58.fields[0] : (void 0);
    const v602: UH2 = (!v597) ? v593 : UH2_UH2_0(["src", v597], v593);
    const v606: any = (v59.tag === US6_Tag.US6_1) ? v59.fields[0] : (void 0);
    const v611: UH2 = (!v606) ? v602 : UH2_UH2_0(["striped", v606], v602);
    const v615: any = (v60.tag === US14_Tag.US14_1) ? v60.fields[0] : (void 0);
    const v620: UH2 = (!v615) ? v611 : UH2_UH2_0(["sx", v615], v611);
    const v624: any = (v61.tag === US6_Tag.US6_1) ? v61.fields[0] : (void 0);
    const v629: UH2 = (!v624) ? v620 : UH2_UH2_0(["thickness", v624], v620);
    const v633: any = (v62.tag === US11_Tag.US11_1) ? v62.fields[0] : (void 0);
    const v638: UH2 = (!v633) ? v629 : UH2_UH2_0(["title", v633], v629);
    const v642: any = (v63.tag === US6_Tag.US6_1) ? v63.fields[0] : (void 0);
    const v647: UH2 = (!v642) ? v638 : UH2_UH2_0(["top", v642], v638);
    const v651: any = (v64.tag === US6_Tag.US6_1) ? v64.fields[0] : (void 0);
    const v656: UH2 = (!v651) ? v647 : UH2_UH2_0(["type", v651], v647);
    const v660: any = (v65.tag === US14_Tag.US14_1) ? v65.fields[0] : (void 0);
    const v665: UH2 = (!v660) ? v656 : UH2_UH2_0(["value", v660], v656);
    const v669: any = (v66.tag === US14_Tag.US14_1) ? v66.fields[0] : (void 0);
    const v674: UH2 = (!v669) ? v665 : UH2_UH2_0(["when", v669], v665);
    const v678: any = (v67.tag === US6_Tag.US6_1) ? v67.fields[0] : (void 0);
    const v683: UH2 = (!v678) ? v674 : UH2_UH2_0(["width", v678], v674);
    const v687: any = (v68.tag === US5_Tag.US5_1) ? v68.fields[0] : (void 0);
    const v692: UH2 = (!v687) ? v683 : UH2_UH2_0(["zIndex", v687], v683);
    const v696: any = (v69.tag === US6_Tag.US6_1) ? v69.fields[0] : (void 0);
    return method8((!v696) ? v692 : UH2_UH2_0(["zoom", v696], v692));
}

export function method5(v0_1: any, v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v2: () => any[]): any {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = method6();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v84: US9 = patternInput_1[11];
    let v151: US9;
    if (v84.tag === US9_Tag.US9_1) {
        const v146: any = children_1;
        v151 = US9_US9_1(v146(v84.fields[0]));
    }
    else {
        v151 = US9_US9_0();
    }
    const v157: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v151.tag === US9_Tag.US9_1) ? v151.fields[0] : v2), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    v157.children = v2;
    const v158: (arg0: any) => any = v0_1;
    const v161: any = createComponent;
    return v161(v158, v157);
}

export function closure9(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = hope;
    const v7: any = v3.tbody;
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure10(void 0, arg10$0040);
    const v9: US9 = v0_1.l11;
    return [method5(v7, v8, (v9.tag === US9_Tag.US9_1) ? v9.fields[0] : ((): any[] => closure11(void 0, void 0)))];
}

export function method4(v0_1: Mut1): any {
    const v3: any = hope;
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure8(v0_1, arg10$0040);
    const v9: () => any[] = (): any[] => closure9(v0_1, void 0);
    return method5(v3.table, v8, v9);
}

export function closure7(unitVar: void, v0_1: Mut1): any {
    return method4(v0_1);
}

export function closure12(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method12(v0_1: boolean): [() => boolean, (arg0: boolean) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: boolean): void => {
        value_2(arg_1);
    })];
}

export function method13(v0_1: string, v1_1: string): string {
    return {
        "@base": v1_1,
        "@sm": v0_1,
    };
}

export function closure15(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], US6_US6_1("neutral.500"), US6_US6_1("1px 1px"), _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("1"), US6_US6_1(method13("row", "column")), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], v27, _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure17(v0_1: Mut3, v1_1: US6, v2: US6, v3: US6, v4: US7, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US6, v11: US8, v12: US9, v13: US6, v14: US6, v15: US8, v16: US6, v17: US6, v18: US6, v19: US10, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US11, v28: US6, v29: US6, v30: US6, v31: US11, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US12, v43: US13, v44: US12, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US14, v62: US6, v63: US11, v64: US6, v65: US6, v66: US14, v67: US14, v68: US6, v69: US5, v70: US6, v71: () => boolean, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v178_1: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], US6_US6_1(((v0_1.l3.tag === US15_Tag.US15_2) ? true : v71()) ? method13("0px !important", void 0) : "0px !important"), US6_US6_1("neutral.500"), _arg[8], _arg[9], _arg[10], _arg[11], US6_US6_1("neutral.400"), _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], _arg[20], US6_US6_1("column"), _arg[22], US6_US6_1((v24.tag === US6_Tag.US6_1) ? v24.fields[0] : "sm"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1(v178_1), US6_US6_1(v178_1), US6_US6_1(method13((v51.tag === US6_Tag.US6_1) ? (("0" === v51.fields[0]) ? "0" : "15px") : "15px", (v52.tag === US6_Tag.US6_1) ? v52.fields[0] : "0")), US6_US6_1(v178_1), _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure19(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v143: string = (v52.tag === US6_Tag.US6_1) ? v52.fields[0] : "4px";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1((v49.tag === US6_Tag.US6_1) ? v49.fields[0] : "2px"), US6_US6_1((v50.tag === US6_Tag.US6_1) ? v50.fields[0] : "8px"), _arg[51], US6_US6_1(v143), _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure22(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure25(v0_1: Mut4, v1_1: any): void {
    const v3: any = v1_1.target;
    const v6: boolean = v3.checked;
    v0_1.l1(v6);
}

export function closure24(v0_1: Mut4, v1_1: US6, v2: US6, v3: US6, v4: US7, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US6, v11: US8, v12: US9, v13: US6, v14: US6, v15: US8, v16: US6, v17: US6, v18: US6, v19: US10, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US11, v28: US6, v29: US6, v30: US6, v31: US11, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US12, v43: US13, v44: US12, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US14, v62: US6, v63: US11, v64: US6, v65: US6, v66: US14, v67: US14, v68: US6, v69: US5, v70: US6, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v146: (arg0: any) => void = (v: any): void => {
        closure25(v0_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US8_US8_1(v0_1.l0()), _arg[11], _arg[12], US6_US6_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], v28, _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US12_US12_1(v146), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("2px"), US6_US6_1("3px"), _arg[51], US6_US6_1("1px"), _arg[53], _arg[54], _arg[55], US6_US6_1("sm"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], US6_US6_1("checkbox"), _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure26(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure28(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], US6_US6_1("1.5px"), _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure29(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure27(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6, unitVar: void): any[] {
    const v72_1: any = Box;
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure28(void 0, arg10$0040);
    return [method5(v72_1, v73_1, (v11.tag === US9_Tag.US9_1) ? v11.fields[0] : ((): any[] => closure29(void 0, void 0)))];
}

export function closure23(v0_1: Mut4, v1_1: US6, v2: US6, v3: US6, v4: US7, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US6, v11: US8, v12: US9, v13: US6, v14: US6, v15: US8, v16: US6, v17: US6, v18: US6, v19: US10, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US11, v28: US6, v29: US6, v30: US6, v31: US11, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US12, v43: US13, v44: US12, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US14, v62: US6, v63: US11, v64: US6, v65: US6, v66: US14, v67: US14, v68: US6, v69: US5, v70: US6, unitVar: void): any[] {
    const v73_1: any = hope;
    const v78: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure24(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, arg10$0040);
    const v79: () => any[] = (): any[] => closure26(void 0, void 0);
    const v84: () => any[] = (): any[] => closure27(v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, void 0);
    return [method5(v73_1.input, v78, v79), <>
        &nbsp;
    </>, v84];
}

export function closure21(unitVar: void, v0_1: Mut4): any {
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v0_1.l2;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = method6();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v83: US9 = patternInput_1[11];
    let v150: US9;
    if (v83.tag === US9_Tag.US9_1) {
        const v145: any = children_1;
        v150 = US9_US9_1(v145(v83.fields[0]));
    }
    else {
        v150 = US9_US9_0();
    }
    const v153: any = Box;
    const v154: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure22(void 0, arg10$0040);
    const v155: () => any[] = (): any[] => closure23(v0_1, patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], v150, patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69], void 0);
    return method5(v153, v154, v155);
}

export function closure31(v0_1: any, unitVar: void): any[] {
    return [v0_1];
}

export function closure30(v0_1: any, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: () => any[] = (): any[] => closure31(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v71), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method14(v0_1: (arg0: Mut4) => any, v1_1: () => boolean, v2: (arg0: boolean) => void, v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): any {
    const v4: Mut4 = new Mut4(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure20(v0_1: Mut3, v1_1: (arg0: boolean) => void, v2: () => boolean, v3: any, unitVar: void): any[] {
    let v5: (arg0: Mut4) => any, v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    return [(v0_1.l3.tag === US15_Tag.US15_2) ? v3 : ((v5 = ((v: Mut4): any => closure21(void 0, v)), (v6 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure30(v3, arg10$0040)), method14(v5, v2, v1_1, v6))))];
}

export function closure18(v0_1: Mut3, v1_1: US6, v2: US6, v3: US6, v4: US7, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US6, v11: US8, v12: US9, v13: US6, v14: US6, v15: US8, v16: US6, v17: US6, v18: US6, v19: US10, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US11, v28: US6, v29: US6, v30: US6, v31: US11, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US12, v43: US13, v44: US12, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US14, v62: US6, v63: US11, v64: US6, v65: US6, v66: US14, v67: US14, v68: US6, v69: US5, v70: US6, v71: (arg0: boolean) => void, v72_1: () => boolean, v73_1: any, unitVar: void): any[] {
    const v76_1: any = Box;
    const v77_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure19(v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, arg10$0040);
    const v78: () => any[] = (): any[] => closure20(v0_1, v71, v72_1, v73_1, void 0);
    return [method5(v76_1, v77_1, v78)];
}

export function closure32(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v70: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], US6_US6_1(v70), _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], US6_US6_1("9px"), _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1(v70), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure33(unitVar: void, unitVar_1: void): any[] {
    return [<>
        &nbsp;
    </>];
}

export function closure34(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v143: string = (v23.tag === US6_Tag.US6_1) ? v23.fields[0] : "sm";
    const v147: string = (v28.tag === US6_Tag.US6_1) ? v28.fields[0] : "center";
    const v151: string = (v34.tag === US6_Tag.US6_1) ? v34.fields[0] : "0";
    const v160: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], US6_US6_1(v160), _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("6"), US6_US6_1("column"), _arg[22], US6_US6_1(v143), _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1(v147), _arg[29], _arg[30], US6_US6_1("base"), _arg[32], US6_US6_1((v33.tag === US6_Tag.US6_1) ? v33.fields[0] : "0"), US6_US6_1(v151), US6_US6_1(v160), US6_US6_1(v160), US6_US6_1("85vh"), _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US6_US6_1(v160), US6_US6_1("auto"), _arg[46], _arg[47], US6_US6_1((v48.tag === US6_Tag.US6_1) ? v48.fields[0] : "0"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure37(v0_1: int32, v1_1: () => string, v2: () => US4, v3: () => US5, unitVar: void): any[] {
    const v6: string = v1_1();
    const v9: US4 = v2();
    return [["loader_id", v0_1], ["chain_token", v6], ["log_level", (v9.tag === US4_Tag.US4_0) ? "Debug" : ((v9.tag === US4_Tag.US4_1) ? "Error" : ((v9.tag === US4_Tag.US4_2) ? "Info" : ((v9.tag === US4_Tag.US4_4) ? "Warn" : "Error")))], ["ui_modal", v3()]];
}

export function method18(v0_1_mut: int32, v1_1_mut: string): string {
    method18:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: string = v1_1_mut;
        if (v1_1.length < v0_1) {
            v0_1_mut = v0_1;
            v1_1_mut = (`0${v1_1}`);
            continue method18;
        }
        else {
            return v1_1;
        }
        break;
    }
}

export function closure39(v0_1: () => US4, v1_1: () => any[], v2: string, v3: string, v4: any, v5: string, v6: string, v7: boolean, v8: int64, v9: US4, v10: any[]): void {
    const v11: US4 = v0_1();
    if (getUnionFields(v11, US4$reflection())[0].tag <= getUnionFields(v9, US4$reflection())[0].tag) {
        const v25: any[] = [["timestamp", method18(6, toString(op_Subtraction(getTicks(utcNow()), v8)))], ["run_id", components.run_id]];
        const v26: any[] = v1_1();
        const v27: string = JSON.stringify(v26);
        const v28: string = JSON.stringify(v10);
        const v29: string = JSON.stringify(v25);
        let patternInput: [string, string, string, string, string];
        if (v7) {
            const v30: string = "";
            patternInput = [v28, v27, v29, v30, v30];
        }
        else {
            patternInput = ["%c%s %c%s", `font-weight: bold; color: ${v2}`, v28, "font-weight: bold; color: #444", `${v27} ${v29}`];
        }
        console.log.apply(console, [patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]]);
    }
}

export function closure38(v0_1: () => US4, v1_1: () => any[], v2: string, v3: string, v4: any, v5: string, v6: string, v7: boolean, v8: int64, v9: US4): (arg0: any[]) => void {
    return (v: any[]): void => {
        closure39(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v);
    };
}

export function method17(v0_1: () => US4, v1_1: () => any[], v2: string): (arg0: US4, arg1: any[]) => void {
    const patternInput: [string, any, string, string, boolean] = method2();
    const v8: int64 = getTicks(utcNow());
    return (v: US4): (arg0: any[]) => void => closure38(v0_1, v1_1, v2, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], v8, v);
}

export function method16(v0_1: () => any[], v1_1: string): (arg0: US4, arg1: any[]) => void {
    const v97: any = components.state_context;
    const v100: any = useContext;
    return method17((v100(v97))[18], v0_1, v1_1);
}

export function closure40(v0_1: Mut5, v1_1: int32, v2: (arg0: US5) => void, unitVar: void): void {
    if (v0_1.l1) {
        v2(US5_US5_1(v1_1));
    }
}

export function closure41(v0_1: (arg0: boolean) => void, v1_1: () => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure42(v0_1: Mut5, unitVar: void): void {
    const v1_1: US13 = v0_1.l3;
    if (v1_1.tag === US13_Tag.US13_1) {
        v1_1.fields[0]();
    }
}

export function closure43(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("1"), _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], v27, _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure45(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px 0"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method21(v0_1: int32, v1_1: Mut6): boolean {
    return v1_1.l0 < v0_1;
}

export function method20(v0_1: Mut1, v1_1: Mut1): void {
    const v2: string[] = Object.keys(v0_1);
    const v3: int32 = v2.length | 0;
    const v4: Mut6 = new Mut6(0);
    while (method21(v3, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v7: string = v2[v6];
        if (!!v1_1[v7].tag) {
            v0_1[v7] = v1_1[v7];
        }
        const v9: int32 = (v6 + 1) | 0;
        v4.l0 = (v9 | 0);
    }
}

export function closure48(v0_1: Mut1, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67, v0_1.l68, v0_1.l69];
    const v149: Mut1 = new Mut1(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US6_US6_1("neutral"), US8_US8_1(true), _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("left"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("xs"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]);
    method20(v149, new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = [v149.l0, v149.l1, v149.l2, v149.l3, v149.l4, v149.l5, v149.l6, v149.l7, v149.l8, v149.l9, v149.l10, v149.l11, v149.l12, v149.l13, v149.l14, v149.l15, v149.l16, v149.l17, v149.l18, v149.l19, v149.l20, v149.l21, v149.l22, v149.l23, v149.l24, v149.l25, v149.l26, v149.l27, v149.l28, v149.l29, v149.l30, v149.l31, v149.l32, v149.l33, v149.l34, v149.l35, v149.l36, v149.l37, v149.l38, v149.l39, v149.l40, v149.l41, v149.l42, v149.l43, v149.l44, v149.l45, v149.l46, v149.l47, v149.l48, v149.l49, v149.l50, v149.l51, v149.l52, v149.l53, v149.l54, v149.l55, v149.l56, v149.l57, v149.l58, v149.l59, v149.l60, v149.l61, v149.l62, v149.l63, v149.l64, v149.l65, v149.l66, v149.l67, v149.l68, v149.l69];
    return [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]];
}

export function closure49(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method19(v0_1: Mut1): any {
    const v3: any = Button;
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure48(v0_1, arg10$0040);
    const v5: US9 = v0_1.l11;
    return method5(v3, v4, (v5.tag === US9_Tag.US9_1) ? v5.fields[0] : ((): any[] => closure49(void 0, void 0)));
}

export function closure47(unitVar: void, v0_1: Mut1): any {
    return method19(v0_1);
}

export function closure51(v0_1: (arg0: boolean) => void, v1_1: Mut5, unitVar: void): void {
    const v2: US13 = v1_1.l2;
    if (v2.tag === US13_Tag.US13_1) {
        v2.fields[0]();
    }
    v0_1(true);
}

export function closure50(v0_1: (arg0: boolean) => void, v1_1: Mut5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: () => void = (): void => {
        closure51(v0_1, v1_1, void 0);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v72_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure52(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Load
    </>];
}

export function method22(v0_1: (arg0: Mut1) => any, v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v2: () => any[]): any {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = method6();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v84: US9 = patternInput_1[11];
    let v151: US9;
    if (v84.tag === US9_Tag.US9_1) {
        const v146: any = children_1;
        v151 = US9_US9_1(v146(v84.fields[0]));
    }
    else {
        v151 = US9_US9_0();
    }
    const v156: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v151.tag === US9_Tag.US9_1) ? v151.fields[0] : v2), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    v156.children = v2;
    const v159: any = createComponent;
    return v159(v0_1, v156);
}

export function closure46(v0_1: (arg0: boolean) => void, v1_1: Mut5, unitVar: void): any[] {
    const v2: (arg0: Mut1) => any = (v: Mut1): any => closure47(void 0, v);
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure50(v0_1, v1_1, arg10$0040);
    const v4: () => any[] = (): any[] => closure52(void 0, void 0);
    return [method22(v2, v3, v4)];
}

export function closure53(v0_1: int32, v1_1: () => US5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: US5 = v1_1();
    const v80: US6 = ((v72_1.tag === US5_Tag.US5_1) && (v72_1.fields[0] === v0_1)) ? US6_US6_1("neutral.800") : US6_US6_0();
    const v81: US5 = v1_1();
    const v89: US6 = ((v81.tag === US5_Tag.US5_1) && (v81.fields[0] === v0_1)) ? US6_US6_1("0") : US6_US6_0();
    const v90: US5 = v1_1();
    const v98: US6 = ((v90.tag === US5_Tag.US5_1) && (v90.fields[0] === v0_1)) ? US6_US6_1("0") : US6_US6_0();
    const v99: US5 = v1_1();
    const v107: US6 = ((v99.tag === US5_Tag.US5_1) && (v99.fields[0] === v0_1)) ? US6_US6_1("fixed") : US6_US6_0();
    const v108: US5 = v1_1();
    const v116: US6 = ((v108.tag === US5_Tag.US5_1) && (v108.fields[0] === v0_1)) ? US6_US6_1("0") : US6_US6_0();
    const v117: US5 = v1_1();
    const v125: US6 = ((v117.tag === US5_Tag.US5_1) && (v117.fields[0] === v0_1)) ? US6_US6_1("0") : US6_US6_0();
    const v126: US5 = v1_1();
    return [_arg[0], _arg[1], _arg[2], _arg[3], v80, _arg[5], _arg[6], _arg[7], _arg[8], v89, _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("1"), _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], v98, _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], v107, v116, _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], v125, _arg[64], _arg[65], _arg[66], _arg[67], ((v126.tag === US5_Tag.US5_1) && (v126.fields[0] === v0_1)) ? US5_US5_1(1) : US5_US5_0(), _arg[69]];
}

export function closure55(v0_1: () => US5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("1"), _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], (v0_1().tag === US5_Tag.US5_0) ? US6_US6_1("relative") : US6_US6_0(), _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure57(v0_1: int32, v1_1: () => US5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: US5 = v1_1();
    const v86: string = "6px";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], US6_US6_1("row"), (v72_1.tag === US5_Tag.US5_1) ? (((v72_1.fields[0] === v0_1) !== true) ? US6_US6_1("none") : US6_US6_0()) : US6_US6_0(), _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], US6_US6_1("absolute"), US6_US6_1(v86), _arg[56], US6_US6_1("3px"), _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], US6_US6_1(v86), _arg[64], _arg[65], _arg[66], _arg[67], US5_US5_1(2), _arg[69]];
}

export function closure61(v0_1: Mut7, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: any = v0_1.l0();
    return v0_1.l1([_arg[0], _arg[1], _arg[2], US7_US7_1(v72_1), _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("14px"), _arg[57], _arg[58], _arg[59], US14_US14_0(), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]]);
}

export function closure62(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method23(v0_1: Mut7): any {
    const v3: any = Icon;
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure61(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure62(void 0, void 0);
    return method5(v3, v4, v5);
}

export function closure60(unitVar: void, v0_1: Mut7): any {
    return method23(v0_1);
}

export function closure63(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularRefresh;
    return v2;
}

export function method24(v0_1: (arg0: Mut7) => any, v1_1: () => any, v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): any {
    const v3: Mut7 = new Mut7(v1_1, v2, v2);
    const v6: any = createComponent;
    return v6(v0_1, v3);
}

export function closure64(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure59(v0_1: (arg0: boolean) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v72_1: () => any = (): any => closure63(void 0, void 0);
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v82: () => void = (): void => {
        closure64(v0_1, void 0);
    };
    return [_arg[0], _arg[1], US6_US6_1("Refresh"), _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US6_US6_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("20px"), _arg[25], US11_US11_1(method24(v71, v72_1, v73_1)), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v82), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("xs"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure65(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure67(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularDownArrow;
    return v2;
}

export function closure68(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUpArrow;
    return v2;
}

export function closure69(v0_1: int32, v1_1: (arg0: US5) => void, v2: () => US5, unitVar: void): void {
    const v3: US5 = v2();
    v1_1((((v3.tag === US5_Tag.US5_1) && (v3.fields[0] === v0_1)) === false) ? US5_US5_1(v0_1) : US5_US5_0());
}

export function closure66(v0_1: int32, v1_1: (arg0: US5) => void, v2: () => US5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: US5 = v2();
    const v80: string = ((v73_1.tag === US5_Tag.US5_1) && (v73_1.fields[0] === v0_1)) ? "Restore" : "Maximize";
    const v81: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v82: US5 = v2();
    const v90: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_2);
    const v98: () => void = (): void => {
        closure69(v0_1, v1_1, v2, void 0);
    };
    return [_arg[0], _arg[1], US6_US6_1(v80), _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US6_US6_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("20px"), _arg[25], US11_US11_1(method24(v81, ((v82.tag === US5_Tag.US5_1) && (v82.fields[0] === v0_1)) ? ((): any => closure67(void 0, void 0)) : ((): any => closure68(void 0, void 0)), v90)), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v98), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("xs"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure70(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure72(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUndo;
    return v2;
}

export function closure73(v0_1: (arg0: boolean) => void, v1_1: Mut5, unitVar: void): void {
    const v2: US13 = v1_1.l3;
    if (v2.tag === US13_Tag.US13_1) {
        v2.fields[0]();
    }
    v0_1(false);
}

export function closure71(v0_1: (arg0: boolean) => void, v1_1: Mut5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v73_1: () => any = (): any => closure72(void 0, void 0);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v83: () => void = (): void => {
        closure73(v0_1, v1_1, void 0);
    };
    return [_arg[0], _arg[1], US6_US6_1("Unload"), _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US6_US6_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("20px"), _arg[25], US11_US11_1(method24(v72_1, v73_1, v74_1)), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v83), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("xs"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure74(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure58(v0_1: int32, v1_1: (arg0: US5) => void, v2: (arg0: boolean) => void, v3: (arg0: boolean) => void, v4: Mut5, v5: () => US5, unitVar: void): any[] {
    const v8: any = IconButton;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure59(v3, arg10$0040);
    const v10: () => any[] = (): any[] => closure65(void 0, void 0);
    const v12: any = IconButton;
    const v13: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure66(v0_1, v1_1, v5, arg10$0040_2);
    const v14: () => any[] = (): any[] => closure70(void 0, void 0);
    const v16: any = IconButton;
    const v17: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure71(v2, v4, arg10$0040_4);
    const v18: () => any[] = (): any[] => closure74(void 0, void 0);
    return [method5(v8, v9, v10), method5(v12, v13, v14), method5(v16, v17, v18)];
}

export function closure56(v0_1: int32, v1_1: (arg0: US5) => void, v2: () => US5, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: () => boolean, v6: Mut5, v7: () => any[], unitVar: void): any[] {
    const v10: any = Stack;
    const v11: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure57(v0_1, v2, arg10$0040);
    const v12: () => any[] = (): any[] => closure58(v0_1, v1_1, v3, v4, v6, v2, void 0);
    return [method5(v10, v11, v12), v5() ? (void 0) : v7];
}

export function closure54(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6, v70: int32, v71: (arg0: US5) => void, v72_1: () => US5, v73_1: (arg0: boolean) => void, v74_1: (arg0: boolean) => void, v75_1: () => boolean, v76_1: Mut5, unitVar: void): any[] {
    let v80: any, v81: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v82: () => any[];
    return [(v11.tag === US9_Tag.US9_1) ? ((v80 = Box, (v81 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure55(v72_1, arg10$0040)), (v82 = ((): any[] => closure56(v70, v71, v72_1, v73_1, v74_1, v75_1, v76_1, v11.fields[0], void 0)), method5(v80, v81, v82))))) : (void 0)];
}

export function closure44(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US6, v16: US6, v17: US6, v18: US10, v19: US8, v20: US6, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US11, v27: US6, v28: US6, v29: US6, v30: US11, v31: US6, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US12, v42: US13, v43: US12, v44: US6, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US14, v61: US6, v62: US11, v63: US6, v64: US6, v65: US14, v66: US14, v67: US6, v68: US5, v69: US6, v70: int32, v71: (arg0: US5) => void, v72_1: () => US5, v73_1: (arg0: boolean) => void, v74_1: () => boolean, v75_1: (arg0: boolean) => void, v76_1: () => boolean, v77_1: Mut5, unitVar: void): any[] {
    let v82: any, v83: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v84: () => any[], v88: any, v89: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v90: () => any[];
    return [(v74_1() === false) ? ((v82 = Box, (v83 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure45(void 0, arg10$0040)), (v84 = ((): any[] => closure46(v73_1, v77_1, void 0)), method5(v82, v83, v84))))) : ((v88 = Box, (v89 = ((arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure53(v70, v72_1, arg10$0040_2)), (v90 = ((): any[] => closure54(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v73_1, v75_1, v76_1, v77_1, void 0)), method5(v88, v89, v90)))))];
}

export function method15(v0_1: Mut5): any {
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v0_1.l4;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = method6();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v99: US6 = patternInput_1[27];
    const v98: US11 = patternInput_1[26];
    const v97: US6 = patternInput_1[25];
    const v96: US6 = patternInput_1[24];
    const v95: US6 = patternInput_1[23];
    const v94: US6 = patternInput_1[22];
    const v93: US6 = patternInput_1[21];
    const v92: US6 = patternInput_1[20];
    const v91: US8 = patternInput_1[19];
    const v90: US10 = patternInput_1[18];
    const v89: US6 = patternInput_1[17];
    const v88: US6 = patternInput_1[16];
    const v87: US6 = patternInput_1[15];
    const v86: US8 = patternInput_1[14];
    const v85: US6 = patternInput_1[13];
    const v84: US6 = patternInput_1[12];
    const v83: US9 = patternInput_1[11];
    const v82: US8 = patternInput_1[10];
    const v81: US6 = patternInput_1[9];
    const v80: US6 = patternInput_1[8];
    const v79: US6 = patternInput_1[7];
    const v78: US6 = patternInput_1[6];
    const v77_1: US6 = patternInput_1[5];
    const v76_1: US6 = patternInput_1[4];
    const v75_1: US7 = patternInput_1[3];
    const v74_1: US6 = patternInput_1[2];
    const v73_1: US6 = patternInput_1[1];
    const v72_1: US6 = patternInput_1[0];
    const v141: US6 = patternInput_1[69];
    const v140: US5 = patternInput_1[68];
    const v139: US6 = patternInput_1[67];
    const v138: US14 = patternInput_1[66];
    const v137: US14 = patternInput_1[65];
    const v136: US6 = patternInput_1[64];
    const v135: US6 = patternInput_1[63];
    const v134: US11 = patternInput_1[62];
    const v133: US6 = patternInput_1[61];
    const v132: US14 = patternInput_1[60];
    const v131: US6 = patternInput_1[59];
    const v130: US6 = patternInput_1[58];
    const v129: US6 = patternInput_1[57];
    const v128: US6 = patternInput_1[56];
    const v127: US6 = patternInput_1[55];
    const v126: US6 = patternInput_1[54];
    const v125: US6 = patternInput_1[53];
    const v124: US6 = patternInput_1[52];
    const v123: US6 = patternInput_1[51];
    const v122: US6 = patternInput_1[50];
    const v121: US6 = patternInput_1[49];
    const v120: US6 = patternInput_1[48];
    const v119: US6 = patternInput_1[47];
    const v118: US6 = patternInput_1[46];
    const v117: US6 = patternInput_1[45];
    const v116: US6 = patternInput_1[44];
    const v115: US12 = patternInput_1[43];
    const v114: US13 = patternInput_1[42];
    const v113: US12 = patternInput_1[41];
    const v112: US6 = patternInput_1[40];
    const v111: US6 = patternInput_1[39];
    const v110: US6 = patternInput_1[38];
    const v109: US6 = patternInput_1[37];
    const v108: US6 = patternInput_1[36];
    const v107: US6 = patternInput_1[35];
    const v106: US6 = patternInput_1[34];
    const v105: US6 = patternInput_1[33];
    const v104: US6 = patternInput_1[32];
    const v103: US6 = patternInput_1[31];
    const v102: US11 = patternInput_1[30];
    const v101: US6 = patternInput_1[29];
    const v100: US6 = patternInput_1[28];
    let v150: US9;
    if (v83.tag === US9_Tag.US9_1) {
        const v145: any = children_1;
        v150 = US9_US9_1(v145(v83.fields[0]));
    }
    else {
        v150 = US9_US9_0();
    }
    const v151: int32 = nonSeeded().Next0() | 0;
    const v247: any = components.state_context;
    const v250: any = useContext;
    const patternInput_2: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v250(v247);
    const v368: any = components.state_context;
    const v369: any = useContext;
    const patternInput_3: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v369(v368);
    const v487: any = components.state_context;
    const v488: any = useContext;
    const patternInput_4: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v488(v487);
    const v510: (arg0: US5) => void = patternInput_4[21];
    const v509: () => US5 = patternInput_4[20];
    const v511: () => any[] = (): any[] => closure37(v151, patternInput_2[4], patternInput_3[18], v509, void 0);
    method16(v511, "#de884c")(US4_US4_0())(["> loader ()"]);
    const patternInput_5: [() => boolean, (arg0: boolean) => void] = method12(v0_1.l0);
    const patternInput_6: [() => boolean, (arg0: boolean) => void] = method12(false);
    const v524: (arg0: boolean) => void = patternInput_6[1];
    const v523: () => boolean = patternInput_6[0];
    const v526: any = createEffect;
    const v527: () => void = (): void => {
        closure40(v0_1, v151, v510, void 0);
    };
    v526(v527);
    const v528: any = createEffect;
    const v529: () => void = (): void => {
        closure41(v524, v523, void 0);
    };
    v528(v529);
    const v531: any = onCleanup;
    const v532: () => void = (): void => {
        closure42(v0_1, void 0);
    };
    v531(v532);
    if (v0_1.l0) {
        const v534: US13 = v0_1.l2;
        if (v534.tag === US13_Tag.US13_1) {
            v534.fields[0]();
        }
    }
    const v538: any = Box;
    const v539: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure43(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, arg10$0040_4);
    const v540: () => any[] = (): any[] => closure44(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v151, v510, v509, patternInput_5[1], patternInput_5[0], v524, v523, v0_1, void 0);
    return method5(v538, v539, v540);
}

export function closure36(unitVar: void, v0_1: Mut5): any {
    return method15(v0_1);
}

export function closure75(v0_1: () => any[], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v0_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method25(v0_1: (arg0: Mut5) => any, v1_1: boolean, v2: boolean, v3: US13, v4: US13, v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): any {
    const v6: Mut5 = new Mut5(v1_1, v2, v3, v4, v5);
    const v9: any = createComponent;
    return v9(v0_1, v6);
}

export function closure35(v0_1: Mut3, v1_1: () => boolean, v2: () => any[], unitVar: void): any[] {
    let v6: (arg0: Mut5) => any, v11: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    return [(v0_1.l3.tag === US15_Tag.US15_2) ? v2 : (v1_1() ? ((v6 = ((v: Mut5): any => closure36(void 0, v)), (v11 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure75(v2, arg10$0040)), method25(v6, true, false, v0_1.l0, v0_1.l1, v11)))) : (void 0))];
}

export function closure16(v0_1: Mut3, v1_1: US6, v2: US6, v3: US6, v4: US7, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US6, v11: US8, v12: US9, v13: US6, v14: US6, v15: US8, v16: US6, v17: US6, v18: US6, v19: US10, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US11, v28: US6, v29: US6, v30: US6, v31: US11, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US12, v43: US13, v44: US12, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US14, v62: US6, v63: US11, v64: US6, v65: US6, v66: US14, v67: US14, v68: US6, v69: US5, v70: US6, v71: (arg0: boolean) => void, v72_1: () => boolean, unitVar: void): any[] {
    let v76_1: any, v81: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v82: () => any[], v90: any, v95: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v96: () => any[], v100: any, v105: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v106: () => any[];
    return [(v63.tag === US11_Tag.US11_1) ? ((v76_1 = hope, (v81 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure17(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v72_1, arg10$0040)), (v82 = ((): any[] => closure18(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v63.fields[0], void 0)), method5(v76_1.td, v81, v82))))) : (void 0), (v12.tag === US9_Tag.US9_1) ? ((v90 = hope, (v95 = ((arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure34(v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, arg10$0040_4)), (v96 = ((): any[] => closure35(v0_1, v72_1, v12.fields[0], void 0)), method5(v90.td, v95, v96))))) : ((v100 = hope, (v105 = ((arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure32(void 0, arg10$0040_2)), (v106 = ((): any[] => closure33(void 0, void 0)), method5(v100.td, v105, v106)))))];
}

export function method11(v0_1: Mut3): any {
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v0_1.l2;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = method6();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v99: US6 = patternInput_1[27];
    const v98: US11 = patternInput_1[26];
    const v97: US6 = patternInput_1[25];
    const v96: US6 = patternInput_1[24];
    const v95: US6 = patternInput_1[23];
    const v94: US6 = patternInput_1[22];
    const v93: US6 = patternInput_1[21];
    const v92: US6 = patternInput_1[20];
    const v91: US8 = patternInput_1[19];
    const v90: US10 = patternInput_1[18];
    const v89: US6 = patternInput_1[17];
    const v88: US6 = patternInput_1[16];
    const v87: US6 = patternInput_1[15];
    const v86: US8 = patternInput_1[14];
    const v85: US6 = patternInput_1[13];
    const v84: US6 = patternInput_1[12];
    const v83: US9 = patternInput_1[11];
    const v82: US8 = patternInput_1[10];
    const v81: US6 = patternInput_1[9];
    const v80: US6 = patternInput_1[8];
    const v79: US6 = patternInput_1[7];
    const v78: US6 = patternInput_1[6];
    const v77_1: US6 = patternInput_1[5];
    const v76_1: US6 = patternInput_1[4];
    const v75_1: US7 = patternInput_1[3];
    const v74_1: US6 = patternInput_1[2];
    const v73_1: US6 = patternInput_1[1];
    const v72_1: US6 = patternInput_1[0];
    const v141: US6 = patternInput_1[69];
    const v140: US5 = patternInput_1[68];
    const v139: US6 = patternInput_1[67];
    const v138: US14 = patternInput_1[66];
    const v137: US14 = patternInput_1[65];
    const v136: US6 = patternInput_1[64];
    const v135: US6 = patternInput_1[63];
    const v134: US11 = patternInput_1[62];
    const v133: US6 = patternInput_1[61];
    const v132: US14 = patternInput_1[60];
    const v131: US6 = patternInput_1[59];
    const v130: US6 = patternInput_1[58];
    const v129: US6 = patternInput_1[57];
    const v128: US6 = patternInput_1[56];
    const v127: US6 = patternInput_1[55];
    const v126: US6 = patternInput_1[54];
    const v125: US6 = patternInput_1[53];
    const v124: US6 = patternInput_1[52];
    const v123: US6 = patternInput_1[51];
    const v122: US6 = patternInput_1[50];
    const v121: US6 = patternInput_1[49];
    const v120: US6 = patternInput_1[48];
    const v119: US6 = patternInput_1[47];
    const v118: US6 = patternInput_1[46];
    const v117: US6 = patternInput_1[45];
    const v116: US6 = patternInput_1[44];
    const v115: US12 = patternInput_1[43];
    const v114: US13 = patternInput_1[42];
    const v113: US12 = patternInput_1[41];
    const v112: US6 = patternInput_1[40];
    const v111: US6 = patternInput_1[39];
    const v110: US6 = patternInput_1[38];
    const v109: US6 = patternInput_1[37];
    const v108: US6 = patternInput_1[36];
    const v107: US6 = patternInput_1[35];
    const v106: US6 = patternInput_1[34];
    const v105: US6 = patternInput_1[33];
    const v104: US6 = patternInput_1[32];
    const v103: US6 = patternInput_1[31];
    const v102: US11 = patternInput_1[30];
    const v101: US6 = patternInput_1[29];
    const v100: US6 = patternInput_1[28];
    let v150: US9;
    if (v83.tag === US9_Tag.US9_1) {
        const v145: any = children_1;
        v150 = US9_US9_1(v145(v83.fields[0]));
    }
    else {
        v150 = US9_US9_0();
    }
    const patternInput_2: [() => boolean, (arg0: boolean) => void] = method12((v0_1.l3.tag === US15_Tag.US15_0) !== true);
    const v159: any = hope;
    const v164: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure15(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, arg10$0040);
    const v165: () => any[] = (): any[] => closure16(v0_1, v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, patternInput_2[1], patternInput_2[0], void 0);
    return method5(v159.tr, v164, v165);
}

export function closure14(unitVar: void, v0_1: Mut3): any {
    return method11(v0_1);
}

export function closure80(v0_1: () => US4, unitVar: void): any[] {
    const v1_1: US4 = v0_1();
    return [<>
        {(v1_1.tag === US4_Tag.US4_0) ? "Debug" : ((v1_1.tag === US4_Tag.US4_1) ? "Error" : ((v1_1.tag === US4_Tag.US4_2) ? "Info" : ((v1_1.tag === US4_Tag.US4_4) ? "Warn" : "Error")))}
    </>];
}

export function closure79(v0_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure80(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Log Level
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method26(v0_1: (arg0: Mut3) => any, v1_1: US13, v2: US13, v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v4: US15): any {
    const v5: Mut3 = new Mut3(v1_1, v2, v3, v4);
    const v8: any = createComponent;
    return v8(v0_1, v5);
}

export function closure83(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure88(v0_1: Mut8, v1_1: () => string, unitVar: void): any[] {
    const v2: string = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure87(v0_1: Mut8, v1_1: () => string, unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure88(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure86(v0_1: Mut8, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure87(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method27(v0_1: Mut8): any {
    const patternInput: [() => string, (arg0: string) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure86(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure85(unitVar: void, v0_1: Mut8): any {
    return method27(v0_1);
}

export function closure89(unitVar: void, v0_1: string): any {
    return v0_1;
}

export function closure90(unitVar: void, unitVar_1: void): [() => string, (arg0: string) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[4], patternInput[5]];
}

export function method28(v0_1: (arg0: Mut8) => any, v1_1: (arg0: string) => any, v2: () => [() => string, (arg0: string) => void], v3: string): any {
    const v4: Mut8 = new Mut8(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure91(unitVar: void, unitVar_1: void): [() => string, (arg0: string) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[6], patternInput[7]];
}

export function closure95(v0_1: Mut9, v1_1: () => int32, unitVar: void): any[] {
    const v2: int32 = v1_1() | 0;
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure94(v0_1: Mut9, v1_1: () => int32, unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure95(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure93(v0_1: Mut9, v1_1: () => int32, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure94(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method29(v0_1: Mut9): any {
    const patternInput: [() => int32, (arg0: int32) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure93(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure92(unitVar: void, v0_1: Mut9): any {
    return method29(v0_1);
}

export function closure96(unitVar: void, v0_1: int32): any {
    return v0_1;
}

export function closure97(unitVar: void, unitVar_1: void): [() => int32, (arg0: int32) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[2], patternInput[3]];
}

export function method30(v0_1: (arg0: Mut9) => any, v1_1: (arg0: int32) => any, v2: () => [() => int32, (arg0: int32) => void], v3: string): any {
    const v4: Mut9 = new Mut9(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure101(v0_1: Mut10, v1_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], unitVar: void): any[] {
    const v2: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure100(v0_1: Mut10, v1_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure101(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure99(v0_1: Mut10, v1_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure100(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method31(v0_1: Mut10): any {
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure99(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure98(unitVar: void, v0_1: Mut10): any {
    return method31(v0_1);
}

export function closure102(unitVar: void, v0_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): any {
    const v1_1: int32 = v0_1.length | 0;
    const v2: [US0, string, string, string][] = fill(new Array(v1_1), 0, v1_1, null);
    const v3: Mut6 = new Mut6(0);
    while (method21(v1_1, v3)) {
        const v5: int32 = v3.l0 | 0;
        const patternInput: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void] = v0_1[v5];
        const v14: US0 = patternInput[0]();
        const v15: string = patternInput[6]();
        const v16: string = patternInput[2]();
        const v17: string = patternInput[4]();
        v2[v5] = [v14, v16, v17, v15];
        const v18: int32 = (v5 + 1) | 0;
        v3.l0 = (v18 | 0);
    }
    return v2;
}

export function closure103(unitVar: void, unitVar_1: void): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[0], patternInput[1]];
}

export function method32(v0_1: (arg0: Mut10) => any, v1_1: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => any, v2: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void], v3: string): any {
    const v4: Mut10 = new Mut10(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure107(v0_1: Mut11, v1_1: () => [US2, any, string][], unitVar: void): any[] {
    const v2: [US2, any, string][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure106(v0_1: Mut11, v1_1: () => [US2, any, string][], unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure107(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure105(v0_1: Mut11, v1_1: () => [US2, any, string][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure106(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method33(v0_1: Mut11): any {
    const patternInput: [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure105(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure104(unitVar: void, v0_1: Mut11): any {
    return method33(v0_1);
}

export function closure108(unitVar: void, v0_1: [US2, any, string][]): any {
    return v0_1;
}

export function closure109(unitVar: void, unitVar_1: void): [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[10], patternInput[11]];
}

export function method34(v0_1: (arg0: Mut11) => any, v1_1: (arg0: [US2, any, string][]) => any, v2: () => [() => [US2, any, string][], (arg0: [US2, any, string][]) => void], v3: string): any {
    const v4: Mut11 = new Mut11(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure113(v0_1: Mut12, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure112(v0_1: Mut12, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure113(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure111(v0_1: Mut12, v1_1: () => [US2[], int32, US3, string, string][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure112(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method35(v0_1: Mut12): any {
    const patternInput: [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure111(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure110(unitVar: void, v0_1: Mut12): any {
    return method35(v0_1);
}

export function closure114(unitVar: void, v0_1: [US2[], int32, US3, string, string][]): any {
    return v0_1;
}

export function closure115(unitVar: void, unitVar_1: void): [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[8], patternInput[9]];
}

export function method36(v0_1: (arg0: Mut12) => any, v1_1: (arg0: [US2[], int32, US3, string, string][]) => any, v2: () => [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void], v3: string): any {
    const v4: Mut12 = new Mut12(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure119(v0_1: Mut13, v1_1: () => US4, unitVar: void): any[] {
    const v2: US4 = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure118(v0_1: Mut13, v1_1: () => US4, unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure119(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure117(v0_1: Mut13, v1_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure118(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method37(v0_1: Mut13): any {
    const patternInput: [() => US4, (arg0: US4) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure117(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure116(unitVar: void, v0_1: Mut13): any {
    return method37(v0_1);
}

export function closure120(unitVar: void, v0_1: US4): any {
    return (v0_1.tag === US4_Tag.US4_0) ? "Debug" : ((v0_1.tag === US4_Tag.US4_1) ? "Error" : ((v0_1.tag === US4_Tag.US4_2) ? "Info" : ((v0_1.tag === US4_Tag.US4_4) ? "Warn" : "Error")));
}

export function closure121(unitVar: void, unitVar_1: void): [() => US4, (arg0: US4) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[18], patternInput[19]];
}

export function method38(v0_1: (arg0: Mut13) => any, v1_1: (arg0: US4) => any, v2: () => [() => US4, (arg0: US4) => void], v3: string): any {
    const v4: Mut13 = new Mut13(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure125(v0_1: Mut14, v1_1: () => US5, unitVar: void): any[] {
    const v2: US5 = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure124(v0_1: Mut14, v1_1: () => US5, unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure125(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure123(v0_1: Mut14, v1_1: () => US5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure124(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method39(v0_1: Mut14): any {
    const patternInput: [() => US5, (arg0: US5) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure123(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure122(unitVar: void, v0_1: Mut14): any {
    return method39(v0_1);
}

export function closure126(unitVar: void, v0_1: US5): any {
    return v0_1;
}

export function closure127(unitVar: void, unitVar_1: void): [() => US5, (arg0: US5) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[20], patternInput[21]];
}

export function method40(v0_1: (arg0: Mut14) => any, v1_1: (arg0: US5) => any, v2: () => [() => US5, (arg0: US5) => void], v3: string): any {
    const v4: Mut14 = new Mut14(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure131(v0_1: Mut15, v1_1: () => [string, int32][], unitVar: void): any[] {
    const v2: [string, int32][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure130(v0_1: Mut15, v1_1: () => [string, int32][], unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure131(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure129(v0_1: Mut15, v1_1: () => [string, int32][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure130(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method41(v0_1: Mut15): any {
    const patternInput: [() => [string, int32][], (arg0: [string, int32][]) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure129(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure128(unitVar: void, v0_1: Mut15): any {
    return method41(v0_1);
}

export function closure132(unitVar: void, v0_1: [string, int32][]): any {
    return v0_1;
}

export function closure133(unitVar: void, unitVar_1: void): [() => [string, int32][], (arg0: [string, int32][]) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[16], patternInput[17]];
}

export function method42(v0_1: (arg0: Mut15) => any, v1_1: (arg0: [string, int32][]) => any, v2: () => [() => [string, int32][], (arg0: [string, int32][]) => void], v3: string): any {
    const v4: Mut15 = new Mut15(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure137(v0_1: Mut16, v1_1: () => [string, any][], unitVar: void): any[] {
    const v2: [string, any][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure136(v0_1: Mut16, v1_1: () => [string, any][], unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure137(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure135(v0_1: Mut16, v1_1: () => [string, any][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure136(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], US6_US6_1("8px"), _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method43(v0_1: Mut16): any {
    const patternInput: [() => [string, any][], (arg0: [string, any][]) => void] = v0_1.l1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure135(v0_1, patternInput[0], arg10$0040);
    return method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2());
}

export function closure134(unitVar: void, v0_1: Mut16): any {
    return method43(v0_1);
}

export function closure138(unitVar: void, v0_1: [string, any][]): any {
    return v0_1;
}

export function closure139(unitVar: void, unitVar_1: void): [() => [string, any][], (arg0: [string, any][]) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[14], patternInput[15]];
}

export function method44(v0_1: (arg0: Mut16) => any, v1_1: (arg0: [string, any][]) => any, v2: () => [() => [string, any][], (arg0: [string, any][]) => void], v3: string): any {
    const v4: Mut16 = new Mut16(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure140(unitVar: void, unitVar_1: void): [() => [string, any][], (arg0: [string, any][]) => void] {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    return [patternInput[12], patternInput[13]];
}

export function closure84(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut8) => any = (v: Mut8): any => closure85(void 0, v);
    const v1_1: (arg0: string) => any = (v_1: string): any => closure89(void 0, v_1);
    const v2: () => [() => string, (arg0: string) => void] = (): [() => string, (arg0: string) => void] => closure90(void 0, void 0);
    const v5: () => [() => string, (arg0: string) => void] = (): [() => string, (arg0: string) => void] => closure91(void 0, void 0);
    const v8: (arg0: Mut9) => any = (v_2: Mut9): any => closure92(void 0, v_2);
    const v9: (arg0: int32) => any = (v_3: int32): any => closure96(void 0, v_3);
    const v10: () => [() => int32, (arg0: int32) => void] = (): [() => int32, (arg0: int32) => void] => closure97(void 0, void 0);
    const v13: (arg0: Mut10) => any = (v_4: Mut10): any => closure98(void 0, v_4);
    const v14: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => any = (v_5: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): any => closure102(void 0, v_5);
    const v15: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] = (): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] => closure103(void 0, void 0);
    const v18: (arg0: Mut11) => any = (v_6: Mut11): any => closure104(void 0, v_6);
    const v19: (arg0: [US2, any, string][]) => any = (v_7: [US2, any, string][]): any => closure108(void 0, v_7);
    const v20: () => [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] = (): [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] => closure109(void 0, void 0);
    const v23: (arg0: Mut12) => any = (v_8: Mut12): any => closure110(void 0, v_8);
    const v24: (arg0: [US2[], int32, US3, string, string][]) => any = (v_9: [US2[], int32, US3, string, string][]): any => closure114(void 0, v_9);
    const v25: () => [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] = (): [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] => closure115(void 0, void 0);
    const v28: (arg0: Mut13) => any = (v_10: Mut13): any => closure116(void 0, v_10);
    const v29: (arg0: US4) => any = (v_11: US4): any => closure120(void 0, v_11);
    const v30: () => [() => US4, (arg0: US4) => void] = (): [() => US4, (arg0: US4) => void] => closure121(void 0, void 0);
    const v33: (arg0: Mut14) => any = (v_12: Mut14): any => closure122(void 0, v_12);
    const v34: (arg0: US5) => any = (v_13: US5): any => closure126(void 0, v_13);
    const v35: () => [() => US5, (arg0: US5) => void] = (): [() => US5, (arg0: US5) => void] => closure127(void 0, void 0);
    const v38: (arg0: Mut15) => any = (v_14: Mut15): any => closure128(void 0, v_14);
    const v39: (arg0: [string, int32][]) => any = (v_15: [string, int32][]): any => closure132(void 0, v_15);
    const v40: () => [() => [string, int32][], (arg0: [string, int32][]) => void] = (): [() => [string, int32][], (arg0: [string, int32][]) => void] => closure133(void 0, void 0);
    const v43: (arg0: Mut16) => any = (v_16: Mut16): any => closure134(void 0, v_16);
    const v44: (arg0: [string, any][]) => any = (v_17: [string, any][]): any => closure138(void 0, v_17);
    const v45: () => [() => [string, any][], (arg0: [string, any][]) => void] = (): [() => [string, any][], (arg0: [string, any][]) => void] => closure139(void 0, void 0);
    const v48: () => [() => [string, any][], (arg0: [string, any][]) => void] = (): [() => [string, any][], (arg0: [string, any][]) => void] => closure140(void 0, void 0);
    return [method28(v0_1, v1_1, v2, "chain.token"), method28(v0_1, v1_1, v5, "chain.url"), method30(v8, v9, v10, "chain.port"), method32(v13, v14, v15, "chain.accounts"), method34(v18, v19, v20, "db.connections"), method36(v23, v24, v25, "db.connection_options"), method38(v28, v29, v30, "settings.log_level"), method40(v33, v34, v35, "settings.ui.modal"), method42(v38, v39, v40, "profile.tmp.counter"), method44(v43, v44, v45, "profile.tmp.chain_status"), method44(v43, v44, v48, "profile.tmp.chain_deploy")];
}

export function closure82(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure83(void 0, arg10$0040);
    const v8: () => any[] = (): any[] => closure84(void 0, void 0);
    return [method5(v2.pre, v7, v8)];
}

export function closure81(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure82(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("flex-start"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        State
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure78(v0_1: () => US4, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure79(v0_1, arg10$0040);
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure81(void 0, arg10$0040_1);
    return [method26(v1_1, US13_US13_0(), US13_US13_0(), v4, US15_US15_2()), method26(v1_1, US13_US13_0(), US13_US13_0(), v9, US15_US15_2())];
}

export function closure77(v0_1: () => US4, unitVar: void): any[] {
    const v1_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure78(v0_1, void 0);
    return [method22(v1_1, v2, v3)];
}

export function closure76(v0_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure77(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("flex-start"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("15px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Debug
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure13(v0_1: () => US4, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure76(v0_1, arg10$0040);
    return [method26(v1_1, US13_US13_0(), US13_US13_0(), v4, US15_US15_0())];
}

export function closure6(v0_1: () => US4, unitVar: void): any[] {
    const v1_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure13(v0_1, void 0);
    return [method22(v1_1, v2, v3)];
}

export function method3(): any {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    const v123: any = Box;
    const v124: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure5(void 0, arg10$0040);
    const v125: () => any[] = (): any[] => closure6(patternInput[18], void 0);
    return method5(v123, v124, v125);
}

export function closure4(unitVar: void, v0_1: Mut2): any {
    return method3();
}

export function method45(v0_1: (arg0: Mut2) => any): any {
    const v1_1: Mut2 = Mut2_$ctor();
    const v4: any = createComponent;
    return v4(v0_1, v1_1);
}

export function closure141(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US6_US6_1("flex"), _arg[18], _arg[19], US6_US6_1("1"), US6_US6_1("column"), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], US6_US6_1("hidden"), US6_US6_1("auto"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure151(v0_1: Mut1, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67, v0_1.l68, v0_1.l69];
    const v143: Mut1 = new Mut1(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], US8_US8_1(true), _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]);
    method20(v143, new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = [v143.l0, v143.l1, v143.l2, v143.l3, v143.l4, v143.l5, v143.l6, v143.l7, v143.l8, v143.l9, v143.l10, v143.l11, v143.l12, v143.l13, v143.l14, v143.l15, v143.l16, v143.l17, v143.l18, v143.l19, v143.l20, v143.l21, v143.l22, v143.l23, v143.l24, v143.l25, v143.l26, v143.l27, v143.l28, v143.l29, v143.l30, v143.l31, v143.l32, v143.l33, v143.l34, v143.l35, v143.l36, v143.l37, v143.l38, v143.l39, v143.l40, v143.l41, v143.l42, v143.l43, v143.l44, v143.l45, v143.l46, v143.l47, v143.l48, v143.l49, v143.l50, v143.l51, v143.l52, v143.l53, v143.l54, v143.l55, v143.l56, v143.l57, v143.l58, v143.l59, v143.l60, v143.l61, v143.l62, v143.l63, v143.l64, v143.l65, v143.l66, v143.l67, v143.l68, v143.l69];
    return [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]];
}

export function closure152(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: US6 = v0_1.l25;
    return [<>
        {(v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : ""}
    </>];
}

export function closure153(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularLinkExternal;
    return v2;
}

export function closure154(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_0(), _arg[35], US6_US6_1("-13px"), _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method48(v0_1: (arg0: Mut7) => any, v1_1: () => any, v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): any {
    const v4: Mut7 = new Mut7(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure150(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = Anchor;
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure151(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure152(v0_1, void 0);
    const v10: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v11: () => any = (): any => closure153(void 0, void 0);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_3);
    const v13: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure154(void 0, arg10$0040_4);
    return [method5(v3, v4, v5), <>
        &nbsp;
    </>, method48(v10, v11, v12, v13)];
}

export function method47(v0_1: Mut1): any {
    const v3: any = Box;
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v5: () => any[] = (): any[] => closure150(v0_1, void 0);
    return method5(v3, v4, v5);
}

export function closure149(unitVar: void, v0_1: Mut1): any {
    return method47(v0_1);
}

export function closure155(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], US6_US6_1("https://github.com/fc1943s/tictactoe"), _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure156(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure148(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure149(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure155(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure156(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure147(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure148(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("1px 6px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure159(v0_1: string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], US6_US6_1(v0_1), _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure158(v0_1: string, unitVar: void): any[] {
    const v1_1: (arg0: Mut1) => any = (v: Mut1): any => closure149(void 0, v);
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure159(v0_1, arg10$0040);
    const v3: () => any[] = (): any[] => closure156(void 0, void 0);
    return [method22(v1_1, v2, v3)];
}

export function closure157(v0_1: string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: () => any[] = (): any[] => closure158(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v71), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("1px 6px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure162(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], US6_US6_1("https://fc1943s.github.io/tictactoe"), _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure161(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure149(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure162(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure156(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure160(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure161(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("1px 6px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure165(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], US6_US6_1("https://fc1943s.github.io/tictactoe/docs"), _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure164(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure149(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure165(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure156(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure163(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure164(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("1px 6px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure146(v0_1: string, unitVar: void): any[] {
    let v2: (arg0: Mut3) => any, v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6], v9: (arg0: Mut3) => any, v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6];
    const v16: (arg0: Mut3) => any = (v_2: Mut3): any => closure14(void 0, v_2);
    const v19: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure160(void 0, arg10$0040_2);
    const v24: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure163(void 0, arg10$0040_3);
    return [("" === v0_1) ? ((v2 = ((v: Mut3): any => closure14(void 0, v)), (v5 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure147(void 0, arg10$0040)), method26(v2, US13_US13_0(), US13_US13_0(), v5, US15_US15_2())))) : ((v9 = ((v_1: Mut3): any => closure14(void 0, v_1)), (v12 = ((arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure157(`https://github.com/fc1943s/tictactoe/tree/${v0_1}`, arg10$0040_1)), method26(v9, US13_US13_0(), US13_US13_0(), v12, US15_US15_2())))), method26(v16, US13_US13_0(), US13_US13_0(), v19, US15_US15_2()), method26(v16, US13_US13_0(), US13_US13_0(), v24, US15_US15_2())];
}

export function method46(): any {
    const patternInput: [string, any, string, string, boolean] = method2();
    const v5: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v7: () => any[] = (): any[] => closure146(patternInput[3], void 0);
    return method22(v5, v6, v7);
}

export function closure145(unitVar: void, v0_1: Mut1): any {
    return method46();
}

export function closure166(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure144(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure145(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure166(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure143(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure144(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Links
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure173(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure176(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], US6_US6_1("row"), _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], US6_US6_1("4"), _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure179(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US6_US6_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("sm"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], US6_US6_1("radio"), US14_US14_1("dark"), _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure180(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Dark
    </>];
}

export function closure178(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure179(void 0, arg10$0040);
    const v8: () => any[] = (): any[] => closure26(void 0, void 0);
    const v13: () => any[] = (): any[] => closure180(void 0, void 0);
    return [method5(v2.input, v7, v8), <>
        &nbsp;
    </>, v13];
}

export function closure182(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US6_US6_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("sm"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], US6_US6_1("radio"), US14_US14_1("light"), _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure183(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Light
    </>];
}

export function closure181(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure182(void 0, arg10$0040);
    const v8: () => any[] = (): any[] => closure26(void 0, void 0);
    const v13: () => any[] = (): any[] => closure183(void 0, void 0);
    return [method5(v2.input, v7, v8), <>
        &nbsp;
    </>, v13];
}

export function closure177(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Box;
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure22(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure178(void 0, void 0);
    const v6: any = Box;
    const v7: () => any[] = (): any[] => closure181(void 0, void 0);
    return [method5(v2, v3, v4), method5(v6, v3, v7)];
}

export function closure175(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Stack;
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure176(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure177(void 0, void 0);
    return [method5(v2, v3, v4)];
}

export function closure174(unitVar: void, unitVar_1: void): any[] {
    const v0_1: () => any[] = (): any[] => closure175(void 0, void 0);
    return [v0_1];
}

export function closure172(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Box;
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure173(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure174(void 0, void 0);
    return [method5(v2, v3, v4)];
}

export function closure171(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure172(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("5px 6px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Theme
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure170(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure171(void 0, arg10$0040);
    return [method26(v0_1, US13_US13_0(), US13_US13_0(), v3, US15_US15_2())];
}

export function method49(): any {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure170(void 0, void 0);
    return method22(v0_1, v1_1, v2);
}

export function closure169(unitVar: void, v0_1: Mut1): any {
    return method49();
}

export function closure184(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure168(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure169(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure184(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure167(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure168(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Settings
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure197(v0_1: Mut17, v1_1: any): void {
    const v3: any = v1_1.currentTarget;
    const v6: string = v3.value;
    v0_1.l1(US6_US6_1(v6));
}

export function closure196(v0_1: Mut17, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: US6 = v0_1.l0();
    const v73_1: string = void 0;
    const v80: (arg0: any) => void = (v: any): void => {
        closure197(v0_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], US6_US6_1("15vw"), _arg[41], _arg[42], US12_US12_1(v80), _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("xs"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], US6_US6_1("text"), US14_US14_1((v72_1.tag === US6_Tag.US6_1) ? v72_1.fields[0] : v73_1), _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure198(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method52(v0_1: Mut17): any {
    const v3: any = Input;
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure196(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure198(void 0, void 0);
    return method5(v3, v4, v5);
}

export function closure195(unitVar: void, v0_1: Mut17): any {
    return method52(v0_1);
}

export function closure199(v0_1: () => string, unitVar: void): US6 {
    return US6_US6_1(v0_1());
}

export function closure200(v0_1: (arg0: string) => void, v1_1: US6): void {
    v0_1((v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function method53(v0_1: (arg0: Mut17) => any, v1_1: () => US6, v2: (arg0: US6) => void): any {
    const v3: Mut17 = new Mut17(v1_1, v2);
    const v6: any = createComponent;
    return v6(v0_1, v3);
}

export function closure194(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: (arg0: Mut17) => any = (v: Mut17): any => closure195(void 0, v);
    const v3: () => US6 = (): US6 => closure199(v1_1, void 0);
    const v4: (arg0: US6) => void = (v_1: US6): void => {
        closure200(v0_1, v_1);
    };
    return [method53(v2, v3, v4)];
}

export function closure193(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure194(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Token
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure202(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: (arg0: Mut17) => any = (v: Mut17): any => closure195(void 0, v);
    const v3: () => US6 = (): US6 => closure199(v1_1, void 0);
    const v4: (arg0: US6) => void = (v_1: US6): void => {
        closure200(v0_1, v_1);
    };
    return [method53(v2, v3, v4)];
}

export function closure201(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure202(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        URL
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure207(v0_1: Mut18, v1_1: any): void {
    const v3: any = v1_1.currentTarget;
    const v6: int32 = v3.value | 0;
    v0_1.l1(US5_US5_1(v6));
}

export function closure206(v0_1: Mut18, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v72_1: US5 = v0_1.l0();
    const v73_1: int32 = (void 0) | 0;
    const v80: (arg0: any) => void = (v: any): void => {
        closure207(v0_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], US6_US6_1("15vw"), _arg[41], _arg[42], US12_US12_1(v80), _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US6_US6_1("xs"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], US6_US6_1("text"), US14_US14_1((v72_1.tag === US5_Tag.US5_1) ? v72_1.fields[0] : v73_1), _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method54(v0_1: Mut18): any {
    const v3: any = Input;
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure206(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure198(void 0, void 0);
    return method5(v3, v4, v5);
}

export function closure205(unitVar: void, v0_1: Mut18): any {
    return method54(v0_1);
}

export function closure208(v0_1: () => int32, unitVar: void): US5 {
    return US5_US5_1(v0_1());
}

export function closure209(v0_1: (arg0: int32) => void, v1_1: US5): void {
    v0_1((v1_1.tag === US5_Tag.US5_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function method55(v0_1: (arg0: Mut18) => any, v1_1: () => US5, v2: (arg0: US5) => void): any {
    const v3: Mut18 = new Mut18(v1_1, v2);
    const v6: any = createComponent;
    return v6(v0_1, v3);
}

export function closure204(v0_1: (arg0: int32) => void, v1_1: () => int32, unitVar: void): any[] {
    const v2: (arg0: Mut18) => any = (v: Mut18): any => closure205(void 0, v);
    const v3: () => US5 = (): US5 => closure208(v1_1, void 0);
    const v4: (arg0: US5) => void = (v_1: US5): void => {
        closure209(v0_1, v_1);
    };
    return [method55(v2, v3, v4)];
}

export function closure203(v0_1: (arg0: int32) => void, v1_1: () => int32, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure204(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Port
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure192(v0_1: (arg0: string) => void, v1_1: () => string, v2: (arg0: string) => void, v3: () => string, v4: (arg0: int32) => void, v5: () => int32, unitVar: void): any[] {
    const v6: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure193(v0_1, v1_1, arg10$0040);
    const v14: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure201(v2, v3, arg10$0040_1);
    const v19: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure203(v4, v5, arg10$0040_2);
    return [method26(v6, US13_US13_0(), US13_US13_0(), v9, US15_US15_2()), method26(v6, US13_US13_0(), US13_US13_0(), v14, US15_US15_2()), method26(v6, US13_US13_0(), US13_US13_0(), v19, US15_US15_2())];
}

export function method51(): any {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    const v216: any = components.state_context;
    const v217: any = useContext;
    const patternInput_1: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v217(v216);
    const v335: any = components.state_context;
    const v336: any = useContext;
    const patternInput_2: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v336(v335);
    const v359: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v360: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v361: () => any[] = (): any[] => closure192(patternInput[5], patternInput[4], patternInput_1[7], patternInput_1[6], patternInput_2[3], patternInput_2[2], void 0);
    return method22(v359, v360, v361);
}

export function closure191(unitVar: void, v0_1: Mut1): any {
    return method51();
}

export function closure210(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure190(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure191(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure210(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure189(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure190(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Connection
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure222(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): US6 {
    return US6_US6_1(v2());
}

export function closure223(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, v8: US6): void {
    v3((v8.tag === US6_Tag.US6_1) ? v8.fields[0] : "");
}

export function closure221(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: (arg0: Mut17) => any = (v: Mut17): any => closure195(void 0, v);
    const v9: () => US6 = (): US6 => closure222(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    const v10: (arg0: US6) => void = (v_1: US6): void => {
        closure223(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v_1);
    };
    return [method53(v8, v9, v10)];
}

export function closure220(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v81: () => any[] = (): any[] => closure221(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v81), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Address
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure226(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): US6 {
    return US6_US6_1(v6());
}

export function closure227(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, v8: US6): void {
    v7((v8.tag === US6_Tag.US6_1) ? v8.fields[0] : "");
}

export function closure225(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: (arg0: Mut17) => any = (v: Mut17): any => closure195(void 0, v);
    const v9: () => US6 = (): US6 => closure226(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    const v10: (arg0: US6) => void = (v_1: US6): void => {
        closure227(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v_1);
    };
    return [method53(v8, v9, v10)];
}

export function closure224(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v81: () => any[] = (): any[] => closure225(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v81), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Private Key
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure219(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v11: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure220(v0_1, v1_1, v2, v3, v4, v5, v6, v7, arg10$0040);
    const v16: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure224(v0_1, v1_1, v2, v3, v4, v5, v6, v7, arg10$0040_1);
    return [method26(v8, US13_US13_0(), US13_US13_0(), v11, US15_US15_2()), method26(v8, US13_US13_0(), US13_US13_0(), v16, US15_US15_2())];
}

export function closure218(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure219(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [method22(v8, v9, v10)];
}

export function closure217(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v78: US0 = v0_1();
    const v89: () => any[] = (): any[] => closure218(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v89), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {(v78.tag === US0_Tag.US0_1) ? ((v78.fields[0].tag === US1_Tag.US1_1) ? "x" : "o") : "admin"}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure216(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, v8: () => int32): any[] {
    const v9: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure217(v0_1, v1_1, v2, v3, v4, v5, v6, v7, arg10$0040);
    return [method26(v9, US13_US13_0(), US13_US13_0(), v12, US15_US15_2())];
}

export function closure215(unitVar: void, _arg: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]): (arg0: () => int32) => any[] {
    return (v: () => int32): any[] => closure216(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], v);
}

export function closure228(v0_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US10_US10_1(v0_1), _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure214(v0_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], unitVar: void): any[] {
    let clo: () => any[];
    const v1_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = v0_1();
    const v2: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void], arg1: () => int32) => any[] = (arg10$0040: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]): (arg0: () => int32) => any[] => closure215(void 0, arg10$0040);
    const v6: any = For;
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure228(v1_1, arg10$0040_1);
    return [method5(v6, v7, (clo = ((item: any, index: () => number) => v2(item)(index)), clo))];
}

export function method56(): any {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    const v121: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v122: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v123: () => any[] = (): any[] => closure214(patternInput[0], void 0);
    return method22(v121, v122, v123);
}

export function closure213(unitVar: void, v0_1: Mut1): any {
    return method56();
}

export function closure229(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure212(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure213(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure229(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure211(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure212(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Accounts
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure232(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], US6_US6_1("#aaa"), _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], US6_US6_1("1"), _arg[21], _arg[22], _arg[23], US6_US6_1("350px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], US6_US6_1("https://bank.testnet.algorand.network"), _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        algorand testnet bank
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure233(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure231(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure232(void 0, arg10$0040);
    const v8: () => any[] = (): any[] => closure233(void 0, void 0);
    return [method5(v2.iframe, v7, v8)];
}

export function closure230(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure231(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Testnet Bank Dispenser
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure188(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure189(void 0, arg10$0040);
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure211(void 0, arg10$0040_1);
    const v13: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure230(void 0, arg10$0040_2);
    return [method26(v0_1, US13_US13_0(), US13_US13_0(), v3, US15_US15_2()), method26(v0_1, US13_US13_0(), US13_US13_0(), v8, US15_US15_2()), method26(v0_1, US13_US13_0(), US13_US13_0(), v13, US15_US15_0())];
}

export function method50(): any {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure188(void 0, void 0);
    return method22(v0_1, v1_1, v2);
}

export function closure187(unitVar: void, v0_1: Mut1): any {
    return method50();
}

export function closure234(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure186(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure187(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure234(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure185(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure186(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_1("db"), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Chain
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method61(v0_1: int32, v1_1: Mut21): boolean {
    return v1_1.l0 < v0_1;
}

export function closure248(v0_1: Mut20, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): US6 {
    let copyOfStruct: US3;
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut21 = new Mut21(0, US6_US6_0());
    while (method61(v3, v5)) {
        const v7: int32 = v5.l0 | 0;
        const v10: int32 = ((op_UnaryNegation_Int32(v7) + v3) - 1) | 0;
        const v11: US6 = v5.l1;
        const patternInput: [US2[], int32, US3, string, string] = v2[v10];
        const v14: US3 = patternInput[2];
        let v23: US6;
        if (v11.tag === US6_Tag.US6_0) {
            const v17: US3 = v0_1.l1;
            v23 = (((copyOfStruct = v14, (copyOfStruct.tag === US3_Tag.US3_1) ? (v17.tag === US3_Tag.US3_1) : ((copyOfStruct.tag === US3_Tag.US3_2) ? (v17.tag === US3_Tag.US3_2) : (v17.tag === US3_Tag.US3_0)))) ? v0_1.l0([patternInput[0], patternInput[1], v14, patternInput[3], patternInput[4]]) : US6_US6_0());
        }
        else {
            v23 = v11;
        }
        const v24: int32 = (v7 + 1) | 0;
        v5.l0 = (v24 | 0);
        v5.l1 = v23;
    }
    return v5.l1;
}

export function closure249(v0_1: Mut20, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: US6): void {
    let copyOfStruct: US3;
    const v4: [US2[], int32, US3, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2[], int32, US3, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut6 = new Mut6(0);
    while (method21(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v4[v9];
        const v14: string = patternInput[4];
        const v13: string = patternInput[3];
        const v12: US3 = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2[] = patternInput[0];
        const v15: US3 = v0_1.l1;
        const patternInput_1: [US2[], int32, US3, string, string] = ((copyOfStruct = v12, (copyOfStruct.tag === US3_Tag.US3_1) ? (v15.tag === US3_Tag.US3_1) : ((copyOfStruct.tag === US3_Tag.US3_2) ? (v15.tag === US3_Tag.US3_2) : (v15.tag === US3_Tag.US3_0)))) ? v0_1.l2([v10, v11, v12, v13, v14], v3) : [v10, v11, v12, v13, v14];
        v6[v9] = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]];
        const v29: int32 = (v9 + 1) | 0;
        v7.l0 = (v29 | 0);
    }
    v1_1(v6);
}

export function method60(v0_1: Mut20): any {
    const v96: any = components.state_context;
    const v99: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v99(v96);
    const v108: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v122: (arg0: Mut17) => any = (v: Mut17): any => closure195(void 0, v);
    const v123: () => US6 = (): US6 => closure248(v0_1, v108, void 0);
    const v124: (arg0: US6) => void = (v_1: US6): void => {
        closure249(v0_1, patternInput[9], v108, v_1);
    };
    return method53(v122, v123, v124);
}

export function closure247(unitVar: void, v0_1: Mut20): any {
    return method60(v0_1);
}

export function closure250(unitVar: void, _arg: [US2[], int32, US3, string, string]): US6 {
    return US6_US6_1(_arg[3]);
}

export function closure252(v0_1: Mut19, v1_1: US2[], v2: int32, v3: US3, v4: string, v5: string, v6: US6): [US2[], int32, US3, string, string] {
    return [v1_1, v2, v0_1.l0, (v6.tag === US6_Tag.US6_1) ? v6.fields[0] : "", v5];
}

export function closure251(v0_1: Mut19, _arg: [US2[], int32, US3, string, string]): (arg0: US6) => [US2[], int32, US3, string, string] {
    return (v: US6): [US2[], int32, US3, string, string] => closure252(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], _arg[4], v);
}

export function method62(v0_1: (arg0: Mut20) => any, v1_1: (arg0: [US2[], int32, US3, string, string]) => US6, v2: US3, v3: (arg0: [US2[], int32, US3, string, string], arg1: US6) => [US2[], int32, US3, string, string]): any {
    const v4: Mut20 = new Mut20(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure246(v0_1: Mut19, unitVar: void): any[] {
    const v1_1: (arg0: Mut20) => any = (v: Mut20): any => closure247(void 0, v);
    const v3: (arg0: [US2[], int32, US3, string, string]) => US6 = (arg10$0040: [US2[], int32, US3, string, string]): US6 => closure250(void 0, arg10$0040);
    const v4: (arg0: [US2[], int32, US3, string, string], arg1: US6) => [US2[], int32, US3, string, string] = (arg10$0040_1: [US2[], int32, US3, string, string]): (arg0: US6) => [US2[], int32, US3, string, string] => closure251(v0_1, arg10$0040_1);
    return [method62(v1_1, v3, v0_1.l0, uncurry(2, v4))];
}

export function closure245(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure246(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        URL
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method64(v0_1: int32, v1_1: Mut23): boolean {
    return v1_1.l0 < v0_1;
}

export function closure256(v0_1: Mut22, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): US5 {
    let copyOfStruct: US3;
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut23 = new Mut23(0, US5_US5_0());
    while (method64(v3, v5)) {
        const v7: int32 = v5.l0 | 0;
        const v10: int32 = ((op_UnaryNegation_Int32(v7) + v3) - 1) | 0;
        const v11: US5 = v5.l1;
        const patternInput: [US2[], int32, US3, string, string] = v2[v10];
        const v14: US3 = patternInput[2];
        let v23: US5;
        if (v11.tag === US5_Tag.US5_0) {
            const v17: US3 = v0_1.l1;
            v23 = (((copyOfStruct = v14, (copyOfStruct.tag === US3_Tag.US3_1) ? (v17.tag === US3_Tag.US3_1) : ((copyOfStruct.tag === US3_Tag.US3_2) ? (v17.tag === US3_Tag.US3_2) : (v17.tag === US3_Tag.US3_0)))) ? v0_1.l0([patternInput[0], patternInput[1], v14, patternInput[3], patternInput[4]]) : US5_US5_0());
        }
        else {
            v23 = v11;
        }
        const v24: int32 = (v7 + 1) | 0;
        v5.l0 = (v24 | 0);
        v5.l1 = v23;
    }
    return v5.l1;
}

export function closure257(v0_1: Mut22, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: US5): void {
    let copyOfStruct: US3;
    const v4: [US2[], int32, US3, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2[], int32, US3, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut6 = new Mut6(0);
    while (method21(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v4[v9];
        const v14: string = patternInput[4];
        const v13: string = patternInput[3];
        const v12: US3 = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2[] = patternInput[0];
        const v15: US3 = v0_1.l1;
        const patternInput_1: [US2[], int32, US3, string, string] = ((copyOfStruct = v12, (copyOfStruct.tag === US3_Tag.US3_1) ? (v15.tag === US3_Tag.US3_1) : ((copyOfStruct.tag === US3_Tag.US3_2) ? (v15.tag === US3_Tag.US3_2) : (v15.tag === US3_Tag.US3_0)))) ? v0_1.l2([v10, v11, v12, v13, v14], v3) : [v10, v11, v12, v13, v14];
        v6[v9] = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]];
        const v29: int32 = (v9 + 1) | 0;
        v7.l0 = (v29 | 0);
    }
    v1_1(v6);
}

export function method63(v0_1: Mut22): any {
    const v96: any = components.state_context;
    const v99: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v99(v96);
    const v108: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v122: (arg0: Mut18) => any = (v: Mut18): any => closure205(void 0, v);
    const v123: () => US5 = (): US5 => closure256(v0_1, v108, void 0);
    const v124: (arg0: US5) => void = (v_1: US5): void => {
        closure257(v0_1, patternInput[9], v108, v_1);
    };
    return method55(v122, v123, v124);
}

export function closure255(unitVar: void, v0_1: Mut22): any {
    return method63(v0_1);
}

export function closure258(unitVar: void, _arg: [US2[], int32, US3, string, string]): US5 {
    return US5_US5_1(_arg[1]);
}

export function closure260(v0_1: Mut19, v1_1: US2[], v2: int32, v3: US3, v4: string, v5: string, v6: US5): [US2[], int32, US3, string, string] {
    const v7: US3 = v0_1.l0;
    return [v1_1, (v6.tag === US5_Tag.US5_1) ? v6.fields[0] : 0, v7, v4, v5];
}

export function closure259(v0_1: Mut19, _arg: [US2[], int32, US3, string, string]): (arg0: US5) => [US2[], int32, US3, string, string] {
    return (v: US5): [US2[], int32, US3, string, string] => closure260(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], _arg[4], v);
}

export function method65(v0_1: (arg0: Mut22) => any, v1_1: (arg0: [US2[], int32, US3, string, string]) => US5, v2: US3, v3: (arg0: [US2[], int32, US3, string, string], arg1: US5) => [US2[], int32, US3, string, string]): any {
    const v4: Mut22 = new Mut22(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure254(v0_1: Mut19, unitVar: void): any[] {
    const v1_1: (arg0: Mut22) => any = (v: Mut22): any => closure255(void 0, v);
    const v3: (arg0: [US2[], int32, US3, string, string]) => US5 = (arg10$0040: [US2[], int32, US3, string, string]): US5 => closure258(void 0, arg10$0040);
    const v4: (arg0: [US2[], int32, US3, string, string], arg1: US5) => [US2[], int32, US3, string, string] = (arg10$0040_1: [US2[], int32, US3, string, string]): (arg0: US5) => [US2[], int32, US3, string, string] => closure259(v0_1, arg10$0040_1);
    return [method65(v1_1, v3, v0_1.l0, uncurry(2, v4))];
}

export function closure253(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure254(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Port
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure244(v0_1: Mut19, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure245(v0_1, arg10$0040);
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure253(v0_1, arg10$0040_1);
    return [method26(v1_1, US13_US13_0(), US13_US13_0(), v4, US15_US15_2()), method26(v1_1, US13_US13_0(), US13_US13_0(), v9, US15_US15_2())];
}

export function method59(v0_1: Mut19): any {
    const v1_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure244(v0_1, void 0);
    return method22(v1_1, v2, v3);
}

export function closure243(unitVar: void, v0_1: Mut19): any {
    return method59(v0_1);
}

export function method66(v0_1: (arg0: Mut19) => any, v1_1: US3): any {
    const v2: Mut19 = new Mut19(v1_1);
    const v5: any = createComponent;
    return v5(v0_1, v2);
}

export function closure242(v0_1: Mut19, unitVar: void): any[] {
    const v1_1: (arg0: Mut19) => any = (v: Mut19): any => closure243(void 0, v);
    return [method66(v1_1, v0_1.l0)];
}

export function closure241(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: US3 = v0_1.l0;
    const v80: () => any[] = (): any[] => closure242(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v80), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_0(), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {(v71.tag === US3_Tag.US3_1) ? "Gun Rust" : ((v71.tag === US3_Tag.US3_2) ? "SignalR" : "Gun JavaScript")}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure266(v0_1: Mut24, unitVar: void): any[] {
    const v1_1: US3 = v0_1.l1;
    const v7: string = (v1_1.tag === US3_Tag.US3_1) ? "Gun Rust" : ((v1_1.tag === US3_Tag.US3_2) ? "SignalR" : "Gun JavaScript");
    const v10: US2 = v0_1.l0;
    return [["props.ServerType", v7], ["props.ClientType", (v10.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v10.tag === US2_Tag.US2_2) ? "Memory" : ((v10.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))]];
}

export function method70(v0_1_mut: US2, v1_1_mut: US2[], v2_mut: int32): boolean {
    let copyOfStruct: US2;
    method70:
    while (true) {
        const v0_1: US2 = v0_1_mut, v1_1: US2[] = v1_1_mut, v2: int32 = v2_mut;
        if (v2 < v1_1.length) {
            const v5: US2 = v1_1[v2];
            if ((copyOfStruct = v0_1, (copyOfStruct.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : ((copyOfStruct.tag === US2_Tag.US2_3) ? (v5.tag === US2_Tag.US2_3) : (v5.tag === US2_Tag.US2_0))))) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_mut = (v2 + 1);
                continue method70;
            }
        }
        else {
            return false;
        }
        break;
    }
}

export function method69(v0_1_mut: Mut24, v1_1_mut: [US2[], int32, US3, string, string][], v2_mut: int32): boolean {
    let copyOfStruct: US3;
    method69:
    while (true) {
        const v0_1: Mut24 = v0_1_mut, v1_1: [US2[], int32, US3, string, string][] = v1_1_mut, v2: int32 = v2_mut;
        if (v2 < v1_1.length) {
            const patternInput: [US2[], int32, US3, string, string] = v1_1[v2];
            const v10: US3 = v0_1.l1;
            if (((copyOfStruct = patternInput[2], (copyOfStruct.tag === US3_Tag.US3_1) ? (v10.tag === US3_Tag.US3_1) : ((copyOfStruct.tag === US3_Tag.US3_2) ? (v10.tag === US3_Tag.US3_2) : (v10.tag === US3_Tag.US3_0)))) && method70(v0_1.l0, patternInput[0], 0)) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_mut = (v2 + 1);
                continue method69;
            }
        }
        else {
            return false;
        }
        break;
    }
}

export function closure267(v0_1: Mut24, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): boolean {
    return method69(v0_1, v1_1(), 0);
}

export function method71(v0_1: int32, v1_1: Mut25): boolean {
    return v1_1.l0 < v0_1;
}

export function closure268(v0_1: Mut24, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: boolean): void {
    let copyOfStruct: US3, v18: US2[], v19: int32, v21: int32, v22: US2[], v23: Mut6, v32: US2, v33: int32, v34: US2[], v35: Mut25, v45: int32, v46: US2[], v47: Mut6;
    const v4: [US2[], int32, US3, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2[], int32, US3, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut6 = new Mut6(0);
    while (method21(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v4[v9];
        const v14: string = patternInput[4];
        const v13: string = patternInput[3];
        const v12: US3 = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2[] = patternInput[0];
        const v15: US3 = v0_1.l1;
        const patternInput_1: [US2[], int32, US3, string, string] = ((copyOfStruct = v12, (copyOfStruct.tag === US3_Tag.US3_1) ? (v15.tag === US3_Tag.US3_1) : ((copyOfStruct.tag === US3_Tag.US3_2) ? (v15.tag === US3_Tag.US3_2) : (v15.tag === US3_Tag.US3_0)))) ? [v3 ? ((v18 = [v0_1.l0], (v19 = (v10.length | 0), (v21 = ((v19 + v18.length) | 0), (v22 = fill(new Array(v21), 0, v21, null), (v23 = (new Mut6(0)), ((() => {
            while (method21(v21, v23)) {
                const v25: int32 = v23.l0 | 0;
                let v30: US2;
                if (v25 < v19) {
                    v30 = v10[v25];
                }
                else {
                    const v28: int32 = (v25 - v19) | 0;
                    v30 = v18[v28];
                }
                v22[v25] = v30;
                const v31: int32 = (v25 + 1) | 0;
                v23.l0 = (v31 | 0);
            }
        })(), v22))))))) : ((v32 = v0_1.l0, (v33 = (v10.length | 0), (v34 = fill(new Array(v33), 0, v33, null), (v35 = (new Mut25(0, 0)), ((() => {
            let copyOfStruct_4: US2;
            while (method71(v33, v35)) {
                const v37: int32 = v35.l0 | 0;
                const v38: int32 = v35.l1 | 0;
                const v39: US2 = v10[v37];
                let v43: int32;
                if (((copyOfStruct_4 = v32, (copyOfStruct_4.tag === US2_Tag.US2_1) ? (v39.tag === US2_Tag.US2_1) : ((copyOfStruct_4.tag === US2_Tag.US2_2) ? (v39.tag === US2_Tag.US2_2) : ((copyOfStruct_4.tag === US2_Tag.US2_3) ? (v39.tag === US2_Tag.US2_3) : (v39.tag === US2_Tag.US2_0))))) !== true) {
                    v34[v38] = v39;
                    v43 = (v38 + 1);
                }
                else {
                    v43 = v38;
                }
                const v44: int32 = (v37 + 1) | 0;
                v35.l0 = (v44 | 0);
                v35.l1 = (v43 | 0);
            }
        })(), (v45 = (v35.l1 | 0), (v46 = fill(new Array(v45), 0, v45, null), (v47 = (new Mut6(0)), ((() => {
            while (method21(v45, v47)) {
                const v49: int32 = v47.l0 | 0;
                const v50: US2 = v34[v49];
                v46[v49] = v50;
                const v51: int32 = (v49 + 1) | 0;
                v47.l0 = (v51 | 0);
            }
        })(), v46)))))))))), v11, v12, v13, v14] : [v10, v11, v12, v13, v14];
        v6[v9] = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]];
        const v58: int32 = (v9 + 1) | 0;
        v7.l0 = (v58 | 0);
    }
    v1_1(v6);
}

export function closure270(v0_1: Mut24, unitVar: void): any[] {
    const v1_1: US2 = v0_1.l0;
    return [<>
        {(v1_1.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v1_1.tag === US2_Tag.US2_2) ? "Memory" : ((v1_1.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))}
    </>];
}

export function closure269(v0_1: Mut24, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: US2 = v0_1.l0;
    const v79: string = (v71.tag === US2_Tag.US2_1) ? "gunrs" : ((v71.tag === US2_Tag.US2_2) ? "mem" : ((v71.tag === US2_Tag.US2_3) ? "signalr" : "gunjs"));
    const v80: US3 = v0_1.l1;
    const v88: () => any[] = (): any[] => closure270(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v88), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_1(`db-${v79}-${(v80.tag === US3_Tag.US3_1) ? "gunrs" : ((v80.tag === US3_Tag.US3_2) ? "signalr" : "gunjs")}`), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method68(v0_1: Mut24): any {
    const v96: any = components.state_context;
    const v99: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v99(v96);
    const v108: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v122: () => any[] = (): any[] => closure266(v0_1, void 0);
    method16(v122, "#666")(US4_US4_0())(["> db_client ()"]);
    const v130: (arg0: Mut4) => any = (v: Mut4): any => closure21(void 0, v);
    const v131: () => boolean = (): boolean => closure267(v0_1, v108, void 0);
    const v132: (arg0: boolean) => void = (v_1: boolean): void => {
        closure268(v0_1, patternInput[9], v108, v_1);
    };
    const v133: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure269(v0_1, arg10$0040_2);
    return method14(v130, v131, v132, v133);
}

export function closure265(unitVar: void, v0_1: Mut24): any {
    return method68(v0_1);
}

export function method72(v0_1: (arg0: Mut24) => any, v1_1: US2, v2: US3): any {
    const v3: Mut24 = new Mut24(v1_1, v2);
    const v6: any = createComponent;
    return v6(v0_1, v3);
}

export function closure264(v0_1: Mut19, unitVar: void): any[] {
    const v1_1: (arg0: Mut24) => any = (v: Mut24): any => closure265(void 0, v);
    return [method72(v1_1, US2_US2_3(), v0_1.l0)];
}

export function closure263(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure264(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_0(), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_1("8px"), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Clients
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method67(v0_1: Mut19): any {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure263(v0_1, arg10$0040);
    return method26(v1_1, US13_US13_0(), US13_US13_0(), v4, US15_US15_2());
}

export function closure262(unitVar: void, v0_1: Mut19): any {
    return method67(v0_1);
}

export function closure261(v0_1: Mut19, unitVar: void): any[] {
    const v1_1: (arg0: Mut19) => any = (v: Mut19): any => closure262(void 0, v);
    return [method66(v1_1, v0_1.l0)];
}

export function closure240(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure241(v0_1, arg10$0040);
    const v77_1: () => any[] = (): any[] => closure261(v0_1, void 0);
    const v80: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v77_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_0(), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1(v80), US6_US6_1(v80), _arg[51], US6_US6_1(v80), _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(method26(v71, US13_US13_0(), US13_US13_0(), v74_1, US15_US15_2())), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method58(v0_1: Mut19): any {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure240(v0_1, arg10$0040);
    return method26(v1_1, US13_US13_0(), US13_US13_0(), v4, US15_US15_2());
}

export function closure239(unitVar: void, v0_1: Mut19): any {
    return method58(v0_1);
}

export function closure238(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut19) => any = (v: Mut19): any => closure239(void 0, v);
    return [method66(v0_1, US3_US3_2())];
}

export function method57(): any {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure238(void 0, void 0);
    return method22(v0_1, v1_1, v2);
}

export function closure237(unitVar: void, v0_1: Mut1): any {
    return method57();
}

export function closure271(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure236(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut1) => any = (v: Mut1): any => closure237(void 0, v);
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure271(void 0, void 0);
    return [method22(v0_1, v1_1, v2)];
}

export function closure235(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure236(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_1("db-connections"), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Database
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure276(v0_1: () => [string, int32][], unitVar: void): any[] {
    return [["profile_tmp_counter", v0_1()]];
}

export function closure277(v0_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1(US4_US4_2(), ["> counter -> effect ()"]);
}

export function closure278(v0_1: (arg0: [string, int32][]) => void, _arg: [[string, int32][], US2, string, int32]): void {
    const v1_1: [string, int32][] = _arg[0];
    const v5: [string, int32][] = [[_arg[2], _arg[3]]];
    const v6: int32 = v1_1.length | 0;
    const v8: int32 = (v6 + v5.length) | 0;
    const v9: [string, int32][] = fill(new Array(v8), 0, v8, null);
    const v10: Mut6 = new Mut6(0);
    while (method21(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        let patternInput_2: [string, int32];
        if (v12 < v6) {
            const patternInput: [string, int32] = v1_1[v12];
            patternInput_2 = [patternInput[0], patternInput[1]];
        }
        else {
            const v16: int32 = (v12 - v6) | 0;
            const patternInput_1: [string, int32] = v5[v16];
            patternInput_2 = [patternInput_1[0], patternInput_1[1]];
        }
        v9[v12] = [patternInput_2[0], patternInput_2[1]];
        const v21: int32 = (v12 + 1) | 0;
        v10.l0 = (v21 | 0);
    }
    v0_1(v9);
}

export function closure281(v0_1: () => [string, int32][], v1_1: (arg0: int32) => void, v2: (arg0: Error) => void): void {
    const v3: [string, int32][] = v0_1();
    v1_1(v3.length);
}

export function closure280(v0_1: () => [string, int32][], v1_1: (arg0: int32) => void): (arg0: (arg0: Error) => void) => void {
    return (v: (arg0: Error) => void): void => {
        closure281(v0_1, v1_1, v);
    };
}

export function closure279(v0_1: () => [string, int32][], v1_1: any): any {
    const v2: (arg0: (arg0: int32) => void, arg1: (arg0: Error) => void) => void = (v: (arg0: int32) => void): (arg0: (arg0: Error) => void) => void => closure280(v0_1, v);
    return new Promise(uncurry(2, v2));
}

export function method75(): [() => void, () => void] {
    let value_1: any, value_2: any;
    const v2: any = createSignal;
    const v3: any[] = v2();
    return [(value_1 = v3[0], (): void => {
        value_1();
    }), (value_2 = v3[1], (): void => {
        value_2();
    })];
}

export function method76(v0_1: US16): [() => US16, (arg0: US16) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: US16): void => {
        value_2(arg_1);
    })];
}

export function method77(v0_1: [US2, any, string][]): [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: [US2, any, string][]): void => {
        value_2(arg_1);
    })];
}

export function closure282(v0_1: string, v1_1: () => [string, int32][], v2: () => [US2, any, string][], v3: () => void, v4: () => void, v5: () => US16, v6: () => [US2, any, string][], unitVar: void): any[] {
    const v9: [string, int32][] = v1_1();
    v3();
    v4();
    const v16: US16 = v5();
    const v19: [US2, any, string][] = v6();
    const v20: int32 = v19.length | 0;
    const v21: [string, any][] = fill(new Array(v20), 0, v20, null);
    const v22: Mut6 = new Mut6(0);
    while (method21(v20, v22)) {
        const v24: int32 = v22.l0 | 0;
        const patternInput: [US2, any, string] = v19[v24];
        const v25: US2 = patternInput[0];
        const v35: string = (v25.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v25.tag === US2_Tag.US2_2) ? "Memory" : ((v25.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"));
        v21[v24] = [v35, patternInput[1]];
        const v36: int32 = (v24 + 1) | 0;
        v22.l0 = (v36 | 0);
    }
    const v39: [US2, any, string][] = v2();
    const v40: int32 = v39.length | 0;
    const v41: string[] = fill(new Array(v40), 0, v40, "");
    const v42: Mut6 = new Mut6(0);
    while (method21(v40, v42)) {
        const v44: int32 = v42.l0 | 0;
        const v45: US2 = v39[v44][0];
        const v55: string = (v45.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v45.tag === US2_Tag.US2_2) ? "Memory" : ((v45.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"));
        v41[v44] = v55;
        const v56: int32 = (v44 + 1) | 0;
        v42.l0 = (v56 | 0);
    }
    return [["content_address", v0_1], ["getter", v9], "events", "timers", ["value", v16], ["subscriptions", v21], ["db_connections", v41]];
}

export function method78(v0_1: int32, v1_1: Mut26): boolean {
    return v1_1.l0 < v0_1;
}

export function closure284(v0_1: string, v1_1: US2, unitVar: void): any[] {
    return [["content_address", v0_1], ["client_type", (v1_1.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v1_1.tag === US2_Tag.US2_2) ? "Memory" : ((v1_1.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))]];
}

export function closure287(unitVar: void, v0_1: string): int64 {
    const v1_1: string = v0_1;
    return parse(`${v1_1.slice(0, 7 + 1)}${v1_1.slice(9, 12 + 1)}${v1_1.slice(14, 17 + 1)}${v1_1.slice(19, 20 + 1)}`, 511, false, 64);
}

export function closure288(v0_1: US2, v1_1: string, v2: int32, unitVar: void): any[] {
    return [["content_address", v1_1], ["client_type", (v0_1.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v0_1.tag === US2_Tag.US2_2) ? "Memory" : ((v0_1.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))], ["new_value", v2]];
}

export function method80(v0_1: int32, v1_1: Mut27): boolean {
    return v1_1.l0 < v0_1;
}

export function closure289(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: UH1): void {
    v0_1(US4_US4_2(), ["> db_put > response\' ()", ["response\'", JSON.stringify(v1_1)]]);
}

export function method79(v0_1: string, v1_1: () => [string, int32][], v2: (arg0: [[string, int32][], US2, string, int32]) => void, v3: () => US4, v4: (arg0: US16) => void, v5: () => US16, v6: (arg0: US4, arg1: any[]) => void, v7: US2, v8: [US2, any, string][], v9: int32, v10: string): void {
    let v15: (arg0: string) => int64, copyOfStruct: US2;
    const v11: US16 = v5();
    if ((v11.tag === US16_Tag.US16_1) ? ((v15 = ((v: string): int64 => closure287(void 0, v)), (v11.fields[2] !== v9) && (compare(v15(v10), v15(v11.fields[1])) > 0))) : true) {
        const v19: [string, int32][] = v1_1();
        const v24: string = "old_value";
        const v34: string = "client_type";
        const v36: string = "new_guid\'";
        const v38: string = "new_value_raw";
        v6(US4_US4_2(), ["> use_fetch > on_value > set ()", [v24, v19], [v34, (v7.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v7.tag === US2_Tag.US2_2) ? "Memory" : ((v7.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))], [v36, v10], [v38, v9]]);
        v2([v19, v7, v10, v9]);
        v4(US16_US16_1(v7, v10, v9));
        const v42: int32 = v8.length | 0;
        const v43: Mut6 = new Mut6(0);
        while (method21(v42, v43)) {
            const v45: int32 = v43.l0 | 0;
            const patternInput: [US2, any, string] = v8[v45];
            const v47: any = patternInput[1];
            const v46: US2 = patternInput[0];
            if (((copyOfStruct = v46, (copyOfStruct.tag === US2_Tag.US2_1) ? (v7.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v7.tag === US2_Tag.US2_2) : ((copyOfStruct.tag === US2_Tag.US2_3) ? (v7.tag === US2_Tag.US2_3) : (v7.tag === US2_Tag.US2_0))))) !== true) {
                v6(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v24, v19], [v34, (v7.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v7.tag === US2_Tag.US2_2) ? "Memory" : ((v7.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))], [v36, v10], [v38, v9], ["connection_client_type", (v46.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v46.tag === US2_Tag.US2_2) ? "Memory" : ((v46.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))]]);
                const v78: () => any[] = (): any[] => closure288(v46, v0_1, v9, void 0);
                const v80: (arg0: US4, arg1: any[]) => void = method17(v3, v78, "#666");
                v80(US4_US4_0())(["> db_put ()"]);
                switch (v46.tag) {
                    case 1: {
                        const v92: string[] = v0_1.split("/");
                        const v93: string = "get";
                        const v97: any = v47[v93]("tictactoe");
                        const v98: int32 = v92.length | 0;
                        const v99: Mut27 = new Mut27(0, v97);
                        while (method80(v98, v99)) {
                            const v101: int32 = v99.l0 | 0;
                            const v102: any = v99.l1;
                            const v103: string = v92[v101];
                            const v106: any = v102[v93](v103);
                            const v107: int32 = (v101 + 1) | 0;
                            v99.l0 = (v107 | 0);
                            v99.l1 = v106;
                        }
                        const v108: any = v99.l1;
                        v108.put(v9);
                        break;
                    }
                    case 2: {
                        throw new Error("db_on Memory");
                        break;
                    }
                    case 3: {
                        const v91: (arg0: UH1) => void = (v_1: UH1): void => {
                            closure289(uncurry(2, v80), v_1);
                        };
                        const pr: any = HubConnection$5__invokeAsPromise_2B595<UH0, UH0, void, UH1, UH1>(v47, UH0_UH0_3("alias", v0_1, v9));
                        void (pr.then(v91));
                        break;
                    }
                    default: {
                        const v112: string[] = v0_1.split("/");
                        const v113: string = "get";
                        const v117: any = v47[v113]("tictactoe");
                        const v118: int32 = v112.length | 0;
                        const v119: Mut27 = new Mut27(0, v117);
                        while (method80(v118, v119)) {
                            const v121: int32 = v119.l0 | 0;
                            const v122: any = v119.l1;
                            const v123: string = v112[v121];
                            const v126: any = v122[v113](v123);
                            const v127: int32 = (v121 + 1) | 0;
                            v119.l0 = (v127 | 0);
                            v119.l1 = v126;
                        }
                        const v128: any = v119.l1;
                        v128.put(v9);
                    }
                }
            }
            const v132: int32 = (v45 + 1) | 0;
            v43.l0 = (v132 | 0);
        }
    }
}

export function closure286(v0_1: string, v1_1: () => [string, int32][], v2: (arg0: [[string, int32][], US2, string, int32]) => void, v3: () => US4, v4: (arg0: US16) => void, v5: () => US16, v6: (arg0: US4, arg1: any[]) => void, v7: US2, v8: [US2, any, string][], v9: (arg0: US4, arg1: any[]) => void, v10: string, v11: int32, v12: any): void {
    v9(US4_US4_2(), ["> db_on > on_value ()", ["v", v10, v11], ["k", v12]]);
    method79(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v11, v10);
}

export function closure285(v0_1: string, v1_1: () => [string, int32][], v2: (arg0: [[string, int32][], US2, string, int32]) => void, v3: () => US4, v4: (arg0: US16) => void, v5: () => US16, v6: (arg0: US4, arg1: any[]) => void, v7: US2, v8: [US2, any, string][], v9: (arg0: US4, arg1: any[]) => void, _arg: [string, int32]): (arg0: any) => void {
    return (v: any): void => {
        closure286(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, _arg[0], _arg[1], v);
    };
}

export function closure291(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: UH1): void {
    v0_1(US4_US4_2(), ["> db_on > stream next ()", ["msg", v1_1]]);
}

export function closure292(v0_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1(US4_US4_2(), ["> db_on > stream complete ()"]);
}

export function closure293(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: any): void {
    v0_1(US4_US4_2(), ["> db_on > stream err ()", ["err", JSON.stringify(v1_1)]]);
}

export function closure290(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: any): US17 {
    const v2: (arg0: UH1) => void = (v: UH1): void => {
        closure291(v0_1, v);
    };
    const v6: () => void = (): void => {
        closure292(v0_1, void 0);
    };
    const v10: (arg0: any) => void = (v_1: any): void => {
        closure293(v0_1, v_1);
    };
    const v16: any = {
        next: v2,
        complete: v6,
        error: v10,
    };
    let v17: IDisposable;
    const sub: any = v1_1.subscribe(v16);
    v17 = {
        Dispose(): void {
            sub.dispose();
        },
    };
    v0_1(US4_US4_2(), ["> db_on > streamFrom subscribe ()", ["stream", JSON.stringify(v1_1)], ["subscription (IDisposable)", v17]]);
    return US17_US17_0(v17);
}

export function method81(v0_1_mut: [US2, string][], v1_1_mut: [US2, string][], v2_mut: int32): boolean {
    let copyOfStruct: US2;
    method81:
    while (true) {
        const v0_1: [US2, string][] = v0_1_mut, v1_1: [US2, string][] = v1_1_mut, v2: int32 = v2_mut;
        if (v2 < v0_1.length) {
            const patternInput: [US2, string] = v0_1[v2];
            const patternInput_1: [US2, string] = v1_1[v2];
            const v7: US2 = patternInput_1[0];
            if (((copyOfStruct = patternInput[0], (copyOfStruct.tag === US2_Tag.US2_1) ? (v7.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v7.tag === US2_Tag.US2_2) : ((copyOfStruct.tag === US2_Tag.US2_3) ? (v7.tag === US2_Tag.US2_3) : (v7.tag === US2_Tag.US2_0))))) && (patternInput[1] === patternInput_1[1])) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_mut = (v2 + 1);
                continue method81;
            }
            else {
                return false;
            }
        }
        else {
            return true;
        }
        break;
    }
}

export function closure283(v0_1: string, v1_1: () => US4, v2: (arg0: [US2, any, string][]) => void, v3: () => [US2, any, string][], v4: (arg0: US4, arg1: any[]) => void, v5: () => [string, int32][], v6: (arg0: [[string, int32][], US2, string, int32]) => void, v7: (arg0: US16) => void, v8: () => US16, v9: [US2, any, string][]): void {
    let copyOfStruct: US2, v59: string[], v60: string, v64: any, v65: int32, v66: Mut27, v75_1: any, v79: int64, v57: (arg0: any) => US17, pr: any, v82: string[], v83: string, v87: any, v88: int32, v89: Mut27, v98: any, v102: int64;
    const v10: [US2, any, string][] = v3();
    const v11: int32 = v9.length | 0;
    const v12: [US2, any, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut6 = new Mut6(0);
    while (method21(v11, v13)) {
        const v15: int32 = v13.l0 | 0;
        const patternInput: [US2, any, string] = v9[v15];
        const v18: string = patternInput[2];
        const v17: any = patternInput[1];
        const v16: US2 = patternInput[0];
        const v19: int32 = v10.length | 0;
        const v21: Mut26 = new Mut26(0, US18_US18_0());
        while (method78(v19, v21)) {
            const v23: int32 = v21.l0 | 0;
            const v26: int32 = ((op_UnaryNegation_Int32(v23) + v19) - 1) | 0;
            const v27: US18 = v21.l1;
            const patternInput_1: [US2, any, string] = v10[v26];
            const v30: string = patternInput_1[2];
            const v28: US2 = patternInput_1[0];
            const v37: US18 = (v27.tag === US18_Tag.US18_0) ? ((((copyOfStruct = v28, (copyOfStruct.tag === US2_Tag.US2_1) ? (v16.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v16.tag === US2_Tag.US2_2) : ((copyOfStruct.tag === US2_Tag.US2_3) ? (v16.tag === US2_Tag.US2_3) : (v16.tag === US2_Tag.US2_0))))) && (v30 === v18)) ? US18_US18_1(v28, patternInput_1[1], v30) : US18_US18_0()) : v27;
            const v38: int32 = (v23 + 1) | 0;
            v21.l0 = (v38 | 0);
            v21.l1 = v37;
        }
        const v39: US18 = v21.l1;
        let patternInput_2: [US2, any, string];
        if (v39.tag === US18_Tag.US18_1) {
            patternInput_2 = [v39.fields[0], v39.fields[1], v39.fields[2]];
        }
        else {
            const v43: () => any[] = (): any[] => closure284(v0_1, v16, void 0);
            const v45: (arg0: US4, arg1: any[]) => void = method17(v1_1, v43, "#666");
            v45(US4_US4_0())(["> db_on ()"]);
            const v51: (arg0: [string, int32], arg1: any) => void = (arg10$0040_1: [string, int32]): (arg0: any) => void => closure285(v0_1, v5, v6, v1_1, v7, v8, v4, v16, v9, uncurry(2, v45), arg10$0040_1);
            let v52: (arg0: [any, int32]) => void;
            const clo: (arg0: [any, int32]) => void = (v: any, k: any) => v51(v)(k);
            v52 = ((arg: [any, int32]): void => {
                clo(arg);
            });
            patternInput_2 = [v16, (v16.tag === US2_Tag.US2_1) ? ((v59 = v0_1.split("/"), (v60 = "get", (v64 = v17[v60]("tictactoe"), (v65 = (v59.length | 0), (v66 = (new Mut27(0, v64)), ((() => {
                while (method80(v65, v66)) {
                    const v68: int32 = v66.l0 | 0;
                    const v69: any = v66.l1;
                    const v70: string = v59[v68];
                    const v73_1: any = v69[v60](v70);
                    const v74_1: int32 = (v68 + 1) | 0;
                    v66.l0 = (v74_1 | 0);
                    v66.l1 = v73_1;
                }
            })(), (v75_1 = v66.l1, (v79 = v75_1.on(v52), Promise.resolve(US17_US17_1(v79))))))))))) : ((v16.tag === US2_Tag.US2_2) ? (() => {
                throw new Error("db_on Memory");
            })() : ((v16.tag === US2_Tag.US2_3) ? ((v57 = ((v: any): US17 => closure290(uncurry(2, v45), v)), (pr = HubConnection$5__streamFromAsPromise_2B594<UH0, UH0, void, UH1, UH1>(v17, UH0_UH0_1("alias", v0_1)), pr.then(v57)))) : ((v82 = v0_1.split("/"), (v83 = "get", (v87 = v17[v83]("tictactoe"), (v88 = (v82.length | 0), (v89 = (new Mut27(0, v87)), ((() => {
                while (method80(v88, v89)) {
                    const v91: int32 = v89.l0 | 0;
                    const v92: any = v89.l1;
                    const v93: string = v82[v91];
                    const v96: any = v92[v83](v93);
                    const v97: int32 = (v91 + 1) | 0;
                    v89.l0 = (v97 | 0);
                    v89.l1 = v96;
                }
            })(), (v98 = v89.l1, (v98.on(v52), (v102 = getTicks(utcNow()), Promise.resolve(US17_US17_1(v102)))))))))))))), v18];
        }
        v12[v15] = [patternInput_2[0], patternInput_2[1], patternInput_2[2]];
        const v116: int32 = (v15 + 1) | 0;
        v13.l0 = (v116 | 0);
    }
    const v117: int32 = v10.length | 0;
    const v118: [US2, string][] = fill(new Array(v117), 0, v117, null);
    const v119: Mut6 = new Mut6(0);
    while (method21(v117, v119)) {
        const v121: int32 = v119.l0 | 0;
        const patternInput_3: [US2, any, string] = v10[v121];
        v118[v121] = [patternInput_3[0], patternInput_3[2]];
        const v125: int32 = (v121 + 1) | 0;
        v119.l0 = (v125 | 0);
    }
    const v126: int32 = v12.length | 0;
    const v127: [US2, string][] = fill(new Array(v126), 0, v126, null);
    const v128: Mut6 = new Mut6(0);
    while (method21(v126, v128)) {
        const v130: int32 = v128.l0 | 0;
        const patternInput_4: [US2, any, string] = v12[v130];
        v127[v130] = [patternInput_4[0], patternInput_4[2]];
        const v134: int32 = (v130 + 1) | 0;
        v128.l0 = (v134 | 0);
    }
    if ((((v118.length === v127.length) !== true) ? false : method81(v118, v127, 0)) !== true) {
        const v144: (arg0: any[]) => void = partialApply(1, v4, [US4_US4_2()]);
        const v147: [string, any][] = fill(new Array(v126), 0, v126, null);
        const v148: Mut6 = new Mut6(0);
        while (method21(v126, v148)) {
            const v150: int32 = v148.l0 | 0;
            const patternInput_5: [US2, any, string] = v12[v150];
            const v151: US2 = patternInput_5[0];
            const v161: string = (v151.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v151.tag === US2_Tag.US2_2) ? "Memory" : ((v151.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"));
            v147[v150] = [v161, patternInput_5[1]];
            const v162: int32 = (v150 + 1) | 0;
            v148.l0 = (v162 | 0);
        }
        v144(["> use_fetch > connections_change", ["new_subscriptions", v147]]);
        v2(v12);
    }
}

export function closure294(v0_1: () => [US2, any, string][], v1_1: (arg0: [US2, any, string][]) => void, unitVar: void): void {
    v1_1(v0_1());
}

export function closure296(v0_1: string, unitVar: void): any[] {
    return [["content_address", v0_1]];
}

export function closure295(v0_1: (arg0: [US2, any, string][]) => void, v1_1: string, v2: () => US4, v3: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1.clear();
    v3(US4_US4_0(), ["> use_fetch > unsubscribe () [1]"]);
    const v13: () => any[] = (): any[] => closure296(v1_1, void 0);
    method17(v2, v13, "#666")(US4_US4_0())(["> db_off ()"]);
}

export function closure298(v0_1: string, v1_1: () => [string, int32][], v2: (arg0: [[string, int32][], US2, string, int32]) => void, v3: () => US4, v4: (arg0: US16) => void, v5: () => US16, v6: (arg0: US4, arg1: any[]) => void, v7: [US2, any, string][], v8: string, v9: int32): void {
    method79(v0_1, v1_1, v2, v3, v4, v5, v6, US2_US2_2(), v7, v9, v8);
}

export function closure297(v0_1: (arg0: any) => any, v1_1: () => [US2, any, string][], v2: string, v3: () => [string, int32][], v4: (arg0: [[string, int32][], US2, string, int32]) => void, v5: () => US4, v6: (arg0: US16) => void, v7: () => US16, v8: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    const v9: [US2, any, string][] = v1_1();
    const v10: int64 = getTicks(utcNow());
    const v12: string = newGuid();
    const v13: string = toString(v10);
    const v14: string = parse_1(`${v13.slice(0, 7 + 1)}-${v13.slice(8, 11 + 1)}-${v13.slice(12, 15 + 1)}-${v13.slice(16, 17 + 1)}${v12.slice(21, v12.length)}`);
    const v17: (arg0: int32) => void = (v: int32): void => {
        closure298(v2, v3, v4, v5, v6, v7, v8, v9, v14, v);
    };
    const pr: any = v0_1();
    void (pr.then(v17));
}

export function closure299(v0_1: () => [US2, any, string][], v1_1: (arg0: US4, arg1: any[]) => void, v2: string, v3: () => [string, int32][], v4: (arg0: [[string, int32][], US2, string, int32]) => void, v5: () => US4, v6: (arg0: US16) => void, v7: () => US16, unitVar: void): void {
    v1_1(US4_US4_2(), [">> use_fetch clear ()"]);
    const v13: [US2, any, string][] = v0_1();
    const v14: int64 = getTicks(utcNow());
    const v16: string = newGuid();
    const v17: string = toString(v14);
    const v18: string = parse_1(`${v17.slice(0, 7 + 1)}-${v17.slice(8, 11 + 1)}-${v17.slice(12, 15 + 1)}-${v17.slice(16, 17 + 1)}${v16.slice(21, v16.length)}`);
    method79(v2, v3, v4, v5, v6, v7, v1_1, US2_US2_2(), v13, null, v18);
}

export function method74(v0_1: string, v1_1: () => [string, int32][], v2: (arg0: [[string, int32][], US2, string, int32]) => void, v3: (arg0: any) => any): [() => void, () => void] {
    const v99: any = components.state_context;
    const v102: any = useContext;
    const v121: () => US4 = (v102(v99))[18];
    const v220: any = components.state_context;
    const v221: any = useContext;
    const v232: () => [US2, any, string][] = (v221(v220))[10];
    const patternInput_2: [() => void, () => void] = method75();
    const patternInput_3: [() => void, () => void] = method75();
    const patternInput_4: [() => US16, (arg0: US16) => void] = method76(US16_US16_0());
    const v250: (arg0: US16) => void = patternInput_4[1];
    const v249: () => US16 = patternInput_4[0];
    const patternInput_5: [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] = method77([]);
    const v252: () => [US2, any, string][] = patternInput_5[0];
    const v254: uint8[] = Array.from(get_UTF8().getBytes(v0_1));
    const v255: int32 = v254.length | 0;
    const v256: Mut25 = new Mut25(0, 100000);
    while (method71(v255, v256)) {
        const v258: int32 = v256.l0 | 0;
        const v263: int32 = (v256.l1 + (v254[v258] * 14)) | 0;
        const v264: int32 = (v258 + 1) | 0;
        v256.l0 = (v264 | 0);
        v256.l1 = (v263 | 0);
    }
    const v268: () => any[] = (): any[] => closure282(v0_1, v1_1, v232, patternInput_2[0], patternInput_3[0], v249, v252, void 0);
    const v269: (arg0: US4, arg1: any[]) => void = method16(v268, `#${int32ToString(v256.l1)}`);
    v269(US4_US4_0())(["> use_fetch ()"]);
    const v277: any = debounce;
    const v278: (arg0: [US2, any, string][]) => void = (v: [US2, any, string][]): void => {
        closure283(v0_1, v121, patternInput_5[1], v252, uncurry(2, v269), v1_1, v2, v250, v249, v);
    };
    const v279: (arg0: [US2, any, string][]) => void = v277(v278, 2500);
    const v281: any = createEffect;
    const v282: () => void = (): void => {
        closure294(v232, v279, void 0);
    };
    v281(v282);
    const v284: any = onCleanup;
    const v285: () => void = (): void => {
        closure295(v279, v0_1, v121, uncurry(2, v269), void 0);
    };
    v284(v285);
    const v286: () => void = (): void => {
        closure297(v3, v232, v0_1, v1_1, v2, v121, v250, v249, uncurry(2, v269), void 0);
    };
    const v287: () => void = (): void => {
        closure299(v232, uncurry(2, v269), v0_1, v1_1, v2, v121, v250, v249, void 0);
    };
    return [v286, v287];
}

export function closure301(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [US6_US6_1(method13("baseline", "center")), _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], US6_US6_1(method13("column", "row")), _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US6_US6_1(method13("8px", "0")), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], US6_US6_1("7px"), _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure303(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure304(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Counter
    </>];
}

export function closure306(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularPlus;
    return v2;
}

export function closure307(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_0(), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure305(v0_1: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v72_1: () => any = (): any => closure306(void 0, void 0);
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure307(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], US11_US11_1(method48(v71, v72_1, v73_1, v74_1)), _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v0_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("10px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure308(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure310(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularMinus;
    return v2;
}

export function closure311(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_0(), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure309(v0_1: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v72_1: () => any = (): any => closure310(void 0, void 0);
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure311(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], US11_US11_1(method48(v71, v72_1, v73_1, v74_1)), _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v0_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("10px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure312(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure302(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure303(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure304(void 0, void 0);
    const v8: (arg0: Mut1) => any = (v: Mut1): any => closure47(void 0, v);
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure305(v1_1, arg10$0040_2);
    const v10: () => any[] = (): any[] => closure308(void 0, void 0);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure309(v0_1, arg10$0040_4);
    const v13: () => any[] = (): any[] => closure312(void 0, void 0);
    return [method5(v4, v5, v6), method22(v8, v9, v10), method22(v8, v12, v13)];
}

export function method82(v0_1: int32, v1_1: Mut28): boolean {
    return v1_1.l0 < v0_1;
}

export function method83(v0_1_mut: UH3, v1_1_mut: UH3): UH3 {
    method83:
    while (true) {
        const v0_1: UH3 = v0_1_mut, v1_1: UH3 = v1_1_mut;
        if (v0_1.tag === UH3_Tag.UH3_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH3_UH3_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method83;
        }
        break;
    }
}

export function method85(v0_1_mut: UH3, v1_1_mut: int32): int32 {
    method85:
    while (true) {
        const v0_1: UH3 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH3_Tag.UH3_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method85;
        }
        break;
    }
}

export function method86(v0_1_mut: [string, int32][], v1_1_mut: UH3, v2_mut: int32): int32 {
    method86:
    while (true) {
        const v0_1: [string, int32][] = v0_1_mut, v1_1: UH3 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH3_Tag.UH3_1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = [v1_1.fields[0], v1_1.fields[1]];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[2];
            v2_mut = (v2 + 1);
            continue method86;
        }
        break;
    }
}

export function method84(v0_1: UH3): [string, int32][] {
    const v2: int32 = method85(v0_1, 0) | 0;
    const v3: [string, int32][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method86(v3, v0_1, 0) | 0;
    return v3;
}

export function closure319(v0_1: int32, v1_1: int32, unitVar: void): any[] {
    return [<>
        {`[${v0_1}=${JSON.stringify(v1_1, null, 2)}]`}
    </>];
}

export function closure318(v0_1: int32, v1_1: int32, unitVar: void): any[] {
    const v4: any = hope;
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v10: () => any[] = (): any[] => closure319(v0_1, v1_1, void 0);
    return [method5(v4.pre, v9, v10)];
}

export function closure317(v0_1: int32, v1_1: int32, v2: string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure318(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure316(v0_1: () => [string, int32], v1_1: int32): any[] {
    const patternInput: [string, int32] = v0_1();
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure317(v1_1, patternInput[1], patternInput[0], arg10$0040);
    return [method26(v4, US13_US13_0(), US13_US13_0(), v7, US15_US15_2())];
}

export function closure315(unitVar: void, v0_1: () => [string, int32]): (arg0: int32) => any[] {
    return (v: int32): any[] => closure316(v0_1, v);
}

export function closure320(v0_1: [string, int32][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US10_US10_1(v0_1), _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure314(v0_1: () => [string, int32][], unitVar: void): any[] {
    let clo: () => any[];
    const v1_1: [string, int32][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut28 = new Mut28(0, UH3_UH3_1());
    while (method82(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH3 = v4.l1;
        const patternInput: [string, int32] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH3_UH3_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [string, int32][] = method84(method83(v4.l1, UH3_UH3_1()));
    const v19: (arg0: () => [string, int32], arg1: int32) => any[] = (v: () => [string, int32]): (arg0: int32) => any[] => closure315(void 0, v);
    const v23: any = Index;
    const v24: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure320(v18, arg10$0040);
    return [method5(v23, v24, (clo = ((item: any, index: () => number) => v19(item)(index)), clo))];
}

export function closure313(v0_1: () => [string, int32][], unitVar: void): any[] {
    const v1_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure314(v0_1, void 0);
    return [method22(v1_1, v2, v3)];
}

export function closure300(v0_1: () => [string, int32][], v1_1: () => void, v2: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: any = Stack;
    const v76_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure301(void 0, arg10$0040);
    const v77_1: () => any[] = (): any[] => closure302(v1_1, v2, void 0);
    const v79: () => any[] = (): any[] => closure313(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v79), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_1("counter"), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(method5(v75_1, v76_1, v77_1)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method73(): any {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    const v115: () => [string, int32][] = patternInput[16];
    const v121: () => any[] = (): any[] => closure276(v115, void 0);
    const v123: (arg0: US4, arg1: any[]) => void = method16(v121, "#666");
    v123(US4_US4_0())(["> counter ()"]);
    const v130: any = createEffect;
    const v131: () => void = (): void => {
        closure277(uncurry(2, v123), void 0);
    };
    v130(v131);
    const v133: (arg0: [[string, int32][], US2, string, int32]) => void = (arg10$0040_2: [[string, int32][], US2, string, int32]): void => {
        closure278(patternInput[17], arg10$0040_2);
    };
    const v134: (arg0: any) => any = (v: any): any => closure279(v115, v);
    const patternInput_1: [() => void, () => void] = method74("profile/tmp/counter", v115, v133, v134);
    const v137: (arg0: Mut3) => any = (v_1: Mut3): any => closure14(void 0, v_1);
    const v140: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure300(v115, patternInput_1[1], patternInput_1[0], arg10$0040_3);
    return method26(v137, US13_US13_0(), US13_US13_0(), v140, US15_US15_2());
}

export function closure275(unitVar: void, v0_1: Mut1): any {
    return method73();
}

export function closure321(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure323(v0_1: (arg0: [string, any][]) => void, _arg: [[string, any][], US2, string, [string, any][]]): void {
    v0_1(_arg[3]);
}

export function closure326(v0_1: () => [string, any][], v1_1: (arg0: [string, any][]) => void, v2: (arg0: Error) => void): void {
    v1_1(v0_1());
}

export function closure325(v0_1: () => [string, any][], v1_1: (arg0: [string, any][]) => void): (arg0: (arg0: Error) => void) => void {
    return (v: (arg0: Error) => void): void => {
        closure326(v0_1, v1_1, v);
    };
}

export function closure324(v0_1: () => [string, any][], v1_1: any): any {
    const v2: (arg0: (arg0: [string, any][]) => void, arg1: (arg0: Error) => void) => void = (v: (arg0: [string, any][]) => void): (arg0: (arg0: Error) => void) => void => closure325(v0_1, v);
    return new Promise(uncurry(2, v2));
}

export function method89(v0_1: US19): [() => US19, (arg0: US19) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: US19): void => {
        value_2(arg_1);
    })];
}

export function closure327(v0_1: string, v1_1: () => [string, any][], v2: () => [US2, any, string][], v3: () => void, v4: () => void, v5: () => US19, v6: () => [US2, any, string][], unitVar: void): any[] {
    const v9: [string, any][] = v1_1();
    v3();
    v4();
    const v16: US19 = v5();
    const v19: [US2, any, string][] = v6();
    const v20: int32 = v19.length | 0;
    const v21: [string, any][] = fill(new Array(v20), 0, v20, null);
    const v22: Mut6 = new Mut6(0);
    while (method21(v20, v22)) {
        const v24: int32 = v22.l0 | 0;
        const patternInput: [US2, any, string] = v19[v24];
        const v25: US2 = patternInput[0];
        const v35: string = (v25.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v25.tag === US2_Tag.US2_2) ? "Memory" : ((v25.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"));
        v21[v24] = [v35, patternInput[1]];
        const v36: int32 = (v24 + 1) | 0;
        v22.l0 = (v36 | 0);
    }
    const v39: [US2, any, string][] = v2();
    const v40: int32 = v39.length | 0;
    const v41: string[] = fill(new Array(v40), 0, v40, "");
    const v42: Mut6 = new Mut6(0);
    while (method21(v40, v42)) {
        const v44: int32 = v42.l0 | 0;
        const v45: US2 = v39[v44][0];
        const v55: string = (v45.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v45.tag === US2_Tag.US2_2) ? "Memory" : ((v45.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"));
        v41[v44] = v55;
        const v56: int32 = (v44 + 1) | 0;
        v42.l0 = (v56 | 0);
    }
    return [["content_address", v0_1], ["getter", v9], "events", "timers", ["value", v16], ["subscriptions", v21], ["db_connections", v41]];
}

export function closure331(v0_1: US2, v1_1: string, v2: [string, any][], unitVar: void): any[] {
    return [["content_address", v1_1], ["client_type", (v0_1.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v0_1.tag === US2_Tag.US2_2) ? "Memory" : ((v0_1.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))], ["new_value", v2]];
}

export function method90(v0_1: string, v1_1: () => [string, any][], v2: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v3: () => US4, v4: (arg0: US19) => void, v5: () => US19, v6: (arg0: US4, arg1: any[]) => void, v7: US2, v8: [US2, any, string][], v9: [string, any][], v10: string): void {
    let v15: (arg0: string) => int64, copyOfStruct: US2;
    const v11: US19 = v5();
    if ((v11.tag === US19_Tag.US19_1) ? ((v15 = ((v: string): int64 => closure287(void 0, v)), (!equalsWith(equalArrays, v11.fields[2], v9)) && (compare(v15(v10), v15(v11.fields[1])) > 0))) : true) {
        const v19: [string, any][] = v1_1();
        const v24: string = "old_value";
        const v34: string = "client_type";
        const v36: string = "new_guid\'";
        const v38: string = "new_value_raw";
        v6(US4_US4_2(), ["> use_fetch > on_value > set ()", [v24, v19], [v34, (v7.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v7.tag === US2_Tag.US2_2) ? "Memory" : ((v7.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))], [v36, v10], [v38, v9]]);
        v2([v19, v7, v10, v9]);
        v4(US19_US19_1(v7, v10, v9));
        const v42: int32 = v8.length | 0;
        const v43: Mut6 = new Mut6(0);
        while (method21(v42, v43)) {
            const v45: int32 = v43.l0 | 0;
            const patternInput: [US2, any, string] = v8[v45];
            const v47: any = patternInput[1];
            const v46: US2 = patternInput[0];
            if (((copyOfStruct = v46, (copyOfStruct.tag === US2_Tag.US2_1) ? (v7.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v7.tag === US2_Tag.US2_2) : ((copyOfStruct.tag === US2_Tag.US2_3) ? (v7.tag === US2_Tag.US2_3) : (v7.tag === US2_Tag.US2_0))))) !== true) {
                v6(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v24, v19], [v34, (v7.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v7.tag === US2_Tag.US2_2) ? "Memory" : ((v7.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))], [v36, v10], [v38, v9], ["connection_client_type", (v46.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v46.tag === US2_Tag.US2_2) ? "Memory" : ((v46.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"))]]);
                const v78: () => any[] = (): any[] => closure331(v46, v0_1, v9, void 0);
                const v80: (arg0: US4, arg1: any[]) => void = method17(v3, v78, "#666");
                v80(US4_US4_0())(["> db_put ()"]);
                switch (v46.tag) {
                    case 1: {
                        const v92: string[] = v0_1.split("/");
                        const v93: string = "get";
                        const v97: any = v47[v93]("tictactoe");
                        const v98: int32 = v92.length | 0;
                        const v99: Mut27 = new Mut27(0, v97);
                        while (method80(v98, v99)) {
                            const v101: int32 = v99.l0 | 0;
                            const v102: any = v99.l1;
                            const v103: string = v92[v101];
                            const v106: any = v102[v93](v103);
                            const v107: int32 = (v101 + 1) | 0;
                            v99.l0 = (v107 | 0);
                            v99.l1 = v106;
                        }
                        const v108: any = v99.l1;
                        v108.put(v9);
                        break;
                    }
                    case 2: {
                        throw new Error("db_on Memory");
                        break;
                    }
                    case 3: {
                        const v91: (arg0: UH1) => void = (v_1: UH1): void => {
                            closure289(uncurry(2, v80), v_1);
                        };
                        const pr: any = HubConnection$5__invokeAsPromise_2B595<UH0, UH0, void, UH1, UH1>(v47, UH0_UH0_3("alias", v0_1, v9));
                        void (pr.then(v91));
                        break;
                    }
                    default: {
                        const v112: string[] = v0_1.split("/");
                        const v113: string = "get";
                        const v117: any = v47[v113]("tictactoe");
                        const v118: int32 = v112.length | 0;
                        const v119: Mut27 = new Mut27(0, v117);
                        while (method80(v118, v119)) {
                            const v121: int32 = v119.l0 | 0;
                            const v122: any = v119.l1;
                            const v123: string = v112[v121];
                            const v126: any = v122[v113](v123);
                            const v127: int32 = (v121 + 1) | 0;
                            v119.l0 = (v127 | 0);
                            v119.l1 = v126;
                        }
                        const v128: any = v119.l1;
                        v128.put(v9);
                    }
                }
            }
            const v132: int32 = (v45 + 1) | 0;
            v43.l0 = (v132 | 0);
        }
    }
}

export function closure330(v0_1: string, v1_1: () => [string, any][], v2: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v3: () => US4, v4: (arg0: US19) => void, v5: () => US19, v6: (arg0: US4, arg1: any[]) => void, v7: US2, v8: [US2, any, string][], v9: (arg0: US4, arg1: any[]) => void, v10: string, v11: [string, any][], v12: any): void {
    v9(US4_US4_2(), ["> db_on > on_value ()", ["v", v10, v11], ["k", v12]]);
    method90(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v11, v10);
}

export function closure329(v0_1: string, v1_1: () => [string, any][], v2: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v3: () => US4, v4: (arg0: US19) => void, v5: () => US19, v6: (arg0: US4, arg1: any[]) => void, v7: US2, v8: [US2, any, string][], v9: (arg0: US4, arg1: any[]) => void, _arg: [string, [string, any][]]): (arg0: any) => void {
    return (v: any): void => {
        closure330(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, _arg[0], _arg[1], v);
    };
}

export function closure328(v0_1: string, v1_1: () => US4, v2: (arg0: [US2, any, string][]) => void, v3: () => [US2, any, string][], v4: (arg0: US4, arg1: any[]) => void, v5: () => [string, any][], v6: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v7: (arg0: US19) => void, v8: () => US19, v9: [US2, any, string][]): void {
    let copyOfStruct: US2, v59: string[], v60: string, v64: any, v65: int32, v66: Mut27, v75_1: any, v79: int64, v57: (arg0: any) => US17, pr: any, v82: string[], v83: string, v87: any, v88: int32, v89: Mut27, v98: any, v102: int64;
    const v10: [US2, any, string][] = v3();
    const v11: int32 = v9.length | 0;
    const v12: [US2, any, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut6 = new Mut6(0);
    while (method21(v11, v13)) {
        const v15: int32 = v13.l0 | 0;
        const patternInput: [US2, any, string] = v9[v15];
        const v18: string = patternInput[2];
        const v17: any = patternInput[1];
        const v16: US2 = patternInput[0];
        const v19: int32 = v10.length | 0;
        const v21: Mut26 = new Mut26(0, US18_US18_0());
        while (method78(v19, v21)) {
            const v23: int32 = v21.l0 | 0;
            const v26: int32 = ((op_UnaryNegation_Int32(v23) + v19) - 1) | 0;
            const v27: US18 = v21.l1;
            const patternInput_1: [US2, any, string] = v10[v26];
            const v30: string = patternInput_1[2];
            const v28: US2 = patternInput_1[0];
            const v37: US18 = (v27.tag === US18_Tag.US18_0) ? ((((copyOfStruct = v28, (copyOfStruct.tag === US2_Tag.US2_1) ? (v16.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v16.tag === US2_Tag.US2_2) : ((copyOfStruct.tag === US2_Tag.US2_3) ? (v16.tag === US2_Tag.US2_3) : (v16.tag === US2_Tag.US2_0))))) && (v30 === v18)) ? US18_US18_1(v28, patternInput_1[1], v30) : US18_US18_0()) : v27;
            const v38: int32 = (v23 + 1) | 0;
            v21.l0 = (v38 | 0);
            v21.l1 = v37;
        }
        const v39: US18 = v21.l1;
        let patternInput_2: [US2, any, string];
        if (v39.tag === US18_Tag.US18_1) {
            patternInput_2 = [v39.fields[0], v39.fields[1], v39.fields[2]];
        }
        else {
            const v43: () => any[] = (): any[] => closure284(v0_1, v16, void 0);
            const v45: (arg0: US4, arg1: any[]) => void = method17(v1_1, v43, "#666");
            v45(US4_US4_0())(["> db_on ()"]);
            const v51: (arg0: [string, [string, any][]], arg1: any) => void = (arg10$0040_1: [string, [string, any][]]): (arg0: any) => void => closure329(v0_1, v5, v6, v1_1, v7, v8, v4, v16, v9, uncurry(2, v45), arg10$0040_1);
            let v52: (arg0: [any, int32]) => void;
            const clo: (arg0: [any, int32]) => void = (v: any, k: any) => v51(v)(k);
            v52 = ((arg: [any, int32]): void => {
                clo(arg);
            });
            patternInput_2 = [v16, (v16.tag === US2_Tag.US2_1) ? ((v59 = v0_1.split("/"), (v60 = "get", (v64 = v17[v60]("tictactoe"), (v65 = (v59.length | 0), (v66 = (new Mut27(0, v64)), ((() => {
                while (method80(v65, v66)) {
                    const v68: int32 = v66.l0 | 0;
                    const v69: any = v66.l1;
                    const v70: string = v59[v68];
                    const v73_1: any = v69[v60](v70);
                    const v74_1: int32 = (v68 + 1) | 0;
                    v66.l0 = (v74_1 | 0);
                    v66.l1 = v73_1;
                }
            })(), (v75_1 = v66.l1, (v79 = v75_1.on(v52), Promise.resolve(US17_US17_1(v79))))))))))) : ((v16.tag === US2_Tag.US2_2) ? (() => {
                throw new Error("db_on Memory");
            })() : ((v16.tag === US2_Tag.US2_3) ? ((v57 = ((v: any): US17 => closure290(uncurry(2, v45), v)), (pr = HubConnection$5__streamFromAsPromise_2B594<UH0, UH0, void, UH1, UH1>(v17, UH0_UH0_1("alias", v0_1)), pr.then(v57)))) : ((v82 = v0_1.split("/"), (v83 = "get", (v87 = v17[v83]("tictactoe"), (v88 = (v82.length | 0), (v89 = (new Mut27(0, v87)), ((() => {
                while (method80(v88, v89)) {
                    const v91: int32 = v89.l0 | 0;
                    const v92: any = v89.l1;
                    const v93: string = v82[v91];
                    const v96: any = v92[v83](v93);
                    const v97: int32 = (v91 + 1) | 0;
                    v89.l0 = (v97 | 0);
                    v89.l1 = v96;
                }
            })(), (v98 = v89.l1, (v98.on(v52), (v102 = getTicks(utcNow()), Promise.resolve(US17_US17_1(v102)))))))))))))), v18];
        }
        v12[v15] = [patternInput_2[0], patternInput_2[1], patternInput_2[2]];
        const v116: int32 = (v15 + 1) | 0;
        v13.l0 = (v116 | 0);
    }
    const v117: int32 = v10.length | 0;
    const v118: [US2, string][] = fill(new Array(v117), 0, v117, null);
    const v119: Mut6 = new Mut6(0);
    while (method21(v117, v119)) {
        const v121: int32 = v119.l0 | 0;
        const patternInput_3: [US2, any, string] = v10[v121];
        v118[v121] = [patternInput_3[0], patternInput_3[2]];
        const v125: int32 = (v121 + 1) | 0;
        v119.l0 = (v125 | 0);
    }
    const v126: int32 = v12.length | 0;
    const v127: [US2, string][] = fill(new Array(v126), 0, v126, null);
    const v128: Mut6 = new Mut6(0);
    while (method21(v126, v128)) {
        const v130: int32 = v128.l0 | 0;
        const patternInput_4: [US2, any, string] = v12[v130];
        v127[v130] = [patternInput_4[0], patternInput_4[2]];
        const v134: int32 = (v130 + 1) | 0;
        v128.l0 = (v134 | 0);
    }
    if ((((v118.length === v127.length) !== true) ? false : method81(v118, v127, 0)) !== true) {
        const v144: (arg0: any[]) => void = partialApply(1, v4, [US4_US4_2()]);
        const v147: [string, any][] = fill(new Array(v126), 0, v126, null);
        const v148: Mut6 = new Mut6(0);
        while (method21(v126, v148)) {
            const v150: int32 = v148.l0 | 0;
            const patternInput_5: [US2, any, string] = v12[v150];
            const v151: US2 = patternInput_5[0];
            const v161: string = (v151.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v151.tag === US2_Tag.US2_2) ? "Memory" : ((v151.tag === US2_Tag.US2_3) ? "SignalR" : "Gun JavaScript"));
            v147[v150] = [v161, patternInput_5[1]];
            const v162: int32 = (v150 + 1) | 0;
            v148.l0 = (v162 | 0);
        }
        v144(["> use_fetch > connections_change", ["new_subscriptions", v147]]);
        v2(v12);
    }
}

export function closure333(v0_1: string, v1_1: () => [string, any][], v2: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v3: () => US4, v4: (arg0: US19) => void, v5: () => US19, v6: (arg0: US4, arg1: any[]) => void, v7: [US2, any, string][], v8: string, v9: [string, any][]): void {
    method90(v0_1, v1_1, v2, v3, v4, v5, v6, US2_US2_2(), v7, v9, v8);
}

export function closure332(v0_1: (arg0: any) => any, v1_1: () => [US2, any, string][], v2: string, v3: () => [string, any][], v4: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v5: () => US4, v6: (arg0: US19) => void, v7: () => US19, v8: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    const v9: [US2, any, string][] = v1_1();
    const v10: int64 = getTicks(utcNow());
    const v12: string = newGuid();
    const v13: string = toString(v10);
    const v14: string = parse_1(`${v13.slice(0, 7 + 1)}-${v13.slice(8, 11 + 1)}-${v13.slice(12, 15 + 1)}-${v13.slice(16, 17 + 1)}${v12.slice(21, v12.length)}`);
    const v17: (arg0: [string, any][]) => void = (v: [string, any][]): void => {
        closure333(v2, v3, v4, v5, v6, v7, v8, v9, v14, v);
    };
    const pr: any = v0_1();
    void (pr.then(v17));
}

export function closure334(v0_1: () => [US2, any, string][], v1_1: (arg0: US4, arg1: any[]) => void, v2: string, v3: () => [string, any][], v4: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v5: () => US4, v6: (arg0: US19) => void, v7: () => US19, unitVar: void): void {
    v1_1(US4_US4_2(), [">> use_fetch clear ()"]);
    const v13: [US2, any, string][] = v0_1();
    const v14: int64 = getTicks(utcNow());
    const v16: string = newGuid();
    const v17: string = toString(v14);
    const v18: string = parse_1(`${v17.slice(0, 7 + 1)}-${v17.slice(8, 11 + 1)}-${v17.slice(12, 15 + 1)}-${v17.slice(16, 17 + 1)}${v16.slice(21, v16.length)}`);
    method90(v2, v3, v4, v5, v6, v7, v1_1, US2_US2_2(), v13, null, v18);
}

export function method88(v0_1: string, v1_1: () => [string, any][], v2: (arg0: [[string, any][], US2, string, [string, any][]]) => void, v3: (arg0: any) => any): [() => void, () => void] {
    const v99: any = components.state_context;
    const v102: any = useContext;
    const v121: () => US4 = (v102(v99))[18];
    const v220: any = components.state_context;
    const v221: any = useContext;
    const v232: () => [US2, any, string][] = (v221(v220))[10];
    const patternInput_2: [() => void, () => void] = method75();
    const patternInput_3: [() => void, () => void] = method75();
    const patternInput_4: [() => US19, (arg0: US19) => void] = method89(US19_US19_0());
    const v250: (arg0: US19) => void = patternInput_4[1];
    const v249: () => US19 = patternInput_4[0];
    const patternInput_5: [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] = method77([]);
    const v252: () => [US2, any, string][] = patternInput_5[0];
    const v254: uint8[] = Array.from(get_UTF8().getBytes(v0_1));
    const v255: int32 = v254.length | 0;
    const v256: Mut25 = new Mut25(0, 100000);
    while (method71(v255, v256)) {
        const v258: int32 = v256.l0 | 0;
        const v263: int32 = (v256.l1 + (v254[v258] * 14)) | 0;
        const v264: int32 = (v258 + 1) | 0;
        v256.l0 = (v264 | 0);
        v256.l1 = (v263 | 0);
    }
    const v268: () => any[] = (): any[] => closure327(v0_1, v1_1, v232, patternInput_2[0], patternInput_3[0], v249, v252, void 0);
    const v269: (arg0: US4, arg1: any[]) => void = method16(v268, `#${int32ToString(v256.l1)}`);
    v269(US4_US4_0())(["> use_fetch ()"]);
    const v277: any = debounce;
    const v278: (arg0: [US2, any, string][]) => void = (v: [US2, any, string][]): void => {
        closure328(v0_1, v121, patternInput_5[1], v252, uncurry(2, v269), v1_1, v2, v250, v249, v);
    };
    const v279: (arg0: [US2, any, string][]) => void = v277(v278, 2500);
    const v281: any = createEffect;
    const v282: () => void = (): void => {
        closure294(v232, v279, void 0);
    };
    v281(v282);
    const v284: any = onCleanup;
    const v285: () => void = (): void => {
        closure295(v279, v0_1, v121, uncurry(2, v269), void 0);
    };
    v284(v285);
    const v286: () => void = (): void => {
        closure332(v3, v232, v0_1, v1_1, v2, v121, v250, v249, uncurry(2, v269), void 0);
    };
    const v287: () => void = (): void => {
        closure334(v232, uncurry(2, v269), v0_1, v1_1, v2, v121, v250, v249, void 0);
    };
    return [v286, v287];
}

export function closure336(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [US6_US6_1(method13("baseline", "center")), _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], US6_US6_1(method13("column", "row")), _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US6_US6_1(method13("8px", "0")), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], US6_US6_1("7px"), _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure338(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Status
    </>];
}

export function closure340(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_0(), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure339(v0_1: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v72_1: () => any = (): any => closure306(void 0, void 0);
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure340(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], US11_US11_1(method48(v71, v72_1, v73_1, v74_1)), _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v0_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("10px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure341(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure343(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_0(), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure342(v0_1: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v72_1: () => any = (): any => closure310(void 0, void 0);
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure343(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], US11_US11_1(method48(v71, v72_1, v73_1, v74_1)), _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v0_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("10px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure344(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure337(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure338(void 0, void 0);
    const v8: (arg0: Mut1) => any = (v: Mut1): any => closure47(void 0, v);
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure339(v1_1, arg10$0040_2);
    const v10: () => any[] = (): any[] => closure341(void 0, void 0);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure342(v0_1, arg10$0040_4);
    const v13: () => any[] = (): any[] => closure344(void 0, void 0);
    return [method5(v4, v5, v6), method22(v8, v9, v10), method22(v8, v12, v13)];
}

export function method91(v0_1: int32, v1_1: Mut29): boolean {
    return v1_1.l0 < v0_1;
}

export function method92(v0_1_mut: UH4, v1_1_mut: UH4): UH4 {
    method92:
    while (true) {
        const v0_1: UH4 = v0_1_mut, v1_1: UH4 = v1_1_mut;
        if (v0_1.tag === UH4_Tag.UH4_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH4_UH4_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method92;
        }
        break;
    }
}

export function method94(v0_1_mut: UH4, v1_1_mut: int32): int32 {
    method94:
    while (true) {
        const v0_1: UH4 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH4_Tag.UH4_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method94;
        }
        break;
    }
}

export function method95(v0_1_mut: [string, any][], v1_1_mut: UH4, v2_mut: int32): int32 {
    method95:
    while (true) {
        const v0_1: [string, any][] = v0_1_mut, v1_1: UH4 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH4_Tag.UH4_1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = [v1_1.fields[0], v1_1.fields[1]];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[2];
            v2_mut = (v2 + 1);
            continue method95;
        }
        break;
    }
}

export function method93(v0_1: UH4): [string, any][] {
    const v2: int32 = method94(v0_1, 0) | 0;
    const v3: [string, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method95(v3, v0_1, 0) | 0;
    return v3;
}

export function closure351(v0_1: () => [string, any], unitVar: void): any[] {
    const patternInput: [string, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure350(v0_1: () => [string, any], unitVar: void): any[] {
    const v3: any = hope;
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v9: () => any[] = (): any[] => closure351(v0_1, void 0);
    return [method5(v3.pre, v8, v9)];
}

export function closure349(v0_1: () => [string, any], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure350(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1()[0]}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure348(v0_1: () => [string, any], v1_1: int32): any[] {
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure349(v0_1, arg10$0040);
    return [method26(v2, US13_US13_0(), US13_US13_0(), v5, US15_US15_2())];
}

export function closure347(unitVar: void, v0_1: () => [string, any]): (arg0: int32) => any[] {
    return (v: int32): any[] => closure348(v0_1, v);
}

export function closure352(v0_1: [string, any][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US10_US10_1(v0_1), _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure346(v0_1: () => [string, any][], unitVar: void): any[] {
    let clo: () => any[];
    const v1_1: [string, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut29 = new Mut29(0, UH4_UH4_1());
    while (method91(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH4 = v4.l1;
        const patternInput: [string, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH4_UH4_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [string, any][] = method93(method92(v4.l1, UH4_UH4_1()));
    const v19: (arg0: () => [string, any], arg1: int32) => any[] = (v: () => [string, any]): (arg0: int32) => any[] => closure347(void 0, v);
    const v23: any = Index;
    const v24: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure352(v18, arg10$0040);
    return [method5(v23, v24, (clo = ((item: any, index: () => number) => v19(item)(index)), clo))];
}

export function closure345(v0_1: () => [string, any][], unitVar: void): any[] {
    const v1_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure346(v0_1, void 0);
    return [method22(v1_1, v2, v3)];
}

export function closure335(v0_1: () => [string, any][], v1_1: () => void, v2: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: any = Stack;
    const v76_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure336(void 0, arg10$0040);
    const v77_1: () => any[] = (): any[] => closure337(v1_1, v2, void 0);
    const v79: () => any[] = (): any[] => closure345(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v79), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_1("status"), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(method5(v75_1, v76_1, v77_1)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method87(): any {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    const v113: () => [string, any][] = patternInput[14];
    const v122: (arg0: [[string, any][], US2, string, [string, any][]]) => void = (arg10$0040: [[string, any][], US2, string, [string, any][]]): void => {
        closure323(patternInput[15], arg10$0040);
    };
    const v123: (arg0: any) => any = (v: any): any => closure324(v113, v);
    const patternInput_1: [() => void, () => void] = method88("profile/tmp/chain_status", v113, v122, v123);
    const v126: (arg0: Mut3) => any = (v_1: Mut3): any => closure14(void 0, v_1);
    const v129: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure335(v113, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    return method26(v126, US13_US13_0(), US13_US13_0(), v129, US15_US15_2());
}

export function closure322(unitVar: void, v0_1: Mut1): any {
    return method87();
}

export function closure353(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure355(v0_1: (arg0: [string, any][]) => void, _arg: [[string, any][], US2, string, [string, any][]]): void {
    v0_1(_arg[3]);
}

export function closure358(v0_1: () => [string, any][], v1_1: (arg0: [string, any][]) => void, v2: (arg0: Error) => void): void {
    v1_1(v0_1());
}

export function closure357(v0_1: () => [string, any][], v1_1: (arg0: [string, any][]) => void): (arg0: (arg0: Error) => void) => void {
    return (v: (arg0: Error) => void): void => {
        closure358(v0_1, v1_1, v);
    };
}

export function closure356(v0_1: () => [string, any][], v1_1: any): any {
    const v2: (arg0: (arg0: [string, any][]) => void, arg1: (arg0: Error) => void) => void = (v: (arg0: [string, any][]) => void): (arg0: (arg0: Error) => void) => void => closure357(v0_1, v);
    return new Promise(uncurry(2, v2));
}

export function closure360(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [US6_US6_1(method13("baseline", "center")), _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], US6_US6_1(method13("column", "row")), _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US6_US6_1(method13("8px", "0")), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], US6_US6_1("7px"), _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure362(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Deploy
    </>];
}

export function closure364(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_0(), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure363(v0_1: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v72_1: () => any = (): any => closure306(void 0, void 0);
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure364(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], US11_US11_1(method48(v71, v72_1, v73_1, v74_1)), _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v0_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("10px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure365(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure367(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_0(), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure366(v0_1: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v71: (arg0: Mut7) => any = (v: Mut7): any => closure60(void 0, v);
    const v72_1: () => any = (): any => closure310(void 0, void 0);
    const v73_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v74_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure367(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], US11_US11_1(method48(v71, v72_1, v73_1, v74_1)), _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US13_US13_1(v0_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("10px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure368(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure361(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure362(void 0, void 0);
    const v8: (arg0: Mut1) => any = (v: Mut1): any => closure47(void 0, v);
    const v9: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure363(v1_1, arg10$0040_2);
    const v10: () => any[] = (): any[] => closure365(void 0, void 0);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure366(v0_1, arg10$0040_4);
    const v13: () => any[] = (): any[] => closure368(void 0, void 0);
    return [method5(v4, v5, v6), method22(v8, v9, v10), method22(v8, v12, v13)];
}

export function closure375(v0_1: () => [string, any], unitVar: void): any[] {
    const patternInput: [string, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure374(v0_1: () => [string, any], unitVar: void): any[] {
    const v3: any = hope;
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v9: () => any[] = (): any[] => closure375(v0_1, void 0);
    return [method5(v3.pre, v8, v9)];
}

export function closure373(v0_1: () => [string, any], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure374(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], US6_US6_1("3px"), _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        {v0_1()[0]}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure372(v0_1: () => [string, any], v1_1: int32): any[] {
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure373(v0_1, arg10$0040);
    return [method26(v2, US13_US13_0(), US13_US13_0(), v5, US15_US15_2())];
}

export function closure371(unitVar: void, v0_1: () => [string, any]): (arg0: int32) => any[] {
    return (v: int32): any[] => closure372(v0_1, v);
}

export function closure370(v0_1: () => [string, any][], unitVar: void): any[] {
    let clo: () => any[];
    const v1_1: [string, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut29 = new Mut29(0, UH4_UH4_1());
    while (method91(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH4 = v4.l1;
        const patternInput: [string, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH4_UH4_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [string, any][] = method93(method92(v4.l1, UH4_UH4_1()));
    const v19: (arg0: () => [string, any], arg1: int32) => any[] = (v: () => [string, any]): (arg0: int32) => any[] => closure371(void 0, v);
    const v23: any = Index;
    const v24: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure352(v18, arg10$0040);
    return [method5(v23, v24, (clo = ((item: any, index: () => number) => v19(item)(index)), clo))];
}

export function closure369(v0_1: () => [string, any][], unitVar: void): any[] {
    const v1_1: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure370(v0_1, void 0);
    return [method22(v1_1, v2, v3)];
}

export function closure359(v0_1: () => [string, any][], v1_1: () => void, v2: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v75_1: any = Stack;
    const v76_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure360(void 0, arg10$0040);
    const v77_1: () => any[] = (): any[] => closure361(v1_1, v2, void 0);
    const v79: () => any[] = (): any[] => closure369(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v79), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], US6_US6_1("deploy"), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(method5(v75_1, v76_1, v77_1)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method96(): any {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    const v111: () => [string, any][] = patternInput[12];
    const v122: (arg0: [[string, any][], US2, string, [string, any][]]) => void = (arg10$0040: [[string, any][], US2, string, [string, any][]]): void => {
        closure355(patternInput[13], arg10$0040);
    };
    const v123: (arg0: any) => any = (v: any): any => closure356(v111, v);
    const patternInput_1: [() => void, () => void] = method88("profile/tmp/chain_deploy", v111, v122, v123);
    const v126: (arg0: Mut3) => any = (v_1: Mut3): any => closure14(void 0, v_1);
    const v129: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure359(v111, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    return method26(v126, US13_US13_0(), US13_US13_0(), v129, US15_US15_2());
}

export function closure354(unitVar: void, v0_1: Mut1): any {
    return method96();
}

export function closure376(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure274(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let v12: (arg0: Mut1) => any, v13: () => any[], v18: (arg0: Mut1) => any, v19: () => any[];
    const v5: (arg0: Mut1) => any = (v: Mut1): any => closure275(void 0, v);
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v7: () => any[] = (): any[] => closure321(void 0, void 0);
    const v11: boolean = (v2 === "") !== true;
    return [method22(v5, v6, v7), v11 ? ((v12 = ((v_1: Mut1): any => closure322(void 0, v_1)), (v13 = ((): any[] => closure353(void 0, void 0)), method22(v12, v6, v13)))) : (void 0), v11 ? ((v18 = ((v_2: Mut1): any => closure354(void 0, v_2)), (v19 = ((): any[] => closure376(void 0, void 0)), method22(v18, v6, v19)))) : (void 0)];
}

export function closure273(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut1) => any = (v: Mut1): any => closure7(void 0, v);
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040);
    const v7: () => any[] = (): any[] => closure274(v0_1, v1_1, v2, v3, v4, void 0);
    return [method22(v5, v6, v7)];
}

export function closure272(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] {
    const v78: () => any[] = (): any[] => closure273(v0_1, v1_1, v2, v3, v4, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v78), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US11_US11_1(<>
        Profile
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure142(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut3) => any = (v: Mut3): any => closure14(void 0, v);
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure143(void 0, arg10$0040);
    const v13: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure12(void 0, arg10$0040_1);
    const v18: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure167(void 0, arg10$0040_2);
    const v27: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure185(void 0, arg10$0040_3);
    const v36: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure235(void 0, arg10$0040_4);
    const v45: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040_5: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure272(v0_1, v1_1, v2, v3, v4, arg10$0040_5);
    return [method26(v5, US13_US13_0(), US13_US13_0(), v8, US15_US15_2()), method26(v5, US13_US13_0(), US13_US13_0(), v13, US15_US15_2()), method26(v5, US13_US13_0(), US13_US13_0(), v18, US15_US15_2()), method26(v5, US13_US13_0(), US13_US13_0(), v13, US15_US15_2()), method26(v5, US13_US13_0(), US13_US13_0(), v27, US15_US15_0()), method26(v5, US13_US13_0(), US13_US13_0(), v13, US15_US15_2()), method26(v5, US13_US13_0(), US13_US13_0(), v36, US15_US15_0()), method26(v5, US13_US13_0(), US13_US13_0(), v13, US15_US15_2()), method26(v5, US13_US13_0(), US13_US13_0(), v45, US15_US15_2())];
}

export function closure3(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let v7: (arg0: Mut2) => any;
    const v11: (arg0: Mut1) => any = (v_1: Mut1): any => closure7(void 0, v_1);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure141(void 0, arg10$0040);
    const v13: () => any[] = (): any[] => closure142(v0_1, v1_1, v2, v3, v4, void 0);
    return [(v2 === "") ? ((v7 = ((v: Mut2): any => closure4(void 0, v)), method45(v7))) : (void 0), method22(v11, v12, v13)];
}

export function method1(): any {
    const patternInput: [string, any, string, string, boolean] = method2();
    const v7: any = Box;
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US6, US6, US6, US10, US8, US6, US6, US6, US6, US6, US6, US11, US6, US6, US6, US11, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US13, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US14, US6, US11, US6, US6, US14, US14, US6, US5, US6] => closure2(void 0, arg10$0040);
    const v9: () => any[] = (): any[] => closure3(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], void 0);
    return method5(v7, v8, v9);
}

export function closure1(unitVar: void, v0_1: Mut1): any {
    return method1();
}

export function closure378(v0_1: () => [US2, any, string][], v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
    return [["db_connection_options", v1_1()], ["db_connections", v0_1()]];
}

export function method98(v0_1: int32, v1_1: Mut30): boolean {
    return v1_1.l0 < v0_1;
}

export function method99(v0_1: int32, v1_1: Mut31): boolean {
    return v1_1.l0 < v0_1;
}

export function closure383(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure384(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: any): any {
    v0_1(US4_US4_2(), ["> hub_on_connect -> automatic reconnect ()", ["delay", 2000]]);
    return 2000;
}

export function closure385(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: any): void {
    v0_1(US4_US4_2(), ["> hub_on_connect -> on_reconnecting ()", ["ex", v1_1]]);
}

export function closure386(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: any): void {
    v0_1(US4_US4_2(), ["> hub_on_connect -> on_reconnected ()", ["ex", v1_1]]);
}

export function closure387(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: any): void {
    v0_1(US4_US4_2(), ["> hub_on_connect -> on_close ()", ["ex", v1_1]]);
}

export function closure388(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: UH1): void {
    v0_1(US4_US4_2(), ["> hub_on_connect -> on_message ()", ["msg", v1_1]]);
}

export function closure382(v0_1: () => US4, v1_1: string, v2: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>): HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1> {
    const v3: () => any[] = (): any[] => closure383(void 0, void 0);
    const v5: (arg0: US4, arg1: any[]) => void = method17(v0_1, v3, "#666");
    v5(US4_US4_0())(["> hub_on_connect ()"]);
    const v11: (arg0: any) => any = (v: any): any => closure384(uncurry(2, v5), v);
    const v17: RetryPolicy = {
        nextRetryDelayInMilliseconds: v11,
    };
    const v20: (arg0: any) => void = (v_1: any): void => {
        closure385(uncurry(2, v5), v_1);
    };
    const v22: (arg0: any) => void = (v_2: any): void => {
        closure386(uncurry(2, v5), v_2);
    };
    const v24: (arg0: any) => void = (v_3: any): void => {
        closure387(uncurry(2, v5), v_3);
    };
    const v28: (arg0: UH1) => void = (v_4: UH1): void => {
        closure388(uncurry(2, v5), v_4);
    };
    return HubConnectionBuilder$5__onMessage_2163CAFC<UH0, UH0, void, UH1, UH1>(HubConnectionBuilder$5__configureLogging_2D37BB17<UH0, UH0, void, UH1, UH1>(HubConnectionBuilder$5__onClose_Z5D4DDAB0<UH0, UH0, void, UH1, UH1>(HubConnectionBuilder$5__onReconnected_20659392<UH0, UH0, void, UH1, UH1>(HubConnectionBuilder$5__onReconnecting_Z5D4DDAB0<UH0, UH0, void, UH1, UH1>(HubConnectionBuilder$5__withAutomaticReconnect_3C7EFEAD<UH0, UH0, void, UH1, UH1>(HubConnectionBuilder$5__withUrl_Z721C83C5<UH0, UH0, void, UH1, UH1>(v2, v1_1), v17), (arg: Option<Error>): void => {
        v20(arg);
    }), (arg_1: Option<string>): void => {
        v22(arg_1);
    }), (arg_2: Option<Error>): void => {
        v24(arg_2);
    }), 0), v28);
}

export function closure381(v0_1: () => US4, v1_1: string): (arg0: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>) => HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1> {
    return (v: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>): HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1> => closure382(v0_1, v1_1, v);
}

export function closure380(unitVar: void, v0_1: () => US4): (arg0: string, arg1: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>) => HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1> {
    return (v: string): (arg0: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>) => HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1> => closure381(v0_1, v);
}

export function method100(v0_1: int32, v1_1: Mut32): boolean {
    return v1_1.l0 < v0_1;
}

export function closure379(v0_1: () => US4, v1_1: (arg0: [US2, any, string][]) => void, v2: (arg0: US4, arg1: any[]) => void, _arg: [[US2[], int32, US3, string, string][], [US2, any, string][]]): void {
    let copyOfStruct: US2, copyOfStruct_5: US3, v79: any, v74_1: (arg0: () => US4, arg1: string, arg2: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>) => HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>, v75_1: HubConnection$5<UH0, UH0, void, UH1, UH1>, _: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>, arg: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>, protocol_2: any, protocol: MsgPack_MsgPackProtocol, protocol_1: Json_JsonProtocol, v83: any, v98: any;
    const v4: [US2, any, string][] = _arg[1];
    const v3: [US2[], int32, US3, string, string][] = _arg[0];
    const v5: int32 = v3.length | 0;
    const v6: [US2, any, string][][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut6 = new Mut6(0);
    while (method21(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v3[v9];
        const v12: US3 = patternInput[2];
        const v10: US2[] = patternInput[0];
        const v15: int32 = v10.length | 0;
        const v16: [US2, any, string][] = fill(new Array(v15), 0, v15, null);
        const v17: Mut6 = new Mut6(0);
        while (method21(v15, v17)) {
            const v19: int32 = v17.l0 | 0;
            const v20: US2 = v10[v19];
            const v21: int32 = v4.length | 0;
            const v23: Mut30 = new Mut30(0, US20_US20_0());
            while (method98(v21, v23)) {
                const v25: int32 = v23.l0 | 0;
                const v28: int32 = ((op_UnaryNegation_Int32(v25) + v21) - 1) | 0;
                const v29: US20 = v23.l1;
                const patternInput_1: [US2, any, string] = v4[v28];
                const v32: string = patternInput_1[2];
                const v30: US2 = patternInput_1[0];
                const v39: US20 = (v29.tag === US20_Tag.US20_0) ? ((((copyOfStruct = v30, (copyOfStruct.tag === US2_Tag.US2_1) ? (v20.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v20.tag === US2_Tag.US2_2) : ((copyOfStruct.tag === US2_Tag.US2_3) ? (v20.tag === US2_Tag.US2_3) : (v20.tag === US2_Tag.US2_0))))) && (v32 === patternInput[3])) ? US20_US20_1(v30, patternInput_1[1], v32) : US20_US20_0()) : v29;
                const v40: int32 = (v25 + 1) | 0;
                v23.l0 = (v40 | 0);
                v23.l1 = v39;
            }
            const v41: US20 = v23.l1;
            let patternInput_3: [US2, any, string];
            if (v41.tag === US20_Tag.US20_1) {
                patternInput_3 = [v41.fields[0], v41.fields[1], v41.fields[2]];
            }
            else {
                const v46: Mut31 = new Mut31(0, US21_US21_0());
                while (method99(v5, v46)) {
                    const v48: int32 = v46.l0 | 0;
                    const v51: int32 = ((op_UnaryNegation_Int32(v48) + v5) - 1) | 0;
                    const v52: US21 = v46.l1;
                    const patternInput_2: [US2[], int32, US3, string, string] = v3[v51];
                    const v55: US3 = patternInput_2[2];
                    const v62: US21 = (v52.tag === US21_Tag.US21_0) ? (((copyOfStruct_5 = v55, (copyOfStruct_5.tag === US3_Tag.US3_1) ? (v12.tag === US3_Tag.US3_1) : ((copyOfStruct_5.tag === US3_Tag.US3_2) ? (v12.tag === US3_Tag.US3_2) : (v12.tag === US3_Tag.US3_0)))) ? US21_US21_1(patternInput_2[0], patternInput_2[1], v55, patternInput_2[3], patternInput_2[4]) : US21_US21_0()) : v52;
                    const v63: int32 = (v48 + 1) | 0;
                    v46.l0 = (v63 | 0);
                    v46.l1 = v62;
                }
                const v64: US21 = v46.l1;
                const v73_1: string = (v64.tag === US21_Tag.US21_1) ? (`${v64.fields[3]}:${v64.fields[1]}/${v64.fields[4]}`) : "";
                patternInput_3 = [v20, (v20.tag === US2_Tag.US2_1) ? ((v79 = Node$, new v79(v73_1))) : ((v20.tag === US2_Tag.US2_2) ? (() => {
                    throw new Error("new_db Memory");
                })() : ((v20.tag === US2_Tag.US2_3) ? ((v74_1 = ((v: () => US4): (arg0: string, arg1: HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1>) => HubConnectionBuilder$5<UH0, UH0, void, UH1, UH1> => closure380(void 0, v)), (v75_1 = ((_ = ((arg = HubConnectionBuilder$5_$ctor_Z66CB2AA1<UH0, UH0, void, UH1, UH1>(new Bindings_signalR.HubConnectionBuilder()), v74_1(v0_1)(v73_1)(arg))), HubConnection$5_$ctor_Z78FDE58B<UH0, UH0, void, UH1, UH1>((protocol_2 = (_.useMsgPack ? ((protocol = MsgPack_MsgPackProtocol_$ctor(), {
                    name: "messagepack",
                    version: 1,
                    transferFormat: 2,
                    parseMessages(input: any, logger: any): any[] {
                        let arg_3: FSharpList<any>;
                        try {
                            const buffer_1: any = input;
                            const reader: Reader = Reader_$ctor_Z3F6BC7B1(new Uint8Array(buffer_1));
                            const read: (arg0: uint64, arg1: FSharpList<any>) => FSharpList<any> = (pos_mut: uint64, xs_mut: FSharpList<any>): FSharpList<any> => {
                                read:
                                while (true) {
                                    const pos: uint64 = pos_mut, xs: FSharpList<any> = xs_mut;
                                    const matchValue_2: uint64 = op_Addition(op_Addition(Reader__Read_24524716(reader, uint64_type), pos), fromBits(1, 0, true));
                                    if (compare(op_Subtraction(fromInteger(buffer_1.byteLength, true, 2), matchValue_2), fromBits(0, 0, true)) > 0) {
                                        pos_mut = matchValue_2;
                                        xs_mut = cons(MsgPack_parseMsg<UH1, UH1>(Reader__Read_24524716(reader, MsgPack_Msg$4$reflection(unit_type, UH1$reflection(), UH1$reflection(), UH1$reflection()))), xs);
                                        continue read;
                                    }
                                    else {
                                        return cons(MsgPack_parseMsg<UH1, UH1>(Reader__Read_24524716(reader, MsgPack_Msg$4$reflection(unit_type, UH1$reflection(), UH1$reflection(), UH1$reflection()))), xs);
                                    }
                                    break;
                                }
                            };
                            arg_3 = reverse(read(fromBits(0, 0, true), empty<any>()));
                        }
                        catch (e: any) {
                            let arg_2_1: string;
                            const arg_2: string = e.message;
                            arg_2_1 = toText(printf("An error occured during message deserialization: %s"))(arg_2);
                            logger.log(4, arg_2_1);
                            arg_3 = empty<any>();
                        }
                        return Array.from(arg_3);
                    },
                    writeMessage(msg_2: any): any {
                        let matchValue_3: int32, invocation: any, matchValue_1_1: string, invocation_1: any, arg_4: string, streamItem: any, completion: any, streamInvocation: any, cancelInvocation: any, close: any;
                        const message: any = msg_2;
                        const outArr: uint8[] = [];
                        writeObject((matchValue_3 = (message.type | 0), (matchValue_3 === 1) ? ((invocation = message, (matchValue_1_1 = invocation.target, (matchValue_1_1 === "Invoke") ? ((invocation.arguments.length === 2) ? MsgPack_Msg$4_InvokeInvocation<UH0, UH0, void, void>(invocation.headers, invocation.invocationId, invocation.target, invocation.arguments[0], invocation.arguments[1], invocation.streamIds) : ((invocation_1 = message, MsgPack_Msg$4_InvocationExplicit<UH0, UH0, void, void>(invocation_1.headers, invocation_1.invocationId, invocation_1.target, invocation_1.arguments, invocation_1.streamIds)))) : ((matchValue_1_1 === "Send") ? MsgPack_Msg$4_Invocation<UH0, UH0, void, void>(invocation.headers, invocation.invocationId, invocation.target, invocation.arguments, invocation.streamIds) : ((matchValue_1_1 === "StreamTo") ? MsgPack_Msg$4_Invocation<UH0, UH0, void, void>(invocation.headers, invocation.invocationId, invocation.target, invocation.arguments, invocation.streamIds) : ((arg_4 = invocation.target, toFail(printf("Invalid Invocation Target: %s"))(arg_4)))))))) : ((matchValue_3 === 2) ? ((streamItem = message, MsgPack_Msg$4_StreamItem<UH0, UH0, void, void>(streamItem.headers, streamItem.invocationId, streamItem.item))) : ((matchValue_3 === 3) ? ((completion = message, MsgPack_Msg$4_Completion<UH0, UH0, void, void>(completion.headers, completion.invocationId, completion.error, completion.result))) : ((matchValue_3 === 4) ? ((streamInvocation = message, MsgPack_Msg$4_StreamInvocation<UH0, UH0, void, void>(streamInvocation.headers, streamInvocation.invocationId, streamInvocation.target, streamInvocation.arguments, streamInvocation.streamIds))) : ((matchValue_3 === 5) ? ((cancelInvocation = message, MsgPack_Msg$4_CancelInvocation<UH0, UH0, void, void>(cancelInvocation.headers, cancelInvocation.invocationId))) : ((matchValue_3 === 6) ? MsgPack_Msg$4_Ping<UH0, UH0, void, void>() : ((matchValue_3 === 7) ? ((close = message, MsgPack_Msg$4_Close<UH0, UH0, void, void>(close.error, close.allowReconnect))) : toFail(printf("Invalid message: %A"))(message)))))))), MsgPack_Msg$4$reflection(UH0$reflection(), UH0$reflection(), unit_type, unit_type), outArr);
                        if (compare(fromInteger(outArr.length, true, 2), fromBits(2147483648, 0, true)) > 0) {
                            throw new Error("Messages over 2GB are not supported.");
                        }
                        else {
                            const msgArr: uint8[] = [];
                            writeObject(fromInteger(outArr.length, true, 2), uint64_type, msgArr);
                            addRangeInPlace(outArr, msgArr);
                            return (new Uint8Array(msgArr)).buffer;
                        }
                    },
                })) : ((protocol_1 = Json_JsonProtocol_$ctor(), {
                    name: "json",
                    version: 1,
                    transferFormat: 1,
                    parseMessages(input_1: any, logger_2: any): any[] {
                        const input_2: any = input_1;
                        const logger_3: any = logger_2;
                        let arg_9_1: any[];
                        if ((typeof input_2) === "string") {
                            if (equals(input_2, "")) {
                                arg_9_1 = [];
                            }
                            else {
                                try {
                                    arg_9_1 = choose((m: string): Option<any> => {
                                        let msg_4: HubRecords_InvocationMessage$1<UH1>;
                                        const parsedRaw: Json = SimpleJson_parse(m);
                                        let _arg_2: FSharpResult$2<any, string>;
                                        const parsedRaw_1: Json = parsedRaw;
                                        const msgType_1: int32 = value_10(map((arg_6: Json): int32 => Convert_fromJson<int32>(arg_6, createTypeInfo(enum_type("Fable.SignalR.Messages.MessageType", int32_type, [["Invocation", 1], ["StreamItem", 2], ["Completion", 3], ["StreamInvocation", 4], ["CancelInvocation", 5], ["Ping", 6], ["Close", 7]]))), SimpleJson_readPath(singleton("type"), parsedRaw))) | 0;
                                        if (msgType_1 === 1) {
                                            let _arg_1: FSharpResult$2<HubRecords_InvocationMessage$1<UH1>, string>;
                                            try {
                                                _arg_1 = FSharpResult$2_Ok<HubRecords_InvocationMessage$1<UH1>, string>(Convert_fromJson<HubRecords_InvocationMessage$1<UH1>>(parsedRaw_1, createTypeInfo(HubRecords_InvocationMessage$1$reflection(UH1$reflection()))));
                                            }
                                            catch (ex: any) {
                                                _arg_1 = FSharpResult$2_Error<HubRecords_InvocationMessage$1<UH1>, string>(ex.message);
                                            }
                                            _arg_2 = ((_arg_1.tag === FSharpResult$2_Tag.Error) ? Result_Map((arg_9: HubRecords_InvocationMessage$1<InvokeArg$1<UH1>>): any => {
                                                let msg_6: HubRecords_InvocationMessage$1<InvokeArg$1<UH1>>;
                                                return (msg_6 = arg_9, ((msg_6.target === "") ? (() => {
                                                    throw new Error("Invalid payload for Invocation message.");
                                                })() : (void 0), ((msg_6.invocationId != null) ? ((value_10(msg_6.invocationId) === "") ? (() => {
                                                    throw new Error("Invalid payload for Invocation message.");
                                                })() : (void 0)) : (void 0), msg_6)));
                                            }, (() => {
                                                try {
                                                    return FSharpResult$2_Ok<HubRecords_InvocationMessage$1<InvokeArg$1<UH1>>, string>(Convert_fromJson<HubRecords_InvocationMessage$1<InvokeArg$1<UH1>>>(parsedRaw_1, createTypeInfo(HubRecords_InvocationMessage$1$reflection(InvokeArg$1$reflection(UH1$reflection())))));
                                                }
                                                catch (ex_1: any) {
                                                    return FSharpResult$2_Error<HubRecords_InvocationMessage$1<InvokeArg$1<UH1>>, string>(ex_1.message);
                                                }
                                            })()) : FSharpResult$2_Ok<any, string>((msg_4 = _arg_1.fields[0], ((msg_4.target === "") ? (() => {
                                                throw new Error("Invalid payload for Invocation message.");
                                            })() : (void 0), ((msg_4.invocationId != null) ? ((value_10(msg_4.invocationId) === "") ? (() => {
                                                throw new Error("Invalid payload for Invocation message.");
                                            })() : (void 0)) : (void 0), msg_4)))));
                                        }
                                        else {
                                            _arg_2 = ((msgType_1 === 2) ? Result_Map((arg_11: HubRecords_StreamItemMessage$1<UH1>): any => {
                                                let msg_7: HubRecords_StreamItemMessage$1<UH1>, matchValue_4: Option<string>, invocationId_1: string;
                                                return (msg_7 = arg_11, (matchValue_4 = msg_7.invocationId, (matchValue_4 != null) ? ((value_10(matchValue_4) !== "") ? ((invocationId_1 = value_10(matchValue_4), msg_7)) : (() => {
                                                    throw new Error("Invalid payload for StreamItem message.");
                                                })()) : (() => {
                                                    throw new Error("Invalid payload for StreamItem message.");
                                                })()));
                                            }, (() => {
                                                try {
                                                    return FSharpResult$2_Ok<HubRecords_StreamItemMessage$1<UH1>, string>(Convert_fromJson<HubRecords_StreamItemMessage$1<UH1>>(parsedRaw_1, createTypeInfo(HubRecords_StreamItemMessage$1$reflection(UH1$reflection()))));
                                                }
                                                catch (ex_2: any) {
                                                    return FSharpResult$2_Error<HubRecords_StreamItemMessage$1<UH1>, string>(ex_2.message);
                                                }
                                            })()) : ((msgType_1 === 3) ? Result_Map((arg_13: HubRecords_CompletionMessage$1<UH1>): any => {
                                                let msg_8: HubRecords_CompletionMessage$1<UH1>, fail: () => $a, matchValue_1_2: Option<string>, err: string;
                                                return (msg_8 = arg_13, (fail = ((): $a => {
                                                    throw new Error("Invalid payload for Completion message.");
                                                }), ((matchValue_1_2 = msg_8.error, (msg_8.result == null) ? ((matchValue_1_2 != null) ? ((err = value_10(matchValue_1_2), (err === "") ? fail() : (void 0))) : ((msg_8.invocationId === "") ? fail() : (void 0))) : ((matchValue_1_2 != null) ? fail() : ((msg_8.invocationId === "") ? fail() : (void 0)))), msg_8)));
                                            }, (() => {
                                                try {
                                                    return FSharpResult$2_Ok<HubRecords_CompletionMessage$1<UH1>, string>(Convert_fromJson<HubRecords_CompletionMessage$1<UH1>>(parsedRaw_1, createTypeInfo(HubRecords_CompletionMessage$1$reflection(UH1$reflection()))));
                                                }
                                                catch (ex_3: any) {
                                                    return FSharpResult$2_Error<HubRecords_CompletionMessage$1<UH1>, string>(ex_3.message);
                                                }
                                            })()) : ((msgType_1 === 4) ? Result_Map((arg_14: HubRecords_StreamInvocationMessage$1<void>): any => arg_14, (() => {
                                                try {
                                                    return FSharpResult$2_Ok<HubRecords_StreamInvocationMessage$1<void>, string>(Convert_fromJson<HubRecords_StreamInvocationMessage$1<void>>(parsedRaw_1, createTypeInfo(HubRecords_StreamInvocationMessage$1$reflection(unit_type))));
                                                }
                                                catch (ex_4: any) {
                                                    return FSharpResult$2_Error<HubRecords_StreamInvocationMessage$1<void>, string>(ex_4.message);
                                                }
                                            })()) : ((msgType_1 === 5) ? Result_Map((arg_15: HubRecords_CancelInvocationMessage): any => arg_15, (() => {
                                                try {
                                                    return FSharpResult$2_Ok<HubRecords_CancelInvocationMessage, string>(Convert_fromJson<HubRecords_CancelInvocationMessage>(parsedRaw_1, createTypeInfo(HubRecords_CancelInvocationMessage$reflection())));
                                                }
                                                catch (ex_5: any) {
                                                    return FSharpResult$2_Error<HubRecords_CancelInvocationMessage, string>(ex_5.message);
                                                }
                                            })()) : ((msgType_1 === 6) ? Result_Map((arg_16: HubRecords_PingMessage): any => arg_16, (() => {
                                                try {
                                                    return FSharpResult$2_Ok<HubRecords_PingMessage, string>(Convert_fromJson<HubRecords_PingMessage>(parsedRaw_1, createTypeInfo(HubRecords_PingMessage$reflection())));
                                                }
                                                catch (ex_6: any) {
                                                    return FSharpResult$2_Error<HubRecords_PingMessage, string>(ex_6.message);
                                                }
                                            })()) : ((msgType_1 === 7) ? Result_Map((arg_17: HubRecords_CloseMessage): any => arg_17, (() => {
                                                try {
                                                    return FSharpResult$2_Ok<HubRecords_CloseMessage, string>(Convert_fromJson<HubRecords_CloseMessage>(parsedRaw_1, createTypeInfo(HubRecords_CloseMessage$reflection())));
                                                }
                                                catch (ex_7: any) {
                                                    return FSharpResult$2_Error<HubRecords_CloseMessage, string>(ex_7.message);
                                                }
                                            })()) : toFail(printf("Invalid message: %A"))(parsedRaw_1)))))));
                                        }
                                        if (_arg_2.tag === FSharpResult$2_Tag.Error) {
                                            const arg_3_2: string = toText(printf("Unknown message type: %s"))(_arg_2.fields[0]);
                                            logger_3.log(4, arg_3_2);
                                            return void 0;
                                        }
                                        else {
                                            return some(_arg_2.fields[0]);
                                        }
                                    }, Json_TextMessageFormat_parse(input_2), null);
                                }
                                catch (e_1_1: any) {
                                    let arg_6_2: string;
                                    const arg_4_2: string = e_1_1.message;
                                    arg_6_2 = toText(printf("An error occured during message deserialization: %s"))(arg_4_2);
                                    logger_3.log(4, arg_6_2);
                                    arg_9_1 = [];
                                }
                            }
                        }
                        else {
                            logger_3.log(4, "Invalid input for JSON hub protocol. Expected a string, got an array buffer instead.");
                            arg_9_1 = [];
                        }
                        return Array.from(arg_9_1);
                    },
                    writeMessage(msg_10: any): string {
                        return Json_TextMessageFormat_write(Convert_serialize(msg_10, createTypeInfo(obj_type)));
                    },
                }))), _["hub@10"].withHubProtocol<UH0, void, UH1>(protocol_2).build<UH0, void, UH1>()), _.handlers))), (HubConnection$5__startNow<UH0, UH0, void, UH1, UH1>(v75_1), v75_1)))) : ((v83 = gun, (v98 = {
                    url: v73_1,
                    localStorage: false,
                    radisk: true,
                }, new v83(v98)))))), v73_1];
            }
            v16[v19] = [patternInput_3[0], patternInput_3[1], patternInput_3[2]];
            const v111: int32 = (v19 + 1) | 0;
            v17.l0 = (v111 | 0);
        }
        v6[v9] = v16;
        const v112: int32 = (v9 + 1) | 0;
        v7.l0 = (v112 | 0);
    }
    const v114: int32 = v6.length | 0;
    const v115: Mut32 = new Mut32(0, []);
    while (method100(v114, v115)) {
        const v117: int32 = v115.l0 | 0;
        const v118: [US2, any, string][] = v115.l1;
        const v119: [US2, any, string][] = v6[v117];
        const v120: int32 = v118.length | 0;
        const v122: int32 = (v120 + v119.length) | 0;
        const v123: [US2, any, string][] = fill(new Array(v122), 0, v122, null);
        const v124: Mut6 = new Mut6(0);
        while (method21(v122, v124)) {
            const v126: int32 = v124.l0 | 0;
            let patternInput_6: [US2, any, string];
            if (v126 < v120) {
                const patternInput_4: [US2, any, string] = v118[v126];
                patternInput_6 = [patternInput_4[0], patternInput_4[1], patternInput_4[2]];
            }
            else {
                const v131: int32 = (v126 - v120) | 0;
                const patternInput_5: [US2, any, string] = v119[v131];
                patternInput_6 = [patternInput_5[0], patternInput_5[1], patternInput_5[2]];
            }
            v123[v126] = [patternInput_6[0], patternInput_6[1], patternInput_6[2]];
            const v138: int32 = (v126 + 1) | 0;
            v124.l0 = (v138 | 0);
        }
        const v139: int32 = (v117 + 1) | 0;
        v115.l0 = (v139 | 0);
        v115.l1 = v123;
    }
    const v140: [US2, any, string][] = v115.l1;
    const v141: int32 = v4.length | 0;
    const v142: [US2, string][] = fill(new Array(v141), 0, v141, null);
    const v143: Mut6 = new Mut6(0);
    while (method21(v141, v143)) {
        const v145: int32 = v143.l0 | 0;
        const patternInput_7: [US2, any, string] = v4[v145];
        v142[v145] = [patternInput_7[0], patternInput_7[2]];
        const v149: int32 = (v145 + 1) | 0;
        v143.l0 = (v149 | 0);
    }
    const v150: int32 = v140.length | 0;
    const v151: [US2, string][] = fill(new Array(v150), 0, v150, null);
    const v152: Mut6 = new Mut6(0);
    while (method21(v150, v152)) {
        const v154: int32 = v152.l0 | 0;
        const patternInput_8: [US2, any, string] = v140[v154];
        v151[v154] = [patternInput_8[0], patternInput_8[2]];
        const v158: int32 = (v154 + 1) | 0;
        v152.l0 = (v158 | 0);
    }
    if ((((v142.length === v151.length) !== true) ? false : method81(v142, v151, 0)) !== true) {
        v2(US4_US4_2(), ["> db_listener > effect", ["new_connections", v140]]);
        v1_1(v140);
    }
}

export function closure389(v0_1: () => [US2, any, string][], v1_1: () => [US2[], int32, US3, string, string][], v2: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void, unitVar: void): void {
    const v3: [US2, any, string][] = v0_1();
    v2([v1_1(), v3]);
}

export function closure390(v0_1: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void, unitVar: void): void {
    v0_1.clear();
}

export function method97(): any {
    const v95: any = components.state_context;
    const v98: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v98(v95);
    const v216: any = components.state_context;
    const v217: any = useContext;
    const patternInput_1: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, any][], (arg0: [string, any][]) => void, () => [string, int32][], (arg0: [string, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v217(v216);
    const v228: () => [US2, any, string][] = patternInput_1[10];
    const v335: any = components.state_context;
    const v336: any = useContext;
    const v345: () => [US2[], int32, US3, string, string][] = (v336(v335))[8];
    const v359: () => any[] = (): any[] => closure378(v228, v345, void 0);
    const v361: (arg0: US4, arg1: any[]) => void = method16(v359, "#cf1100");
    v361(US4_US4_0())(["> db_listener ()"]);
    const v369: any = debounce;
    const v370: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void = (arg10$0040_1: [[US2[], int32, US3, string, string][], [US2, any, string][]]): void => {
        closure379(patternInput[18], patternInput_1[11], uncurry(2, v361), arg10$0040_1);
    };
    const v371: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void = v369(v370, 300);
    const v373: any = createEffect;
    const v374: () => void = (): void => {
        closure389(v228, v345, v371, void 0);
    };
    v373(v374);
    const v376: any = onCleanup;
    const v377: () => void = (): void => {
        closure390(v371, void 0);
    };
    v376(v377);
    return void 0;
}

export function closure377(unitVar: void, v0_1: Mut2): any {
    return method97();
}

export function method101(): [US0, string, string, string][] {
    return [[US0_US0_0(), "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M", "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith", "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="], [US0_US0_1(US1_US1_1()), "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ", "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make", "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="], [US0_US0_1(US1_US1_0()), "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI", "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid", "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="]];
}

export function method102(v0_1: US0): [() => US0, (arg0: US0) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: US0): void => {
        value_2(arg_1);
    })];
}

export function method103(v0_1: string): [() => string, (arg0: string) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: string): void => {
        value_2(arg_1);
    })];
}

export function method104(v0_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): void => {
        value_2(arg_1);
    })];
}

export function method105(): int32 {
    return 4001;
}

export function method106(v0_1: int32): [() => int32, (arg0: int32) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: int32): void => {
        value_2(arg_1);
    })];
}

export function method107(): string {
    return "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
}

export function method108(): string {
    return "http://localhost";
}

export function method109(v0_1: [US2, any, string][]): [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: [US2, any, string][]): void => {
        value_2(arg_1);
    })];
}

export function method110(v0_1: [US2[], int32, US3, string, string][]): [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: [US2[], int32, US3, string, string][]): void => {
        value_2(arg_1);
    })];
}

export function method111(v0_1: US4): [() => US4, (arg0: US4) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: US4): void => {
        value_2(arg_1);
    })];
}

export function method112(v0_1: US5): [() => US5, (arg0: US5) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: US5): void => {
        value_2(arg_1);
    })];
}

export function method113(v0_1: [string, int32][]): [() => [string, int32][], (arg0: [string, int32][]) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: [string, int32][]): void => {
        value_2(arg_1);
    })];
}

export function method114(v0_1: [string, any][]): [() => [string, any][], (arg0: [string, any][]) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: [string, any][]): void => {
        value_2(arg_1);
    })];
}

export function closure391(unitVar: void, unitVar_1: void): any {
    const patternInput: [string, any, string, string, boolean] = method2();
    const v99: boolean = patternInput[4];
    const v95: string = patternInput[0];
    const v100: [US0, string, string, string][] = method101();
    const v101: int32 = v100.length | 0;
    const v102: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = fill(new Array(v101), 0, v101, null);
    const v103: Mut6 = new Mut6(0);
    while (method21(v101, v103)) {
        const v105: int32 = v103.l0 | 0;
        const patternInput_1: [US0, string, string, string] = v100[v105];
        const patternInput_2: [() => US0, (arg0: US0) => void] = method102(patternInput_1[0]);
        const patternInput_3: [() => string, (arg0: string) => void] = method103(patternInput_1[3]);
        const patternInput_4: [() => string, (arg0: string) => void] = method103(patternInput_1[1]);
        const patternInput_5: [() => string, (arg0: string) => void] = method103(patternInput_1[2]);
        v102[v105] = [patternInput_2[0], patternInput_2[1], patternInput_4[0], patternInput_4[1], patternInput_5[0], patternInput_5[1], patternInput_3[0], patternInput_3[1]];
        const v118: int32 = (v105 + 1) | 0;
        v103.l0 = (v118 | 0);
    }
    const patternInput_6: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] = method104(v102);
    const v121: boolean = "" === v95;
    const patternInput_7: [() => int32, (arg0: int32) => void] = method106(v121 ? method105() : 80);
    const patternInput_8: [() => string, (arg0: string) => void] = method103(method107());
    const patternInput_9: [() => string, (arg0: string) => void] = method103(v121 ? method108() : (`http://${v95}-4001.githubpreview.dev`));
    const patternInput_10: [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] = method109(fill(new Array(0), 0, 0, null));
    const v141: string = v121 ? "http://localhost" : (v99 ? "http://localhost" : (`http://${v95}-9761.githubpreview.dev`));
    const v143: int32 = (v121 ? (v99 ? 19761 : 9761) : 80) | 0;
    const v151: string = v121 ? "ws://localhost" : (v99 ? "ws://localhost" : (`ws://${v95}-4944.githubpreview.dev`));
    const v153: int32 = (v121 ? (v99 ? 14944 : 4944) : 80) | 0;
    const v161: string = v121 ? "wss://localhost" : (v99 ? "wss://localhost" : (`ws://${v95}-8765.githubpreview.dev`));
    const v163: int32 = (v121 ? (v99 ? 18765 : 8765) : 80) | 0;
    const patternInput_11: [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] = method110([[fill(new Array(0), 0, 0, null), v143, US3_US3_2(), v141, "peer"], [fill(new Array(0), 0, 0, null), v153, US3_US3_1(), v151, "ws"], [fill(new Array(0), 0, 0, null), v163, US3_US3_0(), v161, "gun"]]);
    const patternInput_12: [() => US4, (arg0: US4) => void] = method111(("" === patternInput[2]) ? US4_US4_0() : (v99 ? US4_US4_0() : US4_US4_4()));
    const patternInput_13: [() => US5, (arg0: US5) => void] = method112(US5_US5_0());
    const patternInput_14: [() => [string, int32][], (arg0: [string, int32][]) => void] = method113(fill(new Array(0), 0, 0, null));
    const patternInput_15: [() => [string, any][], (arg0: [string, any][]) => void] = method114(fill(new Array(0), 0, 0, null));
    const patternInput_16: [() => [string, any][], (arg0: [string, any][]) => void] = method114(fill(new Array(0), 0, 0, null));
    return [patternInput_6[0], patternInput_6[1], patternInput_7[0], patternInput_7[1], patternInput_8[0], patternInput_8[1], patternInput_9[0], patternInput_9[1], patternInput_11[0], patternInput_11[1], patternInput_10[0], patternInput_10[1], patternInput_16[0], patternInput_16[1], patternInput_15[0], patternInput_15[1], patternInput_14[0], patternInput_14[1], patternInput_12[0], patternInput_12[1], patternInput_13[0], patternInput_13[1]];
}

export function patternInput$00407517(): [(arg0: $a, arg1: $b) => $c, (arg0: $d, arg1: $e, arg2: $f) => void] {
    return [(o: $a): (arg0: $b) => $c => ((prop: $b): $c => o[prop]), (o_1: $d): (arg0: $e, arg1: $f) => void => ((prop_1: $e): (arg0: $f) => void => ((v: $f): void => {
        o_1[prop_1] = v;
    }))];
}

export function op_DynamicAssignment<$d, $e, $f>(): (arg0: $d, arg1: $e, arg2: $f) => void {
    return patternInput$00407517<any, any, any, $d, $e, $f>()[1];
}

export function op_Dynamic<$a, $b, $c>(): (arg0: $a, arg1: $b) => $c {
    return patternInput$00407517<$a, $b, $c, any, any, any>()[0];
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const v72 = process.env;

export const v73 = "env";

export const v74 = [v73, v72];

export const v75 = [v74];

export const v76 = createObj(v75);

op_DynamicAssignment<any, string, any>()(window)("components")(v76);

export const v77 = nonSeeded().Next0();

export const v173 = method0();

export const v174 = defaultOf();

export const v175 = defaultOf();

export const v176 = (v: Mut1): any => closure1(void 0, v);

export const v177 = v176;

export const v178 = "content";

export const v179 = [v178, v177];

export const v180 = (v: Mut2): any => closure377(void 0, v);

export const v181 = v180;

export const v182 = "db_listener";

export const v183 = [v182, v181];

export const v184 = v77;

export const v185 = "run_id";

export const v186 = [v185, v184];

export const v187 = (): any => closure391(void 0, void 0);

export const v188 = v187;

export const v189 = "new_state_context_any";

export const v190 = [v189, v188];

export const v191 = "state_context";

export const v192 = [v191, v173];

export const v193 = [v179, v183, v186, v190, v192, v74];

export const v194 = createObj(v193);

op_DynamicAssignment<any, string, any>()(window)("components")(v194);

v1.l0 = v194;


