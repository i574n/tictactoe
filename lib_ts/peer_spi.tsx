import { Union, Record } from "./fable_modules/fable-library-ts/Types.js";
import { bool_type, array_type, union_type, string_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { interpolate, toConsole } from "./fable_modules/fable-library-ts/String.js";
import { comparePrimitives, defaultOf } from "./fable_modules/fable-library-ts/Util.js";
import { ofSeq } from "./fable_modules/fable-library-ts/Map.js";
import { int32 } from "./fable_modules/fable-library-ts/Int32.js";

export class Mut0 extends Record {
    l0: any;
    constructor(l0: any) {
        super();
        this.l0 = l0;
    }
}

export function Mut0$reflection(): TypeInfo {
    return record_type("Peer_spi.Mut0", [], Mut0, () => [["l0", obj_type]]);
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
    return union_type("Peer_spi.UH0", [], UH0_Cons, () => [[["Item", string_type]], [["Item1", string_type], ["Item2", string_type]], [["Item1", string_type], ["Item2", string_type]], [["Item1", string_type], ["Item2", string_type], ["Item3", string_type]]]);
}

export const enum US0_Tag {
    US0_0 = 0,
    US0_1 = 1
}

export type US0_Fields = [[], [string]];

export type US0 = US0_Cons<US0_Tag.US0_0> | US0_Cons<US0_Tag.US0_1>;

export function US0_US0_0() {
    return new US0_Cons<US0_Tag.US0_0>(US0_Tag.US0_0, []);
}

export function US0_US0_1(f1_0: string) {
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
    return union_type("Peer_spi.US0", [], US0_Cons, () => [[], [["f1_0", string_type]]]);
}

export const enum UH1_Tag {
    UH1_0 = 0,
    UH1_1 = 1,
    UH1_2 = 2,
    UH1_3 = 3,
    UH1_4 = 4,
    UH1_5 = 5
}

export type UH1_Fields = [[], [US0], [string, string, US0], [string[]], [string, string, string[], string[]], [boolean]];

export type UH1 = UH1_Cons<UH1_Tag.UH1_0> | UH1_Cons<UH1_Tag.UH1_1> | UH1_Cons<UH1_Tag.UH1_2> | UH1_Cons<UH1_Tag.UH1_3> | UH1_Cons<UH1_Tag.UH1_4> | UH1_Cons<UH1_Tag.UH1_5>;

export function UH1_UH1_0() {
    return new UH1_Cons<UH1_Tag.UH1_0>(UH1_Tag.UH1_0, []);
}

export function UH1_UH1_1(Item: US0) {
    return new UH1_Cons<UH1_Tag.UH1_1>(UH1_Tag.UH1_1, [Item]);
}

export function UH1_UH1_2(Item1: string, Item2: string, Item3: US0) {
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
    return union_type("Peer_spi.UH1", [], UH1_Cons, () => [[], [["Item", US0$reflection()]], [["Item1", string_type], ["Item2", string_type], ["Item3", US0$reflection()]], [["Item", array_type(string_type)]], [["Item1", string_type], ["Item2", string_type], ["Item3", array_type(string_type)], ["Item4", array_type(string_type)]], [["Item", bool_type]]]);
}

export function closure0(unitVar: void, v0_1: UH0): UH1 {
    toConsole(interpolate("%A%P()", ["request:"]));
    toConsole(interpolate("%A%P()", [v0_1]));
    return defaultOf();
}

export function method0(): string {
    return "/peer";
}

export const v0 = defaultOf();

export const v1 = new Mut0(v0);

export const v2 = (v: UH0): UH1 => closure0(void 0, v);

export const v3 = v2;

export const v4 = "update";

export const v5 = [v4, v3];

export const v6 = method0();

export const v7 = v6;

export const v8 = "endpoint";

export const v9 = [v8, v7];

export const v10 = [v5, v9];

export const v11 = ofSeq(v10, {
    Compare: comparePrimitives,
});

export const v12 = v11;

v1.l0 = v12;


