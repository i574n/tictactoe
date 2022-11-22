import { toString, Union, Record } from "./fable_modules/fable-library-ts/Types.js";
import { getUnionFields, int64_type, tuple_type, lambda_type, array_type, unit_type, bool_type, class_type, string_type, int32_type, union_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { uint8, op_UnaryNegation_Int32, int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { compare, fromBits, op_Division, op_Subtraction, toString as toString_1, int64 } from "./fable_modules/fable-library-ts/Long.js";
import { Index, createSignal, onCleanup, createEffect, useContext, For, createComponent, children as children_1, createContext } from "solid-js";
import { equalsWith, fill } from "./fable_modules/fable-library-ts/Array.js";
import { Input, RadioGroup, Radio, useColorMode, Anchor, Table, Tbody, hope, Tr, Td, Stack, IconButton, Icon, Button, Checkbox, Box, SimpleSelect, SimpleOption } from "@hope-ui/solid";
import { equalArrays, int32ToString, partialApply, uncurry, createObj } from "./fable_modules/fable-library-ts/Util.js";
import { utcNow, getTicks } from "./fable_modules/fable-library-ts/Date.js";
import { BiRegularMinus, BiRegularPlus, BiRegularLinkExternal, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh } from "solid-icons/bi";
import { nonSeeded } from "./fable_modules/fable-library-ts/Random.js";
import { interpolate, toConsole } from "./fable_modules/fable-library-ts/String.js";
import { get_UTF8 } from "./fable_modules/fable-library-ts/Encoding.js";
import { debounce } from "@solid-primitives/scheduled";
import { Node as Node$ } from "rusty-gun";
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
    US2_1 = 1,
    US2_2 = 2
}

export type US2_Fields = [[], [], []];

export type US2 = US2_Cons<US2_Tag.US2_0> | US2_Cons<US2_Tag.US2_1> | US2_Cons<US2_Tag.US2_2>;

export function US2_US2_0() {
    return new US2_Cons<US2_Tag.US2_0>(US2_Tag.US2_0, []);
}

export function US2_US2_1() {
    return new US2_Cons<US2_Tag.US2_1>(US2_Tag.US2_1, []);
}

export function US2_US2_2() {
    return new US2_Cons<US2_Tag.US2_2>(US2_Tag.US2_2, []);
}

export class US2_Cons<Tag extends keyof US2_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US2_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1", "US2_2"];
    }
}

export function US2$reflection(): TypeInfo {
    return union_type("Components_spi.US2", [], US2_Cons, () => [[], [], []]);
}

export const enum US3_Tag {
    US3_0 = 0,
    US3_1 = 1
}

export type US3_Fields = [[], []];

export type US3 = US3_Cons<US3_Tag.US3_0> | US3_Cons<US3_Tag.US3_1>;

export function US3_US3_0() {
    return new US3_Cons<US3_Tag.US3_0>(US3_Tag.US3_0, []);
}

export function US3_US3_1() {
    return new US3_Cons<US3_Tag.US3_1>(US3_Tag.US3_1, []);
}

export class US3_Cons<Tag extends keyof US3_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US3_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1"];
    }
}

export function US3$reflection(): TypeInfo {
    return union_type("Components_spi.US3", [], US3_Cons, () => [[], []]);
}

export const enum US4_Tag {
    US4_0 = 0,
    US4_1 = 1,
    US4_2 = 2,
    US4_3 = 3
}

export type US4_Fields = [[], [], [], []];

export type US4 = US4_Cons<US4_Tag.US4_0> | US4_Cons<US4_Tag.US4_1> | US4_Cons<US4_Tag.US4_2> | US4_Cons<US4_Tag.US4_3>;

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

export class US4_Cons<Tag extends keyof US4_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US4_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1", "US4_2", "US4_3"];
    }
}

export function US4$reflection(): TypeInfo {
    return union_type("Components_spi.US4", [], US4_Cons, () => [[], [], [], []]);
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
    return union_type("Components_spi.US5", [], US5_Cons, () => [[], [["f1_0", int32_type]]]);
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
    return union_type("Components_spi.US6", [], US6_Cons, () => [[], [["f1_0", string_type]]]);
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
    return union_type("Components_spi.US7", [], US7_Cons, () => [[], [["f1_0", class_type("Fable.Core.JS.Function")]]]);
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
    return union_type("Components_spi.US8", [], US8_Cons, () => [[], [["f1_0", bool_type]]]);
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
    return union_type("Components_spi.US9", [], US9_Cons, () => [[], [["f1_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]]]);
}

export const enum US10_Tag {
    US10_0 = 0,
    US10_1 = 1
}

export type US10_Fields = [[], [any]];

export type US10 = US10_Cons<US10_Tag.US10_0> | US10_Cons<US10_Tag.US10_1>;

export function US10_US10_0() {
    return new US10_Cons<US10_Tag.US10_0>(US10_Tag.US10_0, []);
}

export function US10_US10_1(f1_0: any) {
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
    return union_type("Components_spi.US10", [], US10_Cons, () => [[], [["f1_0", obj_type]]]);
}

export const enum US11_Tag {
    US11_0 = 0,
    US11_1 = 1
}

export type US11_Fields = [[], [any[]]];

export type US11 = US11_Cons<US11_Tag.US11_0> | US11_Cons<US11_Tag.US11_1>;

export function US11_US11_0() {
    return new US11_Cons<US11_Tag.US11_0>(US11_Tag.US11_0, []);
}

export function US11_US11_1(f1_0: any[]) {
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
    return union_type("Components_spi.US11", [], US11_Cons, () => [[], [["f1_0", array_type(obj_type)]]]);
}

export const enum US12_Tag {
    US12_0 = 0,
    US12_1 = 1
}

export type US12_Fields = [[], [any]];

export type US12 = US12_Cons<US12_Tag.US12_0> | US12_Cons<US12_Tag.US12_1>;

export function US12_US12_0() {
    return new US12_Cons<US12_Tag.US12_0>(US12_Tag.US12_0, []);
}

export function US12_US12_1(f1_0: any) {
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
    return union_type("Components_spi.US12", [], US12_Cons, () => [[], [["f1_0", class_type("Fable.Core.JSX.Element")]]]);
}

export const enum US13_Tag {
    US13_0 = 0,
    US13_1 = 1
}

export type US13_Fields = [[], [(arg0: any) => void]];

export type US13 = US13_Cons<US13_Tag.US13_0> | US13_Cons<US13_Tag.US13_1>;

export function US13_US13_0() {
    return new US13_Cons<US13_Tag.US13_0>(US13_Tag.US13_0, []);
}

export function US13_US13_1(f1_0: (arg0: any) => void) {
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
    return union_type("Components_spi.US13", [], US13_Cons, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
}

export const enum US14_Tag {
    US14_0 = 0,
    US14_1 = 1
}

export type US14_Fields = [[], [() => void]];

export type US14 = US14_Cons<US14_Tag.US14_0> | US14_Cons<US14_Tag.US14_1>;

export function US14_US14_0() {
    return new US14_Cons<US14_Tag.US14_0>(US14_Tag.US14_0, []);
}

export function US14_US14_1(f1_0: () => void) {
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
    return union_type("Components_spi.US14", [], US14_Cons, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
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
    l15: US10;
    l16: US6;
    l17: US6;
    l18: US6;
    l19: US11;
    l20: US8;
    l21: US6;
    l22: US6;
    l23: US6;
    l24: US6;
    l25: US6;
    l26: US6;
    l27: US12;
    l28: US6;
    l29: US6;
    l30: US6;
    l31: US12;
    l32: US6;
    l33: US6;
    l34: US6;
    l35: US6;
    l36: US6;
    l37: US6;
    l38: US6;
    l39: US6;
    l40: US6;
    l41: US6;
    l42: US13;
    l43: US14;
    l44: US13;
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
    l60: US6;
    l61: US6;
    l62: US12;
    l63: US6;
    l64: US6;
    l65: US10;
    l66: US10;
    l67: US6;
    l68: US5;
    l69: US6;
    constructor(l0: US6, l1: US6, l2: US6, l3: US7, l4: US6, l5: US6, l6: US6, l7: US6, l8: US6, l9: US6, l10: US8, l11: US9, l12: US6, l13: US6, l14: US8, l15: US10, l16: US6, l17: US6, l18: US6, l19: US11, l20: US8, l21: US6, l22: US6, l23: US6, l24: US6, l25: US6, l26: US6, l27: US12, l28: US6, l29: US6, l30: US6, l31: US12, l32: US6, l33: US6, l34: US6, l35: US6, l36: US6, l37: US6, l38: US6, l39: US6, l40: US6, l41: US6, l42: US13, l43: US14, l44: US13, l45: US6, l46: US6, l47: US6, l48: US6, l49: US6, l50: US6, l51: US6, l52: US6, l53: US6, l54: US6, l55: US6, l56: US6, l57: US6, l58: US6, l59: US6, l60: US6, l61: US6, l62: US12, l63: US6, l64: US6, l65: US10, l66: US10, l67: US6, l68: US5, l69: US6) {
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
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", US6$reflection()], ["l1", US6$reflection()], ["l2", US6$reflection()], ["l3", US7$reflection()], ["l4", US6$reflection()], ["l5", US6$reflection()], ["l6", US6$reflection()], ["l7", US6$reflection()], ["l8", US6$reflection()], ["l9", US6$reflection()], ["l10", US8$reflection()], ["l11", US9$reflection()], ["l12", US6$reflection()], ["l13", US6$reflection()], ["l14", US8$reflection()], ["l15", US10$reflection()], ["l16", US6$reflection()], ["l17", US6$reflection()], ["l18", US6$reflection()], ["l19", US11$reflection()], ["l20", US8$reflection()], ["l21", US6$reflection()], ["l22", US6$reflection()], ["l23", US6$reflection()], ["l24", US6$reflection()], ["l25", US6$reflection()], ["l26", US6$reflection()], ["l27", US12$reflection()], ["l28", US6$reflection()], ["l29", US6$reflection()], ["l30", US6$reflection()], ["l31", US12$reflection()], ["l32", US6$reflection()], ["l33", US6$reflection()], ["l34", US6$reflection()], ["l35", US6$reflection()], ["l36", US6$reflection()], ["l37", US6$reflection()], ["l38", US6$reflection()], ["l39", US6$reflection()], ["l40", US6$reflection()], ["l41", US6$reflection()], ["l42", US13$reflection()], ["l43", US14$reflection()], ["l44", US13$reflection()], ["l45", US6$reflection()], ["l46", US6$reflection()], ["l47", US6$reflection()], ["l48", US6$reflection()], ["l49", US6$reflection()], ["l50", US6$reflection()], ["l51", US6$reflection()], ["l52", US6$reflection()], ["l53", US6$reflection()], ["l54", US6$reflection()], ["l55", US6$reflection()], ["l56", US6$reflection()], ["l57", US6$reflection()], ["l58", US6$reflection()], ["l59", US6$reflection()], ["l60", US6$reflection()], ["l61", US6$reflection()], ["l62", US12$reflection()], ["l63", US6$reflection()], ["l64", US6$reflection()], ["l65", US10$reflection()], ["l66", US10$reflection()], ["l67", US6$reflection()], ["l68", US5$reflection()], ["l69", US6$reflection()]]);
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
    return union_type("Components_spi.US15", [], US15_Cons, () => [[], [], []]);
}

export class Mut4 extends Record {
    l0: US14;
    l1: US14;
    l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6];
    l3: US15;
    constructor(l0: US14, l1: US14, l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], l3: US15) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
    }
}

export function Mut4$reflection(): TypeInfo {
    return record_type("Components_spi.Mut4", [], Mut4, () => [["l0", US14$reflection()], ["l1", US14$reflection()], ["l2", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))], ["l3", US15$reflection()]]);
}

export class Mut5 extends Record {
    l0: () => boolean;
    l1: (arg0: boolean) => void;
    l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6];
    constructor(l0: () => boolean, l1: (arg0: boolean) => void, l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut5$reflection(): TypeInfo {
    return record_type("Components_spi.Mut5", [], Mut5, () => [["l0", lambda_type(unit_type, bool_type)], ["l1", lambda_type(bool_type, unit_type)], ["l2", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))]]);
}

export class Mut6 extends Record {
    l0: boolean;
    l1: boolean;
    l2: US14;
    l3: US14;
    l4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6];
    constructor(l0: boolean, l1: boolean, l2: US14, l3: US14, l4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
    }
}

export function Mut6$reflection(): TypeInfo {
    return record_type("Components_spi.Mut6", [], Mut6, () => [["l0", bool_type], ["l1", bool_type], ["l2", US14$reflection()], ["l3", US14$reflection()], ["l4", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))]]);
}

export class Mut7 extends Record {
    l0: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6];
    l1: () => any;
    l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6];
    constructor(l0: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], l1: () => any, l2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut7$reflection(): TypeInfo {
    return record_type("Components_spi.Mut7", [], Mut7, () => [["l0", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))], ["l1", lambda_type(unit_type, class_type("Fable.Core.JS.Function"))], ["l2", lambda_type(tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()), tuple_type(US6$reflection(), US6$reflection(), US6$reflection(), US7$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US9$reflection(), US6$reflection(), US6$reflection(), US8$reflection(), US10$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US11$reflection(), US8$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US13$reflection(), US14$reflection(), US13$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US6$reflection(), US12$reflection(), US6$reflection(), US6$reflection(), US10$reflection(), US10$reflection(), US6$reflection(), US5$reflection(), US6$reflection()))]]);
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
    return record_type("Components_spi.Mut8", [], Mut8, () => [["l0", lambda_type(string_type, obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, string_type), lambda_type(string_type, unit_type)))], ["l2", string_type]]);
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
    return record_type("Components_spi.Mut9", [], Mut9, () => [["l0", lambda_type(int32_type, obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, int32_type), lambda_type(int32_type, unit_type)))], ["l2", string_type]]);
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
    return record_type("Components_spi.Mut10", [], Mut10, () => [["l0", lambda_type(array_type(tuple_type(lambda_type(unit_type, US0$reflection()), lambda_type(US0$reflection(), unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type))), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(lambda_type(unit_type, US0$reflection()), lambda_type(US0$reflection(), unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type)))), lambda_type(array_type(tuple_type(lambda_type(unit_type, US0$reflection()), lambda_type(US0$reflection(), unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type), lambda_type(unit_type, string_type), lambda_type(string_type, unit_type))), unit_type)))], ["l2", string_type]]);
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
    return record_type("Components_spi.Mut11", [], Mut11, () => [["l0", lambda_type(array_type(tuple_type(US2$reflection(), obj_type, string_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(US2$reflection(), obj_type, string_type))), lambda_type(array_type(tuple_type(US2$reflection(), obj_type, string_type)), unit_type)))], ["l2", string_type]]);
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
    return record_type("Components_spi.Mut12", [], Mut12, () => [["l0", lambda_type(array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type))), lambda_type(array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)), unit_type)))], ["l2", string_type]]);
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
    return record_type("Components_spi.Mut13", [], Mut13, () => [["l0", lambda_type(US4$reflection(), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, US4$reflection()), lambda_type(US4$reflection(), unit_type)))], ["l2", string_type]]);
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
    return record_type("Components_spi.Mut14", [], Mut14, () => [["l0", lambda_type(US5$reflection(), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, US5$reflection()), lambda_type(US5$reflection(), unit_type)))], ["l2", string_type]]);
}

export class Mut15 extends Record {
    l0: (arg0: [int64, int32][]) => any;
    l1: () => [() => [int64, int32][], (arg0: [int64, int32][]) => void];
    l2: string;
    constructor(l0: (arg0: [int64, int32][]) => any, l1: () => [() => [int64, int32][], (arg0: [int64, int32][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut15$reflection(): TypeInfo {
    return record_type("Components_spi.Mut15", [], Mut15, () => [["l0", lambda_type(array_type(tuple_type(int64_type, int32_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(int64_type, int32_type))), lambda_type(array_type(tuple_type(int64_type, int32_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut16 extends Record {
    l0: (arg0: [int64, any][]) => any;
    l1: () => [() => [int64, any][], (arg0: [int64, any][]) => void];
    l2: string;
    constructor(l0: (arg0: [int64, any][]) => any, l1: () => [() => [int64, any][], (arg0: [int64, any][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut16$reflection(): TypeInfo {
    return record_type("Components_spi.Mut16", [], Mut16, () => [["l0", lambda_type(array_type(tuple_type(int64_type, obj_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(int64_type, obj_type))), lambda_type(array_type(tuple_type(int64_type, obj_type)), unit_type)))], ["l2", string_type]]);
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
    return record_type("Components_spi.Mut17", [], Mut17, () => [["l0", lambda_type(unit_type, US6$reflection())], ["l1", lambda_type(US6$reflection(), unit_type)]]);
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
    return record_type("Components_spi.Mut18", [], Mut18, () => [["l0", lambda_type(unit_type, US5$reflection())], ["l1", lambda_type(US5$reflection(), unit_type)]]);
}

export class Mut19 extends Record {
    l0: US3;
    constructor(l0: US3) {
        super();
        this.l0 = l0;
    }
}

export function Mut19$reflection(): TypeInfo {
    return record_type("Components_spi.Mut19", [], Mut19, () => [["l0", US3$reflection()]]);
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
    return record_type("Components_spi.Mut20", [], Mut20, () => [["l0", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), US6$reflection())], ["l1", US3$reflection()], ["l2", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), lambda_type(US6$reflection(), tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)))]]);
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
    return record_type("Components_spi.Mut21", [], Mut21, () => [["l0", int32_type], ["l1", US6$reflection()]]);
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
    return record_type("Components_spi.Mut22", [], Mut22, () => [["l0", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), US5$reflection())], ["l1", US3$reflection()], ["l2", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), lambda_type(US5$reflection(), tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)))]]);
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
    return record_type("Components_spi.Mut23", [], Mut23, () => [["l0", int32_type], ["l1", US5$reflection()]]);
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
    return record_type("Components_spi.Mut24", [], Mut24, () => [["l0", US2$reflection()], ["l1", US3$reflection()]]);
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
    return record_type("Components_spi.Mut25", [], Mut25, () => [["l0", int32_type], ["l1", int32_type]]);
}

export const enum US16_Tag {
    US16_0 = 0,
    US16_1 = 1
}

export type US16_Fields = [[], [US2, int64, int32]];

export type US16 = US16_Cons<US16_Tag.US16_0> | US16_Cons<US16_Tag.US16_1>;

export function US16_US16_0() {
    return new US16_Cons<US16_Tag.US16_0>(US16_Tag.US16_0, []);
}

export function US16_US16_1(f1_0: US2, f1_1: int64, f1_2: int32) {
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
    return union_type("Components_spi.US16", [], US16_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", int64_type], ["f1_2", int32_type]]]);
}

export const enum US17_Tag {
    US17_0 = 0,
    US17_1 = 1
}

export type US17_Fields = [[], [US2, int64, string]];

export type US17 = US17_Cons<US17_Tag.US17_0> | US17_Cons<US17_Tag.US17_1>;

export function US17_US17_0() {
    return new US17_Cons<US17_Tag.US17_0>(US17_Tag.US17_0, []);
}

export function US17_US17_1(f1_0: US2, f1_1: int64, f1_2: string) {
    return new US17_Cons<US17_Tag.US17_1>(US17_Tag.US17_1, [f1_0, f1_1, f1_2]);
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
    return union_type("Components_spi.US17", [], US17_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", int64_type], ["f1_2", string_type]]]);
}

export class Mut26 extends Record {
    l0: int32;
    l1: US17;
    constructor(l0: int32, l1: US17) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut26$reflection(): TypeInfo {
    return record_type("Components_spi.Mut26", [], Mut26, () => [["l0", int32_type], ["l1", US17$reflection()]]);
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
    return record_type("Components_spi.Mut27", [], Mut27, () => [["l0", int32_type], ["l1", obj_type]]);
}

export const enum UH1_Tag {
    UH1_0 = 0,
    UH1_1 = 1
}

export type UH1_Fields = [[int64, int32, UH1], []];

export type UH1 = UH1_Cons<UH1_Tag.UH1_0> | UH1_Cons<UH1_Tag.UH1_1>;

export function UH1_UH1_0(Item1: int64, Item2: int32, Item3: UH1) {
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
    return union_type("Components_spi.UH1", [], UH1_Cons, () => [[["Item1", int64_type], ["Item2", int32_type], ["Item3", UH1$reflection()]], []]);
}

export class Mut28 extends Record {
    l0: int32;
    l1: UH1;
    constructor(l0: int32, l1: UH1) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut28$reflection(): TypeInfo {
    return record_type("Components_spi.Mut28", [], Mut28, () => [["l0", int32_type], ["l1", UH1$reflection()]]);
}

export const enum US18_Tag {
    US18_0 = 0,
    US18_1 = 1
}

export type US18_Fields = [[], [US2, int64, [int64, any][]]];

export type US18 = US18_Cons<US18_Tag.US18_0> | US18_Cons<US18_Tag.US18_1>;

export function US18_US18_0() {
    return new US18_Cons<US18_Tag.US18_0>(US18_Tag.US18_0, []);
}

export function US18_US18_1(f1_0: US2, f1_1: int64, f1_2: [int64, any][]) {
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
    return union_type("Components_spi.US18", [], US18_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", int64_type], ["f1_2", array_type(tuple_type(int64_type, obj_type))]]]);
}

export const enum UH2_Tag {
    UH2_0 = 0,
    UH2_1 = 1
}

export type UH2_Fields = [[int64, any, UH2], []];

export type UH2 = UH2_Cons<UH2_Tag.UH2_0> | UH2_Cons<UH2_Tag.UH2_1>;

export function UH2_UH2_0(Item1: int64, Item2: any, Item3: UH2) {
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
    return union_type("Components_spi.UH2", [], UH2_Cons, () => [[["Item1", int64_type], ["Item2", obj_type], ["Item3", UH2$reflection()]], []]);
}

export class Mut29 extends Record {
    l0: int32;
    l1: UH2;
    constructor(l0: int32, l1: UH2) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut29$reflection(): TypeInfo {
    return record_type("Components_spi.Mut29", [], Mut29, () => [["l0", int32_type], ["l1", UH2$reflection()]]);
}

export const enum US19_Tag {
    US19_0 = 0,
    US19_1 = 1
}

export type US19_Fields = [[], [US2, any, string]];

export type US19 = US19_Cons<US19_Tag.US19_0> | US19_Cons<US19_Tag.US19_1>;

export function US19_US19_0() {
    return new US19_Cons<US19_Tag.US19_0>(US19_Tag.US19_0, []);
}

export function US19_US19_1(f1_0: US2, f1_1: any, f1_2: string) {
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
    return union_type("Components_spi.US19", [], US19_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", obj_type], ["f1_2", string_type]]]);
}

export class Mut30 extends Record {
    l0: int32;
    l1: US19;
    constructor(l0: int32, l1: US19) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut30$reflection(): TypeInfo {
    return record_type("Components_spi.Mut30", [], Mut30, () => [["l0", int32_type], ["l1", US19$reflection()]]);
}

export const enum US20_Tag {
    US20_0 = 0,
    US20_1 = 1
}

export type US20_Fields = [[], [US2[], int32, US3, string, string]];

export type US20 = US20_Cons<US20_Tag.US20_0> | US20_Cons<US20_Tag.US20_1>;

export function US20_US20_0() {
    return new US20_Cons<US20_Tag.US20_0>(US20_Tag.US20_0, []);
}

export function US20_US20_1(f1_0: US2[], f1_1: int32, f1_2: US3, f1_3: string, f1_4: string) {
    return new US20_Cons<US20_Tag.US20_1>(US20_Tag.US20_1, [f1_0, f1_1, f1_2, f1_3, f1_4]);
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
    return union_type("Components_spi.US20", [], US20_Cons, () => [[], [["f1_0", array_type(US2$reflection())], ["f1_1", int32_type], ["f1_2", US3$reflection()], ["f1_3", string_type], ["f1_4", string_type]]]);
}

export class Mut31 extends Record {
    l0: int32;
    l1: US20;
    constructor(l0: int32, l1: US20) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut31$reflection(): TypeInfo {
    return record_type("Components_spi.Mut31", [], Mut31, () => [["l0", int32_type], ["l1", US20$reflection()]]);
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
    return record_type("Components_spi.Mut32", [], Mut32, () => [["l0", int32_type], ["l1", array_type(tuple_type(US2$reflection(), obj_type, string_type))]]);
}

export function method0(): any {
    const v2: any = createContext;
    const v3: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = (): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] => (void 0);
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

export function method3(): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [US6_US6_0(), US6_US6_0(), US6_US6_0(), US7_US7_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US8_US8_0(), US9_US9_0(), US6_US6_0(), US6_US6_0(), US8_US8_0(), US10_US10_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US11_US11_0(), US8_US8_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US12_US12_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US12_US12_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US13_US13_0(), US14_US14_0(), US13_US13_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US6_US6_0(), US12_US12_0(), US6_US6_0(), US6_US6_0(), US10_US10_0(), US10_US10_0(), US6_US6_0(), US5_US5_0(), US6_US6_0()];
}

export function method5(v0_1: int32, v1_1: Mut3): boolean {
    return v1_1.l0 < v0_1;
}

export function closure10(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure11(v0_1: (arg0: US4) => void, v1_1: any): void {
    let v9: boolean;
    const v2: string = toString(v1_1);
    v0_1(("Debug" === v2) ? US4_US4_0() : (("Info" === v2) ? US4_US4_2() : (("Warn" === v2) ? US4_US4_3() : ((v9 = ("Error" === v2), US4_US4_1())))));
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

export function method7(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US10, v16: US6, v17: US6, v18: US6, v19: US11, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US12, v28: US6, v29: US6, v30: US6, v31: US12, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US13, v43: US14, v44: US13, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US6, v62: US12, v63: US6, v64: US6, v65: US10, v66: US10, v67: US6, v68: US5, v69: US6): [string, any][] {
    const v73_1: any = (v0_1.tag === US6_Tag.US6_1) ? v0_1.fields[0] : (void 0);
    const v80: UH0 = (!v73_1) ? UH0_UH0_1() : UH0_UH0_0(["alignItems", v73_1], UH0_UH0_1());
    const v84: any = (v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : (void 0);
    const v89: UH0 = (!v84) ? v80 : UH0_UH0_0(["alignSelf", v84], v80);
    const v93: any = (v2.tag === US6_Tag.US6_1) ? v2.fields[0] : (void 0);
    const v98: UH0 = (!v93) ? v89 : UH0_UH0_0(["aria-label", v93], v89);
    const v102: any = (v3.tag === US7_Tag.US7_1) ? v3.fields[0] : (void 0);
    const v107: UH0 = (!v102) ? v98 : UH0_UH0_0(["as", v102], v98);
    const v111: any = (v4.tag === US6_Tag.US6_1) ? v4.fields[0] : (void 0);
    const v116: UH0 = (!v111) ? v107 : UH0_UH0_0(["backgroundColor", v111], v107);
    const v120: any = (v5.tag === US6_Tag.US6_1) ? v5.fields[0] : (void 0);
    const v125: UH0 = (!v120) ? v116 : UH0_UH0_0(["border", v120], v116);
    const v129: any = (v6.tag === US6_Tag.US6_1) ? v6.fields[0] : (void 0);
    const v134: UH0 = (!v129) ? v125 : UH0_UH0_0(["borderBottomWidth", v129], v125);
    const v138: any = (v7.tag === US6_Tag.US6_1) ? v7.fields[0] : (void 0);
    const v143: UH0 = (!v138) ? v134 : UH0_UH0_0(["borderColor", v138], v134);
    const v147: any = (v8.tag === US6_Tag.US6_1) ? v8.fields[0] : (void 0);
    const v152: UH0 = (!v147) ? v143 : UH0_UH0_0(["borderWidth", v147], v143);
    const v156: any = (v9.tag === US6_Tag.US6_1) ? v9.fields[0] : (void 0);
    const v161: UH0 = (!v156) ? v152 : UH0_UH0_0(["bottom", v156], v152);
    const v165: any = (v10.tag === US8_Tag.US8_1) ? v10.fields[0] : (void 0);
    const v170: UH0 = (!v165) ? v161 : UH0_UH0_0(["checked", v165], v161);
    const v174: any = (v11.tag === US9_Tag.US9_1) ? v11.fields[0] : (void 0);
    const v179: UH0 = (!v174) ? v170 : UH0_UH0_0(["children", v174], v170);
    const v183: any = (v12.tag === US6_Tag.US6_1) ? v12.fields[0] : (void 0);
    const v188: UH0 = (!v183) ? v179 : UH0_UH0_0(["color", v183], v179);
    const v192: any = (v13.tag === US6_Tag.US6_1) ? v13.fields[0] : (void 0);
    const v197: UH0 = (!v192) ? v188 : UH0_UH0_0(["colorScheme", v192], v188);
    const v201: any = (v14.tag === US8_Tag.US8_1) ? v14.fields[0] : (void 0);
    const v206_1: UH0 = (!v201) ? v197 : UH0_UH0_0(["compact", v201], v197);
    const v210_1: any = (v15.tag === US10_Tag.US10_1) ? v15.fields[0] : (void 0);
    const v215_1: UH0 = (!v210_1) ? v206_1 : UH0_UH0_0(["css", v210_1], v206_1);
    const v219: any = (v16.tag === US6_Tag.US6_1) ? v16.fields[0] : (void 0);
    const v224: UH0 = (!v219) ? v215_1 : UH0_UH0_0(["defaultValue", v219], v215_1);
    const v228: any = (v17.tag === US6_Tag.US6_1) ? v17.fields[0] : (void 0);
    const v233: UH0 = (!v228) ? v224 : UH0_UH0_0(["direction", v228], v224);
    const v237: any = (v18.tag === US6_Tag.US6_1) ? v18.fields[0] : (void 0);
    const v242: UH0 = (!v237) ? v233 : UH0_UH0_0(["display", v237], v233);
    const v246: any = (v19.tag === US11_Tag.US11_1) ? v19.fields[0] : (void 0);
    const v251: UH0 = (!v246) ? v242 : UH0_UH0_0(["each", v246], v242);
    const v255: any = (v20.tag === US8_Tag.US8_1) ? v20.fields[0] : (void 0);
    const v260: UH0 = (!v255) ? v251 : UH0_UH0_0(["external", v255], v251);
    const v264: any = (v21.tag === US6_Tag.US6_1) ? v21.fields[0] : (void 0);
    const v269: UH0 = (!v264) ? v260 : UH0_UH0_0(["flex", v264], v260);
    const v273: any = (v22.tag === US6_Tag.US6_1) ? v22.fields[0] : (void 0);
    const v278: UH0 = (!v273) ? v269 : UH0_UH0_0(["flexDirection", v273], v269);
    const v282: any = (v23.tag === US6_Tag.US6_1) ? v23.fields[0] : (void 0);
    const v287: UH0 = (!v282) ? v278 : UH0_UH0_0(["flexFlow", v282], v278);
    const v291: any = (v24.tag === US6_Tag.US6_1) ? v24.fields[0] : (void 0);
    const v296: UH0 = (!v291) ? v287 : UH0_UH0_0(["fontSize", v291], v287);
    const v300: any = (v25.tag === US6_Tag.US6_1) ? v25.fields[0] : (void 0);
    const v305: UH0 = (!v300) ? v296 : UH0_UH0_0(["height", v300], v296);
    const v309: any = (v26.tag === US6_Tag.US6_1) ? v26.fields[0] : (void 0);
    const v314: UH0 = (!v309) ? v305 : UH0_UH0_0(["href", v309], v305);
    const v318: any = (v27.tag === US12_Tag.US12_1) ? v27.fields[0] : (void 0);
    const v323: UH0 = (!v318) ? v314 : UH0_UH0_0(["icon", v318], v314);
    const v327: any = (v28.tag === US6_Tag.US6_1) ? v28.fields[0] : (void 0);
    const v332: UH0 = (!v327) ? v323 : UH0_UH0_0(["id", v327], v323);
    const v336: any = (v29.tag === US6_Tag.US6_1) ? v29.fields[0] : (void 0);
    const v341: UH0 = (!v336) ? v332 : UH0_UH0_0(["justifyContent", v336], v332);
    const v345: any = (v30.tag === US6_Tag.US6_1) ? v30.fields[0] : (void 0);
    const v350: UH0 = (!v345) ? v341 : UH0_UH0_0(["left", v345], v341);
    const v354: any = (v31.tag === US12_Tag.US12_1) ? v31.fields[0] : (void 0);
    const v359: UH0 = (!v354) ? v350 : UH0_UH0_0(["leftIcon", v354], v350);
    const v363: any = (v32.tag === US6_Tag.US6_1) ? v32.fields[0] : (void 0);
    const v368: UH0 = (!v363) ? v359 : UH0_UH0_0(["lineHeight", v363], v359);
    const v372: any = (v33.tag === US6_Tag.US6_1) ? v33.fields[0] : (void 0);
    const v377: UH0 = (!v372) ? v368 : UH0_UH0_0(["margin", v372], v368);
    const v381: any = (v34.tag === US6_Tag.US6_1) ? v34.fields[0] : (void 0);
    const v386: UH0 = (!v381) ? v377 : UH0_UH0_0(["marginBottom", v381], v377);
    const v390: any = (v35.tag === US6_Tag.US6_1) ? v35.fields[0] : (void 0);
    const v395: UH0 = (!v390) ? v386 : UH0_UH0_0(["marginLeft", v390], v386);
    const v399: any = (v36.tag === US6_Tag.US6_1) ? v36.fields[0] : (void 0);
    const v404: UH0 = (!v399) ? v395 : UH0_UH0_0(["marginRight", v399], v395);
    const v408: any = (v37.tag === US6_Tag.US6_1) ? v37.fields[0] : (void 0);
    const v413: UH0 = (!v408) ? v404 : UH0_UH0_0(["marginTop", v408], v404);
    const v417: any = (v38.tag === US6_Tag.US6_1) ? v38.fields[0] : (void 0);
    const v422: UH0 = (!v417) ? v413 : UH0_UH0_0(["maxHeight", v417], v413);
    const v426: any = (v39.tag === US6_Tag.US6_1) ? v39.fields[0] : (void 0);
    const v431: UH0 = (!v426) ? v422 : UH0_UH0_0(["maxWidth", v426], v422);
    const v435: any = (v40.tag === US6_Tag.US6_1) ? v40.fields[0] : (void 0);
    const v440: UH0 = (!v435) ? v431 : UH0_UH0_0(["minHeight", v435], v431);
    const v444: any = (v41.tag === US6_Tag.US6_1) ? v41.fields[0] : (void 0);
    const v449: UH0 = (!v444) ? v440 : UH0_UH0_0(["minWidth", v444], v440);
    const v453: any = (v42.tag === US13_Tag.US13_1) ? v42.fields[0] : (void 0);
    const v458: UH0 = (!v453) ? v449 : UH0_UH0_0(["onChange", v453], v449);
    const v462: any = (v43.tag === US14_Tag.US14_1) ? v43.fields[0] : (void 0);
    const v467: UH0 = (!v462) ? v458 : UH0_UH0_0(["onClick", v462], v458);
    const v471: any = (v44.tag === US13_Tag.US13_1) ? v44.fields[0] : (void 0);
    const v476: UH0 = (!v471) ? v467 : UH0_UH0_0(["onInput", v471], v467);
    const v480: any = (v45.tag === US6_Tag.US6_1) ? v45.fields[0] : (void 0);
    const v485: UH0 = (!v480) ? v476 : UH0_UH0_0(["outline", v480], v476);
    const v489: any = (v46.tag === US6_Tag.US6_1) ? v46.fields[0] : (void 0);
    const v494: UH0 = (!v489) ? v485 : UH0_UH0_0(["overflow", v489], v485);
    const v498: any = (v47.tag === US6_Tag.US6_1) ? v47.fields[0] : (void 0);
    const v503: UH0 = (!v498) ? v494 : UH0_UH0_0(["overflowX", v498], v494);
    const v507: any = (v48.tag === US6_Tag.US6_1) ? v48.fields[0] : (void 0);
    const v512: UH0 = (!v507) ? v503 : UH0_UH0_0(["overflowY", v507], v503);
    const v516: any = (v49.tag === US6_Tag.US6_1) ? v49.fields[0] : (void 0);
    const v521: UH0 = (!v516) ? v512 : UH0_UH0_0(["padding", v516], v512);
    const v525: any = (v50.tag === US6_Tag.US6_1) ? v50.fields[0] : (void 0);
    const v530: UH0 = (!v525) ? v521 : UH0_UH0_0(["paddingBottom", v525], v521);
    const v534: any = (v51.tag === US6_Tag.US6_1) ? v51.fields[0] : (void 0);
    const v539: UH0 = (!v534) ? v530 : UH0_UH0_0(["paddingLeft", v534], v530);
    const v543: any = (v52.tag === US6_Tag.US6_1) ? v52.fields[0] : (void 0);
    const v548: UH0 = (!v543) ? v539 : UH0_UH0_0(["paddingRight", v543], v539);
    const v552: any = (v53.tag === US6_Tag.US6_1) ? v53.fields[0] : (void 0);
    const v557: UH0 = (!v552) ? v548 : UH0_UH0_0(["paddingTop", v552], v548);
    const v561: any = (v54.tag === US6_Tag.US6_1) ? v54.fields[0] : (void 0);
    const v566: UH0 = (!v561) ? v557 : UH0_UH0_0(["placeholder", v561], v557);
    const v570: any = (v55.tag === US6_Tag.US6_1) ? v55.fields[0] : (void 0);
    const v575: UH0 = (!v570) ? v566 : UH0_UH0_0(["position", v570], v566);
    const v579: any = (v56.tag === US6_Tag.US6_1) ? v56.fields[0] : (void 0);
    const v584: UH0 = (!v579) ? v575 : UH0_UH0_0(["right", v579], v575);
    const v588: any = (v57.tag === US6_Tag.US6_1) ? v57.fields[0] : (void 0);
    const v593: UH0 = (!v588) ? v584 : UH0_UH0_0(["size", v588], v584);
    const v597: any = (v58.tag === US6_Tag.US6_1) ? v58.fields[0] : (void 0);
    const v602: UH0 = (!v597) ? v593 : UH0_UH0_0(["spacing", v597], v593);
    const v606: any = (v59.tag === US6_Tag.US6_1) ? v59.fields[0] : (void 0);
    const v611: UH0 = (!v606) ? v602 : UH0_UH0_0(["src", v606], v602);
    const v615: any = (v60.tag === US6_Tag.US6_1) ? v60.fields[0] : (void 0);
    const v620: UH0 = (!v615) ? v611 : UH0_UH0_0(["striped", v615], v611);
    const v624: any = (v61.tag === US6_Tag.US6_1) ? v61.fields[0] : (void 0);
    const v629: UH0 = (!v624) ? v620 : UH0_UH0_0(["thickness", v624], v620);
    const v633: any = (v62.tag === US12_Tag.US12_1) ? v62.fields[0] : (void 0);
    const v638: UH0 = (!v633) ? v629 : UH0_UH0_0(["title", v633], v629);
    const v642: any = (v63.tag === US6_Tag.US6_1) ? v63.fields[0] : (void 0);
    const v647: UH0 = (!v642) ? v638 : UH0_UH0_0(["top", v642], v638);
    const v651: any = (v64.tag === US6_Tag.US6_1) ? v64.fields[0] : (void 0);
    const v656: UH0 = (!v651) ? v647 : UH0_UH0_0(["type", v651], v647);
    const v660: any = (v65.tag === US10_Tag.US10_1) ? v65.fields[0] : (void 0);
    const v665: UH0 = (!v660) ? v656 : UH0_UH0_0(["value", v660], v656);
    const v669: any = (v66.tag === US10_Tag.US10_1) ? v66.fields[0] : (void 0);
    const v674: UH0 = (!v669) ? v665 : UH0_UH0_0(["when", v669], v665);
    const v678: any = (v67.tag === US6_Tag.US6_1) ? v67.fields[0] : (void 0);
    const v683: UH0 = (!v678) ? v674 : UH0_UH0_0(["width", v678], v674);
    const v687: any = (v68.tag === US5_Tag.US5_1) ? v68.fields[0] : (void 0);
    const v692: UH0 = (!v687) ? v683 : UH0_UH0_0(["zIndex", v687], v683);
    const v696: any = (v69.tag === US6_Tag.US6_1) ? v69.fields[0] : (void 0);
    return method8((!v696) ? v692 : UH0_UH0_0(["zoom", v696], v692));
}

export function closure14(unitVar: void, v0_1: any): any[] {
    const v3: any = SimpleOption;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    let v81: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v78: any = children_1;
        v81 = US9_US9_1(v78(v15.fields[0]));
    }
    else {
        v81 = US9_US9_0();
    }
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v81.tag === US9_Tag.US9_1) ? v81.fields[0] : ((): any[] => closure15(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], US10_US10_1(v0_1), patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure15(v0_1, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v3;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure13(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: US11 = v0_1.l19;
    const v4: any[] = (v1_1.tag === US11_Tag.US11_1) ? v1_1.fields[0] : [];
    const v7: any = For;
    const v8: (arg0: any) => any[] = (v: any): any[] => closure14(void 0, v);
    const v9: () => any[] = v8;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v21: US9 = patternInput[11];
    let v87: US9;
    if (v21.tag === US9_Tag.US9_1) {
        const v84: any = children_1;
        v87 = US9_US9_1(v84(v21.fields[0]));
    }
    else {
        v87 = US9_US9_0();
    }
    const v93: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v87.tag === US9_Tag.US9_1) ? v87.fields[0] : v9), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], US11_US11_1(v4), patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    v93.children = v9;
    const v94: (arg0: any) => any = v7;
    const v96: any = createComponent;
    return [v96(v94, v93)];
}

export function method6(v0_1: Mut1): any {
    const v3: any = SimpleSelect;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    const v74_1: US6 = v0_1.l37;
    const v75_1: US6 = v0_1.l54;
    const v76_1: US13 = v0_1.l42;
    const v77_1: US10 = v0_1.l65;
    let v85: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v82: any = children_1;
        v85 = US9_US9_1(v82(v15.fields[0]));
    }
    else {
        v85 = US9_US9_0();
    }
    const v93: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v85.tag === US9_Tag.US9_1) ? v85.fields[0] : ((): any[] => closure13(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], v74_1, patternInput[38], patternInput[39], patternInput[40], patternInput[41], v76_1, patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], v75_1, patternInput[55], patternInput[56], US6_US6_1("xs"), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], v77_1, patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v94: () => any[] = (): any[] => closure13(v0_1, void 0);
    v93.children = v94;
    const v95: (arg0: any) => any = v3;
    const v98: any = createComponent;
    return v98(v95, v93);
}

export function closure12(unitVar: void, v0_1: Mut1): any {
    return method6(v0_1);
}

export function closure9(v0_1: (arg0: US4) => void, v1_1: () => US4, unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v13: US9 = patternInput[11];
    const v76_1: US4[] = [US4_US4_0(), US4_US4_2(), US4_US4_3(), US4_US4_1()];
    const v77_1: int32 = v76_1.length | 0;
    const v78: string[] = fill(new Array(v77_1), 0, v77_1, "");
    const v79: Mut3 = new Mut3(0);
    while (method5(v77_1, v79)) {
        const v81: int32 = v79.l0 | 0;
        const v82: US4 = v76_1[v81];
        const v87: string = (v82.tag === US4_Tag.US4_1) ? "Error" : ((v82.tag === US4_Tag.US4_2) ? "Info" : ((v82.tag === US4_Tag.US4_3) ? "Warn" : "Debug"));
        v78[v81] = v87;
        const v88: int32 = (v81 + 1) | 0;
        v79.l0 = (v88 | 0);
    }
    const v89: int32 = v78.length | 0;
    const v90: any[] = fill(new Array(v89), 0, v89, null);
    const v91: Mut3 = new Mut3(0);
    while (method5(v89, v91)) {
        const v93: int32 = v91.l0 | 0;
        const v94: string = v78[v93];
        v90[v93] = v94;
        const v96: int32 = (v93 + 1) | 0;
        v91.l0 = (v96 | 0);
    }
    const v97: US4 = v1_1();
    const v102: string = (v97.tag === US4_Tag.US4_1) ? "Error" : ((v97.tag === US4_Tag.US4_2) ? "Info" : ((v97.tag === US4_Tag.US4_3) ? "Warn" : "Debug"));
    let v111: US9;
    if (v13.tag === US9_Tag.US9_1) {
        const v108: any = children_1;
        v111 = US9_US9_1(v108(v13.fields[0]));
    }
    else {
        v111 = US9_US9_0();
    }
    const v119: (arg0: any) => void = (v: any): void => {
        closure11(v0_1, v);
    };
    const v122: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v111.tag === US9_Tag.US9_1) ? v111.fields[0] : ((): any[] => closure10(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], US11_US11_1(v90), patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], US6_US6_1("2px"), patternInput[38], patternInput[39], patternInput[40], patternInput[41], US13_US13_1(v119), patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], US10_US10_1(v102), patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v123: () => any[] = (): any[] => closure10(void 0, void 0);
    v122.children = v123;
    const v126: any = createComponent;
    const v127: (arg0: Mut1) => any = (v_1: Mut1): any => closure12(void 0, v_1);
    return [v126(v127, v122)];
}

export function closure8(v0_1: (arg0: US4) => void, v1_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure9(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Log Level
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method12(v0_1: string, v1_1: string): string {
    return {
        "@initial": v1_1,
        "@sm": v0_1,
    };
}

export function closure21(v0_1: any, unitVar: void): any[] {
    return [v0_1];
}

export function closure20(v0_1: any, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v71: () => any[] = (): any[] => closure21(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v71), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure24(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure23(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US10, v16: US6, v17: US6, v18: US6, v19: US11, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US12, v28: US6, v29: US6, v30: US6, v31: US12, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US13, v43: US14, v44: US13, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US6, v62: US12, v63: US6, v64: US6, v65: US10, v66: US10, v67: US6, v68: US5, v69: US6, unitVar: void): any[] {
    const v72_1: any = Box;
    const v75_1: () => any[] = (v11.tag === US9_Tag.US9_1) ? v11.fields[0] : ((): any[] => closure24(void 0, void 0));
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v87: US9 = patternInput[11];
    let v153: US9;
    if (v87.tag === US9_Tag.US9_1) {
        const v150: any = children_1;
        v153 = US9_US9_1(v150(v87.fields[0]));
    }
    else {
        v153 = US9_US9_0();
    }
    const v160: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v153.tag === US9_Tag.US9_1) ? v153.fields[0] : v75_1), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], US6_US6_1("1.5px"), patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    v160.children = v75_1;
    const v161: (arg0: any) => any = v72_1;
    const v164: any = createComponent;
    return [v164(v161, v160)];
}

export function closure25(v0_1: Mut5, v1_1: any): void {
    const v2: boolean = v1_1.target.checked;
    v0_1.l1(v2);
}

export function closure22(unitVar: void, v0_1: Mut5): any {
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v0_1.l2;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v99: US12 = patternInput_1[27];
    const v98: US6 = patternInput_1[26];
    const v97: US6 = patternInput_1[25];
    const v96: US6 = patternInput_1[24];
    const v95: US6 = patternInput_1[23];
    const v94: US6 = patternInput_1[22];
    const v93: US6 = patternInput_1[21];
    const v92: US8 = patternInput_1[20];
    const v91: US11 = patternInput_1[19];
    const v90: US6 = patternInput_1[18];
    const v89: US6 = patternInput_1[17];
    const v88: US6 = patternInput_1[16];
    const v87: US10 = patternInput_1[15];
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
    const v138: US10 = patternInput_1[66];
    const v137: US10 = patternInput_1[65];
    const v136: US6 = patternInput_1[64];
    const v135: US6 = patternInput_1[63];
    const v134: US12 = patternInput_1[62];
    const v133: US6 = patternInput_1[61];
    const v132: US6 = patternInput_1[60];
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
    const v116: US13 = patternInput_1[44];
    const v115: US14 = patternInput_1[43];
    const v114: US13 = patternInput_1[42];
    const v113: US6 = patternInput_1[41];
    const v112: US6 = patternInput_1[40];
    const v111: US6 = patternInput_1[39];
    const v110: US6 = patternInput_1[38];
    const v109: US6 = patternInput_1[37];
    const v108: US6 = patternInput_1[36];
    const v107: US6 = patternInput_1[35];
    const v106: US6 = patternInput_1[34];
    const v105: US6 = patternInput_1[33];
    const v104: US6 = patternInput_1[32];
    const v103: US12 = patternInput_1[31];
    const v102: US6 = patternInput_1[30];
    const v101: US6 = patternInput_1[29];
    const v100: US6 = patternInput_1[28];
    let v149: US9;
    if (v83.tag === US9_Tag.US9_1) {
        const v146: any = children_1;
        v149 = US9_US9_1(v146(v83.fields[0]));
    }
    else {
        v149 = US9_US9_0();
    }
    const v152: any = Checkbox;
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v164: US9 = patternInput_2[11];
    const v224: boolean = v0_1.l0();
    let v232: US9;
    if (v164.tag === US9_Tag.US9_1) {
        const v229: any = children_1;
        v232 = US9_US9_1(v229(v164.fields[0]));
    }
    else {
        v232 = US9_US9_0();
    }
    const v240: (arg0: any) => void = (v: any): void => {
        closure25(v0_1, v);
    };
    const v251: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US8_US8_1(v224), US9_US9_1((v232.tag === US9_Tag.US9_1) ? v232.fields[0] : ((): any[] => closure23(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, void 0))), patternInput_2[12], US6_US6_1("neutral"), patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], US13_US13_1(v240), patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], US6_US6_1("2px"), US6_US6_1("3px"), patternInput_2[52], US6_US6_1("1px"), patternInput_2[54], patternInput_2[55], patternInput_2[56], US6_US6_1("sm"), patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    const v252: () => any[] = (): any[] => closure23(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, void 0);
    v251.children = v252;
    const v253: (arg0: any) => any = v152;
    const v256: any = createComponent;
    return v256(v253, v251);
}

export function closure19(v0_1: Mut4, v1_1: (arg0: boolean) => void, v2: () => boolean, v3: any, unitVar: void): any[] {
    let v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v13: Mut5, v16: any, v17: (arg0: Mut5) => any, v5: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v6: Mut5, v9: any, v10: (arg0: Mut5) => any;
    const v4: US15 = v0_1.l3;
    return [(v4.tag === US15_Tag.US15_1) ? ((v12 = ((arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure20(v3, arg10$0040_1)), (v13 = (new Mut5(v2, v1_1, v12)), (v16 = createComponent, (v17 = ((v_1: Mut5): any => closure22(void 0, v_1)), v16(v17, v13)))))) : ((v4.tag === US15_Tag.US15_2) ? v3 : ((v5 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure20(v3, arg10$0040)), (v6 = (new Mut5(v2, v1_1, v5)), (v9 = createComponent, (v10 = ((v: Mut5): any => closure22(void 0, v)), v9(v10, v6)))))))];
}

export function closure18(v0_1: Mut4, v1_1: US6, v2: US6, v3: US6, v4: US7, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US6, v11: US8, v12: US9, v13: US6, v14: US6, v15: US8, v16: US10, v17: US6, v18: US6, v19: US6, v20: US11, v21: US8, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US6, v28: US12, v29: US6, v30: US6, v31: US6, v32: US12, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US6, v43: US13, v44: US14, v45: US13, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US6, v62: US6, v63: US12, v64: US6, v65: US6, v66: US10, v67: US10, v68: US6, v69: US5, v70: US6, v71: (arg0: boolean) => void, v72_1: () => boolean, v73_1: any, unitVar: void): any[] {
    const v76_1: any = Box;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v88: US9 = patternInput[11];
    const v149: string = (v54.tag === US6_Tag.US6_1) ? v54.fields[0] : "4px";
    const v152: string = (v51.tag === US6_Tag.US6_1) ? v51.fields[0] : "2px";
    const v155: string = (v52.tag === US6_Tag.US6_1) ? v52.fields[0] : "8px";
    let v163: US9;
    if (v88.tag === US9_Tag.US9_1) {
        const v160: any = children_1;
        v163 = US9_US9_1(v160(v88.fields[0]));
    }
    else {
        v163 = US9_US9_0();
    }
    const v172: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v163.tag === US9_Tag.US9_1) ? v163.fields[0] : ((): any[] => closure19(v0_1, v71, v72_1, v73_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], US6_US6_1(v152), US6_US6_1(v155), patternInput[52], US6_US6_1(v149), patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v173: () => any[] = (): any[] => closure19(v0_1, v71, v72_1, v73_1, void 0);
    v172.children = v173;
    const v174: (arg0: any) => any = v76_1;
    const v177: any = createComponent;
    return [v177(v174, v172)];
}

export function closure26(unitVar: void, unitVar_1: void): any[] {
    return [<>
        &nbsp;
    </>];
}

export function closure28(v0_1: () => any[], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v0_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure30(v0_1: int32, v1_1: () => string, v2: () => US4, v3: () => US5, unitVar: void): any[] {
    const v6: string = v1_1();
    const v9: US4 = v2();
    return [["loader_id:", v0_1], ["chain_token:", v6], ["log_level:", (v9.tag === US4_Tag.US4_1) ? "Error" : ((v9.tag === US4_Tag.US4_2) ? "Info" : ((v9.tag === US4_Tag.US4_3) ? "Warn" : "Debug"))], ["ui_modal:", v3()]];
}

export function method16(v0_1_mut: int32, v1_1_mut: string): string {
    method16:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: string = v1_1_mut;
        if (v1_1.length < v0_1) {
            v0_1_mut = v0_1;
            v1_1_mut = (`0${v1_1}`);
            continue method16;
        }
        else {
            return v1_1;
        }
        break;
    }
}

export function closure32(v0_1: () => US4, v1_1: () => any[], v2: string, v3: string, v4: any, v5: string, v6: string, v7: boolean, v8: int64, v9: US4, v10: any[]): void {
    const v11: US4 = v0_1();
    if (getUnionFields(v11, US4$reflection())[0].tag <= getUnionFields(v9, US4$reflection())[0].tag) {
        const v25: any[] = [["timestamp:", method16(6, toString_1(op_Subtraction(op_Division(getTicks(utcNow()), fromBits(1000, 0, false)), v8)))], ["run_id:", components_spi.run_id]];
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

export function closure31(v0_1: () => US4, v1_1: () => any[], v2: string, v3: string, v4: any, v5: string, v6: string, v7: boolean, v8: int64, v9: US4): (arg0: any[]) => void {
    return (v: any[]): void => {
        closure32(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v);
    };
}

export function method15(v0_1: () => US4, v1_1: () => any[], v2: string): (arg0: US4, arg1: any[]) => void {
    const patternInput: [string, any, string, string, boolean] = method2();
    const v8: int64 = op_Division(getTicks(utcNow()), fromBits(1000, 0, false));
    return (v: US4): (arg0: any[]) => void => closure31(v0_1, v1_1, v2, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], v8, v);
}

export function method14(v0_1: () => any[], v1_1: string): (arg0: US4, arg1: any[]) => void {
    const v127: any = components_spi.state_context;
    const v130: any = useContext;
    return method15((v130(v127))[18], v0_1, v1_1);
}

export function closure33(v0_1: Mut6, v1_1: int32, v2: (arg0: US5) => void, unitVar: void): void {
    if (v0_1.l1) {
        v2(US5_US5_1(v1_1));
    }
}

export function method17(v0_1: () => void): void {
    const v3: any = createEffect;
    v3(v0_1);
}

export function closure34(v0_1: (arg0: boolean) => void, v1_1: () => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure35(v0_1: Mut6, unitVar: void): void {
    const v1_1: US14 = v0_1.l3;
    if (v1_1.tag === US14_Tag.US14_1) {
        v1_1.fields[0]();
    }
}

export function method18(v0_1: () => void): void {
    const v3: any = onCleanup;
    v3(v0_1);
}

export function closure38(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Load
    </>];
}

export function closure39(v0_1: (arg0: boolean) => void, v1_1: Mut6, unitVar: void): void {
    const v2: US14 = v1_1.l2;
    if (v2.tag === US14_Tag.US14_1) {
        v2.fields[0]();
    }
    v0_1(true);
}

export function closure41(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method20(v0_1: Mut1, v1_1: Mut1): void {
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

export function method19(v0_1: Mut1): any {
    const v3: any = Button;
    const v4: US9 = v0_1.l11;
    const v7: () => any[] = (v4.tag === US9_Tag.US9_1) ? v4.fields[0] : ((): any[] => closure41(void 0, void 0));
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67, v0_1.l68, v0_1.l69];
    const v156: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], US6_US6_1("neutral"), US8_US8_1(true), patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], US6_US6_1("left"), patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1("xs"), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    method20(v156, new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = [v156.l0, v156.l1, v156.l2, v156.l3, v156.l4, v156.l5, v156.l6, v156.l7, v156.l8, v156.l9, v156.l10, v156.l11, v156.l12, v156.l13, v156.l14, v156.l15, v156.l16, v156.l17, v156.l18, v156.l19, v156.l20, v156.l21, v156.l22, v156.l23, v156.l24, v156.l25, v156.l26, v156.l27, v156.l28, v156.l29, v156.l30, v156.l31, v156.l32, v156.l33, v156.l34, v156.l35, v156.l36, v156.l37, v156.l38, v156.l39, v156.l40, v156.l41, v156.l42, v156.l43, v156.l44, v156.l45, v156.l46, v156.l47, v156.l48, v156.l49, v156.l50, v156.l51, v156.l52, v156.l53, v156.l54, v156.l55, v156.l56, v156.l57, v156.l58, v156.l59, v156.l60, v156.l61, v156.l62, v156.l63, v156.l64, v156.l65, v156.l66, v156.l67, v156.l68, v156.l69];
    const v168: US9 = patternInput_2[11];
    let v234: US9;
    if (v168.tag === US9_Tag.US9_1) {
        const v231: any = children_1;
        v234 = US9_US9_1(v231(v168.fields[0]));
    }
    else {
        v234 = US9_US9_0();
    }
    const v239: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v234.tag === US9_Tag.US9_1) ? v234.fields[0] : v7), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    v239.children = v7;
    const v240: (arg0: any) => any = v3;
    const v243: any = createComponent;
    return v243(v240, v239);
}

export function closure40(unitVar: void, v0_1: Mut1): any {
    return method19(v0_1);
}

export function closure37(v0_1: (arg0: boolean) => void, v1_1: Mut6, unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v13: US9 = patternInput[11];
    let v79: US9;
    if (v13.tag === US9_Tag.US9_1) {
        const v76_1: any = children_1;
        v79 = US9_US9_1(v76_1(v13.fields[0]));
    }
    else {
        v79 = US9_US9_0();
    }
    const v84: () => void = (): void => {
        closure39(v0_1, v1_1, void 0);
    };
    const v86: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v79.tag === US9_Tag.US9_1) ? v79.fields[0] : ((): any[] => closure38(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], US14_US14_1(v84), patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v87: () => any[] = (): any[] => closure38(void 0, void 0);
    v86.children = v87;
    const v90: any = createComponent;
    const v91: (arg0: Mut1) => any = (v: Mut1): any => closure40(void 0, v);
    return [v90(v91, v86)];
}

export function closure45(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure46(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularRefresh;
    return v2;
}

export function closure48(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method21(v0_1: Mut7): any {
    const v3: any = Icon;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v75_1: any = v0_1.l1();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v87: US9 = patternInput_1[11];
    let v153: US9;
    if (v87.tag === US9_Tag.US9_1) {
        const v150: any = children_1;
        v153 = US9_US9_1(v150(v87.fields[0]));
    }
    else {
        v153 = US9_US9_0();
    }
    const v155: string = "-12px";
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v0_1.l0([patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], v153, patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], US6_US6_1(v155), patternInput_1[36], US6_US6_1(v155), patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], US6_US6_1("0.6")]);
    const v231: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    const patternInput_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v0_1.l2([patternInput[0], patternInput[1], patternInput[2], US7_US7_1(v75_1), patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], US10_US10_1(v231), patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1("14px"), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v248: US9 = patternInput_3[11];
    let v314: US9;
    if (v248.tag === US9_Tag.US9_1) {
        const v311: any = children_1;
        v314 = US9_US9_1(v311(v248.fields[0]));
    }
    else {
        v314 = US9_US9_0();
    }
    const v320: any = createObj(method7(patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3], patternInput_3[4], patternInput_3[5], patternInput_3[6], patternInput_3[7], patternInput_3[8], patternInput_3[9], patternInput_3[10], US9_US9_1((v314.tag === US9_Tag.US9_1) ? v314.fields[0] : ((): any[] => closure48(void 0, void 0))), patternInput_3[12], patternInput_3[13], patternInput_3[14], patternInput_3[15], patternInput_3[16], patternInput_3[17], patternInput_3[18], patternInput_3[19], patternInput_3[20], patternInput_3[21], patternInput_3[22], patternInput_3[23], patternInput_3[24], patternInput_3[25], patternInput_3[26], patternInput_3[27], patternInput_3[28], patternInput_3[29], patternInput_3[30], patternInput_3[31], patternInput_3[32], patternInput_3[33], patternInput_3[34], patternInput_3[35], patternInput_3[36], patternInput_3[37], patternInput_3[38], patternInput_3[39], patternInput_3[40], patternInput_3[41], patternInput_3[42], patternInput_3[43], patternInput_3[44], patternInput_3[45], patternInput_3[46], patternInput_3[47], patternInput_3[48], patternInput_3[49], patternInput_3[50], patternInput_3[51], patternInput_3[52], patternInput_3[53], patternInput_3[54], patternInput_3[55], patternInput_3[56], patternInput_3[57], patternInput_3[58], patternInput_3[59], patternInput_3[60], patternInput_3[61], patternInput_3[62], patternInput_3[63], patternInput_3[64], patternInput_3[65], patternInput_3[66], patternInput_3[67], patternInput_3[68], patternInput_3[69]));
    const v321: () => any[] = (): any[] => closure48(void 0, void 0);
    v320.children = v321;
    const v322: (arg0: any) => any = v3;
    const v325: any = createComponent;
    return v325(v322, v320);
}

export function closure47(unitVar: void, v0_1: Mut7): any {
    return method21(v0_1);
}

export function closure49(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure50(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure51(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularDownArrow;
    return v2;
}

export function closure52(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUpArrow;
    return v2;
}

export function closure53(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure54(v0_1: int32, v1_1: (arg0: US5) => void, v2: () => US5, unitVar: void): void {
    const v3: US5 = v2();
    v1_1((((v3.tag === US5_Tag.US5_1) && (v3.fields[0] === v0_1)) === false) ? US5_US5_1(v0_1) : US5_US5_0());
}

export function closure55(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUndo;
    return v2;
}

export function closure56(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure57(v0_1: (arg0: boolean) => void, v1_1: Mut6, unitVar: void): void {
    const v2: US14 = v1_1.l3;
    if (v2.tag === US14_Tag.US14_1) {
        v2.fields[0]();
    }
    v0_1(false);
}

export function closure44(v0_1: int32, v1_1: (arg0: US5) => void, v2: (arg0: boolean) => void, v3: (arg0: boolean) => void, v4: Mut6, v5: () => US5, unitVar: void): any[] {
    const v8: any = IconButton;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v20: US9 = patternInput[11];
    const v79: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040);
    const v80: () => any = (): any => closure46(void 0, void 0);
    const v81: Mut7 = new Mut7(v79, v80, v79);
    const v84: any = createComponent;
    const v85: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    const v86: any = v84(v85, v81);
    let v93: US9;
    if (v20.tag === US9_Tag.US9_1) {
        const v90: any = children_1;
        v93 = US9_US9_1(v90(v20.fields[0]));
    }
    else {
        v93 = US9_US9_0();
    }
    const v100: string = "neutral";
    const v102: string = "20px";
    const v105: () => void = (): void => {
        closure50(v3, void 0);
    };
    const v107: string = "xs";
    const v110: any = createObj(method7(patternInput[0], patternInput[1], US6_US6_1("Refresh"), patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v93.tag === US9_Tag.US9_1) ? v93.fields[0] : ((): any[] => closure49(void 0, void 0))), patternInput[12], US6_US6_1(v100), patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], US6_US6_1(v102), patternInput[26], US12_US12_1(v86), patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], US14_US14_1(v105), patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1(v107), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v111: () => any[] = (): any[] => closure49(void 0, void 0);
    v110.children = v111;
    const v112: (arg0: any) => any = v8;
    const v113: any = createComponent;
    const v114: any = v113(v112, v110);
    const v115: any = IconButton;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v127: US9 = patternInput_1[11];
    const v186: US5 = v5();
    const v193: string = ((v186.tag === US5_Tag.US5_1) && (v186.fields[0] === v0_1)) ? "Restore" : "Maximize";
    const v194: US5 = v5();
    const v202: Mut7 = new Mut7(v79, ((v194.tag === US5_Tag.US5_1) && (v194.fields[0] === v0_1)) ? ((): any => closure51(void 0, void 0)) : ((): any => closure52(void 0, void 0)), v79);
    const v203_1: any = createComponent;
    const v204_1: any = v203_1(v85, v202);
    let v211_1: US9;
    if (v127.tag === US9_Tag.US9_1) {
        const v208_1: any = children_1;
        v211_1 = US9_US9_1(v208_1(v127.fields[0]));
    }
    else {
        v211_1 = US9_US9_0();
    }
    const v220: () => void = (): void => {
        closure54(v0_1, v1_1, v5, void 0);
    };
    const v224: any = createObj(method7(patternInput_1[0], patternInput_1[1], US6_US6_1(v193), patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v211_1.tag === US9_Tag.US9_1) ? v211_1.fields[0] : ((): any[] => closure53(void 0, void 0))), patternInput_1[12], US6_US6_1(v100), patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], US6_US6_1(v102), patternInput_1[26], US12_US12_1(v204_1), patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], US14_US14_1(v220), patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], US6_US6_1(v107), patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    const v225: () => any[] = (): any[] => closure53(void 0, void 0);
    v224.children = v225;
    const v226: (arg0: any) => any = v115;
    const v227: any = createComponent;
    const v228: any = v227(v226, v224);
    const v229: any = IconButton;
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v241: US9 = patternInput_2[11];
    const v300: () => any = (): any => closure55(void 0, void 0);
    const v301: Mut7 = new Mut7(v79, v300, v79);
    const v302: any = createComponent;
    const v303: any = v302(v85, v301);
    let v310: US9;
    if (v241.tag === US9_Tag.US9_1) {
        const v307: any = children_1;
        v310 = US9_US9_1(v307(v241.fields[0]));
    }
    else {
        v310 = US9_US9_0();
    }
    const v320: () => void = (): void => {
        closure57(v2, v4, void 0);
    };
    const v324: any = createObj(method7(patternInput_2[0], patternInput_2[1], US6_US6_1("Unload"), patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v310.tag === US9_Tag.US9_1) ? v310.fields[0] : ((): any[] => closure56(void 0, void 0))), patternInput_2[12], US6_US6_1(v100), patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], US6_US6_1(v102), patternInput_2[26], US12_US12_1(v303), patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US14_US14_1(v320), patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], US6_US6_1(v107), patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    const v325: () => any[] = (): any[] => closure56(void 0, void 0);
    v324.children = v325;
    const v326: (arg0: any) => any = v229;
    const v327: any = createComponent;
    return [v114, v228, v327(v326, v324)];
}

export function closure43(v0_1: int32, v1_1: (arg0: US5) => void, v2: () => US5, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: () => boolean, v6: Mut6, v7: () => any[], unitVar: void): any[] {
    const v10: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v22: US9 = patternInput[11];
    const v81: US5 = v2();
    const v90: US6 = (v81.tag === US5_Tag.US5_1) ? (((v81.fields[0] === v0_1) !== true) ? US6_US6_1("none") : US6_US6_0()) : US6_US6_0();
    let v98: US9;
    if (v22.tag === US9_Tag.US9_1) {
        const v95: any = children_1;
        v98 = US9_US9_1(v95(v22.fields[0]));
    }
    else {
        v98 = US9_US9_0();
    }
    const v107: string = "6px";
    const v115: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v98.tag === US9_Tag.US9_1) ? v98.fields[0] : ((): any[] => closure44(v0_1, v1_1, v3, v4, v6, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1("row"), v90, patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], US6_US6_1("absolute"), US6_US6_1(v107), patternInput[57], US6_US6_1("3px"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], US6_US6_1(v107), patternInput[64], patternInput[65], patternInput[66], patternInput[67], US5_US5_1(2), patternInput[69]));
    const v116: () => any[] = (): any[] => closure44(v0_1, v1_1, v3, v4, v6, v2, void 0);
    v115.children = v116;
    const v117: (arg0: any) => any = v10;
    const v120: any = createComponent;
    return [v120(v117, v115), v5() ? (void 0) : v7];
}

export function closure42(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US10, v16: US6, v17: US6, v18: US6, v19: US11, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US12, v28: US6, v29: US6, v30: US6, v31: US12, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US13, v43: US14, v44: US13, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US6, v62: US12, v63: US6, v64: US6, v65: US10, v66: US10, v67: US6, v68: US5, v69: US6, v70: int32, v71: (arg0: US5) => void, v72_1: () => US5, v73_1: (arg0: boolean) => void, v74_1: (arg0: boolean) => void, v75_1: () => boolean, v76_1: Mut6, unitVar: void): any[] {
    let v78: () => any[], v81: any, patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v93: US9, v158: US6, v166: US9, v163: any, v176: any, v177: () => any[], v178: (arg0: any) => any, v181: any;
    return [(v11.tag === US9_Tag.US9_1) ? ((v78 = v11.fields[0], (v81 = Box, (patternInput = method3(), (v93 = patternInput[11], (v158 = ((v72_1().tag === US5_Tag.US5_0) ? US6_US6_1("relative") : US6_US6_0()), (v166 = ((v93.tag === US9_Tag.US9_1) ? ((v163 = children_1, US9_US9_1(v163(v93.fields[0])))) : US9_US9_0()), (v176 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v166.tag === US9_Tag.US9_1) ? v166.fields[0] : ((): any[] => closure43(v70, v71, v72_1, v73_1, v74_1, v75_1, v76_1, v78, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], US6_US6_1("1"), patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], v158, patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69])), (v177 = ((): any[] => closure43(v70, v71, v72_1, v73_1, v74_1, v75_1, v76_1, v78, void 0)), (v176.children = v177, (v178 = (v81), (v181 = createComponent, v181(v178, v176))))))))))))) : (void 0)];
}

export function closure36(v0_1: US6, v1_1: US6, v2: US6, v3: US7, v4: US6, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US8, v11: US9, v12: US6, v13: US6, v14: US8, v15: US10, v16: US6, v17: US6, v18: US6, v19: US11, v20: US8, v21: US6, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US12, v28: US6, v29: US6, v30: US6, v31: US12, v32: US6, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US13, v43: US14, v44: US13, v45: US6, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US6, v62: US12, v63: US6, v64: US6, v65: US10, v66: US10, v67: US6, v68: US5, v69: US6, v70: int32, v71: (arg0: US5) => void, v72_1: () => US5, v73_1: (arg0: boolean) => void, v74_1: () => boolean, v75_1: (arg0: boolean) => void, v76_1: () => boolean, v77_1: Mut6, unitVar: void): any[] {
    let v82: any, patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v94: US9, v160: US9, v157: any, v168: any, v169: () => any[], v170: (arg0: any) => any, v173: any, v177: any, patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v189: US9, v248: US5, v256: US6, v257: US5, v265: US6, v266: US5, v274: US6, v275: US5, v283: US6, v284: US5, v292: US6, v293: US5, v301: US6, v302: US5, v309: US5, v317: US9, v314: any, v327: any, v328: () => any[], v329: (arg0: any) => any, v332: any;
    return [(v74_1() === false) ? ((v82 = Box, (patternInput = method3(), (v94 = patternInput[11], (v160 = ((v94.tag === US9_Tag.US9_1) ? ((v157 = children_1, US9_US9_1(v157(v94.fields[0])))) : US9_US9_0()), (v168 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v160.tag === US9_Tag.US9_1) ? v160.fields[0] : ((): any[] => closure37(v73_1, v77_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1("3px 0"), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69])), (v169 = ((): any[] => closure37(v73_1, v77_1, void 0)), (v168.children = v169, (v170 = (v82), (v173 = createComponent, v173(v170, v168))))))))))) : ((v177 = Box, (patternInput_1 = method3(), (v189 = patternInput_1[11], (v248 = v72_1(), (v256 = (((v248.tag === US5_Tag.US5_1) && (v248.fields[0] === v70)) ? US6_US6_1("$bg") : US6_US6_0()), (v257 = v72_1(), (v265 = (((v257.tag === US5_Tag.US5_1) && (v257.fields[0] === v70)) ? US6_US6_1("0") : US6_US6_0()), (v266 = v72_1(), (v274 = (((v266.tag === US5_Tag.US5_1) && (v266.fields[0] === v70)) ? US6_US6_1("0") : US6_US6_0()), (v275 = v72_1(), (v283 = (((v275.tag === US5_Tag.US5_1) && (v275.fields[0] === v70)) ? US6_US6_1("fixed") : US6_US6_0()), (v284 = v72_1(), (v292 = (((v284.tag === US5_Tag.US5_1) && (v284.fields[0] === v70)) ? US6_US6_1("0") : US6_US6_0()), (v293 = v72_1(), (v301 = (((v293.tag === US5_Tag.US5_1) && (v293.fields[0] === v70)) ? US6_US6_1("0") : US6_US6_0()), (v302 = v72_1(), (v309 = (((v302.tag === US5_Tag.US5_1) && (v302.fields[0] === v70)) ? US5_US5_1(1) : US5_US5_0()), (v317 = ((v189.tag === US9_Tag.US9_1) ? ((v314 = children_1, US9_US9_1(v314(v189.fields[0])))) : US9_US9_0()), (v327 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], v256, patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], v265, patternInput_1[10], US9_US9_1((v317.tag === US9_Tag.US9_1) ? v317.fields[0] : ((): any[] => closure42(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v73_1, v75_1, v76_1, v77_1, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US6_US6_1("flex"), patternInput_1[19], patternInput_1[20], US6_US6_1("1"), patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], v274, patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], v283, v292, patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], v301, patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], v309, patternInput_1[69])), (v328 = ((): any[] => closure42(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v73_1, v75_1, v76_1, v77_1, void 0)), (v327.children = v328, (v329 = (v177), (v332 = createComponent, v332(v329, v327)))))))))))))))))))))))))];
}

export function method13(v0_1: Mut6): any {
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v0_1.l4;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v99: US12 = patternInput_1[27];
    const v98: US6 = patternInput_1[26];
    const v97: US6 = patternInput_1[25];
    const v96: US6 = patternInput_1[24];
    const v95: US6 = patternInput_1[23];
    const v94: US6 = patternInput_1[22];
    const v93: US6 = patternInput_1[21];
    const v92: US8 = patternInput_1[20];
    const v91: US11 = patternInput_1[19];
    const v90: US6 = patternInput_1[18];
    const v89: US6 = patternInput_1[17];
    const v88: US6 = patternInput_1[16];
    const v87: US10 = patternInput_1[15];
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
    const v138: US10 = patternInput_1[66];
    const v137: US10 = patternInput_1[65];
    const v136: US6 = patternInput_1[64];
    const v135: US6 = patternInput_1[63];
    const v134: US12 = patternInput_1[62];
    const v133: US6 = patternInput_1[61];
    const v132: US6 = patternInput_1[60];
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
    const v116: US13 = patternInput_1[44];
    const v115: US14 = patternInput_1[43];
    const v114: US13 = patternInput_1[42];
    const v113: US6 = patternInput_1[41];
    const v112: US6 = patternInput_1[40];
    const v111: US6 = patternInput_1[39];
    const v110: US6 = patternInput_1[38];
    const v109: US6 = patternInput_1[37];
    const v108: US6 = patternInput_1[36];
    const v107: US6 = patternInput_1[35];
    const v106: US6 = patternInput_1[34];
    const v105: US6 = patternInput_1[33];
    const v104: US6 = patternInput_1[32];
    const v103: US12 = patternInput_1[31];
    const v102: US6 = patternInput_1[30];
    const v101: US6 = patternInput_1[29];
    const v100: US6 = patternInput_1[28];
    let v149: US9;
    if (v83.tag === US9_Tag.US9_1) {
        const v146: any = children_1;
        v149 = US9_US9_1(v146(v83.fields[0]));
    }
    else {
        v149 = US9_US9_0();
    }
    const v150: int32 = nonSeeded().Next0() | 0;
    const v276: any = components_spi.state_context;
    const v279: any = useContext;
    const patternInput_2: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v279(v276);
    const v425: any = components_spi.state_context;
    const v426: any = useContext;
    const patternInput_3: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v426(v425);
    const v572: any = components_spi.state_context;
    const v573: any = useContext;
    const patternInput_4: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v573(v572);
    const v595: (arg0: US5) => void = patternInput_4[21];
    const v594: () => US5 = patternInput_4[20];
    const v596: () => any[] = (): any[] => closure30(v150, patternInput_2[4], patternInput_3[18], v594, void 0);
    method14(v596, "#de884c")(US4_US4_0())(["> loader ()"]);
    const v604: boolean = v0_1.l0;
    const v606: any = createSignal;
    const v607: any[] = v606(v604);
    let v608: () => boolean;
    const value_5: any = v607[0];
    v608 = (value_5);
    let v609: (arg0: boolean) => void;
    const value_6: any = v607[1];
    v609 = ((arg_1: boolean): void => {
        value_6(arg_1);
    });
    const v610: any = createSignal;
    const v611: any[] = v610(false);
    let v612: () => boolean;
    const value_8: any = v611[0];
    v612 = (value_8);
    let v613: (arg0: boolean) => void;
    const value_9: any = v611[1];
    v613 = ((arg_3: boolean): void => {
        value_9(arg_3);
    });
    const v614: () => void = (): void => {
        closure33(v0_1, v150, v595, void 0);
    };
    method17(v614);
    const v615: () => void = (): void => {
        closure34(v613, v612, void 0);
    };
    method17(v615);
    const v616: () => void = (): void => {
        closure35(v0_1, void 0);
    };
    method18(v616);
    if (v0_1.l0 === true) {
        const v619: US14 = v0_1.l2;
        if (v619.tag === US14_Tag.US14_1) {
            v619.fields[0]();
        }
    }
    const v623: any = Box;
    const patternInput_5: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v635: US9 = patternInput_5[11];
    let v700: US9;
    if (v635.tag === US9_Tag.US9_1) {
        const v697: any = children_1;
        v700 = US9_US9_1(v697(v635.fields[0]));
    }
    else {
        v700 = US9_US9_0();
    }
    const v710: any = createObj(method7(patternInput_5[0], patternInput_5[1], patternInput_5[2], patternInput_5[3], patternInput_5[4], patternInput_5[5], patternInput_5[6], patternInput_5[7], patternInput_5[8], patternInput_5[9], patternInput_5[10], US9_US9_1((v700.tag === US9_Tag.US9_1) ? v700.fields[0] : ((): any[] => closure36(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v595, v594, v609, v608, v613, v612, v0_1, void 0))), patternInput_5[12], patternInput_5[13], patternInput_5[14], patternInput_5[15], patternInput_5[16], patternInput_5[17], US6_US6_1("flex"), patternInput_5[19], patternInput_5[20], US6_US6_1("1"), patternInput_5[22], patternInput_5[23], patternInput_5[24], patternInput_5[25], patternInput_5[26], patternInput_5[27], v100, patternInput_5[29], patternInput_5[30], patternInput_5[31], patternInput_5[32], patternInput_5[33], patternInput_5[34], patternInput_5[35], patternInput_5[36], patternInput_5[37], patternInput_5[38], patternInput_5[39], patternInput_5[40], patternInput_5[41], patternInput_5[42], patternInput_5[43], patternInput_5[44], patternInput_5[45], patternInput_5[46], patternInput_5[47], patternInput_5[48], patternInput_5[49], patternInput_5[50], patternInput_5[51], patternInput_5[52], patternInput_5[53], patternInput_5[54], patternInput_5[55], patternInput_5[56], patternInput_5[57], patternInput_5[58], patternInput_5[59], patternInput_5[60], patternInput_5[61], patternInput_5[62], patternInput_5[63], patternInput_5[64], patternInput_5[65], patternInput_5[66], patternInput_5[67], patternInput_5[68], patternInput_5[69]));
    const v711: () => any[] = (): any[] => closure36(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v595, v594, v609, v608, v613, v612, v0_1, void 0);
    v710.children = v711;
    const v712: (arg0: any) => any = v623;
    const v714: any = createComponent;
    return v714(v712, v710);
}

export function closure29(unitVar: void, v0_1: Mut6): any {
    return method13(v0_1);
}

export function closure27(v0_1: Mut4, v1_1: () => boolean, v2: () => any[], unitVar: void): any[] {
    let v19: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v20: Mut6, v23: any, v24: (arg0: Mut6) => any, v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v8: Mut6, v11: any, v12: (arg0: Mut6) => any;
    const v3: US15 = v0_1.l3;
    return [(v3.tag === US15_Tag.US15_1) ? (v1_1() ? ((v19 = ((arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure28(v2, arg10$0040_1)), (v20 = (new Mut6(true, false, v0_1.l0, v0_1.l1, v19)), (v23 = createComponent, (v24 = ((v_1: Mut6): any => closure29(void 0, v_1)), v23(v24, v20)))))) : (void 0)) : ((v3.tag === US15_Tag.US15_2) ? v2 : (v1_1() ? ((v7 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure28(v2, arg10$0040)), (v8 = (new Mut6(true, false, v0_1.l0, v0_1.l1, v7)), (v11 = createComponent, (v12 = ((v: Mut6): any => closure29(void 0, v)), v11(v12, v8)))))) : (void 0)))];
}

export function closure17(v0_1: Mut4, v1_1: US6, v2: US6, v3: US6, v4: US7, v5: US6, v6: US6, v7: US6, v8: US6, v9: US6, v10: US6, v11: US8, v12: US9, v13: US6, v14: US6, v15: US8, v16: US10, v17: US6, v18: US6, v19: US6, v20: US11, v21: US8, v22: US6, v23: US6, v24: US6, v25: US6, v26: US6, v27: US6, v28: US12, v29: US6, v30: US6, v31: US6, v32: US12, v33: US6, v34: US6, v35: US6, v36: US6, v37: US6, v38: US6, v39: US6, v40: US6, v41: US6, v42: US6, v43: US13, v44: US14, v45: US13, v46: US6, v47: US6, v48: US6, v49: US6, v50: US6, v51: US6, v52: US6, v53: US6, v54: US6, v55: US6, v56: US6, v57: US6, v58: US6, v59: US6, v60: US6, v61: US6, v62: US6, v63: US12, v64: US6, v65: US6, v66: US10, v67: US10, v68: US6, v69: US5, v70: US6, v71: (arg0: boolean) => void, v72_1: () => boolean, unitVar: void): any[] {
    let v74_1: any, v77_1: any, patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v89: US9, v157: string, v160: string, v163: string, v171: string, v179: US9, v176: any, v194: string, v200: any, v201: () => any[], v202: (arg0: any) => any, v205_1: any, v306: () => any[], v309: any, patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v321: US9, v382: string, v385: string, v388: string, v391: string, v394: string, v402: US9, v399: any, v406: string, v430: any, v431: () => any[], v432: (arg0: any) => any, v435: any, v210_1: any, patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v222: US9, v288: US9, v285: any, v292: string, v299: any, v300: () => any[], v301: (arg0: any) => any, v304: any;
    return [(v63.tag === US12_Tag.US12_1) ? ((v74_1 = v63.fields[0], (v77_1 = Td, (patternInput = method3(), (v89 = patternInput[11], (v157 = (((v0_1.l3.tag === US15_Tag.US15_2) ? true : v72_1()) ? method12("0px !important", void 0) : "0px !important"), (v160 = ((v25.tag === US6_Tag.US6_1) ? v25.fields[0] : "$sm"), (v163 = ((v53.tag === US6_Tag.US6_1) ? v53.fields[0] : "0"), (v171 = method12((v52.tag === US6_Tag.US6_1) ? (("0" === v52.fields[0]) ? "0" : "15px") : "15px", v163), (v179 = ((v89.tag === US9_Tag.US9_1) ? ((v176 = children_1, US9_US9_1(v176(v89.fields[0])))) : US9_US9_0()), (v194 = "0", (v200 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], US6_US6_1(v157), US6_US6_1("$neutral5"), patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v179.tag === US9_Tag.US9_1) ? v179.fields[0] : ((): any[] => closure18(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v74_1, void 0))), US6_US6_1("$neutral11"), patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], patternInput[21], US6_US6_1("column"), patternInput[23], US6_US6_1(v160), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], US6_US6_1(v194), US6_US6_1(v194), US6_US6_1(v171), US6_US6_1(v194), patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69])), (v201 = ((): any[] => closure18(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v74_1, void 0)), (v200.children = v201, (v202 = (v77_1), (v205_1 = createComponent, v205_1(v202, v200))))))))))))))))) : (void 0), (v12.tag === US9_Tag.US9_1) ? ((v306 = v12.fields[0], (v309 = Td, (patternInput_2 = method3(), (v321 = patternInput_2[11], (v382 = ((v25.tag === US6_Tag.US6_1) ? v25.fields[0] : "$sm"), (v385 = ((v30.tag === US6_Tag.US6_1) ? v30.fields[0] : "center"), (v388 = ((v36.tag === US6_Tag.US6_1) ? v36.fields[0] : "0"), (v391 = ((v35.tag === US6_Tag.US6_1) ? v35.fields[0] : "0"), (v394 = ((v50.tag === US6_Tag.US6_1) ? v50.fields[0] : "0"), (v402 = ((v321.tag === US9_Tag.US9_1) ? ((v399 = children_1, US9_US9_1(v399(v321.fields[0])))) : US9_US9_0()), (v406 = "0", (v430 = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], US6_US6_1(v406), patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v402.tag === US9_Tag.US9_1) ? v402.fields[0] : ((): any[] => closure27(v0_1, v72_1, v306, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US6_US6_1("flex"), patternInput_2[19], patternInput_2[20], US6_US6_1("6"), US6_US6_1("column"), patternInput_2[23], US6_US6_1(v382), patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], US6_US6_1(v385), patternInput_2[30], patternInput_2[31], US6_US6_1("$base"), patternInput_2[33], US6_US6_1(v391), US6_US6_1(v388), US6_US6_1(v406), US6_US6_1(v406), US6_US6_1("85vh"), patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], US6_US6_1(v406), US6_US6_1("auto"), patternInput_2[47], patternInput_2[48], US6_US6_1(v394), patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69])), (v431 = ((): any[] => closure27(v0_1, v72_1, v306, void 0)), (v430.children = v431, (v432 = (v309), (v435 = createComponent, v435(v432, v430)))))))))))))))))) : ((v210_1 = Td, (patternInput_1 = method3(), (v222 = patternInput_1[11], (v288 = ((v222.tag === US9_Tag.US9_1) ? ((v285 = children_1, US9_US9_1(v285(v222.fields[0])))) : US9_US9_0()), (v292 = "0", (v299 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], US6_US6_1(v292), patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v288.tag === US9_Tag.US9_1) ? v288.fields[0] : ((): any[] => closure26(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], US6_US6_1("9px"), patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], US6_US6_1(v292), patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69])), (v300 = ((): any[] => closure26(void 0, void 0)), (v299.children = v300, (v301 = (v210_1), (v304 = createComponent, v304(v301, v299))))))))))))];
}

export function method11(v0_1: Mut4): any {
    const v1_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v0_1.l2;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]]);
    const v99: US12 = patternInput_1[27];
    const v98: US6 = patternInput_1[26];
    const v97: US6 = patternInput_1[25];
    const v96: US6 = patternInput_1[24];
    const v95: US6 = patternInput_1[23];
    const v94: US6 = patternInput_1[22];
    const v93: US6 = patternInput_1[21];
    const v92: US8 = patternInput_1[20];
    const v91: US11 = patternInput_1[19];
    const v90: US6 = patternInput_1[18];
    const v89: US6 = patternInput_1[17];
    const v88: US6 = patternInput_1[16];
    const v87: US10 = patternInput_1[15];
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
    const v138: US10 = patternInput_1[66];
    const v137: US10 = patternInput_1[65];
    const v136: US6 = patternInput_1[64];
    const v135: US6 = patternInput_1[63];
    const v134: US12 = patternInput_1[62];
    const v133: US6 = patternInput_1[61];
    const v132: US6 = patternInput_1[60];
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
    const v116: US13 = patternInput_1[44];
    const v115: US14 = patternInput_1[43];
    const v114: US13 = patternInput_1[42];
    const v113: US6 = patternInput_1[41];
    const v112: US6 = patternInput_1[40];
    const v111: US6 = patternInput_1[39];
    const v110: US6 = patternInput_1[38];
    const v109: US6 = patternInput_1[37];
    const v108: US6 = patternInput_1[36];
    const v107: US6 = patternInput_1[35];
    const v106: US6 = patternInput_1[34];
    const v105: US6 = patternInput_1[33];
    const v104: US6 = patternInput_1[32];
    const v103: US12 = patternInput_1[31];
    const v102: US6 = patternInput_1[30];
    const v101: US6 = patternInput_1[29];
    const v100: US6 = patternInput_1[28];
    let v149: US9;
    if (v83.tag === US9_Tag.US9_1) {
        const v146: any = children_1;
        v149 = US9_US9_1(v146(v83.fields[0]));
    }
    else {
        v149 = US9_US9_0();
    }
    const v153: boolean = (v0_1.l3.tag === US15_Tag.US15_0) !== true;
    const v156: any = createSignal;
    const v157: any[] = v156(v153);
    let v158: () => boolean;
    const value_2: any = v157[0];
    v158 = (value_2);
    let v159: (arg0: boolean) => void;
    const value_3: any = v157[1];
    v159 = ((arg_1: boolean): void => {
        value_3(arg_1);
    });
    const v162: any = Tr;
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v174: US9 = patternInput_2[11];
    const v235: string = method12("row", "column");
    let v242: US9;
    if (v174.tag === US9_Tag.US9_1) {
        const v239: any = children_1;
        v242 = US9_US9_1(v239(v174.fields[0]));
    }
    else {
        v242 = US9_US9_0();
    }
    const v257: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], US6_US6_1("$neutral5"), US6_US6_1("1px 1px"), patternInput_2[9], patternInput_2[10], US9_US9_1((v242.tag === US9_Tag.US9_1) ? v242.fields[0] : ((): any[] => closure17(v0_1, v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v159, v158, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US6_US6_1("flex"), patternInput_2[19], patternInput_2[20], US6_US6_1("1"), US6_US6_1(v235), patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], v100, patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    const v258: () => any[] = (): any[] => closure17(v0_1, v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v159, v158, void 0);
    v257.children = v258;
    const v259: (arg0: any) => any = v162;
    const v261: any = createComponent;
    return v261(v259, v257);
}

export function closure16(unitVar: void, v0_1: Mut4): any {
    return method11(v0_1);
}

export function closure61(unitVar: void, v0_1: string): any {
    return v0_1;
}

export function closure62(unitVar: void, unitVar_1: void): [() => string, (arg0: string) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[4], patternInput[5]];
}

export function closure66(v0_1: Mut8, v1_1: () => string, unitVar: void): any[] {
    const v2: string = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure65(v0_1: Mut8, v1_1: () => string, unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure66(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure66(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure64(v0_1: Mut8, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure65(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method22(v0_1: Mut8): any {
    const patternInput: [() => string, (arg0: string) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure64(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure63(unitVar: void, v0_1: Mut8): any {
    return method22(v0_1);
}

export function closure67(unitVar: void, unitVar_1: void): [() => string, (arg0: string) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[6], patternInput[7]];
}

export function closure68(unitVar: void, v0_1: int32): any {
    return v0_1;
}

export function closure69(unitVar: void, unitVar_1: void): [() => int32, (arg0: int32) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[2], patternInput[3]];
}

export function closure73(v0_1: Mut9, v1_1: () => int32, unitVar: void): any[] {
    const v2: int32 = v1_1() | 0;
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure72(v0_1: Mut9, v1_1: () => int32, unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure73(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure73(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure71(v0_1: Mut9, v1_1: () => int32, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure72(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method23(v0_1: Mut9): any {
    const patternInput: [() => int32, (arg0: int32) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure71(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure70(unitVar: void, v0_1: Mut9): any {
    return method23(v0_1);
}

export function closure74(unitVar: void, v0_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): any {
    const v1_1: int32 = v0_1.length | 0;
    const v2: [US0, string, string, string][] = fill(new Array(v1_1), 0, v1_1, null);
    const v3: Mut3 = new Mut3(0);
    while (method5(v1_1, v3)) {
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

export function closure75(unitVar: void, unitVar_1: void): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[0], patternInput[1]];
}

export function closure79(v0_1: Mut10, v1_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], unitVar: void): any[] {
    const v2: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure78(v0_1: Mut10, v1_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure79(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure79(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure77(v0_1: Mut10, v1_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure78(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method24(v0_1: Mut10): any {
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure77(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure76(unitVar: void, v0_1: Mut10): any {
    return method24(v0_1);
}

export function closure80(unitVar: void, v0_1: [US2, any, string][]): any {
    return v0_1;
}

export function closure81(unitVar: void, unitVar_1: void): [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[10], patternInput[11]];
}

export function closure85(v0_1: Mut11, v1_1: () => [US2, any, string][], unitVar: void): any[] {
    const v2: [US2, any, string][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure84(v0_1: Mut11, v1_1: () => [US2, any, string][], unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure85(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure85(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure83(v0_1: Mut11, v1_1: () => [US2, any, string][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure84(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method25(v0_1: Mut11): any {
    const patternInput: [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure83(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure82(unitVar: void, v0_1: Mut11): any {
    return method25(v0_1);
}

export function closure86(unitVar: void, v0_1: [US2[], int32, US3, string, string][]): any {
    return v0_1;
}

export function closure87(unitVar: void, unitVar_1: void): [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[8], patternInput[9]];
}

export function closure91(v0_1: Mut12, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure90(v0_1: Mut12, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure91(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure91(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure89(v0_1: Mut12, v1_1: () => [US2[], int32, US3, string, string][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure90(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method26(v0_1: Mut12): any {
    const patternInput: [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure89(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure88(unitVar: void, v0_1: Mut12): any {
    return method26(v0_1);
}

export function closure92(unitVar: void, v0_1: US4): any {
    return (v0_1.tag === US4_Tag.US4_1) ? "Error" : ((v0_1.tag === US4_Tag.US4_2) ? "Info" : ((v0_1.tag === US4_Tag.US4_3) ? "Warn" : "Debug"));
}

export function closure93(unitVar: void, unitVar_1: void): [() => US4, (arg0: US4) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[18], patternInput[19]];
}

export function closure97(v0_1: Mut13, v1_1: () => US4, unitVar: void): any[] {
    const v2: US4 = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure96(v0_1: Mut13, v1_1: () => US4, unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure97(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure97(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure95(v0_1: Mut13, v1_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure96(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method27(v0_1: Mut13): any {
    const patternInput: [() => US4, (arg0: US4) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure95(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure94(unitVar: void, v0_1: Mut13): any {
    return method27(v0_1);
}

export function closure98(unitVar: void, v0_1: US5): any {
    return v0_1;
}

export function closure99(unitVar: void, unitVar_1: void): [() => US5, (arg0: US5) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[20], patternInput[21]];
}

export function closure103(v0_1: Mut14, v1_1: () => US5, unitVar: void): any[] {
    const v2: US5 = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure102(v0_1: Mut14, v1_1: () => US5, unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure103(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure103(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure101(v0_1: Mut14, v1_1: () => US5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure102(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method28(v0_1: Mut14): any {
    const patternInput: [() => US5, (arg0: US5) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure101(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure100(unitVar: void, v0_1: Mut14): any {
    return method28(v0_1);
}

export function closure104(unitVar: void, v0_1: [int64, int32][]): any {
    return v0_1;
}

export function closure105(unitVar: void, unitVar_1: void): [() => [int64, int32][], (arg0: [int64, int32][]) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[16], patternInput[17]];
}

export function closure109(v0_1: Mut15, v1_1: () => [int64, int32][], unitVar: void): any[] {
    const v2: [int64, int32][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure108(v0_1: Mut15, v1_1: () => [int64, int32][], unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure109(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure109(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure107(v0_1: Mut15, v1_1: () => [int64, int32][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure108(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method29(v0_1: Mut15): any {
    const patternInput: [() => [int64, int32][], (arg0: [int64, int32][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure107(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure106(unitVar: void, v0_1: Mut15): any {
    return method29(v0_1);
}

export function closure110(unitVar: void, v0_1: [int64, any][]): any {
    return v0_1;
}

export function closure111(unitVar: void, unitVar_1: void): [() => [int64, any][], (arg0: [int64, any][]) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[14], patternInput[15]];
}

export function closure115(v0_1: Mut16, v1_1: () => [int64, any][], unitVar: void): any[] {
    const v2: [int64, any][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure114(v0_1: Mut16, v1_1: () => [int64, any][], unitVar: void): any[] {
    const v4: any = hope;
    const v5: any = v4.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v17: US9 = patternInput[11];
    let v83: US9;
    if (v17.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v17.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure115(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure115(v0_1, v1_1, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v5;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure113(v0_1: Mut16, v1_1: () => [int64, any][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure114(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method30(v0_1: Mut16): any {
    const patternInput: [() => [int64, any][], (arg0: [int64, any][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure113(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure112(unitVar: void, v0_1: Mut16): any {
    return method30(v0_1);
}

export function closure116(unitVar: void, unitVar_1: void): [() => [int64, any][], (arg0: [int64, any][]) => void] {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    return [patternInput[12], patternInput[13]];
}

export function closure60(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: string) => any = (v: string): any => closure61(void 0, v);
    const v1_1: () => [() => string, (arg0: string) => void] = (): [() => string, (arg0: string) => void] => closure62(void 0, void 0);
    const v3: Mut8 = new Mut8(v0_1, v1_1, "chain.token");
    const v6: any = createComponent;
    const v7: (arg0: Mut8) => any = (v_1: Mut8): any => closure63(void 0, v_1);
    const v9: () => [() => string, (arg0: string) => void] = (): [() => string, (arg0: string) => void] => closure67(void 0, void 0);
    const v11: Mut8 = new Mut8(v0_1, v9, "chain.url");
    const v12: any = createComponent;
    const v14: (arg0: int32) => any = (v_2: int32): any => closure68(void 0, v_2);
    const v15: () => [() => int32, (arg0: int32) => void] = (): [() => int32, (arg0: int32) => void] => closure69(void 0, void 0);
    const v17: Mut9 = new Mut9(v14, v15, "chain.port");
    const v18: any = createComponent;
    const v19: (arg0: Mut9) => any = (v_3: Mut9): any => closure70(void 0, v_3);
    const v21: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => any = (v_4: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): any => closure74(void 0, v_4);
    const v22: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] = (): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void] => closure75(void 0, void 0);
    const v24: Mut10 = new Mut10(v21, v22, "chain.accounts");
    const v25: any = createComponent;
    const v26: (arg0: Mut10) => any = (v_5: Mut10): any => closure76(void 0, v_5);
    const v28: (arg0: [US2, any, string][]) => any = (v_6: [US2, any, string][]): any => closure80(void 0, v_6);
    const v29: () => [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] = (): [() => [US2, any, string][], (arg0: [US2, any, string][]) => void] => closure81(void 0, void 0);
    const v31: Mut11 = new Mut11(v28, v29, "db.connections");
    const v32: any = createComponent;
    const v33: (arg0: Mut11) => any = (v_7: Mut11): any => closure82(void 0, v_7);
    const v35: (arg0: [US2[], int32, US3, string, string][]) => any = (v_8: [US2[], int32, US3, string, string][]): any => closure86(void 0, v_8);
    const v36: () => [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] = (): [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] => closure87(void 0, void 0);
    const v38: Mut12 = new Mut12(v35, v36, "db.connection_options");
    const v39: any = createComponent;
    const v40: (arg0: Mut12) => any = (v_9: Mut12): any => closure88(void 0, v_9);
    const v42: (arg0: US4) => any = (v_10: US4): any => closure92(void 0, v_10);
    const v43: () => [() => US4, (arg0: US4) => void] = (): [() => US4, (arg0: US4) => void] => closure93(void 0, void 0);
    const v45: Mut13 = new Mut13(v42, v43, "settings.log_level");
    const v46: any = createComponent;
    const v47: (arg0: Mut13) => any = (v_11: Mut13): any => closure94(void 0, v_11);
    const v49: (arg0: US5) => any = (v_12: US5): any => closure98(void 0, v_12);
    const v50: () => [() => US5, (arg0: US5) => void] = (): [() => US5, (arg0: US5) => void] => closure99(void 0, void 0);
    const v52: Mut14 = new Mut14(v49, v50, "settings.ui.modal");
    const v53: any = createComponent;
    const v54: (arg0: Mut14) => any = (v_13: Mut14): any => closure100(void 0, v_13);
    const v56: (arg0: [int64, int32][]) => any = (v_14: [int64, int32][]): any => closure104(void 0, v_14);
    const v57: () => [() => [int64, int32][], (arg0: [int64, int32][]) => void] = (): [() => [int64, int32][], (arg0: [int64, int32][]) => void] => closure105(void 0, void 0);
    const v59: Mut15 = new Mut15(v56, v57, "profile.tmp.counter");
    const v60: any = createComponent;
    const v61: (arg0: Mut15) => any = (v_15: Mut15): any => closure106(void 0, v_15);
    const v63: (arg0: [int64, any][]) => any = (v_16: [int64, any][]): any => closure110(void 0, v_16);
    const v64: () => [() => [int64, any][], (arg0: [int64, any][]) => void] = (): [() => [int64, any][], (arg0: [int64, any][]) => void] => closure111(void 0, void 0);
    const v66: Mut16 = new Mut16(v63, v64, "profile.tmp.chain_status");
    const v67: any = createComponent;
    const v68: (arg0: Mut16) => any = (v_17: Mut16): any => closure112(void 0, v_17);
    const v70: () => [() => [int64, any][], (arg0: [int64, any][]) => void] = (): [() => [int64, any][], (arg0: [int64, any][]) => void] => closure116(void 0, void 0);
    const v72_1: Mut16 = new Mut16(v63, v70, "profile.tmp.chain_deploy");
    const v73_1: any = createComponent;
    return [v6(v7, v3), v12(v7, v11), v18(v19, v17), v25(v26, v24), v32(v33, v31), v39(v40, v38), v46(v47, v45), v53(v54, v52), v60(v61, v59), v67(v68, v66), v73_1(v68, v72_1)];
}

export function closure59(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v3: any = v2.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    let v81: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v78: any = children_1;
        v81 = US9_US9_1(v78(v15.fields[0]));
    }
    else {
        v81 = US9_US9_0();
    }
    const v89: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v81.tag === US9_Tag.US9_1) ? v81.fields[0] : ((): any[] => closure60(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], US6_US6_1("8px"), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v90: () => any[] = (): any[] => closure60(void 0, void 0);
    v89.children = v90;
    const v91: (arg0: any) => any = v3;
    const v94: any = createComponent;
    return [v94(v91, v89)];
}

export function closure58(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure59(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], US6_US6_1("flex-start"), _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        State
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure7(v0_1: (arg0: US4) => void, v1_1: () => US4, unitVar: void): any[] {
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure8(v0_1, v1_1, arg10$0040);
    const v6: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v4, US15_US15_2());
    const v9: any = createComponent;
    const v10: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v14: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure58(void 0, arg10$0040_1);
    const v16: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v14, US15_US15_2());
    const v17: any = createComponent;
    return [v9(v10, v6), v17(v10, v16)];
}

export function closure119(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure118(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = Tbody;
    const v4: US9 = v0_1.l11;
    const v7: () => any[] = (v4.tag === US9_Tag.US9_1) ? v4.fields[0] : ((): any[] => closure119(void 0, void 0));
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v19: US9 = patternInput[11];
    let v85: US9;
    if (v19.tag === US9_Tag.US9_1) {
        const v82: any = children_1;
        v85 = US9_US9_1(v82(v19.fields[0]));
    }
    else {
        v85 = US9_US9_0();
    }
    const v98: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], US6_US6_1("$blackAlpha7"), patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v85.tag === US9_Tag.US9_1) ? v85.fields[0] : v7), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], patternInput[21], US6_US6_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], US6_US6_1("-1px"), patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    v98.children = v7;
    const v99: (arg0: any) => any = v3;
    const v102: any = createComponent;
    return [v102(v99, v98)];
}

export function method31(v0_1: Mut1): any {
    const v3: any = Table;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    const v74_1: US6 = v0_1.l47;
    const v77_1: string = (v74_1.tag === US6_Tag.US6_1) ? v74_1.fields[0] : "hidden";
    const v78: US6 = v0_1.l48;
    const v81: string = (v78.tag === US6_Tag.US6_1) ? v78.fields[0] : "hidden";
    let v89: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v86: any = children_1;
        v89 = US9_US9_1(v86(v15.fields[0]));
    }
    else {
        v89 = US9_US9_0();
    }
    const v103: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v89.tag === US9_Tag.US9_1) ? v89.fields[0] : ((): any[] => closure118(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], US6_US6_1("1"), US6_US6_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US6_US6_1(v77_1), US6_US6_1(v81), patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v104: () => any[] = (): any[] => closure118(v0_1, void 0);
    v103.children = v104;
    const v105: (arg0: any) => any = v3;
    const v108: any = createComponent;
    return v108(v105, v103);
}

export function closure117(unitVar: void, v0_1: Mut1): any {
    return method31(v0_1);
}

export function closure6(v0_1: (arg0: US4) => void, v1_1: () => US4, unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v13: US9 = patternInput[11];
    let v79: US9;
    if (v13.tag === US9_Tag.US9_1) {
        const v76_1: any = children_1;
        v79 = US9_US9_1(v76_1(v13.fields[0]));
    }
    else {
        v79 = US9_US9_0();
    }
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v79.tag === US9_Tag.US9_1) ? v79.fields[0] : ((): any[] => closure7(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure7(v0_1, v1_1, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return [v88(v89, v84)];
}

export function closure5(v0_1: (arg0: US4) => void, v1_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure6(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], US6_US6_1("flex-start"), _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], US6_US6_1("15px"), _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Debug
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure4(v0_1: (arg0: US4) => void, v1_1: () => US4, unitVar: void): any[] {
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure5(v0_1, v1_1, arg10$0040);
    const v6: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v4, US15_US15_0());
    const v9: any = createComponent;
    const v10: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v9(v10, v6)];
}

export function closure3(v0_1: (arg0: US4) => void, v1_1: () => US4, unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v13: US9 = patternInput[11];
    let v79: US9;
    if (v13.tag === US9_Tag.US9_1) {
        const v76_1: any = children_1;
        v79 = US9_US9_1(v76_1(v13.fields[0]));
    }
    else {
        v79 = US9_US9_0();
    }
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v79.tag === US9_Tag.US9_1) ? v79.fields[0] : ((): any[] => closure4(v0_1, v1_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure4(v0_1, v1_1, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return [v88(v89, v84)];
}

export function method4(): any {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    const v148: (arg0: US4) => void = patternInput[19];
    const v147: () => US4 = patternInput[18];
    const v153: any = Box;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v165: US9 = patternInput_1[11];
    let v230: US9;
    if (v165.tag === US9_Tag.US9_1) {
        const v227: any = children_1;
        v230 = US9_US9_1(v227(v165.fields[0]));
    }
    else {
        v230 = US9_US9_0();
    }
    const v236: string = "0";
    const v255: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], US6_US6_1("$blackAlpha12"), patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], US6_US6_1(v236), patternInput_1[10], US9_US9_1((v230.tag === US9_Tag.US9_1) ? v230.fields[0] : ((): any[] => closure3(v148, v147, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US6_US6_1("flex"), patternInput_1[19], patternInput_1[20], patternInput_1[21], US6_US6_1("column"), patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], US6_US6_1("80vh"), US6_US6_1("50vw"), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], US6_US6_1("auto"), patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], US6_US6_1("absolute"), US6_US6_1(v236), patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], US5_US5_1(2), patternInput_1[69]));
    const v256: () => any[] = (): any[] => closure3(v148, v147, void 0);
    v255.children = v256;
    const v257: (arg0: any) => any = v153;
    const v259: any = createComponent;
    return v259(v257, v255);
}

export function closure2(unitVar: void, v0_1: Mut2): any {
    return method4();
}

export function closure123(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure128(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure131(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: US6 = v0_1.l26;
    return [<>
        {(v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : ""}
    </>];
}

export function closure132(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], US6_US6_1("-13px"), _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure133(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularLinkExternal;
    return v2;
}

export function closure130(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = Anchor;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67, v0_1.l68, v0_1.l69];
    const v146: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], US8_US8_1(true), patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    method20(v146, new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = [v146.l0, v146.l1, v146.l2, v146.l3, v146.l4, v146.l5, v146.l6, v146.l7, v146.l8, v146.l9, v146.l10, v146.l11, v146.l12, v146.l13, v146.l14, v146.l15, v146.l16, v146.l17, v146.l18, v146.l19, v146.l20, v146.l21, v146.l22, v146.l23, v146.l24, v146.l25, v146.l26, v146.l27, v146.l28, v146.l29, v146.l30, v146.l31, v146.l32, v146.l33, v146.l34, v146.l35, v146.l36, v146.l37, v146.l38, v146.l39, v146.l40, v146.l41, v146.l42, v146.l43, v146.l44, v146.l45, v146.l46, v146.l47, v146.l48, v146.l49, v146.l50, v146.l51, v146.l52, v146.l53, v146.l54, v146.l55, v146.l56, v146.l57, v146.l58, v146.l59, v146.l60, v146.l61, v146.l62, v146.l63, v146.l64, v146.l65, v146.l66, v146.l67, v146.l68, v146.l69];
    const v158: US9 = patternInput_2[11];
    let v224: US9;
    if (v158.tag === US9_Tag.US9_1) {
        const v221: any = children_1;
        v224 = US9_US9_1(v221(v158.fields[0]));
    }
    else {
        v224 = US9_US9_0();
    }
    const v230: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v224.tag === US9_Tag.US9_1) ? v224.fields[0] : ((): any[] => closure131(v0_1, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    const v231: () => any[] = (): any[] => closure131(v0_1, void 0);
    v230.children = v231;
    const v232: (arg0: any) => any = v3;
    const v235: any = createComponent;
    const v240: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure132(void 0, arg10$0040_2);
    const v241: () => any = (): any => closure133(void 0, void 0);
    const v242: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v243: Mut7 = new Mut7(v240, v241, v242);
    const v244: any = createComponent;
    const v245: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    return [v235(v232, v230), <>
        &nbsp;
    </>, v244(v245, v243)];
}

export function method33(v0_1: Mut1): any {
    const v3: any = Box;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    let v81: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v78: any = children_1;
        v81 = US9_US9_1(v78(v15.fields[0]));
    }
    else {
        v81 = US9_US9_0();
    }
    const v87: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v81.tag === US9_Tag.US9_1) ? v81.fields[0] : ((): any[] => closure130(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v88: () => any[] = (): any[] => closure130(v0_1, void 0);
    v87.children = v88;
    const v89: (arg0: any) => any = v3;
    const v92: any = createComponent;
    return v92(v89, v87);
}

export function closure129(unitVar: void, v0_1: Mut1): any {
    return method33(v0_1);
}

export function closure127(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure128(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1("https://github.com/fc1943s/tictactoe_spiral"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure128(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure129(void 0, v);
    return [v88(v89, v84)];
}

export function closure126(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure127(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure135(v0_1: string, unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v12: US9 = patternInput[11];
    let v78: US9;
    if (v12.tag === US9_Tag.US9_1) {
        const v75_1: any = children_1;
        v78 = US9_US9_1(v75_1(v12.fields[0]));
    }
    else {
        v78 = US9_US9_0();
    }
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure128(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1(v0_1), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure128(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure129(void 0, v);
    return [v88(v89, v84)];
}

export function closure134(v0_1: string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v71: () => any[] = (): any[] => closure135(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v71), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure137(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure128(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1("https://fc1943s.github.io/tictactoe_spiral"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure128(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure129(void 0, v);
    return [v88(v89, v84)];
}

export function closure136(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure137(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure139(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure128(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1("https://fc1943s.github.io/tictactoe_spiral/docs"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure128(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure129(void 0, v);
    return [v88(v89, v84)];
}

export function closure138(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure139(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure125(v0_1: string, unitVar: void): any[] {
    let v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v6: Mut4, v9: any, v10: (arg0: Mut4) => any, v15: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v17: Mut4, v20: any, v21: (arg0: Mut4) => any;
    const v26: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure136(void 0, arg10$0040_2);
    const v28: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v26, US15_US15_2());
    const v31: any = createComponent;
    const v32: (arg0: Mut4) => any = (v_2: Mut4): any => closure16(void 0, v_2);
    const v36: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure138(void 0, arg10$0040_3);
    const v38: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v36, US15_US15_2());
    const v39: any = createComponent;
    return [("" === v0_1) ? ((v4 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure126(void 0, arg10$0040)), (v6 = (new Mut4(US14_US14_0(), US14_US14_0(), v4, US15_US15_2())), (v9 = createComponent, (v10 = ((v: Mut4): any => closure16(void 0, v)), v9(v10, v6)))))) : ((v15 = ((arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure134(`https://github.com/fc1943s/tictactoe_spiral/tree/${v0_1}`, arg10$0040_1)), (v17 = (new Mut4(US14_US14_0(), US14_US14_0(), v15, US15_US15_2())), (v20 = createComponent, (v21 = ((v_1: Mut4): any => closure16(void 0, v_1)), v20(v21, v17)))))), v31(v32, v28), v39(v32, v38)];
}

export function method32(): any {
    const v3: string = method2()[3];
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v16: US9 = patternInput_1[11];
    let v82: US9;
    if (v16.tag === US9_Tag.US9_1) {
        const v79: any = children_1;
        v82 = US9_US9_1(v79(v16.fields[0]));
    }
    else {
        v82 = US9_US9_0();
    }
    const v87: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure125(v3, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v88: () => any[] = (): any[] => closure125(v3, void 0);
    v87.children = v88;
    const v91: any = createComponent;
    const v92: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return v91(v92, v87);
}

export function closure124(unitVar: void, v0_1: Mut1): any {
    return method32();
}

export function closure122(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure123(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure123(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure124(void 0, v);
    return [v86(v87, v82)];
}

export function closure121(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure122(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Links
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure142(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method35(): [() => string, () => void] {
    const v2: any = useColorMode;
    const v3: any = v2();
    return [v3.colorMode, v3.toggleColorMode];
}

export function closure149(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Dark
    </>];
}

export function closure150(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Light
    </>];
}

export function closure148(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Radio;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v14: US9 = patternInput[11];
    let v82: US9;
    if (v14.tag === US9_Tag.US9_1) {
        const v79: any = children_1;
        v82 = US9_US9_1(v79(v14.fields[0]));
    }
    else {
        v82 = US9_US9_0();
    }
    const v87: string = "neutral";
    const v89: string = "sm";
    const v93: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure149(void 0, void 0))), patternInput[12], US6_US6_1(v87), patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1(v89), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], US10_US10_1("dark"), patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v94: () => any[] = (): any[] => closure149(void 0, void 0);
    v93.children = v94;
    const v95: (arg0: any) => any = v2;
    const v98: any = createComponent;
    const v99: any = v98(v95, v93);
    const v100: any = Radio;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v112: US9 = patternInput_1[11];
    let v179: US9;
    if (v112.tag === US9_Tag.US9_1) {
        const v176: any = children_1;
        v179 = US9_US9_1(v176(v112.fields[0]));
    }
    else {
        v179 = US9_US9_0();
    }
    const v188: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v179.tag === US9_Tag.US9_1) ? v179.fields[0] : ((): any[] => closure150(void 0, void 0))), patternInput_1[12], US6_US6_1(v87), patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], US6_US6_1(v89), patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], US10_US10_1("light"), patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    const v189: () => any[] = (): any[] => closure150(void 0, void 0);
    v188.children = v189;
    const v190: (arg0: any) => any = v100;
    const v191: any = createComponent;
    return [v99, v191(v190, v188)];
}

export function closure147(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v14: US9 = patternInput[11];
    let v80: US9;
    if (v14.tag === US9_Tag.US9_1) {
        const v77_1: any = children_1;
        v80 = US9_US9_1(v77_1(v14.fields[0]));
    }
    else {
        v80 = US9_US9_0();
    }
    const v90: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v80.tag === US9_Tag.US9_1) ? v80.fields[0] : ((): any[] => closure148(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1("row"), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("$4"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v91: () => any[] = (): any[] => closure148(void 0, void 0);
    v90.children = v91;
    const v92: (arg0: any) => any = v2;
    const v95: any = createComponent;
    return [v95(v92, v90)];
}

export function closure151(v0_1: () => void, v1_1: any): void {
    v0_1();
}

export function closure146(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: any = RadioGroup;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v16: US9 = patternInput[11];
    const v75_1: string = v1_1();
    let v83: US9;
    if (v16.tag === US9_Tag.US9_1) {
        const v80: any = children_1;
        v83 = US9_US9_1(v80(v16.fields[0]));
    }
    else {
        v83 = US9_US9_0();
    }
    const v89: (arg0: any) => void = (v: any): void => {
        closure151(v0_1, v);
    };
    const v92: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure147(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], US6_US6_1(v75_1), patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], US13_US13_1(v89), patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v93: () => any[] = (): any[] => closure147(void 0, void 0);
    v92.children = v93;
    const v94: (arg0: any) => any = v4;
    const v97: any = createComponent;
    return [v97(v94, v92)];
}

export function closure145(v0_1: () => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure146(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("5px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Theme
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure144(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure145(v0_1, v1_1, arg10$0040);
    const v6: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v4, US15_US15_2());
    const v9: any = createComponent;
    const v10: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v9(v10, v6)];
}

export function method34(): any {
    const patternInput: [() => string, () => void] = method35();
    const v1_1: () => void = patternInput[1];
    const v0_1: () => string = patternInput[0];
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v13: US9 = patternInput_1[11];
    let v79: US9;
    if (v13.tag === US9_Tag.US9_1) {
        const v76_1: any = children_1;
        v79 = US9_US9_1(v76_1(v13.fields[0]));
    }
    else {
        v79 = US9_US9_0();
    }
    const v84: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v79.tag === US9_Tag.US9_1) ? v79.fields[0] : ((): any[] => closure144(v1_1, v0_1, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v85: () => any[] = (): any[] => closure144(v1_1, v0_1, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return v88(v89, v84);
}

export function closure143(unitVar: void, v0_1: Mut1): any {
    return method34();
}

export function closure141(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure142(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure142(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure143(void 0, v);
    return [v86(v87, v82)];
}

export function closure140(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure141(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Settings
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure154(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure159(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure164(v0_1: () => string, unitVar: void): US6 {
    return US6_US6_1(v0_1());
}

export function closure165(v0_1: (arg0: string) => void, v1_1: US6): void {
    v0_1((v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function closure167(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure168(v0_1: Mut17, v1_1: any): void {
    const v2: string = v1_1.currentTarget.value;
    v0_1.l1(US6_US6_1(v2));
}

export function method38(v0_1: Mut17): any {
    const v3: any = Input;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    const v75_1: US6 = v0_1.l0();
    const v76_1: string = void 0;
    const v78: string = (v75_1.tag === US6_Tag.US6_1) ? v75_1.fields[0] : v76_1;
    let v87: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v84: any = children_1;
        v87 = US9_US9_1(v84(v15.fields[0]));
    }
    else {
        v87 = US9_US9_0();
    }
    const v94: (arg0: any) => void = (v: any): void => {
        closure168(v0_1, v);
    };
    const v102: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v87.tag === US9_Tag.US9_1) ? v87.fields[0] : ((): any[] => closure167(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], US6_US6_1("15vw"), patternInput[42], patternInput[43], US13_US13_1(v94), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1("xs"), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], US6_US6_1("text"), US10_US10_1(v78), patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v103: () => any[] = (): any[] => closure167(void 0, void 0);
    v102.children = v103;
    const v104: (arg0: any) => any = v3;
    const v107: any = createComponent;
    return v107(v104, v102);
}

export function closure166(unitVar: void, v0_1: Mut17): any {
    return method38(v0_1);
}

export function closure163(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: () => US6 = (): US6 => closure164(v1_1, void 0);
    const v3: (arg0: US6) => void = (v: US6): void => {
        closure165(v0_1, v);
    };
    const v4: Mut17 = new Mut17(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut17) => any = (v_1: Mut17): any => closure166(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure162(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure163(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Token
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure170(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: () => US6 = (): US6 => closure164(v1_1, void 0);
    const v3: (arg0: US6) => void = (v: US6): void => {
        closure165(v0_1, v);
    };
    const v4: Mut17 = new Mut17(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut17) => any = (v_1: Mut17): any => closure166(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure169(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure170(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        URL
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure173(v0_1: () => int32, unitVar: void): US5 {
    return US5_US5_1(v0_1());
}

export function closure174(v0_1: (arg0: int32) => void, v1_1: US5): void {
    v0_1((v1_1.tag === US5_Tag.US5_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function closure176(v0_1: Mut18, v1_1: any): void {
    const v2: int32 = v1_1.currentTarget.value | 0;
    v0_1.l1(US5_US5_1(v2));
}

export function method39(v0_1: Mut18): any {
    const v3: any = Input;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    const v75_1: US5 = v0_1.l0();
    const v76_1: int32 = (void 0) | 0;
    const v78: int32 = ((v75_1.tag === US5_Tag.US5_1) ? v75_1.fields[0] : v76_1) | 0;
    let v87: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v84: any = children_1;
        v87 = US9_US9_1(v84(v15.fields[0]));
    }
    else {
        v87 = US9_US9_0();
    }
    const v94: (arg0: any) => void = (v: any): void => {
        closure176(v0_1, v);
    };
    const v102: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v87.tag === US9_Tag.US9_1) ? v87.fields[0] : ((): any[] => closure167(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], US6_US6_1("15vw"), patternInput[42], patternInput[43], US13_US13_1(v94), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1("xs"), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], US6_US6_1("text"), US10_US10_1(v78), patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v103: () => any[] = (): any[] => closure167(void 0, void 0);
    v102.children = v103;
    const v104: (arg0: any) => any = v3;
    const v107: any = createComponent;
    return v107(v104, v102);
}

export function closure175(unitVar: void, v0_1: Mut18): any {
    return method39(v0_1);
}

export function closure172(v0_1: (arg0: int32) => void, v1_1: () => int32, unitVar: void): any[] {
    const v2: () => US5 = (): US5 => closure173(v1_1, void 0);
    const v3: (arg0: US5) => void = (v: US5): void => {
        closure174(v0_1, v);
    };
    const v4: Mut18 = new Mut18(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut18) => any = (v_1: Mut18): any => closure175(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure171(v0_1: (arg0: int32) => void, v1_1: () => int32, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure172(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Port
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure161(v0_1: (arg0: string) => void, v1_1: () => string, v2: (arg0: string) => void, v3: () => string, v4: (arg0: int32) => void, v5: () => int32, unitVar: void): any[] {
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure162(v0_1, v1_1, arg10$0040);
    const v10: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v8, US15_US15_2());
    const v13: any = createComponent;
    const v14: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v18: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure169(v2, v3, arg10$0040_1);
    const v20: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v18, US15_US15_2());
    const v21: any = createComponent;
    const v25: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure171(v4, v5, arg10$0040_2);
    const v27: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v25, US15_US15_2());
    const v28: any = createComponent;
    return [v13(v14, v10), v21(v14, v20), v28(v14, v27)];
}

export function method37(): any {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    const v134: (arg0: string) => void = patternInput[5];
    const v133: () => string = patternInput[4];
    const v274: any = components_spi.state_context;
    const v275: any = useContext;
    const patternInput_1: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v275(v274);
    const v283: (arg0: string) => void = patternInput_1[7];
    const v282: () => string = patternInput_1[6];
    const v421: any = components_spi.state_context;
    const v422: any = useContext;
    const patternInput_2: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v422(v421);
    const v426: (arg0: int32) => void = patternInput_2[3];
    const v425: () => int32 = patternInput_2[2];
    const patternInput_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v456: US9 = patternInput_3[11];
    let v521: US9;
    if (v456.tag === US9_Tag.US9_1) {
        const v518: any = children_1;
        v521 = US9_US9_1(v518(v456.fields[0]));
    }
    else {
        v521 = US9_US9_0();
    }
    const v526: Mut1 = new Mut1(patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3], patternInput_3[4], patternInput_3[5], patternInput_3[6], patternInput_3[7], patternInput_3[8], patternInput_3[9], patternInput_3[10], US9_US9_1((v521.tag === US9_Tag.US9_1) ? v521.fields[0] : ((): any[] => closure161(v134, v133, v283, v282, v426, v425, void 0))), patternInput_3[12], patternInput_3[13], patternInput_3[14], patternInput_3[15], patternInput_3[16], patternInput_3[17], patternInput_3[18], patternInput_3[19], patternInput_3[20], patternInput_3[21], patternInput_3[22], patternInput_3[23], patternInput_3[24], patternInput_3[25], patternInput_3[26], patternInput_3[27], patternInput_3[28], patternInput_3[29], patternInput_3[30], patternInput_3[31], patternInput_3[32], patternInput_3[33], patternInput_3[34], patternInput_3[35], patternInput_3[36], patternInput_3[37], patternInput_3[38], patternInput_3[39], patternInput_3[40], patternInput_3[41], patternInput_3[42], patternInput_3[43], patternInput_3[44], patternInput_3[45], patternInput_3[46], patternInput_3[47], patternInput_3[48], patternInput_3[49], patternInput_3[50], patternInput_3[51], patternInput_3[52], patternInput_3[53], patternInput_3[54], patternInput_3[55], patternInput_3[56], patternInput_3[57], patternInput_3[58], patternInput_3[59], patternInput_3[60], patternInput_3[61], patternInput_3[62], patternInput_3[63], patternInput_3[64], patternInput_3[65], patternInput_3[66], patternInput_3[67], patternInput_3[68], patternInput_3[69]);
    const v527: () => any[] = (): any[] => closure161(v134, v133, v283, v282, v426, v425, void 0);
    v526.children = v527;
    const v529: any = createComponent;
    const v530: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return v529(v530, v526);
}

export function closure160(unitVar: void, v0_1: Mut1): any {
    return method37();
}

export function closure158(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure159(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure159(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure160(void 0, v);
    return [v86(v87, v82)];
}

export function closure157(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure158(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Connection
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure179(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure188(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): US6 {
    return US6_US6_1(v2());
}

export function closure189(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, v8: US6): void {
    v3((v8.tag === US6_Tag.US6_1) ? v8.fields[0] : "");
}

export function closure187(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: () => US6 = (): US6 => closure188(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    const v9: (arg0: US6) => void = (v: US6): void => {
        closure189(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v);
    };
    const v10: Mut17 = new Mut17(v8, v9);
    const v13: any = createComponent;
    const v14: (arg0: Mut17) => any = (v_1: Mut17): any => closure166(void 0, v_1);
    return [v13(v14, v10)];
}

export function closure186(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v81: () => any[] = (): any[] => closure187(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v81), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Address
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure192(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): US6 {
    return US6_US6_1(v6());
}

export function closure193(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, v8: US6): void {
    v7((v8.tag === US6_Tag.US6_1) ? v8.fields[0] : "");
}

export function closure191(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: () => US6 = (): US6 => closure192(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    const v9: (arg0: US6) => void = (v: US6): void => {
        closure193(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v);
    };
    const v10: Mut17 = new Mut17(v8, v9);
    const v13: any = createComponent;
    const v14: (arg0: Mut17) => any = (v_1: Mut17): any => closure166(void 0, v_1);
    return [v13(v14, v10)];
}

export function closure190(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v81: () => any[] = (): any[] => closure191(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v81), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Private Key
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure185(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v10: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure186(v0_1, v1_1, v2, v3, v4, v5, v6, v7, arg10$0040);
    const v12: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v10, US15_US15_2());
    const v15: any = createComponent;
    const v16: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v20: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure190(v0_1, v1_1, v2, v3, v4, v5, v6, v7, arg10$0040_1);
    const v22: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v20, US15_US15_2());
    const v23: any = createComponent;
    return [v15(v16, v12), v23(v16, v22)];
}

export function closure184(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v19: US9 = patternInput[11];
    let v85: US9;
    if (v19.tag === US9_Tag.US9_1) {
        const v82: any = children_1;
        v85 = US9_US9_1(v82(v19.fields[0]));
    }
    else {
        v85 = US9_US9_0();
    }
    const v90: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v85.tag === US9_Tag.US9_1) ? v85.fields[0] : ((): any[] => closure185(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v91: () => any[] = (): any[] => closure185(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    v90.children = v91;
    const v94: any = createComponent;
    const v95: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return [v94(v95, v90)];
}

export function closure183(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v78: US0 = v0_1();
    const v87: () => any[] = (): any[] => closure184(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v87), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {(v78.tag === US0_Tag.US0_1) ? ((v78.fields[0].tag === US1_Tag.US1_1) ? "x" : "o") : "admin"}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure182(unitVar: void, _arg: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]): any[] {
    const v10: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure183(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], arg10$0040);
    const v12: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v10, US15_US15_2());
    const v15: any = createComponent;
    const v16: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v15(v16, v12)];
}

export function closure181(v0_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], unitVar: void): any[] {
    const v1_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = v0_1();
    const v4: any = For;
    const v5: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]) => any[] = (arg10$0040: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]): any[] => closure182(void 0, arg10$0040);
    const v6: () => any[] = v5;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v18: US9 = patternInput[11];
    let v84: US9;
    if (v18.tag === US9_Tag.US9_1) {
        const v81: any = children_1;
        v84 = US9_US9_1(v81(v18.fields[0]));
    }
    else {
        v84 = US9_US9_0();
    }
    const v90: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v84.tag === US9_Tag.US9_1) ? v84.fields[0] : v6), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], US11_US11_1(v1_1), patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    v90.children = v6;
    const v91: (arg0: any) => any = v4;
    const v93: any = createComponent;
    return [v93(v91, v90)];
}

export function method40(): any {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const v129: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = (v128(v125))[0];
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v162: US9 = patternInput_1[11];
    let v227: US9;
    if (v162.tag === US9_Tag.US9_1) {
        const v224: any = children_1;
        v227 = US9_US9_1(v224(v162.fields[0]));
    }
    else {
        v227 = US9_US9_0();
    }
    const v232: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v227.tag === US9_Tag.US9_1) ? v227.fields[0] : ((): any[] => closure181(v129, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v233: () => any[] = (): any[] => closure181(v129, void 0);
    v232.children = v233;
    const v235: any = createComponent;
    const v236: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return v235(v236, v232);
}

export function closure180(unitVar: void, v0_1: Mut1): any {
    return method40();
}

export function closure178(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure179(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure179(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure180(void 0, v);
    return [v86(v87, v82)];
}

export function closure177(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure178(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Accounts
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure196(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure195(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v3: any = v2.iframe;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    const v76_1: any = <>
        algorand testnet bank
    </>;
    let v84: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v81: any = children_1;
        v84 = US9_US9_1(v81(v15.fields[0]));
    }
    else {
        v84 = US9_US9_0();
    }
    const v99: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], US6_US6_1("#aaa"), patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v84.tag === US9_Tag.US9_1) ? v84.fields[0] : ((): any[] => closure196(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], US6_US6_1("1"), patternInput[22], patternInput[23], patternInput[24], US6_US6_1("350px"), patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], US6_US6_1("https://bank.testnet.algorand.network"), patternInput[60], patternInput[61], US12_US12_1(v76_1), patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v100: () => any[] = (): any[] => closure196(void 0, void 0);
    v99.children = v100;
    const v101: (arg0: any) => any = v3;
    const v104: any = createComponent;
    return [v104(v101, v99)];
}

export function closure194(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure195(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Testnet Bank Dispenser
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure156(unitVar: void, unitVar_1: void): any[] {
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure157(void 0, arg10$0040);
    const v4: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v2, US15_US15_2());
    const v7: any = createComponent;
    const v8: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure177(void 0, arg10$0040_1);
    const v14: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v12, US15_US15_2());
    const v15: any = createComponent;
    const v19: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure194(void 0, arg10$0040_2);
    const v21: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v19, US15_US15_0());
    const v22: any = createComponent;
    return [v7(v8, v4), v15(v8, v14), v22(v8, v21)];
}

export function method36(): any {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure156(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure156(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return v86(v87, v82);
}

export function closure155(unitVar: void, v0_1: Mut1): any {
    return method36();
}

export function closure153(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure154(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure154(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure155(void 0, v);
    return [v86(v87, v82)];
}

export function closure152(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure153(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Chain
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure199(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure209(unitVar: void, _arg: [US2[], int32, US3, string, string]): US6 {
    return US6_US6_1(_arg[3]);
}

export function closure211(v0_1: Mut19, v1_1: US2[], v2: int32, v3: US3, v4: string, v5: string, v6: US6): [US2[], int32, US3, string, string] {
    return [v1_1, v2, v0_1.l0, (v6.tag === US6_Tag.US6_1) ? v6.fields[0] : "", v5];
}

export function closure210(v0_1: Mut19, _arg: [US2[], int32, US3, string, string]): (arg0: US6) => [US2[], int32, US3, string, string] {
    return (v: US6): [US2[], int32, US3, string, string] => closure211(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], _arg[4], v);
}

export function method44(v0_1: int32, v1_1: Mut21): boolean {
    return v1_1.l0 < v0_1;
}

export function closure213(v0_1: Mut20, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): US6 {
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut21 = new Mut21(0, US6_US6_0());
    while (method44(v3, v5)) {
        const v7: int32 = v5.l0 | 0;
        const v10: int32 = ((op_UnaryNegation_Int32(v7) + v3) - 1) | 0;
        const v11: US6 = v5.l1;
        const patternInput: [US2[], int32, US3, string, string] = v2[v10];
        const v14: US3 = patternInput[2];
        let v24: US6;
        if (v11.tag === US6_Tag.US6_1) {
            v24 = v11;
        }
        else {
            const v17: US3 = v0_1.l1;
            v24 = (((v14.tag === US3_Tag.US3_1) ? (v17.tag === US3_Tag.US3_1) : (v17.tag === US3_Tag.US3_0)) ? v0_1.l0([patternInput[0], patternInput[1], v14, patternInput[3], patternInput[4]]) : US6_US6_0());
        }
        const v25: int32 = (v7 + 1) | 0;
        v5.l0 = (v25 | 0);
        v5.l1 = v24;
    }
    return v5.l1;
}

export function closure214(v0_1: Mut20, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: US6): void {
    const v4: [US2[], int32, US3, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2[], int32, US3, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut3 = new Mut3(0);
    while (method5(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v4[v9];
        const v14: string = patternInput[4];
        const v13: string = patternInput[3];
        const v12: US3 = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2[] = patternInput[0];
        const v15: US3 = v0_1.l1;
        let patternInput_2: [US2[], int32, US3, string, string];
        if ((v12.tag === US3_Tag.US3_1) ? (v15.tag === US3_Tag.US3_1) : (v15.tag === US3_Tag.US3_0)) {
            const patternInput_1: [US2[], int32, US3, string, string] = v0_1.l2([v10, v11, v12, v13, v14], v3);
            patternInput_2 = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]];
        }
        else {
            patternInput_2 = [v10, v11, v12, v13, v14];
        }
        v6[v9] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4]];
        const v29: int32 = (v9 + 1) | 0;
        v7.l0 = (v29 | 0);
    }
    v1_1(v6);
}

export function method43(v0_1: Mut20): any {
    const v126: any = components_spi.state_context;
    const v129: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v129(v126);
    const v138: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v152: () => US6 = (): US6 => closure213(v0_1, v138, void 0);
    const v153: (arg0: US6) => void = (v: US6): void => {
        closure214(v0_1, patternInput[9], v138, v);
    };
    const v154: Mut17 = new Mut17(v152, v153);
    const v156: any = createComponent;
    const v157: (arg0: Mut17) => any = (v_1: Mut17): any => closure166(void 0, v_1);
    return v156(v157, v154);
}

export function closure212(unitVar: void, v0_1: Mut20): any {
    return method43(v0_1);
}

export function closure208(v0_1: Mut19, unitVar: void): any[] {
    const v2: (arg0: [US2[], int32, US3, string, string]) => US6 = (arg10$0040: [US2[], int32, US3, string, string]): US6 => closure209(void 0, arg10$0040);
    const v3: (arg0: [US2[], int32, US3, string, string], arg1: US6) => [US2[], int32, US3, string, string] = (arg10$0040_1: [US2[], int32, US3, string, string]): (arg0: US6) => [US2[], int32, US3, string, string] => closure210(v0_1, arg10$0040_1);
    const v4: Mut20 = new Mut20(v2, v0_1.l0, uncurry(2, v3));
    const v7: any = createComponent;
    const v8: (arg0: Mut20) => any = (v: Mut20): any => closure212(void 0, v);
    return [v7(v8, v4)];
}

export function closure207(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure208(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        URL
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure217(unitVar: void, _arg: [US2[], int32, US3, string, string]): US5 {
    return US5_US5_1(_arg[1]);
}

export function closure219(v0_1: Mut19, v1_1: US2[], v2: int32, v3: US3, v4: string, v5: string, v6: US5): [US2[], int32, US3, string, string] {
    const v7: US3 = v0_1.l0;
    return [v1_1, (v6.tag === US5_Tag.US5_1) ? v6.fields[0] : 0, v7, v4, v5];
}

export function closure218(v0_1: Mut19, _arg: [US2[], int32, US3, string, string]): (arg0: US5) => [US2[], int32, US3, string, string] {
    return (v: US5): [US2[], int32, US3, string, string] => closure219(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], _arg[4], v);
}

export function method46(v0_1: int32, v1_1: Mut23): boolean {
    return v1_1.l0 < v0_1;
}

export function closure221(v0_1: Mut22, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): US5 {
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut23 = new Mut23(0, US5_US5_0());
    while (method46(v3, v5)) {
        const v7: int32 = v5.l0 | 0;
        const v10: int32 = ((op_UnaryNegation_Int32(v7) + v3) - 1) | 0;
        const v11: US5 = v5.l1;
        const patternInput: [US2[], int32, US3, string, string] = v2[v10];
        const v14: US3 = patternInput[2];
        let v24: US5;
        if (v11.tag === US5_Tag.US5_1) {
            v24 = v11;
        }
        else {
            const v17: US3 = v0_1.l1;
            v24 = (((v14.tag === US3_Tag.US3_1) ? (v17.tag === US3_Tag.US3_1) : (v17.tag === US3_Tag.US3_0)) ? v0_1.l0([patternInput[0], patternInput[1], v14, patternInput[3], patternInput[4]]) : US5_US5_0());
        }
        const v25: int32 = (v7 + 1) | 0;
        v5.l0 = (v25 | 0);
        v5.l1 = v24;
    }
    return v5.l1;
}

export function closure222(v0_1: Mut22, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: US5): void {
    const v4: [US2[], int32, US3, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2[], int32, US3, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut3 = new Mut3(0);
    while (method5(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v4[v9];
        const v14: string = patternInput[4];
        const v13: string = patternInput[3];
        const v12: US3 = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2[] = patternInput[0];
        const v15: US3 = v0_1.l1;
        let patternInput_2: [US2[], int32, US3, string, string];
        if ((v12.tag === US3_Tag.US3_1) ? (v15.tag === US3_Tag.US3_1) : (v15.tag === US3_Tag.US3_0)) {
            const patternInput_1: [US2[], int32, US3, string, string] = v0_1.l2([v10, v11, v12, v13, v14], v3);
            patternInput_2 = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]];
        }
        else {
            patternInput_2 = [v10, v11, v12, v13, v14];
        }
        v6[v9] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4]];
        const v29: int32 = (v9 + 1) | 0;
        v7.l0 = (v29 | 0);
    }
    v1_1(v6);
}

export function method45(v0_1: Mut22): any {
    const v126: any = components_spi.state_context;
    const v129: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v129(v126);
    const v138: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v152: () => US5 = (): US5 => closure221(v0_1, v138, void 0);
    const v153: (arg0: US5) => void = (v: US5): void => {
        closure222(v0_1, patternInput[9], v138, v);
    };
    const v154: Mut18 = new Mut18(v152, v153);
    const v156: any = createComponent;
    const v157: (arg0: Mut18) => any = (v_1: Mut18): any => closure175(void 0, v_1);
    return v156(v157, v154);
}

export function closure220(unitVar: void, v0_1: Mut22): any {
    return method45(v0_1);
}

export function closure216(v0_1: Mut19, unitVar: void): any[] {
    const v2: (arg0: [US2[], int32, US3, string, string]) => US5 = (arg10$0040: [US2[], int32, US3, string, string]): US5 => closure217(void 0, arg10$0040);
    const v3: (arg0: [US2[], int32, US3, string, string], arg1: US5) => [US2[], int32, US3, string, string] = (arg10$0040_1: [US2[], int32, US3, string, string]): (arg0: US5) => [US2[], int32, US3, string, string] => closure218(v0_1, arg10$0040_1);
    const v4: Mut22 = new Mut22(v2, v0_1.l0, uncurry(2, v3));
    const v7: any = createComponent;
    const v8: (arg0: Mut22) => any = (v: Mut22): any => closure220(void 0, v);
    return [v7(v8, v4)];
}

export function closure215(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure216(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Port
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure206(v0_1: Mut19, unitVar: void): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure207(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v13: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure215(v0_1, arg10$0040_1);
    const v15: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v13, US15_US15_2());
    const v16: any = createComponent;
    return [v8(v9, v5), v16(v9, v15)];
}

export function method42(v0_1: Mut19): any {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v12: US9 = patternInput[11];
    let v78: US9;
    if (v12.tag === US9_Tag.US9_1) {
        const v75_1: any = children_1;
        v78 = US9_US9_1(v75_1(v12.fields[0]));
    }
    else {
        v78 = US9_US9_0();
    }
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure206(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure206(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return v87(v88, v83);
}

export function closure205(unitVar: void, v0_1: Mut19): any {
    return method42(v0_1);
}

export function closure204(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut19 = new Mut19(US3_US3_1());
    const v4: any = createComponent;
    const v5: (arg0: Mut19) => any = (v: Mut19): any => closure205(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure203(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure204(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Gun Rust
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure228(v0_1: Mut24, unitVar: void): any[] {
    return [["props.ServerType:", v0_1.l1], ["props.ClientType:", v0_1.l0]];
}

export function method50(v0_1_mut: US2, v1_1_mut: US2[], v2_mut: int32): boolean {
    let copyOfStruct: US2;
    method50:
    while (true) {
        const v0_1: US2 = v0_1_mut, v1_1: US2[] = v1_1_mut, v2: int32 = v2_mut;
        if (v2 < v1_1.length) {
            const v5: US2 = v1_1[v2];
            if ((copyOfStruct = v0_1, (copyOfStruct.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : (v5.tag === US2_Tag.US2_0)))) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_mut = (v2 + 1);
                continue method50;
            }
        }
        else {
            return false;
        }
        break;
    }
}

export function method49(v0_1_mut: Mut24, v1_1_mut: [US2[], int32, US3, string, string][], v2_mut: int32): boolean {
    method49:
    while (true) {
        const v0_1: Mut24 = v0_1_mut, v1_1: [US2[], int32, US3, string, string][] = v1_1_mut, v2: int32 = v2_mut;
        if (v2 < v1_1.length) {
            const patternInput: [US2[], int32, US3, string, string] = v1_1[v2];
            const v10: US3 = v0_1.l1;
            if (((patternInput[2].tag === US3_Tag.US3_1) ? (v10.tag === US3_Tag.US3_1) : (v10.tag === US3_Tag.US3_0)) && method50(v0_1.l0, patternInput[0], 0)) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_mut = (v2 + 1);
                continue method49;
            }
        }
        else {
            return false;
        }
        break;
    }
}

export function closure229(v0_1: Mut24, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): boolean {
    return method49(v0_1, v1_1(), 0);
}

export function method51(v0_1: int32, v1_1: Mut25): boolean {
    return v1_1.l0 < v0_1;
}

export function closure230(v0_1: Mut24, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: boolean): void {
    let v18: US2[], v19: int32, v21: int32, v22: US2[], v23: Mut3, v32: US2, v33: int32, v34: US2[], v35: Mut25, v45: int32, v46: US2[], v47: Mut3;
    const v4: [US2[], int32, US3, string, string][] = v2();
    const v5: int32 = v4.length | 0;
    const v6: [US2[], int32, US3, string, string][] = fill(new Array(v5), 0, v5, null);
    const v7: Mut3 = new Mut3(0);
    while (method5(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v4[v9];
        const v14: string = patternInput[4];
        const v13: string = patternInput[3];
        const v12: US3 = patternInput[2];
        const v11: int32 = patternInput[1] | 0;
        const v10: US2[] = patternInput[0];
        const v15: US3 = v0_1.l1;
        const patternInput_1: [US2[], int32, US3, string, string] = ((v12.tag === US3_Tag.US3_1) ? (v15.tag === US3_Tag.US3_1) : (v15.tag === US3_Tag.US3_0)) ? [v3 ? ((v18 = [v0_1.l0], (v19 = (v10.length | 0), (v21 = ((v19 + v18.length) | 0), (v22 = fill(new Array(v21), 0, v21, null), (v23 = (new Mut3(0)), ((() => {
            while (method5(v21, v23)) {
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
            let copyOfStruct_3: US2;
            while (method51(v33, v35)) {
                const v37: int32 = v35.l0 | 0;
                const v38: int32 = v35.l1 | 0;
                const v39: US2 = v10[v37];
                let v43: int32;
                if (((copyOfStruct_3 = v32, (copyOfStruct_3.tag === US2_Tag.US2_1) ? (v39.tag === US2_Tag.US2_1) : ((copyOfStruct_3.tag === US2_Tag.US2_2) ? (v39.tag === US2_Tag.US2_2) : (v39.tag === US2_Tag.US2_0)))) !== true) {
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
        })(), (v45 = (v35.l1 | 0), (v46 = fill(new Array(v45), 0, v45, null), (v47 = (new Mut3(0)), ((() => {
            while (method5(v45, v47)) {
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

export function closure232(v0_1: Mut24, unitVar: void): any[] {
    const v1_1: US2 = v0_1.l0;
    return [<>
        {(v1_1.tag === US2_Tag.US2_1) ? "Gun Rust" : ((v1_1.tag === US2_Tag.US2_2) ? "???" : "Gun JavaScript")}
    </>];
}

export function closure231(v0_1: Mut24, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v71: () => any[] = (): any[] => closure232(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v71), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method48(v0_1: Mut24): any {
    const v126: any = components_spi.state_context;
    const v129: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v129(v126);
    const v138: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v152: () => any[] = (): any[] => closure228(v0_1, void 0);
    method14(v152, "#666")(US4_US4_0())(["> db_client ()"]);
    const v160: () => boolean = (): boolean => closure229(v0_1, v138, void 0);
    const v161: (arg0: boolean) => void = (v: boolean): void => {
        closure230(v0_1, patternInput[9], v138, v);
    };
    const v162: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure231(v0_1, arg10$0040_2);
    const v163: Mut5 = new Mut5(v160, v161, v162);
    const v165: any = createComponent;
    const v166: (arg0: Mut5) => any = (v_1: Mut5): any => closure22(void 0, v_1);
    return v165(v166, v163);
}

export function closure227(unitVar: void, v0_1: Mut24): any {
    return method48(v0_1);
}

export function closure226(v0_1: Mut19, unitVar: void): any[] {
    const v3: Mut24 = new Mut24(US2_US2_1(), v0_1.l0);
    const v6: any = createComponent;
    const v7: (arg0: Mut24) => any = (v: Mut24): any => closure227(void 0, v);
    const v8: any = v6(v7, v3);
    const v11: Mut24 = new Mut24(US2_US2_0(), v0_1.l0);
    const v12: any = createComponent;
    return [v8, v12(v7, v11)];
}

export function closure225(v0_1: Mut19, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure226(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_1("8px"), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Clients
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method47(v0_1: Mut19): any {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure225(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v8(v9, v5);
}

export function closure224(unitVar: void, v0_1: Mut19): any {
    return method47(v0_1);
}

export function closure223(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut19 = new Mut19(US3_US3_1());
    const v4: any = createComponent;
    const v5: (arg0: Mut19) => any = (v: Mut19): any => closure224(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure202(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v72_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure203(void 0, arg10$0040);
    const v74_1: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v72_1, US15_US15_2());
    const v77_1: any = createComponent;
    const v78: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v80: () => any[] = (): any[] => closure223(void 0, void 0);
    const v83: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v80), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US6_US6_1(v83), US6_US6_1(v83), _arg[52], US6_US6_1(v83), _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v77_1(v78, v74_1)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure235(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut19 = new Mut19(US3_US3_0());
    const v4: any = createComponent;
    const v5: (arg0: Mut19) => any = (v: Mut19): any => closure205(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure234(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure235(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Gun JavaScript
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure236(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut19 = new Mut19(US3_US3_0());
    const v4: any = createComponent;
    const v5: (arg0: Mut19) => any = (v: Mut19): any => closure224(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure233(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v72_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure234(void 0, arg10$0040);
    const v74_1: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v72_1, US15_US15_2());
    const v77_1: any = createComponent;
    const v78: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v80: () => any[] = (): any[] => closure236(void 0, void 0);
    const v83: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v80), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US6_US6_1(v83), US6_US6_1(v83), _arg[52], US6_US6_1(v83), _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v77_1(v78, v74_1)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure201(unitVar: void, unitVar_1: void): any[] {
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure202(void 0, arg10$0040);
    const v4: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v2, US15_US15_2());
    const v7: any = createComponent;
    const v8: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure233(void 0, arg10$0040_1);
    const v14: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v12, US15_US15_2());
    const v15: any = createComponent;
    return [v7(v8, v4), v15(v8, v14)];
}

export function method41(): any {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure201(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure201(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return v86(v87, v82);
}

export function closure200(unitVar: void, v0_1: Mut1): any {
    return method41();
}

export function closure198(unitVar: void, unitVar_1: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v11: US9 = patternInput[11];
    let v77_1: US9;
    if (v11.tag === US9_Tag.US9_1) {
        const v74_1: any = children_1;
        v77_1 = US9_US9_1(v74_1(v11.fields[0]));
    }
    else {
        v77_1 = US9_US9_0();
    }
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure199(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure199(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure200(void 0, v);
    return [v86(v87, v82)];
}

export function closure197(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure198(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Database
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure240(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure242(v0_1: () => [int64, int32][], v1_1: () => [US2, any, string][], v2: () => void, v3: () => void, v4: () => US16, v5: () => [US2, int64, string][], unitVar: void): any[] {
    const v9: [int64, int32][] = v0_1();
    v2();
    v3();
    const v16: US16 = v4();
    const v19: [US2, int64, string][] = v5();
    const v20: int32 = v19.length | 0;
    const v21: [US2, int64][] = fill(new Array(v20), 0, v20, null);
    const v22: Mut3 = new Mut3(0);
    while (method5(v20, v22)) {
        const v24: int32 = v22.l0 | 0;
        const patternInput: [US2, int64, string] = v19[v24];
        v21[v24] = [patternInput[0], patternInput[1]];
        const v28: int32 = (v24 + 1) | 0;
        v22.l0 = (v28 | 0);
    }
    const v31: [US2, any, string][] = v1_1();
    const v32: int32 = v31.length | 0;
    const v33: US2[] = fill(new Array(v32), 0, v32, null);
    const v34: Mut3 = new Mut3(0);
    while (method5(v32, v34)) {
        const v36: int32 = v34.l0 | 0;
        const patternInput_1: [US2, any, string] = v31[v36];
        v33[v36] = patternInput_1[0];
        const v40: int32 = (v36 + 1) | 0;
        v34.l0 = (v40 | 0);
    }
    return [["content_address:", "profile/tmp/counter"], ["getter:", v9], "events:", "timers:", ["value:", v16], ["subscriptions:", v21], ["db_connections:", v33]];
}

export function method53(v0_1: int32, v1_1: Mut26): boolean {
    return v1_1.l0 < v0_1;
}

export function closure244(v0_1: US2, unitVar: void): any[] {
    return [["content_address:", "profile/tmp/counter"], ["client_type:", v0_1]];
}

export function method55(v0_1: int32, v1_1: Mut27): boolean {
    return v1_1.l0 < v0_1;
}

export function method54(v0_1: () => [int64, int32][], v1_1: (arg0: [int64, int32][]) => void, v2: (arg0: US16) => void, v3: () => US16, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: int32, v9: any): void {
    let copyOfStruct_5: US2, copyOfStruct_1: US2;
    const v10: int64 = op_Division(getTicks(utcNow()), fromBits(1000, 0, false));
    v7(US4_US4_2(), ["> db_on > on_value ()", ["v:", v8], ["k:", v9], ["new_timestamp:", v10]]);
    const v22: US16 = v3();
    if (v22.tag === US16_Tag.US16_1) {
        if ((v22.fields[2] !== v8) && (compare(v10, v22.fields[1]) > 0)) {
            const v90: string = "new_value:";
            v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v90, v8]]);
            const v93: [int64, int32][] = v0_1();
            const v94: [int64, int32][] = [[v10, v8]];
            const v95: int32 = v93.length | 0;
            const v97: int32 = (v95 + v94.length) | 0;
            const v98: [int64, int32][] = fill(new Array(v97), 0, v97, null);
            const v99: Mut3 = new Mut3(0);
            while (method5(v97, v99)) {
                const v101: int32 = v99.l0 | 0;
                let patternInput_6: [int64, int32];
                if (v101 < v95) {
                    const patternInput_4: [int64, int32] = v93[v101];
                    patternInput_6 = [patternInput_4[0], patternInput_4[1]];
                }
                else {
                    const v105: int32 = (v101 - v95) | 0;
                    const patternInput_5: [int64, int32] = v94[v105];
                    patternInput_6 = [patternInput_5[0], patternInput_5[1]];
                }
                v98[v101] = [patternInput_6[0], patternInput_6[1]];
                const v110: int32 = (v101 + 1) | 0;
                v99.l0 = (v110 | 0);
            }
            v1_1(v98);
            v2(US16_US16_1(v5, v10, v8));
            const v112: int32 = v6.length | 0;
            const v113: Mut3 = new Mut3(0);
            while (method5(v112, v113)) {
                const v115: int32 = v113.l0 | 0;
                const patternInput_7: [US2, any, string] = v6[v115];
                const v116: US2 = patternInput_7[0];
                if (((copyOfStruct_5 = v116, (copyOfStruct_5.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct_5.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : (v5.tag === US2_Tag.US2_0)))) !== true) {
                    v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v90, v8], ["connection_client_type:", v116]]);
                    const v130: string[] = "profile/tmp/counter".split("/");
                    const v133: any = patternInput_7[1].get("tictactoe_spiral");
                    const v134: int32 = v130.length | 0;
                    const v135: Mut27 = new Mut27(0, v133);
                    while (method55(v134, v135)) {
                        const v137: int32 = v135.l0 | 0;
                        const v138: any = v135.l1;
                        const v139: string = v130[v137];
                        const v141: any = v138.get(v139);
                        const v142: int32 = (v137 + 1) | 0;
                        v135.l0 = (v142 | 0);
                        v135.l1 = v141;
                    }
                    const v143: any = v135.l1;
                    v143.put(v8);
                }
                const v144: int32 = (v115 + 1) | 0;
                v113.l0 = (v144 | 0);
            }
        }
    }
    else {
        const v27: string = "new_value:";
        v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v27, v8]]);
        const v30: [int64, int32][] = v0_1();
        const v31: [int64, int32][] = [[v10, v8]];
        const v32: int32 = v30.length | 0;
        const v34: int32 = (v32 + v31.length) | 0;
        const v35: [int64, int32][] = fill(new Array(v34), 0, v34, null);
        const v36: Mut3 = new Mut3(0);
        while (method5(v34, v36)) {
            const v38: int32 = v36.l0 | 0;
            let patternInput_2: [int64, int32];
            if (v38 < v32) {
                const patternInput: [int64, int32] = v30[v38];
                patternInput_2 = [patternInput[0], patternInput[1]];
            }
            else {
                const v42: int32 = (v38 - v32) | 0;
                const patternInput_1: [int64, int32] = v31[v42];
                patternInput_2 = [patternInput_1[0], patternInput_1[1]];
            }
            v35[v38] = [patternInput_2[0], patternInput_2[1]];
            const v47: int32 = (v38 + 1) | 0;
            v36.l0 = (v47 | 0);
        }
        v1_1(v35);
        v2(US16_US16_1(v5, v10, v8));
        const v49: int32 = v6.length | 0;
        const v50: Mut3 = new Mut3(0);
        while (method5(v49, v50)) {
            const v52: int32 = v50.l0 | 0;
            const patternInput_3: [US2, any, string] = v6[v52];
            const v53: US2 = patternInput_3[0];
            if (((copyOfStruct_1 = v53, (copyOfStruct_1.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct_1.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : (v5.tag === US2_Tag.US2_0)))) !== true) {
                v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v27, v8], ["connection_client_type:", v53]]);
                const v67: string[] = "profile/tmp/counter".split("/");
                const v70: any = patternInput_3[1].get("tictactoe_spiral");
                const v71: int32 = v67.length | 0;
                const v72_1: Mut27 = new Mut27(0, v70);
                while (method55(v71, v72_1)) {
                    const v74_1: int32 = v72_1.l0 | 0;
                    const v75_1: any = v72_1.l1;
                    const v76_1: string = v67[v74_1];
                    const v78: any = v75_1.get(v76_1);
                    const v79: int32 = (v74_1 + 1) | 0;
                    v72_1.l0 = (v79 | 0);
                    v72_1.l1 = v78;
                }
                const v80: any = v72_1.l1;
                v80.put(v8);
            }
            const v81: int32 = (v52 + 1) | 0;
            v50.l0 = (v81 | 0);
        }
    }
}

export function closure246(v0_1: () => [int64, int32][], v1_1: (arg0: [int64, int32][]) => void, v2: (arg0: US16) => void, v3: () => US16, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: int32, v9: any): void {
    method54(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9);
}

export function closure245(v0_1: () => [int64, int32][], v1_1: (arg0: [int64, int32][]) => void, v2: (arg0: US16) => void, v3: () => US16, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: int32): (arg0: any) => void {
    return (v: any): void => {
        closure246(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v);
    };
}

export function method56(v0_1_mut: [US2, string][], v1_1_mut: [US2, string][], v2_mut: int32): boolean {
    let copyOfStruct: US2;
    method56:
    while (true) {
        const v0_1: [US2, string][] = v0_1_mut, v1_1: [US2, string][] = v1_1_mut, v2: int32 = v2_mut;
        if (v2 < v0_1.length) {
            const patternInput: [US2, string] = v0_1[v2];
            const patternInput_1: [US2, string] = v1_1[v2];
            const v7: US2 = patternInput_1[0];
            if (((copyOfStruct = patternInput[0], (copyOfStruct.tag === US2_Tag.US2_1) ? (v7.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v7.tag === US2_Tag.US2_2) : (v7.tag === US2_Tag.US2_0)))) && (patternInput[1] === patternInput_1[1])) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_mut = (v2 + 1);
                continue method56;
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

export function closure243(v0_1: () => US4, v1_1: (arg0: [US2, int64, string][]) => void, v2: () => [US2, int64, string][], v3: (arg0: US4, arg1: any[]) => void, v4: () => [int64, int32][], v5: (arg0: [int64, int32][]) => void, v6: (arg0: US16) => void, v7: () => US16, v8: [US2, any, string][]): void {
    let copyOfStruct: US2;
    const v9: [US2, int64, string][] = v2();
    const v10: int32 = v8.length | 0;
    const v11: [US2, int64, string][] = fill(new Array(v10), 0, v10, null);
    const v12: Mut3 = new Mut3(0);
    while (method5(v10, v12)) {
        const v14: int32 = v12.l0 | 0;
        const patternInput: [US2, any, string] = v8[v14];
        const v17: string = patternInput[2];
        const v15: US2 = patternInput[0];
        const v18: int32 = v9.length | 0;
        const v20: Mut26 = new Mut26(0, US17_US17_0());
        while (method53(v18, v20)) {
            const v22: int32 = v20.l0 | 0;
            const v25: int32 = ((op_UnaryNegation_Int32(v22) + v18) - 1) | 0;
            const v26: US17 = v20.l1;
            const patternInput_1: [US2, int64, string] = v9[v25];
            const v29: string = patternInput_1[2];
            const v27: US2 = patternInput_1[0];
            const v39: US17 = (v26.tag === US17_Tag.US17_1) ? v26 : ((((copyOfStruct = v27, (copyOfStruct.tag === US2_Tag.US2_1) ? (v15.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v15.tag === US2_Tag.US2_2) : (v15.tag === US2_Tag.US2_0)))) && (v29 === v17)) ? US17_US17_1(v27, patternInput_1[1], v29) : US17_US17_0());
            const v40: int32 = (v22 + 1) | 0;
            v20.l0 = (v40 | 0);
            v20.l1 = v39;
        }
        const v41: US17 = v20.l1;
        let patternInput_2: [US2, int64, string];
        if (v41.tag === US17_Tag.US17_1) {
            patternInput_2 = [v41.fields[0], v41.fields[1], v41.fields[2]];
        }
        else {
            const v42: () => any[] = (): any[] => closure244(v15, void 0);
            const v44: (arg0: US4, arg1: any[]) => void = method15(v0_1, v42, "#666");
            v44(US4_US4_0())(["> db_on ()"]);
            const v50: (arg0: int32, arg1: any) => void = (v: int32): (arg0: any) => void => closure245(v4, v5, v6, v7, v3, v15, v8, uncurry(2, v44), v);
            let v51: (arg0: [any, any]) => void;
            const clo: (arg0: [any, any]) => void = (v: any, k: any) => v50(v)(k);
            v51 = ((arg: [any, any]): void => {
                clo(arg);
            });
            const v53: string[] = "profile/tmp/counter".split("/");
            const v56: any = patternInput[1].get("tictactoe_spiral");
            const v57: int32 = v53.length | 0;
            const v58: Mut27 = new Mut27(0, v56);
            while (method55(v57, v58)) {
                const v60: int32 = v58.l0 | 0;
                const v61: any = v58.l1;
                const v62: string = v53[v60];
                const v64: any = v61.get(v62);
                const v65: int32 = (v60 + 1) | 0;
                v58.l0 = (v65 | 0);
                v58.l1 = v64;
            }
            const v66: any = v58.l1;
            patternInput_2 = [v15, (v15.tag === US2_Tag.US2_1) ? (v66.on(v51)) : ((v15.tag === US2_Tag.US2_2) ? (() => {
                throw new Error("db_on Memory");
            })() : ((v66.on(v51), op_Division(getTicks(utcNow()), fromBits(1000, 0, false))))), v17];
        }
        v11[v14] = [patternInput_2[0], patternInput_2[1], patternInput_2[2]];
        const v77_1: int32 = (v14 + 1) | 0;
        v12.l0 = (v77_1 | 0);
    }
    const v78: int32 = v9.length | 0;
    const v79: [US2, string][] = fill(new Array(v78), 0, v78, null);
    const v80: Mut3 = new Mut3(0);
    while (method5(v78, v80)) {
        const v82: int32 = v80.l0 | 0;
        const patternInput_3: [US2, int64, string] = v9[v82];
        v79[v82] = [patternInput_3[0], patternInput_3[2]];
        const v86: int32 = (v82 + 1) | 0;
        v80.l0 = (v86 | 0);
    }
    const v87: int32 = v11.length | 0;
    const v88: [US2, string][] = fill(new Array(v87), 0, v87, null);
    const v89: Mut3 = new Mut3(0);
    while (method5(v87, v89)) {
        const v91: int32 = v89.l0 | 0;
        const patternInput_4: [US2, int64, string] = v11[v91];
        v88[v91] = [patternInput_4[0], patternInput_4[2]];
        const v95: int32 = (v91 + 1) | 0;
        v89.l0 = (v95 | 0);
    }
    if ((((v79.length === v88.length) !== true) ? false : method56(v79, v88, 0)) !== true) {
        const v105: (arg0: any[]) => void = partialApply(1, v3, [US4_US4_2()]);
        const v108: [US2, int64][] = fill(new Array(v87), 0, v87, null);
        const v109: Mut3 = new Mut3(0);
        while (method5(v87, v109)) {
            const v111: int32 = v109.l0 | 0;
            const patternInput_5: [US2, int64, string] = v11[v111];
            v108[v111] = [patternInput_5[0], patternInput_5[1]];
            const v115: int32 = (v111 + 1) | 0;
            v109.l0 = (v115 | 0);
        }
        v105(["> use_fetch > connections_change", ["new_subscriptions:", v108]]);
        v1_1(v11);
    }
}

export function closure247(v0_1: () => [US2, any, string][], v1_1: (arg0: [US2, any, string][]) => void, unitVar: void): void {
    v1_1(v0_1());
}

export function closure248(v0_1: (arg0: [US2, any, string][]) => void, v1_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1.clear();
    v1_1(US4_US4_0(), ["> use_fetch > unsubscribe () [1]"]);
    toConsole(interpolate("%A%P()", [["db_off", "profile/tmp/counter"]]));
}

export function closure251(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Counter
    </>];
}

export function closure252(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure253(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularPlus;
    return v2;
}

export function closure254(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure257(v0_1: () => [int64, int32][], v1_1: (arg0: int32) => void, v2: (arg0: Error) => void): void {
    const v3: [int64, int32][] = v0_1();
    v1_1(v3.length);
}

export function closure256(v0_1: () => [int64, int32][], v1_1: (arg0: int32) => void): (arg0: (arg0: Error) => void) => void {
    return (v: (arg0: Error) => void): void => {
        closure257(v0_1, v1_1, v);
    };
}

export function closure258(v0_1: () => [int64, int32][], v1_1: (arg0: [int64, int32][]) => void, v2: (arg0: US16) => void, v3: () => US16, v4: (arg0: US4, arg1: any[]) => void, v5: [US2, any, string][], v6: int64, v7: int32): void {
    const v8: US16 = v3();
    if (v8.tag === US16_Tag.US16_1) {
        if ((v8.fields[2] !== v7) && (compare(v6, v8.fields[1]) > 0)) {
            const v78: string = "new_value:";
            v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v78, v7]]);
            const v81: [int64, int32][] = v0_1();
            const v82: [int64, int32][] = [[v6, v7]];
            const v83: int32 = v81.length | 0;
            const v85: int32 = (v83 + v82.length) | 0;
            const v86: [int64, int32][] = fill(new Array(v85), 0, v85, null);
            const v87: Mut3 = new Mut3(0);
            while (method5(v85, v87)) {
                const v89: int32 = v87.l0 | 0;
                let patternInput_6: [int64, int32];
                if (v89 < v83) {
                    const patternInput_4: [int64, int32] = v81[v89];
                    patternInput_6 = [patternInput_4[0], patternInput_4[1]];
                }
                else {
                    const v93: int32 = (v89 - v83) | 0;
                    const patternInput_5: [int64, int32] = v82[v93];
                    patternInput_6 = [patternInput_5[0], patternInput_5[1]];
                }
                v86[v89] = [patternInput_6[0], patternInput_6[1]];
                const v98: int32 = (v89 + 1) | 0;
                v87.l0 = (v98 | 0);
            }
            v1_1(v86);
            v2(US16_US16_1(US2_US2_2(), v6, v7));
            const v101: int32 = v5.length | 0;
            const v102: Mut3 = new Mut3(0);
            while (method5(v101, v102)) {
                const v104: int32 = v102.l0 | 0;
                const patternInput_7: [US2, any, string] = v5[v104];
                const v105: US2 = patternInput_7[0];
                if ((v105.tag === US2_Tag.US2_2) !== true) {
                    v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v78, v7], ["connection_client_type:", v105]]);
                    const v120: string[] = "profile/tmp/counter".split("/");
                    const v123: any = patternInput_7[1].get("tictactoe_spiral");
                    const v124: int32 = v120.length | 0;
                    const v125: Mut27 = new Mut27(0, v123);
                    while (method55(v124, v125)) {
                        const v127: int32 = v125.l0 | 0;
                        const v128: any = v125.l1;
                        const v129: string = v120[v127];
                        const v131: any = v128.get(v129);
                        const v132: int32 = (v127 + 1) | 0;
                        v125.l0 = (v132 | 0);
                        v125.l1 = v131;
                    }
                    const v133: any = v125.l1;
                    v133.put(v7);
                }
                const v134: int32 = (v104 + 1) | 0;
                v102.l0 = (v134 | 0);
            }
        }
    }
    else {
        const v13: string = "new_value:";
        v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v13, v7]]);
        const v16: [int64, int32][] = v0_1();
        const v17: [int64, int32][] = [[v6, v7]];
        const v18: int32 = v16.length | 0;
        const v20: int32 = (v18 + v17.length) | 0;
        const v21: [int64, int32][] = fill(new Array(v20), 0, v20, null);
        const v22: Mut3 = new Mut3(0);
        while (method5(v20, v22)) {
            const v24: int32 = v22.l0 | 0;
            let patternInput_2: [int64, int32];
            if (v24 < v18) {
                const patternInput: [int64, int32] = v16[v24];
                patternInput_2 = [patternInput[0], patternInput[1]];
            }
            else {
                const v28: int32 = (v24 - v18) | 0;
                const patternInput_1: [int64, int32] = v17[v28];
                patternInput_2 = [patternInput_1[0], patternInput_1[1]];
            }
            v21[v24] = [patternInput_2[0], patternInput_2[1]];
            const v33: int32 = (v24 + 1) | 0;
            v22.l0 = (v33 | 0);
        }
        v1_1(v21);
        v2(US16_US16_1(US2_US2_2(), v6, v7));
        const v36: int32 = v5.length | 0;
        const v37: Mut3 = new Mut3(0);
        while (method5(v36, v37)) {
            const v39: int32 = v37.l0 | 0;
            const patternInput_3: [US2, any, string] = v5[v39];
            const v40: US2 = patternInput_3[0];
            if ((v40.tag === US2_Tag.US2_2) !== true) {
                v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v13, v7], ["connection_client_type:", v40]]);
                const v55: string[] = "profile/tmp/counter".split("/");
                const v58: any = patternInput_3[1].get("tictactoe_spiral");
                const v59: int32 = v55.length | 0;
                const v60: Mut27 = new Mut27(0, v58);
                while (method55(v59, v60)) {
                    const v62: int32 = v60.l0 | 0;
                    const v63: any = v60.l1;
                    const v64: string = v55[v62];
                    const v66: any = v63.get(v64);
                    const v67: int32 = (v62 + 1) | 0;
                    v60.l0 = (v67 | 0);
                    v60.l1 = v66;
                }
                const v68: any = v60.l1;
                v68.put(v7);
            }
            const v69: int32 = (v39 + 1) | 0;
            v37.l0 = (v69 | 0);
        }
    }
}

export function closure255(v0_1: () => [int64, int32][], v1_1: () => [US2, any, string][], v2: (arg0: [int64, int32][]) => void, v3: (arg0: US16) => void, v4: () => US16, v5: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    const v6: [US2, any, string][] = v1_1();
    const v7: int64 = op_Division(getTicks(utcNow()), fromBits(1000, 0, false));
    const v9: (arg0: (arg0: int32) => void, arg1: (arg0: Error) => void) => void = (v: (arg0: int32) => void): (arg0: (arg0: Error) => void) => void => closure256(v0_1, v);
    const v11: (arg0: int32) => void = (v_1: int32): void => {
        closure258(v0_1, v2, v3, v4, v5, v6, v7, v_1);
    };
    const pr: any = new Promise(uncurry(2, v9));
    void (pr.then(v11));
}

export function closure259(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure260(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularMinus;
    return v2;
}

export function closure261(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure262(v0_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1(US4_US4_2(), [">> use_fetch clear()"]);
}

export function closure250(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: () => [int64, int32][], v2: () => [US2, any, string][], v3: (arg0: [int64, int32][]) => void, v4: (arg0: US16) => void, v5: () => US16, unitVar: void): any[] {
    const v8: any = Box;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v20: US9 = patternInput[11];
    let v86: US9;
    if (v20.tag === US9_Tag.US9_1) {
        const v83: any = children_1;
        v86 = US9_US9_1(v83(v20.fields[0]));
    }
    else {
        v86 = US9_US9_0();
    }
    const v92: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v86.tag === US9_Tag.US9_1) ? v86.fields[0] : ((): any[] => closure251(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v93: () => any[] = (): any[] => closure251(void 0, void 0);
    v92.children = v93;
    const v94: (arg0: any) => any = v8;
    const v97: any = createComponent;
    const v98: any = v97(v94, v92);
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v110: US9 = patternInput_1[11];
    const v169: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure252(void 0, arg10$0040_2);
    const v170: () => any = (): any => closure253(void 0, void 0);
    const v171: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v172: Mut7 = new Mut7(v169, v170, v171);
    const v173: any = createComponent;
    const v174: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    const v175: any = v173(v174, v172);
    let v182: US9;
    if (v110.tag === US9_Tag.US9_1) {
        const v179: any = children_1;
        v182 = US9_US9_1(v179(v110.fields[0]));
    }
    else {
        v182 = US9_US9_0();
    }
    const v188: () => void = (): void => {
        closure255(v1_1, v2, v3, v4, v5, v0_1, void 0);
    };
    const v190: string = "10px";
    const v192: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v182.tag === US9_Tag.US9_1) ? v182.fields[0] : ((): any[] => closure254(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US12_US12_1(v175), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], US14_US14_1(v188), patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], US6_US6_1(v190), patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v193: () => any[] = (): any[] => closure254(void 0, void 0);
    v192.children = v193;
    const v194: any = createComponent;
    const v195: (arg0: Mut1) => any = (v_1: Mut1): any => closure40(void 0, v_1);
    const v196: any = v194(v195, v192);
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v208_1: US9 = patternInput_2[11];
    const v267: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_8: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure259(void 0, arg10$0040_8);
    const v268: () => any = (): any => closure260(void 0, void 0);
    const v269: Mut7 = new Mut7(v267, v268, v171);
    const v270: any = createComponent;
    const v271: any = v270(v174, v269);
    let v278: US9;
    if (v208_1.tag === US9_Tag.US9_1) {
        const v275: any = children_1;
        v278 = US9_US9_1(v275(v208_1.fields[0]));
    }
    else {
        v278 = US9_US9_0();
    }
    const v284: () => void = (): void => {
        closure262(v0_1, void 0);
    };
    const v287: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v278.tag === US9_Tag.US9_1) ? v278.fields[0] : ((): any[] => closure261(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US12_US12_1(v271), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US14_US14_1(v284), patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], US6_US6_1(v190), patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]);
    const v288: () => any[] = (): any[] => closure261(void 0, void 0);
    v287.children = v288;
    const v289: any = createComponent;
    return [v98, v196, v289(v195, v287)];
}

export function method57(v0_1: int32, v1_1: Mut28): boolean {
    return v1_1.l0 < v0_1;
}

export function method58(v0_1_mut: UH1, v1_1_mut: UH1): UH1 {
    method58:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: UH1 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH1_UH1_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method58;
        }
        break;
    }
}

export function method60(v0_1_mut: UH1, v1_1_mut: int32): int32 {
    method60:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method60;
        }
        break;
    }
}

export function method61(v0_1_mut: [int64, int32][], v1_1_mut: UH1, v2_mut: int32): int32 {
    method61:
    while (true) {
        const v0_1: [int64, int32][] = v0_1_mut, v1_1: UH1 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH1_Tag.UH1_1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = [v1_1.fields[0], v1_1.fields[1]];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[2];
            v2_mut = (v2 + 1);
            continue method61;
        }
        break;
    }
}

export function method59(v0_1: UH1): [int64, int32][] {
    const v2: int32 = method60(v0_1, 0) | 0;
    const v3: [int64, int32][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method61(v3, v0_1, 0) | 0;
    return v3;
}

export function closure268(v0_1: () => [int64, int32], unitVar: void): any[] {
    const patternInput: [int64, int32] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure267(v0_1: () => [int64, int32], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v16: US9 = patternInput[11];
    let v82: US9;
    if (v16.tag === US9_Tag.US9_1) {
        const v79: any = children_1;
        v82 = US9_US9_1(v79(v16.fields[0]));
    }
    else {
        v82 = US9_US9_0();
    }
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure268(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure268(v0_1, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure266(v0_1: () => [int64, int32], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure267(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {toString_1(v0_1()[0])}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure265(unitVar: void, v0_1: () => [int64, int32]): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure266(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure264(v0_1: () => [int64, int32][], unitVar: void): any[] {
    const v1_1: [int64, int32][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut28 = new Mut28(0, UH1_UH1_1());
    while (method57(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH1 = v4.l1;
        const patternInput: [int64, int32] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH1_UH1_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int64, int32][] = method59(method58(v4.l1, UH1_UH1_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int64, int32]) => any[] = (v: () => [int64, int32]): any[] => closure265(void 0, v);
    const v23: () => any[] = v22;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v35: US9 = patternInput_1[11];
    let v101: US9;
    if (v35.tag === US9_Tag.US9_1) {
        const v98: any = children_1;
        v101 = US9_US9_1(v98(v35.fields[0]));
    }
    else {
        v101 = US9_US9_0();
    }
    const v107: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v101.tag === US9_Tag.US9_1) ? v101.fields[0] : v23), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], US11_US11_1(v18), patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    v107.children = v23;
    const v108: (arg0: any) => any = v21;
    const v110: any = createComponent;
    return [v110(v108, v107)];
}

export function closure263(v0_1: () => [int64, int32][], unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v12: US9 = patternInput[11];
    let v78: US9;
    if (v12.tag === US9_Tag.US9_1) {
        const v75_1: any = children_1;
        v78 = US9_US9_1(v75_1(v12.fields[0]));
    }
    else {
        v78 = US9_US9_0();
    }
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure264(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure264(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return [v87(v88, v83)];
}

export function closure249(v0_1: () => [int64, int32][], v1_1: (arg0: US4, arg1: any[]) => void, v2: () => [US2, any, string][], v3: (arg0: [int64, int32][]) => void, v4: (arg0: US16) => void, v5: () => US16, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v78: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v90: US9 = patternInput[11];
    const v151: string = method12("baseline", "center");
    const v154: string = method12("column", "row");
    const v157: string = method12("8px", "0");
    let v165: US9;
    if (v90.tag === US9_Tag.US9_1) {
        const v162: any = children_1;
        v165 = US9_US9_1(v162(v90.fields[0]));
    }
    else {
        v165 = US9_US9_0();
    }
    const v178: any = createObj(method7(US6_US6_1(v151), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v165.tag === US9_Tag.US9_1) ? v165.fields[0] : ((): any[] => closure250(v1_1, v0_1, v2, v3, v4, v5, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1(v154), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US6_US6_1(v157), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1("3px"), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("7px"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v179: () => any[] = (): any[] => closure250(v1_1, v0_1, v2, v3, v4, v5, void 0);
    v178.children = v179;
    const v180: (arg0: any) => any = v78;
    const v183: any = createComponent;
    const v185: () => any[] = (): any[] => closure263(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v185), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("counter"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v183(v180, v178)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method52(): any {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    const v146: (arg0: [int64, int32][]) => void = patternInput[17];
    const v145: () => [int64, int32][] = patternInput[16];
    const v274: any = components_spi.state_context;
    const v275: any = useContext;
    const patternInput_1: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v275(v274);
    const v421: any = components_spi.state_context;
    const v422: any = useContext;
    const v433: () => [US2, any, string][] = (v422(v421))[10];
    const v446: any = createSignal;
    const v447: any[] = v446();
    let v448: () => void;
    const value_4: any = v447[0];
    v448 = ((): void => {
        value_4();
    });
    let v449: () => void;
    const value_5: any = v447[1];
    v449 = ((): void => {
        value_5();
    });
    const v450: any = createSignal;
    const v451: any[] = v450();
    let v452: () => void;
    const value_7: any = v451[0];
    v452 = ((): void => {
        value_7();
    });
    let v453: () => void;
    const value_8: any = v451[1];
    v453 = ((): void => {
        value_8();
    });
    const v454: any = createSignal;
    const v456: any[] = v454(US16_US16_0());
    let v457: () => US16;
    const value_10: any = v456[0];
    v457 = (value_10);
    let v458: (arg0: US16) => void;
    const value_11: any = v456[1];
    v458 = ((arg_5: US16): void => {
        value_11(arg_5);
    });
    const v460: any = createSignal;
    const v461: any[] = v460([]);
    let v462: () => [US2, int64, string][];
    const value_13: any = v461[0];
    v462 = (value_13);
    let v463: (arg0: [US2, int64, string][]) => void;
    const value_14: any = v461[1];
    v463 = ((arg_7: [US2, int64, string][]): void => {
        value_14(arg_7);
    });
    const v465: uint8[] = Array.from(get_UTF8().getBytes("profile/tmp/counter"));
    const v466: int32 = v465.length | 0;
    const v467: Mut25 = new Mut25(0, 100000);
    while (method51(v466, v467)) {
        const v469: int32 = v467.l0 | 0;
        const v474: int32 = (v467.l1 + (v465[v469] * 14)) | 0;
        const v475: int32 = (v469 + 1) | 0;
        v467.l0 = (v475 | 0);
        v467.l1 = (v474 | 0);
    }
    const v479: () => any[] = (): any[] => closure242(v145, v433, v448, v452, v457, v462, void 0);
    const v480: (arg0: US4, arg1: any[]) => void = method14(v479, `#${int32ToString(v467.l1)}`);
    v480(US4_US4_0())(["> use_fetch ()"]);
    const v488: any = debounce;
    const v489: (arg0: [US2, any, string][]) => void = (v: [US2, any, string][]): void => {
        closure243(patternInput_1[18], v463, v462, uncurry(2, v480), v145, v146, v458, v457, v);
    };
    const v490: (arg0: [US2, any, string][]) => void = v488(v489, 2500);
    const v491: () => void = (): void => {
        closure247(v433, v490, void 0);
    };
    method17(v491);
    const v492: () => void = (): void => {
        closure248(v490, uncurry(2, v480), void 0);
    };
    method18(v492);
    const v495: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure249(v145, uncurry(2, v480), v433, v146, v458, v457, arg10$0040_3);
    const v497: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v495, US15_US15_2());
    const v499: any = createComponent;
    const v500: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v499(v500, v497);
}

export function closure241(unitVar: void, v0_1: Mut1): any {
    return method52();
}

export function closure269(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure271(v0_1: () => [int64, any][], v1_1: () => [US2, any, string][], v2: () => void, v3: () => void, v4: () => US18, v5: () => [US2, int64, string][], unitVar: void): any[] {
    const v9: [int64, any][] = v0_1();
    v2();
    v3();
    const v16: US18 = v4();
    const v19: [US2, int64, string][] = v5();
    const v20: int32 = v19.length | 0;
    const v21: [US2, int64][] = fill(new Array(v20), 0, v20, null);
    const v22: Mut3 = new Mut3(0);
    while (method5(v20, v22)) {
        const v24: int32 = v22.l0 | 0;
        const patternInput: [US2, int64, string] = v19[v24];
        v21[v24] = [patternInput[0], patternInput[1]];
        const v28: int32 = (v24 + 1) | 0;
        v22.l0 = (v28 | 0);
    }
    const v31: [US2, any, string][] = v1_1();
    const v32: int32 = v31.length | 0;
    const v33: US2[] = fill(new Array(v32), 0, v32, null);
    const v34: Mut3 = new Mut3(0);
    while (method5(v32, v34)) {
        const v36: int32 = v34.l0 | 0;
        const patternInput_1: [US2, any, string] = v31[v36];
        v33[v36] = patternInput_1[0];
        const v40: int32 = (v36 + 1) | 0;
        v34.l0 = (v40 | 0);
    }
    return [["content_address:", "profile/tmp/chain_status"], ["getter:", v9], "events:", "timers:", ["value:", v16], ["subscriptions:", v21], ["db_connections:", v33]];
}

export function closure273(v0_1: US2, unitVar: void): any[] {
    return [["content_address:", "profile/tmp/chain_status"], ["client_type:", v0_1]];
}

export function method63(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: [int64, any][], v9: any): void {
    let copyOfStruct_5: US2, copyOfStruct_1: US2;
    const v10: int64 = op_Division(getTicks(utcNow()), fromBits(1000, 0, false));
    v7(US4_US4_2(), ["> db_on > on_value ()", ["v:", v8], ["k:", v9], ["new_timestamp:", v10]]);
    const v22: US18 = v3();
    if (v22.tag === US18_Tag.US18_1) {
        if ((!equalsWith(equalArrays, v22.fields[2], v8)) && (compare(v10, v22.fields[1]) > 0)) {
            const v73_1: string = "new_value:";
            v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v73_1, v8]]);
            const v76_1: [int64, any][] = v0_1();
            v1_1(v8);
            v2(US18_US18_1(v5, v10, v8));
            const v78: int32 = v6.length | 0;
            const v79: Mut3 = new Mut3(0);
            while (method5(v78, v79)) {
                const v81: int32 = v79.l0 | 0;
                const patternInput_1: [US2, any, string] = v6[v81];
                const v82: US2 = patternInput_1[0];
                if (((copyOfStruct_5 = v82, (copyOfStruct_5.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct_5.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : (v5.tag === US2_Tag.US2_0)))) !== true) {
                    v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v73_1, v8], ["connection_client_type:", v82]]);
                    const v96: string[] = "profile/tmp/chain_status".split("/");
                    const v99: any = patternInput_1[1].get("tictactoe_spiral");
                    const v100: int32 = v96.length | 0;
                    const v101: Mut27 = new Mut27(0, v99);
                    while (method55(v100, v101)) {
                        const v103: int32 = v101.l0 | 0;
                        const v104: any = v101.l1;
                        const v105: string = v96[v103];
                        const v107: any = v104.get(v105);
                        const v108: int32 = (v103 + 1) | 0;
                        v101.l0 = (v108 | 0);
                        v101.l1 = v107;
                    }
                    const v109: any = v101.l1;
                    v109.put(v8);
                }
                const v110: int32 = (v81 + 1) | 0;
                v79.l0 = (v110 | 0);
            }
        }
    }
    else {
        const v27: string = "new_value:";
        v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v27, v8]]);
        const v30: [int64, any][] = v0_1();
        v1_1(v8);
        v2(US18_US18_1(v5, v10, v8));
        const v32: int32 = v6.length | 0;
        const v33: Mut3 = new Mut3(0);
        while (method5(v32, v33)) {
            const v35: int32 = v33.l0 | 0;
            const patternInput: [US2, any, string] = v6[v35];
            const v36: US2 = patternInput[0];
            if (((copyOfStruct_1 = v36, (copyOfStruct_1.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct_1.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : (v5.tag === US2_Tag.US2_0)))) !== true) {
                v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v27, v8], ["connection_client_type:", v36]]);
                const v50: string[] = "profile/tmp/chain_status".split("/");
                const v53: any = patternInput[1].get("tictactoe_spiral");
                const v54: int32 = v50.length | 0;
                const v55: Mut27 = new Mut27(0, v53);
                while (method55(v54, v55)) {
                    const v57: int32 = v55.l0 | 0;
                    const v58: any = v55.l1;
                    const v59: string = v50[v57];
                    const v61: any = v58.get(v59);
                    const v62: int32 = (v57 + 1) | 0;
                    v55.l0 = (v62 | 0);
                    v55.l1 = v61;
                }
                const v63: any = v55.l1;
                v63.put(v8);
            }
            const v64: int32 = (v35 + 1) | 0;
            v33.l0 = (v64 | 0);
        }
    }
}

export function closure275(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: [int64, any][], v9: any): void {
    method63(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9);
}

export function closure274(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: [int64, any][]): (arg0: any) => void {
    return (v: any): void => {
        closure275(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v);
    };
}

export function closure272(v0_1: () => US4, v1_1: (arg0: [US2, int64, string][]) => void, v2: () => [US2, int64, string][], v3: (arg0: US4, arg1: any[]) => void, v4: () => [int64, any][], v5: (arg0: [int64, any][]) => void, v6: (arg0: US18) => void, v7: () => US18, v8: [US2, any, string][]): void {
    let copyOfStruct: US2;
    const v9: [US2, int64, string][] = v2();
    const v10: int32 = v8.length | 0;
    const v11: [US2, int64, string][] = fill(new Array(v10), 0, v10, null);
    const v12: Mut3 = new Mut3(0);
    while (method5(v10, v12)) {
        const v14: int32 = v12.l0 | 0;
        const patternInput: [US2, any, string] = v8[v14];
        const v17: string = patternInput[2];
        const v15: US2 = patternInput[0];
        const v18: int32 = v9.length | 0;
        const v20: Mut26 = new Mut26(0, US17_US17_0());
        while (method53(v18, v20)) {
            const v22: int32 = v20.l0 | 0;
            const v25: int32 = ((op_UnaryNegation_Int32(v22) + v18) - 1) | 0;
            const v26: US17 = v20.l1;
            const patternInput_1: [US2, int64, string] = v9[v25];
            const v29: string = patternInput_1[2];
            const v27: US2 = patternInput_1[0];
            const v39: US17 = (v26.tag === US17_Tag.US17_1) ? v26 : ((((copyOfStruct = v27, (copyOfStruct.tag === US2_Tag.US2_1) ? (v15.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v15.tag === US2_Tag.US2_2) : (v15.tag === US2_Tag.US2_0)))) && (v29 === v17)) ? US17_US17_1(v27, patternInput_1[1], v29) : US17_US17_0());
            const v40: int32 = (v22 + 1) | 0;
            v20.l0 = (v40 | 0);
            v20.l1 = v39;
        }
        const v41: US17 = v20.l1;
        let patternInput_2: [US2, int64, string];
        if (v41.tag === US17_Tag.US17_1) {
            patternInput_2 = [v41.fields[0], v41.fields[1], v41.fields[2]];
        }
        else {
            const v42: () => any[] = (): any[] => closure273(v15, void 0);
            const v44: (arg0: US4, arg1: any[]) => void = method15(v0_1, v42, "#666");
            v44(US4_US4_0())(["> db_on ()"]);
            const v50: (arg0: [int64, any][], arg1: any) => void = (v: [int64, any][]): (arg0: any) => void => closure274(v4, v5, v6, v7, v3, v15, v8, uncurry(2, v44), v);
            let v51: (arg0: [any, any]) => void;
            const clo: (arg0: [any, any]) => void = (v: any, k: any) => v50(v)(k);
            v51 = ((arg: [any, any]): void => {
                clo(arg);
            });
            const v53: string[] = "profile/tmp/chain_status".split("/");
            const v56: any = patternInput[1].get("tictactoe_spiral");
            const v57: int32 = v53.length | 0;
            const v58: Mut27 = new Mut27(0, v56);
            while (method55(v57, v58)) {
                const v60: int32 = v58.l0 | 0;
                const v61: any = v58.l1;
                const v62: string = v53[v60];
                const v64: any = v61.get(v62);
                const v65: int32 = (v60 + 1) | 0;
                v58.l0 = (v65 | 0);
                v58.l1 = v64;
            }
            const v66: any = v58.l1;
            patternInput_2 = [v15, (v15.tag === US2_Tag.US2_1) ? (v66.on(v51)) : ((v15.tag === US2_Tag.US2_2) ? (() => {
                throw new Error("db_on Memory");
            })() : ((v66.on(v51), op_Division(getTicks(utcNow()), fromBits(1000, 0, false))))), v17];
        }
        v11[v14] = [patternInput_2[0], patternInput_2[1], patternInput_2[2]];
        const v77_1: int32 = (v14 + 1) | 0;
        v12.l0 = (v77_1 | 0);
    }
    const v78: int32 = v9.length | 0;
    const v79: [US2, string][] = fill(new Array(v78), 0, v78, null);
    const v80: Mut3 = new Mut3(0);
    while (method5(v78, v80)) {
        const v82: int32 = v80.l0 | 0;
        const patternInput_3: [US2, int64, string] = v9[v82];
        v79[v82] = [patternInput_3[0], patternInput_3[2]];
        const v86: int32 = (v82 + 1) | 0;
        v80.l0 = (v86 | 0);
    }
    const v87: int32 = v11.length | 0;
    const v88: [US2, string][] = fill(new Array(v87), 0, v87, null);
    const v89: Mut3 = new Mut3(0);
    while (method5(v87, v89)) {
        const v91: int32 = v89.l0 | 0;
        const patternInput_4: [US2, int64, string] = v11[v91];
        v88[v91] = [patternInput_4[0], patternInput_4[2]];
        const v95: int32 = (v91 + 1) | 0;
        v89.l0 = (v95 | 0);
    }
    if ((((v79.length === v88.length) !== true) ? false : method56(v79, v88, 0)) !== true) {
        const v105: (arg0: any[]) => void = partialApply(1, v3, [US4_US4_2()]);
        const v108: [US2, int64][] = fill(new Array(v87), 0, v87, null);
        const v109: Mut3 = new Mut3(0);
        while (method5(v87, v109)) {
            const v111: int32 = v109.l0 | 0;
            const patternInput_5: [US2, int64, string] = v11[v111];
            v108[v111] = [patternInput_5[0], patternInput_5[1]];
            const v115: int32 = (v111 + 1) | 0;
            v109.l0 = (v115 | 0);
        }
        v105(["> use_fetch > connections_change", ["new_subscriptions:", v108]]);
        v1_1(v11);
    }
}

export function closure276(v0_1: (arg0: [US2, any, string][]) => void, v1_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1.clear();
    v1_1(US4_US4_0(), ["> use_fetch > unsubscribe () [1]"]);
    toConsole(interpolate("%A%P()", [["db_off", "profile/tmp/chain_status"]]));
}

export function closure279(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Status
    </>];
}

export function closure280(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure281(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure284(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: Error) => void): void {
    v1_1(v0_1());
}

export function closure283(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void): (arg0: (arg0: Error) => void) => void {
    return (v: (arg0: Error) => void): void => {
        closure284(v0_1, v1_1, v);
    };
}

export function closure285(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: [US2, any, string][], v6: int64, v7: [int64, any][]): void {
    const v8: US18 = v3();
    if (v8.tag === US18_Tag.US18_1) {
        if ((!equalsWith(equalArrays, v8.fields[2], v7)) && (compare(v6, v8.fields[1]) > 0)) {
            const v61: string = "new_value:";
            v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v61, v7]]);
            const v64: [int64, any][] = v0_1();
            v1_1(v7);
            v2(US18_US18_1(US2_US2_2(), v6, v7));
            const v67: int32 = v5.length | 0;
            const v68: Mut3 = new Mut3(0);
            while (method5(v67, v68)) {
                const v70: int32 = v68.l0 | 0;
                const patternInput_1: [US2, any, string] = v5[v70];
                const v71: US2 = patternInput_1[0];
                if ((v71.tag === US2_Tag.US2_2) !== true) {
                    v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v61, v7], ["connection_client_type:", v71]]);
                    const v86: string[] = "profile/tmp/chain_status".split("/");
                    const v89: any = patternInput_1[1].get("tictactoe_spiral");
                    const v90: int32 = v86.length | 0;
                    const v91: Mut27 = new Mut27(0, v89);
                    while (method55(v90, v91)) {
                        const v93: int32 = v91.l0 | 0;
                        const v94: any = v91.l1;
                        const v95: string = v86[v93];
                        const v97: any = v94.get(v95);
                        const v98: int32 = (v93 + 1) | 0;
                        v91.l0 = (v98 | 0);
                        v91.l1 = v97;
                    }
                    const v99: any = v91.l1;
                    v99.put(v7);
                }
                const v100: int32 = (v70 + 1) | 0;
                v68.l0 = (v100 | 0);
            }
        }
    }
    else {
        const v13: string = "new_value:";
        v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v13, v7]]);
        const v16: [int64, any][] = v0_1();
        v1_1(v7);
        v2(US18_US18_1(US2_US2_2(), v6, v7));
        const v19: int32 = v5.length | 0;
        const v20: Mut3 = new Mut3(0);
        while (method5(v19, v20)) {
            const v22: int32 = v20.l0 | 0;
            const patternInput: [US2, any, string] = v5[v22];
            const v23: US2 = patternInput[0];
            if ((v23.tag === US2_Tag.US2_2) !== true) {
                v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v13, v7], ["connection_client_type:", v23]]);
                const v38: string[] = "profile/tmp/chain_status".split("/");
                const v41: any = patternInput[1].get("tictactoe_spiral");
                const v42: int32 = v38.length | 0;
                const v43: Mut27 = new Mut27(0, v41);
                while (method55(v42, v43)) {
                    const v45: int32 = v43.l0 | 0;
                    const v46: any = v43.l1;
                    const v47: string = v38[v45];
                    const v49: any = v46.get(v47);
                    const v50: int32 = (v45 + 1) | 0;
                    v43.l0 = (v50 | 0);
                    v43.l1 = v49;
                }
                const v51: any = v43.l1;
                v51.put(v7);
            }
            const v52: int32 = (v22 + 1) | 0;
            v20.l0 = (v52 | 0);
        }
    }
}

export function closure282(v0_1: () => [int64, any][], v1_1: () => [US2, any, string][], v2: (arg0: [int64, any][]) => void, v3: (arg0: US18) => void, v4: () => US18, v5: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    const v6: [US2, any, string][] = v1_1();
    const v7: int64 = op_Division(getTicks(utcNow()), fromBits(1000, 0, false));
    const v9: (arg0: (arg0: [int64, any][]) => void, arg1: (arg0: Error) => void) => void = (v: (arg0: [int64, any][]) => void): (arg0: (arg0: Error) => void) => void => closure283(v0_1, v);
    const v11: (arg0: [int64, any][]) => void = (v_1: [int64, any][]): void => {
        closure285(v0_1, v2, v3, v4, v5, v6, v7, v_1);
    };
    const pr: any = new Promise(uncurry(2, v9));
    void (pr.then(v11));
}

export function closure286(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure287(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure278(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: () => [int64, any][], v2: () => [US2, any, string][], v3: (arg0: [int64, any][]) => void, v4: (arg0: US18) => void, v5: () => US18, unitVar: void): any[] {
    const v8: any = Box;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v20: US9 = patternInput[11];
    let v86: US9;
    if (v20.tag === US9_Tag.US9_1) {
        const v83: any = children_1;
        v86 = US9_US9_1(v83(v20.fields[0]));
    }
    else {
        v86 = US9_US9_0();
    }
    const v92: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v86.tag === US9_Tag.US9_1) ? v86.fields[0] : ((): any[] => closure279(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v93: () => any[] = (): any[] => closure279(void 0, void 0);
    v92.children = v93;
    const v94: (arg0: any) => any = v8;
    const v97: any = createComponent;
    const v98: any = v97(v94, v92);
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v110: US9 = patternInput_1[11];
    const v169: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure280(void 0, arg10$0040_2);
    const v170: () => any = (): any => closure253(void 0, void 0);
    const v171: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v172: Mut7 = new Mut7(v169, v170, v171);
    const v173: any = createComponent;
    const v174: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    const v175: any = v173(v174, v172);
    let v182: US9;
    if (v110.tag === US9_Tag.US9_1) {
        const v179: any = children_1;
        v182 = US9_US9_1(v179(v110.fields[0]));
    }
    else {
        v182 = US9_US9_0();
    }
    const v188: () => void = (): void => {
        closure282(v1_1, v2, v3, v4, v5, v0_1, void 0);
    };
    const v190: string = "10px";
    const v192: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v182.tag === US9_Tag.US9_1) ? v182.fields[0] : ((): any[] => closure281(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US12_US12_1(v175), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], US14_US14_1(v188), patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], US6_US6_1(v190), patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v193: () => any[] = (): any[] => closure281(void 0, void 0);
    v192.children = v193;
    const v194: any = createComponent;
    const v195: (arg0: Mut1) => any = (v_1: Mut1): any => closure40(void 0, v_1);
    const v196: any = v194(v195, v192);
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v208_1: US9 = patternInput_2[11];
    const v267: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_8: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure286(void 0, arg10$0040_8);
    const v268: () => any = (): any => closure260(void 0, void 0);
    const v269: Mut7 = new Mut7(v267, v268, v171);
    const v270: any = createComponent;
    const v271: any = v270(v174, v269);
    let v278: US9;
    if (v208_1.tag === US9_Tag.US9_1) {
        const v275: any = children_1;
        v278 = US9_US9_1(v275(v208_1.fields[0]));
    }
    else {
        v278 = US9_US9_0();
    }
    const v284: () => void = (): void => {
        closure262(v0_1, void 0);
    };
    const v287: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v278.tag === US9_Tag.US9_1) ? v278.fields[0] : ((): any[] => closure287(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US12_US12_1(v271), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US14_US14_1(v284), patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], US6_US6_1(v190), patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]);
    const v288: () => any[] = (): any[] => closure287(void 0, void 0);
    v287.children = v288;
    const v289: any = createComponent;
    return [v98, v196, v289(v195, v287)];
}

export function method64(v0_1: int32, v1_1: Mut29): boolean {
    return v1_1.l0 < v0_1;
}

export function method65(v0_1_mut: UH2, v1_1_mut: UH2): UH2 {
    method65:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: UH2 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH2_UH2_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method65;
        }
        break;
    }
}

export function method67(v0_1_mut: UH2, v1_1_mut: int32): int32 {
    method67:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method67;
        }
        break;
    }
}

export function method68(v0_1_mut: [int64, any][], v1_1_mut: UH2, v2_mut: int32): int32 {
    method68:
    while (true) {
        const v0_1: [int64, any][] = v0_1_mut, v1_1: UH2 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === UH2_Tag.UH2_1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = [v1_1.fields[0], v1_1.fields[1]];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[2];
            v2_mut = (v2 + 1);
            continue method68;
        }
        break;
    }
}

export function method66(v0_1: UH2): [int64, any][] {
    const v2: int32 = method67(v0_1, 0) | 0;
    const v3: [int64, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method68(v3, v0_1, 0) | 0;
    return v3;
}

export function closure293(v0_1: () => [int64, any], unitVar: void): any[] {
    const patternInput: [int64, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure292(v0_1: () => [int64, any], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v16: US9 = patternInput[11];
    let v82: US9;
    if (v16.tag === US9_Tag.US9_1) {
        const v79: any = children_1;
        v82 = US9_US9_1(v79(v16.fields[0]));
    }
    else {
        v82 = US9_US9_0();
    }
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure293(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure293(v0_1, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure291(v0_1: () => [int64, any], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure292(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {toString_1(v0_1()[0])}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure290(unitVar: void, v0_1: () => [int64, any]): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure291(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure289(v0_1: () => [int64, any][], unitVar: void): any[] {
    const v1_1: [int64, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut29 = new Mut29(0, UH2_UH2_1());
    while (method64(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH2 = v4.l1;
        const patternInput: [int64, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH2_UH2_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int64, any][] = method66(method65(v4.l1, UH2_UH2_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int64, any]) => any[] = (v: () => [int64, any]): any[] => closure290(void 0, v);
    const v23: () => any[] = v22;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v35: US9 = patternInput_1[11];
    let v101: US9;
    if (v35.tag === US9_Tag.US9_1) {
        const v98: any = children_1;
        v101 = US9_US9_1(v98(v35.fields[0]));
    }
    else {
        v101 = US9_US9_0();
    }
    const v107: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v101.tag === US9_Tag.US9_1) ? v101.fields[0] : v23), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], US11_US11_1(v18), patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    v107.children = v23;
    const v108: (arg0: any) => any = v21;
    const v110: any = createComponent;
    return [v110(v108, v107)];
}

export function closure288(v0_1: () => [int64, any][], unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v12: US9 = patternInput[11];
    let v78: US9;
    if (v12.tag === US9_Tag.US9_1) {
        const v75_1: any = children_1;
        v78 = US9_US9_1(v75_1(v12.fields[0]));
    }
    else {
        v78 = US9_US9_0();
    }
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure289(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure289(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return [v87(v88, v83)];
}

export function closure277(v0_1: () => [int64, any][], v1_1: (arg0: US4, arg1: any[]) => void, v2: () => [US2, any, string][], v3: (arg0: [int64, any][]) => void, v4: (arg0: US18) => void, v5: () => US18, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v78: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v90: US9 = patternInput[11];
    const v151: string = method12("baseline", "center");
    const v154: string = method12("column", "row");
    const v157: string = method12("8px", "0");
    let v165: US9;
    if (v90.tag === US9_Tag.US9_1) {
        const v162: any = children_1;
        v165 = US9_US9_1(v162(v90.fields[0]));
    }
    else {
        v165 = US9_US9_0();
    }
    const v178: any = createObj(method7(US6_US6_1(v151), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v165.tag === US9_Tag.US9_1) ? v165.fields[0] : ((): any[] => closure278(v1_1, v0_1, v2, v3, v4, v5, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1(v154), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US6_US6_1(v157), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1("3px"), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("7px"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v179: () => any[] = (): any[] => closure278(v1_1, v0_1, v2, v3, v4, v5, void 0);
    v178.children = v179;
    const v180: (arg0: any) => any = v78;
    const v183: any = createComponent;
    const v185: () => any[] = (): any[] => closure288(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v185), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("status"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v183(v180, v178)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method62(): any {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    const v144: (arg0: [int64, any][]) => void = patternInput[15];
    const v143: () => [int64, any][] = patternInput[14];
    const v274: any = components_spi.state_context;
    const v275: any = useContext;
    const patternInput_1: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v275(v274);
    const v421: any = components_spi.state_context;
    const v422: any = useContext;
    const v433: () => [US2, any, string][] = (v422(v421))[10];
    const v446: any = createSignal;
    const v447: any[] = v446();
    let v448: () => void;
    const value_4: any = v447[0];
    v448 = ((): void => {
        value_4();
    });
    let v449: () => void;
    const value_5: any = v447[1];
    v449 = ((): void => {
        value_5();
    });
    const v450: any = createSignal;
    const v451: any[] = v450();
    let v452: () => void;
    const value_7: any = v451[0];
    v452 = ((): void => {
        value_7();
    });
    let v453: () => void;
    const value_8: any = v451[1];
    v453 = ((): void => {
        value_8();
    });
    const v454: any = createSignal;
    const v456: any[] = v454(US18_US18_0());
    let v457: () => US18;
    const value_10: any = v456[0];
    v457 = (value_10);
    let v458: (arg0: US18) => void;
    const value_11: any = v456[1];
    v458 = ((arg_5: US18): void => {
        value_11(arg_5);
    });
    const v460: any = createSignal;
    const v461: any[] = v460([]);
    let v462: () => [US2, int64, string][];
    const value_13: any = v461[0];
    v462 = (value_13);
    let v463: (arg0: [US2, int64, string][]) => void;
    const value_14: any = v461[1];
    v463 = ((arg_7: [US2, int64, string][]): void => {
        value_14(arg_7);
    });
    const v465: uint8[] = Array.from(get_UTF8().getBytes("profile/tmp/chain_status"));
    const v466: int32 = v465.length | 0;
    const v467: Mut25 = new Mut25(0, 100000);
    while (method51(v466, v467)) {
        const v469: int32 = v467.l0 | 0;
        const v474: int32 = (v467.l1 + (v465[v469] * 14)) | 0;
        const v475: int32 = (v469 + 1) | 0;
        v467.l0 = (v475 | 0);
        v467.l1 = (v474 | 0);
    }
    const v479: () => any[] = (): any[] => closure271(v143, v433, v448, v452, v457, v462, void 0);
    const v480: (arg0: US4, arg1: any[]) => void = method14(v479, `#${int32ToString(v467.l1)}`);
    v480(US4_US4_0())(["> use_fetch ()"]);
    const v488: any = debounce;
    const v489: (arg0: [US2, any, string][]) => void = (v: [US2, any, string][]): void => {
        closure272(patternInput_1[18], v463, v462, uncurry(2, v480), v143, v144, v458, v457, v);
    };
    const v490: (arg0: [US2, any, string][]) => void = v488(v489, 2500);
    const v491: () => void = (): void => {
        closure247(v433, v490, void 0);
    };
    method17(v491);
    const v492: () => void = (): void => {
        closure276(v490, uncurry(2, v480), void 0);
    };
    method18(v492);
    const v495: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure277(v143, uncurry(2, v480), v433, v144, v458, v457, arg10$0040_3);
    const v497: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v495, US15_US15_2());
    const v499: any = createComponent;
    const v500: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v499(v500, v497);
}

export function closure270(unitVar: void, v0_1: Mut1): any {
    return method62();
}

export function closure294(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure296(v0_1: () => [int64, any][], v1_1: () => [US2, any, string][], v2: () => void, v3: () => void, v4: () => US18, v5: () => [US2, int64, string][], unitVar: void): any[] {
    const v9: [int64, any][] = v0_1();
    v2();
    v3();
    const v16: US18 = v4();
    const v19: [US2, int64, string][] = v5();
    const v20: int32 = v19.length | 0;
    const v21: [US2, int64][] = fill(new Array(v20), 0, v20, null);
    const v22: Mut3 = new Mut3(0);
    while (method5(v20, v22)) {
        const v24: int32 = v22.l0 | 0;
        const patternInput: [US2, int64, string] = v19[v24];
        v21[v24] = [patternInput[0], patternInput[1]];
        const v28: int32 = (v24 + 1) | 0;
        v22.l0 = (v28 | 0);
    }
    const v31: [US2, any, string][] = v1_1();
    const v32: int32 = v31.length | 0;
    const v33: US2[] = fill(new Array(v32), 0, v32, null);
    const v34: Mut3 = new Mut3(0);
    while (method5(v32, v34)) {
        const v36: int32 = v34.l0 | 0;
        const patternInput_1: [US2, any, string] = v31[v36];
        v33[v36] = patternInput_1[0];
        const v40: int32 = (v36 + 1) | 0;
        v34.l0 = (v40 | 0);
    }
    return [["content_address:", "profile/tmp/chain_deploy"], ["getter:", v9], "events:", "timers:", ["value:", v16], ["subscriptions:", v21], ["db_connections:", v33]];
}

export function closure298(v0_1: US2, unitVar: void): any[] {
    return [["content_address:", "profile/tmp/chain_deploy"], ["client_type:", v0_1]];
}

export function method70(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: [int64, any][], v9: any): void {
    let copyOfStruct_5: US2, copyOfStruct_1: US2;
    const v10: int64 = op_Division(getTicks(utcNow()), fromBits(1000, 0, false));
    v7(US4_US4_2(), ["> db_on > on_value ()", ["v:", v8], ["k:", v9], ["new_timestamp:", v10]]);
    const v22: US18 = v3();
    if (v22.tag === US18_Tag.US18_1) {
        if ((!equalsWith(equalArrays, v22.fields[2], v8)) && (compare(v10, v22.fields[1]) > 0)) {
            const v73_1: string = "new_value:";
            v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v73_1, v8]]);
            const v76_1: [int64, any][] = v0_1();
            v1_1(v8);
            v2(US18_US18_1(v5, v10, v8));
            const v78: int32 = v6.length | 0;
            const v79: Mut3 = new Mut3(0);
            while (method5(v78, v79)) {
                const v81: int32 = v79.l0 | 0;
                const patternInput_1: [US2, any, string] = v6[v81];
                const v82: US2 = patternInput_1[0];
                if (((copyOfStruct_5 = v82, (copyOfStruct_5.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct_5.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : (v5.tag === US2_Tag.US2_0)))) !== true) {
                    v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v73_1, v8], ["connection_client_type:", v82]]);
                    const v96: string[] = "profile/tmp/chain_deploy".split("/");
                    const v99: any = patternInput_1[1].get("tictactoe_spiral");
                    const v100: int32 = v96.length | 0;
                    const v101: Mut27 = new Mut27(0, v99);
                    while (method55(v100, v101)) {
                        const v103: int32 = v101.l0 | 0;
                        const v104: any = v101.l1;
                        const v105: string = v96[v103];
                        const v107: any = v104.get(v105);
                        const v108: int32 = (v103 + 1) | 0;
                        v101.l0 = (v108 | 0);
                        v101.l1 = v107;
                    }
                    const v109: any = v101.l1;
                    v109.put(v8);
                }
                const v110: int32 = (v81 + 1) | 0;
                v79.l0 = (v110 | 0);
            }
        }
    }
    else {
        const v27: string = "new_value:";
        v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v27, v8]]);
        const v30: [int64, any][] = v0_1();
        v1_1(v8);
        v2(US18_US18_1(v5, v10, v8));
        const v32: int32 = v6.length | 0;
        const v33: Mut3 = new Mut3(0);
        while (method5(v32, v33)) {
            const v35: int32 = v33.l0 | 0;
            const patternInput: [US2, any, string] = v6[v35];
            const v36: US2 = patternInput[0];
            if (((copyOfStruct_1 = v36, (copyOfStruct_1.tag === US2_Tag.US2_1) ? (v5.tag === US2_Tag.US2_1) : ((copyOfStruct_1.tag === US2_Tag.US2_2) ? (v5.tag === US2_Tag.US2_2) : (v5.tag === US2_Tag.US2_0)))) !== true) {
                v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v27, v8], ["connection_client_type:", v36]]);
                const v50: string[] = "profile/tmp/chain_deploy".split("/");
                const v53: any = patternInput[1].get("tictactoe_spiral");
                const v54: int32 = v50.length | 0;
                const v55: Mut27 = new Mut27(0, v53);
                while (method55(v54, v55)) {
                    const v57: int32 = v55.l0 | 0;
                    const v58: any = v55.l1;
                    const v59: string = v50[v57];
                    const v61: any = v58.get(v59);
                    const v62: int32 = (v57 + 1) | 0;
                    v55.l0 = (v62 | 0);
                    v55.l1 = v61;
                }
                const v63: any = v55.l1;
                v63.put(v8);
            }
            const v64: int32 = (v35 + 1) | 0;
            v33.l0 = (v64 | 0);
        }
    }
}

export function closure300(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: [int64, any][], v9: any): void {
    method70(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9);
}

export function closure299(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: US2, v6: [US2, any, string][], v7: (arg0: US4, arg1: any[]) => void, v8: [int64, any][]): (arg0: any) => void {
    return (v: any): void => {
        closure300(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v);
    };
}

export function closure297(v0_1: () => US4, v1_1: (arg0: [US2, int64, string][]) => void, v2: () => [US2, int64, string][], v3: (arg0: US4, arg1: any[]) => void, v4: () => [int64, any][], v5: (arg0: [int64, any][]) => void, v6: (arg0: US18) => void, v7: () => US18, v8: [US2, any, string][]): void {
    let copyOfStruct: US2;
    const v9: [US2, int64, string][] = v2();
    const v10: int32 = v8.length | 0;
    const v11: [US2, int64, string][] = fill(new Array(v10), 0, v10, null);
    const v12: Mut3 = new Mut3(0);
    while (method5(v10, v12)) {
        const v14: int32 = v12.l0 | 0;
        const patternInput: [US2, any, string] = v8[v14];
        const v17: string = patternInput[2];
        const v15: US2 = patternInput[0];
        const v18: int32 = v9.length | 0;
        const v20: Mut26 = new Mut26(0, US17_US17_0());
        while (method53(v18, v20)) {
            const v22: int32 = v20.l0 | 0;
            const v25: int32 = ((op_UnaryNegation_Int32(v22) + v18) - 1) | 0;
            const v26: US17 = v20.l1;
            const patternInput_1: [US2, int64, string] = v9[v25];
            const v29: string = patternInput_1[2];
            const v27: US2 = patternInput_1[0];
            const v39: US17 = (v26.tag === US17_Tag.US17_1) ? v26 : ((((copyOfStruct = v27, (copyOfStruct.tag === US2_Tag.US2_1) ? (v15.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v15.tag === US2_Tag.US2_2) : (v15.tag === US2_Tag.US2_0)))) && (v29 === v17)) ? US17_US17_1(v27, patternInput_1[1], v29) : US17_US17_0());
            const v40: int32 = (v22 + 1) | 0;
            v20.l0 = (v40 | 0);
            v20.l1 = v39;
        }
        const v41: US17 = v20.l1;
        let patternInput_2: [US2, int64, string];
        if (v41.tag === US17_Tag.US17_1) {
            patternInput_2 = [v41.fields[0], v41.fields[1], v41.fields[2]];
        }
        else {
            const v42: () => any[] = (): any[] => closure298(v15, void 0);
            const v44: (arg0: US4, arg1: any[]) => void = method15(v0_1, v42, "#666");
            v44(US4_US4_0())(["> db_on ()"]);
            const v50: (arg0: [int64, any][], arg1: any) => void = (v: [int64, any][]): (arg0: any) => void => closure299(v4, v5, v6, v7, v3, v15, v8, uncurry(2, v44), v);
            let v51: (arg0: [any, any]) => void;
            const clo: (arg0: [any, any]) => void = (v: any, k: any) => v50(v)(k);
            v51 = ((arg: [any, any]): void => {
                clo(arg);
            });
            const v53: string[] = "profile/tmp/chain_deploy".split("/");
            const v56: any = patternInput[1].get("tictactoe_spiral");
            const v57: int32 = v53.length | 0;
            const v58: Mut27 = new Mut27(0, v56);
            while (method55(v57, v58)) {
                const v60: int32 = v58.l0 | 0;
                const v61: any = v58.l1;
                const v62: string = v53[v60];
                const v64: any = v61.get(v62);
                const v65: int32 = (v60 + 1) | 0;
                v58.l0 = (v65 | 0);
                v58.l1 = v64;
            }
            const v66: any = v58.l1;
            patternInput_2 = [v15, (v15.tag === US2_Tag.US2_1) ? (v66.on(v51)) : ((v15.tag === US2_Tag.US2_2) ? (() => {
                throw new Error("db_on Memory");
            })() : ((v66.on(v51), op_Division(getTicks(utcNow()), fromBits(1000, 0, false))))), v17];
        }
        v11[v14] = [patternInput_2[0], patternInput_2[1], patternInput_2[2]];
        const v77_1: int32 = (v14 + 1) | 0;
        v12.l0 = (v77_1 | 0);
    }
    const v78: int32 = v9.length | 0;
    const v79: [US2, string][] = fill(new Array(v78), 0, v78, null);
    const v80: Mut3 = new Mut3(0);
    while (method5(v78, v80)) {
        const v82: int32 = v80.l0 | 0;
        const patternInput_3: [US2, int64, string] = v9[v82];
        v79[v82] = [patternInput_3[0], patternInput_3[2]];
        const v86: int32 = (v82 + 1) | 0;
        v80.l0 = (v86 | 0);
    }
    const v87: int32 = v11.length | 0;
    const v88: [US2, string][] = fill(new Array(v87), 0, v87, null);
    const v89: Mut3 = new Mut3(0);
    while (method5(v87, v89)) {
        const v91: int32 = v89.l0 | 0;
        const patternInput_4: [US2, int64, string] = v11[v91];
        v88[v91] = [patternInput_4[0], patternInput_4[2]];
        const v95: int32 = (v91 + 1) | 0;
        v89.l0 = (v95 | 0);
    }
    if ((((v79.length === v88.length) !== true) ? false : method56(v79, v88, 0)) !== true) {
        const v105: (arg0: any[]) => void = partialApply(1, v3, [US4_US4_2()]);
        const v108: [US2, int64][] = fill(new Array(v87), 0, v87, null);
        const v109: Mut3 = new Mut3(0);
        while (method5(v87, v109)) {
            const v111: int32 = v109.l0 | 0;
            const patternInput_5: [US2, int64, string] = v11[v111];
            v108[v111] = [patternInput_5[0], patternInput_5[1]];
            const v115: int32 = (v111 + 1) | 0;
            v109.l0 = (v115 | 0);
        }
        v105(["> use_fetch > connections_change", ["new_subscriptions:", v108]]);
        v1_1(v11);
    }
}

export function closure301(v0_1: (arg0: [US2, any, string][]) => void, v1_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1.clear();
    v1_1(US4_US4_0(), ["> use_fetch > unsubscribe () [1]"]);
    toConsole(interpolate("%A%P()", [["db_off", "profile/tmp/chain_deploy"]]));
}

export function closure304(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Deploy
    </>];
}

export function closure305(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure306(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure309(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: Error) => void): void {
    v1_1(v0_1());
}

export function closure308(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void): (arg0: (arg0: Error) => void) => void {
    return (v: (arg0: Error) => void): void => {
        closure309(v0_1, v1_1, v);
    };
}

export function closure310(v0_1: () => [int64, any][], v1_1: (arg0: [int64, any][]) => void, v2: (arg0: US18) => void, v3: () => US18, v4: (arg0: US4, arg1: any[]) => void, v5: [US2, any, string][], v6: int64, v7: [int64, any][]): void {
    const v8: US18 = v3();
    if (v8.tag === US18_Tag.US18_1) {
        if ((!equalsWith(equalArrays, v8.fields[2], v7)) && (compare(v6, v8.fields[1]) > 0)) {
            const v61: string = "new_value:";
            v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v61, v7]]);
            const v64: [int64, any][] = v0_1();
            v1_1(v7);
            v2(US18_US18_1(US2_US2_2(), v6, v7));
            const v67: int32 = v5.length | 0;
            const v68: Mut3 = new Mut3(0);
            while (method5(v67, v68)) {
                const v70: int32 = v68.l0 | 0;
                const patternInput_1: [US2, any, string] = v5[v70];
                const v71: US2 = patternInput_1[0];
                if ((v71.tag === US2_Tag.US2_2) !== true) {
                    v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v61, v7], ["connection_client_type:", v71]]);
                    const v86: string[] = "profile/tmp/chain_deploy".split("/");
                    const v89: any = patternInput_1[1].get("tictactoe_spiral");
                    const v90: int32 = v86.length | 0;
                    const v91: Mut27 = new Mut27(0, v89);
                    while (method55(v90, v91)) {
                        const v93: int32 = v91.l0 | 0;
                        const v94: any = v91.l1;
                        const v95: string = v86[v93];
                        const v97: any = v94.get(v95);
                        const v98: int32 = (v93 + 1) | 0;
                        v91.l0 = (v98 | 0);
                        v91.l1 = v97;
                    }
                    const v99: any = v91.l1;
                    v99.put(v7);
                }
                const v100: int32 = (v70 + 1) | 0;
                v68.l0 = (v100 | 0);
            }
        }
    }
    else {
        const v13: string = "new_value:";
        v4(US4_US4_2(), ["> use_fetch > on_value > set ()", [v13, v7]]);
        const v16: [int64, any][] = v0_1();
        v1_1(v7);
        v2(US18_US18_1(US2_US2_2(), v6, v7));
        const v19: int32 = v5.length | 0;
        const v20: Mut3 = new Mut3(0);
        while (method5(v19, v20)) {
            const v22: int32 = v20.l0 | 0;
            const patternInput: [US2, any, string] = v5[v22];
            const v23: US2 = patternInput[0];
            if ((v23.tag === US2_Tag.US2_2) !== true) {
                v4(US4_US4_2(), ["> use_fetch > on_value > set () > db_put", [v13, v7], ["connection_client_type:", v23]]);
                const v38: string[] = "profile/tmp/chain_deploy".split("/");
                const v41: any = patternInput[1].get("tictactoe_spiral");
                const v42: int32 = v38.length | 0;
                const v43: Mut27 = new Mut27(0, v41);
                while (method55(v42, v43)) {
                    const v45: int32 = v43.l0 | 0;
                    const v46: any = v43.l1;
                    const v47: string = v38[v45];
                    const v49: any = v46.get(v47);
                    const v50: int32 = (v45 + 1) | 0;
                    v43.l0 = (v50 | 0);
                    v43.l1 = v49;
                }
                const v51: any = v43.l1;
                v51.put(v7);
            }
            const v52: int32 = (v22 + 1) | 0;
            v20.l0 = (v52 | 0);
        }
    }
}

export function closure307(v0_1: () => [int64, any][], v1_1: () => [US2, any, string][], v2: (arg0: [int64, any][]) => void, v3: (arg0: US18) => void, v4: () => US18, v5: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    const v6: [US2, any, string][] = v1_1();
    const v7: int64 = op_Division(getTicks(utcNow()), fromBits(1000, 0, false));
    const v9: (arg0: (arg0: [int64, any][]) => void, arg1: (arg0: Error) => void) => void = (v: (arg0: [int64, any][]) => void): (arg0: (arg0: Error) => void) => void => closure308(v0_1, v);
    const v11: (arg0: [int64, any][]) => void = (v_1: [int64, any][]): void => {
        closure310(v0_1, v2, v3, v4, v5, v6, v7, v_1);
    };
    const pr: any = new Promise(uncurry(2, v9));
    void (pr.then(v11));
}

export function closure311(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure312(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure303(v0_1: (arg0: US4, arg1: any[]) => void, v1_1: () => [int64, any][], v2: () => [US2, any, string][], v3: (arg0: [int64, any][]) => void, v4: (arg0: US18) => void, v5: () => US18, unitVar: void): any[] {
    const v8: any = Box;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v20: US9 = patternInput[11];
    let v86: US9;
    if (v20.tag === US9_Tag.US9_1) {
        const v83: any = children_1;
        v86 = US9_US9_1(v83(v20.fields[0]));
    }
    else {
        v86 = US9_US9_0();
    }
    const v92: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v86.tag === US9_Tag.US9_1) ? v86.fields[0] : ((): any[] => closure304(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v93: () => any[] = (): any[] => closure304(void 0, void 0);
    v92.children = v93;
    const v94: (arg0: any) => any = v8;
    const v97: any = createComponent;
    const v98: any = v97(v94, v92);
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v110: US9 = patternInput_1[11];
    const v169: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure305(void 0, arg10$0040_2);
    const v170: () => any = (): any => closure253(void 0, void 0);
    const v171: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v172: Mut7 = new Mut7(v169, v170, v171);
    const v173: any = createComponent;
    const v174: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    const v175: any = v173(v174, v172);
    let v182: US9;
    if (v110.tag === US9_Tag.US9_1) {
        const v179: any = children_1;
        v182 = US9_US9_1(v179(v110.fields[0]));
    }
    else {
        v182 = US9_US9_0();
    }
    const v188: () => void = (): void => {
        closure307(v1_1, v2, v3, v4, v5, v0_1, void 0);
    };
    const v190: string = "10px";
    const v192: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v182.tag === US9_Tag.US9_1) ? v182.fields[0] : ((): any[] => closure306(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US12_US12_1(v175), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], US14_US14_1(v188), patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], US6_US6_1(v190), patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v193: () => any[] = (): any[] => closure306(void 0, void 0);
    v192.children = v193;
    const v194: any = createComponent;
    const v195: (arg0: Mut1) => any = (v_1: Mut1): any => closure40(void 0, v_1);
    const v196: any = v194(v195, v192);
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v208_1: US9 = patternInput_2[11];
    const v267: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_8: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure311(void 0, arg10$0040_8);
    const v268: () => any = (): any => closure260(void 0, void 0);
    const v269: Mut7 = new Mut7(v267, v268, v171);
    const v270: any = createComponent;
    const v271: any = v270(v174, v269);
    let v278: US9;
    if (v208_1.tag === US9_Tag.US9_1) {
        const v275: any = children_1;
        v278 = US9_US9_1(v275(v208_1.fields[0]));
    }
    else {
        v278 = US9_US9_0();
    }
    const v284: () => void = (): void => {
        closure262(v0_1, void 0);
    };
    const v287: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v278.tag === US9_Tag.US9_1) ? v278.fields[0] : ((): any[] => closure312(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US12_US12_1(v271), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US14_US14_1(v284), patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], US6_US6_1(v190), patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]);
    const v288: () => any[] = (): any[] => closure312(void 0, void 0);
    v287.children = v288;
    const v289: any = createComponent;
    return [v98, v196, v289(v195, v287)];
}

export function closure318(v0_1: () => [int64, any], unitVar: void): any[] {
    const patternInput: [int64, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure317(v0_1: () => [int64, any], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v16: US9 = patternInput[11];
    let v82: US9;
    if (v16.tag === US9_Tag.US9_1) {
        const v79: any = children_1;
        v82 = US9_US9_1(v79(v16.fields[0]));
    }
    else {
        v82 = US9_US9_0();
    }
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure318(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure318(v0_1, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure316(v0_1: () => [int64, any], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure317(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {toString_1(v0_1()[0])}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure315(unitVar: void, v0_1: () => [int64, any]): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure316(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure314(v0_1: () => [int64, any][], unitVar: void): any[] {
    const v1_1: [int64, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut29 = new Mut29(0, UH2_UH2_1());
    while (method64(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH2 = v4.l1;
        const patternInput: [int64, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH2_UH2_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int64, any][] = method66(method65(v4.l1, UH2_UH2_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int64, any]) => any[] = (v: () => [int64, any]): any[] => closure315(void 0, v);
    const v23: () => any[] = v22;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v35: US9 = patternInput_1[11];
    let v101: US9;
    if (v35.tag === US9_Tag.US9_1) {
        const v98: any = children_1;
        v101 = US9_US9_1(v98(v35.fields[0]));
    }
    else {
        v101 = US9_US9_0();
    }
    const v107: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v101.tag === US9_Tag.US9_1) ? v101.fields[0] : v23), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], US11_US11_1(v18), patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    v107.children = v23;
    const v108: (arg0: any) => any = v21;
    const v110: any = createComponent;
    return [v110(v108, v107)];
}

export function closure313(v0_1: () => [int64, any][], unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v12: US9 = patternInput[11];
    let v78: US9;
    if (v12.tag === US9_Tag.US9_1) {
        const v75_1: any = children_1;
        v78 = US9_US9_1(v75_1(v12.fields[0]));
    }
    else {
        v78 = US9_US9_0();
    }
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure314(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure314(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return [v87(v88, v83)];
}

export function closure302(v0_1: () => [int64, any][], v1_1: (arg0: US4, arg1: any[]) => void, v2: () => [US2, any, string][], v3: (arg0: [int64, any][]) => void, v4: (arg0: US18) => void, v5: () => US18, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v78: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v90: US9 = patternInput[11];
    const v151: string = method12("baseline", "center");
    const v154: string = method12("column", "row");
    const v157: string = method12("8px", "0");
    let v165: US9;
    if (v90.tag === US9_Tag.US9_1) {
        const v162: any = children_1;
        v165 = US9_US9_1(v162(v90.fields[0]));
    }
    else {
        v165 = US9_US9_0();
    }
    const v178: any = createObj(method7(US6_US6_1(v151), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v165.tag === US9_Tag.US9_1) ? v165.fields[0] : ((): any[] => closure303(v1_1, v0_1, v2, v3, v4, v5, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1(v154), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US6_US6_1(v157), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1("3px"), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("7px"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v179: () => any[] = (): any[] => closure303(v1_1, v0_1, v2, v3, v4, v5, void 0);
    v178.children = v179;
    const v180: (arg0: any) => any = v78;
    const v183: any = createComponent;
    const v185: () => any[] = (): any[] => closure313(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v185), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("deploy"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v183(v180, v178)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method69(): any {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    const v142: (arg0: [int64, any][]) => void = patternInput[13];
    const v141: () => [int64, any][] = patternInput[12];
    const v274: any = components_spi.state_context;
    const v275: any = useContext;
    const patternInput_1: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v275(v274);
    const v421: any = components_spi.state_context;
    const v422: any = useContext;
    const v433: () => [US2, any, string][] = (v422(v421))[10];
    const v446: any = createSignal;
    const v447: any[] = v446();
    let v448: () => void;
    const value_4: any = v447[0];
    v448 = ((): void => {
        value_4();
    });
    let v449: () => void;
    const value_5: any = v447[1];
    v449 = ((): void => {
        value_5();
    });
    const v450: any = createSignal;
    const v451: any[] = v450();
    let v452: () => void;
    const value_7: any = v451[0];
    v452 = ((): void => {
        value_7();
    });
    let v453: () => void;
    const value_8: any = v451[1];
    v453 = ((): void => {
        value_8();
    });
    const v454: any = createSignal;
    const v456: any[] = v454(US18_US18_0());
    let v457: () => US18;
    const value_10: any = v456[0];
    v457 = (value_10);
    let v458: (arg0: US18) => void;
    const value_11: any = v456[1];
    v458 = ((arg_5: US18): void => {
        value_11(arg_5);
    });
    const v460: any = createSignal;
    const v461: any[] = v460([]);
    let v462: () => [US2, int64, string][];
    const value_13: any = v461[0];
    v462 = (value_13);
    let v463: (arg0: [US2, int64, string][]) => void;
    const value_14: any = v461[1];
    v463 = ((arg_7: [US2, int64, string][]): void => {
        value_14(arg_7);
    });
    const v465: uint8[] = Array.from(get_UTF8().getBytes("profile/tmp/chain_deploy"));
    const v466: int32 = v465.length | 0;
    const v467: Mut25 = new Mut25(0, 100000);
    while (method51(v466, v467)) {
        const v469: int32 = v467.l0 | 0;
        const v474: int32 = (v467.l1 + (v465[v469] * 14)) | 0;
        const v475: int32 = (v469 + 1) | 0;
        v467.l0 = (v475 | 0);
        v467.l1 = (v474 | 0);
    }
    const v479: () => any[] = (): any[] => closure296(v141, v433, v448, v452, v457, v462, void 0);
    const v480: (arg0: US4, arg1: any[]) => void = method14(v479, `#${int32ToString(v467.l1)}`);
    v480(US4_US4_0())(["> use_fetch ()"]);
    const v488: any = debounce;
    const v489: (arg0: [US2, any, string][]) => void = (v: [US2, any, string][]): void => {
        closure297(patternInput_1[18], v463, v462, uncurry(2, v480), v141, v142, v458, v457, v);
    };
    const v490: (arg0: [US2, any, string][]) => void = v488(v489, 2500);
    const v491: () => void = (): void => {
        closure247(v433, v490, void 0);
    };
    method17(v491);
    const v492: () => void = (): void => {
        closure301(v490, uncurry(2, v480), void 0);
    };
    method18(v492);
    const v495: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure302(v141, uncurry(2, v480), v433, v142, v458, v457, arg10$0040_3);
    const v497: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v495, US15_US15_2());
    const v499: any = createComponent;
    const v500: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v499(v500, v497);
}

export function closure295(unitVar: void, v0_1: Mut1): any {
    return method69();
}

export function closure239(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v108: US9, v173: US9, v170: any, v178: Mut1, v179: () => any[], v180: any, v181: (arg0: Mut1) => any, patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v197: US9, v262: US9, v259: any, v267: Mut1, v268: () => any[], v269: any, v270: (arg0: Mut1) => any;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v16: US9 = patternInput[11];
    let v82: US9;
    if (v16.tag === US9_Tag.US9_1) {
        const v79: any = children_1;
        v82 = US9_US9_1(v79(v16.fields[0]));
    }
    else {
        v82 = US9_US9_0();
    }
    const v87: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure240(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v88: () => any[] = (): any[] => closure240(void 0, void 0);
    v87.children = v88;
    const v91: any = createComponent;
    const v92: (arg0: Mut1) => any = (v: Mut1): any => closure241(void 0, v);
    const v96: boolean = (v2 === "") !== true;
    return [v91(v92, v87), v96 ? ((patternInput_1 = method3(), (v108 = patternInput_1[11], (v173 = ((v108.tag === US9_Tag.US9_1) ? ((v170 = children_1, US9_US9_1(v170(v108.fields[0])))) : US9_US9_0()), (v178 = (new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v173.tag === US9_Tag.US9_1) ? v173.fields[0] : ((): any[] => closure269(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69])), (v179 = ((): any[] => closure269(void 0, void 0)), (v178.children = v179, (v180 = createComponent, (v181 = ((v_1: Mut1): any => closure270(void 0, v_1)), v180(v181, v178)))))))))) : (void 0), v96 ? ((patternInput_2 = method3(), (v197 = patternInput_2[11], (v262 = ((v197.tag === US9_Tag.US9_1) ? ((v259 = children_1, US9_US9_1(v259(v197.fields[0])))) : US9_US9_0()), (v267 = (new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v262.tag === US9_Tag.US9_1) ? v262.fields[0] : ((): any[] => closure294(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69])), (v268 = ((): any[] => closure294(void 0, void 0)), (v267.children = v268, (v269 = createComponent, (v270 = ((v_2: Mut1): any => closure295(void 0, v_2)), v269(v270, v267)))))))))) : (void 0)];
}

export function closure238(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v16: US9 = patternInput[11];
    let v82: US9;
    if (v16.tag === US9_Tag.US9_1) {
        const v79: any = children_1;
        v82 = US9_US9_1(v79(v16.fields[0]));
    }
    else {
        v82 = US9_US9_0();
    }
    const v87: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure239(v0_1, v1_1, v2, v3, v4, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v88: () => any[] = (): any[] => closure239(v0_1, v1_1, v2, v3, v4, void 0);
    v87.children = v88;
    const v91: any = createComponent;
    const v92: (arg0: Mut1) => any = (v: Mut1): any => closure117(void 0, v);
    return [v91(v92, v87)];
}

export function closure237(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v78: () => any[] = (): any[] => closure238(v0_1, v1_1, v2, v3, v4, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v78), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Profile
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure120(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure121(void 0, arg10$0040);
    const v9: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v7, US15_US15_2());
    const v12: any = createComponent;
    const v13: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v17: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_1);
    const v19: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v20: any = createComponent;
    const v24: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure140(void 0, arg10$0040_2);
    const v26: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v24, US15_US15_2());
    const v27: any = createComponent;
    const v32: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v33: any = createComponent;
    const v37: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure152(void 0, arg10$0040_3);
    const v39: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v37, US15_US15_0());
    const v40: any = createComponent;
    const v45: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v46: any = createComponent;
    const v50: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure197(void 0, arg10$0040_4);
    const v52: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v50, US15_US15_0());
    const v53: any = createComponent;
    const v58: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v59: any = createComponent;
    const v63: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_5: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure237(v0_1, v1_1, v2, v3, v4, arg10$0040_5);
    const v65: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v63, US15_US15_2());
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
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v26: US9 = patternInput[11];
    let v92: US9;
    if (v26.tag === US9_Tag.US9_1) {
        const v89: any = children_1;
        v92 = US9_US9_1(v89(v26.fields[0]));
    }
    else {
        v92 = US9_US9_0();
    }
    const v107: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v92.tag === US9_Tag.US9_1) ? v92.fields[0] : ((): any[] => closure120(v0_1, v1_1, v2, v3, v4, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], US6_US6_1("1"), US6_US6_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US6_US6_1("hidden"), US6_US6_1("auto"), patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v108: () => any[] = (): any[] => closure120(v0_1, v1_1, v2, v3, v4, void 0);
    v107.children = v108;
    const v111: any = createComponent;
    const v112: (arg0: Mut1) => any = (v_1: Mut1): any => closure117(void 0, v_1);
    return [v14, v111(v112, v107)];
}

export function method1(): any {
    const patternInput: [string, any, string, string, boolean] = method2();
    const v4: boolean = patternInput[4];
    const v3: string = patternInput[3];
    const v2: string = patternInput[2];
    const v1_1: any = patternInput[1];
    const v0_1: string = patternInput[0];
    const v7: any = Box;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v19: US9 = patternInput_1[11];
    let v85: US9;
    if (v19.tag === US9_Tag.US9_1) {
        const v82: any = children_1;
        v85 = US9_US9_1(v82(v19.fields[0]));
    }
    else {
        v85 = US9_US9_0();
    }
    const v109: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], US6_US6_1("$bg"), patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v85.tag === US9_Tag.US9_1) ? v85.fields[0] : ((): any[] => closure1(v0_1, v1_1, v2, v3, v4, void 0))), US6_US6_1("$text1"), patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US6_US6_1("flex"), patternInput_1[19], patternInput_1[20], US6_US6_1("1"), US6_US6_1("column"), patternInput_1[23], US6_US6_1("$sm"), US6_US6_1("100vh"), patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], US6_US6_1("100vw"), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], US6_US6_1("1px"), patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    const v110: () => any[] = (): any[] => closure1(v0_1, v1_1, v2, v3, v4, void 0);
    v109.children = v110;
    const v111: (arg0: any) => any = v7;
    const v114: any = createComponent;
    return v114(v111, v109);
}

export function closure0(unitVar: void, v0_1: Mut1): any {
    return method1();
}

export function closure320(v0_1: () => [US2, any, string][], v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
    return [["db_connection_options\':", v1_1()], ["db_connections\':", v0_1()]];
}

export function method72(v0_1: int32, v1_1: Mut30): boolean {
    return v1_1.l0 < v0_1;
}

export function method73(v0_1: int32, v1_1: Mut31): boolean {
    return v1_1.l0 < v0_1;
}

export function method74(v0_1: int32, v1_1: Mut32): boolean {
    return v1_1.l0 < v0_1;
}

export function closure321(v0_1: (arg0: [US2, any, string][]) => void, v1_1: (arg0: US4, arg1: any[]) => void, _arg: [[US2[], int32, US3, string, string][], [US2, any, string][]]): void {
    let copyOfStruct: US2, v94: any, v78: any, v90: any;
    const v3: [US2, any, string][] = _arg[1];
    const v2: [US2[], int32, US3, string, string][] = _arg[0];
    const v4: int32 = v2.length | 0;
    const v5: [US2, any, string][][] = fill(new Array(v4), 0, v4, null);
    const v6: Mut3 = new Mut3(0);
    while (method5(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v2[v8];
        const v9: US2[] = patternInput[0];
        const v11: US3 = patternInput[2];
        const v14: int32 = v9.length | 0;
        const v15: [US2, any, string][] = fill(new Array(v14), 0, v14, null);
        const v16: Mut3 = new Mut3(0);
        while (method5(v14, v16)) {
            const v18: int32 = v16.l0 | 0;
            const v19: US2 = v9[v18];
            const v20: int32 = v3.length | 0;
            const v22: Mut30 = new Mut30(0, US19_US19_0());
            while (method72(v20, v22)) {
                const v24: int32 = v22.l0 | 0;
                const v27: int32 = ((op_UnaryNegation_Int32(v24) + v20) - 1) | 0;
                const v28: US19 = v22.l1;
                const patternInput_1: [US2, any, string] = v3[v27];
                const v31: string = patternInput_1[2];
                const v29: US2 = patternInput_1[0];
                const v41: US19 = (v28.tag === US19_Tag.US19_1) ? v28 : ((((copyOfStruct = v29, (copyOfStruct.tag === US2_Tag.US2_1) ? (v19.tag === US2_Tag.US2_1) : ((copyOfStruct.tag === US2_Tag.US2_2) ? (v19.tag === US2_Tag.US2_2) : (v19.tag === US2_Tag.US2_0)))) && (v31 === patternInput[3])) ? US19_US19_1(v29, patternInput_1[1], v31) : US19_US19_0());
                const v42: int32 = (v24 + 1) | 0;
                v22.l0 = (v42 | 0);
                v22.l1 = v41;
            }
            const v43: US19 = v22.l1;
            let patternInput_3: [US2, any, string];
            if (v43.tag === US19_Tag.US19_1) {
                patternInput_3 = [v43.fields[0], v43.fields[1], v43.fields[2]];
            }
            else {
                const v45: Mut31 = new Mut31(0, US20_US20_0());
                while (method73(v4, v45)) {
                    const v47: int32 = v45.l0 | 0;
                    const v50: int32 = ((op_UnaryNegation_Int32(v47) + v4) - 1) | 0;
                    const v51: US20 = v45.l1;
                    const patternInput_2: [US2[], int32, US3, string, string] = v2[v50];
                    const v54: US3 = patternInput_2[2];
                    const v66: US20 = (v51.tag === US20_Tag.US20_1) ? v51 : (((v54.tag === US3_Tag.US3_1) ? (v11.tag === US3_Tag.US3_1) : (v11.tag === US3_Tag.US3_0)) ? US20_US20_1(patternInput_2[0], patternInput_2[1], v54, patternInput_2[3], patternInput_2[4]) : US20_US20_0());
                    const v67: int32 = (v47 + 1) | 0;
                    v45.l0 = (v67 | 0);
                    v45.l1 = v66;
                }
                const v68: US20 = v45.l1;
                const v76_1: string = (v68.tag === US20_Tag.US20_1) ? (`${v68.fields[3]}:${v68.fields[1]}/${v68.fields[4]}`) : "";
                patternInput_3 = [v19, (v19.tag === US2_Tag.US2_1) ? ((v94 = Node$, new v94(v76_1))) : ((v19.tag === US2_Tag.US2_2) ? (() => {
                    throw new Error("new_db Memory");
                })() : ((v78 = gun, (v90 = {
                    url: v76_1,
                    localStorage: false,
                    radisk: true,
                }, new v78(v90))))), v76_1];
            }
            v15[v18] = [patternInput_3[0], patternInput_3[1], patternInput_3[2]];
            const v105: int32 = (v18 + 1) | 0;
            v16.l0 = (v105 | 0);
        }
        v5[v8] = v15;
        const v106: int32 = (v8 + 1) | 0;
        v6.l0 = (v106 | 0);
    }
    const v108: int32 = v5.length | 0;
    const v109: Mut32 = new Mut32(0, []);
    while (method74(v108, v109)) {
        const v111: int32 = v109.l0 | 0;
        const v112: [US2, any, string][] = v109.l1;
        const v113: [US2, any, string][] = v5[v111];
        const v114: int32 = v112.length | 0;
        const v116: int32 = (v114 + v113.length) | 0;
        const v117: [US2, any, string][] = fill(new Array(v116), 0, v116, null);
        const v118: Mut3 = new Mut3(0);
        while (method5(v116, v118)) {
            const v120: int32 = v118.l0 | 0;
            let patternInput_6: [US2, any, string];
            if (v120 < v114) {
                const patternInput_4: [US2, any, string] = v112[v120];
                patternInput_6 = [patternInput_4[0], patternInput_4[1], patternInput_4[2]];
            }
            else {
                const v125: int32 = (v120 - v114) | 0;
                const patternInput_5: [US2, any, string] = v113[v125];
                patternInput_6 = [patternInput_5[0], patternInput_5[1], patternInput_5[2]];
            }
            v117[v120] = [patternInput_6[0], patternInput_6[1], patternInput_6[2]];
            const v132: int32 = (v120 + 1) | 0;
            v118.l0 = (v132 | 0);
        }
        const v133: int32 = (v111 + 1) | 0;
        v109.l0 = (v133 | 0);
        v109.l1 = v117;
    }
    const v134: [US2, any, string][] = v109.l1;
    const v135: int32 = v3.length | 0;
    const v136: [US2, string][] = fill(new Array(v135), 0, v135, null);
    const v137: Mut3 = new Mut3(0);
    while (method5(v135, v137)) {
        const v139: int32 = v137.l0 | 0;
        const patternInput_7: [US2, any, string] = v3[v139];
        v136[v139] = [patternInput_7[0], patternInput_7[2]];
        const v143: int32 = (v139 + 1) | 0;
        v137.l0 = (v143 | 0);
    }
    const v144: int32 = v134.length | 0;
    const v145: [US2, string][] = fill(new Array(v144), 0, v144, null);
    const v146: Mut3 = new Mut3(0);
    while (method5(v144, v146)) {
        const v148: int32 = v146.l0 | 0;
        const patternInput_8: [US2, any, string] = v134[v148];
        v145[v148] = [patternInput_8[0], patternInput_8[2]];
        const v152: int32 = (v148 + 1) | 0;
        v146.l0 = (v152 | 0);
    }
    if ((((v136.length === v145.length) !== true) ? false : method56(v136, v145, 0)) !== true) {
        v1_1(US4_US4_2(), ["> db_listener > effect", ["new_connections:", v134]]);
        v0_1(v134);
    }
}

export function closure322(v0_1: () => [US2, any, string][], v1_1: () => [US2[], int32, US3, string, string][], v2: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void, unitVar: void): void {
    const v3: [US2, any, string][] = v0_1();
    v2([v1_1(), v3]);
}

export function closure323(v0_1: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void, unitVar: void): void {
    v0_1.clear();
}

export function method71(): any {
    const v125: any = components_spi.state_context;
    const v128: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [US2, any, string][], (arg0: [US2, any, string][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, any][], (arg0: [int64, any][]) => void, () => [int64, int32][], (arg0: [int64, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v128(v125);
    const v139: () => [US2, any, string][] = patternInput[10];
    const v274: any = components_spi.state_context;
    const v275: any = useContext;
    const v284: () => [US2[], int32, US3, string, string][] = (v275(v274))[8];
    const v298: () => any[] = (): any[] => closure320(v139, v284, void 0);
    const v300: (arg0: US4, arg1: any[]) => void = method14(v298, "#cf1100");
    v300(US4_US4_0())(["> db_listener ()"]);
    const v308: any = debounce;
    const v309: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void = (arg10$0040_1: [[US2[], int32, US3, string, string][], [US2, any, string][]]): void => {
        closure321(patternInput[11], uncurry(2, v300), arg10$0040_1);
    };
    const v310: (arg0: [[US2[], int32, US3, string, string][], [US2, any, string][]]) => void = v308(v309, 300);
    const v311: () => void = (): void => {
        closure322(v139, v284, v310, void 0);
    };
    method17(v311);
    const v312: () => void = (): void => {
        closure323(v310, void 0);
    };
    method18(v312);
    return void 0;
}

export function closure319(unitVar: void, v0_1: Mut2): any {
    return method71();
}

export function method75(): [US0, string, string, string][] {
    return [[US0_US0_0(), "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M", "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith", "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="], [US0_US0_1(US1_US1_1()), "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ", "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make", "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="], [US0_US0_1(US1_US1_0()), "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI", "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid", "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="]];
}

export function method76(): int32 {
    return 4001;
}

export function method77(): string {
    return "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
}

export function method78(): string {
    return "http://localhost";
}

export function closure324(unitVar: void, unitVar_1: void): any {
    let value_43: any, value_44: any;
    const patternInput: [string, any, string, string, boolean] = method2();
    const v129: boolean = patternInput[4];
    const v125: string = patternInput[0];
    const v130: [US0, string, string, string][] = method75();
    const v131: int32 = v130.length | 0;
    const v132: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = fill(new Array(v131), 0, v131, null);
    const v133: Mut3 = new Mut3(0);
    while (method5(v131, v133)) {
        const v135: int32 = v133.l0 | 0;
        const patternInput_1: [US0, string, string, string] = v130[v135];
        const v142: any = createSignal;
        const v143: any[] = v142(patternInput_1[0]);
        let v144: () => US0;
        const value_1: any = v143[0];
        v144 = (value_1);
        let v145: (arg0: US0) => void;
        const value_2: any = v143[1];
        v145 = ((arg_1: US0): void => {
            value_2(arg_1);
        });
        const v146: any = createSignal;
        const v147: any[] = v146(patternInput_1[3]);
        let v148: () => string;
        const value_4: any = v147[0];
        v148 = (value_4);
        let v149: (arg0: string) => void;
        const value_5: any = v147[1];
        v149 = ((arg_3: string): void => {
            value_5(arg_3);
        });
        const v150: any = createSignal;
        const v151: any[] = v150(patternInput_1[1]);
        let v152: () => string;
        const value_7: any = v151[0];
        v152 = (value_7);
        let v153: (arg0: string) => void;
        const value_8: any = v151[1];
        v153 = ((arg_5: string): void => {
            value_8(arg_5);
        });
        const v154: any = createSignal;
        const v155: any[] = v154(patternInput_1[2]);
        let v156: () => string;
        const value_10: any = v155[0];
        v156 = (value_10);
        let v157: (arg0: string) => void;
        const value_11: any = v155[1];
        v157 = ((arg_7: string): void => {
            value_11(arg_7);
        });
        v132[v135] = [v144, v145, v152, v153, v156, v157, v148, v149];
        const v158: int32 = (v135 + 1) | 0;
        v133.l0 = (v158 | 0);
    }
    const v161: any = createSignal;
    const v162: any[] = v161(v132);
    let v163: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][];
    const value_13: any = v162[0];
    v163 = (value_13);
    let v164: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void;
    const value_14: any = v162[1];
    v164 = ((arg_9: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): void => {
        value_14(arg_9);
    });
    const v165: boolean = "" === v125;
    const v167: int32 = (v165 ? method76() : 80) | 0;
    const v168: any = createSignal;
    const v169: any[] = v168(v167);
    let v170: () => int32;
    const value_16: any = v169[0];
    v170 = (value_16);
    let v171: (arg0: int32) => void;
    const value_17: any = v169[1];
    v171 = ((arg_11: int32): void => {
        value_17(arg_11);
    });
    const v172: string = method77();
    const v173: any = createSignal;
    const v174: any[] = v173(v172);
    let v175: () => string;
    const value_19: any = v174[0];
    v175 = (value_19);
    let v176: (arg0: string) => void;
    const value_20: any = v174[1];
    v176 = ((arg_13: string): void => {
        value_20(arg_13);
    });
    const v179: string = v165 ? method78() : (`http://${v125}-4001.githubpreview.dev`);
    const v180: any = createSignal;
    const v181: any[] = v180(v179);
    let v182: () => string;
    const value_22: any = v181[0];
    v182 = (value_22);
    let v183: (arg0: string) => void;
    const value_23: any = v181[1];
    v183 = ((arg_15: string): void => {
        value_23(arg_15);
    });
    const v184: [US2, any, string][] = fill(new Array(0), 0, 0, null);
    const v185: any = createSignal;
    const v186: any[] = v185(v184);
    let v187: () => [US2, any, string][];
    const value_25: any = v186[0];
    v187 = (value_25);
    let v188: (arg0: [US2, any, string][]) => void;
    const value_26: any = v186[1];
    v188 = ((arg_17: [US2, any, string][]): void => {
        value_26(arg_17);
    });
    const v194: string = v165 ? "ws://localhost" : ((true === v129) ? "ws://localhost" : (`ws://${v125}-4944.githubpreview.dev`));
    const v199: int32 = (v165 ? ((true === v129) ? 14944 : ((false === v129) ? 4944 : 80)) : 80) | 0;
    const v208_1: string = v165 ? "wss://localhost" : ((true === v129) ? "wss://localhost" : (`ws://${v125}-8765.githubpreview.dev`));
    const v213_1: int32 = (v165 ? ((true === v129) ? 18765 : ((false === v129) ? 8765 : 80)) : 80) | 0;
    const v217_1: [US2[], int32, US3, string, string][] = [[fill(new Array(0), 0, 0, null), v199, US3_US3_1(), v194, "ws"], [fill(new Array(0), 0, 0, null), v213_1, US3_US3_0(), v208_1, "gun"]];
    const v218_1: any = createSignal;
    const v219: any[] = v218_1(v217_1);
    let v220: () => [US2[], int32, US3, string, string][];
    const value_28: any = v219[0];
    v220 = (value_28);
    let v221: (arg0: [US2[], int32, US3, string, string][]) => void;
    const value_29: any = v219[1];
    v221 = ((arg_19: [US2[], int32, US3, string, string][]): void => {
        value_29(arg_19);
    });
    const v225: US4 = ("" === patternInput[2]) ? US4_US4_0() : US4_US4_3();
    const v226: any = createSignal;
    const v227: any[] = v226(v225);
    let v228: () => US4;
    const value_31: any = v227[0];
    v228 = (value_31);
    let v229: (arg0: US4) => void;
    const value_32: any = v227[1];
    v229 = ((arg_21: US4): void => {
        value_32(arg_21);
    });
    const v230: any = createSignal;
    const v232: any[] = v230(US5_US5_0());
    let v233: () => US5;
    const value_34: any = v232[0];
    v233 = (value_34);
    let v234: (arg0: US5) => void;
    const value_35: any = v232[1];
    v234 = ((arg_23: US5): void => {
        value_35(arg_23);
    });
    const v235: [int64, int32][] = fill(new Array(0), 0, 0, null);
    const v236: any = createSignal;
    const v237: any[] = v236(v235);
    let v238: () => [int64, int32][];
    const value_37: any = v237[0];
    v238 = (value_37);
    let v239: (arg0: [int64, int32][]) => void;
    const value_38: any = v237[1];
    v239 = ((arg_25: [int64, int32][]): void => {
        value_38(arg_25);
    });
    const v240: [int64, any][] = fill(new Array(0), 0, 0, null);
    const v241: any = createSignal;
    const v242: any[] = v241(v240);
    let v243: () => [int64, any][];
    const value_40: any = v242[0];
    v243 = (value_40);
    let v244: (arg0: [int64, any][]) => void;
    const value_41: any = v242[1];
    v244 = ((arg_27: [int64, any][]): void => {
        value_41(arg_27);
    });
    const v245: [int64, any][] = fill(new Array(0), 0, 0, null);
    const v246: any = createSignal;
    const v247: any[] = v246(v245);
    return [v163, v164, v170, v171, v175, v176, v182, v183, v220, v221, v187, v188, (value_43 = v247[0], value_43), (value_44 = v247[1], (arg_29: [int64, any][]): void => {
        value_44(arg_29);
    }), v243, v244, v238, v239, v228, v229, v233, v234];
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const v72 = process.env;

export const v73 = "env";

export const v74 = [v73, v72];

export const v75 = [v74];

export const v76 = createObj(v75);

window.components_spi = v76;

export const v77 = nonSeeded().Next0();

export const v203 = method0();

export const v204 = "content";

export const v205 = (v: Mut1): any => closure0(void 0, v);

export const v206 = [v204, v205];

export const v207 = "db_listener";

export const v208 = (v: Mut2): any => closure319(void 0, v);

export const v209 = [v207, v208];

export const v210 = "run_id";

export const v211 = [v210, v77];

export const v212 = "new_state_context_any";

export const v213 = (): any => closure324(void 0, void 0);

export const v214 = [v212, v213];

export const v215 = "state_context";

export const v216 = [v215, v203];

export const v217 = [v206, v209, v211, v214, v216, v74];

export const v218 = createObj(v217);

window.components_spi = v218;

v1.l0 = v218;


