import { toString, Union, Record } from "./fable_modules/fable-library-ts/Types.js";
import { tuple_type, lambda_type, array_type, unit_type, bool_type, class_type, string_type, int32_type, union_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { uint8, op_UnaryNegation_Int32, int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { Index, createSignal, useContext, onCleanup, createEffect, For, createComponent, children as children_1, createContext } from "solid-js";
import { fill } from "./fable_modules/fable-library-ts/Array.js";
import { Input, RadioGroup, Radio, useColorMode, Anchor, Table, Tbody, hope, Tr, Td, Stack, IconButton, Icon, Button, Checkbox, Box, SimpleSelect, SimpleOption } from "@hope-ui/solid";
import { int32ToString, uncurry, createObj } from "./fable_modules/fable-library-ts/Util.js";
import { int64, fromBits, op_Division, op_Subtraction, toString as toString_1 } from "./fable_modules/fable-library-ts/Long.js";
import { getTicks, utcNow } from "./fable_modules/fable-library-ts/Date.js";
import { BiRegularMinus, BiRegularPlus, BiRegularLinkExternal, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh } from "solid-icons/bi";
import { nonSeeded } from "./fable_modules/fable-library-ts/Random.js";
import { get_UTF8 } from "./fable_modules/fable-library-ts/Encoding.js";

export class Mut0 extends Record {
    l0: any;
    constructor(l0: any) {
        super();
        this.l0 = l0;
    }
}

export function Mut0$reflection(): TypeInfo {
    return record_type("Components_spi.Mut0", [], Mut0, () => [["l0", obj_type]]);
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
    return union_type("Components_spi.US1", [], US1_Cons, () => [[], []]);
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
    return union_type("Components_spi.US0", [], US0_Cons, () => [[], [["f1_0", US1$reflection()]]]);
}

export const enum US2_Tag {
    US2_0 = 0,
    US2_1 = 1
}

export type US2_Fields = [[], []];

export type US2 = US2_Cons<US2_Tag.US2_0> | US2_Cons<US2_Tag.US2_1>;

export function US2_US2_0() {
    return new US2_Cons<US2_Tag.US2_0>(US2_Tag.US2_0, []);
}

export function US2_US2_1() {
    return new US2_Cons<US2_Tag.US2_1>(US2_Tag.US2_1, []);
}

export class US2_Cons<Tag extends keyof US2_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US2_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1"];
    }
}

export function US2$reflection(): TypeInfo {
    return union_type("Components_spi.US2", [], US2_Cons, () => [[], []]);
}

export const enum US3_Tag {
    US3_0 = 0,
    US3_1 = 1,
    US3_2 = 2,
    US3_3 = 3
}

export type US3_Fields = [[], [], [], []];

export type US3 = US3_Cons<US3_Tag.US3_0> | US3_Cons<US3_Tag.US3_1> | US3_Cons<US3_Tag.US3_2> | US3_Cons<US3_Tag.US3_3>;

export function US3_US3_0() {
    return new US3_Cons<US3_Tag.US3_0>(US3_Tag.US3_0, []);
}

export function US3_US3_1() {
    return new US3_Cons<US3_Tag.US3_1>(US3_Tag.US3_1, []);
}

export function US3_US3_2() {
    return new US3_Cons<US3_Tag.US3_2>(US3_Tag.US3_2, []);
}

export function US3_US3_3() {
    return new US3_Cons<US3_Tag.US3_3>(US3_Tag.US3_3, []);
}

export class US3_Cons<Tag extends keyof US3_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US3_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1", "US3_2", "US3_3"];
    }
}

export function US3$reflection(): TypeInfo {
    return union_type("Components_spi.US3", [], US3_Cons, () => [[], [], [], []]);
}

export const enum US4_Tag {
    US4_0 = 0,
    US4_1 = 1
}

export type US4_Fields = [[], [int32]];

export type US4 = US4_Cons<US4_Tag.US4_0> | US4_Cons<US4_Tag.US4_1>;

export function US4_US4_0() {
    return new US4_Cons<US4_Tag.US4_0>(US4_Tag.US4_0, []);
}

export function US4_US4_1(f1_0: int32) {
    return new US4_Cons<US4_Tag.US4_1>(US4_Tag.US4_1, [f1_0]);
}

export class US4_Cons<Tag extends keyof US4_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US4_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1"];
    }
}

export function US4$reflection(): TypeInfo {
    return union_type("Components_spi.US4", [], US4_Cons, () => [[], [["f1_0", int32_type]]]);
}

export const enum US5_Tag {
    US5_0 = 0,
    US5_1 = 1
}

export type US5_Fields = [[], [string]];

export type US5 = US5_Cons<US5_Tag.US5_0> | US5_Cons<US5_Tag.US5_1>;

export function US5_US5_0() {
    return new US5_Cons<US5_Tag.US5_0>(US5_Tag.US5_0, []);
}

export function US5_US5_1(f1_0: string) {
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
    return union_type("Components_spi.US5", [], US5_Cons, () => [[], [["f1_0", string_type]]]);
}

export const enum US6_Tag {
    US6_0 = 0,
    US6_1 = 1
}

export type US6_Fields = [[], [any]];

export type US6 = US6_Cons<US6_Tag.US6_0> | US6_Cons<US6_Tag.US6_1>;

export function US6_US6_0() {
    return new US6_Cons<US6_Tag.US6_0>(US6_Tag.US6_0, []);
}

export function US6_US6_1(f1_0: any) {
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
    return union_type("Components_spi.US6", [], US6_Cons, () => [[], [["f1_0", class_type("Fable.Core.JS.Function")]]]);
}

export const enum US7_Tag {
    US7_0 = 0,
    US7_1 = 1
}

export type US7_Fields = [[], [boolean]];

export type US7 = US7_Cons<US7_Tag.US7_0> | US7_Cons<US7_Tag.US7_1>;

export function US7_US7_0() {
    return new US7_Cons<US7_Tag.US7_0>(US7_Tag.US7_0, []);
}

export function US7_US7_1(f1_0: boolean) {
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
    return union_type("Components_spi.US7", [], US7_Cons, () => [[], [["f1_0", bool_type]]]);
}

export const enum US8_Tag {
    US8_0 = 0,
    US8_1 = 1
}

export type US8_Fields = [[], [() => any[]]];

export type US8 = US8_Cons<US8_Tag.US8_0> | US8_Cons<US8_Tag.US8_1>;

export function US8_US8_0() {
    return new US8_Cons<US8_Tag.US8_0>(US8_Tag.US8_0, []);
}

export function US8_US8_1(f1_0: () => any[]) {
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
    return union_type("Components_spi.US8", [], US8_Cons, () => [[], [["f1_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]]]);
}

export const enum US9_Tag {
    US9_0 = 0,
    US9_1 = 1
}

export type US9_Fields = [[], [any]];

export type US9 = US9_Cons<US9_Tag.US9_0> | US9_Cons<US9_Tag.US9_1>;

export function US9_US9_0() {
    return new US9_Cons<US9_Tag.US9_0>(US9_Tag.US9_0, []);
}

export function US9_US9_1(f1_0: any) {
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
    return union_type("Components_spi.US9", [], US9_Cons, () => [[], [["f1_0", obj_type]]]);
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
    return union_type("Components_spi.US10", [], US10_Cons, () => [[], [["f1_0", array_type(obj_type)]]]);
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
    return union_type("Components_spi.US11", [], US11_Cons, () => [[], [["f1_0", class_type("Fable.Core.JSX.Element")]]]);
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
    return union_type("Components_spi.US12", [], US12_Cons, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
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
    return union_type("Components_spi.US13", [], US13_Cons, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
}

export class Mut1 extends Record {
    l0: US5;
    l1: US5;
    l2: US5;
    l3: US6;
    l4: US5;
    l5: US5;
    l6: US5;
    l7: US5;
    l8: US5;
    l9: US5;
    l10: US7;
    l11: US8;
    l12: US5;
    l13: US5;
    l14: US7;
    l15: US9;
    l16: US5;
    l17: US5;
    l18: US5;
    l19: US10;
    l20: US7;
    l21: US5;
    l22: US5;
    l23: US5;
    l24: US5;
    l25: US5;
    l26: US5;
    l27: US11;
    l28: US5;
    l29: US5;
    l30: US5;
    l31: US11;
    l32: US5;
    l33: US5;
    l34: US5;
    l35: US5;
    l36: US5;
    l37: US5;
    l38: US5;
    l39: US5;
    l40: US12;
    l41: US13;
    l42: US12;
    l43: US5;
    l44: US5;
    l45: US5;
    l46: US5;
    l47: US5;
    l48: US5;
    l49: US5;
    l50: US5;
    l51: US5;
    l52: US5;
    l53: US5;
    l54: US5;
    l55: US5;
    l56: US5;
    l57: US5;
    l58: US5;
    l59: US5;
    l60: US11;
    l61: US5;
    l62: US5;
    l63: US9;
    l64: US9;
    l65: US5;
    l66: US4;
    l67: US5;
    constructor(l0: US5, l1: US5, l2: US5, l3: US6, l4: US5, l5: US5, l6: US5, l7: US5, l8: US5, l9: US5, l10: US7, l11: US8, l12: US5, l13: US5, l14: US7, l15: US9, l16: US5, l17: US5, l18: US5, l19: US10, l20: US7, l21: US5, l22: US5, l23: US5, l24: US5, l25: US5, l26: US5, l27: US11, l28: US5, l29: US5, l30: US5, l31: US11, l32: US5, l33: US5, l34: US5, l35: US5, l36: US5, l37: US5, l38: US5, l39: US5, l40: US12, l41: US13, l42: US12, l43: US5, l44: US5, l45: US5, l46: US5, l47: US5, l48: US5, l49: US5, l50: US5, l51: US5, l52: US5, l53: US5, l54: US5, l55: US5, l56: US5, l57: US5, l58: US5, l59: US5, l60: US11, l61: US5, l62: US5, l63: US9, l64: US9, l65: US5, l66: US4, l67: US5) {
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
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", US5$reflection()], ["l1", US5$reflection()], ["l2", US5$reflection()], ["l3", US6$reflection()], ["l4", US5$reflection()], ["l5", US5$reflection()], ["l6", US5$reflection()], ["l7", US5$reflection()], ["l8", US5$reflection()], ["l9", US5$reflection()], ["l10", US7$reflection()], ["l11", US8$reflection()], ["l12", US5$reflection()], ["l13", US5$reflection()], ["l14", US7$reflection()], ["l15", US9$reflection()], ["l16", US5$reflection()], ["l17", US5$reflection()], ["l18", US5$reflection()], ["l19", US10$reflection()], ["l20", US7$reflection()], ["l21", US5$reflection()], ["l22", US5$reflection()], ["l23", US5$reflection()], ["l24", US5$reflection()], ["l25", US5$reflection()], ["l26", US5$reflection()], ["l27", US11$reflection()], ["l28", US5$reflection()], ["l29", US5$reflection()], ["l30", US5$reflection()], ["l31", US11$reflection()], ["l32", US5$reflection()], ["l33", US5$reflection()], ["l34", US5$reflection()], ["l35", US5$reflection()], ["l36", US5$reflection()], ["l37", US5$reflection()], ["l38", US5$reflection()], ["l39", US5$reflection()], ["l40", US12$reflection()], ["l41", US13$reflection()], ["l42", US12$reflection()], ["l43", US5$reflection()], ["l44", US5$reflection()], ["l45", US5$reflection()], ["l46", US5$reflection()], ["l47", US5$reflection()], ["l48", US5$reflection()], ["l49", US5$reflection()], ["l50", US5$reflection()], ["l51", US5$reflection()], ["l52", US5$reflection()], ["l53", US5$reflection()], ["l54", US5$reflection()], ["l55", US5$reflection()], ["l56", US5$reflection()], ["l57", US5$reflection()], ["l58", US5$reflection()], ["l59", US5$reflection()], ["l60", US11$reflection()], ["l61", US5$reflection()], ["l62", US5$reflection()], ["l63", US9$reflection()], ["l64", US9$reflection()], ["l65", US5$reflection()], ["l66", US4$reflection()], ["l67", US5$reflection()]]);
}

export class Mut2 {
    constructor() {
    }
}

export function Mut2$reflection(): TypeInfo {
    return class_type("Components_spi.Mut2", void 0, Mut2);
}

export function Mut2_$ctor(): Mut2 {
    return new Mut2();
}

export class Mut3 extends Record {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut3$reflection(): TypeInfo {
    return record_type("Components_spi.Mut3", [], Mut3, () => [["l0", int32_type]]);
}

export const enum UH0_Tag {
    UH0_0 = 0,
    UH0_1 = 1
}

export type UH0_Fields = [[[string, any], UH0], []];

export type UH0 = UH0_Cons<UH0_Tag.UH0_0> | UH0_Cons<UH0_Tag.UH0_1>;

export function UH0_UH0_0(Item1: [string, any], Item2: UH0) {
    return new UH0_Cons<UH0_Tag.UH0_0>(UH0_Tag.UH0_0, [Item1, Item2]);
}

export function UH0_UH0_1() {
    return new UH0_Cons<UH0_Tag.UH0_1>(UH0_Tag.UH0_1, []);
}

export class UH0_Cons<Tag extends keyof UH0_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: UH0_Fields[Tag]) {
        super();
    }
    cases() {
        return ["UH0_0", "UH0_1"];
    }
}

export function UH0$reflection(): TypeInfo {
    return union_type("Components_spi.UH0", [], UH0_Cons, () => [[["Item1", tuple_type(string_type, obj_type)], ["Item2", UH0$reflection()]], []]);
}

export const enum US14_Tag {
    US14_0 = 0,
    US14_1 = 1,
    US14_2 = 2
}

export type US14_Fields = [[], [], []];

export type US14 = US14_Cons<US14_Tag.US14_0> | US14_Cons<US14_Tag.US14_1> | US14_Cons<US14_Tag.US14_2>;

export function US14_US14_0() {
    return new US14_Cons<US14_Tag.US14_0>(US14_Tag.US14_0, []);
}

export function US14_US14_1() {
    return new US14_Cons<US14_Tag.US14_1>(US14_Tag.US14_1, []);
}

export function US14_US14_2() {
    return new US14_Cons<US14_Tag.US14_2>(US14_Tag.US14_2, []);
}

export class US14_Cons<Tag extends keyof US14_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US14_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US14_0", "US14_1", "US14_2"];
    }
}

export function US14$reflection(): TypeInfo {
    return union_type("Components_spi.US14", [], US14_Cons, () => [[], [], []]);
}

export class Mut4 extends Record {
    l0: US13;
    l1: US13;
    l2: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5];
    l3: US14;
    constructor(l0: US13, l1: US13, l2: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], l3: US14) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
    }
}

export function Mut4$reflection(): TypeInfo {
    return record_type("Components_spi.Mut4", [], Mut4, () => [["l0", US13$reflection()], ["l1", US13$reflection()], ["l2", lambda_type(tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()), tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()))], ["l3", US14$reflection()]]);
}

export class Mut5 extends Record {
    l0: () => boolean;
    l1: (arg0: boolean) => void;
    l2: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5];
    constructor(l0: () => boolean, l1: (arg0: boolean) => void, l2: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut5$reflection(): TypeInfo {
    return record_type("Components_spi.Mut5", [], Mut5, () => [["l0", lambda_type(unit_type, bool_type)], ["l1", lambda_type(bool_type, unit_type)], ["l2", lambda_type(tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()), tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()))]]);
}

export class Mut6 extends Record {
    l0: boolean;
    l1: boolean;
    l2: US13;
    l3: US13;
    l4: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5];
    constructor(l0: boolean, l1: boolean, l2: US13, l3: US13, l4: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
    }
}

export function Mut6$reflection(): TypeInfo {
    return record_type("Components_spi.Mut6", [], Mut6, () => [["l0", bool_type], ["l1", bool_type], ["l2", US13$reflection()], ["l3", US13$reflection()], ["l4", lambda_type(tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()), tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()))]]);
}

export class Mut7 extends Record {
    l0: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5];
    l1: () => any;
    l2: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5];
    constructor(l0: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], l1: () => any, l2: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut7$reflection(): TypeInfo {
    return record_type("Components_spi.Mut7", [], Mut7, () => [["l0", lambda_type(tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()), tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()))], ["l1", lambda_type(unit_type, class_type("Fable.Core.JS.Function"))], ["l2", lambda_type(tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()), tuple_type(US5$reflection(), US5$reflection(), US5$reflection(), US6$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US8$reflection(), US5$reflection(), US5$reflection(), US7$reflection(), US9$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US10$reflection(), US7$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US5$reflection(), US11$reflection(), US5$reflection(), US5$reflection(), US9$reflection(), US9$reflection(), US5$reflection(), US4$reflection(), US5$reflection()))]]);
}

export class Mut8 extends Record {
    l0: () => US5;
    l1: (arg0: US5) => void;
    constructor(l0: () => US5, l1: (arg0: US5) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut8$reflection(): TypeInfo {
    return record_type("Components_spi.Mut8", [], Mut8, () => [["l0", lambda_type(unit_type, US5$reflection())], ["l1", lambda_type(US5$reflection(), unit_type)]]);
}

export class Mut9 extends Record {
    l0: () => US4;
    l1: (arg0: US4) => void;
    constructor(l0: () => US4, l1: (arg0: US4) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut9$reflection(): TypeInfo {
    return record_type("Components_spi.Mut9", [], Mut9, () => [["l0", lambda_type(unit_type, US4$reflection())], ["l1", lambda_type(US4$reflection(), unit_type)]]);
}

export class Mut10 extends Record {
    l0: US2;
    l1: string;
    l2: US2;
    l3: US2;
    l4: string;
    constructor(l0: US2, l1: string, l2: US2, l3: US2, l4: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
    }
}

export function Mut10$reflection(): TypeInfo {
    return record_type("Components_spi.Mut10", [], Mut10, () => [["l0", US2$reflection()], ["l1", string_type], ["l2", US2$reflection()], ["l3", US2$reflection()], ["l4", string_type]]);
}

export class Mut11 extends Record {
    l0: int32;
    l1: int32;
    constructor(l0: int32, l1: int32) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = (l1 | 0);
    }
}

export function Mut11$reflection(): TypeInfo {
    return record_type("Components_spi.Mut11", [], Mut11, () => [["l0", int32_type], ["l1", int32_type]]);
}

export class Mut12 extends Record {
    l0: US2;
    constructor(l0: US2) {
        super();
        this.l0 = l0;
    }
}

export function Mut12$reflection(): TypeInfo {
    return record_type("Components_spi.Mut12", [], Mut12, () => [["l0", US2$reflection()]]);
}

export class Mut13 extends Record {
    l0: US2;
    l1: (arg0: [US2, int32, string, string]) => US5;
    l2: (arg0: [US2, int32, string, string], arg1: US5) => [US2, int32, string, string];
    constructor(l0: US2, l1: (arg0: [US2, int32, string, string]) => US5, l2: (arg0: [US2, int32, string, string], arg1: US5) => [US2, int32, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut13$reflection(): TypeInfo {
    return record_type("Components_spi.Mut13", [], Mut13, () => [["l0", US2$reflection()], ["l1", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), US5$reflection())], ["l2", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), lambda_type(US5$reflection(), tuple_type(US2$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut14 extends Record {
    l0: int32;
    l1: US5;
    constructor(l0: int32, l1: US5) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut14$reflection(): TypeInfo {
    return record_type("Components_spi.Mut14", [], Mut14, () => [["l0", int32_type], ["l1", US5$reflection()]]);
}

export class Mut15 extends Record {
    l0: US2;
    l1: (arg0: [US2, int32, string, string]) => US4;
    l2: (arg0: [US2, int32, string, string], arg1: US4) => [US2, int32, string, string];
    constructor(l0: US2, l1: (arg0: [US2, int32, string, string]) => US4, l2: (arg0: [US2, int32, string, string], arg1: US4) => [US2, int32, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut15$reflection(): TypeInfo {
    return record_type("Components_spi.Mut15", [], Mut15, () => [["l0", US2$reflection()], ["l1", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), US4$reflection())], ["l2", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), lambda_type(US4$reflection(), tuple_type(US2$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut16 extends Record {
    l0: int32;
    l1: US4;
    constructor(l0: int32, l1: US4) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut16$reflection(): TypeInfo {
    return record_type("Components_spi.Mut16", [], Mut16, () => [["l0", int32_type], ["l1", US4$reflection()]]);
}

export const enum UH1_Tag {
    UH1_0 = 0,
    UH1_1 = 1
}

export type UH1_Fields = [[int32, int32, UH1], []];

export type UH1 = UH1_Cons<UH1_Tag.UH1_0> | UH1_Cons<UH1_Tag.UH1_1>;

export function UH1_UH1_0(Item1: int32, Item2: int32, Item3: UH1) {
    return new UH1_Cons<UH1_Tag.UH1_0>(UH1_Tag.UH1_0, [Item1, Item2, Item3]);
}

export function UH1_UH1_1() {
    return new UH1_Cons<UH1_Tag.UH1_1>(UH1_Tag.UH1_1, []);
}

export class UH1_Cons<Tag extends keyof UH1_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: UH1_Fields[Tag]) {
        super();
    }
    cases() {
        return ["UH1_0", "UH1_1"];
    }
}

export function UH1$reflection(): TypeInfo {
    return union_type("Components_spi.UH1", [], UH1_Cons, () => [[["Item1", int32_type], ["Item2", int32_type], ["Item3", UH1$reflection()]], []]);
}

export class Mut17 extends Record {
    l0: int32;
    l1: UH1;
    constructor(l0: int32, l1: UH1) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut17$reflection(): TypeInfo {
    return record_type("Components_spi.Mut17", [], Mut17, () => [["l0", int32_type], ["l1", UH1$reflection()]]);
}

export const enum UH2_Tag {
    UH2_0 = 0,
    UH2_1 = 1
}

export type UH2_Fields = [[int32, any, UH2], []];

export type UH2 = UH2_Cons<UH2_Tag.UH2_0> | UH2_Cons<UH2_Tag.UH2_1>;

export function UH2_UH2_0(Item1: int32, Item2: any, Item3: UH2) {
    return new UH2_Cons<UH2_Tag.UH2_0>(UH2_Tag.UH2_0, [Item1, Item2, Item3]);
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
    return union_type("Components_spi.UH2", [], UH2_Cons, () => [[["Item1", int32_type], ["Item2", obj_type], ["Item3", UH2$reflection()]], []]);
}

export class Mut18 extends Record {
    l0: int32;
    l1: UH2;
    constructor(l0: int32, l1: UH2) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut18$reflection(): TypeInfo {
    return record_type("Components_spi.Mut18", [], Mut18, () => [["l0", int32_type], ["l1", UH2$reflection()]]);
}

export function method0(): any {
    const v2: any = createContext;
    const v3: () => [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = (): [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] => (void 0);
    return v2<ReturnType<typeof v3>>();
}

export function method2(): [string, any, string, string, boolean] {
    const v0_1: any = components_spi.env;
    const v1_1: string = v0_1.CODESPACE_NAME || "";
    const v2: string = v0_1.GITHUB_RUN_ID || "";
    const v3: string = v0_1.GITHUB_SHA || "";
    const v4: any = v0_1.IS_TEST;
    return [v1_1, v0_1, v2, v3, (!v4) === false];
}

export function method3(): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [US5_US5_0(), US5_US5_0(), US5_US5_0(), US6_US6_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US7_US7_0(), US8_US8_0(), US5_US5_0(), US5_US5_0(), US7_US7_0(), US9_US9_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US10_US10_0(), US7_US7_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US11_US11_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US11_US11_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US12_US12_0(), US13_US13_0(), US12_US12_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US5_US5_0(), US11_US11_0(), US5_US5_0(), US5_US5_0(), US9_US9_0(), US9_US9_0(), US5_US5_0(), US4_US4_0(), US5_US5_0()];
}

export function method5(v0_1: int32, v1_1: Mut3): boolean {
    return v1_1.l0 < v0_1;
}

export function closure10(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure11(v0_1: (arg0: US3) => void, v1_1: any): void {
    let v9: boolean;
    const v2: string = toString(v1_1);
    v0_1(("Debug" === v2) ? US3_US3_0() : (("Info" === v2) ? US3_US3_2() : (("Warn" === v2) ? US3_US3_3() : ((v9 = ("Error" === v2), US3_US3_1())))));
}

export function closure15(v0_1: any, unitVar: void): any[] {
    return [<>
        {toString(v0_1)}
    </>];
}

export function method9(v0_1_mut: UH0, v1_1_mut: int32): int32 {
    method9:
    while (true) {
        const v0_1: UH0 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH0_Tag.UH0_1) {
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

export function method10(v0_1_mut: [string, any][], v1_1_mut: UH0, v2_mut: int32): int32 {
    method10:
    while (true) {
        const v0_1: [string, any][] = v0_1_mut, v1_1: UH0 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH0_Tag.UH0_1) {
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

export function method8(v0_1: UH0): [string, any][] {
    const v2: int32 = method9(v0_1, 0) | 0;
    const v3: [string, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method10(v3, v0_1, 0) | 0;
    return v3;
}

export function method7(v0_1: US5, v1_1: US5, v2: US5, v3: US6, v4: US5, v5: US5, v6: US5, v7: US5, v8: US5, v9: US5, v10: US7, v11: US8, v12: US5, v13: US5, v14: US7, v15: US9, v16: US5, v17: US5, v18: US5, v19: US10, v20: US7, v21: US5, v22: US5, v23: US5, v24: US5, v25: US5, v26: US5, v27: US11, v28: US5, v29: US5, v30: US5, v31: US11, v32: US5, v33: US5, v34: US5, v35: US5, v36: US5, v37: US5, v38: US5, v39: US5, v40: US12, v41: US13, v42: US12, v43: US5, v44: US5, v45: US5, v46: US5, v47: US5, v48: US5, v49: US5, v50: US5, v51: US5, v52: US5, v53: US5, v54: US5, v55: US5, v56: US5, v57: US5, v58: US5, v59: US5, v60: US11, v61: US5, v62: US5, v63: US9, v64: US9, v65: US5, v66: US4, v67: US5): [string, any][] {
    const v71_1: any = (v0_1.tag === US5_Tag.US5_1) ? v0_1.fields[0] : (void 0);
    const v78: UH0 = (!v71_1) ? UH0_UH0_1() : UH0_UH0_0(["alignItems", v71_1], UH0_UH0_1());
    const v82: any = (v1_1.tag === US5_Tag.US5_1) ? v1_1.fields[0] : (void 0);
    const v87: UH0 = (!v82) ? v78 : UH0_UH0_0(["alignSelf", v82], v78);
    const v91: any = (v2.tag === US5_Tag.US5_1) ? v2.fields[0] : (void 0);
    const v96: UH0 = (!v91) ? v87 : UH0_UH0_0(["aria-label", v91], v87);
    const v100: any = (v3.tag === US6_Tag.US6_1) ? v3.fields[0] : (void 0);
    const v105: UH0 = (!v100) ? v96 : UH0_UH0_0(["as", v100], v96);
    const v109: any = (v4.tag === US5_Tag.US5_1) ? v4.fields[0] : (void 0);
    const v114: UH0 = (!v109) ? v105 : UH0_UH0_0(["backgroundColor", v109], v105);
    const v118: any = (v5.tag === US5_Tag.US5_1) ? v5.fields[0] : (void 0);
    const v123: UH0 = (!v118) ? v114 : UH0_UH0_0(["border", v118], v114);
    const v127: any = (v6.tag === US5_Tag.US5_1) ? v6.fields[0] : (void 0);
    const v132: UH0 = (!v127) ? v123 : UH0_UH0_0(["borderBottomWidth", v127], v123);
    const v136: any = (v7.tag === US5_Tag.US5_1) ? v7.fields[0] : (void 0);
    const v141: UH0 = (!v136) ? v132 : UH0_UH0_0(["borderColor", v136], v132);
    const v145: any = (v8.tag === US5_Tag.US5_1) ? v8.fields[0] : (void 0);
    const v150: UH0 = (!v145) ? v141 : UH0_UH0_0(["borderWidth", v145], v141);
    const v154: any = (v9.tag === US5_Tag.US5_1) ? v9.fields[0] : (void 0);
    const v159: UH0 = (!v154) ? v150 : UH0_UH0_0(["bottom", v154], v150);
    const v163: any = (v10.tag === US7_Tag.US7_1) ? v10.fields[0] : (void 0);
    const v168: UH0 = (!v163) ? v159 : UH0_UH0_0(["checked", v163], v159);
    const v172_1: any = (v11.tag === US8_Tag.US8_1) ? v11.fields[0] : (void 0);
    const v177_1: UH0 = (!v172_1) ? v168 : UH0_UH0_0(["children", v172_1], v168);
    const v181_1: any = (v12.tag === US5_Tag.US5_1) ? v12.fields[0] : (void 0);
    const v186_1: UH0 = (!v181_1) ? v177_1 : UH0_UH0_0(["color", v181_1], v177_1);
    const v190: any = (v13.tag === US5_Tag.US5_1) ? v13.fields[0] : (void 0);
    const v195: UH0 = (!v190) ? v186_1 : UH0_UH0_0(["colorScheme", v190], v186_1);
    const v199: any = (v14.tag === US7_Tag.US7_1) ? v14.fields[0] : (void 0);
    const v204: UH0 = (!v199) ? v195 : UH0_UH0_0(["compact", v199], v195);
    const v208: any = (v15.tag === US9_Tag.US9_1) ? v15.fields[0] : (void 0);
    const v213: UH0 = (!v208) ? v204 : UH0_UH0_0(["css", v208], v204);
    const v217: any = (v16.tag === US5_Tag.US5_1) ? v16.fields[0] : (void 0);
    const v222: UH0 = (!v217) ? v213 : UH0_UH0_0(["defaultValue", v217], v213);
    const v226: any = (v17.tag === US5_Tag.US5_1) ? v17.fields[0] : (void 0);
    const v231: UH0 = (!v226) ? v222 : UH0_UH0_0(["direction", v226], v222);
    const v235: any = (v18.tag === US5_Tag.US5_1) ? v18.fields[0] : (void 0);
    const v240: UH0 = (!v235) ? v231 : UH0_UH0_0(["display", v235], v231);
    const v244: any = (v19.tag === US10_Tag.US10_1) ? v19.fields[0] : (void 0);
    const v249: UH0 = (!v244) ? v240 : UH0_UH0_0(["each", v244], v240);
    const v253: any = (v20.tag === US7_Tag.US7_1) ? v20.fields[0] : (void 0);
    const v258: UH0 = (!v253) ? v249 : UH0_UH0_0(["external", v253], v249);
    const v262: any = (v21.tag === US5_Tag.US5_1) ? v21.fields[0] : (void 0);
    const v267: UH0 = (!v262) ? v258 : UH0_UH0_0(["flex", v262], v258);
    const v271: any = (v22.tag === US5_Tag.US5_1) ? v22.fields[0] : (void 0);
    const v276: UH0 = (!v271) ? v267 : UH0_UH0_0(["flexDirection", v271], v267);
    const v280: any = (v23.tag === US5_Tag.US5_1) ? v23.fields[0] : (void 0);
    const v285: UH0 = (!v280) ? v276 : UH0_UH0_0(["flexFlow", v280], v276);
    const v289: any = (v24.tag === US5_Tag.US5_1) ? v24.fields[0] : (void 0);
    const v294: UH0 = (!v289) ? v285 : UH0_UH0_0(["fontSize", v289], v285);
    const v298: any = (v25.tag === US5_Tag.US5_1) ? v25.fields[0] : (void 0);
    const v303: UH0 = (!v298) ? v294 : UH0_UH0_0(["height", v298], v294);
    const v307: any = (v26.tag === US5_Tag.US5_1) ? v26.fields[0] : (void 0);
    const v312: UH0 = (!v307) ? v303 : UH0_UH0_0(["href", v307], v303);
    const v316: any = (v27.tag === US11_Tag.US11_1) ? v27.fields[0] : (void 0);
    const v321: UH0 = (!v316) ? v312 : UH0_UH0_0(["icon", v316], v312);
    const v325: any = (v28.tag === US5_Tag.US5_1) ? v28.fields[0] : (void 0);
    const v330: UH0 = (!v325) ? v321 : UH0_UH0_0(["id", v325], v321);
    const v334: any = (v29.tag === US5_Tag.US5_1) ? v29.fields[0] : (void 0);
    const v339: UH0 = (!v334) ? v330 : UH0_UH0_0(["justifyContent", v334], v330);
    const v343: any = (v30.tag === US5_Tag.US5_1) ? v30.fields[0] : (void 0);
    const v348: UH0 = (!v343) ? v339 : UH0_UH0_0(["left", v343], v339);
    const v352: any = (v31.tag === US11_Tag.US11_1) ? v31.fields[0] : (void 0);
    const v357: UH0 = (!v352) ? v348 : UH0_UH0_0(["leftIcon", v352], v348);
    const v361: any = (v32.tag === US5_Tag.US5_1) ? v32.fields[0] : (void 0);
    const v366: UH0 = (!v361) ? v357 : UH0_UH0_0(["lineHeight", v361], v357);
    const v370: any = (v33.tag === US5_Tag.US5_1) ? v33.fields[0] : (void 0);
    const v375: UH0 = (!v370) ? v366 : UH0_UH0_0(["margin", v370], v366);
    const v379: any = (v34.tag === US5_Tag.US5_1) ? v34.fields[0] : (void 0);
    const v384: UH0 = (!v379) ? v375 : UH0_UH0_0(["marginBottom", v379], v375);
    const v388: any = (v35.tag === US5_Tag.US5_1) ? v35.fields[0] : (void 0);
    const v393: UH0 = (!v388) ? v384 : UH0_UH0_0(["marginLeft", v388], v384);
    const v397: any = (v36.tag === US5_Tag.US5_1) ? v36.fields[0] : (void 0);
    const v402: UH0 = (!v397) ? v393 : UH0_UH0_0(["marginRight", v397], v393);
    const v406: any = (v37.tag === US5_Tag.US5_1) ? v37.fields[0] : (void 0);
    const v411: UH0 = (!v406) ? v402 : UH0_UH0_0(["marginTop", v406], v402);
    const v415: any = (v38.tag === US5_Tag.US5_1) ? v38.fields[0] : (void 0);
    const v420: UH0 = (!v415) ? v411 : UH0_UH0_0(["maxHeight", v415], v411);
    const v424: any = (v39.tag === US5_Tag.US5_1) ? v39.fields[0] : (void 0);
    const v429: UH0 = (!v424) ? v420 : UH0_UH0_0(["maxWidth", v424], v420);
    const v433: any = (v40.tag === US12_Tag.US12_1) ? v40.fields[0] : (void 0);
    const v438: UH0 = (!v433) ? v429 : UH0_UH0_0(["onChange", v433], v429);
    const v442: any = (v41.tag === US13_Tag.US13_1) ? v41.fields[0] : (void 0);
    const v447: UH0 = (!v442) ? v438 : UH0_UH0_0(["onClick", v442], v438);
    const v451: any = (v42.tag === US12_Tag.US12_1) ? v42.fields[0] : (void 0);
    const v456: UH0 = (!v451) ? v447 : UH0_UH0_0(["onInput", v451], v447);
    const v460: any = (v43.tag === US5_Tag.US5_1) ? v43.fields[0] : (void 0);
    const v465: UH0 = (!v460) ? v456 : UH0_UH0_0(["outline", v460], v456);
    const v469: any = (v44.tag === US5_Tag.US5_1) ? v44.fields[0] : (void 0);
    const v474: UH0 = (!v469) ? v465 : UH0_UH0_0(["overflow", v469], v465);
    const v478: any = (v45.tag === US5_Tag.US5_1) ? v45.fields[0] : (void 0);
    const v483: UH0 = (!v478) ? v474 : UH0_UH0_0(["overflowX", v478], v474);
    const v487: any = (v46.tag === US5_Tag.US5_1) ? v46.fields[0] : (void 0);
    const v492: UH0 = (!v487) ? v483 : UH0_UH0_0(["overflowY", v487], v483);
    const v496: any = (v47.tag === US5_Tag.US5_1) ? v47.fields[0] : (void 0);
    const v501: UH0 = (!v496) ? v492 : UH0_UH0_0(["padding", v496], v492);
    const v505: any = (v48.tag === US5_Tag.US5_1) ? v48.fields[0] : (void 0);
    const v510: UH0 = (!v505) ? v501 : UH0_UH0_0(["paddingBottom", v505], v501);
    const v514: any = (v49.tag === US5_Tag.US5_1) ? v49.fields[0] : (void 0);
    const v519: UH0 = (!v514) ? v510 : UH0_UH0_0(["paddingLeft", v514], v510);
    const v523: any = (v50.tag === US5_Tag.US5_1) ? v50.fields[0] : (void 0);
    const v528: UH0 = (!v523) ? v519 : UH0_UH0_0(["paddingRight", v523], v519);
    const v532: any = (v51.tag === US5_Tag.US5_1) ? v51.fields[0] : (void 0);
    const v537: UH0 = (!v532) ? v528 : UH0_UH0_0(["paddingTop", v532], v528);
    const v541: any = (v52.tag === US5_Tag.US5_1) ? v52.fields[0] : (void 0);
    const v546: UH0 = (!v541) ? v537 : UH0_UH0_0(["placeholder", v541], v537);
    const v550: any = (v53.tag === US5_Tag.US5_1) ? v53.fields[0] : (void 0);
    const v555: UH0 = (!v550) ? v546 : UH0_UH0_0(["position", v550], v546);
    const v559: any = (v54.tag === US5_Tag.US5_1) ? v54.fields[0] : (void 0);
    const v564: UH0 = (!v559) ? v555 : UH0_UH0_0(["right", v559], v555);
    const v568: any = (v55.tag === US5_Tag.US5_1) ? v55.fields[0] : (void 0);
    const v573: UH0 = (!v568) ? v564 : UH0_UH0_0(["size", v568], v564);
    const v577: any = (v56.tag === US5_Tag.US5_1) ? v56.fields[0] : (void 0);
    const v582: UH0 = (!v577) ? v573 : UH0_UH0_0(["spacing", v577], v573);
    const v586: any = (v57.tag === US5_Tag.US5_1) ? v57.fields[0] : (void 0);
    const v591: UH0 = (!v586) ? v582 : UH0_UH0_0(["src", v586], v582);
    const v595: any = (v58.tag === US5_Tag.US5_1) ? v58.fields[0] : (void 0);
    const v600: UH0 = (!v595) ? v591 : UH0_UH0_0(["striped", v595], v591);
    const v604: any = (v59.tag === US5_Tag.US5_1) ? v59.fields[0] : (void 0);
    const v609: UH0 = (!v604) ? v600 : UH0_UH0_0(["thickness", v604], v600);
    const v613: any = (v60.tag === US11_Tag.US11_1) ? v60.fields[0] : (void 0);
    const v618: UH0 = (!v613) ? v609 : UH0_UH0_0(["title", v613], v609);
    const v622: any = (v61.tag === US5_Tag.US5_1) ? v61.fields[0] : (void 0);
    const v627: UH0 = (!v622) ? v618 : UH0_UH0_0(["top", v622], v618);
    const v631: any = (v62.tag === US5_Tag.US5_1) ? v62.fields[0] : (void 0);
    const v636: UH0 = (!v631) ? v627 : UH0_UH0_0(["type", v631], v627);
    const v640: any = (v63.tag === US9_Tag.US9_1) ? v63.fields[0] : (void 0);
    const v645: UH0 = (!v640) ? v636 : UH0_UH0_0(["value", v640], v636);
    const v649: any = (v64.tag === US9_Tag.US9_1) ? v64.fields[0] : (void 0);
    const v654: UH0 = (!v649) ? v645 : UH0_UH0_0(["when", v649], v645);
    const v658: any = (v65.tag === US5_Tag.US5_1) ? v65.fields[0] : (void 0);
    const v663: UH0 = (!v658) ? v654 : UH0_UH0_0(["width", v658], v654);
    const v667: any = (v66.tag === US4_Tag.US4_1) ? v66.fields[0] : (void 0);
    const v672: UH0 = (!v667) ? v663 : UH0_UH0_0(["zIndex", v667], v663);
    const v676: any = (v67.tag === US5_Tag.US5_1) ? v67.fields[0] : (void 0);
    return method8((!v676) ? v672 : UH0_UH0_0(["zoom", v676], v672));
}

export function closure14(unitVar: void, v0_1: any): any[] {
    const v3: any = SimpleOption;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    let v79: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v76: any = children_1;
        v79 = US8_US8_1(v76(v15.fields[0]));
    }
    else {
        v79 = US8_US8_0();
    }
    const v86: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v79.tag === US8_Tag.US8_1) ? v79.fields[0] : ((): any[] => closure15(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], US9_US9_1(v0_1), patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v87: () => any[] = (): any[] => closure15(v0_1, void 0);
    v86.children = v87;
    const v88: (arg0: any) => any = v3;
    const v91: any = createComponent;
    return [v91(v88, v86)];
}

export function closure13(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: US10 = v0_1.l19;
    const v4: any[] = (v1_1.tag === US10_Tag.US10_1) ? v1_1.fields[0] : [];
    const v7: any = For;
    const v8: (arg0: any) => any[] = (v: any): any[] => closure14(void 0, v);
    const v9: () => any[] = v8;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v21: US8 = patternInput[11];
    let v85: US8;
    if (v21.tag === US8_Tag.US8_1) {
        const v82: any = children_1;
        v85 = US8_US8_1(v82(v21.fields[0]));
    }
    else {
        v85 = US8_US8_0();
    }
    const v91: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v85.tag === US8_Tag.US8_1) ? v85.fields[0] : v9), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], US10_US10_1(v4), patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    v91.children = v9;
    const v92: (arg0: any) => any = v7;
    const v94: any = createComponent;
    return [v94(v92, v91)];
}

export function method6(v0_1: Mut1): any {
    const v3: any = SimpleSelect;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    const v72_1: US5 = v0_1.l37;
    const v73_1: US5 = v0_1.l52;
    const v74_1: US9 = v0_1.l63;
    const v75_1: US12 = v0_1.l40;
    let v83: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v80: any = children_1;
        v83 = US8_US8_1(v80(v15.fields[0]));
    }
    else {
        v83 = US8_US8_0();
    }
    const v91: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v83.tag === US8_Tag.US8_1) ? v83.fields[0] : ((): any[] => closure13(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], v72_1, patternInput[38], patternInput[39], v75_1, patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], v73_1, patternInput[53], patternInput[54], US5_US5_1("xs"), patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], v74_1, patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v92: () => any[] = (): any[] => closure13(v0_1, void 0);
    v91.children = v92;
    const v93: (arg0: any) => any = v3;
    const v96: any = createComponent;
    return v96(v93, v91);
}

export function closure12(unitVar: void, v0_1: Mut1): any {
    return method6(v0_1);
}

export function closure9(v0_1: (arg0: US3) => void, v1_1: () => US3, unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v13: US8 = patternInput[11];
    const v74_1: US3[] = [US3_US3_0(), US3_US3_2(), US3_US3_3(), US3_US3_1()];
    const v75_1: int32 = v74_1.length | 0;
    const v76: string[] = fill(new Array(v75_1), 0, v75_1, "");
    const v77: Mut3 = new Mut3(0);
    while (method5(v75_1, v77)) {
        const v79: int32 = v77.l0 | 0;
        const v80: US3 = v74_1[v79];
        const v85: string = (v80.tag === US3_Tag.US3_1) ? "Error" : ((v80.tag === US3_Tag.US3_2) ? "Info" : ((v80.tag === US3_Tag.US3_3) ? "Warn" : "Debug"));
        v76[v79] = v85;
        const v86: int32 = (v79 + 1) | 0;
        v77.l0 = (v86 | 0);
    }
    const v87: int32 = v76.length | 0;
    const v88: any[] = fill(new Array(v87), 0, v87, null);
    const v89: Mut3 = new Mut3(0);
    while (method5(v87, v89)) {
        const v91: int32 = v89.l0 | 0;
        const v92: string = v76[v91];
        v88[v91] = v92;
        const v94: int32 = (v91 + 1) | 0;
        v89.l0 = (v94 | 0);
    }
    const v95: US3 = v1_1();
    const v100: string = (v95.tag === US3_Tag.US3_1) ? "Error" : ((v95.tag === US3_Tag.US3_2) ? "Info" : ((v95.tag === US3_Tag.US3_3) ? "Warn" : "Debug"));
    let v109: US8;
    if (v13.tag === US8_Tag.US8_1) {
        const v106: any = children_1;
        v109 = US8_US8_1(v106(v13.fields[0]));
    }
    else {
        v109 = US8_US8_0();
    }
    const v117: (arg0: any) => void = (v: any): void => {
        closure11(v0_1, v);
    };
    const v120: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v109.tag === US8_Tag.US8_1) ? v109.fields[0] : ((): any[] => closure10(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], US10_US10_1(v88), patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], US5_US5_1("2px"), patternInput[38], patternInput[39], US12_US12_1(v117), patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], US9_US9_1(v100), patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v121: () => any[] = (): any[] => closure10(void 0, void 0);
    v120.children = v121;
    const v124: any = createComponent;
    const v125: (arg0: Mut1) => any = (v_1: Mut1): any => closure12(void 0, v_1);
    return [v124(v125, v120)];
}

export function closure8(v0_1: (arg0: US3) => void, v1_1: () => US3, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: () => any[] = (): any[] => closure9(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Log Level
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method12(v0_1: string, v1_1: string): string {
    return {
        "@initial": v1_1,
        "@sm": v0_1,
    };
}

export function closure20(v0_1: any, unitVar: void): any[] {
    return [v0_1];
}

export function closure19(v0_1: any, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v69: () => any[] = (): any[] => closure20(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v69), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure23(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure22(v0_1: US5, v1_1: US5, v2: US5, v3: US6, v4: US5, v5: US5, v6: US5, v7: US5, v8: US5, v9: US5, v10: US7, v11: US8, v12: US5, v13: US5, v14: US7, v15: US9, v16: US5, v17: US5, v18: US5, v19: US10, v20: US7, v21: US5, v22: US5, v23: US5, v24: US5, v25: US5, v26: US5, v27: US11, v28: US5, v29: US5, v30: US5, v31: US11, v32: US5, v33: US5, v34: US5, v35: US5, v36: US5, v37: US5, v38: US5, v39: US5, v40: US12, v41: US13, v42: US12, v43: US5, v44: US5, v45: US5, v46: US5, v47: US5, v48: US5, v49: US5, v50: US5, v51: US5, v52: US5, v53: US5, v54: US5, v55: US5, v56: US5, v57: US5, v58: US5, v59: US5, v60: US11, v61: US5, v62: US5, v63: US9, v64: US9, v65: US5, v66: US4, v67: US5, unitVar: void): any[] {
    const v70_1: any = Box;
    const v73_1: () => any[] = (v11.tag === US8_Tag.US8_1) ? v11.fields[0] : ((): any[] => closure23(void 0, void 0));
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v85: US8 = patternInput[11];
    let v149: US8;
    if (v85.tag === US8_Tag.US8_1) {
        const v146: any = children_1;
        v149 = US8_US8_1(v146(v85.fields[0]));
    }
    else {
        v149 = US8_US8_0();
    }
    const v156: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v149.tag === US8_Tag.US8_1) ? v149.fields[0] : v73_1), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US5_US5_1("2px"), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    v156.children = v73_1;
    const v157: (arg0: any) => any = v70_1;
    const v160: any = createComponent;
    return [v160(v157, v156)];
}

export function closure24(v0_1: Mut5, v1_1: any): void {
    const v2: boolean = v1_1.target.checked;
    v0_1.l1(v2);
}

export function closure21(unitVar: void, v0_1: Mut5): any {
    const v1_1: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v0_1.l2;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v99: US5 = patternInput_1[29];
    const v98: US5 = patternInput_1[28];
    const v97: US11 = patternInput_1[27];
    const v96: US5 = patternInput_1[26];
    const v95: US5 = patternInput_1[25];
    const v94: US5 = patternInput_1[24];
    const v93: US5 = patternInput_1[23];
    const v92: US5 = patternInput_1[22];
    const v91: US5 = patternInput_1[21];
    const v90: US7 = patternInput_1[20];
    const v89: US10 = patternInput_1[19];
    const v88: US5 = patternInput_1[18];
    const v87: US5 = patternInput_1[17];
    const v86: US5 = patternInput_1[16];
    const v85: US9 = patternInput_1[15];
    const v84: US7 = patternInput_1[14];
    const v83: US5 = patternInput_1[13];
    const v82: US5 = patternInput_1[12];
    const v81: US8 = patternInput_1[11];
    const v80: US7 = patternInput_1[10];
    const v79: US5 = patternInput_1[9];
    const v78: US5 = patternInput_1[8];
    const v77: US5 = patternInput_1[7];
    const v76: US5 = patternInput_1[6];
    const v75_1: US5 = patternInput_1[5];
    const v74_1: US5 = patternInput_1[4];
    const v73_1: US6 = patternInput_1[3];
    const v72_1: US5 = patternInput_1[2];
    const v71_1: US5 = patternInput_1[1];
    const v70_1: US5 = patternInput_1[0];
    const v137: US5 = patternInput_1[67];
    const v136: US4 = patternInput_1[66];
    const v135: US5 = patternInput_1[65];
    const v134: US9 = patternInput_1[64];
    const v133: US9 = patternInput_1[63];
    const v132: US5 = patternInput_1[62];
    const v131: US5 = patternInput_1[61];
    const v130: US11 = patternInput_1[60];
    const v129: US5 = patternInput_1[59];
    const v128: US5 = patternInput_1[58];
    const v127: US5 = patternInput_1[57];
    const v126: US5 = patternInput_1[56];
    const v125: US5 = patternInput_1[55];
    const v124: US5 = patternInput_1[54];
    const v123: US5 = patternInput_1[53];
    const v122: US5 = patternInput_1[52];
    const v121: US5 = patternInput_1[51];
    const v120: US5 = patternInput_1[50];
    const v119: US5 = patternInput_1[49];
    const v118: US5 = patternInput_1[48];
    const v117: US5 = patternInput_1[47];
    const v116: US5 = patternInput_1[46];
    const v115: US5 = patternInput_1[45];
    const v114: US5 = patternInput_1[44];
    const v113: US5 = patternInput_1[43];
    const v112: US12 = patternInput_1[42];
    const v111: US13 = patternInput_1[41];
    const v110: US12 = patternInput_1[40];
    const v109: US5 = patternInput_1[39];
    const v108: US5 = patternInput_1[38];
    const v107: US5 = patternInput_1[37];
    const v106: US5 = patternInput_1[36];
    const v105: US5 = patternInput_1[35];
    const v104: US5 = patternInput_1[34];
    const v103: US5 = patternInput_1[33];
    const v102: US5 = patternInput_1[32];
    const v101: US11 = patternInput_1[31];
    const v100: US5 = patternInput_1[30];
    let v145: US8;
    if (v81.tag === US8_Tag.US8_1) {
        const v142: any = children_1;
        v145 = US8_US8_1(v142(v81.fields[0]));
    }
    else {
        v145 = US8_US8_0();
    }
    const v148: any = Checkbox;
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v160: US8 = patternInput_2[11];
    const v218: boolean = v0_1.l0();
    let v226: US8;
    if (v160.tag === US8_Tag.US8_1) {
        const v223: any = children_1;
        v226 = US8_US8_1(v223(v160.fields[0]));
    }
    else {
        v226 = US8_US8_0();
    }
    const v236: (arg0: any) => void = (v: any): void => {
        closure24(v0_1, v);
    };
    const v241: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v218), US8_US8_1((v226.tag === US8_Tag.US8_1) ? v226.fields[0] : ((): any[] => closure22(v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, void 0))), patternInput_2[12], US5_US5_1("neutral"), patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], US5_US5_1("2px"), patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], US12_US12_1(v236), patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], US5_US5_1("sm"), patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]));
    const v242: () => any[] = (): any[] => closure22(v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, void 0);
    v241.children = v242;
    const v243: (arg0: any) => any = v148;
    const v246: any = createComponent;
    return v246(v243, v241);
}

export function closure18(v0_1: Mut4, v1_1: (arg0: boolean) => void, v2: () => boolean, v3: any, unitVar: void): any[] {
    let v12: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v13: Mut5, v16: any, v17: (arg0: Mut5) => any, v5: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v6: Mut5, v9: any, v10: (arg0: Mut5) => any;
    const v4: US14 = v0_1.l3;
    return [(v4.tag === US14_Tag.US14_1) ? ((v12 = ((arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure19(v3, arg10$0040_1)), (v13 = (new Mut5(v2, v1_1, v12)), (v16 = createComponent, (v17 = ((v_1: Mut5): any => closure21(void 0, v_1)), v16(v17, v13)))))) : ((v4.tag === US14_Tag.US14_2) ? v3 : ((v5 = ((arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure19(v3, arg10$0040)), (v6 = (new Mut5(v2, v1_1, v5)), (v9 = createComponent, (v10 = ((v: Mut5): any => closure21(void 0, v)), v9(v10, v6)))))))];
}

export function closure25(unitVar: void, unitVar_1: void): any[] {
    return [<>
        &nbsp;
    </>];
}

export function closure27(v0_1: () => any[], _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v0_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure29(v0_1: () => US3, unitVar: void): boolean {
    if (v0_1().tag === US3_Tag.US3_0) {
        return true;
    }
    else {
        return false;
    }
}

export function closure30(v0_1: int32, v1_1: () => string, v2: () => US3, v3: () => US4, unitVar: void): any[] {
    return ["loader_id:", v0_1, "chain_token:", v1_1(), "log_level:", v2(), "ui_modal:", v3()];
}

export function method15(v0_1_mut: int32, v1_1_mut: string): string {
    method15:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: string = v1_1_mut;
        if (v1_1.length < v0_1) {
            v0_1_mut = v0_1;
            v1_1_mut = (`0${v1_1}`);
            continue method15;
        }
        else {
            return v1_1;
        }
        break;
    }
}

export function closure31(v0_1: () => boolean, v1_1: () => any[], v2: string, v3: string, v4: any, v5: string, v6: string, v7: boolean, v8: int64, v9: any[]): void {
    let copyOfStruct: Date;
    if (v0_1()) {
        const v17: string = `[${method15(6, toString_1(op_Subtraction(op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false)), v8)))}] ${components_spi.run_id}`;
        const v18: string = JSON.stringify(v9);
        const v19: any[] = v1_1();
        const v20: string = JSON.stringify(v19);
        let patternInput: [string, string, string, string, string];
        if (v7) {
            const v21: string = "";
            patternInput = [v17, v18, v20, v21, v21];
        }
        else {
            patternInput = [`${v17} %c%s %c%s`, `font-weight: bold; color: ${v2}`, v18, "font-weight: bold; color: #444", v20];
        }
        console.log.apply(console, [patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]]);
    }
}

export function method14(v0_1: () => boolean, v1_1: () => any[], v2: string): (arg0: any[]) => void {
    let copyOfStruct: Date;
    const patternInput: [string, any, string, string, boolean] = method2();
    const v8: int64 = op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false));
    return (v: any[]): void => {
        closure31(v0_1, v1_1, v2, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], v8, v);
    };
}

export function closure32(v0_1: Mut6, v1_1: int32, v2: (arg0: US4) => void, unitVar: void): void {
    if (v0_1.l1) {
        v2(US4_US4_1(v1_1));
    }
}

export function method16(v0_1: () => void): void {
    const v3: any = createEffect;
    v3(v0_1);
}

export function closure33(v0_1: (arg0: boolean) => void, v1_1: () => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure34(v0_1: Mut6, unitVar: void): void {
    const v1_1: US13 = v0_1.l3;
    if (v1_1.tag === US13_Tag.US13_1) {
        v1_1.fields[0]();
    }
}

export function method17(v0_1: () => void): void {
    const v3: any = onCleanup;
    v3(v0_1);
}

export function closure37(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Load
    </>];
}

export function closure38(v0_1: (arg0: boolean) => void, v1_1: Mut6, unitVar: void): void {
    const v2: US13 = v1_1.l2;
    if (v2.tag === US13_Tag.US13_1) {
        v2.fields[0]();
    }
    v0_1(true);
}

export function closure40(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method19(v0_1: Mut1, v1_1: Mut1): void {
    const v2: string[] = Object.keys(v0_1);
    const v3: int32 = v2.length | 0;
    const v4: Mut3 = new Mut3(0);
    while (method5(v3, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v7: string = v2[v6];
        if (!!v1_1[v7].tag) {
            v0_1[v7] = v1_1[v7];
        }
        const v9: int32 = (v6 + 1) | 0;
        v4.l0 = (v9 | 0);
    }
}

export function method18(v0_1: Mut1): any {
    const v3: any = Button;
    const v4: US8 = v0_1.l11;
    const v7: () => any[] = (v4.tag === US8_Tag.US8_1) ? v4.fields[0] : ((): any[] => closure40(void 0, void 0));
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67];
    const v152: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], US5_US5_1("neutral"), US7_US7_1(true), patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], US5_US5_1("left"), patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], US5_US5_1("xs"), patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    method19(v152, new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = [v152.l0, v152.l1, v152.l2, v152.l3, v152.l4, v152.l5, v152.l6, v152.l7, v152.l8, v152.l9, v152.l10, v152.l11, v152.l12, v152.l13, v152.l14, v152.l15, v152.l16, v152.l17, v152.l18, v152.l19, v152.l20, v152.l21, v152.l22, v152.l23, v152.l24, v152.l25, v152.l26, v152.l27, v152.l28, v152.l29, v152.l30, v152.l31, v152.l32, v152.l33, v152.l34, v152.l35, v152.l36, v152.l37, v152.l38, v152.l39, v152.l40, v152.l41, v152.l42, v152.l43, v152.l44, v152.l45, v152.l46, v152.l47, v152.l48, v152.l49, v152.l50, v152.l51, v152.l52, v152.l53, v152.l54, v152.l55, v152.l56, v152.l57, v152.l58, v152.l59, v152.l60, v152.l61, v152.l62, v152.l63, v152.l64, v152.l65, v152.l66, v152.l67];
    const v164: US8 = patternInput_2[11];
    let v228: US8;
    if (v164.tag === US8_Tag.US8_1) {
        const v225: any = children_1;
        v228 = US8_US8_1(v225(v164.fields[0]));
    }
    else {
        v228 = US8_US8_0();
    }
    const v233: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v228.tag === US8_Tag.US8_1) ? v228.fields[0] : v7), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]));
    v233.children = v7;
    const v234: (arg0: any) => any = v3;
    const v237: any = createComponent;
    return v237(v234, v233);
}

export function closure39(unitVar: void, v0_1: Mut1): any {
    return method18(v0_1);
}

export function closure36(v0_1: (arg0: boolean) => void, v1_1: Mut6, unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v13: US8 = patternInput[11];
    let v77: US8;
    if (v13.tag === US8_Tag.US8_1) {
        const v74_1: any = children_1;
        v77 = US8_US8_1(v74_1(v13.fields[0]));
    }
    else {
        v77 = US8_US8_0();
    }
    const v82: () => void = (): void => {
        closure38(v0_1, v1_1, void 0);
    };
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v77.tag === US8_Tag.US8_1) ? v77.fields[0] : ((): any[] => closure37(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], US13_US13_1(v82), patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v85: () => any[] = (): any[] => closure37(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure39(void 0, v);
    return [v88(v89, v84)];
}

export function closure44(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure45(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularRefresh;
    return v2;
}

export function closure47(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method20(v0_1: Mut7): any {
    const v3: any = Icon;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v73_1: any = v0_1.l1();
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v85: US8 = patternInput_1[11];
    let v149: US8;
    if (v85.tag === US8_Tag.US8_1) {
        const v146: any = children_1;
        v149 = US8_US8_1(v146(v85.fields[0]));
    }
    else {
        v149 = US8_US8_0();
    }
    const v151: string = "-12px";
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v0_1.l0([patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], v149, patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], US5_US5_1(v151), patternInput_1[36], US5_US5_1(v151), patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], US5_US5_1("0.6")]);
    const v225: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]));
    const patternInput_3: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v0_1.l2([patternInput[0], patternInput[1], patternInput[2], US6_US6_1(v73_1), patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], US9_US9_1(v225), patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], US5_US5_1("14px"), patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v242: US8 = patternInput_3[11];
    let v306: US8;
    if (v242.tag === US8_Tag.US8_1) {
        const v303: any = children_1;
        v306 = US8_US8_1(v303(v242.fields[0]));
    }
    else {
        v306 = US8_US8_0();
    }
    const v312: any = createObj(method7(patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3], patternInput_3[4], patternInput_3[5], patternInput_3[6], patternInput_3[7], patternInput_3[8], patternInput_3[9], patternInput_3[10], US8_US8_1((v306.tag === US8_Tag.US8_1) ? v306.fields[0] : ((): any[] => closure47(void 0, void 0))), patternInput_3[12], patternInput_3[13], patternInput_3[14], patternInput_3[15], patternInput_3[16], patternInput_3[17], patternInput_3[18], patternInput_3[19], patternInput_3[20], patternInput_3[21], patternInput_3[22], patternInput_3[23], patternInput_3[24], patternInput_3[25], patternInput_3[26], patternInput_3[27], patternInput_3[28], patternInput_3[29], patternInput_3[30], patternInput_3[31], patternInput_3[32], patternInput_3[33], patternInput_3[34], patternInput_3[35], patternInput_3[36], patternInput_3[37], patternInput_3[38], patternInput_3[39], patternInput_3[40], patternInput_3[41], patternInput_3[42], patternInput_3[43], patternInput_3[44], patternInput_3[45], patternInput_3[46], patternInput_3[47], patternInput_3[48], patternInput_3[49], patternInput_3[50], patternInput_3[51], patternInput_3[52], patternInput_3[53], patternInput_3[54], patternInput_3[55], patternInput_3[56], patternInput_3[57], patternInput_3[58], patternInput_3[59], patternInput_3[60], patternInput_3[61], patternInput_3[62], patternInput_3[63], patternInput_3[64], patternInput_3[65], patternInput_3[66], patternInput_3[67]));
    const v313: () => any[] = (): any[] => closure47(void 0, void 0);
    v312.children = v313;
    const v314: (arg0: any) => any = v3;
    const v317: any = createComponent;
    return v317(v314, v312);
}

export function closure46(unitVar: void, v0_1: Mut7): any {
    return method20(v0_1);
}

export function closure48(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure49(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure50(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularDownArrow;
    return v2;
}

export function closure51(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUpArrow;
    return v2;
}

export function closure52(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure53(v0_1: int32, v1_1: (arg0: US4) => void, v2: () => US4, unitVar: void): void {
    const v3: US4 = v2();
    v1_1((((v3.tag === US4_Tag.US4_1) && (v3.fields[0] === v0_1)) === false) ? US4_US4_1(v0_1) : US4_US4_0());
}

export function closure54(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUndo;
    return v2;
}

export function closure55(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure56(v0_1: (arg0: boolean) => void, v1_1: Mut6, unitVar: void): void {
    const v2: US13 = v1_1.l3;
    if (v2.tag === US13_Tag.US13_1) {
        v2.fields[0]();
    }
    v0_1(false);
}

export function closure43(v0_1: int32, v1_1: (arg0: US4) => void, v2: (arg0: boolean) => void, v3: (arg0: boolean) => void, v4: Mut6, v5: () => US4, unitVar: void): any[] {
    const v8: any = IconButton;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v20: US8 = patternInput[11];
    const v77: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure44(void 0, arg10$0040);
    const v78: () => any = (): any => closure45(void 0, void 0);
    const v79: Mut7 = new Mut7(v77, v78, v77);
    const v82: any = createComponent;
    const v83: (arg0: Mut7) => any = (v: Mut7): any => closure46(void 0, v);
    const v84: any = v82(v83, v79);
    let v91: US8;
    if (v20.tag === US8_Tag.US8_1) {
        const v88: any = children_1;
        v91 = US8_US8_1(v88(v20.fields[0]));
    }
    else {
        v91 = US8_US8_0();
    }
    const v98: string = "neutral";
    const v100: string = "20px";
    const v103: () => void = (): void => {
        closure49(v3, void 0);
    };
    const v105: string = "xs";
    const v108: any = createObj(method7(patternInput[0], patternInput[1], US5_US5_1("Refresh"), patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v91.tag === US8_Tag.US8_1) ? v91.fields[0] : ((): any[] => closure48(void 0, void 0))), patternInput[12], US5_US5_1(v98), patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], US5_US5_1(v100), patternInput[26], US11_US11_1(v84), patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], US13_US13_1(v103), patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], US5_US5_1(v105), patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v109: () => any[] = (): any[] => closure48(void 0, void 0);
    v108.children = v109;
    const v110: (arg0: any) => any = v8;
    const v111: any = createComponent;
    const v112: any = v111(v110, v108);
    const v113: any = IconButton;
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v125: US8 = patternInput_1[11];
    const v182_1: US4 = v5();
    const v189: string = ((v182_1.tag === US4_Tag.US4_1) && (v182_1.fields[0] === v0_1)) ? "Restore" : "Maximize";
    const v190: US4 = v5();
    const v198: Mut7 = new Mut7(v77, ((v190.tag === US4_Tag.US4_1) && (v190.fields[0] === v0_1)) ? ((): any => closure50(void 0, void 0)) : ((): any => closure51(void 0, void 0)), v77);
    const v199: any = createComponent;
    const v200: any = v199(v83, v198);
    let v207: US8;
    if (v125.tag === US8_Tag.US8_1) {
        const v204: any = children_1;
        v207 = US8_US8_1(v204(v125.fields[0]));
    }
    else {
        v207 = US8_US8_0();
    }
    const v216: () => void = (): void => {
        closure53(v0_1, v1_1, v5, void 0);
    };
    const v220: any = createObj(method7(patternInput_1[0], patternInput_1[1], US5_US5_1(v189), patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v207.tag === US8_Tag.US8_1) ? v207.fields[0] : ((): any[] => closure52(void 0, void 0))), patternInput_1[12], US5_US5_1(v98), patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], US5_US5_1(v100), patternInput_1[26], US11_US11_1(v200), patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], US13_US13_1(v216), patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], US5_US5_1(v105), patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    const v221: () => any[] = (): any[] => closure52(void 0, void 0);
    v220.children = v221;
    const v222: (arg0: any) => any = v113;
    const v223: any = createComponent;
    const v224: any = v223(v222, v220);
    const v225: any = IconButton;
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v237: US8 = patternInput_2[11];
    const v294: () => any = (): any => closure54(void 0, void 0);
    const v295: Mut7 = new Mut7(v77, v294, v77);
    const v296: any = createComponent;
    const v297: any = v296(v83, v295);
    let v304: US8;
    if (v237.tag === US8_Tag.US8_1) {
        const v301: any = children_1;
        v304 = US8_US8_1(v301(v237.fields[0]));
    }
    else {
        v304 = US8_US8_0();
    }
    const v314: () => void = (): void => {
        closure56(v2, v4, void 0);
    };
    const v318: any = createObj(method7(patternInput_2[0], patternInput_2[1], US5_US5_1("Unload"), patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v304.tag === US8_Tag.US8_1) ? v304.fields[0] : ((): any[] => closure55(void 0, void 0))), patternInput_2[12], US5_US5_1(v98), patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], US5_US5_1(v100), patternInput_2[26], US11_US11_1(v297), patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], US13_US13_1(v314), patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], US5_US5_1(v105), patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]));
    const v319: () => any[] = (): any[] => closure55(void 0, void 0);
    v318.children = v319;
    const v320: (arg0: any) => any = v225;
    const v321: any = createComponent;
    return [v112, v224, v321(v320, v318)];
}

export function closure42(v0_1: int32, v1_1: (arg0: US4) => void, v2: () => US4, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: () => boolean, v6: Mut6, v7: () => any[], unitVar: void): any[] {
    const v10: any = Stack;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v22: US8 = patternInput[11];
    const v79: US4 = v2();
    const v88: US5 = (v79.tag === US4_Tag.US4_1) ? (((v79.fields[0] === v0_1) !== true) ? US5_US5_1("none") : US5_US5_0()) : US5_US5_0();
    let v96: US8;
    if (v22.tag === US8_Tag.US8_1) {
        const v93: any = children_1;
        v96 = US8_US8_1(v93(v22.fields[0]));
    }
    else {
        v96 = US8_US8_0();
    }
    const v105: string = "6px";
    const v113: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v96.tag === US8_Tag.US8_1) ? v96.fields[0] : ((): any[] => closure43(v0_1, v1_1, v3, v4, v6, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US5_US5_1("row"), v88, patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], US5_US5_1("absolute"), US5_US5_1(v105), patternInput[55], US5_US5_1("3px"), patternInput[57], patternInput[58], patternInput[59], patternInput[60], US5_US5_1(v105), patternInput[62], patternInput[63], patternInput[64], patternInput[65], US4_US4_1(2), patternInput[67]));
    const v114: () => any[] = (): any[] => closure43(v0_1, v1_1, v3, v4, v6, v2, void 0);
    v113.children = v114;
    const v115: (arg0: any) => any = v10;
    const v118: any = createComponent;
    return [v118(v115, v113), v5() ? (void 0) : v7];
}

export function closure41(v0_1: US5, v1_1: US5, v2: US5, v3: US6, v4: US5, v5: US5, v6: US5, v7: US5, v8: US5, v9: US5, v10: US7, v11: US8, v12: US5, v13: US5, v14: US7, v15: US9, v16: US5, v17: US5, v18: US5, v19: US10, v20: US7, v21: US5, v22: US5, v23: US5, v24: US5, v25: US5, v26: US5, v27: US11, v28: US5, v29: US5, v30: US5, v31: US11, v32: US5, v33: US5, v34: US5, v35: US5, v36: US5, v37: US5, v38: US5, v39: US5, v40: US12, v41: US13, v42: US12, v43: US5, v44: US5, v45: US5, v46: US5, v47: US5, v48: US5, v49: US5, v50: US5, v51: US5, v52: US5, v53: US5, v54: US5, v55: US5, v56: US5, v57: US5, v58: US5, v59: US5, v60: US11, v61: US5, v62: US5, v63: US9, v64: US9, v65: US5, v66: US4, v67: US5, v68: int32, v69: (arg0: US4) => void, v70_1: () => US4, v71_1: (arg0: boolean) => void, v72_1: (arg0: boolean) => void, v73_1: () => boolean, v74_1: Mut6, unitVar: void): any[] {
    let v76: () => any[], v79: any, patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v91: US8, v154: US5, v162: US8, v159: any, v172_1: any, v173_1: () => any[], v174_1: (arg0: any) => any, v177_1: any;
    return [(v11.tag === US8_Tag.US8_1) ? ((v76 = v11.fields[0], (v79 = Box, (patternInput = method3(), (v91 = patternInput[11], (v154 = ((v70_1().tag === US4_Tag.US4_0) ? US5_US5_1("relative") : US5_US5_0()), (v162 = ((v91.tag === US8_Tag.US8_1) ? ((v159 = children_1, US8_US8_1(v159(v91.fields[0])))) : US8_US8_0()), (v172_1 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v162.tag === US8_Tag.US8_1) ? v162.fields[0] : ((): any[] => closure42(v68, v69, v70_1, v71_1, v72_1, v73_1, v74_1, v76, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US5_US5_1("flex"), patternInput[19], patternInput[20], US5_US5_1("1"), patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], v154, patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67])), (v173_1 = ((): any[] => closure42(v68, v69, v70_1, v71_1, v72_1, v73_1, v74_1, v76, void 0)), (v172_1.children = v173_1, (v174_1 = (v79), (v177_1 = createComponent, v177_1(v174_1, v172_1))))))))))))) : (void 0)];
}

export function closure35(v0_1: US5, v1_1: US5, v2: US5, v3: US6, v4: US5, v5: US5, v6: US5, v7: US5, v8: US5, v9: US5, v10: US7, v11: US8, v12: US5, v13: US5, v14: US7, v15: US9, v16: US5, v17: US5, v18: US5, v19: US10, v20: US7, v21: US5, v22: US5, v23: US5, v24: US5, v25: US5, v26: US5, v27: US11, v28: US5, v29: US5, v30: US5, v31: US11, v32: US5, v33: US5, v34: US5, v35: US5, v36: US5, v37: US5, v38: US5, v39: US5, v40: US12, v41: US13, v42: US12, v43: US5, v44: US5, v45: US5, v46: US5, v47: US5, v48: US5, v49: US5, v50: US5, v51: US5, v52: US5, v53: US5, v54: US5, v55: US5, v56: US5, v57: US5, v58: US5, v59: US5, v60: US11, v61: US5, v62: US5, v63: US9, v64: US9, v65: US5, v66: US4, v67: US5, v68: int32, v69: (arg0: US4) => void, v70_1: () => US4, v71_1: (arg0: boolean) => void, v72_1: () => boolean, v73_1: (arg0: boolean) => void, v74_1: () => boolean, v75_1: Mut6, unitVar: void): any[] {
    let v80: any, patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v92: US8, v156: US8, v153: any, v164: any, v165: () => any[], v166: (arg0: any) => any, v169: any, v173_1: any, patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v185_1: US8, v242: US4, v249: US4, v250: US4, v258: US5, v259: US4, v267: US5, v268: US4, v276: US5, v277: US4, v285: US5, v286: US4, v294: US5, v295: US4, v303: US5, v311: US8, v308: any, v321: any, v322: () => any[], v323: (arg0: any) => any, v326: any;
    return [(v72_1() === false) ? ((v80 = Box, (patternInput = method3(), (v92 = patternInput[11], (v156 = ((v92.tag === US8_Tag.US8_1) ? ((v153 = children_1, US8_US8_1(v153(v92.fields[0])))) : US8_US8_0()), (v164 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v156.tag === US8_Tag.US8_1) ? v156.fields[0] : ((): any[] => closure36(v71_1, v75_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US5_US5_1("3px 0"), patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67])), (v165 = ((): any[] => closure36(v71_1, v75_1, void 0)), (v164.children = v165, (v166 = (v80), (v169 = createComponent, v169(v166, v164))))))))))) : ((v173_1 = Box, (patternInput_1 = method3(), (v185_1 = patternInput_1[11], (v242 = v70_1(), (v249 = (((v242.tag === US4_Tag.US4_1) && (v242.fields[0] === v68)) ? US4_US4_1(1) : US4_US4_0()), (v250 = v70_1(), (v258 = (((v250.tag === US4_Tag.US4_1) && (v250.fields[0] === v68)) ? US5_US5_1("fixed") : US5_US5_0()), (v259 = v70_1(), (v267 = (((v259.tag === US4_Tag.US4_1) && (v259.fields[0] === v68)) ? US5_US5_1("0") : US5_US5_0()), (v268 = v70_1(), (v276 = (((v268.tag === US4_Tag.US4_1) && (v268.fields[0] === v68)) ? US5_US5_1("0") : US5_US5_0()), (v277 = v70_1(), (v285 = (((v277.tag === US4_Tag.US4_1) && (v277.fields[0] === v68)) ? US5_US5_1("0") : US5_US5_0()), (v286 = v70_1(), (v294 = (((v286.tag === US4_Tag.US4_1) && (v286.fields[0] === v68)) ? US5_US5_1("0") : US5_US5_0()), (v295 = v70_1(), (v303 = (((v295.tag === US4_Tag.US4_1) && (v295.fields[0] === v68)) ? US5_US5_1("$bg") : US5_US5_0()), (v311 = ((v185_1.tag === US8_Tag.US8_1) ? ((v308 = children_1, US8_US8_1(v308(v185_1.fields[0])))) : US8_US8_0()), (v321 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], v303, patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], v285, patternInput_1[10], US8_US8_1((v311.tag === US8_Tag.US8_1) ? v311.fields[0] : ((): any[] => closure41(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70_1, v71_1, v73_1, v74_1, v75_1, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US5_US5_1("flex"), patternInput_1[19], patternInput_1[20], US5_US5_1("1"), patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], v294, patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], v258, v276, patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], v267, patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], v249, patternInput_1[67])), (v322 = ((): any[] => closure41(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70_1, v71_1, v73_1, v74_1, v75_1, void 0)), (v321.children = v322, (v323 = (v173_1), (v326 = createComponent, v326(v323, v321)))))))))))))))))))))))))];
}

export function method13(v0_1: Mut6): any {
    const v1_1: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v0_1.l4;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v99: US5 = patternInput_1[29];
    const v98: US5 = patternInput_1[28];
    const v97: US11 = patternInput_1[27];
    const v96: US5 = patternInput_1[26];
    const v95: US5 = patternInput_1[25];
    const v94: US5 = patternInput_1[24];
    const v93: US5 = patternInput_1[23];
    const v92: US5 = patternInput_1[22];
    const v91: US5 = patternInput_1[21];
    const v90: US7 = patternInput_1[20];
    const v89: US10 = patternInput_1[19];
    const v88: US5 = patternInput_1[18];
    const v87: US5 = patternInput_1[17];
    const v86: US5 = patternInput_1[16];
    const v85: US9 = patternInput_1[15];
    const v84: US7 = patternInput_1[14];
    const v83: US5 = patternInput_1[13];
    const v82: US5 = patternInput_1[12];
    const v81: US8 = patternInput_1[11];
    const v80: US7 = patternInput_1[10];
    const v79: US5 = patternInput_1[9];
    const v78: US5 = patternInput_1[8];
    const v77: US5 = patternInput_1[7];
    const v76: US5 = patternInput_1[6];
    const v75_1: US5 = patternInput_1[5];
    const v74_1: US5 = patternInput_1[4];
    const v73_1: US6 = patternInput_1[3];
    const v72_1: US5 = patternInput_1[2];
    const v71_1: US5 = patternInput_1[1];
    const v70_1: US5 = patternInput_1[0];
    const v137: US5 = patternInput_1[67];
    const v136: US4 = patternInput_1[66];
    const v135: US5 = patternInput_1[65];
    const v134: US9 = patternInput_1[64];
    const v133: US9 = patternInput_1[63];
    const v132: US5 = patternInput_1[62];
    const v131: US5 = patternInput_1[61];
    const v130: US11 = patternInput_1[60];
    const v129: US5 = patternInput_1[59];
    const v128: US5 = patternInput_1[58];
    const v127: US5 = patternInput_1[57];
    const v126: US5 = patternInput_1[56];
    const v125: US5 = patternInput_1[55];
    const v124: US5 = patternInput_1[54];
    const v123: US5 = patternInput_1[53];
    const v122: US5 = patternInput_1[52];
    const v121: US5 = patternInput_1[51];
    const v120: US5 = patternInput_1[50];
    const v119: US5 = patternInput_1[49];
    const v118: US5 = patternInput_1[48];
    const v117: US5 = patternInput_1[47];
    const v116: US5 = patternInput_1[46];
    const v115: US5 = patternInput_1[45];
    const v114: US5 = patternInput_1[44];
    const v113: US5 = patternInput_1[43];
    const v112: US12 = patternInput_1[42];
    const v111: US13 = patternInput_1[41];
    const v110: US12 = patternInput_1[40];
    const v109: US5 = patternInput_1[39];
    const v108: US5 = patternInput_1[38];
    const v107: US5 = patternInput_1[37];
    const v106: US5 = patternInput_1[36];
    const v105: US5 = patternInput_1[35];
    const v104: US5 = patternInput_1[34];
    const v103: US5 = patternInput_1[33];
    const v102: US5 = patternInput_1[32];
    const v101: US11 = patternInput_1[31];
    const v100: US5 = patternInput_1[30];
    let v145: US8;
    if (v81.tag === US8_Tag.US8_1) {
        const v142: any = children_1;
        v145 = US8_US8_1(v142(v81.fields[0]));
    }
    else {
        v145 = US8_US8_0();
    }
    const v146: int32 = nonSeeded().Next0() | 0;
    const v242: any = components_spi.state_context;
    const v245: any = useContext;
    const patternInput_2: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v245(v242);
    const v362: any = components_spi.state_context;
    const v363: any = useContext;
    const v382: () => US3 = (v363(v362))[18];
    const v480: any = components_spi.state_context;
    const v481: any = useContext;
    const patternInput_4: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v481(v480);
    const v503: (arg0: US4) => void = patternInput_4[21];
    const v502: () => US4 = patternInput_4[20];
    const v504: () => boolean = (): boolean => closure29(v382, void 0);
    const v505: () => any[] = (): any[] => closure30(v146, patternInput_2[4], v382, v502, void 0);
    method14(v504, v505, "#de884c")(["> loader ()"]);
    const v511: boolean = v0_1.l0;
    const v513: any = createSignal;
    const v514: any[] = v513(v511);
    let v515: () => boolean;
    const value_5: any = v514[0];
    v515 = (value_5);
    let v516: (arg0: boolean) => void;
    const value_6: any = v514[1];
    v516 = ((arg_1: boolean): void => {
        value_6(arg_1);
    });
    const v517: any = createSignal;
    const v518: any[] = v517(false);
    let v519: () => boolean;
    const value_8: any = v518[0];
    v519 = (value_8);
    let v520: (arg0: boolean) => void;
    const value_9: any = v518[1];
    v520 = ((arg_3: boolean): void => {
        value_9(arg_3);
    });
    const v521: () => void = (): void => {
        closure32(v0_1, v146, v503, void 0);
    };
    method16(v521);
    const v522: () => void = (): void => {
        closure33(v520, v519, void 0);
    };
    method16(v522);
    const v523: () => void = (): void => {
        closure34(v0_1, void 0);
    };
    method17(v523);
    if (v0_1.l0 === true) {
        const v526: US13 = v0_1.l2;
        if (v526.tag === US13_Tag.US13_1) {
            v526.fields[0]();
        }
    }
    const v530: any = Box;
    const patternInput_5: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v542: US8 = patternInput_5[11];
    let v605: US8;
    if (v542.tag === US8_Tag.US8_1) {
        const v602: any = children_1;
        v605 = US8_US8_1(v602(v542.fields[0]));
    }
    else {
        v605 = US8_US8_0();
    }
    const v615: any = createObj(method7(patternInput_5[0], patternInput_5[1], patternInput_5[2], patternInput_5[3], patternInput_5[4], patternInput_5[5], patternInput_5[6], patternInput_5[7], patternInput_5[8], patternInput_5[9], patternInput_5[10], US8_US8_1((v605.tag === US8_Tag.US8_1) ? v605.fields[0] : ((): any[] => closure35(v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v146, v503, v502, v516, v515, v520, v519, v0_1, void 0))), patternInput_5[12], patternInput_5[13], patternInput_5[14], patternInput_5[15], patternInput_5[16], patternInput_5[17], US5_US5_1("flex"), patternInput_5[19], patternInput_5[20], US5_US5_1("1"), patternInput_5[22], patternInput_5[23], patternInput_5[24], patternInput_5[25], patternInput_5[26], patternInput_5[27], v98, patternInput_5[29], patternInput_5[30], patternInput_5[31], patternInput_5[32], patternInput_5[33], patternInput_5[34], patternInput_5[35], patternInput_5[36], patternInput_5[37], patternInput_5[38], patternInput_5[39], patternInput_5[40], patternInput_5[41], patternInput_5[42], patternInput_5[43], patternInput_5[44], patternInput_5[45], patternInput_5[46], patternInput_5[47], patternInput_5[48], patternInput_5[49], patternInput_5[50], patternInput_5[51], patternInput_5[52], patternInput_5[53], patternInput_5[54], patternInput_5[55], patternInput_5[56], patternInput_5[57], patternInput_5[58], patternInput_5[59], patternInput_5[60], patternInput_5[61], patternInput_5[62], patternInput_5[63], patternInput_5[64], patternInput_5[65], patternInput_5[66], patternInput_5[67]));
    const v616: () => any[] = (): any[] => closure35(v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v146, v503, v502, v516, v515, v520, v519, v0_1, void 0);
    v615.children = v616;
    const v617: (arg0: any) => any = v530;
    const v619: any = createComponent;
    return v619(v617, v615);
}

export function closure28(unitVar: void, v0_1: Mut6): any {
    return method13(v0_1);
}

export function closure26(v0_1: Mut4, v1_1: () => boolean, v2: () => any[], unitVar: void): any[] {
    let v19: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v20: Mut6, v23: any, v24: (arg0: Mut6) => any, v7: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v8: Mut6, v11: any, v12: (arg0: Mut6) => any;
    const v3: US14 = v0_1.l3;
    return [(v3.tag === US14_Tag.US14_1) ? (v1_1() ? ((v19 = ((arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure27(v2, arg10$0040_1)), (v20 = (new Mut6(true, false, v0_1.l0, v0_1.l1, v19)), (v23 = createComponent, (v24 = ((v_1: Mut6): any => closure28(void 0, v_1)), v23(v24, v20)))))) : (void 0)) : ((v3.tag === US14_Tag.US14_2) ? v2 : (v1_1() ? ((v7 = ((arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure27(v2, arg10$0040)), (v8 = (new Mut6(true, false, v0_1.l0, v0_1.l1, v7)), (v11 = createComponent, (v12 = ((v: Mut6): any => closure28(void 0, v)), v11(v12, v8)))))) : (void 0)))];
}

export function closure17(v0_1: Mut4, v1_1: US5, v2: US5, v3: US5, v4: US6, v5: US5, v6: US5, v7: US5, v8: US5, v9: US5, v10: US5, v11: US7, v12: US8, v13: US5, v14: US5, v15: US7, v16: US9, v17: US5, v18: US5, v19: US5, v20: US10, v21: US7, v22: US5, v23: US5, v24: US5, v25: US5, v26: US5, v27: US5, v28: US11, v29: US5, v30: US5, v31: US5, v32: US11, v33: US5, v34: US5, v35: US5, v36: US5, v37: US5, v38: US5, v39: US5, v40: US5, v41: US12, v42: US13, v43: US12, v44: US5, v45: US5, v46: US5, v47: US5, v48: US5, v49: US5, v50: US5, v51: US5, v52: US5, v53: US5, v54: US5, v55: US5, v56: US5, v57: US5, v58: US5, v59: US5, v60: US5, v61: US11, v62: US5, v63: US5, v64: US9, v65: US9, v66: US5, v67: US4, v68: US5, v69: (arg0: boolean) => void, v70_1: () => boolean, unitVar: void): any[] {
    let v72_1: any, v75_1: any, patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v87: US8, v153: string, v161: US8, v158: any, v180_1: any, v181_1: () => any[], v182_1: (arg0: any) => any, v185_1: any, v284: () => any[], v287: any, patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v299: US8, v358: string, v366: US8, v363: any, v370: string, v391: any, v392: () => any[], v393: (arg0: any) => any, v396: any, v190: any, patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v202: US8, v266: US8, v263: any, v270: string, v277: any, v278: () => any[], v279: (arg0: any) => any, v282: any;
    return [(v61.tag === US11_Tag.US11_1) ? ((v72_1 = v61.fields[0], (v75_1 = Td, (patternInput = method3(), (v87 = patternInput[11], (v153 = (((v0_1.l3.tag === US14_Tag.US14_2) ? true : v70_1()) ? method12("0px !important", "2px !important") : "0px !important"), (v161 = ((v87.tag === US8_Tag.US8_1) ? ((v158 = children_1, US8_US8_1(v158(v87.fields[0])))) : US8_US8_0()), (v180_1 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], US5_US5_1(v153), US5_US5_1("$neutral5"), patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v161.tag === US8_Tag.US8_1) ? v161.fields[0] : ((): any[] => closure18(v0_1, v69, v70_1, v72_1, void 0))), US5_US5_1("$neutral9"), patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US5_US5_1("flex"), patternInput[19], patternInput[20], patternInput[21], US5_US5_1("column"), patternInput[23], US5_US5_1("$sm"), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US5_US5_1("3px 20px 0 8px"), patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67])), (v181_1 = ((): any[] => closure18(v0_1, v69, v70_1, v72_1, void 0)), (v180_1.children = v181_1, (v182_1 = (v75_1), (v185_1 = createComponent, v185_1(v182_1, v180_1))))))))))))) : (void 0), (v12.tag === US8_Tag.US8_1) ? ((v284 = v12.fields[0], (v287 = Td, (patternInput_2 = method3(), (v299 = patternInput_2[11], (v358 = ((v48.tag === US5_Tag.US5_1) ? v48.fields[0] : "0"), (v366 = ((v299.tag === US8_Tag.US8_1) ? ((v363 = children_1, US8_US8_1(v363(v299.fields[0])))) : US8_US8_0()), (v370 = "0", (v391 = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], US5_US5_1(v370), patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v366.tag === US8_Tag.US8_1) ? v366.fields[0] : ((): any[] => closure26(v0_1, v70_1, v284, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US5_US5_1("flex"), patternInput_2[19], patternInput_2[20], US5_US5_1("6"), US5_US5_1("column"), patternInput_2[23], US5_US5_1("$sm"), patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], US5_US5_1("$base"), US5_US5_1(v370), patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], US5_US5_1("85vh"), patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US5_US5_1(v370), patternInput_2[44], patternInput_2[45], US5_US5_1("auto"), US5_US5_1(v358), patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67])), (v392 = ((): any[] => closure26(v0_1, v70_1, v284, void 0)), (v391.children = v392, (v393 = (v287), (v396 = createComponent, v396(v393, v391)))))))))))))) : ((v190 = Td, (patternInput_1 = method3(), (v202 = patternInput_1[11], (v266 = ((v202.tag === US8_Tag.US8_1) ? ((v263 = children_1, US8_US8_1(v263(v202.fields[0])))) : US8_US8_0()), (v270 = "0", (v277 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], US5_US5_1(v270), patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v266.tag === US8_Tag.US8_1) ? v266.fields[0] : ((): any[] => closure25(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], US5_US5_1("9px"), patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], US5_US5_1(v270), patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67])), (v278 = ((): any[] => closure25(void 0, void 0)), (v277.children = v278, (v279 = (v190), (v282 = createComponent, v282(v279, v277))))))))))))];
}

export function method11(v0_1: Mut4): any {
    const v1_1: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v0_1.l2;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v99: US5 = patternInput_1[29];
    const v98: US5 = patternInput_1[28];
    const v97: US11 = patternInput_1[27];
    const v96: US5 = patternInput_1[26];
    const v95: US5 = patternInput_1[25];
    const v94: US5 = patternInput_1[24];
    const v93: US5 = patternInput_1[23];
    const v92: US5 = patternInput_1[22];
    const v91: US5 = patternInput_1[21];
    const v90: US7 = patternInput_1[20];
    const v89: US10 = patternInput_1[19];
    const v88: US5 = patternInput_1[18];
    const v87: US5 = patternInput_1[17];
    const v86: US5 = patternInput_1[16];
    const v85: US9 = patternInput_1[15];
    const v84: US7 = patternInput_1[14];
    const v83: US5 = patternInput_1[13];
    const v82: US5 = patternInput_1[12];
    const v81: US8 = patternInput_1[11];
    const v80: US7 = patternInput_1[10];
    const v79: US5 = patternInput_1[9];
    const v78: US5 = patternInput_1[8];
    const v77: US5 = patternInput_1[7];
    const v76: US5 = patternInput_1[6];
    const v75_1: US5 = patternInput_1[5];
    const v74_1: US5 = patternInput_1[4];
    const v73_1: US6 = patternInput_1[3];
    const v72_1: US5 = patternInput_1[2];
    const v71_1: US5 = patternInput_1[1];
    const v70_1: US5 = patternInput_1[0];
    const v137: US5 = patternInput_1[67];
    const v136: US4 = patternInput_1[66];
    const v135: US5 = patternInput_1[65];
    const v134: US9 = patternInput_1[64];
    const v133: US9 = patternInput_1[63];
    const v132: US5 = patternInput_1[62];
    const v131: US5 = patternInput_1[61];
    const v130: US11 = patternInput_1[60];
    const v129: US5 = patternInput_1[59];
    const v128: US5 = patternInput_1[58];
    const v127: US5 = patternInput_1[57];
    const v126: US5 = patternInput_1[56];
    const v125: US5 = patternInput_1[55];
    const v124: US5 = patternInput_1[54];
    const v123: US5 = patternInput_1[53];
    const v122: US5 = patternInput_1[52];
    const v121: US5 = patternInput_1[51];
    const v120: US5 = patternInput_1[50];
    const v119: US5 = patternInput_1[49];
    const v118: US5 = patternInput_1[48];
    const v117: US5 = patternInput_1[47];
    const v116: US5 = patternInput_1[46];
    const v115: US5 = patternInput_1[45];
    const v114: US5 = patternInput_1[44];
    const v113: US5 = patternInput_1[43];
    const v112: US12 = patternInput_1[42];
    const v111: US13 = patternInput_1[41];
    const v110: US12 = patternInput_1[40];
    const v109: US5 = patternInput_1[39];
    const v108: US5 = patternInput_1[38];
    const v107: US5 = patternInput_1[37];
    const v106: US5 = patternInput_1[36];
    const v105: US5 = patternInput_1[35];
    const v104: US5 = patternInput_1[34];
    const v103: US5 = patternInput_1[33];
    const v102: US5 = patternInput_1[32];
    const v101: US11 = patternInput_1[31];
    const v100: US5 = patternInput_1[30];
    let v145: US8;
    if (v81.tag === US8_Tag.US8_1) {
        const v142: any = children_1;
        v145 = US8_US8_1(v142(v81.fields[0]));
    }
    else {
        v145 = US8_US8_0();
    }
    const v149: boolean = (v0_1.l3.tag === US14_Tag.US14_0) !== true;
    const v152: any = createSignal;
    const v153: any[] = v152(v149);
    let v154: () => boolean;
    const value_2: any = v153[0];
    v154 = (value_2);
    let v155: (arg0: boolean) => void;
    const value_3: any = v153[1];
    v155 = ((arg_1: boolean): void => {
        value_3(arg_1);
    });
    const v158: any = Tr;
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v170: US8 = patternInput_2[11];
    const v229: string = method12("row", "column");
    let v236: US8;
    if (v170.tag === US8_Tag.US8_1) {
        const v233: any = children_1;
        v236 = US8_US8_1(v233(v170.fields[0]));
    }
    else {
        v236 = US8_US8_0();
    }
    const v251: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], US5_US5_1("$neutral5"), US5_US5_1("1px 2px"), patternInput_2[9], patternInput_2[10], US8_US8_1((v236.tag === US8_Tag.US8_1) ? v236.fields[0] : ((): any[] => closure17(v0_1, v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v155, v154, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US5_US5_1("flex"), patternInput_2[19], patternInput_2[20], US5_US5_1("1"), US5_US5_1(v229), patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], v98, patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]));
    const v252: () => any[] = (): any[] => closure17(v0_1, v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76, v77, v78, v79, v80, v145, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v155, v154, void 0);
    v251.children = v252;
    const v253: (arg0: any) => any = v158;
    const v255: any = createComponent;
    return v255(v253, v251);
}

export function closure16(unitVar: void, v0_1: Mut4): any {
    return method11(v0_1);
}

export function closure59(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure58(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v3: any = v2.pre;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    let v79: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v76: any = children_1;
        v79 = US8_US8_1(v76(v15.fields[0]));
    }
    else {
        v79 = US8_US8_0();
    }
    const v87: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v79.tag === US8_Tag.US8_1) ? v79.fields[0] : ((): any[] => closure59(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], US5_US5_1("8px"), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v88: () => any[] = (): any[] => closure59(void 0, void 0);
    v87.children = v88;
    const v89: (arg0: any) => any = v3;
    const v92: any = createComponent;
    return [v92(v89, v87)];
}

export function closure57(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure58(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        State
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure7(v0_1: (arg0: US3) => void, v1_1: () => US3, unitVar: void): any[] {
    const v4: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure8(v0_1, v1_1, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v4, US14_US14_2());
    const v9: any = createComponent;
    const v10: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v14: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure57(void 0, arg10$0040_1);
    const v16: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v14, US14_US14_2());
    const v17: any = createComponent;
    return [v9(v10, v6), v17(v10, v16)];
}

export function closure62(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure61(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = Tbody;
    const v4: US8 = v0_1.l11;
    const v7: () => any[] = (v4.tag === US8_Tag.US8_1) ? v4.fields[0] : ((): any[] => closure62(void 0, void 0));
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v19: US8 = patternInput[11];
    let v83: US8;
    if (v19.tag === US8_Tag.US8_1) {
        const v80: any = children_1;
        v83 = US8_US8_1(v80(v19.fields[0]));
    }
    else {
        v83 = US8_US8_0();
    }
    const v96: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], US5_US5_1("$blackAlpha3"), patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v83.tag === US8_Tag.US8_1) ? v83.fields[0] : v7), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US5_US5_1("flex"), patternInput[19], patternInput[20], patternInput[21], US5_US5_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], US5_US5_1("-1px"), patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    v96.children = v7;
    const v97: (arg0: any) => any = v3;
    const v100: any = createComponent;
    return [v100(v97, v96)];
}

export function method21(v0_1: Mut1): any {
    const v3: any = Table;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    const v72_1: US5 = v0_1.l46;
    const v75_1: string = (v72_1.tag === US5_Tag.US5_1) ? v72_1.fields[0] : "hidden";
    let v83: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v80: any = children_1;
        v83 = US8_US8_1(v80(v15.fields[0]));
    }
    else {
        v83 = US8_US8_0();
    }
    const v98: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v83.tag === US8_Tag.US8_1) ? v83.fields[0] : ((): any[] => closure61(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US5_US5_1("flex"), patternInput[19], patternInput[20], US5_US5_1("1"), US5_US5_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], US5_US5_1("hidden"), US5_US5_1(v75_1), patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v99: () => any[] = (): any[] => closure61(v0_1, void 0);
    v98.children = v99;
    const v100: (arg0: any) => any = v3;
    const v103: any = createComponent;
    return v103(v100, v98);
}

export function closure60(unitVar: void, v0_1: Mut1): any {
    return method21(v0_1);
}

export function closure6(v0_1: (arg0: US3) => void, v1_1: () => US3, unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v13: US8 = patternInput[11];
    let v77: US8;
    if (v13.tag === US8_Tag.US8_1) {
        const v74_1: any = children_1;
        v77 = US8_US8_1(v74_1(v13.fields[0]));
    }
    else {
        v77 = US8_US8_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v77.tag === US8_Tag.US8_1) ? v77.fields[0] : ((): any[] => closure7(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v83: () => any[] = (): any[] => closure7(v0_1, v1_1, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return [v86(v87, v82)];
}

export function closure5(v0_1: (arg0: US3) => void, v1_1: () => US3, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: () => any[] = (): any[] => closure6(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Debug
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure4(v0_1: (arg0: US3) => void, v1_1: () => US3, unitVar: void): any[] {
    const v4: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure5(v0_1, v1_1, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v4, US14_US14_0());
    const v9: any = createComponent;
    const v10: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v9(v10, v6)];
}

export function closure3(v0_1: (arg0: US3) => void, v1_1: () => US3, unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v13: US8 = patternInput[11];
    let v77: US8;
    if (v13.tag === US8_Tag.US8_1) {
        const v74_1: any = children_1;
        v77 = US8_US8_1(v74_1(v13.fields[0]));
    }
    else {
        v77 = US8_US8_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v77.tag === US8_Tag.US8_1) ? v77.fields[0] : ((): any[] => closure4(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v83: () => any[] = (): any[] => closure4(v0_1, v1_1, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return [v86(v87, v82)];
}

export function method4(): any {
    const v95: any = components_spi.state_context;
    const v98: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v98(v95);
    const v118: (arg0: US3) => void = patternInput[19];
    const v117: () => US3 = patternInput[18];
    const v123: any = Box;
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v135: US8 = patternInput_1[11];
    let v198: US8;
    if (v135.tag === US8_Tag.US8_1) {
        const v195: any = children_1;
        v198 = US8_US8_1(v195(v135.fields[0]));
    }
    else {
        v198 = US8_US8_0();
    }
    const v204: string = "0";
    const v223: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], US5_US5_1("$blackAlpha9"), patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], US5_US5_1(v204), patternInput_1[10], US8_US8_1((v198.tag === US8_Tag.US8_1) ? v198.fields[0] : ((): any[] => closure3(v118, v117, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US5_US5_1("flex"), patternInput_1[19], patternInput_1[20], patternInput_1[21], US5_US5_1("column"), patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], US5_US5_1("80vh"), US5_US5_1("50vw"), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], US5_US5_1("auto"), patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], US5_US5_1("absolute"), US5_US5_1(v204), patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], US4_US4_1(2), patternInput_1[67]));
    const v224: () => any[] = (): any[] => closure3(v118, v117, void 0);
    v223.children = v224;
    const v225: (arg0: any) => any = v123;
    const v227: any = createComponent;
    return v227(v225, v223);
}

export function closure2(unitVar: void, v0_1: Mut2): any {
    return method4();
}

export function closure66(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure71(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure74(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: US5 = v0_1.l26;
    return [<>
        {(v1_1.tag === US5_Tag.US5_1) ? v1_1.fields[0] : ""}
    </>];
}

export function closure75(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US5_US5_0(), _arg[36], US5_US5_1("-13px"), _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure76(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularLinkExternal;
    return v2;
}

export function closure73(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = Anchor;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67];
    const v142: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], US7_US7_1(true), patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    method19(v142, new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = [v142.l0, v142.l1, v142.l2, v142.l3, v142.l4, v142.l5, v142.l6, v142.l7, v142.l8, v142.l9, v142.l10, v142.l11, v142.l12, v142.l13, v142.l14, v142.l15, v142.l16, v142.l17, v142.l18, v142.l19, v142.l20, v142.l21, v142.l22, v142.l23, v142.l24, v142.l25, v142.l26, v142.l27, v142.l28, v142.l29, v142.l30, v142.l31, v142.l32, v142.l33, v142.l34, v142.l35, v142.l36, v142.l37, v142.l38, v142.l39, v142.l40, v142.l41, v142.l42, v142.l43, v142.l44, v142.l45, v142.l46, v142.l47, v142.l48, v142.l49, v142.l50, v142.l51, v142.l52, v142.l53, v142.l54, v142.l55, v142.l56, v142.l57, v142.l58, v142.l59, v142.l60, v142.l61, v142.l62, v142.l63, v142.l64, v142.l65, v142.l66, v142.l67];
    const v154: US8 = patternInput_2[11];
    let v218: US8;
    if (v154.tag === US8_Tag.US8_1) {
        const v215: any = children_1;
        v218 = US8_US8_1(v215(v154.fields[0]));
    }
    else {
        v218 = US8_US8_0();
    }
    const v224: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v218.tag === US8_Tag.US8_1) ? v218.fields[0] : ((): any[] => closure74(v0_1, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]));
    const v225: () => any[] = (): any[] => closure74(v0_1, void 0);
    v224.children = v225;
    const v226: (arg0: any) => any = v3;
    const v229: any = createComponent;
    const v234: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure75(void 0, arg10$0040_2);
    const v235: () => any = (): any => closure76(void 0, void 0);
    const v236: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_4: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure44(void 0, arg10$0040_4);
    const v237: Mut7 = new Mut7(v234, v235, v236);
    const v238: any = createComponent;
    const v239: (arg0: Mut7) => any = (v: Mut7): any => closure46(void 0, v);
    return [v229(v226, v224), <>
        &nbsp;
    </>, v238(v239, v237)];
}

export function method23(v0_1: Mut1): any {
    const v3: any = Box;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    let v79: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v76: any = children_1;
        v79 = US8_US8_1(v76(v15.fields[0]));
    }
    else {
        v79 = US8_US8_0();
    }
    const v85: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v79.tag === US8_Tag.US8_1) ? v79.fields[0] : ((): any[] => closure73(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v86: () => any[] = (): any[] => closure73(v0_1, void 0);
    v85.children = v86;
    const v87: (arg0: any) => any = v3;
    const v90: any = createComponent;
    return v90(v87, v85);
}

export function closure72(unitVar: void, v0_1: Mut1): any {
    return method23(v0_1);
}

export function closure70(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure71(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US5_US5_1("https://github.com/fc1943s/tictactoe_spiral"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v83: () => any[] = (): any[] => closure71(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure72(void 0, v);
    return [v86(v87, v82)];
}

export function closure69(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v68: () => any[] = (): any[] => closure70(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v68), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure78(v0_1: string, unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v12: US8 = patternInput[11];
    let v76: US8;
    if (v12.tag === US8_Tag.US8_1) {
        const v73_1: any = children_1;
        v76 = US8_US8_1(v73_1(v12.fields[0]));
    }
    else {
        v76 = US8_US8_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v76.tag === US8_Tag.US8_1) ? v76.fields[0] : ((): any[] => closure71(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US5_US5_1(v0_1), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v83: () => any[] = (): any[] => closure71(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure72(void 0, v);
    return [v86(v87, v82)];
}

export function closure77(v0_1: string, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v69: () => any[] = (): any[] => closure78(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v69), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure80(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure71(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US5_US5_1("https://fc1943s.github.io/tictactoe_spiral"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v83: () => any[] = (): any[] => closure71(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure72(void 0, v);
    return [v86(v87, v82)];
}

export function closure79(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v68: () => any[] = (): any[] => closure80(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v68), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure82(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure71(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US5_US5_1("https://fc1943s.github.io/tictactoe_spiral/docs"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v83: () => any[] = (): any[] => closure71(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure72(void 0, v);
    return [v86(v87, v82)];
}

export function closure81(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v68: () => any[] = (): any[] => closure82(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v68), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure68(v0_1: string, unitVar: void): any[] {
    let v4: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v6: Mut4, v9: any, v10: (arg0: Mut4) => any, v15: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v17: Mut4, v20: any, v21: (arg0: Mut4) => any;
    const v26: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure79(void 0, arg10$0040_2);
    const v28: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v26, US14_US14_2());
    const v31: any = createComponent;
    const v32: (arg0: Mut4) => any = (v_2: Mut4): any => closure16(void 0, v_2);
    const v36: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_3: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure81(void 0, arg10$0040_3);
    const v38: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v36, US14_US14_2());
    const v39: any = createComponent;
    return [("" === v0_1) ? ((v4 = ((arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure69(void 0, arg10$0040)), (v6 = (new Mut4(US13_US13_0(), US13_US13_0(), v4, US14_US14_2())), (v9 = createComponent, (v10 = ((v: Mut4): any => closure16(void 0, v)), v9(v10, v6)))))) : ((v15 = ((arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure77(`https://github.com/fc1943s/tictactoe_spiral/tree/${v0_1}`, arg10$0040_1)), (v17 = (new Mut4(US13_US13_0(), US13_US13_0(), v15, US14_US14_2())), (v20 = createComponent, (v21 = ((v_1: Mut4): any => closure16(void 0, v_1)), v20(v21, v17)))))), v31(v32, v28), v39(v32, v38)];
}

export function method22(): any {
    const v3: string = method2()[3];
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput_1[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v85: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure68(v3, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]);
    const v86: () => any[] = (): any[] => closure68(v3, void 0);
    v85.children = v86;
    const v89: any = createComponent;
    const v90: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return v89(v90, v85);
}

export function closure67(unitVar: void, v0_1: Mut1): any {
    return method22();
}

export function closure65(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure66(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure66(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure67(void 0, v);
    return [v84(v85, v80)];
}

export function closure64(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure65(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Links
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure85(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method25(): [() => string, () => void] {
    const v2: any = useColorMode;
    const v3: any = v2();
    return [v3.colorMode, v3.toggleColorMode];
}

export function closure92(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Dark
    </>];
}

export function closure93(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Light
    </>];
}

export function closure91(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Radio;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v14: US8 = patternInput[11];
    let v80: US8;
    if (v14.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v14.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v85: string = "neutral";
    const v87: string = "sm";
    const v91: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure92(void 0, void 0))), patternInput[12], US5_US5_1(v85), patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], US5_US5_1(v87), patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], US9_US9_1("dark"), patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v92: () => any[] = (): any[] => closure92(void 0, void 0);
    v91.children = v92;
    const v93: (arg0: any) => any = v2;
    const v96: any = createComponent;
    const v97: any = v96(v93, v91);
    const v98: any = Radio;
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v110: US8 = patternInput_1[11];
    let v175_1: US8;
    if (v110.tag === US8_Tag.US8_1) {
        const v172_1: any = children_1;
        v175_1 = US8_US8_1(v172_1(v110.fields[0]));
    }
    else {
        v175_1 = US8_US8_0();
    }
    const v184_1: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v175_1.tag === US8_Tag.US8_1) ? v175_1.fields[0] : ((): any[] => closure93(void 0, void 0))), patternInput_1[12], US5_US5_1(v85), patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], US5_US5_1(v87), patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], US9_US9_1("light"), patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    const v185_1: () => any[] = (): any[] => closure93(void 0, void 0);
    v184_1.children = v185_1;
    const v186_1: (arg0: any) => any = v98;
    const v187: any = createComponent;
    return [v97, v187(v186_1, v184_1)];
}

export function closure90(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Stack;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v14: US8 = patternInput[11];
    let v78: US8;
    if (v14.tag === US8_Tag.US8_1) {
        const v75_1: any = children_1;
        v78 = US8_US8_1(v75_1(v14.fields[0]));
    }
    else {
        v78 = US8_US8_0();
    }
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v78.tag === US8_Tag.US8_1) ? v78.fields[0] : ((): any[] => closure91(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US5_US5_1("row"), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], US5_US5_1("$4"), patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v89: () => any[] = (): any[] => closure91(void 0, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v2;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure94(v0_1: () => void, v1_1: any): void {
    v0_1();
}

export function closure89(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: any = RadioGroup;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    const v73_1: string = v1_1();
    let v81: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v78: any = children_1;
        v81 = US8_US8_1(v78(v16.fields[0]));
    }
    else {
        v81 = US8_US8_0();
    }
    const v87: (arg0: any) => void = (v: any): void => {
        closure94(v0_1, v);
    };
    const v90: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v81.tag === US8_Tag.US8_1) ? v81.fields[0] : ((): any[] => closure90(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], US5_US5_1(v73_1), patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], US12_US12_1(v87), patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v91: () => any[] = (): any[] => closure90(void 0, void 0);
    v90.children = v91;
    const v92: (arg0: any) => any = v4;
    const v95: any = createComponent;
    return [v95(v92, v90)];
}

export function closure88(v0_1: () => void, v1_1: () => string, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: () => any[] = (): any[] => closure89(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("5px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Theme
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure87(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure88(v0_1, v1_1, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v4, US14_US14_2());
    const v9: any = createComponent;
    const v10: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v9(v10, v6)];
}

export function method24(): any {
    const patternInput: [() => string, () => void] = method25();
    const v1_1: () => void = patternInput[1];
    const v0_1: () => string = patternInput[0];
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v13: US8 = patternInput_1[11];
    let v77: US8;
    if (v13.tag === US8_Tag.US8_1) {
        const v74_1: any = children_1;
        v77 = US8_US8_1(v74_1(v13.fields[0]));
    }
    else {
        v77 = US8_US8_0();
    }
    const v82: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v77.tag === US8_Tag.US8_1) ? v77.fields[0] : ((): any[] => closure87(v1_1, v0_1, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]);
    const v83: () => any[] = (): any[] => closure87(v1_1, v0_1, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return v86(v87, v82);
}

export function closure86(unitVar: void, v0_1: Mut1): any {
    return method24();
}

export function closure84(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure85(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure85(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure86(void 0, v);
    return [v84(v85, v80)];
}

export function closure83(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure84(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Settings
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure97(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure102(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure107(v0_1: () => string, unitVar: void): US5 {
    return US5_US5_1(v0_1());
}

export function closure108(v0_1: (arg0: string) => void, v1_1: US5): void {
    v0_1((v1_1.tag === US5_Tag.US5_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function closure110(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure111(v0_1: Mut8, v1_1: any): void {
    const v2: string = v1_1.currentTarget.value;
    v0_1.l1(US5_US5_1(v2));
}

export function method28(v0_1: Mut8): any {
    const v3: any = Input;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    const v73_1: US5 = v0_1.l0();
    const v74_1: string = void 0;
    const v76: string = (v73_1.tag === US5_Tag.US5_1) ? v73_1.fields[0] : v74_1;
    let v85: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v82: any = children_1;
        v85 = US8_US8_1(v82(v15.fields[0]));
    }
    else {
        v85 = US8_US8_0();
    }
    const v90: (arg0: any) => void = (v: any): void => {
        closure111(v0_1, v);
    };
    const v98: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v85.tag === US8_Tag.US8_1) ? v85.fields[0] : ((): any[] => closure110(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], US12_US12_1(v90), patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], US5_US5_1("xs"), patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], US5_US5_1("text"), US9_US9_1(v76), patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v99: () => any[] = (): any[] => closure110(void 0, void 0);
    v98.children = v99;
    const v100: (arg0: any) => any = v3;
    const v103: any = createComponent;
    return v103(v100, v98);
}

export function closure109(unitVar: void, v0_1: Mut8): any {
    return method28(v0_1);
}

export function closure106(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: () => US5 = (): US5 => closure107(v1_1, void 0);
    const v3: (arg0: US5) => void = (v: US5): void => {
        closure108(v0_1, v);
    };
    const v4: Mut8 = new Mut8(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut8) => any = (v_1: Mut8): any => closure109(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure105(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: () => any[] = (): any[] => closure106(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Token
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure113(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: () => US5 = (): US5 => closure107(v1_1, void 0);
    const v3: (arg0: US5) => void = (v: US5): void => {
        closure108(v0_1, v);
    };
    const v4: Mut8 = new Mut8(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut8) => any = (v_1: Mut8): any => closure109(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure112(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: () => any[] = (): any[] => closure113(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        URL
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure116(v0_1: () => int32, unitVar: void): US4 {
    return US4_US4_1(v0_1());
}

export function closure117(v0_1: (arg0: int32) => void, v1_1: US4): void {
    v0_1((v1_1.tag === US4_Tag.US4_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function closure119(v0_1: Mut9, v1_1: any): void {
    const v2: int32 = v1_1.currentTarget.value | 0;
    v0_1.l1(US4_US4_1(v2));
}

export function method29(v0_1: Mut9): any {
    const v3: any = Input;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    const v73_1: US4 = v0_1.l0();
    const v74_1: int32 = (void 0) | 0;
    const v76: int32 = ((v73_1.tag === US4_Tag.US4_1) ? v73_1.fields[0] : v74_1) | 0;
    let v85: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v82: any = children_1;
        v85 = US8_US8_1(v82(v15.fields[0]));
    }
    else {
        v85 = US8_US8_0();
    }
    const v90: (arg0: any) => void = (v: any): void => {
        closure119(v0_1, v);
    };
    const v98: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v85.tag === US8_Tag.US8_1) ? v85.fields[0] : ((): any[] => closure110(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], US12_US12_1(v90), patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], US5_US5_1("xs"), patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], US5_US5_1("text"), US9_US9_1(v76), patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v99: () => any[] = (): any[] => closure110(void 0, void 0);
    v98.children = v99;
    const v100: (arg0: any) => any = v3;
    const v103: any = createComponent;
    return v103(v100, v98);
}

export function closure118(unitVar: void, v0_1: Mut9): any {
    return method29(v0_1);
}

export function closure115(v0_1: (arg0: int32) => void, v1_1: () => int32, unitVar: void): any[] {
    const v2: () => US4 = (): US4 => closure116(v1_1, void 0);
    const v3: (arg0: US4) => void = (v: US4): void => {
        closure117(v0_1, v);
    };
    const v4: Mut9 = new Mut9(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut9) => any = (v_1: Mut9): any => closure118(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure114(v0_1: (arg0: int32) => void, v1_1: () => int32, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: () => any[] = (): any[] => closure115(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Port
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure104(v0_1: (arg0: string) => void, v1_1: () => string, v2: (arg0: string) => void, v3: () => string, v4: (arg0: int32) => void, v5: () => int32, unitVar: void): any[] {
    const v8: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure105(v0_1, v1_1, arg10$0040);
    const v10: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v8, US14_US14_2());
    const v13: any = createComponent;
    const v14: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v18: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure112(v2, v3, arg10$0040_1);
    const v20: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v18, US14_US14_2());
    const v21: any = createComponent;
    const v25: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure114(v4, v5, arg10$0040_2);
    const v27: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v25, US14_US14_2());
    const v28: any = createComponent;
    return [v13(v14, v10), v21(v14, v20), v28(v14, v27)];
}

export function method27(): any {
    const v95: any = components_spi.state_context;
    const v98: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v98(v95);
    const v104: (arg0: string) => void = patternInput[5];
    const v103: () => string = patternInput[4];
    const v215: any = components_spi.state_context;
    const v216: any = useContext;
    const patternInput_1: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v216(v215);
    const v224: (arg0: string) => void = patternInput_1[7];
    const v223: () => string = patternInput_1[6];
    const v333: any = components_spi.state_context;
    const v334: any = useContext;
    const patternInput_2: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v334(v333);
    const v338: (arg0: int32) => void = patternInput_2[3];
    const v337: () => int32 = patternInput_2[2];
    const patternInput_3: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v368: US8 = patternInput_3[11];
    let v431: US8;
    if (v368.tag === US8_Tag.US8_1) {
        const v428: any = children_1;
        v431 = US8_US8_1(v428(v368.fields[0]));
    }
    else {
        v431 = US8_US8_0();
    }
    const v436: Mut1 = new Mut1(patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3], patternInput_3[4], patternInput_3[5], patternInput_3[6], patternInput_3[7], patternInput_3[8], patternInput_3[9], patternInput_3[10], US8_US8_1((v431.tag === US8_Tag.US8_1) ? v431.fields[0] : ((): any[] => closure104(v104, v103, v224, v223, v338, v337, void 0))), patternInput_3[12], patternInput_3[13], patternInput_3[14], patternInput_3[15], patternInput_3[16], patternInput_3[17], patternInput_3[18], patternInput_3[19], patternInput_3[20], patternInput_3[21], patternInput_3[22], patternInput_3[23], patternInput_3[24], patternInput_3[25], patternInput_3[26], patternInput_3[27], patternInput_3[28], patternInput_3[29], patternInput_3[30], patternInput_3[31], patternInput_3[32], patternInput_3[33], patternInput_3[34], patternInput_3[35], patternInput_3[36], patternInput_3[37], patternInput_3[38], patternInput_3[39], patternInput_3[40], patternInput_3[41], patternInput_3[42], patternInput_3[43], patternInput_3[44], patternInput_3[45], patternInput_3[46], patternInput_3[47], patternInput_3[48], patternInput_3[49], patternInput_3[50], patternInput_3[51], patternInput_3[52], patternInput_3[53], patternInput_3[54], patternInput_3[55], patternInput_3[56], patternInput_3[57], patternInput_3[58], patternInput_3[59], patternInput_3[60], patternInput_3[61], patternInput_3[62], patternInput_3[63], patternInput_3[64], patternInput_3[65], patternInput_3[66], patternInput_3[67]);
    const v437: () => any[] = (): any[] => closure104(v104, v103, v224, v223, v338, v337, void 0);
    v436.children = v437;
    const v439: any = createComponent;
    const v440: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return v439(v440, v436);
}

export function closure103(unitVar: void, v0_1: Mut1): any {
    return method27();
}

export function closure101(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure102(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure102(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure103(void 0, v);
    return [v84(v85, v80)];
}

export function closure100(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure101(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Connection
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure122(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure131(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): US5 {
    return US5_US5_1(v1_1);
}

export function closure132(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, v6: US5): void {
    let copyOfStruct: US0, copyOfStruct_1: US0;
    const v7: [US0, string, string, string][] = v1_1();
    const v8: int32 = v7.length | 0;
    const v9: [US0, string, string, string][] = fill(new Array(v8), 0, v8, null);
    const v10: Mut3 = new Mut3(0);
    while (method5(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        const patternInput: [US0, string, string, string] = v7[v12];
        const v16: string = patternInput[3];
        const v15: string = patternInput[2];
        const v13: US0 = patternInput[0];
        const patternInput_1: [US0, string, string, string] = ((copyOfStruct = v13, (copyOfStruct.tag === US0_Tag.US0_1) ? ((copyOfStruct_1 = v2, (copyOfStruct_1.tag === US0_Tag.US0_1) && ((copyOfStruct.fields[0].tag === US1_Tag.US1_1) ? (copyOfStruct_1.fields[0].tag === US1_Tag.US1_1) : (copyOfStruct_1.fields[0].tag === US1_Tag.US1_0)))) : (v2.tag === US0_Tag.US0_0))) ? [v13, (v6.tag === US5_Tag.US5_1) ? v6.fields[0] : "", v15, v16] : [v13, patternInput[1], v15, v16];
        v9[v12] = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]];
        const v28: int32 = (v12 + 1) | 0;
        v10.l0 = (v28 | 0);
    }
    v0_1(v9);
}

export function closure130(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, unitVar: void): any[] {
    const v6: () => US5 = (): US5 => closure131(v2, v3, v4, v5, void 0);
    const v7: (arg0: US5) => void = (v: US5): void => {
        closure132(v0_1, v1_1, v2, v3, v4, v5, v);
    };
    const v8: Mut8 = new Mut8(v6, v7);
    const v11: any = createComponent;
    const v12: (arg0: Mut8) => any = (v_1: Mut8): any => closure109(void 0, v_1);
    return [v11(v12, v8)];
}

export function closure129(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v77: () => any[] = (): any[] => closure130(v0_1, v1_1, v2, v3, v4, v5, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v77), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Address
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure135(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): US5 {
    return US5_US5_1(v3);
}

export function closure136(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, v6: US5): void {
    let copyOfStruct: US0, copyOfStruct_1: US0;
    const v7: [US0, string, string, string][] = v1_1();
    const v8: int32 = v7.length | 0;
    const v9: [US0, string, string, string][] = fill(new Array(v8), 0, v8, null);
    const v10: Mut3 = new Mut3(0);
    while (method5(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        const patternInput: [US0, string, string, string] = v7[v12];
        const v15: string = patternInput[2];
        const v14: string = patternInput[1];
        const v13: US0 = patternInput[0];
        const patternInput_1: [US0, string, string, string] = ((copyOfStruct = v13, (copyOfStruct.tag === US0_Tag.US0_1) ? ((copyOfStruct_1 = v2, (copyOfStruct_1.tag === US0_Tag.US0_1) && ((copyOfStruct.fields[0].tag === US1_Tag.US1_1) ? (copyOfStruct_1.fields[0].tag === US1_Tag.US1_1) : (copyOfStruct_1.fields[0].tag === US1_Tag.US1_0)))) : (v2.tag === US0_Tag.US0_0))) ? [v13, v14, v15, (v6.tag === US5_Tag.US5_1) ? v6.fields[0] : ""] : [v13, v14, v15, patternInput[3]];
        v9[v12] = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]];
        const v28: int32 = (v12 + 1) | 0;
        v10.l0 = (v28 | 0);
    }
    v0_1(v9);
}

export function closure134(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, unitVar: void): any[] {
    const v6: () => US5 = (): US5 => closure135(v2, v3, v4, v5, void 0);
    const v7: (arg0: US5) => void = (v: US5): void => {
        closure136(v0_1, v1_1, v2, v3, v4, v5, v);
    };
    const v8: Mut8 = new Mut8(v6, v7);
    const v11: any = createComponent;
    const v12: (arg0: Mut8) => any = (v_1: Mut8): any => closure109(void 0, v_1);
    return [v11(v12, v8)];
}

export function closure133(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v77: () => any[] = (): any[] => closure134(v0_1, v1_1, v2, v3, v4, v5, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v77), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Private Key
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure128(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, unitVar: void): any[] {
    const v8: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure129(v0_1, v1_1, v2, v3, v4, v5, arg10$0040);
    const v10: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v8, US14_US14_2());
    const v13: any = createComponent;
    const v14: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v18: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure133(v0_1, v1_1, v2, v3, v4, v5, arg10$0040_1);
    const v20: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v18, US14_US14_2());
    const v21: any = createComponent;
    return [v13(v14, v10), v21(v14, v20)];
}

export function closure127(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v17: US8 = patternInput[11];
    let v81: US8;
    if (v17.tag === US8_Tag.US8_1) {
        const v78: any = children_1;
        v81 = US8_US8_1(v78(v17.fields[0]));
    }
    else {
        v81 = US8_US8_0();
    }
    const v86: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v81.tag === US8_Tag.US8_1) ? v81.fields[0] : ((): any[] => closure128(v0_1, v1_1, v2, v3, v4, v5, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v87: () => any[] = (): any[] => closure128(v0_1, v1_1, v2, v3, v4, v5, void 0);
    v86.children = v87;
    const v90: any = createComponent;
    const v91: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return [v90(v91, v86)];
}

export function closure126(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], v2: US0, v3: string, v4: string, v5: string, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v82: () => any[] = (): any[] => closure127(v0_1, v1_1, v2, v3, v4, v5, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v82), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {(v2.tag === US0_Tag.US0_1) ? ((v2.fields[0].tag === US1_Tag.US1_1) ? "x" : "o") : "admin"}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure125(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], _arg: [US0, string, string, string]): any[] {
    const v8: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure126(v0_1, v1_1, _arg[0], _arg[1], _arg[2], _arg[3], arg10$0040);
    const v10: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v8, US14_US14_2());
    const v13: any = createComponent;
    const v14: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v13(v14, v10)];
}

export function closure124(v0_1: (arg0: [US0, string, string, string][]) => void, v1_1: () => [US0, string, string, string][], unitVar: void): any[] {
    const v2: [US0, string, string, string][] = v1_1();
    const v5: any = For;
    const v6: (arg0: [US0, string, string, string]) => any[] = (arg10$0040: [US0, string, string, string]): any[] => closure125(v0_1, v1_1, arg10$0040);
    const v7: () => any[] = v6;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v19: US8 = patternInput[11];
    let v83: US8;
    if (v19.tag === US8_Tag.US8_1) {
        const v80: any = children_1;
        v83 = US8_US8_1(v80(v19.fields[0]));
    }
    else {
        v83 = US8_US8_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v83.tag === US8_Tag.US8_1) ? v83.fields[0] : v7), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], US10_US10_1(v2), patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    v89.children = v7;
    const v90: (arg0: any) => any = v5;
    const v92: any = createComponent;
    return [v92(v90, v89)];
}

export function method30(): any {
    const v95: any = components_spi.state_context;
    const v98: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v98(v95);
    const v99: () => [US0, string, string, string][] = patternInput[0];
    const v100: (arg0: [US0, string, string, string][]) => void = patternInput[1];
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v132: US8 = patternInput_1[11];
    let v195: US8;
    if (v132.tag === US8_Tag.US8_1) {
        const v192: any = children_1;
        v195 = US8_US8_1(v192(v132.fields[0]));
    }
    else {
        v195 = US8_US8_0();
    }
    const v200: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v195.tag === US8_Tag.US8_1) ? v195.fields[0] : ((): any[] => closure124(v100, v99, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]);
    const v201: () => any[] = (): any[] => closure124(v100, v99, void 0);
    v200.children = v201;
    const v203: any = createComponent;
    const v204: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return v203(v204, v200);
}

export function closure123(unitVar: void, v0_1: Mut1): any {
    return method30();
}

export function closure121(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure122(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure122(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure123(void 0, v);
    return [v84(v85, v80)];
}

export function closure120(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure121(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Accounts
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure139(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure138(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v3: any = v2.iframe;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v15: US8 = patternInput[11];
    const v74_1: any = <>
        algorand testnet bank
    </>;
    let v82: US8;
    if (v15.tag === US8_Tag.US8_1) {
        const v79: any = children_1;
        v82 = US8_US8_1(v79(v15.fields[0]));
    }
    else {
        v82 = US8_US8_0();
    }
    const v97: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], US5_US5_1("#aaa"), patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v82.tag === US8_Tag.US8_1) ? v82.fields[0] : ((): any[] => closure139(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], US5_US5_1("1"), patternInput[22], patternInput[23], patternInput[24], US5_US5_1("350px"), patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US5_US5_1("https://bank.testnet.algorand.network"), patternInput[58], patternInput[59], US11_US11_1(v74_1), patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v98: () => any[] = (): any[] => closure139(void 0, void 0);
    v97.children = v98;
    const v99: (arg0: any) => any = v3;
    const v102: any = createComponent;
    return [v102(v99, v97)];
}

export function closure137(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure138(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Testnet Bank Dispenser
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure99(unitVar: void, unitVar_1: void): any[] {
    const v2: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure100(void 0, arg10$0040);
    const v4: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v2, US14_US14_2());
    const v7: any = createComponent;
    const v8: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v12: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure120(void 0, arg10$0040_1);
    const v14: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v12, US14_US14_2());
    const v15: any = createComponent;
    const v19: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure137(void 0, arg10$0040_2);
    const v21: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v19, US14_US14_0());
    const v22: any = createComponent;
    return [v7(v8, v4), v15(v8, v14), v22(v8, v21)];
}

export function method26(): any {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure99(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure99(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return v84(v85, v80);
}

export function closure98(unitVar: void, v0_1: Mut1): any {
    return method26();
}

export function closure96(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure97(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure97(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure98(void 0, v);
    return [v84(v85, v80)];
}

export function closure95(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure96(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US5_US5_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Chain
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure142(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure146(v0_1: Mut10, v1_1: (arg0: [US2, US2][]) => void, v2: () => [US2, US2][], unitVar: void): void {
    const v3: [US2, US2][] = v2();
    const patternInput: [US2, US2] = [v0_1.l2, v0_1.l3];
    const v6: [US2, US2][] = [[patternInput[0], patternInput[1]]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US2, US2][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut3 = new Mut3(0);
    while (method5(v9, v11)) {
        const v13: int32 = v11.l0 | 0;
        let patternInput_3: [US2, US2];
        if (v13 < v7) {
            const patternInput_1: [US2, US2] = v3[v13];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v17: int32 = (v13 - v7) | 0;
            const patternInput_2: [US2, US2] = v6[v17];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v10[v13] = [patternInput_3[0], patternInput_3[1]];
        const v22: int32 = (v13 + 1) | 0;
        v11.l0 = (v22 | 0);
    }
    v1_1(v10);
}

export function method33(v0_1: int32, v1_1: Mut11): boolean {
    return v1_1.l0 < v0_1;
}

export function closure147(v0_1: Mut10, v1_1: (arg0: [US2, US2][]) => void, v2: () => [US2, US2][], unitVar: void): void {
    const v3: [US2, US2][] = v2();
    const v4: int32 = v3.length | 0;
    const v5: [US2, US2][] = fill(new Array(v4), 0, v4, null);
    const v6: Mut11 = new Mut11(0, 0);
    while (method33(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v9: int32 = v6.l1 | 0;
        const patternInput: [US2, US2] = v3[v8];
        const v11: US2 = patternInput[1];
        const v10: US2 = patternInput[0];
        const patternInput_1: [US2, US2] = [v0_1.l2, v0_1.l3];
        const v13: US2 = patternInput_1[1];
        const v12: US2 = patternInput_1[0];
        let v19: int32;
        if ((((v10.tag === US2_Tag.US2_1) ? (v12.tag === US2_Tag.US2_1) : (v12.tag === US2_Tag.US2_0)) && ((v11.tag === US2_Tag.US2_1) ? (v13.tag === US2_Tag.US2_1) : (v13.tag === US2_Tag.US2_0))) !== true) {
            v5[v9] = [v10, v11];
            v19 = (v9 + 1);
        }
        else {
            v19 = v9;
        }
        const v20: int32 = (v8 + 1) | 0;
        v6.l0 = (v20 | 0);
        v6.l1 = (v19 | 0);
    }
    const v21: int32 = v6.l1 | 0;
    const v22: [US2, US2][] = fill(new Array(v21), 0, v21, null);
    const v23: Mut3 = new Mut3(0);
    while (method5(v21, v23)) {
        const v25: int32 = v23.l0 | 0;
        const patternInput_2: [US2, US2] = v5[v25];
        v22[v25] = [patternInput_2[0], patternInput_2[1]];
        const v28: int32 = (v25 + 1) | 0;
        v23.l0 = (v28 | 0);
    }
    v1_1(v22);
}

export function closure154(unitVar: void, _arg: [US2, int32, string, string]): US5 {
    return US5_US5_1(_arg[2]);
}

export function closure156(v0_1: Mut12, v1_1: US2, v2: int32, v3: string, v4: string, v5: US5): [US2, int32, string, string] {
    return [v0_1.l0, v2, (v5.tag === US5_Tag.US5_1) ? v5.fields[0] : "", v4];
}

export function closure155(v0_1: Mut12, _arg: [US2, int32, string, string]): (arg0: US5) => [US2, int32, string, string] {
    return (v: US5): [US2, int32, string, string] => closure156(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function method36(v0_1: int32, v1_1: Mut14): boolean {
    return v1_1.l0 < v0_1;
}

export function closure158(v0_1: Mut13, v1_1: () => [US2, int32, string, string][], unitVar: void): US5 {
    const v2: [US2, int32, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut14 = new Mut14(0, US5_US5_0());
    while (method36(v3, v5)) {
        const v7: int32 = v5.l0 | 0;
        const v10: int32 = ((op_UnaryNegation_Int32(v7) + v3) - 1) | 0;
        const v11: US5 = v5.l1;
        const patternInput: [US2, int32, string, string] = v2[v10];
        const v12: US2 = patternInput[0];
        let v23: US5;
        if (v11.tag === US5_Tag.US5_1) {
            v23 = v11;
        }
        else {
            const v16: US2 = v0_1.l0;
            v23 = (((v12.tag === US2_Tag.US2_1) ? (v16.tag === US2_Tag.US2_1) : (v16.tag === US2_Tag.US2_0)) ? v0_1.l1([v12, patternInput[1], patternInput[2], patternInput[3]]) : US5_US5_0());
        }
        const v24: int32 = (v7 + 1) | 0;
        v5.l0 = (v24 | 0);
        v5.l1 = v23;
    }
    return v5.l1;
}

export function closure159(v0_1: Mut13, v1_1: (arg0: [US2, int32, string, string][]) => void, v2: () => [US2, int32, string, string][], v3: US5): void {
    const v4: [US2, int32, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2, int32, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut3 = new Mut3(0);
    while (method5(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2, int32, string, string] = v4[v9];
        const v13: string = patternInput[3];
        const v12: string = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2 = patternInput[0];
        const v14: US2 = v0_1.l0;
        let patternInput_2: [US2, int32, string, string];
        if ((v10.tag === US2_Tag.US2_1) ? (v14.tag === US2_Tag.US2_1) : (v14.tag === US2_Tag.US2_0)) {
            const patternInput_1: [US2, int32, string, string] = v0_1.l2([v10, v11, v12, v13], v3);
            patternInput_2 = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]];
        }
        else {
            patternInput_2 = [v10, v11, v12, v13];
        }
        v6[v9] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        const v26: int32 = (v9 + 1) | 0;
        v7.l0 = (v26 | 0);
    }
    v1_1(v6);
}

export function method35(v0_1: Mut13): any {
    const v96: any = components_spi.state_context;
    const v99: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v99(v96);
    const v108: () => [US2, int32, string, string][] = patternInput[8];
    const v122: () => US5 = (): US5 => closure158(v0_1, v108, void 0);
    const v123: (arg0: US5) => void = (v: US5): void => {
        closure159(v0_1, patternInput[9], v108, v);
    };
    const v124: Mut8 = new Mut8(v122, v123);
    const v126: any = createComponent;
    const v127: (arg0: Mut8) => any = (v_1: Mut8): any => closure109(void 0, v_1);
    return v126(v127, v124);
}

export function closure157(unitVar: void, v0_1: Mut13): any {
    return method35(v0_1);
}

export function closure153(v0_1: Mut12, unitVar: void): any[] {
    const v2: (arg0: [US2, int32, string, string]) => US5 = (arg10$0040: [US2, int32, string, string]): US5 => closure154(void 0, arg10$0040);
    const v3: (arg0: [US2, int32, string, string], arg1: US5) => [US2, int32, string, string] = (arg10$0040_1: [US2, int32, string, string]): (arg0: US5) => [US2, int32, string, string] => closure155(v0_1, arg10$0040_1);
    const v4: Mut13 = new Mut13(v0_1.l0, v2, uncurry(2, v3));
    const v7: any = createComponent;
    const v8: (arg0: Mut13) => any = (v: Mut13): any => closure157(void 0, v);
    return [v7(v8, v4)];
}

export function closure152(v0_1: Mut12, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v72_1: () => any[] = (): any[] => closure153(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v72_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        URL
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure162(unitVar: void, _arg: [US2, int32, string, string]): US4 {
    return US4_US4_1(_arg[1]);
}

export function closure164(v0_1: Mut12, v1_1: US2, v2: int32, v3: string, v4: string, v5: US4): [US2, int32, string, string] {
    return [v0_1.l0, (v5.tag === US4_Tag.US4_1) ? v5.fields[0] : 0, v3, v4];
}

export function closure163(v0_1: Mut12, _arg: [US2, int32, string, string]): (arg0: US4) => [US2, int32, string, string] {
    return (v: US4): [US2, int32, string, string] => closure164(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function method38(v0_1: int32, v1_1: Mut16): boolean {
    return v1_1.l0 < v0_1;
}

export function closure166(v0_1: Mut15, v1_1: () => [US2, int32, string, string][], unitVar: void): US4 {
    const v2: [US2, int32, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut16 = new Mut16(0, US4_US4_0());
    while (method38(v3, v5)) {
        const v7: int32 = v5.l0 | 0;
        const v10: int32 = ((op_UnaryNegation_Int32(v7) + v3) - 1) | 0;
        const v11: US4 = v5.l1;
        const patternInput: [US2, int32, string, string] = v2[v10];
        const v12: US2 = patternInput[0];
        let v23: US4;
        if (v11.tag === US4_Tag.US4_1) {
            v23 = v11;
        }
        else {
            const v16: US2 = v0_1.l0;
            v23 = (((v12.tag === US2_Tag.US2_1) ? (v16.tag === US2_Tag.US2_1) : (v16.tag === US2_Tag.US2_0)) ? v0_1.l1([v12, patternInput[1], patternInput[2], patternInput[3]]) : US4_US4_0());
        }
        const v24: int32 = (v7 + 1) | 0;
        v5.l0 = (v24 | 0);
        v5.l1 = v23;
    }
    return v5.l1;
}

export function closure167(v0_1: Mut15, v1_1: (arg0: [US2, int32, string, string][]) => void, v2: () => [US2, int32, string, string][], v3: US4): void {
    const v4: [US2, int32, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2, int32, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut3 = new Mut3(0);
    while (method5(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2, int32, string, string] = v4[v9];
        const v13: string = patternInput[3];
        const v12: string = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2 = patternInput[0];
        const v14: US2 = v0_1.l0;
        let patternInput_2: [US2, int32, string, string];
        if ((v10.tag === US2_Tag.US2_1) ? (v14.tag === US2_Tag.US2_1) : (v14.tag === US2_Tag.US2_0)) {
            const patternInput_1: [US2, int32, string, string] = v0_1.l2([v10, v11, v12, v13], v3);
            patternInput_2 = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]];
        }
        else {
            patternInput_2 = [v10, v11, v12, v13];
        }
        v6[v9] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        const v26: int32 = (v9 + 1) | 0;
        v7.l0 = (v26 | 0);
    }
    v1_1(v6);
}

export function method37(v0_1: Mut15): any {
    const v96: any = components_spi.state_context;
    const v99: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v99(v96);
    const v108: () => [US2, int32, string, string][] = patternInput[8];
    const v122: () => US4 = (): US4 => closure166(v0_1, v108, void 0);
    const v123: (arg0: US4) => void = (v: US4): void => {
        closure167(v0_1, patternInput[9], v108, v);
    };
    const v124: Mut9 = new Mut9(v122, v123);
    const v126: any = createComponent;
    const v127: (arg0: Mut9) => any = (v_1: Mut9): any => closure118(void 0, v_1);
    return v126(v127, v124);
}

export function closure165(unitVar: void, v0_1: Mut15): any {
    return method37(v0_1);
}

export function closure161(v0_1: Mut12, unitVar: void): any[] {
    const v2: (arg0: [US2, int32, string, string]) => US4 = (arg10$0040: [US2, int32, string, string]): US4 => closure162(void 0, arg10$0040);
    const v3: (arg0: [US2, int32, string, string], arg1: US4) => [US2, int32, string, string] = (arg10$0040_1: [US2, int32, string, string]): (arg0: US4) => [US2, int32, string, string] => closure163(v0_1, arg10$0040_1);
    const v4: Mut15 = new Mut15(v0_1.l0, v2, uncurry(2, v3));
    const v7: any = createComponent;
    const v8: (arg0: Mut15) => any = (v: Mut15): any => closure165(void 0, v);
    return [v7(v8, v4)];
}

export function closure160(v0_1: Mut12, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v72_1: () => any[] = (): any[] => closure161(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v72_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Port
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure151(v0_1: Mut12, unitVar: void): any[] {
    const v3: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure152(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v3, US14_US14_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v13: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure160(v0_1, arg10$0040_1);
    const v15: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v13, US14_US14_2());
    const v16: any = createComponent;
    return [v8(v9, v5), v16(v9, v15)];
}

export function method34(v0_1: Mut12): any {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v12: US8 = patternInput[11];
    let v76: US8;
    if (v12.tag === US8_Tag.US8_1) {
        const v73_1: any = children_1;
        v76 = US8_US8_1(v73_1(v12.fields[0]));
    }
    else {
        v76 = US8_US8_0();
    }
    const v81: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v76.tag === US8_Tag.US8_1) ? v76.fields[0] : ((): any[] => closure151(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v82: () => any[] = (): any[] => closure151(v0_1, void 0);
    v81.children = v82;
    const v85: any = createComponent;
    const v86: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return v85(v86, v81);
}

export function closure150(unitVar: void, v0_1: Mut12): any {
    return method34(v0_1);
}

export function closure149(v0_1: Mut10, unitVar: void): any[] {
    const v2: Mut12 = new Mut12(v0_1.l0);
    const v5: any = createComponent;
    const v6: (arg0: Mut12) => any = (v: Mut12): any => closure150(void 0, v);
    return [v5(v6, v2)];
}

export function closure148(v0_1: Mut10, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: () => any[] = (): any[] => closure149(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US5_US5_1(v0_1.l1), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {v0_1.l4}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method32(v0_1: Mut10): any {
    const v96: any = components_spi.state_context;
    const v99: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v99(v96);
    const v111: (arg0: [US2, US2][]) => void = patternInput[11];
    const v110: () => [US2, US2][] = patternInput[10];
    const v122: () => void = (): void => {
        closure146(v0_1, v111, v110, void 0);
    };
    const v124: () => void = (): void => {
        closure147(v0_1, v111, v110, void 0);
    };
    const v126: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure148(v0_1, arg10$0040_2);
    const v128: Mut4 = new Mut4(US13_US13_1(v122), US13_US13_1(v124), v126, US14_US14_0());
    const v130: any = createComponent;
    const v131: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v130(v131, v128);
}

export function closure145(unitVar: void, v0_1: Mut10): any {
    return method32(v0_1);
}

export function closure144(unitVar: void, unitVar_1: void): any[] {
    const v5: Mut10 = new Mut10(US2_US2_1(), "db-gun-rs-rs", US2_US2_1(), US2_US2_1(), "Rust -> Rust");
    const v8: any = createComponent;
    const v9: (arg0: Mut10) => any = (v: Mut10): any => closure145(void 0, v);
    const v16: Mut10 = new Mut10(US2_US2_0(), "db-gun-rs-js", US2_US2_1(), US2_US2_0(), "Rust -> JavaScript");
    const v17: any = createComponent;
    const v24: Mut10 = new Mut10(US2_US2_0(), "db-gun-js-js", US2_US2_0(), US2_US2_0(), "JavaScript -> JavaScript");
    const v25: any = createComponent;
    const v32: Mut10 = new Mut10(US2_US2_1(), "db-gun-js-rs", US2_US2_0(), US2_US2_1(), "JavaScript -> Rust");
    const v33: any = createComponent;
    return [v8(v9, v5), v17(v9, v16), v25(v9, v24), v33(v9, v32)];
}

export function method31(): any {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure144(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure144(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return v84(v85, v80);
}

export function closure143(unitVar: void, v0_1: Mut1): any {
    return method31();
}

export function closure141(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v11: US8 = patternInput[11];
    let v75_1: US8;
    if (v11.tag === US8_Tag.US8_1) {
        const v72_1: any = children_1;
        v75_1 = US8_US8_1(v72_1(v11.fields[0]));
    }
    else {
        v75_1 = US8_US8_0();
    }
    const v80: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v75_1.tag === US8_Tag.US8_1) ? v75_1.fields[0] : ((): any[] => closure142(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v81: () => any[] = (): any[] => closure142(void 0, void 0);
    v80.children = v81;
    const v84: any = createComponent;
    const v85: (arg0: Mut1) => any = (v: Mut1): any => closure143(void 0, v);
    return [v84(v85, v80)];
}

export function closure140(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v71_1: () => any[] = (): any[] => closure141(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US5_US5_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Database
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure171(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure175(v0_1: (arg0: [int32, int32][]) => void, v1_1: [int32, int32][]): void {
    v0_1(v1_1);
}

export function closure174(v0_1: (arg0: [int32, int32][]) => void, unitVar: void): (arg0: [int32, int32][]) => void {
    return (v: [int32, int32][]): void => {
        closure175(v0_1, v);
    };
}

export function closure173(v0_1: (arg0: [int32, int32][]) => void, unitVar: void): (arg0: void, arg1: [int32, int32][]) => void {
    return (): (arg0: [int32, int32][]) => void => closure174(v0_1, void 0);
}

export function closure176(v0_1: () => [int32, int32][], v1_1: any): int32 {
    const v2: [int32, int32][] = v0_1();
    const v3: int32 = v2.length | 0;
    const v4: Mut11 = new Mut11(0, 0);
    while (method33(v3, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v7: int32 = v4.l1 | 0;
        const patternInput: [int32, int32] = v2[v6];
        const v10: int32 = (v7 + 1) | 0;
        const v11: int32 = (v6 + 1) | 0;
        v4.l0 = (v11 | 0);
        v4.l1 = (v10 | 0);
    }
    return v4.l1 | 0;
}

export function closure177(v0_1: () => US3, unitVar: void): boolean {
    if (v0_1().tag === US3_Tag.US3_0) {
        return true;
    }
    else {
        return false;
    }
}

export function closure178(v0_1: () => US3, unitVar: void): any[] {
    return ["log_level:", v0_1()];
}

export function closure179(v0_1: string, v1_1: (arg0: any[]) => void, unitVar: void): void {
    v1_1([">> use_fetch request()", ["content_address:", v0_1]]);
}

export function closure180(v0_1: string, v1_1: (arg0: any[]) => void, unitVar: void): void {
    v1_1([">> use_fetch clear()", ["content_address:", v0_1]]);
}

export function method40(v0_1: string): [() => void, () => void] {
    const v96: any = components_spi.state_context;
    const v99: any = useContext;
    const v118: () => US3 = (v99(v96))[18];
    const v122: uint8[] = Array.from(get_UTF8().getBytes(v0_1));
    const v123: int32 = v122.length | 0;
    const v124: Mut11 = new Mut11(0, 100000);
    while (method33(v123, v124)) {
        const v126: int32 = v124.l0 | 0;
        const v131: int32 = (v124.l1 + (v122[v126] * 12)) | 0;
        const v132: int32 = (v126 + 1) | 0;
        v124.l0 = (v132 | 0);
        v124.l1 = (v131 | 0);
    }
    const v136: () => boolean = (): boolean => closure177(v118, void 0);
    const v137: () => any[] = (): any[] => closure178(v118, void 0);
    const v138: (arg0: any[]) => void = method14(v136, v137, `#${int32ToString(v124.l1)}`);
    v138(["> use_fetch ()"]);
    const v142: () => void = (): void => {
        closure179(v0_1, v138, void 0);
    };
    const v143: () => void = (): void => {
        closure180(v0_1, v138, void 0);
    };
    return [v142, v143];
}

export function closure183(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Counter
    </>];
}

export function closure184(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US5_US5_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure185(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularPlus;
    return v2;
}

export function closure186(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure187(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US5_US5_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure188(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularMinus;
    return v2;
}

export function closure189(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure182(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v86: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure183(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v87: () => any[] = (): any[] => closure183(void 0, void 0);
    v86.children = v87;
    const v88: (arg0: any) => any = v4;
    const v91: any = createComponent;
    const v92: any = v91(v88, v86);
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v104: US8 = patternInput_1[11];
    const v161: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure184(void 0, arg10$0040_2);
    const v162: () => any = (): any => closure185(void 0, void 0);
    const v163: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_4: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure44(void 0, arg10$0040_4);
    const v164: Mut7 = new Mut7(v161, v162, v163);
    const v165: any = createComponent;
    const v166: (arg0: Mut7) => any = (v: Mut7): any => closure46(void 0, v);
    const v167: any = v165(v166, v164);
    let v174_1: US8;
    if (v104.tag === US8_Tag.US8_1) {
        const v171_1: any = children_1;
        v174_1 = US8_US8_1(v171_1(v104.fields[0]));
    }
    else {
        v174_1 = US8_US8_0();
    }
    const v181_1: string = "10px";
    const v183_1: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v174_1.tag === US8_Tag.US8_1) ? v174_1.fields[0] : ((): any[] => closure186(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US11_US11_1(v167), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], US13_US13_1(v1_1), patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], US5_US5_1(v181_1), patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]);
    const v184_1: () => any[] = (): any[] => closure186(void 0, void 0);
    v183_1.children = v184_1;
    const v185_1: any = createComponent;
    const v186_1: (arg0: Mut1) => any = (v_1: Mut1): any => closure39(void 0, v_1);
    const v187: any = v185_1(v186_1, v183_1);
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v199: US8 = patternInput_2[11];
    const v256: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_7: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure187(void 0, arg10$0040_7);
    const v257: () => any = (): any => closure188(void 0, void 0);
    const v258: Mut7 = new Mut7(v256, v257, v163);
    const v259: any = createComponent;
    const v260: any = v259(v166, v258);
    let v267: US8;
    if (v199.tag === US8_Tag.US8_1) {
        const v264: any = children_1;
        v267 = US8_US8_1(v264(v199.fields[0]));
    }
    else {
        v267 = US8_US8_0();
    }
    const v275: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v267.tag === US8_Tag.US8_1) ? v267.fields[0] : ((): any[] => closure189(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US11_US11_1(v260), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], US13_US13_1(v0_1), patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], US5_US5_1(v181_1), patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]);
    const v276: () => any[] = (): any[] => closure189(void 0, void 0);
    v275.children = v276;
    const v277: any = createComponent;
    return [v92, v187, v277(v186_1, v275)];
}

export function method41(v0_1: int32, v1_1: Mut17): boolean {
    return v1_1.l0 < v0_1;
}

export function method42(v0_1_mut: UH1, v1_1_mut: UH1): UH1 {
    method42:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: UH1 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH1_UH1_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method42;
        }
        break;
    }
}

export function method44(v0_1_mut: UH1, v1_1_mut: int32): int32 {
    method44:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method44;
        }
        break;
    }
}

export function method45(v0_1_mut: [int32, int32][], v1_1_mut: UH1, v2_mut: int32): int32 {
    method45:
    while (true) {
        const v0_1: [int32, int32][] = v0_1_mut, v1_1: UH1 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH1_Tag.UH1_1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = [v1_1.fields[0], v1_1.fields[1]];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[2];
            v2_mut = (v2 + 1);
            continue method45;
        }
        break;
    }
}

export function method43(v0_1: UH1): [int32, int32][] {
    const v2: int32 = method44(v0_1, 0) | 0;
    const v3: [int32, int32][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method45(v3, v0_1, 0) | 0;
    return v3;
}

export function closure195(v0_1: () => [int32, int32], unitVar: void): any[] {
    const patternInput: [int32, int32] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure194(v0_1: () => [int32, int32], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v86: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure195(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v87: () => any[] = (): any[] => closure195(v0_1, void 0);
    v86.children = v87;
    const v88: (arg0: any) => any = v4;
    const v91: any = createComponent;
    return [v91(v88, v86)];
}

export function closure193(v0_1: () => [int32, int32], _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v74_1: () => any[] = (): any[] => closure194(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure192(unitVar: void, v0_1: () => [int32, int32]): any[] {
    const v3: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure193(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v3, US14_US14_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure191(v0_1: () => [int32, int32][], unitVar: void): any[] {
    const v1_1: [int32, int32][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut17 = new Mut17(0, UH1_UH1_1());
    while (method41(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH1 = v4.l1;
        const patternInput: [int32, int32] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH1_UH1_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int32, int32][] = method43(method42(v4.l1, UH1_UH1_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int32, int32]) => any[] = (v: () => [int32, int32]): any[] => closure192(void 0, v);
    const v23: () => any[] = v22;
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v35: US8 = patternInput_1[11];
    let v99: US8;
    if (v35.tag === US8_Tag.US8_1) {
        const v96: any = children_1;
        v99 = US8_US8_1(v96(v35.fields[0]));
    }
    else {
        v99 = US8_US8_0();
    }
    const v105: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v99.tag === US8_Tag.US8_1) ? v99.fields[0] : v23), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], US10_US10_1(v18), patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    v105.children = v23;
    const v106: (arg0: any) => any = v21;
    const v108: any = createComponent;
    return [v108(v106, v105)];
}

export function closure190(v0_1: () => [int32, int32][], unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v12: US8 = patternInput[11];
    let v76: US8;
    if (v12.tag === US8_Tag.US8_1) {
        const v73_1: any = children_1;
        v76 = US8_US8_1(v73_1(v12.fields[0]));
    }
    else {
        v76 = US8_US8_0();
    }
    const v81: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v76.tag === US8_Tag.US8_1) ? v76.fields[0] : ((): any[] => closure191(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v82: () => any[] = (): any[] => closure191(v0_1, void 0);
    v81.children = v82;
    const v85: any = createComponent;
    const v86: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return [v85(v86, v81)];
}

export function closure181(v0_1: () => [int32, int32][], v1_1: () => void, v2: () => void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: any = Stack;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v85: US8 = patternInput[11];
    const v144: string = method12("column", "row");
    const v147: string = method12("8px", "0");
    let v155: US8;
    if (v85.tag === US8_Tag.US8_1) {
        const v152: any = children_1;
        v155 = US8_US8_1(v152(v85.fields[0]));
    }
    else {
        v155 = US8_US8_0();
    }
    const v169: any = createObj(method7(US5_US5_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v155.tag === US8_Tag.US8_1) ? v155.fields[0] : ((): any[] => closure182(v1_1, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US5_US5_1(v144), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US5_US5_1(v147), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US5_US5_1("3px"), patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], US5_US5_1("7px"), patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v170: () => any[] = (): any[] => closure182(v1_1, v2, void 0);
    v169.children = v170;
    const v171_1: (arg0: any) => any = v73_1;
    const v174_1: any = createComponent;
    const v176_1: () => any[] = (): any[] => closure190(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v176_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US5_US5_1("counter"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(v174_1(v171_1, v169)), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method39(): any {
    const v95: any = components_spi.state_context;
    const v98: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v98(v95);
    const v115: () => [int32, int32][] = patternInput[16];
    const v122: [int32, int32][] = v115();
    const v123: (arg0: void, arg1: void, arg2: [int32, int32][]) => void = (): (arg0: void, arg1: [int32, int32][]) => void => closure173(patternInput[17], void 0);
    const v124: (arg0: any) => int32 = (v: any): int32 => closure176(v115, v);
    const patternInput_1: [() => void, () => void] = method40("profile/tmp/counter");
    const v129: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure181(v115, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    const v131: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v129, US14_US14_2());
    const v133: any = createComponent;
    const v134: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v133(v134, v131);
}

export function closure172(unitVar: void, v0_1: Mut1): any {
    return method39();
}

export function closure196(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure200(v0_1: (arg0: [int32, any][]) => void, v1_1: [int32, any][]): void {
    v0_1(v1_1);
}

export function closure199(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: [int32, any][]) => void {
    return (v: [int32, any][]): void => {
        closure200(v0_1, v);
    };
}

export function closure198(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: void, arg1: [int32, any][]) => void {
    return (): (arg0: [int32, any][]) => void => closure199(v0_1, void 0);
}

export function closure201(unitVar: void, v0_1: any): any {
    return "status";
}

export function closure204(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Status
    </>];
}

export function closure205(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US5_US5_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure206(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure207(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US5_US5_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure208(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure203(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v86: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure204(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v87: () => any[] = (): any[] => closure204(void 0, void 0);
    v86.children = v87;
    const v88: (arg0: any) => any = v4;
    const v91: any = createComponent;
    const v92: any = v91(v88, v86);
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v104: US8 = patternInput_1[11];
    const v161: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure205(void 0, arg10$0040_2);
    const v162: () => any = (): any => closure185(void 0, void 0);
    const v163: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_4: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure44(void 0, arg10$0040_4);
    const v164: Mut7 = new Mut7(v161, v162, v163);
    const v165: any = createComponent;
    const v166: (arg0: Mut7) => any = (v: Mut7): any => closure46(void 0, v);
    const v167: any = v165(v166, v164);
    let v174_1: US8;
    if (v104.tag === US8_Tag.US8_1) {
        const v171_1: any = children_1;
        v174_1 = US8_US8_1(v171_1(v104.fields[0]));
    }
    else {
        v174_1 = US8_US8_0();
    }
    const v181_1: string = "10px";
    const v183_1: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v174_1.tag === US8_Tag.US8_1) ? v174_1.fields[0] : ((): any[] => closure206(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US11_US11_1(v167), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], US13_US13_1(v1_1), patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], US5_US5_1(v181_1), patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]);
    const v184_1: () => any[] = (): any[] => closure206(void 0, void 0);
    v183_1.children = v184_1;
    const v185_1: any = createComponent;
    const v186_1: (arg0: Mut1) => any = (v_1: Mut1): any => closure39(void 0, v_1);
    const v187: any = v185_1(v186_1, v183_1);
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v199: US8 = patternInput_2[11];
    const v256: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_7: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure207(void 0, arg10$0040_7);
    const v257: () => any = (): any => closure188(void 0, void 0);
    const v258: Mut7 = new Mut7(v256, v257, v163);
    const v259: any = createComponent;
    const v260: any = v259(v166, v258);
    let v267: US8;
    if (v199.tag === US8_Tag.US8_1) {
        const v264: any = children_1;
        v267 = US8_US8_1(v264(v199.fields[0]));
    }
    else {
        v267 = US8_US8_0();
    }
    const v275: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v267.tag === US8_Tag.US8_1) ? v267.fields[0] : ((): any[] => closure208(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US11_US11_1(v260), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], US13_US13_1(v0_1), patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], US5_US5_1(v181_1), patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]);
    const v276: () => any[] = (): any[] => closure208(void 0, void 0);
    v275.children = v276;
    const v277: any = createComponent;
    return [v92, v187, v277(v186_1, v275)];
}

export function method47(v0_1: int32, v1_1: Mut18): boolean {
    return v1_1.l0 < v0_1;
}

export function method48(v0_1_mut: UH2, v1_1_mut: UH2): UH2 {
    method48:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: UH2 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH2_UH2_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method48;
        }
        break;
    }
}

export function method50(v0_1_mut: UH2, v1_1_mut: int32): int32 {
    method50:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method50;
        }
        break;
    }
}

export function method51(v0_1_mut: [int32, any][], v1_1_mut: UH2, v2_mut: int32): int32 {
    method51:
    while (true) {
        const v0_1: [int32, any][] = v0_1_mut, v1_1: UH2 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH2_Tag.UH2_1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = [v1_1.fields[0], v1_1.fields[1]];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[2];
            v2_mut = (v2 + 1);
            continue method51;
        }
        break;
    }
}

export function method49(v0_1: UH2): [int32, any][] {
    const v2: int32 = method50(v0_1, 0) | 0;
    const v3: [int32, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method51(v3, v0_1, 0) | 0;
    return v3;
}

export function closure214(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure213(v0_1: () => [int32, any], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v86: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure214(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v87: () => any[] = (): any[] => closure214(v0_1, void 0);
    v86.children = v87;
    const v88: (arg0: any) => any = v4;
    const v91: any = createComponent;
    return [v91(v88, v86)];
}

export function closure212(v0_1: () => [int32, any], _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v74_1: () => any[] = (): any[] => closure213(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure211(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v3: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure212(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v3, US14_US14_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure210(v0_1: () => [int32, any][], unitVar: void): any[] {
    const v1_1: [int32, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut18 = new Mut18(0, UH2_UH2_1());
    while (method47(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH2 = v4.l1;
        const patternInput: [int32, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH2_UH2_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int32, any][] = method49(method48(v4.l1, UH2_UH2_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure211(void 0, v);
    const v23: () => any[] = v22;
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v35: US8 = patternInput_1[11];
    let v99: US8;
    if (v35.tag === US8_Tag.US8_1) {
        const v96: any = children_1;
        v99 = US8_US8_1(v96(v35.fields[0]));
    }
    else {
        v99 = US8_US8_0();
    }
    const v105: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v99.tag === US8_Tag.US8_1) ? v99.fields[0] : v23), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], US10_US10_1(v18), patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    v105.children = v23;
    const v106: (arg0: any) => any = v21;
    const v108: any = createComponent;
    return [v108(v106, v105)];
}

export function closure209(v0_1: () => [int32, any][], unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v12: US8 = patternInput[11];
    let v76: US8;
    if (v12.tag === US8_Tag.US8_1) {
        const v73_1: any = children_1;
        v76 = US8_US8_1(v73_1(v12.fields[0]));
    }
    else {
        v76 = US8_US8_0();
    }
    const v81: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v76.tag === US8_Tag.US8_1) ? v76.fields[0] : ((): any[] => closure210(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v82: () => any[] = (): any[] => closure210(v0_1, void 0);
    v81.children = v82;
    const v85: any = createComponent;
    const v86: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return [v85(v86, v81)];
}

export function closure202(v0_1: () => [int32, any][], v1_1: () => void, v2: () => void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: any = Stack;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v85: US8 = patternInput[11];
    const v144: string = method12("column", "row");
    const v147: string = method12("8px", "0");
    let v155: US8;
    if (v85.tag === US8_Tag.US8_1) {
        const v152: any = children_1;
        v155 = US8_US8_1(v152(v85.fields[0]));
    }
    else {
        v155 = US8_US8_0();
    }
    const v169: any = createObj(method7(US5_US5_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v155.tag === US8_Tag.US8_1) ? v155.fields[0] : ((): any[] => closure203(v1_1, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US5_US5_1(v144), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US5_US5_1(v147), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US5_US5_1("3px"), patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], US5_US5_1("7px"), patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v170: () => any[] = (): any[] => closure203(v1_1, v2, void 0);
    v169.children = v170;
    const v171_1: (arg0: any) => any = v73_1;
    const v174_1: any = createComponent;
    const v176_1: () => any[] = (): any[] => closure209(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v176_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US5_US5_1("status"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(v174_1(v171_1, v169)), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method46(): any {
    const v95: any = components_spi.state_context;
    const v98: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v98(v95);
    const v113: () => [int32, any][] = patternInput[14];
    const v122: [int32, any][] = v113();
    const v123: (arg0: void, arg1: void, arg2: [int32, any][]) => void = (): (arg0: void, arg1: [int32, any][]) => void => closure198(patternInput[15], void 0);
    const v124: (arg0: any) => any = (v: any): any => closure201(void 0, v);
    const patternInput_1: [() => void, () => void] = method40("profile/tmp/chain_status");
    const v129: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure202(v113, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    const v131: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v129, US14_US14_2());
    const v133: any = createComponent;
    const v134: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v133(v134, v131);
}

export function closure197(unitVar: void, v0_1: Mut1): any {
    return method46();
}

export function closure215(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure219(v0_1: (arg0: [int32, any][]) => void, v1_1: [int32, any][]): void {
    v0_1(v1_1);
}

export function closure218(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: [int32, any][]) => void {
    return (v: [int32, any][]): void => {
        closure219(v0_1, v);
    };
}

export function closure217(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: void, arg1: [int32, any][]) => void {
    return (): (arg0: [int32, any][]) => void => closure218(v0_1, void 0);
}

export function closure220(unitVar: void, v0_1: any): any {
    return void 0;
}

export function closure223(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Deploy
    </>];
}

export function closure224(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US5_US5_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure225(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure226(unitVar: void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US5_US5_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure227(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure222(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v86: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure223(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v87: () => any[] = (): any[] => closure223(void 0, void 0);
    v86.children = v87;
    const v88: (arg0: any) => any = v4;
    const v91: any = createComponent;
    const v92: any = v91(v88, v86);
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v104: US8 = patternInput_1[11];
    const v161: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure224(void 0, arg10$0040_2);
    const v162: () => any = (): any => closure185(void 0, void 0);
    const v163: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_4: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure44(void 0, arg10$0040_4);
    const v164: Mut7 = new Mut7(v161, v162, v163);
    const v165: any = createComponent;
    const v166: (arg0: Mut7) => any = (v: Mut7): any => closure46(void 0, v);
    const v167: any = v165(v166, v164);
    let v174_1: US8;
    if (v104.tag === US8_Tag.US8_1) {
        const v171_1: any = children_1;
        v174_1 = US8_US8_1(v171_1(v104.fields[0]));
    }
    else {
        v174_1 = US8_US8_0();
    }
    const v181_1: string = "10px";
    const v183_1: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v174_1.tag === US8_Tag.US8_1) ? v174_1.fields[0] : ((): any[] => closure225(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US11_US11_1(v167), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], US13_US13_1(v1_1), patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], US5_US5_1(v181_1), patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]);
    const v184_1: () => any[] = (): any[] => closure225(void 0, void 0);
    v183_1.children = v184_1;
    const v185_1: any = createComponent;
    const v186_1: (arg0: Mut1) => any = (v_1: Mut1): any => closure39(void 0, v_1);
    const v187: any = v185_1(v186_1, v183_1);
    const patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v199: US8 = patternInput_2[11];
    const v256: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_7: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure226(void 0, arg10$0040_7);
    const v257: () => any = (): any => closure188(void 0, void 0);
    const v258: Mut7 = new Mut7(v256, v257, v163);
    const v259: any = createComponent;
    const v260: any = v259(v166, v258);
    let v267: US8;
    if (v199.tag === US8_Tag.US8_1) {
        const v264: any = children_1;
        v267 = US8_US8_1(v264(v199.fields[0]));
    }
    else {
        v267 = US8_US8_0();
    }
    const v275: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v267.tag === US8_Tag.US8_1) ? v267.fields[0] : ((): any[] => closure227(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US11_US11_1(v260), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], US13_US13_1(v0_1), patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], US5_US5_1(v181_1), patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]);
    const v276: () => any[] = (): any[] => closure227(void 0, void 0);
    v275.children = v276;
    const v277: any = createComponent;
    return [v92, v187, v277(v186_1, v275)];
}

export function closure233(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure232(v0_1: () => [int32, any], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v86: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure233(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v87: () => any[] = (): any[] => closure233(v0_1, void 0);
    v86.children = v87;
    const v88: (arg0: any) => any = v4;
    const v91: any = createComponent;
    return [v91(v88, v86)];
}

export function closure231(v0_1: () => [int32, any], _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v74_1: () => any[] = (): any[] => closure232(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US5_US5_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure230(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v3: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure231(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v3, US14_US14_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure229(v0_1: () => [int32, any][], unitVar: void): any[] {
    const v1_1: [int32, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut18 = new Mut18(0, UH2_UH2_1());
    while (method47(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH2 = v4.l1;
        const patternInput: [int32, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH2_UH2_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int32, any][] = method49(method48(v4.l1, UH2_UH2_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure230(void 0, v);
    const v23: () => any[] = v22;
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v35: US8 = patternInput_1[11];
    let v99: US8;
    if (v35.tag === US8_Tag.US8_1) {
        const v96: any = children_1;
        v99 = US8_US8_1(v96(v35.fields[0]));
    }
    else {
        v99 = US8_US8_0();
    }
    const v105: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v99.tag === US8_Tag.US8_1) ? v99.fields[0] : v23), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], US10_US10_1(v18), patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    v105.children = v23;
    const v106: (arg0: any) => any = v21;
    const v108: any = createComponent;
    return [v108(v106, v105)];
}

export function closure228(v0_1: () => [int32, any][], unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v12: US8 = patternInput[11];
    let v76: US8;
    if (v12.tag === US8_Tag.US8_1) {
        const v73_1: any = children_1;
        v76 = US8_US8_1(v73_1(v12.fields[0]));
    }
    else {
        v76 = US8_US8_0();
    }
    const v81: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v76.tag === US8_Tag.US8_1) ? v76.fields[0] : ((): any[] => closure229(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v82: () => any[] = (): any[] => closure229(v0_1, void 0);
    v81.children = v82;
    const v85: any = createComponent;
    const v86: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return [v85(v86, v81)];
}

export function closure221(v0_1: () => [int32, any][], v1_1: () => void, v2: () => void, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v73_1: any = Stack;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v85: US8 = patternInput[11];
    const v144: string = method12("column", "row");
    const v147: string = method12("8px", "0");
    let v155: US8;
    if (v85.tag === US8_Tag.US8_1) {
        const v152: any = children_1;
        v155 = US8_US8_1(v152(v85.fields[0]));
    }
    else {
        v155 = US8_US8_0();
    }
    const v169: any = createObj(method7(US5_US5_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v155.tag === US8_Tag.US8_1) ? v155.fields[0] : ((): any[] => closure222(v1_1, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US5_US5_1(v144), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US5_US5_1(v147), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US5_US5_1("3px"), patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], US5_US5_1("7px"), patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const v170: () => any[] = (): any[] => closure222(v1_1, v2, void 0);
    v169.children = v170;
    const v171_1: (arg0: any) => any = v73_1;
    const v174_1: any = createComponent;
    const v176_1: () => any[] = (): any[] => closure228(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v176_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US5_US5_1("deploy"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(v174_1(v171_1, v169)), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method52(): any {
    const v95: any = components_spi.state_context;
    const v98: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v98(v95);
    const v111: () => [int32, any][] = patternInput[12];
    const v122: [int32, any][] = v111();
    const v123: (arg0: void, arg1: void, arg2: [int32, any][]) => void = (): (arg0: void, arg1: [int32, any][]) => void => closure217(patternInput[13], void 0);
    const v124: (arg0: any) => any = (v: any): any => closure220(void 0, v);
    const patternInput_1: [() => void, () => void] = method40("profile/tmp/chain_deploy");
    const v129: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure221(v111, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    const v131: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v129, US14_US14_2());
    const v133: any = createComponent;
    const v134: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v133(v134, v131);
}

export function closure216(unitVar: void, v0_1: Mut1): any {
    return method52();
}

export function closure170(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v106: US8, v169: US8, v166: any, v174_1: Mut1, v175_1: () => any[], v176_1: any, v177_1: (arg0: Mut1) => any, patternInput_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5], v193: US8, v256: US8, v253: any, v261: Mut1, v262: () => any[], v263: any, v264: (arg0: Mut1) => any;
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v85: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure171(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v86: () => any[] = (): any[] => closure171(void 0, void 0);
    v85.children = v86;
    const v89: any = createComponent;
    const v90: (arg0: Mut1) => any = (v: Mut1): any => closure172(void 0, v);
    const v94: boolean = (v2 === "") !== true;
    return [v89(v90, v85), v94 ? ((patternInput_1 = method3(), (v106 = patternInput_1[11], (v169 = ((v106.tag === US8_Tag.US8_1) ? ((v166 = children_1, US8_US8_1(v166(v106.fields[0])))) : US8_US8_0()), (v174_1 = (new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v169.tag === US8_Tag.US8_1) ? v169.fields[0] : ((): any[] => closure196(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67])), (v175_1 = ((): any[] => closure196(void 0, void 0)), (v174_1.children = v175_1, (v176_1 = createComponent, (v177_1 = ((v_1: Mut1): any => closure197(void 0, v_1)), v176_1(v177_1, v174_1)))))))))) : (void 0), v94 ? ((patternInput_2 = method3(), (v193 = patternInput_2[11], (v256 = ((v193.tag === US8_Tag.US8_1) ? ((v253 = children_1, US8_US8_1(v253(v193.fields[0])))) : US8_US8_0()), (v261 = (new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US8_US8_1((v256.tag === US8_Tag.US8_1) ? v256.fields[0] : ((): any[] => closure215(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67])), (v262 = ((): any[] => closure215(void 0, void 0)), (v261.children = v262, (v263 = createComponent, (v264 = ((v_2: Mut1): any => closure216(void 0, v_2)), v263(v264, v261)))))))))) : (void 0)];
}

export function closure169(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v16: US8 = patternInput[11];
    let v80: US8;
    if (v16.tag === US8_Tag.US8_1) {
        const v77: any = children_1;
        v80 = US8_US8_1(v77(v16.fields[0]));
    }
    else {
        v80 = US8_US8_0();
    }
    const v85: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v80.tag === US8_Tag.US8_1) ? v80.fields[0] : ((): any[] => closure170(v0_1, v1_1, v2, v3, v4, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v86: () => any[] = (): any[] => closure170(v0_1, v1_1, v2, v3, v4, void 0);
    v85.children = v86;
    const v89: any = createComponent;
    const v90: (arg0: Mut1) => any = (v: Mut1): any => closure60(void 0, v);
    return [v89(v90, v85)];
}

export function closure168(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, _arg: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] {
    const v76: () => any[] = (): any[] => closure169(v0_1, v1_1, v2, v3, v4, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v76), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Profile
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure63(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v7: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure64(void 0, arg10$0040);
    const v9: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v7, US14_US14_2());
    const v12: any = createComponent;
    const v13: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v17: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure44(void 0, arg10$0040_1);
    const v19: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v17, US14_US14_2());
    const v20: any = createComponent;
    const v24: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_2: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure83(void 0, arg10$0040_2);
    const v26: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v24, US14_US14_2());
    const v27: any = createComponent;
    const v32: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v17, US14_US14_2());
    const v33: any = createComponent;
    const v37: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_3: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure95(void 0, arg10$0040_3);
    const v39: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v37, US14_US14_0());
    const v40: any = createComponent;
    const v45: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v17, US14_US14_2());
    const v46: any = createComponent;
    const v50: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_4: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure140(void 0, arg10$0040_4);
    const v52: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v50, US14_US14_0());
    const v53: any = createComponent;
    const v58: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v17, US14_US14_2());
    const v59: any = createComponent;
    const v63: (arg0: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]) => [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = (arg10$0040_5: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5]): [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] => closure168(v0_1, v1_1, v2, v3, v4, arg10$0040_5);
    const v65: Mut4 = new Mut4(US13_US13_0(), US13_US13_0(), v63, US14_US14_2());
    const v66: any = createComponent;
    return [v12(v13, v9), v20(v13, v19), v27(v13, v26), v33(v13, v32), v40(v13, v39), v46(v13, v45), v53(v13, v52), v59(v13, v58), v66(v13, v65)];
}

export function closure1(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let v14: any;
    if (v2 === "") {
        const v7: Mut2 = Mut2_$ctor();
        const v10: any = createComponent;
        const v11: (arg0: Mut2) => any = (v: Mut2): any => closure2(void 0, v);
        v14 = (v10(v11, v7));
    }
    else {
        v14 = (void 0);
    }
    const patternInput: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v26: US8 = patternInput[11];
    let v90: US8;
    if (v26.tag === US8_Tag.US8_1) {
        const v87: any = children_1;
        v90 = US8_US8_1(v87(v26.fields[0]));
    }
    else {
        v90 = US8_US8_0();
    }
    const v105: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US8_US8_1((v90.tag === US8_Tag.US8_1) ? v90.fields[0] : ((): any[] => closure63(v0_1, v1_1, v2, v3, v4, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US5_US5_1("flex"), patternInput[19], patternInput[20], US5_US5_1("1"), US5_US5_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], US5_US5_1("hidden"), US5_US5_1("auto"), patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]);
    const v106: () => any[] = (): any[] => closure63(v0_1, v1_1, v2, v3, v4, void 0);
    v105.children = v106;
    const v109: any = createComponent;
    const v110: (arg0: Mut1) => any = (v_1: Mut1): any => closure60(void 0, v_1);
    return [v14, v109(v110, v105)];
}

export function method1(): any {
    const patternInput: [string, any, string, string, boolean] = method2();
    const v4: boolean = patternInput[4];
    const v3: string = patternInput[3];
    const v2: string = patternInput[2];
    const v1_1: any = patternInput[1];
    const v0_1: string = patternInput[0];
    const v7: any = Box;
    const patternInput_1: [US5, US5, US5, US6, US5, US5, US5, US5, US5, US5, US7, US8, US5, US5, US7, US9, US5, US5, US5, US10, US7, US5, US5, US5, US5, US5, US5, US11, US5, US5, US5, US11, US5, US5, US5, US5, US5, US5, US5, US5, US12, US13, US12, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US5, US11, US5, US5, US9, US9, US5, US4, US5] = method3();
    const v19: US8 = patternInput_1[11];
    let v83: US8;
    if (v19.tag === US8_Tag.US8_1) {
        const v80: any = children_1;
        v83 = US8_US8_1(v80(v19.fields[0]));
    }
    else {
        v83 = US8_US8_0();
    }
    const v107: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], US5_US5_1("$bg"), patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1((v83.tag === US8_Tag.US8_1) ? v83.fields[0] : ((): any[] => closure1(v0_1, v1_1, v2, v3, v4, void 0))), US5_US5_1("$text1"), patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US5_US5_1("flex"), patternInput_1[19], patternInput_1[20], US5_US5_1("1"), US5_US5_1("column"), patternInput_1[23], US5_US5_1("$sm"), US5_US5_1("100vh"), patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], US5_US5_1("100vw"), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], US5_US5_1("1px"), patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    const v108: () => any[] = (): any[] => closure1(v0_1, v1_1, v2, v3, v4, void 0);
    v107.children = v108;
    const v109: (arg0: any) => any = v7;
    const v112: any = createComponent;
    return v112(v109, v107);
}

export function closure0(unitVar: void, v0_1: Mut1): any {
    return method1();
}

export function closure235(v0_1: () => US3, unitVar: void): boolean {
    if (v0_1().tag === US3_Tag.US3_0) {
        return true;
    }
    else {
        return false;
    }
}

export function closure236(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method53(): any {
    const v95: any = components_spi.state_context;
    const v98: any = useContext;
    const patternInput: [() => [US0, string, string, string][], (arg0: [US0, string, string, string][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2, int32, string, string][], (arg0: [US2, int32, string, string][]) => void, () => [US2, US2][], (arg0: [US2, US2][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US3, (arg0: US3) => void, () => US4, (arg0: US4) => void] = v98(v95);
    const v121: () => boolean = (): boolean => closure235(patternInput[18], void 0);
    const v122: () => any[] = (): any[] => closure236(void 0, void 0);
    method14(v121, v122, "#cf1100")(["> db_listener ()"]);
    return void 0;
}

export function closure234(unitVar: void, v0_1: Mut2): any {
    return method53();
}

export function method54(): string {
    return "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
}

export function method55(): string {
    return "http://localhost";
}

export function method56(): int32 {
    return 4001;
}

export function method57(): [US0, string, string, string][] {
    return [[US0_US0_0(), "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M", "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith", "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="], [US0_US0_1(US1_US1_1()), "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ", "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make", "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="], [US0_US0_1(US1_US1_0()), "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI", "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid", "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="]];
}

export function closure237(unitVar: void, unitVar_1: void): any {
    let value_31: any, value_32: any;
    const patternInput: [string, any, string, string, boolean] = method2();
    const v99: boolean = patternInput[4];
    const v95: string = patternInput[0];
    const v100: string = method54();
    const v103: any = createSignal;
    const v104: any[] = v103(v100);
    let v105: () => string;
    const value_1: any = v104[0];
    v105 = (value_1);
    let v106: (arg0: string) => void;
    const value_2: any = v104[1];
    v106 = ((arg_1: string): void => {
        value_2(arg_1);
    });
    const v107: boolean = "" === v95;
    const v110: string = v107 ? method55() : (`http://${v95}-4001.githubpreview.dev`);
    const v111: any = createSignal;
    const v112: any[] = v111(v110);
    let v113: () => string;
    const value_4: any = v112[0];
    v113 = (value_4);
    let v114: (arg0: string) => void;
    const value_5: any = v112[1];
    v114 = ((arg_3: string): void => {
        value_5(arg_3);
    });
    const v116: int32 = (v107 ? method56() : 80) | 0;
    const v117: any = createSignal;
    const v118: any[] = v117(v116);
    let v119: () => int32;
    const value_7: any = v118[0];
    v119 = (value_7);
    let v120: (arg0: int32) => void;
    const value_8: any = v118[1];
    v120 = ((arg_5: int32): void => {
        value_8(arg_5);
    });
    const v121: [US0, string, string, string][] = method57();
    const v122: any = createSignal;
    const v123: any[] = v122(v121);
    let v124: () => [US0, string, string, string][];
    const value_10: any = v123[0];
    v124 = (value_10);
    let v125: (arg0: [US0, string, string, string][]) => void;
    const value_11: any = v123[1];
    v125 = ((arg_7: [US0, string, string, string][]): void => {
        value_11(arg_7);
    });
    const v152: [US2, int32, string, string][] = [[US2_US2_1(), v107 ? ((true === v99) ? 14944 : ((false === v99) ? 4944 : 80)) : 80, v107 ? "ws://localhost" : ((true === v99) ? "ws://localhost" : (`ws://${v95}-4944.githubpreview.dev`)), "ws"], [US2_US2_0(), v107 ? ((true === v99) ? 18765 : ((false === v99) ? 8765 : 80)) : 80, v107 ? "wss://localhost" : ((true === v99) ? "wss://localhost" : (`ws://${v95}-8765.githubpreview.dev`)), "gun"]];
    const v153: any = createSignal;
    const v154: any[] = v153(v152);
    let v155: () => [US2, int32, string, string][];
    const value_13: any = v154[0];
    v155 = (value_13);
    let v156: (arg0: [US2, int32, string, string][]) => void;
    const value_14: any = v154[1];
    v156 = ((arg_9: [US2, int32, string, string][]): void => {
        value_14(arg_9);
    });
    const v157: [US2, US2][] = fill(new Array(0), 0, 0, null);
    const v158: any = createSignal;
    const v159: any[] = v158(v157);
    let v160: () => [US2, US2][];
    const value_16: any = v159[0];
    v160 = (value_16);
    let v161: (arg0: [US2, US2][]) => void;
    const value_17: any = v159[1];
    v161 = ((arg_11: [US2, US2][]): void => {
        value_17(arg_11);
    });
    const v165: US3 = ("" === patternInput[2]) ? US3_US3_0() : US3_US3_3();
    const v166: any = createSignal;
    const v167: any[] = v166(v165);
    let v168: () => US3;
    const value_19: any = v167[0];
    v168 = (value_19);
    let v169: (arg0: US3) => void;
    const value_20: any = v167[1];
    v169 = ((arg_13: US3): void => {
        value_20(arg_13);
    });
    const v170: any = createSignal;
    const v172_1: any[] = v170(US4_US4_0());
    let v173_1: () => US4;
    const value_22: any = v172_1[0];
    v173_1 = (value_22);
    let v174_1: (arg0: US4) => void;
    const value_23: any = v172_1[1];
    v174_1 = ((arg_15: US4): void => {
        value_23(arg_15);
    });
    const v175_1: [int32, int32][] = fill(new Array(0), 0, 0, null);
    const v176_1: any = createSignal;
    const v177_1: any[] = v176_1(v175_1);
    let v178_1: () => [int32, int32][];
    const value_25: any = v177_1[0];
    v178_1 = (value_25);
    let v179_1: (arg0: [int32, int32][]) => void;
    const value_26: any = v177_1[1];
    v179_1 = ((arg_17: [int32, int32][]): void => {
        value_26(arg_17);
    });
    const v180_1: [int32, any][] = fill(new Array(0), 0, 0, null);
    const v181_1: any = createSignal;
    const v182_1: any[] = v181_1(v180_1);
    let v183_1: () => [int32, any][];
    const value_28: any = v182_1[0];
    v183_1 = (value_28);
    let v184_1: (arg0: [int32, any][]) => void;
    const value_29: any = v182_1[1];
    v184_1 = ((arg_19: [int32, any][]): void => {
        value_29(arg_19);
    });
    const v185_1: [int32, any][] = fill(new Array(0), 0, 0, null);
    const v186_1: any = createSignal;
    const v187: any[] = v186_1(v185_1);
    return [v124, v125, v119, v120, v105, v106, v113, v114, v155, v156, v160, v161, (value_31 = v187[0], value_31), (value_32 = v187[1], (arg_21: [int32, any][]): void => {
        value_32(arg_21);
    }), v183_1, v184_1, v178_1, v179_1, v168, v169, v173_1, v174_1];
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const v70 = process.env;

export const v71 = "env";

export const v72 = [v71, v70];

export const v73 = [v72];

export const v74 = createObj(v73);

window.components_spi = v74;

export const v75 = nonSeeded().Next0();

export const v171 = method0();

export const v172 = "content";

export const v173 = (v: Mut1): any => closure0(void 0, v);

export const v174 = [v172, v173];

export const v175 = "db_listener";

export const v176 = (v: Mut2): any => closure234(void 0, v);

export const v177 = [v175, v176];

export const v178 = "run_id";

export const v179 = [v178, v75];

export const v180 = "new_state_context_any";

export const v181 = (): any => closure237(void 0, void 0);

export const v182 = [v180, v181];

export const v183 = "state_context";

export const v184 = [v183, v171];

export const v185 = [v174, v177, v179, v182, v184, v72];

export const v186 = createObj(v185);

window.components_spi = v186;

v1.l0 = v186;


