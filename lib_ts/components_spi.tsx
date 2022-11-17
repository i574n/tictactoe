import { toString, Union, Record } from "./fable_modules/fable-library-ts/Types.js";
import { getUnionFields, tuple_type, lambda_type, array_type, unit_type, bool_type, class_type, int32_type, string_type, union_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { uint8, op_UnaryNegation_Int32, int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { Index, createSignal, onCleanup, createEffect, useContext, For, createComponent, children as children_1, createContext } from "solid-js";
import { fill } from "./fable_modules/fable-library-ts/Array.js";
import { Input, RadioGroup, Radio, useColorMode, Anchor, Table, Tbody, hope, Tr, Td, Stack, IconButton, Icon, Button, Checkbox, Box, SimpleSelect, SimpleOption } from "@hope-ui/solid";
import { int32ToString, uncurry, createObj } from "./fable_modules/fable-library-ts/Util.js";
import { int64, fromBits, op_Division, op_Subtraction, toString as toString_1 } from "./fable_modules/fable-library-ts/Long.js";
import { utcNow, getTicks } from "./fable_modules/fable-library-ts/Date.js";
import { BiRegularMinus, BiRegularPlus, BiRegularLinkExternal, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh } from "solid-icons/bi";
import { nonSeeded } from "./fable_modules/fable-library-ts/Random.js";
import { interpolate, toConsole } from "./fable_modules/fable-library-ts/String.js";
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

export type US2_Fields = [[any, string], [any, string]];

export type US2 = US2_Cons<US2_Tag.US2_0> | US2_Cons<US2_Tag.US2_1>;

export function US2_US2_0(f0_0: any, f0_1: string) {
    return new US2_Cons<US2_Tag.US2_0>(US2_Tag.US2_0, [f0_0, f0_1]);
}

export function US2_US2_1(f1_0: any, f1_1: string) {
    return new US2_Cons<US2_Tag.US2_1>(US2_Tag.US2_1, [f1_0, f1_1]);
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
    return union_type("Components_spi.US2", [], US2_Cons, () => [[["f0_0", obj_type], ["f0_1", string_type]], [["f1_0", obj_type], ["f1_1", string_type]]]);
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

export function Mut11$reflection(): TypeInfo {
    return record_type("Components_spi.Mut11", [], Mut11, () => [["l0", lambda_type(array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type))), lambda_type(array_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut12 extends Record {
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

export function Mut12$reflection(): TypeInfo {
    return record_type("Components_spi.Mut12", [], Mut12, () => [["l0", lambda_type(US4$reflection(), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, US4$reflection()), lambda_type(US4$reflection(), unit_type)))], ["l2", string_type]]);
}

export class Mut13 extends Record {
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

export function Mut13$reflection(): TypeInfo {
    return record_type("Components_spi.Mut13", [], Mut13, () => [["l0", lambda_type(US5$reflection(), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, US5$reflection()), lambda_type(US5$reflection(), unit_type)))], ["l2", string_type]]);
}

export class Mut14 extends Record {
    l0: (arg0: [int32, int32][]) => any;
    l1: () => [() => [int32, int32][], (arg0: [int32, int32][]) => void];
    l2: string;
    constructor(l0: (arg0: [int32, int32][]) => any, l1: () => [() => [int32, int32][], (arg0: [int32, int32][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut14$reflection(): TypeInfo {
    return record_type("Components_spi.Mut14", [], Mut14, () => [["l0", lambda_type(array_type(tuple_type(int32_type, int32_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(int32_type, int32_type))), lambda_type(array_type(tuple_type(int32_type, int32_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut15 extends Record {
    l0: (arg0: [int32, any][]) => any;
    l1: () => [() => [int32, any][], (arg0: [int32, any][]) => void];
    l2: string;
    constructor(l0: (arg0: [int32, any][]) => any, l1: () => [() => [int32, any][], (arg0: [int32, any][]) => void], l2: string) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut15$reflection(): TypeInfo {
    return record_type("Components_spi.Mut15", [], Mut15, () => [["l0", lambda_type(array_type(tuple_type(int32_type, obj_type)), obj_type)], ["l1", lambda_type(unit_type, tuple_type(lambda_type(unit_type, array_type(tuple_type(int32_type, obj_type))), lambda_type(array_type(tuple_type(int32_type, obj_type)), unit_type)))], ["l2", string_type]]);
}

export class Mut16 extends Record {
    l0: () => US6;
    l1: (arg0: US6) => void;
    constructor(l0: () => US6, l1: (arg0: US6) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut16$reflection(): TypeInfo {
    return record_type("Components_spi.Mut16", [], Mut16, () => [["l0", lambda_type(unit_type, US6$reflection())], ["l1", lambda_type(US6$reflection(), unit_type)]]);
}

export class Mut17 extends Record {
    l0: () => US5;
    l1: (arg0: US5) => void;
    constructor(l0: () => US5, l1: (arg0: US5) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut17$reflection(): TypeInfo {
    return record_type("Components_spi.Mut17", [], Mut17, () => [["l0", lambda_type(unit_type, US5$reflection())], ["l1", lambda_type(US5$reflection(), unit_type)]]);
}

export class Mut18 extends Record {
    l0: US3;
    constructor(l0: US3) {
        super();
        this.l0 = l0;
    }
}

export function Mut18$reflection(): TypeInfo {
    return record_type("Components_spi.Mut18", [], Mut18, () => [["l0", US3$reflection()]]);
}

export class Mut19 extends Record {
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

export function Mut19$reflection(): TypeInfo {
    return record_type("Components_spi.Mut19", [], Mut19, () => [["l0", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), US6$reflection())], ["l1", US3$reflection()], ["l2", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), lambda_type(US6$reflection(), tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)))]]);
}

export class Mut20 extends Record {
    l0: int32;
    l1: US6;
    constructor(l0: int32, l1: US6) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut20$reflection(): TypeInfo {
    return record_type("Components_spi.Mut20", [], Mut20, () => [["l0", int32_type], ["l1", US6$reflection()]]);
}

export class Mut21 extends Record {
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

export function Mut21$reflection(): TypeInfo {
    return record_type("Components_spi.Mut21", [], Mut21, () => [["l0", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), US5$reflection())], ["l1", US3$reflection()], ["l2", lambda_type(tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type), lambda_type(US5$reflection(), tuple_type(array_type(US2$reflection()), int32_type, US3$reflection(), string_type, string_type)))]]);
}

export class Mut22 extends Record {
    l0: int32;
    l1: US5;
    constructor(l0: int32, l1: US5) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut22$reflection(): TypeInfo {
    return record_type("Components_spi.Mut22", [], Mut22, () => [["l0", int32_type], ["l1", US5$reflection()]]);
}

export class Mut23 extends Record {
    l0: (arg0: [any, string]) => US2;
    l1: US3;
    constructor(l0: (arg0: [any, string]) => US2, l1: US3) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut23$reflection(): TypeInfo {
    return record_type("Components_spi.Mut23", [], Mut23, () => [["l0", lambda_type(tuple_type(obj_type, string_type), US2$reflection())], ["l1", US3$reflection()]]);
}

export class Mut24 extends Record {
    l0: int32;
    l1: int32;
    constructor(l0: int32, l1: int32) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = (l1 | 0);
    }
}

export function Mut24$reflection(): TypeInfo {
    return record_type("Components_spi.Mut24", [], Mut24, () => [["l0", int32_type], ["l1", int32_type]]);
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

export class Mut25 extends Record {
    l0: int32;
    l1: UH1;
    constructor(l0: int32, l1: UH1) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut25$reflection(): TypeInfo {
    return record_type("Components_spi.Mut25", [], Mut25, () => [["l0", int32_type], ["l1", UH1$reflection()]]);
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

export class Mut26 extends Record {
    l0: int32;
    l1: UH2;
    constructor(l0: int32, l1: UH2) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut26$reflection(): TypeInfo {
    return record_type("Components_spi.Mut26", [], Mut26, () => [["l0", int32_type], ["l1", UH2$reflection()]]);
}

export function method0(): any {
    const v2: any = createContext;
    const v3: () => [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = (): [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] => (void 0);
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
    const v197_1: UH0 = (!v192) ? v188 : UH0_UH0_0(["colorScheme", v192], v188);
    const v201_1: any = (v14.tag === US8_Tag.US8_1) ? v14.fields[0] : (void 0);
    const v206_1: UH0 = (!v201_1) ? v197_1 : UH0_UH0_0(["compact", v201_1], v197_1);
    const v210_1: any = (v15.tag === US10_Tag.US10_1) ? v15.fields[0] : (void 0);
    const v215: UH0 = (!v210_1) ? v206_1 : UH0_UH0_0(["css", v210_1], v206_1);
    const v219: any = (v16.tag === US6_Tag.US6_1) ? v16.fields[0] : (void 0);
    const v224: UH0 = (!v219) ? v215 : UH0_UH0_0(["defaultValue", v219], v215);
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
    const v160: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v153.tag === US9_Tag.US9_1) ? v153.fields[0] : v75_1), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], US6_US6_1("2px"), patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
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
    const v242: (arg0: any) => void = (v: any): void => {
        closure25(v0_1, v);
    };
    const v247: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US8_US8_1(v224), US9_US9_1((v232.tag === US9_Tag.US9_1) ? v232.fields[0] : ((): any[] => closure23(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, void 0))), patternInput_2[12], US6_US6_1("neutral"), patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], US6_US6_1("3px"), patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], US13_US13_1(v242), patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], US6_US6_1("sm"), patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    const v248: () => any[] = (): any[] => closure23(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, void 0);
    v247.children = v248;
    const v249: (arg0: any) => any = v152;
    const v252: any = createComponent;
    return v252(v249, v247);
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
    const v149: string = (v52.tag === US6_Tag.US6_1) ? v52.fields[0] : "8px";
    let v157: US9;
    if (v88.tag === US9_Tag.US9_1) {
        const v154: any = children_1;
        v157 = US9_US9_1(v154(v88.fields[0]));
    }
    else {
        v157 = US9_US9_0();
    }
    const v164: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v157.tag === US9_Tag.US9_1) ? v157.fields[0] : ((): any[] => closure19(v0_1, v71, v72_1, v73_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US6_US6_1(v149), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v165: () => any[] = (): any[] => closure19(v0_1, v71, v72_1, v73_1, void 0);
    v164.children = v165;
    const v166: (arg0: any) => any = v76_1;
    const v169: any = createComponent;
    return [v169(v166, v164)];
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
    const v120: any = components_spi.state_context;
    const v123: any = useContext;
    return method15((v123(v120))[16], v0_1, v1_1);
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
    const v202_1: Mut7 = new Mut7(v79, ((v194.tag === US5_Tag.US5_1) && (v194.fields[0] === v0_1)) ? ((): any => closure51(void 0, void 0)) : ((): any => closure52(void 0, void 0)), v79);
    const v203_1: any = createComponent;
    const v204_1: any = v203_1(v85, v202_1);
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
    const v269: any = components_spi.state_context;
    const v272: any = useContext;
    const patternInput_2: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v272(v269);
    const v410: any = components_spi.state_context;
    const v411: any = useContext;
    const patternInput_3: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v411(v410);
    const v549: any = components_spi.state_context;
    const v550: any = useContext;
    const patternInput_4: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v550(v549);
    const v570: (arg0: US5) => void = patternInput_4[19];
    const v569: () => US5 = patternInput_4[18];
    const v571: () => any[] = (): any[] => closure30(v150, patternInput_2[4], patternInput_3[16], v569, void 0);
    method14(v571, "#de884c")(US4_US4_0())(["> loader ()"]);
    const v579: boolean = v0_1.l0;
    const v581: any = createSignal;
    const v582: any[] = v581(v579);
    let v583: () => boolean;
    const value_5: any = v582[0];
    v583 = (value_5);
    let v584: (arg0: boolean) => void;
    const value_6: any = v582[1];
    v584 = ((arg_1: boolean): void => {
        value_6(arg_1);
    });
    const v585: any = createSignal;
    const v586: any[] = v585(false);
    let v587: () => boolean;
    const value_8: any = v586[0];
    v587 = (value_8);
    let v588: (arg0: boolean) => void;
    const value_9: any = v586[1];
    v588 = ((arg_3: boolean): void => {
        value_9(arg_3);
    });
    const v589: () => void = (): void => {
        closure33(v0_1, v150, v570, void 0);
    };
    method17(v589);
    const v590: () => void = (): void => {
        closure34(v588, v587, void 0);
    };
    method17(v590);
    const v591: () => void = (): void => {
        closure35(v0_1, void 0);
    };
    method18(v591);
    if (v0_1.l0 === true) {
        const v594: US14 = v0_1.l2;
        if (v594.tag === US14_Tag.US14_1) {
            v594.fields[0]();
        }
    }
    const v598: any = Box;
    const patternInput_5: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v610: US9 = patternInput_5[11];
    let v675: US9;
    if (v610.tag === US9_Tag.US9_1) {
        const v672: any = children_1;
        v675 = US9_US9_1(v672(v610.fields[0]));
    }
    else {
        v675 = US9_US9_0();
    }
    const v685: any = createObj(method7(patternInput_5[0], patternInput_5[1], patternInput_5[2], patternInput_5[3], patternInput_5[4], patternInput_5[5], patternInput_5[6], patternInput_5[7], patternInput_5[8], patternInput_5[9], patternInput_5[10], US9_US9_1((v675.tag === US9_Tag.US9_1) ? v675.fields[0] : ((): any[] => closure36(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v570, v569, v584, v583, v588, v587, v0_1, void 0))), patternInput_5[12], patternInput_5[13], patternInput_5[14], patternInput_5[15], patternInput_5[16], patternInput_5[17], US6_US6_1("flex"), patternInput_5[19], patternInput_5[20], US6_US6_1("1"), patternInput_5[22], patternInput_5[23], patternInput_5[24], patternInput_5[25], patternInput_5[26], patternInput_5[27], v100, patternInput_5[29], patternInput_5[30], patternInput_5[31], patternInput_5[32], patternInput_5[33], patternInput_5[34], patternInput_5[35], patternInput_5[36], patternInput_5[37], patternInput_5[38], patternInput_5[39], patternInput_5[40], patternInput_5[41], patternInput_5[42], patternInput_5[43], patternInput_5[44], patternInput_5[45], patternInput_5[46], patternInput_5[47], patternInput_5[48], patternInput_5[49], patternInput_5[50], patternInput_5[51], patternInput_5[52], patternInput_5[53], patternInput_5[54], patternInput_5[55], patternInput_5[56], patternInput_5[57], patternInput_5[58], patternInput_5[59], patternInput_5[60], patternInput_5[61], patternInput_5[62], patternInput_5[63], patternInput_5[64], patternInput_5[65], patternInput_5[66], patternInput_5[67], patternInput_5[68], patternInput_5[69]));
    const v686: () => any[] = (): any[] => closure36(v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v570, v569, v584, v583, v588, v587, v0_1, void 0);
    v685.children = v686;
    const v687: (arg0: any) => any = v598;
    const v689: any = createComponent;
    return v689(v687, v685);
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
    let v74_1: any, v77_1: any, patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v89: US9, v157: string, v160: string, v169: string, v177: US9, v174: any, v196_1: any, v197_1: () => any[], v198_1: (arg0: any) => any, v201_1: any, v302: () => any[], v305: any, patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v317: US9, v378: string, v381: string, v384: string, v387: string, v395: US9, v392: any, v399: string, v424: any, v425: () => any[], v426: (arg0: any) => any, v429: any, v206_1: any, patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v218: US9, v284: US9, v281: any, v288: string, v295: any, v296: () => any[], v297: (arg0: any) => any, v300: any;
    return [(v63.tag === US12_Tag.US12_1) ? ((v74_1 = v63.fields[0], (v77_1 = Td, (patternInput = method3(), (v89 = patternInput[11], (v157 = (((v0_1.l3.tag === US15_Tag.US15_2) ? true : v72_1()) ? method12("0px !important", void 0) : "0px !important"), (v160 = ((v25.tag === US6_Tag.US6_1) ? v25.fields[0] : "$sm"), (v169 = method12((v52.tag === US6_Tag.US6_1) ? (("0" === v52.fields[0]) ? "0" : "0 20px 0 0") : "0 20px 0 0", "0"), (v177 = ((v89.tag === US9_Tag.US9_1) ? ((v174 = children_1, US9_US9_1(v174(v89.fields[0])))) : US9_US9_0()), (v196_1 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], US6_US6_1(v157), US6_US6_1("$neutral5"), patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v177.tag === US9_Tag.US9_1) ? v177.fields[0] : ((): any[] => closure18(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v74_1, void 0))), US6_US6_1("$neutral11"), patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], patternInput[21], US6_US6_1("column"), patternInput[23], US6_US6_1(v160), patternInput[25], patternInput[26], patternInput[27], patternInput[28], US6_US6_1("center"), patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1(v169), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69])), (v197_1 = ((): any[] => closure18(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72_1, v74_1, void 0)), (v196_1.children = v197_1, (v198_1 = (v77_1), (v201_1 = createComponent, v201_1(v198_1, v196_1))))))))))))))) : (void 0), (v12.tag === US9_Tag.US9_1) ? ((v302 = v12.fields[0], (v305 = Td, (patternInput_2 = method3(), (v317 = patternInput_2[11], (v378 = ((v25.tag === US6_Tag.US6_1) ? v25.fields[0] : "$sm"), (v381 = ((v36.tag === US6_Tag.US6_1) ? v36.fields[0] : "0"), (v384 = ((v35.tag === US6_Tag.US6_1) ? v35.fields[0] : "0"), (v387 = ((v50.tag === US6_Tag.US6_1) ? v50.fields[0] : "0"), (v395 = ((v317.tag === US9_Tag.US9_1) ? ((v392 = children_1, US9_US9_1(v392(v317.fields[0])))) : US9_US9_0()), (v399 = "0", (v424 = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], US6_US6_1(v399), patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v395.tag === US9_Tag.US9_1) ? v395.fields[0] : ((): any[] => closure27(v0_1, v72_1, v302, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US6_US6_1("flex"), patternInput_2[19], patternInput_2[20], US6_US6_1("6"), US6_US6_1("column"), patternInput_2[23], US6_US6_1(v378), patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], US6_US6_1("center"), patternInput_2[30], patternInput_2[31], US6_US6_1("$base"), patternInput_2[33], US6_US6_1(v384), US6_US6_1(v381), US6_US6_1(v399), US6_US6_1(v399), US6_US6_1("85vh"), patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], US6_US6_1(v399), patternInput_2[46], patternInput_2[47], US6_US6_1("auto"), US6_US6_1(v387), patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69])), (v425 = ((): any[] => closure27(v0_1, v72_1, v302, void 0)), (v424.children = v425, (v426 = (v305), (v429 = createComponent, v429(v426, v424))))))))))))))))) : ((v206_1 = Td, (patternInput_1 = method3(), (v218 = patternInput_1[11], (v284 = ((v218.tag === US9_Tag.US9_1) ? ((v281 = children_1, US9_US9_1(v281(v218.fields[0])))) : US9_US9_0()), (v288 = "0", (v295 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], US6_US6_1(v288), patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v284.tag === US9_Tag.US9_1) ? v284.fields[0] : ((): any[] => closure26(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], US6_US6_1("9px"), patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], US6_US6_1(v288), patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69])), (v296 = ((): any[] => closure26(void 0, void 0)), (v295.children = v296, (v297 = (v206_1), (v300 = createComponent, v300(v297, v295))))))))))))];
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
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
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
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    return [patternInput[6], patternInput[7]];
}

export function closure68(unitVar: void, v0_1: int32): any {
    return v0_1;
}

export function closure69(unitVar: void, unitVar_1: void): [() => int32, (arg0: int32) => void] {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
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
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
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

export function closure80(unitVar: void, v0_1: [US2[], int32, US3, string, string][]): any {
    return v0_1;
}

export function closure81(unitVar: void, unitVar_1: void): [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    return [patternInput[8], patternInput[9]];
}

export function closure85(v0_1: Mut11, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure84(v0_1: Mut11, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): any[] {
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

export function closure83(v0_1: Mut11, v1_1: () => [US2[], int32, US3, string, string][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure84(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method25(v0_1: Mut11): any {
    const patternInput: [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure83(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure82(unitVar: void, v0_1: Mut11): any {
    return method25(v0_1);
}

export function closure86(unitVar: void, v0_1: US4): any {
    return (v0_1.tag === US4_Tag.US4_1) ? "Error" : ((v0_1.tag === US4_Tag.US4_2) ? "Info" : ((v0_1.tag === US4_Tag.US4_3) ? "Warn" : "Debug"));
}

export function closure87(unitVar: void, unitVar_1: void): [() => US4, (arg0: US4) => void] {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    return [patternInput[16], patternInput[17]];
}

export function closure91(v0_1: Mut12, v1_1: () => US4, unitVar: void): any[] {
    const v2: US4 = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure90(v0_1: Mut12, v1_1: () => US4, unitVar: void): any[] {
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

export function closure89(v0_1: Mut12, v1_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure90(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method26(v0_1: Mut12): any {
    const patternInput: [() => US4, (arg0: US4) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure89(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure88(unitVar: void, v0_1: Mut12): any {
    return method26(v0_1);
}

export function closure92(unitVar: void, v0_1: US5): any {
    return v0_1;
}

export function closure93(unitVar: void, unitVar_1: void): [() => US5, (arg0: US5) => void] {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    return [patternInput[18], patternInput[19]];
}

export function closure97(v0_1: Mut13, v1_1: () => US5, unitVar: void): any[] {
    const v2: US5 = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure96(v0_1: Mut13, v1_1: () => US5, unitVar: void): any[] {
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

export function closure95(v0_1: Mut13, v1_1: () => US5, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure96(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method27(v0_1: Mut13): any {
    const patternInput: [() => US5, (arg0: US5) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure95(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure94(unitVar: void, v0_1: Mut13): any {
    return method27(v0_1);
}

export function closure98(unitVar: void, v0_1: [int32, int32][]): any {
    return v0_1;
}

export function closure99(unitVar: void, unitVar_1: void): [() => [int32, int32][], (arg0: [int32, int32][]) => void] {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    return [patternInput[14], patternInput[15]];
}

export function closure103(v0_1: Mut14, v1_1: () => [int32, int32][], unitVar: void): any[] {
    const v2: [int32, int32][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure102(v0_1: Mut14, v1_1: () => [int32, int32][], unitVar: void): any[] {
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

export function closure101(v0_1: Mut14, v1_1: () => [int32, int32][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure102(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method28(v0_1: Mut14): any {
    const patternInput: [() => [int32, int32][], (arg0: [int32, int32][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure101(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure100(unitVar: void, v0_1: Mut14): any {
    return method28(v0_1);
}

export function closure104(unitVar: void, v0_1: [int32, any][]): any {
    return v0_1;
}

export function closure105(unitVar: void, unitVar_1: void): [() => [int32, any][], (arg0: [int32, any][]) => void] {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    return [patternInput[12], patternInput[13]];
}

export function closure109(v0_1: Mut15, v1_1: () => [int32, any][], unitVar: void): any[] {
    const v2: [int32, any][] = v1_1();
    const v4: any = v0_1.l0(v2);
    return [<>
        {JSON.stringify(v4, null, 2)}
    </>];
}

export function closure108(v0_1: Mut15, v1_1: () => [int32, any][], unitVar: void): any[] {
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

export function closure107(v0_1: Mut15, v1_1: () => [int32, any][], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure108(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US6_US6_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {v0_1.l2}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method29(v0_1: Mut15): any {
    const patternInput: [() => [int32, any][], (arg0: [int32, any][]) => void] = v0_1.l1();
    const v6: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure107(v0_1, patternInput[0], arg10$0040);
    const v8: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v6, US15_US15_2());
    const v11: any = createComponent;
    const v12: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v11(v12, v8);
}

export function closure106(unitVar: void, v0_1: Mut15): any {
    return method29(v0_1);
}

export function closure110(unitVar: void, unitVar_1: void): [() => [int32, any][], (arg0: [int32, any][]) => void] {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    return [patternInput[10], patternInput[11]];
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
    const v28: (arg0: [US2[], int32, US3, string, string][]) => any = (v_6: [US2[], int32, US3, string, string][]): any => closure80(void 0, v_6);
    const v29: () => [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] = (): [() => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void] => closure81(void 0, void 0);
    const v31: Mut11 = new Mut11(v28, v29, "db.connections");
    const v32: any = createComponent;
    const v33: (arg0: Mut11) => any = (v_7: Mut11): any => closure82(void 0, v_7);
    const v35: (arg0: US4) => any = (v_8: US4): any => closure86(void 0, v_8);
    const v36: () => [() => US4, (arg0: US4) => void] = (): [() => US4, (arg0: US4) => void] => closure87(void 0, void 0);
    const v38: Mut12 = new Mut12(v35, v36, "settings.log_level");
    const v39: any = createComponent;
    const v40: (arg0: Mut12) => any = (v_9: Mut12): any => closure88(void 0, v_9);
    const v42: (arg0: US5) => any = (v_10: US5): any => closure92(void 0, v_10);
    const v43: () => [() => US5, (arg0: US5) => void] = (): [() => US5, (arg0: US5) => void] => closure93(void 0, void 0);
    const v45: Mut13 = new Mut13(v42, v43, "settings.ui.modal");
    const v46: any = createComponent;
    const v47: (arg0: Mut13) => any = (v_11: Mut13): any => closure94(void 0, v_11);
    const v49: (arg0: [int32, int32][]) => any = (v_12: [int32, int32][]): any => closure98(void 0, v_12);
    const v50: () => [() => [int32, int32][], (arg0: [int32, int32][]) => void] = (): [() => [int32, int32][], (arg0: [int32, int32][]) => void] => closure99(void 0, void 0);
    const v52: Mut14 = new Mut14(v49, v50, "profile.tmp.counter");
    const v53: any = createComponent;
    const v54: (arg0: Mut14) => any = (v_13: Mut14): any => closure100(void 0, v_13);
    const v56: (arg0: [int32, any][]) => any = (v_14: [int32, any][]): any => closure104(void 0, v_14);
    const v57: () => [() => [int32, any][], (arg0: [int32, any][]) => void] = (): [() => [int32, any][], (arg0: [int32, any][]) => void] => closure105(void 0, void 0);
    const v59: Mut15 = new Mut15(v56, v57, "profile.tmp.chain_status");
    const v60: any = createComponent;
    const v61: (arg0: Mut15) => any = (v_15: Mut15): any => closure106(void 0, v_15);
    const v63: () => [() => [int32, any][], (arg0: [int32, any][]) => void] = (): [() => [int32, any][], (arg0: [int32, any][]) => void] => closure110(void 0, void 0);
    const v65: Mut15 = new Mut15(v56, v63, "profile.tmp.chain_deploy");
    const v66: any = createComponent;
    return [v6(v7, v3), v12(v7, v11), v18(v19, v17), v25(v26, v24), v32(v33, v31), v39(v40, v38), v46(v47, v45), v53(v54, v52), v60(v61, v59), v66(v61, v65)];
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
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
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

export function closure113(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure112(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = Tbody;
    const v4: US9 = v0_1.l11;
    const v7: () => any[] = (v4.tag === US9_Tag.US9_1) ? v4.fields[0] : ((): any[] => closure113(void 0, void 0));
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

export function method30(v0_1: Mut1): any {
    const v3: any = Table;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v15: US9 = patternInput[11];
    const v74_1: US6 = v0_1.l48;
    const v77_1: string = (v74_1.tag === US6_Tag.US6_1) ? v74_1.fields[0] : "hidden";
    let v85: US9;
    if (v15.tag === US9_Tag.US9_1) {
        const v82: any = children_1;
        v85 = US9_US9_1(v82(v15.fields[0]));
    }
    else {
        v85 = US9_US9_0();
    }
    const v100: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v85.tag === US9_Tag.US9_1) ? v85.fields[0] : ((): any[] => closure112(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], US6_US6_1("1"), US6_US6_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US6_US6_1("hidden"), US6_US6_1(v77_1), patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v101: () => any[] = (): any[] => closure112(v0_1, void 0);
    v100.children = v101;
    const v102: (arg0: any) => any = v3;
    const v105: any = createComponent;
    return v105(v102, v100);
}

export function closure111(unitVar: void, v0_1: Mut1): any {
    return method30(v0_1);
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
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return [v88(v89, v84)];
}

export function closure5(v0_1: (arg0: US4) => void, v1_1: () => US4, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure6(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
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
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return [v88(v89, v84)];
}

export function method4(): any {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    const v139: (arg0: US4) => void = patternInput[17];
    const v138: () => US4 = patternInput[16];
    const v144: any = Box;
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v156: US9 = patternInput_1[11];
    let v221: US9;
    if (v156.tag === US9_Tag.US9_1) {
        const v218: any = children_1;
        v221 = US9_US9_1(v218(v156.fields[0]));
    }
    else {
        v221 = US9_US9_0();
    }
    const v227: string = "0";
    const v246: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], US6_US6_1("$blackAlpha12"), patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], US6_US6_1(v227), patternInput_1[10], US9_US9_1((v221.tag === US9_Tag.US9_1) ? v221.fields[0] : ((): any[] => closure3(v139, v138, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US6_US6_1("flex"), patternInput_1[19], patternInput_1[20], patternInput_1[21], US6_US6_1("column"), patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], US6_US6_1("80vh"), US6_US6_1("50vw"), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], US6_US6_1("auto"), patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], US6_US6_1("absolute"), US6_US6_1(v227), patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], US5_US5_1(2), patternInput_1[69]));
    const v247: () => any[] = (): any[] => closure3(v139, v138, void 0);
    v246.children = v247;
    const v248: (arg0: any) => any = v144;
    const v250: any = createComponent;
    return v250(v248, v246);
}

export function closure2(unitVar: void, v0_1: Mut2): any {
    return method4();
}

export function closure117(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure122(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure125(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: US6 = v0_1.l26;
    return [<>
        {(v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : ""}
    </>];
}

export function closure126(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], US6_US6_1("-13px"), _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure127(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularLinkExternal;
    return v2;
}

export function closure124(v0_1: Mut1, unitVar: void): any[] {
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
    const v230: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v224.tag === US9_Tag.US9_1) ? v224.fields[0] : ((): any[] => closure125(v0_1, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]));
    const v231: () => any[] = (): any[] => closure125(v0_1, void 0);
    v230.children = v231;
    const v232: (arg0: any) => any = v3;
    const v235: any = createComponent;
    const v240: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure126(void 0, arg10$0040_2);
    const v241: () => any = (): any => closure127(void 0, void 0);
    const v242: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v243: Mut7 = new Mut7(v240, v241, v242);
    const v244: any = createComponent;
    const v245: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    return [v235(v232, v230), <>
        &nbsp;
    </>, v244(v245, v243)];
}

export function method32(v0_1: Mut1): any {
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
    const v87: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v81.tag === US9_Tag.US9_1) ? v81.fields[0] : ((): any[] => closure124(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v88: () => any[] = (): any[] => closure124(v0_1, void 0);
    v87.children = v88;
    const v89: (arg0: any) => any = v3;
    const v92: any = createComponent;
    return v92(v89, v87);
}

export function closure123(unitVar: void, v0_1: Mut1): any {
    return method32(v0_1);
}

export function closure121(unitVar: void, unitVar_1: void): any[] {
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
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure122(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1("https://github.com/fc1943s/tictactoe_spiral"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure122(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure123(void 0, v);
    return [v88(v89, v84)];
}

export function closure120(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure121(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure129(v0_1: string, unitVar: void): any[] {
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
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure122(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1(v0_1), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure122(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure123(void 0, v);
    return [v88(v89, v84)];
}

export function closure128(v0_1: string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v71: () => any[] = (): any[] => closure129(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v71), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure131(unitVar: void, unitVar_1: void): any[] {
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
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure122(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1("https://fc1943s.github.io/tictactoe_spiral"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure122(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure123(void 0, v);
    return [v88(v89, v84)];
}

export function closure130(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure131(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure133(unitVar: void, unitVar_1: void): any[] {
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
    const v84: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure122(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], US6_US6_1("https://fc1943s.github.io/tictactoe_spiral/docs"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v85: () => any[] = (): any[] => closure122(void 0, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure123(void 0, v);
    return [v88(v89, v84)];
}

export function closure132(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v70: () => any[] = (): any[] => closure133(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v70), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("1px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure119(v0_1: string, unitVar: void): any[] {
    let v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v6: Mut4, v9: any, v10: (arg0: Mut4) => any, v15: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v17: Mut4, v20: any, v21: (arg0: Mut4) => any;
    const v26: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure130(void 0, arg10$0040_2);
    const v28: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v26, US15_US15_2());
    const v31: any = createComponent;
    const v32: (arg0: Mut4) => any = (v_2: Mut4): any => closure16(void 0, v_2);
    const v36: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure132(void 0, arg10$0040_3);
    const v38: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v36, US15_US15_2());
    const v39: any = createComponent;
    return [("" === v0_1) ? ((v4 = ((arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure120(void 0, arg10$0040)), (v6 = (new Mut4(US14_US14_0(), US14_US14_0(), v4, US15_US15_2())), (v9 = createComponent, (v10 = ((v: Mut4): any => closure16(void 0, v)), v9(v10, v6)))))) : ((v15 = ((arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure128(`https://github.com/fc1943s/tictactoe_spiral/tree/${v0_1}`, arg10$0040_1)), (v17 = (new Mut4(US14_US14_0(), US14_US14_0(), v15, US15_US15_2())), (v20 = createComponent, (v21 = ((v_1: Mut4): any => closure16(void 0, v_1)), v20(v21, v17)))))), v31(v32, v28), v39(v32, v38)];
}

export function method31(): any {
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
    const v87: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure119(v3, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v88: () => any[] = (): any[] => closure119(v3, void 0);
    v87.children = v88;
    const v91: any = createComponent;
    const v92: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return v91(v92, v87);
}

export function closure118(unitVar: void, v0_1: Mut1): any {
    return method31();
}

export function closure116(unitVar: void, unitVar_1: void): any[] {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure117(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure117(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure118(void 0, v);
    return [v86(v87, v82)];
}

export function closure115(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure116(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Links
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure136(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method34(): [() => string, () => void] {
    const v2: any = useColorMode;
    const v3: any = v2();
    return [v3.colorMode, v3.toggleColorMode];
}

export function closure143(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Dark
    </>];
}

export function closure144(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Light
    </>];
}

export function closure142(unitVar: void, unitVar_1: void): any[] {
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
    const v93: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure143(void 0, void 0))), patternInput[12], US6_US6_1(v87), patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1(v89), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], US10_US10_1("dark"), patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v94: () => any[] = (): any[] => closure143(void 0, void 0);
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
    const v188: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v179.tag === US9_Tag.US9_1) ? v179.fields[0] : ((): any[] => closure144(void 0, void 0))), patternInput_1[12], US6_US6_1(v87), patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], US6_US6_1(v89), patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], US10_US10_1("light"), patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]));
    const v189: () => any[] = (): any[] => closure144(void 0, void 0);
    v188.children = v189;
    const v190: (arg0: any) => any = v100;
    const v191: any = createComponent;
    return [v99, v191(v190, v188)];
}

export function closure141(unitVar: void, unitVar_1: void): any[] {
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
    const v90: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v80.tag === US9_Tag.US9_1) ? v80.fields[0] : ((): any[] => closure142(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1("row"), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("$4"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v91: () => any[] = (): any[] => closure142(void 0, void 0);
    v90.children = v91;
    const v92: (arg0: any) => any = v2;
    const v95: any = createComponent;
    return [v95(v92, v90)];
}

export function closure145(v0_1: () => void, v1_1: any): void {
    v0_1();
}

export function closure140(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
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
        closure145(v0_1, v);
    };
    const v92: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v83.tag === US9_Tag.US9_1) ? v83.fields[0] : ((): any[] => closure141(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], US6_US6_1(v75_1), patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], US13_US13_1(v89), patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v93: () => any[] = (): any[] => closure141(void 0, void 0);
    v92.children = v93;
    const v94: (arg0: any) => any = v4;
    const v97: any = createComponent;
    return [v97(v94, v92)];
}

export function closure139(v0_1: () => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure140(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("5px 6px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Theme
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure138(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure139(v0_1, v1_1, arg10$0040);
    const v6: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v4, US15_US15_2());
    const v9: any = createComponent;
    const v10: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v9(v10, v6)];
}

export function method33(): any {
    const patternInput: [() => string, () => void] = method34();
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
    const v84: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v79.tag === US9_Tag.US9_1) ? v79.fields[0] : ((): any[] => closure138(v1_1, v0_1, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v85: () => any[] = (): any[] => closure138(v1_1, v0_1, void 0);
    v84.children = v85;
    const v88: any = createComponent;
    const v89: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return v88(v89, v84);
}

export function closure137(unitVar: void, v0_1: Mut1): any {
    return method33();
}

export function closure135(unitVar: void, unitVar_1: void): any[] {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure136(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure136(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure137(void 0, v);
    return [v86(v87, v82)];
}

export function closure134(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure135(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Settings
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure148(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure153(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure158(v0_1: () => string, unitVar: void): US6 {
    return US6_US6_1(v0_1());
}

export function closure159(v0_1: (arg0: string) => void, v1_1: US6): void {
    v0_1((v1_1.tag === US6_Tag.US6_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function closure161(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure162(v0_1: Mut16, v1_1: any): void {
    const v2: string = v1_1.currentTarget.value;
    v0_1.l1(US6_US6_1(v2));
}

export function method37(v0_1: Mut16): any {
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
        closure162(v0_1, v);
    };
    const v102: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v87.tag === US9_Tag.US9_1) ? v87.fields[0] : ((): any[] => closure161(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], US6_US6_1("15vw"), patternInput[42], patternInput[43], US13_US13_1(v94), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1("xs"), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], US6_US6_1("text"), US10_US10_1(v78), patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v103: () => any[] = (): any[] => closure161(void 0, void 0);
    v102.children = v103;
    const v104: (arg0: any) => any = v3;
    const v107: any = createComponent;
    return v107(v104, v102);
}

export function closure160(unitVar: void, v0_1: Mut16): any {
    return method37(v0_1);
}

export function closure157(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: () => US6 = (): US6 => closure158(v1_1, void 0);
    const v3: (arg0: US6) => void = (v: US6): void => {
        closure159(v0_1, v);
    };
    const v4: Mut16 = new Mut16(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut16) => any = (v_1: Mut16): any => closure160(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure156(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure157(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Token
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure164(v0_1: (arg0: string) => void, v1_1: () => string, unitVar: void): any[] {
    const v2: () => US6 = (): US6 => closure158(v1_1, void 0);
    const v3: (arg0: US6) => void = (v: US6): void => {
        closure159(v0_1, v);
    };
    const v4: Mut16 = new Mut16(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut16) => any = (v_1: Mut16): any => closure160(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure163(v0_1: (arg0: string) => void, v1_1: () => string, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure164(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        URL
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure167(v0_1: () => int32, unitVar: void): US5 {
    return US5_US5_1(v0_1());
}

export function closure168(v0_1: (arg0: int32) => void, v1_1: US5): void {
    v0_1((v1_1.tag === US5_Tag.US5_1) ? v1_1.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })());
}

export function closure170(v0_1: Mut17, v1_1: any): void {
    const v2: int32 = v1_1.currentTarget.value | 0;
    v0_1.l1(US5_US5_1(v2));
}

export function method38(v0_1: Mut17): any {
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
        closure170(v0_1, v);
    };
    const v102: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v87.tag === US9_Tag.US9_1) ? v87.fields[0] : ((): any[] => closure161(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], US6_US6_1("15vw"), patternInput[42], patternInput[43], US13_US13_1(v94), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US6_US6_1("xs"), patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], US6_US6_1("text"), US10_US10_1(v78), patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v103: () => any[] = (): any[] => closure161(void 0, void 0);
    v102.children = v103;
    const v104: (arg0: any) => any = v3;
    const v107: any = createComponent;
    return v107(v104, v102);
}

export function closure169(unitVar: void, v0_1: Mut17): any {
    return method38(v0_1);
}

export function closure166(v0_1: (arg0: int32) => void, v1_1: () => int32, unitVar: void): any[] {
    const v2: () => US5 = (): US5 => closure167(v1_1, void 0);
    const v3: (arg0: US5) => void = (v: US5): void => {
        closure168(v0_1, v);
    };
    const v4: Mut17 = new Mut17(v2, v3);
    const v7: any = createComponent;
    const v8: (arg0: Mut17) => any = (v_1: Mut17): any => closure169(void 0, v_1);
    return [v7(v8, v4)];
}

export function closure165(v0_1: (arg0: int32) => void, v1_1: () => int32, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: () => any[] = (): any[] => closure166(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Port
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure155(v0_1: (arg0: string) => void, v1_1: () => string, v2: (arg0: string) => void, v3: () => string, v4: (arg0: int32) => void, v5: () => int32, unitVar: void): any[] {
    const v8: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure156(v0_1, v1_1, arg10$0040);
    const v10: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v8, US15_US15_2());
    const v13: any = createComponent;
    const v14: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v18: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure163(v2, v3, arg10$0040_1);
    const v20: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v18, US15_US15_2());
    const v21: any = createComponent;
    const v25: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure165(v4, v5, arg10$0040_2);
    const v27: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v25, US15_US15_2());
    const v28: any = createComponent;
    return [v13(v14, v10), v21(v14, v20), v28(v14, v27)];
}

export function method36(): any {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    const v127: (arg0: string) => void = patternInput[5];
    const v126: () => string = patternInput[4];
    const v259: any = components_spi.state_context;
    const v260: any = useContext;
    const patternInput_1: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v260(v259);
    const v268: (arg0: string) => void = patternInput_1[7];
    const v267: () => string = patternInput_1[6];
    const v398: any = components_spi.state_context;
    const v399: any = useContext;
    const patternInput_2: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v399(v398);
    const v403: (arg0: int32) => void = patternInput_2[3];
    const v402: () => int32 = patternInput_2[2];
    const patternInput_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v431: US9 = patternInput_3[11];
    let v496: US9;
    if (v431.tag === US9_Tag.US9_1) {
        const v493: any = children_1;
        v496 = US9_US9_1(v493(v431.fields[0]));
    }
    else {
        v496 = US9_US9_0();
    }
    const v501: Mut1 = new Mut1(patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3], patternInput_3[4], patternInput_3[5], patternInput_3[6], patternInput_3[7], patternInput_3[8], patternInput_3[9], patternInput_3[10], US9_US9_1((v496.tag === US9_Tag.US9_1) ? v496.fields[0] : ((): any[] => closure155(v127, v126, v268, v267, v403, v402, void 0))), patternInput_3[12], patternInput_3[13], patternInput_3[14], patternInput_3[15], patternInput_3[16], patternInput_3[17], patternInput_3[18], patternInput_3[19], patternInput_3[20], patternInput_3[21], patternInput_3[22], patternInput_3[23], patternInput_3[24], patternInput_3[25], patternInput_3[26], patternInput_3[27], patternInput_3[28], patternInput_3[29], patternInput_3[30], patternInput_3[31], patternInput_3[32], patternInput_3[33], patternInput_3[34], patternInput_3[35], patternInput_3[36], patternInput_3[37], patternInput_3[38], patternInput_3[39], patternInput_3[40], patternInput_3[41], patternInput_3[42], patternInput_3[43], patternInput_3[44], patternInput_3[45], patternInput_3[46], patternInput_3[47], patternInput_3[48], patternInput_3[49], patternInput_3[50], patternInput_3[51], patternInput_3[52], patternInput_3[53], patternInput_3[54], patternInput_3[55], patternInput_3[56], patternInput_3[57], patternInput_3[58], patternInput_3[59], patternInput_3[60], patternInput_3[61], patternInput_3[62], patternInput_3[63], patternInput_3[64], patternInput_3[65], patternInput_3[66], patternInput_3[67], patternInput_3[68], patternInput_3[69]);
    const v502: () => any[] = (): any[] => closure155(v127, v126, v268, v267, v403, v402, void 0);
    v501.children = v502;
    const v504: any = createComponent;
    const v505: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return v504(v505, v501);
}

export function closure154(unitVar: void, v0_1: Mut1): any {
    return method36();
}

export function closure152(unitVar: void, unitVar_1: void): any[] {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure153(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure153(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure154(void 0, v);
    return [v86(v87, v82)];
}

export function closure151(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure152(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Connection
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure173(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure182(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): US6 {
    return US6_US6_1(v2());
}

export function closure183(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, v8: US6): void {
    v3((v8.tag === US6_Tag.US6_1) ? v8.fields[0] : "");
}

export function closure181(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: () => US6 = (): US6 => closure182(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    const v9: (arg0: US6) => void = (v: US6): void => {
        closure183(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v);
    };
    const v10: Mut16 = new Mut16(v8, v9);
    const v13: any = createComponent;
    const v14: (arg0: Mut16) => any = (v_1: Mut16): any => closure160(void 0, v_1);
    return [v13(v14, v10)];
}

export function closure180(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v81: () => any[] = (): any[] => closure181(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v81), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Address
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure186(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): US6 {
    return US6_US6_1(v6());
}

export function closure187(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, v8: US6): void {
    v7((v8.tag === US6_Tag.US6_1) ? v8.fields[0] : "");
}

export function closure185(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v8: () => US6 = (): US6 => closure186(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    const v9: (arg0: US6) => void = (v: US6): void => {
        closure187(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v);
    };
    const v10: Mut16 = new Mut16(v8, v9);
    const v13: any = createComponent;
    const v14: (arg0: Mut16) => any = (v_1: Mut16): any => closure160(void 0, v_1);
    return [v13(v14, v10)];
}

export function closure184(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v81: () => any[] = (): any[] => closure185(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v81), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Private Key
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure179(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
    const v10: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure180(v0_1, v1_1, v2, v3, v4, v5, v6, v7, arg10$0040);
    const v12: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v10, US15_US15_2());
    const v15: any = createComponent;
    const v16: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v20: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure184(v0_1, v1_1, v2, v3, v4, v5, v6, v7, arg10$0040_1);
    const v22: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v20, US15_US15_2());
    const v23: any = createComponent;
    return [v15(v16, v12), v23(v16, v22)];
}

export function closure178(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, unitVar: void): any[] {
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
    const v90: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v85.tag === US9_Tag.US9_1) ? v85.fields[0] : ((): any[] => closure179(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v91: () => any[] = (): any[] => closure179(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    v90.children = v91;
    const v94: any = createComponent;
    const v95: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return [v94(v95, v90)];
}

export function closure177(v0_1: () => US0, v1_1: (arg0: US0) => void, v2: () => string, v3: (arg0: string) => void, v4: () => string, v5: (arg0: string) => void, v6: () => string, v7: (arg0: string) => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v78: US0 = v0_1();
    const v87: () => any[] = (): any[] => closure178(v0_1, v1_1, v2, v3, v4, v5, v6, v7, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v87), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {(v78.tag === US0_Tag.US0_1) ? ((v78.fields[0].tag === US1_Tag.US1_1) ? "x" : "o") : "admin"}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure176(unitVar: void, _arg: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]): any[] {
    const v10: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure177(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], arg10$0040);
    const v12: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v10, US15_US15_2());
    const v15: any = createComponent;
    const v16: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v15(v16, v12)];
}

export function closure175(v0_1: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], unitVar: void): any[] {
    const v1_1: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = v0_1();
    const v4: any = For;
    const v5: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]) => any[] = (arg10$0040: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void]): any[] => closure176(void 0, arg10$0040);
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

export function method39(): any {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const v122: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = (v121(v118))[0];
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v153: US9 = patternInput_1[11];
    let v218: US9;
    if (v153.tag === US9_Tag.US9_1) {
        const v215: any = children_1;
        v218 = US9_US9_1(v215(v153.fields[0]));
    }
    else {
        v218 = US9_US9_0();
    }
    const v223: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v218.tag === US9_Tag.US9_1) ? v218.fields[0] : ((): any[] => closure175(v122, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v224: () => any[] = (): any[] => closure175(v122, void 0);
    v223.children = v224;
    const v226: any = createComponent;
    const v227: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return v226(v227, v223);
}

export function closure174(unitVar: void, v0_1: Mut1): any {
    return method39();
}

export function closure172(unitVar: void, unitVar_1: void): any[] {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure173(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure173(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure174(void 0, v);
    return [v86(v87, v82)];
}

export function closure171(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure172(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Accounts
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure190(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure189(unitVar: void, unitVar_1: void): any[] {
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
    const v99: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], US6_US6_1("#aaa"), patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v84.tag === US9_Tag.US9_1) ? v84.fields[0] : ((): any[] => closure190(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], US6_US6_1("1"), patternInput[22], patternInput[23], patternInput[24], US6_US6_1("350px"), patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], US6_US6_1("https://bank.testnet.algorand.network"), patternInput[60], patternInput[61], US12_US12_1(v76_1), patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v100: () => any[] = (): any[] => closure190(void 0, void 0);
    v99.children = v100;
    const v101: (arg0: any) => any = v3;
    const v104: any = createComponent;
    return [v104(v101, v99)];
}

export function closure188(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure189(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Testnet Bank Dispenser
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure150(unitVar: void, unitVar_1: void): any[] {
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure151(void 0, arg10$0040);
    const v4: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v2, US15_US15_2());
    const v7: any = createComponent;
    const v8: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure171(void 0, arg10$0040_1);
    const v14: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v12, US15_US15_2());
    const v15: any = createComponent;
    const v19: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure188(void 0, arg10$0040_2);
    const v21: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v19, US15_US15_0());
    const v22: any = createComponent;
    return [v7(v8, v4), v15(v8, v14), v22(v8, v21)];
}

export function method35(): any {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure150(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure150(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return v86(v87, v82);
}

export function closure149(unitVar: void, v0_1: Mut1): any {
    return method35();
}

export function closure147(unitVar: void, unitVar_1: void): any[] {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure148(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure148(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure149(void 0, v);
    return [v86(v87, v82)];
}

export function closure146(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure147(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Chain
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure193(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure203(unitVar: void, _arg: [US2[], int32, US3, string, string]): US6 {
    return US6_US6_1(_arg[3]);
}

export function closure205(v0_1: Mut18, v1_1: US2[], v2: int32, v3: US3, v4: string, v5: string, v6: US6): [US2[], int32, US3, string, string] {
    return [v1_1, v2, v0_1.l0, (v6.tag === US6_Tag.US6_1) ? v6.fields[0] : "", v5];
}

export function closure204(v0_1: Mut18, _arg: [US2[], int32, US3, string, string]): (arg0: US6) => [US2[], int32, US3, string, string] {
    return (v: US6): [US2[], int32, US3, string, string] => closure205(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], _arg[4], v);
}

export function method43(v0_1: int32, v1_1: Mut20): boolean {
    return v1_1.l0 < v0_1;
}

export function closure207(v0_1: Mut19, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): US6 {
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut20 = new Mut20(0, US6_US6_0());
    while (method43(v3, v5)) {
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

export function closure208(v0_1: Mut19, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: US6): void {
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

export function method42(v0_1: Mut19): any {
    const v119: any = components_spi.state_context;
    const v122: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v122(v119);
    const v131: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v143: () => US6 = (): US6 => closure207(v0_1, v131, void 0);
    const v144: (arg0: US6) => void = (v: US6): void => {
        closure208(v0_1, patternInput[9], v131, v);
    };
    const v145: Mut16 = new Mut16(v143, v144);
    const v147: any = createComponent;
    const v148: (arg0: Mut16) => any = (v_1: Mut16): any => closure160(void 0, v_1);
    return v147(v148, v145);
}

export function closure206(unitVar: void, v0_1: Mut19): any {
    return method42(v0_1);
}

export function closure202(v0_1: Mut18, unitVar: void): any[] {
    const v2: (arg0: [US2[], int32, US3, string, string]) => US6 = (arg10$0040: [US2[], int32, US3, string, string]): US6 => closure203(void 0, arg10$0040);
    const v3: (arg0: [US2[], int32, US3, string, string], arg1: US6) => [US2[], int32, US3, string, string] = (arg10$0040_1: [US2[], int32, US3, string, string]): (arg0: US6) => [US2[], int32, US3, string, string] => closure204(v0_1, arg10$0040_1);
    const v4: Mut19 = new Mut19(v2, v0_1.l0, uncurry(2, v3));
    const v7: any = createComponent;
    const v8: (arg0: Mut19) => any = (v: Mut19): any => closure206(void 0, v);
    return [v7(v8, v4)];
}

export function closure201(v0_1: Mut18, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure202(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        URL
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure211(unitVar: void, _arg: [US2[], int32, US3, string, string]): US5 {
    return US5_US5_1(_arg[1]);
}

export function closure213(v0_1: Mut18, v1_1: US2[], v2: int32, v3: US3, v4: string, v5: string, v6: US5): [US2[], int32, US3, string, string] {
    const v7: US3 = v0_1.l0;
    return [v1_1, (v6.tag === US5_Tag.US5_1) ? v6.fields[0] : 0, v7, v4, v5];
}

export function closure212(v0_1: Mut18, _arg: [US2[], int32, US3, string, string]): (arg0: US5) => [US2[], int32, US3, string, string] {
    return (v: US5): [US2[], int32, US3, string, string] => closure213(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], _arg[4], v);
}

export function method45(v0_1: int32, v1_1: Mut22): boolean {
    return v1_1.l0 < v0_1;
}

export function closure215(v0_1: Mut21, v1_1: () => [US2[], int32, US3, string, string][], unitVar: void): US5 {
    const v2: [US2[], int32, US3, string, string][] = v1_1();
    const v3: int32 = v2.length | 0;
    const v5: Mut22 = new Mut22(0, US5_US5_0());
    while (method45(v3, v5)) {
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

export function closure216(v0_1: Mut21, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: US5): void {
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

export function method44(v0_1: Mut21): any {
    const v119: any = components_spi.state_context;
    const v122: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v122(v119);
    const v131: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v143: () => US5 = (): US5 => closure215(v0_1, v131, void 0);
    const v144: (arg0: US5) => void = (v: US5): void => {
        closure216(v0_1, patternInput[9], v131, v);
    };
    const v145: Mut17 = new Mut17(v143, v144);
    const v147: any = createComponent;
    const v148: (arg0: Mut17) => any = (v_1: Mut17): any => closure169(void 0, v_1);
    return v147(v148, v145);
}

export function closure214(unitVar: void, v0_1: Mut21): any {
    return method44(v0_1);
}

export function closure210(v0_1: Mut18, unitVar: void): any[] {
    const v2: (arg0: [US2[], int32, US3, string, string]) => US5 = (arg10$0040: [US2[], int32, US3, string, string]): US5 => closure211(void 0, arg10$0040);
    const v3: (arg0: [US2[], int32, US3, string, string], arg1: US5) => [US2[], int32, US3, string, string] = (arg10$0040_1: [US2[], int32, US3, string, string]): (arg0: US5) => [US2[], int32, US3, string, string] => closure212(v0_1, arg10$0040_1);
    const v4: Mut21 = new Mut21(v2, v0_1.l0, uncurry(2, v3));
    const v7: any = createComponent;
    const v8: (arg0: Mut21) => any = (v: Mut21): any => closure214(void 0, v);
    return [v7(v8, v4)];
}

export function closure209(v0_1: Mut18, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure210(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Port
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure200(v0_1: Mut18, unitVar: void): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure201(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v13: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure209(v0_1, arg10$0040_1);
    const v15: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v13, US15_US15_2());
    const v16: any = createComponent;
    return [v8(v9, v5), v16(v9, v15)];
}

export function method41(v0_1: Mut18): any {
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
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure200(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure200(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return v87(v88, v83);
}

export function closure199(unitVar: void, v0_1: Mut18): any {
    return method41(v0_1);
}

export function closure198(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut18 = new Mut18(US3_US3_1());
    const v4: any = createComponent;
    const v5: (arg0: Mut18) => any = (v: Mut18): any => closure199(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure197(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure198(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Gun Rust
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure221(unitVar: void, _arg: [any, string]): US2 {
    return US2_US2_1(_arg[0], _arg[1]);
}

export function method49(v0_1_mut: US2, v1_1_mut: US2[], v2_mut: int32): boolean {
    method49:
    while (true) {
        const v0_1: US2 = v0_1_mut, v1_1: US2[] = v1_1_mut, v2: int32 = v2_mut;
        if (v2 < v1_1.length) {
            const v5: US2 = v1_1[v2];
            if ((v5.tag === US2_Tag.US2_1) ? (v0_1.tag === US2_Tag.US2_1) : (!(v0_1.tag === US2_Tag.US2_1))) {
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

export function method48(v0_1_mut: Mut23, v1_1_mut: US2, v2_mut: [US2[], int32, US3, string, string][], v3_mut: int32): boolean {
    method48:
    while (true) {
        const v0_1: Mut23 = v0_1_mut, v1_1: US2 = v1_1_mut, v2: [US2[], int32, US3, string, string][] = v2_mut, v3: int32 = v3_mut;
        if (v3 < v2.length) {
            const patternInput: [US2[], int32, US3, string, string] = v2[v3];
            const v11: US3 = v0_1.l1;
            if (((patternInput[2].tag === US3_Tag.US3_1) ? (v11.tag === US3_Tag.US3_1) : (v11.tag === US3_Tag.US3_0)) && method49(v1_1, patternInput[0], 0)) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_mut = v2;
                v3_mut = (v3 + 1);
                continue method48;
            }
        }
        else {
            return false;
        }
        break;
    }
}

export function closure223(v0_1: Mut23, v1_1: () => [US2[], int32, US3, string, string][], v2: US2, unitVar: void): boolean {
    return method48(v0_1, v2, v1_1(), 0);
}

export function method50(v0_1: int32, v1_1: Mut24): boolean {
    return v1_1.l0 < v0_1;
}

export function closure224(v0_1: Mut23, v1_1: (arg0: [US2[], int32, US3, string, string][]) => void, v2: () => [US2[], int32, US3, string, string][], v3: US2, v4: boolean): void {
    let v18: US2[], v19: int32, v21: int32, v22: US2[], v23: Mut3, v32: int32, v33: US2[], v34: Mut24, v58: int32, v59: US2[], v60: Mut3;
    const v5: [US2[], int32, US3, string, string][] = v2();
    const v6: int32 = v5.length | 0;
    const v7: [US2[], int32, US3, string, string][] = fill(new Array(v6), 0, v6, null);
    const v8: Mut3 = new Mut3(0);
    while (method5(v6, v8)) {
        const v10: int32 = v8.l0 | 0;
        const patternInput: [US2[], int32, US3, string, string] = v5[v10];
        const v15: string = patternInput[4];
        const v14: string = patternInput[3];
        const v13: US3 = patternInput[2];
        const v12: int32 = patternInput[1] | 0;
        const v11: US2[] = patternInput[0];
        const v16: US3 = v0_1.l1;
        const patternInput_1: [US2[], int32, US3, string, string] = ((v13.tag === US3_Tag.US3_1) ? (v16.tag === US3_Tag.US3_1) : (v16.tag === US3_Tag.US3_0)) ? [v4 ? ((v18 = [v3], (v19 = (v11.length | 0), (v21 = ((v19 + v18.length) | 0), (v22 = fill(new Array(v21), 0, v21, null), (v23 = (new Mut3(0)), ((() => {
            while (method5(v21, v23)) {
                const v25: int32 = v23.l0 | 0;
                let v30: US2;
                if (v25 < v19) {
                    v30 = v11[v25];
                }
                else {
                    const v28: int32 = (v25 - v19) | 0;
                    v30 = v18[v28];
                }
                v22[v25] = v30;
                const v31: int32 = (v25 + 1) | 0;
                v23.l0 = (v31 | 0);
            }
        })(), v22))))))) : ((v32 = (v11.length | 0), (v33 = fill(new Array(v32), 0, v32, null), (v34 = (new Mut24(0, 0)), ((() => {
            while (method50(v32, v34)) {
                const v36: int32 = v34.l0 | 0;
                const v37: int32 = v34.l1 | 0;
                const v38: US2 = v11[v36];
                let v56: int32;
                if (((v38.tag === US2_Tag.US2_1) ? (v3.tag === US2_Tag.US2_1) : (!(v3.tag === US2_Tag.US2_1))) !== true) {
                    v33[v37] = v38;
                    v56 = (v37 + 1);
                }
                else {
                    v56 = v37;
                }
                const v57: int32 = (v36 + 1) | 0;
                v34.l0 = (v57 | 0);
                v34.l1 = (v56 | 0);
            }
        })(), (v58 = (v34.l1 | 0), (v59 = fill(new Array(v58), 0, v58, null), (v60 = (new Mut3(0)), ((() => {
            while (method5(v58, v60)) {
                const v62: int32 = v60.l0 | 0;
                const v63: US2 = v33[v62];
                v59[v62] = v63;
                const v64: int32 = (v62 + 1) | 0;
                v60.l0 = (v64 | 0);
            }
        })(), v59))))))))), v12, v13, v14, v15] : [v11, v12, v13, v14, v15];
        v7[v10] = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]];
        const v71: int32 = (v10 + 1) | 0;
        v8.l0 = (v71 | 0);
    }
    v1_1(v7);
}

export function closure226(v0_1: US2, unitVar: void): any[] {
    return [<>
        {(v0_1.tag === US2_Tag.US2_1) ? "Gun Rust" : "Gun JavaScript"}
    </>];
}

export function closure225(v0_1: US2, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v71: () => any[] = (): any[] => closure226(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v71), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method47(v0_1: Mut23): any {
    const v119: any = components_spi.state_context;
    const v122: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v122(v119);
    const v131: () => [US2[], int32, US3, string, string][] = patternInput[8];
    const v144: string = "";
    const v146: US2 = v0_1.l0([v144, v144]);
    const v147: () => boolean = (): boolean => closure223(v0_1, v131, v146, void 0);
    const v148: (arg0: boolean) => void = (v: boolean): void => {
        closure224(v0_1, patternInput[9], v131, v146, v);
    };
    const v149: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure225(v146, arg10$0040_1);
    const v150: Mut5 = new Mut5(v147, v148, v149);
    const v152: any = createComponent;
    const v153: (arg0: Mut5) => any = (v_1: Mut5): any => closure22(void 0, v_1);
    return v152(v153, v150);
}

export function closure222(unitVar: void, v0_1: Mut23): any {
    return method47(v0_1);
}

export function closure227(unitVar: void, _arg: [any, string]): US2 {
    return US2_US2_0(_arg[0], _arg[1]);
}

export function closure220(v0_1: Mut18, unitVar: void): any[] {
    const v2: (arg0: [any, string]) => US2 = (arg10$0040: [any, string]): US2 => closure221(void 0, arg10$0040);
    const v3: Mut23 = new Mut23(v2, v0_1.l0);
    const v6: any = createComponent;
    const v7: (arg0: Mut23) => any = (v: Mut23): any => closure222(void 0, v);
    const v8: any = v6(v7, v3);
    const v10: (arg0: [any, string]) => US2 = (arg10$0040_1: [any, string]): US2 => closure227(void 0, arg10$0040_1);
    const v11: Mut23 = new Mut23(v10, v0_1.l0);
    const v12: any = createComponent;
    return [v8, v12(v7, v11)];
}

export function closure219(v0_1: Mut18, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v74_1: () => any[] = (): any[] => closure220(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US6_US6_1("4px"), US6_US6_1("8px"), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Clients
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method46(v0_1: Mut18): any {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure219(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return v8(v9, v5);
}

export function closure218(unitVar: void, v0_1: Mut18): any {
    return method46(v0_1);
}

export function closure217(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut18 = new Mut18(US3_US3_1());
    const v4: any = createComponent;
    const v5: (arg0: Mut18) => any = (v: Mut18): any => closure218(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure196(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v72_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure197(void 0, arg10$0040);
    const v74_1: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v72_1, US15_US15_2());
    const v77_1: any = createComponent;
    const v78: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v80: () => any[] = (): any[] => closure217(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v80), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("0"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v77_1(v78, v74_1)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure230(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut18 = new Mut18(US3_US3_0());
    const v4: any = createComponent;
    const v5: (arg0: Mut18) => any = (v: Mut18): any => closure199(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure229(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure230(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Gun JavaScript
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure231(unitVar: void, unitVar_1: void): any[] {
    const v1_1: Mut18 = new Mut18(US3_US3_0());
    const v4: any = createComponent;
    const v5: (arg0: Mut18) => any = (v: Mut18): any => closure218(void 0, v);
    return [v4(v5, v1_1)];
}

export function closure228(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v72_1: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure229(void 0, arg10$0040);
    const v74_1: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v72_1, US15_US15_2());
    const v77_1: any = createComponent;
    const v78: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v80: () => any[] = (): any[] => closure231(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v80), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_0(), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US6_US6_1("0"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v77_1(v78, v74_1)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure195(unitVar: void, unitVar_1: void): any[] {
    const v2: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure196(void 0, arg10$0040);
    const v4: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v2, US15_US15_2());
    const v7: any = createComponent;
    const v8: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v12: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure228(void 0, arg10$0040_1);
    const v14: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v12, US15_US15_2());
    const v15: any = createComponent;
    return [v7(v8, v4), v15(v8, v14)];
}

export function method40(): any {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure195(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure195(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return v86(v87, v82);
}

export function closure194(unitVar: void, v0_1: Mut1): any {
    return method40();
}

export function closure192(unitVar: void, unitVar_1: void): any[] {
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
    const v82: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v77_1.tag === US9_Tag.US9_1) ? v77_1.fields[0] : ((): any[] => closure193(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v83: () => any[] = (): any[] => closure193(void 0, void 0);
    v82.children = v83;
    const v86: any = createComponent;
    const v87: (arg0: Mut1) => any = (v: Mut1): any => closure194(void 0, v);
    return [v86(v87, v82)];
}

export function closure191(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v73_1: () => any[] = (): any[] => closure192(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Database
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure235(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure239(v0_1: (arg0: [int32, int32][]) => void, v1_1: [int32, int32][]): void {
    v0_1(v1_1);
}

export function closure238(v0_1: (arg0: [int32, int32][]) => void, unitVar: void): (arg0: [int32, int32][]) => void {
    return (v: [int32, int32][]): void => {
        closure239(v0_1, v);
    };
}

export function closure237(v0_1: (arg0: [int32, int32][]) => void, unitVar: void): (arg0: void, arg1: [int32, int32][]) => void {
    return (): (arg0: [int32, int32][]) => void => closure238(v0_1, void 0);
}

export function closure240(v0_1: () => [int32, int32][], v1_1: any): int32 {
    const v2: [int32, int32][] = v0_1();
    const v3: int32 = v2.length | 0;
    const v4: Mut24 = new Mut24(0, 0);
    while (method50(v3, v4)) {
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

export function closure241(v0_1: string, v1_1: [int32, int32][], v2: () => void, v3: () => void, v4: () => void, v5: () => void, unitVar: void): any[] {
    return [["content_address:", v0_1], ["proxy:", v1_1], ["events:", v2], ["timers:", v3], ["values:", v4], ["subscriptions:", v5]];
}

export function closure242(v0_1: string, v1_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v1_1(US4_US4_0(), ["> use_fetch > unsubscribe () [1]"]);
    toConsole(interpolate("%A%P()", [["db_off", v0_1]]));
}

export function closure243(v0_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1(US4_US4_2(), [">> use_fetch request()"]);
}

export function closure244(v0_1: (arg0: US4, arg1: any[]) => void, unitVar: void): void {
    v0_1(US4_US4_2(), [">> use_fetch clear()"]);
}

export function method52(v0_1: string, v1_1: [int32, int32][]): [() => void, () => void] {
    const v120: any = components_spi.state_context;
    const v123: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v123(v120);
    const v145: any = createSignal;
    const v146: any[] = v145();
    let v147: () => void;
    const value_2: any = v146[0];
    v147 = ((): void => {
        value_2();
    });
    let v148: () => void;
    const value_3: any = v146[1];
    v148 = ((): void => {
        value_3();
    });
    const v149: any = createSignal;
    const v150: any[] = v149();
    let v151: () => void;
    const value_5: any = v150[0];
    v151 = ((): void => {
        value_5();
    });
    let v152: () => void;
    const value_6: any = v150[1];
    v152 = ((): void => {
        value_6();
    });
    const v153: any = createSignal;
    const v154: any[] = v153();
    let v155: () => void;
    const value_8: any = v154[0];
    v155 = ((): void => {
        value_8();
    });
    let v156: () => void;
    const value_9: any = v154[1];
    v156 = ((): void => {
        value_9();
    });
    const v157: any = createSignal;
    const v158: any[] = v157();
    let v159: () => void;
    const value_11: any = v158[0];
    v159 = ((): void => {
        value_11();
    });
    let v160: () => void;
    const value_12: any = v158[1];
    v160 = ((): void => {
        value_12();
    });
    const v161: uint8[] = Array.from(get_UTF8().getBytes(v0_1));
    const v162: int32 = v161.length | 0;
    const v163: Mut24 = new Mut24(0, 100000);
    while (method50(v162, v163)) {
        const v165: int32 = v163.l0 | 0;
        const v170: int32 = (v163.l1 + (v161[v165] * 14)) | 0;
        const v171: int32 = (v165 + 1) | 0;
        v163.l0 = (v171 | 0);
        v163.l1 = (v170 | 0);
    }
    const v175: () => any[] = (): any[] => closure241(v0_1, v1_1, v147, v151, v155, v159, void 0);
    const v176: (arg0: US4, arg1: any[]) => void = method14(v175, `#${int32ToString(v163.l1)}`);
    v176(US4_US4_0())(["> use_fetch ()"]);
    const v182: () => void = (): void => {
        closure242(v0_1, uncurry(2, v176), void 0);
    };
    method18(v182);
    const v183: () => void = (): void => {
        closure243(uncurry(2, v176), void 0);
    };
    const v184: () => void = (): void => {
        closure244(uncurry(2, v176), void 0);
    };
    return [v183, v184];
}

export function closure247(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Counter
    </>];
}

export function closure248(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure249(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularPlus;
    return v2;
}

export function closure250(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure251(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure252(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularMinus;
    return v2;
}

export function closure253(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure246(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
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
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure247(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure247(void 0, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    const v94: any = v93(v90, v88);
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v106: US9 = patternInput_1[11];
    const v165: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure248(void 0, arg10$0040_2);
    const v166: () => any = (): any => closure249(void 0, void 0);
    const v167: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v168: Mut7 = new Mut7(v165, v166, v167);
    const v169: any = createComponent;
    const v170: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    const v171: any = v169(v170, v168);
    let v178: US9;
    if (v106.tag === US9_Tag.US9_1) {
        const v175: any = children_1;
        v178 = US9_US9_1(v175(v106.fields[0]));
    }
    else {
        v178 = US9_US9_0();
    }
    const v185: string = "10px";
    const v187: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v178.tag === US9_Tag.US9_1) ? v178.fields[0] : ((): any[] => closure250(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US12_US12_1(v171), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], US14_US14_1(v1_1), patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], US6_US6_1(v185), patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v188: () => any[] = (): any[] => closure250(void 0, void 0);
    v187.children = v188;
    const v189: any = createComponent;
    const v190: (arg0: Mut1) => any = (v_1: Mut1): any => closure40(void 0, v_1);
    const v191: any = v189(v190, v187);
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v203_1: US9 = patternInput_2[11];
    const v262: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_7: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure251(void 0, arg10$0040_7);
    const v263: () => any = (): any => closure252(void 0, void 0);
    const v264: Mut7 = new Mut7(v262, v263, v167);
    const v265: any = createComponent;
    const v266: any = v265(v170, v264);
    let v273: US9;
    if (v203_1.tag === US9_Tag.US9_1) {
        const v270: any = children_1;
        v273 = US9_US9_1(v270(v203_1.fields[0]));
    }
    else {
        v273 = US9_US9_0();
    }
    const v281: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v273.tag === US9_Tag.US9_1) ? v273.fields[0] : ((): any[] => closure253(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US12_US12_1(v266), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US14_US14_1(v0_1), patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], US6_US6_1(v185), patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]);
    const v282: () => any[] = (): any[] => closure253(void 0, void 0);
    v281.children = v282;
    const v283: any = createComponent;
    return [v94, v191, v283(v190, v281)];
}

export function method53(v0_1: int32, v1_1: Mut25): boolean {
    return v1_1.l0 < v0_1;
}

export function method54(v0_1_mut: UH1, v1_1_mut: UH1): UH1 {
    method54:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: UH1 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH1_UH1_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method54;
        }
        break;
    }
}

export function method56(v0_1_mut: UH1, v1_1_mut: int32): int32 {
    method56:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method56;
        }
        break;
    }
}

export function method57(v0_1_mut: [int32, int32][], v1_1_mut: UH1, v2_mut: int32): int32 {
    method57:
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
            continue method57;
        }
        break;
    }
}

export function method55(v0_1: UH1): [int32, int32][] {
    const v2: int32 = method56(v0_1, 0) | 0;
    const v3: [int32, int32][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method57(v3, v0_1, 0) | 0;
    return v3;
}

export function closure259(v0_1: () => [int32, int32], unitVar: void): any[] {
    const patternInput: [int32, int32] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure258(v0_1: () => [int32, int32], unitVar: void): any[] {
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
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure259(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure259(v0_1, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure257(v0_1: () => [int32, int32], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure258(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure256(unitVar: void, v0_1: () => [int32, int32]): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure257(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure255(v0_1: () => [int32, int32][], unitVar: void): any[] {
    const v1_1: [int32, int32][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut25 = new Mut25(0, UH1_UH1_1());
    while (method53(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH1 = v4.l1;
        const patternInput: [int32, int32] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH1_UH1_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int32, int32][] = method55(method54(v4.l1, UH1_UH1_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int32, int32]) => any[] = (v: () => [int32, int32]): any[] => closure256(void 0, v);
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

export function closure254(v0_1: () => [int32, int32][], unitVar: void): any[] {
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
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure255(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure255(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return [v87(v88, v83)];
}

export function closure245(v0_1: () => [int32, int32][], v1_1: () => void, v2: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v87: US9 = patternInput[11];
    const v148: string = method12("column", "row");
    const v151: string = method12("8px", "0");
    let v159: US9;
    if (v87.tag === US9_Tag.US9_1) {
        const v156: any = children_1;
        v159 = US9_US9_1(v156(v87.fields[0]));
    }
    else {
        v159 = US9_US9_0();
    }
    const v173: any = createObj(method7(US6_US6_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v159.tag === US9_Tag.US9_1) ? v159.fields[0] : ((): any[] => closure246(v1_1, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1(v148), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US6_US6_1(v151), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1("3px"), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("7px"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v174: () => any[] = (): any[] => closure246(v1_1, v2, void 0);
    v173.children = v174;
    const v175: (arg0: any) => any = v75_1;
    const v178: any = createComponent;
    const v180: () => any[] = (): any[] => closure254(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v180), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("counter"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v178(v175, v173)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method51(): any {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    const v136: () => [int32, int32][] = patternInput[14];
    const v144: (arg0: void, arg1: void, arg2: [int32, int32][]) => void = (): (arg0: void, arg1: [int32, int32][]) => void => closure237(patternInput[15], void 0);
    const v145: (arg0: any) => int32 = (v: any): int32 => closure240(v136, v);
    const patternInput_1: [() => void, () => void] = method52("profile/tmp/counter", v136());
    const v150: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure245(v136, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    const v152: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v150, US15_US15_2());
    const v154: any = createComponent;
    const v155: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v154(v155, v152);
}

export function closure236(unitVar: void, v0_1: Mut1): any {
    return method51();
}

export function closure260(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure264(v0_1: (arg0: [int32, any][]) => void, v1_1: [int32, any][]): void {
    v0_1(v1_1);
}

export function closure263(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: [int32, any][]) => void {
    return (v: [int32, any][]): void => {
        closure264(v0_1, v);
    };
}

export function closure262(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: void, arg1: [int32, any][]) => void {
    return (): (arg0: [int32, any][]) => void => closure263(v0_1, void 0);
}

export function closure265(unitVar: void, v0_1: any): any {
    return "status";
}

export function closure266(v0_1: string, v1_1: [int32, any][], v2: () => void, v3: () => void, v4: () => void, v5: () => void, unitVar: void): any[] {
    return [["content_address:", v0_1], ["proxy:", v1_1], ["events:", v2], ["timers:", v3], ["values:", v4], ["subscriptions:", v5]];
}

export function method59(v0_1: string, v1_1: [int32, any][]): [() => void, () => void] {
    const v120: any = components_spi.state_context;
    const v123: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v123(v120);
    const v145: any = createSignal;
    const v146: any[] = v145();
    let v147: () => void;
    const value_2: any = v146[0];
    v147 = ((): void => {
        value_2();
    });
    let v148: () => void;
    const value_3: any = v146[1];
    v148 = ((): void => {
        value_3();
    });
    const v149: any = createSignal;
    const v150: any[] = v149();
    let v151: () => void;
    const value_5: any = v150[0];
    v151 = ((): void => {
        value_5();
    });
    let v152: () => void;
    const value_6: any = v150[1];
    v152 = ((): void => {
        value_6();
    });
    const v153: any = createSignal;
    const v154: any[] = v153();
    let v155: () => void;
    const value_8: any = v154[0];
    v155 = ((): void => {
        value_8();
    });
    let v156: () => void;
    const value_9: any = v154[1];
    v156 = ((): void => {
        value_9();
    });
    const v157: any = createSignal;
    const v158: any[] = v157();
    let v159: () => void;
    const value_11: any = v158[0];
    v159 = ((): void => {
        value_11();
    });
    let v160: () => void;
    const value_12: any = v158[1];
    v160 = ((): void => {
        value_12();
    });
    const v161: uint8[] = Array.from(get_UTF8().getBytes(v0_1));
    const v162: int32 = v161.length | 0;
    const v163: Mut24 = new Mut24(0, 100000);
    while (method50(v162, v163)) {
        const v165: int32 = v163.l0 | 0;
        const v170: int32 = (v163.l1 + (v161[v165] * 14)) | 0;
        const v171: int32 = (v165 + 1) | 0;
        v163.l0 = (v171 | 0);
        v163.l1 = (v170 | 0);
    }
    const v175: () => any[] = (): any[] => closure266(v0_1, v1_1, v147, v151, v155, v159, void 0);
    const v176: (arg0: US4, arg1: any[]) => void = method14(v175, `#${int32ToString(v163.l1)}`);
    v176(US4_US4_0())(["> use_fetch ()"]);
    const v182: () => void = (): void => {
        closure242(v0_1, uncurry(2, v176), void 0);
    };
    method18(v182);
    const v183: () => void = (): void => {
        closure243(uncurry(2, v176), void 0);
    };
    const v184: () => void = (): void => {
        closure244(uncurry(2, v176), void 0);
    };
    return [v183, v184];
}

export function closure269(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Status
    </>];
}

export function closure270(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure271(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure272(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure273(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure268(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
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
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure269(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure269(void 0, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    const v94: any = v93(v90, v88);
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v106: US9 = patternInput_1[11];
    const v165: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure270(void 0, arg10$0040_2);
    const v166: () => any = (): any => closure249(void 0, void 0);
    const v167: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v168: Mut7 = new Mut7(v165, v166, v167);
    const v169: any = createComponent;
    const v170: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    const v171: any = v169(v170, v168);
    let v178: US9;
    if (v106.tag === US9_Tag.US9_1) {
        const v175: any = children_1;
        v178 = US9_US9_1(v175(v106.fields[0]));
    }
    else {
        v178 = US9_US9_0();
    }
    const v185: string = "10px";
    const v187: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v178.tag === US9_Tag.US9_1) ? v178.fields[0] : ((): any[] => closure271(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US12_US12_1(v171), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], US14_US14_1(v1_1), patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], US6_US6_1(v185), patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v188: () => any[] = (): any[] => closure271(void 0, void 0);
    v187.children = v188;
    const v189: any = createComponent;
    const v190: (arg0: Mut1) => any = (v_1: Mut1): any => closure40(void 0, v_1);
    const v191: any = v189(v190, v187);
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v203_1: US9 = patternInput_2[11];
    const v262: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_7: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure272(void 0, arg10$0040_7);
    const v263: () => any = (): any => closure252(void 0, void 0);
    const v264: Mut7 = new Mut7(v262, v263, v167);
    const v265: any = createComponent;
    const v266: any = v265(v170, v264);
    let v273: US9;
    if (v203_1.tag === US9_Tag.US9_1) {
        const v270: any = children_1;
        v273 = US9_US9_1(v270(v203_1.fields[0]));
    }
    else {
        v273 = US9_US9_0();
    }
    const v281: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v273.tag === US9_Tag.US9_1) ? v273.fields[0] : ((): any[] => closure273(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US12_US12_1(v266), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US14_US14_1(v0_1), patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], US6_US6_1(v185), patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]);
    const v282: () => any[] = (): any[] => closure273(void 0, void 0);
    v281.children = v282;
    const v283: any = createComponent;
    return [v94, v191, v283(v190, v281)];
}

export function method60(v0_1: int32, v1_1: Mut26): boolean {
    return v1_1.l0 < v0_1;
}

export function method61(v0_1_mut: UH2, v1_1_mut: UH2): UH2 {
    method61:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: UH2 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH2_UH2_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method61;
        }
        break;
    }
}

export function method63(v0_1_mut: UH2, v1_1_mut: int32): int32 {
    method63:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method63;
        }
        break;
    }
}

export function method64(v0_1_mut: [int32, any][], v1_1_mut: UH2, v2_mut: int32): int32 {
    method64:
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
            continue method64;
        }
        break;
    }
}

export function method62(v0_1: UH2): [int32, any][] {
    const v2: int32 = method63(v0_1, 0) | 0;
    const v3: [int32, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method64(v3, v0_1, 0) | 0;
    return v3;
}

export function closure279(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure278(v0_1: () => [int32, any], unitVar: void): any[] {
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
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure279(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure279(v0_1, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure277(v0_1: () => [int32, any], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure278(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure276(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure277(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure275(v0_1: () => [int32, any][], unitVar: void): any[] {
    const v1_1: [int32, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut26 = new Mut26(0, UH2_UH2_1());
    while (method60(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH2 = v4.l1;
        const patternInput: [int32, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH2_UH2_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int32, any][] = method62(method61(v4.l1, UH2_UH2_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure276(void 0, v);
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

export function closure274(v0_1: () => [int32, any][], unitVar: void): any[] {
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
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure275(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure275(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return [v87(v88, v83)];
}

export function closure267(v0_1: () => [int32, any][], v1_1: () => void, v2: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v87: US9 = patternInput[11];
    const v148: string = method12("column", "row");
    const v151: string = method12("8px", "0");
    let v159: US9;
    if (v87.tag === US9_Tag.US9_1) {
        const v156: any = children_1;
        v159 = US9_US9_1(v156(v87.fields[0]));
    }
    else {
        v159 = US9_US9_0();
    }
    const v173: any = createObj(method7(US6_US6_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v159.tag === US9_Tag.US9_1) ? v159.fields[0] : ((): any[] => closure268(v1_1, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1(v148), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US6_US6_1(v151), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1("3px"), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("7px"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v174: () => any[] = (): any[] => closure268(v1_1, v2, void 0);
    v173.children = v174;
    const v175: (arg0: any) => any = v75_1;
    const v178: any = createComponent;
    const v180: () => any[] = (): any[] => closure274(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v180), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("status"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v178(v175, v173)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method58(): any {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    const v134: () => [int32, any][] = patternInput[12];
    const v144: (arg0: void, arg1: void, arg2: [int32, any][]) => void = (): (arg0: void, arg1: [int32, any][]) => void => closure262(patternInput[13], void 0);
    const v145: (arg0: any) => any = (v: any): any => closure265(void 0, v);
    const patternInput_1: [() => void, () => void] = method59("profile/tmp/chain_status", v134());
    const v150: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure267(v134, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    const v152: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v150, US15_US15_2());
    const v154: any = createComponent;
    const v155: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v154(v155, v152);
}

export function closure261(unitVar: void, v0_1: Mut1): any {
    return method58();
}

export function closure280(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure284(v0_1: (arg0: [int32, any][]) => void, v1_1: [int32, any][]): void {
    v0_1(v1_1);
}

export function closure283(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: [int32, any][]) => void {
    return (v: [int32, any][]): void => {
        closure284(v0_1, v);
    };
}

export function closure282(v0_1: (arg0: [int32, any][]) => void, unitVar: void): (arg0: void, arg1: [int32, any][]) => void {
    return (): (arg0: [int32, any][]) => void => closure283(v0_1, void 0);
}

export function closure285(unitVar: void, v0_1: any): any {
    return void 0;
}

export function closure288(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Deploy
    </>];
}

export function closure289(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure290(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure291(unitVar: void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US6_US6_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure292(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure287(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
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
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure288(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure288(void 0, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    const v94: any = v93(v90, v88);
    const patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v106: US9 = patternInput_1[11];
    const v165: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure289(void 0, arg10$0040_2);
    const v166: () => any = (): any => closure249(void 0, void 0);
    const v167: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_4);
    const v168: Mut7 = new Mut7(v165, v166, v167);
    const v169: any = createComponent;
    const v170: (arg0: Mut7) => any = (v: Mut7): any => closure47(void 0, v);
    const v171: any = v169(v170, v168);
    let v178: US9;
    if (v106.tag === US9_Tag.US9_1) {
        const v175: any = children_1;
        v178 = US9_US9_1(v175(v106.fields[0]));
    }
    else {
        v178 = US9_US9_0();
    }
    const v185: string = "10px";
    const v187: Mut1 = new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v178.tag === US9_Tag.US9_1) ? v178.fields[0] : ((): any[] => closure290(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], US12_US12_1(v171), patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], US14_US14_1(v1_1), patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], US6_US6_1(v185), patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69]);
    const v188: () => any[] = (): any[] => closure290(void 0, void 0);
    v187.children = v188;
    const v189: any = createComponent;
    const v190: (arg0: Mut1) => any = (v_1: Mut1): any => closure40(void 0, v_1);
    const v191: any = v189(v190, v187);
    const patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v203_1: US9 = patternInput_2[11];
    const v262: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_7: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure291(void 0, arg10$0040_7);
    const v263: () => any = (): any => closure252(void 0, void 0);
    const v264: Mut7 = new Mut7(v262, v263, v167);
    const v265: any = createComponent;
    const v266: any = v265(v170, v264);
    let v273: US9;
    if (v203_1.tag === US9_Tag.US9_1) {
        const v270: any = children_1;
        v273 = US9_US9_1(v270(v203_1.fields[0]));
    }
    else {
        v273 = US9_US9_0();
    }
    const v281: Mut1 = new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v273.tag === US9_Tag.US9_1) ? v273.fields[0] : ((): any[] => closure292(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], US12_US12_1(v266), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], US14_US14_1(v0_1), patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], US6_US6_1(v185), patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69]);
    const v282: () => any[] = (): any[] => closure292(void 0, void 0);
    v281.children = v282;
    const v283: any = createComponent;
    return [v94, v191, v283(v190, v281)];
}

export function closure298(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure297(v0_1: () => [int32, any], unitVar: void): any[] {
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
    const v88: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure298(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v89: () => any[] = (): any[] => closure298(v0_1, void 0);
    v88.children = v89;
    const v90: (arg0: any) => any = v4;
    const v93: any = createComponent;
    return [v93(v90, v88)];
}

export function closure296(v0_1: () => [int32, any], _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v76_1: () => any[] = (): any[] => closure297(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v76_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], US6_US6_1("3px"), _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure295(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v3: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure296(v0_1, arg10$0040);
    const v5: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v3, US15_US15_2());
    const v8: any = createComponent;
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    return [v8(v9, v5)];
}

export function closure294(v0_1: () => [int32, any][], unitVar: void): any[] {
    const v1_1: [int32, any][] = v0_1();
    const v2: int32 = v1_1.length | 0;
    const v4: Mut26 = new Mut26(0, UH2_UH2_1());
    while (method60(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: int32 = ((op_UnaryNegation_Int32(v6) + v2) - 1) | 0;
        const v10: UH2 = v4.l1;
        const patternInput: [int32, any] = v1_1[v9];
        const v13: int32 = (v6 + 1) | 0;
        v4.l0 = (v13 | 0);
        v4.l1 = UH2_UH2_0(patternInput[0], patternInput[1], v10);
    }
    const v18: [int32, any][] = method62(method61(v4.l1, UH2_UH2_1()));
    const v21: any = Index;
    const v22: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure295(void 0, v);
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

export function closure293(v0_1: () => [int32, any][], unitVar: void): any[] {
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
    const v83: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v78.tag === US9_Tag.US9_1) ? v78.fields[0] : ((): any[] => closure294(v0_1, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v84: () => any[] = (): any[] => closure294(v0_1, void 0);
    v83.children = v84;
    const v87: any = createComponent;
    const v88: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return [v87(v88, v83)];
}

export function closure286(v0_1: () => [int32, any][], v1_1: () => void, v2: () => void, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v75_1: any = Stack;
    const patternInput: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = method3();
    const v87: US9 = patternInput[11];
    const v148: string = method12("column", "row");
    const v151: string = method12("8px", "0");
    let v159: US9;
    if (v87.tag === US9_Tag.US9_1) {
        const v156: any = children_1;
        v159 = US9_US9_1(v156(v87.fields[0]));
    }
    else {
        v159 = US9_US9_0();
    }
    const v173: any = createObj(method7(US6_US6_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v159.tag === US9_Tag.US9_1) ? v159.fields[0] : ((): any[] => closure287(v1_1, v2, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US6_US6_1(v148), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], US6_US6_1(v151), patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US6_US6_1("3px"), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US6_US6_1("7px"), patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]));
    const v174: () => any[] = (): any[] => closure287(v1_1, v2, void 0);
    v173.children = v174;
    const v175: (arg0: any) => any = v75_1;
    const v178: any = createComponent;
    const v180: () => any[] = (): any[] => closure293(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v180), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US6_US6_1("deploy"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(v178(v175, v173)), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function method65(): any {
    const v118: any = components_spi.state_context;
    const v121: any = useContext;
    const patternInput: [() => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][], (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void, () => int32, (arg0: int32) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => [US2[], int32, US3, string, string][], (arg0: [US2[], int32, US3, string, string][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, any][], (arg0: [int32, any][]) => void, () => [int32, int32][], (arg0: [int32, int32][]) => void, () => US4, (arg0: US4) => void, () => US5, (arg0: US5) => void] = v121(v118);
    const v132: () => [int32, any][] = patternInput[10];
    const v144: (arg0: void, arg1: void, arg2: [int32, any][]) => void = (): (arg0: void, arg1: [int32, any][]) => void => closure282(patternInput[11], void 0);
    const v145: (arg0: any) => any = (v: any): any => closure285(void 0, v);
    const patternInput_1: [() => void, () => void] = method59("profile/tmp/chain_deploy", v132());
    const v150: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure286(v132, patternInput_1[1], patternInput_1[0], arg10$0040_1);
    const v152: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v150, US15_US15_2());
    const v154: any = createComponent;
    const v155: (arg0: Mut4) => any = (v_1: Mut4): any => closure16(void 0, v_1);
    return v154(v155, v152);
}

export function closure281(unitVar: void, v0_1: Mut1): any {
    return method65();
}

export function closure234(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let patternInput_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v108: US9, v173: US9, v170: any, v178: Mut1, v179: () => any[], v180: any, v181: (arg0: Mut1) => any, patternInput_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6], v197_1: US9, v262: US9, v259: any, v267: Mut1, v268: () => any[], v269: any, v270: (arg0: Mut1) => any;
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
    const v87: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure235(void 0, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v88: () => any[] = (): any[] => closure235(void 0, void 0);
    v87.children = v88;
    const v91: any = createComponent;
    const v92: (arg0: Mut1) => any = (v: Mut1): any => closure236(void 0, v);
    const v96: boolean = (v2 === "") !== true;
    return [v91(v92, v87), v96 ? ((patternInput_1 = method3(), (v108 = patternInput_1[11], (v173 = ((v108.tag === US9_Tag.US9_1) ? ((v170 = children_1, US9_US9_1(v170(v108.fields[0])))) : US9_US9_0()), (v178 = (new Mut1(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US9_US9_1((v173.tag === US9_Tag.US9_1) ? v173.fields[0] : ((): any[] => closure260(void 0, void 0))), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], patternInput_1[68], patternInput_1[69])), (v179 = ((): any[] => closure260(void 0, void 0)), (v178.children = v179, (v180 = createComponent, (v181 = ((v_1: Mut1): any => closure261(void 0, v_1)), v180(v181, v178)))))))))) : (void 0), v96 ? ((patternInput_2 = method3(), (v197_1 = patternInput_2[11], (v262 = ((v197_1.tag === US9_Tag.US9_1) ? ((v259 = children_1, US9_US9_1(v259(v197_1.fields[0])))) : US9_US9_0()), (v267 = (new Mut1(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], US9_US9_1((v262.tag === US9_Tag.US9_1) ? v262.fields[0] : ((): any[] => closure280(void 0, void 0))), patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67], patternInput_2[68], patternInput_2[69])), (v268 = ((): any[] => closure280(void 0, void 0)), (v267.children = v268, (v269 = createComponent, (v270 = ((v_2: Mut1): any => closure281(void 0, v_2)), v269(v270, v267)))))))))) : (void 0)];
}

export function closure233(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
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
    const v87: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v82.tag === US9_Tag.US9_1) ? v82.fields[0] : ((): any[] => closure234(v0_1, v1_1, v2, v3, v4, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v88: () => any[] = (): any[] => closure234(v0_1, v1_1, v2, v3, v4, void 0);
    v87.children = v88;
    const v91: any = createComponent;
    const v92: (arg0: Mut1) => any = (v: Mut1): any => closure111(void 0, v);
    return [v91(v92, v87)];
}

export function closure232(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, _arg: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] {
    const v78: () => any[] = (): any[] => closure233(v0_1, v1_1, v2, v3, v4, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US9_US9_1(v78), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US12_US12_1(<>
        Profile
    </>), _arg[63], _arg[64], _arg[65], _arg[66], _arg[67], _arg[68], _arg[69]];
}

export function closure114(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v7: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure115(void 0, arg10$0040);
    const v9: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v7, US15_US15_2());
    const v12: any = createComponent;
    const v13: (arg0: Mut4) => any = (v: Mut4): any => closure16(void 0, v);
    const v17: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_1: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure45(void 0, arg10$0040_1);
    const v19: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v20: any = createComponent;
    const v24: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_2: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure134(void 0, arg10$0040_2);
    const v26: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v24, US15_US15_2());
    const v27: any = createComponent;
    const v32: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v33: any = createComponent;
    const v37: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_3: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure146(void 0, arg10$0040_3);
    const v39: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v37, US15_US15_0());
    const v40: any = createComponent;
    const v45: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v46: any = createComponent;
    const v50: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_4: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure191(void 0, arg10$0040_4);
    const v52: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v50, US15_US15_0());
    const v53: any = createComponent;
    const v58: Mut4 = new Mut4(US14_US14_0(), US14_US14_0(), v17, US15_US15_2());
    const v59: any = createComponent;
    const v63: (arg0: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]) => [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] = (arg10$0040_5: [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6]): [US6, US6, US6, US7, US6, US6, US6, US6, US6, US6, US8, US9, US6, US6, US8, US10, US6, US6, US6, US11, US8, US6, US6, US6, US6, US6, US6, US12, US6, US6, US6, US12, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US13, US14, US13, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US6, US12, US6, US6, US10, US10, US6, US5, US6] => closure232(v0_1, v1_1, v2, v3, v4, arg10$0040_5);
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
    const v107: Mut1 = new Mut1(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], US9_US9_1((v92.tag === US9_Tag.US9_1) ? v92.fields[0] : ((): any[] => closure114(v0_1, v1_1, v2, v3, v4, void 0))), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], US6_US6_1("flex"), patternInput[19], patternInput[20], US6_US6_1("1"), US6_US6_1("column"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], US6_US6_1("hidden"), US6_US6_1("auto"), patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67], patternInput[68], patternInput[69]);
    const v108: () => any[] = (): any[] => closure114(v0_1, v1_1, v2, v3, v4, void 0);
    v107.children = v108;
    const v111: any = createComponent;
    const v112: (arg0: Mut1) => any = (v_1: Mut1): any => closure111(void 0, v_1);
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

export function closure300(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method66(): any {
    const v0_1: () => any[] = (): any[] => closure300(void 0, void 0);
    method14(v0_1, "#cf1100")(US4_US4_0())(["> db_listener ()"]);
    return void 0;
}

export function closure299(unitVar: void, v0_1: Mut2): any {
    return method66();
}

export function method67(): string {
    return "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
}

export function method68(): string {
    return "http://localhost";
}

export function method69(): int32 {
    return 4001;
}

export function method70(): [US0, string, string, string][] {
    return [[US0_US0_0(), "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M", "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith", "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="], [US0_US0_1(US1_US1_1()), "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ", "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make", "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="], [US0_US0_1(US1_US1_0()), "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI", "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid", "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="]];
}

export function closure301(unitVar: void, unitVar_1: void): any {
    let value_40: any, value_41: any;
    const patternInput: [string, any, string, string, boolean] = method2();
    const v122: boolean = patternInput[4];
    const v118: string = patternInput[0];
    const v123: string = method67();
    const v126: any = createSignal;
    const v127: any[] = v126(v123);
    let v128: () => string;
    const value_1: any = v127[0];
    v128 = (value_1);
    let v129: (arg0: string) => void;
    const value_2: any = v127[1];
    v129 = ((arg_1: string): void => {
        value_2(arg_1);
    });
    const v130: boolean = "" === v118;
    const v133: string = v130 ? method68() : (`http://${v118}-4001.githubpreview.dev`);
    const v134: any = createSignal;
    const v135: any[] = v134(v133);
    let v136: () => string;
    const value_4: any = v135[0];
    v136 = (value_4);
    let v137: (arg0: string) => void;
    const value_5: any = v135[1];
    v137 = ((arg_3: string): void => {
        value_5(arg_3);
    });
    const v139: int32 = (v130 ? method69() : 80) | 0;
    const v140: any = createSignal;
    const v141: any[] = v140(v139);
    let v142: () => int32;
    const value_7: any = v141[0];
    v142 = (value_7);
    let v143: (arg0: int32) => void;
    const value_8: any = v141[1];
    v143 = ((arg_5: int32): void => {
        value_8(arg_5);
    });
    const v144: [US0, string, string, string][] = method70();
    const v145: int32 = v144.length | 0;
    const v146: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][] = fill(new Array(v145), 0, v145, null);
    const v147: Mut3 = new Mut3(0);
    while (method5(v145, v147)) {
        const v149: int32 = v147.l0 | 0;
        const patternInput_1: [US0, string, string, string] = v144[v149];
        const v154: any = createSignal;
        const v155: any[] = v154(patternInput_1[0]);
        let v156: () => US0;
        const value_10: any = v155[0];
        v156 = (value_10);
        let v157: (arg0: US0) => void;
        const value_11: any = v155[1];
        v157 = ((arg_7: US0): void => {
            value_11(arg_7);
        });
        const v158: any = createSignal;
        const v159: any[] = v158(patternInput_1[3]);
        let v160: () => string;
        const value_13: any = v159[0];
        v160 = (value_13);
        let v161: (arg0: string) => void;
        const value_14: any = v159[1];
        v161 = ((arg_9: string): void => {
            value_14(arg_9);
        });
        const v162: any = createSignal;
        const v163: any[] = v162(patternInput_1[1]);
        let v164: () => string;
        const value_16: any = v163[0];
        v164 = (value_16);
        let v165: (arg0: string) => void;
        const value_17: any = v163[1];
        v165 = ((arg_11: string): void => {
            value_17(arg_11);
        });
        const v166: any = createSignal;
        const v167: any[] = v166(patternInput_1[2]);
        let v168: () => string;
        const value_19: any = v167[0];
        v168 = (value_19);
        let v169: (arg0: string) => void;
        const value_20: any = v167[1];
        v169 = ((arg_13: string): void => {
            value_20(arg_13);
        });
        v146[v149] = [v156, v157, v164, v165, v168, v169, v160, v161];
        const v170: int32 = (v149 + 1) | 0;
        v147.l0 = (v170 | 0);
    }
    const v171: any = createSignal;
    const v172: any[] = v171(v146);
    let v173: () => [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][];
    const value_22: any = v172[0];
    v173 = (value_22);
    let v174: (arg0: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]) => void;
    const value_23: any = v172[1];
    v174 = ((arg_15: [() => US0, (arg0: US0) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void, () => string, (arg0: string) => void][]): void => {
        value_23(arg_15);
    });
    const v180: string = v130 ? "ws://localhost" : ((true === v122) ? "ws://localhost" : (`ws://${v118}-4944.githubpreview.dev`));
    const v185: int32 = (v130 ? ((true === v122) ? 14944 : ((false === v122) ? 4944 : 80)) : 80) | 0;
    const v194: string = v130 ? "wss://localhost" : ((true === v122) ? "wss://localhost" : (`ws://${v118}-8765.githubpreview.dev`));
    const v199_1: int32 = (v130 ? ((true === v122) ? 18765 : ((false === v122) ? 8765 : 80)) : 80) | 0;
    const v203_1: [US2[], int32, US3, string, string][] = [[fill(new Array(0), 0, 0, null), v185, US3_US3_1(), v180, "ws"], [fill(new Array(0), 0, 0, null), v199_1, US3_US3_0(), v194, "gun"]];
    const v204_1: any = createSignal;
    const v205_1: any[] = v204_1(v203_1);
    let v206_1: () => [US2[], int32, US3, string, string][];
    const value_25: any = v205_1[0];
    v206_1 = (value_25);
    let v207_1: (arg0: [US2[], int32, US3, string, string][]) => void;
    const value_26: any = v205_1[1];
    v207_1 = ((arg_17: [US2[], int32, US3, string, string][]): void => {
        value_26(arg_17);
    });
    const v211_1: US4 = ("" === patternInput[2]) ? US4_US4_2() : US4_US4_3();
    const v212: any = createSignal;
    const v213: any[] = v212(v211_1);
    let v214: () => US4;
    const value_28: any = v213[0];
    v214 = (value_28);
    let v215: (arg0: US4) => void;
    const value_29: any = v213[1];
    v215 = ((arg_19: US4): void => {
        value_29(arg_19);
    });
    const v216: any = createSignal;
    const v218: any[] = v216(US5_US5_0());
    let v219: () => US5;
    const value_31: any = v218[0];
    v219 = (value_31);
    let v220: (arg0: US5) => void;
    const value_32: any = v218[1];
    v220 = ((arg_21: US5): void => {
        value_32(arg_21);
    });
    const v221: [int32, int32][] = fill(new Array(0), 0, 0, null);
    const v222: any = createSignal;
    const v223: any[] = v222(v221);
    let v224: () => [int32, int32][];
    const value_34: any = v223[0];
    v224 = (value_34);
    let v225: (arg0: [int32, int32][]) => void;
    const value_35: any = v223[1];
    v225 = ((arg_23: [int32, int32][]): void => {
        value_35(arg_23);
    });
    const v226: [int32, any][] = fill(new Array(0), 0, 0, null);
    const v227: any = createSignal;
    const v228: any[] = v227(v226);
    let v229: () => [int32, any][];
    const value_37: any = v228[0];
    v229 = (value_37);
    let v230: (arg0: [int32, any][]) => void;
    const value_38: any = v228[1];
    v230 = ((arg_25: [int32, any][]): void => {
        value_38(arg_25);
    });
    const v231: [int32, any][] = fill(new Array(0), 0, 0, null);
    const v232: any = createSignal;
    const v233: any[] = v232(v231);
    return [v173, v174, v142, v143, v128, v129, v136, v137, v206_1, v207_1, (value_40 = v233[0], value_40), (value_41 = v233[1], (arg_27: [int32, any][]): void => {
        value_41(arg_27);
    }), v229, v230, v224, v225, v214, v215, v219, v220];
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

export const v196 = method0();

export const v197 = "content";

export const v198 = (v: Mut1): any => closure0(void 0, v);

export const v199 = [v197, v198];

export const v200 = "db_listener";

export const v201 = (v: Mut2): any => closure299(void 0, v);

export const v202 = [v200, v201];

export const v203 = "run_id";

export const v204 = [v203, v77];

export const v205 = "new_state_context_any";

export const v206 = (): any => closure301(void 0, void 0);

export const v207 = [v205, v206];

export const v208 = "state_context";

export const v209 = [v208, v196];

export const v210 = [v199, v202, v204, v207, v209, v74];

export const v211 = createObj(v210);

window.components_spi = v211;

v1.l0 = v211;


